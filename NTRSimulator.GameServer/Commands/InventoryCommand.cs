using NTRSimulator.Command;
using NTRSimulator.Common.Proto;
using NTRSimulator.Database.Entities;
using NTRSimulator.GameServer.Extensions;
using NTRSimulator.GameServer.Services;

namespace NTRSimulator.GameServer.Commands;

[Command("inventory", "Manage player inventory", "inventory addall [type]", CommandSource.Client)]
public sealed class InventoryCommand(IInventoryService inventoryService) : ICommand
{
    private const int ItemsPerResponse = 200;
    private const int ResponseSendDelayMs = 50;

    private enum InventoryType
    {
        Gun,
        Weapon,
        WeaponMod,
        WeaponSkin,
        WeaponModSkin,
        Item,
        Costume,
        AvgDuo,
    }

    private static readonly Dictionary<string, InventoryType> TypeAliases = new(StringComparer.OrdinalIgnoreCase)
    {
        ["gun"] = InventoryType.Gun,
        ["char"] = InventoryType.Gun,
        ["character"] = InventoryType.Gun,
        ["weapon"] = InventoryType.Weapon,
        ["weaponmod"] = InventoryType.WeaponMod,
        ["weaponskin"] = InventoryType.WeaponSkin,
        ["weaponmodskin"] = InventoryType.WeaponModSkin,
        ["item"] = InventoryType.Item,
        ["characterskin"] = InventoryType.Costume,
        ["costume"] = InventoryType.Costume,
        ["avgduo"] = InventoryType.AvgDuo,
    };

    [Argument("addall", "Add all entries for one or all inventory types", pattern: "true", flags: ArgumentFlags.Optional | ArgumentFlags.IgnoreCase)]
    public bool AddAll { get; set; }

    [Argument("type", "Optional inventory type", pattern: "gun|char|character|weapon|weaponmod|weaponskin|weaponmodskin|item|characterskin|costume|avgduo", flags: ArgumentFlags.Optional | ArgumentFlags.IgnoreCase)]
    public string? Type { get; set; }

    public void Execute(CommandContext ctx)
    {
        if (ctx.Connection?.Account is null)
        {
            ctx.Reply("You must be logged in to use this command.");
            return;
        }

        uint accountUid = ctx.Connection.Account.Uid;

        if (!AddAll && !ctx.RawArgs.ContainsKey("addall"))
        {
            ctx.Reply("Usage: /inventory addall [type]");
            return;
        }

        var requestedType = ResolveRequestedType(ctx.RawArgs, Type);
        InventoryType? inventoryType = null;
        if (!string.IsNullOrEmpty(requestedType))
        {
            if (!TypeAliases.TryGetValue(requestedType, out var resolvedType))
            {
                ctx.Reply($"Unknown type '{requestedType}'. Valid types: gun|char|character|weapon|weaponmod|weaponskin|weaponmodskin|item|characterskin|costume|avgduo");
                return;
            }

            inventoryType = resolvedType;
        }

        if (requestedType is null)
        {
            AddAllTypes(accountUid, ctx);
            ctx.Reply("Added all inventory types.");
            return;
        }

        AddSingleType(accountUid, inventoryType!.Value, ctx);
    }

    private static string? ResolveRequestedType(IReadOnlyDictionary<string, string> rawArgs, string? typedTypeArg)
    {
        if (!string.IsNullOrWhiteSpace(typedTypeArg))
            return typedTypeArg;

        foreach (var (key, value) in rawArgs)
        {
            if (key.Equals("addall", StringComparison.OrdinalIgnoreCase))
                continue;
            if (key.Equals("type", StringComparison.OrdinalIgnoreCase))
                continue;

            if (string.Equals(value, "true", StringComparison.OrdinalIgnoreCase))
                return key;

            return value;
        }

        return null;
    }

    private void AddAllTypes(uint accountUid, CommandContext ctx)
    {
        InventoryType[] types = Enum.GetValues<InventoryType>();

        foreach (InventoryType type in types)
        {
            AddInventoryType(accountUid, type);
            ctx.Reply($"Added all {type.ToString().ToLowerInvariant()} entries.");
        }

        SendInventoryResponses(ctx, types);
    }

    private void AddSingleType(uint accountUid, InventoryType type, CommandContext ctx)
    {
        AddInventoryType(accountUid, type);
        SendInventoryResponses(ctx, [type]);

        ctx.Reply($"Added all {type.ToString().ToLowerInvariant()} entries.");
    }

