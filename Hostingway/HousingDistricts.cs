using Lumina.Excel.Sheets;

namespace Hostingway;

public static class HousingDistricts
{
    public static unsafe string GetFullLocationString(uint territoryId)
    {
        var housing = FFXIVClientStructs.FFXIV.Client.Game.HousingManager.Instance();

        if (housing != null && housing->GetCurrentHouseId().Id != 0)
        {
            ulong houseId = housing->GetCurrentHouseId().Id;

            uint internalId = (uint)((houseId >> 32) & 0xFFFF);
            int ward = (int)((houseId >> 16) & 0xFFFF) + 1;
            int plot = (int)(houseId & 0xFFFF) + 1;

            string district = GetDistrictNameFromInternalId(internalId);
            return $"{district}, Ward {ward}, Plot {plot}";
        }

        return GetTerritoryName(territoryId);
    }

    private static string GetDistrictNameFromInternalId(uint id)
    {
        return id switch
        {
            282 or 283 or 284 or 384 or 608 or 339 => "The Mist",
            342 or 343 or 344 or 385 or 609 or 340 => "The Lavender Beds",
            345 or 346 or 347 or 1251 or 386 or 610 or 341 => "The Goblet",
            649 or 650 or 651 or 652 or 655 or 644 => "Shirogane",
            980 or 981 or 982 or 983 or 999 or 984 => "Empyreum",
            _ => $"Unknown ({id})"
        };
    }

    public static unsafe string GetTerritoryName(uint territoryId)
    {
        var row = Plugin.DataManager.GetExcelSheet<TerritoryType>()?.GetRow(territoryId);
        if (row.HasValue)
        {
            var pRow = Plugin.DataManager.GetExcelSheet<PlaceName>()?.GetRow(row.Value.PlaceName.RowId);
            return pRow?.Name.ExtractText() ?? $"Zone {territoryId}";
        }
        return $"Zone {territoryId}";
    }
}