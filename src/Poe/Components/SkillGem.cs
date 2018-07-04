namespace PoeHUD.Poe.Components
{
    public class SkillGem : Component
    {
		public int GemLevel => M.ReadByte(Address + 0x2C);
    }
}