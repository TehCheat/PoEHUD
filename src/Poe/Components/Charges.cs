namespace PoeHUD.Poe.Components
{
    public class Charges : Component
    {
        public int NumCharges => Address != 0 ? M.ReadInt(Address + 0x18) : 0;

        public int ChargesPerUse => Address != 0 ? M.ReadInt(Address + 0x10, 0x14) : 0;

        public int ChargesMax => Address != 0 ? M.ReadInt(Address + 0x10, 0x10) : 0;
    }
}
