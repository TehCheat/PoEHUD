using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using PoeHUD.Poe.FilesInMemory;
using PoeHUD.Poe.RemoteMemoryObjects;
using PoeHUD.Controllers;
using PoeHUD.Poe.FilesInMemory;
using PoeHUD.Models;
using PoeHUD.Models.Attributes;

namespace PoeHUD.Poe.Components
{
    public class Player : Component
    {
        public string PlayerName => GetObject<NativeStringReader>(Address + 0x20).Value;
        public uint XP => Address != 0 ? M.ReadUInt(Address + 0x48) : 0;
		public int Strength => Address != 0 ? M.ReadInt(Address + 0x4c) : 0;
		public int Dexterity => Address != 0 ? M.ReadInt(Address + 0x50) : 0;
		public int Intelligence => Address != 0 ? M.ReadInt(Address + 0x54) : 0;
        public int Level => Address != 0 ? M.ReadByte(Address + 0x58) : 1;
        public int AllocatedLootId => Address != 0 ? M.ReadByte(Address + 0x44) : 1;


        public int HideoutLevel => M.ReadByte(Address + 0x256);
        public byte PropheciesCount => M.ReadByte(Address + 0x257);

        public List<ProphecyDat> Prophecies
        {
            get
            {
                var result = new List<ProphecyDat>();
                var readAddr = Address + 0x258;

                for (int i = 0; i < 7; i++)
                {
                    var prophecyId = M.ReadUShort(readAddr);
                    //if(prophacyId > 0)//Dunno why it will never be 0 even if there is no prophecy
                    {
                        var prophecy = GameController.Instance.Files.Prophecies.GetProphecyById(prophecyId);
                        if (prophecy != null)
                            result.Add(prophecy);
                    }
                    readAddr += 4;//prophecy prophecyId(UShort), Skip index(byte), Skip unknown(byte)
                }
                return result;
            }
        }


        public HideoutWrapper Hidout => ReadObject<HideoutWrapper>(Address + 0x230);

        public PantheonGod PantheonMinor => (PantheonGod)M.ReadByte(Address + 0x5b);
        public PantheonGod PantheonMajor => (PantheonGod)M.ReadByte(Address + 0x5c);

        
        public List<PassiveSkill> AllocatedPassives
        {
            get
            {
                var result = new List<PassiveSkill>();
                var passiveIds = GameController.Instance.Game.IngameState.ServerData.PassiveSkillIds;

                foreach(var id in passiveIds)
                {
                    var passive = GameController.Instance.Files.PassiveSkills.GetPassiveSkillByPassiveId(id);
                    if(passive == null)
                    {
                        DebugPlug.DebugPlugin.LogMsg($"Can't find passive with id: {id}", 10, SharpDX.Color.Red);
                        continue;
                    }
                    result.Add(passive);
                }
                return result;
            }
        }
        
        #region Trials
        public bool IsTrialCompleted(string trialId)
        {
            var trialWrapper = GameController.Instance.Files.LabyrinthTrials.GetLabyrinthTrialByAreaId(trialId);
            if(trialWrapper == null)
                throw new ArgumentException($"Trial with id '{trialId}' is not found. Use WorldArea.Id or LabyrinthTrials.LabyrinthTrialAreaIds[]");

            return TrialPassStates.Get(trialWrapper.Id);
        }
        public bool IsTrialCompleted(LabyrinthTrial trialWrapper)
        {
            if (trialWrapper == null)
                throw new ArgumentException($"Argument {nameof(trialWrapper)} should not be null");

            return TrialPassStates.Get(trialWrapper.Id);
        }
        public bool IsTrialCompleted(WorldArea area)
        {
            if (area == null)
                throw new ArgumentException($"Argument {nameof(area)} should not be null");

            var trialWrapper = GameController.Instance.Files.LabyrinthTrials.GetLabyrinthTrialByArea(area);

            if (trialWrapper == null)
                throw new ArgumentException($"Can't find trial wrapper for area '{area.Name}' (seems not a trial area).");

            return TrialPassStates.Get(trialWrapper.Id);
        }

        [HideInReflection]
        private BitArray TrialPassStates
        {
            get
            {
                byte[] buffer = new byte[0x30];
                var stateBuff = M.ReadBytes(Address + 0x15c, 0x34);
                for (int i = 0; i < buffer.Length; i++)
                {
                    buffer[i] = stateBuff[i];
                }
                return new BitArray(buffer);
            }
        }

        #region Debug things
        
