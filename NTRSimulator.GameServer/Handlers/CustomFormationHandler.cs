using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;
using System.Collections.Concurrent;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace NTRSimulator.GameServer.Handlers
{
    /// <summary>
    /// 自定义编队。
    /// 原来只实现了 HandleGetCustomFormation，而且返回 `new PBEBLABCGEP()` 空结构 ——
    /// 客户端拿到空编队列表后，点空框就在本地卡死，连请求都不发。
    /// 现在：默认返回两条编队（编队1/编队2），并把 Modify / ModifyName 存下来回显。
    /// </summary>
    public sealed class CustomFormationHandler : CustomFormationHandlerBase
    {
        // 编队持久化：存成 formations.json（Google.Protobuf 的 JsonFormatter，重启不丢）
        private static readonly string StorePath = Path.Combine(AppContext.BaseDirectory, "formations.json");
        private static readonly object StoreLock = new();
        private static bool StoreLoaded;

        private static void StoreLoad()
        {
            if (StoreLoaded) return;
            lock (StoreLock)
            {
                if (StoreLoaded) return;
                StoreLoaded = true;
                try
                {
                    if (!File.Exists(StorePath)) return;
                    string json = File.ReadAllText(StorePath);
                    var doc = System.Text.Json.JsonDocument.Parse(json);
                    foreach (var prop in doc.RootElement.EnumerateObject())
                    {
                        if (!uint.TryParse(prop.Name, out uint id)) continue;
                        var msg = Google.Protobuf.JsonParser.Default.Parse<CLHJOEOIFHP>(prop.Value.GetRawText());
                        Formations[id] = msg;
                    }
                    Console.WriteLine($"[FORMATION] 已从 {StorePath} 读回 {Formations.Count} 个编队");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[FORMATION] 读取失败: {ex.Message}");
                }
            }
        }

        private static void StoreSave()
        {
            lock (StoreLock)
            {
                try
                {
                    // 直接写成 { "1": { ... }, "2": { ... } }，不要套一层字符串
                    var sb = new System.Text.StringBuilder("{\n");
                    bool first = true;
                    foreach (var kv in Formations)
                    {
                        if (!first) sb.Append(",\n");
                        first = false;
                        sb.Append("  \"").Append(kv.Key).Append("\": ");
                        sb.Append(Google.Protobuf.JsonFormatter.Default.Format(kv.Value));
                    }
                    sb.Append("\n}");
                    File.WriteAllText(StorePath, sb.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[FORMATION] 保存失败: {ex.Message}");
                }
            }
        }

        // key = 编队 Id
        private static readonly ConcurrentDictionary<uint, CLHJOEOIFHP> Formations = new();

        // 编队数量：默认 12，可用环境变量 GF2_FORMATION_COUNT 覆盖（便于排查客户端 UI 行为）
        private static uint FormationCount
        {
            get
            {
                string? v = Environment.GetEnvironmentVariable("GF2_FORMATION_COUNT");
                return uint.TryParse(v, out uint n) && n > 0 && n <= 32 ? n : 6;
            }
        }

        // GF2_FORMATION_ID_BASE=1 → Id 从 1 开始；=0 → 从 0 开始
        private static uint FormationIdBase
        {
            get
            {
                string? v = Environment.GetEnvironmentVariable("GF2_FORMATION_ID_BASE");
                return uint.TryParse(v, out uint n) ? n : 1;
            }
        }

        private static void EnsureDefaults()
        {
            StoreLoad();
            if (!Formations.IsEmpty) return;
            uint count = FormationCount, idb = FormationIdBase;
            for (uint i = 0; i < count; i++)
            {
                uint id = idb + i;
                Formations[id] = new CLHJOEOIFHP { Name = "编队" + (i + 1), DCKBFGJJMFG = id };
            }
        }

        /// <summary>取某个编队的队长角色 id（第一个 gunId），给 StageBattle.leader_id 用。</summary>
        /// <summary>取某个编队里所有角色 id（给 StageStart 组装默认队伍用）。</summary>
        public static System.Collections.Generic.List<uint> GetFormationGunIds(uint formationId)
        {
            var result = new System.Collections.Generic.List<uint>();
            if (Formations.TryGetValue(formationId, out var f))
            {
                foreach (var g in f.Guns) result.Add(g.GunId);
            }
            return result;
        }

        /// <summary>
        /// 把一次部署写进编队：按客户端给的顺序（出生点 id 升序/降序由客户端决定），
        /// 用已有编队里同 gunId 的 BattleAiGun 数据（武器/配件/天赋都在里面），
        /// 组出这次战斗的新编队，供 StageBattle.formation_id 引用。
        /// </summary>
        public static void SetFormationGunsFromDeployment(uint formationId, System.Collections.Generic.IList<uint> gunIds)
        {
            StoreLoad();
            // 收集所有编队里已有的 BattleAiGun（按 gunId 索引）
            var pool = new System.Collections.Generic.Dictionary<uint, BattleAiGun>();
            foreach (var kv in Formations)
            {
                foreach (var g in kv.Value.Guns)
                {
                    if (!pool.ContainsKey(g.GunId)) pool[g.GunId] = g;
                }
            }

            var guns = new System.Collections.Generic.List<BattleAiGun>();
            foreach (uint gid in gunIds)
            {
                if (pool.TryGetValue(gid, out BattleAiGun? exist)) guns.Add(exist);
                else guns.Add(new BattleAiGun { GunId = gid });
            }

            if (!Formations.TryGetValue(formationId, out CLHJOEOIFHP? formation))
            {
                formation = new CLHJOEOIFHP { Name = "编队" + formationId, DCKBFGJJMFG = formationId };
            }
            formation.Guns.Clear();
            formation.Guns.AddRange(guns);
            Formations[formationId] = formation;
            StoreSave();
            Console.WriteLine($"[FORMATION] 已把部署写回编队{formationId}：{guns.Count} 人");
        }

        public static uint GetLeaderGunId(uint formationId)
        {
            if (Formations.TryGetValue(formationId, out var f) && f.Guns.Count > 0)
                return f.Guns[0].GunId;
            return 0;
        }

        public override void HandleGetCustomFormation(CS_GetCustomFormation request, Connection connection)
        {
            EnsureDefaults();

            var groups = new PBEBLABCGEP();
            foreach (var kv in Formations.OrderBy(k => k.Key))
            {
                groups.KMPIHKFBAEP.Add(kv.Value);
            }

            connection.Send(new SC_GetCustomFormation
            {
                OGNHICHKFAD = groups,
            });
        }

        public override void HandleCustomFormationModify(CS_CustomFormationModify request, Connection connection)
        {
            var formation = request.FOAHOCCEHMB ?? new CLHJOEOIFHP();
            if (string.IsNullOrEmpty(formation.Name)) formation.Name = "编队" + request.Id;
            if (formation.DCKBFGJJMFG == 0) formation.DCKBFGJJMFG = request.Id;
            Formations[request.Id] = formation;
            StoreSave();

            connection.Send(new SC_CustomFormationModify
            {
                Id = request.Id,
                FOAHOCCEHMB = formation,
            });
        }

        public override void HandleCustomFormationModifyName(CS_CustomFormationModifyName request, Connection connection)
        {
            EnsureDefaults();
            if (Formations.TryGetValue(request.Id, out var formation))
            {
                formation.Name = request.Name;
                StoreSave();
            }
            else
            {
                Formations[request.Id] = new CLHJOEOIFHP { Name = request.Name, DCKBFGJJMFG = request.Id };
            }

            connection.Send(new SC_CustomFormationModifyName
            {
                Id = request.Id,
                Name = request.Name,
            });
        }
    }
}
