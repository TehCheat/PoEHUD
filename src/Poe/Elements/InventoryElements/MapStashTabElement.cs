using System.Collections.Generic;

namespace PoeHUD.Poe.Elements
{
    public class MapSubInventoryInfo
    {
        public int Tier;
        public int Count;
        public string MapName;
        public override string ToString()
        {
            return "Tier:" + Tier + " Count:" + Count + " MapName:" + MapName;
        }
    }

    public class MapSubInventoryKey
    {
        public string Path;
        public MapType Type;
        public override string ToString()
        {
            return "Path:" + Path + " Type:" + Type;
        }
    }

    public enum MapType
    {
        Normal,
        Shaped,
        Unknown2,
        Unknown3,
        Unique
    }

    public class MapStashTabElement : Element
    {
        private long mapListStartPtr => (Address != 0) ? M.ReadLong(Address + 0x9D8) : 0x00;
        private long mapListEndPtr => (Address != 0) ? M.ReadLong(Address + 0x9D8 + 0x08) : 0x00;
        public int TotalInventories => (int)((mapListEndPtr - mapListStartPtr) / 0x10);

        public Dictionary<MapSubInventoryKey, MapSubInventoryInfo> MapsCount => GetMapsCount();
        private Dictionary<MapSubInventoryKey, MapSubInventoryInfo> GetMapsCount()
        {
            var result = new Dictionary<MapSubInventoryKey, MapSubInventoryInfo>();
            MapSubInventoryInfo subInventoryInfo = null;
            MapSubInventoryKey subInventoryKey = null;

            for (int i = 0; i < TotalInventories; i++)
            {
                subInventoryInfo = new MapSubInventoryInfo();
                subInventoryKey = new MapSubInventoryKey();
                subInventoryInfo.Tier = SubInventoryMapTier(i);
                subInventoryInfo.Count = SubInventoryMapCount(i);
                subInventoryInfo.MapName = SubInventoryMapName(i);
                if (subInventoryInfo.Count == 0)
                    continue;
                subInventoryKey.Path = SubInventoryMapPath(i);
                subInventoryKey.Type = SubInventoryMapType(i);
                result.Add(subInventoryKey, subInventoryInfo);
            }
            return result;
        }

        private int SubInventoryMapTier(int index)
        {
            return M.ReadInt(mapListStartPtr + (index * 0x10), 0x00);
        }
        private int SubInventoryMapCount(int index)
        {
            return M.ReadInt(mapListStartPtr + (index * 0x10), 0x08);
        }
        private MapType SubInventoryMapType(int index)
        {
            return (MapType)M.ReadInt(mapListStartPtr + (index * 0x10), 0x1C);
        }
        private string SubInventoryMapPath(int index)
        {
            return M.ReadStringU(M.ReadLong(mapListStartPtr + (index * 0x10), 0x28, 0x00));
        }
        private string SubInventoryMapName(int index)
        {
            return M.ReadStringU(M.ReadLong(mapListStartPtr + (index * 0x10), 0x28, 0x20));
        }
    }
}
