namespace PoeHUD.Poe.Components
{
    public class CurrencyInfo : Component
    {
        public int MaxStackSize => Address != 0 ? M.ReadInt(Address + 0x28) : 0;
    }
}