        public List<TrialState> TrialStates
        {
            get
            {
                var result = new List<TrialState>();
                var passStates = TrialPassStates;
                foreach (var trialAreaId in LabyrinthTrials.LabyrinthTrialAreaIds)
                {
                    var wrapper = GameController.Instance.Files.LabyrinthTrials.GetLabyrinthTrialByAreaId(trialAreaId);
                    result.Add(new TrialState() { TrialAreaId = trialAreaId, TrialArea = wrapper, IsCompleted = passStates.Get(wrapper.Id - 1) });
                }
                return result;
            }
        }
        
        public class TrialState
        {
            public LabyrinthTrial TrialArea { get; internal set; }
            public string TrialAreaId { get; internal set; }
            public bool IsCompleted { get; internal set; }
            public string AreaAddr => TrialArea.Address.ToString("x");

            public override string ToString()
            {
                return $"Completed: {IsCompleted}, Trial {TrialArea.Area.Name}, AreaId: {TrialArea.Id}";//, TrialAreaId: {TrialAreaId}
            }
        }
        #endregion
        #endregion

        /*//TODO fixme https://pathofexile.gamepedia.com/Master
        #region Master Exp Levels
        public uint CurrentExperienceTora => M.ReadUInt(Address + 0x198);
        public uint CurrentExperienceVorici => M.ReadUInt(Address + 0x188);
        public uint CurrentExperienceCatarina => M.ReadUInt(Address + 0x1a8);
        public uint CurrentExperienceZana => M.ReadUInt(Address + 0x1b8);
        public uint CurrentExperienceVagan => M.ReadUInt(Address + 0x1c8);
        public uint CurrentExperienceElreon => M.ReadUInt(Address + 0x1d8);
        public uint CurrentExperienceHaku => M.ReadUInt(Address + 0x1e8);
        public uint CurrentExperienceLeo => M.ReadUInt(Address + 0x1f8);

        public int CurrentLevelTora => Constants.GetLevel(Constants.ToraExperienceLevels, CurrentExperienceVorici);
        public int CurrentLevelVorici => Constants.GetLevel(Constants.VoriciExperienceLevels, CurrentExperienceVorici);
        public int CurrentLevelCatarina => Constants.GetLevel(Constants.CatarinaExperienceLevels, CurrentExperienceVorici);
        public int CurrentLevelZana => Constants.GetLevel(Constants.ZanaExperienceLevels, CurrentExperienceVorici);
        public int CurrentLevelVagan => Constants.GetLevel(Constants.VaganExperienceLevels, CurrentExperienceVorici);
        public int CurrentLevelElreon => Constants.GetLevel(Constants.ElreonExperienceLevels, CurrentExperienceVorici);
        public int CurrentLevelHaku => Constants.GetLevel(Constants.HakuExperienceLevels, CurrentExperienceVorici);
        public int CurrentLevelLeo => Constants.GetLevel(Constants.LeoExperienceLevels, CurrentExperienceVorici);

        public uint CurrentFullLevelTora => Constants.GetFullCurrentLevel(Constants.ToraExperienceLevels, CurrentExperienceVorici);
        public uint CurrentFullLevelVorici => Constants.GetFullCurrentLevel(Constants.VoriciExperienceLevels, CurrentExperienceVorici);
        public uint CurrentFullLevelCatarina => Constants.GetFullCurrentLevel(Constants.CatarinaExperienceLevels, CurrentExperienceVorici);
        public uint CurrentFullLevelZana => Constants.GetFullCurrentLevel(Constants.ZanaExperienceLevels, CurrentExperienceVorici);
        public uint CurrentFullLevelVagan => Constants.GetFullCurrentLevel(Constants.VaganExperienceLevels, CurrentExperienceVorici);
        public uint CurrentFullLevelElreon => Constants.GetFullCurrentLevel(Constants.ElreonExperienceLevels, CurrentExperienceVorici);
        public uint CurrentFullLevelHaku => Constants.GetFullCurrentLevel(Constants.HakuExperienceLevels, CurrentExperienceVorici);
        public uint CurrentFullLevelLeo => Constants.GetFullCurrentLevel(Constants.LeoExperienceLevels, CurrentExperienceVorici);
        #endregion
        */

        public enum PantheonGod
        {
            None,
            TheBrineKing,
            Arakaali,
            Solaris,
            Lunaris,
            MinorGod1,
            MinorGod2,
            Abberath,
            MinorGod4,
            Gruthkul,
            Yugul,
            Shakari,
            Tukohama,
            MinorGod9,
            Ralakesh,
            Garukhan,
            Ryslatha
        }
    }
}
