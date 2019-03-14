using System.Collections.Generic;
using PoeHUD.Controllers;
using SharpDX;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
	public class BetrayalSyndicateState : RemoteMemoryObject
	{
		public static int STRUCT_SIZE = 0x98;

		public Element UIElement => ReadObjectAt<Element>(0);

		public float PosX => M.ReadFloat(Address + 0x7C);
		public float PosY => M.ReadFloat(Address + 0x80);
		public Vector2 Pos => new Vector2(PosX, PosY);

		public int PrisonTurns => M.ReadInt(Address + 0x74);
		public bool IsPrisoned => PrisonTurns > 0;

		//TODO: There should be some offset
		public bool IsLeader
		{
			get
			{
				if (string.IsNullOrEmpty(Job.Name))
					return false;

				return Vector2.Distance(Pos, Job.LeaderPos) < 10;
			}
		}

		public BetrayalTarget Target => GameController.Instance.Files.BetrayalTargets.GetByAddress(M.ReadLong(Address + 0x10));
		public BetrayalJob Job => GameController.Instance.Files.BetrayalJobs.GetByAddress(M.ReadLong(Address + 0x20));
		public BetrayalRank Rank => GameController.Instance.Files.BetrayalRanks.GetByAddress(M.ReadLong(Address + 0x30));
		public BetrayalReward Reward => GameController.Instance.Files.BetrayalRewards.EntriesList.Find(x => x.Target == Target && x.Job == Job && x.Rank == Rank);

		public List<BetrayalUpgrade> BetrayalUpgrades
		{
			get
			{
				var startAddress = M.ReadLong(Address + 0x38);
				var endAddress = M.ReadLong(Address + 0x40);
				var result = new List<BetrayalUpgrade>();

				for (var addr = startAddress; addr < endAddress; addr += 0x10)
				{
					result.Add(ReadObject<BetrayalUpgrade>(addr + 0x8));
				}

				return result;
			}
		}

		public List<BetrayalSyndicateState> Relations
		{
			get
			{
				var relationAddress = M.ReadLong(Address + 0x50);
				var result = new List<BetrayalSyndicateState>();
				for (var i = 0; i < 3; i++)
				{
					var address = M.ReadLong(relationAddress + i * 0x8);
					if (address != 0)
					{
						result.Add(GetObject<BetrayalSyndicateState>(address));
					}
				}

				return result;
			}
		}


		public override string ToString()
		{
			return $"{Target.Name}, {Rank.Name}, {Job.Name}" +
			       $"{(IsLeader ? ", Leader" : "")}" +
			       $"{(IsPrisoned ? $" (Prisoned for: {PrisonTurns} turns)" : ".")}";
		}
	}

	public class BetrayalUpgrade : RemoteMemoryObject
	{
		public string UpgradeName => M.ReadStringU(M.ReadLong(Address + 0x8));
		public string UpgradeStat => M.ReadStringU(M.ReadLong(Address + 0x10));
		public string Art => M.ReadStringU(M.ReadLong(Address + 0x28));

		public override string ToString()
		{
			return $"{UpgradeName} ({UpgradeStat})";
		}
	}
}