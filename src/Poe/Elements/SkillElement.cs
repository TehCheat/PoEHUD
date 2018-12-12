namespace PoeHUD.Poe.Elements
{
    public class SkillElement : Element
    {
        public bool isValid => unknown1 != 0;

        // Usefull for aura/golums, if they are active or assigned to a key, it's value would be true.
        public bool IsAssignedKeyOrIsActive => M.ReadInt(unknown1 + 0x08) > 3;

        // Couldn't find the skill path, but found skillicon path.
        public string SkillIconPath => M.ReadStringU(M.ReadLong(unknown1 + 0x10), 100).TrimEnd('0');

        // Number of time a skill is used ... reset on area change.
        public int totalUses => M.ReadInt(unknown3 + 0x50);

        // Usefull for channeling skills only.
        public bool isUsing => M.ReadByte(unknown3 + 0x08) > 2;

        // A variable is unknown.
        private long unknown1 => M.ReadLong( Address + OffsetBuffers + 0x244);
        private long unknown3 => M.ReadLong(Address + OffsetBuffers + 0x32C);
    }
}
