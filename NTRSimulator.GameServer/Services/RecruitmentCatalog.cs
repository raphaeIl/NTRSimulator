using System.Globalization;
using NTRSimulator.Common.Table;

namespace NTRSimulator.GameServer.Services;

/// <summary>Banner membership and featured rewards come from the installed CN tables.</summary>
public static class RecruitmentCatalog
{
    public static IReadOnlyList<GachaData> Available(IEnumerable<GachaData> rows, long unixSeconds, bool includePast)
        => rows.Where(row => row.Id != 0 && row.Type is >= 1 and <= 9
                && (row.StartTime == 0 || row.StartTime <= unixSeconds)
                && (includePast || row.EndTime == 0 || row.EndTime >= unixSeconds))
            .OrderByDescending(row => row.StartTime)
            .ThenBy(row => row.Sequence)
            .ThenBy(row => row.Id)
            .ToArray();

    public static uint[] RankItems(string encoded, uint rank = 5)
    {
        var items = new List<uint>();
        foreach (string group in encoded.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))
        {
            string[] parts = group.Split(':', StringSplitOptions.TrimEntries);
            if (parts.Length < 2 || !uint.TryParse(parts[0], NumberStyles.None, CultureInfo.InvariantCulture, out uint groupRank))
                throw new InvalidDataException("Invalid recruitment rank group.");
            foreach (string part in parts.Skip(1))
            {
                if (!uint.TryParse(part, NumberStyles.None, CultureInfo.InvariantCulture, out uint id) || id == 0)
                    throw new InvalidDataException("Invalid recruitment item ID.");
                if (groupRank == rank) items.Add(id);
            }
        }
        return items.Distinct().ToArray();
    }

    public static bool IsWeapon(GachaData banner) => banner.Type is 4 or 7;

    public static uint[] Rewards(GachaData banner)
    {
        // These generated property names are partly deobfuscated. In CN 4.0:
        // fields 22/23 are full doll/weapon pools; fields 27/29 are featured pools.
        string featured = IsWeapon(banner) ? banner.GunUpCharacterVideo : banner.GunUpCharacter;
        uint[] rewards = RankItems(featured);
        if (rewards.Length > 0) return rewards;
        return RankItems(IsWeapon(banner) ? banner.GunUpRate : banner.GachaStartTimeline);
    }

    public static uint[] SelectableRewards(GachaData banner)
        => banner.Type is 5 or 6 or 7 && banner.LIFIKKLKKDD.Count > 0
            ? banner.LIFIKKLKKDD.Distinct().ToArray()
            : Rewards(banner);
}
