namespace PoeHUD.Poe.Elements
{
    public class Map : Element
    {
        //public Element MapProperties => ReadObjectAt<Element>(0x1FC + OffsetBuffers);

        public Element LargeMap => ReadObjectAt<Element>(0x31C + OffsetBuffers);
        public float LargeMapShiftX => M.ReadFloat(LargeMap.Address + OffsetBuffers + 0x2AC);
        public float LargeMapShiftY => M.ReadFloat(LargeMap.Address + OffsetBuffers + 0x2B0);
        public float LargeMapZoom => M.ReadFloat(LargeMap.Address + OffsetBuffers + 0x2F0);

        public Element SmallMinimap => ReadObjectAt<Element>(0x324 + OffsetBuffers);
        public float SmallMinimapX => M.ReadFloat(SmallMinimap.Address + OffsetBuffers + 0x2AC);
        public float SmallMinimapY => M.ReadFloat(SmallMinimap.Address + OffsetBuffers + 0x2B0);
        public float SmallMinimapZoom => M.ReadFloat(SmallMinimap.Address + OffsetBuffers + 0x2F0);


        public Element OrangeWords => ReadObjectAt<Element>(0x33C + OffsetBuffers);
        public Element BlueWords => ReadObjectAt<Element>(0x374 + OffsetBuffers);
    }
}