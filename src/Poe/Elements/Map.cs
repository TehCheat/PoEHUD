namespace PoeHUD.Poe.Elements
{
    public class Map : Element
    {
        //public Element MapProperties => ReadObjectAt<Element>(0x1FC + OffsetBuffers);

        public Element LargeMap => ReadObjectAt<Element>(0x230);
        public float LargeMapShiftX => M.ReadFloat(LargeMap.Address +0x1C0);
        public float LargeMapShiftY => M.ReadFloat(LargeMap.Address +0x1C4);
        public float LargeMapZoom => M.ReadFloat(LargeMap.Address +0x204);

        public Element SmallMinimap => ReadObjectAt<Element>(0x238);
        public float SmallMinimapX => M.ReadFloat(SmallMinimap.Address + 0x1C0);
        public float SmallMinimapY => M.ReadFloat(SmallMinimap.Address + 0x1C4);
        public float SmallMinimapZoom => M.ReadFloat(SmallMinimap.Address + 0x204);


        public Element OrangeWords => ReadObjectAt<Element>(0x250);
        public Element BlueWords => ReadObjectAt<Element>(0x2A8);
    }
}