using NTRSimulator.Command;
using NTRSimulator.Common.Proto;
using NTRSimulator.Database.Entities;
using NTRSimulator.GameServer.Extensions;
using NTRSimulator.GameServer.Services;
using ProtoIndex = NTRSimulator.Common.Proto.Index;

namespace NTRSimulator.GameServer.Commands;

[Command("inventory", "Manage player inventory", "inventory addall [type]", CommandSource.Client)]
public sealed class InventoryCommand(IInventoryService inventoryService) : ICommand
{
    private const int ItemsPerResponse = 100;
    private const int ResponseSendDelayMs = 100;

    private enum InventoryType
    {
        Gun,
        Weapon,
        WeaponMod,
        WeaponSkin,
        WeaponModSkin,
        Item,
        Costume,
        CostumePart,
        Background,
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
        ["costumepart"] = InventoryType.CostumePart,
        ["background"] = InventoryType.Background,
        ["avgduo"] = InventoryType.AvgDuo,
    };

    [Argument("addall", "Add all entries for one or all inventory types", pattern: "true", flags: ArgumentFlags.Optional | ArgumentFlags.IgnoreCase)]
    public bool AddAll { get; set; }

    [Argument("type", "Optional inventory type", pattern: "gun|char|character|weapon|weaponmod|weaponskin|weaponmodskin|item|characterskin|costume|costumepart|background|avgduo", flags: ArgumentFlags.Optional | ArgumentFlags.IgnoreCase)]
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
                ctx.Reply($"Unknown type '{requestedType}'. Valid types: gun|char|character|weapon|weaponmod|weaponskin|weaponmodskin|item|characterskin|costume|costumepart|background|avgduo");
                return;
            }

            inventoryType = resolvedType;
        }

        if (requestedType is null)
        {
            AddAllTypes(accountUid, ctx);
            ctx.Reply("Added all inventory types.");
        }
        else
        {
            AddSingleType(accountUid, inventoryType!.Value, ctx);
        }

        ctx.Reply("[IMPORTANT] Please restart the client for the changes to take effect.");
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
        InventoryType[] types = Enum.GetValues<InventoryType>().Where(t => t != InventoryType.Item).ToArray();

        // TODO: if all items are included when adding all inventory types, it can cause the whole game to freeze, probably because too much data are being send, spliting/delaying them seems to cause problem as well
        ctx.Reply($"Due to the shear size of the All Items Packet, please run \"/inventory addall item\" seperately if you need");

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
                inventoryService.AddAll<GunEntity>(accountUid);
                break;
            case InventoryType.Weapon:
                inventoryService.AddAll<WeaponEntity>(accountUid);
                break;
            case InventoryType.WeaponMod:
                inventoryService.AddAll<WeaponModEntity>(accountUid);
                break;
            case InventoryType.WeaponSkin:
                inventoryService.AddAll<WeaponSkinEntity>(accountUid);
                break;
            case InventoryType.WeaponModSkin:
                inventoryService.AddAll<WeaponModSkinEntity>(accountUid);
                break;
            case InventoryType.Item:
                inventoryService.AddAll<ItemEntity>(accountUid);
                break;
            case InventoryType.Costume:
                inventoryService.AddAll<CostumeEntity>(accountUid);
                break;
            case InventoryType.CostumePart:
                inventoryService.AddAll<CostumePartEntity>(accountUid);
                break;
            case InventoryType.Background:
                inventoryService.AddAll<BackgroundEntity>(accountUid);
                break;
            case InventoryType.AvgDuo:
                inventoryService.AddAll<AvgDuoEntity>(accountUid);
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
                case InventoryType.CostumePart:
                case InventoryType.Background:
                    ctx.Connection.SendAutoEncrypted(CreateIndexResponse(accountUid, type));
                    Thread.Sleep(ResponseSendDelayMs);
                    ctx.Reply($"{type} index successfully updated!");
                    break;
                case InventoryType.Item:
                    foreach (SC_Items response in CreateItemResponses(accountUid))
                    {
                        ctx.Connection.SendAutoEncrypted(response);
                        Thread.Sleep(ResponseSendDelayMs);
                    }
                    ctx.Reply("Items successfully updated!");
                    ctx.Connection.SendAutoEncrypted(CreateIndexResponse(accountUid, type));
                    Thread.Sleep(ResponseSendDelayMs);
                    ctx.Reply("Item index successfully updated!");
                    break;
                case InventoryType.AvgDuo:
                    ctx.Reply("AvgDuo successfully updated!");
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, "Unsupported inventory type.");
            }
        }
    }

    private SC_Guns CreateGunResponse(uint accountUid)
    {
        SC_Guns response = new();
        foreach (GunEntity gun in inventoryService.GetPlayerInventory<GunEntity>(accountUid))
            response.Guns.Add(gun.ToProtoGunCharacter());

        return response;
    }

    private SC_GunWeapons CreateWeaponResponse(uint accountUid)
    {
        SC_GunWeapons response = new();
        foreach (WeaponEntity weapon in inventoryService.GetPlayerInventory<WeaponEntity>(accountUid))
        {
            response.Weapons.Add(weapon.ToProtoWeapon());

            if (weapon.GunId != 0)
                response.FEDCFGGDNBN[weapon.Id] = weapon.GunId;
        }

        return response;
    }

    private IEnumerable<SC_Items> CreateItemResponses(uint accountUid)
    {
        ItemEntity[] items = inventoryService.GetPlayerInventory<ItemEntity>(accountUid);
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

    private SC_Index CreateIndexResponse(uint accountUid, InventoryType type)
    {
        uint indexType = type switch
        {
            InventoryType.Costume => 13,
            InventoryType.CostumePart => 14,
            InventoryType.Background => 30,
            InventoryType.WeaponMod => 21,
            InventoryType.WeaponSkin => 60,
            InventoryType.WeaponModSkin => 61,
            InventoryType.Item => 162,
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, "Inventory type has no index slot."),
        };

        ProtoIndex index = new ProtoIndex { Type = indexType };

        switch (type)
        {
            case InventoryType.Costume:
                foreach (CostumeEntity costume in inventoryService.GetPlayerInventory<CostumeEntity>(accountUid))
                    index.Details[costume.CostumeId] = true;
                break;
            case InventoryType.CostumePart:
                foreach (CostumePartEntity costumePart in inventoryService.GetPlayerInventory<CostumePartEntity>(accountUid))
                    index.Details[costumePart.CostumePartId] = false;
                break;
            case InventoryType.Background:
                foreach (BackgroundEntity background in inventoryService.GetPlayerInventory<BackgroundEntity>(accountUid))
                    index.Details[background.BackgroundId] = true;
                break;
            case InventoryType.WeaponMod:
                foreach (WeaponModEntity weaponMod in inventoryService.GetPlayerInventory<WeaponModEntity>(accountUid))
                    index.Details[weaponMod.WeaponModId] = true;
                break;
            case InventoryType.WeaponSkin:
                foreach (WeaponSkinEntity weaponSkin in inventoryService.GetPlayerInventory<WeaponSkinEntity>(accountUid))
                    index.Details[weaponSkin.WeaponSkinId] = true;
                break;
            case InventoryType.WeaponModSkin:
                foreach (WeaponModSkinEntity weaponModSkin in inventoryService.GetPlayerInventory<WeaponModSkinEntity>(accountUid))
                    index.Details[weaponModSkin.WeaponModSkinId] = true;
                break;
            case InventoryType.Item:
                foreach (ItemEntity item in inventoryService.GetPlayerInventory<ItemEntity>(accountUid))
                {
                    if (item.Type != 162)
                        continue;

                    index.Details[item.ItemId] = true;
                }
                break;
        }

        return new SC_Index
        {
            Indices =
            {
                { indexType, index },
            },
        };
    }
}
