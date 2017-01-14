namespace PoeHUD.Poe.EntityComponents
{
	public class Charges : Component
	{
		public int NumCharges
		{
			get
			{
				return this.Address != 0 ? this.M.ReadInt(this.Address + 24) : 0;
			}
		}

		public int ChargesPerUse
		{
			get
			{
				return this.Address != 0 ? this.M.ReadInt(this.Address + 16, 20) : 0;
			}
		}
		public int ChargesMax
		{
			get
			{
				return this.Address != 0 ? this.M.ReadInt(this.Address + 16, 16) : 0;
			}
		}
	}
}