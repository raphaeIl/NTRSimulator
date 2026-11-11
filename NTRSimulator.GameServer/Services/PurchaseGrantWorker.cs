using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;
using NTRSimulator.Common.Table;
using NTRSimulator.Database.Entities;
using NTRSimulator.GameServer.Handlers;
using NTRSimulator.GameServer.Services;
using System.IO;

namespace NTRSimulator.GameServer.Services;

/// <summary>
/// 商城购买发货（不依赖客户端请求，后台每秒处理）：
///   pending_purchase.txt（点购买时写入）→ 价格+商品名 → StorePayData 商品id
///   → StoreGoodData.reward → ItemData.icon_path 得到时装 id
///   → 只写这一件 CostumeEntity
///   → 主动推 SC_Index（拥有列表）+ SC_Items（背包）给在线客户端
/// </summary>
public sealed class PurchaseGrantWorker(
    IServiceScopeFactory scopeFactory,
    ConnectionManager connectionManager) : Microsoft.Extensions.Hosting.BackgroundService
{
    private static readonly string PendingPath = Path.Combine(AppContext.BaseDirectory, "pending_purchase.txt");

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                if (File.Exists(PendingPath)) await ProcessAsync();
            }
            catch (Exception ex) { Console.WriteLine($"[SHOP] 处理失败: {ex.Message}"); }

            try { await Task.Delay(1000, stoppingToken); }
            catch (TaskCanceledException) { break; }
        }
    }

    private async Task ProcessAsync()
    {
        string[] lines = File.ReadAllLines(PendingPath);
        File.Delete(PendingPath);
        if (lines.Length == 0) return;

        var targets = connectionManager.Connections.Where(c => c.Account != null).ToArray();
        if (targets.Length == 0) { File.WriteAllLines(PendingPath, lines); return; }

        using var scope = scopeFactory.CreateScope();
        var inventory = scope.ServiceProvider.GetRequiredService<IInventoryService>();
        var tables = scope.ServiceProvider.GetRequiredService<ITableService>();
        var indexHandler = (IndexHandler?)scope.ServiceProvider.GetService(typeof(IndexHandler));
        var storeHandler = (StoreHandler?)scope.ServiceProvider.GetService(typeof(StoreHandler));
        Console.WriteLine($"[SHOP] handler 解析: index={(indexHandler != null)} store={(storeHandler != null)}");

        var payRows = tables.GetTable<StorePayData>()
            .Select(r => (ProductId: r.NDBHJAMGEDF ?? string.Empty, r.Price,
                          Name: r.Name ?? string.Empty, GoodsId: r.MNAIKLPNEIN))
            .ToList();
        var rewards = new Dictionary<uint, string>();
        foreach (var g in tables.GetTable<StoreGoodData>()) rewards[g.Id] = g.Reward ?? string.Empty;

        var validCostumes = new HashSet<uint>();
        foreach (var cd in tables.GetTable<CostumeData>()) validCostumes.Add(cd.Id);
        foreach (var gd in tables.GetTable<GunData>())
            foreach (uint cid in gd.EILBLOLKOCM) validCostumes.Add(cid);

        var costumeByItem = new Dictionary<uint, uint>();
        foreach (var item in tables.GetTable<ItemData>())
            if (uint.TryParse(item.IconPath, out uint cid) && validCostumes.Contains(cid))
                costumeByItem[item.Id] = cid;

        bool grantedAny = false;

        foreach (string line in lines)
        {
            string[] parts = line.Split('\t');
            if (parts.Length < 2) continue;
            if (!long.TryParse(parts[1], out long amountFen)) continue;
            string subject = parts.Length > 2 ? parts[2].Trim() : string.Empty;
            uint yuan = (uint)(amountFen / 100);
            string target = subject.Replace("衣装·", "").Replace("衣装.", "").Trim();

            string productId = parts[0].Trim();

            // ① 用 product_id 精确匹配（最可靠）
            var hit = payRows.Where(r => r.ProductId.Length > 0 &&
                                         string.Equals(r.ProductId, productId, StringComparison.OrdinalIgnoreCase))
                             .ToList();
            // ② 退而用 价格 + 名称
            if (hit.Count == 0)
                hit = payRows.Where(r => r.Price == yuan &&
                                         (target.Length == 0 || r.Name.Contains(target) || target.Contains(r.Name)))
                             .ToList();
            if (hit.Count == 0) hit = payRows.Where(r => r.Price == yuan).Take(1).ToList();
            if (hit.Count == 0) { Console.WriteLine($"[SHOP] 未匹配商品 amount={amountFen} subject={subject}"); continue; }

            var pick = hit[0];
            if (!rewards.TryGetValue(pick.GoodsId, out string? reward)) { Console.WriteLine($"[SHOP] 商品 {pick.GoodsId} 无奖励"); continue; }

            Console.WriteLine($"[SHOP] 购买命中: {pick.Name} ({yuan}元) → 商品 {pick.GoodsId} → 奖励 {reward}");
            try
            {
                string boughtPath = Path.Combine(AppContext.BaseDirectory, "purchased_goods.txt");
                var bought = File.Exists(boughtPath) ? File.ReadAllLines(boughtPath).ToList() : new List<string>();
                if (!bought.Contains(pick.GoodsId.ToString()))
                {
                    bought.Add(pick.GoodsId.ToString());
                    File.WriteAllLines(boughtPath, bought);
                    Console.WriteLine($"[SHOP] 已记录已购商品 id={pick.GoodsId}");
                }
            }
            catch (Exception ex) { Console.WriteLine($"[SHOP] 记录已购失败: {ex.Message}"); }


            foreach (string part in reward.Split([';', ','], StringSplitOptions.RemoveEmptyEntries))
            {
                string[] kv = part.Split(':');
                if (kv.Length < 2) continue;
                if (!uint.TryParse(kv[0].Trim(), out uint itemId)) continue;
                if (!uint.TryParse(kv[1].Trim(), out uint count)) continue;

                foreach (var conn in targets)
                {
                    uint uid = conn.Account!.Uid;
                    if (costumeByItem.TryGetValue(itemId, out uint costumeId))
                    {
                        var owned = inventory.GetPlayerInventory<CostumeEntity>(uid);
                        if (owned.Any(c => c.CostumeId == costumeId))
                        {
                            Console.WriteLine($"[SHOP]   = 时装 {costumeId} 已拥有，跳过");
                            continue;
                        }
                        for (uint i = 0; i < count; i++)
                            inventory.Add<CostumeEntity>(uid, new CostumeEntity { CostumeId = costumeId });
                        Console.WriteLine($"[SHOP]   + 时装 CostumeId={costumeId} x{count}");
                    }
                    else
                    {
                        var items = inventory.GetPlayerInventory<ItemEntity>(uid);
                        var exist = items.FirstOrDefault(i => i.ItemId == itemId);
                        int newCount = (exist?.Count ?? 0) + (int)count;
                        if (exist != null) inventory.Remove<ItemEntity>(uid, exist);
                        inventory.Add<ItemEntity>(uid, new ItemEntity { ItemId = itemId, Count = newCount });
                        Console.WriteLine($"[SHOP]   + 道具 {itemId} x{count}");
                    }
                    grantedAny = true;
                }
            }
        }

        // 主动推"拥有列表"，客户端立刻刷新时装为已拥有
        if (grantedAny)
        {
            foreach (var conn in targets)
            {
                try
                {
                    if (indexHandler != null)
                    {
                        indexHandler.HandleIndex(new CS_Index(), conn);
                        Console.WriteLine("[SHOP] 已推 SC_Index（拥有列表）");
                    }
                    if (storeHandler != null)
                    {
                        storeHandler.HandleStore(new CS_Store(), conn);
                        Console.WriteLine("[SHOP] 已推 SC_Store（商店状态）");
                    }
                }
                catch (Exception ex) { Console.WriteLine($"[SHOP] 推送失败: {ex.Message}"); }
                try
                {
                    if (storeHandler != null)
                    {
                        storeHandler.HandleStore(new CS_Store(), conn);
                        Console.WriteLine("[SHOP] 已推整份商店状态（含已拥有标记）");
                    }
                }
                catch (Exception ex) { Console.WriteLine($"[SHOP] 推商店失败: {ex.Message}"); }
            }
        }

        await Task.CompletedTask;
    }
}
