using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
	public class BetrayalData : RemoteMemoryObject
	{
		//This offsets seems good too https://dl.dropboxusercontent.com/s/2csb82ba4mmm2ee/StructureSpiderAdvanced_2018-12-29_02-42-18.png
		//0x728, 0x0, 0x7b8, 0xA38 - this is to some member (detected using WhoAccessingAddr)
		public BetrayalSyndicateLeadersData SyndicateLeadersData => ReadObjectAt<BetrayalSyndicateLeadersData>(0x9f0);

		public List<BetrayalSyndicateState> SyndicateStates
		{
			get
			{
				var betrayalStateAddr = M.ReadLong(Address + 0x110, 0x178, 0x178, 0x178, 0x4A0);
				return M.ReadStructsArray<BetrayalSyndicateState>(betrayalStateAddr, betrayalStateAddr + BetrayalSyndicateState.STRUCT_SIZE * 14, BetrayalSyndicateState.STRUCT_SIZE, 20);
			}
		}

		public BetrayalEventData BetrayalEventData
		{
			get
			{
				var addr = M.ReadLong(Address + 0xA50, 0xAD8, 0xB48, 0x7B8);
				return addr == 0 ? null : GetObject<BetrayalEventData>(addr);
			}
		}
	}
}