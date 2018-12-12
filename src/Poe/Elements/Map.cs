namespace PoeHUD.Poe.Elements
{
    public class Map : Element
    {
        //public Element MapProperties => ReadObjectAt<Element>(0x1FC + OffsetBuffers);

        public Element LargeMap => ReadObjectAt<Element>(0x32C + OffsetBuffers);
        public float LargeMapShiftX => M.ReadFloat(LargeMap.Address + OffsetBuffers + 0x2BC);
        public float LargeMapShiftY => M.ReadFloat(LargeMap.Address + OffsetBuffers + 0x2C0);
        public float LargeMapZoom => M.ReadFloat(LargeMap.Address + OffsetBuffers + 0x300);

        public Element SmallMinimap => ReadObjectAt<Element>(0x334 + OffsetBuffers);
        public float SmallMinimapX => M.ReadFloat(SmallMinimap.Address + OffsetBuffers + 0x2BC);
        public float SmallMinimapY => M.ReadFloat(SmallMinimap.Address + OffsetBuffers + 0x2C0);
        public float SmallMinimapZoom => M.ReadFloat(SmallMinimap.Address + OffsetBuffers + 0x300);


        public Element OrangeWords => ReadObjectAt<Element>(0x34C + OffsetBuffers);
        public Element BlueWords => ReadObjectAt<Element>(0x3A4 + OffsetBuffers);
    }
}