using System.Net;
using System.Net.Sockets;
using Google.Protobuf;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging.Abstractions;
using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;
using NTRSimulator.Common.Protocol;
using NTRSimulator.Common.Table;
using NTRSimulator.Database.Entities;
using NTRSimulator.GameServer.Services;

int checks = 0;
void Check(bool condition, string name)
{
    if (!condition) throw new Exception("FAILED: " + name);
    checks++;
}
void Reject(Action action, string name)
{
    bool rejected = false;
    try { action(); } catch (InvalidOperationException) { rejected = true; }
    Check(rejected, name);
}

GachaData[] banners =
[
    new() { Id = 1001, Type = 1, GachaStartTimeline = "5:1001:1002" },
    new() { Id = 2001, Type = 3, StartTime = 10, EndTime = 20, GunUpCharacter = "5:1001" },
    new() { Id = 3001, Type = 3, StartTime = 30, EndTime = 50, GunUpCharacter = "5:1002" },
    new() { Id = 4001, Type = 4, StartTime = 30, EndTime = 50, GunUpCharacterVideo = "5:11001" },
    new() { Id = 5001, Type = 3, StartTime = 60, EndTime = 80, GunUpCharacter = "5:1003" },
    new() { Id = 6001, Type = 6, StartTime = 10, EndTime = 20, GunUpCharacter = "5:1001", LIFIKKLKKDD = { 1001, 1002 } },
];
Check(RecruitmentCatalog.Available(banners, 40, false).Select(b => b.Id).Order().SequenceEqual(new uint[] {1001,3001,4001}), "scheduled includes current/permanent only");
Check(RecruitmentCatalog.Available(banners, 40, true).Count == 5, "archive includes past and excludes future");
Check(RecruitmentCatalog.Available(banners.Reverse(), 40, true).Select(b => b.Id).SequenceEqual(RecruitmentCatalog.Available(banners, 40, true).Select(b => b.Id)), "stable order after refresh");
Check(RecruitmentCatalog.RankItems("5:1001:1002,4:1003").SequenceEqual(new uint[] {1001,1002}), "rank parser preserves featured membership");
Check(RecruitmentCatalog.Rewards(banners[3]).SequenceEqual(new uint[] {11001}), "weapon pool uses weapon field");

var tables = new FakeTables(banners);
var inventory = new FakeInventory();
var config = new ConfigurationBuilder().AddInMemoryCollection(new Dictionary<string,string?> { ["Recruitment:IncludePastBanners"] = "true" }).Build();
var service = new RecruitmentService(tables, inventory, config);
using var listener = new TcpListener(IPAddress.Loopback, 0);
listener.Start();
using var receiver = new TcpClient();
receiver.Connect((IPEndPoint)listener.LocalEndpoint);
using var sender = listener.AcceptTcpClient();
receiver.ReceiveTimeout = 3000;
var connection = new Connection(sender, null!, null!, NullLogger.Instance)
{
    Account = new AccountEntity { Uid = 1 },
    ServerTimeOverride = 40,
};
Check(connection.ServerTimeSeconds == 40, "clock override remains in seconds");
var syncHandler = new NTRSimulator.GameServer.Handlers.SyncHandler();
for (int i = 0; i < 2; i++)
{
    syncHandler.HandleSync(new CS_Sync(), connection);
    var syncFrame = PacketFramer.Read(receiver.GetStream())!;
    Check(syncFrame.Packets.Select(p => p.Message).OfType<SC_Sync>().Single().Timestamp == 40,
        "periodic sync preserves seconds across refreshes");
}
connection.ServerTimeOverride = null;
Check(Math.Abs(connection.ServerTimeSeconds - DateTimeOffset.UtcNow.ToUnixTimeSeconds()) <= 1, "default clock is current Unix seconds");
connection.ServerTimeOverride = 40;

