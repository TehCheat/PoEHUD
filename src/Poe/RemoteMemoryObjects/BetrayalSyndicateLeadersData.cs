using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
	public class BetrayalSyndicateLeadersData : RemoteMemoryObject
	{
		public List<BetrayalSyndicateState> Leaders => new List<BetrayalSyndicateState>
		{
			ReadObjectAt<BetrayalSyndicateState>(0x0),
			ReadObjectAt<BetrayalSyndicateState>(0x8),
			ReadObjectAt<BetrayalSyndicateState>(0x10),
			ReadObjectAt<BetrayalSyndicateState>(0x18)
		};
	}
}