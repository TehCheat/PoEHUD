using System;

namespace PoeHUD.Poe.Components
{
    public class Charges : Component
	{
		public int NumCharges
		{
			get
			{
				return this.Address != 0 ? this.M.ReadInt(this.Address + 0x18) : 0;
			}
		}

		public int ChargesPerUse
		{
			get
			{
				return this.Address != 0 ? this.M.ReadInt(this.Address + 0x10, 0x14) : 0;
			}
		}
		public int ChargesMax
		{
			get
			{
				return this.Address != 0 ? this.M.ReadInt(this.Address + 0x10, 0x10) : 0;
			}
		}
	}
}

namespace PoeHUD.Poe.EntityComponents
{
	[Obsolete("Use PoeHUD.Poe.Components.Charges instead. Will be removed soon")]
	public class Charges : Component
	{
		public int NumCharges
		{
			get
			{
				return this.Address != 0 ? this.M.ReadInt(this.Address + 0x18) : 0;
			}
		}

		public int ChargesPerUse
		{
			get
			{
				return this.Address != 0 ? this.M.ReadInt(this.Address + 0x10, 0x14) : 0;
			}
		}
		public int ChargesMax
		{
			get
			{
				return this.Address != 0 ? this.M.ReadInt(this.Address + 0x10, 0x10) : 0;
			}
		}
	}
}