SC_GachaAcquirement ReceiveDraw()
{
    var frame = PacketFramer.Read(receiver.GetStream()) ?? throw new Exception("No response frame");
    return frame.Packets.Select(p => p.Message).OfType<SC_GachaAcquirement>().Single();
}
Check(service.GetBannerList(connection).GachaIds.Count == 5, "handler list uses session clock in seconds");
service.Draw(connection, 2001, 10);
var past = ReceiveDraw();
Check(past.GachaId == 2001 && past.GachaTimes == 10 && past.Drops.Count == 10 && past.Drops.All(d => d.ItemId == 1001), "past banner returns its own doll and request ID");
Check(inventory.Guns.Count == 1 && inventory.Guns[0].GunId == 1001, "ten duplicate pulls persist only one doll");
inventory.Guns[0].Level = 17;
service.Draw(connection, 2001, 1);
Check(ReceiveDraw().Drops.Count == 1 && inventory.Guns[0].Level == 17, "single draw does not overwrite existing progression");
service.Draw(connection, 3001, 1);
Check(ReceiveDraw().Drops.Single().ItemId == 1002, "current banner differs from past banner");
service.Draw(connection, 4001, 10);
Check(ReceiveDraw().Drops.All(d => d.ItemId == 11001) && inventory.Weapons.Count == 1, "weapon banner awards weapons without duplicate entities");
service.Select(connection, 6001, 1002);
_ = PacketFramer.Read(receiver.GetStream());
service.Draw(connection, 6001, 1);
Check(ReceiveDraw().Drops.Single().ItemId == 1002, "custom selection applies only to chosen banner");
Reject(() => service.Select(connection, 6001, 9999), "invalid selection rejected");
Reject(() => service.Draw(connection, 5001, 1), "future banner rejected");
Reject(() => service.Draw(connection, 9999, 1), "unknown banner rejected");
Check(inventory.Guns.Count == 2 && inventory.Weapons.Count == 1, "rejected requests leave inventory unchanged");

if (args.Length == 1)
{
    TableService.ResourceDir = args[0];
    var actual = new TableService(NullLogger<TableService>.Instance);
    var all = actual.GetTable<GachaData>();
    var guns = actual.GetTable<GunData>().Select(g => g.Id).ToHashSet();
    var weapons = actual.GetTable<GunWeaponData>().Select(w => w.Id).ToHashSet();
    foreach (var banner in all.Where(b => b.Type is >= 1 and <= 8))
    {
        var rewards = RecruitmentCatalog.Rewards(banner);
        Check(rewards.Length > 0 && rewards.All(id => RecruitmentCatalog.IsWeapon(banner) ? weapons.Contains(id) : guns.Contains(id)), $"CN banner {banner.Id} references real rewards");
    }
    Console.WriteLine($"Validated reward pools for {all.Count} installed CN banners.");
}
Console.WriteLine($"Passed {checks} recruitment checks.");

sealed class FakeTables(GachaData[] banners) : ITableService
{
    public List<T> GetTable<T>(bool bypassCache = false) where T : IMessage<T>, new()
    {
        object data = typeof(T) == typeof(GachaData) ? banners.ToList()
            : typeof(T) == typeof(GunData) ? new List<GunData> { new() { Id=1001 }, new() { Id=1002 }, new() { Id=1003 } }
            : typeof(T) == typeof(GunWeaponData) ? new List<GunWeaponData> { new() { Id=11001 } }
            : throw new NotSupportedException();
        return (List<T>)data;
    }
    public void DumpAllJsonToFile(string? outputDir = null) => throw new NotSupportedException();
    public void EnsureTables() => throw new NotSupportedException();
    public void DownloadTables() => throw new NotSupportedException();
    public void ClearCache() { }
}
sealed class FakeInventory : IInventoryService
{
    public List<GunEntity> Guns { get; } = [];
    public List<WeaponEntity> Weapons { get; } = [];
    public T[] GetPlayerInventory<T>(uint uid) where T : class => typeof(T) == typeof(GunEntity) ? Guns.Cast<T>().ToArray() : Weapons.Cast<T>().ToArray();
    public void Add<T>(uint uid, T item) where T : class
    {
        if (item is GunEntity gun) Guns.Add(gun);
        else if (item is WeaponEntity weapon) { weapon.Id=(uint)Weapons.Count+1; Weapons.Add(weapon); }
        else throw new NotSupportedException();
    }
    public bool Remove<T>(uint uid, T item) where T : class => throw new NotSupportedException();
    public void AddAll<T>(uint uid) where T : class => throw new NotSupportedException();
}
