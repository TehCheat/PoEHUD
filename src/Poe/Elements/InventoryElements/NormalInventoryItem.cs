namespace PoeHUD.Poe.Elements
{
    public class NormalInventoryItem : Element
    {
        public virtual int InventPosX => M.ReadInt(Address + 0xb70);
        public virtual int InventPosY => M.ReadInt(Address + 0xb74);
        public Entity Item => ReadObject<Entity>(Address + 0xB68);
        public ToolTipType toolTipType => ToolTipType.InventoryItem;
        public Element ToolTip => ReadObject<Element>(Address + 0xB18);

    }
}
