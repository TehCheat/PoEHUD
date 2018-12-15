using System;
using System.Collections;
using System.Collections.Generic;
using PoeHUD.Poe.FilesInMemory;
using PoeHUD.Poe.RemoteMemoryObjects;
using PoeHUD.Controllers;
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
	    public HideoutWrapper Hideout => ReadObject<HideoutWrapper>(Address + 0x230);

	    public PantheonGod PantheonMinor => (PantheonGod)M.ReadByte(Address + 0x5b);
	    public PantheonGod PantheonMajor => (PantheonGod)M.ReadByte(Address + 0x5c);

	    #region Prophecy
	    public byte PropheciesCount => M.ReadByte(Address + 0x1EA);

        //How to fix prophecies:
        //PropheciesCount is ez to find (use Structure Spider Advanced)
        //Prophecies reading offset: 
        //seek some prophecy, find it in GameFiles.Prophecies.List (qvin debug plugin), read it's id and search it in Structure Spider Advanced
        //Fx prophecy The Cursed Choir has ProphecyId 18633 (use Id, not prophecy index!)
        //Prophecies offset goes directly after PropheciesCount offset, maybe 1 byte distance.
	    public List<ProphecyDat> Prophecies
	    {
		    get
		    {
			    var result = new List<ProphecyDat>();
			    var readAddr = Address + 0x1EC;

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
	    #endregion
	    #region Passives
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
	    #endregion
        #region Trials
        public bool IsTrialCompleted(string trialId)
        {
            var trialWrapper = GameController.Instance.Files.LabyrinthTrials.GetLabyrinthTrialByAreaId(trialId);
            if(trialWrapper == null)
                throw new ArgumentException($"Trial with id '{trialId}' is not found. Use WorldArea.Id or LabyrinthTrials.LabyrinthTrialAreaIds[]");

            return TrialPassStates.Get(trialWrapper.Id - 1);
        }
        public bool IsTrialCompleted(LabyrinthTrial trialWrapper)
        {
            if (trialWrapper == null)
                throw new ArgumentException($"Argument {nameof(trialWrapper)} should not be null");

            return TrialPassStates.Get(trialWrapper.Id - 1);
        }
        public bool IsTrialCompleted(WorldArea area)
        {
            if (area == null)
                throw new ArgumentException($"Argument {nameof(area)} should not be null");

            var trialWrapper = GameController.Instance.Files.LabyrinthTrials.GetLabyrinthTrialByArea(area);

            if (trialWrapper == null)
                throw new ArgumentException($"Can't find trial wrapper for area '{area.Name}' (seems not a trial area).");

            return TrialPassStates.Get(trialWrapper.Id - 1);
        }

		/*
		 How to fix TrialPassStates offsets. Detailed example. 

        Update. New way: Uncomment argument (StaticOffsetFieldDebugAttribute) from:
        public static int DebugPlayerTrialStates
        Use "Qvin Debug Tree" plugin. Change slider DebugPlayerTrialStates to pick the right offset. Convert slider number to hex
            
        Old way:
		 Better to use ReClass.Net for that (or program that can show bits of byte on some offset)
		 Go to some uncompleted trial but do not activate it!
		 Open ReClass on Player component address (get it from "Qvin Debug Tree" (QDT) plugin)
		 Scroll to offset near (0x180) (Use "Add bytes->2048" command to increase view range). 
		 Switch all next data to display as bits (better to switch them to Hex8 first, then to bits, to see bits of each byte on a new line)
		 Detect which bit is changed after activating trial (make 2 screenshots then compare)
		 In my case I got this:
			0x180:	11000000
			0x181:	01111111
			after activating "The Bath House" trial:
			0x180:	11000000
			0x181:	11111111   <<here
		so after activating trial the last (8) bit of 0x181 byte was changed (count bits from right to left).
		Open in QDT GameController->Files->LabyrinthTrials->EntriesList. Here we can see that area Id of "The Bath House" trial is 272
		So the 8th bit of 0x181 byte is "The Bath House" trial
		The first trial (Lower Prison) id is 263 (at this moment), so Bath House is 272-263= 9th bit from our data bits, 

		Byte have 8 bits (yes, obviously), so we going to start read bytes array data from 0x180 (ignoring first 7 bits)
		And to simplify it we will read whole array (286 bits (as 286 is the last trial area id) = 35,75(36) bytes). 
		So 263 - 7(skipped) = 256.  256/8bits = 0x20 back from 0x180. So 0x180 - 0x20 = 0x160. Read offset is 0x160
		*/

        //[StaticOffsetFieldDebugAttribute]
        public static int DebugPlayerTrialStates = 0x17E;

        [HideInReflection]//Comment this attribute to see it in "Qvin Debug Tree" plugin.
        private BitArray TrialPassStates
        {
            get
            {
	            var stateBuff = M.ReadBytes(Address + DebugPlayerTrialStates, 36);// (286+) bytes of info.
                return new BitArray(stateBuff);
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
                    result.Add(new TrialState { TrialAreaId = trialAreaId, TrialArea = wrapper, IsCompleted = passStates.Get(wrapper.Id - 1) });
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
                return $"Completed: {IsCompleted}, {TrialArea.Area.Name}";//, TrialAreaId: {TrialAreaId}
            }
        }
        #endregion
        #endregion

	    public override string ToString()
	    {
		    return $"{PlayerName} ({Level})";
	    }

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