    private void AddInventoryType(uint accountUid, InventoryType type)
    {
        switch (type)
        {
            case InventoryType.Gun:
                inventoryService.AddAll<Gun>(accountUid);
                break;
            case InventoryType.Weapon:
                inventoryService.AddAll<Weapon>(accountUid);
                break;
            case InventoryType.WeaponMod:
                inventoryService.AddAll<WeaponMod>(accountUid);
                break;
            case InventoryType.WeaponSkin:
                inventoryService.AddAll<WeaponSkin>(accountUid);
                break;
            case InventoryType.WeaponModSkin:
                inventoryService.AddAll<WeaponModSkin>(accountUid);
                break;
            case InventoryType.Item:
                inventoryService.AddAll<Item>(accountUid);
                break;
            case InventoryType.Costume:
                inventoryService.AddAll<Costume>(accountUid);
                break;
            case InventoryType.AvgDuo:
                inventoryService.AddAll<AvgDuo>(accountUid);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(type), type, "Unsupported inventory type.");
        }
    }

    private void SendInventoryResponses(
        CommandContext ctx,
        IEnumerable<InventoryType> types)
    {
        if (ctx.Connection?.Account is null)
            return;

        uint accountUid = ctx.Connection.Account.Uid;
        bool needsIndexResponse = false;

        foreach (InventoryType type in types.Distinct())
        {
            switch (type)
            {
                case InventoryType.Gun:
                    ctx.Connection.SendAutoEncrypted(CreateGunResponse(accountUid));
                    Thread.Sleep(ResponseSendDelayMs);
                    ctx.Reply("Guns successfully updated!");
                    break;
                case InventoryType.Weapon:
                    ctx.Connection.SendAutoEncrypted(CreateWeaponResponse(accountUid));
                    Thread.Sleep(ResponseSendDelayMs);
                    ctx.Reply("Weapons successfully updated!");
                    break;
                case InventoryType.WeaponMod:
                case InventoryType.WeaponSkin:
                case InventoryType.WeaponModSkin:
                case InventoryType.Costume:
                case InventoryType.AvgDuo:
                    needsIndexResponse = true;
                    break;
                case InventoryType.Item:
                    foreach (SC_Items response in CreateItemResponses(accountUid))
                    {
                        ctx.Connection.SendAutoEncrypted(response);
                        Thread.Sleep(ResponseSendDelayMs);
                    }
                    ctx.Reply("Items successfully updated!");
                    needsIndexResponse = true;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, "Unsupported inventory type.");
            }
        }

        if (needsIndexResponse)
        {
            ctx.Connection.SendAutoEncrypted(CreateIndexResponse(accountUid));
            Thread.Sleep(ResponseSendDelayMs);
            ctx.Reply("Index successfully updated!");
        }
    }

    private SC_Guns CreateGunResponse(uint accountUid)
    {
        SC_Guns response = new();
        foreach (Gun gun in inventoryService.GetPlayerInventory<Gun>(accountUid))
            response.Field1.Add(gun.ToProtoGunCharacter());

        return response;
    }

    private SC_GunWeapons CreateWeaponResponse(uint accountUid)
    {
        SC_GunWeapons response = new();
        foreach (Weapon weapon in inventoryService.GetPlayerInventory<Weapon>(accountUid))
        {
            response.GunWeapons.Add(weapon.ToProtoWeapon());

            if (weapon.GunId != 0)
                response.Belong[weapon.Id] = weapon.GunId;
        }

        return response;
    }

    private IEnumerable<SC_Items> CreateItemResponses(uint accountUid)
    {
        Item[] items = inventoryService.GetPlayerInventory<Item>(accountUid);
        if (items.Length == 0)
        {
            yield return new SC_Items();
            yield break;
        }

        for (int offset = 0; offset < items.Length; offset += ItemsPerResponse)
        {
            SC_Items response = new();
            int end = Math.Min(offset + ItemsPerResponse, items.Length);

            for (int i = offset; i < end; i++)
                response.Items[items[i].ItemId] = items[i].Count;

            yield return response;
        }
    }

    private SC_Index CreateIndexResponse(uint accountUid)
    {
        SC_Index response = new SC_Index
        {
            Field1 =
            {
                {
                    10u,
                    new SC_Index_F1ValueType
                    {
                        Field1 = 10,
                        Field2 =
                        {
                            { 1001u, false },
                            { 1008u, false },
                            { 1017u, false },
                            { 1024u, false },
                        },
                    }
                },
                {
                    12u,
                    new SC_Index_F1ValueType
                    {
                        Field1 = 12,
                        Field2 =
                        {
                            { 21000u, true },
                            { 21001u, true },
                            { 21004u, true },
                            { 21009u, true },
                            { 21038u, false },
                            { 21999u, true },
                        },
                    }
                },
                {
                    13u,
                    new SC_Index_F1ValueType
                    {
                        Field1 = 13,
                        Field2 = { },
                    }
                },
                {
                    14u,
                    new SC_Index_F1ValueType
                    {
                        Field1 = 14,
                        Field2 = { },
                    }
                },
                {
                    20u,
                    new SC_Index_F1ValueType
                    {
                        Field1 = 20,
                        Field2 =
                        {
                            { 11009u, false },
                            { 11010u, false },
                            { 11022u, false },
                            { 11023u, false },
                            { 11039u, false },
                        },
                    }
                },
                {
                    21u,
                    new SC_Index_F1ValueType
                    {
                        Field1 = 21,
                        Field2 = { },
                    }
                },
                {
                    36u,
                    new SC_Index_F1ValueType
                    {
                        Field1 = 36,
                        Field2 =
                        {
                            { 22001u, true },
                            { 22002u, false },
                            { 22019u, false },
                            { 22020u, false },
                            { 22022u, false },
                            { 22023u, false },
                        },
                    }
                },
                {
                    37u,
                    new SC_Index_F1ValueType
                    {
                        Field1 = 37,
                        Field2 =
                        {
                            { 23001u, true },
                            { 23012u, true },
                            { 23014u, true },
                            { 23015u, true },
                            { 23019u, true },
                        },
                    }
                },
                {
                    39u,
                    new SC_Index_F1ValueType
                    {
                        Field1 = 39,
                        Field2 =
                        {
                            { 24001u, true },
                        },
                    }
                },
                {
                    40u,
                    new SC_Index_F1ValueType
                    {
                        Field1 = 40,
                        Field2 =
                        {
                            { 25001u, true },
                        },
                    }
                },
                {
                    60u,
                    new SC_Index_F1ValueType
                    {
                        Field1 = 60,
                        Field2 = { },
                    }
                },
                {
                    61u,
                    new SC_Index_F1ValueType
                    {
                        Field1 = 61,
                        Field2 = { },
                    }
                },
                {
                    133u,
                    new SC_Index_F1ValueType
                    {
                        Field1 = 133,
                        Field2 =
                        {
                            { 1335001u, false },
                            { 1335101u, false },
                        },
                    }
                },
                {
                    162u,
                    new SC_Index_F1ValueType
                    {
                        Field1 = 162,
                        Field2 = { },
                    }
                },
            },
            Field2 =
            {
                {
                    36u,
                    new SC_Index_F2ValueType
                    {
                        Field1 =
                        {
                            { 22001u, 1703592104 },
                            { 22002u, 1728668611 },
                            { 22019u, 1737270231 },
                            { 22020u, 1736063989 },
                            { 22022u, 1737956678 },
                            { 22023u, 1731480838 },
                        },
                    }
                },
                {
                    37u,
                    new SC_Index_F2ValueType
                    {
                        Field1 =
                        {
                            { 23001u, 1703592104 },
                            { 23012u, 1703900704 },
                            { 23014u, 1703900704 },
                            { 23015u, 1704824955 },
                            { 23019u, 1703901382 },
                        },
                    }
                },
            },
        };

        foreach (Costume costume in inventoryService.GetPlayerInventory<Costume>(accountUid))
            response.Field1[13].Field2[costume.CostumeId] = true;

        foreach (WeaponMod weaponMod in inventoryService.GetPlayerInventory<WeaponMod>(accountUid))
            response.Field1[21].Field2[weaponMod.WeaponModId] = true;

        foreach (WeaponSkin weaponSkin in inventoryService.GetPlayerInventory<WeaponSkin>(accountUid))
            response.Field1[60].Field2[weaponSkin.WeaponSkinId] = true;

        foreach (WeaponModSkin weaponModSkin in inventoryService.GetPlayerInventory<WeaponModSkin>(accountUid))
            response.Field1[61].Field2[weaponModSkin.WeaponModSkinId] = true;

        foreach (Item item in inventoryService.GetPlayerInventory<Item>(accountUid))
        {
            if (item.Type != 162)
            {
                continue;
            }

            response.Field1[162u].Field2[item.ItemId] = true;
        }

        return response;
    }
}
