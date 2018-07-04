using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PoeHUD.Poe.RemoteMemoryObjects
{
	public class ActorVaalSkill : RemoteMemoryObject
	{
		const int NAMES_POINTER_OFFSET = 0x8;
		const int INTERNAL_NAME_OFFSET = 0x0;
		const int NAME_OFFSET = 0x8;
		const int DESCRIPTION_OFFSET = 0x10;
		const int SKILL_NAME_OFFSET = 0x18;
		const int ICON_OFFSET = 0x20;

		const int MAX_VAAL_SOULS_OFFSET = 0x10;
		const int VAAL_SOULS_PER_USE_OFFSET = 0x14;
		const int CURRENT_VAAL_SOULS_OFFSET = 0x18;

		public string VaalSkillInternalName => M.ReadStringU(M.ReadLong(NAMES_POINTER_OFFSET) + INTERNAL_NAME_OFFSET);
		public string VaalSkillDisplayName => M.ReadStringU(M.ReadLong(NAMES_POINTER_OFFSET) + NAME_OFFSET);
		public string VaalSkillDescription => M.ReadStringU(M.ReadLong(NAMES_POINTER_OFFSET) + DESCRIPTION_OFFSET);
		public string VaalSkillSkillName => M.ReadStringU(M.ReadLong(NAMES_POINTER_OFFSET) + SKILL_NAME_OFFSET);
		public string VaalSkillIcon => M.ReadStringU(M.ReadLong(NAMES_POINTER_OFFSET) + ICON_OFFSET);

		public int VaalMaxSouls => M.ReadInt(Address + MAX_VAAL_SOULS_OFFSET);
		public int VaalSoulsPerUse => M.ReadInt(Address + VAAL_SOULS_PER_USE_OFFSET);
		public int CurrVaalSouls => M.ReadInt(Address + CURRENT_VAAL_SOULS_OFFSET);
	}
}
