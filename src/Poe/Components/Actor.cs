using System.Collections.Generic;
using System;
using PoeHUD.Poe.RemoteMemoryObjects;
using PoeHUD.Controllers;
using PoeHUD.Models;
using SharpDX;

namespace PoeHUD.Poe.Components
{
    public partial class Actor : Component
    {
        /// <summary>
        ///     Standing still = 2048 =bit 11 set
        ///     running = 2178 = bit 11 & 7
        ///     Maybe Bit-field : Bit 7 set = running
        /// </summary>
        public int ActionId => Address != 0 ? M.ReadInt(Address + 0xD8) : 1;

        public ActionFlags Action => Address != 0 ? (ActionFlags)M.ReadInt(Address + 0xD8) : ActionFlags.None;
        public bool isMoving => Action == ActionFlags.Moving;
        public bool isAttacking => Action == ActionFlags.UsingAbility;

        [Obsolete("Use DeployedObjects instead")]
        public List<int> Minions
        {
            get
            {
                var list = new List<int>();
                if (Address == 0)
                {
                    return list;
                }
                long num = M.ReadLong(Address + 0x310);
                long num2 = M.ReadLong(Address + 0x318);
                for (long i = num; i < num2; i += 8)
                {
                    // using int instead of long because first 4 bytes are id
                    // second 4 bytes are wierd number which depend on socket number/location.
                    int item = M.ReadInt(i);
                    list.Add(item);
                }
                return list;
            }
        }

        public bool HasMinion(Entity entity)
        {
            if (Address == 0)
            {
                return false;
            }
            long num = M.ReadLong(Address + 0x308);
            long num2 = M.ReadLong(Address + 0x310);
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


        public float TimeSinseLastMove => -M.ReadFloat(Address + 0x110);
        public float TimeSinseLastAction => -M.ReadFloat(Address + 0x114);

        public ActionWrapper CurrentAction => Action == ActionFlags.UsingAbility ? ReadObject<ActionWrapper>(Address + 0x60) : null;

        public List<DeployedObject> DeployedObjects
        {
            get
            {
                var result = new List<DeployedObject>();
                var start = M.ReadLong(Address + 0x310);
                var end = M.ReadLong(Address + 0x318);

                for (var addr = start; addr < end; addr += 8)
                {
                    var objectId = M.ReadUInt(addr);
                    var objectKey = M.ReadUShort(addr + 4);//in list of entities
                    result.Add(new DeployedObject(objectId, objectKey));
                }
                return result;
            }
        }

        public List<ActorSkill> ActorSkills
        {
            get
            {
                var skillsStartPointer = M.ReadLong(Address + 0x2c0);
                var skillsEndPointer = M.ReadLong(Address + 0x2c8);
                skillsStartPointer += 8;//Don't ask me why. Just skipping first one

                var result = new List<ActorSkill>();
                for (var addr = skillsStartPointer; addr < skillsEndPointer; addr += 16)//16 because we are reading each second pointer (pointer vectors)
                {
                    result.Add(ReadObject<ActorSkill>(addr));
                }
                return result;
            }
        }


        public class ActionWrapper : RemoteMemoryObject
        {
            public float DestinationX => M.ReadInt(Address + 0x38);
            public float DestinationY => M.ReadInt(Address + 0x3c);

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
            LocalPlayer = 2048
        }
    }
}
