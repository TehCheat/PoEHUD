using PoeHUD.Controllers;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
	public class BetrayalEventData : RemoteMemoryObject
	{
		public BetrayalTarget Target1 => GameController.Instance.Files.BetrayalTargets.GetByAddress(M.ReadLong(Address + 0xAB8)); //ReadObjectAt<BetrayalTarget>(0xAB8);
		public BetrayalTarget Target2 => GameController.Instance.Files.BetrayalTargets.GetByAddress(M.ReadLong(Address + 0xAD8)); //ReadObjectAt<BetrayalTarget>(0xAD8);
		public BetrayalTarget Target3 => GameController.Instance.Files.BetrayalTargets.GetByAddress(M.ReadLong(Address + 0xAE8)); //ReadObjectAt<BetrayalTarget>(0xAE8);
		public BetrayalChoiceAction Action => GameController.Instance.Files.BetrayalChoiseActions.GetByAddress(M.ReadLong(Address + 0xAC8)); //ReadObjectAt<BetrayalChoiceAction>(0xAC8);
	}
}