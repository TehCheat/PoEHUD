using PoeHUD.Controllers;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
	public class BetrayalReward : RemoteMemoryObject
	{
		public BetrayalJob Job => GameController.Instance.Files.BetrayalJobs.GetByAddress(M.ReadLong(Address + 0x8));
		public BetrayalTarget Target => GameController.Instance.Files.BetrayalTargets.GetByAddress(M.ReadLong(Address + 0x18));
		public BetrayalRank Rank => GameController.Instance.Files.BetrayalRanks.GetByAddress(M.ReadLong(Address + 0x28));
		public string Reward => M.ReadStringU(M.ReadLong(Address + 0x30));

		public override string ToString()
		{
			return Reward;
		}
	}
}
