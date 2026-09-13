using Google.Protobuf;
using Microsoft.Extensions.Configuration;
using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;
using NTRSimulator.Common.Table;
using NTRSimulator.Database.Entities;
using NTRSimulator.GameServer.Extensions;

namespace NTRSimulator.GameServer.Services;

public interface IRecruitmentService : IGameService
{
    SC_GachaList GetBannerList(Connection connection);
    void Draw(Connection connection, uint bannerId, uint count);
    void Select(Connection connection, uint bannerId, uint itemId);
}

/// <summary>Free emulator draws for testing featured dolls and weapons, not live-server odds.</summary>
public sealed class RecruitmentService(ITableService tables, IInventoryService inventory, IConfiguration configuration)
    : IRecruitmentService
{
    private IReadOnlyList<GachaData> Available(Connection connection)
    {
        bool includePast = bool.TryParse(configuration["Recruitment:IncludePastBanners"], out bool value) && value;
        long seconds = connection.ServerTimeSeconds;
        return RecruitmentCatalog.Available(tables.GetTable<GachaData>(), seconds, includePast);
    }

    public SC_GachaList GetBannerList(Connection connection)
    {
        var response = new SC_GachaList();
        response.GachaIds.AddRange(Available(connection).Select(row => row.Id));
        return response;
    }

    public void Select(Connection connection, uint bannerId, uint itemId)
    {
        if (connection.Account is null) return;
        GachaData banner = Available(connection).FirstOrDefault(row => row.Id == bannerId)
            ?? throw new InvalidOperationException("Recruitment banner is unavailable.");
        if (!RecruitmentCatalog.SelectableRewards(banner).Contains(itemId))
            throw new InvalidOperationException("This reward is not selectable on this banner.");
        connection.RecruitmentSelections[bannerId] = itemId;
        connection.Send(new SC_GachaSelectUp { GachaId = bannerId, OAIDHJMAEMM = itemId });
    }

    public void Draw(Connection connection, uint bannerId, uint count)
    {
        if (connection.Account is null) return;
        if (count is not (1 or 10)) throw new ArgumentOutOfRangeException(nameof(count));
        GachaData banner = Available(connection).FirstOrDefault(row => row.Id == bannerId)
            ?? throw new InvalidOperationException("Recruitment banner is unavailable.");
        if (banner.Type == 9) throw new InvalidOperationException("Outfit procurement uses its separate handler.");

        uint[] rewards = RecruitmentCatalog.Rewards(banner);
        if (connection.RecruitmentSelections.TryGetValue(bannerId, out uint selected)
            && RecruitmentCatalog.SelectableRewards(banner).Contains(selected))
            rewards = [selected];
        bool weaponBanner = RecruitmentCatalog.IsWeapon(banner);
        var guns = tables.GetTable<GunData>().ToDictionary(row => row.Id);
        var weapons = tables.GetTable<GunWeaponData>().Select(row => row.Id).ToHashSet();
        // Validate the complete pool before touching persistent inventory.
        if (rewards.Length == 0 || rewards.Any(id => weaponBanner ? !weapons.Contains(id) : !guns.ContainsKey(id)))
            throw new InvalidDataException("Banner rewards do not match the installed game tables.");

        uint uid = connection.Account.Uid;
        var ownedGuns = inventory.GetPlayerInventory<GunEntity>(uid).ToDictionary(gun => gun.GunId);
        var ownedWeapons = inventory.GetPlayerInventory<WeaponEntity>(uid).GroupBy(weapon => weapon.WeaponId)
            .ToDictionary(group => group.Key, group => group.First());
        var updates = new List<IMessage>();
        var response = new SC_GachaAcquirement
        {
            GachaId = bannerId,
            GachaTimes = count,
            Gacha = new GachaRecord(),
            GachaDetails = new GachaDetails(),
        };
        for (uint i = 0; i < count; i++)
        {
            uint itemId = rewards[Random.Shared.Next(rewards.Length)];
            ulong relate;
            if (weaponBanner)
            {
                if (!ownedWeapons.TryGetValue(itemId, out WeaponEntity? weapon))
                {
                    weapon = GunService.CreateDefaultWeapon(itemId, 0);
                    inventory.Add(uid, weapon);
                    ownedWeapons[itemId] = weapon;
                    updates.Add(new SC_NewGunWeapon { Weapon = weapon.ToProtoWeapon() });
                }
                relate = weapon.Id;
            }
            else
            {
                if (!ownedGuns.TryGetValue(itemId, out GunEntity? gun))
                {
                    gun = GunService.CreateDefault(guns[itemId], level: 60);
                    inventory.Add(uid, gun);
                    ownedGuns[itemId] = gun;
                    WeaponEntity? defaultWeapon = inventory.GetPlayerInventory<WeaponEntity>(uid).FirstOrDefault(w => w.Id == gun.WeaponId);
                    if (defaultWeapon is not null)
                        updates.Add(new SC_NewGunWeapon { Weapon = defaultWeapon.ToProtoWeapon() });
                    updates.Add(new SC_NewGun { Gun = gun.ToProtoGunCharacter() });
                    response.PMJGFLLPIHO.Add(itemId);
                }
                relate = gun.GunId;
            }
            response.Drops.Add(new UserDropCache
            {
                ItemId = itemId, ItemNum = 1, Relate = relate, DropUp = true,
                CIPFHAHNMBM = FMMNODBGEJC.Gacha,
            });
        }
        foreach (GachaData row in Available(connection))
            response.Guarantee[row.Id] = row.SsrTimes;
        updates.Add(response);
        connection.SendAutoEncrypted(updates.ToArray());
    }
}
