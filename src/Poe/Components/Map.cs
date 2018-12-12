using PoeHUD.Poe.RemoteMemoryObjects;
using PoeHUD.Controllers;

namespace PoeHUD.Poe.Components
{
    public class Map : Component
    {
        public WorldArea Area => GetObject<WorldArea>(M.ReadLong(Address + 0x10, 0x18, 0x8));// GameController.Instance.Files.WorldAreas.GetByAddress(M.ReadLong(Address + 0x10, 0x18));
        public int Tier => M.ReadByte(Address + 0x18);//let it be int to not break some plugins
        //public InventoryTabMapSeries MapSeries => (InventoryTabMapSeries)M.ReadByte(Address + 0x10, 0x9c);
    }

    public enum InventoryTabMapSeries : byte
    {
        Atlas_of_Worlds = 3,
        None = 0,
        Original = 1,
        The_Awakening = 2,
        War_for_the_Atlas = 4,
        Bestiary = 5,
    }
}