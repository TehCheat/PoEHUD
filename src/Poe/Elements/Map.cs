namespace PoeHUD.Poe.Elements
{
    public class Map : Element
    {
        //public Element MapProperties => ReadObjectAt<Element>(0x1FC + OffsetBuffers);

        public Element LargeMap => ReadObjectAt<Element>(0x324 + OffsetBuffers);
        public float LargeMapShiftX => M.ReadFloat(LargeMap.Address + 0x2B4 + OffsetBuffers);
        public float LargeMapShiftY => M.ReadFloat(LargeMap.Address + 0x2B8 + OffsetBuffers);
        public float LargeMapZoom => M.ReadFloat(LargeMap.Address + 0x2F8 + OffsetBuffers);

        public Element SmallMinimap => ReadObjectAt<Element>(0x32C + OffsetBuffers);
        public float SmallMinimapX => M.ReadFloat(SmallMinimap.Address + 0x1C0);
        public float SmallMinimapY => M.ReadFloat(SmallMinimap.Address + 0x1C4);
        public float SmallMinimapZoom => M.ReadFloat(SmallMinimap.Address + 0x204);


        public Element OrangeWords => ReadObjectAt<Element>(0x250);
        public Element BlueWords => ReadObjectAt<Element>(0x2A8);
    }
}