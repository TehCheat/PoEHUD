using System.Collections.Generic;
using System;
using PoeHUD.Poe.RemoteMemoryObjects;
using SharpDX;

namespace PoeHUD.Poe.Components
{
    public class Actor : Component
    {
        /// <summary>
        ///     Standing still = 2048 =bit 11 set
        ///     running = 2178 = bit 11 & 7
        ///     Maybe Bit-field : Bit 7 set = running
        /// </summary>
        public int ActionId => Address != 0 ? M.ReadInt(Address + 0x98) : 1;
        public ActionFlags Action => Address != 0 ? (ActionFlags)ActionId : ActionFlags.None;
        public bool isMoving => (Action & ActionFlags.Moving) > 0;
        public bool isAttacking => (Action & ActionFlags.UsingAbility) > 0;

        public bool HasMinion(Entity entity)
        {
            if (Address == 0)
            {
                return false;
            }
            long num = M.ReadLong(Address + 0x438);
            long num2 = M.ReadLong(Address + 0x440);
            for (long i = num; i < num2; i += 8)
            {
                int num3 = M.ReadInt(i);
                if (num3 == (int)(entity.Id >> 32))
                {
                    return true;
                }
            }
            return false;
        }

		// Needs fixed
        // public float TimeSinseLastMove => -M.ReadFloat(Address + 0x110);
        // public float TimeSinseLastAction => -M.ReadFloat(Address + 0x114);

        public ActionWrapper CurrentAction => (Action & ActionFlags.UsingAbility) > 0 ? ReadObject<ActionWrapper>(Address + 0x98) : null;

        // e.g minions, mines
        private long DeployedObjectStart => M.ReadLong(Address + 0x440);
        private long DeployedObjectEnd => M.ReadLong(Address + 0x448);
        public long DeployedObjectsCount => (DeployedObjectEnd - DeployedObjectStart) / 8;
        public List<DeployedObject> DeployedObjects
        {
            get
            {
                var result = new List<DeployedObject>();
                var LIMIT = 300;
                for (var addr = DeployedObjectStart; addr < DeployedObjectEnd; addr += 8)
                {
                    var objectId = M.ReadUInt(addr);
                    var objectKey = M.ReadUShort(addr + 4);//in list of entities
                    result.Add(new DeployedObject(objectId, objectKey));

                    if (--LIMIT < 0)
                    {
                        DebugPlug.DebugPlugin.LogMsg("Fixed stuck in Actor.DeployedObjects", 2);
                        break;
                    }
                }
                return result;
            }
        }

        public List<ActorSkill> ActorSkills
        {
            get
            {
                var skillsStartPointer = M.ReadLong(Address + 0x3D8);
                var skillsEndPointer = M.ReadLong(Address + 0x3E0);
                skillsStartPointer += 8;//Don't ask me why. Just skipping first one
                if ((skillsEndPointer - skillsStartPointer) / 16 > 50)
                    return new List<ActorSkill>();

                var result = new List<ActorSkill>();
                for (var addr = skillsStartPointer; addr < skillsEndPointer; addr += 16)//16 because we are reading each second pointer (pointer vectors)
                {
                    result.Add(ReadObject<ActorSkill>(addr));
                }
                return result;
            }
        }

        public List<ActorVaalSkill> ActorVaalSkills
		{
			get
			{
				const int ACTOR_VAAL_SKILLS_SIZE = 0x20;
				var skillsStartPointer = M.ReadLong(Address + 0x408);
				var skillsEndPointer = M.ReadLong(Address + 0x410);

				int stuckCounter = 0;
				var result = new List<ActorVaalSkill>();
				for (var addr = skillsStartPointer; addr < skillsEndPointer; addr += ACTOR_VAAL_SKILLS_SIZE)
				{
					result.Add(ReadObject<ActorVaalSkill>(addr));
					if (stuckCounter++ > 50)
						return new List<ActorVaalSkill>();
				}
				return result;
			}
		}

		public class ActionWrapper : RemoteMemoryObject
        {
            public float DestinationX => M.ReadInt(Address + 0x60);
            public float DestinationY => M.ReadInt(Address + 0x64);
            public long Target => M.ReadLong(Address + 0x38);
            public Vector2 CastDestination => new Vector2(DestinationX, DestinationY);
            public ActorSkill Skill => ReadObject<ActorSkill>(Address + 0x18);
        }


        [Flags]
        public enum ActionFlags
        {
            None = 0,
            UsingAbility = 2,

            //Actor is currently playing the "attack" animation, and therefor locked in a cooldown before any other action.
            AbilityCooldownActive = 16,
            Dead = 64,
            Moving = 128,

            /// actor is in the washed up state and false otherwise.
            WashedUpState = 256,
            HasMines = 2048
        }
    }
}
