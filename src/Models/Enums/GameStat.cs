using System.ComponentModel;

namespace PoeHUD.Models.Enums
{
	public enum GameStat
	{
		[Description("Level")] Level = 1,
		[Description("Item Drop Slots")] ItemDropSlots = 2,
		[Description("Main Hand Weapon Type")] MainHandWeaponType = 3,
		[Description("Off Hand Weapon Type")] OffHandWeaponType = 4,

		[Description("Current Endurance Charges")]
		CurrentEnduranceCharges = 5,

		[Description("Current Frenzy Charges")]
		CurrentFrenzyCharges = 6,
		[Description("Current Power Charges")] CurrentPowerCharges = 7,

		[Description("Cannot Have Life Leeched From")]
		CannotHaveLifeLeechedFrom = 8,

		[Description("Cannot Have Mana Leeched From")]
		CannotHaveManaLeechedFrom = 9,

		[Description("Monster Slain Experience +%")]
		MonsterSlainExperiencePosPct = 10,

		[Description("Monster Dropped Item Rarity +%")]
		MonsterDroppedItemRarityPosPct = 11,

		[Description("Monster Dropped Item Quantity +%")]
		MonsterDroppedItemQuantityPosPct = 12,

		[Description("Local Flask Life To Recover")]
		LocalFlaskLifeToRecover = 13,

		[Description("Local Flask Life To Recover +%")]
		LocalFlaskLifeToRecoverPosPct = 14,

		[Description("Local Flask Mana To Recover")]
		LocalFlaskManaToRecover = 15,

		[Description("Local Flask Mana To Recover +%")]
		LocalFlaskManaToRecoverPosPct = 16,

		[Description("Local Flask Recovery Speed +%")]
		LocalFlaskRecoverySpeedPosPct = 17,

		[Description("Local Flask Deciseconds To Recover")]
		LocalFlaskDecisecondsToRecover = 18,

		[Description("Local Extra Max Charges")]
		LocalExtraMaxCharges = 19,
		[Description("Shield Block %")] ShieldBlockPct = 20,

		[Description("Old Do Not Use Spell Block % From Assumed Block Value")]
		OldDoNotUseSpellBlockPctFromAssumedBlockValue = 21,

		[Description("Block While Dual Wielding %")]
		BlockWhileDualWieldingPct = 22,
		[Description("Block Recovery +%")] BlockRecoveryPosPct = 23,
		[Description("Shield Armour +%")] ShieldArmourPosPct = 24,
		[Description("Damage +%")] DamagePosPct = 25,
		[Description("Spell Damage +%")] SpellDamagePosPct = 26,
		[Description("Physical Damage +%")] PhysicalDamagePosPct = 27,

		[Description("Local Physical Damage +%")]
		LocalPhysicalDamagePosPct = 28,

		[Description("Global Minimum Added Physical Damage")]
		GlobalMinimumAddedPhysicalDamage = 29,

		[Description("Global Maximum Added Physical Damage")]
		GlobalMaximumAddedPhysicalDamage = 30,

		[Description("Attack Minimum Added Physical Damage")]
		AttackMinimumAddedPhysicalDamage = 31,

		[Description("Attack Maximum Added Physical Damage")]
		AttackMaximumAddedPhysicalDamage = 32,

		[Description("Local Minimum Added Physical Damage")]
		LocalMinimumAddedPhysicalDamage = 33,

		[Description("Local Maximum Added Physical Damage")]
		LocalMaximumAddedPhysicalDamage = 34,

		[Description("Physical Axe Damage +%")]
		PhysicalAxeDamagePosPct = 35,

		[Description("Physical Staff Damage +%")]
		PhysicalStaffDamagePosPct = 36,

		[Description("Physical Claw Damage +%")]
		PhysicalClawDamagePosPct = 37,

		[Description("Physical Dagger Damage +%")]
		PhysicalDaggerDamagePosPct = 38,

		[Description("Physical Mace Damage +%")]
		PhysicalMaceDamagePosPct = 39,

		[Description("Physical Bow Damage +%")]
		PhysicalBowDamagePosPct = 40,

		[Description("Physical Sword Damage +%")]
		PhysicalSwordDamagePosPct = 41,

		[Description("Physical Wand Damage +%")]
		PhysicalWandDamagePosPct = 42,
		[Description("Fire Damage +%")] FireDamagePosPct = 43,

		[Description("Global Minimum Added Fire Damage")]
		GlobalMinimumAddedFireDamage = 44,

		[Description("Global Maximum Added Fire Damage")]
		GlobalMaximumAddedFireDamage = 45,

		[Description("Attack Minimum Added Fire Damage")]
		AttackMinimumAddedFireDamage = 46,

		[Description("Attack Maximum Added Fire Damage")]
		AttackMaximumAddedFireDamage = 47,

		[Description("Local Minimum Added Fire Damage")]
		LocalMinimumAddedFireDamage = 48,

		[Description("Local Maximum Added Fire Damage")]
		LocalMaximumAddedFireDamage = 49,
		[Description("Cold Damage +%")] ColdDamagePosPct = 50,

		[Description("Global Minimum Added Cold Damage")]
		GlobalMinimumAddedColdDamage = 51,

		[Description("Global Maximum Added Cold Damage")]
		GlobalMaximumAddedColdDamage = 52,

		[Description("Attack Minimum Added Cold Damage")]
		AttackMinimumAddedColdDamage = 53,

		[Description("Attack Maximum Added Cold Damage")]
		AttackMaximumAddedColdDamage = 54,

		[Description("Local Minimum Added Cold Damage")]
		LocalMinimumAddedColdDamage = 55,

		[Description("Local Maximum Added Cold Damage")]
		LocalMaximumAddedColdDamage = 56,
		[Description("Lightning Damage +%")] LightningDamagePosPct = 57,

		[Description("Global Minimum Added Lightning Damage")]
		GlobalMinimumAddedLightningDamage = 58,

		[Description("Global Maximum Added Lightning Damage")]
		GlobalMaximumAddedLightningDamage = 59,

		[Description("Attack Minimum Added Lightning Damage")]
		AttackMinimumAddedLightningDamage = 60,

		[Description("Attack Maximum Added Lightning Damage")]
		AttackMaximumAddedLightningDamage = 61,

		[Description("Local Minimum Added Lightning Damage")]
		LocalMinimumAddedLightningDamage = 62,

		[Description("Local Maximum Added Lightning Damage")]
		LocalMaximumAddedLightningDamage = 63,
		[Description("Chaos Damage +%")] ChaosDamagePosPct = 64,

		[Description("Global Minimum Added Chaos Damage")]
		GlobalMinimumAddedChaosDamage = 65,

		[Description("Global Maximum Added Chaos Damage")]
		GlobalMaximumAddedChaosDamage = 66,

		[Description("Attack Minimum Added Chaos Damage")]
		AttackMinimumAddedChaosDamage = 67,

		[Description("Attack Maximum Added Chaos Damage")]
		AttackMaximumAddedChaosDamage = 68,

		[Description("Local Minimum Added Chaos Damage")]
		LocalMinimumAddedChaosDamage = 69,

		[Description("Local Maximum Added Chaos Damage")]
		LocalMaximumAddedChaosDamage = 70,
		[Description("Attack Speed +%")] AttackSpeedPosPct = 71,
		[Description("Local Attack Speed +%")] LocalAttackSpeedPosPct = 72,
		[Description("Melee Attack Speed +%")] MeleeAttackSpeedPosPct = 73,

		[Description("Attack Speed While Dual Wielding +%")]
		AttackSpeedWhileDualWieldingPosPct = 74,
		[Description("Axe Attack Speed +%")] AxeAttackSpeedPosPct = 75,
		[Description("Staff Attack Speed +%")] StaffAttackSpeedPosPct = 76,
		[Description("Claw Attack Speed +%")] ClawAttackSpeedPosPct = 77,

		[Description("Dagger Attack Speed +%")]
		DaggerAttackSpeedPosPct = 78,
		[Description("Mace Attack Speed +%")] MaceAttackSpeedPosPct = 79,
		[Description("Bow Attack Speed +%")] BowAttackSpeedPosPct = 80,
		[Description("Sword Attack Speed +%")] SwordAttackSpeedPosPct = 81,
		[Description("Wand Attack Speed +%")] WandAttackSpeedPosPct = 82,

		[Description("Shield Attack Speed +%")]
		ShieldAttackSpeedPosPct = 83,
		[Description("Accuracy Rating")] AccuracyRating = 84,
		[Description("Accuracy Rating +%")] AccuracyRatingPosPct = 85,

		[Description("Accuracy Rating While Dual Wielding +%")]
		AccuracyRatingWhileDualWieldingPosPct = 86,

		[Description("Axe Accuracy Rating +%")]
		AxeAccuracyRatingPosPct = 87,

		[Description("Staff Accuracy Rating +%")]
		StaffAccuracyRatingPosPct = 88,

		[Description("Claw Accuracy Rating +%")]
		ClawAccuracyRatingPosPct = 89,

		[Description("Dagger Accuracy Rating +%")]
		DaggerAccuracyRatingPosPct = 90,

		[Description("Mace Accuracy Rating +%")]
		MaceAccuracyRatingPosPct = 91,

		[Description("Bow Accuracy Rating +%")]
		BowAccuracyRatingPosPct = 92,

		[Description("Sword Accuracy Rating +%")]
		SwordAccuracyRatingPosPct = 93,

		[Description("Wand Accuracy Rating +%")]
		WandAccuracyRatingPosPct = 94,

		[Description("Poison On Critical Strike With Dagger")]
		PoisonOnCriticalStrikeWithDagger = 95,

		[Description("Base Critical Strike Multiplier +")]
		BaseCriticalStrikeMultiplierPos = 96,

		[Description("Critical Strike Multiplier With Dagger +")]
		CriticalStrikeMultiplierWithDaggerPos = 97,

		[Description("Base Self Critical Strike Multiplier -%")]
		BaseSelfCriticalStrikeMultiplierNegPct = 98,

		[Description("Self Critical Strike Multiplier -% Per Endurance Charge")]
		SelfCriticalStrikeMultiplierNegPctPerEnduranceCharge = 99,

		[Description("Old Do Not Use Local Life Leech From Physical Damage %")]
		OldDoNotUseLocalLifeLeechFromPhysicalDamagePct = 100,

		[Description("Old Do Not Use Local Mana Leech From Physical Damage %")]
		OldDoNotUseLocalManaLeechFromPhysicalDamagePct = 101,

		[Description("Old Do Not Use Life Leech From Physical Damage %")]
		OldDoNotUseLifeLeechFromPhysicalDamagePct = 102,

		[Description("Old Do Not Use Mana Leech From Physical Damage %")]
		OldDoNotUseManaLeechFromPhysicalDamagePct = 103,

		[Description("Old Do Not Use Life Leech From Physical Damage With Claw %")]
		OldDoNotUseLifeLeechFromPhysicalDamageWithClawPct = 104,

		[Description("Base Life Gained On Enemy Death")]
		BaseLifeGainedOnEnemyDeath = 105,

		[Description("Life Leech From Any Damage Permyriad")]
		LifeLeechFromAnyDamagePermyriad = 106,

		[Description("Mana Leech From Any Damage Permyriad")]
		ManaLeechFromAnyDamagePermyriad = 107,

		[Description("Base Mana Gained On Enemy Death")]
		BaseManaGainedOnEnemyDeath = 108,

		[Description("Base Stun Threshold Reduction +%")]
		BaseStunThresholdReductionPosPct = 109,

		[Description("While Using Mace Stun Threshold Reduction +%")]
		WhileUsingMaceStunThresholdReductionPosPct = 110,
		[Description("Global Knockback")] GlobalKnockback = 111,
		[Description("Knockback With Bow")] KnockbackWithBow = 112,
		[Description("Knockback With Staff")] KnockbackWithStaff = 113,
		[Description("Knockback With Wand")] KnockbackWithWand = 114,
		[Description("Local Knockback")] LocalKnockback = 115,

		[Description("Maximum Physical Damage Reduction %")]
		MaximumPhysicalDamageReductionPct = 116,

		[Description("Base Physical Damage Reduction Rating")]
		BasePhysicalDamageReductionRating = 117,

		[Description("Physical Damage Reduction Rating +%")]
		PhysicalDamageReductionRatingPosPct = 118,

		[Description("Local Physical Damage Reduction Rating +%")]
		LocalPhysicalDamageReductionRatingPosPct = 119,
		[Description("Base Evasion Rating")] BaseEvasionRating = 120,
		[Description("Evasion Rating +%")] EvasionRatingPosPct = 121,

		[Description("Local Evasion Rating +%")]
		LocalEvasionRatingPosPct = 122,

		[Description("Evasion Rating +% Per Frenzy Charge")]
		EvasionRatingPosPctPerFrenzyCharge = 123,
		[Description("Base Maximum Life")] BaseMaximumLife = 124,
		[Description("Maximum Life +%")] MaximumLifePosPct = 125,

		[Description("Base Life Regeneration Rate Per Minute")]
		BaseLifeRegenerationRatePerMinute = 126,

		[Description("Life Regeneration Rate Per Minute % Per Endurance Charge")]
		LifeRegenerationRatePerMinutePctPerEnduranceCharge = 127,
		[Description("Base Maximum Mana")] BaseMaximumMana = 128,
		[Description("Maximum Mana +%")] MaximumManaPosPct = 129,

		[Description("Mana Regeneration Rate Per Minute %")]
		ManaRegenerationRatePerMinutePct = 130,

		[Description("Mana Regeneration Rate +%")]
		ManaRegenerationRatePosPct = 131,

		[Description("Base Mana Regeneration Rate Per Minute")]
		BaseManaRegenerationRatePerMinute = 132,

		[Description("Mana Regeneration Rate Per Minute % Per Power Charge")]
		ManaRegenerationRatePerMinutePctPerPowerCharge = 133,

		[Description("Base Maximum Energy Shield")]
		BaseMaximumEnergyShield = 134,

		[Description("Maximum Energy Shield +%")]
		MaximumEnergyShieldPosPct = 135,
		[Description("Local Energy Shield")] LocalEnergyShield = 136,

		[Description("Local Energy Shield +%")]
		LocalEnergyShieldPosPct = 137,

		[Description("Energy Shield Recharge Rate Per Minute %")]
		EnergyShieldRechargeRatePerMinutePct = 138,

		[Description("Energy Shield Recharge Rate +%")]
		EnergyShieldRechargeRatePosPct = 139,

		[Description("Energy Shield Delay -%")]
		EnergyShieldDelayNegPct = 140,
		[Description("Cannot Be Damaged")] CannotBeDamaged = 141,

		[Description("Base Resist All Elements %")]
		BaseResistAllElementsPct = 142,

		[Description("Resist All Elements % Per Endurance Charge")]
		ResistAllElementsPctPerEnduranceCharge = 143,

		[Description("Maximum Fire Damage Resistance %")]
		MaximumFireDamageResistancePct = 144,

		[Description("Base Fire Damage Resistance %")]
		BaseFireDamageResistancePct = 145,

		[Description("Maximum Cold Damage Resistance %")]
		MaximumColdDamageResistancePct = 146,

		[Description("Base Cold Damage Resistance %")]
		BaseColdDamageResistancePct = 147,

		[Description("Maximum Lightning Damage Resistance %")]
		MaximumLightningDamageResistancePct = 148,

		[Description("Base Lightning Damage Resistance %")]
		BaseLightningDamageResistancePct = 149,

		[Description("Maximum Chaos Damage Resistance %")]
		MaximumChaosDamageResistancePct = 150,

		[Description("Base Chaos Damage Resistance %")]
		BaseChaosDamageResistancePct = 151,

		[Description("Base Item Found Quantity +%")]
		BaseItemFoundQuantityPosPct = 152,

		[Description("Chest Item Quantity +%")]
		ChestItemQuantityPosPct = 153,

		[Description("Base Item Found Rarity +%")]
		BaseItemFoundRarityPosPct = 154,
		[Description("Chest Item Rarity +%")] ChestItemRarityPosPct = 155,
		[Description("Item Found Quality +%")] ItemFoundQualityPosPct = 156,

		[Description("Item Found Relevancy +%")]
		ItemFoundRelevancyPosPct = 157,
		[Description("Experience Gain +%")] ExperienceGainPosPct = 158,

		[Description("Experience Loss On Death -%")]
		ExperienceLossOnDeathNegPct = 159,

		[Description("Minion Maximum Life +%")]
		MinionMaximumLifePosPct = 160,

		[Description("Base Spectre Maximum Life +%")]
		BaseSpectreMaximumLifePosPct = 161,

		[Description("Base Zombie Maximum Life +%")]
		BaseZombieMaximumLifePosPct = 162,

		[Description("Base Fire Elemental Maximum Life +%")]
		BaseFireElementalMaximumLifePosPct = 163,

		[Description("Base Raven Maximum Life +%")]
		BaseRavenMaximumLifePosPct = 164,

		[Description("Base Number Of Spectres Allowed")]
		BaseNumberOfSpectresAllowed = 165,

		[Description("Base Number Of Zombies Allowed")]
		BaseNumberOfZombiesAllowed = 166,
		[Description("Totem Life +%")] TotemLifePosPct = 167,
		[Description("Totem Range +%")] TotemRangePosPct = 168,
		[Description("Buff Duration +%")] BuffDurationPosPct = 169,
		[Description("Buff Affects Party")] BuffAffectsParty = 170,

		[Description("Buff Party Effect Radius +%")]
		BuffPartyEffectRadiusPosPct = 171,
		[Description("Do Not Chain")] DoNotChain = 172,

		[Description("Number Of Additional Projectiles In Chain")]
		NumberOfAdditionalProjectilesInChain = 173,

		[Description("Number Of Additional Projectiles")]
		NumberOfAdditionalProjectiles = 174,

		[Description("Base Number Of Additional Arrows")]
		BaseNumberOfAdditionalArrows = 175,

		[Description("Base Projectile Speed +%")]
		BaseProjectileSpeedPosPct = 176,
		[Description("Base Arrow Speed +%")] BaseArrowSpeedPosPct = 177,

		[Description("Projectile Homing Magnitude")]
		ProjectileHomingMagnitude = 178,

		[Description("Base Movement Velocity +%")]
		BaseMovementVelocityPosPct = 179,

		[Description("Movement Velocity +% Per Frenzy Charge")]
		MovementVelocityPosPctPerFrenzyCharge = 180,
		[Description("Max Endurance Charges")] MaxEnduranceCharges = 181,
		[Description("Max Frenzy Charges")] MaxFrenzyCharges = 182,
		[Description("Max Power Charges")] MaxPowerCharges = 183,

		[Description("Add Endurance Charge On Critical Strike")]
		AddEnduranceChargeOnCriticalStrike = 184,

		[Description("Add Frenzy Charge On Critical Strike")]
		AddFrenzyChargeOnCriticalStrike = 185,

		[Description("Add Power Charge On Critical Strike")]
		AddPowerChargeOnCriticalStrike = 186,

		[Description("Add Endurance Charge On Skill Hit %")]
		AddEnduranceChargeOnSkillHitPct = 187,

		[Description("Add Frenzy Charge On Skill Hit %")]
		AddFrenzyChargeOnSkillHitPct = 188,

		[Description("Add Power Charge On Skill Hit %")]
		AddPowerChargeOnSkillHitPct = 189,

		[Description("Add Endurance Charge On Enemy Critical Strike")]
		AddEnduranceChargeOnEnemyCriticalStrike = 190,

		[Description("Add Endurance Charge On Status Ailment")]
		AddEnduranceChargeOnStatusAilment = 191,
		[Description("Base Avoid Chill %")] BaseAvoidChillPct = 192,
		[Description("Base Avoid Freeze %")] BaseAvoidFreezePct = 193,
		[Description("Base Avoid Ignite %")] BaseAvoidIgnitePct = 194,
		[Description("Base Avoid Shock %")] BaseAvoidShockPct = 195,
		[Description("Avoid Stun %")] AvoidStunPct = 196,
		[Description("Always Ignite")] AlwaysIgnite = 197,
		[Description("Always Shock")] AlwaysShock = 198,
		[Description("Always Stun")] AlwaysStun = 199,
		[Description("Always Freeze")] AlwaysFreeze = 200,
		[Description("Chill Duration +%")] ChillDurationPosPct = 201,
		[Description("Shock Duration +%")] ShockDurationPosPct = 202,
		[Description("Freeze Duration +%")] FreezeDurationPosPct = 203,
		[Description("Ignite Duration +%")] IgniteDurationPosPct = 204,
		[Description("Stun Duration +%")] StunDurationPosPct = 205,

		[Description("Base Self Chill Duration -%")]
		BaseSelfChillDurationNegPct = 206,

		[Description("Base Self Shock Duration -%")]
		BaseSelfShockDurationNegPct = 207,

		[Description("Base Self Freeze Duration -%")]
		BaseSelfFreezeDurationNegPct = 208,

		[Description("Base Self Ignite Duration -%")]
		BaseSelfIgniteDurationNegPct = 209,

		[Description("Chance Per Second Of Fire Spreading Between Enemies %")]
		ChancePerSecondOfFireSpreadingBetweenEnemiesPct = 210,
		[Description("Burn Damage +%")] BurnDamagePosPct = 211,
		[Description("Active Skill Level +")] ActiveSkillLevelPos = 212,

		[Description("Gem Experience Gain +%")]
		GemExperienceGainPosPct = 213,

		[Description("Skill Area Of Effect +%")]
		SkillAreaOfEffectPosPct = 214,
		[Description("Base Mana Cost -%")] BaseManaCostNegPct = 215,
		[Description("Skill Repeat Count")] SkillRepeatCount = 216,

		[Description("Skill Effect Duration +%")]
		SkillEffectDurationPosPct = 217,
		[Description("Base Cast Speed +%")] BaseCastSpeedPosPct = 218,

		[Description("Cast Speed +% Per Power Charge")]
		CastSpeedPosPctPerPowerCharge = 219,
		[Description("Skill Cooldown -%")] SkillCooldownNegPct = 220,

		[Description("Avoid Interruption While Casting %")]
		AvoidInterruptionWhileCastingPct = 221,

		[Description("Base Attack Repeat Count")]
		BaseAttackRepeatCount = 222,
		[Description("Base Stun Recovery +%")] BaseStunRecoveryPosPct = 223,

		[Description("Stun Recovery +% Per Frenzy Charge")]
		StunRecoveryPosPctPerFrenzyCharge = 224,

		[Description("While Using Sword Reduce Enemy Block %")]
		WhileUsingSwordReduceEnemyBlockPct = 225,
		[Description("Prevent Monster Heal")] PreventMonsterHeal = 226,

		[Description("Prevent Monster Heal Duration +%")]
		PreventMonsterHealDurationPosPct = 227,
		[Description("Chest Trap Defuse %")] ChestTrapDefusePct = 228,

		[Description("Enemies Chill As Unfrozen")]
		EnemiesChillAsUnfrozen = 229,

		[Description("Shocks Enemies That Hit Actor While Actor Is Casting")]
		ShocksEnemiesThatHitActorWhileActorIsCasting = 230,
		[Description("Local Is Max Quality")] LocalIsMaxQuality = 231,

		[Description("Local Disable Gem Experience Gain")]
		LocalDisableGemExperienceGain = 232,

		[Description("Local Gem Experience Gain +%")]
		LocalGemExperienceGainPosPct = 233,
		[Description("Local Extra Socket")] LocalExtraSocket = 234,

		[Description("Local Level Requirement -")]
		LocalLevelRequirementNeg = 235,

		[Description("Local Attribute Requirements +%")]
		LocalAttributeRequirementsPosPct = 236,

		[Description("Local All Sockets Are White")]
		LocalAllSocketsAreWhite = 237,

		[Description("Local Quantity Of Sockets +%")]
		LocalQuantityOfSocketsPosPct = 238,

		[Description("Local Connectivity Of Sockets +%")]
		LocalConnectivityOfSocketsPosPct = 239,
		[Description("Local Gem Level +")] LocalGemLevelPos = 240,
		[Description("Combined Base Block %")] CombinedBaseBlockPct = 241,

		[Description("Physical Damage Reduction Rating")]
		PhysicalDamageReductionRating = 242,
		[Description("Spell Block %")] SpellBlockPct = 243,
		[Description("Movement Velocity +%")] MovementVelocityPosPct = 244,
		[Description("Is Dual Wielding")] IsDualWielding = 245,
		[Description("Maximum Life")] MaximumLife = 246,
		[Description("Maximum Mana")] MaximumMana = 247,
		[Description("Maximum Energy Shield")] MaximumEnergyShield = 248,

		[Description("Life Regeneration Rate Per Minute")]
		LifeRegenerationRatePerMinute = 249,

		[Description("Mana Regeneration Rate Per Minute")]
		ManaRegenerationRatePerMinute = 250,

		[Description("Energy Shield Recharge Rate Per Minute")]
		EnergyShieldRechargeRatePerMinute = 251,

		[Description("Spell Minimum Cold Damage")]
		SpellMinimumColdDamage = 252,

		[Description("Spell Maximum Cold Damage")]
		SpellMaximumColdDamage = 253,

		[Description("Spell Minimum Fire Damage")]
		SpellMinimumFireDamage = 254,

		[Description("Spell Maximum Fire Damage")]
		SpellMaximumFireDamage = 255,

		[Description("Spell Minimum Lightning Damage")]
		SpellMinimumLightningDamage = 256,

		[Description("Spell Minimum Chaos Damage")]
		SpellMinimumChaosDamage = 257,

		[Description("Spell Maximum Lightning Damage")]
		SpellMaximumLightningDamage = 258,

		[Description("Spell Maximum Chaos Damage")]
		SpellMaximumChaosDamage = 259,

		[Description("Spell Minimum Physical Damage")]
		SpellMinimumPhysicalDamage = 260,

		[Description("Spell Maximum Physical Damage")]
		SpellMaximumPhysicalDamage = 261,

		[Description("Main Hand Minimum Cold Damage")]
		MainHandMinimumColdDamage = 262,

		[Description("Main Hand Maximum Cold Damage")]
		MainHandMaximumColdDamage = 263,

		[Description("Off Hand Minimum Cold Damage")]
		OffHandMinimumColdDamage = 264,

		[Description("Off Hand Maximum Cold Damage")]
		OffHandMaximumColdDamage = 265,

		[Description("Main Hand Minimum Fire Damage")]
		MainHandMinimumFireDamage = 266,

		[Description("Main Hand Maximum Fire Damage")]
		MainHandMaximumFireDamage = 267,

		[Description("Off Hand Minimum Fire Damage")]
		OffHandMinimumFireDamage = 268,

		[Description("Off Hand Maximum Fire Damage")]
		OffHandMaximumFireDamage = 269,

		[Description("Main Hand Minimum Lightning Damage")]
		MainHandMinimumLightningDamage = 270,

		[Description("Main Hand Maximum Lightning Damage")]
		MainHandMaximumLightningDamage = 271,

		[Description("Off Hand Minimum Lightning Damage")]
		OffHandMinimumLightningDamage = 272,

		[Description("Off Hand Maximum Lightning Damage")]
		OffHandMaximumLightningDamage = 273,

		[Description("Main Hand Minimum Chaos Damage")]
		MainHandMinimumChaosDamage = 274,

		[Description("Main Hand Maximum Chaos Damage")]
		MainHandMaximumChaosDamage = 275,

		[Description("Off Hand Minimum Chaos Damage")]
		OffHandMinimumChaosDamage = 276,

		[Description("Off Hand Maximum Chaos Damage")]
		OffHandMaximumChaosDamage = 277,

		[Description("Main Hand Minimum Physical Damage")]
		MainHandMinimumPhysicalDamage = 278,

		[Description("Main Hand Maximum Physical Damage")]
		MainHandMaximumPhysicalDamage = 279,

		[Description("Off Hand Minimum Physical Damage")]
		OffHandMinimumPhysicalDamage = 280,

		[Description("Off Hand Maximum Physical Damage")]
		OffHandMaximumPhysicalDamage = 281,
		[Description("Stun Recovery +%")] StunRecoveryPosPct = 282,
		[Description("Evasion Rating")] EvasionRating = 283,

		[Description("Main Hand Reduce Enemy Block %")]
		MainHandReduceEnemyBlockPct = 284,

		[Description("Off Hand Reduce Enemy Block %")]
		OffHandReduceEnemyBlockPct = 285,

		[Description("Main Hand Critical Strike Multiplier +")]
		MainHandCriticalStrikeMultiplierPos = 286,

		[Description("Off Hand Critical Strike Multiplier +")]
		OffHandCriticalStrikeMultiplierPos = 287,

		[Description("Self Critical Strike Multiplier +%")]
		SelfCriticalStrikeMultiplierPosPct = 288,
		[Description("Main Hand Knockback")] MainHandKnockback = 289,
		[Description("Off Hand Knockback")] OffHandKnockback = 290,

		[Description("Main Hand Accuracy Rating")]
		MainHandAccuracyRating = 291,

		[Description("Off Hand Accuracy Rating")]
		OffHandAccuracyRating = 292,

		[Description("Main Hand Attack Speed +%")]
		MainHandAttackSpeedPosPct = 293,

		[Description("Off Hand Attack Speed +%")]
		OffHandAttackSpeedPosPct = 294,
		[Description("Cast Speed +%")] CastSpeedPosPct = 295,

		[Description("Spectre Maximum Life +%")]
		SpectreMaximumLifePosPct = 296,

		[Description("Zombie Maximum Life +%")]
		ZombieMaximumLifePosPct = 297,

		[Description("Fire Elemental Maximum Life +%")]
		FireElementalMaximumLifePosPct = 298,
		[Description("Raven Maximum Life +%")] RavenMaximumLifePosPct = 299,

		[Description("Number Of Additional Arrows")]
		NumberOfAdditionalArrows = 300,
		[Description("Arrow Speed +%")] ArrowSpeedPosPct = 301,

		[Description("Main Hand Stun Threshold Reduction +%")]
		MainHandStunThresholdReductionPosPct = 302,

		[Description("Off Hand Stun Threshold Reduction +%")]
		OffHandStunThresholdReductionPosPct = 303,

		[Description("Main Hand Life Leech From Physical Attack Damage Permyriad")]
		MainHandLifeLeechFromPhysicalAttackDamagePermyriad = 304,

		[Description("Off Hand Life Leech From Physical Attack Damage Permyriad")]
		OffHandLifeLeechFromPhysicalAttackDamagePermyriad = 305,

		[Description("Main Hand Mana Leech From Physical Attack Damage Permyriad")]
		MainHandManaLeechFromPhysicalAttackDamagePermyriad = 306,

		[Description("Off Hand Mana Leech From Physical Attack Damage Permyriad")]
		OffHandManaLeechFromPhysicalAttackDamagePermyriad = 307,

		[Description("Cold Damage Resistance %")]
		ColdDamageResistancePct = 308,

		[Description("Fire Damage Resistance %")]
		FireDamageResistancePct = 309,

		[Description("Lightning Damage Resistance %")]
		LightningDamageResistancePct = 310,

		[Description("Chaos Damage Resistance %")]
		ChaosDamageResistancePct = 311,
		[Description("Resist All Elements %")] ResistAllElementsPct = 312,
		[Description("Trap Duration +%")] TrapDurationPosPct = 313,

		[Description("Trap Trigger Radius +%")]
		TrapTriggerRadiusPosPct = 314,

		[Description("Trap Throwing Speed +%")]
		TrapThrowingSpeedPosPct = 315,

		[Description("Monster Response Time Ms")]
		MonsterResponseTimeMs = 316,

		[Description("Skill Internal Monster Responsiveness +%")]
		SkillInternalMonsterResponsivenessPosPct = 317,

		[Description("Endurance Charges Granted Per One Hundred Nearby Enemies During Endurance Warcry")]
		EnduranceChargesGrantedPerOneHundredNearbyEnemiesDuringEnduranceWarcry = 318,
		[Description("Skill Range +%")] SkillRangePosPct = 319,
		[Description("Gem Level +")] GemLevelPos = 320,
		[Description("Skill Visual Scale +%")] SkillVisualScalePosPct = 321,
		[Description("Imp Variation")] ImpVariation = 322,

		[Description("Main Hand Base Weapon Attack Duration Ms")]
		MainHandBaseWeaponAttackDurationMs = 323,

		[Description("Off Hand Base Weapon Attack Duration Ms")]
		OffHandBaseWeaponAttackDurationMs = 324,

		[Description("Main Hand Minimum Attack Distance")]
		MainHandMinimumAttackDistance = 325,

		[Description("Off Hand Minimum Attack Distance")]
		OffHandMinimumAttackDistance = 326,

		[Description("Main Hand Base Maximum Attack Distance")]
		MainHandBaseMaximumAttackDistance = 327,

		[Description("Off Hand Base Maximum Attack Distance")]
		OffHandBaseMaximumAttackDistance = 328,
		[Description("Main Hand Quality")] MainHandQuality = 329,
		[Description("Off Hand Quality")] OffHandQuality = 330,

		[Description("Base Spell Critical Strike Multiplier +")]
		BaseSpellCriticalStrikeMultiplierPos = 331,

		[Description("Spell Critical Strike Multiplier +")]
		SpellCriticalStrikeMultiplierPos = 332,
		[Description("Is Trap")] IsTrap = 333,

		[Description("Weapon Elemental Damage +%")]
		WeaponElementalDamagePosPct = 334,

		[Description("Staff Stun Duration +%")]
		StaffStunDurationPosPct = 335,

		[Description("Two Handed Melee Physical Damage +%")]
		TwoHandedMeleePhysicalDamagePosPct = 336,

		[Description("Two Handed Melee Stun Duration +%")]
		TwoHandedMeleeStunDurationPosPct = 337,

		[Description("Two Handed Melee Attack Speed +%")]
		TwoHandedMeleeAttackSpeedPosPct = 338,

		[Description("Two Handed Melee Accuracy Rating +%")]
		TwoHandedMeleeAccuracyRatingPosPct = 339,

		[Description("Physical Damage While Dual Wielding +%")]
		PhysicalDamageWhileDualWieldingPosPct = 340,

		[Description("One Handed Melee Physical Damage +%")]
		OneHandedMeleePhysicalDamagePosPct = 341,

		[Description("One Handed Melee Attack Speed +%")]
		OneHandedMeleeAttackSpeedPosPct = 342,

		[Description("One Handed Melee Accuracy Rating +%")]
		OneHandedMeleeAccuracyRatingPosPct = 343,
		[Description("Base Stun Duration +%")] BaseStunDurationPosPct = 344,
		[Description("Bow Stun Duration +%")] BowStunDurationPosPct = 345,

		[Description("Base Life Gain Per Target")]
		BaseLifeGainPerTarget = 346,

		[Description("Corpse Explosion Monster Life %")]
		CorpseExplosionMonsterLifePct = 347,
		[Description("Skill Level")] SkillLevel = 348,
		[Description("Action Speed -%")] ActionSpeedNegPct = 349,
		[Description("Skill Art Variation")] SkillArtVariation = 350,
		[Description("Always Crit")] AlwaysCrit = 351,
		[Description("Damage Infusion %")] DamageInfusionPct = 352,

		[Description("Chaos Damage Taken Per Minute")]
		ChaosDamageTakenPerMinute = 353,

		[Description("Base Fire Damage To Deal Per Minute")]
		BaseFireDamageToDealPerMinute = 354,

		[Description("Add Frenzy Charge On Kill")]
		AddFrenzyChargeOnKill = 355,

		[Description("Base Fire Damage To Deal To Nearby Per Minute")]
		BaseFireDamageToDealToNearbyPerMinute = 356,

		[Description("Base Physical Damage Taken Per Minute")]
		BasePhysicalDamageTakenPerMinute = 357,

		[Description("Spell Minimum Base Lightning Damage Per Power Charge")]
		SpellMinimumBaseLightningDamagePerPowerCharge = 358,

		[Description("Spell Maximum Base Lightning Damage Per Power Charge")]
		SpellMaximumBaseLightningDamagePerPowerCharge = 359,

		[Description("Base Skill Effect Duration")]
		BaseSkillEffectDuration = 360,
		[Description("Skill Effect Duration")] SkillEffectDuration = 361,
		[Description("Buff Effect Duration")] BuffEffectDuration = 362,

		[Description("Buff Effect Duration +% Per Endurance Charge")]
		BuffEffectDurationPosPctPerEnduranceCharge = 363,

		[Description("Local Base Evasion Rating")]
		LocalBaseEvasionRating = 364,

		[Description("Local Base Physical Damage Reduction Rating")]
		LocalBasePhysicalDamageReductionRating = 365,

		[Description("Base Attack Speed +% Per Frenzy Charge")]
		BaseAttackSpeedPosPctPerFrenzyCharge = 366,

		[Description("Physical Damage +% Per Frenzy Charge")]
		PhysicalDamagePosPctPerFrenzyCharge = 367,
		[Description("Is Player")] IsPlayer = 368,
		[Description("Life Per Level")] LifePerLevel = 369,
		[Description("Mana Per Level")] ManaPerLevel = 370,
		[Description("Backstab Damage +%")] BackstabDamagePosPct = 371,

		[Description("Additional Player Bonus Maximum Life +% Final")]
		AdditionalPlayerBonusMaximumLifePosPctFinal = 372,

		[Description("Intermediary Maximum Life")]
		IntermediaryMaximumLife = 373,

		[Description("Local Flask Armour +% While Healing")]
		LocalFlaskArmourPosPctWhileHealing = 374,

		[Description("Local Flask Evasion +% While Healing")]
		LocalFlaskEvasionPosPctWhileHealing = 375,

		[Description("Local Flask Energy Shield +% While Healing")]
		LocalFlaskEnergyShieldPosPctWhileHealing = 376,

		[Description("Local Flask Movement Speed +% While Healing")]
		LocalFlaskMovementSpeedPosPctWhileHealing = 377,

		[Description("Local Flask Stun Recovery +% While Healing")]
		LocalFlaskStunRecoveryPosPctWhileHealing = 378,

		[Description("Local Flask Resistances +% While Healing")]
		LocalFlaskResistancesPosPctWhileHealing = 379,

		[Description("Old Do Not Use Local Flask Life Leech % While Healing")]
		OldDoNotUseLocalFlaskLifeLeechPctWhileHealing = 380,

		[Description("Old Do Not Use Local Flask Mana Leech % While Healing")]
		OldDoNotUseLocalFlaskManaLeechPctWhileHealing = 381,

		[Description("Local Flask Adds Knockback While Healing")]
		LocalFlaskAddsKnockbackWhileHealing = 382,

		[Description("Local Flask Removes % Of Mana Recovery From Life On Use")]
		LocalFlaskRemovesPctOfManaRecoveryFromLifeOnUse = 383,

		[Description("Local Flask Removes % Of Life Recovery From Mana On Use")]
		LocalFlaskRemovesPctOfLifeRecoveryFromManaOnUse = 384,

		[Description("Local Flask Removes % Of Life Recovery From Life On Use")]
		LocalFlaskRemovesPctOfLifeRecoveryFromLifeOnUse = 385,

		[Description("Local Flask Amount To Recover +% When On Low Life")]
		LocalFlaskAmountToRecoverPosPctWhenOnLowLife = 386,

		[Description("Local Flask Recover Instantly When On Low Life")]
		LocalFlaskRecoverInstantlyWhenOnLowLife = 387,

		[Description("Local Flask Recovery Amount % To Recover Instantly")]
		LocalFlaskRecoveryAmountPctToRecoverInstantly = 388,

		[Description("Local Flask Dispels Burning")]
		LocalFlaskDispelsBurning = 389,

		[Description("Local Flask Dispels Freeze And Chill")]
		LocalFlaskDispelsFreezeAndChill = 390,
		[Description("Local Max Charges +%")] LocalMaxChargesPosPct = 391,

		[Description("Local Charges Added +%")]
		LocalChargesAddedPosPct = 392,

		[Description("Local Flask Amount To Recover +%")]
		LocalFlaskAmountToRecoverPosPct = 393,

		[Description("Local Flask Recovers Instantly")]
		LocalFlaskRecoversInstantly = 394,

		[Description("Local Flask Minion Heal %")]
		LocalFlaskMinionHealPct = 395,

		[Description("Local Recharge On Crit")]
		LocalRechargeOnCrit = 396,

		[Description("Local Recharge On Take Crit")]
		LocalRechargeOnTakeCrit = 397,

		[Description("Local Critical Strike Multiplier +")]
		LocalCriticalStrikeMultiplierPos = 398,

		[Description("Local Flask Prevents Death While Healing")]
		LocalFlaskPreventsDeathWhileHealing = 399,
		[Description("Cannot Die")] CannotDie = 400,

		[Description("Flask Life To Recover +%")]
		FlaskLifeToRecoverPosPct = 401,

		[Description("Flask Mana To Recover +%")]
		FlaskManaToRecoverPosPct = 402,

		[Description("Flask Recovery Speed +%")]
		FlaskRecoverySpeedPosPct = 403,
		[Description("Knockback Distance +%")] KnockbackDistancePosPct = 404,
		[Description("Weapon Fire Damage +%")] WeaponFireDamagePosPct = 405,
		[Description("Weapon Cold Damage +%")] WeaponColdDamagePosPct = 406,

		[Description("Weapon Lightning Damage +%")]
		WeaponLightningDamagePosPct = 407,

		[Description("Weapon Chaos Damage +%")]
		WeaponChaosDamagePosPct = 408,

		[Description("Spell Elemental Damage +%")]
		SpellElementalDamagePosPct = 409,

		[Description("Resist All Elements +% While Holding Shield")]
		ResistAllElementsPosPctWhileHoldingShield = 410,
		[Description("Staff Block %")] StaffBlockPct = 411,

		[Description("Attack Minimum Added Lightning Damage With Wand")]
		AttackMinimumAddedLightningDamageWithWand = 412,

		[Description("Attack Maximum Added Lightning Damage With Wand")]
		AttackMaximumAddedLightningDamageWithWand = 413,

		[Description("Attack Minimum Added Fire Damage With Wand")]
		AttackMinimumAddedFireDamageWithWand = 414,

		[Description("Attack Maximum Added Fire Damage With Wand")]
		AttackMaximumAddedFireDamageWithWand = 415,

		[Description("Attack Minimum Added Cold Damage With Wand")]
		AttackMinimumAddedColdDamageWithWand = 416,

		[Description("Attack Maximum Added Cold Damage With Wand")]
		AttackMaximumAddedColdDamageWithWand = 417,

		[Description("Wand Elemental Damage +%")]
		WandElementalDamagePosPct = 418,

		[Description("Chance To Gain Endurance Charge On Block %")]
		ChanceToGainEnduranceChargeOnBlockPct = 419,

		[Description("Endurance Charge Duration +%")]
		EnduranceChargeDurationPosPct = 420,

		[Description("Share Endurance Charges With Party Within Distance")]
		ShareEnduranceChargesWithPartyWithinDistance = 421,

		[Description("Add Frenzy Charge On Enemy Block")]
		AddFrenzyChargeOnEnemyBlock = 422,

		[Description("Base Frenzy Charge Duration +%")]
		BaseFrenzyChargeDurationPosPct = 423,

		[Description("Share Frenzy Charges With Party Within Distance")]
		ShareFrenzyChargesWithPartyWithinDistance = 424,

		[Description("Add Power Charge On Minion Death")]
		AddPowerChargeOnMinionDeath = 425,

		[Description("Skill Area Of Effect +% Per Power Charge")]
		SkillAreaOfEffectPosPctPerPowerCharge = 426,

		[Description("Spell Damage +% Per Power Charge")]
		SpellDamagePosPctPerPowerCharge = 427,

		[Description("Wand Damage +% Per Power Charge")]
		WandDamagePosPctPerPowerCharge = 428,

		[Description("Power Charge Duration +%")]
		PowerChargeDurationPosPct = 429,

		[Description("Share Power Charges With Party Within Distance")]
		SharePowerChargesWithPartyWithinDistance = 430,

		[Description("Minions Explode On Low Life Maximum Life % To Deal")]
		MinionsExplodeOnLowLifeMaximumLifePctToDeal = 431,
		[Description("Totem Duration +%")] TotemDurationPosPct = 432,

		[Description("Buff Effect On Self +%")]
		BuffEffectOnSelfPosPct = 433,

		[Description("Add Power Charge When Interrupted While Casting")]
		AddPowerChargeWhenInterruptedWhileCasting = 434,

		[Description("Add Power Charge When Kill Shocked Enemy")]
		AddPowerChargeWhenKillShockedEnemy = 435,

		[Description("Base Skill Area Of Effect +%")]
		BaseSkillAreaOfEffectPosPct = 436,
		[Description("Casting Spell")] CastingSpell = 437,
		[Description("Avoid Interruption %")] AvoidInterruptionPct = 438,

		[Description("Shocks Enemies That Hit Actor")]
		ShocksEnemiesThatHitActor = 439,

		[Description("Add Power Charge When Interrupted")]
		AddPowerChargeWhenInterrupted = 440,

		[Description("Attack Minimum Base Fire Damage For Elemental Hit")]
		AttackMinimumBaseFireDamageForElementalHit = 441,

		[Description("Attack Maximum Base Fire Damage For Elemental Hit")]
		AttackMaximumBaseFireDamageForElementalHit = 442,

		[Description("Attack Minimum Base Cold Damage For Elemental Hit")]
		AttackMinimumBaseColdDamageForElementalHit = 443,

		[Description("Attack Maximum Base Cold Damage For Elemental Hit")]
		AttackMaximumBaseColdDamageForElementalHit = 444,

		[Description("Attack Minimum Base Lightning Damage For Elemental Hit")]
		AttackMinimumBaseLightningDamageForElementalHit = 445,

		[Description("Attack Maximum Base Lightning Damage For Elemental Hit")]
		AttackMaximumBaseLightningDamageForElementalHit = 446,

		[Description("Additional Physical Damage Reduction %")]
		AdditionalPhysicalDamageReductionPct = 447,

		[Description("Physical Damage Reduction % Per Endurance Charge")]
		PhysicalDamageReductionPctPerEnduranceCharge = 448,

		[Description("Physical Damage % To Add As Fire")]
		PhysicalDamagePctToAddAsFire = 449,

		[Description("Physical Damage % To Add As Cold")]
		PhysicalDamagePctToAddAsCold = 450,

		[Description("Physical Damage % To Add As Lightning")]
		PhysicalDamagePctToAddAsLightning = 451,

		[Description("Physical Damage % To Add As Chaos")]
		PhysicalDamagePctToAddAsChaos = 452,

		[Description("Life Regeneration Rate Per Minute %")]
		LifeRegenerationRatePerMinutePct = 453,

		[Description("Base Chaos Damage % Of Maximum Life Taken Per Minute")]
		BaseChaosDamagePctOfMaximumLifeTakenPerMinute = 454,

		[Description("Base Chaos Damage Taken Per Minute")]
		BaseChaosDamageTakenPerMinute = 455,

		[Description("Add Level X Blood Rage On Kill")]
		AddLevelXBloodRageOnKill = 456,

		[Description("Base Chance To Freeze %")]
		BaseChanceToFreezePct = 457,

		[Description("Display Mana Cost Reduction %")]
		DisplayManaCostReductionPct = 458,

		[Description("Display Minion Monster Level")]
		DisplayMinionMonsterLevel = 459,

		[Description("Display Minion Monster Type")]
		DisplayMinionMonsterType = 460,

		[Description("Monster Slain Flask Charges Granted +%")]
		MonsterSlainFlaskChargesGrantedPosPct = 461,
		[Description("Charges Gained +%")] ChargesGainedPosPct = 462,

		[Description("Global Knockback On Crit")]
		GlobalKnockbackOnCrit = 463,

		[Description("Dummy Stat Display Nothing")]
		DummyStatDisplayNothing = 464,

		[Description("Shield Charge Extra Distance")]
		ShieldChargeExtraDistance = 465,

		[Description("Shield Charge End Slide Distance")]
		ShieldChargeEndSlideDistance = 466,

		[Description("Main Hand Knockback On Crit")]
		MainHandKnockbackOnCrit = 467,

		[Description("Off Hand Knockback On Crit")]
		OffHandKnockbackOnCrit = 468,

		[Description("Knockback On Crit With Staff")]
		KnockbackOnCritWithStaff = 469,

		[Description("Knockback On Crit With Bow")]
		KnockbackOnCritWithBow = 470,

		[Description("Knockback On Crit With Wand")]
		KnockbackOnCritWithWand = 471,

		[Description("Shield Charge Stun Duration +% Maximum")]
		ShieldChargeStunDurationPosPctMaximum = 472,

		[Description("Shield Charge Knockback Distance +% Maximum")]
		ShieldChargeKnockbackDistancePosPctMaximum = 473,

		[Description("Shield Charge Damage +% Maximum")]
		ShieldChargeDamagePosPctMaximum = 474,

		[Description("Spell Minimum Base Fire Damage Per Endurance Charge")]
		SpellMinimumBaseFireDamagePerEnduranceCharge = 475,

		[Description("Spell Maximum Base Fire Damage Per Endurance Charge")]
		SpellMaximumBaseFireDamagePerEnduranceCharge = 476,

		[Description("Spell Minimum Base Cold Damage Per Frenzy Charge")]
		SpellMinimumBaseColdDamagePerFrenzyCharge = 477,

		[Description("Spell Maximum Base Cold Damage Per Frenzy Charge")]
		SpellMaximumBaseColdDamagePerFrenzyCharge = 478,
		[Description("Base Damage Taken +%")] BaseDamageTakenPosPct = 479,
		[Description("Is Shocked")] IsShocked = 480,

		[Description("Base Global Chance To Knockback %")]
		BaseGlobalChanceToKnockbackPct = 481,

		[Description("Main Hand Chance To Knockback %")]
		MainHandChanceToKnockbackPct = 482,

		[Description("Off Hand Chance To Knockback %")]
		OffHandChanceToKnockbackPct = 483,

		[Description("Base Physical Damage % To Convert To Fire")]
		BasePhysicalDamagePctToConvertToFire = 484,

		[Description("Base Physical Damage % To Convert To Cold")]
		BasePhysicalDamagePctToConvertToCold = 485,

		[Description("Base Physical Damage % To Convert To Lightning")]
		BasePhysicalDamagePctToConvertToLightning = 486,

		[Description("Base Physical Damage % To Convert To Chaos")]
		BasePhysicalDamagePctToConvertToChaos = 487,
		[Description("Elemental Damage +%")] ElementalDamagePosPct = 488,

		[Description("Mana Regeneration Rate +% Per Power Charge")]
		ManaRegenerationRatePosPctPerPowerCharge = 489,
		[Description("Minion Damage +%")] MinionDamagePosPct = 490,

		[Description("Shield Maximum Energy Shield +%")]
		ShieldMaximumEnergyShieldPosPct = 491,

		[Description("Melee Physical Damage +%")]
		MeleePhysicalDamagePosPct = 492,
		[Description("Maximum Block %")] MaximumBlockPct = 493,

		[Description("Shield Physical Damage Reduction Rating +%")]
		ShieldPhysicalDamageReductionRatingPosPct = 494,

		[Description("Shield Evasion Rating +%")]
		ShieldEvasionRatingPosPct = 495,

		[Description("Base Shield Evasion Rating")]
		BaseShieldEvasionRating = 496,

		[Description("Base Shield Physical Damage Reduction Rating")]
		BaseShieldPhysicalDamageReductionRating = 497,

		[Description("Base Shield Maximum Energy Shield")]
		BaseShieldMaximumEnergyShield = 498,

		[Description("Ranged Weapon Physical Damage +%")]
		RangedWeaponPhysicalDamagePosPct = 499,
		[Description("Projectile Damage +%")] ProjectileDamagePosPct = 500,
		[Description("Base Is Projectile")] BaseIsProjectile = 501,

		[Description("Base Cast Speed +% Per Frenzy Charge")]
		BaseCastSpeedPosPctPerFrenzyCharge = 502,
		[Description("Sword Accuracy Rating")] SwordAccuracyRating = 503,
		[Description("Bow Accuracy Rating")] BowAccuracyRating = 504,

		[Description("Dagger Accuracy Rating")]
		DaggerAccuracyRating = 505,
		[Description("Axe Accuracy Rating")] AxeAccuracyRating = 506,
		[Description("Claw Accuracy Rating")] ClawAccuracyRating = 507,
		[Description("Staff Accuracy Rating")] StaffAccuracyRating = 508,
		[Description("Mace Accuracy Rating")] MaceAccuracyRating = 509,
		[Description("Wand Accuracy Rating")] WandAccuracyRating = 510,
		[Description("Wall Expand Delay Ms")] WallExpandDelayMs = 511,
		[Description("Wall Maximum Length")] WallMaximumLength = 512,

		[Description("Main Hand Poison On Critical Strike")]
		MainHandPoisonOnCriticalStrike = 513,

		[Description("Off Hand Poison On Critical Strike")]
		OffHandPoisonOnCriticalStrike = 514,

		[Description("Current Viper Strike Orbs")]
		CurrentViperStrikeOrbs = 515,
		[Description("Max Viper Strike Orbs")] MaxViperStrikeOrbs = 516,

		[Description("Monster Chance To Not Flee %")]
		MonsterChanceToNotFleePct = 517,

		[Description("Local Socketed Fire Gem Level +")]
		LocalSocketedFireGemLevelPos = 518,

		[Description("Local Socketed Cold Gem Level +")]
		LocalSocketedColdGemLevelPos = 519,

		[Description("Local Socketed Lightning Gem Level +")]
		LocalSocketedLightningGemLevelPos = 520,

		[Description("Local Socketed Chaos Gem Level +")]
		LocalSocketedChaosGemLevelPos = 521,

		[Description("Local Socketed Projectile Gem Level +")]
		LocalSocketedProjectileGemLevelPos = 522,

		[Description("Local Socketed Spell Gem Level +")]
		LocalSocketedSpellGemLevelPos = 523,

		[Description("Local Socketed Melee Gem Level +")]
		LocalSocketedMeleeGemLevelPos = 524,

		[Description("Local Socketed Bow Gem Level +")]
		LocalSocketedBowGemLevelPos = 525,

		[Description("Local Socketed Minion Gem Level +")]
		LocalSocketedMinionGemLevelPos = 526,

		[Description("Local Socketed Gem Level +")]
		LocalSocketedGemLevelPos = 527,

		[Description("Base Killed Monster Dropped Item Rarity +%")]
		BaseKilledMonsterDroppedItemRarityPosPct = 528,

		[Description("Base Killed Monster Dropped Item Quantity +%")]
		BaseKilledMonsterDroppedItemQuantityPosPct = 529,

		[Description("Current Fuse Arrow Orbs")]
		CurrentFuseArrowOrbs = 530,
		[Description("Max Fuse Arrow Orbs")] MaxFuseArrowOrbs = 531,

		[Description("Minimum Fire Damage Per Fuse Arrow Orb")]
		MinimumFireDamagePerFuseArrowOrb = 532,

		[Description("Maximum Fire Damage Per Fuse Arrow Orb")]
		MaximumFireDamagePerFuseArrowOrb = 533,
		[Description("Buff Time Passed -%")] BuffTimePassedNegPct = 534,

		[Description("Chance To Be Shocked %")]
		ChanceToBeShockedPct = 535,

		[Description("Chance To Be Chilled %")]
		ChanceToBeChilledPct = 536,
		[Description("Chance To Be Frozen %")] ChanceToBeFrozenPct = 537,

		[Description("Chance To Be Ignited %")]
		ChanceToBeIgnitedPct = 538,

		[Description("Life Leech On Any Damage When Hit Permyriad")]
		LifeLeechOnAnyDamageWhenHitPermyriad = 539,

		[Description("Mana Leech On Any Damage When Hit Permyriad")]
		ManaLeechOnAnyDamageWhenHitPermyriad = 540,

		[Description("Chance To Grant Power Charge On Death %")]
		ChanceToGrantPowerChargeOnDeathPct = 541,

		[Description("Physical Damage Dealt Applied To Self %")]
		PhysicalDamageDealtAppliedToSelfPct = 542,

		[Description("Additional Chance To Take Critical Strike %")]
		AdditionalChanceToTakeCriticalStrikePct = 543,

		[Description("Chance To Be Knocked Back %")]
		ChanceToBeKnockedBackPct = 544,
		[Description("Degen Effect +%")] DegenEffectPosPct = 545,

		[Description("Chance To Be Stunned %")]
		ChanceToBeStunnedPct = 546,

		[Description("Chance To Grant Endurance Charge On Death %")]
		ChanceToGrantEnduranceChargeOnDeathPct = 547,

		[Description("Physical Damage Taken +%")]
		PhysicalDamageTakenPosPct = 548,

		[Description("Fuse Arrow Explosion Radius + Per Fuse Arrow Orb")]
		FuseArrowExplosionRadiusPosPerFuseArrowOrb = 549,

		[Description("Base Number Of Skeletons Allowed")]
		BaseNumberOfSkeletonsAllowed = 550,

		[Description("Number Of Melee Skeletons To Summon")]
		NumberOfMeleeSkeletonsToSummon = 551,

		[Description("Main Hand Critical Strike Chance")]
		MainHandCriticalStrikeChance = 552,

		[Description("Off Hand Critical Strike Chance")]
		OffHandCriticalStrikeChance = 553,

		[Description("Spell Critical Strike Chance")]
		SpellCriticalStrikeChance = 554,

		[Description("Local Critical Strike Chance")]
		LocalCriticalStrikeChance = 555,

		[Description("Base Spell Critical Strike Chance")]
		BaseSpellCriticalStrikeChance = 556,

		[Description("Critical Strike Chance +%")]
		CriticalStrikeChancePosPct = 557,

		[Description("Critical Strike Chance +% Per Power Charge")]
		CriticalStrikeChancePosPctPerPowerCharge = 558,

		[Description("Spell Critical Strike Chance +%")]
		SpellCriticalStrikeChancePosPct = 559,

		[Description("Local Critical Strike Chance +%")]
		LocalCriticalStrikeChancePosPct = 560,

		[Description("Dagger Critical Strike Chance +%")]
		DaggerCriticalStrikeChancePosPct = 561,

		[Description("Bow Critical Strike Chance +%")]
		BowCriticalStrikeChancePosPct = 562,

		[Description("Claw Critical Strike Chance +%")]
		ClawCriticalStrikeChancePosPct = 563,

		[Description("Base Life Recovery Per Minute")]
		BaseLifeRecoveryPerMinute = 564,

		[Description("Base Mana Recovery Per Minute")]
		BaseManaRecoveryPerMinute = 565,

		[Description("Maximum Life % To Add To Maximum Energy Shield")]
		MaximumLifePctToAddToMaximumEnergyShield = 566,

		[Description("Physical Damage Taken % To Deal To Attacker")]
		PhysicalDamageTakenPctToDealToAttacker = 567,

		[Description("Elemental Damage Taken % To Deal To Attacker")]
		ElementalDamageTakenPctToDealToAttacker = 568,

		[Description("Base Skeleton Maximum Life +%")]
		BaseSkeletonMaximumLifePosPct = 569,

		[Description("Skeleton Maximum Life +%")]
		SkeletonMaximumLifePosPct = 570,

		[Description("Additional Base Critical Strike Chance")]
		AdditionalBaseCriticalStrikeChance = 571,

		[Description("Accuracy Rating Per Level")]
		AccuracyRatingPerLevel = 572,

		[Description("Evasion Rating Per Level")]
		EvasionRatingPerLevel = 573,
		[Description("Local Accuracy Rating")] LocalAccuracyRating = 574,
		[Description("strength")] Strength = 575,
		[Description("Base Strength")] BaseStrength = 576,
		[Description("Additional Strength")] AdditionalStrength = 577,
		[Description("intelligence")] Intelligence = 578,
		[Description("Base Intelligence")] BaseIntelligence = 579,

		[Description("Additional Intelligence")]
		AdditionalIntelligence = 580,
		[Description("dexterity")] Dexterity = 581,
		[Description("Base Dexterity")] BaseDexterity = 582,
		[Description("Additional Dexterity")] AdditionalDexterity = 583,
		[Description("On Low Life")] OnLowLife = 584,
		[Description("On Full Life")] OnFullLife = 585,

		[Description("Damage +% When On Low Life")]
		DamagePosPctWhenOnLowLife = 586,

		[Description("Damage +% When On Full Life")]
		DamagePosPctWhenOnFullLife = 587,

		[Description("Cast Speed +% When On Low Life")]
		CastSpeedPosPctWhenOnLowLife = 588,

		[Description("Cast Speed +% When On Full Life")]
		CastSpeedPosPctWhenOnFullLife = 589,

		[Description("Attack Speed +% When On Low Life")]
		AttackSpeedPosPctWhenOnLowLife = 590,

		[Description("Attack Speed +% When On Full Life")]
		AttackSpeedPosPctWhenOnFullLife = 591,

		[Description("Kill Enemy On Hit If Under 10% Life")]
		KillEnemyOnHitIfUnder10PctLife = 592,

		[Description("Reduce Enemy Cold Resistance %")]
		ReduceEnemyColdResistancePct = 593,

		[Description("Reduce Enemy Fire Resistance %")]
		ReduceEnemyFireResistancePct = 594,

		[Description("Reduce Enemy Lightning Resistance %")]
		ReduceEnemyLightningResistancePct = 595,

		[Description("Base Reduce Enemy Fire Resistance %")]
		BaseReduceEnemyFireResistancePct = 596,

		[Description("Base Reduce Enemy Cold Resistance %")]
		BaseReduceEnemyColdResistancePct = 597,

		[Description("Base Reduce Enemy Lightning Resistance %")]
		BaseReduceEnemyLightningResistancePct = 598,

		[Description("Reduce Enemy Elemental Resistance %")]
		ReduceEnemyElementalResistancePct = 599,

		[Description("Reduce Enemy Chaos Resistance %")]
		ReduceEnemyChaosResistancePct = 600,

		[Description("Life Leech On Physical Damage When Hit By Attack %")]
		LifeLeechOnPhysicalDamageWhenHitByAttackPct = 601,

		[Description("Mana Leech On Physical Damage When Hit By Attack %")]
		ManaLeechOnPhysicalDamageWhenHitByAttackPct = 602,

		[Description("Add Endurance Charge On Melee Critical Strike")]
		AddEnduranceChargeOnMeleeCriticalStrike = 603,

		[Description("Add Frenzy Charge On Melee Critical Strike")]
		AddFrenzyChargeOnMeleeCriticalStrike = 604,

		[Description("Add Power Charge On Melee Critical Strike")]
		AddPowerChargeOnMeleeCriticalStrike = 605,
		[Description("Life Leech Speed +%")] LifeLeechSpeedPosPct = 606,
		[Description("Mana Leech Speed +%")] ManaLeechSpeedPosPct = 607,

		[Description("Additional All Attributes")]
		AdditionalAllAttributes = 608,

		[Description("Base Critical Strike Multiplier")]
		BaseCriticalStrikeMultiplier = 609,

		[Description("Main Hand Critical Strike Multiplier")]
		MainHandCriticalStrikeMultiplier = 610,

		[Description("Off Hand Critical Strike Multiplier")]
		OffHandCriticalStrikeMultiplier = 611,

		[Description("Spell Critical Strike Multiplier")]
		SpellCriticalStrikeMultiplier = 612,

		[Description("Base Cold Damage % To Convert To Fire")]
		BaseColdDamagePctToConvertToFire = 613,

		[Description("Base Chance To Ignite %")]
		BaseChanceToIgnitePct = 614,

		[Description("Fire Storm Fireball Delay Ms")]
		FireStormFireballDelayMs = 615,

		[Description("One Handed Melee Critical Strike Chance +%")]
		OneHandedMeleeCriticalStrikeChancePosPct = 616,

		[Description("Axe Critical Strike Multiplier +")]
		AxeCriticalStrikeMultiplierPos = 617,

		[Description("Sword Critical Strike Multiplier +")]
		SwordCriticalStrikeMultiplierPos = 618,

		[Description("Bow Critical Strike Multiplier +")]
		BowCriticalStrikeMultiplierPos = 619,

		[Description("Minion Movement Speed +%")]
		MinionMovementSpeedPosPct = 620,
		[Description("Is Area Damage")] IsAreaDamage = 621,
		[Description("Area Damage +%")] AreaDamagePosPct = 622,

		[Description("Avoid All Elemental Status %")]
		AvoidAllElementalStatusPct = 623,

		[Description("Self Elemental Status Duration -%")]
		SelfElementalStatusDurationNegPct = 624,

		[Description("One Handed Melee Critical Strike Multiplier +")]
		OneHandedMeleeCriticalStrikeMultiplierPos = 625,

		[Description("Two Handed Melee Critical Strike Chance +%")]
		TwoHandedMeleeCriticalStrikeChancePosPct = 626,

		[Description("Two Handed Melee Critical Strike Multiplier +")]
		TwoHandedMeleeCriticalStrikeMultiplierPos = 627,

		[Description("Shield Charge Continue Past Target")]
		ShieldChargeContinuePastTarget = 628,
		[Description("Avoid Chill %")] AvoidChillPct = 629,
		[Description("Avoid Freeze %")] AvoidFreezePct = 630,
		[Description("Avoid Ignite %")] AvoidIgnitePct = 631,
		[Description("Avoid Shock %")] AvoidShockPct = 632,

		[Description("Self Chill Duration -%")]
		SelfChillDurationNegPct = 633,

		[Description("Self Shock Duration -%")]
		SelfShockDurationNegPct = 634,

		[Description("Self Freeze Duration -%")]
		SelfFreezeDurationNegPct = 635,

		[Description("Self Ignite Duration -%")]
		SelfIgniteDurationNegPct = 636,

		[Description("Active Skill Damage +% Final")]
		ActiveSkillDamagePosPctFinal = 637,

		[Description("Phase Run Melee Physical Damage +% Final")]
		PhaseRunMeleePhysicalDamagePosPctFinal = 638,

		[Description("Active Skill Physical Damage +% Final")]
		ActiveSkillPhysicalDamagePosPctFinal = 639,

		[Description("Active Skill Elemental Damage +% Final")]
		ActiveSkillElementalDamagePosPctFinal = 640,

		[Description("Active Skill Fire Damage +% Final")]
		ActiveSkillFireDamagePosPctFinal = 641,

		[Description("Active Skill Cold Damage +% Final")]
		ActiveSkillColdDamagePosPctFinal = 642,

		[Description("Active Skill Lightning Damage +% Final")]
		ActiveSkillLightningDamagePosPctFinal = 643,

		[Description("Active Skill Chaos Damage +% Final")]
		ActiveSkillChaosDamagePosPctFinal = 644,

		[Description("Support Melee Physical Damage +% Final")]
		SupportMeleePhysicalDamagePosPctFinal = 645,

		[Description("Support Weapon Elemental Damage +% Final")]
		SupportWeaponElementalDamagePosPctFinal = 646,

		[Description("Support Area Concentrate Area Damage +% Final")]
		SupportAreaConcentrateAreaDamagePosPctFinal = 647,

		[Description("Active Skill Attack Damage +% Final")]
		ActiveSkillAttackDamagePosPctFinal = 648,

		[Description("Active Skill Spell Damage +% Final")]
		ActiveSkillSpellDamagePosPctFinal = 649,

		[Description("Support Multiple Projectile Damage +% Final")]
		SupportMultipleProjectileDamagePosPctFinal = 650,

		[Description("Enfeeble Damage +% Final")]
		EnfeebleDamagePosPctFinal = 651,

		[Description("Main Hand Weapon Minimum Physical Damage")]
		MainHandWeaponMinimumPhysicalDamage = 652,

		[Description("Main Hand Weapon Maximum Physical Damage")]
		MainHandWeaponMaximumPhysicalDamage = 653,

		[Description("Off Hand Weapon Minimum Physical Damage")]
		OffHandWeaponMinimumPhysicalDamage = 654,

		[Description("Off Hand Weapon Maximum Physical Damage")]
		OffHandWeaponMaximumPhysicalDamage = 655,

		[Description("Active Skill Minion Life +% Final")]
		ActiveSkillMinionLifePosPctFinal = 656,

		[Description("Active Skill Minion Damage +% Final")]
		ActiveSkillMinionDamagePosPctFinal = 657,

		[Description("Max Life +% Final For Minion")]
		MaxLifePosPctFinalForMinion = 658,

		[Description("Damage +% Final For Minion")]
		DamagePosPctFinalForMinion = 659,
		[Description("Strength Per Level")] StrengthPerLevel = 660,
		[Description("Dexterity Per Level")] DexterityPerLevel = 661,

		[Description("Intelligence Per Level")]
		IntelligencePerLevel = 662,

		[Description("Critical Strike Chance While Dual Wielding +%")]
		CriticalStrikeChanceWhileDualWieldingPosPct = 663,

		[Description("Critical Strike Multiplier While Dual Wielding +")]
		CriticalStrikeMultiplierWhileDualWieldingPos = 664,

		[Description("Mace Critical Strike Multiplier +")]
		MaceCriticalStrikeMultiplierPos = 665,

		[Description("Base Chance To Shock %")]
		BaseChanceToShockPct = 666,

		[Description("Spell Maximum Action Distance +%")]
		SpellMaximumActionDistancePosPct = 667,

		[Description("Local Accuracy Rating +%")]
		LocalAccuracyRatingPosPct = 668,

		[Description("Display Skill Increased Item Quantity +%")]
		DisplaySkillIncreasedItemQuantityPosPct = 669,

		[Description("Display Skill Increased Item Rarity +%")]
		DisplaySkillIncreasedItemRarityPosPct = 670,

		[Description("Wand Physical Damage % To Add As Fire")]
		WandPhysicalDamagePctToAddAsFire = 671,

		[Description("Wand Physical Damage % To Add As Cold")]
		WandPhysicalDamagePctToAddAsCold = 672,

		[Description("Wand Physical Damage % To Add As Lightning")]
		WandPhysicalDamagePctToAddAsLightning = 673,

		[Description("Main Hand Minimum Total Damage")]
		MainHandMinimumTotalDamage = 674,

		[Description("Main Hand Maximum Total Damage")]
		MainHandMaximumTotalDamage = 675,

		[Description("Off Hand Minimum Total Damage")]
		OffHandMinimumTotalDamage = 676,

		[Description("Off Hand Maximum Total Damage")]
		OffHandMaximumTotalDamage = 677,

		[Description("Spell Minimum Total Damage")]
		SpellMinimumTotalDamage = 678,

		[Description("Spell Maximum Total Damage")]
		SpellMaximumTotalDamage = 679,

		[Description("Main Hand Chance To Hit %")]
		MainHandChanceToHitPct = 680,

		[Description("Off Hand Chance To Hit %")]
		OffHandChanceToHitPct = 681,

		[Description("Hundred Times Attacks Per Second")]
		HundredTimesAttacksPerSecond = 682,

		[Description("Hundred Times Damage Per Second")]
		HundredTimesDamagePerSecond = 683,
		[Description("Chance To Evade %")] ChanceToEvadePct = 684,

		[Description("Base Spell Cast Time Ms")]
		BaseSpellCastTimeMs = 685,

		[Description("Hundred Times Casts Per Second")]
		HundredTimesCastsPerSecond = 686,

		[Description("Global Hit Causes Monster Flee %")]
		GlobalHitCausesMonsterFleePct = 687,

		[Description("Local Hit Causes Monster Flee %")]
		LocalHitCausesMonsterFleePct = 688,

		[Description("Main Hand Hit Causes Monster Flee %")]
		MainHandHitCausesMonsterFleePct = 689,

		[Description("Off Hand Hit Causes Monster Flee %")]
		OffHandHitCausesMonsterFleePct = 690,
		[Description("Global Always Hit")] GlobalAlwaysHit = 691,
		[Description("Main Hand Always Hit")] MainHandAlwaysHit = 692,
		[Description("Off Hand Always Hit")] OffHandAlwaysHit = 693,
		[Description("Local Always Hit")] LocalAlwaysHit = 694,

		[Description("Explode On Low Life % Maximum Life To Deal")]
		ExplodeOnLowLifePctMaximumLifeToDeal = 695,
		[Description("Curses Never Expire")] CursesNeverExpire = 696,
		[Description("Chance To Dodge %")] ChanceToDodgePct = 697,

		[Description("No Physical Damage Reduction Rating")]
		NoPhysicalDamageReductionRating = 698,
		[Description("No Energy Shield")] NoEnergyShield = 699,

		[Description("Keystone Iron Reflexes")]
		KeystoneIronReflexes = 700,
		[Description("Global Cannot Crit")] GlobalCannotCrit = 701,

		[Description("Convert All Physical Damage To Fire")]
		ConvertAllPhysicalDamageToFire = 702,
		[Description("Base Cannot Evade")] BaseCannotEvade = 703,
		[Description("Chaos Immunity")] ChaosImmunity = 704,

		[Description("Keystone Chaos Inoculation")]
		KeystoneChaosInoculation = 705,

		[Description("Mana % To Add As Energy Shield")]
		ManaPctToAddAsEnergyShield = 706,
		[Description("No Mana")] NoMana = 707,

		[Description("Base Use Life In Place Of Mana")]
		BaseUseLifeInPlaceOfMana = 708,

		[Description("Base Cannot Be Stunned")]
		BaseCannotBeStunned = 709,

		[Description("Ignore Armour Movement Penalties")]
		IgnoreArmourMovementPenalties = 710,

		[Description("Base Buff Duration Ms + Per Endurance Charge")]
		BaseBuffDurationMsPosPerEnduranceCharge = 711,

		[Description("Secondary Minimum Physical Damage")]
		SecondaryMinimumPhysicalDamage = 712,

		[Description("Secondary Maximum Physical Damage")]
		SecondaryMaximumPhysicalDamage = 713,

		[Description("Secondary Minimum Cold Damage")]
		SecondaryMinimumColdDamage = 714,

		[Description("Secondary Maximum Cold Damage")]
		SecondaryMaximumColdDamage = 715,

		[Description("Secondary Minimum Fire Damage")]
		SecondaryMinimumFireDamage = 716,

		[Description("Secondary Maximum Fire Damage")]
		SecondaryMaximumFireDamage = 717,

		[Description("Secondary Minimum Lightning Damage")]
		SecondaryMinimumLightningDamage = 718,

		[Description("Secondary Maximum Lightning Damage")]
		SecondaryMaximumLightningDamage = 719,

		[Description("Secondary Minimum Chaos Damage")]
		SecondaryMinimumChaosDamage = 720,

		[Description("Secondary Maximum Chaos Damage")]
		SecondaryMaximumChaosDamage = 721,

		[Description("Secondary Critical Strike Multiplier")]
		SecondaryCriticalStrikeMultiplier = 722,

		[Description("Secondary Critical Strike Chance")]
		SecondaryCriticalStrikeChance = 723,
		[Description("Physical Immunity")] PhysicalImmunity = 724,
		[Description("Base Actor Scale +%")] BaseActorScalePosPct = 725,

		[Description("Display Estimated Physical Damage Reduciton %")]
		DisplayEstimatedPhysicalDamageReducitonPct = 726,
		[Description("Curse Count")] CurseCount = 727,

		[Description("Number Of Additional Curses Allowed")]
		NumberOfAdditionalCursesAllowed = 728,
		[Description("Melee Knockback")] MeleeKnockback = 729,

		[Description("Total Number Of Projectiles To Fire")]
		TotalNumberOfProjectilesToFire = 730,

		[Description("Total Number Of Arrows To Fire")]
		TotalNumberOfArrowsToFire = 731,

		[Description("Number Of Zombies Allowed")]
		NumberOfZombiesAllowed = 732,

		[Description("Number Of Spectres Allowed")]
		NumberOfSpectresAllowed = 733,

		[Description("Number Of Skeletons Allowed")]
		NumberOfSkeletonsAllowed = 734,

		[Description("From Armour Movement Speed +%")]
		FromArmourMovementSpeedPosPct = 735,

		[Description("Active Skill Minion Energy Shield +% Final")]
		ActiveSkillMinionEnergyShieldPosPctFinal = 736,

		[Description("Energy Shield +% Final For Minion")]
		EnergyShieldPosPctFinalForMinion = 737,

		[Description("Projectile Damage Taken +%")]
		ProjectileDamageTakenPosPct = 738,

		[Description("Fire Shield Damage Threshold")]
		FireShieldDamageThreshold = 739,

		[Description("Support Multiple Projectiles Critical Strike Chance +% Final")]
		SupportMultipleProjectilesCriticalStrikeChancePosPctFinal = 740,

		[Description("Display Monster Wealth Mod")]
		DisplayMonsterWealthMod = 741,

		[Description("Local Armour And Energy Shield +%")]
		LocalArmourAndEnergyShieldPosPct = 742,

		[Description("Local Armour And Evasion +%")]
		LocalArmourAndEvasionPosPct = 743,

		[Description("Local Evasion And Energy Shield +%")]
		LocalEvasionAndEnergyShieldPosPct = 744,

		[Description("Local Armour And Evasion And Energy Shield +%")]
		LocalArmourAndEvasionAndEnergyShieldPosPct = 745,
		[Description("Flask Charges Used +%")] FlaskChargesUsedPosPct = 746,
		[Description("Flask Duration +%")] FlaskDurationPosPct = 747,

		[Description("Flask Life Recovery Rate +%")]
		FlaskLifeRecoveryRatePosPct = 748,

		[Description("Flask Mana Recovery Rate +%")]
		FlaskManaRecoveryRatePosPct = 749,

		[Description("Minions Get Shield Stats Instead Of You")]
		MinionsGetShieldStatsInsteadOfYou = 750,

		[Description("Cannot Resist Cold Damage")]
		CannotResistColdDamage = 751,

		[Description("Add Power Charge On Kill")]
		AddPowerChargeOnKill = 752,
		[Description("Immune To Curses")] ImmuneToCurses = 753,

		[Description("Monster Grants Frenzy Charges To Allies Within Distance On Death")]
		MonsterGrantsFrenzyChargesToAlliesWithinDistanceOnDeath = 754,

		[Description("Dual Wield Or Shield Block %")]
		DualWieldOrShieldBlockPct = 755,

		[Description("Gain Frenzy Charge For Each Quarter Life Removed")]
		GainFrenzyChargeForEachQuarterLifeRemoved = 756,

		[Description("Monster Life Thresholds Passed")]
		MonsterLifeThresholdsPassed = 757,

		[Description("Chaos Inoculation Keystone Energy Shield +% Final")]
		ChaosInoculationKeystoneEnergyShieldPosPctFinal = 758,

		[Description("Pain Attunement Keystone Spell Damage +% Final")]
		PainAttunementKeystoneSpellDamagePosPctFinal = 759,

		[Description("Keystone Elemental Equilibrium")]
		KeystoneElementalEquilibrium = 760,

		[Description("Evasion Rating + When On Low Life")]
		EvasionRatingPosWhenOnLowLife = 761,

		[Description("Life Regeneration Rate Per Minute % When On Low Life")]
		LifeRegenerationRatePerMinutePctWhenOnLowLife = 762,

		[Description("Local Socketed Strength Gem Level +")]
		LocalSocketedStrengthGemLevelPos = 763,

		[Description("Local Socketed Dexterity Gem Level +")]
		LocalSocketedDexterityGemLevelPos = 764,

		[Description("Local Socketed Intelligence Gem Level +")]
		LocalSocketedIntelligenceGemLevelPos = 765,

		[Description("Maximum Physical Damage To Return To Melee Attacker")]
		MaximumPhysicalDamageToReturnToMeleeAttacker = 766,

		[Description("Maximum Fire Damage To Return To Melee Attacker")]
		MaximumFireDamageToReturnToMeleeAttacker = 767,

		[Description("Maximum Cold Damage To Return To Melee Attacker")]
		MaximumColdDamageToReturnToMeleeAttacker = 768,

		[Description("Maximum Lightning Damage To Return To Melee Attacker")]
		MaximumLightningDamageToReturnToMeleeAttacker = 769,

		[Description("Maximum Chaos Damage To Return To Melee Attacker")]
		MaximumChaosDamageToReturnToMeleeAttacker = 770,

		[Description("Minimum Physical Damage To Return To Melee Attacker")]
		MinimumPhysicalDamageToReturnToMeleeAttacker = 771,

		[Description("Minimum Fire Damage To Return To Melee Attacker")]
		MinimumFireDamageToReturnToMeleeAttacker = 772,

		[Description("Minimum Cold Damage To Return To Melee Attacker")]
		MinimumColdDamageToReturnToMeleeAttacker = 773,

		[Description("Minimum Lightning Damage To Return To Melee Attacker")]
		MinimumLightningDamageToReturnToMeleeAttacker = 774,

		[Description("Minimum Chaos Damage To Return To Melee Attacker")]
		MinimumChaosDamageToReturnToMeleeAttacker = 775,

		[Description("Physical Damage Taken When Hit By Attack")]
		PhysicalDamageTakenWhenHitByAttack = 776,

		[Description("Fire Damage Taken When Hit By Attack")]
		FireDamageTakenWhenHitByAttack = 777,

		[Description("Cold Damage Taken When Hit By Attack")]
		ColdDamageTakenWhenHitByAttack = 778,

		[Description("Lightning Damage Taken When Hit By Attack")]
		LightningDamageTakenWhenHitByAttack = 779,

		[Description("Chaos Damage Taken When Hit By Attack")]
		ChaosDamageTakenWhenHitByAttack = 780,

		[Description("Mana Cost +% When On Low Life")]
		ManaCostPosPctWhenOnLowLife = 781,

		[Description("Elemental Resistance % When On Low Life")]
		ElementalResistancePctWhenOnLowLife = 782,
		[Description("Local Has No Sockets")] LocalHasNoSockets = 783,

		[Description("Local All Sockets Linked")]
		LocalAllSocketsLinked = 784,

		[Description("Movement Velocity +% When On Low Life")]
		MovementVelocityPosPctWhenOnLowLife = 785,
		[Description("Mana Cost +%")] ManaCostPosPct = 786,
		[Description("Keystone Acrobatics")] KeystoneAcrobatics = 787,

		[Description("Keystone Pain Attunement")]
		KeystonePainAttunement = 788,

		[Description("Item Found Quantity +% When On Low Life")]
		ItemFoundQuantityPosPctWhenOnLowLife = 789,

		[Description("Item Found Rarity +% When On Low Life")]
		ItemFoundRarityPosPctWhenOnLowLife = 790,

		[Description("Item Found Quantity +%")]
		ItemFoundQuantityPosPct = 791,
		[Description("Item Found Rarity +%")] ItemFoundRarityPosPct = 792,

		[Description("Active Skill Projectile Damage +% Final")]
		ActiveSkillProjectileDamagePosPctFinal = 793,

		[Description("Bonus Damage +% From Strength")]
		BonusDamagePosPctFromStrength = 794,

		[Description("Keystone Strong Bowman")]
		KeystoneStrongBowman = 795,

		[Description("Monster Projectile Variation")]
		MonsterProjectileVariation = 796,
		[Description("Keystone Point Blank")] KeystonePointBlank = 797,

		[Description("Damage +% Final From Distance")]
		DamagePosPctFinalFromDistance = 798,
		[Description("Keystone Conduit")] KeystoneConduit = 799,

		[Description("Movement Velocity +% When On Full Life")]
		MovementVelocityPosPctWhenOnFullLife = 800,

		[Description("Show Number Of Projectiles")]
		ShowNumberOfProjectiles = 801,

		[Description("Lightning Arrow Maximum Number Of Extra Targets")]
		LightningArrowMaximumNumberOfExtraTargets = 802,

		[Description("Main Hand Local Physical Damage +%")]
		MainHandLocalPhysicalDamagePosPct = 803,

		[Description("Main Hand Local Minimum Added Physical Damage")]
		MainHandLocalMinimumAddedPhysicalDamage = 804,

		[Description("Main Hand Local Maximum Added Physical Damage")]
		MainHandLocalMaximumAddedPhysicalDamage = 805,

		[Description("Main Hand Local Minimum Added Fire Damage")]
		MainHandLocalMinimumAddedFireDamage = 806,

		[Description("Main Hand Local Maximum Added Fire Damage")]
		MainHandLocalMaximumAddedFireDamage = 807,

		[Description("Main Hand Local Minimum Added Cold Damage")]
		MainHandLocalMinimumAddedColdDamage = 808,

		[Description("Main Hand Local Maximum Added Cold Damage")]
		MainHandLocalMaximumAddedColdDamage = 809,

		[Description("Main Hand Local Minimum Added Lightning Damage")]
		MainHandLocalMinimumAddedLightningDamage = 810,

		[Description("Main Hand Local Maximum Added Lightning Damage")]
		MainHandLocalMaximumAddedLightningDamage = 811,

		[Description("Main Hand Local Minimum Added Chaos Damage")]
		MainHandLocalMinimumAddedChaosDamage = 812,

		[Description("Main Hand Local Maximum Added Chaos Damage")]
		MainHandLocalMaximumAddedChaosDamage = 813,

		[Description("Main Hand Local Attack Speed +%")]
		MainHandLocalAttackSpeedPosPct = 814,

		[Description("Old Do Not Use Main Hand Local Life Leech From Physical Damage %")]
		OldDoNotUseMainHandLocalLifeLeechFromPhysicalDamagePct = 815,

		[Description("Old Do Not Use Main Hand Local Mana Leech From Physical Damage %")]
		OldDoNotUseMainHandLocalManaLeechFromPhysicalDamagePct = 816,

		[Description("Main Hand Local Knockback")]
		MainHandLocalKnockback = 817,

		[Description("Main Hand Local Critical Strike Multiplier +")]
		MainHandLocalCriticalStrikeMultiplierPos = 818,

		[Description("Main Hand Local Critical Strike Chance")]
		MainHandLocalCriticalStrikeChance = 819,

		[Description("Main Hand Local Critical Strike Chance +%")]
		MainHandLocalCriticalStrikeChancePosPct = 820,

		[Description("Main Hand Local Accuracy Rating")]
		MainHandLocalAccuracyRating = 821,

		[Description("Main Hand Local Accuracy Rating +%")]
		MainHandLocalAccuracyRatingPosPct = 822,

		[Description("Main Hand Local Hit Causes Monster Flee %")]
		MainHandLocalHitCausesMonsterFleePct = 823,

		[Description("Main Hand Local Always Hit")]
		MainHandLocalAlwaysHit = 824,

		[Description("Off Hand Local Physical Damage +%")]
		OffHandLocalPhysicalDamagePosPct = 825,

		[Description("Off Hand Local Minimum Added Physical Damage")]
		OffHandLocalMinimumAddedPhysicalDamage = 826,

		[Description("Off Hand Local Maximum Added Physical Damage")]
		OffHandLocalMaximumAddedPhysicalDamage = 827,

		[Description("Off Hand Local Minimum Added Fire Damage")]
		OffHandLocalMinimumAddedFireDamage = 828,

		[Description("Off Hand Local Maximum Added Fire Damage")]
		OffHandLocalMaximumAddedFireDamage = 829,

		[Description("Off Hand Local Minimum Added Cold Damage")]
		OffHandLocalMinimumAddedColdDamage = 830,

		[Description("Off Hand Local Maximum Added Cold Damage")]
		OffHandLocalMaximumAddedColdDamage = 831,

		[Description("Off Hand Local Minimum Added Lightning Damage")]
		OffHandLocalMinimumAddedLightningDamage = 832,

		[Description("Off Hand Local Maximum Added Lightning Damage")]
		OffHandLocalMaximumAddedLightningDamage = 833,

		[Description("Off Hand Local Minimum Added Chaos Damage")]
		OffHandLocalMinimumAddedChaosDamage = 834,

		[Description("Off Hand Local Maximum Added Chaos Damage")]
		OffHandLocalMaximumAddedChaosDamage = 835,

		[Description("Off Hand Local Attack Speed +%")]
		OffHandLocalAttackSpeedPosPct = 836,

		[Description("Old Do Not Use Off Hand Local Life Leech From Physical Damage %")]
		OldDoNotUseOffHandLocalLifeLeechFromPhysicalDamagePct = 837,

		[Description("Old Do Not Use Off Hand Local Mana Leech From Physical Damage %")]
		OldDoNotUseOffHandLocalManaLeechFromPhysicalDamagePct = 838,

		[Description("Off Hand Local Knockback")]
		OffHandLocalKnockback = 839,

		[Description("Off Hand Local Critical Strike Multiplier +")]
		OffHandLocalCriticalStrikeMultiplierPos = 840,

		[Description("Off Hand Local Critical Strike Chance")]
		OffHandLocalCriticalStrikeChance = 841,

		[Description("Off Hand Local Critical Strike Chance +%")]
		OffHandLocalCriticalStrikeChancePosPct = 842,

		[Description("Off Hand Local Accuracy Rating")]
		OffHandLocalAccuracyRating = 843,

		[Description("Off Hand Local Accuracy Rating +%")]
		OffHandLocalAccuracyRatingPosPct = 844,

		[Description("Off Hand Local Hit Causes Monster Flee %")]
		OffHandLocalHitCausesMonsterFleePct = 845,

		[Description("Off Hand Local Always Hit")]
		OffHandLocalAlwaysHit = 846,

		[Description("Acrobatics Additional Chance To Dodge %")]
		AcrobaticsAdditionalChanceToDodgePct = 847,

		[Description("Keystone Phase Acrobatics")]
		KeystonePhaseAcrobatics = 848,

		[Description("Chance To Dodge Spells %")]
		ChanceToDodgeSpellsPct = 849,

		[Description("Phase Acrobatics Additional Chance To Dodge Spells %")]
		PhaseAcrobaticsAdditionalChanceToDodgeSpellsPct = 850,

		[Description("Number Of Inca Minions Allowed")]
		NumberOfIncaMinionsAllowed = 851,
		[Description("Curse Cast Speed +%")] CurseCastSpeedPosPct = 852,

		[Description("Chance To Evade Projectile Attacks +%")]
		ChanceToEvadeProjectileAttacksPosPct = 853,

		[Description("Keystone Projectile Evasion")]
		KeystoneProjectileEvasion = 854,

		[Description("Elemental Status Effect Aura Radius")]
		ElementalStatusEffectAuraRadius = 855,

		[Description("Support Lesser Multiple Projectile Damage +% Final")]
		SupportLesserMultipleProjectileDamagePosPctFinal = 856,

		[Description("Use Life In Place Of Mana")]
		UseLifeInPlaceOfMana = 857,
		[Description("Keystone Blood Magic")] KeystoneBloodMagic = 858,

		[Description("Base Mana Reservation +%")]
		BaseManaReservationPosPct = 859,

		[Description("Base Aura Area Of Effect +%")]
		BaseAuraAreaOfEffectPosPct = 860,

		[Description("Physical Attack Damage Taken +")]
		PhysicalAttackDamageTakenPos = 861,

		[Description("Physical Ranged Attack Damage Taken +")]
		PhysicalRangedAttackDamageTakenPos = 862,

		[Description("Old Do Not Use Spell Block % While On Low Life From Assumed Block Value")]
		OldDoNotUseSpellBlockPctWhileOnLowLifeFromAssumedBlockValue = 863,

		[Description("Display What Elemental Proliferation Does")]
		DisplayWhatElementalProliferationDoes = 864,
		[Description("Skill Can Fire Arrows")] SkillCanFireArrows = 865,

		[Description("Skill Can Fire Wand Projectiles")]
		SkillCanFireWandProjectiles = 866,

		[Description("Local Additional Block Chance %")]
		LocalAdditionalBlockChancePct = 867,

		[Description("Keystone Minion Instability")]
		KeystoneMinionInstability = 868,
		[Description("Strong Casting")] StrongCasting = 869,

		[Description("Support Damage While On Full Life +% Final")]
		SupportDamageWhileOnFullLifePosPctFinal = 870,
		[Description("Is Totem")] IsTotem = 871,

		[Description("Monster Base Type Attack Cast Speed +% And Damage -% Final")]
		MonsterBaseTypeAttackCastSpeedPosPctAndDamageNegPctFinal = 872,

		[Description("Monster Rarity Attack Cast Speed +% And Damage -% Final")]
		MonsterRarityAttackCastSpeedPosPctAndDamageNegPctFinal = 873,

		[Description("Monster Attack Cast Speed +% And Damage -% Final")]
		MonsterAttackCastSpeedPosPctAndDamageNegPctFinal = 874,

		[Description("Cast Speed +% Granted From Skill")]
		CastSpeedPosPctGrantedFromSkill = 875,
		[Description("Is Hidden Monster")] IsHiddenMonster = 876,
		[Description("Base Totem Duration")] BaseTotemDuration = 877,
		[Description("Totem Duration")] TotemDuration = 878,
		[Description("Base Totem Range")] BaseTotemRange = 879,
		[Description("Totem Range")] TotemRange = 880,

		[Description("Immune To Auras From Other Entities")]
		ImmuneToAurasFromOtherEntities = 881,

		[Description("Totem Support Gem Level")]
		TotemSupportGemLevel = 882,

		[Description("Base Number Of Totems Allowed")]
		BaseNumberOfTotemsAllowed = 883,
		[Description("Base Trap Duration")] BaseTrapDuration = 884,
		[Description("Trap Duration")] TrapDuration = 885,

		[Description("Base Number Of Traps Allowed")]
		BaseNumberOfTrapsAllowed = 886,
		[Description("Monster Flurry")] MonsterFlurry = 887,

		[Description("Number Of Insects Allowed")]
		NumberOfInsectsAllowed = 888,
		[Description("Is Remote Mine")] IsRemoteMine = 889,

		[Description("Base Number Of Remote Mines Allowed")]
		BaseNumberOfRemoteMinesAllowed = 890,
		[Description("Base Mine Duration")] BaseMineDuration = 891,
		[Description("Mine Duration")] MineDuration = 892,

		[Description("Nonlethal Fire Damage Taken Per Minute")]
		NonlethalFireDamageTakenPerMinute = 893,

		[Description("Base Nonlethal Fire Damage % Of Maximum Life Taken Per Minute")]
		BaseNonlethalFireDamagePctOfMaximumLifeTakenPerMinute = 894,

		[Description("Righteous Fire Spell Damage +% Final")]
		RighteousFireSpellDamagePosPctFinal = 895,

		[Description("Base Righteous Fire % Of Max Life To Deal To Nearby Per Minute")]
		BaseRighteousFirePctOfMaxLifeToDealToNearbyPerMinute = 896,
		[Description("Totem Level")] TotemLevel = 897,

		[Description("Base Active Skill Totem Level")]
		BaseActiveSkillTotemLevel = 898,
		[Description("Alternate Minion")] AlternateMinion = 899,

		[Description("Corpse Consumption Life To Gain")]
		CorpseConsumptionLifeToGain = 900,

		[Description("Support Totem Damage +% Final")]
		SupportTotemDamagePosPctFinal = 901,

		[Description("Freeze Mine Damage To Freeze As Though Dealing")]
		FreezeMineDamageToFreezeAsThoughDealing = 902,

		[Description("Monster No Drops Or Experience")]
		MonsterNoDropsOrExperience = 903,

		[Description("Active Skill Gem Added Damage Effectiveness +% Final")]
		ActiveSkillGemAddedDamageEffectivenessPosPctFinal = 904,

		[Description("Monster Gain Frenzy Charge On Kin Death")]
		MonsterGainFrenzyChargeOnKinDeath = 905,

		[Description("Monster Ground Fire On Death % Max Damage To Deal Per Minute")]
		MonsterGroundFireOnDeathPctMaxDamageToDealPerMinute = 906,

		[Description("Monster Ground Fire On Death Base Area Of Effect Radius")]
		MonsterGroundFireOnDeathBaseAreaOfEffectRadius = 907,

		[Description("Monster Ground Effect On Death Base Duration Ms")]
		MonsterGroundEffectOnDeathBaseDurationMs = 908,

		[Description("Monster Ground Fire On Death Duration Ms")]
		MonsterGroundFireOnDeathDurationMs = 909,

		[Description("Curse On Hit % Vulnerability")]
		CurseOnHitPctVulnerability = 910,

		[Description("Curse On Hit % Temporal Chains")]
		CurseOnHitPctTemporalChains = 911,

		[Description("Support Gem Mine Damage +% Final")]
		SupportGemMineDamagePosPctFinal = 912,
		[Description("Undead Description")] UndeadDescription = 913,

		[Description("Monster Casts Firestorm Text")]
		MonsterCastsFirestormText = 914,

		[Description("Monster Casts Puncture Text")]
		MonsterCastsPunctureText = 915,

		[Description("Monster Casts Coldsnap Text")]
		MonsterCastsColdsnapText = 916,

		[Description("Monster Casts Assassins Mark Curse Text")]
		MonsterCastsAssassinsMarkCurseText = 917,

		[Description("Monster Casts Elementral Weakness Curse Text")]
		MonsterCastsElementralWeaknessCurseText = 918,

		[Description("Monster Casts Enfeeble Curse Text")]
		MonsterCastsEnfeebleCurseText = 919,

		[Description("Monster Casts Fireball Text")]
		MonsterCastsFireballText = 920,

		[Description("Monster Casts Ice Nova Text")]
		MonsterCastsIceNovaText = 921,

		[Description("Monster Casts Ice Spear Text")]
		MonsterCastsIceSpearText = 922,

		[Description("Monster Casts Molten Shell Text")]
		MonsterCastsMoltenShellText = 923,

		[Description("Monster Casts Projectile Vulnerability Curse Text")]
		MonsterCastsProjectileVulnerabilityCurseText = 924,

		[Description("Monster Casts Shock Nova Text")]
		MonsterCastsShockNovaText = 925,

		[Description("Monster Casts Spark Text")]
		MonsterCastsSparkText = 926,

		[Description("Monster Casts Vulnerability Curse Text")]
		MonsterCastsVulnerabilityCurseText = 927,

		[Description("Monster Casts Warlords Mark Curse Text")]
		MonsterCastsWarlordsMarkCurseText = 928,

		[Description("Monster Detonates Corpses Text")]
		MonsterDetonatesCorpsesText = 929,

		[Description("Monster Explodes On Its Target Text")]
		MonsterExplodesOnItsTargetText = 930,

		[Description("Monster Fires A Rain Of Arrows Text")]
		MonsterFiresARainOfArrowsText = 931,

		[Description("Monster Fires Burning Arrows Text")]
		MonsterFiresBurningArrowsText = 932,

		[Description("Monster Fires Explosive Arrows Text")]
		MonsterFiresExplosiveArrowsText = 933,

		[Description("Monster Fires Lightning Arrows Text")]
		MonsterFiresLightningArrowsText = 934,

		[Description("Monster Fires Caustic Arrows Text")]
		MonsterFiresCausticArrowsText = 935,

		[Description("Monster Fires Split Arrows Text")]
		MonsterFiresSplitArrowsText = 936,

		[Description("Monster Leaps Onto Enemies Text")]
		MonsterLeapsOntoEnemiesText = 937,

		[Description("Monster Raises Undead Text")]
		MonsterRaisesUndeadText = 938,

		[Description("Monster Summons Exploding Spawn Text")]
		MonsterSummonsExplodingSpawnText = 939,

		[Description("Monster Summons Monkeys From Nearby Trees Text")]
		MonsterSummonsMonkeysFromNearbyTreesText = 940,

		[Description("Monster Summons Skeletons Text")]
		MonsterSummonsSkeletonsText = 941,

		[Description("Monster Summons Spawn Text")]
		MonsterSummonsSpawnText = 942,

		[Description("Monster Uses Enduring Cry Text")]
		MonsterUsesEnduringCryText = 943,

		[Description("Monster Uses Flicker Strike Text")]
		MonsterUsesFlickerStrikeText = 944,

		[Description("Monster Uses Glacial Hammer Text")]
		MonsterUsesGlacialHammerText = 945,

		[Description("Monster Uses Ground Slam Text")]
		MonsterUsesGroundSlamText = 946,

		[Description("Monster Uses Lightning Strike Text")]
		MonsterUsesLightningStrikeText = 947,

		[Description("Monster Uses Phase Run Text")]
		MonsterUsesPhaseRunText = 948,

		[Description("Monster Casts Shield Charge Text")]
		MonsterCastsShieldChargeText = 949,

		[Description("Monster Casts Mass Frenzy Text")]
		MonsterCastsMassFrenzyText = 950,

		[Description("Monster Casts Temporal Chains Text")]
		MonsterCastsTemporalChainsText = 951,

		[Description("Monster Casts Frenzy Text")]
		MonsterCastsFrenzyText = 952,

		[Description("Monster Casts Viper Strike Text")]
		MonsterCastsViperStrikeText = 953,

		[Description("Monster Casts Elemental Hit Text")]
		MonsterCastsElementalHitText = 954,
		[Description("Cannot Block Attacks")] CannotBlockAttacks = 955,
		[Description("Attack Block %")] AttackBlockPct = 956,

		[Description("Local Weapon Uses Both Hands")]
		LocalWeaponUsesBothHands = 957,

		[Description("Base Maximum Fire Damage Resistance %")]
		BaseMaximumFireDamageResistancePct = 958,

		[Description("Base Maximum Cold Damage Resistance %")]
		BaseMaximumColdDamageResistancePct = 959,

		[Description("Base Maximum Lightning Damage Resistance %")]
		BaseMaximumLightningDamageResistancePct = 960,

		[Description("Base Maximum Chaos Damage Resistance %")]
		BaseMaximumChaosDamageResistancePct = 961,

		[Description("Additional Maximum All Resistances %")]
		AdditionalMaximumAllResistancesPct = 962,

		[Description("Additional Maximum All Elemental Resistances %")]
		AdditionalMaximumAllElementalResistancesPct = 963,

		[Description("Local Display Socketed Gems Get Concentrated Area Level")]
		LocalDisplaySocketedGemsGetConcentratedAreaLevel = 964,

		[Description("Number Of Additional Traps Allowed")]
		NumberOfAdditionalTrapsAllowed = 965,

		[Description("Number Of Additional Remote Mines Allowed")]
		NumberOfAdditionalRemoteMinesAllowed = 966,

		[Description("Number Of Traps Allowed")]
		NumberOfTrapsAllowed = 967,

		[Description("Number Of Remote Mines Allowed")]
		NumberOfRemoteMinesAllowed = 968,

		[Description("Number Of Additional Totems Allowed")]
		NumberOfAdditionalTotemsAllowed = 969,

		[Description("Number Of Totems Allowed")]
		NumberOfTotemsAllowed = 970,

		[Description("Additional Physical Damage Reduction % When On Low Life")]
		AdditionalPhysicalDamageReductionPctWhenOnLowLife = 971,

		[Description("Endurance Only Conduit")]
		EnduranceOnlyConduit = 972,
		[Description("Frenzy Only Conduit")] FrenzyOnlyConduit = 973,
		[Description("Power Only Conduit")] PowerOnlyConduit = 974,

		[Description("Ice Spear Second Form Critical Strike Chance +%")]
		IceSpearSecondFormCriticalStrikeChancePosPct = 975,

		[Description("Monster Dropped Item Rarity +% From Player Support")]
		MonsterDroppedItemRarityPosPctFromPlayerSupport = 976,

		[Description("Monster Dropped Item Quantity +% From Player Support")]
		MonsterDroppedItemQuantityPosPctFromPlayerSupport = 977,

		[Description("Monster Ground Ice On Death Base Area Of Effect Radius")]
		MonsterGroundIceOnDeathBaseAreaOfEffectRadius = 978,

		[Description("Monster Ground Ice On Death Duration Ms")]
		MonsterGroundIceOnDeathDurationMs = 979,

		[Description("Monster Ground Tar On Death Base Area Of Effect Radius")]
		MonsterGroundTarOnDeathBaseAreaOfEffectRadius = 980,

		[Description("Monster Ground Tar On Death Duration Ms")]
		MonsterGroundTarOnDeathDurationMs = 981,

		[Description("Monster Ground Tar On Death Monvement Speed Pluspercent")]
		MonsterGroundTarOnDeathMonvementSpeedPluspercent = 982,
		[Description("blinded")] Blinded = 983,

		[Description("Local Chance To Blind On Hit %")]
		LocalChanceToBlindOnHitPct = 984,

		[Description("Main Hand Local Chance To Blind On Hit %")]
		MainHandLocalChanceToBlindOnHitPct = 985,

		[Description("Off Hand Local Chance To Blind On Hit %")]
		OffHandLocalChanceToBlindOnHitPct = 986,

		[Description("Global Chance To Blind On Hit %")]
		GlobalChanceToBlindOnHitPct = 987,

		[Description("Main Hand Chance To Blind On Hit %")]
		MainHandChanceToBlindOnHitPct = 988,

		[Description("Off Hand Chance To Blind On Hit %")]
		OffHandChanceToBlindOnHitPct = 989,

		[Description("Local Display Socketed Gems Get Blind Level")]
		LocalDisplaySocketedGemsGetBlindLevel = 990,
		[Description("Blind Duration +%")] BlindDurationPosPct = 991,

		[Description("Cannot Be Knocked Back")]
		CannotBeKnockedBack = 992,

		[Description("Dual Wield Inherent Attack Speed +% Final")]
		DualWieldInherentAttackSpeedPosPctFinal = 993,
		[Description("Map Spawn Two Bosses")] MapSpawnTwoBosses = 994,
		[Description("Map Boss Damage +%")] MapBossDamagePosPct = 995,

		[Description("Map Boss Attack And Cast Speed +%")]
		MapBossAttackAndCastSpeedPosPct = 996,

		[Description("Map Monsters Additional Fire Resistance")]
		MapMonstersAdditionalFireResistance = 997,

		[Description("Map Monsters Additional Cold Resistance")]
		MapMonstersAdditionalColdResistance = 998,

		[Description("Map Monsters Additional Lightning Resistance")]
		MapMonstersAdditionalLightningResistance = 999,

		[Description("Map Monsters Additional Physical Damage Reduction")]
		MapMonstersAdditionalPhysicalDamageReduction = 1000,

		[Description("Map Monsters Cannot Be Stunned")]
		MapMonstersCannotBeStunned = 1001,
		[Description("Map Monsters Life +%")] MapMonstersLifePosPct = 1002,

		[Description("Map Monsters Damage +%")]
		MapMonstersDamagePosPct = 1003,

		[Description("Map Monsters Movement Speed +%")]
		MapMonstersMovementSpeedPosPct = 1004,

		[Description("Map Monsters Attack Speed +%")]
		MapMonstersAttackSpeedPosPct = 1005,

		[Description("Map Monsters Cast Speed +%")]
		MapMonstersCastSpeedPosPct = 1006,

		[Description("Map Monsters Reflect % Physical Damage")]
		MapMonstersReflectPctPhysicalDamage = 1007,

		[Description("Map Monsters Reflect % Elemental Damage")]
		MapMonstersReflectPctElementalDamage = 1008,

		[Description("Map Monsters Additional Number Of Projecitles")]
		MapMonstersAdditionalNumberOfProjecitles = 1009,

		[Description("Map Player Has Level X Vulnerability")]
		MapPlayerHasLevelXVulnerability = 1010,

		[Description("Map Player Has Level X Warlords Mark")]
		MapPlayerHasLevelXWarlordsMark = 1011,

		[Description("Map Player Has Level X Enfeeble")]
		MapPlayerHasLevelXEnfeeble = 1012,

		[Description("Map Player Has Level X Elemental Weakness")]
		MapPlayerHasLevelXElementalWeakness = 1013,

		[Description("Map Player Has Level X Temporal Chains")]
		MapPlayerHasLevelXTemporalChains = 1014,

		[Description("Map Player No Regeneration")]
		MapPlayerNoRegeneration = 1015,
		[Description("No Life Regeneration")] NoLifeRegeneration = 1016,
		[Description("No Mana Regeneration")] NoManaRegeneration = 1017,

		[Description("Map Player Base Chaos Damage Taken Per Minute")]
		MapPlayerBaseChaosDamageTakenPerMinute = 1018,

		[Description("Map Player Has Blood Magic Keystone")]
		MapPlayerHasBloodMagicKeystone = 1019,

		[Description("Map Player Has Elemental Equilibrium Keystone")]
		MapPlayerHasElementalEquilibriumKeystone = 1020,

		[Description("Map Player Has Chaos Inoculation Keystone")]
		MapPlayerHasChaosInoculationKeystone = 1021,

		[Description("Map Additional Player Maximum Resistances %")]
		MapAdditionalPlayerMaximumResistancesPct = 1022,

		[Description("Map Player Status Recovery Speed +%")]
		MapPlayerStatusRecoverySpeedPosPct = 1023,

		[Description("Life Recovery Speed +% Final From Map")]
		LifeRecoverySpeedPosPctFinalFromMap = 1024,

		[Description("Mana Recovery Speed +% Final From Map")]
		ManaRecoverySpeedPosPctFinalFromMap = 1025,

		[Description("Energy Shield Recovery Speed +% Final From Map")]
		EnergyShieldRecoverySpeedPosPctFinalFromMap = 1026,
		[Description("Map Size +%")] MapSizePosPct = 1027,
		[Description("Map Is Branchy")] MapIsBranchy = 1028,
		[Description("Map Packs Are Totems")] MapPacksAreTotems = 1029,

		[Description("Map Packs Are Skeletons")]
		MapPacksAreSkeletons = 1030,
		[Description("Map Packs Are Bandits")] MapPacksAreBandits = 1031,
		[Description("Map Packs Are Goatmen")] MapPacksAreGoatmen = 1032,

		[Description("Map Packs Are Sea Witches And Spawn")]
		MapPacksAreSeaWitchesAndSpawn = 1033,

		[Description("Map Packs Are Undead And Necromancers")]
		MapPacksAreUndeadAndNecromancers = 1034,

		[Description("Map Packs Fire Projectiles")]
		MapPacksFireProjectiles = 1035,
		[Description("Map Pack Size +%")] MapPackSizePosPct = 1036,

		[Description("Map Number Of Magic Packs +%")]
		MapNumberOfMagicPacksPosPct = 1037,

		[Description("Map Number Of Rare Packs +%")]
		MapNumberOfRarePacksPosPct = 1038,

		[Description("Map Base Ground Fire Damage To Deal Per Minute")]
		MapBaseGroundFireDamageToDealPerMinute = 1039,

		[Description("Map Monsters % Physical Damage To Convert To Fire")]
		MapMonstersPctPhysicalDamageToConvertToFire = 1040,

		[Description("Map Monsters % Physical Damage To Convert To Cold")]
		MapMonstersPctPhysicalDamageToConvertToCold = 1041,

		[Description("Map Monsters % Physical Damage To Convert To Lightning")]
		MapMonstersPctPhysicalDamageToConvertToLightning = 1042,

		[Description("Map Monsters % Physical Damage To Convert To Chaos")]
		MapMonstersPctPhysicalDamageToConvertToChaos = 1043,

		[Description("Map Monsters % Physical Damage To Add As Fire")]
		MapMonstersPctPhysicalDamageToAddAsFire = 1044,

		[Description("Map Monsters % Physical Damage To Add As Cold")]
		MapMonstersPctPhysicalDamageToAddAsCold = 1045,

		[Description("Map Monsters % Physical Damage To Add As Lightning")]
		MapMonstersPctPhysicalDamageToAddAsLightning = 1046,

		[Description("Map Monsters % Physical Damage To Add As Chaos")]
		MapMonstersPctPhysicalDamageToAddAsChaos = 1047,

		[Description("Base Additional Physical Damage Reduction %")]
		BaseAdditionalPhysicalDamageReductionPct = 1048,

		[Description("Map Monsters Gain X Frenzy Charges Every 20 Seconds")]
		MapMonstersGainXFrenzyChargesEvery20Seconds = 1049,

		[Description("Map Additional Number Of Packs To Choose")]
		MapAdditionalNumberOfPacksToChoose = 1050,

		[Description("Map Item Drop Quantity +%")]
		MapItemDropQuantityPosPct = 1051,

		[Description("Map Ground Effect Patches Per 100 Tiles")]
		MapGroundEffectPatchesPer100Tiles = 1052,

		[Description("Map Ground Tar Movement Speed +%")]
		MapGroundTarMovementSpeedPosPct = 1053,

		[Description("Map Ground Effect Radius")]
		MapGroundEffectRadius = 1054,
		[Description("Map Ground Ice")] MapGroundIce = 1055,

		[Description("Map Chest Item Quantity +%")]
		MapChestItemQuantityPosPct = 1056,

		[Description("Map Chest Item Rarity +%")]
		MapChestItemRarityPosPct = 1057,

		[Description("Display Map No Monsters")]
		DisplayMapNoMonsters = 1058,

		[Description("Necromancer Additional Rarity Levels Can Be Raised")]
		NecromancerAdditionalRarityLevelsCanBeRaised = 1059,

		[Description("Monster Dropped Item Quantity From Numplayers +%")]
		MonsterDroppedItemQuantityFromNumplayersPosPct = 1060,

		[Description("Map Disable Chest Drop Scaling")]
		MapDisableChestDropScaling = 1061,

		[Description("Physical Damage Taken % As Fire")]
		PhysicalDamageTakenPctAsFire = 1062,

		[Description("Physical Damage Taken % As Cold")]
		PhysicalDamageTakenPctAsCold = 1063,

		[Description("Physical Damage Taken % As Lightning")]
		PhysicalDamageTakenPctAsLightning = 1064,

		[Description("Physical Damage Taken % As Chaos")]
		PhysicalDamageTakenPctAsChaos = 1065,

		[Description("Base Energy Shield Regeneration Rate Per Minute")]
		BaseEnergyShieldRegenerationRatePerMinute = 1066,

		[Description("Leech Energy Shield Instead Of Life")]
		LeechEnergyShieldInsteadOfLife = 1067,

		[Description("Energy Shield Regeneration Rate Per Minute")]
		EnergyShieldRegenerationRatePerMinute = 1068,

		[Description("Monster Uses Mass Power Text")]
		MonsterUsesMassPowerText = 1069,

		[Description("Monster Uses Mass Endurance Text")]
		MonsterUsesMassEnduranceText = 1070,

		[Description("Monster Uses Shockwave Text")]
		MonsterUsesShockwaveText = 1071,

		[Description("Unique Facebreaker Unarmed Physical Damage +% Final")]
		UniqueFacebreakerUnarmedPhysicalDamagePosPctFinal = 1072,

		[Description("Local Display Socketed Gems Get Increased Area Level")]
		LocalDisplaySocketedGemsGetIncreasedAreaLevel = 1073,

		[Description("Local Socketed Aura Gem Level +")]
		LocalSocketedAuraGemLevelPos = 1074,
		[Description("Extra Gore")] ExtraGore = 1075,

		[Description("Local One Socket Each Colour Only")]
		LocalOneSocketEachColourOnly = 1076,

		[Description("Life Reserved By Stat %")]
		LifeReservedByStatPct = 1077,

		[Description("Block While Dual Wielding Claws %")]
		BlockWhileDualWieldingClawsPct = 1078,

		[Description("Unique Chin Sol Close Range Bow Damage +% Final")]
		UniqueChinSolCloseRangeBowDamagePosPctFinal = 1079,

		[Description("Unique Chin Sol Close Range Knockback")]
		UniqueChinSolCloseRangeKnockback = 1080,

		[Description("Physical Damage Reduction Rating Against Projectiles")]
		PhysicalDamageReductionRatingAgainstProjectiles = 1081,
		[Description("Projectile Block %")] ProjectileBlockPct = 1082,

		[Description("Additional Block Chance Against Projectiles %")]
		AdditionalBlockChanceAgainstProjectilesPct = 1083,

		[Description("Physical Damage Reduction Rating +% Against Projectiles")]
		PhysicalDamageReductionRatingPosPctAgainstProjectiles = 1084,

		[Description("Spell Projectile Block %")]
		SpellProjectileBlockPct = 1085,

		[Description("Projectile Attack Block %")]
		ProjectileAttackBlockPct = 1086,

		[Description("Display Estimated Physical Damage Reduciton Against Projectiles %")]
		DisplayEstimatedPhysicalDamageReducitonAgainstProjectilesPct = 1087,

		[Description("Damage Taken Goes To Mana %")]
		DamageTakenGoesToManaPct = 1088,

		[Description("Evasion And Physical Damage Reduction Rating +%")]
		EvasionAndPhysicalDamageReductionRatingPosPct = 1089,

		[Description("Additional Item Drop Slots When Deleted On Death")]
		AdditionalItemDropSlotsWhenDeletedOnDeath = 1090,

		[Description("Mana Degeneration Per Minute")]
		ManaDegenerationPerMinute = 1091,

		[Description("Life Degeneration Per Minute")]
		LifeDegenerationPerMinute = 1092,

		[Description("Ice Shield Moving Mana Degeneration Per Minute")]
		IceShieldMovingManaDegenerationPerMinute = 1093,

		[Description("Unique Quill Rain Weapon Damage +% Final")]
		UniqueQuillRainWeaponDamagePosPctFinal = 1094,

		[Description("Melee Physical Damage Taken % To Deal To Attacker")]
		MeleePhysicalDamageTakenPctToDealToAttacker = 1095,
		[Description("Additional Block %")] AdditionalBlockPct = 1096,

		[Description("Frozen Monsters Take Increased Damage")]
		FrozenMonstersTakeIncreasedDamage = 1097,

		[Description("Local Display Socketed Gems Get Blood Magic Level")]
		LocalDisplaySocketedGemsGetBloodMagicLevel = 1098,

		[Description("Local Display Socketed Gems Have Blood Magic")]
		LocalDisplaySocketedGemsHaveBloodMagic = 1099,
		[Description("Monster Base Block %")] MonsterBaseBlockPct = 1100,
		[Description("Base Cannot Leech")] BaseCannotLeech = 1101,
		[Description("Keystone Vampirism")] KeystoneVampirism = 1102,

		[Description("Unique Dewaths Hide Physical Attack Damage Dealt -")]
		UniqueDewathsHidePhysicalAttackDamageDealtNeg = 1103,

		[Description("Local Strength Requirement +%")]
		LocalStrengthRequirementPosPct = 1104,

		[Description("Local Dexterity Requirement +%")]
		LocalDexterityRequirementPosPct = 1105,

		[Description("Local Intelligence Requirement +%")]
		LocalIntelligenceRequirementPosPct = 1106,

		[Description("Local Cannot Be Used With Chaos Innoculation")]
		LocalCannotBeUsedWithChaosInnoculation = 1107,

		[Description("Local Display Socketed Gems Have Mana Reservation +%")]
		LocalDisplaySocketedGemsHaveManaReservationPosPct = 1108,

		[Description("Mace Elemental Damage +%")]
		MaceElementalDamagePosPct = 1109,

		[Description("Active Skill Minion Movement Velocity +% Final")]
		ActiveSkillMinionMovementVelocityPosPctFinal = 1110,

		[Description("Movement Velocity +% Final For Minion")]
		MovementVelocityPosPctFinalForMinion = 1111,
		[Description("Movement Velocity Cap")] MovementVelocityCap = 1112,

		[Description("Display Minion Base Maximum Life")]
		DisplayMinionBaseMaximumLife = 1113,

		[Description("Display Minion Maximum Life")]
		DisplayMinionMaximumLife = 1114,

		[Description("Skill Physical Damage % To Convert To Fire")]
		SkillPhysicalDamagePctToConvertToFire = 1115,

		[Description("Skill Physical Damage % To Convert To Cold")]
		SkillPhysicalDamagePctToConvertToCold = 1116,

		[Description("Skill Physical Damage % To Convert To Lightning")]
		SkillPhysicalDamagePctToConvertToLightning = 1117,

		[Description("Skill Physical Damage % To Convert To Chaos")]
		SkillPhysicalDamagePctToConvertToChaos = 1118,

		[Description("Skill Cold Damage % To Convert To Fire")]
		SkillColdDamagePctToConvertToFire = 1119,

		[Description("Physical Damage % To Convert To Fire")]
		PhysicalDamagePctToConvertToFire = 1120,

		[Description("Physical Damage % To Convert To Cold")]
		PhysicalDamagePctToConvertToCold = 1121,

		[Description("Physical Damage % To Convert To Lightning")]
		PhysicalDamagePctToConvertToLightning = 1122,

		[Description("Physical Damage % To Convert To Chaos")]
		PhysicalDamagePctToConvertToChaos = 1123,

		[Description("Cold Damage % To Convert To Fire")]
		ColdDamagePctToConvertToFire = 1124,

		[Description("Main Hand Attack Duration Ms")]
		MainHandAttackDurationMs = 1125,

		[Description("Off Hand Attack Duration Ms")]
		OffHandAttackDurationMs = 1126,
		[Description("Spell Cast Time Ms")] SpellCastTimeMs = 1127,

		[Description("Cast Time Overrides Attack Duration")]
		CastTimeOverridesAttackDuration = 1128,
		[Description("Projectiles Fork")] ProjectilesFork = 1129,

		[Description("Base Skill Number Of Additional Hits")]
		BaseSkillNumberOfAdditionalHits = 1130,

		[Description("Skill Override Pvp Scaling Time Ms")]
		SkillOverridePvpScalingTimeMs = 1131,

		[Description("Skill Double Hits When Dual Wielding")]
		SkillDoubleHitsWhenDualWielding = 1132,

		[Description("Skill Number Of Additional Hits")]
		SkillNumberOfAdditionalHits = 1133,

		[Description("Trap Override Pvp Scaling Time Ms")]
		TrapOverridePvpScalingTimeMs = 1134,

		[Description("Mine Override Pvp Scaling Time Ms")]
		MineOverridePvpScalingTimeMs = 1135,

		[Description("Override Pvp Scaling Time Ms")]
		OverridePvpScalingTimeMs = 1136,

		[Description("Skill Display Number Of Totems Allowed")]
		SkillDisplayNumberOfTotemsAllowed = 1137,

		[Description("Skill Display Number Of Traps Allowed")]
		SkillDisplayNumberOfTrapsAllowed = 1138,

		[Description("Skill Display Number Of Remote Mines Allowed")]
		SkillDisplayNumberOfRemoteMinesAllowed = 1139,

		[Description("Energy Shield % Gained On Block")]
		EnergyShieldPctGainedOnBlock = 1140,

		[Description("Local Display Socketed Gems Get Added Chaos Damage Level")]
		LocalDisplaySocketedGemsGetAddedChaosDamageLevel = 1141,
		[Description("Projectiles Return")] ProjectilesReturn = 1142,

		[Description("Projectile Number To Split")]
		ProjectileNumberToSplit = 1143,

		[Description("Determination Aura Armour +% Final")]
		DeterminationAuraArmourPosPctFinal = 1144,

		[Description("Support Chain Hit Damage +% Final")]
		SupportChainHitDamagePosPctFinal = 1145,

		[Description("Support Split Projectile Damage +% Final")]
		SupportSplitProjectileDamagePosPctFinal = 1146,

		[Description("Support Return Projectile Damage +% Final")]
		SupportReturnProjectileDamagePosPctFinal = 1147,

		[Description("Support Fork Projectile Damage +% Final")]
		SupportForkProjectileDamagePosPctFinal = 1148,

		[Description("Energy Shield % Of Armour Rating Gained On Block")]
		EnergyShieldPctOfArmourRatingGainedOnBlock = 1149,
		[Description("Skeleton Duration +%")] SkeletonDurationPosPct = 1150,
		[Description("Local Poison On Hit")] LocalPoisonOnHit = 1151,

		[Description("Main Hand Local Poison On Hit")]
		MainHandLocalPoisonOnHit = 1152,

		[Description("Off Hand Local Poison On Hit")]
		OffHandLocalPoisonOnHit = 1153,
		[Description("On Low Mana")] OnLowMana = 1154,

		[Description("Spell Damage Taken +% When On Low Mana")]
		SpellDamageTakenPosPctWhenOnLowMana = 1155,
		[Description("Spell Damage Taken +%")] SpellDamageTakenPosPct = 1156,

		[Description("Evasion Rating + When On Full Life")]
		EvasionRatingPosWhenOnFullLife = 1157,

		[Description("Aura Effect On Self +%")]
		AuraEffectOnSelfPosPct = 1158,

		[Description("Minions Have Aura Effect +%")]
		MinionsHaveAuraEffectPosPct = 1159,
		[Description("Reflect Curses")] ReflectCurses = 1160,

		[Description("Global Critical Strike Chance +% While Holding Staff")]
		GlobalCriticalStrikeChancePosPctWhileHoldingStaff = 1161,

		[Description("Global Critical Strike Multiplier + While Holding Staff")]
		GlobalCriticalStrikeMultiplierPosWhileHoldingStaff = 1162,

		[Description("Secondary Damage Critical Strike Multiplier +")]
		SecondaryDamageCriticalStrikeMultiplierPos = 1163,

		[Description("Old Do Not Use Life Leech From Spell Damage %")]
		OldDoNotUseLifeLeechFromSpellDamagePct = 1164,

		[Description("Old Do Not Use Mana Leech From Spell Damage %")]
		OldDoNotUseManaLeechFromSpellDamagePct = 1165,

		[Description("Punishment Physical Damage % Reflected For Normal Monsters")]
		PunishmentPhysicalDamagePctReflectedForNormalMonsters = 1166,

		[Description("Punishment Physical Damage % Reflected For Magic Monsters")]
		PunishmentPhysicalDamagePctReflectedForMagicMonsters = 1167,

		[Description("Punishment Physical Damage % Reflected For Rare Monsters")]
		PunishmentPhysicalDamagePctReflectedForRareMonsters = 1168,

		[Description("Punishment Physical Damage % Reflected For Unique Monsters")]
		PunishmentPhysicalDamagePctReflectedForUniqueMonsters = 1169,
		[Description("Is Player Minion")] IsPlayerMinion = 1170,

		[Description("Local Flask Curse Immunity While Healing")]
		LocalFlaskCurseImmunityWhileHealing = 1171,

		[Description("Attacks Deal No Physical Damage")]
		AttacksDealNoPhysicalDamage = 1172,

		[Description("Whirling Blades Base Ground Fire Damage To Deal Per Minute")]
		WhirlingBladesBaseGroundFireDamageToDealPerMinute = 1173,

		[Description("Monster Casts Ethereal Knives Text")]
		MonsterCastsEtherealKnivesText = 1174,

		[Description("Monster Throws Beartraps Text")]
		MonsterThrowsBeartrapsText = 1175,

		[Description("Monster Casts Lightning Thorns Text")]
		MonsterCastsLightningThornsText = 1176,

		[Description("Monster Throws Fire Bombs Text")]
		MonsterThrowsFireBombsText = 1177,

		[Description("Monster Throws Caustic Bombs Text")]
		MonsterThrowsCausticBombsText = 1178,

		[Description("Monster Casts Freezing Pulse Text")]
		MonsterCastsFreezingPulseText = 1179,
		[Description("Monster Cleaves Text")] MonsterCleavesText = 1180,

		[Description("Monster Fires Ice Shot Arrows Text")]
		MonsterFiresIceShotArrowsText = 1181,

		[Description("Monster Casts Conductivity Text")]
		MonsterCastsConductivityText = 1182,

		[Description("Monster Casts Flammability Text")]
		MonsterCastsFlammabilityText = 1183,

		[Description("Monster Casts Augmented Fireballs Text")]
		MonsterCastsAugmentedFireballsText = 1184,

		[Description("Monster Channels Lightning Text")]
		MonsterChannelsLightningText = 1185,

		[Description("Monster Casts Arc Text")]
		MonsterCastsArcText = 1186,

		[Description("Monster Raises Zombies Text")]
		MonsterRaisesZombiesText = 1187,

		[Description("Monster Casts Ice Shield Text")]
		MonsterCastsIceShieldText = 1188,

		[Description("Monster Casts Unholy Fire Text")]
		MonsterCastsUnholyFireText = 1189,

		[Description("Physical Damage Taken +")]
		PhysicalDamageTakenPos = 1190,
		[Description("Fire Damage Taken +")] FireDamageTakenPos = 1191,

		[Description("Monster Gain Power Charge On Kin Death")]
		MonsterGainPowerChargeOnKinDeath = 1192,

		[Description("Monster Casts Discharge Text")]
		MonsterCastsDischargeText = 1193,
		[Description("Trap Variation")] TrapVariation = 1194,

		[Description("Number Of Water Elementals To Summon")]
		NumberOfWaterElementalsToSummon = 1195,

		[Description("Number Of Water Elementals Allowed")]
		NumberOfWaterElementalsAllowed = 1196,

		[Description("Display Summons Water Elementals Text")]
		DisplaySummonsWaterElementalsText = 1197,

		[Description("Shield Charge Remove Stun And Knockback")]
		ShieldChargeRemoveStunAndKnockback = 1198,

		[Description("Display Monster Uses Double Strike Text")]
		DisplayMonsterUsesDoubleStrikeText = 1199,

		[Description("Bleed On Hit Base Duration")]
		BleedOnHitBaseDuration = 1200,

		[Description("Display Monster Uses Whirling Blades Text")]
		DisplayMonsterUsesWhirlingBladesText = 1201,
		[Description("Cannot Be Stunned")] CannotBeStunned = 1202,

		[Description("Cannot Be Stunned When On Low Life")]
		CannotBeStunnedWhenOnLowLife = 1203,

		[Description("Display Monster Casts Lightning Warp Text")]
		DisplayMonsterCastsLightningWarpText = 1204,

		[Description("Display Golden Radiance")]
		DisplayGoldenRadiance = 1205,

		[Description("Display Monster Casts Frostbite Text")]
		DisplayMonsterCastsFrostbiteText = 1206,

		[Description("Cannot Be Converted Or Dominated")]
		CannotBeConvertedOrDominated = 1207,

		[Description("Map Hidden Monster Life +% Times 6 Final")]
		MapHiddenMonsterLifePosPctTimes6Final = 1208,

		[Description("Map Hidden Monster Damage +% Squared Final")]
		MapHiddenMonsterDamagePosPctSquaredFinal = 1209,

		[Description("Regenerate Energy Shield Instead Of Life")]
		RegenerateEnergyShieldInsteadOfLife = 1210,

		[Description("Damage Not From Skill User")]
		DamageNotFromSkillUser = 1211,

		[Description("Deal No Damage Yourself")]
		DealNoDamageYourself = 1212,
		[Description("Deal No Damage")] DealNoDamage = 1213,

		[Description("Disable Skill If Melee Attack")]
		DisableSkillIfMeleeAttack = 1214,

		[Description("Display Disable Melee Weapons")]
		DisplayDisableMeleeWeapons = 1215,

		[Description("Chaos Damage Does Not Bypass Energy Shield")]
		ChaosDamageDoesNotBypassEnergyShield = 1216,
		[Description("Cannot Cast Spells")] CannotCastSpells = 1217,

		[Description("Piety Transform Debuff Time Ms")]
		PietyTransformDebuffTimeMs = 1218,

		[Description("Cheat Override Blood Effect Level")]
		CheatOverrideBloodEffectLevel = 1219,

		[Description("Map Undead Monsters Get Up After X Seconds")]
		MapUndeadMonstersGetUpAfterXSeconds = 1220,

		[Description("Local Stun Threshold Reduction +%")]
		LocalStunThresholdReductionPosPct = 1221,

		[Description("Main Hand Local Stun Threshold Reduction +%")]
		MainHandLocalStunThresholdReductionPosPct = 1222,

		[Description("Off Hand Local Stun Threshold Reduction +%")]
		OffHandLocalStunThresholdReductionPosPct = 1223,

		[Description("Intermediary Maximum Life Including Chaos Innoculation")]
		IntermediaryMaximumLifeIncludingChaosInnoculation = 1224,
		[Description("Light Radius +%")] LightRadiusPosPct = 1225,

		[Description("Active Skill Cast Speed +% Final")]
		ActiveSkillCastSpeedPosPctFinal = 1226,

		[Description("Map Has X Waves Of Monsters")]
		MapHasXWavesOfMonsters = 1227,

		[Description("Map Has X Seconds Between Waves")]
		MapHasXSecondsBetweenWaves = 1228,

		[Description("Map Num Initial Wave Monsters")]
		MapNumInitialWaveMonsters = 1229,

		[Description("Map Wave Monster Increment")]
		MapWaveMonsterIncrement = 1230,

		[Description("Flamethrower Damage +% Per Stage Final")]
		FlamethrowerDamagePosPctPerStageFinal = 1231,

		[Description("Ground Tar On Take Crit Base Area Of Effect Radius")]
		GroundTarOnTakeCritBaseAreaOfEffectRadius = 1232,

		[Description("Ground Tar On Take Crit Duration Ms")]
		GroundTarOnTakeCritDurationMs = 1233,

		[Description("Ground Tar On Take Crit Monvement Speed Pluspercent")]
		GroundTarOnTakeCritMonvementSpeedPluspercent = 1234,

		[Description("Curse On Hit % Enfeeble")]
		CurseOnHitPctEnfeeble = 1235,
		[Description("Totem Art Variation")] TotemArtVariation = 1236,

		[Description("Spells Have Culling Strike")]
		SpellsHaveCullingStrike = 1237,

		[Description("Map Monsters Immune To A Random Status Ailment Or Stun")]
		MapMonstersImmuneToARandomStatusAilmentOrStun = 1238,

		[Description("Map Monster Melee Attacks Apply Random Curses")]
		MapMonsterMeleeAttacksApplyRandomCurses = 1239,

		[Description("Map Monsters Reflect Curses")]
		MapMonstersReflectCurses = 1240,

		[Description("Curse On Melee Hit % Random Curse")]
		CurseOnMeleeHitPctRandomCurse = 1241,

		[Description("Main Hand Maximum Attack Distance")]
		MainHandMaximumAttackDistance = 1242,

		[Description("Off Hand Maximum Attack Distance")]
		OffHandMaximumAttackDistance = 1243,
		[Description("Melee Range +")] MeleeRangePos = 1244,

		[Description("Cyclone Movement Speed +% Final")]
		CycloneMovementSpeedPosPctFinal = 1245,

		[Description("Local Display Socketed Gems Get Added Fire Damage Level")]
		LocalDisplaySocketedGemsGetAddedFireDamageLevel = 1246,

		[Description("Local Display Socketed Gems Get Cold To Fire Level")]
		LocalDisplaySocketedGemsGetColdToFireLevel = 1247,

		[Description("Local Display Socketed Gems Get Fire Penetration Level")]
		LocalDisplaySocketedGemsGetFirePenetrationLevel = 1248,

		[Description("Evasion Rating +% When On Low Life")]
		EvasionRatingPosPctWhenOnLowLife = 1249,
		[Description("Life Leech Is Instant")] LifeLeechIsInstant = 1250,

		[Description("Base Life Leech Is Instant")]
		BaseLifeLeechIsInstant = 1251,

		[Description("Support Multiple Attacks Melee Attack Speed +% Final")]
		SupportMultipleAttacksMeleeAttackSpeedPosPctFinal = 1252,

		[Description("Map Item Drop Rarity +%")]
		MapItemDropRarityPosPct = 1253,
		[Description("Life Gain Per Target")] LifeGainPerTarget = 1254,

		[Description("Local Life Leech Is Instant")]
		LocalLifeLeechIsInstant = 1255,

		[Description("Main Hand Local Life Leech Is Instant")]
		MainHandLocalLifeLeechIsInstant = 1256,

		[Description("Off Hand Local Life Leech Is Instant")]
		OffHandLocalLifeLeechIsInstant = 1257,

		[Description("Avoid Ignite % When On Low Life")]
		AvoidIgnitePctWhenOnLowLife = 1258,

		[Description("Fire Damage Resistance % When On Low Life")]
		FireDamageResistancePctWhenOnLowLife = 1259,

		[Description("Local Display Socketed Gems Get Elemental Proliferation Level")]
		LocalDisplaySocketedGemsGetElementalProliferationLevel = 1260,
		[Description("Melee Splash")] MeleeSplash = 1261,

		[Description("Support Melee Splash Damage +% Final")]
		SupportMeleeSplashDamagePosPctFinal = 1262,

		[Description("Support Melee Splash Damage +% Final For Splash")]
		SupportMeleeSplashDamagePosPctFinalForSplash = 1263,

		[Description("Add Power Charge On Critical Strike %")]
		AddPowerChargeOnCriticalStrikePct = 1264,

		[Description("Base Melee Attack Repeat Count")]
		BaseMeleeAttackRepeatCount = 1265,
		[Description("Attack Repeat Count")] AttackRepeatCount = 1266,

		[Description("Display Map Larger Maze")]
		DisplayMapLargerMaze = 1267,

		[Description("Display Map Restless Dead")]
		DisplayMapRestlessDead = 1268,

		[Description("Display Map Two Bosses")]
		DisplayMapTwoBosses = 1269,

		[Description("Display Map Large Chest")]
		DisplayMapLargeChest = 1270,

		[Description("Local Socketed Movement Gem Level +")]
		LocalSocketedMovementGemLevelPos = 1271,

		[Description("Map Projectile Speed +%")]
		MapProjectileSpeedPosPct = 1272,

		[Description("Map Player Projectile Damage +% Final")]
		MapPlayerProjectileDamagePosPctFinal = 1273,

		[Description("Projectile Damage +% Final From Map")]
		ProjectileDamagePosPctFinalFromMap = 1274,

		[Description("Support Multiple Attack Damage +% Final")]
		SupportMultipleAttackDamagePosPctFinal = 1275,

		[Description("Necromancer Revivable Even If Corpse Unusable")]
		NecromancerRevivableEvenIfCorpseUnusable = 1276,

		[Description("Local Six Linked White Sockets")]
		LocalSixLinkedWhiteSockets = 1277,

		[Description("Area Of Effect +% Per 20 Int")]
		AreaOfEffectPosPctPer20Int = 1278,

		[Description("Attack Speed +% Per 10 Dex")]
		AttackSpeedPosPctPer10Dex = 1279,

		[Description("Physical Weapon Damage +% Per 10 Str")]
		PhysicalWeaponDamagePosPctPer10Str = 1280,

		[Description("Chance To Dodge % Per Frenzy Charge")]
		ChanceToDodgePctPerFrenzyCharge = 1281,

		[Description("Gain Power Charge Per Enemy You Crit")]
		GainPowerChargePerEnemyYouCrit = 1282,

		[Description("Local Unique Tabula Rasa No Requirement Or Energy Shield")]
		LocalUniqueTabulaRasaNoRequirementOrEnergyShield = 1283,

		[Description("Map Wave Magic Increase")]
		MapWaveMagicIncrease = 1284,

		[Description("Local Display Socketed Gems Get Spell Totem Level")]
		LocalDisplaySocketedGemsGetSpellTotemLevel = 1285,

		[Description("Cannot Increase Quantity Of Dropped Items")]
		CannotIncreaseQuantityOfDroppedItems = 1286,

		[Description("Cannot Increase Rarity Of Dropped Items")]
		CannotIncreaseRarityOfDroppedItems = 1287,

		[Description("Killed Monster Dropped Item Rarity +%")]
		KilledMonsterDroppedItemRarityPosPct = 1288,

		[Description("Killed Monster Dropped Item Quantity +%")]
		KilledMonsterDroppedItemQuantityPosPct = 1289,

		[Description("Burning Damage Taken +%")]
		BurningDamageTakenPosPct = 1290,

		[Description("Curse Effect On Self +%")]
		CurseEffectOnSelfPosPct = 1291,

		[Description("Randomly Cursed When Totems Die Curse Level")]
		RandomlyCursedWhenTotemsDieCurseLevel = 1292,

		[Description("Maximum Physical Damage To Return When Hit")]
		MaximumPhysicalDamageToReturnWhenHit = 1293,

		[Description("Maximum Fire Damage To Return When Hit")]
		MaximumFireDamageToReturnWhenHit = 1294,

		[Description("Maximum Cold Damage To Return When Hit")]
		MaximumColdDamageToReturnWhenHit = 1295,

		[Description("Maximum Lightning Damage To Return When Hit")]
		MaximumLightningDamageToReturnWhenHit = 1296,

		[Description("Maximum Chaos Damage To Return When Hit")]
		MaximumChaosDamageToReturnWhenHit = 1297,

		[Description("Minimum Physical Damage To Return When Hit")]
		MinimumPhysicalDamageToReturnWhenHit = 1298,

		[Description("Minimum Fire Damage To Return When Hit")]
		MinimumFireDamageToReturnWhenHit = 1299,

		[Description("Minimum Cold Damage To Return When Hit")]
		MinimumColdDamageToReturnWhenHit = 1300,

		[Description("Minimum Lightning Damage To Return When Hit")]
		MinimumLightningDamageToReturnWhenHit = 1301,

		[Description("Minimum Chaos Damage To Return When Hit")]
		MinimumChaosDamageToReturnWhenHit = 1302,

		[Description("Local Display Socketed Gems Get Increased Duration Level")]
		LocalDisplaySocketedGemsGetIncreasedDurationLevel = 1303,

		[Description("Summon Fire Resistance +")]
		SummonFireResistancePos = 1304,

		[Description("Summon Cold Resistance +")]
		SummonColdResistancePos = 1305,

		[Description("Summon Lightning Resistance +")]
		SummonLightningResistancePos = 1306,

		[Description("Melee Weapon Critical Strike Multiplier +")]
		MeleeWeaponCriticalStrikeMultiplierPos = 1307,

		[Description("Map Monster Skills Chain X Additional Times")]
		MapMonsterSkillsChainXAdditionalTimes = 1308,

		[Description("Local Ring Disable Other Ring")]
		LocalRingDisableOtherRing = 1309,
		[Description("Disable Ring Slot 1")] DisableRingSlot1 = 1310,
		[Description("Disable Ring Slot 2")] DisableRingSlot2 = 1311,

		[Description("Global Item Attribute Requirements +%")]
		GlobalItemAttributeRequirementsPosPct = 1312,

		[Description("Grant Kill To Target When Exploding Self")]
		GrantKillToTargetWhenExplodingSelf = 1313,
		[Description("Mana Gain Per Target")] ManaGainPerTarget = 1314,

		[Description("Animation Effect Variation")]
		AnimationEffectVariation = 1315,

		[Description("Enemy Hits Roll Low Damage")]
		EnemyHitsRollLowDamage = 1316,

		[Description("Minions Take No Actions")]
		MinionsTakeNoActions = 1317,

		[Description("Unique Loris Lantern Golden Light")]
		UniqueLorisLanternGoldenLight = 1318,

		[Description("Chaos Damage Resistance % When On Low Life")]
		ChaosDamageResistancePctWhenOnLowLife = 1319,

		[Description("Gain Power Charge For Each Quarter Life Removed")]
		GainPowerChargeForEachQuarterLifeRemoved = 1320,

		[Description("Enemy Extra Damage Rolls")]
		EnemyExtraDamageRolls = 1321,

		[Description("Enemy Extra Damage Rolls When On Low Life")]
		EnemyExtraDamageRollsWhenOnLowLife = 1322,
		[Description("Map Fixed Seed")] MapFixedSeed = 1323,

		[Description("Map Monsters Drop Ground Fire On Death Base Radius")]
		MapMonstersDropGroundFireOnDeathBaseRadius = 1324,

		[Description("Map Monsters Drop Ground Fire On Death Duration Ms")]
		MapMonstersDropGroundFireOnDeathDurationMs = 1325,

		[Description("Map Monsters Drop Ground Fire On Death % Max Damage To Deal Per Minute")]
		MapMonstersDropGroundFireOnDeathPctMaxDamageToDealPerMinute = 1326,

		[Description("Map Monsters Convert All Physical Damage To Fire")]
		MapMonstersConvertAllPhysicalDamageToFire = 1327,

		[Description("Map Players Convert All Physical Damage To Fire")]
		MapPlayersConvertAllPhysicalDamageToFire = 1328,

		[Description("Local Display Socketed Gems Have Chance To Flee %")]
		LocalDisplaySocketedGemsHaveChanceToFleePct = 1329,

		[Description("Map No Refills In Town")]
		MapNoRefillsInTown = 1330,

		[Description("Base Minimum Lightning Damage On Charge Expiry")]
		BaseMinimumLightningDamageOnChargeExpiry = 1331,

		[Description("Base Maximum Lightning Damage On Charge Expiry")]
		BaseMaximumLightningDamageOnChargeExpiry = 1332,
		[Description("Item Drops On Death")] ItemDropsOnDeath = 1333,
		[Description("Map Minimap Revealed")] MapMinimapRevealed = 1334,

		[Description("Explode On Death % Main Hand Damage To Deal As Fire")]
		ExplodeOnDeathPctMainHandDamageToDealAsFire = 1335,

		[Description("Explode On Death % Main Hand Damage To Deal As Lightning")]
		ExplodeOnDeathPctMainHandDamageToDealAsLightning = 1336,

		[Description("Explode On Death % Main Hand Damage To Deal As Cold")]
		ExplodeOnDeathPctMainHandDamageToDealAsCold = 1337,

		[Description("Explode On Death % Main Hand Damage To Deal As Chaos")]
		ExplodeOnDeathPctMainHandDamageToDealAsChaos = 1338,
		[Description("Never Shock")] NeverShock = 1339,
		[Description("Never Freeze")] NeverFreeze = 1340,
		[Description("Faster Burn %")] FasterBurnPct = 1341,
		[Description("Disable Chest Slot")] DisableChestSlot = 1342,

		[Description("Local Display Socketed Gems Get Faster Attacks Level")]
		LocalDisplaySocketedGemsGetFasterAttacksLevel = 1343,

		[Description("Local Display Socketed Gems Get Melee Physical Damage Level")]
		LocalDisplaySocketedGemsGetMeleePhysicalDamageLevel = 1344,
		[Description("Flasks Dispel Burning")] FlasksDispelBurning = 1345,

		[Description("Physical Claw Damage +% When On Low Life")]
		PhysicalClawDamagePosPctWhenOnLowLife = 1346,

		[Description("Accuracy Rating +% When On Low Life")]
		AccuracyRatingPosPctWhenOnLowLife = 1347,
		[Description("Cannot Leech")] CannotLeech = 1348,

		[Description("Cannot Leech When On Low Life")]
		CannotLeechWhenOnLowLife = 1349,

		[Description("Base Cannot Leech Life")]
		BaseCannotLeechLife = 1350,

		[Description("Base Cannot Leech Mana")]
		BaseCannotLeechMana = 1351,
		[Description("Cannot Leech Life")] CannotLeechLife = 1352,
		[Description("Cannot Leech Mana")] CannotLeechMana = 1353,

		[Description("Base Energy Shield Gained On Enemy Death")]
		BaseEnergyShieldGainedOnEnemyDeath = 1354,

		[Description("Summon Totem Cast Speed +%")]
		SummonTotemCastSpeedPosPct = 1355,

		[Description("Consecrate On Block % Chance To Create")]
		ConsecrateOnBlockPctChanceToCreate = 1356,

		[Description("Consecrate On Block % Life Regen Per Minute")]
		ConsecrateOnBlockPctLifeRegenPerMinute = 1357,

		[Description("Consecrate On Block Base Radius")]
		ConsecrateOnBlockBaseRadius = 1358,

		[Description("Consecrate On Block Duration Ms")]
		ConsecrateOnBlockDurationMs = 1359,

		[Description("Desecrate On Block % Chance To Create")]
		DesecrateOnBlockPctChanceToCreate = 1360,

		[Description("Desecrate On Block Base Chaos Damage To Deal Per Minute")]
		DesecrateOnBlockBaseChaosDamageToDealPerMinute = 1361,

		[Description("Desecrate On Block Base Radius")]
		DesecrateOnBlockBaseRadius = 1362,

		[Description("Desecrate On Block Duration Ms")]
		DesecrateOnBlockDurationMs = 1363,

		[Description("Base Chaos Damage % Of Maximum Life Taken Per Minute Per Frenzy Charge")]
		BaseChaosDamagePctOfMaximumLifeTakenPerMinutePerFrenzyCharge = 1364,

		[Description("Add Frenzy Charge On Kill % Chance")]
		AddFrenzyChargeOnKillPctChance = 1365,

		[Description("Local Socketed Elemental Gem Level +")]
		LocalSocketedElementalGemLevelPos = 1366,

		[Description("Melee Critical Strike Chance +%")]
		MeleeCriticalStrikeChancePosPct = 1367,

		[Description("Melee Critical Strike Chance +% When On Full Life")]
		MeleeCriticalStrikeChancePosPctWhenOnFullLife = 1368,

		[Description("Cannot Be Killed By Elemental Reflect")]
		CannotBeKilledByElementalReflect = 1369,

		[Description("Local Display Socketed Gems Get Added Lightning Damage Level")]
		LocalDisplaySocketedGemsGetAddedLightningDamageLevel = 1370,
		[Description("Map Is Unidentified")] MapIsUnidentified = 1371,

		[Description("Melee Attacks Usable Without Mana Cost")]
		MeleeAttacksUsableWithoutManaCost = 1372,

		[Description("Melee Attack Mana Cost +")]
		MeleeAttackManaCostPos = 1373,
		[Description("Melee Damage +%")] MeleeDamagePosPct = 1374,
		[Description("Melee Damage Taken +%")] MeleeDamageTakenPosPct = 1375,

		[Description("Map Experience Gain +%")]
		MapExperienceGainPosPct = 1376,
		[Description("Life Gained On Block")] LifeGainedOnBlock = 1377,
		[Description("Mana Gained On Block")] ManaGainedOnBlock = 1378,

		[Description("Minimum Physical Damage To Return On Block")]
		MinimumPhysicalDamageToReturnOnBlock = 1379,

		[Description("Maximum Physical Damage To Return On Block")]
		MaximumPhysicalDamageToReturnOnBlock = 1380,

		[Description("Footstep Effect Variation")]
		FootstepEffectVariation = 1381,
		[Description("Zombie Maximum Life +")] ZombieMaximumLifePos = 1382,

		[Description("Number Of Zombies Allowed +%")]
		NumberOfZombiesAllowedPosPct = 1383,

		[Description("Zombie Chaos Elemental Damage Resistance %")]
		ZombieChaosElementalDamageResistancePct = 1384,

		[Description("Chill And Freeze Duration Based On % Energy Shield")]
		ChillAndFreezeDurationBasedOnPctEnergyShield = 1385,

		[Description("Number Of Equipped Uniques")]
		NumberOfEquippedUniques = 1386,

		[Description("Intelligence +% Per Equipped Unique")]
		IntelligencePosPctPerEquippedUnique = 1387,

		[Description("Ignited Enemies Explode On Kill")]
		IgnitedEnemiesExplodeOnKill = 1388,

		[Description("Additional Scroll Of Wisdom Drop Chance %")]
		AdditionalScrollOfWisdomDropChancePct = 1389,

		[Description("Explode On Kill % Fire Damage To Deal")]
		ExplodeOnKillPctFireDamageToDeal = 1390,

		[Description("Zombie Explode On Kill % Fire Damage To Deal")]
		ZombieExplodeOnKillPctFireDamageToDeal = 1391,

		[Description("Local Unique Flask Item Rarity +% While Healing")]
		LocalUniqueFlaskItemRarityPosPctWhileHealing = 1392,

		[Description("Local Unique Flask Item Quantity +% While Healing")]
		LocalUniqueFlaskItemQuantityPosPctWhileHealing = 1393,

		[Description("Local Unique Flask Light Radius +% While Healing")]
		LocalUniqueFlaskLightRadiusPosPctWhileHealing = 1394,

		[Description("Local Unique Flask Additional Maximum All Elemental Resistances % While Healing")]
		LocalUniqueFlaskAdditionalMaximumAllElementalResistancesPctWhileHealing = 1395,

		[Description("Additional Strength And Intelligence")]
		AdditionalStrengthAndIntelligence = 1396,

		[Description("Additional Strength And Dexterity")]
		AdditionalStrengthAndDexterity = 1397,

		[Description("Additional Dexterity And Intelligence")]
		AdditionalDexterityAndIntelligence = 1398,
		[Description("Curse Effect +%")] CurseEffectPosPct = 1399,

		[Description("Nonfunctional Old Stat Map Monster Movement Velocity Cap")]
		NonfunctionalOldStatMapMonsterMovementVelocityCap = 1400,

		[Description("Movement Velocity +% While Cursed")]
		MovementVelocityPosPctWhileCursed = 1401,

		[Description("Map Spawn Exile Per Area %")]
		MapSpawnExilePerAreaPct = 1402,

		[Description("Cyclone Extra Distance")]
		CycloneExtraDistance = 1403,

		[Description("Zombie Boss Extract Life % To Gain")]
		ZombieBossExtractLifePctToGain = 1404,

		[Description("Life Regeneration Rate Per Minute % Per Frenzy Charge")]
		LifeRegenerationRatePerMinutePctPerFrenzyCharge = 1405,

		[Description("Enemy On Low Life Damage Taken +% Per Frenzy Charge")]
		EnemyOnLowLifeDamageTakenPosPctPerFrenzyCharge = 1406,

		[Description("Movement Velocity +% Per Ten Levels")]
		MovementVelocityPosPctPerTenLevels = 1407,

		[Description("Enemy On Low Life Damage Taken +%")]
		EnemyOnLowLifeDamageTakenPosPct = 1408,

		[Description("Add Power Charge On Kill % Chance")]
		AddPowerChargeOnKillPctChance = 1409,

		[Description("Gain Endurance Charge On Power Charge Expiry")]
		GainEnduranceChargeOnPowerChargeExpiry = 1410,

		[Description("Melee Damage +% When On Full Life")]
		MeleeDamagePosPctWhenOnFullLife = 1411,

		[Description("Consecrate On Crit % Chance To Create")]
		ConsecrateOnCritPctChanceToCreate = 1412,
		[Description("Projectile Speed +%")] ProjectileSpeedPosPct = 1413,

		[Description("Projectile Speed +% Per Frenzy Charge")]
		ProjectileSpeedPosPctPerFrenzyCharge = 1414,

		[Description("Projectile Damage +% Per Power Charge")]
		ProjectileDamagePosPctPerPowerCharge = 1415,

		[Description("Killed Monster Dropped Item Rarity +% On Crit")]
		KilledMonsterDroppedItemRarityPosPctOnCrit = 1416,

		[Description("Onslaught Buff Duration On Kill Ms")]
		OnslaughtBuffDurationOnKillMs = 1417,

		[Description("Local Right Ring Slot No Mana Regeneration")]
		LocalRightRingSlotNoManaRegeneration = 1418,

		[Description("Local Right Ring Slot Base Energy Shield Regeneration Rate Per Minute %")]
		LocalRightRingSlotBaseEnergyShieldRegenerationRatePerMinutePct = 1419,

		[Description("Local Left Ring Slot Mana Regeneration Rate +%")]
		LocalLeftRingSlotManaRegenerationRatePosPct = 1420,

		[Description("Local Left Ring Slot No Energy Shield Recharge Or Regeneration")]
		LocalLeftRingSlotNoEnergyShieldRechargeOrRegeneration = 1421,

		[Description("No Energy Shield Recharge Or Regeneration")]
		NoEnergyShieldRechargeOrRegeneration = 1422,

		[Description("Base Energy Shield Regeneration Rate Per Minute %")]
		BaseEnergyShieldRegenerationRatePerMinutePct = 1423,

		[Description("Character Sheet Monster Level")]
		CharacterSheetMonsterLevel = 1424,

		[Description("Keystone Acrobatics Energy Shield +% Final")]
		KeystoneAcrobaticsEnergyShieldPosPctFinal = 1425,

		[Description("Keystone Acrobatics Physical Damage Reduction Rating +% Final")]
		KeystoneAcrobaticsPhysicalDamageReductionRatingPosPctFinal = 1426,

		[Description("Life Recovery Per Minute From Leech")]
		LifeRecoveryPerMinuteFromLeech = 1427,

		[Description("Mana Recovery Per Minute From Leech")]
		ManaRecoveryPerMinuteFromLeech = 1428,

		[Description("Energy Shield Recovery Per Minute From Leech")]
		EnergyShieldRecoveryPerMinuteFromLeech = 1429,

		[Description("Life Recovery Per Minute")]
		LifeRecoveryPerMinute = 1430,

		[Description("Mana Recovery Per Minute")]
		ManaRecoveryPerMinute = 1431,

		[Description("Energy Shield Recovery Per Minute")]
		EnergyShieldRecoveryPerMinute = 1432,
		[Description("Extra Critical Rolls")] ExtraCriticalRolls = 1433,

		[Description("Combined All Damage +%")]
		CombinedAllDamagePosPct = 1434,

		[Description("Combined All Damage +% Final")]
		CombinedAllDamagePosPctFinal = 1435,

		[Description("Combined Spell All Damage +%")]
		CombinedSpellAllDamagePosPct = 1436,

		[Description("Combined Spell All Damage +% Final")]
		CombinedSpellAllDamagePosPctFinal = 1437,

		[Description("Combined Attack All Damage +%")]
		CombinedAttackAllDamagePosPct = 1438,

		[Description("Combined Attack All Damage +% Final")]
		CombinedAttackAllDamagePosPctFinal = 1439,

		[Description("Combined Main Hand Attack All Damage +%")]
		CombinedMainHandAttackAllDamagePosPct = 1440,

		[Description("Combined Off Hand Attack All Damage +%")]
		CombinedOffHandAttackAllDamagePosPct = 1441,

		[Description("Combined Physical Damage +%")]
		CombinedPhysicalDamagePosPct = 1442,

		[Description("Combined Physical Damage +% Final")]
		CombinedPhysicalDamagePosPctFinal = 1443,

		[Description("Combined Attack Physical Damage +%")]
		CombinedAttackPhysicalDamagePosPct = 1444,

		[Description("Combined Attack Physical Damage +% Final")]
		CombinedAttackPhysicalDamagePosPctFinal = 1445,

		[Description("Combined Main Hand Attack Physical Damage +%")]
		CombinedMainHandAttackPhysicalDamagePosPct = 1446,

		[Description("Combined Off Hand Attack Physical Damage +%")]
		CombinedOffHandAttackPhysicalDamagePosPct = 1447,

		[Description("Combined Main Hand Attack Physical Damage +% Final")]
		CombinedMainHandAttackPhysicalDamagePosPctFinal = 1448,

		[Description("Combined Off Hand Attack Physical Damage +% Final")]
		CombinedOffHandAttackPhysicalDamagePosPctFinal = 1449,

		[Description("Combined Fire Damage +%")]
		CombinedFireDamagePosPct = 1450,

		[Description("Combined Fire Damage +% Final")]
		CombinedFireDamagePosPctFinal = 1451,

		[Description("Combined Cold Damage +%")]
		CombinedColdDamagePosPct = 1452,

		[Description("Combined Cold Damage +% Final")]
		CombinedColdDamagePosPctFinal = 1453,

		[Description("Combined Lightning Damage +%")]
		CombinedLightningDamagePosPct = 1454,

		[Description("Combined Lightning Damage +% Final")]
		CombinedLightningDamagePosPctFinal = 1455,

		[Description("Combined Chaos Damage +%")]
		CombinedChaosDamagePosPct = 1456,

		[Description("Combined Chaos Damage +% Final")]
		CombinedChaosDamagePosPctFinal = 1457,

		[Description("Combined Elemental Damage +%")]
		CombinedElementalDamagePosPct = 1458,

		[Description("Combined Elemental Damage +% Final")]
		CombinedElementalDamagePosPctFinal = 1459,

		[Description("Combined Attack Fire Damage +%")]
		CombinedAttackFireDamagePosPct = 1460,

		[Description("Combined Attack Fire Damage +% Final")]
		CombinedAttackFireDamagePosPctFinal = 1461,

		[Description("Combined Attack Cold Damage +%")]
		CombinedAttackColdDamagePosPct = 1462,

		[Description("Combined Attack Cold Damage +% Final")]
		CombinedAttackColdDamagePosPctFinal = 1463,

		[Description("Combined Spell Fire Damage +%")]
		CombinedSpellFireDamagePosPct = 1464,

		[Description("Combined Spell Fire Damage +% Final")]
		CombinedSpellFireDamagePosPctFinal = 1465,

		[Description("Combined Spell Cold Damage +%")]
		CombinedSpellColdDamagePosPct = 1466,

		[Description("Combined Spell Lightning Damage +%")]
		CombinedSpellLightningDamagePosPct = 1467,

		[Description("Combined Spell Lightning Damage +% Final")]
		CombinedSpellLightningDamagePosPctFinal = 1468,

		[Description("Combined Spell Elemental Damage +%")]
		CombinedSpellElementalDamagePosPct = 1469,

		[Description("Combined Spell Elemental Damage +% Final")]
		CombinedSpellElementalDamagePosPctFinal = 1470,

		[Description("Combined Main Hand Attack Elemental Damage +%")]
		CombinedMainHandAttackElementalDamagePosPct = 1471,

		[Description("Combined Off Hand Attack Elemental Damage +%")]
		CombinedOffHandAttackElementalDamagePosPct = 1472,

		[Description("Combined Main Hand Attack Elemental Damage +% Final")]
		CombinedMainHandAttackElementalDamagePosPctFinal = 1473,

		[Description("Combined Off Hand Attack Elemental Damage +% Final")]
		CombinedOffHandAttackElementalDamagePosPctFinal = 1474,

		[Description("Combined Main Hand Attack Fire Damage +%")]
		CombinedMainHandAttackFireDamagePosPct = 1475,

		[Description("Combined Off Hand Attack Fire Damage +%")]
		CombinedOffHandAttackFireDamagePosPct = 1476,

		[Description("Combined Main Hand Attack Cold Damage +%")]
		CombinedMainHandAttackColdDamagePosPct = 1477,

		[Description("Combined Off Hand Attack Cold Damage +%")]
		CombinedOffHandAttackColdDamagePosPct = 1478,

		[Description("Combined Main Hand Attack Lightning Damage +%")]
		CombinedMainHandAttackLightningDamagePosPct = 1479,

		[Description("Combined Off Hand Attack Lightning Damage +%")]
		CombinedOffHandAttackLightningDamagePosPct = 1480,

		[Description("Combined Main Hand Attack Chaos Damage +%")]
		CombinedMainHandAttackChaosDamagePosPct = 1481,

		[Description("Combined Off Hand Attack Chaos Damage +%")]
		CombinedOffHandAttackChaosDamagePosPct = 1482,

		[Description("Spell Minimum Base Physical Damage")]
		SpellMinimumBasePhysicalDamage = 1483,

		[Description("Spell Maximum Base Physical Damage")]
		SpellMaximumBasePhysicalDamage = 1484,

		[Description("Spell Minimum Base Fire Damage")]
		SpellMinimumBaseFireDamage = 1485,

		[Description("Spell Maximum Base Fire Damage")]
		SpellMaximumBaseFireDamage = 1486,

		[Description("Spell Minimum Base Cold Damage")]
		SpellMinimumBaseColdDamage = 1487,

		[Description("Spell Maximum Base Cold Damage")]
		SpellMaximumBaseColdDamage = 1488,

		[Description("Spell Minimum Base Lightning Damage")]
		SpellMinimumBaseLightningDamage = 1489,

		[Description("Spell Maximum Base Lightning Damage")]
		SpellMaximumBaseLightningDamage = 1490,

		[Description("Spell Minimum Base Chaos Damage")]
		SpellMinimumBaseChaosDamage = 1491,

		[Description("Spell Maximum Base Chaos Damage")]
		SpellMaximumBaseChaosDamage = 1492,
		[Description("Is Projectile")] IsProjectile = 1493,
		[Description("Attack Is Melee")] AttackIsMelee = 1494,

		[Description("Base Lightning Damage % To Convert To Fire")]
		BaseLightningDamagePctToConvertToFire = 1495,

		[Description("Base Lightning Damage % To Convert To Cold")]
		BaseLightningDamagePctToConvertToCold = 1496,

		[Description("Base Fire Damage % To Convert To Chaos")]
		BaseFireDamagePctToConvertToChaos = 1497,

		[Description("Base Cold Damage % To Convert To Chaos")]
		BaseColdDamagePctToConvertToChaos = 1498,

		[Description("Base Lightning Damage % To Convert To Chaos")]
		BaseLightningDamagePctToConvertToChaos = 1499,

		[Description("Skill Lightning Damage % To Convert To Fire")]
		SkillLightningDamagePctToConvertToFire = 1500,

		[Description("Skill Lightning Damage % To Convert To Cold")]
		SkillLightningDamagePctToConvertToCold = 1501,

		[Description("Skill Fire Damage % To Convert To Chaos")]
		SkillFireDamagePctToConvertToChaos = 1502,

		[Description("Skill Cold Damage % To Convert To Chaos")]
		SkillColdDamagePctToConvertToChaos = 1503,

		[Description("Skill Lightning Damage % To Convert To Chaos")]
		SkillLightningDamagePctToConvertToChaos = 1504,

		[Description("Lightning Damage % To Convert To Fire")]
		LightningDamagePctToConvertToFire = 1505,

		[Description("Lightning Damage % To Convert To Cold")]
		LightningDamagePctToConvertToCold = 1506,

		[Description("Fire Damage % To Convert To Chaos")]
		FireDamagePctToConvertToChaos = 1507,

		[Description("Cold Damage % To Convert To Chaos")]
		ColdDamagePctToConvertToChaos = 1508,

		[Description("Lightning Damage % To Convert To Chaos")]
		LightningDamagePctToConvertToChaos = 1509,

		[Description("Physical Damage % Lost To Conversion")]
		PhysicalDamagePctLostToConversion = 1510,

		[Description("Fire Damage % Lost To Conversion")]
		FireDamagePctLostToConversion = 1511,

		[Description("Cold Damage % Lost To Conversion")]
		ColdDamagePctLostToConversion = 1512,

		[Description("Lightning Damage % Lost To Conversion")]
		LightningDamagePctLostToConversion = 1513,

		[Description("Chaos Damage % Lost To Conversion")]
		ChaosDamagePctLostToConversion = 1514,

		[Description("Fire Damage % To Add As Chaos")]
		FireDamagePctToAddAsChaos = 1515,

		[Description("Cold Damage % To Add As Fire")]
		ColdDamagePctToAddAsFire = 1516,

		[Description("Cold Damage % To Add As Chaos")]
		ColdDamagePctToAddAsChaos = 1517,

		[Description("Lightning Damage % To Add As Fire")]
		LightningDamagePctToAddAsFire = 1518,

		[Description("Lightning Damage % To Add As Cold")]
		LightningDamagePctToAddAsCold = 1519,

		[Description("Lightning Damage % To Add As Chaos")]
		LightningDamagePctToAddAsChaos = 1520,

		[Description("Total Physical Damage % As Fire")]
		TotalPhysicalDamagePctAsFire = 1521,

		[Description("Total Physical Damage % As Cold")]
		TotalPhysicalDamagePctAsCold = 1522,

		[Description("Total Physical Damage % As Lightning")]
		TotalPhysicalDamagePctAsLightning = 1523,

		[Description("Total Physical Damage % As Chaos")]
		TotalPhysicalDamagePctAsChaos = 1524,

		[Description("Total Lightning Damage % As Fire")]
		TotalLightningDamagePctAsFire = 1525,

		[Description("Total Lightning Damage % As Cold")]
		TotalLightningDamagePctAsCold = 1526,

		[Description("Total Lightning Damage % As Chaos")]
		TotalLightningDamagePctAsChaos = 1527,

		[Description("Total Cold Damage % As Fire")]
		TotalColdDamagePctAsFire = 1528,

		[Description("Total Cold Damage % As Chaos")]
		TotalColdDamagePctAsChaos = 1529,

		[Description("Total Fire Damage % As Chaos")]
		TotalFireDamagePctAsChaos = 1530,

		[Description("Secondary Minimum Base Physical Damage")]
		SecondaryMinimumBasePhysicalDamage = 1531,

		[Description("Secondary Maximum Base Physical Damage")]
		SecondaryMaximumBasePhysicalDamage = 1532,

		[Description("Secondary Minimum Base Fire Damage")]
		SecondaryMinimumBaseFireDamage = 1533,

		[Description("Secondary Maximum Base Fire Damage")]
		SecondaryMaximumBaseFireDamage = 1534,

		[Description("Secondary Minimum Base Cold Damage")]
		SecondaryMinimumBaseColdDamage = 1535,

		[Description("Secondary Maximum Base Cold Damage")]
		SecondaryMaximumBaseColdDamage = 1536,

		[Description("Secondary Minimum Base Lightning Damage")]
		SecondaryMinimumBaseLightningDamage = 1537,

		[Description("Secondary Maximum Base Lightning Damage")]
		SecondaryMaximumBaseLightningDamage = 1538,

		[Description("Secondary Minimum Base Chaos Damage")]
		SecondaryMinimumBaseChaosDamage = 1539,

		[Description("Secondary Maximum Base Chaos Damage")]
		SecondaryMaximumBaseChaosDamage = 1540,

		[Description("Spell Total Minimum Base Physical Damage")]
		SpellTotalMinimumBasePhysicalDamage = 1541,

		[Description("Spell Total Maximum Base Physical Damage")]
		SpellTotalMaximumBasePhysicalDamage = 1542,

		[Description("Spell Total Minimum Base Fire Damage")]
		SpellTotalMinimumBaseFireDamage = 1543,

		[Description("Spell Total Maximum Base Fire Damage")]
		SpellTotalMaximumBaseFireDamage = 1544,

		[Description("Spell Total Minimum Base Cold Damage")]
		SpellTotalMinimumBaseColdDamage = 1545,

		[Description("Spell Total Maximum Base Cold Damage")]
		SpellTotalMaximumBaseColdDamage = 1546,

		[Description("Spell Total Minimum Base Lightning Damage")]
		SpellTotalMinimumBaseLightningDamage = 1547,

		[Description("Spell Total Maximum Base Lightning Damage")]
		SpellTotalMaximumBaseLightningDamage = 1548,

		[Description("Spell Total Minimum Base Chaos Damage")]
		SpellTotalMinimumBaseChaosDamage = 1549,

		[Description("Spell Total Maximum Base Chaos Damage")]
		SpellTotalMaximumBaseChaosDamage = 1550,

		[Description("Spell Total Minimum Added Physical Damage")]
		SpellTotalMinimumAddedPhysicalDamage = 1551,

		[Description("Spell Total Maximum Added Physical Damage")]
		SpellTotalMaximumAddedPhysicalDamage = 1552,

		[Description("Spell Total Minimum Added Fire Damage")]
		SpellTotalMinimumAddedFireDamage = 1553,

		[Description("Spell Total Maximum Added Fire Damage")]
		SpellTotalMaximumAddedFireDamage = 1554,

		[Description("Spell Total Minimum Added Cold Damage")]
		SpellTotalMinimumAddedColdDamage = 1555,

		[Description("Spell Total Maximum Added Cold Damage")]
		SpellTotalMaximumAddedColdDamage = 1556,

		[Description("Spell Total Minimum Added Lightning Damage")]
		SpellTotalMinimumAddedLightningDamage = 1557,

		[Description("Spell Total Maximum Added Lightning Damage")]
		SpellTotalMaximumAddedLightningDamage = 1558,

		[Description("Spell Total Minimum Added Chaos Damage")]
		SpellTotalMinimumAddedChaosDamage = 1559,

		[Description("Spell Total Maximum Added Chaos Damage")]
		SpellTotalMaximumAddedChaosDamage = 1560,

		[Description("Main Hand Total Minimum Base Physical Damage")]
		MainHandTotalMinimumBasePhysicalDamage = 1561,

		[Description("Main Hand Total Maximum Base Physical Damage")]
		MainHandTotalMaximumBasePhysicalDamage = 1562,

		[Description("Main Hand Total Minimum Base Fire Damage")]
		MainHandTotalMinimumBaseFireDamage = 1563,

		[Description("Main Hand Total Maximum Base Fire Damage")]
		MainHandTotalMaximumBaseFireDamage = 1564,

		[Description("Main Hand Total Minimum Base Cold Damage")]
		MainHandTotalMinimumBaseColdDamage = 1565,

		[Description("Main Hand Total Maximum Base Cold Damage")]
		MainHandTotalMaximumBaseColdDamage = 1566,

		[Description("Main Hand Total Minimum Base Lightning Damage")]
		MainHandTotalMinimumBaseLightningDamage = 1567,

		[Description("Main Hand Total Maximum Base Lightning Damage")]
		MainHandTotalMaximumBaseLightningDamage = 1568,

		[Description("Main Hand Total Minimum Base Chaos Damage")]
		MainHandTotalMinimumBaseChaosDamage = 1569,

		[Description("Main Hand Total Maximum Base Chaos Damage")]
		MainHandTotalMaximumBaseChaosDamage = 1570,

		[Description("Main Hand Total Minimum Added Physical Damage")]
		MainHandTotalMinimumAddedPhysicalDamage = 1571,

		[Description("Main Hand Total Maximum Added Physical Damage")]
		MainHandTotalMaximumAddedPhysicalDamage = 1572,

		[Description("Main Hand Total Minimum Added Fire Damage")]
		MainHandTotalMinimumAddedFireDamage = 1573,

		[Description("Main Hand Total Maximum Added Fire Damage")]
		MainHandTotalMaximumAddedFireDamage = 1574,

		[Description("Main Hand Total Minimum Added Cold Damage")]
		MainHandTotalMinimumAddedColdDamage = 1575,

		[Description("Main Hand Total Maximum Added Cold Damage")]
		MainHandTotalMaximumAddedColdDamage = 1576,

		[Description("Main Hand Total Minimum Added Lightning Damage")]
		MainHandTotalMinimumAddedLightningDamage = 1577,

		[Description("Main Hand Total Maximum Added Lightning Damage")]
		MainHandTotalMaximumAddedLightningDamage = 1578,

		[Description("Main Hand Total Minimum Added Chaos Damage")]
		MainHandTotalMinimumAddedChaosDamage = 1579,

		[Description("Main Hand Total Maximum Added Chaos Damage")]
		MainHandTotalMaximumAddedChaosDamage = 1580,

		[Description("Off Hand Total Minimum Base Physical Damage")]
		OffHandTotalMinimumBasePhysicalDamage = 1581,

		[Description("Off Hand Total Maximum Base Physical Damage")]
		OffHandTotalMaximumBasePhysicalDamage = 1582,

		[Description("Off Hand Total Minimum Base Fire Damage")]
		OffHandTotalMinimumBaseFireDamage = 1583,

		[Description("Off Hand Total Maximum Base Fire Damage")]
		OffHandTotalMaximumBaseFireDamage = 1584,

		[Description("Off Hand Total Minimum Base Cold Damage")]
		OffHandTotalMinimumBaseColdDamage = 1585,

		[Description("Off Hand Total Maximum Base Cold Damage")]
		OffHandTotalMaximumBaseColdDamage = 1586,

		[Description("Off Hand Total Minimum Base Lightning Damage")]
		OffHandTotalMinimumBaseLightningDamage = 1587,

		[Description("Off Hand Total Maximum Base Lightning Damage")]
		OffHandTotalMaximumBaseLightningDamage = 1588,

		[Description("Off Hand Total Minimum Base Chaos Damage")]
		OffHandTotalMinimumBaseChaosDamage = 1589,

		[Description("Off Hand Total Maximum Base Chaos Damage")]
		OffHandTotalMaximumBaseChaosDamage = 1590,

		[Description("Off Hand Total Minimum Added Physical Damage")]
		OffHandTotalMinimumAddedPhysicalDamage = 1591,

		[Description("Off Hand Total Maximum Added Physical Damage")]
		OffHandTotalMaximumAddedPhysicalDamage = 1592,

		[Description("Off Hand Total Minimum Added Fire Damage")]
		OffHandTotalMinimumAddedFireDamage = 1593,

		[Description("Off Hand Total Maximum Added Fire Damage")]
		OffHandTotalMaximumAddedFireDamage = 1594,

		[Description("Off Hand Total Minimum Added Cold Damage")]
		OffHandTotalMinimumAddedColdDamage = 1595,

		[Description("Off Hand Total Maximum Added Cold Damage")]
		OffHandTotalMaximumAddedColdDamage = 1596,

		[Description("Off Hand Total Minimum Added Lightning Damage")]
		OffHandTotalMinimumAddedLightningDamage = 1597,

		[Description("Off Hand Total Maximum Added Lightning Damage")]
		OffHandTotalMaximumAddedLightningDamage = 1598,

		[Description("Off Hand Total Minimum Added Chaos Damage")]
		OffHandTotalMinimumAddedChaosDamage = 1599,

		[Description("Off Hand Total Maximum Added Chaos Damage")]
		OffHandTotalMaximumAddedChaosDamage = 1600,

		[Description("Spell Minimum Added Physical Damage")]
		SpellMinimumAddedPhysicalDamage = 1601,

		[Description("Spell Maximum Added Physical Damage")]
		SpellMaximumAddedPhysicalDamage = 1602,

		[Description("Spell Minimum Added Fire Damage")]
		SpellMinimumAddedFireDamage = 1603,

		[Description("Spell Maximum Added Fire Damage")]
		SpellMaximumAddedFireDamage = 1604,

		[Description("Spell Minimum Added Cold Damage")]
		SpellMinimumAddedColdDamage = 1605,

		[Description("Spell Maximum Added Cold Damage")]
		SpellMaximumAddedColdDamage = 1606,

		[Description("Spell Minimum Added Lightning Damage")]
		SpellMinimumAddedLightningDamage = 1607,

		[Description("Spell Maximum Added Lightning Damage")]
		SpellMaximumAddedLightningDamage = 1608,

		[Description("Spell Minimum Added Chaos Damage")]
		SpellMinimumAddedChaosDamage = 1609,

		[Description("Spell Maximum Added Chaos Damage")]
		SpellMaximumAddedChaosDamage = 1610,

		[Description("Total Base Life Regeneration Rate Per Minute %")]
		TotalBaseLifeRegenerationRatePerMinutePct = 1611,

		[Description("Total Base Life Regeneration Rate Per Minute")]
		TotalBaseLifeRegenerationRatePerMinute = 1612,

		[Description("Total Base Maximum Energy Shield")]
		TotalBaseMaximumEnergyShield = 1613,

		[Description("Combined Energy Shield +%")]
		CombinedEnergyShieldPosPct = 1614,

		[Description("Combined Energy Shield From Shield +%")]
		CombinedEnergyShieldFromShieldPosPct = 1615,

		[Description("Combined Energy Shield +% Final")]
		CombinedEnergyShieldPosPctFinal = 1616,

		[Description("Total Base Evasion Rating")]
		TotalBaseEvasionRating = 1617,

		[Description("Combined Evasion Rating +%")]
		CombinedEvasionRatingPosPct = 1618,

		[Description("Combined Evasion Rating From Shield +%")]
		CombinedEvasionRatingFromShieldPosPct = 1619,

		[Description("Movement Velocity +1% Per X Evasion Rating")]
		MovementVelocityPos1PctPerXEvasionRating = 1620,

		[Description("Local Display Socketed Gems Have % Chance To Ignite With Fire Damage")]
		LocalDisplaySocketedGemsHavePctChanceToIgniteWithFireDamage = 1621,

		[Description("Cannot Freeze Shock Ignite On Critical")]
		CannotFreezeShockIgniteOnCritical = 1622,

		[Description("No Critical Strike Multiplier")]
		NoCriticalStrikeMultiplier = 1623,

		[Description("Onslaught On Crit Duration Ms")]
		OnslaughtOnCritDurationMs = 1624,
		[Description("Zombie Scale +%")] ZombieScalePosPct = 1625,

		[Description("Zombie Physical Damage +%")]
		ZombiePhysicalDamagePosPct = 1626,

		[Description("Faster Burn From Attacks %")]
		FasterBurnFromAttacksPct = 1627,

		[Description("Weapon Elemental Damage +% Per Power Charge")]
		WeaponElementalDamagePosPctPerPowerCharge = 1628,

		[Description("Apply Linked Curses On Hit %")]
		ApplyLinkedCursesOnHitPct = 1629,
		[Description("Cannot Cast Curses")] CannotCastCurses = 1630,

		[Description("Spell Damage Modifiers Apply To Attack Damage")]
		SpellDamageModifiersApplyToAttackDamage = 1631,

		[Description("Spell Damage +% From Dexterity")]
		SpellDamagePosPctFromDexterity = 1632,
		[Description("Agile Will")] AgileWill = 1633,

		[Description("Old Do Not Use Mana Leech From Physical Damage % Per Power Charge")]
		OldDoNotUseManaLeechFromPhysicalDamagePctPerPowerCharge = 1634,

		[Description("Chaos Damage Can Shock")]
		ChaosDamageCanShock = 1635,

		[Description("Physical Damage Can Chill")]
		PhysicalDamageCanChill = 1636,

		[Description("Killed Monster Dropped Item Quantity +% When Frozen")]
		KilledMonsterDroppedItemQuantityPosPctWhenFrozen = 1637,

		[Description("Killed Monster Dropped Item Rarity +% When Shocked")]
		KilledMonsterDroppedItemRarityPosPctWhenShocked = 1638,

		[Description("Local Flask Removes % Maximum Energy Shield On Use")]
		LocalFlaskRemovesPctMaximumEnergyShieldOnUse = 1639,

		[Description("Local Flask Deals % Maximum Life As Chaos Damage On Use")]
		LocalFlaskDealsPctMaximumLifeAsChaosDamageOnUse = 1640,

		[Description("Local Flask Gain Power Charges On Use")]
		LocalFlaskGainPowerChargesOnUse = 1641,

		[Description("Local Flask Gain Frenzy Charges On Use")]
		LocalFlaskGainFrenzyChargesOnUse = 1642,

		[Description("Local Flask Gain Endurance Charges On Use")]
		LocalFlaskGainEnduranceChargesOnUse = 1643,

		[Description("Deaths Oath Debuff On Kill Duration Ms")]
		DeathsOathDebuffOnKillDurationMs = 1644,

		[Description("Deaths Oath Debuff On Kill Base Chaos Damage To Deal Per Minute")]
		DeathsOathDebuffOnKillBaseChaosDamageToDealPerMinute = 1645,

		[Description("Local Display Aura Base Chaos Damage To Deal Per Minute")]
		LocalDisplayAuraBaseChaosDamageToDealPerMinute = 1646,

		[Description("Blood Footprints From Item")]
		BloodFootprintsFromItem = 1647,

		[Description("Demigod Footprints From Item")]
		DemigodFootprintsFromItem = 1648,

		[Description("Silver Footprints From Item")]
		SilverFootprintsFromItem = 1649,

		[Description("Projectile Homing Type")]
		ProjectileHomingType = 1650,

		[Description("Projectile Homing Range")]
		ProjectileHomingRange = 1651,
		[Description("Map Obas Trial")] MapObasTrial = 1652,

		[Description("Display Skill Deals Secondary Damage")]
		DisplaySkillDealsSecondaryDamage = 1653,

		[Description("Secondary Minimum Total Damage")]
		SecondaryMinimumTotalDamage = 1654,

		[Description("Secondary Maximum Total Damage")]
		SecondaryMaximumTotalDamage = 1655,

		[Description("Local Unique Counts As Dual Wielding")]
		LocalUniqueCountsAsDualWielding = 1656,

		[Description("Unique Local Minimum Added Fire Damage When In Main Hand")]
		UniqueLocalMinimumAddedFireDamageWhenInMainHand = 1657,

		[Description("Unique Local Maximum Added Fire Damage When In Main Hand")]
		UniqueLocalMaximumAddedFireDamageWhenInMainHand = 1658,

		[Description("Unique Local Minimum Added Chaos Damage When In Off Hand")]
		UniqueLocalMinimumAddedChaosDamageWhenInOffHand = 1659,

		[Description("Unique Local Maximum Added Chaos Damage When In Off Hand")]
		UniqueLocalMaximumAddedChaosDamageWhenInOffHand = 1660,

		[Description("Unique Local Minimum Added Cold Damage When In Off Hand")]
		UniqueLocalMinimumAddedColdDamageWhenInOffHand = 1661,

		[Description("Unique Local Maximum Added Cold Damage When In Off Hand")]
		UniqueLocalMaximumAddedColdDamageWhenInOffHand = 1662,

		[Description("Map Floor Unlock Time Seconds Unused")]
		MapFloorUnlockTimeSecondsUnused = 1663,

		[Description("Map Ignore Rogue Exile Rarity Bias")]
		MapIgnoreRogueExileRarityBias = 1664,

		[Description("Map Override Rogue Exile Min Level")]
		MapOverrideRogueExileMinLevel = 1665,

		[Description("Attack Speed +% Per Frenzy Charge")]
		AttackSpeedPosPctPerFrenzyCharge = 1666,

		[Description("Cast Speed +% Per Frenzy Charge")]
		CastSpeedPosPctPerFrenzyCharge = 1667,

		[Description("Attack And Cast Speed +% Per Frenzy Charge")]
		AttackAndCastSpeedPosPctPerFrenzyCharge = 1668,

		[Description("Converted Original Team")]
		ConvertedOriginalTeam = 1669,

		[Description("Damage +% Vs Enemies On Low Life Per Frenzy Charge")]
		DamagePosPctVsEnemiesOnLowLifePerFrenzyCharge = 1670,

		[Description("Damage +% Per Frenzy Charge")]
		DamagePosPctPerFrenzyCharge = 1671,

		[Description("Damage Removed From Mana Before Life %")]
		DamageRemovedFromManaBeforeLifePct = 1672,

		[Description("Local Display Aura Damage +%")]
		LocalDisplayAuraDamagePosPct = 1673,

		[Description("Attack Ignite Chance %")]
		AttackIgniteChancePct = 1674,

		[Description("Melee Damage +% Vs Frozen Enemies")]
		MeleeDamagePosPctVsFrozenEnemies = 1675,

		[Description("Melee Damage +% Vs Shocked Enemies")]
		MeleeDamagePosPctVsShockedEnemies = 1676,

		[Description("Melee Damage +% Vs Burning Enemies")]
		MeleeDamagePosPctVsBurningEnemies = 1677,

		[Description("Melee Damage Taken % To Deal To Attacker")]
		MeleeDamageTakenPctToDealToAttacker = 1678,
		[Description("Mana Gained When Hit")] ManaGainedWhenHit = 1679,

		[Description("Local Display Socketed Gems Get Reduced Mana Cost Level")]
		LocalDisplaySocketedGemsGetReducedManaCostLevel = 1680,

		[Description("Local Display Socketed Gems Get Faster Cast Level")]
		LocalDisplaySocketedGemsGetFasterCastLevel = 1681,

		[Description("Projectile Ignite Chance %")]
		ProjectileIgniteChancePct = 1682,

		[Description("Projectile Freeze Chance %")]
		ProjectileFreezeChancePct = 1683,

		[Description("Projectile Shock Chance %")]
		ProjectileShockChancePct = 1684,

		[Description("Local Off Hand Visual Identity Override Hash")]
		LocalOffHandVisualIdentityOverrideHash = 1685,

		[Description("Elemental Reflect Damage Taken +%")]
		ElementalReflectDamageTakenPosPct = 1686,

		[Description("Physical Reflect Damage Taken +%")]
		PhysicalReflectDamageTakenPosPct = 1687,

		[Description("Local Left Ring Slot Elemental Reflect Damage Taken +%")]
		LocalLeftRingSlotElementalReflectDamageTakenPosPct = 1688,

		[Description("Local Right Ring Slot Physical Reflect Damage Taken +%")]
		LocalRightRingSlotPhysicalReflectDamageTakenPosPct = 1689,

		[Description("Grace Aura Evasion Rating +% Final")]
		GraceAuraEvasionRatingPosPctFinal = 1690,
		[Description("Deal No Attack Damage")] DealNoAttackDamage = 1691,

		[Description("Deal No Main Hand Damage")]
		DealNoMainHandDamage = 1692,

		[Description("Deal No Off Hand Damage")]
		DealNoOffHandDamage = 1693,
		[Description("Deal No Spell Damage")] DealNoSpellDamage = 1694,

		[Description("Deal No Secondary Damage")]
		DealNoSecondaryDamage = 1695,

		[Description("Deal No Physical Damage")]
		DealNoPhysicalDamage = 1696,
		[Description("Deal No Fire Damage")] DealNoFireDamage = 1697,
		[Description("Deal No Cold Damage")] DealNoColdDamage = 1698,

		[Description("Deal No Lightning Damage")]
		DealNoLightningDamage = 1699,
		[Description("Deal No Chaos Damage")] DealNoChaosDamage = 1700,

		[Description("Deal No Spell Physical Damage")]
		DealNoSpellPhysicalDamage = 1701,

		[Description("Deal No Spell Fire Damage")]
		DealNoSpellFireDamage = 1702,

		[Description("Deal No Spell Cold Damage")]
		DealNoSpellColdDamage = 1703,

		[Description("Deal No Spell Lightning Damage")]
		DealNoSpellLightningDamage = 1704,

		[Description("Deal No Spell Chaos Damage")]
		DealNoSpellChaosDamage = 1705,

		[Description("Deal No Secondary Physical Damage")]
		DealNoSecondaryPhysicalDamage = 1706,

		[Description("Deal No Secondary Fire Damage")]
		DealNoSecondaryFireDamage = 1707,

		[Description("Deal No Secondary Cold Damage")]
		DealNoSecondaryColdDamage = 1708,

		[Description("Deal No Secondary Lightning Damage")]
		DealNoSecondaryLightningDamage = 1709,

		[Description("Deal No Secondary Chaos Damage")]
		DealNoSecondaryChaosDamage = 1710,

		[Description("Deal No Main Hand Physical Damage")]
		DealNoMainHandPhysicalDamage = 1711,

		[Description("Deal No Main Hand Fire Damage")]
		DealNoMainHandFireDamage = 1712,

		[Description("Deal No Main Hand Cold Damage")]
		DealNoMainHandColdDamage = 1713,

		[Description("Deal No Main Hand Lightning Damage")]
		DealNoMainHandLightningDamage = 1714,

		[Description("Deal No Main Hand Chaos Damage")]
		DealNoMainHandChaosDamage = 1715,

		[Description("Deal No Off Hand Physical Damage")]
		DealNoOffHandPhysicalDamage = 1716,

		[Description("Deal No Off Hand Fire Damage")]
		DealNoOffHandFireDamage = 1717,

		[Description("Deal No Off Hand Cold Damage")]
		DealNoOffHandColdDamage = 1718,

		[Description("Deal No Off Hand Lightning Damage")]
		DealNoOffHandLightningDamage = 1719,

		[Description("Deal No Off Hand Chaos Damage")]
		DealNoOffHandChaosDamage = 1720,

		[Description("Base Deal No Main Hand Damage")]
		BaseDealNoMainHandDamage = 1721,

		[Description("Base Deal No Off Hand Damage")]
		BaseDealNoOffHandDamage = 1722,

		[Description("Base Deal No Spell Damage")]
		BaseDealNoSpellDamage = 1723,

		[Description("Base Deal No Secondary Damage")]
		BaseDealNoSecondaryDamage = 1724,

		[Description("Base Deal No Attack Damage")]
		BaseDealNoAttackDamage = 1725,

		[Description("Base Deal No Physical Damage")]
		BaseDealNoPhysicalDamage = 1726,

		[Description("Base Deal No Fire Damage")]
		BaseDealNoFireDamage = 1727,

		[Description("Base Deal No Cold Damage")]
		BaseDealNoColdDamage = 1728,

		[Description("Base Deal No Lightning Damage")]
		BaseDealNoLightningDamage = 1729,

		[Description("Base Deal No Chaos Damage")]
		BaseDealNoChaosDamage = 1730,

		[Description("Local Can Only Deal Damage With This Weapon")]
		LocalCanOnlyDealDamageWithThisWeapon = 1731,

		[Description("Reave Area Of Effect +% Final Per Stage")]
		ReaveAreaOfEffectPosPctFinalPerStage = 1732,

		[Description("Skill Can Add Multiple Charges Per Action")]
		SkillCanAddMultipleChargesPerAction = 1733,
		[Description("Local Charges Used +%")] LocalChargesUsedPosPct = 1734,

		[Description("Non Critical Damage Multiplier +%")]
		NonCriticalDamageMultiplierPosPct = 1735,
		[Description("Skill Sound Variation")] SkillSoundVariation = 1736,

		[Description("Unique Map Boss Number Of Rare Items To Drop")]
		UniqueMapBossNumberOfRareItemsToDrop = 1737,

		[Description("Unique Map Boss Class Of Rare Items To Drop")]
		UniqueMapBossClassOfRareItemsToDrop = 1738,

		[Description("Base Cold Damage To Deal Per Minute")]
		BaseColdDamageToDealPerMinute = 1739,

		[Description("Number Of Totems Summoned In Formation")]
		NumberOfTotemsSummonedInFormation = 1740,

		[Description("Supported Active Skill Gem Level +")]
		SupportedActiveSkillGemLevelPos = 1741,
		[Description("Shock Art Variation")] ShockArtVariation = 1742,

		[Description("Support Multicast Cast Speed +% Final")]
		SupportMulticastCastSpeedPosPctFinal = 1743,

		[Description("Global Attack Speed +% Per Green Socket On Item")]
		GlobalAttackSpeedPosPctPerGreenSocketOnItem = 1744,

		[Description("Global Weapon Physical Damage +% Per Red Socket On Item")]
		GlobalWeaponPhysicalDamagePosPctPerRedSocketOnItem = 1745,

		[Description("Old Do Not Use Global Mana Leech From Physical Attack Damage % Per Blue Socket On Item")]
		OldDoNotUseGlobalManaLeechFromPhysicalAttackDamagePctPerBlueSocketOnItem = 1746,

		[Description("Global Melee Range + Per White Socket On Item")]
		GlobalMeleeRangePosPerWhiteSocketOnItem = 1747,

		[Description("Spell Damage +% Per 5% Block Chance")]
		SpellDamagePosPctPer5PctBlockChance = 1748,

		[Description("Base Life Gained On Spell Hit")]
		BaseLifeGainedOnSpellHit = 1749,

		[Description("Armour % To Leech As Life On Block")]
		ArmourPctToLeechAsLifeOnBlock = 1750,

		[Description("Energy Shield % To Lose On Block")]
		EnergyShieldPctToLoseOnBlock = 1751,

		[Description("Light Radius Scales With Energy Shield")]
		LightRadiusScalesWithEnergyShield = 1752,
		[Description("Fishing Range +%")] FishingRangePosPct = 1753,

		[Description("Fishing Line Strength +%")]
		FishingLineStrengthPosPct = 1754,
		[Description("Fish Quantity +%")] FishQuantityPosPct = 1755,
		[Description("Fish Rarity +%")] FishRarityPosPct = 1756,

		[Description("Fishing Pool Consumption +%")]
		FishingPoolConsumptionPosPct = 1757,
		[Description("Fishing Lure Type")] FishingLureType = 1758,
		[Description("Fishing Hook Type")] FishingHookType = 1759,

		[Description("Cannot Be Damaged By Things Outside Radius")]
		CannotBeDamagedByThingsOutsideRadius = 1760,
		[Description("Inside Shield")] InsideShield = 1761,
		[Description("Flask Effect +%")] FlaskEffectPosPct = 1762,

		[Description("Chance To Gain Endurance Charge When Hit %")]
		ChanceToGainEnduranceChargeWhenHitPct = 1763,

		[Description("Lose All Endurance Charges When Reaching Maximum")]
		LoseAllEnduranceChargesWhenReachingMaximum = 1764,

		[Description("Gain Onslaught Ms When Reaching Maximum Endurance Charges")]
		GainOnslaughtMsWhenReachingMaximumEnduranceCharges = 1765,

		[Description("Cannot Gain Endurance Charges While Have Onslaught")]
		CannotGainEnduranceChargesWhileHaveOnslaught = 1766,
		[Description("Has Onslaught")] HasOnslaught = 1767,

		[Description("Cannot Gain Endurance Charges")]
		CannotGainEnduranceCharges = 1768,
		[Description("Local Weapon Range +")] LocalWeaponRangePos = 1769,

		[Description("Off Hand Weapon Range +")]
		OffHandWeaponRangePos = 1770,

		[Description("Main Hand Weapon Range +")]
		MainHandWeaponRangePos = 1771,
		[Description("Local Has X Sockets")] LocalHasXSockets = 1772,

		[Description("Weapon Physical Damage +%")]
		WeaponPhysicalDamagePosPct = 1773,

		[Description("Maximum Critical Strike Chance")]
		MaximumCriticalStrikeChance = 1774,

		[Description("Chilled Monsters Take +% Burning Damage")]
		ChilledMonstersTakePosPctBurningDamage = 1775,

		[Description("Unique Ignite Chance % When In Main Hand")]
		UniqueIgniteChancePctWhenInMainHand = 1776,

		[Description("Unique Chill Duration +% When In Off Hand")]
		UniqueChillDurationPosPctWhenInOffHand = 1777,

		[Description("Curse On Melee Block Level 15 Punishment")]
		CurseOnMeleeBlockLevel15Punishment = 1778,

		[Description("Curse On Projectile Block Level 15 Temporal Chains")]
		CurseOnProjectileBlockLevel15TemporalChains = 1779,

		[Description("Curse On Spell Block Level 15 Elemental Weakness")]
		CurseOnSpellBlockLevel15ElementalWeakness = 1780,

		[Description("Local Display Socketed Gems Get Item Quantity +%")]
		LocalDisplaySocketedGemsGetItemQuantityPosPct = 1781,

		[Description("Local Display Socketed Gems Get Iron Will Level")]
		LocalDisplaySocketedGemsGetIronWillLevel = 1782,

		[Description("Gain Onslaught On Stun Duration Ms")]
		GainOnslaughtOnStunDurationMs = 1783,

		[Description("Cast Linked Spells On Attack Hit %")]
		CastLinkedSpellsOnAttackHitPct = 1784,

		[Description("Spectres Have Aura Cast Attack Move Speed +%")]
		SpectresHaveAuraCastAttackMoveSpeedPosPct = 1785,

		[Description("Physical Damage Reduction Rating Per Level")]
		PhysicalDamageReductionRatingPerLevel = 1786,

		[Description("Maximum Life Per 10 Levels")]
		MaximumLifePer10Levels = 1787,

		[Description("Resist All Elements % Per 10 Levels")]
		ResistAllElementsPctPer10Levels = 1788,

		[Description("Chance To Gain Random Curse When Hit % Per 10 Levels")]
		ChanceToGainRandomCurseWhenHitPctPer10Levels = 1789,

		[Description("Chance To Gain Random Curse When Hit %")]
		ChanceToGainRandomCurseWhenHitPct = 1790,

		[Description("Curse On Hit % Flammability")]
		CurseOnHitPctFlammability = 1791,

		[Description("Support Trap Damage +% Final")]
		SupportTrapDamagePosPctFinal = 1792,

		[Description("Number Of Additional Traps To Throw")]
		NumberOfAdditionalTrapsToThrow = 1793,

		[Description("Number Of Traps To Throw")]
		NumberOfTrapsToThrow = 1794,
		[Description("Projectiles Nova")] ProjectilesNova = 1795,

		[Description("Support Multithrow Damage +% Final")]
		SupportMultithrowDamagePosPctFinal = 1796,

		[Description("Suppressing Fire Debuff Cast Speed +% Final")]
		SuppressingFireDebuffCastSpeedPosPctFinal = 1797,

		[Description("Suppressing Fire Debuff Non Melee Attack Speed +% Final")]
		SuppressingFireDebuffNonMeleeAttackSpeedPosPctFinal = 1798,
		[Description("Cast On Death %")] CastOnDeathPct = 1799,

		[Description("Accuracy Rating +% Per Frenzy Charge")]
		AccuracyRatingPosPctPerFrenzyCharge = 1800,
		[Description("Base Skill Is Trapped")] BaseSkillIsTrapped = 1801,
		[Description("Base Skill Is Mined")] BaseSkillIsMined = 1802,

		[Description("Base Skill Is Totemified")]
		BaseSkillIsTotemified = 1803,
		[Description("Trap Damage +%")] TrapDamagePosPct = 1804,
		[Description("Totem Damage +%")] TotemDamagePosPct = 1805,
		[Description("Mine Damage +%")] MineDamagePosPct = 1806,

		[Description("Monster Reverse Point Blank Damage -% At Minimum Range")]
		MonsterReversePointBlankDamageNegPctAtMinimumRange = 1807,

		[Description("Frenzy Charge Duration +% Per Frenzy Charge")]
		FrenzyChargeDurationPosPctPerFrenzyCharge = 1808,

		[Description("Virtual Frenzy Charge Duration +%")]
		VirtualFrenzyChargeDurationPosPct = 1809,

		[Description("Attacks Poison While At Max Frenzy Charges")]
		AttacksPoisonWhileAtMaxFrenzyCharges = 1810,
		[Description("Attacks Poison")] AttacksPoison = 1811,

		[Description("Gain Endurance Charge On Melee Stun")]
		GainEnduranceChargeOnMeleeStun = 1812,

		[Description("Damage Taken +% Vs Demons")]
		DamageTakenPosPctVsDemons = 1813,
		[Description("Damage +% Vs Demons")] DamagePosPctVsDemons = 1814,

		[Description("Local Recharge On Demon Killed")]
		LocalRechargeOnDemonKilled = 1815,

		[Description("Local Unique Flask Damage Taken +% Vs Demons While Healing")]
		LocalUniqueFlaskDamageTakenPosPctVsDemonsWhileHealing = 1816,

		[Description("Local Unique Flask Damage +% Vs Demons While Healing")]
		LocalUniqueFlaskDamagePosPctVsDemonsWhileHealing = 1817,

		[Description("Chance To Apply Suppression On Hit %")]
		ChanceToApplySuppressionOnHitPct = 1818,
		[Description("Is Frozen")] IsFrozen = 1819,
		[Description("Is Chilled")] IsChilled = 1820,
		[Description("Is Ignited")] IsIgnited = 1821,

		[Description("Curses Reflected To Self")]
		CursesReflectedToSelf = 1822,

		[Description("Movement Speed Bonus When Throwing Trap Ms")]
		MovementSpeedBonusWhenThrowingTrapMs = 1823,

		[Description("Local Display Socketed Gems Get Trap Level")]
		LocalDisplaySocketedGemsGetTrapLevel = 1824,

		[Description("Poison On Melee Critical Strike %")]
		PoisonOnMeleeCriticalStrikePct = 1825,

		[Description("Shocks Reflected To Self")]
		ShocksReflectedToSelf = 1826,
		[Description("Damage +% Per Shock")] DamagePosPctPerShock = 1827,

		[Description("Movement Velocity +% Per Shock")]
		MovementVelocityPosPctPerShock = 1828,

		[Description("Damage +1% Per X Strength")]
		DamagePos1PctPerXStrength = 1829,

		[Description("Physical Damage Reduction Rating +1% Per X Strength")]
		PhysicalDamageReductionRatingPos1PctPerXStrength = 1830,

		[Description("Damage +1% Per X Strength When In Main Hand")]
		DamagePos1PctPerXStrengthWhenInMainHand = 1831,

		[Description("Physical Damage Reduction Rating +1% Per X Strength When In Off Hand")]
		PhysicalDamageReductionRatingPos1PctPerXStrengthWhenInOffHand = 1832,

		[Description("Local Display Socketed Gems Get Curse Reflection")]
		LocalDisplaySocketedGemsGetCurseReflection = 1833,

		[Description("Freeze Mine Cold Resistance + While Frozen")]
		FreezeMineColdResistancePosWhileFrozen = 1834,

		[Description("Max Corrupted Blood Stacks")]
		MaxCorruptedBloodStacks = 1835,

		[Description("Current Corrupted Blood Stacks")]
		CurrentCorruptedBloodStacks = 1836,

		[Description("Physical Damage Taken Per Minute")]
		PhysicalDamageTakenPerMinute = 1837,

		[Description("Base Physical Damage Taken Per Minute Per Corrupted Blood Stack")]
		BasePhysicalDamageTakenPerMinutePerCorruptedBloodStack = 1838,

		[Description("Firestorm Drop Burning Ground Duration Ms")]
		FirestormDropBurningGroundDurationMs = 1839,

		[Description("Firestorm Base Area Of Effect +%")]
		FirestormBaseAreaOfEffectPosPct = 1840,
		[Description("Mine Duration +%")] MineDurationPosPct = 1841,

		[Description("Display Monster Spike Nova On Death Text")]
		DisplayMonsterSpikeNovaOnDeathText = 1842,

		[Description("Display Monster Ice Spear Nova On Death Text")]
		DisplayMonsterIceSpearNovaOnDeathText = 1843,
		[Description("Skill Unusable")] SkillUnusable = 1844,

		[Description("Cast Linked Spells On Attack Crit %")]
		CastLinkedSpellsOnAttackCritPct = 1845,

		[Description("Cast Linked Spells On Melee Kill %")]
		CastLinkedSpellsOnMeleeKillPct = 1846,

		[Description("Spell Uncastable If Triggerable")]
		SpellUncastableIfTriggerable = 1847,

		[Description("Mine Detonation Is Instant")]
		MineDetonationIsInstant = 1848,

		[Description("Trap Damage Penetrates % Elemental Resistance")]
		TrapDamagePenetratesPctElementalResistance = 1849,

		[Description("Mine Damage Penetrates % Elemental Resistance")]
		MineDamagePenetratesPctElementalResistance = 1850,

		[Description("Traps Invulnerable For Duration Ms")]
		TrapsInvulnerableForDurationMs = 1851,

		[Description("Mines Invulnerable For Duration Ms")]
		MinesInvulnerableForDurationMs = 1852,

		[Description("Totem Elemental Resistance %")]
		TotemElementalResistancePct = 1853,

		[Description("Totem Additional Physical Damage Reduction %")]
		TotemAdditionalPhysicalDamageReductionPct = 1854,

		[Description("Mine Detonation Radius +%")]
		MineDetonationRadiusPosPct = 1855,

		[Description("Totem Skill Cast Speed +%")]
		TotemSkillCastSpeedPosPct = 1856,

		[Description("Totem Skill Attack Speed +%")]
		TotemSkillAttackSpeedPosPct = 1857,
		[Description("Mine Laying Speed +%")] MineLayingSpeedPosPct = 1858,

		[Description("Cyclone Places Ground Ice")]
		CyclonePlacesGroundIce = 1859,

		[Description("Leap Slam Base Ground Fire Damage To Deal Per Minute")]
		LeapSlamBaseGroundFireDamageToDealPerMinute = 1860,

		[Description("Projectiles Return If No Hit Object")]
		ProjectilesReturnIfNoHitObject = 1861,
		[Description("Cast On Stunned %")] CastOnStunnedPct = 1862,

		[Description("Cast On Damage Taken %")]
		CastOnDamageTakenPct = 1863,

		[Description("Cast On Damage Taken Threshold")]
		CastOnDamageTakenThreshold = 1864,

		[Description("Deal No Non Fire Damage")]
		DealNoNonFireDamage = 1865,

		[Description("Ice Nova Places Ground Ice")]
		IceNovaPlacesGroundIce = 1866,

		[Description("Shock Nova Places X Ground Lightning Patches")]
		ShockNovaPlacesXGroundLightningPatches = 1867,

		[Description("Ignores Proximity Shield")]
		IgnoresProximityShield = 1868,
		[Description("Emerge Speed +%")] EmergeSpeedPosPct = 1869,

		[Description("Animated Armour Replace Off Hand Weapon")]
		AnimatedArmourReplaceOffHandWeapon = 1870,
		[Description("Map No Exiles")] MapNoExiles = 1871,

		[Description("Animate Item Maximum Level Requirement")]
		AnimateItemMaximumLevelRequirement = 1872,
		[Description("Phase Through Objects")] PhaseThroughObjects = 1873,
		[Description("Delete On Death")] DeleteOnDeath = 1874,

		[Description("Corpse Consumption Mana To Gain")]
		CorpseConsumptionManaToGain = 1875,

		[Description("Fixed Projectile Spread")]
		FixedProjectileSpread = 1876,

		[Description("Fire And Cold Damage Resistance %")]
		FireAndColdDamageResistancePct = 1877,

		[Description("Fire And Lightning Damage Resistance %")]
		FireAndLightningDamageResistancePct = 1878,

		[Description("Cold And Lightning Damage Resistance %")]
		ColdAndLightningDamageResistancePct = 1879,

		[Description("Display Monster Mod Nemesis Test")]
		DisplayMonsterModNemesisTest = 1880,

		[Description("Base Damage Not From Skill User")]
		BaseDamageNotFromSkillUser = 1881,

		[Description("Map Rare Monsters Have Nemesis Mod")]
		MapRareMonstersHaveNemesisMod = 1882,

		[Description("Display Monster Has Firestorm Daemon")]
		DisplayMonsterHasFirestormDaemon = 1883,

		[Description("Monster Raises After Death")]
		MonsterRaisesAfterDeath = 1884,

		[Description("Display Monster Is Apparition")]
		DisplayMonsterIsApparition = 1885,

		[Description("Monster Spawns X Monsters On Death")]
		MonsterSpawnsXMonstersOnDeath = 1886,

		[Description("Damage +% While Ignited")]
		DamagePosPctWhileIgnited = 1887,

		[Description("Physical Damage Reduction Rating While Frozen")]
		PhysicalDamageReductionRatingWhileFrozen = 1888,

		[Description("Old Do Not Use Mana Leech % Vs Shocked Enemies")]
		OldDoNotUseManaLeechPctVsShockedEnemies = 1889,

		[Description("Old Do Not Use Life Leech % Vs Frozen Enemies")]
		OldDoNotUseLifeLeechPctVsFrozenEnemies = 1890,

		[Description("Damage +% Vs Rare Monsters")]
		DamagePosPctVsRareMonsters = 1891,

		[Description("Damage +% Vs Enemies Per Freeze Shock Ignite")]
		DamagePosPctVsEnemiesPerFreezeShockIgnite = 1892,

		[Description("Chance To Freeze Shock Ignite %")]
		ChanceToFreezeShockIgnitePct = 1893,

		[Description("Shrine Buff Effect On Self +%")]
		ShrineBuffEffectOnSelfPosPct = 1894,

		[Description("Shrine Effect Duration +%")]
		ShrineEffectDurationPosPct = 1895,

		[Description("Local Unique Flask Cannot Recover Life While Healing")]
		LocalUniqueFlaskCannotRecoverLifeWhileHealing = 1896,

		[Description("Local Unique Flask Recover % Maximum Life When Effect Reaches Duration")]
		LocalUniqueFlaskRecoverPctMaximumLifeWhenEffectReachesDuration = 1897,

		[Description("Local Unique Flask No Mana Cost While Healing")]
		LocalUniqueFlaskNoManaCostWhileHealing = 1898,

		[Description("Shock X Nearby Enemies For 2 S On Killing Shocked Enemy")]
		ShockXNearbyEnemiesFor2SOnKillingShockedEnemy = 1899,

		[Description("Ignite X Nearby Enemies For 4 S On Killing Ignited Enemy")]
		IgniteXNearbyEnemiesFor4SOnKillingIgnitedEnemy = 1900,
		[Description("Chance To Ignite %")] ChanceToIgnitePct = 1901,
		[Description("Chance To Shock %")] ChanceToShockPct = 1902,
		[Description("Chance To Freeze %")] ChanceToFreezePct = 1903,

		[Description("Echoing Shrine Cast Speed +% Final")]
		EchoingShrineCastSpeedPosPctFinal = 1904,

		[Description("Echoing Shrine Attack Speed +% Final")]
		EchoingShrineAttackSpeedPosPctFinal = 1905,

		[Description("Display Monster Has Proximity Shield Daemon")]
		DisplayMonsterHasProximityShieldDaemon = 1906,

		[Description("Display Monster Has Summon Skeletons Daemon")]
		DisplayMonsterHasSummonSkeletonsDaemon = 1907,

		[Description("Display Monster Has Smoke Mine Daemon")]
		DisplayMonsterHasSmokeMineDaemon = 1908,

		[Description("Monster Drop Additional Unique Items")]
		MonsterDropAdditionalUniqueItems = 1909,

		[Description("Base Corrupt Blood When Hit % Average Damage To Deal Per Minute Per Stack")]
		BaseCorruptBloodWhenHitPctAverageDamageToDealPerMinutePerStack = 1910,
		[Description("Cannot Recover Life")] CannotRecoverLife = 1911,

		[Description("Recover % Maximum Life When Buff Reaches Duration")]
		RecoverPctMaximumLifeWhenBuffReachesDuration = 1912,
		[Description("No Mana Cost")] NoManaCost = 1913,

		[Description("Gain Rare Monster Mods On Kill Ms")]
		GainRareMonsterModsOnKillMs = 1914,

		[Description("Corpse Cannot Be Destroyed")]
		CorpseCannotBeDestroyed = 1915,
		[Description("Cannot Be Dominated")] CannotBeDominated = 1916,

		[Description("Lightning Warp Shocked Ground Duration Ms")]
		LightningWarpShockedGroundDurationMs = 1917,

		[Description("Physical Damage % To Add As Random Element")]
		PhysicalDamagePctToAddAsRandomElement = 1918,

		[Description("Always Cause Elemental Status Ailment")]
		AlwaysCauseElementalStatusAilment = 1919,

		[Description("Reflect Projectiles At Owner")]
		ReflectProjectilesAtOwner = 1920,

		[Description("Base Righteous Fire % Of Max Energy Shield To Deal To Nearby Per Minute")]
		BaseRighteousFirePctOfMaxEnergyShieldToDealToNearbyPerMinute = 1921,

		[Description("Base Nonlethal Fire Damage % Of Maximum Energy Shield Taken Per Minute")]
		BaseNonlethalFireDamagePctOfMaximumEnergyShieldTakenPerMinute = 1922,

		[Description("Nemesis Transform On Low Life")]
		NemesisTransformOnLowLife = 1923,

		[Description("Attack And Cast Speed +%")]
		AttackAndCastSpeedPosPct = 1924,

		[Description("Cleave Damage +% Final While Dual Wielding")]
		CleaveDamagePosPctFinalWhileDualWielding = 1925,

		[Description("Monster Level Scale Maximum Mana And Mana Cost +% Final")]
		MonsterLevelScaleMaximumManaAndManaCostPosPctFinal = 1926,

		[Description("Grant Actor Scale +% To Aura Owner On Death")]
		GrantActorScalePosPctToAuraOwnerOnDeath = 1927,

		[Description("Grant Attack Speed +% To Aura Owner On Death")]
		GrantAttackSpeedPosPctToAuraOwnerOnDeath = 1928,

		[Description("Grant Cast Speed +% To Aura Owner On Death")]
		GrantCastSpeedPosPctToAuraOwnerOnDeath = 1929,

		[Description("Grant Damage Reduction % To Aura Owner On Death")]
		GrantDamageReductionPctToAuraOwnerOnDeath = 1930,
		[Description("Random Curse On Hit %")] RandomCurseOnHitPct = 1931,

		[Description("Random Curses Include Silence")]
		RandomCursesIncludeSilence = 1932,

		[Description("Is Twinned Unique Boss")]
		IsTwinnedUniqueBoss = 1933,

		[Description("Remove Flask Effects On Hit %")]
		RemoveFlaskEffectsOnHitPct = 1934,

		[Description("Remove Charges On Hit %")]
		RemoveChargesOnHitPct = 1935,

		[Description("Monster Casts Arctic Breath Text")]
		MonsterCastsArcticBreathText = 1936,

		[Description("Cast On Death Damage +% Final While Dead")]
		CastOnDeathDamagePosPctFinalWhileDead = 1937,

		[Description("Cast On Damage Taken Damage +% Final")]
		CastOnDamageTakenDamagePosPctFinal = 1938,

		[Description("Life Gained On Spell Hit")]
		LifeGainedOnSpellHit = 1939,
		[Description("Base Attacks Poison")] BaseAttacksPoison = 1940,

		[Description("Active Skill Attack Speed +% Final")]
		ActiveSkillAttackSpeedPosPctFinal = 1941,

		[Description("Infinite Skill Effect Duration")]
		InfiniteSkillEffectDuration = 1942,

		[Description("Physical Damage Reduction Rating +% While Not Ignited Frozen Shocked")]
		PhysicalDamageReductionRatingPosPctWhileNotIgnitedFrozenShocked = 1943,

		[Description("Max Corrupted Blood Rain Stacks")]
		MaxCorruptedBloodRainStacks = 1944,

		[Description("Current Corrupted Blood Rain Stacks")]
		CurrentCorruptedBloodRainStacks = 1945,

		[Description("Base Physical Damage Taken Per Minute Per Corrupted Blood Rain Stack")]
		BasePhysicalDamageTakenPerMinutePerCorruptedBloodRainStack = 1946,

		[Description("Base Damage Removed From Mana Before Life %")]
		BaseDamageRemovedFromManaBeforeLifePct = 1947,
		[Description("Keystone Mana Shield")] KeystoneManaShield = 1948,
		[Description("Actor Scale +%")] ActorScalePosPct = 1949,
		[Description("Capped Actor Scale +%")] CappedActorScalePosPct = 1950,
		[Description("Cannot Stun")] CannotStun = 1951,
		[Description("Is Daemon")] IsDaemon = 1952,
		[Description("Disable Light")] DisableLight = 1953,

		[Description("Base Chance To Dodge %")]
		BaseChanceToDodgePct = 1954,

		[Description("Base Chance To Dodge Spells %")]
		BaseChanceToDodgeSpellsPct = 1955,
		[Description("Map Allow Shrines")] MapAllowShrines = 1956,
		[Description("Aura Effect +%")] AuraEffectPosPct = 1957,

		[Description("Display Monster Uses Far Shot Text")]
		DisplayMonsterUsesFarShotText = 1958,

		[Description("Monster Additional Rarity Of Dropped Items In Merciless +%")]
		MonsterAdditionalRarityOfDroppedItemsInMercilessPosPct = 1959,

		[Description("Monster Additional Quantity Of Dropped Items In Merciless +%")]
		MonsterAdditionalQuantityOfDroppedItemsInMercilessPosPct = 1960,

		[Description("Mortal Conviction Mana Reservation +% Final")]
		MortalConvictionManaReservationPosPctFinal = 1961,
		[Description("Mana Reservation +%")] ManaReservationPosPct = 1962,

		[Description("Additional Player Bonus Maximum Energy Shield +% Final")]
		AdditionalPlayerBonusMaximumEnergyShieldPosPctFinal = 1963,

		[Description("Additional Player Bonus Monster Slain Flask Charges Granted +% Final")]
		AdditionalPlayerBonusMonsterSlainFlaskChargesGrantedPosPctFinal = 1964,

		[Description("Display Monster Uses Suppressing Fire Text")]
		DisplayMonsterUsesSuppressingFireText = 1965,

		[Description("Display Monster Casts Devouring Totem Skill Text")]
		DisplayMonsterCastsDevouringTotemSkillText = 1966,

		[Description("Monster Additional Quantity Of Dropped Items In Cruel +%")]
		MonsterAdditionalQuantityOfDroppedItemsInCruelPosPct = 1967,

		[Description("Monster Additional Rarity Of Dropped Items In Cruel +%")]
		MonsterAdditionalRarityOfDroppedItemsInCruelPosPct = 1968,

		[Description("Supported Active Skill Gem Quality %")]
		SupportedActiveSkillGemQualityPct = 1969,
		[Description("Map Rarity")] MapRarity = 1970,

		[Description("Animate Guardian Last Known Life")]
		AnimateGuardianLastKnownLife = 1971,

		[Description("Spell Only Castable On Death")]
		SpellOnlyCastableOnDeath = 1972,

		[Description("Local Support Gem Max Skill Level Requirement To Support")]
		LocalSupportGemMaxSkillLevelRequirementToSupport = 1973,

		[Description("Display Monster Casts Lightning Nova Text")]
		DisplayMonsterCastsLightningNovaText = 1974,

		[Description("Physical Damage To Deal Per Minute")]
		PhysicalDamageToDealPerMinute = 1975,

		[Description("Base Physical Damage To Deal Per Minute")]
		BasePhysicalDamageToDealPerMinute = 1976,

		[Description("Fire Damage To Deal Per Minute")]
		FireDamageToDealPerMinute = 1977,

		[Description("Cold Damage To Deal Per Minute")]
		ColdDamageToDealPerMinute = 1978,

		[Description("Lightning Damage To Deal Per Minute")]
		LightningDamageToDealPerMinute = 1979,

		[Description("Base Lightning Damage To Deal Per Minute")]
		BaseLightningDamageToDealPerMinute = 1980,

		[Description("Chaos Damage To Deal Per Minute")]
		ChaosDamageToDealPerMinute = 1981,

		[Description("Base Chaos Damage To Deal Per Minute")]
		BaseChaosDamageToDealPerMinute = 1982,

		[Description("Base Chaos Damage % Of Maximum Life To Deal Per Minute")]
		BaseChaosDamagePctOfMaximumLifeToDealPerMinute = 1983,

		[Description("Base Chaos Damage Taken Per Minute Per Viper Strike Orb")]
		BaseChaosDamageTakenPerMinutePerViperStrikeOrb = 1984,

		[Description("Combined All Damage Over Time +%")]
		CombinedAllDamageOverTimePosPct = 1985,

		[Description("Combined All Damage Over Time +% Final")]
		CombinedAllDamageOverTimePosPctFinal = 1986,

		[Description("Combined Physical Damage Over Time +%")]
		CombinedPhysicalDamageOverTimePosPct = 1987,

		[Description("Combined Physical Damage Over Time +% Final")]
		CombinedPhysicalDamageOverTimePosPctFinal = 1988,

		[Description("Combined Elemental Damage Over Time +%")]
		CombinedElementalDamageOverTimePosPct = 1989,

		[Description("Combined Elemental Damage Over Time +% Final")]
		CombinedElementalDamageOverTimePosPctFinal = 1990,

		[Description("Combined Fire Damage Over Time +%")]
		CombinedFireDamageOverTimePosPct = 1991,

		[Description("Combined Fire Damage Over Time +% Final")]
		CombinedFireDamageOverTimePosPctFinal = 1992,

		[Description("Combined Cold Damage Over Time +%")]
		CombinedColdDamageOverTimePosPct = 1993,

		[Description("Combined Cold Damage Over Time +% Final")]
		CombinedColdDamageOverTimePosPctFinal = 1994,

		[Description("Combined Lightning Damage Over Time +%")]
		CombinedLightningDamageOverTimePosPct = 1995,

		[Description("Combined Lightning Damage Over Time +% Final")]
		CombinedLightningDamageOverTimePosPctFinal = 1996,

		[Description("Combined Chaos Damage Over Time +%")]
		CombinedChaosDamageOverTimePosPct = 1997,

		[Description("Combined Chaos Damage Over Time +% Final")]
		CombinedChaosDamageOverTimePosPctFinal = 1998,
		[Description("Damage Over Time +%")] DamageOverTimePosPct = 1999,

		[Description("Fire Damage Taken Per Minute")]
		FireDamageTakenPerMinute = 2000,

		[Description("Base Fire Damage Taken Per Minute")]
		BaseFireDamageTakenPerMinute = 2001,

		[Description("Cold Damage Taken Per Minute")]
		ColdDamageTakenPerMinute = 2002,

		[Description("Base Cold Damage Taken Per Minute")]
		BaseColdDamageTakenPerMinute = 2003,

		[Description("Lightning Damage Taken Per Minute")]
		LightningDamageTakenPerMinute = 2004,

		[Description("Base Lightning Damage Taken Per Minute")]
		BaseLightningDamageTakenPerMinute = 2005,

		[Description("Deal No Damage Over Time")]
		DealNoDamageOverTime = 2006,

		[Description("Base Deal No Damage Over Time")]
		BaseDealNoDamageOverTime = 2007,

		[Description("Deal No Physical Damage Over Time")]
		DealNoPhysicalDamageOverTime = 2008,

		[Description("Deal No Fire Damage Over Time")]
		DealNoFireDamageOverTime = 2009,

		[Description("Deal No Cold Damage Over Time")]
		DealNoColdDamageOverTime = 2010,

		[Description("Deal No Lightning Damage Over Time")]
		DealNoLightningDamageOverTime = 2011,

		[Description("Deal No Chaos Damage Over Time")]
		DealNoChaosDamageOverTime = 2012,

		[Description("Unique Critical Strike Chance +% Final")]
		UniqueCriticalStrikeChancePosPctFinal = 2013,
		[Description("Map Ground Lightning")] MapGroundLightning = 2014,

		[Description("Add Endurance Charge On Kill")]
		AddEnduranceChargeOnKill = 2015,

		[Description("Unique Lose All Endurance Charges When Hit")]
		UniqueLoseAllEnduranceChargesWhenHit = 2016,

		[Description("Unique Gain Onslaught When Hit Duration Ms")]
		UniqueGainOnslaughtWhenHitDurationMs = 2017,

		[Description("Chance To Counter Strike When Hit %")]
		ChanceToCounterStrikeWhenHitPct = 2018,

		[Description("Hundred Times Average Damage Per Hit")]
		HundredTimesAverageDamagePerHit = 2019,

		[Description("Hundred Times Average Damage Per Skill Use")]
		HundredTimesAverageDamagePerSkillUse = 2020,

		[Description("Base Skill Show Average Damage Instead Of Dps")]
		BaseSkillShowAverageDamageInsteadOfDps = 2021,

		[Description("Display Hundred Times Damage Per Skill Use")]
		DisplayHundredTimesDamagePerSkillUse = 2022,

		[Description("Base Monster Will Be Deleted On Death")]
		BaseMonsterWillBeDeletedOnDeath = 2023,

		[Description("Monster Will Be Deleted On Death")]
		MonsterWillBeDeletedOnDeath = 2024,

		[Description("Charged Blast Spell Damage +% Final Per Stack")]
		ChargedBlastSpellDamagePosPctFinalPerStack = 2025,

		[Description("From Code Active Skill Spell Damage +% Final")]
		FromCodeActiveSkillSpellDamagePosPctFinal = 2026,

		[Description("Leech X Life Per Spell Cast")]
		LeechXLifePerSpellCast = 2027,

		[Description("Zero Elemental Resistance")]
		ZeroElementalResistance = 2028,
		[Description("Global Defences +%")] GlobalDefencesPosPct = 2029,

		[Description("Minimum Lightning Damage To Return On Block")]
		MinimumLightningDamageToReturnOnBlock = 2030,

		[Description("Maximum Lightning Damage To Return On Block")]
		MaximumLightningDamageToReturnOnBlock = 2031,

		[Description("Leap Slam Spawn X Zombies On Impact")]
		LeapSlamSpawnXZombiesOnImpact = 2032,

		[Description("Culling Strike On Burning Enemies")]
		CullingStrikeOnBurningEnemies = 2033,

		[Description("Gain Frenzy Charge If Attack Ignites")]
		GainFrenzyChargeIfAttackIgnites = 2034,

		[Description("Map Monsters Are Immune To Curses")]
		MapMonstersAreImmuneToCurses = 2035,
		[Description("Map Packs Are Animals")] MapPacksAreAnimals = 2036,
		[Description("Map Packs Are Demons")] MapPacksAreDemons = 2037,

		[Description("Map Packs Are Humanoids")]
		MapPacksAreHumanoids = 2038,

		[Description("Monster Drop Higher Level Gear")]
		MonsterDropHigherLevelGear = 2039,

		[Description("Regenerate X Life Over 1 Second On Cast")]
		RegenerateXLifeOver1SecondOnCast = 2040,

		[Description("Map Monsters Gain X Power Charges Every 20 Seconds")]
		MapMonstersGainXPowerChargesEvery20Seconds = 2041,

		[Description("Map Monsters Gain X Endurance Charges Every 20 Seconds")]
		MapMonstersGainXEnduranceChargesEvery20Seconds = 2042,

		[Description("Damage +% Per 10 Levels")]
		DamagePosPctPer10Levels = 2043,

		[Description("Monster Caustic Cloud On Death % Max Damage To Deal Per Minute")]
		MonsterCausticCloudOnDeathPctMaxDamageToDealPerMinute = 2044,

		[Description("Monster Caustic Cloud On Death Base Area Of Effect Radius")]
		MonsterCausticCloudOnDeathBaseAreaOfEffectRadius = 2045,

		[Description("Monster Caustic Cloud On Death Duration Ms")]
		MonsterCausticCloudOnDeathDurationMs = 2046,
		[Description("Chaos Damage Taken +")] ChaosDamageTakenPos = 2047,

		[Description("Local Socketed Curse Gem Level +")]
		LocalSocketedCurseGemLevelPos = 2048,

		[Description("Base Curse Duration +%")]
		BaseCurseDurationPosPct = 2049,
		[Description("Curse Duration +%")] CurseDurationPosPct = 2050,
		[Description("Curse Effect Duration")] CurseEffectDuration = 2051,

		[Description("Self Curse Duration +%")]
		SelfCurseDurationPosPct = 2052,

		[Description("Local Display Socketed Gems Get Flee Level")]
		LocalDisplaySocketedGemsGetFleeLevel = 2053,
		[Description("Dexterity +%")] DexterityPosPct = 2054,
		[Description("Strength +%")] StrengthPosPct = 2055,
		[Description("Intelligence +%")] IntelligencePosPct = 2056,

		[Description("Display Map Final Boss Drops Higher Level Gear")]
		DisplayMapFinalBossDropsHigherLevelGear = 2057,

		[Description("Chaos Resistance + While Using Flask")]
		ChaosResistancePosWhileUsingFlask = 2058,

		[Description("Minimum Physical Damage To Reflect To Self On Attack")]
		MinimumPhysicalDamageToReflectToSelfOnAttack = 2059,

		[Description("Maximum Physical Damage To Reflect To Self On Attack")]
		MaximumPhysicalDamageToReflectToSelfOnAttack = 2060,
		[Description("Is Bleeding")] IsBleeding = 2061,

		[Description("Damage +% Vs Bleeding Enemies")]
		DamagePosPctVsBleedingEnemies = 2062,

		[Description("Unique Gain Onslaught When Hit Duration Ms Per Endurance Charge")]
		UniqueGainOnslaughtWhenHitDurationMsPerEnduranceCharge = 2063,

		[Description("Unique Gain Endurance Charges Instead Of Frenzy Charges")]
		UniqueGainEnduranceChargesInsteadOfFrenzyCharges = 2064,

		[Description("Unique Gain Endurance Charges Instead Of Power Charges")]
		UniqueGainEnduranceChargesInsteadOfPowerCharges = 2065,
		[Description("Fire Damage Taken +%")] FireDamageTakenPosPct = 2066,

		[Description("Crits Have Culling Strike")]
		CritsHaveCullingStrike = 2067,

		[Description("Support Projectile Attack Physical Damage +% Final")]
		SupportProjectileAttackPhysicalDamagePosPctFinal = 2068,

		[Description("Support Projectile Attack Speed +% Final")]
		SupportProjectileAttackSpeedPosPctFinal = 2069,

		[Description("Supported Active Skill Gem Expereince Gained +%")]
		SupportedActiveSkillGemExpereinceGainedPosPct = 2070,

		[Description("Flame Whip Damage +% Final Vs Burning Enemies")]
		FlameWhipDamagePosPctFinalVsBurningEnemies = 2071,

		[Description("Unique Spread Poison To Nearby Enemies On Kill")]
		UniqueSpreadPoisonToNearbyEnemiesOnKill = 2072,

		[Description("Unique Spread Poison To Nearby Allies As Regeneration On Kill")]
		UniqueSpreadPoisonToNearbyAlliesAsRegenerationOnKill = 2073,

		[Description("Uncapped Fire Damage Resistance %")]
		UncappedFireDamageResistancePct = 2074,

		[Description("Uncapped Cold Damage Resistance %")]
		UncappedColdDamageResistancePct = 2075,

		[Description("Uncapped Lightning Damage Resistance %")]
		UncappedLightningDamageResistancePct = 2076,

		[Description("Uncapped Chaos Damage Resistance %")]
		UncappedChaosDamageResistancePct = 2077,

		[Description("Local Ring Duplicate Other Ring")]
		LocalRingDuplicateOtherRing = 2078,
		[Description("Duplicate Ring Slot 1")] DuplicateRingSlot1 = 2079,
		[Description("Duplicate Ring Slot 2")] DuplicateRingSlot2 = 2080,

		[Description("Unique Fire Damage Shocks")]
		UniqueFireDamageShocks = 2081,

		[Description("Unique Cold Damage Ignites")]
		UniqueColdDamageIgnites = 2082,

		[Description("Unique Lightning Damage Freezes")]
		UniqueLightningDamageFreezes = 2083,
		[Description("Fire Damage Can Shock")] FireDamageCanShock = 2084,

		[Description("Cold Damage Can Ignite")]
		ColdDamageCanIgnite = 2085,

		[Description("Lightning Damage Can Freeze")]
		LightningDamageCanFreeze = 2086,

		[Description("Fire Damage Cannot Ignite")]
		FireDamageCannotIgnite = 2087,

		[Description("Cold Damage Cannot Freeze")]
		ColdDamageCannotFreeze = 2088,

		[Description("Lightning Damage Cannot Shock")]
		LightningDamageCannotShock = 2089,
		[Description("Can Catch Exotic Fish")] CanCatchExoticFish = 2090,

		[Description("Transfer Curses To X Nearby Enemies On Kill")]
		TransferCursesToXNearbyEnemiesOnKill = 2091,

		[Description("Freeze As Though Dealt Damage +%")]
		FreezeAsThoughDealtDamagePosPct = 2092,

		[Description("Chill Prevention Ms When Chilled")]
		ChillPreventionMsWhenChilled = 2093,

		[Description("Freeze Prevention Ms When Frozen")]
		FreezePreventionMsWhenFrozen = 2094,

		[Description("Ignite Prevention Ms When Ignited")]
		IgnitePreventionMsWhenIgnited = 2095,

		[Description("Shock Prevention Ms When Shocked")]
		ShockPreventionMsWhenShocked = 2096,

		[Description("Grant X Frenzy Charges To Nearby Allies On Death")]
		GrantXFrenzyChargesToNearbyAlliesOnDeath = 2097,

		[Description("Unique Gain Power Charge On Non Crit")]
		UniqueGainPowerChargeOnNonCrit = 2098,

		[Description("Unique Lose All Power Charges On Crit")]
		UniqueLoseAllPowerChargesOnCrit = 2099,

		[Description("Curse Area Of Effect +%")]
		CurseAreaOfEffectPosPct = 2100,

		[Description("Support Spell Totem Cast Speed +% Final")]
		SupportSpellTotemCastSpeedPosPctFinal = 2101,

		[Description("Support Attack Totem Attack Speed +% Final")]
		SupportAttackTotemAttackSpeedPosPctFinal = 2102,

		[Description("Map Non Unique Monsters Spawn X Monsters On Death")]
		MapNonUniqueMonstersSpawnXMonstersOnDeath = 2103,

		[Description("Local Unique Attacks Cast Socketed Lightning Spells %")]
		LocalUniqueAttacksCastSocketedLightningSpellsPct = 2104,

		[Description("Main Hand Local Unique Attacks Cast Socketed Lightning Spells %")]
		MainHandLocalUniqueAttacksCastSocketedLightningSpellsPct = 2105,

		[Description("Off Hand Local Unique Attacks Cast Socketed Lightning Spells %")]
		OffHandLocalUniqueAttacksCastSocketedLightningSpellsPct = 2106,

		[Description("Local Display Aura Curse Effect On Self +%")]
		LocalDisplayAuraCurseEffectOnSelfPosPct = 2107,
		[Description("Flask Minion Heal %")] FlaskMinionHealPct = 2108,
		[Description("Minion Block %")] MinionBlockPct = 2109,

		[Description("Minion Physical Damage Reduction Rating")]
		MinionPhysicalDamageReductionRating = 2110,

		[Description("Untargetable By Monster Ai")]
		UntargetableByMonsterAi = 2111,

		[Description("Virtual Untargetable By Monster Ai")]
		VirtualUntargetableByMonsterAi = 2112,

		[Description("Desecrate Number Of Corpses To Create")]
		DesecrateNumberOfCorpsesToCreate = 2113,

		[Description("Local Display Aura Damage +% Allies Only")]
		LocalDisplayAuraDamagePosPctAlliesOnly = 2114,

		[Description("Map Invasion Monster Packs")]
		MapInvasionMonsterPacks = 2115,
		[Description("Base Spell Block %")] BaseSpellBlockPct = 2116,

		[Description("Minion Attack Speed +%")]
		MinionAttackSpeedPosPct = 2117,
		[Description("Minion Cast Speed +%")] MinionCastSpeedPosPct = 2118,

		[Description("Old Do Not Use Minion Life Leech From Any Damage Permyriad")]
		OldDoNotUseMinionLifeLeechFromAnyDamagePermyriad = 2119,

		[Description("Minion Life Regeneration Rate Per Minute %")]
		MinionLifeRegenerationRatePerMinutePct = 2120,

		[Description("Minion Elemental Resistance %")]
		MinionElementalResistancePct = 2121,

		[Description("Minion Chaos Resistance %")]
		MinionChaosResistancePct = 2122,

		[Description("Skill Show Average Damage Instead Of Dps")]
		SkillShowAverageDamageInsteadOfDps = 2123,

		[Description("Offering Skill Effect Duration Per Corpse")]
		OfferingSkillEffectDurationPerCorpse = 2124,

		[Description("Unholy Might On Kill Duration Ms")]
		UnholyMightOnKillDurationMs = 2125,

		[Description("Minion Unholy Might On Kill Duration Ms")]
		MinionUnholyMightOnKillDurationMs = 2126,

		[Description("Chest Delay Drops Until Daemons Finish")]
		ChestDelayDropsUntilDaemonsFinish = 2127,

		[Description("Base Number Of Raging Spirits Allowed")]
		BaseNumberOfRagingSpiritsAllowed = 2128,

		[Description("Number Of Raging Spirits Allowed")]
		NumberOfRagingSpiritsAllowed = 2129,

		[Description("Chest Play Warning Sound")]
		ChestPlayWarningSound = 2130,

		[Description("Chest Drop Additional Unqiue Items")]
		ChestDropAdditionalUnqiueItems = 2131,

		[Description("Upheaval Number Of Spikes")]
		UpheavalNumberOfSpikes = 2132,

		[Description("Chest Display Summons Skeletons")]
		ChestDisplaySummonsSkeletons = 2133,

		[Description("Chest Display Ice Nova")]
		ChestDisplayIceNova = 2134,
		[Description("Chest Display Freeze")] ChestDisplayFreeze = 2135,

		[Description("Cyclone Places Ground Desecration Chaos Damage Per Minute")]
		CyclonePlacesGroundDesecrationChaosDamagePerMinute = 2136,

		[Description("Firestorm Drop Ground Ice Duration Ms")]
		FirestormDropGroundIceDurationMs = 2137,

		[Description("Vaal Burning Arrow Explode On Hit")]
		VaalBurningArrowExplodeOnHit = 2138,

		[Description("Molten Shell Explode Each Hit")]
		MoltenShellExplodeEachHit = 2139,

		[Description("Desecrate Corpse Level")]
		DesecrateCorpseLevel = 2140,

		[Description("Lightning Warp Remove Delay")]
		LightningWarpRemoveDelay = 2141,

		[Description("Immortal Call Prevent All Damage")]
		ImmortalCallPreventAllDamage = 2142,

		[Description("Power Siphon Fire At All Targets")]
		PowerSiphonFireAtAllTargets = 2143,

		[Description("Rain Of Arrows Place Shocking Ground Duration Ms")]
		RainOfArrowsPlaceShockingGroundDurationMs = 2144,

		[Description("Leap Slam Base Caustic Cloud Damage To Deal Per Minute")]
		LeapSlamBaseCausticCloudDamageToDealPerMinute = 2145,

		[Description("Base Number Of Projectiles In Spiral Nova")]
		BaseNumberOfProjectilesInSpiralNova = 2146,

		[Description("Projectile Spiral Nova Time Ms")]
		ProjectileSpiralNovaTimeMs = 2147,

		[Description("Projectile Spiral Nova Angle")]
		ProjectileSpiralNovaAngle = 2148,

		[Description("Kiweth Consume Leech % Max Life")]
		KiwethConsumeLeechPctMaxLife = 2149,

		[Description("Ice Nova Number Of Repeats")]
		IceNovaNumberOfRepeats = 2150,

		[Description("Ice Nova Radius +% Per Repeat")]
		IceNovaRadiusPosPctPerRepeat = 2151,

		[Description("Local Display Socketed Gems Have Iron Will")]
		LocalDisplaySocketedGemsHaveIronWill = 2152,

		[Description("Local Display Socketed Gems Chain X Additional Times")]
		LocalDisplaySocketedGemsChainXAdditionalTimes = 2153,

		[Description("Old Do Not Use Base Life Leech From Physical Damage Permyriad")]
		OldDoNotUseBaseLifeLeechFromPhysicalDamagePermyriad = 2154,

		[Description("Old Do Not Use Base Life Leech From Fire Damage Permyriad")]
		OldDoNotUseBaseLifeLeechFromFireDamagePermyriad = 2155,

		[Description("Old Do Not Use Base Life Leech From Cold Damage Permyriad")]
		OldDoNotUseBaseLifeLeechFromColdDamagePermyriad = 2156,

		[Description("Old Do Not Use Base Life Leech From Lightning Damage Permyriad")]
		OldDoNotUseBaseLifeLeechFromLightningDamagePermyriad = 2157,

		[Description("Base Life Leech From Chaos Damage Permyriad")]
		BaseLifeLeechFromChaosDamagePermyriad = 2158,

		[Description("Base Mana Leech From Physical Damage Permyriad")]
		BaseManaLeechFromPhysicalDamagePermyriad = 2159,

		[Description("Base Mana Leech From Fire Damage Permyriad")]
		BaseManaLeechFromFireDamagePermyriad = 2160,

		[Description("Base Mana Leech From Cold Damage Permyriad")]
		BaseManaLeechFromColdDamagePermyriad = 2161,

		[Description("Old Do Not Use Base Mana Leech From Lightning Damage Permyriad")]
		OldDoNotUseBaseManaLeechFromLightningDamagePermyriad = 2162,

		[Description("Base Mana Leech From Chaos Damage Permyriad")]
		BaseManaLeechFromChaosDamagePermyriad = 2163,

		[Description("Base Leech Is Instant On Critical")]
		BaseLeechIsInstantOnCritical = 2164,

		[Description("Local Socketed Vaal Gem Level +")]
		LocalSocketedVaalGemLevelPos = 2165,

		[Description("Elemental Damage % To Add As Chaos")]
		ElementalDamagePctToAddAsChaos = 2166,

		[Description("Chance To Ignite % While Using Flask")]
		ChanceToIgnitePctWhileUsingFlask = 2167,

		[Description("Chance To Freeze % While Using Flask")]
		ChanceToFreezePctWhileUsingFlask = 2168,

		[Description("Chance To Shock % While Using Flask")]
		ChanceToShockPctWhileUsingFlask = 2169,

		[Description("Stun Threshold Reduction +% While Using Flask")]
		StunThresholdReductionPosPctWhileUsingFlask = 2170,

		[Description("Local Unique Flask Physical Damage % To Add As Chaos While Healing")]
		LocalUniqueFlaskPhysicalDamagePctToAddAsChaosWhileHealing = 2171,

		[Description("Local Unique Flask Elemental Damage % To Add As Chaos While Healing")]
		LocalUniqueFlaskElementalDamagePctToAddAsChaosWhileHealing = 2172,

		[Description("Old Do Not Use Local Unique Flask Life Leech From Chaos Damage Permyriad While Healing")]
		OldDoNotUseLocalUniqueFlaskLifeLeechFromChaosDamagePermyriadWhileHealing = 2173,

		[Description("Local Display Socketed Spells Repeat Count")]
		LocalDisplaySocketedSpellsRepeatCount = 2174,
		[Description("Map Ambush Chests")] MapAmbushChests = 2175,

		[Description("Atziri Do Not Gain Skill Charges")]
		AtziriDoNotGainSkillCharges = 2176,

		[Description("Chest Hidden Item Quantity +%")]
		ChestHiddenItemQuantityPosPct = 2177,

		[Description("Chest Hidden Item Rarity +%")]
		ChestHiddenItemRarityPosPct = 2178,

		[Description("Monster Drop Vaal Fragment Chance")]
		MonsterDropVaalFragmentChance = 2179,

		[Description("Summoned Monster Rarity")]
		SummonedMonsterRarity = 2180,

		[Description("Number Of Monsters To Summon")]
		NumberOfMonstersToSummon = 2181,

		[Description("Chest Gems Drop With Experience")]
		ChestGemsDropWithExperience = 2182,

		[Description("Chest Drops Additional Utility Flasks")]
		ChestDropsAdditionalUtilityFlasks = 2183,

		[Description("Chest Items Drop Identified")]
		ChestItemsDropIdentified = 2184,

		[Description("Chest Drop Additional Normal Items Up To")]
		ChestDropAdditionalNormalItemsUpTo = 2185,

		[Description("Chest Drop Additional Magic Items Up To")]
		ChestDropAdditionalMagicItemsUpTo = 2186,

		[Description("Chest Drop Additional Rare Items Up To")]
		ChestDropAdditionalRareItemsUpTo = 2187,

		[Description("Chest Dropped Items Have Quality %")]
		ChestDroppedItemsHaveQualityPct = 2188,

		[Description("Dropped Items Have Additional Sockets")]
		DroppedItemsHaveAdditionalSockets = 2189,

		[Description("Dropped Items Are Fully Linked")]
		DroppedItemsAreFullyLinked = 2190,

		[Description("Chest Dropped Item Level +")]
		ChestDroppedItemLevelPos = 2191,

		[Description("Dropped Items Are Duplicated")]
		DroppedItemsAreDuplicated = 2192,

		[Description("Monster Unlock Chests On Death")]
		MonsterUnlockChestsOnDeath = 2193,

		[Description("Local Display Socketed Gems Mana Cost -%")]
		LocalDisplaySocketedGemsManaCostNegPct = 2194,

		[Description("Chest Spawn Rogue Exiles")]
		ChestSpawnRogueExiles = 2195,

		[Description("Chest Display Revive Nearby Monsters")]
		ChestDisplayReviveNearbyMonsters = 2196,

		[Description("Chest Display Spawns Monsters Continuously")]
		ChestDisplaySpawnsMonstersContinuously = 2197,

		[Description("Chest Display Explodes Corpses")]
		ChestDisplayExplodesCorpses = 2198,
		[Description("Chest Camoflaged")] ChestCamoflaged = 2199,

		[Description("Chest Display Cast Random Curse")]
		ChestDisplayCastRandomCurse = 2200,
		[Description("Chest Display Ignite")] ChestDisplayIgnite = 2201,

		[Description("Chest Display Fire Storm")]
		ChestDisplayFireStorm = 2202,

		[Description("Chest Display Caustic Clouds")]
		ChestDisplayCausticClouds = 2203,

		[Description("Chest Display Explosion")]
		ChestDisplayExplosion = 2204,

		[Description("Chest Drops Only Hybrid Flasks")]
		ChestDropsOnlyHybridFlasks = 2205,

		[Description("Chest Drops Only Support Gems")]
		ChestDropsOnlySupportGems = 2206,

		[Description("Chest Drops Extra Vaal Gems")]
		ChestDropsExtraVaalGems = 2207,

		[Description("Firestorm Drop Ground Shock Duration Ms")]
		FirestormDropGroundShockDurationMs = 2208,

		[Description("Detonate Dead Chain Explode")]
		DetonateDeadChainExplode = 2209,

		[Description("Corrupted Blood Cleave Stacks To Add")]
		CorruptedBloodCleaveStacksToAdd = 2210,

		[Description("Desecrated Ground Art Variation")]
		DesecratedGroundArtVariation = 2211,

		[Description("Kiweth Projectile Spawn Kiweth")]
		KiwethProjectileSpawnKiweth = 2212,
		[Description("Rain Of Arrows Pin")] RainOfArrowsPin = 2213,

		[Description("Onslaught On Vaal Skill Use Duration Ms")]
		OnslaughtOnVaalSkillUseDurationMs = 2214,
		[Description("Cold Snap Ground Ice")] ColdSnapGroundIce = 2215,

		[Description("Num Ghost Monkeys To Summon")]
		NumGhostMonkeysToSummon = 2216,

		[Description("Smoke Mine Spawn X Snakes On Teleport")]
		SmokeMineSpawnXSnakesOnTeleport = 2217,

		[Description("Num Sandspitters To Summon")]
		NumSandspittersToSummon = 2218,

		[Description("Vaal Lightning Strike Beam Damage +% Final")]
		VaalLightningStrikeBeamDamagePosPctFinal = 2219,

		[Description("Atziri Lightning Charge Requirement -")]
		AtziriLightningChargeRequirementNeg = 2220,

		[Description("Atziri Fire Charge Requirement -")]
		AtziriFireChargeRequirementNeg = 2221,

		[Description("Atziri Physical Charge Requirement -")]
		AtziriPhysicalChargeRequirementNeg = 2222,

		[Description("Life Leech From Physical Damage Permyriad")]
		LifeLeechFromPhysicalDamagePermyriad = 2223,

		[Description("Life Leech From Fire Damage Permyriad")]
		LifeLeechFromFireDamagePermyriad = 2224,

		[Description("Life Leech From Cold Damage Permyriad")]
		LifeLeechFromColdDamagePermyriad = 2225,

		[Description("Life Leech From Lightning Damage Permyriad")]
		LifeLeechFromLightningDamagePermyriad = 2226,

		[Description("Life Leech From Chaos Damage Permyriad")]
		LifeLeechFromChaosDamagePermyriad = 2227,

		[Description("Mana Leech From Physical Damage Permyriad")]
		ManaLeechFromPhysicalDamagePermyriad = 2228,

		[Description("Mana Leech From Fire Damage Permyriad")]
		ManaLeechFromFireDamagePermyriad = 2229,

		[Description("Mana Leech From Cold Damage Permyriad")]
		ManaLeechFromColdDamagePermyriad = 2230,

		[Description("Mana Leech From Lightning Damage Permyriad")]
		ManaLeechFromLightningDamagePermyriad = 2231,

		[Description("Mana Leech From Chaos Damage Permyriad")]
		ManaLeechFromChaosDamagePermyriad = 2232,

		[Description("Old Do Not Use Base Life Leech From Elemental Damage Permyriad")]
		OldDoNotUseBaseLifeLeechFromElementalDamagePermyriad = 2233,

		[Description("Base Mana Leech From Elemental Damage Permyriad")]
		BaseManaLeechFromElementalDamagePermyriad = 2234,

		[Description("Keystone Vampirism Life Leech Amount +% Final")]
		KeystoneVampirismLifeLeechAmountPosPctFinal = 2235,

		[Description("Attack Minimum Added Physical Damage With Bow")]
		AttackMinimumAddedPhysicalDamageWithBow = 2236,

		[Description("Attack Maximum Added Physical Damage With Bow")]
		AttackMaximumAddedPhysicalDamageWithBow = 2237,

		[Description("Attack Minimum Added Fire Damage With Bow")]
		AttackMinimumAddedFireDamageWithBow = 2238,

		[Description("Attack Maximum Added Fire Damage With Bow")]
		AttackMaximumAddedFireDamageWithBow = 2239,

		[Description("Number Of Packs To Summon")]
		NumberOfPacksToSummon = 2240,
		[Description("Summon Monster Radius")] SummonMonsterRadius = 2241,
		[Description("Resist Life Leech %")] ResistLifeLeechPct = 2242,
		[Description("Resist Mana Leech %")] ResistManaLeechPct = 2243,
		[Description("Life Leech Amount +%")] LifeLeechAmountPosPct = 2244,

		[Description("Level 11 Or Lower Life +% Final")]
		Level11OrLowerLifePosPctFinal = 2245,

		[Description("Local Socketed Support Gem Level +")]
		LocalSocketedSupportGemLevelPos = 2246,

		[Description("Level 33 Or Lower Life +% Final")]
		Level33OrLowerLifePosPctFinal = 2247,

		[Description("Level 33 Or Lower Damage +% Final")]
		Level33OrLowerDamagePosPctFinal = 2248,

		[Description("Display Monster Casts Vaal Detonate Dead Text")]
		DisplayMonsterCastsVaalDetonateDeadText = 2249,

		[Description("Minions Have Chest Summon Indicator")]
		MinionsHaveChestSummonIndicator = 2250,

		[Description("Curse On Hit Level Temporal Chains")]
		CurseOnHitLevelTemporalChains = 2251,

		[Description("Curse On Hit Level Vulnerability")]
		CurseOnHitLevelVulnerability = 2252,

		[Description("Curse On Hit Level Elemental Weakness")]
		CurseOnHitLevelElementalWeakness = 2253,

		[Description("Local Display Socketed Gems Get Melee Splash Level")]
		LocalDisplaySocketedGemsGetMeleeSplashLevel = 2254,

		[Description("Local Display Socketed Gems Get Cast On Crit Level")]
		LocalDisplaySocketedGemsGetCastOnCritLevel = 2255,

		[Description("Local Display Socketed Gems Get Cast When Stunned Level")]
		LocalDisplaySocketedGemsGetCastWhenStunnedLevel = 2256,
		[Description("Is Double")] IsDouble = 2257,

		[Description("Can Catch Corrupted Fish")]
		CanCatchCorruptedFish = 2258,

		[Description("Disable Animated Armour")]
		DisableAnimatedArmour = 2259,

		[Description("Number Of Archer Skeletons To Summon")]
		NumberOfArcherSkeletonsToSummon = 2260,

		[Description("Number Of Mage Skeletons To Summon")]
		NumberOfMageSkeletonsToSummon = 2261,

		[Description("Number Of Leader Skeletons To Summon")]
		NumberOfLeaderSkeletonsToSummon = 2262,

		[Description("Map Spawn Extra Exiles")]
		MapSpawnExtraExiles = 2263,

		[Description("Map Disable New Instance Management")]
		MapDisableNewInstanceManagement = 2264,

		[Description("Local Display Socketed Gems Get Mana Multplier %")]
		LocalDisplaySocketedGemsGetManaMultplierPct = 2265,

		[Description("Local Display Socketed Gems Get Stun Level")]
		LocalDisplaySocketedGemsGetStunLevel = 2266,

		[Description("Local Display Socketed Gems Get Additional Accuracy Level")]
		LocalDisplaySocketedGemsGetAdditionalAccuracyLevel = 2267,

		[Description("Local Display Socketed Gems Get Multistrike Level")]
		LocalDisplaySocketedGemsGetMultistrikeLevel = 2268,

		[Description("Local Display Socketed Gems Get Faster Projectiles Level")]
		LocalDisplaySocketedGemsGetFasterProjectilesLevel = 2269,

		[Description("Local Display Socketed Gems Get Life Leech Level")]
		LocalDisplaySocketedGemsGetLifeLeechLevel = 2270,

		[Description("Local Display Socketed Gems Get Increased Critical Damage Level")]
		LocalDisplaySocketedGemsGetIncreasedCriticalDamageLevel = 2271,

		[Description("Local Display Socketed Gems Get Fork Level")]
		LocalDisplaySocketedGemsGetForkLevel = 2272,

		[Description("Local Display Socketed Gems Get Weapon Elemental Damage Level")]
		LocalDisplaySocketedGemsGetWeaponElementalDamageLevel = 2273,

		[Description("Local Display Grants Skill Purity Of Fire Level")]
		LocalDisplayGrantsSkillPurityOfFireLevel = 2274,

		[Description("Local Display Grants Skill Purity Of Cold Level")]
		LocalDisplayGrantsSkillPurityOfColdLevel = 2275,

		[Description("Local Display Grants Skill Purity Of Lightning Level")]
		LocalDisplayGrantsSkillPurityOfLightningLevel = 2276,

		[Description("Local Display Grants Skill Flammability Level")]
		LocalDisplayGrantsSkillFlammabilityLevel = 2277,

		[Description("Local Display Grants Skill Conductivity Level")]
		LocalDisplayGrantsSkillConductivityLevel = 2278,

		[Description("Local Display Grants Skill Frostbite Level")]
		LocalDisplayGrantsSkillFrostbiteLevel = 2279,

		[Description("Local Display Grants Skill Temporal Chains Level")]
		LocalDisplayGrantsSkillTemporalChainsLevel = 2280,

		[Description("Local Display Grants Skill Haste Level")]
		LocalDisplayGrantsSkillHasteLevel = 2281,

		[Description("Local Display Grants Skill Clarity Level")]
		LocalDisplayGrantsSkillClarityLevel = 2282,

		[Description("Local Display Grants Skill Vitality Level")]
		LocalDisplayGrantsSkillVitalityLevel = 2283,

		[Description("Local Display Grants Skill Purity Level")]
		LocalDisplayGrantsSkillPurityLevel = 2284,

		[Description("Local Display Grants Skill Critical Weakness Level")]
		LocalDisplayGrantsSkillCriticalWeaknessLevel = 2285,

		[Description("Local Display Grants Skill Wrath Level")]
		LocalDisplayGrantsSkillWrathLevel = 2286,

		[Description("Local Display Grants Skill Hatred Level")]
		LocalDisplayGrantsSkillHatredLevel = 2287,

		[Description("Local Display Grants Skill Anger Level")]
		LocalDisplayGrantsSkillAngerLevel = 2288,

		[Description("Local Display Grants Skill Determination Level")]
		LocalDisplayGrantsSkillDeterminationLevel = 2289,

		[Description("Local Display Grants Skill Grace Level")]
		LocalDisplayGrantsSkillGraceLevel = 2290,

		[Description("Local Display Grants Skill Discipline Level")]
		LocalDisplayGrantsSkillDisciplineLevel = 2291,

		[Description("Local Display Grants Skill Projectile Weakness Level")]
		LocalDisplayGrantsSkillProjectileWeaknessLevel = 2292,

		[Description("Local Display Grants Skill Elemental Weakness Level")]
		LocalDisplayGrantsSkillElementalWeaknessLevel = 2293,

		[Description("Local Display Grants Skill Vulnerability Level")]
		LocalDisplayGrantsSkillVulnerabilityLevel = 2294,

		[Description("Cold Damage Cannot Chill")]
		ColdDamageCannotChill = 2295,

		[Description("Elemental Damage Taken % As Chaos")]
		ElementalDamageTakenPctAsChaos = 2296,

		[Description("Fire Damage Taken % As Chaos")]
		FireDamageTakenPctAsChaos = 2297,

		[Description("Cold Damage Taken % As Chaos")]
		ColdDamageTakenPctAsChaos = 2298,

		[Description("Lightning Damage Taken % As Chaos")]
		LightningDamageTakenPctAsChaos = 2299,

		[Description("Global Reduce Enemy Block %")]
		GlobalReduceEnemyBlockPct = 2300,

		[Description("Base Spell Repeat Count")]
		BaseSpellRepeatCount = 2301,
		[Description("Spell Repeat Count")] SpellRepeatCount = 2302,

		[Description("Pvp Damage +% Final Scale")]
		PvpDamagePosPctFinalScale = 2303,

		[Description("Physical Damage Taken + Vs Beasts")]
		PhysicalDamageTakenPosVsBeasts = 2304,

		[Description("Local Strength Requirement +")]
		LocalStrengthRequirementPos = 2305,

		[Description("Local Dexterity Requirement +")]
		LocalDexterityRequirementPos = 2306,

		[Description("Local Intelligence Requirement +")]
		LocalIntelligenceRequirementPos = 2307,

		[Description("Display Monster Vaal Storm Call")]
		DisplayMonsterVaalStormCall = 2308,

		[Description("Reave Rotation On Repeat")]
		ReaveRotationOnRepeat = 2309,

		[Description("Reave Additional Max Stacks")]
		ReaveAdditionalMaxStacks = 2310,

		[Description("Reave Additional Starting Stacks")]
		ReaveAdditionalStartingStacks = 2311,

		[Description("Bleed On Melee Crit Chance %")]
		BleedOnMeleeCritChancePct = 2312,

		[Description("Bleed On Melee Crit Chance Duration Ms")]
		BleedOnMeleeCritChanceDurationMs = 2313,

		[Description("Energy Shield Recharge Not Delayed By Damage")]
		EnergyShieldRechargeNotDelayedByDamage = 2314,

		[Description("Maximum Dodge Chance %")]
		MaximumDodgeChancePct = 2315,

		[Description("Maximum Spell Dodge Chance %")]
		MaximumSpellDodgeChancePct = 2316,

		[Description("Weapon Physical Damage % To Add As Random Element")]
		WeaponPhysicalDamagePctToAddAsRandomElement = 2317,

		[Description("Throw Traps In Circle Radius")]
		ThrowTrapsInCircleRadius = 2318,
		[Description("Damage Taken +%")] DamageTakenPosPct = 2319,

		[Description("Damage Taken +% Per Frenzy Charge")]
		DamageTakenPosPctPerFrenzyCharge = 2320,

		[Description("Lightning Damage +% Per Frenzy Charge")]
		LightningDamagePosPctPerFrenzyCharge = 2321,

		[Description("Life Gained On Enemy Death")]
		LifeGainedOnEnemyDeath = 2322,

		[Description("Life Gained On Enemy Death Per Frenzy Charge")]
		LifeGainedOnEnemyDeathPerFrenzyCharge = 2323,

		[Description("Vaal Sweep Additional Base Radius For Push")]
		VaalSweepAdditionalBaseRadiusForPush = 2324,

		[Description("Main Hand Weapon Elemental Damage +%")]
		MainHandWeaponElementalDamagePosPct = 2325,

		[Description("Off Hand Weapon Elemental Damage +%")]
		OffHandWeaponElementalDamagePosPct = 2326,

		[Description("Local Attacks With This Weapon Elemental Damage +%")]
		LocalAttacksWithThisWeaponElementalDamagePosPct = 2327,

		[Description("Monster Casts Glacial Cascade Text")]
		MonsterCastsGlacialCascadeText = 2328,

		[Description("Dual Wield Inherent Physical Attack Damage +% Final")]
		DualWieldInherentPhysicalAttackDamagePosPctFinal = 2329,

		[Description("Damage Cannot Be Reflected")]
		DamageCannotBeReflected = 2330,

		[Description("Map Base Ground Desecration Damage To Deal Per Minute")]
		MapBaseGroundDesecrationDamageToDealPerMinute = 2331,
		[Description("Global Poison On Hit")] GlobalPoisonOnHit = 2332,

		[Description("Map Monsters Poison On Hit")]
		MapMonstersPoisonOnHit = 2333,

		[Description("Play Jack The Axe Sounds")]
		PlayJackTheAxeSounds = 2334,

		[Description("Sound On Kill Wolf Call")]
		SoundOnKillWolfCall = 2335,
		[Description("Oba Decapitated")] ObaDecapitated = 2336,

		[Description("Chest Number Of Additional Kaom Uniques To Drop")]
		ChestNumberOfAdditionalKaomUniquesToDrop = 2337,

		[Description("Chest Drop Additional Number Of Uniques Of Drop Pool Types")]
		ChestDropAdditionalNumberOfUniquesOfDropPoolTypes = 2338,

		[Description("Chest Display Kaom Totems")]
		ChestDisplayKaomTotems = 2339,
		[Description("Map Mission Id")] MapMissionId = 2340,

		[Description("Chest No Regular Drops")]
		ChestNoRegularDrops = 2341,

		[Description("Map Side Area Chance +%")]
		MapSideAreaChancePosPct = 2342,

		[Description("Chest Drop Additional Unique Maps")]
		ChestDropAdditionalUniqueMaps = 2343,

		[Description("Map Display Garena Drop Buff")]
		MapDisplayGarenaDropBuff = 2344,

		[Description("Keystone Unwavering Stance")]
		KeystoneUnwaveringStance = 2345,
		[Description("Cannot Evade")] CannotEvade = 2346,
		[Description("Never Ignite")] NeverIgnite = 2347,

		[Description("Global Chance To Knockback %")]
		GlobalChanceToKnockbackPct = 2348,

		[Description("Local Unique Flask Instantly Recovers % Maximum Life")]
		LocalUniqueFlaskInstantlyRecoversPctMaximumLife = 2349,

		[Description("Local Unique Flask Chaos Damage % Of Maximum Life To Deal Per Minute While Healing")]
		LocalUniqueFlaskChaosDamagePctOfMaximumLifeToDealPerMinuteWhileHealing = 2350,

		[Description("Unique Add Power Charge On Melee Knockback %")]
		UniqueAddPowerChargeOnMeleeKnockbackPct = 2351,

		[Description("Display Map Boss Gives Experience +%")]
		DisplayMapBossGivesExperiencePosPct = 2352,

		[Description("Gain Power Charge When Throwing Trap %")]
		GainPowerChargeWhenThrowingTrapPct = 2353,

		[Description("Local Display Grants Skill Bear Trap Level")]
		LocalDisplayGrantsSkillBearTrapLevel = 2354,

		[Description("Critical Strike Chance +% Per 8 Strength")]
		CriticalStrikeChancePosPctPer8Strength = 2355,
		[Description("Skill Is Trapped")] SkillIsTrapped = 2356,
		[Description("Skill Is Mined")] SkillIsMined = 2357,
		[Description("Skill Is Totemified")] SkillIsTotemified = 2358,

		[Description("Current Rampage Stacks")]
		CurrentRampageStacks = 2359,
		[Description("Max Rampage Stacks")] MaxRampageStacks = 2360,

		[Description("Damage +% Per 10 Rampage Stacks")]
		DamagePosPctPer10RampageStacks = 2361,

		[Description("Movement Velocity +% Per 10 Rampage Stacks")]
		MovementVelocityPosPctPer10RampageStacks = 2362,

		[Description("Map Players Gain Rampage Stacks")]
		MapPlayersGainRampageStacks = 2363,
		[Description("Map Disable Missions")] MapDisableMissions = 2364,
		[Description("Map Spawn Map Portal")] MapSpawnMapPortal = 2365,

		[Description("Local Unique Flask Block % While Healing")]
		LocalUniqueFlaskBlockPctWhileHealing = 2366,

		[Description("Local Unique Flask Spell Block % While Healing")]
		LocalUniqueFlaskSpellBlockPctWhileHealing = 2367,
		[Description("Map Beyond Rules")] MapBeyondRules = 2368,
		[Description("Map Extra Ruleset")] MapExtraRuleset = 2369,
		[Description("Map Mission Variation")] MapMissionVariation = 2370,

		[Description("Ground Spikes Physical Damage To Deal Per Minute")]
		GroundSpikesPhysicalDamageToDealPerMinute = 2371,

		[Description("Ground Spikes Moving Physical Damage To Deal Per Minute")]
		GroundSpikesMovingPhysicalDamageToDealPerMinute = 2372,

		[Description("Attack Speed +% While Ignited")]
		AttackSpeedPosPctWhileIgnited = 2373,

		[Description("Cast Speed +% While Ignited")]
		CastSpeedPosPctWhileIgnited = 2374,

		[Description("Chance To Ignite % While Ignited")]
		ChanceToIgnitePctWhileIgnited = 2375,

		[Description("Fire Nova Damage +% Per Repeat Final")]
		FireNovaDamagePosPctPerRepeatFinal = 2376,

		[Description("Lightning Trap Projectiles Leave Shocking Ground")]
		LightningTrapProjectilesLeaveShockingGround = 2377,

		[Description("Main Hand Weapon Physical Damage +% Per 250 Evasion")]
		MainHandWeaponPhysicalDamagePosPctPer250Evasion = 2378,

		[Description("Off Hand Weapon Physical Damage +% Per 250 Evasion")]
		OffHandWeaponPhysicalDamagePosPctPer250Evasion = 2379,

		[Description("Local Attacks With This Weapon Physical Damage +% Per 250 Evasion")]
		LocalAttacksWithThisWeaponPhysicalDamagePosPctPer250Evasion = 2380,

		[Description("Map Cagan Has Hidden Mods")]
		MapCaganHasHiddenMods = 2381,

		[Description("Cyclone Places Ground Tar Movement Speed +%")]
		CyclonePlacesGroundTarMovementSpeedPosPct = 2382,
		[Description("Wand Damage +%")] WandDamagePosPct = 2383,

		[Description("Cast Speed While Dual Wielding +%")]
		CastSpeedWhileDualWieldingPosPct = 2384,
		[Description("Shield Spell Block %")] ShieldSpellBlockPct = 2385,

		[Description("Local Display Socketed Gems Get Echo Level")]
		LocalDisplaySocketedGemsGetEchoLevel = 2386,

		[Description("Support Echo Damage +% Final")]
		SupportEchoDamagePosPctFinal = 2387,
		[Description("Global Bleed On Hit")] GlobalBleedOnHit = 2388,
		[Description("Local Bleed On Hit")] LocalBleedOnHit = 2389,

		[Description("Main Hand Bleed On Hit")]
		MainHandBleedOnHit = 2390,
		[Description("Off Hand Bleed On Hit")] OffHandBleedOnHit = 2391,

		[Description("Damage +% Vs Ignited Enemies")]
		DamagePosPctVsIgnitedEnemies = 2392,

		[Description("Recover % Maximum Life On Rampage Threshold")]
		RecoverPctMaximumLifeOnRampageThreshold = 2393,

		[Description("Dispel Status Ailments On Rampage Threshold")]
		DispelStatusAilmentsOnRampageThreshold = 2394,

		[Description("Gain Physical Damage Immunity On Rampage Threshold Ms")]
		GainPhysicalDamageImmunityOnRampageThresholdMs = 2395,

		[Description("Gain X Vaal Souls On Rampage Threshold")]
		GainXVaalSoulsOnRampageThreshold = 2396,

		[Description("Physical Damage +% Vs Poisoned Enemies")]
		PhysicalDamagePosPctVsPoisonedEnemies = 2397,

		[Description("Block Causes Monster Flee %")]
		BlockCausesMonsterFleePct = 2398,

		[Description("Life Regeneration Rate Per Minute Per Level")]
		LifeRegenerationRatePerMinutePerLevel = 2399,

		[Description("Critical Strike Chance +% Per Level")]
		CriticalStrikeChancePosPctPerLevel = 2400,

		[Description("Attack Damage +% Per Level")]
		AttackDamagePosPctPerLevel = 2401,

		[Description("Spell Damage +% Per Level")]
		SpellDamagePosPctPerLevel = 2402,

		[Description("Recharge Flasks On Crit")]
		RechargeFlasksOnCrit = 2403,

		[Description("Bleeding Monsters Movement Velocity +%")]
		BleedingMonstersMovementVelocityPosPct = 2404,

		[Description("Old Do Not Use Life Leech Permyriad On Crit")]
		OldDoNotUseLifeLeechPermyriadOnCrit = 2405,

		[Description("Ground Smoke On Rampage Threshold Ms")]
		GroundSmokeOnRampageThresholdMs = 2406,

		[Description("Phasing On Rampage Threshold Ms")]
		PhasingOnRampageThresholdMs = 2407,
		[Description("On Full Energy Shield")] OnFullEnergyShield = 2408,

		[Description("Movement Velocity +% On Full Energy Shield")]
		MovementVelocityPosPctOnFullEnergyShield = 2409,

		[Description("Sword Critical Strike Chance +%")]
		SwordCriticalStrikeChancePosPct = 2410,

		[Description("Attack Damage +% Per 450 Evasion")]
		AttackDamagePosPctPer450Evasion = 2411,

		[Description("Old Do Not Use Mana Leech From Physical Damage With Claw %")]
		OldDoNotUseManaLeechFromPhysicalDamageWithClawPct = 2412,

		[Description("Main Hand Steal Power Frenzy Endurance Charges On Hit %")]
		MainHandStealPowerFrenzyEnduranceChargesOnHitPct = 2413,

		[Description("Off Hand Steal Power Frenzy Endurance Charges On Hit %")]
		OffHandStealPowerFrenzyEnduranceChargesOnHitPct = 2414,

		[Description("Claw Steal Power Frenzy Endurance Charges On Hit %")]
		ClawStealPowerFrenzyEnduranceChargesOnHitPct = 2415,

		[Description("Player Gain Rampage Stacks")]
		PlayerGainRampageStacks = 2416,

		[Description("Regenerate % Armour As Life Over 1 Second On Block")]
		RegeneratePctArmourAsLifeOver1SecondOnBlock = 2417,

		[Description("Monster Cast Spell % On Attack Hit")]
		MonsterCastSpellPctOnAttackHit = 2418,

		[Description("Unique Chaos Damage To Reflect To Self On Attack % Chance")]
		UniqueChaosDamageToReflectToSelfOnAttackPctChance = 2419,

		[Description("Unique Minimum Chaos Damage To Reflect To Self On Attack")]
		UniqueMinimumChaosDamageToReflectToSelfOnAttack = 2420,

		[Description("Unique Maximum Chaos Damage To Reflect To Self On Attack")]
		UniqueMaximumChaosDamageToReflectToSelfOnAttack = 2421,

		[Description("Map Monsters Curse Effect +%")]
		MapMonstersCurseEffectPosPct = 2422,

		[Description("Map Mission Variation2")]
		MapMissionVariation2 = 2423,

		[Description("Map Player Has Random Level X Curse Every 10 Seconds")]
		MapPlayerHasRandomLevelXCurseEvery10Seconds = 2424,

		[Description("Display Map Inhabited By Wild Beasts")]
		DisplayMapInhabitedByWildBeasts = 2425,
		[Description("Monster No Drops")] MonsterNoDrops = 2426,
		[Description("Map Monster No Drops")] MapMonsterNoDrops = 2427,

		[Description("Life Regeneration Rate +%")]
		LifeRegenerationRatePosPct = 2428,
		[Description("Cannot Be Blinded")] CannotBeBlinded = 2429,

		[Description("Local Socketed Skill Gem Level +")]
		LocalSocketedSkillGemLevelPos = 2430,

		[Description("Gain Unholy Might On Rampage Threshold Ms")]
		GainUnholyMightOnRampageThresholdMs = 2431,

		[Description("Elemental Damage +% Per Level")]
		ElementalDamagePosPctPerLevel = 2432,

		[Description("Chaos Damage +% Per Level")]
		ChaosDamagePosPctPerLevel = 2433,

		[Description("Life Gained On Enemy Death Per Level")]
		LifeGainedOnEnemyDeathPerLevel = 2434,

		[Description("Mana Gained On Enemy Death")]
		ManaGainedOnEnemyDeath = 2435,

		[Description("Energy Shield Gained On Enemy Death")]
		EnergyShieldGainedOnEnemyDeath = 2436,

		[Description("Mana Gained On Enemy Death Per Level")]
		ManaGainedOnEnemyDeathPerLevel = 2437,

		[Description("Energy Shield Gained On Enemy Death Per Level")]
		EnergyShieldGainedOnEnemyDeathPerLevel = 2438,

		[Description("Aura Cannot Affect Self")]
		AuraCannotAffectSelf = 2439,

		[Description("Map Scion Mission Monster Pack")]
		MapScionMissionMonsterPack = 2440,

		[Description("Mace Critical Strike Chance +%")]
		MaceCriticalStrikeChancePosPct = 2441,

		[Description("Staff Critical Strike Chance +%")]
		StaffCriticalStrikeChancePosPct = 2442,

		[Description("Wand Critical Strike Chance +%")]
		WandCriticalStrikeChancePosPct = 2443,

		[Description("Wand Critical Strike Multiplier +")]
		WandCriticalStrikeMultiplierPos = 2444,

		[Description("Bow Stun Threshold Reduction +%")]
		BowStunThresholdReductionPosPct = 2445,

		[Description("Number Of Animated Bows To Summon")]
		NumberOfAnimatedBowsToSummon = 2446,

		[Description("Number Of Animated Daggers To Summon")]
		NumberOfAnimatedDaggersToSummon = 2447,

		[Description("Number Of Animated Two Handed Swords To Summon")]
		NumberOfAnimatedTwoHandedSwordsToSummon = 2448,

		[Description("Firestorm Avoid Unwalkable Terrain")]
		FirestormAvoidUnwalkableTerrain = 2449,

		[Description("Ground Effect Ring Type")]
		GroundEffectRingType = 2450,

		[Description("Local Display Socketed Gems Have Elemental Equilibrium")]
		LocalDisplaySocketedGemsHaveElementalEquilibrium = 2451,

		[Description("Unique Fire Damage Resistance % When Red Gem Socketed")]
		UniqueFireDamageResistancePctWhenRedGemSocketed = 2452,

		[Description("Unique Cold Damage Resistance % When Green Gem Socketed")]
		UniqueColdDamageResistancePctWhenGreenGemSocketed = 2453,

		[Description("Unique Lightning Damage Resistance % When Blue Gem Socketed")]
		UniqueLightningDamageResistancePctWhenBlueGemSocketed = 2454,
		[Description("Skill Mana Cost +")] SkillManaCostPos = 2455,

		[Description("Map Aoe Daemons Per 100 Tiles")]
		MapAoeDaemonsPer100Tiles = 2456,

		[Description("Map Aoe Daemons Variation")]
		MapAoeDaemonsVariation = 2457,

		[Description("Monster No Beyond Portal")]
		MonsterNoBeyondPortal = 2458,

		[Description("Local Socketed Support Gem Quality +")]
		LocalSocketedSupportGemQualityPos = 2459,

		[Description("Map Packs Are Str Mission Totems")]
		MapPacksAreStrMissionTotems = 2460,

		[Description("Chance To Grant Frenzy Charge On Death %")]
		ChanceToGrantFrenzyChargeOnDeathPct = 2461,

		[Description("Life Granted When Hit By Attacks")]
		LifeGrantedWhenHitByAttacks = 2462,

		[Description("Mana Granted When Hit By Attacks")]
		ManaGrantedWhenHitByAttacks = 2463,

		[Description("Life Granted When Killed")]
		LifeGrantedWhenKilled = 2464,

		[Description("Mana Granted When Killed")]
		ManaGrantedWhenKilled = 2465,

		[Description("Evasion Rating +% Final From Poachers Mark")]
		EvasionRatingPosPctFinalFromPoachersMark = 2466,

		[Description("Monster Interactible Corpse")]
		MonsterInteractibleCorpse = 2467,

		[Description("Revive All With Onslaught Make Minions")]
		ReviveAllWithOnslaughtMakeMinions = 2468,

		[Description("Revive All With Onslaught Make Unusable")]
		ReviveAllWithOnslaughtMakeUnusable = 2469,

		[Description("Additive Spell Damage Modifiers Apply To Attack Damage")]
		AdditiveSpellDamageModifiersApplyToAttackDamage = 2470,
		[Description("Monster Minimap Icon")] MonsterMinimapIcon = 2471,
		[Description("Is Trap Object")] IsTrapObject = 2472,

		[Description("Attack Projectiles Return")]
		AttackProjectilesReturn = 2473,

		[Description("Attack Projectiles Return If No Hit Object")]
		AttackProjectilesReturnIfNoHitObject = 2474,

		[Description("Minion Damage +% Per 10 Rampage Stacks")]
		MinionDamagePosPctPer10RampageStacks = 2475,

		[Description("Minion Movement Velocity +% Per 10 Rampage Stacks")]
		MinionMovementVelocityPosPctPer10RampageStacks = 2476,

		[Description("Virtual Minion Damage +%")]
		VirtualMinionDamagePosPct = 2477,

		[Description("Player Dex Mission Enable Pointer")]
		PlayerDexMissionEnablePointer = 2478,

		[Description("Map Hidden Monster Life +% Final")]
		MapHiddenMonsterLifePosPctFinal = 2479,

		[Description("Map Hidden Monster Damage +% Final")]
		MapHiddenMonsterDamagePosPctFinal = 2480,

		[Description("Projectiles Not Offset")]
		ProjectilesNotOffset = 2481,

		[Description("Herald Of Ash Fire Damage +%")]
		HeraldOfAshFireDamagePosPct = 2482,

		[Description("Map Num Extra Invasion Bosses")]
		MapNumExtraInvasionBosses = 2483,

		[Description("Map Num Extra Strongboxes")]
		MapNumExtraStrongboxes = 2484,
		[Description("Map Num Extra Shrines")] MapNumExtraShrines = 2485,

		[Description("Map All Monster Packs Rare And Allow Magic")]
		MapAllMonsterPacksRareAndAllowMagic = 2486,

		[Description("Duelist Master Is Dummy Variation")]
		DuelistMasterIsDummyVariation = 2487,

		[Description("Soul Eater Ignore Non Experience Monsters")]
		SoulEaterIgnoreNonExperienceMonsters = 2488,

		[Description("Summoned Monsters Are Minions")]
		SummonedMonstersAreMinions = 2489,

		[Description("Summoned Monsters No Drops Or Experience")]
		SummonedMonstersNoDropsOrExperience = 2490,

		[Description("Monster Do Not Fracture")]
		MonsterDoNotFracture = 2491,

		[Description("Item Generation Cannot Change Prefixes")]
		ItemGenerationCannotChangePrefixes = 2492,

		[Description("Item Generation Cannot Change Suffixes")]
		ItemGenerationCannotChangeSuffixes = 2493,

		[Description("Item Generation Cannot Roll Caster Affixes")]
		ItemGenerationCannotRollCasterAffixes = 2494,

		[Description("Item Generation Cannot Roll Attack Affixes")]
		ItemGenerationCannotRollAttackAffixes = 2495,

		[Description("Item Generation Can Have Multiple Crafted Mods")]
		ItemGenerationCanHaveMultipleCraftedMods = 2496,

		[Description("Map Set League Category")]
		MapSetLeagueCategory = 2497,

		[Description("Local Level Requirement +")]
		LocalLevelRequirementPos = 2498,

		[Description("Projectile Spiral Nova Starting Angle Offset")]
		ProjectileSpiralNovaStartingAngleOffset = 2499,

		[Description("Projectile Spiral Nova Both Directions")]
		ProjectileSpiralNovaBothDirections = 2500,

		[Description("Triggered Spell Spell Damage +%")]
		TriggeredSpellSpellDamagePosPct = 2501,

		[Description("Damage +% Vs Blinded Enemies")]
		DamagePosPctVsBlindedEnemies = 2502,

		[Description("Ground Smoke When Hit %")]
		GroundSmokeWhenHitPct = 2503,
		[Description("Number Of Beacons")] NumberOfBeacons = 2504,
		[Description("Is Dead")] IsDead = 2505,

		[Description("Area Of Effect +% While Dead")]
		AreaOfEffectPosPctWhileDead = 2506,

		[Description("Beacon Placement Radius")]
		BeaconPlacementRadius = 2507,

		[Description("Map Area Portal Variation")]
		MapAreaPortalVariation = 2508,
		[Description("Skill Is Triggered")] SkillIsTriggered = 2509,
		[Description("Skill Is Curse")] SkillIsCurse = 2510,

		[Description("Skill Triggerable Spell")]
		SkillTriggerableSpell = 2511,

		[Description("Unique Mjolner Lightning Spells Triggered")]
		UniqueMjolnerLightningSpellsTriggered = 2512,

		[Description("Skill Number Of Triggers")]
		SkillNumberOfTriggers = 2513,

		[Description("Curse On Block Level 5 Vulnerability")]
		CurseOnBlockLevel5Vulnerability = 2514,

		[Description("Monster Enrages On Low Life Text")]
		MonsterEnragesOnLowLifeText = 2515,

		[Description("Drop Bear Fall On Target")]
		DropBearFallOnTarget = 2516,

		[Description("Map Magic Pack Mod Rules")]
		MapMagicPackModRules = 2517,

		[Description("Display Map Has Oxygen")]
		DisplayMapHasOxygen = 2518,

		[Description("Bloodlines Beacon On Death Variation")]
		BloodlinesBeaconOnDeathVariation = 2519,

		[Description("Actor Scale +% Granted To Pack Members On Death")]
		ActorScalePosPctGrantedToPackMembersOnDeath = 2520,

		[Description("Maximum Life +% Granted To Pack Members On Death")]
		MaximumLifePosPctGrantedToPackMembersOnDeath = 2521,

		[Description("Monster Dodge Direction")]
		MonsterDodgeDirection = 2522,

		[Description("Herald Of Ice Cold Damage +%")]
		HeraldOfIceColdDamagePosPct = 2523,

		[Description("Herald Of Thunder Lightning Damage +%")]
		HeraldOfThunderLightningDamagePosPct = 2524,

		[Description("Number Of Taniwha Tails Allowed")]
		NumberOfTaniwhaTailsAllowed = 2525,

		[Description("Minion Dies When Parent Dies")]
		MinionDiesWhenParentDies = 2526,

		[Description("Unique Nearby Allies Recover Permyriad Max Life On Death")]
		UniqueNearbyAlliesRecoverPermyriadMaxLifeOnDeath = 2527,

		[Description("Suppress Mod Stat Display")]
		SuppressModStatDisplay = 2528,

		[Description("Base Steal Power Frenzy Endurance Charges On Hit %")]
		BaseStealPowerFrenzyEnduranceChargesOnHitPct = 2529,

		[Description("Cannot Die And Damage +% Near Pack Corpse")]
		CannotDieAndDamagePosPctNearPackCorpse = 2530,

		[Description("Projectile Spread Radius")]
		ProjectileSpreadRadius = 2531,

		[Description("Local Item Drops On Death If Equipped By Animate Armour")]
		LocalItemDropsOnDeathIfEquippedByAnimateArmour = 2532,

		[Description("Physical Attack Damage +%")]
		PhysicalAttackDamagePosPct = 2533,

		[Description("Melee Physical Damage +% While Holding Shield")]
		MeleePhysicalDamagePosPctWhileHoldingShield = 2534,

		[Description("Local Display Socketed Gems Get Cast On Death Level")]
		LocalDisplaySocketedGemsGetCastOnDeathLevel = 2535,

		[Description("Cluster Burst Spawn Amount")]
		ClusterBurstSpawnAmount = 2536,

		[Description("Bloodline Daemon Update Count On Death")]
		BloodlineDaemonUpdateCountOnDeath = 2537,

		[Description("Bloodline Daemon Pack Death Count")]
		BloodlineDaemonPackDeathCount = 2538,

		[Description("Bloodline Summon Blood Monster On Pack Death")]
		BloodlineSummonBloodMonsterOnPackDeath = 2539,

		[Description("Damage Taken +% Per Bloodline Damage Charge")]
		DamageTakenPosPctPerBloodlineDamageCharge = 2540,

		[Description("Attack Speed +% Per Bloodline Speed Charge")]
		AttackSpeedPosPctPerBloodlineSpeedCharge = 2541,

		[Description("Cast Speed +% Per Bloodline Speed Charge")]
		CastSpeedPosPctPerBloodlineSpeedCharge = 2542,

		[Description("Current Bloodline Damage Charges")]
		CurrentBloodlineDamageCharges = 2543,

		[Description("Current Bloodline Speed Charges")]
		CurrentBloodlineSpeedCharges = 2544,

		[Description("Maximum Bloodline Damage Charges")]
		MaximumBloodlineDamageCharges = 2545,

		[Description("Maximum Bloodline Speed Charges")]
		MaximumBloodlineSpeedCharges = 2546,

		[Description("Apply X Random Curses On Hit")]
		ApplyXRandomCursesOnHit = 2547,

		[Description("Total Projectile Spread Angle Override")]
		TotalProjectileSpreadAngleOverride = 2548,
		[Description("Map Beyond Chance %")] MapBeyondChancePct = 2549,

		[Description("Map Boss Vaal Item Drop %")]
		MapBossVaalItemDropPct = 2550,
		[Description("Map Is Corrupted")] MapIsCorrupted = 2551,
		[Description("Map No Strongboxes")] MapNoStrongboxes = 2552,

		[Description("Keystone Acrobatics Block Chance +% Final")]
		KeystoneAcrobaticsBlockChancePosPctFinal = 2553,

		[Description("Corpse Consumption Affects Pack")]
		CorpseConsumptionAffectsPack = 2554,

		[Description("Damage +% Per Bloodline Damage Charge")]
		DamagePosPctPerBloodlineDamageCharge = 2555,

		[Description("Movement Speed +% Per Bloodline Speed Charge")]
		MovementSpeedPosPctPerBloodlineSpeedCharge = 2556,

		[Description("Active Skill Area Damage +% Final")]
		ActiveSkillAreaDamagePosPctFinal = 2557,

		[Description("Monster Share Charges With Pack")]
		MonsterShareChargesWithPack = 2558,

		[Description("Melee Counterattack Trigger On Block %")]
		MeleeCounterattackTriggerOnBlockPct = 2559,

		[Description("Bloodline Firestorm Scales With Pack Death")]
		BloodlineFirestormScalesWithPackDeath = 2560,

		[Description("Base Fire Damage % Of Maximum Life Plus Maximum Es Taken Per Minute")]
		BaseFireDamagePctOfMaximumLifePlusMaximumEsTakenPerMinute = 2561,
		[Description("Is Totem Object")] IsTotemObject = 2562,
		[Description("Uses No Mana")] UsesNoMana = 2563,

		[Description("Monster Spawn Bloodlines Ghost Totem On Death")]
		MonsterSpawnBloodlinesGhostTotemOnDeath = 2564,

		[Description("Skill Triggerable Attack")]
		SkillTriggerableAttack = 2565,

		[Description("Attack Unusable If Triggerable")]
		AttackUnusableIfTriggerable = 2566,
		[Description("Clone Hidden Duration")] CloneHiddenDuration = 2567,

		[Description("Never Take Critical Strike")]
		NeverTakeCriticalStrike = 2568,

		[Description("Tormented Necromancer Spawn Monster On Death Variation")]
		TormentedNecromancerSpawnMonsterOnDeathVariation = 2569,

		[Description("Tormented Mutilator Spawn Monster On Death Variation")]
		TormentedMutilatorSpawnMonsterOnDeathVariation = 2570,

		[Description("Spawn Monster On Death Variation")]
		SpawnMonsterOnDeathVariation = 2571,

		[Description("Map Spawn Tormented Spirits")]
		MapSpawnTormentedSpirits = 2572,

		[Description("Damage +% Vs Frozen Shocked Ignited Enemies")]
		DamagePosPctVsFrozenShockedIgnitedEnemies = 2573,

		[Description("Bloodlines Animate Guardian On Death")]
		BloodlinesAnimateGuardianOnDeath = 2574,

		[Description("Melee Counterattack Trigger On Hit %")]
		MeleeCounterattackTriggerOnHitPct = 2575,
		[Description("Reduce Enemy Dodge %")] ReduceEnemyDodgePct = 2576,

		[Description("Shield Counterattack Aoe Range")]
		ShieldCounterattackAoeRange = 2577,

		[Description("Bloodlines Monster Unholy Might Duration Ms")]
		BloodlinesMonsterUnholyMightDurationMs = 2578,

		[Description("Bloodlines Monster Unholy Might Damage Taken +%")]
		BloodlinesMonsterUnholyMightDamageTakenPosPct = 2579,

		[Description("Bloodlines Phylacteral Link Is Vulnerable")]
		BloodlinesPhylacteralLinkIsVulnerable = 2580,

		[Description("Bloodlines Full Guardian Size +% On Death")]
		BloodlinesFullGuardianSizePosPctOnDeath = 2581,

		[Description("Bloodlines Guardian Damage +% On Death")]
		BloodlinesGuardianDamagePosPctOnDeath = 2582,

		[Description("Bloodlines Guardian Attack Speed +% On Death")]
		BloodlinesGuardianAttackSpeedPosPctOnDeath = 2583,

		[Description("Bloodlines Guardian Movement Speed +% On Death")]
		BloodlinesGuardianMovementSpeedPosPctOnDeath = 2584,

		[Description("Bloodlines Force Drop Of Pack Item Type Rarity")]
		BloodlinesForceDropOfPackItemTypeRarity = 2585,

		[Description("Merveil Number Of Geysers")]
		MerveilNumberOfGeysers = 2586,

		[Description("Weapon Elemental Damage +% While Using Flask")]
		WeaponElementalDamagePosPctWhileUsingFlask = 2587,

		[Description("Attack Speed +% While Holding Shield")]
		AttackSpeedPosPctWhileHoldingShield = 2588,

		[Description("Create Trap At Target Location")]
		CreateTrapAtTargetLocation = 2589,
		[Description("Avoid Knockback %")] AvoidKnockbackPct = 2590,

		[Description("Bloodlines Corrupted Blood % Average Damage To Deal Per Minute Per Stack For 20 Pack Members")]
		BloodlinesCorruptedBloodPctAverageDamageToDealPerMinutePerStackFor20PackMembers = 2591,
		[Description("Cant Touch This")] CantTouchThis = 2592,
		[Description("Cant Possess This")] CantPossessThis = 2593,

		[Description("Base Physical Damage % Of Maximum Life Taken Per Minute")]
		BasePhysicalDamagePctOfMaximumLifeTakenPerMinute = 2594,

		[Description("Static Strike Explosion Damage +% Final")]
		StaticStrikeExplosionDamagePosPctFinal = 2595,
		[Description("Disable Highlight")] DisableHighlight = 2596,
		[Description("Removes % Mana On Hit")] RemovesPctManaOnHit = 2597,

		[Description("Curse When Hit % Silence")]
		CurseWhenHitPctSilence = 2598,

		[Description("Life Gain On Ignited Enemy Hit")]
		LifeGainOnIgnitedEnemyHit = 2599,

		[Description("Minimum Added Physical Damage Vs Frozen Enemies")]
		MinimumAddedPhysicalDamageVsFrozenEnemies = 2600,

		[Description("Maximum Added Physical Damage Vs Frozen Enemies")]
		MaximumAddedPhysicalDamageVsFrozenEnemies = 2601,

		[Description("Damage Vs Shocked Enemies +%")]
		DamageVsShockedEnemiesPosPct = 2602,

		[Description("Old Do Not Use Life Leech Permyriad Vs Shocked Enemies")]
		OldDoNotUseLifeLeechPermyriadVsShockedEnemies = 2603,

		[Description("Physical Damage As Fire Damage Vs Ignited Enemies %")]
		PhysicalDamageAsFireDamageVsIgnitedEnemiesPct = 2604,

		[Description("Local Display Socketed Melee Gems Have Area Radius +%")]
		LocalDisplaySocketedMeleeGemsHaveAreaRadiusPosPct = 2605,

		[Description("Local Display Socketed Red Gems Have % Of Physical Damage To Add As Fire")]
		LocalDisplaySocketedRedGemsHavePctOfPhysicalDamageToAddAsFire = 2606,

		[Description("Curse Effect +% Vs Players")]
		CurseEffectPosPctVsPlayers = 2607,

		[Description("Monster Drop Additional Currency Items")]
		MonsterDropAdditionalCurrencyItems = 2608,

		[Description("Monster Drop Additional Wisdom Scrolls")]
		MonsterDropAdditionalWisdomScrolls = 2609,

		[Description("Monster Drop Additional Portal Scrolls")]
		MonsterDropAdditionalPortalScrolls = 2610,

		[Description("Monster Drop Additional Rings Amulets")]
		MonsterDropAdditionalRingsAmulets = 2611,

		[Description("Item Generation Local Maximum Mod Required Level Override")]
		ItemGenerationLocalMaximumModRequiredLevelOverride = 2612,
		[Description("Block Chance +%")] BlockChancePosPct = 2613,

		[Description("Local Unique Flask Physical Damage Taken % As Cold While Healing")]
		LocalUniqueFlaskPhysicalDamageTakenPctAsColdWhileHealing = 2614,

		[Description("Local Unique Flask Physical Damage % To Add As Cold While Healing")]
		LocalUniqueFlaskPhysicalDamagePctToAddAsColdWhileHealing = 2615,

		[Description("Local Unique Flask Avoid Chill % While Healing")]
		LocalUniqueFlaskAvoidChillPctWhileHealing = 2616,

		[Description("Local Unique Flask Avoid Freeze % While Healing")]
		LocalUniqueFlaskAvoidFreezePctWhileHealing = 2617,

		[Description("Monster Drop Additional Map Items")]
		MonsterDropAdditionalMapItems = 2618,

		[Description("Lightning Warp Move Speed Override")]
		LightningWarpMoveSpeedOverride = 2619,

		[Description("Fire Damage Taken % Causes Additional Physical Damage")]
		FireDamageTakenPctCausesAdditionalPhysicalDamage = 2620,

		[Description("Chill Effectiveness On Self +%")]
		ChillEffectivenessOnSelfPosPct = 2621,

		[Description("Temporal Chains Effeciveness +%")]
		TemporalChainsEffecivenessPosPct = 2622,

		[Description("Gain Flask Charge When Crit %")]
		GainFlaskChargeWhenCritPct = 2623,

		[Description("Gain Flask Charge When Crit Amount")]
		GainFlaskChargeWhenCritAmount = 2624,

		[Description("Self Physical Damage On Skill Use % Mana Cost")]
		SelfPhysicalDamageOnSkillUsePctManaCost = 2625,

		[Description("Torment Embezzler Debuff On Hit Recovery Speed +%")]
		TormentEmbezzlerDebuffOnHitRecoverySpeedPosPct = 2626,

		[Description("Monster No Drops When Not Deleted On Death")]
		MonsterNoDropsWhenNotDeletedOnDeath = 2627,

		[Description("Leech Amount +% Final On Crit")]
		LeechAmountPosPctFinalOnCrit = 2628,

		[Description("Unqiue Atzitis Acuity Instant Leech 60% Effectiveness On Crit")]
		UnqiueAtzitisAcuityInstantLeech60PctEffectivenessOnCrit = 2629,

		[Description("Leech Is Instant On Critical")]
		LeechIsInstantOnCritical = 2630,

		[Description("Bleed On Melee Attack Chance %")]
		BleedOnMeleeAttackChancePct = 2631,

		[Description("Physical Damage Over Time +%")]
		PhysicalDamageOverTimePosPct = 2632,

		[Description("Elemental Equilibrium Effect +%")]
		ElementalEquilibriumEffectPosPct = 2633,

		[Description("Local Display Socketed Gems Have Elemental Equilibrium Effect Pluspercent")]
		LocalDisplaySocketedGemsHaveElementalEquilibriumEffectPluspercent = 2634,
		[Description("Attack Damage +%")] AttackDamagePosPct = 2635,

		[Description("Attack Damage Vs Bleeding Enemies +%")]
		AttackDamageVsBleedingEnemiesPosPct = 2636,

		[Description("Chance To Gain Endurance Charge On Crit %")]
		ChanceToGainEnduranceChargeOnCritPct = 2637,

		[Description("Chance To Gain Power Charge When Block %")]
		ChanceToGainPowerChargeWhenBlockPct = 2638,

		[Description("Stuns Have Culling Strike")]
		StunsHaveCullingStrike = 2639,

		[Description("Chance To Gain Onslaught On Kill %")]
		ChanceToGainOnslaughtOnKillPct = 2640,

		[Description("Onslaught Time Granted On Kill Ms")]
		OnslaughtTimeGrantedOnKillMs = 2641,

		[Description("Base Main Hand Damage +%")]
		BaseMainHandDamagePosPct = 2642,

		[Description("Base Off Hand Attack Speed +%")]
		BaseOffHandAttackSpeedPosPct = 2643,

		[Description("Damage Vs Enemies On Low Life +%")]
		DamageVsEnemiesOnLowLifePosPct = 2644,

		[Description("Drop Additional Rare Items")]
		DropAdditionalRareItems = 2645,

		[Description("Monster Drop Additional Vaal Items")]
		MonsterDropAdditionalVaalItems = 2646,
		[Description("Bloodlines Shrouded")] BloodlinesShrouded = 2647,

		[Description("Monster Pretend To Be Player Level")]
		MonsterPretendToBePlayerLevel = 2648,

		[Description("Monster Display Es When Life Full")]
		MonsterDisplayEsWhenLifeFull = 2649,

		[Description("Minimum Added Fire Damage Vs Ignited Enemies")]
		MinimumAddedFireDamageVsIgnitedEnemies = 2650,

		[Description("Maximum Added Fire Damage Vs Ignited Enemies")]
		MaximumAddedFireDamageVsIgnitedEnemies = 2651,
		[Description("Monster Is Possessed")] MonsterIsPossessed = 2652,

		[Description("Monster Has Second Form")]
		MonsterHasSecondForm = 2653,

		[Description("Map Crash Instance Debug")]
		MapCrashInstanceDebug = 2654,

		[Description("Map Pause Instance Debug")]
		MapPauseInstanceDebug = 2655,

		[Description("Chance To Gain Endurance Charge On Melee Crit %")]
		ChanceToGainEnduranceChargeOnMeleeCritPct = 2656,

		[Description("Physical Damage Per Endurance Charge +%")]
		PhysicalDamagePerEnduranceChargePosPct = 2657,

		[Description("Penetrate Elemental Resistance Per Frenzy Charge %")]
		PenetrateElementalResistancePerFrenzyChargePct = 2658,

		[Description("Damage Vs Enemies On Full Life Per Power Charge +%")]
		DamageVsEnemiesOnFullLifePerPowerChargePosPct = 2659,

		[Description("Damage Vs Enemies On Low Life Per Power Charge +%")]
		DamageVsEnemiesOnLowLifePerPowerChargePosPct = 2660,

		[Description("Monster Dodge Distance")]
		MonsterDodgeDistance = 2661,

		[Description("Cast Socketed Minion Skills On Bow Kill %")]
		CastSocketedMinionSkillsOnBowKillPct = 2662,

		[Description("Minion Damage +% Per 10 Dex")]
		MinionDamagePosPctPer10Dex = 2663,

		[Description("Unique Bow Minion Spells Triggered")]
		UniqueBowMinionSpellsTriggered = 2664,

		[Description("Local Flask Ignite Immunity While Healing")]
		LocalFlaskIgniteImmunityWhileHealing = 2665,

		[Description("Local Flask Chill And Freeze Immunity While Healing")]
		LocalFlaskChillAndFreezeImmunityWhileHealing = 2666,

		[Description("Local Flask Shock Immunity While Healing")]
		LocalFlaskShockImmunityWhileHealing = 2667,

		[Description("Local Flask Bleeding Immunity While Healing")]
		LocalFlaskBleedingImmunityWhileHealing = 2668,
		[Description("Immune To Bleeding")] ImmuneToBleeding = 2669,

		[Description("Local Display Socketed Gems Have Number Of Additional Projectiles")]
		LocalDisplaySocketedGemsHaveNumberOfAdditionalProjectiles = 2670,

		[Description("Local Display Socketed Gems Projectiles Nova")]
		LocalDisplaySocketedGemsProjectilesNova = 2671,

		[Description("Local Display Socketed Gems Skill Effect Duration +%")]
		LocalDisplaySocketedGemsSkillEffectDurationPosPct = 2672,

		[Description("Life Regen Per Minute Per Endurance Charge")]
		LifeRegenPerMinutePerEnduranceCharge = 2673,

		[Description("Vaal Souls Gained Per Minute")]
		VaalSoulsGainedPerMinute = 2674,

		[Description("Attack Damage That Stuns Also Chills")]
		AttackDamageThatStunsAlsoChills = 2675,
		[Description("Cannot Knockback")] CannotKnockback = 2676,

		[Description("Cleave Disable Predictive Damage")]
		CleaveDisablePredictiveDamage = 2677,

		[Description("Display Map Contains Grandmasters")]
		DisplayMapContainsGrandmasters = 2678,

		[Description("Gain X Life When Endurance Charge Expires Or Consumed")]
		GainXLifeWhenEnduranceChargeExpiresOrConsumed = 2679,

		[Description("Virtual Maximum Endurance Charges")]
		VirtualMaximumEnduranceCharges = 2680,

		[Description("Virtual Maximum Frenzy Charges")]
		VirtualMaximumFrenzyCharges = 2681,

		[Description("Virtual Maximum Power Charges")]
		VirtualMaximumPowerCharges = 2682,

		[Description("No Maximum Power Charges")]
		NoMaximumPowerCharges = 2683,

		[Description("Damage Vs Cursed Enemies Per Enemy Curse +%")]
		DamageVsCursedEnemiesPerEnemyCursePosPct = 2684,

		[Description("Virtual Ignite Duration +%")]
		VirtualIgniteDurationPosPct = 2685,

		[Description("Virtual Shock Duration +%")]
		VirtualShockDurationPosPct = 2686,

		[Description("Virtual Freeze Duration +%")]
		VirtualFreezeDurationPosPct = 2687,

		[Description("Virtual Chill Duration +%")]
		VirtualChillDurationPosPct = 2688,

		[Description("Base Elemental Status Ailment Duration +%")]
		BaseElementalStatusAilmentDurationPosPct = 2689,

		[Description("Local Display Socketed Gems Supported By X Knockback Level")]
		LocalDisplaySocketedGemsSupportedByXKnockbackLevel = 2690,

		[Description("Enemy Knockback Direction Is Reversed")]
		EnemyKnockbackDirectionIsReversed = 2691,

		[Description("Map Zana Subarea Mission")]
		MapZanaSubareaMission = 2692,

		[Description("Map Zana Subarea Extra Req")]
		MapZanaSubareaExtraReq = 2693,

		[Description("Immune To Ally Buff Auras")]
		ImmuneToAllyBuffAuras = 2694,

		[Description("Buff Auras Dont Affect Allies")]
		BuffAurasDontAffectAllies = 2695,

		[Description("Hits Can Only Kill Frozen Enemies")]
		HitsCanOnlyKillFrozenEnemies = 2696,

		[Description("Spectral Throw Deceleration Override")]
		SpectralThrowDecelerationOverride = 2697,

		[Description("Maximum Life Taken As Physical Damage On Minion Death %")]
		MaximumLifeTakenAsPhysicalDamageOnMinionDeathPct = 2698,

		[Description("Maximum Es Taken As Physical Damage On Minion Death %")]
		MaximumEsTakenAsPhysicalDamageOnMinionDeathPct = 2699,

		[Description("Minion Skill Area Of Effect +%")]
		MinionSkillAreaOfEffectPosPct = 2700,

		[Description("Energy Shield Regeneration % Per Minute While Shocked")]
		EnergyShieldRegenerationPctPerMinuteWhileShocked = 2701,

		[Description("Chest Drops Extra Vaal Fragments")]
		ChestDropsExtraVaalFragments = 2702,

		[Description("Chest Drops Extra Rare Items Of Same Base Type")]
		ChestDropsExtraRareItemsOfSameBaseType = 2703,
		[Description("Ignite Art Variation")] IgniteArtVariation = 2704,
		[Description("Curse Apply As Aura")] CurseApplyAsAura = 2705,

		[Description("Combined Pvp Damage +% Final")]
		CombinedPvpDamagePosPctFinal = 2706,

		[Description("Support Cast On Death Pvp Damage +% Final")]
		SupportCastOnDeathPvpDamagePosPctFinal = 2707,

		[Description("Support Cast On Damage Taken Pvp Damage +% Final")]
		SupportCastOnDamageTakenPvpDamagePosPctFinal = 2708,

		[Description("Support Cast When Stunned Pvp Damage +% Final")]
		SupportCastWhenStunnedPvpDamagePosPctFinal = 2709,

		[Description("Support Cast On Crit Pvp Damage +% Final")]
		SupportCastOnCritPvpDamagePosPctFinal = 2710,

		[Description("Support Bloodlust Melee Physical Damage +% Final Vs Bleeding Enemies")]
		SupportBloodlustMeleePhysicalDamagePosPctFinalVsBleedingEnemies = 2711,

		[Description("Support Bloodlust Melee Physical Damage +% Final")]
		SupportBloodlustMeleePhysicalDamagePosPctFinal = 2712,

		[Description("Cannot Be Damaged By Nonplayer Damage")]
		CannotBeDamagedByNonplayerDamage = 2713,
		[Description("Cannot Cause Bleeding")] CannotCauseBleeding = 2714,

		[Description("Inspiring Cry Damage +% Per One Hundred Nearby Enemies")]
		InspiringCryDamagePosPctPerOneHundredNearbyEnemies = 2715,
		[Description("Charge Duration +%")] ChargeDurationPosPct = 2716,

		[Description("Virtual Power Charge Duration +%")]
		VirtualPowerChargeDurationPosPct = 2717,

		[Description("Virtual Endurance Charge Duration +%")]
		VirtualEnduranceChargeDurationPosPct = 2718,

		[Description("Daresso Attack Combo Physical Damage % To Add As Cold")]
		DaressoAttackComboPhysicalDamagePctToAddAsCold = 2719,

		[Description("Old Do Not Use Life Leech From Attack Damage Permyriad Vs Chilled Enemies")]
		OldDoNotUseLifeLeechFromAttackDamagePermyriadVsChilledEnemies = 2720,

		[Description("Base Life Leech From Attack Damage Permyriad")]
		BaseLifeLeechFromAttackDamagePermyriad = 2721,

		[Description("Base Mana Leech From Attack Damage Permyriad")]
		BaseManaLeechFromAttackDamagePermyriad = 2722,
		[Description("Test Stat Check Code")] TestStatCheckCode = 2723,

		[Description("Monster Penalty Against Minions Damage +% Final")]
		MonsterPenaltyAgainstMinionsDamagePosPctFinal = 2724,

		[Description("Monster Penalty Against Minions Damage +% Final Vs Player Minions")]
		MonsterPenaltyAgainstMinionsDamagePosPctFinalVsPlayerMinions = 2725,

		[Description("Physical Damage Taken On Minion Death")]
		PhysicalDamageTakenOnMinionDeath = 2726,

		[Description("Abyssal Cry Movement Velocity +% Per One Hundred Nearby Enemies")]
		AbyssalCryMovementVelocityPosPctPerOneHundredNearbyEnemies = 2727,

		[Description("Onslaught Buff Duration On Culling Strike Ms")]
		OnslaughtBuffDurationOnCullingStrikeMs = 2728,

		[Description("Base Avoid Chill % While Have Onslaught")]
		BaseAvoidChillPctWhileHaveOnslaught = 2729,

		[Description("Base Avoid Freeze % While Have Onslaught")]
		BaseAvoidFreezePctWhileHaveOnslaught = 2730,

		[Description("Base Avoid Shock % While Have Onslaught")]
		BaseAvoidShockPctWhileHaveOnslaught = 2731,

		[Description("Base Avoid Ignite % While Have Onslaught")]
		BaseAvoidIgnitePctWhileHaveOnslaught = 2732,

		[Description("Avoid Chill % While Have Onslaught")]
		AvoidChillPctWhileHaveOnslaught = 2733,

		[Description("Avoid Freeze % While Have Onslaught")]
		AvoidFreezePctWhileHaveOnslaught = 2734,

		[Description("Avoid Shock % While Have Onslaught")]
		AvoidShockPctWhileHaveOnslaught = 2735,

		[Description("Avoid Ignite % While Have Onslaught")]
		AvoidIgnitePctWhileHaveOnslaught = 2736,

		[Description("Attack Minimum Added Lightning Damage While Unarmed")]
		AttackMinimumAddedLightningDamageWhileUnarmed = 2737,

		[Description("Attack Maximum Added Lightning Damage While Unarmed")]
		AttackMaximumAddedLightningDamageWhileUnarmed = 2738,

		[Description("Spell Minimum Added Lightning Damage While Unarmed")]
		SpellMinimumAddedLightningDamageWhileUnarmed = 2739,

		[Description("Spell Maximum Added Lightning Damage While Unarmed")]
		SpellMaximumAddedLightningDamageWhileUnarmed = 2740,

		[Description("Gain X Energy Shield On Killing Shocked Enemy")]
		GainXEnergyShieldOnKillingShockedEnemy = 2741,

		[Description("Support Concentrated Effect Skill Area Of Effect +% Final")]
		SupportConcentratedEffectSkillAreaOfEffectPosPctFinal = 2742,

		[Description("Elemental Damage +% Per Frenzy Charge")]
		ElementalDamagePosPctPerFrenzyCharge = 2743,
		[Description("Chaos Damage Poisons")] ChaosDamagePoisons = 2744,
		[Description("Mine Extra Uses")] MineExtraUses = 2745,

		[Description("From Code Active Skill Damage +% Final")]
		FromCodeActiveSkillDamagePosPctFinal = 2746,

		[Description("Newshocknova First Ring Damage +% Final")]
		NewshocknovaFirstRingDamagePosPctFinal = 2747,

		[Description("Ice Crash Second Hit Damage +% Final")]
		IceCrashSecondHitDamagePosPctFinal = 2748,

		[Description("Killed Monster Dropped Item Rarity +% When Frozen")]
		KilledMonsterDroppedItemRarityPosPctWhenFrozen = 2749,

		[Description("Local Six Linked Sockets")]
		LocalSixLinkedSockets = 2750,

		[Description("Local Display Socketed Gems Get Generosity Level")]
		LocalDisplaySocketedGemsGetGenerosityLevel = 2751,

		[Description("Local Display Socketed Gems Get Remote Mine Level")]
		LocalDisplaySocketedGemsGetRemoteMineLevel = 2752,

		[Description("Local Display Aura Life Regeneration Rate Per Minute %")]
		LocalDisplayAuraLifeRegenerationRatePerMinutePct = 2753,

		[Description("Local Display Aura Mana Regeneration Rate +%")]
		LocalDisplayAuraManaRegenerationRatePosPct = 2754,

		[Description("Unique Insanity Do Weird Things")]
		UniqueInsanityDoWeirdThings = 2755,

		[Description("Base Elemental Damage Heals")]
		BaseElementalDamageHeals = 2756,

		[Description("Base Fire Damage Heals")]
		BaseFireDamageHeals = 2757,

		[Description("Base Cold Damage Heals")]
		BaseColdDamageHeals = 2758,

		[Description("Base Lightning Damage Heals")]
		BaseLightningDamageHeals = 2759,
		[Description("Fire Damage Heals")] FireDamageHeals = 2760,
		[Description("Cold Damage Heals")] ColdDamageHeals = 2761,

		[Description("Lightning Damage Heals")]
		LightningDamageHeals = 2762,

		[Description("Chance To Gain Power Charge On Melee Stun %")]
		ChanceToGainPowerChargeOnMeleeStunPct = 2763,

		[Description("Gain Unholy Might For 2 Seconds On Melee Crit")]
		GainUnholyMightFor2SecondsOnMeleeCrit = 2764,

		[Description("Unique Mine Damage +% Final")]
		UniqueMineDamagePosPctFinal = 2765,

		[Description("Abyssal Cry % Max Life As Chaos On Death")]
		AbyssalCryPctMaxLifeAsChaosOnDeath = 2766,

		[Description("Ignites Reflected To Self")]
		IgnitesReflectedToSelf = 2767,

		[Description("Avoid Freeze Chill Ignite % While Have Onslaught")]
		AvoidFreezeChillIgnitePctWhileHaveOnslaught = 2768,

		[Description("Sword Physical Damage % To Add As Fire")]
		SwordPhysicalDamagePctToAddAsFire = 2769,

		[Description("Gain Onslaught When Ignited Ms")]
		GainOnslaughtWhenIgnitedMs = 2770,

		[Description("Blind Nearby Enemies When Ignited %")]
		BlindNearbyEnemiesWhenIgnitedPct = 2771,
		[Description("Map Has Weather")] MapHasWeather = 2772,

		[Description("Malachai Elemental Cone Spell Minimum Damage")]
		MalachaiElementalConeSpellMinimumDamage = 2773,

		[Description("Malachai Elemental Cone Spell Maximum Damage")]
		MalachaiElementalConeSpellMaximumDamage = 2774,

		[Description("Local Display Socketed Gems Supported By Pierce Level")]
		LocalDisplaySocketedGemsSupportedByPierceLevel = 2775,

		[Description("Map Non Unique Equipment Drops As Sell Price")]
		MapNonUniqueEquipmentDropsAsSellPrice = 2776,

		[Description("Local Flask Use Causes Monster Flee Chance %")]
		LocalFlaskUseCausesMonsterFleeChancePct = 2777,

		[Description("Local Unique Lions Roar Melee Physical Damage +% Final During Flask Effect")]
		LocalUniqueLionsRoarMeleePhysicalDamagePosPctFinalDuringFlaskEffect = 2778,

		[Description("Unique Lions Roar Melee Physical Damage +% Final")]
		UniqueLionsRoarMeleePhysicalDamagePosPctFinal = 2779,

		[Description("Local Flask Adds Knockback During Flask Effect")]
		LocalFlaskAddsKnockbackDuringFlaskEffect = 2780,

		[Description("Map Items Drop Corrupted")]
		MapItemsDropCorrupted = 2781,

		[Description("Chest Number Of Additional Spider Uniques To Drop")]
		ChestNumberOfAdditionalSpiderUniquesToDrop = 2782,

		[Description("Virtual Mana Gain Per Target")]
		VirtualManaGainPerTarget = 2783,

		[Description("Life And Mana Gain Per Hit")]
		LifeAndManaGainPerHit = 2784,

		[Description("Life And Mana Leech From Physical Damage Permyriad")]
		LifeAndManaLeechFromPhysicalDamagePermyriad = 2785,

		[Description("Cannot Inflict Status Ailments")]
		CannotInflictStatusAilments = 2786,

		[Description("Map Weapons Drop Animated")]
		MapWeaponsDropAnimated = 2787,
		[Description("Attacks Bleed On Stun")] AttacksBleedOnStun = 2788,

		[Description("Chance To Fortify On Melee Hit +%")]
		ChanceToFortifyOnMeleeHitPosPct = 2789,
		[Description("Taunt Target Id")] TauntTargetId = 2790,

		[Description("Spell Minimum Base Cold Damage + Per 10 Intelligence")]
		SpellMinimumBaseColdDamagePosPer10Intelligence = 2791,

		[Description("Spell Maximum Base Cold Damage + Per 10 Intelligence")]
		SpellMaximumBaseColdDamagePosPer10Intelligence = 2792,

		[Description("Skill Effect Duration +% Per 10 Strength")]
		SkillEffectDurationPosPctPer10Strength = 2793,

		[Description("Virtual Skill Effect Duration +%")]
		VirtualSkillEffectDurationPosPct = 2794,
		[Description("Skill Is Fire Skill")] SkillIsFireSkill = 2795,
		[Description("Skill Is Cold Skill")] SkillIsColdSkill = 2796,

		[Description("Skill Is Lightning Skill")]
		SkillIsLightningSkill = 2797,

		[Description("Ground Slam Cone Angle Override")]
		GroundSlamConeAngleOverride = 2798,

		[Description("Virtual Minion Movement Velocity +%")]
		VirtualMinionMovementVelocityPosPct = 2799,

		[Description("Map Disable Torment Spirits")]
		MapDisableTormentSpirits = 2800,

		[Description("Map Spawn Extra Torment Spirits")]
		MapSpawnExtraTormentSpirits = 2801,

		[Description("Use Goddess Player Audio")]
		UseGoddessPlayerAudio = 2802,

		[Description("Local Display Grants Skill Gluttony Of Elements Level")]
		LocalDisplayGrantsSkillGluttonyOfElementsLevel = 2803,

		[Description("Local Display Socketed Gems Get Pierce Level")]
		LocalDisplaySocketedGemsGetPierceLevel = 2804,

		[Description("Damage With Fire Skills +%")]
		DamageWithFireSkillsPosPct = 2805,

		[Description("Damage With Cold Skills +%")]
		DamageWithColdSkillsPosPct = 2806,

		[Description("Damage With Lightning Skills +%")]
		DamageWithLightningSkillsPosPct = 2807,

		[Description("Cast Speed For Fire Skills +%")]
		CastSpeedForFireSkillsPosPct = 2808,

		[Description("Cast Speed For Cold Skills +%")]
		CastSpeedForColdSkillsPosPct = 2809,

		[Description("Cast Speed For Lightning Skills +%")]
		CastSpeedForLightningSkillsPosPct = 2810,

		[Description("Movement Velocity +% While Phasing")]
		MovementVelocityPosPctWhilePhasing = 2811,

		[Description("Phase On Vaal Skill Use Duration Ms")]
		PhaseOnVaalSkillUseDurationMs = 2812,

		[Description("Monster Inherent Damage Taken +% Final")]
		MonsterInherentDamageTakenPosPctFinal = 2813,
		[Description("Taunt Duration +%")] TauntDurationPosPct = 2814,

		[Description("Cyclone Ice Path Radius")]
		CycloneIcePathRadius = 2815,

		[Description("Unarmed Melee Physical Damage +%")]
		UnarmedMeleePhysicalDamagePosPct = 2816,

		[Description("Unarmed Melee Attack Speed +%")]
		UnarmedMeleeAttackSpeedPosPct = 2817,

		[Description("Cast Speed +% While Holding Shield")]
		CastSpeedPosPctWhileHoldingShield = 2818,

		[Description("Cast Speed +% While Holding Staff")]
		CastSpeedPosPctWhileHoldingStaff = 2819,

		[Description("Virtual Energy Shield Gain Per Target")]
		VirtualEnergyShieldGainPerTarget = 2820,

		[Description("Energy Shield Gain Per Target")]
		EnergyShieldGainPerTarget = 2821,

		[Description("Axe Critical Strike Chance +%")]
		AxeCriticalStrikeChancePosPct = 2822,

		[Description("Claw Critical Strike Multiplier +")]
		ClawCriticalStrikeMultiplierPos = 2823,

		[Description("Staff Critical Strike Multiplier +")]
		StaffCriticalStrikeMultiplierPos = 2824,

		[Description("Local Jewel Effect Base Radius")]
		LocalJewelEffectBaseRadius = 2825,

		[Description("Local Jewel Nearby Passives Str To Dex")]
		LocalJewelNearbyPassivesStrToDex = 2826,

		[Description("Local Jewel Nearby Passives Dex To Str")]
		LocalJewelNearbyPassivesDexToStr = 2827,

		[Description("Local Jewel Nearby Passives Str To Int")]
		LocalJewelNearbyPassivesStrToInt = 2828,

		[Description("Local Jewel Nearby Passives Int To Str")]
		LocalJewelNearbyPassivesIntToStr = 2829,

		[Description("Local Jewel Nearby Passives Dex To Int")]
		LocalJewelNearbyPassivesDexToInt = 2830,

		[Description("Local Jewel Nearby Passives Int To Dex")]
		LocalJewelNearbyPassivesIntToDex = 2831,

		[Description("Critical Strike Chance While Wielding Shield +%")]
		CriticalStrikeChanceWhileWieldingShieldPosPct = 2832,

		[Description("Trap Critical Strike Chance +%")]
		TrapCriticalStrikeChancePosPct = 2833,

		[Description("Mine Critical Strike Chance +%")]
		MineCriticalStrikeChancePosPct = 2834,

		[Description("Projectiles Can Shotgun")]
		ProjectilesCanShotgun = 2835,
		[Description("Life Recovery Rate +%")] LifeRecoveryRatePosPct = 2836,
		[Description("Mana Recovery Rate +%")] ManaRecoveryRatePosPct = 2837,

		[Description("Energy Shield Recovery Rate +%")]
		EnergyShieldRecoveryRatePosPct = 2838,

		[Description("Spell Chance To Shock Frozen Enemies %")]
		SpellChanceToShockFrozenEnemiesPct = 2839,
		[Description("Cannot Be Taunted")] CannotBeTaunted = 2840,

		[Description("Cannot Be Taunted When Taunted Ms")]
		CannotBeTauntedWhenTauntedMs = 2841,

		[Description("Attacks Do Not Cost Mana")]
		AttacksDoNotCostMana = 2842,

		[Description("Cannot Leech Or Regenerate Mana")]
		CannotLeechOrRegenerateMana = 2843,

		[Description("Virtual Global Cannot Crit")]
		VirtualGlobalCannotCrit = 2844,

		[Description("Virtual Global Attacks Always Hit")]
		VirtualGlobalAttacksAlwaysHit = 2845,
		[Description("Resolute Technique")] ResoluteTechnique = 2846,

		[Description("Local Life And Mana Leech From Physical Damage Permyriad")]
		LocalLifeAndManaLeechFromPhysicalDamagePermyriad = 2847,

		[Description("Main Hand Local Life And Mana Leech From Physical Damage Permyriad")]
		MainHandLocalLifeAndManaLeechFromPhysicalDamagePermyriad = 2848,

		[Description("Off Hand Local Life And Mana Leech From Physical Damage Permyriad")]
		OffHandLocalLifeAndManaLeechFromPhysicalDamagePermyriad = 2849,

		[Description("Local Flask Use Causes Area Knockback")]
		LocalFlaskUseCausesAreaKnockback = 2850,
		[Description("Skill Is Chaos Skill")] SkillIsChaosSkill = 2851,

		[Description("Critical Strike Multiplier Is 100")]
		CriticalStrikeMultiplierIs100 = 2852,

		[Description("Can Inflict Multiple Ignites")]
		CanInflictMultipleIgnites = 2853,
		[Description("Ignite Duration -%")] IgniteDurationNegPct = 2854,

		[Description("Passive Can Be Allocated Without Connection")]
		PassiveCanBeAllocatedWithoutConnection = 2855,

		[Description("Local Unique Jewel Nearby Disconnected Passives Can Be Allocated")]
		LocalUniqueJewelNearbyDisconnectedPassivesCanBeAllocated = 2856,

		[Description("Local Chance To Bleed On Hit %")]
		LocalChanceToBleedOnHitPct = 2857,

		[Description("Main Hand Local Chance To Bleed On Hit %")]
		MainHandLocalChanceToBleedOnHitPct = 2858,

		[Description("Off Hand Local Chance To Bleed On Hit %")]
		OffHandLocalChanceToBleedOnHitPct = 2859,

		[Description("Skill Total Pvp Damage +% Final")]
		SkillTotalPvpDamagePosPctFinal = 2860,

		[Description("Fire Critical Strike Chance +%")]
		FireCriticalStrikeChancePosPct = 2861,

		[Description("Lightning Critical Strike Chance +%")]
		LightningCriticalStrikeChancePosPct = 2862,

		[Description("Cold Critical Strike Chance +%")]
		ColdCriticalStrikeChancePosPct = 2863,

		[Description("Elemental Critical Strike Chance +%")]
		ElementalCriticalStrikeChancePosPct = 2864,

		[Description("Chaos Critical Strike Chance +%")]
		ChaosCriticalStrikeChancePosPct = 2865,

		[Description("Pvp Shield Damage +% Final")]
		PvpShieldDamagePosPctFinal = 2866,

		[Description("Skill Area Of Effect When Unarmed +%")]
		SkillAreaOfEffectWhenUnarmedPosPct = 2867,

		[Description("Gain X Random Rare Monster Mods On Kill")]
		GainXRandomRareMonsterModsOnKill = 2868,

		[Description("Chance To Gain Power Charge On Stun %")]
		ChanceToGainPowerChargeOnStunPct = 2869,

		[Description("Gain Unholy Might For 2 Seconds On Crit")]
		GainUnholyMightFor2SecondsOnCrit = 2870,

		[Description("Monster Life +% Final From Rarity")]
		MonsterLifePosPctFinalFromRarity = 2871,

		[Description("Monster Life +% Final From Map")]
		MonsterLifePosPctFinalFromMap = 2872,

		[Description("Melee Critical Strike Multiplier + While Wielding Shield")]
		MeleeCriticalStrikeMultiplierPosWhileWieldingShield = 2873,

		[Description("Trap Critical Strike Multiplier +")]
		TrapCriticalStrikeMultiplierPos = 2874,

		[Description("Mine Critical Strike Multiplier +")]
		MineCriticalStrikeMultiplierPos = 2875,

		[Description("Fire Critical Strike Multiplier +")]
		FireCriticalStrikeMultiplierPos = 2876,

		[Description("Lightning Critical Strike Multiplier +")]
		LightningCriticalStrikeMultiplierPos = 2877,

		[Description("Cold Critical Strike Multiplier +")]
		ColdCriticalStrikeMultiplierPos = 2878,

		[Description("Elemental Critical Strike Multiplier +")]
		ElementalCriticalStrikeMultiplierPos = 2879,

		[Description("Chaos Critical Strike Multiplier +")]
		ChaosCriticalStrikeMultiplierPos = 2880,

		[Description("Cast Speed For Chaos Skills +%")]
		CastSpeedForChaosSkillsPosPct = 2881,

		[Description("Spell Block While Dual Wielding %")]
		SpellBlockWhileDualWieldingPct = 2882,

		[Description("Spell Block With Staff %")]
		SpellBlockWithStaffPct = 2883,

		[Description("Recover % Maximum Life When Corpse Destroyed Or Consumed")]
		RecoverPctMaximumLifeWhenCorpseDestroyedOrConsumed = 2884,

		[Description("Local Unique Jewel Totem Life +X% Per 10 Str In Radius")]
		LocalUniqueJewelTotemLifePosXPctPer10StrInRadius = 2885,

		[Description("Minion Chance To Dodge %")]
		MinionChanceToDodgePct = 2886,

		[Description("Local Unique Jewel With 4 Notables Gain X Random Rare Monster Mods On Kill")]
		LocalUniqueJewelWith4NotablesGainXRandomRareMonsterModsOnKill = 2887,

		[Description("Minimum Added Fire Damage Per Active Buff")]
		MinimumAddedFireDamagePerActiveBuff = 2888,

		[Description("Maximum Added Fire Damage Per Active Buff")]
		MaximumAddedFireDamagePerActiveBuff = 2889,

		[Description("Recover % Of Maximum Life On Block")]
		RecoverPctOfMaximumLifeOnBlock = 2890,

		[Description("Minion Recover % Of Maximum Life On Block")]
		MinionRecoverPctOfMaximumLifeOnBlock = 2891,

		[Description("Totems Cannot Be Stunned")]
		TotemsCannotBeStunned = 2892,
		[Description("Is Leeching")] IsLeeching = 2893,

		[Description("Damage +% While Leeching")]
		DamagePosPctWhileLeeching = 2894,
		[Description("Is Life Leeching")] IsLifeLeeching = 2895,
		[Description("Is Mana Leeching")] IsManaLeeching = 2896,
		[Description("Is Es Leeching")] IsEsLeeching = 2897,

		[Description("Movement Velocity +% While Ignited")]
		MovementVelocityPosPctWhileIgnited = 2898,
		[Description("Bow Damage +%")] BowDamagePosPct = 2899,
		[Description("Display Bow Range +")] DisplayBowRangePos = 2900,

		[Description("Bleed On Bow Attack Chance %")]
		BleedOnBowAttackChancePct = 2901,

		[Description("Bow Physical Damage +% While Holding Shield")]
		BowPhysicalDamagePosPctWhileHoldingShield = 2902,

		[Description("Bow Steal Power Frenzy Endurance Charges On Hit %")]
		BowStealPowerFrenzyEnduranceChargesOnHitPct = 2903,

		[Description("Life Leech From Physical Damage With Bow Permyriad")]
		LifeLeechFromPhysicalDamageWithBowPermyriad = 2904,

		[Description("Mana Leech From Physical Damage With Bow Permyriad")]
		ManaLeechFromPhysicalDamageWithBowPermyriad = 2905,

		[Description("Poison On Critical Strike With Bow")]
		PoisonOnCriticalStrikeWithBow = 2906,

		[Description("Bow Elemental Damage +%")]
		BowElementalDamagePosPct = 2907,

		[Description("With Bow Additional Block %")]
		WithBowAdditionalBlockPct = 2908,
		[Description("Bow Enemy Block -%")] BowEnemyBlockNegPct = 2909,

		[Description("Local Unique Jewel Melee Applies To Bow")]
		LocalUniqueJewelMeleeAppliesToBow = 2910,

		[Description("Local Unique Jewel Chaos Damage +% Per 10 Int In Radius")]
		LocalUniqueJewelChaosDamagePosPctPer10IntInRadius = 2911,

		[Description("Local Unique Jewel Passives In Radius Applied To Minions Instead")]
		LocalUniqueJewelPassivesInRadiusAppliedToMinionsInstead = 2912,

		[Description("Life Gained On Hit Per Enemy Status Ailment")]
		LifeGainedOnHitPerEnemyStatusAilment = 2913,

		[Description("Life Gained On Spell Hit Per Enemy Status Ailment")]
		LifeGainedOnSpellHitPerEnemyStatusAilment = 2914,

		[Description("Life Regeneration Rate +% While Es Full")]
		LifeRegenerationRatePosPctWhileEsFull = 2915,

		[Description("Local Unique Jewel With X Int In Radius +1 Curse")]
		LocalUniqueJewelWithXIntInRadiusPos1Curse = 2916,

		[Description("Melee Range + While Unarmed")]
		MeleeRangePosWhileUnarmed = 2917,

		[Description("Damage +% Per Equipped Magic Item")]
		DamagePosPctPerEquippedMagicItem = 2918,

		[Description("Number Of Equipped Magic Items")]
		NumberOfEquippedMagicItems = 2919,

		[Description("Base Number Of Golems Allowed")]
		BaseNumberOfGolemsAllowed = 2920,

		[Description("Number Of Golems Allowed")]
		NumberOfGolemsAllowed = 2921,

		[Description("Fire Golem Grants Damage +%")]
		FireGolemGrantsDamagePosPct = 2922,

		[Description("Ice Golem Grants Critical Strike Chance +%")]
		IceGolemGrantsCriticalStrikeChancePosPct = 2923,

		[Description("Ice Golem Grants Accuracy +%")]
		IceGolemGrantsAccuracyPosPct = 2924,

		[Description("Chaos Golem Grants Additional Physical Damage Reduction %")]
		ChaosGolemGrantsAdditionalPhysicalDamageReductionPct = 2925,

		[Description("Spell Damage +% While Es Full")]
		SpellDamagePosPctWhileEsFull = 2926,

		[Description("Virtual Number Of Additional Projectiles")]
		VirtualNumberOfAdditionalProjectiles = 2927,

		[Description("Totem Number Of Additional Projectiles")]
		TotemNumberOfAdditionalProjectiles = 2928,

		[Description("Chance To Dodge Spells % While Es Full")]
		ChanceToDodgeSpellsPctWhileEsFull = 2929,

		[Description("Chance To Gain Unholy Might On Melee Kill %")]
		ChanceToGainUnholyMightOnMeleeKillPct = 2930,

		[Description("Spell Damage +% While No Mana Reserved")]
		SpellDamagePosPctWhileNoManaReserved = 2931,
		[Description("Mana Reserved")] ManaReserved = 2932,

		[Description("Spell Damage +% While Not Low Mana")]
		SpellDamagePosPctWhileNotLowMana = 2933,

		[Description("Mana Cost +% While Not Low Mana")]
		ManaCostPosPctWhileNotLowMana = 2934,

		[Description("Local Display Grants Skill Icestorm Level")]
		LocalDisplayGrantsSkillIcestormLevel = 2935,

		[Description("Spell Damage +% Per 10 Int")]
		SpellDamagePosPctPer10Int = 2936,

		[Description("Virtual Firestorm Drop Chilled Ground Duration Ms")]
		VirtualFirestormDropChilledGroundDurationMs = 2937,

		[Description("Virtual Firestorm Drop Shocked Ground Duration Ms")]
		VirtualFirestormDropShockedGroundDurationMs = 2938,

		[Description("Virtual Firestorm Drop Burning Ground Duration Ms")]
		VirtualFirestormDropBurningGroundDurationMs = 2939,

		[Description("Number Of Assigned Keystones")]
		NumberOfAssignedKeystones = 2940,

		[Description("All Attributes +% Per Assigned Keystone")]
		AllAttributesPosPctPerAssignedKeystone = 2941,

		[Description("Number Of Additional Clones")]
		NumberOfAdditionalClones = 2942,

		[Description("Damage Taken +% From Hits")]
		DamageTakenPosPctFromHits = 2943,

		[Description("Chance To Gain Frenzy Charge On Killing Frozen Enemy %")]
		ChanceToGainFrenzyChargeOnKillingFrozenEnemyPct = 2944,

		[Description("Damage +% Vs Frozen Enemies")]
		DamagePosPctVsFrozenEnemies = 2945,

		[Description("Support Hypothermia Damage +% Vs Chilled Enemies Final")]
		SupportHypothermiaDamagePosPctVsChilledEnemiesFinal = 2946,

		[Description("Additional Chance To Freeze Chilled Enemies %")]
		AdditionalChanceToFreezeChilledEnemiesPct = 2947,

		[Description("Onslaught Time Granted On Killing Shocked Enemy Ms")]
		OnslaughtTimeGrantedOnKillingShockedEnemyMs = 2948,

		[Description("Support Hypothermia Damage +% Final")]
		SupportHypothermiaDamagePosPctFinal = 2949,

		[Description("Object Inherent Attack Skills Damage +% Final Per Frenzy Charge")]
		ObjectInherentAttackSkillsDamagePosPctFinalPerFrenzyCharge = 2950,

		[Description("Skill Effect Duration Per 100 Int")]
		SkillEffectDurationPer100Int = 2951,

		[Description("Local Unique Jewel Intelligence Per Unallocated Node In Radius")]
		LocalUniqueJewelIntelligencePerUnallocatedNodeInRadius = 2952,

		[Description("Local Unique Jewel With 70 Dex Physical Damage To Add As Chaos %")]
		LocalUniqueJewelWith70DexPhysicalDamageToAddAsChaosPct = 2953,

		[Description("Local Unique Jewel With 70 Str Life Recovery Speed +%")]
		LocalUniqueJewelWith70StrLifeRecoverySpeedPosPct = 2954,

		[Description("Cannot Be Cursed With Silence")]
		CannotBeCursedWithSilence = 2955,

		[Description("Number Of Equipped Corrupted Items")]
		NumberOfEquippedCorruptedItems = 2956,
		[Description("Vaal Skill Damage +%")] VaalSkillDamagePosPct = 2957,
		[Description("Skill Is Vaal Skill")] SkillIsVaalSkill = 2958,
		[Description("Damage +% While Dead")] DamagePosPctWhileDead = 2959,

		[Description("Chaos Damage +% Per Equipped Corrupted Item")]
		ChaosDamagePosPctPerEquippedCorruptedItem = 2960,

		[Description("Life Leech Speed +% Per Equipped Corrupted Item")]
		LifeLeechSpeedPosPctPerEquippedCorruptedItem = 2961,

		[Description("Virtual Life Leech Speed +%")]
		VirtualLifeLeechSpeedPosPct = 2962,

		[Description("Mana Leech Speed +% Per Equipped Corrupted Item")]
		ManaLeechSpeedPosPctPerEquippedCorruptedItem = 2963,

		[Description("Virtual Mana Leech Speed +%")]
		VirtualManaLeechSpeedPosPct = 2964,
		[Description("Skill Is Attack")] SkillIsAttack = 2965,

		[Description("Hundred Times Non Spell Casts Per Second")]
		HundredTimesNonSpellCastsPerSecond = 2966,

		[Description("Sound On Rare Kill Ice Whisper")]
		SoundOnRareKillIceWhisper = 2967,

		[Description("Chance To Gain Vaal Soul On Kill %")]
		ChanceToGainVaalSoulOnKillPct = 2968,

		[Description("Piety Fire Form Hits Cause Stacking Damage Taken")]
		PietyFireFormHitsCauseStackingDamageTaken = 2969,

		[Description("Vaal Skill Effect Duration +%")]
		VaalSkillEffectDurationPosPct = 2970,

		[Description("Energy Shield Protects Mana")]
		EnergyShieldProtectsMana = 2971,

		[Description("Spend Energy Shield For Costs Before Mana")]
		SpendEnergyShieldForCostsBeforeMana = 2972,

		[Description("Vaal Skill Critical Strike Chance +%")]
		VaalSkillCriticalStrikeChancePosPct = 2973,

		[Description("Local Unique Item Limit")]
		LocalUniqueItemLimit = 2974,

		[Description("Vaal Skill Critical Strike Multiplier +")]
		VaalSkillCriticalStrikeMultiplierPos = 2975,

		[Description("Local Display Aura Allies Have Culling Strike")]
		LocalDisplayAuraAlliesHaveCullingStrike = 2976,

		[Description("Local Display Aura Allies Have Increased Item Rarity +%")]
		LocalDisplayAuraAlliesHaveIncreasedItemRarityPosPct = 2977,

		[Description("Chance To Gain Vaal Soul On Enemy Shatter %")]
		ChanceToGainVaalSoulOnEnemyShatterPct = 2978,

		[Description("Mana Cost +% On Totemified Aura Skills")]
		ManaCostPosPctOnTotemifiedAuraSkills = 2979,
		[Description("Skill Is Aura Skill")] SkillIsAuraSkill = 2980,

		[Description("Corrupted Gem Experience Gain +%")]
		CorruptedGemExperienceGainPosPct = 2981,

		[Description("Active Skill Attack Damage Final Permyriad")]
		ActiveSkillAttackDamageFinalPermyriad = 2982,
		[Description("Fortify Duration +%")] FortifyDurationPosPct = 2983,

		[Description("Support Slower Projectiles Damage +% Final")]
		SupportSlowerProjectilesDamagePosPctFinal = 2984,

		[Description("Chance To Evade Melee Attacks +%")]
		ChanceToEvadeMeleeAttacksPosPct = 2985,

		[Description("Support Elemental Proliferation Damage +% Final")]
		SupportElementalProliferationDamagePosPctFinal = 2986,

		[Description("Flicker Strike More Attack Speed +% Final")]
		FlickerStrikeMoreAttackSpeedPosPctFinal = 2987,

		[Description("Support Minion Damage +% Final")]
		SupportMinionDamagePosPctFinal = 2988,

		[Description("Damage +% Final From Support Minion Damage")]
		DamagePosPctFinalFromSupportMinionDamage = 2989,

		[Description("Life Leech Uses Chaos Damage When X Corrupted Items Equipped")]
		LifeLeechUsesChaosDamageWhenXCorruptedItemsEquipped = 2990,

		[Description("Half Physical Bypasses Es Half Chaos Damages Es When X Corrupted Items Equipped")]
		HalfPhysicalBypassesEsHalfChaosDamagesEsWhenXCorruptedItemsEquipped = 2991,

		[Description("Chaos Damage Damages Energy Shield %")]
		ChaosDamageDamagesEnergyShieldPct = 2992,

		[Description("Physical Damage Bypass Energy Shield %")]
		PhysicalDamageBypassEnergyShieldPct = 2993,

		[Description("Gain Soul Eater With Equipped Corrupted Items On Vaal Skill Use Ms")]
		GainSoulEaterWithEquippedCorruptedItemsOnVaalSkillUseMs = 2994,

		[Description("Base Spell Lightning Damage +%")]
		BaseSpellLightningDamagePosPct = 2995,

		[Description("Wrath Aura Spell Lightning Damage +% Final")]
		WrathAuraSpellLightningDamagePosPctFinal = 2996,

		[Description("Support Slower Projectiles Projectile Speed +% Final")]
		SupportSlowerProjectilesProjectileSpeedPosPctFinal = 2997,

		[Description("Support Reduced Duration Skill Effect Duration +% Final")]
		SupportReducedDurationSkillEffectDurationPosPctFinal = 2998,

		[Description("Maximum Mana % Gained On Kill")]
		MaximumManaPctGainedOnKill = 2999,

		[Description("Maximum Life % Lost On Kill")]
		MaximumLifePctLostOnKill = 3000,

		[Description("Maximum Energy Shield % Lost On Kill")]
		MaximumEnergyShieldPctLostOnKill = 3001,

		[Description("Passive Applies To Minions")]
		PassiveAppliesToMinions = 3002,

		[Description("Chance To Curse Self With Punishment On Kill %")]
		ChanceToCurseSelfWithPunishmentOnKillPct = 3003,

		[Description("Damage Taken +% While Es Full")]
		DamageTakenPosPctWhileEsFull = 3004,
		[Description("Base Deal No Damage")] BaseDealNoDamage = 3005,

		[Description("Voll Slam Damage +% Final At Centre")]
		VollSlamDamagePosPctFinalAtCentre = 3006,

		[Description("Local Unique Jewel Evasion Rating +% Per X Dex In Radius")]
		LocalUniqueJewelEvasionRatingPosPctPerXDexInRadius = 3007,

		[Description("Local Unique Jewel Claw Physical Damage +% Per X Dex In Radius")]
		LocalUniqueJewelClawPhysicalDamagePosPctPerXDexInRadius = 3008,

		[Description("Local Unique Jewel Damage Increases Applies To Fire Damage")]
		LocalUniqueJewelDamageIncreasesAppliesToFireDamage = 3009,
		[Description("Fire Sword Damage +%")] FireSwordDamagePosPct = 3010,
		[Description("Fire Wand Damage +%")] FireWandDamagePosPct = 3011,

		[Description("Two Handed Melee Fire Damage +%")]
		TwoHandedMeleeFireDamagePosPct = 3012,
		[Description("Spell Fire Damage +%")] SpellFireDamagePosPct = 3013,

		[Description("Melee Fire Damage +% While Holding Shield")]
		MeleeFireDamagePosPctWhileHoldingShield = 3014,
		[Description("Fire Staff Damage +%")] FireStaffDamagePosPct = 3015,
		[Description("Fire Mace Damage +%")] FireMaceDamagePosPct = 3016,

		[Description("Fire Damage While Dual Wielding +%")]
		FireDamageWhileDualWieldingPosPct = 3017,
		[Description("Fire Dagger Damage +%")] FireDaggerDamagePosPct = 3018,
		[Description("Fire Claw Damage +%")] FireClawDamagePosPct = 3019,
		[Description("Fire Bow Damage +%")] FireBowDamagePosPct = 3020,
		[Description("Fire Axe Damage +%")] FireAxeDamagePosPct = 3021,
		[Description("Fire Attack Damage +%")] FireAttackDamagePosPct = 3022,

		[Description("One Handed Melee Fire Damage +%")]
		OneHandedMeleeFireDamagePosPct = 3023,
		[Description("Melee Fire Damage +%")] MeleeFireDamagePosPct = 3024,

		[Description("Fire Damage Over Time +%")]
		FireDamageOverTimePosPct = 3025,

		[Description("Local Unique Jewel Physical Damage Increases Applies To Cold Damage")]
		LocalUniqueJewelPhysicalDamageIncreasesAppliesToColdDamage = 3026,
		[Description("Cold Sword Damage +%")] ColdSwordDamagePosPct = 3027,
		[Description("Cold Wand Damage +%")] ColdWandDamagePosPct = 3028,

		[Description("Two Handed Melee Cold Damage +%")]
		TwoHandedMeleeColdDamagePosPct = 3029,
		[Description("Spell Cold Damage +%")] SpellColdDamagePosPct = 3030,

		[Description("Melee Cold Damage +% While Holding Shield")]
		MeleeColdDamagePosPctWhileHoldingShield = 3031,
		[Description("Cold Staff Damage +%")] ColdStaffDamagePosPct = 3032,
		[Description("Cold Mace Damage +%")] ColdMaceDamagePosPct = 3033,

		[Description("Cold Damage While Dual Wielding +%")]
		ColdDamageWhileDualWieldingPosPct = 3034,
		[Description("Cold Dagger Damage +%")] ColdDaggerDamagePosPct = 3035,
		[Description("Cold Claw Damage +%")] ColdClawDamagePosPct = 3036,
		[Description("Cold Bow Damage +%")] ColdBowDamagePosPct = 3037,
		[Description("Cold Axe Damage +%")] ColdAxeDamagePosPct = 3038,
		[Description("Cold Attack Damage +%")] ColdAttackDamagePosPct = 3039,

		[Description("One Handed Melee Cold Damage +%")]
		OneHandedMeleeColdDamagePosPct = 3040,
		[Description("Melee Cold Damage +%")] MeleeColdDamagePosPct = 3041,

		[Description("Cold Damage Over Time +%")]
		ColdDamageOverTimePosPct = 3042,

		[Description("Additional Staff Block %")]
		AdditionalStaffBlockPct = 3043,

		[Description("Local Unique Jewel Cold Damage Increases Applies To Physical Damage")]
		LocalUniqueJewelColdDamageIncreasesAppliesToPhysicalDamage = 3044,

		[Description("Local Unique Jewel One Additional Maximum Lightning Damage Per X Dex")]
		LocalUniqueJewelOneAdditionalMaximumLightningDamagePerXDex = 3045,

		[Description("Local Unique Jewel Additional Life Per X Int In Radius")]
		LocalUniqueJewelAdditionalLifePerXIntInRadius = 3046,

		[Description("Local Unique Jewel Chaos Damage +% Per X Int In Radius")]
		LocalUniqueJewelChaosDamagePosPctPerXIntInRadius = 3047,

		[Description("Local Unique Jewel Chill Freeze Duration -% Per X Dex In Radius")]
		LocalUniqueJewelChillFreezeDurationNegPctPerXDexInRadius = 3048,

		[Description("Local Unique Jewel Dex And Int Apply To Str Melee Damage Bonus In Radius")]
		LocalUniqueJewelDexAndIntApplyToStrMeleeDamageBonusInRadius = 3049,

		[Description("Melee Damage Bonus Attributes From Jewels")]
		MeleeDamageBonusAttributesFromJewels = 3050,

		[Description("Kaom Number Of Spawners Triggered")]
		KaomNumberOfSpawnersTriggered = 3051,

		[Description("Melee Damage Vs Bleeding Enemies +%")]
		MeleeDamageVsBleedingEnemiesPosPct = 3052,

		[Description("Number Of Active Buffs")]
		NumberOfActiveBuffs = 3053,

		[Description("Fire Mortar Second Hit Damage +% Final")]
		FireMortarSecondHitDamagePosPctFinal = 3054,

		[Description("Support Trap And Mine Damage +% Final")]
		SupportTrapAndMineDamagePosPctFinal = 3055,

		[Description("Active Skill Minion Added Damage +% Final")]
		ActiveSkillMinionAddedDamagePosPctFinal = 3056,

		[Description("Minion Added Damage +% Final From Skill")]
		MinionAddedDamagePosPctFinalFromSkill = 3057,

		[Description("Newpunishment Melee Physical Damage +% Final")]
		NewpunishmentMeleePhysicalDamagePosPctFinal = 3058,

		[Description("Physical Damage +% While Life Leeching")]
		PhysicalDamagePosPctWhileLifeLeeching = 3059,
		[Description("Spell Staff Damage +%")] SpellStaffDamagePosPct = 3060,

		[Description("Spell Damage +% While Holding Shield")]
		SpellDamagePosPctWhileHoldingShield = 3061,

		[Description("Spell Damage +% While Dual Wielding")]
		SpellDamagePosPctWhileDualWielding = 3062,

		[Description("Cyclone Places Ground Fire Damage Per Minute")]
		CyclonePlacesGroundFireDamagePerMinute = 3063,

		[Description("Newpunishment Melee Damage +% Final")]
		NewpunishmentMeleeDamagePosPctFinal = 3064,

		[Description("Newpunishment Attack Speed +%")]
		NewpunishmentAttackSpeedPosPct = 3065,

		[Description("Base Strength And Dexterity")]
		BaseStrengthAndDexterity = 3066,

		[Description("Base Strength And Intelligence")]
		BaseStrengthAndIntelligence = 3067,

		[Description("Base Dexterity And Intelligence")]
		BaseDexterityAndIntelligence = 3068,

		[Description("Base Physical Damage % Of Maximum Life To Deal Per Minute")]
		BasePhysicalDamagePctOfMaximumLifeToDealPerMinute = 3069,
		[Description("Has Fortify")] HasFortify = 3070,

		[Description("Physical Damage Reduction Rating +% While Fortify Is Active")]
		PhysicalDamageReductionRatingPosPctWhileFortifyIsActive = 3071,

		[Description("Evasion Rating +% While Onslaught Is Active")]
		EvasionRatingPosPctWhileOnslaughtIsActive = 3072,
		[Description("Fortify Effect +%")] FortifyEffectPosPct = 3073,

		[Description("Melee Physical Damage +% While Fortify Is Active")]
		MeleePhysicalDamagePosPctWhileFortifyIsActive = 3074,

		[Description("Local Unique Jewel Unarmed Damage +% Per X Dex In Radius")]
		LocalUniqueJewelUnarmedDamagePosPctPerXDexInRadius = 3075,

		[Description("Increased Critical Strike Chance Buff For X Milliseconds On Placing A Totem")]
		IncreasedCriticalStrikeChanceBuffForXMillisecondsOnPlacingATotem = 3076,

		[Description("% Chance To Gain Power Charge On Trap Triggered By An Enemy")]
		Pctchancetogainpowerchargeontraptriggeredbyanenemy = 3077,

		[Description("% Chance To Gain Power Charge On Mine Detonated Targeting An Enemy")]
		Pctchancetogainpowerchargeonminedetonatedtargetinganenemy = 3078,

		[Description("Totem Critical Strike Chance +%")]
		TotemCriticalStrikeChancePosPct = 3079,

		[Description("Totem Critical Strike Multiplier +")]
		TotemCriticalStrikeMultiplierPos = 3080,

		[Description("Damage +% Per Active Curse On Self")]
		DamagePosPctPerActiveCurseOnSelf = 3081,
		[Description("Map Force Topology")] MapForceTopology = 3082,

		[Description("Maximum Life Leech Rate % Per Minute")]
		MaximumLifeLeechRatePctPerMinute = 3083,

		[Description("Maximum Mana Leech Rate % Per Minute")]
		MaximumManaLeechRatePctPerMinute = 3084,

		[Description("Chill Enemy When Hit Duration Ms")]
		ChillEnemyWhenHitDurationMs = 3085,

		[Description("Ice Crash Third Hit Damage +% Final")]
		IceCrashThirdHitDamagePosPctFinal = 3086,

		[Description("Newpunishment Applied Buff Duration Ms")]
		NewpunishmentAppliedBuffDurationMs = 3087,

		[Description("Recover X Life On Block")]
		RecoverXLifeOnBlock = 3088,

		[Description("Minion Recover X Life On Block")]
		MinionRecoverXLifeOnBlock = 3089,

		[Description("Base Physical Damage % Of Maximum Energy Shield To Deal Per Minute")]
		BasePhysicalDamagePctOfMaximumEnergyShieldToDealPerMinute = 3090,

		[Description("Base Physical Damage % Of Maximum Energy Shield Taken Per Minute")]
		BasePhysicalDamagePctOfMaximumEnergyShieldTakenPerMinute = 3091,

		[Description("Minimum Added Fire Attack Damage Per Active Buff")]
		MinimumAddedFireAttackDamagePerActiveBuff = 3092,

		[Description("Maximum Added Fire Attack Damage Per Active Buff")]
		MaximumAddedFireAttackDamagePerActiveBuff = 3093,

		[Description("Minimum Added Fire Spell Damage Per Active Buff")]
		MinimumAddedFireSpellDamagePerActiveBuff = 3094,

		[Description("Maximum Added Fire Spell Damage Per Active Buff")]
		MaximumAddedFireSpellDamagePerActiveBuff = 3095,

		[Description("Revenant Revive Explode Damage %")]
		RevenantReviveExplodeDamagePct = 3096,

		[Description("New Arctic Armour Physical Damage Taken When Hit +% Final")]
		NewArcticArmourPhysicalDamageTakenWhenHitPosPctFinal = 3097,

		[Description("New Arctic Armour Fire Damage Taken When Hit +% Final")]
		NewArcticArmourFireDamageTakenWhenHitPosPctFinal = 3098,

		[Description("Firestorm Use Server Effects")]
		FirestormUseServerEffects = 3099,
		[Description("Monster No Map Drops")] MonsterNoMapDrops = 3100,

		[Description("Local Life Gain Per Target")]
		LocalLifeGainPerTarget = 3101,

		[Description("Base Main Hand Local Life Gain Per Target")]
		BaseMainHandLocalLifeGainPerTarget = 3102,

		[Description("Base Off Hand Local Life Gain Per Target")]
		BaseOffHandLocalLifeGainPerTarget = 3103,

		[Description("Local Mana Gain Per Target")]
		LocalManaGainPerTarget = 3104,

		[Description("Base Main Hand Local Mana Gain Per Target")]
		BaseMainHandLocalManaGainPerTarget = 3105,

		[Description("Base Off Hand Local Mana Gain Per Target")]
		BaseOffHandLocalManaGainPerTarget = 3106,

		[Description("Local Unique Chaos Damage Does Not Bypass Energy Shield During Flask Effect")]
		LocalUniqueChaosDamageDoesNotBypassEnergyShieldDuringFlaskEffect = 3107,

		[Description("Local Unique Remove Life And Regen Es From Removed Life")]
		LocalUniqueRemoveLifeAndRegenEsFromRemovedLife = 3108,

		[Description("Local Unique Regen Es From Removed Life Duration Ms")]
		LocalUniqueRegenEsFromRemovedLifeDurationMs = 3109,

		[Description("Elemental Strike Physical Damage % To Convert")]
		ElementalStrikePhysicalDamagePctToConvert = 3110,

		[Description("Main Hand Local Life Gain Per Target")]
		MainHandLocalLifeGainPerTarget = 3111,

		[Description("Off Hand Local Life Gain Per Target")]
		OffHandLocalLifeGainPerTarget = 3112,

		[Description("Local Life And Mana Gain Per Target")]
		LocalLifeAndManaGainPerTarget = 3113,

		[Description("Base Main Hand Local Life And Mana Gain Per Target")]
		BaseMainHandLocalLifeAndManaGainPerTarget = 3114,

		[Description("Base Off Hand Local Life And Mana Gain Per Target")]
		BaseOffHandLocalLifeAndManaGainPerTarget = 3115,

		[Description("Main Hand Local Mana Gain Per Target")]
		MainHandLocalManaGainPerTarget = 3116,

		[Description("Off Hand Local Mana Gain Per Target")]
		OffHandLocalManaGainPerTarget = 3117,

		[Description("Local Life Leech From Physical Damage Permyriad")]
		LocalLifeLeechFromPhysicalDamagePermyriad = 3118,

		[Description("Main Hand Local Life Leech From Physical Damage Permyriad")]
		MainHandLocalLifeLeechFromPhysicalDamagePermyriad = 3119,

		[Description("Off Hand Local Life Leech From Physical Damage Permyriad")]
		OffHandLocalLifeLeechFromPhysicalDamagePermyriad = 3120,

		[Description("Local Mana Leech From Physical Damage Permyriad")]
		LocalManaLeechFromPhysicalDamagePermyriad = 3121,

		[Description("Main Hand Local Mana Leech From Physical Damage Permyriad")]
		MainHandLocalManaLeechFromPhysicalDamagePermyriad = 3122,

		[Description("Off Hand Local Mana Leech From Physical Damage Permyriad")]
		OffHandLocalManaLeechFromPhysicalDamagePermyriad = 3123,

		[Description("Life Leech From Physical Attack Damage Permyriad")]
		LifeLeechFromPhysicalAttackDamagePermyriad = 3124,

		[Description("Mana Leech From Physical Attack Damage Permyriad")]
		ManaLeechFromPhysicalAttackDamagePermyriad = 3125,

		[Description("Local Flask Life Leech Permyriad While Healing")]
		LocalFlaskLifeLeechPermyriadWhileHealing = 3126,

		[Description("Local Flask Mana Leech Permyriad While Healing")]
		LocalFlaskManaLeechPermyriadWhileHealing = 3127,

		[Description("Base Life Leech From Spell Damage Permyriad")]
		BaseLifeLeechFromSpellDamagePermyriad = 3128,

		[Description("Base Mana Leech From Spell Damage Permyriad")]
		BaseManaLeechFromSpellDamagePermyriad = 3129,

		[Description("Life Leech From Spell Damage Permyriad")]
		LifeLeechFromSpellDamagePermyriad = 3130,

		[Description("Mana Leech From Spell Damage Permyriad")]
		ManaLeechFromSpellDamagePermyriad = 3131,

		[Description("Mana Leech From Physical Damage Permyriad Per Power Charge")]
		ManaLeechFromPhysicalDamagePermyriadPerPowerCharge = 3132,

		[Description("Global Mana Leech From Physical Attack Damage Permyriad Per Blue Socket On Item")]
		GlobalManaLeechFromPhysicalAttackDamagePermyriadPerBlueSocketOnItem = 3133,

		[Description("Base Mana Leech Permyriad Vs Shocked Enemies")]
		BaseManaLeechPermyriadVsShockedEnemies = 3134,

		[Description("Base Life Leech Permyriad Vs Frozen Enemies")]
		BaseLifeLeechPermyriadVsFrozenEnemies = 3135,

		[Description("Mana Leech Permyriad Vs Shocked Enemies")]
		ManaLeechPermyriadVsShockedEnemies = 3136,

		[Description("Life Leech Permyriad Vs Frozen Enemies")]
		LifeLeechPermyriadVsFrozenEnemies = 3137,

		[Description("Base Life Leech From Physical Damage Permyriad")]
		BaseLifeLeechFromPhysicalDamagePermyriad = 3138,

		[Description("Base Life Leech From Fire Damage Permyriad")]
		BaseLifeLeechFromFireDamagePermyriad = 3139,

		[Description("Base Life Leech From Cold Damage Permyriad")]
		BaseLifeLeechFromColdDamagePermyriad = 3140,

		[Description("Base Life Leech From Lightning Damage Permyriad")]
		BaseLifeLeechFromLightningDamagePermyriad = 3141,

		[Description("Base Mana Leech From Lightning Damage Permyriad")]
		BaseManaLeechFromLightningDamagePermyriad = 3142,

		[Description("Local Unique Flask Life Leech From Chaos Damage Permyriad While Healing")]
		LocalUniqueFlaskLifeLeechFromChaosDamagePermyriadWhileHealing = 3143,

		[Description("Base Life Leech From Elemental Damage Permyriad")]
		BaseLifeLeechFromElementalDamagePermyriad = 3144,

		[Description("Life Leech Permyriad On Crit")]
		LifeLeechPermyriadOnCrit = 3145,

		[Description("Base Life Leech Permyriad Vs Shocked Enemies")]
		BaseLifeLeechPermyriadVsShockedEnemies = 3146,

		[Description("Life Leech Permyriad Vs Shocked Enemies")]
		LifeLeechPermyriadVsShockedEnemies = 3147,

		[Description("Base Life Leech From Attack Damage Permyriad Vs Chilled Enemies")]
		BaseLifeLeechFromAttackDamagePermyriadVsChilledEnemies = 3148,

		[Description("Life Leech From Physical Damage With Claw Permyriad")]
		LifeLeechFromPhysicalDamageWithClawPermyriad = 3149,

		[Description("Minion Life Leech From Any Damage Permyriad")]
		MinionLifeLeechFromAnyDamagePermyriad = 3150,

		[Description("Mana Leech From Physical Damage With Claw Permyriad")]
		ManaLeechFromPhysicalDamageWithClawPermyriad = 3151,

		[Description("Life Leech From Attack Damage Permyriad Vs Chilled Enemies")]
		LifeLeechFromAttackDamagePermyriadVsChilledEnemies = 3152,

		[Description("Map Summon Exploding Buff Storms")]
		MapSummonExplodingBuffStorms = 3153,

		[Description("Map Items Have Random Quality")]
		MapItemsHaveRandomQuality = 3154,

		[Description("Map Summon Runic Circles")]
		MapSummonRunicCircles = 3155,
		[Description("Map Spawn Warbands")] MapSpawnWarbands = 3156,

		[Description("Chance To Gain Endurance Charge On Bow Crit %")]
		ChanceToGainEnduranceChargeOnBowCritPct = 3157,

		[Description("Global Critical Strike Chance +% While Holding Bow")]
		GlobalCriticalStrikeChancePosPctWhileHoldingBow = 3158,

		[Description("Global Critical Strike Multiplier + While Holding Bow")]
		GlobalCriticalStrikeMultiplierPosWhileHoldingBow = 3159,

		[Description("Map Spawn Extra Warbands")]
		MapSpawnExtraWarbands = 3160,

		[Description("Soul Is Consumed On Death")]
		SoulIsConsumedOnDeath = 3161,

		[Description("Some Passives Apply To Minions")]
		SomePassivesApplyToMinions = 3162,

		[Description("Damage +% With Movement Skills")]
		DamagePosPctWithMovementSkills = 3163,

		[Description("Attack Speed +% With Movement Skills")]
		AttackSpeedPosPctWithMovementSkills = 3164,

		[Description("Life Gained On Killing Ignited Enemies")]
		LifeGainedOnKillingIgnitedEnemies = 3165,

		[Description("Damage Taken +% From Skeletons")]
		DamageTakenPosPctFromSkeletons = 3166,

		[Description("Damage Taken +% From Ghosts")]
		DamageTakenPosPctFromGhosts = 3167,

		[Description("Skill Is Movement Skill")]
		SkillIsMovementSkill = 3168,

		[Description("Cannot Be Shocked While Frozen")]
		CannotBeShockedWhileFrozen = 3169,

		[Description("Local Display Grants Skill Lightning Warp Level")]
		LocalDisplayGrantsSkillLightningWarpLevel = 3170,

		[Description("Life Leech From Attack Damage Permyriad Vs Bleeding Enemies")]
		LifeLeechFromAttackDamagePermyriadVsBleedingEnemies = 3171,

		[Description("Number Of Additional Curses Allowed On Self")]
		NumberOfAdditionalCursesAllowedOnSelf = 3172,

		[Description("Map Spawn Warband Fire")]
		MapSpawnWarbandFire = 3173,

		[Description("Map Spawn Warband Cold")]
		MapSpawnWarbandCold = 3174,

		[Description("Map Spawn Warband Thunder")]
		MapSpawnWarbandThunder = 3175,

		[Description("Map Spawn Warband Chaos")]
		MapSpawnWarbandChaos = 3176,
		[Description("Map Max Warband Rank")] MapMaxWarbandRank = 3177,

		[Description("Monster Report Warband Destroyed On Death")]
		MonsterReportWarbandDestroyedOnDeath = 3178,

		[Description("Trap Throw Arm Time Override")]
		TrapThrowArmTimeOverride = 3179,

		[Description("Item Rarity +% While Using Flask")]
		ItemRarityPosPctWhileUsingFlask = 3180,

		[Description("Dropped Items Are Corrupted")]
		DroppedItemsAreCorrupted = 3181,

		[Description("Monster Dropped Non Unique Equipment Drops As Sell Price")]
		MonsterDroppedNonUniqueEquipmentDropsAsSellPrice = 3182,

		[Description("Monster Dropped Items Have Random Quality")]
		MonsterDroppedItemsHaveRandomQuality = 3183,

		[Description("Player Found Items Are Corrupted")]
		PlayerFoundItemsAreCorrupted = 3184,

		[Description("Player Non Unique Equipment Found As Sell Price")]
		PlayerNonUniqueEquipmentFoundAsSellPrice = 3185,

		[Description("Player Found Items Have Random Quality")]
		PlayerFoundItemsHaveRandomQuality = 3186,
		[Description("Map Storm Delay +%")] MapStormDelayPosPct = 3187,
		[Description("Map Storm Duration +%")] MapStormDurationPosPct = 3188,

		[Description("Map Storm Area Of Effect +%")]
		MapStormAreaOfEffectPosPct = 3189,

		[Description("Map Storm Buff Duration +%")]
		MapStormBuffDurationPosPct = 3190,

		[Description("Map Storm Buff Duration +% On Low Life Target")]
		MapStormBuffDurationPosPctOnLowLifeTarget = 3191,

		[Description("Map Tempest Random Monster Drops Unique")]
		MapTempestRandomMonsterDropsUnique = 3192,

		[Description("Map Tempest Random Monster Drops Map")]
		MapTempestRandomMonsterDropsMap = 3193,

		[Description("Map Tempest Fish School Size +%")]
		MapTempestFishSchoolSizePosPct = 3194,

		[Description("Monster Stormcall Individually Trigger")]
		MonsterStormcallIndividuallyTrigger = 3195,

		[Description("Map Tempest Random Monster Drops Vaal Fragment")]
		MapTempestRandomMonsterDropsVaalFragment = 3196,

		[Description("Map Bosses Have Phylacteral Link")]
		MapBossesHavePhylacteralLink = 3197,

		[Description("Monster Can Have Bloodline")]
		MonsterCanHaveBloodline = 3198,

		[Description("Local Socketed Warcry Gem Level +")]
		LocalSocketedWarcryGemLevelPos = 3199,

		[Description("Mana Gained On Hitting Taunted Enemy")]
		ManaGainedOnHittingTauntedEnemy = 3200,

		[Description("Life Gained On Taunting Enemy")]
		LifeGainedOnTauntingEnemy = 3201,

		[Description("Onslaught Buff Duration On Killing Taunted Enemy Ms")]
		OnslaughtBuffDurationOnKillingTauntedEnemyMs = 3202,

		[Description("Local Socketed Golem Gem Level +")]
		LocalSocketedGolemGemLevelPos = 3203,

		[Description("Local Display Socketed Gems Supported By X Increased Minion Life Level")]
		LocalDisplaySocketedGemsSupportedByXIncreasedMinionLifeLevel = 3204,

		[Description("Local Display Socketed Gems Supported By X Lesser Multiple Projectiles Level")]
		LocalDisplaySocketedGemsSupportedByXLesserMultipleProjectilesLevel = 3205,

		[Description("Local Display Socketed Gems Supported By X Increased Minion Damage Level")]
		LocalDisplaySocketedGemsSupportedByXIncreasedMinionDamageLevel = 3206,

		[Description("Local Display Socketed Gems Supported By X Increased Critical Damage Level")]
		LocalDisplaySocketedGemsSupportedByXIncreasedCriticalDamageLevel = 3207,

		[Description("Number Of Power Charges To Gain")]
		NumberOfPowerChargesToGain = 3208,

		[Description("Number Of Frenzy Charges To Gain")]
		NumberOfFrenzyChargesToGain = 3209,

		[Description("Number Of Endurance Charges To Gain")]
		NumberOfEnduranceChargesToGain = 3210,

		[Description("Animate Weapon Duration +%")]
		AnimateWeaponDurationPosPct = 3211,

		[Description("Totem Skill Area Of Effect +%")]
		TotemSkillAreaOfEffectPosPct = 3212,

		[Description("Life Leech From Skills Used By Totems Permyriad")]
		LifeLeechFromSkillsUsedByTotemsPermyriad = 3213,

		[Description("Damage Reflected To Enemies % Gained As Life")]
		DamageReflectedToEnemiesPctGainedAsLife = 3214,

		[Description("Animate Weapon Number Of Additional Copies")]
		AnimateWeaponNumberOfAdditionalCopies = 3215,

		[Description("Cannot Drop Below % Life")]
		CannotDropBelowPctLife = 3216,

		[Description("Local Display Socketed Gems Supported By X Increased Minion Speed Level")]
		LocalDisplaySocketedGemsSupportedByXIncreasedMinionSpeedLevel = 3217,

		[Description("Attack Is Not Melee Override")]
		AttackIsNotMeleeOverride = 3218,

		[Description("Map Storm Delay +% Final")]
		MapStormDelayPosPctFinal = 3219,

		[Description("Map Storm Duration +% Final")]
		MapStormDurationPosPctFinal = 3220,

		[Description("Map Always Has Weather")]
		MapAlwaysHasWeather = 3221,
		[Description("Melee Weapon Range +")] MeleeWeaponRangePos = 3222,
		[Description("Damage +% Vs Players")] DamagePosPctVsPlayers = 3223,

		[Description("Immune Vaal Lighting Warp")]
		ImmuneVaalLightingWarp = 3224,

		[Description("Base Secondary Skill Effect Duration")]
		BaseSecondarySkillEffectDuration = 3225,

		[Description("Secondary Skill Effect Duration")]
		SecondarySkillEffectDuration = 3226,
		[Description("Enemy Aggro Radius +%")] EnemyAggroRadiusPosPct = 3227,

		[Description("Skill Effect Duration +% Per Frenzy Charge")]
		SkillEffectDurationPosPctPerFrenzyCharge = 3228,

		[Description("Chilled Ground Effect On Self +%")]
		ChilledGroundEffectOnSelfPosPct = 3229,

		[Description("Burning Ground Effect On Self +%")]
		BurningGroundEffectOnSelfPosPct = 3230,

		[Description("Shocked Ground Effect On Self +%")]
		ShockedGroundEffectOnSelfPosPct = 3231,

		[Description("Desecrated Ground Effect On Self +%")]
		DesecratedGroundEffectOnSelfPosPct = 3232,

		[Description("Spell And Attack Minimum Added Lightning Damage")]
		SpellAndAttackMinimumAddedLightningDamage = 3233,

		[Description("Spell And Attack Maximum Added Lightning Damage")]
		SpellAndAttackMaximumAddedLightningDamage = 3234,

		[Description("Shocked Ground When Hit %")]
		ShockedGroundWhenHitPct = 3235,

		[Description("Map Tempest Base Ground Fire Damage To Deal Per Minute")]
		MapTempestBaseGroundFireDamageToDealPerMinute = 3236,

		[Description("Map Tempest Base Ground Desecration Damage To Deal Per Minute")]
		MapTempestBaseGroundDesecrationDamageToDealPerMinute = 3237,

		[Description("Map Tempest Ground Ice")]
		MapTempestGroundIce = 3238,

		[Description("Map Tempest Ground Tar Movement Speed +%")]
		MapTempestGroundTarMovementSpeedPosPct = 3239,

		[Description("Map Tempest Ground Lightning")]
		MapTempestGroundLightning = 3240,

		[Description("Map Tempest Ground Effect Patches Per 100 Tiles")]
		MapTempestGroundEffectPatchesPer100Tiles = 3241,

		[Description("Map Tempest Ground Effect Radius")]
		MapTempestGroundEffectRadius = 3242,

		[Description("Projectile Minimum Range")]
		ProjectileMinimumRange = 3243,

		[Description("Projectile Speed Variation +%")]
		ProjectileSpeedVariationPosPct = 3244,

		[Description("Secondary Buff Effect Duration")]
		SecondaryBuffEffectDuration = 3245,

		[Description("Level 1 To 40 Life +% Final")]
		Level1To40LifePosPctFinal = 3246,

		[Description("Level 41 To 57 Life +% Final")]
		Level41To57LifePosPctFinal = 3247,

		[Description("Level 58 To 70 Life +% Final")]
		Level58To70LifePosPctFinal = 3248,

		[Description("Local Unique Jewel Energy Shield Increases Applies To Armour Doubled")]
		LocalUniqueJewelEnergyShieldIncreasesAppliesToArmourDoubled = 3249,

		[Description("Local Unique Jewel Life Increases Applies To Energy Shield")]
		LocalUniqueJewelLifeIncreasesAppliesToEnergyShield = 3250,

		[Description("Local Unique Jewel Life Increases Applies To Mana Doubled")]
		LocalUniqueJewelLifeIncreasesAppliesToManaDoubled = 3251,

		[Description("Cyclone First Hit Damage +% Final")]
		CycloneFirstHitDamagePosPctFinal = 3252,
		[Description("Cannot Use Warcries")] CannotUseWarcries = 3253,

		[Description("Map Debug Disable Nonboss Monsters")]
		MapDebugDisableNonbossMonsters = 3254,
		[Description("Totem Mana +%")] TotemManaPosPct = 3255,

		[Description("Totem Energy Shield +%")]
		TotemEnergyShieldPosPct = 3256,

		[Description("Minion Maximum Mana +%")]
		MinionMaximumManaPosPct = 3257,

		[Description("Minion Maximum Energy Shield +%")]
		MinionMaximumEnergyShieldPosPct = 3258,

		[Description("Base Maximum Life Per Red Socket On Item")]
		BaseMaximumLifePerRedSocketOnItem = 3259,

		[Description("Base Maximum Energy Shield Per Blue Socket On Item")]
		BaseMaximumEnergyShieldPerBlueSocketOnItem = 3260,

		[Description("Base Maximum Mana Per Green Socket On Item")]
		BaseMaximumManaPerGreenSocketOnItem = 3261,

		[Description("Currently Has No Energy Shield")]
		CurrentlyHasNoEnergyShield = 3262,

		[Description("Damage +% When Currently Has No Energy Shield")]
		DamagePosPctWhenCurrentlyHasNoEnergyShield = 3263,

		[Description("Chance To Gain Unholy Might On Block %")]
		ChanceToGainUnholyMightOnBlockPct = 3264,

		[Description("Damage +% When On Burning Ground")]
		DamagePosPctWhenOnBurningGround = 3265,

		[Description("Life Regeneration Rate Per Minute % When On Chilled Ground")]
		LifeRegenerationRatePerMinutePctWhenOnChilledGround = 3266,

		[Description("Movement Velocity +% When On Shocked Ground")]
		MovementVelocityPosPctWhenOnShockedGround = 3267,

		[Description("Is On Ground Fire Burn")]
		IsOnGroundFireBurn = 3268,

		[Description("Is On Ground Ice Chill")]
		IsOnGroundIceChill = 3269,

		[Description("Is On Ground Lightning Shock")]
		IsOnGroundLightningShock = 3270,

		[Description("Damage Taken Goes To Mana % Per Power Charge")]
		DamageTakenGoesToManaPctPerPowerCharge = 3271,

		[Description("Power Charge Art Variation")]
		PowerChargeArtVariation = 3272,

		[Description("Map Tempest Display Prefix")]
		MapTempestDisplayPrefix = 3273,

		[Description("Map Tempest Display Suffix")]
		MapTempestDisplaySuffix = 3274,

		[Description("Temporal Chains Action Speed +% Final")]
		TemporalChainsActionSpeedPosPctFinal = 3275,

		[Description("Virtual Action Speed +%")]
		VirtualActionSpeedPosPct = 3276,

		[Description("Light Radius +% While Phased")]
		LightRadiusPosPctWhilePhased = 3277,

		[Description("Map Monsters Area Of Effect +%")]
		MapMonstersAreaOfEffectPosPct = 3278,

		[Description("Map Monsters Avoid Freeze And Chill %")]
		MapMonstersAvoidFreezeAndChillPct = 3279,

		[Description("Map Monsters Avoid Ignite %")]
		MapMonstersAvoidIgnitePct = 3280,

		[Description("Map Monsters Avoid Shock %")]
		MapMonstersAvoidShockPct = 3281,

		[Description("Map Monsters Avoid Elemental Ailments %")]
		MapMonstersAvoidElementalAilmentsPct = 3282,

		[Description("Map Monsters Critical Strike Chance +%")]
		MapMonstersCriticalStrikeChancePosPct = 3283,

		[Description("Map Monsters Critical Strike Multiplier +")]
		MapMonstersCriticalStrikeMultiplierPos = 3284,

		[Description("Map Monsters Life Leech Resistance %")]
		MapMonstersLifeLeechResistancePct = 3285,

		[Description("Map Monsters Mana Leech Resistance %")]
		MapMonstersManaLeechResistancePct = 3286,

		[Description("Map Boss Maximum Life +%")]
		MapBossMaximumLifePosPct = 3287,

		[Description("Map Boss Area Of Effect +%")]
		MapBossAreaOfEffectPosPct = 3288,

		[Description("Map Hidden Experience Gain +%")]
		MapHiddenExperienceGainPosPct = 3289,

		[Description("Map Hidden Rare Monsters Have Nemesis Mod")]
		MapHiddenRareMonstersHaveNemesisMod = 3290,

		[Description("Map Hidden Spawn Extra Exiles")]
		MapHiddenSpawnExtraExiles = 3291,

		[Description("Map Hidden Spawn Extra Torment Spirits")]
		MapHiddenSpawnExtraTormentSpirits = 3292,

		[Description("Map Hidden Magic Pack Mod Rules")]
		MapHiddenMagicPackModRules = 3293,

		[Description("Map Hidden Monsters Additional Fire Resistance")]
		MapHiddenMonstersAdditionalFireResistance = 3294,

		[Description("Map Hidden Monsters Additional Cold Resistance")]
		MapHiddenMonstersAdditionalColdResistance = 3295,

		[Description("Map Hidden Monsters Additional Lightning Resistance")]
		MapHiddenMonstersAdditionalLightningResistance = 3296,

		[Description("Map Hidden Monsters Poison On Hit")]
		MapHiddenMonstersPoisonOnHit = 3297,

		[Description("Map Hidden Monsters % Physical Damage To Add As Fire")]
		MapHiddenMonstersPctPhysicalDamageToAddAsFire = 3298,

		[Description("Map Hidden Monsters % Physical Damage To Add As Cold")]
		MapHiddenMonstersPctPhysicalDamageToAddAsCold = 3299,

		[Description("Map Hidden Monsters % Physical Damage To Add As Lightning")]
		MapHiddenMonstersPctPhysicalDamageToAddAsLightning = 3300,

		[Description("Map Hidden Monsters % Physical Damage To Add As Chaos")]
		MapHiddenMonstersPctPhysicalDamageToAddAsChaos = 3301,

		[Description("Map Hidden Packs Are Totems")]
		MapHiddenPacksAreTotems = 3302,

		[Description("Skill Effect Duration Per 100 Int +%")]
		SkillEffectDurationPer100IntPosPct = 3303,

		[Description("Map Equipment Drops Identified")]
		MapEquipmentDropsIdentified = 3304,

		[Description("Player Found Equipment Drops Identified")]
		PlayerFoundEquipmentDropsIdentified = 3305,

		[Description("Monster Equipment Drops Identified")]
		MonsterEquipmentDropsIdentified = 3306,

		[Description("Flask Charges Gained +% During Flask Effect")]
		FlaskChargesGainedPosPctDuringFlaskEffect = 3307,

		[Description("Mana Regeneration Rate +% During Flask Effect")]
		ManaRegenerationRatePosPctDuringFlaskEffect = 3308,

		[Description("Movement Speed +% During Flask Effect")]
		MovementSpeedPosPctDuringFlaskEffect = 3309,

		[Description("Map Player Has Level X Punishment")]
		MapPlayerHasLevelXPunishment = 3310,

		[Description("Item Found Quantity +% Per White Socket On Item")]
		ItemFoundQuantityPosPctPerWhiteSocketOnItem = 3311,

		[Description("Monster Number Of Additional Players")]
		MonsterNumberOfAdditionalPlayers = 3312,

		[Description("Local Unique Jewel Physical Attack Damage +1% Per X Strength In Radius")]
		LocalUniqueJewelPhysicalAttackDamagePos1PctPerXStrengthInRadius = 3313,

		[Description("Local Unique Jewel Fortify Duration +1% Per X Int In Radius")]
		LocalUniqueJewelFortifyDurationPos1PctPerXIntInRadius = 3314,

		[Description("Local Unique Jewel Fire Damage +1% Per X Int In Radius")]
		LocalUniqueJewelFireDamagePos1PctPerXIntInRadius = 3315,

		[Description("Local Unique Jewel Cold Damage +1% Per X Int In Radius")]
		LocalUniqueJewelColdDamagePos1PctPerXIntInRadius = 3316,

		[Description("Local Unique Jewel Physical Damage +1% Per Int In Radius")]
		LocalUniqueJewelPhysicalDamagePos1PctPerIntInRadius = 3317,

		[Description("Local Unique Jewel Physical Attack Damage +1% Per X Dex In Radius")]
		LocalUniqueJewelPhysicalAttackDamagePos1PctPerXDexInRadius = 3318,

		[Description("Local Unique Jewel Projectile Damage +1% Per X Dex In Radius")]
		LocalUniqueJewelProjectileDamagePos1PctPerXDexInRadius = 3319,

		[Description("Local Unique Jewel Fireball Explosion Radius 20% Less At Close Range 50% More At Long Range With X Int In Radius")]
		LocalUniqueJewelFireballExplosionRadius20PctLessAtCloseRange50PctMoreAtLongRangeWithXIntInRadius = 3320,

		[Description("Local Unique Jewel Glacial Cascade Additional Sequence With X Int In Radius")]
		LocalUniqueJewelGlacialCascadeAdditionalSequenceWithXIntInRadius = 3321,

		[Description("Local Unique Jewel Animate Weapon Animates Bows And Wands With X Dex In Radius")]
		LocalUniqueJewelAnimateWeaponAnimatesBowsAndWandsWithXDexInRadius = 3322,

		[Description("Local Unique Jewel Split Arrow Fires Additional Arrow With X Dex In Radius")]
		LocalUniqueJewelSplitArrowFiresAdditionalArrowWithXDexInRadius = 3323,

		[Description("Vigilant Strike Applies To Nearby Allies For X Seconds")]
		VigilantStrikeAppliesToNearbyAlliesForXSeconds = 3324,

		[Description("Split Arrow Number Of Additional Arrows")]
		SplitArrowNumberOfAdditionalArrows = 3325,

		[Description("Animate Weapon Can Animate Bows")]
		AnimateWeaponCanAnimateBows = 3326,

		[Description("Animate Weapon Can Animate Wands")]
		AnimateWeaponCanAnimateWands = 3327,

		[Description("Fireball Explosion Radius 20% Less At Close Range 50% More At Long Range")]
		FireballExplosionRadius20PctLessAtCloseRange50PctMoreAtLongRange = 3328,

		[Description("Total Physical Damage Taken Per Minute")]
		TotalPhysicalDamageTakenPerMinute = 3329,

		[Description("Total Fire Damage Taken Per Minute")]
		TotalFireDamageTakenPerMinute = 3330,

		[Description("Total Cold Damage Taken Per Minute")]
		TotalColdDamageTakenPerMinute = 3331,

		[Description("Total Lightning Damage Taken Per Minute")]
		TotalLightningDamageTakenPerMinute = 3332,

		[Description("Total Chaos Damage Taken Per Minute")]
		TotalChaosDamageTakenPerMinute = 3333,

		[Description("Total Nonlethal Fire Damage Taken Per Minute")]
		TotalNonlethalFireDamageTakenPerMinute = 3334,

		[Description("Total Damage Taken Per Minute To Energy Shield")]
		TotalDamageTakenPerMinuteToEnergyShield = 3335,

		[Description("Total Damage Taken Per Minute To Life")]
		TotalDamageTakenPerMinuteToLife = 3336,

		[Description("Total Nonlethal Damage Taken Per Minute To Energy Shield")]
		TotalNonlethalDamageTakenPerMinuteToEnergyShield = 3337,

		[Description("Total Nonlethal Damage Taken Per Minute To Life")]
		TotalNonlethalDamageTakenPerMinuteToLife = 3338,

		[Description("Total Healing From Damage Taken Per Minute")]
		TotalHealingFromDamageTakenPerMinute = 3339,

		[Description("Chance To Gain Unholy Might On Kill For 3 Seconds %")]
		ChanceToGainUnholyMightOnKillFor3SecondsPct = 3340,

		[Description("Chance To Grant Nearby Enemies Onslaught On Kill %")]
		ChanceToGrantNearbyEnemiesOnslaughtOnKillPct = 3341,

		[Description("Chance To Grant Nearby Enemies Unholy Might On Kill %")]
		ChanceToGrantNearbyEnemiesUnholyMightOnKillPct = 3342,

		[Description("Recover % Maximum Life On Kill")]
		RecoverPctMaximumLifeOnKill = 3343,

		[Description("Chance To Cast On Kill % Target Self")]
		ChanceToCastOnKillPctTargetSelf = 3344,

		[Description("Socketed Trap Skills Create Smoke Cloud")]
		SocketedTrapSkillsCreateSmokeCloud = 3345,

		[Description("Fire Damage +% To Blinded Enemies")]
		FireDamagePosPctToBlindedEnemies = 3346,

		[Description("Spell Damage Taken +% From Blinded Enemies")]
		SpellDamageTakenPosPctFromBlindedEnemies = 3347,

		[Description("Curse Enemies With Level X Assassins Mark When Curse Cast")]
		CurseEnemiesWithLevelXAssassinsMarkWhenCurseCast = 3348,
		[Description("Disable Weapons")] DisableWeapons = 3349,

		[Description("Shock Dispelled On Full Energy Shield")]
		ShockDispelledOnFullEnergyShield = 3350,

		[Description("Local Display Nearby Enemies Take X Lightning Damage Per Minute")]
		LocalDisplayNearbyEnemiesTakeXLightningDamagePerMinute = 3351,

		[Description("Item Destroyed On Death")]
		ItemDestroyedOnDeath = 3352,

		[Description("Summoned Monsters Set Parent")]
		SummonedMonstersSetParent = 3353,

		[Description("Maximum Number Of Spinning Blades")]
		MaximumNumberOfSpinningBlades = 3354,

		[Description("Ball Lightning Damage +%")]
		BallLightningDamagePosPct = 3355,

		[Description("Cast When Critically Hit %")]
		CastWhenCriticallyHitPct = 3356,

		[Description("Attack Trigger On Hit %")]
		AttackTriggerOnHitPct = 3357,
		[Description("Cast On Hit %")] CastOnHitPct = 3358,
		[Description("Map Spawn Talismans")] MapSpawnTalismans = 3359,

		[Description("Map Spawn Extra Talismans")]
		MapSpawnExtraTalismans = 3360,

		[Description("Map Hidden Num Extra Invasion Bosses")]
		MapHiddenNumExtraInvasionBosses = 3361,
		[Description("Monster No Talismans")] MonsterNoTalismans = 3362,

		[Description("Enchantment Boots Life And Mana Regen Per Minute % For 4 Seconds When Hit")]
		EnchantmentBootsLifeAndManaRegenPerMinutePctFor4SecondsWhenHit = 3363,

		[Description("Fire Damage Taken % As Lightning")]
		FireDamageTakenPctAsLightning = 3364,

		[Description("Fire Damage Taken % As Cold")]
		FireDamageTakenPctAsCold = 3365,

		[Description("Lightning Damage Taken % As Cold")]
		LightningDamageTakenPctAsCold = 3366,

		[Description("Lightning Damage Taken % As Fire")]
		LightningDamageTakenPctAsFire = 3367,

		[Description("Cold Damage Taken % As Lightning")]
		ColdDamageTakenPctAsLightning = 3368,

		[Description("Cold Damage Taken % As Fire")]
		ColdDamageTakenPctAsFire = 3369,
		[Description("All Attributes +%")] AllAttributesPosPct = 3370,

		[Description("Base Cooldown Speed +%")]
		BaseCooldownSpeedPosPct = 3371,

		[Description("Virtual Cooldown Speed +%")]
		VirtualCooldownSpeedPosPct = 3372,

		[Description("Base Righteous Lightning % Of Max Mana To Deal To Nearby Per Minute")]
		BaseRighteousLightningPctOfMaxManaToDealToNearbyPerMinute = 3373,

		[Description("Righteous Lightning Critical Strike Chance +%")]
		RighteousLightningCriticalStrikeChancePosPct = 3374,

		[Description("Mana Degeneration Per Minute %")]
		ManaDegenerationPerMinutePct = 3375,
		[Description("Active Skill Index")] ActiveSkillIndex = 3376,

		[Description("Stun Threshold Based On % Mana Instead Of Life")]
		StunThresholdBasedOnPctManaInsteadOfLife = 3377,

		[Description("Local Flask Gain X Seconds Of Onslaught Per Frenzy Charge")]
		LocalFlaskGainXSecondsOfOnslaughtPerFrenzyCharge = 3378,

		[Description("Life Leech Applies To Enemies %")]
		LifeLeechAppliesToEnemiesPct = 3379,

		[Description("Enchantment Boots Minimum Added Fire Damage On Kill 4s")]
		EnchantmentBootsMinimumAddedFireDamageOnKill4s = 3380,

		[Description("Enchantment Boots Maximum Added Fire Damage On Kill 4s")]
		EnchantmentBootsMaximumAddedFireDamageOnKill4s = 3381,

		[Description("Enchantment Boots Movement Speed +% When Not Hit For 4 Seconds")]
		EnchantmentBootsMovementSpeedPosPctWhenNotHitFor4Seconds = 3382,

		[Description("Enchantment Boots Dodge Chance When Critically Hit %")]
		EnchantmentBootsDodgeChanceWhenCriticallyHitPct = 3383,

		[Description("Enchantment Boots Status Ailment Chance +% When Havent Crit For 4 Seconds")]
		EnchantmentBootsStatusAilmentChancePosPctWhenHaventCritFor4Seconds = 3384,
		[Description("Base Chance To Stun %")] BaseChanceToStunPct = 3385,

		[Description("Display Cast Word Of Flames On Kill %")]
		DisplayCastWordOfFlamesOnKillPct = 3386,

		[Description("Display Cast Word Of Blades On Kill %")]
		DisplayCastWordOfBladesOnKillPct = 3387,

		[Description("Display Cast Word Of Reflection On Kill %")]
		DisplayCastWordOfReflectionOnKillPct = 3388,

		[Description("Display Cast Word Of Force On Hit %")]
		DisplayCastWordOfForceOnHitPct = 3389,

		[Description("Display Cast Word Of Light When Hit %")]
		DisplayCastWordOfLightWhenHitPct = 3390,

		[Description("Display Cast Word Of Thunder On Hit %")]
		DisplayCastWordOfThunderOnHitPct = 3391,

		[Description("Display Cast Word Of The Grave On Kill %")]
		DisplayCastWordOfTheGraveOnKillPct = 3392,

		[Description("Display Cast Word Of War On Kill %")]
		DisplayCastWordOfWarOnKillPct = 3393,

		[Description("Map Spawn Stone Circles")]
		MapSpawnStoneCircles = 3394,

		[Description("Map Force Stone Circle")]
		MapForceStoneCircle = 3395,
		[Description("Base Poison Damage +%")] BasePoisonDamagePosPct = 3396,

		[Description("Base Poison Duration +%")]
		BasePoisonDurationPosPct = 3397,
		[Description("Poison Duration +%")] PoisonDurationPosPct = 3398,

		[Description("Poison Skill Effect Duration")]
		PoisonSkillEffectDuration = 3399,

		[Description("Base Chance To Poison On Hit %")]
		BaseChanceToPoisonOnHitPct = 3400,

		[Description("Quake Slam Fully Charged Explosion Damage +% Final")]
		QuakeSlamFullyChargedExplosionDamagePosPctFinal = 3401,

		[Description("Local Unique Jewel Glacial Hammer Item Rarity On Shattering Enemy +% With 50 Strength In Radius")]
		LocalUniqueJewelGlacialHammerItemRarityOnShatteringEnemyPosPctWith50StrengthInRadius = 3402,

		[Description("Local Unique Jewel Spectral Throw Damage For Each Enemy Hit With Spectral Weapon +% With 50 Dexterity In Radius")]
		LocalUniqueJewelSpectralThrowDamageForEachEnemyHitWithSpectralWeaponPosPctWith50DexterityInRadius = 3403,

		[Description("Local Unique Jewel Double Strike Chance To Trigger On Kill Effects An Additional Time % With 50 Dexterity In Radius")]
		LocalUniqueJewelDoubleStrikeChanceToTriggerOnKillEffectsAnAdditionalTimePctWith50DexterityInRadius = 3404,

		[Description("Local Unique Jewel Viper Strike Attack Damage Per Poison On Enemy +% With 50 Dexterity In Radius")]
		LocalUniqueJewelViperStrikeAttackDamagePerPoisonOnEnemyPosPctWith50DexterityInRadius = 3405,

		[Description("Local Unique Jewel Heavy Strike Chance To Deal Double Damage % With 50 Strength In Radius")]
		LocalUniqueJewelHeavyStrikeChanceToDealDoubleDamagePctWith50StrengthInRadius = 3406,

		[Description("Enchantment Boots Mana Costs When Hit +%")]
		EnchantmentBootsManaCostsWhenHitPosPct = 3407,

		[Description("Enchantment Boots Stun Avoid % On Kill")]
		EnchantmentBootsStunAvoidPctOnKill = 3408,

		[Description("Enchantment Boots Spell Dodge When Hit By Spells %")]
		EnchantmentBootsSpellDodgeWhenHitBySpellsPct = 3409,

		[Description("Enchantment Boots Attack And Cast Speed +% For 4 Seconds On Kill")]
		EnchantmentBootsAttackAndCastSpeedPosPctFor4SecondsOnKill = 3410,

		[Description("Enchantment Boots Added Cold Damage When Hit Minimum")]
		EnchantmentBootsAddedColdDamageWhenHitMinimum = 3411,

		[Description("Enchantment Boots Added Cold Damage When Hit Maximum")]
		EnchantmentBootsAddedColdDamageWhenHitMaximum = 3412,

		[Description("Enchantment Boots Minimum Added Lightning Damage When You Havent Killed For 4 Seconds")]
		EnchantmentBootsMinimumAddedLightningDamageWhenYouHaventKilledFor4Seconds = 3413,

		[Description("Enchantment Boots Maximum Added Lightning Damage When You Havent Killed For 4 Seconds")]
		EnchantmentBootsMaximumAddedLightningDamageWhenYouHaventKilledFor4Seconds = 3414,

		[Description("Enchantment Boots Life And Mana Leech On Kill Permyriad")]
		EnchantmentBootsLifeAndManaLeechOnKillPermyriad = 3415,

		[Description("Enchantment Critical Strike Chance +% If You Havent Crit For 4 Seconds")]
		EnchantmentCriticalStrikeChancePosPctIfYouHaventCritFor4Seconds = 3416,

		[Description("No Extra Bleed Damage While Moving")]
		NoExtraBleedDamageWhileMoving = 3417,

		[Description("Action Speed Cannot Be Reduced Below Base")]
		ActionSpeedCannotBeReducedBelowBase = 3418,

		[Description("Movement Speed Cannot Be Reduced Below Base")]
		MovementSpeedCannotBeReducedBelowBase = 3419,

		[Description("Damage +% While Fortified")]
		DamagePosPctWhileFortified = 3420,

		[Description("Life Regeneration Per Minute % While Fortified")]
		LifeRegenerationPerMinutePctWhileFortified = 3421,

		[Description("Damage +% Per Endurance Charge")]
		DamagePosPctPerEnduranceCharge = 3422,
		[Description("Warcry Duration +%")] WarcryDurationPosPct = 3423,

		[Description("Restore Life And Mana On Warcry %")]
		RestoreLifeAndManaOnWarcryPct = 3424,

		[Description("Attack Speed +% When Hit")]
		AttackSpeedPosPctWhenHit = 3425,

		[Description("Movement Velocity While Not Hit +%")]
		MovementVelocityWhileNotHitPosPct = 3426,
		[Description("Is Warcry")] IsWarcry = 3427,

		[Description("Map Player Corrupt Blood When Hit % Average Damage To Deal Per Minute Per Stack")]
		MapPlayerCorruptBloodWhenHitPctAverageDamageToDealPerMinutePerStack = 3428,

		[Description("Damage +% When Not On Low Life")]
		DamagePosPctWhenNotOnLowLife = 3429,

		[Description("Gain Life And Mana Leech On Kill Permyriad")]
		GainLifeAndManaLeechOnKillPermyriad = 3430,

		[Description("Number Of Active Minions")]
		NumberOfActiveMinions = 3431,

		[Description("Number Of Active Totems")]
		NumberOfActiveTotems = 3432,

		[Description("Damage +% While Totem Active")]
		DamagePosPctWhileTotemActive = 3433,

		[Description("Physical Damage % Added As Fire Damage On Kill")]
		PhysicalDamagePctAddedAsFireDamageOnKill = 3434,

		[Description("Totems Gain % Of Players Armour")]
		TotemsGainPctOfPlayersArmour = 3435,

		[Description("Attack And Cast Speed +% On Placing Totem")]
		AttackAndCastSpeedPosPctOnPlacingTotem = 3436,

		[Description("Damage +% To Rare And Unique Enemies")]
		DamagePosPctToRareAndUniqueEnemies = 3437,

		[Description("Life Leech On Overkill Damage %")]
		LifeLeechOnOverkillDamagePct = 3438,

		[Description("Attack Speed +% While Leeching")]
		AttackSpeedPosPctWhileLeeching = 3439,

		[Description("Life Leech Does Not Stop At Full Life")]
		LifeLeechDoesNotStopAtFullLife = 3440,

		[Description("Cannot Be Stunned While Leeching")]
		CannotBeStunnedWhileLeeching = 3441,

		[Description("Attacks Use Life In Place Of Mana")]
		AttacksUseLifeInPlaceOfMana = 3442,

		[Description("Chance To Taunt On Hit %")]
		ChanceToTauntOnHitPct = 3443,

		[Description("Bleeding Enemies Explode For % Life As Physical Damage")]
		BleedingEnemiesExplodeForPctLifeAsPhysicalDamage = 3444,

		[Description("Attack And Cast Speed When Hit +%")]
		AttackAndCastSpeedWhenHitPosPct = 3445,

		[Description("Physical Damage On Block +%")]
		PhysicalDamageOnBlockPosPct = 3446,

		[Description("Block Chance On Damage Taken %")]
		BlockChanceOnDamageTakenPct = 3447,

		[Description("Damage While No Damage Taken +%")]
		DamageWhileNoDamageTakenPosPct = 3448,

		[Description("Recover % Life On Gained Fortify")]
		RecoverPctLifeOnGainedFortify = 3449,

		[Description("Recover % Life On Lost Fortify")]
		RecoverPctLifeOnLostFortify = 3450,

		[Description("Attack Speed While Fortified +%")]
		AttackSpeedWhileFortifiedPosPct = 3451,

		[Description("Taunted Enemies Damage Taken +%")]
		TauntedEnemiesDamageTakenPosPct = 3452,

		[Description("Taunted Enemies Chance To Be Stunned +%")]
		TauntedEnemiesChanceToBeStunnedPosPct = 3453,

		[Description("Armour And Evasion On Low Life +%")]
		ArmourAndEvasionOnLowLifePosPct = 3454,
		[Description("Is Taunted")] IsTaunted = 3455,

		[Description("Summoned Monsters Set Monster Mortar Parent")]
		SummonedMonstersSetMonsterMortarParent = 3456,

		[Description("Storm Cloud Charged Damage +% Final")]
		StormCloudChargedDamagePosPctFinal = 3457,
		[Description("Chaos Damage Taken +%")] ChaosDamageTakenPosPct = 3458,

		[Description("Number Of Melee Skeletons To Summon As Mage Skeletons")]
		NumberOfMeleeSkeletonsToSummonAsMageSkeletons = 3459,

		[Description("Local Unique Jewel With 50 Int In Radius Summon X Melee Skeletons As Mage Skeletons")]
		LocalUniqueJewelWith50IntInRadiusSummonXMeleeSkeletonsAsMageSkeletons = 3460,

		[Description("Local Display Socketed Trap Skills Create Smoke Cloud")]
		LocalDisplaySocketedTrapSkillsCreateSmokeCloud = 3461,

		[Description("Glacial Hammer Item Rarity On Shattering Enemy +%")]
		GlacialHammerItemRarityOnShatteringEnemyPosPct = 3462,

		[Description("Spectral Throw Damage For Each Enemy Hit With Spectral Weapon +%")]
		SpectralThrowDamageForEachEnemyHitWithSpectralWeaponPosPct = 3463,

		[Description("Double Strike Chance To Trigger On Kill Effects An Additional Time %")]
		DoubleStrikeChanceToTriggerOnKillEffectsAnAdditionalTimePct = 3464,

		[Description("Viper Strike Attack Damage Per Poison On Enemy +%")]
		ViperStrikeAttackDamagePerPoisonOnEnemyPosPct = 3465,

		[Description("Heavy Strike Chance To Deal Double Damage %")]
		HeavyStrikeChanceToDealDoubleDamagePct = 3466,

		[Description("Local Unique Jewel Vigilant Strike Fortifies Nearby Allies For X Seconds With 50 Str In Radius")]
		LocalUniqueJewelVigilantStrikeFortifiesNearbyAlliesForXSecondsWith50StrInRadius = 3467,

		[Description("Local Unique Jewel Fireball Radius Up To +% At Longer Ranges With 50 Int In Radius")]
		LocalUniqueJewelFireballRadiusUpToPosPctAtLongerRangesWith50IntInRadius = 3468,

		[Description("Fireball Radius Up To +% At Longer Ranges")]
		FireballRadiusUpToPosPctAtLongerRanges = 3469,

		[Description("Local Unique Jewel Animate Weapon Can Animate Up To X Additional Ranged Weapons With 50 Dex In Radius")]
		LocalUniqueJewelAnimateWeaponCanAnimateUpToXAdditionalRangedWeaponsWith50DexInRadius = 3470,

		[Description("Animate Weapon Can Animate Up To X Additional Ranged Weapons")]
		AnimateWeaponCanAnimateUpToXAdditionalRangedWeapons = 3471,

		[Description("Local Unique Jewel Ground Slam Angle +% With 50 Str In Radius")]
		LocalUniqueJewelGroundSlamAnglePosPctWith50StrInRadius = 3472,
		[Description("Ground Slam Angle +%")] GroundSlamAnglePosPct = 3473,

		[Description("Local Unique Jewel Cold Snap Gain Power Charge On Kill % With 50 Int In Radius")]
		LocalUniqueJewelColdSnapGainPowerChargeOnKillPctWith50IntInRadius = 3474,

		[Description("Cold Snap Gain Power Charge On Kill %")]
		ColdSnapGainPowerChargeOnKillPct = 3475,

		[Description("Local Unique Jewel Rallying Cry Damage Taken Goes To Mana % With 50 Int In Radius")]
		LocalUniqueJewelRallyingCryDamageTakenGoesToManaPctWith50IntInRadius = 3476,

		[Description("Rallying Cry Damage Taken Goes To Mana %")]
		RallyingCryDamageTakenGoesToManaPct = 3477,

		[Description("Local Unique Jewel Barrage Final Volley Fires X Additional Projectiles Simultaneously With 50 Dex In Radius")]
		LocalUniqueJewelBarrageFinalVolleyFiresXAdditionalProjectilesSimultaneouslyWith50DexInRadius = 3478,

		[Description("Barrage Final Volley Fires X Additional Projectiles Simultaneously")]
		BarrageFinalVolleyFiresXAdditionalProjectilesSimultaneously = 3479,
		[Description("Never Block")] NeverBlock = 3480,

		[Description("Mana Cost -% Per Endurance Charge")]
		ManaCostNegPctPerEnduranceCharge = 3481,

		[Description("Gain Rampage While At Maximum Endurance Charges")]
		GainRampageWhileAtMaximumEnduranceCharges = 3482,

		[Description("Lose Endurance Charges On Rampage End")]
		LoseEnduranceChargesOnRampageEnd = 3483,

		[Description("Physical Attack Damage +% While Holding A Shield")]
		PhysicalAttackDamagePosPctWhileHoldingAShield = 3484,

		[Description("Cold Attack Damage +% While Holding A Shield")]
		ColdAttackDamagePosPctWhileHoldingAShield = 3485,

		[Description("Fire Attack Damage +% While Holding A Shield")]
		FireAttackDamagePosPctWhileHoldingAShield = 3486,

		[Description("Base Number Of Ranged Animated Weapons Allowed")]
		BaseNumberOfRangedAnimatedWeaponsAllowed = 3487,

		[Description("Virtual Number Of Ranged Animated Weapons Allowed")]
		VirtualNumberOfRangedAnimatedWeaponsAllowed = 3488,

		[Description("Virtual Player Gain Rampage Stacks")]
		VirtualPlayerGainRampageStacks = 3489,

		[Description("Minion Does Not Equip Quiver")]
		MinionDoesNotEquipQuiver = 3490,

		[Description("Number Of Grasping Ornaments")]
		NumberOfGraspingOrnaments = 3491,

		[Description("Grasping Ornament Placement Radius")]
		GraspingOrnamentPlacementRadius = 3492,
		[Description("Local No Block Chance")] LocalNoBlockChance = 3493,

		[Description("Support Controlled Destruction Spell Damage +% Final")]
		SupportControlledDestructionSpellDamagePosPctFinal = 3494,

		[Description("Support Void Manipulation Chaos Damage +% Final")]
		SupportVoidManipulationChaosDamagePosPctFinal = 3495,

		[Description("Support Rapid Decay Damage Over Time +% Final")]
		SupportRapidDecayDamageOverTimePosPctFinal = 3496,

		[Description("Cast On Any Damage Taken %")]
		CastOnAnyDamageTakenPct = 3497,
		[Description("Stun Threshold +%")] StunThresholdPosPct = 3498,

		[Description("Number Of Active Spectres")]
		NumberOfActiveSpectres = 3499,

		[Description("Number Of Active Skeletons")]
		NumberOfActiveSkeletons = 3500,

		[Description("Number Of Active Raging Spirits")]
		NumberOfActiveRagingSpirits = 3501,

		[Description("Number Of Active Zombies")]
		NumberOfActiveZombies = 3502,

		[Description("Minion Attack And Cast Speed +% Per Active Skeleton")]
		MinionAttackAndCastSpeedPosPctPerActiveSkeleton = 3503,

		[Description("Minion Duration +% Per Active Zombie")]
		MinionDurationPosPctPerActiveZombie = 3504,

		[Description("Minion Damage +% Per Active Spectre")]
		MinionDamagePosPctPerActiveSpectre = 3505,

		[Description("Minion Life Regeneration Per Minute Per Active Raging Spirit")]
		MinionLifeRegenerationPerMinutePerActiveRagingSpirit = 3506,

		[Description("Virtual Skill Effect Duration Pluspercent Final")]
		VirtualSkillEffectDurationPluspercentFinal = 3507,

		[Description("Virtual Additional Skill Effect Duration")]
		VirtualAdditionalSkillEffectDuration = 3508,

		[Description("Offering Of Judgement Counter")]
		OfferingOfJudgementCounter = 3509,

		[Description("Gain Her Blessing For 3 Seconds On Ignite %")]
		GainHerBlessingFor3SecondsOnIgnitePct = 3510,

		[Description("Blind Nearby Enemies When Gaining Her Blessing %")]
		BlindNearbyEnemiesWhenGainingHerBlessingPct = 3511,
		[Description("Have Her Blessing")] HaveHerBlessing = 3512,

		[Description("Avoid Freeze Chill Ignite % With Her Blessing")]
		AvoidFreezeChillIgnitePctWithHerBlessing = 3513,

		[Description("Attack And Movement Speed +% With Her Blessing")]
		AttackAndMovementSpeedPosPctWithHerBlessing = 3514,
		[Description("Warcry Speed +%")] WarcrySpeedPosPct = 3515,

		[Description("Gain Power Charge On Non Critical Strike %")]
		GainPowerChargeOnNonCriticalStrikePct = 3516,

		[Description("Critical Strike Multiplier + Per Power Charge")]
		CriticalStrikeMultiplierPosPerPowerCharge = 3517,

		[Description("Apply Poison On Hit Vs Bleeding Enemies %")]
		ApplyPoisonOnHitVsBleedingEnemiesPct = 3518,
		[Description("Avoid Blind %")] AvoidBlindPct = 3519,

		[Description("Damage Taken +% From Blinded Enemies")]
		DamageTakenPosPctFromBlindedEnemies = 3520,

		[Description("Attack Damage +% Per Frenzy Charge")]
		AttackDamagePosPctPerFrenzyCharge = 3521,

		[Description("Attack Damage +% While Onslaught Active")]
		AttackDamagePosPctWhileOnslaughtActive = 3522,
		[Description("Onslaught Effect +%")] OnslaughtEffectPosPct = 3523,

		[Description("Critical Strike Multiplier + Vs Bleeding Enemies")]
		CriticalStrikeMultiplierPosVsBleedingEnemies = 3524,

		[Description("Critical Strike Chance +% Vs Poisoned Enemies")]
		CriticalStrikeChancePosPctVsPoisonedEnemies = 3525,

		[Description("Elemental Damage Taken +%")]
		ElementalDamageTakenPosPct = 3526,

		[Description("Damage Taken From Traps And Mines +%")]
		DamageTakenFromTrapsAndMinesPosPct = 3527,

		[Description("Maim On Hit % Vs Poisoned Enemies")]
		MaimOnHitPctVsPoisonedEnemies = 3528,

		[Description("Raider Passive Evade Melee Attacks While Onslaughted +% Final")]
		RaiderPassiveEvadeMeleeAttacksWhileOnslaughtedPosPctFinal = 3529,

		[Description("Raider Passive Evade Projectile Attacks While Onslaughted +% Final")]
		RaiderPassiveEvadeProjectileAttacksWhileOnslaughtedPosPctFinal = 3530,

		[Description("Dispel Status Ailments On Flask Use")]
		DispelStatusAilmentsOnFlaskUse = 3531,

		[Description("Avoid Status Ailments % During Flask Effect")]
		AvoidStatusAilmentsPctDuringFlaskEffect = 3532,

		[Description("Attack Speed +% During Flask Effect")]
		AttackSpeedPosPctDuringFlaskEffect = 3533,

		[Description("Poison On Hit During Flask Effect %")]
		PoisonOnHitDuringFlaskEffectPct = 3534,

		[Description("Cyclone Places Ground Lightning")]
		CyclonePlacesGroundLightning = 3535,

		[Description("Cyclone Lightning Path Radius")]
		CycloneLightningPathRadius = 3536,

		[Description("Local Unique Flask Shock Nearby Enemies During Flask Effect")]
		LocalUniqueFlaskShockNearbyEnemiesDuringFlaskEffect = 3537,

		[Description("Local Unique Flask Shocked During Flask Effect")]
		LocalUniqueFlaskShockedDuringFlaskEffect = 3538,

		[Description("Local Unique Flask Leech Lightning Damage % As Life During Flask Effect")]
		LocalUniqueFlaskLeechLightningDamagePctAsLifeDuringFlaskEffect = 3539,

		[Description("Local Unique Flask Leech Lightning Damage % As Mana During Flask Effect")]
		LocalUniqueFlaskLeechLightningDamagePctAsManaDuringFlaskEffect = 3540,

		[Description("Local Unique Flask Leech Is Instant During Flask Effect")]
		LocalUniqueFlaskLeechIsInstantDuringFlaskEffect = 3541,

		[Description("Local Unique Flask Minimum Added Lightning Damage To Attacks During Flask Effect")]
		LocalUniqueFlaskMinimumAddedLightningDamageToAttacksDuringFlaskEffect = 3542,

		[Description("Local Unique Flask Maximum Added Lightning Damage To Attacks During Flask Effect")]
		LocalUniqueFlaskMaximumAddedLightningDamageToAttacksDuringFlaskEffect = 3543,

		[Description("Local Unique Flask Minimum Added Lightning Damage To Spells During Flask Effect")]
		LocalUniqueFlaskMinimumAddedLightningDamageToSpellsDuringFlaskEffect = 3544,

		[Description("Local Unique Flask Maximum Added Lightning Damage To Spells During Flask Effect")]
		LocalUniqueFlaskMaximumAddedLightningDamageToSpellsDuringFlaskEffect = 3545,

		[Description("Local Unique Flask Physical Damage % Converted To Lightning During Flask Effect")]
		LocalUniqueFlaskPhysicalDamagePctConvertedToLightningDuringFlaskEffect = 3546,

		[Description("Local Unique Flask Lightning Resistance Penetration % During Flask Effect")]
		LocalUniqueFlaskLightningResistancePenetrationPctDuringFlaskEffect = 3547,
		[Description("Leech Is Instant")] LeechIsInstant = 3548,
		[Description("Mana Leech Is Instant")] ManaLeechIsInstant = 3549,

		[Description("Projectiles Drop Ground Fire")]
		ProjectilesDropGroundFire = 3550,

		[Description("Projectiles Drop Ground Lightning")]
		ProjectilesDropGroundLightning = 3551,

		[Description("Projectiles Drop Ground Ice")]
		ProjectilesDropGroundIce = 3552,

		[Description("Projectiles Drop Ground Effects On Client")]
		ProjectilesDropGroundEffectsOnClient = 3553,

		[Description("Base Projectile Ground Effect Duration")]
		BaseProjectileGroundEffectDuration = 3554,

		[Description("Base Projectile Skill Dot Ground Fire Area Damage Per Minute")]
		BaseProjectileSkillDotGroundFireAreaDamagePerMinute = 3555,

		[Description("Projectile Ground Effect Duration")]
		ProjectileGroundEffectDuration = 3556,

		[Description("Projectile Skill Dot Ground Fire Area Damage Per Minute")]
		ProjectileSkillDotGroundFireAreaDamagePerMinute = 3557,

		[Description("Chaos Damage Can Chill")]
		ChaosDamageCanChill = 3558,

		[Description("Explode On Kill % Chaos Damage To Deal")]
		ExplodeOnKillPctChaosDamageToDeal = 3559,

		[Description("Enchantment Boots Damage Penetrates Elemental Resistance % While You Havent Killed For 4 Seconds")]
		EnchantmentBootsDamagePenetratesElementalResistancePctWhileYouHaventKilledFor4Seconds = 3560,

		[Description("Enchantment Boots Physical Damage % Added As Elements In Spells That Hit You In Past 4 Seconds")]
		EnchantmentBootsPhysicalDamagePctAddedAsElementsInSpellsThatHitYouInPast4Seconds = 3561,

		[Description("Enchantment Boots Minimum Added Chaos Damage For 4 Seconds When Crit 4s")]
		EnchantmentBootsMinimumAddedChaosDamageFor4SecondsWhenCrit4s = 3562,

		[Description("Enchantment Boots Maximum Added Chaos Damage For 4 Seconds When Crit 4s")]
		EnchantmentBootsMaximumAddedChaosDamageFor4SecondsWhenCrit4s = 3563,

		[Description("Life Leech Permyriad From Elemental Damage Against Enemies With Elemental Status Ailments")]
		LifeLeechPermyriadFromElementalDamageAgainstEnemiesWithElementalStatusAilments = 3564,

		[Description("Movement Speed +% While Not Affected By Status Ailments")]
		MovementSpeedPosPctWhileNotAffectedByStatusAilments = 3565,

		[Description("Stacking Spell Damage +% When You Or Your Totems Kill An Enemy For 2 Seconds")]
		StackingSpellDamagePosPctWhenYouOrYourTotemsKillAnEnemyFor2Seconds = 3566,

		[Description("Give Parent Stacking Spell Damage +% For 2 Seconds On Kill")]
		GiveParentStackingSpellDamagePosPctFor2SecondsOnKill = 3567,

		[Description("Totems Explode For % Of Max Life As Fire Damage On Low Life")]
		TotemsExplodeForPctOfMaxLifeAsFireDamageOnLowLife = 3568,

		[Description("Chance To Avoid Stun % Aura While Wielding A Staff")]
		ChanceToAvoidStunPctAuraWhileWieldingAStaff = 3569,

		[Description("Map Monsters Have Onslaught")]
		MapMonstersHaveOnslaught = 3570,

		[Description("Monster Is Invasion Boss")]
		MonsterIsInvasionBoss = 3571,

		[Description("Virtual Minion Attack Speed +%")]
		VirtualMinionAttackSpeedPosPct = 3572,

		[Description("Virtual Minion Cast Speed +%")]
		VirtualMinionCastSpeedPosPct = 3573,

		[Description("Virtual Minion Life Regeneration Per Minute")]
		VirtualMinionLifeRegenerationPerMinute = 3574,

		[Description("Dropbear Desecration Area Of Effect +%")]
		DropbearDesecrationAreaOfEffectPosPct = 3575,

		[Description("Physical Damage To Return To Melee Attacker")]
		PhysicalDamageToReturnToMeleeAttacker = 3576,

		[Description("Cold Damage To Return To Melee Attacker")]
		ColdDamageToReturnToMeleeAttacker = 3577,

		[Description("Fire Damage To Return To Melee Attacker")]
		FireDamageToReturnToMeleeAttacker = 3578,

		[Description("Lightning Damage To Return To Melee Attacker")]
		LightningDamageToReturnToMeleeAttacker = 3579,

		[Description("Chaos Damage To Return To Melee Attacker")]
		ChaosDamageToReturnToMeleeAttacker = 3580,

		[Description("Physical Damage To Return When Hit")]
		PhysicalDamageToReturnWhenHit = 3581,

		[Description("Cold Damage To Return When Hit")]
		ColdDamageToReturnWhenHit = 3582,

		[Description("Fire Damage To Return When Hit")]
		FireDamageToReturnWhenHit = 3583,

		[Description("Lightning Damage To Return When Hit")]
		LightningDamageToReturnWhenHit = 3584,

		[Description("Chaos Damage To Return When Hit")]
		ChaosDamageToReturnWhenHit = 3585,
		[Description("Trap Idle Duration")] TrapIdleDuration = 3586,
		[Description("Trap Retracts")] TrapRetracts = 3587,

		[Description("Physical Damage Taken +% While Frozen")]
		PhysicalDamageTakenPosPctWhileFrozen = 3588,

		[Description("Damage +% For 4 Seconds On Crit")]
		DamagePosPctFor4SecondsOnCrit = 3589,

		[Description("Damage And Minion Damage +% For 4 Seconds On Consume Corpse")]
		DamageAndMinionDamagePosPctFor4SecondsOnConsumeCorpse = 3590,

		[Description("Enemies Damage Taken +% While Cursed")]
		EnemiesDamageTakenPosPctWhileCursed = 3591,
		[Description("Spectre Damage +%")] SpectreDamagePosPct = 3592,

		[Description("Critical Strike Chance +% For 4 Seconds On Kill")]
		CriticalStrikeChancePosPctFor4SecondsOnKill = 3593,
		[Description("Ignite Effect +%")] IgniteEffectPosPct = 3594,
		[Description("Chill Effect +%")] ChillEffectPosPct = 3595,
		[Description("Shock Effect +%")] ShockEffectPosPct = 3596,
		[Description("Frozen Effect +%")] FrozenEffectPosPct = 3597,

		[Description("Critical Strikes Ignore Elemental Resistances")]
		CriticalStrikesIgnoreElementalResistances = 3598,

		[Description("Physical Damage Reduction And Minion Physical Damage Reduction % Per Raised Zombie")]
		PhysicalDamageReductionAndMinionPhysicalDamageReductionPctPerRaisedZombie = 3599,

		[Description("Damage Taken +% From Bleeding Enemies")]
		DamageTakenPosPctFromBleedingEnemies = 3600,

		[Description("Maim Bleeding Enemies On Hit %")]
		MaimBleedingEnemiesOnHitPct = 3601,

		[Description("One Handed Attack Speed +%")]
		OneHandedAttackSpeedPosPct = 3602,

		[Description("Movement Speed +% For 4 Seconds On Block")]
		MovementSpeedPosPctFor4SecondsOnBlock = 3603,

		[Description("Movement Speed +% While Fortified")]
		MovementSpeedPosPctWhileFortified = 3604,

		[Description("Elemental Damage Taken +% At Maximum Endurance Charges")]
		ElementalDamageTakenPosPctAtMaximumEnduranceCharges = 3605,

		[Description("Status Ailments Removed At Low Life")]
		StatusAilmentsRemovedAtLowLife = 3606,

		[Description("Gain Frenzy Charge On Main Hand Kill %")]
		GainFrenzyChargeOnMainHandKillPct = 3607,

		[Description("Gain Endurance Charge On Main Hand Kill %")]
		GainEnduranceChargeOnMainHandKillPct = 3608,

		[Description("Damage Taken +% For 4 Seconds On Kill")]
		DamageTakenPosPctFor4SecondsOnKill = 3609,

		[Description("Avoid Stun % For 4 Seconds On Kill")]
		AvoidStunPctFor4SecondsOnKill = 3610,

		[Description("Damage Taken +% For 4 Seconds On Killing Taunted Enemy")]
		DamageTakenPosPctFor4SecondsOnKillingTauntedEnemy = 3611,

		[Description("Warcry Cooldown Speed +%")]
		WarcryCooldownSpeedPosPct = 3612,

		[Description("Always Stun Enemies That Are On Full Life")]
		AlwaysStunEnemiesThatAreOnFullLife = 3613,

		[Description("Stun Duration +% Vs Enemies That Are On Full Life")]
		StunDurationPosPctVsEnemiesThatAreOnFullLife = 3614,

		[Description("Stun Duration +% Vs Enemies That Are On Low Life")]
		StunDurationPosPctVsEnemiesThatAreOnLowLife = 3615,

		[Description("Damage +% With One Handed Weapons")]
		DamagePosPctWithOneHandedWeapons = 3616,

		[Description("Damage +% With Two Handed Weapons")]
		DamagePosPctWithTwoHandedWeapons = 3617,

		[Description("Damage Reduction Rating From Body Armour Doubled")]
		DamageReductionRatingFromBodyArmourDoubled = 3618,

		[Description("Damage Reduction Rating % With Active Totem")]
		DamageReductionRatingPctWithActiveTotem = 3619,

		[Description("Virtual Physical Damage Taken +%")]
		VirtualPhysicalDamageTakenPosPct = 3620,

		[Description("Virtual Elemental Damage Taken +%")]
		VirtualElementalDamageTakenPosPct = 3621,
		[Description("Is Burning")] IsBurning = 3622,

		[Description("Ignite Effect On Self +%")]
		IgniteEffectOnSelfPosPct = 3623,

		[Description("Shocked Effect On Self +%")]
		ShockedEffectOnSelfPosPct = 3624,

		[Description("Ancestor Totem Parent Activiation Range")]
		AncestorTotemParentActiviationRange = 3625,

		[Description("Support Clustertrap Damage +% Final")]
		SupportClustertrapDamagePosPctFinal = 3626,

		[Description("Local Display Cast Level X Manifest Rageblade")]
		LocalDisplayCastLevelXManifestRageblade = 3627,

		[Description("Local Display Manifest Rageblade Disables Weapons")]
		LocalDisplayManifestRagebladeDisablesWeapons = 3628,

		[Description("Local Display Manifest Rageblade Destroy On End Rampage")]
		LocalDisplayManifestRagebladeDestroyOnEndRampage = 3629,

		[Description("Minions Grant Onslaught")]
		MinionsGrantOnslaught = 3630,

		[Description("Ground Fire Art Variation")]
		GroundFireArtVariation = 3631,

		[Description("Frost Blades Damage +%")]
		FrostBladesDamagePosPct = 3632,

		[Description("Frost Blades Projectile Speed +%")]
		FrostBladesProjectileSpeedPosPct = 3633,

		[Description("Frost Blades Number Of Additional Projectiles In Chain")]
		FrostBladesNumberOfAdditionalProjectilesInChain = 3634,

		[Description("Summoned Raging Spirit Duration +%")]
		SummonedRagingSpiritDurationPosPct = 3635,

		[Description("Summoned Raging Spirit Chance To Spawn Additional Minion %")]
		SummonedRagingSpiritChanceToSpawnAdditionalMinionPct = 3636,
		[Description("Discharge Damage +%")] DischargeDamagePosPct = 3637,
		[Description("Discharge Radius +%")] DischargeRadiusPosPct = 3638,

		[Description("Discharge Chance Not To Consume Charges %")]
		DischargeChanceNotToConsumeChargesPct = 3639,

		[Description("Anger Mana Reservation +%")]
		AngerManaReservationPosPct = 3640,
		[Description("Anger Aura Effect +%")] AngerAuraEffectPosPct = 3641,

		[Description("Lightning Trap Damage +%")]
		LightningTrapDamagePosPct = 3642,

		[Description("Lightning Trap Number Of Additional Projectiles")]
		LightningTrapNumberOfAdditionalProjectiles = 3643,

		[Description("Lightning Trap Cooldown Speed +%")]
		LightningTrapCooldownSpeedPosPct = 3644,

		[Description("Virtual Number Of Additional Projectiles In Chain")]
		VirtualNumberOfAdditionalProjectilesInChain = 3645,

		[Description("Ambush Passive Critical Strike Chance Vs Enemies On Full Life +% Final")]
		AmbushPassiveCriticalStrikeChanceVsEnemiesOnFullLifePosPctFinal = 3646,

		[Description("Critical Strike Multiplier Vs Enemies On Full Life +")]
		CriticalStrikeMultiplierVsEnemiesOnFullLifePos = 3647,

		[Description("Assassinate Passive Critical Strike Chance Vs Enemies On Low Life +% Final")]
		AssassinatePassiveCriticalStrikeChanceVsEnemiesOnLowLifePosPctFinal = 3648,

		[Description("Ambush Passive Critical Strike Chance +% Final")]
		AmbushPassiveCriticalStrikeChancePosPctFinal = 3649,

		[Description("Assassinate Passive Critical Strike Chance +% Final")]
		AssassinatePassiveCriticalStrikeChancePosPctFinal = 3650,
		[Description("Immune To Lava Damage")] ImmuneToLavaDamage = 3651,

		[Description("Number Of Additional Storm Clouds Allowed")]
		NumberOfAdditionalStormCloudsAllowed = 3652,

		[Description("Local Flask Consumes X Frenzy Charges On Use")]
		LocalFlaskConsumesXFrenzyChargesOnUse = 3653,

		[Description("Local Flask Consumes X Endurance Charges On Use")]
		LocalFlaskConsumesXEnduranceChargesOnUse = 3654,

		[Description("Local Flask Consumes X Power Charges On Use")]
		LocalFlaskConsumesXPowerChargesOnUse = 3655,

		[Description("Map Shrines Are Darkshrines")]
		MapShrinesAreDarkshrines = 3656,

		[Description("Physical Damage +% While Frozen")]
		PhysicalDamagePosPctWhileFrozen = 3657,

		[Description("Local Recharge On Crit %")]
		LocalRechargeOnCritPct = 3658,

		[Description("Mana And Es Regeneration Per Minute % When You Freeze Shock Or Ignite An Enemy")]
		ManaAndEsRegenerationPerMinutePctWhenYouFreezeShockOrIgniteAnEnemy = 3659,

		[Description("Damage Taken +% To An Element For 4 Seconds When Hit By Damage From An Element")]
		DamageTakenPosPctToAnElementFor4SecondsWhenHitByDamageFromAnElement = 3660,
		[Description("Cold Damage Taken +%")] ColdDamageTakenPosPct = 3661,

		[Description("Lightning Damage Taken +%")]
		LightningDamageTakenPosPct = 3662,

		[Description("Burning Arrow Spread Burning Ground When Igniting Enemy On Hit %")]
		BurningArrowSpreadBurningGroundWhenIgnitingEnemyOnHitPct = 3663,

		[Description("Burning Arrow Spread Tar Ground When Not Igniting Enemy On Hit %")]
		BurningArrowSpreadTarGroundWhenNotIgnitingEnemyOnHitPct = 3664,

		[Description("Local Unique Jewel Burning Arrow Spread Burning Ground When Igniting Enemy On Hit % With 50 Dexterity In Radius")]
		LocalUniqueJewelBurningArrowSpreadBurningGroundWhenIgnitingEnemyOnHitPctWith50DexterityInRadius = 3665,

		[Description("Local Unique Jewel Burning Arrow Spread Tar Ground When Not Igniting Enemy On Hit % With 50 Dexterity In Radius")]
		LocalUniqueJewelBurningArrowSpreadTarGroundWhenNotIgnitingEnemyOnHitPctWith50DexterityInRadius = 3666,

		[Description("Bleed On Hit With Attacks %")]
		BleedOnHitWithAttacksPct = 3667,

		[Description("Gain Flask Chance On Crit %")]
		GainFlaskChanceOnCritPct = 3668,
		[Description("Player Far Shot")] PlayerFarShot = 3669,

		[Description("Fire Elemental Meteor Landing Range")]
		FireElementalMeteorLandingRange = 3670,

		[Description("Virtual Aura Effect Pluspercent")]
		VirtualAuraEffectPluspercent = 3671,
		[Description("Cannot Be Poisoned")] CannotBePoisoned = 3672,
		[Description("Avoid Fire Damage %")] AvoidFireDamagePct = 3673,
		[Description("Avoid Cold Damage %")] AvoidColdDamagePct = 3674,

		[Description("Avoid Lightning Damage %")]
		AvoidLightningDamagePct = 3675,
		[Description("Avoid Chaos Damage %")] AvoidChaosDamagePct = 3676,

		[Description("Avoid Physical Damage %")]
		AvoidPhysicalDamagePct = 3677,

		[Description("Remove Bleed On Flask Use")]
		RemoveBleedOnFlaskUse = 3678,

		[Description("Slayer Ascendancy Melee Splash Damage +% Final")]
		SlayerAscendancyMeleeSplashDamagePosPctFinal = 3679,

		[Description("Slayer Ascendancy Melee Splash Damage +% Final For Splash")]
		SlayerAscendancyMeleeSplashDamagePosPctFinalForSplash = 3680,

		[Description("Guardian Reserved Mana % Given To You And Nearby Allies As Base Maximum Energy Shield")]
		GuardianReservedManaPctGivenToYouAndNearbyAlliesAsBaseMaximumEnergyShield = 3681,

		[Description("Virtual Base Maximum Energy Shield To Grant To You And Nearby Allies")]
		VirtualBaseMaximumEnergyShieldToGrantToYouAndNearbyAllies = 3682,

		[Description("Virtual Armour To Grant To You And Nearby Allies")]
		VirtualArmourToGrantToYouAndNearbyAllies = 3683,

		[Description("Number Of Additional Siege Ballistae Per 200 Dexterity")]
		NumberOfAdditionalSiegeBallistaePer200Dexterity = 3684,

		[Description("Attack Minimum Added Physical Damage Per 25 Dexterity")]
		AttackMinimumAddedPhysicalDamagePer25Dexterity = 3685,

		[Description("Attack Maximum Added Physical Damage Per 25 Dexterity")]
		AttackMaximumAddedPhysicalDamagePer25Dexterity = 3686,

		[Description("Local Display Nearby Enemies Are Blinded")]
		LocalDisplayNearbyEnemiesAreBlinded = 3687,

		[Description("Local Display Nearby Enemies Movement Speed +%")]
		LocalDisplayNearbyEnemiesMovementSpeedPosPct = 3688,

		[Description("Local Display Socketed Gems Supported By X Hypothermia")]
		LocalDisplaySocketedGemsSupportedByXHypothermia = 3689,

		[Description("Local Display Socketed Gems Supported By X Ice Bite")]
		LocalDisplaySocketedGemsSupportedByXIceBite = 3690,

		[Description("Local Display Socketed Gems Supported By X Cold Penetration")]
		LocalDisplaySocketedGemsSupportedByXColdPenetration = 3691,

		[Description("Local Display Socketed Gems Supported By X Mana Leech")]
		LocalDisplaySocketedGemsSupportedByXManaLeech = 3692,

		[Description("Local Display Socketed Gems Supported By X Added Cold Damage")]
		LocalDisplaySocketedGemsSupportedByXAddedColdDamage = 3693,

		[Description("Local Display Socketed Gems Supported By X Reduced Mana Cost")]
		LocalDisplaySocketedGemsSupportedByXReducedManaCost = 3694,

		[Description("Projectile Nova Extend Projectiles Forward By X Units")]
		ProjectileNovaExtendProjectilesForwardByXUnits = 3695,

		[Description("Storm Cloud Destroy When Caster Dies")]
		StormCloudDestroyWhenCasterDies = 3696,

		[Description("Chance To Gain Onslaught On Kill For 4 Seconds %")]
		ChanceToGainOnslaughtOnKillFor4SecondsPct = 3697,

		[Description("Chance To Cast On Rampage Tier %")]
		ChanceToCastOnRampageTierPct = 3698,

		[Description("Local Display Minions Grant Onslaught")]
		LocalDisplayMinionsGrantOnslaught = 3699,

		[Description("% Of Life And Energy Shield To Deal As Damage")]
		Pctoflifeandenergyshieldtodealasdamage = 3700,

		[Description("Critical Strike Chance +% Vs Blinded Enemies")]
		CriticalStrikeChancePosPctVsBlindedEnemies = 3701,
		[Description("Is In Singularity")] IsInSingularity = 3702,

		[Description("Chilled Ground On Freeze % Chance For 3 Seconds")]
		ChilledGroundOnFreezePctChanceFor3Seconds = 3703,

		[Description("Consecrate Ground On Kill % For 3 Seconds")]
		ConsecrateGroundOnKillPctFor3Seconds = 3704,
		[Description("In Symbol")] InSymbol = 3705,

		[Description("Damage Taken +% From Enemies In Symbols")]
		DamageTakenPosPctFromEnemiesInSymbols = 3706,

		[Description("Local Display Socketed Aura Gems Reserve No Mana")]
		LocalDisplaySocketedAuraGemsReserveNoMana = 3707,
		[Description("No Mana Reserved")] NoManaReserved = 3708,

		[Description("Piercing Attacks Cause Bleeding")]
		PiercingAttacksCauseBleeding = 3709,

		[Description("Spell Damage Modifiers Apply To Skill Dot")]
		SpellDamageModifiersApplyToSkillDot = 3710,

		[Description("Shadow Blades Projectile Spread")]
		ShadowBladesProjectileSpread = 3711,

		[Description("Map Disable Bloodlines")]
		MapDisableBloodlines = 3712,
		[Description("Map Disable Nemesis")] MapDisableNemesis = 3713,
		[Description("Is Poisoned")] IsPoisoned = 3714,

		[Description("Is Vinktar Lightning Bond Source")]
		IsVinktarLightningBondSource = 3715,

		[Description("Is Vinktar Lightning Bond Target")]
		IsVinktarLightningBondTarget = 3716,

		[Description("Energy Shield Recharges On Block %")]
		EnergyShieldRechargesOnBlockPct = 3717,

		[Description("Dropped Weapons Have 20 Quality")]
		DroppedWeaponsHave20Quality = 3718,

		[Description("Drop Additional 20 Quality Gems")]
		DropAdditional20QualityGems = 3719,

		[Description("Killed Rare Monsters Drop Additional Unique Items")]
		KilledRareMonstersDropAdditionalUniqueItems = 3720,

		[Description("Poison Duration Is Skill Duration")]
		PoisonDurationIsSkillDuration = 3721,

		[Description("Map Players Gain Rare Monster Mods On Kill Ms")]
		MapPlayersGainRareMonsterModsOnKillMs = 3722,

		[Description("Soul Eater On Rare Kill Ms")]
		SoulEaterOnRareKillMs = 3723,

		[Description("Map Players Gain Soul Eater On Rare Kill Ms")]
		MapPlayersGainSoulEaterOnRareKillMs = 3724,

		[Description("Gain Soul Eater During Flask Effect")]
		GainSoulEaterDuringFlaskEffect = 3725,

		[Description("Lose Soul Eater Souls On Flask Use")]
		LoseSoulEaterSoulsOnFlaskUse = 3726,

		[Description("Totemified Skills Taunt On Hit %")]
		TotemifiedSkillsTauntOnHitPct = 3727,

		[Description("Virtual Chance To Taunt On Hit %")]
		VirtualChanceToTauntOnHitPct = 3728,

		[Description("Offerings Also Buff You")]
		OfferingsAlsoBuffYou = 3729,

		[Description("Caustic Cloud On Death Maximum Life Per Minute To Deal As Chaos Damage %")]
		CausticCloudOnDeathMaximumLifePerMinuteToDealAsChaosDamagePct = 3730,

		[Description("Minion Caustic Cloud On Death Maximum Life Per Minute To Deal As Chaos Damage %")]
		MinionCausticCloudOnDeathMaximumLifePerMinuteToDealAsChaosDamagePct = 3731,

		[Description("Storm Cloud Charge Count")]
		StormCloudChargeCount = 3732,
		[Description("Monster Is Duplicated")] MonsterIsDuplicated = 3733,

		[Description("Gain Life Leech From Any Damage Permyriad As Life For 4 Seconds If Taken Savage Hit")]
		GainLifeLeechFromAnyDamagePermyriadAsLifeFor4SecondsIfTakenSavageHit = 3734,

		[Description("Gain Damage +% For 4 Seconds If Taken Savage Hit")]
		GainDamagePosPctFor4SecondsIfTakenSavageHit = 3735,

		[Description("Gain Attack Speed +% For 4 Seconds If Taken Savage Hit")]
		GainAttackSpeedPosPctFor4SecondsIfTakenSavageHit = 3736,

		[Description("Damage +% Vs Burning Enemies")]
		DamagePosPctVsBurningEnemies = 3737,

		[Description("Endurance Charge On Off Hand Kill %")]
		EnduranceChargeOnOffHandKillPct = 3738,

		[Description("Aura Melee Physical Damage +% Per 10 Strength")]
		AuraMeleePhysicalDamagePosPctPer10Strength = 3739,
		[Description("Attack On Death %")] AttackOnDeathPct = 3740,

		[Description("Siphon Life Leech From Damage Permyriad")]
		SiphonLifeLeechFromDamagePermyriad = 3741,

		[Description("Total Base Maximum Mana")]
		TotalBaseMaximumMana = 3742,
		[Description("Combined Mana +%")] CombinedManaPosPct = 3743,

		[Description("Combined Mana +% Final")]
		CombinedManaPosPctFinal = 3744,

		[Description("You And Your Totems Gain An Endurance Charge On Burning Enemy Kill %")]
		YouAndYourTotemsGainAnEnduranceChargeOnBurningEnemyKillPct = 3745,

		[Description("Minions Grant Owner And Owners Totems Gains Endurance Charge On Burning Enemy Kill %")]
		MinionsGrantOwnerAndOwnersTotemsGainsEnduranceChargeOnBurningEnemyKillPct = 3746,

		[Description("Grant Owner And Owners Totems An Endurance Charge On Burning Enemy Kill %")]
		GrantOwnerAndOwnersTotemsAnEnduranceChargeOnBurningEnemyKillPct = 3747,

		[Description("Auras Grant Additional Physical Damage Reduction % To You And Your Allies")]
		AurasGrantAdditionalPhysicalDamageReductionPctToYouAndYourAllies = 3748,

		[Description("Auras Grant Damage +% To You And Your Allies")]
		AurasGrantDamagePosPctToYouAndYourAllies = 3749,

		[Description("Auras Grant Attack And Cast Speed +% To You And Your Allies")]
		AurasGrantAttackAndCastSpeedPosPctToYouAndYourAllies = 3750,

		[Description("Placing Traps Cooldown Recovery +%")]
		PlacingTrapsCooldownRecoveryPosPct = 3751,

		[Description("Damage +% Vs Enemies Affected By Status Ailments")]
		DamagePosPctVsEnemiesAffectedByStatusAilments = 3752,
		[Description("Warcries Are Instant")] WarcriesAreInstant = 3753,

		[Description("Aura Grant Shield Defences To Nearby Allies")]
		AuraGrantShieldDefencesToNearbyAllies = 3754,

		[Description("Minion Additional Physical Damage Reduction %")]
		MinionAdditionalPhysicalDamageReductionPct = 3755,

		[Description("Phasing For 4 Seconds On Kill %")]
		PhasingFor4SecondsOnKillPct = 3756,

		[Description("Skill Area Of Effect +% Per Active Mine")]
		SkillAreaOfEffectPosPctPerActiveMine = 3757,

		[Description("Damage +% Per Active Trap")]
		DamagePosPctPerActiveTrap = 3758,

		[Description("Immune To Status Ailments While Phased")]
		ImmuneToStatusAilmentsWhilePhased = 3759,

		[Description("Chance To Dodge Spells % While Phased")]
		ChanceToDodgeSpellsPctWhilePhased = 3760,

		[Description("Additional Critical Strike Chance Per Power Charge Permyriad")]
		AdditionalCriticalStrikeChancePerPowerChargePermyriad = 3761,

		[Description("Movement Skills Cost No Mana")]
		MovementSkillsCostNoMana = 3762,

		[Description("Attack And Cast Speed +% For 4 Seconds On Movement Skill Use")]
		AttackAndCastSpeedPosPctFor4SecondsOnMovementSkillUse = 3763,

		[Description("Recover 10% Of Maximum Mana On Skill Use %")]
		Recover10PctOfMaximumManaOnSkillUsePct = 3764,

		[Description("Mine Laying Speed +% For 4 Seconds On Detonation")]
		MineLayingSpeedPosPctFor4SecondsOnDetonation = 3765,

		[Description("Damage +% For 4 Seconds On Detonation")]
		DamagePosPctFor4SecondsOnDetonation = 3766,

		[Description("Flask Charges Recovered Per 3 Seconds")]
		FlaskChargesRecoveredPer3Seconds = 3767,

		[Description("Trap Skill Area Of Effect +%")]
		TrapSkillAreaOfEffectPosPct = 3768,

		[Description("Number Of Active Mines")]
		NumberOfActiveMines = 3769,

		[Description("Number Of Active Traps")]
		NumberOfActiveTraps = 3770,
		[Description("Is Spike Trap")] IsSpikeTrap = 3771,
		[Description("Is Arrow Trap")] IsArrowTrap = 3772,

		[Description("Damage Taken +% From Spike Traps Final")]
		DamageTakenPosPctFromSpikeTrapsFinal = 3773,

		[Description("Damage Taken +% From Arrow Traps Final")]
		DamageTakenPosPctFromArrowTrapsFinal = 3774,

		[Description("Minion Damage Taken +% From Spike Traps Final")]
		MinionDamageTakenPosPctFromSpikeTrapsFinal = 3775,

		[Description("Minion Damage Taken +% From Arrow Traps Final")]
		MinionDamageTakenPosPctFromArrowTrapsFinal = 3776,

		[Description("Labyrinth Trap Degen Effect On Self +%")]
		LabyrinthTrapDegenEffectOnSelfPosPct = 3777,

		[Description("Minions Have Labyrinth Trap Degen Effect +%")]
		MinionsHaveLabyrinthTrapDegenEffectPosPct = 3778,

		[Description("Immune To Labyrinth Degen Effect")]
		ImmuneToLabyrinthDegenEffect = 3779,

		[Description("Minions Are Immune To Labyrinth Degen Effect")]
		MinionsAreImmuneToLabyrinthDegenEffect = 3780,

		[Description("Nearby Traps Within X Units Also Trigger On Triggering Trap")]
		NearbyTrapsWithinXUnitsAlsoTriggerOnTriggeringTrap = 3781,

		[Description("Number Of Additional Mines To Place")]
		NumberOfAdditionalMinesToPlace = 3782,

		[Description("Chance To Place An Additional Mine %")]
		ChanceToPlaceAnAdditionalMinePct = 3783,
		[Description("Immune To Shunt Geal")] ImmuneToShuntGeal = 3784,

		[Description("Chance For Elemental Damage To Be Added As Additional Chaos Damage %")]
		ChanceForElementalDamageToBeAddedAsAdditionalChaosDamagePct = 3785,

		[Description("Critical Strike Chance +% Vs Enemies Without Elemental Status Ailments")]
		CriticalStrikeChancePosPctVsEnemiesWithoutElementalStatusAilments = 3786,

		[Description("Spell Damage +% For 4 Seconds On Cast")]
		SpellDamagePosPctFor4SecondsOnCast = 3787,

		[Description("Attack Damage +% For 4 Seconds On Cast")]
		AttackDamagePosPctFor4SecondsOnCast = 3788,

		[Description("Attack Speed +% For 4 Seconds On Attack")]
		AttackSpeedPosPctFor4SecondsOnAttack = 3789,

		[Description("Cast Speed +% For 4 Seconds On Attack")]
		CastSpeedPosPctFor4SecondsOnAttack = 3790,

		[Description("Attack And Cast Speed +% For 4 Seconds On Begin Es Recharge")]
		AttackAndCastSpeedPosPctFor4SecondsOnBeginEsRecharge = 3791,

		[Description("Display Attack With Commandment Of Force On Hit %")]
		DisplayAttackWithCommandmentOfForceOnHitPct = 3792,

		[Description("Display Attack With Commandment Of Fury On Hit %")]
		DisplayAttackWithCommandmentOfFuryOnHitPct = 3793,

		[Description("Display Attack With Commandment Of Light When Critically Hit %")]
		DisplayAttackWithCommandmentOfLightWhenCriticallyHitPct = 3794,

		[Description("Display Attack With Commandment Of Spite When Hit %")]
		DisplayAttackWithCommandmentOfSpiteWhenHitPct = 3795,

		[Description("Display Attack With Decree Of Force On Hit %")]
		DisplayAttackWithDecreeOfForceOnHitPct = 3796,

		[Description("Display Attack With Decree Of Fury On Hit %")]
		DisplayAttackWithDecreeOfFuryOnHitPct = 3797,

		[Description("Display Attack With Decree Of Light When Critically Hit %")]
		DisplayAttackWithDecreeOfLightWhenCriticallyHitPct = 3798,

		[Description("Display Attack With Decree Of Spite When Hit %")]
		DisplayAttackWithDecreeOfSpiteWhenHitPct = 3799,

		[Description("Display Attack With Edict Of Force On Hit %")]
		DisplayAttackWithEdictOfForceOnHitPct = 3800,

		[Description("Display Attack With Edict Of Fury On Hit %")]
		DisplayAttackWithEdictOfFuryOnHitPct = 3801,

		[Description("Display Attack With Edict Of Ire When Hit %")]
		DisplayAttackWithEdictOfIreWhenHitPct = 3802,

		[Description("Display Attack With Edict Of Light When Critically Hit %")]
		DisplayAttackWithEdictOfLightWhenCriticallyHitPct = 3803,

		[Description("Display Attack With Edict Of Spite When Hit %")]
		DisplayAttackWithEdictOfSpiteWhenHitPct = 3804,

		[Description("Display Attack With Word Of Force On Hit %")]
		DisplayAttackWithWordOfForceOnHitPct = 3805,

		[Description("Display Attack With Word Of Fury On Hit %")]
		DisplayAttackWithWordOfFuryOnHitPct = 3806,

		[Description("Display Attack With Word Of Light When Critically Hit %")]
		DisplayAttackWithWordOfLightWhenCriticallyHitPct = 3807,

		[Description("Display Attack With Word Of Ire When Hit %")]
		DisplayAttackWithWordOfIreWhenHitPct = 3808,

		[Description("Display Attack With Word Of Spite When Hit %")]
		DisplayAttackWithWordOfSpiteWhenHitPct = 3809,

		[Description("Display Cast Commandment Of Blades On Hit % ")]
		DisplayCastCommandmentOfBladesOnHitPct = 3810,

		[Description("Display Cast Commandment Of Inferno On Kill %")]
		DisplayCastCommandmentOfInfernoOnKillPct = 3811,

		[Description("Display Cast Commandment Of Reflection When Hit %")]
		DisplayCastCommandmentOfReflectionWhenHitPct = 3812,

		[Description("Display Cast Commandment Of Tempest On Hit %")]
		DisplayCastCommandmentOfTempestOnHitPct = 3813,

		[Description("Display Cast Commandment Of The Grave On Kill %")]
		DisplayCastCommandmentOfTheGraveOnKillPct = 3814,

		[Description("Display Cast Commandment Of War On Kill %")]
		DisplayCastCommandmentOfWarOnKillPct = 3815,

		[Description("Display Cast Commandment Of Winter When Hit %")]
		DisplayCastCommandmentOfWinterWhenHitPct = 3816,

		[Description("Display Cast Decree Of Blades On Hit %  ")]
		DisplayCastDecreeOfBladesOnHitPct = 3817,

		[Description("Display Cast Decree Of Inferno On Kill %")]
		DisplayCastDecreeOfInfernoOnKillPct = 3818,

		[Description("Display Cast Decree Of Reflection When Hit %")]
		DisplayCastDecreeOfReflectionWhenHitPct = 3819,

		[Description("Display Cast Decree Of Tempest On Hit %")]
		DisplayCastDecreeOfTempestOnHitPct = 3820,

		[Description("Display Cast Decree Of The Grave On Kill %")]
		DisplayCastDecreeOfTheGraveOnKillPct = 3821,

		[Description("Display Cast Decree Of War On Kill %")]
		DisplayCastDecreeOfWarOnKillPct = 3822,

		[Description("Display Cast Decree Of Winter When Hit %")]
		DisplayCastDecreeOfWinterWhenHitPct = 3823,

		[Description("Display Cast Edict Of Blades On Hit % ")]
		DisplayCastEdictOfBladesOnHitPct = 3824,

		[Description("Display Cast Edict Of Inferno On Kill %")]
		DisplayCastEdictOfInfernoOnKillPct = 3825,

		[Description("Display Cast Edict Of Reflection When Hit %")]
		DisplayCastEdictOfReflectionWhenHitPct = 3826,

		[Description("Display Cast Edict Of Tempest On Hit %")]
		DisplayCastEdictOfTempestOnHitPct = 3827,

		[Description("Display Cast Edict Of The Grave On Kill %")]
		DisplayCastEdictOfTheGraveOnKillPct = 3828,

		[Description("Display Cast Edict Of War On Kill %")]
		DisplayCastEdictOfWarOnKillPct = 3829,

		[Description("Display Cast Edict Of Winter When Hit %")]
		DisplayCastEdictOfWinterWhenHitPct = 3830,

		[Description("Display Cast Word Of Blades On Hit %")]
		DisplayCastWordOfBladesOnHitPct = 3831,

		[Description("Display Cast Word Of Inferno On Kill %")]
		DisplayCastWordOfInfernoOnKillPct = 3832,

		[Description("Display Cast Word Of Reflection When Hit %")]
		DisplayCastWordOfReflectionWhenHitPct = 3833,

		[Description("Display Cast Word Of Tempest On Hit %")]
		DisplayCastWordOfTempestOnHitPct = 3834,

		[Description("Display Cast Word Of Winter When Hit %")]
		DisplayCastWordOfWinterWhenHitPct = 3835,

		[Description("Life Es And Mana Recovery +% For 4 Seconds On Killing Enemies Affected By Your Degen")]
		LifeEsAndManaRecoveryPosPctFor4SecondsOnKillingEnemiesAffectedByYourDegen = 3836,

		[Description("Trickster Passive Chance To Evade Attacks While Not On Full Energy Shield +% Final")]
		TricksterPassiveChanceToEvadeAttacksWhileNotOnFullEnergyShieldPosPctFinal = 3837,

		[Description("Display Cast Word Of Flames On Hit %")]
		DisplayCastWordOfFlamesOnHitPct = 3838,

		[Description("Display Cast Edict Of Flames On Hit %")]
		DisplayCastEdictOfFlamesOnHitPct = 3839,

		[Description("Display Cast Decree Of Flames On Hit %")]
		DisplayCastDecreeOfFlamesOnHitPct = 3840,

		[Description("Display Cast Commandment Of Flames On Hit %")]
		DisplayCastCommandmentOfFlamesOnHitPct = 3841,

		[Description("Display Cast Word Of Frost On Kill %")]
		DisplayCastWordOfFrostOnKillPct = 3842,

		[Description("Display Cast Edict Of Frost On Kill %")]
		DisplayCastEdictOfFrostOnKillPct = 3843,

		[Description("Display Cast Decree Of Frost On Kill %")]
		DisplayCastDecreeOfFrostOnKillPct = 3844,

		[Description("Display Cast Commandment Of Frost On Kill %")]
		DisplayCastCommandmentOfFrostOnKillPct = 3845,

		[Description("Display Cast Word Of Thunder On Kill %")]
		DisplayCastWordOfThunderOnKillPct = 3846,

		[Description("Display Cast Edict Of Thunder On Kill %")]
		DisplayCastEdictOfThunderOnKillPct = 3847,

		[Description("Display Cast Decree Of Thunder On Kill %")]
		DisplayCastDecreeOfThunderOnKillPct = 3848,

		[Description("Display Cast Commandment Of Thunder On Kill %")]
		DisplayCastCommandmentOfThunderOnKillPct = 3849,

		[Description("Display Cast Fire Burst On Kill")]
		DisplayCastFireBurstOnKill = 3850,

		[Description("Local Stat Monsters Pick Up Item")]
		LocalStatMonstersPickUpItem = 3851,

		[Description("Stone Golem Grants Base Life Regeneration Rate Per Minute")]
		StoneGolemGrantsBaseLifeRegenerationRatePerMinute = 3852,

		[Description("Bladefall Damage Per Stage +% Final")]
		BladefallDamagePerStagePosPctFinal = 3853,
		[Description("Global Maim On Hit")] GlobalMaimOnHit = 3854,

		[Description("Consecrate Ground For 3 Seconds When Hit %")]
		ConsecrateGroundFor3SecondsWhenHitPct = 3855,

		[Description("Damage +% On Consecrated Ground")]
		DamagePosPctOnConsecratedGround = 3856,

		[Description("Mana Cost +% On Consecrated Ground")]
		ManaCostPosPctOnConsecratedGround = 3857,

		[Description("Avoid Ailments % On Consecrated Ground")]
		AvoidAilmentsPctOnConsecratedGround = 3858,
		[Description("On Consecrated Ground")] OnConsecratedGround = 3859,

		[Description("Inquisitor Aura Elemental Damage +% Final")]
		InquisitorAuraElementalDamagePosPctFinal = 3860,

		[Description("Critical Strike Multiplier + Vs Enemies Affected By Elemental Status Ailment")]
		CriticalStrikeMultiplierPosVsEnemiesAffectedByElementalStatusAilment = 3861,

		[Description("Non Critical Strikes Penetrate Elemental Resistances %")]
		NonCriticalStrikesPenetrateElementalResistancesPct = 3862,

		[Description("Virtual Penetrate Elemental Resistances %")]
		VirtualPenetrateElementalResistancesPct = 3863,

		[Description("Base Penetrate Elemental Resistances %")]
		BasePenetrateElementalResistancesPct = 3864,

		[Description("Virtual Minion Additional Physical Damage Reduction Percent")]
		VirtualMinionAdditionalPhysicalDamageReductionPercent = 3865,

		[Description("Chance To Poison On Hit With Attacks %")]
		ChanceToPoisonOnHitWithAttacksPct = 3866,

		[Description("Chance To Double Stun Duration %")]
		ChanceToDoubleStunDurationPct = 3867,
		[Description("Is Guillotine Trap")] IsGuillotineTrap = 3868,

		[Description("Damage Taken +% From Guillotine Traps Final")]
		DamageTakenPosPctFromGuillotineTrapsFinal = 3869,

		[Description("Minion Damage Taken +% From Guillotine Traps Final")]
		MinionDamageTakenPosPctFromGuillotineTrapsFinal = 3870,

		[Description("Labyrinth Arrow Movement Speed +% Final")]
		LabyrinthArrowMovementSpeedPosPctFinal = 3871,

		[Description("Map Disable Portal Use")]
		MapDisablePortalUse = 3872,

		[Description("Jorrhasts Blacksteel Animate Weapon Duration +% Final")]
		JorrhastsBlacksteelAnimateWeaponDurationPosPctFinal = 3873,

		[Description("Shockwave Slam Explosion Damage +% Final")]
		ShockwaveSlamExplosionDamagePosPctFinal = 3874,

		[Description("Display Monster Casts Wither")]
		DisplayMonsterCastsWither = 3875,

		[Description("Display Monster Causes Ground Desecration")]
		DisplayMonsterCausesGroundDesecration = 3876,

		[Description("Spread Tar Ground When Not Igniting Enemy On Hit %")]
		SpreadTarGroundWhenNotIgnitingEnemyOnHitPct = 3877,

		[Description("Spread Burning Ground When Igniting Enemy On Hit %")]
		SpreadBurningGroundWhenIgnitingEnemyOnHitPct = 3878,

		[Description("Non Curse Aura Effect +%")]
		NonCurseAuraEffectPosPct = 3879,

		[Description("Max Talisman Degen Stacks")]
		MaxTalismanDegenStacks = 3880,

		[Description("Current Talisman Degen Stacks")]
		CurrentTalismanDegenStacks = 3881,

		[Description("Base Physical Damage Taken Per Minute Per Talisman Degen Stack")]
		BasePhysicalDamageTakenPerMinutePerTalismanDegenStack = 3882,

		[Description("Melee Splash Area Of Effect +% Final")]
		MeleeSplashAreaOfEffectPosPctFinal = 3883,

		[Description("Unarmed Damage +% Vs Bleeding Enemies")]
		UnarmedDamagePosPctVsBleedingEnemies = 3884,

		[Description("Life Gained On Bleeding Enemy Hit")]
		LifeGainedOnBleedingEnemyHit = 3885,

		[Description("Base Critical Strike Chance While Unarmed %")]
		BaseCriticalStrikeChanceWhileUnarmedPct = 3886,

		[Description("Modifiers To Claw Damage Also Affect Unarmed Damage")]
		ModifiersToClawDamageAlsoAffectUnarmedDamage = 3887,

		[Description("Damage +% While Unarmed")]
		DamagePosPctWhileUnarmed = 3888,

		[Description("Bloodworm On Damage Taken %")]
		BloodwormOnDamageTakenPct = 3889,

		[Description("Map Sidearea Level Override")]
		MapSideareaLevelOverride = 3890,

		[Description("Map Boss Talisman Tier")]
		MapBossTalismanTier = 3891,

		[Description("Map Boss Talisman Rarity")]
		MapBossTalismanRarity = 3892,

		[Description("Local Display Illusory Warp Level")]
		LocalDisplayIllusoryWarpLevel = 3893,

		[Description("Fortify Effect On Self +%")]
		FortifyEffectOnSelfPosPct = 3894,

		[Description("Local Implicit Stat Magnitude +%")]
		LocalImplicitStatMagnitudePosPct = 3895,
		[Description("Using Flask")] UsingFlask = 3896,

		[Description("Chance To Poison On Hit %")]
		ChanceToPoisonOnHitPct = 3897,

		[Description("Flask Charges Gained +%")]
		FlaskChargesGainedPosPct = 3898,
		[Description("Soul Eater From Stat")] SoulEaterFromStat = 3899,

		[Description("Gain Power Charge On Kill With Hit %")]
		GainPowerChargeOnKillWithHitPct = 3900,

		[Description("Killed Monster Dropped Item Rarity +% When Shattered")]
		KilledMonsterDroppedItemRarityPosPctWhenShattered = 3901,

		[Description("Energy Shield Delay During Flask Effect -%")]
		EnergyShieldDelayDuringFlaskEffectNegPct = 3902,

		[Description("Virtual Energy Shield Delay -%")]
		VirtualEnergyShieldDelayNegPct = 3903,

		[Description("Energy Shield Recharge Rate During Flask Effect +%")]
		EnergyShieldRechargeRateDuringFlaskEffectPosPct = 3904,

		[Description("Virtual Energy Shield Recharge Rate +%")]
		VirtualEnergyShieldRechargeRatePosPct = 3905,

		[Description("Base Cold Damage % Of Maximum Life Plus Maximum Es Taken Per Minute")]
		BaseColdDamagePctOfMaximumLifePlusMaximumEsTakenPerMinute = 3906,

		[Description("Base Lightning Damage % Of Maximum Life Plus Maximum Es Taken Per Minute")]
		BaseLightningDamagePctOfMaximumLifePlusMaximumEsTakenPerMinute = 3907,

		[Description("Modifiers To Claw Attack Speed Also Affect Unarmed Attack Speed")]
		ModifiersToClawAttackSpeedAlsoAffectUnarmedAttackSpeed = 3908,

		[Description("Modifiers To Claw Critical Strike Chance Also Affect Unarmed Critical Strike Chance")]
		ModifiersToClawCriticalStrikeChanceAlsoAffectUnarmedCriticalStrikeChance = 3909,

		[Description("Main Hand Chance To Poison On Critical Strike %")]
		MainHandChanceToPoisonOnCriticalStrikePct = 3910,

		[Description("Off Hand Chance To Poison On Critical Strike %")]
		OffHandChanceToPoisonOnCriticalStrikePct = 3911,

		[Description("Chance To Poison On Critical Strike With Dagger %")]
		ChanceToPoisonOnCriticalStrikeWithDaggerPct = 3912,
		[Description("Minion Duration")] MinionDuration = 3913,

		[Description("Number Of Wolves Allowed")]
		NumberOfWolvesAllowed = 3914,

		[Description("Whirling Leap Bloodworms To Spawn")]
		WhirlingLeapBloodwormsToSpawn = 3915,

		[Description("Map Display Unique Boss Drops X Maps")]
		MapDisplayUniqueBossDropsXMaps = 3916,

		[Description("Endurance Charge On Kill %")]
		EnduranceChargeOnKillPct = 3917,

		[Description("Fishing Bite Sensitivity +%")]
		FishingBiteSensitivityPosPct = 3918,

		[Description("Local Display Summon Wolf On Kill %")]
		LocalDisplaySummonWolfOnKillPct = 3919,

		[Description("Corrupted Blood On Hit % Average Damage To Deal Per Minute Per Stack")]
		CorruptedBloodOnHitPctAverageDamageToDealPerMinutePerStack = 3920,

		[Description("Maim On Hit % With At Least 3 Stacks Of Corrupted Blood")]
		MaimOnHitPctWithAtLeast3StacksOfCorruptedBlood = 3921,

		[Description("Monster Can Spawn With Talisman")]
		MonsterCanSpawnWithTalisman = 3922,

		[Description("Monster Explodes On Death Text")]
		MonsterExplodesOnDeathText = 3923,

		[Description("Number Of Active Wolves")]
		NumberOfActiveWolves = 3924,

		[Description("Active Skill Area Of Effect +% Final")]
		ActiveSkillAreaOfEffectPosPctFinal = 3925,

		[Description("Cold Damage +% Per 1% Block Chance")]
		ColdDamagePosPctPer1PctBlockChance = 3926,

		[Description("Maximum Mana +% Per 2% Spell Block Chance")]
		MaximumManaPosPctPer2PctSpellBlockChance = 3927,

		[Description("Physical Damage Reduction Rating +% While Chilled Or Frozen")]
		PhysicalDamageReductionRatingPosPctWhileChilledOrFrozen = 3928,

		[Description("Support Reduced Duration Damage +% Final")]
		SupportReducedDurationDamagePosPctFinal = 3929,

		[Description("Map Players Action Speed +% While Chilled")]
		MapPlayersActionSpeedPosPctWhileChilled = 3930,

		[Description("Action Speed +% While Chilled")]
		ActionSpeedPosPctWhileChilled = 3931,

		[Description("Extra Gore Chance Override %")]
		ExtraGoreChanceOverridePct = 3932,

		[Description("Siphon Base Chaos Damage To Deal Per Minute")]
		SiphonBaseChaosDamageToDealPerMinute = 3933,

		[Description("Blade Vortex Buff Range")]
		BladeVortexBuffRange = 3934,

		[Description("Spell And Attack Minimum Added Cold Damage")]
		SpellAndAttackMinimumAddedColdDamage = 3935,

		[Description("Spell And Attack Maximum Added Cold Damage")]
		SpellAndAttackMaximumAddedColdDamage = 3936,

		[Description("Reduce Enemy Cold Resistance With Weapons %")]
		ReduceEnemyColdResistanceWithWeaponsPct = 3937,

		[Description("Reduce Enemy Fire Resistance With Weapons %")]
		ReduceEnemyFireResistanceWithWeaponsPct = 3938,

		[Description("Reduce Enemy Lightning Resistance With Weapons %")]
		ReduceEnemyLightningResistanceWithWeaponsPct = 3939,

		[Description("Reduce Enemy Chaos Resistance With Weapons %")]
		ReduceEnemyChaosResistanceWithWeaponsPct = 3940,

		[Description("Support Minefield Mine Damage +% Final")]
		SupportMinefieldMineDamagePosPctFinal = 3941,

		[Description("Modifiers To Map Item Drop Quantity Also Apply To Map Item Drop Rarity")]
		ModifiersToMapItemDropQuantityAlsoApplyToMapItemDropRarity = 3942,

		[Description("Map Monster Drop Higher Level Gear")]
		MapMonsterDropHigherLevelGear = 3943,

		[Description("Support Gem Elemental Damage +% Final")]
		SupportGemElementalDamagePosPctFinal = 3944,

		[Description("Keystone Elemental Overload Damage +% Final")]
		KeystoneElementalOverloadDamagePosPctFinal = 3945,

		[Description("Keystone Elemental Overload")]
		KeystoneElementalOverload = 3946,

		[Description("Local Smoke Ground On Flask Use Radius")]
		LocalSmokeGroundOnFlaskUseRadius = 3947,

		[Description("Local Consecrate Ground On Flask Use Radius")]
		LocalConsecrateGroundOnFlaskUseRadius = 3948,

		[Description("Gain Onslaught During Flask Effect")]
		GainOnslaughtDuringFlaskEffect = 3949,

		[Description("Cast Linked Curses On Curse")]
		CastLinkedCursesOnCurse = 3950,

		[Description("Reduce Enemy Elemental Resistance With Weapons %")]
		ReduceEnemyElementalResistanceWithWeaponsPct = 3951,

		[Description("% Chance To Gain Frenzy Charge On Trap Triggered By An Enemy")]
		Pctchancetogainfrenzychargeontraptriggeredbyanenemy = 3952,

		[Description("% Chance To Gain Endurance Charge On Trap Triggered By An Enemy")]
		Pctchancetogainendurancechargeontraptriggeredbyanenemy = 3953,

		[Description("Local Number Of Bloodworms To Spawn On Flask Use")]
		LocalNumberOfBloodwormsToSpawnOnFlaskUse = 3954,

		[Description("Add Power Charge On Hit %")]
		AddPowerChargeOnHitPct = 3955,

		[Description("Lose All Power Charges On Reaching Maximum Power Charges")]
		LoseAllPowerChargesOnReachingMaximumPowerCharges = 3956,

		[Description("Shocked For 4 Seconds On Reaching Maximum Power Charges")]
		ShockedFor4SecondsOnReachingMaximumPowerCharges = 3957,

		[Description("Local Display Molten Burst On Melee Hit %")]
		LocalDisplayMoltenBurstOnMeleeHitPct = 3958,
		[Description("Max Frost Nova Stacks")] MaxFrostNovaStacks = 3959,

		[Description("Current Frost Nova Stacks")]
		CurrentFrostNovaStacks = 3960,

		[Description("Reverse Projectile Spread")]
		ReverseProjectileSpread = 3961,

		[Description("Base Cold Damage +% Per Frost Nova Stack")]
		BaseColdDamagePosPctPerFrostNovaStack = 3962,

		[Description("Frost Nova Cold Damage +% Per Frost Nova Stack")]
		FrostNovaColdDamagePosPctPerFrostNovaStack = 3963,
		[Description("Is Petrified")] IsPetrified = 3964,
		[Description("Cast On Melee Hit %")] CastOnMeleeHitPct = 3965,

		[Description("Izaro Curse On Hit Level Temporal Chains")]
		IzaroCurseOnHitLevelTemporalChains = 3966,

		[Description("Izaro Curse On Hit Level Elemental Weakness")]
		IzaroCurseOnHitLevelElementalWeakness = 3967,

		[Description("Izaro Curse On Hit Level Vulnerability")]
		IzaroCurseOnHitLevelVulnerability = 3968,

		[Description("Labyrinth Trinket Instantly Kill Next Pylon")]
		LabyrinthTrinketInstantlyKillNextPylon = 3969,

		[Description("Labyrinth Trinket Instantly Kill Next Lieutenant")]
		LabyrinthTrinketInstantlyKillNextLieutenant = 3970,

		[Description("Labyrinth Trinket Instantly Kill Next Elemental")]
		LabyrinthTrinketInstantlyKillNextElemental = 3971,

		[Description("Labyrinth Trinket Instantly Kill Next Gargoyle")]
		LabyrinthTrinketInstantlyKillNextGargoyle = 3972,

		[Description("Labyrinth Trinket Permanently Disable Next Statue")]
		LabyrinthTrinketPermanentlyDisableNextStatue = 3973,

		[Description("Labyrinth Trinket Permanently Disable Next Symbol")]
		LabyrinthTrinketPermanentlyDisableNextSymbol = 3974,

		[Description("Labyrinth Trinket Reactivate Next Charge Disruptor After 5 Seconds")]
		LabyrinthTrinketReactivateNextChargeDisruptorAfter5Seconds = 3975,

		[Description("Add Endurance Charge On Gain Power Charge %")]
		AddEnduranceChargeOnGainPowerChargePct = 3976,

		[Description("Stacking Damage +% On Kill For 4 Seconds")]
		StackingDamagePosPctOnKillFor4Seconds = 3977,

		[Description("Grant Owner Stacking Damage +% On Kill For 4 Seconds")]
		GrantOwnerStackingDamagePosPctOnKillFor4Seconds = 3978,

		[Description("Attack And Cast Speed +% While Totem Active")]
		AttackAndCastSpeedPosPctWhileTotemActive = 3979,

		[Description("Number Of Additional Totems Allowed On Kill For 8 Seconds")]
		NumberOfAdditionalTotemsAllowedOnKillFor8Seconds = 3980,

		[Description("Owner Number Of Additional Totems Allowed On Kill For 8 Seconds")]
		OwnerNumberOfAdditionalTotemsAllowedOnKillFor8Seconds = 3981,

		[Description("Map Monsters Base Self Critical Strike Multiplier -%")]
		MapMonstersBaseSelfCriticalStrikeMultiplierNegPct = 3982,

		[Description("Local Flask Is Petrified")]
		LocalFlaskIsPetrified = 3983,

		[Description("Hierophant Helmet Supported By Elemental Penetration")]
		HierophantHelmetSupportedByElementalPenetration = 3984,

		[Description("Hierophant Gloves Supported By Increased Area Of Effect")]
		HierophantGlovesSupportedByIncreasedAreaOfEffect = 3985,

		[Description("Hierophant Boots Supported By Life Leech")]
		HierophantBootsSupportedByLifeLeech = 3986,

		[Description("Power Frenzy Or Endurance Charge On Kill %")]
		PowerFrenzyOrEnduranceChargeOnKillPct = 3987,
		[Description("Local Flask Effect +%")] LocalFlaskEffectPosPct = 3988,

		[Description("Local Flask Poison Immunity During Flask Effect")]
		LocalFlaskPoisonImmunityDuringFlaskEffect = 3989,
		[Description("Immune To Poison")] ImmuneToPoison = 3990,

		[Description("Local Flask Additional Physical Damage Reduction %")]
		LocalFlaskAdditionalPhysicalDamageReductionPct = 3991,

		[Description("Unique Spread Poison To Nearby Allies As 200 Life Regeneration Per Second On Kill")]
		UniqueSpreadPoisonToNearbyAlliesAs200LifeRegenerationPerSecondOnKill = 3992,

		[Description("Support Pierce Projectile Damage +% Final")]
		SupportPierceProjectileDamagePosPctFinal = 3993,

		[Description("Elementalist Damage With An Element +% For 4 Seconds After Being Hit By An Element")]
		ElementalistDamageWithAnElementPosPctFor4SecondsAfterBeingHitByAnElement = 3994,

		[Description("Elementalist Elemental Damage +% For 4 Seconds Every 10 Seconds")]
		ElementalistElementalDamagePosPctFor4SecondsEvery10Seconds = 3995,

		[Description("Elementalist Cold Penetration % For 4 Seconds On Using Fire Skill")]
		ElementalistColdPenetrationPctFor4SecondsOnUsingFireSkill = 3996,

		[Description("Elementalist Lightning Penetration % For 4 Seconds On Using Cold Skill")]
		ElementalistLightningPenetrationPctFor4SecondsOnUsingColdSkill = 3997,

		[Description("Elementalist Fire Penetration % For 4 Seconds On Using Lightning Skill")]
		ElementalistFirePenetrationPctFor4SecondsOnUsingLightningSkill = 3998,

		[Description("Elementalist Summon Elemental Golem On Killing Enemy With Element %")]
		ElementalistSummonElementalGolemOnKillingEnemyWithElementPct = 3999,

		[Description("Elementalist All Damage Causes Chill Shock And Ignite For 4 Seconds On Kill %")]
		ElementalistAllDamageCausesChillShockAndIgniteFor4SecondsOnKillPct = 4000,

		[Description("Elementalist Elemental Status Effect Aura Radius")]
		ElementalistElementalStatusEffectAuraRadius = 4001,

		[Description("Elementalist Elemental Damage Rotation")]
		ElementalistElementalDamageRotation = 4002,

		[Description("Virtual Elemental Status Effect Aura Radius")]
		VirtualElementalStatusEffectAuraRadius = 4003,

		[Description("All Damage Can Chill Ignite Shock")]
		AllDamageCanChillIgniteShock = 4004,
		[Description("Is Blighted")] IsBlighted = 4005,

		[Description("Virtual Life Leech Permyriad On Crit")]
		VirtualLifeLeechPermyriadOnCrit = 4006,

		[Description("Occultist Gain % Of Non Chaos Damage As Chaos Damage Per Curse On Target On Kill For 4 Seconds")]
		OccultistGainPctOfNonChaosDamageAsChaosDamagePerCurseOnTargetOnKillFor4Seconds = 4007,

		[Description("Occultist Energy Shield Always Recovers For 4 Seconds After Starting Recovery")]
		OccultistEnergyShieldAlwaysRecoversFor4SecondsAfterStartingRecovery = 4008,

		[Description("Occultist Stun Threshold Is Based On Energy Shield Instead Of Life")]
		OccultistStunThresholdIsBasedOnEnergyShieldInsteadOfLife = 4009,
		[Description("Is Counterattack")] IsCounterattack = 4010,

		[Description("Knockback On Counterattack %")]
		KnockbackOnCounterattackPct = 4011,

		[Description("Local Flask Chilled Ground On Flask Use Radius")]
		LocalFlaskChilledGroundOnFlaskUseRadius = 4012,

		[Description("Local Flask Duration +%")]
		LocalFlaskDurationPosPct = 4013,

		[Description("Max Charged Attack Stacks")]
		MaxChargedAttackStacks = 4014,

		[Description("Current Charged Attack Stacks")]
		CurrentChargedAttackStacks = 4015,

		[Description("Local Display Socketed Curse Gems Supported By Level X Blasphemy")]
		LocalDisplaySocketedCurseGemsSupportedByLevelXBlasphemy = 4016,

		[Description("Chill On You Proliferates To Nearby Enemies Within X Radius")]
		ChillOnYouProliferatesToNearbyEnemiesWithinXRadius = 4017,

		[Description("Freeze On You Proliferates To Nearby Enemies Within X Radius")]
		FreezeOnYouProliferatesToNearbyEnemiesWithinXRadius = 4018,

		[Description("Animate Weapon Damage +%")]
		AnimateWeaponDamagePosPct = 4019,

		[Description("Burning Arrow Damage +%")]
		BurningArrowDamagePosPct = 4020,
		[Description("Cleave Damage +%")] CleaveDamagePosPct = 4021,

		[Description("Double Strike Damage +%")]
		DoubleStrikeDamagePosPct = 4022,
		[Description("Dual Strike Damage +%")] DualStrikeDamagePosPct = 4023,
		[Description("Fire Trap Damage +%")] FireTrapDamagePosPct = 4024,
		[Description("Fireball Damage +%")] FireballDamagePosPct = 4025,

		[Description("Freezing Pulse Damage +%")]
		FreezingPulseDamagePosPct = 4026,

		[Description("Glacial Hammer Damage +%")]
		GlacialHammerDamagePosPct = 4027,
		[Description("Ground Slam Damage +%")] GroundSlamDamagePosPct = 4028,

		[Description("Heavy Strike Damage +%")]
		HeavyStrikeDamagePosPct = 4029,

		[Description("Infernal Blow Damage +%")]
		InfernalBlowDamagePosPct = 4030,

		[Description("Lightning Strike Damage +%")]
		LightningStrikeDamagePosPct = 4031,

		[Description("Lightning Tendrils Damage +%")]
		LightningTendrilsDamagePosPct = 4032,
		[Description("Magma Orb Damage +%")] MagmaOrbDamagePosPct = 4033,

		[Description("Molten Strike Damage +%")]
		MoltenStrikeDamagePosPct = 4034,
		[Description("Zombie Damage +%")] ZombieDamagePosPct = 4035,
		[Description("Reave Damage +%")] ReaveDamagePosPct = 4036,
		[Description("Spark Damage +%")] SparkDamagePosPct = 4037,

		[Description("Spectral Throw Damage +%")]
		SpectralThrowDamagePosPct = 4038,
		[Description("Split Arrow Damage +%")] SplitArrowDamagePosPct = 4039,

		[Description("Ethereal Knives Damage +%")]
		EtherealKnivesDamagePosPct = 4040,
		[Description("Ice Shot Damage +%")] IceShotDamagePosPct = 4041,

		[Description("Rain Of Arrows Damage +%")]
		RainOfArrowsDamagePosPct = 4042,

		[Description("Raging Spirit Damage +%")]
		RagingSpiritDamagePosPct = 4043,

		[Description("Viper Strike Damage +%")]
		ViperStrikeDamagePosPct = 4044,

		[Description("Flicker Strike Damage +%")]
		FlickerStrikeDamagePosPct = 4045,
		[Description("Leap Slam Damage +%")] LeapSlamDamagePosPct = 4046,

		[Description("Lightning Arrow Damage +%")]
		LightningArrowDamagePosPct = 4047,

		[Description("Lightning Warp Damage +%")]
		LightningWarpDamagePosPct = 4048,
		[Description("Puncture Damage +%")] PunctureDamagePosPct = 4049,

		[Description("Shield Charge Damage +%")]
		ShieldChargeDamagePosPct = 4050,
		[Description("Skeletons Damage +%")] SkeletonsDamagePosPct = 4051,
		[Description("Arc Damage +%")] ArcDamagePosPct = 4052,
		[Description("Barrage Damage +%")] BarrageDamagePosPct = 4053,

		[Description("Fire Nova Mine Damage +%")]
		FireNovaMineDamagePosPct = 4054,
		[Description("Fire Storm Damage +%")] FireStormDamagePosPct = 4055,
		[Description("Flame Surge Damage +%")] FlameSurgeDamagePosPct = 4056,
		[Description("Ice Nova Damage +%")] IceNovaDamagePosPct = 4057,
		[Description("Ice Spear Damage +%")] IceSpearDamagePosPct = 4058,
		[Description("Incinerate Damage +%")] IncinerateDamagePosPct = 4059,

		[Description("Power Siphon Damage +%")]
		PowerSiphonDamagePosPct = 4060,

		[Description("Searing Bond Damage +%")]
		SearingBondDamagePosPct = 4061,

		[Description("Static Strike Damage +%")]
		StaticStrikeDamagePosPct = 4062,
		[Description("Storm Call Damage +%")] StormCallDamagePosPct = 4063,
		[Description("Sweep Damage +%")] SweepDamagePosPct = 4064,
		[Description("Frenzy Damage +%")] FrenzyDamagePosPct = 4065,

		[Description("Righteous Fire Damage +%")]
		RighteousFireDamagePosPct = 4066,

		[Description("Elemental Hit Damage +%")]
		ElementalHitDamagePosPct = 4067,
		[Description("Cyclone Damage +%")] CycloneDamagePosPct = 4068,

		[Description("Tornado Shot Damage +%")]
		TornadoShotDamagePosPct = 4069,

		[Description("Arctic Breath Damage +%")]
		ArcticBreathDamagePosPct = 4070,

		[Description("Explosive Arrow Damage +%")]
		ExplosiveArrowDamagePosPct = 4071,
		[Description("Flameblast Damage +%")] FlameblastDamagePosPct = 4072,

		[Description("Glacial Cascade Damage +%")]
		GlacialCascadeDamagePosPct = 4073,
		[Description("Ice Crash Damage +%")] IceCrashDamagePosPct = 4074,

		[Description("Kinetic Blast Damage +%")]
		KineticBlastDamagePosPct = 4075,
		[Description("Shock Nova Damage +%")] ShockNovaDamagePosPct = 4076,

		[Description("Shockwave Totem Damage +%")]
		ShockwaveTotemDamagePosPct = 4077,
		[Description("Wild Strike Damage +%")] WildStrikeDamagePosPct = 4078,

		[Description("Detonate Dead Damage +%")]
		DetonateDeadDamagePosPct = 4079,

		[Description("Caustic Arrow Damage +%")]
		CausticArrowDamagePosPct = 4080,
		[Description("Chaos Golem Damage +%")] ChaosGolemDamagePosPct = 4081,
		[Description("Flame Golem Damage +%")] FlameGolemDamagePosPct = 4082,
		[Description("Ice Golem Damage +%")] IceGolemDamagePosPct = 4083,
		[Description("Cold Snap Damage +%")] ColdSnapDamagePosPct = 4084,
		[Description("Flame Totem Damage +%")] FlameTotemDamagePosPct = 4085,

		[Description("Animate Guardian Damage +%")]
		AnimateGuardianDamagePosPct = 4086,
		[Description("Bear Trap Damage +%")] BearTrapDamagePosPct = 4087,
		[Description("Frost Wall Damage +%")] FrostWallDamagePosPct = 4088,

		[Description("Molten Shell Damage +%")]
		MoltenShellDamagePosPct = 4089,
		[Description("Reckoning Damage +%")] ReckoningDamagePosPct = 4090,

		[Description("Vigilant Strike Damage +%")]
		VigilantStrikeDamagePosPct = 4091,

		[Description("Whirling Blades Damage +%")]
		WhirlingBladesDamagePosPct = 4092,
		[Description("Flame Dash Damage +%")] FlameDashDamagePosPct = 4093,
		[Description("Freeze Mine Damage +%")] FreezeMineDamagePosPct = 4094,

		[Description("Herald Of Ash Damage +%")]
		HeraldOfAshDamagePosPct = 4095,

		[Description("Herald Of Ice Damage +%")]
		HeraldOfIceDamagePosPct = 4096,

		[Description("Herald Of Thunder Damage +%")]
		HeraldOfThunderDamagePosPct = 4097,

		[Description("Tempest Shield Damage +%")]
		TempestShieldDamagePosPct = 4098,
		[Description("Desecrate Damage +%")] DesecrateDamagePosPct = 4099,

		[Description("Blink Arrow And Blink Arrow Clone Damage +%")]
		BlinkArrowAndBlinkArrowCloneDamagePosPct = 4100,

		[Description("Mirror Arrow And Mirror Arrow Clone Damage +%")]
		MirrorArrowAndMirrorArrowCloneDamagePosPct = 4101,
		[Description("Riposte Damage +%")] RiposteDamagePosPct = 4102,
		[Description("Vengeance Damage +%")] VengeanceDamagePosPct = 4103,

		[Description("Converted Enemies Damage +%")]
		ConvertedEnemiesDamagePosPct = 4104,
		[Description("Abyssal Cry Damage +%")] AbyssalCryDamagePosPct = 4105,

		[Description("Shrapnel Shot Damage +%")]
		ShrapnelShotDamagePosPct = 4106,
		[Description("Blast Rain Damage +%")] BlastRainDamagePosPct = 4107,

		[Description("Essence Drain Damage +%")]
		EssenceDrainDamagePosPct = 4108,
		[Description("Contagion Damage +%")] ContagionDamagePosPct = 4109,

		[Description("Blade Vortex Damage +%")]
		BladeVortexDamagePosPct = 4110,
		[Description("Bladefall Damage +%")] BladefallDamagePosPct = 4111,
		[Description("Ice Trap Damage +%")] IceTrapDamagePosPct = 4112,
		[Description("Earthquake Damage +%")] EarthquakeDamagePosPct = 4113,
		[Description("Stone Golem Damage +%")] StoneGolemDamagePosPct = 4114,
		[Description("Frost Bomb Damage +%")] FrostBombDamagePosPct = 4115,

		[Description("Orb Of Storms Damage +%")]
		OrbOfStormsDamagePosPct = 4116,

		[Description("Siege Ballista Damage +%")]
		SiegeBallistaDamagePosPct = 4117,
		[Description("Blight Damage +%")] BlightDamagePosPct = 4118,

		[Description("Shockwave Slam Damage +%")]
		ShockwaveSlamDamagePosPct = 4119,
		[Description("Fire Beam Damage +%")] FireBeamDamagePosPct = 4120,

		[Description("Life Regeneration Per Minute % While Frozen")]
		LifeRegenerationPerMinutePctWhileFrozen = 4121,

		[Description("Occultist Stacking Energy Shield Regeneration Rate Per Minute % On Kill For 4 Seconds")]
		OccultistStackingEnergyShieldRegenerationRatePerMinutePctOnKillFor4Seconds = 4122,

		[Description("Occultist Immune To Stun While Has Energy Shield")]
		OccultistImmuneToStunWhileHasEnergyShield = 4123,

		[Description("Totem Damage +% Final Per Active Totem")]
		TotemDamagePosPctFinalPerActiveTotem = 4124,
		[Description("Totem Damage +% Final")] TotemDamagePosPctFinal = 4125,

		[Description("Cannot Be Affected By Flasks")]
		CannotBeAffectedByFlasks = 4126,

		[Description("Flasks Apply To Your Zombies And Spectres")]
		FlasksApplyToYourZombiesAndSpectres = 4127,

		[Description("Modifiers To Minion Damage Also Affect You")]
		ModifiersToMinionDamageAlsoAffectYou = 4128,

		[Description("Additive Modifiers To Minion Attack Speed Also Affect You")]
		AdditiveModifiersToMinionAttackSpeedAlsoAffectYou = 4129,

		[Description("Modifiers To Minion Cast Speed Also Affect You")]
		ModifiersToMinionCastSpeedAlsoAffectYou = 4130,

		[Description("Modifiers To Minion Life Regeneration Also Affect You")]
		ModifiersToMinionLifeRegenerationAlsoAffectYou = 4131,

		[Description("Modifiers To Minion Movement Speed Also Affect You")]
		ModifiersToMinionMovementSpeedAlsoAffectYou = 4132,

		[Description("Modifiers To Minion Resistances Also Affect You")]
		ModifiersToMinionResistancesAlsoAffectYou = 4133,
		[Description("Cast On Gain Skill")] CastOnGainSkill = 4134,

		[Description("Base Lightning Damage Taken Per Second")]
		BaseLightningDamageTakenPerSecond = 4135,
		[Description("Current Izaro Charges")] CurrentIzaroCharges = 4136,

		[Description("Attack Speed +% Per Izaro Charge")]
		AttackSpeedPosPctPerIzaroCharge = 4137,

		[Description("Cast Speed +% Per Izaro Charge")]
		CastSpeedPosPctPerIzaroCharge = 4138,

		[Description("Damage +% Per Izaro Charge Final")]
		DamagePosPctPerIzaroChargeFinal = 4139,

		[Description("Physical Damage Reduction % Per Izaro Charge")]
		PhysicalDamageReductionPctPerIzaroCharge = 4140,

		[Description("Resist All Elements % Per Izaro Charge")]
		ResistAllElementsPctPerIzaroCharge = 4141,

		[Description("Critical Strike Chance +% Per Izaro Charge")]
		CriticalStrikeChancePosPctPerIzaroCharge = 4142,

		[Description("Shield Charge Scaling Stun Threshold Reduction +% At Maximum Range")]
		ShieldChargeScalingStunThresholdReductionPosPctAtMaximumRange = 4143,

		[Description("Map Spawn Perandus Chests")]
		MapSpawnPerandusChests = 4144,

		[Description("Set User Life To 1 On Skill Use")]
		SetUserLifeTo1OnSkillUse = 4145,

		[Description("Grant Izaro Buff On Skill Use")]
		GrantIzaroBuffOnSkillUse = 4146,

		[Description("Local Double Damage To Chilled Enemies")]
		LocalDoubleDamageToChilledEnemies = 4147,

		[Description("Main Hand Double Damage To Chilled Enemies")]
		MainHandDoubleDamageToChilledEnemies = 4148,

		[Description("Off Hand Double Damage To Chilled Enemies")]
		OffHandDoubleDamageToChilledEnemies = 4149,

		[Description("Global Number Of Times Damage Is Doubled")]
		GlobalNumberOfTimesDamageIsDoubled = 4150,

		[Description("Main Hand Number Of Times Damage Is Doubled")]
		MainHandNumberOfTimesDamageIsDoubled = 4151,

		[Description("Off Hand Number Of Times Damage Is Doubled")]
		OffHandNumberOfTimesDamageIsDoubled = 4152,

		[Description("Base Main Hand Number Of Times Damage Is Doubled")]
		BaseMainHandNumberOfTimesDamageIsDoubled = 4153,

		[Description("Base Off Hand Number Of Times Damage Is Doubled")]
		BaseOffHandNumberOfTimesDamageIsDoubled = 4154,

		[Description("Local Elemental Penetration %")]
		LocalElementalPenetrationPct = 4155,

		[Description("Main Hand Elemental Penetration %")]
		MainHandElementalPenetrationPct = 4156,

		[Description("Off Hand Elemental Penetration %")]
		OffHandElementalPenetrationPct = 4157,

		[Description("Damage While No Frenzy Charges +%")]
		DamageWhileNoFrenzyChargesPosPct = 4158,

		[Description("Local Flask Ghost Reaver")]
		LocalFlaskGhostReaver = 4159,

		[Description("Local Flask Zealots Oath")]
		LocalFlaskZealotsOath = 4160,

		[Description("Critical Strike Chance Against Enemies On Full Life +%")]
		CriticalStrikeChanceAgainstEnemiesOnFullLifePosPct = 4161,

		[Description("Spirit Offering Life % Added As Base Maximum Energy Shield Per Corpse Consumed")]
		SpiritOfferingLifePctAddedAsBaseMaximumEnergyShieldPerCorpseConsumed = 4162,

		[Description("Minions Deal % Of Physical Damage As Additional Chaos Damage")]
		MinionsDealPctOfPhysicalDamageAsAdditionalChaosDamage = 4163,

		[Description("Attack Critical Strike Damage Life Leech Permyriad")]
		AttackCriticalStrikeDamageLifeLeechPermyriad = 4164,

		[Description("Minion Attack Minimum Added Physical Damage")]
		MinionAttackMinimumAddedPhysicalDamage = 4165,

		[Description("Minion Attack Maximum Added Physical Damage")]
		MinionAttackMaximumAddedPhysicalDamage = 4166,

		[Description("Attack Physical Damage % To Add As Lightning")]
		AttackPhysicalDamagePctToAddAsLightning = 4167,

		[Description("Attack Physical Damage % To Add As Fire")]
		AttackPhysicalDamagePctToAddAsFire = 4168,

		[Description("Maximum Energy Shield + Per 5 Strength")]
		MaximumEnergyShieldPosPer5Strength = 4169,
		[Description("Attack Always Crit")] AttackAlwaysCrit = 4170,

		[Description("Totem Aura Enemy Damage +% Final")]
		TotemAuraEnemyDamagePosPctFinal = 4171,

		[Description("Totem Aura Enemy Fire And Physical Damage Taken +%")]
		TotemAuraEnemyFireAndPhysicalDamageTakenPosPct = 4172,

		[Description("Local Varunastra Weapon Counts As All 1h Melee Weapon Types")]
		LocalVarunastraWeaponCountsAsAll1hMeleeWeaponTypes = 4173,

		[Description("Main Hand Varunastra Weapon Counts As All 1h Melee Weapon Types")]
		MainHandVarunastraWeaponCountsAsAll1hMeleeWeaponTypes = 4174,

		[Description("Off Hand Varunastra Weapon Counts As All 1h Melee Weapon Types")]
		OffHandVarunastraWeaponCountsAsAll1hMeleeWeaponTypes = 4175,

		[Description("Guardian Warcry Grant Attack Cast And Movement Speed To You And Nearby Allies +%")]
		GuardianWarcryGrantAttackCastAndMovementSpeedToYouAndNearbyAlliesPosPct = 4176,

		[Description("Guardian Auras Grant Life Regeneration Per Minute %")]
		GuardianAurasGrantLifeRegenerationPerMinutePct = 4177,

		[Description("Guardian Nearby Enemies Cannot Gain Charges")]
		GuardianNearbyEnemiesCannotGainCharges = 4178,

		[Description("Guardian Reserved Life Granted To You And Allies As Armour %")]
		GuardianReservedLifeGrantedToYouAndAlliesAsArmourPct = 4179,

		[Description("Guardian Remove Curses And Status Ailments Every 10 Seconds")]
		GuardianRemoveCursesAndStatusAilmentsEvery10Seconds = 4180,

		[Description("Guardian Gain Life Regeneration Per Minute % For 1 Second Every 10 Seconds")]
		GuardianGainLifeRegenerationPerMinutePctFor1SecondEvery10Seconds = 4181,
		[Description("Life Reserved")] LifeReserved = 4182,
		[Description("Cannot Gain Charges")] CannotGainCharges = 4183,
		[Description("Max Izaro Charges")] MaxIzaroCharges = 4184,

		[Description("Local Display Socketed Gems Supported By Level X Fortify")]
		LocalDisplaySocketedGemsSupportedByLevelXFortify = 4185,
		[Description("Base Fire Immunity")] BaseFireImmunity = 4186,
		[Description("Totem Fire Immunity")] TotemFireImmunity = 4187,

		[Description("Base % Maximum Life Inflicted As Aoe Fire Damage When Hit")]
		BasePctMaximumLifeInflictedAsAoeFireDamageWhenHit = 4188,

		[Description("Totem % Maximum Life Inflicted As Aoe Fire Damage When Hit")]
		TotemPctMaximumLifeInflictedAsAoeFireDamageWhenHit = 4189,

		[Description("Active Skill Attack Speed +% Final Per Frenzy Charge")]
		ActiveSkillAttackSpeedPosPctFinalPerFrenzyCharge = 4190,

		[Description("Trap Damage Buildup Damage +% Final")]
		TrapDamageBuildupDamagePosPctFinal = 4191,

		[Description("Trap Damage Buildup Damage +% Final When First Set")]
		TrapDamageBuildupDamagePosPctFinalWhenFirstSet = 4192,

		[Description("Trap Damage Buildup Damage +% Final After 4 Seconds")]
		TrapDamageBuildupDamagePosPctFinalAfter4Seconds = 4193,

		[Description("Local Display Grants Level X Summon Stone Golem")]
		LocalDisplayGrantsLevelXSummonStoneGolem = 4194,

		[Description("Global Total Minimum Added Physical Damage")]
		GlobalTotalMinimumAddedPhysicalDamage = 4195,

		[Description("Global Total Maximum Added Physical Damage")]
		GlobalTotalMaximumAddedPhysicalDamage = 4196,

		[Description("Local Flask Immune To Damage")]
		LocalFlaskImmuneToDamage = 4197,

		[Description("Local Weapon Always Crit")]
		LocalWeaponAlwaysCrit = 4198,

		[Description("Main Hand Weapon Always Crit")]
		MainHandWeaponAlwaysCrit = 4199,

		[Description("Off Hand Weapon Always Crit")]
		OffHandWeaponAlwaysCrit = 4200,

		[Description("Trap And Mine Minimum Added Physical Damage")]
		TrapAndMineMinimumAddedPhysicalDamage = 4201,

		[Description("Trap And Mine Maximum Added Physical Damage")]
		TrapAndMineMaximumAddedPhysicalDamage = 4202,

		[Description("Trap % Chance To Trigger Twice")]
		TrapPctChanceToTriggerTwice = 4203,
		[Description("Trap Has Triggered")] TrapHasTriggered = 4204,

		[Description("Physical Damage Over Time Per 10 Dexterity +%")]
		PhysicalDamageOverTimePer10DexterityPosPct = 4205,

		[Description("Bleed Duration Per 12 Intelligence +%")]
		BleedDurationPer12IntelligencePosPct = 4206,

		[Description("% Chance To Cause Bleeding Enemies To Flee On Hit")]
		Pctchancetocausebleedingenemiestofleeonhit = 4207,

		[Description("Labyrinth Trinket Permanently Disable Statue Healing")]
		LabyrinthTrinketPermanentlyDisableStatueHealing = 4208,

		[Description("Labyrinth Trinket Instantly Kill Next Pedestal")]
		LabyrinthTrinketInstantlyKillNextPedestal = 4209,

		[Description("Labyrinth Trinket Instantly Kill Next Portal")]
		LabyrinthTrinketInstantlyKillNextPortal = 4210,

		[Description("Number Of Perandus Coin Stacks To Drop")]
		NumberOfPerandusCoinStacksToDrop = 4211,

		[Description("Melee Ancestor Totem Grant Owner Attack Speed +% Final")]
		MeleeAncestorTotemGrantOwnerAttackSpeedPosPctFinal = 4212,

		[Description("Gain Cannot Be Stunned Aura For 4 Seconds On Block Radius")]
		GainCannotBeStunnedAuraFor4SecondsOnBlockRadius = 4213,
		[Description("Cleave Radius +%")] CleaveRadiusPosPct = 4214,
		[Description("Ground Slam Radius +%")] GroundSlamRadiusPosPct = 4215,

		[Description("Infernal Blow Radius +%")]
		InfernalBlowRadiusPosPct = 4216,

		[Description("Lightning Tendrils Radius +%")]
		LightningTendrilsRadiusPosPct = 4217,
		[Description("Magma Orb Radius +%")] MagmaOrbRadiusPosPct = 4218,
		[Description("Reave Radius +%")] ReaveRadiusPosPct = 4219,

		[Description("Molten Strike Radius +%")]
		MoltenStrikeRadiusPosPct = 4220,
		[Description("Ice Shot Radius +%")] IceShotRadiusPosPct = 4221,

		[Description("Rain Of Arrows Radius +%")]
		RainOfArrowsRadiusPosPct = 4222,
		[Description("Leap Slam Radius +%")] LeapSlamRadiusPosPct = 4223,

		[Description("Lightning Arrow Radius +%")]
		LightningArrowRadiusPosPct = 4224,
		[Description("Ice Nova Radius +%")] IceNovaRadiusPosPct = 4225,

		[Description("Static Strike Radius +%")]
		StaticStrikeRadiusPosPct = 4226,
		[Description("Storm Call Radius +%")] StormCallRadiusPosPct = 4227,
		[Description("Sweep Radius +%")] SweepRadiusPosPct = 4228,

		[Description("Righteous Fire Radius +%")]
		RighteousFireRadiusPosPct = 4229,

		[Description("Arctic Breath Radius +%")]
		ArcticBreathRadiusPosPct = 4230,

		[Description("Ball Lightning Radius +%")]
		BallLightningRadiusPosPct = 4231,

		[Description("Explosive Arrow Radius +%")]
		ExplosiveArrowRadiusPosPct = 4232,
		[Description("Flameblast Radius +%")] FlameblastRadiusPosPct = 4233,

		[Description("Glacial Cascade Radius +%")]
		GlacialCascadeRadiusPosPct = 4234,
		[Description("Wild Strike Radius +%")] WildStrikeRadiusPosPct = 4235,

		[Description("Detonate Dead Radius +%")]
		DetonateDeadRadiusPosPct = 4236,
		[Description("Ice Crash Radius +%")] IceCrashRadiusPosPct = 4237,

		[Description("Kinetic Blast Radius +%")]
		KineticBlastRadiusPosPct = 4238,

		[Description("Caustic Arrow Radius +%")]
		CausticArrowRadiusPosPct = 4239,
		[Description("Cold Snap Radius +%")] ColdSnapRadiusPosPct = 4240,
		[Description("Decoy Totem Radius +%")] DecoyTotemRadiusPosPct = 4241,
		[Description("Shock Nova Radius +%")] ShockNovaRadiusPosPct = 4242,

		[Description("Shockwave Totem Radius +%")]
		ShockwaveTotemRadiusPosPct = 4243,

		[Description("Cleave Attack Speed +%")]
		CleaveAttackSpeedPosPct = 4244,

		[Description("Double Strike Attack Speed +%")]
		DoubleStrikeAttackSpeedPosPct = 4245,

		[Description("Dual Strike Attack Speed +%")]
		DualStrikeAttackSpeedPosPct = 4246,

		[Description("Heavy Strike Attack Speed +%")]
		HeavyStrikeAttackSpeedPosPct = 4247,

		[Description("Zombie Attack Speed +%")]
		ZombieAttackSpeedPosPct = 4248,

		[Description("Rain Of Arrows Attack Speed +%")]
		RainOfArrowsAttackSpeedPosPct = 4249,

		[Description("Leap Slam Attack Speed +%")]
		LeapSlamAttackSpeedPosPct = 4250,

		[Description("Shield Charge Attack Speed +%")]
		ShieldChargeAttackSpeedPosPct = 4251,

		[Description("Barrage Attack Speed +%")]
		BarrageAttackSpeedPosPct = 4252,

		[Description("Elemental Hit Attack Speed +%")]
		ElementalHitAttackSpeedPosPct = 4253,

		[Description("Cyclone Attack Speed +%")]
		CycloneAttackSpeedPosPct = 4254,

		[Description("Power Siphon Attack Speed +%")]
		PowerSiphonAttackSpeedPosPct = 4255,

		[Description("Spectre Attack And Cast Speed +%")]
		SpectreAttackAndCastSpeedPosPct = 4256,

		[Description("Freezing Pulse Cast Speed +%")]
		FreezingPulseCastSpeedPosPct = 4257,

		[Description("Fireball Cast Speed +%")]
		FireballCastSpeedPosPct = 4258,

		[Description("Fire Nova Mine Cast Speed +%")]
		FireNovaMineCastSpeedPosPct = 4259,

		[Description("Lightning Warp Cast Speed +%")]
		LightningWarpCastSpeedPosPct = 4260,

		[Description("Fire Trap Cooldown Speed +%")]
		FireTrapCooldownSpeedPosPct = 4261,

		[Description("Flicker Strike Cooldown Speed +%")]
		FlickerStrikeCooldownSpeedPosPct = 4262,

		[Description("Cold Snap Cooldown Speed +%")]
		ColdSnapCooldownSpeedPosPct = 4263,

		[Description("Ball Lightning Projectile Speed +%")]
		BallLightningProjectileSpeedPosPct = 4264,

		[Description("Freezing Pulse Projectile Speed +%")]
		FreezingPulseProjectileSpeedPosPct = 4265,

		[Description("Spark Projectile Speed +%")]
		SparkProjectileSpeedPosPct = 4266,

		[Description("Spectral Throw Projectile Speed +%")]
		SpectralThrowProjectileSpeedPosPct = 4267,

		[Description("Ethereal Knives Projectile Speed +%")]
		EtherealKnivesProjectileSpeedPosPct = 4268,

		[Description("Flame Totem Projectile Speed +%")]
		FlameTotemProjectileSpeedPosPct = 4269,

		[Description("Incinerate Projectile Speed +%")]
		IncinerateProjectileSpeedPosPct = 4270,

		[Description("Dominating Blow Duration +%")]
		DominatingBlowDurationPosPct = 4271,
		[Description("Puncture Duration +%")] PunctureDurationPosPct = 4272,

		[Description("Viper Strike Poison Duration +%")]
		ViperStrikePoisonDurationPosPct = 4273,
		[Description("Firestorm Duration +%")] FirestormDurationPosPct = 4274,

		[Description("Static Strike Duration +%")]
		StaticStrikeDurationPosPct = 4275,

		[Description("Storm Call Duration +%")]
		StormCallDurationPosPct = 4276,

		[Description("Arctic Breath Duration +%")]
		ArcticBreathDurationPosPct = 4277,

		[Description("Lightning Warp Duration +%")]
		LightningWarpDurationPosPct = 4278,
		[Description("Ice Shot Duration +%")] IceShotDurationPosPct = 4279,

		[Description("Caustic Arrow Duration +%")]
		CausticArrowDurationPosPct = 4280,

		[Description("Double Strike Critical Strike Chance +%")]
		DoubleStrikeCriticalStrikeChancePosPct = 4281,

		[Description("Dual Strike Critical Strike Chance +%")]
		DualStrikeCriticalStrikeChancePosPct = 4282,

		[Description("Split Arrow Critical Strike Chance +%")]
		SplitArrowCriticalStrikeChancePosPct = 4283,

		[Description("Viper Strike Critical Strike Chance +%")]
		ViperStrikeCriticalStrikeChancePosPct = 4284,

		[Description("Flameblast Critical Strike Chance +%")]
		FlameblastCriticalStrikeChancePosPct = 4285,

		[Description("Flame Surge Critical Strike Chance +%")]
		FlameSurgeCriticalStrikeChancePosPct = 4286,

		[Description("Tornado Shot Critical Strike Chance +%")]
		TornadoShotCriticalStrikeChancePosPct = 4287,

		[Description("Lightning Strike Num Of Additional Projectiles")]
		LightningStrikeNumOfAdditionalProjectiles = 4288,

		[Description("Molten Strike Num Of Additional Projectiles")]
		MoltenStrikeNumOfAdditionalProjectiles = 4289,

		[Description("Spark Num Of Additional Projectiles")]
		SparkNumOfAdditionalProjectiles = 4290,

		[Description("Split Arrow Num Of Additional Projectiles")]
		SplitArrowNumOfAdditionalProjectiles = 4291,

		[Description("Barrage Num Of Additional Projectiles")]
		BarrageNumOfAdditionalProjectiles = 4292,

		[Description("Tornado Shot Num Of Secondary Projectiles")]
		TornadoShotNumOfSecondaryProjectiles = 4293,

		[Description("Magma Orb Num Of Additional Projectiles In Chain")]
		MagmaOrbNumOfAdditionalProjectilesInChain = 4294,

		[Description("Arc Num Of Additional Projectiles In Chain")]
		ArcNumOfAdditionalProjectilesInChain = 4295,

		[Description("Flame Totem Num Of Additional Projectiles")]
		FlameTotemNumOfAdditionalProjectiles = 4296,

		[Description("Burning Arrow Ignite Chance %")]
		BurningArrowIgniteChancePct = 4297,

		[Description("Burning Arrow Physical Damage % To Add As Fire Damage")]
		BurningArrowPhysicalDamagePctToAddAsFireDamage = 4298,

		[Description("Infernal Blow Physical Damage % To Add As Fire Damage")]
		InfernalBlowPhysicalDamagePctToAddAsFireDamage = 4299,

		[Description("Fire Trap Burning Damage +%")]
		FireTrapBurningDamagePosPct = 4300,

		[Description("Fireball Ignite Chance %")]
		FireballIgniteChancePct = 4301,

		[Description("Glacial Hammer Freeze Chance %")]
		GlacialHammerFreezeChancePct = 4302,

		[Description("Ice Nova Freeze Chance %")]
		IceNovaFreezeChancePct = 4303,

		[Description("Reave Attack Speed Per Reave Stack +%")]
		ReaveAttackSpeedPerReaveStackPosPct = 4304,

		[Description("Spectral Throw Projectile Deceleration +%")]
		SpectralThrowProjectileDecelerationPosPct = 4305,

		[Description("Flicker Strike Damage +% Per Frenzy Charge")]
		FlickerStrikeDamagePosPctPerFrenzyCharge = 4306,

		[Description("Puncture Maim On Hit % Chance")]
		PunctureMaimOnHitPctChance = 4307,
		[Description("Arc Shock Chance %")] ArcShockChancePct = 4308,

		[Description("Fire Nova Mine Num Of Additional Repeats")]
		FireNovaMineNumOfAdditionalRepeats = 4309,

		[Description("Firestorm Explosion Area Of Effect +%")]
		FirestormExplosionAreaOfEffectPosPct = 4310,

		[Description("Flame Surge Damage +% Vs Burning Enemies")]
		FlameSurgeDamagePosPctVsBurningEnemies = 4311,

		[Description("Ice Spear % Chance To Gain Power Charge On Critical Strike")]
		IceSpearPctChanceToGainPowerChargeOnCriticalStrike = 4312,

		[Description("Power Siphon % Chance To Gain Power Charge On Kill")]
		PowerSiphonPctChanceToGainPowerChargeOnKill = 4313,

		[Description("Searing Bond Totem Placement Speed +%")]
		SearingBondTotemPlacementSpeedPosPct = 4314,

		[Description("Sweep Knockback Chance %")]
		SweepKnockbackChancePct = 4315,

		[Description("Frenzy Damage +% Per Frenzy Charge")]
		FrenzyDamagePosPctPerFrenzyCharge = 4316,

		[Description("Frenzy % Chance To Gain Additional Frenzy Charge")]
		FrenzyPctChanceToGainAdditionalFrenzyCharge = 4317,

		[Description("Elemental Hit Chance To Freeze Shock Ignite %")]
		ElementalHitChanceToFreezeShockIgnitePct = 4318,

		[Description("Glacial Cascade Physical Damage % To Convert To Cold")]
		GlacialCascadePhysicalDamagePctToConvertToCold = 4319,

		[Description("Glacial Hammer Physical Damage % To Add As Cold Damage")]
		GlacialHammerPhysicalDamagePctToAddAsColdDamage = 4320,

		[Description("Ice Crash Physical Damage % To Add As Cold Damage")]
		IceCrashPhysicalDamagePctToAddAsColdDamage = 4321,

		[Description("Spectre Elemental Resistances %")]
		SpectreElementalResistancesPct = 4322,

		[Description("Zombie Elemental Resistances %")]
		ZombieElementalResistancesPct = 4323,

		[Description("Flame Golem Elemental Resistances %")]
		FlameGolemElementalResistancesPct = 4324,

		[Description("Chaos Golem Elemental Resistances %")]
		ChaosGolemElementalResistancesPct = 4325,

		[Description("Ice Golem Elemental Resistances %")]
		IceGolemElementalResistancesPct = 4326,

		[Description("Shock Nova Ring Damage +%")]
		ShockNovaRingDamagePosPct = 4327,

		[Description("Detonate Dead % Chance To Detonate Additional Corpse")]
		DetonateDeadPctChanceToDetonateAdditionalCorpse = 4328,

		[Description("Animate Weapon Chance To Create Additional Copy %")]
		AnimateWeaponChanceToCreateAdditionalCopyPct = 4329,
		[Description("Decoy Totem Life +%")] DecoyTotemLifePosPct = 4330,

		[Description("Devouring Totem Leech Per Second +%")]
		DevouringTotemLeechPerSecondPosPct = 4331,

		[Description("Rejuvenation Totem % Life Regeneration Added As Mana Regeneration")]
		RejuvenationTotemPctLifeRegenerationAddedAsManaRegeneration = 4332,

		[Description("Rejuvenation Totem Aura Effect +%")]
		RejuvenationTotemAuraEffectPosPct = 4333,

		[Description("Summon Skeletons Num Additional Warrior Skeletons")]
		SummonSkeletonsNumAdditionalWarriorSkeletons = 4334,

		[Description("Wild Strike Num Of Additional Projectiles In Chain")]
		WildStrikeNumOfAdditionalProjectilesInChain = 4335,

		[Description("Shockwave Totem Cast Speed +%")]
		ShockwaveTotemCastSpeedPosPct = 4336,

		[Description("Devouring Totem % Chance To Consume Additional Corpse")]
		DevouringTotemPctChanceToConsumeAdditionalCorpse = 4337,

		[Description("Incinerate Damage +% Per Stage")]
		IncinerateDamagePosPctPerStage = 4338,

		[Description("Siege Ballista Totem Placement Speed +%")]
		SiegeBallistaTotemPlacementSpeedPosPct = 4339,

		[Description("Virtual Curse Effect +%")]
		VirtualCurseEffectPosPct = 4340,

		[Description("Poachers Mark Curse Effect +%")]
		PoachersMarkCurseEffectPosPct = 4341,

		[Description("Projectile Weakness Curse Effect +%")]
		ProjectileWeaknessCurseEffectPosPct = 4342,

		[Description("Temporal Chains Curse Effect +%")]
		TemporalChainsCurseEffectPosPct = 4343,

		[Description("Assassins Mark Curse Effect +%")]
		AssassinsMarkCurseEffectPosPct = 4344,

		[Description("Conductivity Curse Effect +%")]
		ConductivityCurseEffectPosPct = 4345,

		[Description("Elemental Weakness Curse Effect +%")]
		ElementalWeaknessCurseEffectPosPct = 4346,

		[Description("Enfeeble Curse Effect +%")]
		EnfeebleCurseEffectPosPct = 4347,

		[Description("Flammability Curse Effect +%")]
		FlammabilityCurseEffectPosPct = 4348,

		[Description("Frostbite Curse Effect +%")]
		FrostbiteCurseEffectPosPct = 4349,

		[Description("Punishment Curse Effect +%")]
		PunishmentCurseEffectPosPct = 4350,

		[Description("Vulnerability Curse Effect +%")]
		VulnerabilityCurseEffectPosPct = 4351,

		[Description("Warlords Mark Curse Effect +%")]
		WarlordsMarkCurseEffectPosPct = 4352,

		[Description("Lightning Golem Grants Attack And Cast Speed +%")]
		LightningGolemGrantsAttackAndCastSpeedPosPct = 4353,

		[Description("Lightning Golem Grants Added Lightning Damage")]
		LightningGolemGrantsAddedLightningDamage = 4354,

		[Description("Arctic Armour Mana Reservation +%")]
		ArcticArmourManaReservationPosPct = 4355,

		[Description("Herald Of Ash Mana Reservation +%")]
		HeraldOfAshManaReservationPosPct = 4356,

		[Description("Herald Of Ice Mana Reservation +%")]
		HeraldOfIceManaReservationPosPct = 4357,

		[Description("Herald Of Thunder Mana Reservation +%")]
		HeraldOfThunderManaReservationPosPct = 4358,

		[Description("Clarity Mana Reservation +%")]
		ClarityManaReservationPosPct = 4359,

		[Description("Hatred Mana Reservation +%")]
		HatredManaReservationPosPct = 4360,

		[Description("Purity Of Ice Mana Reservation +%")]
		PurityOfIceManaReservationPosPct = 4361,

		[Description("Determination Mana Reservation +%")]
		DeterminationManaReservationPosPct = 4362,

		[Description("Discipline Mana Reservation +%")]
		DisciplineManaReservationPosPct = 4363,

		[Description("Purity Of Elements Mana Reservation +%")]
		PurityOfElementsManaReservationPosPct = 4364,

		[Description("Purity Of Fire Mana Reservation +%")]
		PurityOfFireManaReservationPosPct = 4365,

		[Description("Purity Of Lightning Mana Reservation +%")]
		PurityOfLightningManaReservationPosPct = 4366,

		[Description("Vitality Mana Reservation +%")]
		VitalityManaReservationPosPct = 4367,

		[Description("Wrath Mana Reservation +%")]
		WrathManaReservationPosPct = 4368,

		[Description("Grace Mana Reservation +%")]
		GraceManaReservationPosPct = 4369,

		[Description("Haste Mana Reservation +%")]
		HasteManaReservationPosPct = 4370,

		[Description("Immortal Call Duration +%")]
		ImmortalCallDurationPosPct = 4371,

		[Description("Bone Offering Duration +%")]
		BoneOfferingDurationPosPct = 4372,

		[Description("Flesh Offering Duration +%")]
		FleshOfferingDurationPosPct = 4373,

		[Description("Smoke Mine Duration +%")]
		SmokeMineDurationPosPct = 4374,

		[Description("Frost Wall Duration +%")]
		FrostWallDurationPosPct = 4375,

		[Description("Vigilant Strike Fortify Duration +%")]
		VigilantStrikeFortifyDurationPosPct = 4376,

		[Description("Poachers Mark Duration +%")]
		PoachersMarkDurationPosPct = 4377,

		[Description("Projectile Weakness Duration +%")]
		ProjectileWeaknessDurationPosPct = 4378,

		[Description("Temporal Chains Duration +%")]
		TemporalChainsDurationPosPct = 4379,

		[Description("Warlords Mark Duration +%")]
		WarlordsMarkDurationPosPct = 4380,

		[Description("Vulnerability Duration +%")]
		VulnerabilityDurationPosPct = 4381,

		[Description("Punishment Duration +%")]
		PunishmentDurationPosPct = 4382,
		[Description("Frostbite Duration +%")] FrostbiteDurationPosPct = 4383,

		[Description("Flammability Duration +%")]
		FlammabilityDurationPosPct = 4384,
		[Description("Enfeeble Duration +%")] EnfeebleDurationPosPct = 4385,

		[Description("Elemental Weakness Duration +%")]
		ElementalWeaknessDurationPosPct = 4386,

		[Description("Conductivity Duration +%")]
		ConductivityDurationPosPct = 4387,

		[Description("Assassins Mark Duration +%")]
		AssassinsMarkDurationPosPct = 4388,

		[Description("Rallying Cry Duration +%")]
		RallyingCryDurationPosPct = 4389,

		[Description("Abyssal Cry Duration +%")]
		AbyssalCryDurationPosPct = 4390,
		[Description("Contagion Duration +%")] ContagionDurationPosPct = 4391,
		[Description("Siphon Duration +%")] SiphonDurationPosPct = 4392,
		[Description("Wither Duration +%")] WitherDurationPosPct = 4393,

		[Description("Blade Vortex Duration +%")]
		BladeVortexDurationPosPct = 4394,

		[Description("Earthquake Duration +%")]
		EarthquakeDurationPosPct = 4395,
		[Description("Blight Duration +%")] BlightDurationPosPct = 4396,

		[Description("Blight Secondary Skill Effect Duration +%")]
		BlightSecondarySkillEffectDurationPosPct = 4397,

		[Description("Convocation Cooldown Speed +%")]
		ConvocationCooldownSpeedPosPct = 4398,

		[Description("Bear Trap Cooldown Speed +%")]
		BearTrapCooldownSpeedPosPct = 4399,

		[Description("Frost Wall Cooldown Speed +%")]
		FrostWallCooldownSpeedPosPct = 4400,

		[Description("Reckoning Cooldown Speed +%")]
		ReckoningCooldownSpeedPosPct = 4401,

		[Description("Flame Dash Cooldown Speed +%")]
		FlameDashCooldownSpeedPosPct = 4402,

		[Description("Desecrate Cooldown Speed +%")]
		DesecrateCooldownSpeedPosPct = 4403,

		[Description("Blink Arrow Cooldown Speed +%")]
		BlinkArrowCooldownSpeedPosPct = 4404,

		[Description("Mirror Arrow Cooldown Speed +%")]
		MirrorArrowCooldownSpeedPosPct = 4405,

		[Description("Riposte Cooldown Speed +%")]
		RiposteCooldownSpeedPosPct = 4406,

		[Description("Vengeance Cooldown Speed +%")]
		VengeanceCooldownSpeedPosPct = 4407,

		[Description("Enduring Cry Cooldown Speed +%")]
		EnduringCryCooldownSpeedPosPct = 4408,

		[Description("Frost Bomb Cooldown Speed +%")]
		FrostBombCooldownSpeedPosPct = 4409,

		[Description("Conversion Trap Cooldown Speed +%")]
		ConversionTrapCooldownSpeedPosPct = 4410,

		[Description("Ice Trap Cooldown Speed +%")]
		IceTrapCooldownSpeedPosPct = 4411,

		[Description("Siege Ballista Attack Speed +%")]
		SiegeBallistaAttackSpeedPosPct = 4412,

		[Description("Shockwave Slam Attack Speed +%")]
		ShockwaveSlamAttackSpeedPosPct = 4413,

		[Description("Mirror Arrow And Mirror Arrow Clone Attack Speed +%")]
		MirrorArrowAndMirrorArrowCloneAttackSpeedPosPct = 4414,
		[Description("Freeze Mine Radius +%")] FreezeMineRadiusPosPct = 4415,

		[Description("Shrapnel Shot Radius +%")]
		ShrapnelShotRadiusPosPct = 4416,
		[Description("Blast Rain Radius +%")] BlastRainRadiusPosPct = 4417,
		[Description("Contagion Radius +%")] ContagionRadiusPosPct = 4418,
		[Description("Wither Radius +%")] WitherRadiusPosPct = 4419,

		[Description("Blade Vortex Radius +%")]
		BladeVortexRadiusPosPct = 4420,
		[Description("Bladefall Radius +%")] BladefallRadiusPosPct = 4421,
		[Description("Ice Trap Radius +%")] IceTrapRadiusPosPct = 4422,
		[Description("Earthquake Radius +%")] EarthquakeRadiusPosPct = 4423,
		[Description("Frost Bomb Radius +%")] FrostBombRadiusPosPct = 4424,
		[Description("Storm Cloud Radius +%")] StormCloudRadiusPosPct = 4425,
		[Description("Blight Radius +%")] BlightRadiusPosPct = 4426,

		[Description("Shockwave Slam Radius +%")]
		ShockwaveSlamRadiusPosPct = 4427,

		[Description("Display Attack With Decree Of Ire When Hit %")]
		DisplayAttackWithDecreeOfIreWhenHitPct = 4428,

		[Description("Display Attack With Commandment Of Ire When Hit %")]
		DisplayAttackWithCommandmentOfIreWhenHitPct = 4429,

		[Description("Blink Arrow And Blink Arrow Clone Attack Speed +%")]
		BlinkArrowAndBlinkArrowCloneAttackSpeedPosPct = 4430,

		[Description("Whirling Blades Attack Speed +%")]
		WhirlingBladesAttackSpeedPosPct = 4431,

		[Description("Arctic Armour Buff Effect +%")]
		ArcticArmourBuffEffectPosPct = 4432,

		[Description("Immortal Call % Chance To Not Consume Endurance Charges")]
		ImmortalCallPctChanceToNotConsumeEnduranceCharges = 4433,

		[Description("Phase Run % Chance To Not Consume Frenzy Charges")]
		PhaseRunPctChanceToNotConsumeFrenzyCharges = 4434,

		[Description("Animate Guardian Elemental Resistances %")]
		AnimateGuardianElementalResistancesPct = 4435,

		[Description("Shrapnel Shot Physical Damage % To Add As Lightning Damage")]
		ShrapnelShotPhysicalDamagePctToAddAsLightningDamage = 4436,

		[Description("Bladefall Critical Strike Chance +%")]
		BladefallCriticalStrikeChancePosPct = 4437,

		[Description("Storm Cloud Critical Strike Chance +%")]
		StormCloudCriticalStrikeChancePosPct = 4438,

		[Description("Tempest Shield Num Of Additional Projectiles In Chain")]
		TempestShieldNumOfAdditionalProjectilesInChain = 4439,

		[Description("Map Labyrinth Secret1 Override")]
		MapLabyrinthSecret1Override = 4440,

		[Description("Map Labyrinth Secret2 Override")]
		MapLabyrinthSecret2Override = 4441,

		[Description("Melee Ancestor Totem Granted Attack Speed +% Final")]
		MeleeAncestorTotemGrantedAttackSpeedPosPctFinal = 4442,

		[Description("Cannot Be Stunned While At Max Endurance Charges")]
		CannotBeStunnedWhileAtMaxEnduranceCharges = 4443,

		[Description("Life Regenerate Rate Per Second % While Totem Active")]
		LifeRegenerateRatePerSecondPctWhileTotemActive = 4444,

		[Description("Gain Attack And Cast Speed +% For 4 Seconds If Taken Savage Hit")]
		GainAttackAndCastSpeedPosPctFor4SecondsIfTakenSavageHit = 4445,

		[Description("Berserker Damage +% Final")]
		BerserkerDamagePosPctFinal = 4446,

		[Description("Elemental Damage Taken +% While On Consecrated Ground")]
		ElementalDamageTakenPosPctWhileOnConsecratedGround = 4447,

		[Description("Critical Strike Chance +% Vs Enemies With Elemental Status Ailments")]
		CriticalStrikeChancePosPctVsEnemiesWithElementalStatusAilments = 4448,

		[Description("Scion Helmet Skill Maximum Totems +")]
		ScionHelmetSkillMaximumTotemsPos = 4449,

		[Description("% Chance To Gain Power Charge On Placing A Totem")]
		Pctchancetogainpowerchargeonplacingatotem = 4450,

		[Description("Attack And Cast Speed +% For You And Allies Affected By Your Auras")]
		AttackAndCastSpeedPosPctForYouAndAlliesAffectedByYourAuras = 4451,

		[Description("Gain Elemental Conflux For X Ms When You Kill A Rare Or Unique Enemy")]
		GainElementalConfluxForXMsWhenYouKillARareOrUniqueEnemy = 4452,

		[Description("Enemies Chaos Resistance % While Cursed")]
		EnemiesChaosResistancePctWhileCursed = 4453,

		[Description("Damage +% For 4 Seconds When You Kill A Cursed Enemy")]
		DamagePosPctFor4SecondsWhenYouKillACursedEnemy = 4454,

		[Description("Physical Damage Reduction And Minion Physical Damage Reduction %")]
		PhysicalDamageReductionAndMinionPhysicalDamageReductionPct = 4455,

		[Description("Offering Spells Effect +%")]
		OfferingSpellsEffectPosPct = 4456,

		[Description("Damage +% For You And Allies Affected By Your Auras")]
		DamagePosPctForYouAndAlliesAffectedByYourAuras = 4457,

		[Description("You And Minion Attack And Cast Speed +% For 4 Seconds When Corpse Destroyed")]
		YouAndMinionAttackAndCastSpeedPosPctFor4SecondsWhenCorpseDestroyed = 4458,

		[Description("% Chance To Gain Power Charge On Hit Against Enemies On Full Life")]
		Pctchancetogainpowerchargeonhitagainstenemiesonfulllife = 4459,

		[Description("Cause Maim On Critical Strike Attack")]
		CauseMaimOnCriticalStrikeAttack = 4460,

		[Description("% Chance To Create Smoke Cloud On Mine Or Trap Creation")]
		Pctchancetocreatesmokecloudonmineortrapcreation = 4461,

		[Description("Damage +% For Each Trap And Mine Active")]
		DamagePosPctForEachTrapAndMineActive = 4462,

		[Description("Evasion Rating While Es Full +% Final")]
		EvasionRatingWhileEsFullPosPctFinal = 4463,

		[Description("Damage +% While Es Not Full")]
		DamagePosPctWhileEsNotFull = 4464,

		[Description("Mana Regeneration +% For 4 Seconds On Movement Skill Use")]
		ManaRegenerationPosPctFor4SecondsOnMovementSkillUse = 4465,

		[Description("Gain Onslaught While Frenzy Charges Full")]
		GainOnslaughtWhileFrenzyChargesFull = 4466,

		[Description("Projectile Damage +% Max As Distance Travelled Increases")]
		ProjectileDamagePosPctMaxAsDistanceTravelledIncreases = 4467,

		[Description("Damage +% During Flask Effect")]
		DamagePosPctDuringFlaskEffect = 4468,

		[Description("Avoid Freeze Shock Ignite Bleed % During Flask Effect")]
		AvoidFreezeShockIgniteBleedPctDuringFlaskEffect = 4469,

		[Description("Elemental Damage Taken +% During Flask Effect")]
		ElementalDamageTakenPosPctDuringFlaskEffect = 4470,

		[Description("Damage +% For 4 Seconds When You Kill A Bleeding Enemy")]
		DamagePosPctFor4SecondsWhenYouKillABleedingEnemy = 4471,

		[Description("Damage +% To You And Nearby Allies While You Have Fortify")]
		DamagePosPctToYouAndNearbyAlliesWhileYouHaveFortify = 4472,

		[Description("Damage Taken +% From Taunted Enemies")]
		DamageTakenPosPctFromTauntedEnemies = 4473,

		[Description("Attack And Cast Speed +% While Leeching")]
		AttackAndCastSpeedPosPctWhileLeeching = 4474,
		[Description("Base Avoid Bleed %")] BaseAvoidBleedPct = 4475,
		[Description("Avoid Bleed %")] AvoidBleedPct = 4476,

		[Description("Virtual Phase Through Objects")]
		VirtualPhaseThroughObjects = 4477,
		[Description("Virtual Has Onslaught")] VirtualHasOnslaught = 4478,

		[Description("Shield Charge Damage Per Target Hit +%")]
		ShieldChargeDamagePerTargetHitPosPct = 4479,

		[Description("Number Of Mines To Place")]
		NumberOfMinesToPlace = 4480,

		[Description("Local Flask Life Gain On Skill Use % Mana Cost")]
		LocalFlaskLifeGainOnSkillUsePctManaCost = 4481,

		[Description("Life Gain On Skill Use Percent Mana Cost")]
		LifeGainOnSkillUsePercentManaCost = 4482,

		[Description("Traps And Mines % Chance To Poison")]
		TrapsAndMinesPctChanceToPoison = 4483,

		[Description("Damage +% Of Each Type That You Have An Active Golem Of")]
		DamagePosPctOfEachTypeThatYouHaveAnActiveGolemOf = 4484,

		[Description("Elemental Golem Immunity To Elemental Damage")]
		ElementalGolemImmunityToElementalDamage = 4485,

		[Description("Elemental Golem Granted Buff Effect +%")]
		ElementalGolemGrantedBuffEffectPosPct = 4486,

		[Description("Current Number Of Fire Golems")]
		CurrentNumberOfFireGolems = 4487,

		[Description("Current Number Of Ice Golems")]
		CurrentNumberOfIceGolems = 4488,

		[Description("Current Number Of Lightning Golems")]
		CurrentNumberOfLightningGolems = 4489,

		[Description("Current Number Of Stone Golems")]
		CurrentNumberOfStoneGolems = 4490,

		[Description("Current Number Of Chaos Golems")]
		CurrentNumberOfChaosGolems = 4491,
		[Description("Base Cold Immunity")] BaseColdImmunity = 4492,

		[Description("Base Lightning Immunity")]
		BaseLightningImmunity = 4493,

		[Description("Gain Elemental Penetration For 4 Seconds On Mine Detonation")]
		GainElementalPenetrationFor4SecondsOnMineDetonation = 4494,

		[Description("Display Can Take Character Start Point")]
		DisplayCanTakeCharacterStartPoint = 4495,
		[Description("Fire Damage Immunity")] FireDamageImmunity = 4496,
		[Description("Cold Damage Immunity")] ColdDamageImmunity = 4497,

		[Description("Lightning Damage Immunity")]
		LightningDamageImmunity = 4498,
		[Description("Chaos Damage Immunity")] ChaosDamageImmunity = 4499,

		[Description("Elemental Damage Immunity")]
		ElementalDamageImmunity = 4500,

		[Description("Global Total Minimum Added Lightning Damage")]
		GlobalTotalMinimumAddedLightningDamage = 4501,

		[Description("Global Total Maximum Added Lightning Damage")]
		GlobalTotalMaximumAddedLightningDamage = 4502,
		[Description("Have Killed Recently")] HaveKilledRecently = 4503,

		[Description("Track Have Killed Recently")]
		TrackHaveKilledRecently = 4504,

		[Description("Number Of Times Have Been Hit Recently")]
		NumberOfTimesHaveBeenHitRecently = 4505,

		[Description("Track Have Been Hit Recently")]
		TrackHaveBeenHitRecently = 4506,
		[Description("Have Crit Recently")] HaveCritRecently = 4507,

		[Description("Track Have Crit Recently")]
		TrackHaveCritRecently = 4508,

		[Description("Base Body Armour Physical Damage Reduction Rating")]
		BaseBodyArmourPhysicalDamageReductionRating = 4509,

		[Description("Chance To Grant Power Charge To Nearby Allies On Kill %")]
		ChanceToGrantPowerChargeToNearbyAlliesOnKillPct = 4510,

		[Description("Chance To Grant Frenzy Charge To Nearby Allies On Hit %")]
		ChanceToGrantFrenzyChargeToNearbyAlliesOnHitPct = 4511,

		[Description("Blood Rage Grants Additional Attack Speed +%")]
		BloodRageGrantsAdditionalAttackSpeedPosPct = 4512,

		[Description("Blood Rage Grants Additional % Chance To Gain Frenzy On Kill")]
		BloodRageGrantsAdditionalPctChanceToGainFrenzyOnKill = 4513,

		[Description("Play Tempestuous Steel Sounds")]
		PlayTempestuousSteelSounds = 4514,

		[Description("From Totem Aura Damage +% Final")]
		FromTotemAuraDamagePosPctFinal = 4515,

		[Description("Explode Enemies For 25% Life As Chaos On Kill Chance %")]
		ExplodeEnemiesFor25PctLifeAsChaosOnKillChancePct = 4516,

		[Description("Explode Cursed Enemies For 25% Life As Chaos On Kill Chance %")]
		ExplodeCursedEnemiesFor25PctLifeAsChaosOnKillChancePct = 4517,

		[Description("Base Minion Duration +%")]
		BaseMinionDurationPosPct = 4518,

		[Description("Skill Specific Minion Duration +% Final")]
		SkillSpecificMinionDurationPosPctFinal = 4519,

		[Description("Base Chaos Golem Granted Buff Effect +%")]
		BaseChaosGolemGrantedBuffEffectPosPct = 4520,

		[Description("Base Stone Golem Granted Buff Effect +%")]
		BaseStoneGolemGrantedBuffEffectPosPct = 4521,

		[Description("Base Fire Golem Granted Buff Effect +%")]
		BaseFireGolemGrantedBuffEffectPosPct = 4522,

		[Description("Base Ice Golem Granted Buff Effect +%")]
		BaseIceGolemGrantedBuffEffectPosPct = 4523,

		[Description("Base Lightning Golem Granted Buff Effect +%")]
		BaseLightningGolemGrantedBuffEffectPosPct = 4524,

		[Description("Stone Golem Elemental Resistances %")]
		StoneGolemElementalResistancesPct = 4525,

		[Description("Dominating Blow Minion Damage +%")]
		DominatingBlowMinionDamagePosPct = 4526,

		[Description("Dominating Blow Skill Attack Damage +%")]
		DominatingBlowSkillAttackDamagePosPct = 4527,

		[Description("Lightning Golem Elemental Resistances %")]
		LightningGolemElementalResistancesPct = 4528,

		[Description("Lightning Golem Damage +%")]
		LightningGolemDamagePosPct = 4529,
		[Description("Is Hindered")] IsHindered = 4530,

		[Description("Damage +% Vs Hindered Enemies")]
		DamagePosPctVsHinderedEnemies = 4531,

		[Description("Blast Rain Number Of Blasts")]
		BlastRainNumberOfBlasts = 4532,

		[Description("Local Display Socketed Curse Gems Have Mana Reservation +%")]
		LocalDisplaySocketedCurseGemsHaveManaReservationPosPct = 4533,

		[Description("Bone Offering Block Chance +%")]
		BoneOfferingBlockChancePosPct = 4534,

		[Description("Map Number Of Explicit Mods")]
		MapNumberOfExplicitMods = 4535,

		[Description("Curse Orb Additional Height")]
		CurseOrbAdditionalHeight = 4536,

		[Description("Curse Orb Additional Radius")]
		CurseOrbAdditionalRadius = 4537,

		[Description("Phase Run Skill Effect Duration +%")]
		PhaseRunSkillEffectDurationPosPct = 4538,

		[Description("Lightning Tendrils Critical Strike Chance +%")]
		LightningTendrilsCriticalStrikeChancePosPct = 4539,

		[Description("Searing Totem Elemental Resistance +%")]
		SearingTotemElementalResistancePosPct = 4540,

		[Description("Flesh Offering Attack Speed +%")]
		FleshOfferingAttackSpeedPosPct = 4541,

		[Description("Smoke Mine Base Movement Velocity +%")]
		SmokeMineBaseMovementVelocityPosPct = 4542,

		[Description("Convocation Buff Effect +%")]
		ConvocationBuffEffectPosPct = 4543,

		[Description("Molten Shell Buff Effect +%")]
		MoltenShellBuffEffectPosPct = 4544,

		[Description("Enduring Cry Buff Effect +%")]
		EnduringCryBuffEffectPosPct = 4545,

		[Description("Righteous Fire Spell Damage +%")]
		RighteousFireSpellDamagePosPct = 4546,

		[Description("Rallying Cry Buff Effect +%")]
		RallyingCryBuffEffectPosPct = 4547,

		[Description("Attack Trigger When Critically Hit %")]
		AttackTriggerWhenCriticallyHitPct = 4548,
		[Description("Cast When Hit %")] CastWhenHitPct = 4549,

		[Description("Attack Trigger When Hit %")]
		AttackTriggerWhenHitPct = 4550,

		[Description("Attack Trigger On Kill %")]
		AttackTriggerOnKillPct = 4551,

		[Description("Decrement Parent Counter On Death")]
		DecrementParentCounterOnDeath = 4552,

		[Description("Minions Explode On Death For % Max Life At End Of Duration")]
		MinionsExplodeOnDeathForPctMaxLifeAtEndOfDuration = 4553,

		[Description("Explode On Death For % Max Life At End Of Duration")]
		ExplodeOnDeathForPctMaxLifeAtEndOfDuration = 4554,

		[Description("Melee Ancestor Totem Damage +%")]
		MeleeAncestorTotemDamagePosPct = 4555,

		[Description("Melee Ancestor Totem Placement Speed +%")]
		MeleeAncestorTotemPlacementSpeedPosPct = 4556,

		[Description("Melee Ancestor Totem Elemental Resistance %")]
		MeleeAncestorTotemElementalResistancePct = 4557,

		[Description("Blast Rain % Chance For Additional Blast")]
		BlastRainPctChanceForAdditionalBlast = 4558,

		[Description("Perandus Chest Revive Targeted Monster")]
		PerandusChestReviveTargetedMonster = 4559,
		[Description("Current Difficulty")] CurrentDifficulty = 4560,

		[Description("Base Fire Damage % Of Maximum Life Plus Maximum Es Taken Per Minute In Cruel")]
		BaseFireDamagePctOfMaximumLifePlusMaximumEsTakenPerMinuteInCruel = 4561,

		[Description("Base Fire Damage % Of Maximum Life Plus Maximum Es Taken Per Minute In Merciless")]
		BaseFireDamagePctOfMaximumLifePlusMaximumEsTakenPerMinuteInMerciless = 4562,

		[Description("Kinetic Blast % Chance For Additional Blast")]
		KineticBlastPctChanceForAdditionalBlast = 4563,

		[Description("Share Charges With Party Members In Aura")]
		ShareChargesWithPartyMembersInAura = 4564,

		[Description("Guardian Nearby Allies Share Charges")]
		GuardianNearbyAlliesShareCharges = 4565,
		[Description("Bleed Duration +%")] BleedDurationPosPct = 4566,

		[Description("Summoned Monsters Are Parented To My Parent")]
		SummonedMonstersAreParentedToMyParent = 4567,

		[Description("Monster Grants No Experience After X Revives")]
		MonsterGrantsNoExperienceAfterXRevives = 4568,

		[Description("Consecrate Ground On Shatter % Chance For 3 Seconds")]
		ConsecrateGroundOnShatterPctChanceFor3Seconds = 4569,

		[Description("Summoned Monsters Decrement Parent Counter")]
		SummonedMonstersDecrementParentCounter = 4570,
		[Description("Skill Buff Effect +%")] SkillBuffEffectPosPct = 4571,

		[Description("Glows In Area With Unique Fish")]
		GlowsInAreaWithUniqueFish = 4572,

		[Description("Local Display Summon Raging Spirit On Kill %")]
		LocalDisplaySummonRagingSpiritOnKillPct = 4573,

		[Description("Attacks Num Of Additional Chains")]
		AttacksNumOfAdditionalChains = 4574,

		[Description("Monster Do Not Give Soul To Soul Eater")]
		MonsterDoNotGiveSoulToSoulEater = 4575,

		[Description("Monster Grants No Flask Charges")]
		MonsterGrantsNoFlaskCharges = 4576,
		[Description("Used Teleports")] UsedTeleports = 4577,

		[Description("Explosive Arrow Attack Speed +%")]
		ExplosiveArrowAttackSpeedPosPct = 4578,

		[Description("Slam Ancestor Totem Grant Owner Melee Damage +% Final")]
		SlamAncestorTotemGrantOwnerMeleeDamagePosPctFinal = 4579,

		[Description("Slash Ancestor Totem Grant Owner Physical Damage Added As Fire +%")]
		SlashAncestorTotemGrantOwnerPhysicalDamageAddedAsFirePosPct = 4580,

		[Description("Slam Ancestor Totem Granted Melee Damage +% Final")]
		SlamAncestorTotemGrantedMeleeDamagePosPctFinal = 4581,

		[Description("Perandus Chest Spawned Bosses")]
		PerandusChestSpawnedBosses = 4582,

		[Description("Lightning Damage +% Per 10 Intelligence")]
		LightningDamagePosPctPer10Intelligence = 4583,

		[Description("Shield Charge Range +%")]
		ShieldChargeRangePosPct = 4584,
		[Description("Local Maim On Hit")] LocalMaimOnHit = 4585,
		[Description("Main Hand Maim On Hit")] MainHandMaimOnHit = 4586,
		[Description("Off Hand Maim On Hit")] OffHandMaimOnHit = 4587,
		[Description("Warcries Cost No Mana")] WarcriesCostNoMana = 4588,

		[Description("Is On Ground Maelstrom")]
		IsOnGroundMaelstrom = 4589,

		[Description("Gain A Power Charge When You Or Your Totems Kill % Chance")]
		GainAPowerChargeWhenYouOrYourTotemsKillPctChance = 4590,

		[Description("Give Parent Power Charge On Kill % Chance")]
		GiveParentPowerChargeOnKillPctChance = 4591,

		[Description("Buff Visuals Show While Hidden Override")]
		BuffVisualsShowWhileHiddenOverride = 4592,
		[Description("Always Pierce")] AlwaysPierce = 4593,

		[Description("Always Crit Shocked Enemies")]
		AlwaysCritShockedEnemies = 4594,

		[Description("Cannot Crit Non Shocked Enemies")]
		CannotCritNonShockedEnemies = 4595,
		[Description("Map Prophecy")] MapProphecy = 4596,
		[Description("Frost Bolt Damage +%")] FrostBoltDamagePosPct = 4597,

		[Description("Frost Bolt Nova Damage +%")]
		FrostBoltNovaDamagePosPct = 4598,

		[Description("Double Slash Damage +%")]
		DoubleSlashDamagePosPct = 4599,

		[Description("Charged Attack Damage +%")]
		ChargedAttackDamagePosPct = 4600,

		[Description("Slam Ancestor Totem Damage +%")]
		SlamAncestorTotemDamagePosPct = 4601,

		[Description("Slash Ancestor Totem Damage +%")]
		SlashAncestorTotemDamagePosPct = 4602,

		[Description("Slash Ancestor Totem Radius +%")]
		SlashAncestorTotemRadiusPosPct = 4603,

		[Description("Slam Ancestor Totem Radius +%")]
		SlamAncestorTotemRadiusPosPct = 4604,

		[Description("Frost Bolt Nova Radius +%")]
		FrostBoltNovaRadiusPosPct = 4605,

		[Description("Double Slash Critical Strike Chance +%")]
		DoubleSlashCriticalStrikeChancePosPct = 4606,

		[Description("Charged Attack Radius +%")]
		ChargedAttackRadiusPosPct = 4607,

		[Description("Double Slash Radius +%")]
		DoubleSlashRadiusPosPct = 4608,

		[Description("Charged Attack Damage Per Stack +% Final")]
		ChargedAttackDamagePerStackPosPctFinal = 4609,

		[Description("% Of Life And Energy Shield To Take As Damage On Using A Movement Skill")]
		Pctoflifeandenergyshieldtotakeasdamageonusingamovementskill = 4610,

		[Description("Remove % Of Targets Current Flask Charges On Hit")]
		RemovePctOfTargetsCurrentFlaskChargesOnHit = 4611,

		[Description("Virtual Reduce Enemy Cold Resistance With Weapons %")]
		VirtualReduceEnemyColdResistanceWithWeaponsPct = 4612,

		[Description("Virtual Reduce Enemy Fire Resistance With Weapons %")]
		VirtualReduceEnemyFireResistanceWithWeaponsPct = 4613,

		[Description("Virtual Reduce Enemy Lightning Resistance With Weapons %")]
		VirtualReduceEnemyLightningResistanceWithWeaponsPct = 4614,

		[Description("Minions % Chance To Blind On Hit")]
		MinionsPctChanceToBlindOnHit = 4615,

		[Description("Minions Cannot Be Blinded")]
		MinionsCannotBeBlinded = 4616,

		[Description("Display Socketed Minion Gems Supported By Level X Life Leech")]
		DisplaySocketedMinionGemsSupportedByLevelXLifeLeech = 4617,

		[Description("Magic Items Drop Identified")]
		MagicItemsDropIdentified = 4618,

		[Description("Number Of Stackable Unique Jewels")]
		NumberOfStackableUniqueJewels = 4619,

		[Description("X Mana Per Stackable Unique Jewel")]
		XManaPerStackableUniqueJewel = 4620,

		[Description("X Armour Per Stackable Unique Jewel")]
		XArmourPerStackableUniqueJewel = 4621,

		[Description("Elemental Damage +% Per Stackable Unique Jewel")]
		ElementalDamagePosPctPerStackableUniqueJewel = 4622,

		[Description("Base Fire Damage % Of Maximum Life Plus Maximum Es Taken Per Minute In Normal")]
		BaseFireDamagePctOfMaximumLifePlusMaximumEsTakenPerMinuteInNormal = 4623,

		[Description("Projectile Uses Contact Position")]
		ProjectileUsesContactPosition = 4624,

		[Description("Skeletal Chains Aoe % Health Dealt As Chaos Damage")]
		SkeletalChainsAoePctHealthDealtAsChaosDamage = 4625,

		[Description("Virtual Number Of Inca Minions Allowed")]
		VirtualNumberOfIncaMinionsAllowed = 4626,

		[Description("Virtual Number Of Insects Allowed")]
		VirtualNumberOfInsectsAllowed = 4627,

		[Description("Virtual Number Of Taniwha Tails Allowed")]
		VirtualNumberOfTaniwhaTailsAllowed = 4628,

		[Description("Virtual Number Of Wolves Allowed")]
		VirtualNumberOfWolvesAllowed = 4629,

		[Description("You Cannot Have Non Golem Minions")]
		YouCannotHaveNonGolemMinions = 4630,

		[Description("Lightning Damage % Taken From Mana Before Life")]
		LightningDamagePctTakenFromManaBeforeLife = 4631,

		[Description("Recover % Maximum Mana When Enemy Shocked")]
		RecoverPctMaximumManaWhenEnemyShocked = 4632,

		[Description("Ground Caustic Art Variation")]
		GroundCausticArtVariation = 4633,

		[Description("Global Life Leech From Physical Attack Damage Per Red Socket On Item Permyriad")]
		GlobalLifeLeechFromPhysicalAttackDamagePerRedSocketOnItemPermyriad = 4634,

		[Description("Spell Dodge Chance +% If You Have Taken Attack Damage Recently")]
		SpellDodgeChancePosPctIfYouHaveTakenAttackDamageRecently = 4635,

		[Description("Dodge Chance +% If You Have Taken Spell Damage Recently")]
		DodgeChancePosPctIfYouHaveTakenSpellDamageRecently = 4636,

		[Description("Quantity Of Items Dropped By Maimed Enemies +%")]
		QuantityOfItemsDroppedByMaimedEnemiesPosPct = 4637,

		[Description("Rarity Of Items Dropped By Maimed Enemies +%")]
		RarityOfItemsDroppedByMaimedEnemiesPosPct = 4638,

		[Description("Damage Taken +% If You Have Taken A Savage Hit Recently")]
		DamageTakenPosPctIfYouHaveTakenASavageHitRecently = 4639,
		[Description("Is Maimed")] IsMaimed = 4640,

		[Description("Track Have Been Savage Hit Recently")]
		TrackHaveBeenSavageHitRecently = 4641,

		[Description("Have Been Savage Hit Recently")]
		HaveBeenSavageHitRecently = 4642,

		[Description("Track Have Taken Attack Damage Recently")]
		TrackHaveTakenAttackDamageRecently = 4643,

		[Description("Have Taken Attack Damage Recently")]
		HaveTakenAttackDamageRecently = 4644,

		[Description("Track Have Taken Spell Damage Recently")]
		TrackHaveTakenSpellDamageRecently = 4645,

		[Description("Have Taken Spell Damage Recently")]
		HaveTakenSpellDamageRecently = 4646,

		[Description("Stun Duration On Self +%")]
		StunDurationOnSelfPosPct = 4647,

		[Description("Melee Damage +% Per Endurance Charge")]
		MeleeDamagePosPctPerEnduranceCharge = 4648,

		[Description("Totems Resist All Elements +% Per Active Totem")]
		TotemsResistAllElementsPosPctPerActiveTotem = 4649,

		[Description("Summon Your Maximum Number Of Totems In Formation")]
		SummonYourMaximumNumberOfTotemsInFormation = 4650,

		[Description("Gain Life Regeneration % Per Second For 1 Second If Taken Savage Hit")]
		GainLifeRegenerationPctPerSecondFor1SecondIfTakenSavageHit = 4651,

		[Description("Maximum Life % To Add As Maximum Energy Shield")]
		MaximumLifePctToAddAsMaximumEnergyShield = 4652,

		[Description("Total Base Maximum Life")]
		TotalBaseMaximumLife = 4653,
		[Description("Combined Life +%")] CombinedLifePosPct = 4654,

		[Description("Combined Life +% Final")]
		CombinedLifePosPctFinal = 4655,

		[Description("Cannot Be Shocked While At Maximum Endurance Charges")]
		CannotBeShockedWhileAtMaximumEnduranceCharges = 4656,

		[Description("Movement Speed +% If Used A Warcry Recently")]
		MovementSpeedPosPctIfUsedAWarcryRecently = 4657,

		[Description("Mana Leech From Attack Damage Permyriad Vs Poisoned Enemies")]
		ManaLeechFromAttackDamagePermyriadVsPoisonedEnemies = 4658,

		[Description("Have Used A Warcry Recently")]
		HaveUsedAWarcryRecently = 4659,

		[Description("Track Have Used A Warcry Recently")]
		TrackHaveUsedAWarcryRecently = 4660,

		[Description("Totems Spells Cast Speed +% Per Active Totem")]
		TotemsSpellsCastSpeedPosPctPerActiveTotem = 4661,

		[Description("Movement Skills Mana Cost +%")]
		MovementSkillsManaCostPosPct = 4662,

		[Description("Global Critical Strike Mulitplier + Per Green Socket On Item")]
		GlobalCriticalStrikeMulitplierPosPerGreenSocketOnItem = 4663,

		[Description("Additional Block Chance % When In Off Hand")]
		AdditionalBlockChancePctWhenInOffHand = 4664,

		[Description("Critical Strike Chance +% When In Main Hand")]
		CriticalStrikeChancePosPctWhenInMainHand = 4665,

		[Description("Spirit Offering Duration +%")]
		SpiritOfferingDurationPosPct = 4666,

		[Description("Spirit Offering Physical Damage % To Add As Chaos")]
		SpiritOfferingPhysicalDamagePctToAddAsChaos = 4667,

		[Description("Base Fire Damage % Of Maximum Life Taken Per Minute In Normal")]
		BaseFireDamagePctOfMaximumLifeTakenPerMinuteInNormal = 4668,

		[Description("Base Fire Damage % Of Maximum Es Taken Per Minute In Normal")]
		BaseFireDamagePctOfMaximumEsTakenPerMinuteInNormal = 4669,

		[Description("Base Fire Damage % Of Maximum Life Taken Per Minute In Cruel")]
		BaseFireDamagePctOfMaximumLifeTakenPerMinuteInCruel = 4670,

		[Description("Base Fire Damage % Of Maximum Es Taken Per Minute In Cruel")]
		BaseFireDamagePctOfMaximumEsTakenPerMinuteInCruel = 4671,

		[Description("Base Fire Damage % Of Maximum Life Taken Per Minute In Merciless")]
		BaseFireDamagePctOfMaximumLifeTakenPerMinuteInMerciless = 4672,

		[Description("Base Fire Damage % Of Maximum Es Taken Per Minute In Merciless")]
		BaseFireDamagePctOfMaximumEsTakenPerMinuteInMerciless = 4673,

		[Description("% Of Life To Deal As Damage")]
		Pctoflifetodealasdamage = 4674,

		[Description("% Of Es To Deal As Damage")]
		Pctofestodealasdamage = 4675,

		[Description("% Of Life To Take As Damage On Using A Movement Skill")]
		Pctoflifetotakeasdamageonusingamovementskill = 4676,

		[Description("% Of Energy Shield To Take As Damage On Using A Movement Skill")]
		Pctofenergyshieldtotakeasdamageonusingamovementskill = 4677,

		[Description("% Of Life To Deal As Damage On Using A Movement Skill")]
		Pctoflifetodealasdamageonusingamovementskill = 4678,

		[Description("% Of Energy Shield To Deal As Damage On Using A Movement Skill")]
		Pctofenergyshieldtodealasdamageonusingamovementskill = 4679,

		[Description("Local Unique Overflowing Chalice Flask Cannot Gain Flask Charges During Flask Effect")]
		LocalUniqueOverflowingChaliceFlaskCannotGainFlaskChargesDuringFlaskEffect = 4680,

		[Description("Using Flask Overflowing Chalice")]
		UsingFlaskOverflowingChalice = 4681,

		[Description("Cannot Be Chained From")]
		CannotBeChainedFrom = 4682,

		[Description("Damage Taken +% If Not Hit Recently Final")]
		DamageTakenPosPctIfNotHitRecentlyFinal = 4683,

		[Description("Evasion +% If Hit Recently")]
		EvasionPosPctIfHitRecently = 4684,

		[Description("Cast Socketed Spells On X Mana Spent")]
		CastSocketedSpellsOnXManaSpent = 4685,

		[Description("Cast Socketed Spells On Mana Spent % Chance")]
		CastSocketedSpellsOnManaSpentPctChance = 4686,

		[Description("Block Chance % Vs Taunted Enemies")]
		BlockChancePctVsTauntedEnemies = 4687,

		[Description("Minion Cold Damage Resistance %")]
		MinionColdDamageResistancePct = 4688,

		[Description("Minion Physical Damage % To Add As Cold")]
		MinionPhysicalDamagePctToAddAsCold = 4689,

		[Description("Armour And Evasion Rating +% If Killed A Taunted Enemy Recently")]
		ArmourAndEvasionRatingPosPctIfKilledATauntedEnemyRecently = 4690,

		[Description("Have Killed A Taunted Enemy Recently")]
		HaveKilledATauntedEnemyRecently = 4691,

		[Description("Map Owner Master Exp Favour +%")]
		MapOwnerMasterExpFavourPosPct = 4692,

		[Description("Support Cast On Mana Spent")]
		SupportCastOnManaSpent = 4693,

		[Description("Num Of Additional Chains At Max Frenzy Charges")]
		NumOfAdditionalChainsAtMaxFrenzyCharges = 4694,

		[Description("Critical Strikes Do Not Always Freeze")]
		CriticalStrikesDoNotAlwaysFreeze = 4695,

		[Description("Damage +% For Each Level The Enemy Is Higher Than You")]
		DamagePosPctForEachLevelTheEnemyIsHigherThanYou = 4696,

		[Description("Local Unique Flask Charges Gained +% During Flask Effect")]
		LocalUniqueFlaskChargesGainedPosPctDuringFlaskEffect = 4697,

		[Description("Gain Phasing For 4 Seconds On Begin Es Recharge")]
		GainPhasingFor4SecondsOnBeginEsRecharge = 4698,

		[Description("Chance To Dodge Attacks % While Phasing")]
		ChanceToDodgeAttacksPctWhilePhasing = 4699,

		[Description("Item Found Rarity +% While Phasing")]
		ItemFoundRarityPosPctWhilePhasing = 4700,
		[Description("hexproof")] Hexproof = 4701,

		[Description("Map Monsters Are Hexproof")]
		MapMonstersAreHexproof = 4702,
		[Description("Ignore Hexproof")] IgnoreHexproof = 4703,

		[Description("Totems Attack Speed +% Per Active Totem")]
		TotemsAttackSpeedPosPctPerActiveTotem = 4704,

		[Description("Attacks Num Of Additional Chains When In Main Hand")]
		AttacksNumOfAdditionalChainsWhenInMainHand = 4705,

		[Description("Attacks Number Of Additional Projectiles")]
		AttacksNumberOfAdditionalProjectiles = 4706,

		[Description("Attacks Number Of Additional Projectiles When In Off Hand")]
		AttacksNumberOfAdditionalProjectilesWhenInOffHand = 4707,

		[Description("Counter Attacks Minimum Added Physical Damage")]
		CounterAttacksMinimumAddedPhysicalDamage = 4708,

		[Description("Counter Attacks Maximum Added Physical Damage")]
		CounterAttacksMaximumAddedPhysicalDamage = 4709,

		[Description("Golem Damage +% Per Active Golem Type")]
		GolemDamagePosPctPerActiveGolemType = 4710,

		[Description("Life +% With No Corrupted Equipped Items")]
		LifePosPctWithNoCorruptedEquippedItems = 4711,

		[Description("Life Regeneration Per Minute With No Corrupted Equipped Items")]
		LifeRegenerationPerMinuteWithNoCorruptedEquippedItems = 4712,

		[Description("Energy Shield Recharge Rate Per Minute With All Corrupted Equipped Items")]
		EnergyShieldRechargeRatePerMinuteWithAllCorruptedEquippedItems = 4713,

		[Description("Local Display Nearby Enemies Take X Chaos Damage Per Minute")]
		LocalDisplayNearbyEnemiesTakeXChaosDamagePerMinute = 4714,

		[Description("Number Of Equipped Items")]
		NumberOfEquippedItems = 4715,

		[Description("Virtual Mana Leech From Any Damage Permyriad")]
		VirtualManaLeechFromAnyDamagePermyriad = 4716,

		[Description("Virtual Current Number Of Golem Types")]
		VirtualCurrentNumberOfGolemTypes = 4717,

		[Description("Local Display Socketed Skills Summon Your Maximum Number Of Totems In Formation")]
		LocalDisplaySocketedSkillsSummonYourMaximumNumberOfTotemsInFormation = 4718,

		[Description("Energy Shield Regeneration Rate Per Minute % While On Low Life")]
		EnergyShieldRegenerationRatePerMinutePctWhileOnLowLife = 4719,

		[Description("Counter Attacks Minimum Added Cold Damage")]
		CounterAttacksMinimumAddedColdDamage = 4720,

		[Description("Counter Attacks Maximum Added Cold Damage")]
		CounterAttacksMaximumAddedColdDamage = 4721,

		[Description("Movement Speed +% If Pierced Recently")]
		MovementSpeedPosPctIfPiercedRecently = 4722,
		[Description("Have Pierced Recently")] HavePiercedRecently = 4723,

		[Description("Track Have Pierced Recently")]
		TrackHavePiercedRecently = 4724,

		[Description("Item Found Quantity +% If Wearing A Magic Item")]
		ItemFoundQuantityPosPctIfWearingAMagicItem = 4725,

		[Description("Item Found Rarity +% If Wearing A Normal Item")]
		ItemFoundRarityPosPctIfWearingANormalItem = 4726,

		[Description("Number Of Equipped Normal Items")]
		NumberOfEquippedNormalItems = 4727,

		[Description("Poison Cursed Enemies On Hit")]
		PoisonCursedEnemiesOnHit = 4728,

		[Description("Base Fire Damage % To Convert To Chaos 60% Value")]
		BaseFireDamagePctToConvertToChaos60PctValue = 4729,

		[Description("Base Lightning Damage % To Convert To Chaos 60% Value")]
		BaseLightningDamagePctToConvertToChaos60PctValue = 4730,

		[Description("Gain Onslaught For X Ms On Killing Rare Or Unique Monster")]
		GainOnslaughtForXMsOnKillingRareOrUniqueMonster = 4731,

		[Description("Kill Enemy On Hit If Under 20% Life")]
		KillEnemyOnHitIfUnder20PctLife = 4732,

		[Description("Immune To Bleeding While Leeching")]
		ImmuneToBleedingWhileLeeching = 4733,

		[Description("Damage +% If Enemy Killed Recently Final")]
		DamagePosPctIfEnemyKilledRecentlyFinal = 4734,

		[Description("Skill Area Of Effect +% If Enemy Killed Recently")]
		SkillAreaOfEffectPosPctIfEnemyKilledRecently = 4735,

		[Description("Virtual Immune To Bleeding")]
		VirtualImmuneToBleeding = 4736,

		[Description("Have Killed A Maimed Enemy Recently")]
		HaveKilledAMaimedEnemyRecently = 4737,

		[Description("Track Have Killed A Maimed Enemy Recently")]
		TrackHaveKilledAMaimedEnemyRecently = 4738,

		[Description("Skill Effect Duration +% If Killed Maimed Enemy Recently")]
		SkillEffectDurationPosPctIfKilledMaimedEnemyRecently = 4739,

		[Description("Have Taunted An Enemy Recently")]
		HaveTauntedAnEnemyRecently = 4740,

		[Description("Track Have Taunted An Enemy Recently")]
		TrackHaveTauntedAnEnemyRecently = 4741,

		[Description("Damage Taken +% If Taunted An Enemy Recently")]
		DamageTakenPosPctIfTauntedAnEnemyRecently = 4742,

		[Description("Life Regeneration Rate Per Minute % If Taunted An Enemy Recently")]
		LifeRegenerationRatePerMinutePctIfTauntedAnEnemyRecently = 4743,

		[Description("Immune To Elemental Status Ailments During Flask Effect")]
		ImmuneToElementalStatusAilmentsDuringFlaskEffect = 4744,

		[Description("Elemental Damage +% During Flask Effect")]
		ElementalDamagePosPctDuringFlaskEffect = 4745,

		[Description("Chance To Freeze Shock Ignite % During Flask Effect")]
		ChanceToFreezeShockIgnitePctDuringFlaskEffect = 4746,

		[Description("Summoned Monster Types Arent Duplicated")]
		SummonedMonsterTypesArentDuplicated = 4747,

		[Description("Slash Ancestor Totem Elemental Resistance %")]
		SlashAncestorTotemElementalResistancePct = 4748,

		[Description("Melee Ancestor Totem Grant Owner Attack Speed +%")]
		MeleeAncestorTotemGrantOwnerAttackSpeedPosPct = 4749,

		[Description("Slam Ancestor Totem Grant Owner Melee Damage +%")]
		SlamAncestorTotemGrantOwnerMeleeDamagePosPct = 4750,

		[Description("Frost Bolt Cast Speed +%")]
		FrostBoltCastSpeedPosPct = 4751,

		[Description("Frost Bolt Freeze Chance %")]
		FrostBoltFreezeChancePct = 4752,

		[Description("Frost Bolt Nova Duration +%")]
		FrostBoltNovaDurationPosPct = 4753,

		[Description("Chest Drop Additional Fire Warband Uniques")]
		ChestDropAdditionalFireWarbandUniques = 4754,

		[Description("Chest Drop Additional Cold Warband Uniques")]
		ChestDropAdditionalColdWarbandUniques = 4755,

		[Description("Chest Drop Additional Lightning Warband Uniques")]
		ChestDropAdditionalLightningWarbandUniques = 4756,

		[Description("Chest Drop Additional Chaos Warband Uniques")]
		ChestDropAdditionalChaosWarbandUniques = 4757,
		[Description("Weapons Drop Animated")] WeaponsDropAnimated = 4758,

		[Description("Es And Mana Regeneration Rate Per Minute % While On Consecrated Ground")]
		EsAndManaRegenerationRatePerMinutePctWhileOnConsecratedGround = 4759,

		[Description("Attack And Cast Speed +% While On Consecrated Ground")]
		AttackAndCastSpeedPosPctWhileOnConsecratedGround = 4760,

		[Description("Chest Display Summons Fire Warband")]
		ChestDisplaySummonsFireWarband = 4761,

		[Description("Chest Display Summons Cold Warband")]
		ChestDisplaySummonsColdWarband = 4762,

		[Description("Chest Display Summons Lightning Warband")]
		ChestDisplaySummonsLightningWarband = 4763,

		[Description("Chest Display Summons Chaos Warband")]
		ChestDisplaySummonsChaosWarband = 4764,
		[Description("Is Dominated")] IsDominated = 4765,

		[Description("Blast Rain Arrow Delay Ms")]
		BlastRainArrowDelayMs = 4766,

		[Description("Additional Block Chance % For 1 Second Every 5 Seconds")]
		AdditionalBlockChancePctFor1SecondEvery5Seconds = 4767,
		[Description("Mine Arming Speed +%")] MineArmingSpeedPosPct = 4768,

		[Description("Flasks % Chance To Not Consume Charges")]
		FlasksPctChanceToNotConsumeCharges = 4769,

		[Description("Critical Strike Chance +% Vs Bleeding Enemies")]
		CriticalStrikeChancePosPctVsBleedingEnemies = 4770,

		[Description("Physical Damage +% For 4 Seconds When You Block A Unique Enemy Hit")]
		PhysicalDamagePosPctFor4SecondsWhenYouBlockAUniqueEnemyHit = 4771,

		[Description("Your Consecrated Ground Grants Damage +%")]
		YourConsecratedGroundGrantsDamagePosPct = 4772,

		[Description("Attack Speed +% If Enemy Not Killed Recently")]
		AttackSpeedPosPctIfEnemyNotKilledRecently = 4773,

		[Description("Physical Damage +% While At Maximum Frenzy Charges Final")]
		PhysicalDamagePosPctWhileAtMaximumFrenzyChargesFinal = 4774,

		[Description("Physical Damage Taken +% While At Maximum Endurance Charges")]
		PhysicalDamageTakenPosPctWhileAtMaximumEnduranceCharges = 4775,

		[Description("Totem Damage Leeched As Life To You Permyriad")]
		TotemDamageLeechedAsLifeToYouPermyriad = 4776,

		[Description("Damage Leeched As Life To Parent Permyriad")]
		DamageLeechedAsLifeToParentPermyriad = 4777,

		[Description("Attack Speed +% Per 200 Accuracy Rating")]
		AttackSpeedPosPctPer200AccuracyRating = 4778,

		[Description("Gain Phasing While At Maximum Frenzy Charges")]
		GainPhasingWhileAtMaximumFrenzyCharges = 4779,

		[Description("Gain Phasing While You Have Onslaught")]
		GainPhasingWhileYouHaveOnslaught = 4780,

		[Description("Gain Maximum Endurance Charges On Endurance Charge Gained % Chance")]
		GainMaximumEnduranceChargesOnEnduranceChargeGainedPctChance = 4781,

		[Description("Elementalist Skill Area Of Effect +% For 4 Seconds Every 10 Seconds")]
		ElementalistSkillAreaOfEffectPosPctFor4SecondsEvery10Seconds = 4782,

		[Description("Physical Damage % To Add As Chaos Vs Bleeding Enemies")]
		PhysicalDamagePctToAddAsChaosVsBleedingEnemies = 4783,

		[Description("Elemental Resistances +% For You And Allies Affected By Your Auras")]
		ElementalResistancesPosPctForYouAndAlliesAffectedByYourAuras = 4784,

		[Description("Gain X Life On Trap Triggered By An Enemy")]
		GainXLifeOnTrapTriggeredByAnEnemy = 4785,

		[Description("Gain X Es On Trap Triggered By An Enemy")]
		GainXEsOnTrapTriggeredByAnEnemy = 4786,

		[Description("Phasing % For 3 Seconds On Trap Triggered By An Enemy")]
		PhasingPctFor3SecondsOnTrapTriggeredByAnEnemy = 4787,

		[Description("Visual Always Use Smallest Blood Effect")]
		VisualAlwaysUseSmallestBloodEffect = 4788,

		[Description("Attack Skills Additional Totems Allowed")]
		AttackSkillsAdditionalTotemsAllowed = 4789,

		[Description("Global Defences +% Per White Socket On Item")]
		GlobalDefencesPosPctPerWhiteSocketOnItem = 4790,

		[Description("Global Total Minimum Added Cold Damage")]
		GlobalTotalMinimumAddedColdDamage = 4791,

		[Description("Global Total Maximum Added Cold Damage")]
		GlobalTotalMaximumAddedColdDamage = 4792,

		[Description("Poison From Critical Strikes Damage +% Final")]
		PoisonFromCriticalStrikesDamagePosPctFinal = 4793,

		[Description("Bleed Damage +% Vs Maimed Enemies Final")]
		BleedDamagePosPctVsMaimedEnemiesFinal = 4794,

		[Description("Flask Charges +% From Enemies With Status Ailments")]
		FlaskChargesPosPctFromEnemiesWithStatusAilments = 4795,

		[Description("Mana Cost +% While On Full Energy Shield")]
		ManaCostPosPctWhileOnFullEnergyShield = 4796,

		[Description("Permanently Intimidate Enemies You Hit On Full Life")]
		PermanentlyIntimidateEnemiesYouHitOnFullLife = 4797,

		[Description("Number Of Corpses Consumed Recently")]
		NumberOfCorpsesConsumedRecently = 4798,

		[Description("Track Number Of Corpses Consumed Recently")]
		TrackNumberOfCorpsesConsumedRecently = 4799,

		[Description("Damage +% If You Have Consumed A Corpse Recently")]
		DamagePosPctIfYouHaveConsumedACorpseRecently = 4800,

		[Description("Attack And Cast Speed +% Per Corpse Consumed Recently")]
		AttackAndCastSpeedPosPctPerCorpseConsumedRecently = 4801,

		[Description("Armour And Evasion +% While Fortified")]
		ArmourAndEvasionPosPctWhileFortified = 4802,

		[Description("Melee Damage +% While Fortified")]
		MeleeDamagePosPctWhileFortified = 4803,

		[Description("Desecrate Creates X Additional Corpses")]
		DesecrateCreatesXAdditionalCorpses = 4804,

		[Description("Mana Regeneration Rate +% While Phasing")]
		ManaRegenerationRatePosPctWhilePhasing = 4805,

		[Description("Chaos Skill Effect Duration +%")]
		ChaosSkillEffectDurationPosPct = 4806,

		[Description("Damage +% Final Vs Non Taunt Target From Ot")]
		DamagePosPctFinalVsNonTauntTargetFromOt = 4807,

		[Description("Damage +% Final Vs Non Taunt Target From Passive")]
		DamagePosPctFinalVsNonTauntTargetFromPassive = 4808,

		[Description("Damage +% Final From Damaging Non Taunt Target")]
		DamagePosPctFinalFromDamagingNonTauntTarget = 4809,

		[Description("Taunted Enemies Damage +% Final Vs Non Taunt Target")]
		TauntedEnemiesDamagePosPctFinalVsNonTauntTarget = 4810,

		[Description("Chest Drop Additional Deshret Uniques")]
		ChestDropAdditionalDeshretUniques = 4811,

		[Description("Chest Drop Additional Rare Maraketh Weapons")]
		ChestDropAdditionalRareMarakethWeapons = 4812,

		[Description("Chest Display Spawns Torment Spirits Continuously")]
		ChestDisplaySpawnsTormentSpiritsContinuously = 4813,

		[Description("Chance To Cast On Owned Kill %")]
		ChanceToCastOnOwnedKillPct = 4814,

		[Description("Local Flask Cannot Be Stunned During Flask Effect")]
		LocalFlaskCannotBeStunnedDuringFlaskEffect = 4815,

		[Description("Local Flask Lose All Charges On Entering New Area")]
		LocalFlaskLoseAllChargesOnEnteringNewArea = 4816,

		[Description("Summon Specific Monsters Radius +%")]
		SummonSpecificMonstersRadiusPosPct = 4817,

		[Description("Monster Drop Additional Currency Items With Quality")]
		MonsterDropAdditionalCurrencyItemsWithQuality = 4818,

		[Description("Prophecy Spawned Monster Magic Minimum Rarity")]
		ProphecySpawnedMonsterMagicMinimumRarity = 4819,

		[Description("Gain Life Leech On Kill Permyriad")]
		GainLifeLeechOnKillPermyriad = 4820,
		[Description("Immune To Shock")] ImmuneToShock = 4821,
		[Description("Poison On Melee Hit")] PoisonOnMeleeHit = 4822,

		[Description("Life Leech Permyriad Vs Cursed Enemies")]
		LifeLeechPermyriadVsCursedEnemies = 4823,

		[Description("Movement Speed +% If Enemy Killed Recently")]
		MovementSpeedPosPctIfEnemyKilledRecently = 4824,

		[Description("Local Display Socketed Gems Supported By X Controlled Destruction")]
		LocalDisplaySocketedGemsSupportedByXControlledDestruction = 4825,

		[Description("Local Unique Flask Kiaras Determination")]
		LocalUniqueFlaskKiarasDetermination = 4826,

		[Description("Map Items Dropped Are Mirrored")]
		MapItemsDroppedAreMirrored = 4827,

		[Description("Monster Is Corrupted Display")]
		MonsterIsCorruptedDisplay = 4828,

		[Description("Monster Casts Fire Nova Text")]
		MonsterCastsFireNovaText = 4829,

		[Description("Monster Casts Flask Charge Nova Text")]
		MonsterCastsFlaskChargeNovaText = 4830,

		[Description("Monster Has Damage Taken Aura Text")]
		MonsterHasDamageTakenAuraText = 4831,

		[Description("Monster Has Temporal Chains Aura Text")]
		MonsterHasTemporalChainsAuraText = 4832,

		[Description("Monster Has Movement Skill Damage Aura Text")]
		MonsterHasMovementSkillDamageAuraText = 4833,

		[Description("Monster Casts Bleed Nova Text")]
		MonsterCastsBleedNovaText = 4834,

		[Description("Weapon Physical Damage % To Add As Each Element")]
		WeaponPhysicalDamagePctToAddAsEachElement = 4835,

		[Description("Map Force Labyrinth Trial")]
		MapForceLabyrinthTrial = 4836,

		[Description("Unique Cold Damage Can Also Ignite")]
		UniqueColdDamageCanAlsoIgnite = 4837,

		[Description("Monster Throws Chaos Bombs Text")]
		MonsterThrowsChaosBombsText = 4838,

		[Description("Attack Trigger On Melee Hit %")]
		AttackTriggerOnMeleeHitPct = 4839,

		[Description("Physical Damage % Added As Fire Damage If Enemy Killed Recently By You Or Your Totems")]
		PhysicalDamagePctAddedAsFireDamageIfEnemyKilledRecentlyByYouOrYourTotems = 4840,

		[Description("Give Parent Physical Damage % Added As Fire Damage If Enemy Killed Recently")]
		GiveParentPhysicalDamagePctAddedAsFireDamageIfEnemyKilledRecently = 4841,

		[Description("Unique Boss Curse Effect On Self +% Final")]
		UniqueBossCurseEffectOnSelfPosPctFinal = 4842,

		[Description("Chest Drop Additional Unique Item Divination Cards")]
		ChestDropAdditionalUniqueItemDivinationCards = 4843,

		[Description("Chest Drop Additional Corrupted Item Divination Cards")]
		ChestDropAdditionalCorruptedItemDivinationCards = 4844,

		[Description("Chest Drop Additional Currency Item Divination Cards")]
		ChestDropAdditionalCurrencyItemDivinationCards = 4845,

		[Description("Chest Drop Additional Divination Cards From Current World Area")]
		ChestDropAdditionalDivinationCardsFromCurrentWorldArea = 4846,

		[Description("Chest Drop Additional Divination Cards From Same Set")]
		ChestDropAdditionalDivinationCardsFromSameSet = 4847,

		[Description("Global Critical Strike Chance While Dual Wielding +%")]
		GlobalCriticalStrikeChanceWhileDualWieldingPosPct = 4848,

		[Description("Global Critical Strike Multiplier While Dual Wielding +")]
		GlobalCriticalStrikeMultiplierWhileDualWieldingPos = 4849,

		[Description("Doom Arrow Number Of Arrows")]
		DoomArrowNumberOfArrows = 4850,

		[Description("Stance Movement Speed +% Final")]
		StanceMovementSpeedPosPctFinal = 4851,

		[Description("Base Physical Damage Reduction And Evasion Rating")]
		BasePhysicalDamageReductionAndEvasionRating = 4852,

		[Description("First Blood Extra Gore")]
		FirstBloodExtraGore = 4853,

		[Description("Cast When Triggered By Other Skill %")]
		CastWhenTriggeredByOtherSkillPct = 4854,

		[Description("Local Display Socketed Gems Minimum Added Fire Damage")]
		LocalDisplaySocketedGemsMinimumAddedFireDamage = 4855,

		[Description("Local Display Socketed Gems Maximum Added Fire Damage")]
		LocalDisplaySocketedGemsMaximumAddedFireDamage = 4856,

		[Description("Local Display Socketed Gems Attack And Cast Speed +% Final")]
		LocalDisplaySocketedGemsAttackAndCastSpeedPosPctFinal = 4857,

		[Description("Local Display Socketed Gems Physical Damage % To Add As Lightning")]
		LocalDisplaySocketedGemsPhysicalDamagePctToAddAsLightning = 4858,

		[Description("Local Display Socketed Gems Elemental Damage +% Final")]
		LocalDisplaySocketedGemsElementalDamagePosPctFinal = 4859,

		[Description("Curse Nova Damage +% Final Per Curse Removed")]
		CurseNovaDamagePosPctFinalPerCurseRemoved = 4860,

		[Description("Elemental Penetration % During Flask Effect")]
		ElementalPenetrationPctDuringFlaskEffect = 4861,

		[Description("Additional Physical Damage Reduction % During Flask Effect")]
		AdditionalPhysicalDamageReductionPctDuringFlaskEffect = 4862,

		[Description("Reflect Damage Taken +%")]
		ReflectDamageTakenPosPct = 4863,

		[Description("Power Charge On Block % Chance")]
		PowerChargeOnBlockPctChance = 4864,

		[Description("Nearby Enemies Chilled On Block")]
		NearbyEnemiesChilledOnBlock = 4865,

		[Description("Arrow Projectile Variation")]
		ArrowProjectileVariation = 4866,

		[Description("Essence Buff Elemental Damage Taken +%")]
		EssenceBuffElementalDamageTakenPosPct = 4867,

		[Description("Essence Buff Ground Fire Damage To Deal Per Second")]
		EssenceBuffGroundFireDamageToDealPerSecond = 4868,

		[Description("Essence Buff Ground Fire Duration Ms")]
		EssenceBuffGroundFireDurationMs = 4869,

		[Description("Trigger Spawners Override Row")]
		TriggerSpawnersOverrideRow = 4870,

		[Description("Trigger Spawners Max Count")]
		TriggerSpawnersMaxCount = 4871,
		[Description("Map Race Data")] MapRaceData = 4872,

		[Description("Map Packs Have Pop Up Traps")]
		MapPacksHavePopUpTraps = 4873,

		[Description("Permanent Damage Taken +% On Minion Death")]
		PermanentDamageTakenPosPctOnMinionDeath = 4874,

		[Description("Permanent Actor Scale +% On Minion Death")]
		PermanentActorScalePosPctOnMinionDeath = 4875,

		[Description("Permanent Item Quantity +% On Minion Death")]
		PermanentItemQuantityPosPctOnMinionDeath = 4876,

		[Description("Permanent Item Rarity +% On Minion Death")]
		PermanentItemRarityPosPctOnMinionDeath = 4877,

		[Description("Ground Maelstrom Art Variation")]
		GroundMaelstromArtVariation = 4878,

		[Description("Do Not Revive After Time")]
		DoNotReviveAfterTime = 4879,

		[Description("Chaos Damage Taken Over Time +%")]
		ChaosDamageTakenOverTimePosPct = 4880,

		[Description("Local Display Socketed Gems Additional Critical Strike Chance %")]
		LocalDisplaySocketedGemsAdditionalCriticalStrikeChancePct = 4881,

		[Description("Attack And Cast Speed +% During Flask Effect")]
		AttackAndCastSpeedPosPctDuringFlaskEffect = 4882,

		[Description("Minimum Added Cold Damage Per Frenzy Charge")]
		MinimumAddedColdDamagePerFrenzyCharge = 4883,

		[Description("Maximum Added Cold Damage Per Frenzy Charge")]
		MaximumAddedColdDamagePerFrenzyCharge = 4884,

		[Description("Minimum Added Fire Damage If Blocked Recently")]
		MinimumAddedFireDamageIfBlockedRecently = 4885,

		[Description("Maximum Added Fire Damage If Blocked Recently")]
		MaximumAddedFireDamageIfBlockedRecently = 4886,

		[Description("Track Have Blocked Attack Recently")]
		TrackHaveBlockedAttackRecently = 4887,

		[Description("Have Blocked Attack Recently")]
		HaveBlockedAttackRecently = 4888,

		[Description("Global Total Minimum Added Fire Damage")]
		GlobalTotalMinimumAddedFireDamage = 4889,

		[Description("Global Total Maximum Added Fire Damage")]
		GlobalTotalMaximumAddedFireDamage = 4890,

		[Description("Stun Threshold Based On Energy Shield Instead Of Life")]
		StunThresholdBasedOnEnergyShieldInsteadOfLife = 4891,

		[Description("Cannot Leech Life From Critical Strikes")]
		CannotLeechLifeFromCriticalStrikes = 4892,

		[Description("% Chance To Blind On Critical Strike")]
		Pctchancetoblindoncriticalstrike = 4893,

		[Description("Bleed On Melee Critical Strike")]
		BleedOnMeleeCriticalStrike = 4894,
		[Description("Map Has Monoliths")] MapHasMonoliths = 4895,
		[Description("In Lava")] InLava = 4896,

		[Description("Base Life Regeneration Per Minute % While In Lava")]
		BaseLifeRegenerationPerMinutePctWhileInLava = 4897,

		[Description("Lava Buff Effect On Self +%")]
		LavaBuffEffectOnSelfPosPct = 4898,

		[Description("Current Fire Beam Stacks")]
		CurrentFireBeamStacks = 4899,
		[Description("Max Fire Beam Stacks")] MaxFireBeamStacks = 4900,

		[Description("Marker Warp Marker Variation")]
		MarkerWarpMarkerVariation = 4901,

		[Description("Self Take No Extra Damage From Critical Strikes")]
		SelfTakeNoExtraDamageFromCriticalStrikes = 4902,

		[Description("Enemies You Shock Cast Speed +%")]
		EnemiesYouShockCastSpeedPosPct = 4903,

		[Description("Enemies You Shock Movement Speed +%")]
		EnemiesYouShockMovementSpeedPosPct = 4904,

		[Description("Burning Damage +% If Ignited An Enemy Recently")]
		BurningDamagePosPctIfIgnitedAnEnemyRecently = 4905,

		[Description("Recover % Maximum Life On Enemy Ignited")]
		RecoverPctMaximumLifeOnEnemyIgnited = 4906,

		[Description("Melee Physical Damage +% Vs Ignited Enemies")]
		MeleePhysicalDamagePosPctVsIgnitedEnemies = 4907,

		[Description("Critical Strike Chance +% For Forking Arrows")]
		CriticalStrikeChancePosPctForForkingArrows = 4908,

		[Description("Arrows Always Pierce After Chaining")]
		ArrowsAlwaysPierceAfterChaining = 4909,

		[Description("Arrows That Pierce Cause Bleeding")]
		ArrowsThatPierceCauseBleeding = 4910,

		[Description("Spells Number Of Additional Projectiles")]
		SpellsNumberOfAdditionalProjectiles = 4911,

		[Description("Minion Damage +% If Enemy Hit Recently")]
		MinionDamagePosPctIfEnemyHitRecently = 4912,

		[Description("Have Hit An Enemy Recently")]
		HaveHitAnEnemyRecently = 4913,

		[Description("Track Have Hit An Enemy Recently")]
		TrackHaveHitAnEnemyRecently = 4914,

		[Description("Minion Damage Increases And Reductions Also Affects You")]
		MinionDamageIncreasesAndReductionsAlsoAffectsYou = 4915,

		[Description("Projectile Attack Damage +% Per 200 Accuracy")]
		ProjectileAttackDamagePosPctPer200Accuracy = 4916,

		[Description("Map Bosses Have Union Of Souls")]
		MapBossesHaveUnionOfSouls = 4917,
		[Description("Map Extra Monoliths")] MapExtraMonoliths = 4918,

		[Description("Minion Dies When Parent Deleted")]
		MinionDiesWhenParentDeleted = 4919,

		[Description("Spectral Throw Projectile Scale +%")]
		SpectralThrowProjectileScalePosPct = 4920,

		[Description("Gain Onslaught For 3 Seconds % Chance When Hit")]
		GainOnslaughtFor3SecondsPctChanceWhenHit = 4921,

		[Description("Local Display Socketed Gems Damage Over Time +% Final")]
		LocalDisplaySocketedGemsDamageOverTimePosPctFinal = 4922,

		[Description("Deal Chaos Damage Per Second For 10 Seconds On Hit")]
		DealChaosDamagePerSecondFor10SecondsOnHit = 4923,

		[Description("Movement Speed +% While On Burning Chilled Shocked Ground")]
		MovementSpeedPosPctWhileOnBurningChilledShockedGround = 4924,

		[Description("Mana % Gained On Block")]
		ManaPctGainedOnBlock = 4925,

		[Description("Projectiles Drop Caustic Cloud")]
		ProjectilesDropCausticCloud = 4926,

		[Description("Base Projectile Ground Caustic Cloud Damage Per Minute")]
		BaseProjectileGroundCausticCloudDamagePerMinute = 4927,

		[Description("Local Display Socketed Non Curse Aura Gems Effect +%")]
		LocalDisplaySocketedNonCurseAuraGemsEffectPosPct = 4928,

		[Description("Local Display Fire Burst On Hit %")]
		LocalDisplayFireBurstOnHitPct = 4929,

		[Description("Essence Support Attack And Cast Speed +% Final")]
		EssenceSupportAttackAndCastSpeedPosPctFinal = 4930,

		[Description("Essence Support Elemental Damage +% Final")]
		EssenceSupportElementalDamagePosPctFinal = 4931,

		[Description("Base Number Of Essence Spirits Allowed")]
		BaseNumberOfEssenceSpiritsAllowed = 4932,

		[Description("Number Of Essence Spirits Allowed")]
		NumberOfEssenceSpiritsAllowed = 4933,

		[Description("Number Of Active Essence Spirits")]
		NumberOfActiveEssenceSpirits = 4934,

		[Description("Chest Drop Additional Prophecy Coins")]
		ChestDropAdditionalProphecyCoins = 4935,

		[Description("Ground Effect Variation")]
		GroundEffectVariation = 4936,

		[Description("Essence Support Damage Over Time +% Final")]
		EssenceSupportDamageOverTimePosPctFinal = 4937,

		[Description("Local Unique Jewel Spectres Gain Soul Eater On Kill % Chance With 50 Int In Radius")]
		LocalUniqueJewelSpectresGainSoulEaterOnKillPctChanceWith50IntInRadius = 4938,

		[Description("Spectres Gain Soul Eater For 30 Seconds On Kill % Chance")]
		SpectresGainSoulEaterFor30SecondsOnKillPctChance = 4939,

		[Description("Gain Soul Eater For 30 Seconds On Kill % Chance")]
		GainSoulEaterFor30SecondsOnKillPctChance = 4940,

		[Description("Local Unique Cast Socketed Cold Skills On Melee Critical Strike")]
		LocalUniqueCastSocketedColdSkillsOnMeleeCriticalStrike = 4941,

		[Description("Main Hand Local Unique Cast Socketed Cold Skills On Melee Critical Strike")]
		MainHandLocalUniqueCastSocketedColdSkillsOnMeleeCriticalStrike = 4942,

		[Description("Off Hand Local Unique Cast Socketed Cold Skills On Melee Critical Strike")]
		OffHandLocalUniqueCastSocketedColdSkillsOnMeleeCriticalStrike = 4943,

		[Description("Global Critical Strike Chance +% Vs Chilled Enemies")]
		GlobalCriticalStrikeChancePosPctVsChilledEnemies = 4944,

		[Description("Unique Cospris Malice Cold Spells Triggered")]
		UniqueCosprisMaliceColdSpellsTriggered = 4945,

		[Description("Projectile Ground Caustic Cloud Radius")]
		ProjectileGroundCausticCloudRadius = 4946,

		[Description("Gain Phasing If Enemy Killed Recently")]
		GainPhasingIfEnemyKilledRecently = 4947,

		[Description("Movement Skills Deal No Physical Damage")]
		MovementSkillsDealNoPhysicalDamage = 4948,
		[Description("X Mana Per 4 Strength")] XManaPer4Strength = 4949,

		[Description("Energy Shield +% Per 10 Strength")]
		EnergyShieldPosPctPer10Strength = 4950,

		[Description("X Life Per 4 Dexterity")]
		XLifePer4Dexterity = 4951,

		[Description("Melee Physical Damage +% Per 10 Dexterity")]
		MeleePhysicalDamagePosPctPer10Dexterity = 4952,

		[Description("X Accuracy Per 2 Intelligence")]
		XAccuracyPer2Intelligence = 4953,

		[Description("Evasion +% Per 10 Intelligence")]
		EvasionPosPctPer10Intelligence = 4954,

		[Description("Maximum Life % To Add As Maximum Armour")]
		MaximumLifePctToAddAsMaximumArmour = 4955,

		[Description("Monster No Drops If Death Timer Expired")]
		MonsterNoDropsIfDeathTimerExpired = 4956,

		[Description("Attack Area Of Effect +%")]
		AttackAreaOfEffectPosPct = 4957,

		[Description("Physical Damage Can Shock")]
		PhysicalDamageCanShock = 4958,

		[Description("Deal No Elemental Damage")]
		DealNoElementalDamage = 4959,
		[Description("Immune To Freeze")] ImmuneToFreeze = 4960,
		[Description("Immune To Ignite")] ImmuneToIgnite = 4961,
		[Description("Immune To Chill")] ImmuneToChill = 4962,

		[Description("Monster Drop No Essences")]
		MonsterDropNoEssences = 4963,
		[Description("Base Immune To Freeze")] BaseImmuneToFreeze = 4964,
		[Description("Base Immune To Chill")] BaseImmuneToChill = 4965,
		[Description("Base Immune To Ignite")] BaseImmuneToIgnite = 4966,
		[Description("Base Immune To Shock")] BaseImmuneToShock = 4967,

		[Description("Base Cannot Gain Bleeding")]
		BaseCannotGainBleeding = 4968,

		[Description("Map Boss Dropped Unique Items +")]
		MapBossDroppedUniqueItemsPos = 4969,

		[Description("Map Boss Drops Corrupted Items")]
		MapBossDropsCorruptedItems = 4970,

		[Description("Map Players And Monsters Damage +% Per Curse")]
		MapPlayersAndMonstersDamagePosPctPerCurse = 4971,

		[Description("Map Players And Monsters Critical Strike Chance +%")]
		MapPlayersAndMonstersCriticalStrikeChancePosPct = 4972,

		[Description("Map Monsters Steal Charges")]
		MapMonstersStealCharges = 4973,

		[Description("Map Unidentified Maps Item Quantity +%")]
		MapUnidentifiedMapsItemQuantityPosPct = 4974,

		[Description("Map Boss Dropped Item Quantity +%")]
		MapBossDroppedItemQuantityPosPct = 4975,

		[Description("Map Number Of Additional Mods")]
		MapNumberOfAdditionalMods = 4976,

		[Description("Map Nemesis Dropped Items +")]
		MapNemesisDroppedItemsPos = 4977,
		[Description("Map Contains Master")] MapContainsMaster = 4978,
		[Description("Buff Impl Stat")] BuffImplStat = 4979,
		[Description("Cannot Be Shocked")] CannotBeShocked = 4980,
		[Description("Restore Skill Life %")] RestoreSkillLifePct = 4981,
		[Description("Restore Skill Mana %")] RestoreSkillManaPct = 4982,
		[Description("Restore Skill Es %")] RestoreSkillEsPct = 4983,

		[Description("Ground Tar Art Variation")]
		GroundTarArtVariation = 4984,

		[Description("Fire Damage Taken When Enemy Ignited")]
		FireDamageTakenWhenEnemyIgnited = 4985,

		[Description("Life Leech From Fire Damage While Ignited Permyriad")]
		LifeLeechFromFireDamageWhileIgnitedPermyriad = 4986,

		[Description("Action Ignores Crit Tracking")]
		ActionIgnoresCritTracking = 4987,

		[Description("Movement Velocity While Spider +%")]
		MovementVelocityWhileSpiderPosPct = 4988,
		[Description("Is Spider")] IsSpider = 4989,

		[Description("Projectile Attack Damage +%")]
		ProjectileAttackDamagePosPct = 4990,

		[Description("Covered In Spiders Damage +% Final")]
		CoveredInSpidersDamagePosPctFinal = 4991,

		[Description("Covered In Spiders Attack And Cast Speed +% Final")]
		CoveredInSpidersAttackAndCastSpeedPosPctFinal = 4992,

		[Description("Map Create Instance Terrain Plugin")]
		MapCreateInstanceTerrainPlugin = 4993,

		[Description("Monster Map Boss Take Critical Strike Chance +% Final")]
		MonsterMapBossTakeCriticalStrikeChancePosPctFinal = 4994,

		[Description("Monster Map Boss Extra Damage Taken From Crit +% Final")]
		MonsterMapBossExtraDamageTakenFromCritPosPctFinal = 4995,

		[Description("Extra Damage Taken From Crit +%")]
		ExtraDamageTakenFromCritPosPct = 4996,

		[Description("Chance To Gain Frenzy Charge On Stun %")]
		ChanceToGainFrenzyChargeOnStunPct = 4997,

		[Description("Local Unique Flask Damage Over Time +% During Flask Effect")]
		LocalUniqueFlaskDamageOverTimePosPctDuringFlaskEffect = 4998,

		[Description("Local Unique Flask Nearby Enemies Cursed With Level X Despair During Flask Effect")]
		LocalUniqueFlaskNearbyEnemiesCursedWithLevelXDespairDuringFlaskEffect = 4999,

		[Description("Restore Skill Life Regeneration Rate Per Minute %")]
		RestoreSkillLifeRegenerationRatePerMinutePct = 5000,

		[Description("Restore Skill Mana Regeneration Rate Per Minute %")]
		RestoreSkillManaRegenerationRatePerMinutePct = 5001,

		[Description("Restore Skill Es Regeneration Rate Per Minute %")]
		RestoreSkillEsRegenerationRatePerMinutePct = 5002,

		[Description("Projectiles Pierce While Phasing")]
		ProjectilesPierceWhilePhasing = 5003,

		[Description("Avoid Projectiles While Phasing % Chance")]
		AvoidProjectilesWhilePhasingPctChance = 5004,

		[Description("Essence Display Drop Burning Ground While Moving Fire Damage Per Second")]
		EssenceDisplayDropBurningGroundWhileMovingFireDamagePerSecond = 5005,

		[Description("Essence Display Elemental Damage Taken While Not Moving +%")]
		EssenceDisplayElementalDamageTakenWhileNotMovingPosPct = 5006,

		[Description("Local Flask Area Of Effect +% During Flask Effect")]
		LocalFlaskAreaOfEffectPosPctDuringFlaskEffect = 5007,

		[Description("Local Flask Number Of Additional Projectiles During Flask Effect")]
		LocalFlaskNumberOfAdditionalProjectilesDuringFlaskEffect = 5008,

		[Description("Corrupted Blood On Hit Duration")]
		CorruptedBloodOnHitDuration = 5009,

		[Description("Take No Actions While Parent Dead")]
		TakeNoActionsWhileParentDead = 5010,
		[Description("Cast On Hide %")] CastOnHidePct = 5011,

		[Description("Map Item Level Override")]
		MapItemLevelOverride = 5012,

		[Description("Hallowed Ground Boss Use Clone Attack")]
		HallowedGroundBossUseCloneAttack = 5013,

		[Description("Hallowed Ground Boss Drop Tar On Ground Slam")]
		HallowedGroundBossDropTarOnGroundSlam = 5014,

		[Description("Drop Ground Tar On Hit %")]
		DropGroundTarOnHitPct = 5015,

		[Description("Map Drop Stacked Deck On Death Permyriad")]
		MapDropStackedDeckOnDeathPermyriad = 5016,

		[Description("Magic Monster Dropped Item Rarity +%")]
		MagicMonsterDroppedItemRarityPosPct = 5017,

		[Description("Normal Monster Dropped Item Quantity +%")]
		NormalMonsterDroppedItemQuantityPosPct = 5018,

		[Description("Map Player Has Level X Projectile Weakness")]
		MapPlayerHasLevelXProjectileWeakness = 5019,

		[Description("Map Player Has Level X Conductivity")]
		MapPlayerHasLevelXConductivity = 5020,

		[Description("Map Player Has Level X Flammability")]
		MapPlayerHasLevelXFlammability = 5021,

		[Description("Map Player Has Level X Frostbite")]
		MapPlayerHasLevelXFrostbite = 5022,

		[Description("Support Cast On Crit Spell Damage +% Final")]
		SupportCastOnCritSpellDamagePosPctFinal = 5023,

		[Description("Support Cast On Melee Kill Spell Damage +% Final")]
		SupportCastOnMeleeKillSpellDamagePosPctFinal = 5024,

		[Description("Avoid Projectiles % Chance")]
		AvoidProjectilesPctChance = 5025,

		[Description("Monster Inside Monolith")]
		MonsterInsideMonolith = 5026,

		[Description("Map Spawn Extra Perandus Chests")]
		MapSpawnExtraPerandusChests = 5027,

		[Description("Map Spawn Cadiro % Chance")]
		MapSpawnCadiroPctChance = 5028,
		[Description("Cast On Unhide %")] CastOnUnhidePct = 5029,

		[Description("Map Players And Monsters Have Resolute Technique")]
		MapPlayersAndMonstersHaveResoluteTechnique = 5030,

		[Description("Map Resolute Technique")]
		MapResoluteTechnique = 5031,

		[Description("Map Unique Boss Drops Divination Cards")]
		MapUniqueBossDropsDivinationCards = 5032,
		[Description("All Damage Can Chill")] AllDamageCanChill = 5033,
		[Description("All Damage Can Shock")] AllDamageCanShock = 5034,
		[Description("All Damage Can Ignite")] AllDamageCanIgnite = 5035,

		[Description("Elementalist Gain Shaper Of Desolation Every 10 Seconds")]
		ElementalistGainShaperOfDesolationEvery10Seconds = 5036,

		[Description("Monster Delay Item Drops Millis")]
		MonsterDelayItemDropsMillis = 5037,

		[Description("Map Area Contains Grandmaster Ally")]
		MapAreaContainsGrandmasterAlly = 5038,

		[Description("Map Contains Creeping Agony")]
		MapContainsCreepingAgony = 5039,

		[Description("Map Portals Do Not Expire")]
		MapPortalsDoNotExpire = 5040,

		[Description("Map Monsters Are Converted On Kill")]
		MapMonstersAreConvertedOnKill = 5041,

		[Description("Map Contains X Fewer Portals")]
		MapContainsXFewerPortals = 5042,

		[Description("Monsters Are Converted On Kill")]
		MonstersAreConvertedOnKill = 5043,

		[Description("Map No Uniques Drop Randomly")]
		MapNoUniquesDropRandomly = 5044,

		[Description("Map Players Additional Number Of Projectiles")]
		MapPlayersAdditionalNumberOfProjectiles = 5045,

		[Description("Map Damage +% Of Type Inflicted By Current Ground Effect You Are On")]
		MapDamagePosPctOfTypeInflictedByCurrentGroundEffectYouAreOn = 5046,
		[Description("On Desecrated Ground")] OnDesecratedGround = 5047,

		[Description("Map Players And Monsters Curses Are Reflected")]
		MapPlayersAndMonstersCursesAreReflected = 5048,

		[Description("Map Player Has Level X Silence")]
		MapPlayerHasLevelXSilence = 5049,

		[Description("Map Strongbox Items Dropped Are Mirrored")]
		MapStrongboxItemsDroppedAreMirrored = 5050,

		[Description("Map Players Are Poisoned While Moving Chaos Damage Per Second")]
		MapPlayersArePoisonedWhileMovingChaosDamagePerSecond = 5051,

		[Description("Discharge Triggered Damage +% Final")]
		DischargeTriggeredDamagePosPctFinal = 5052,

		[Description("Map Normal Items Drop As Magic")]
		MapNormalItemsDropAsMagic = 5053,

		[Description("Monster No Additional Player Scaling")]
		MonsterNoAdditionalPlayerScaling = 5054,

		[Description("Phase Through Objects While Spider")]
		PhaseThroughObjectsWhileSpider = 5055,

		[Description("Map Flask Charges Recovered Per 3 Seconds %")]
		MapFlaskChargesRecoveredPer3SecondsPct = 5056,

		[Description("Virtual Flask Charges Recovered Per 3 Seconds %")]
		VirtualFlaskChargesRecoveredPer3SecondsPct = 5057,

		[Description("Combined Hit All Damage +% Final")]
		CombinedHitAllDamagePosPctFinal = 5058,

		[Description("Support Remote Mine Hit Damage +% Final")]
		SupportRemoteMineHitDamagePosPctFinal = 5059,

		[Description("Map Magic Items Drop As Normal")]
		MapMagicItemsDropAsNormal = 5060,

		[Description("Flask Charges Recovered Per 3 Seconds %")]
		FlaskChargesRecoveredPer3SecondsPct = 5061,

		[Description("Support Trap Hit Damage +% Final")]
		SupportTrapHitDamagePosPctFinal = 5062,

		[Description("Damage Vs Tiki Totems +%")]
		DamageVsTikiTotemsPosPct = 5063,
		[Description("Is Tiki Totem")] IsTikiTotem = 5064,

		[Description("Self Ignite Duration +% Final")]
		SelfIgniteDurationPosPctFinal = 5065,

		[Description("Self Bleed Duration +% Final")]
		SelfBleedDurationPosPctFinal = 5066,

		[Description("Self Poison Duration +% Final")]
		SelfPoisonDurationPosPctFinal = 5067,

		[Description("Treasure Pile Damage +% Final")]
		TreasurePileDamagePosPctFinal = 5068,

		[Description("Map Contains Additional Packs Of Fire Monsters")]
		MapContainsAdditionalPacksOfFireMonsters = 5069,

		[Description("Map Contains Additional Packs Of Chaos Monsters")]
		MapContainsAdditionalPacksOfChaosMonsters = 5070,

		[Description("Map Contains Additional Packs Of Physical Monsters")]
		MapContainsAdditionalPacksOfPhysicalMonsters = 5071,

		[Description("Map Contains Additional Packs Of Lightning Monsters")]
		MapContainsAdditionalPacksOfLightningMonsters = 5072,

		[Description("Map Contains Additional Packs Of Cold Monsters")]
		MapContainsAdditionalPacksOfColdMonsters = 5073,

		[Description("Map Players And Monsters Fire Damage Taken +%")]
		MapPlayersAndMonstersFireDamageTakenPosPct = 5074,

		[Description("Map Players And Monsters Chaos Damage Taken +%")]
		MapPlayersAndMonstersChaosDamageTakenPosPct = 5075,

		[Description("Map Players And Monsters Physical Damage Taken +%")]
		MapPlayersAndMonstersPhysicalDamageTakenPosPct = 5076,

		[Description("Map Players And Monsters Lightning Damage Taken +%")]
		MapPlayersAndMonstersLightningDamageTakenPosPct = 5077,

		[Description("Map Players And Monsters Cold Damage Taken +%")]
		MapPlayersAndMonstersColdDamageTakenPosPct = 5078,

		[Description("Map Players And Monsters Have Onslaught If Hit Recently")]
		MapPlayersAndMonstersHaveOnslaughtIfHitRecently = 5079,

		[Description("Map Players And Monsters Damage Taken +% While Stationary")]
		MapPlayersAndMonstersDamageTakenPosPctWhileStationary = 5080,

		[Description("Chance To Poison On Melee Hit %")]
		ChanceToPoisonOnMeleeHitPct = 5081,

		[Description("Chilled Ground Effect +%")]
		ChilledGroundEffectPosPct = 5082,

		[Description("Damage Vs Spiders While Spider +%")]
		DamageVsSpidersWhileSpiderPosPct = 5083,

		[Description("Damage Taken From Spiders While Spider +%")]
		DamageTakenFromSpidersWhileSpiderPosPct = 5084,

		[Description("Map Players And Monsters Movement Speed +%")]
		MapPlayersAndMonstersMovementSpeedPosPct = 5085,

		[Description("Damage Taken +% For 4 Seconds After Spending 200 Mana")]
		DamageTakenPosPctFor4SecondsAfterSpending200Mana = 5086,

		[Description("Life Regeneration Per Minute Per Active Buff")]
		LifeRegenerationPerMinutePerActiveBuff = 5087,

		[Description("Buff Effect +% On Low Energy Shield")]
		BuffEffectPosPctOnLowEnergyShield = 5088,
		[Description("On Low Energy Shield")] OnLowEnergyShield = 5089,

		[Description("Map Ground Haste Action Speed +%")]
		MapGroundHasteActionSpeedPosPct = 5090,
		[Description("Map Drops All Maps")] MapDropsAllMaps = 5091,

		[Description("Essence Delirium Spawn Monster On Death Variation")]
		EssenceDeliriumSpawnMonsterOnDeathVariation = 5092,

		[Description("Essence Anguish Spawn Monster On Death Variation")]
		EssenceAnguishSpawnMonsterOnDeathVariation = 5093,

		[Description("Essence Suffering Spawn Monster On Death Variation")]
		EssenceSufferingSpawnMonsterOnDeathVariation = 5094,

		[Description("Essence Corrupt Spawn Monster On Death Variation")]
		EssenceCorruptSpawnMonsterOnDeathVariation = 5095,

		[Description("Map Ground Haste Effect Patches Per 100 Tiles")]
		MapGroundHasteEffectPatchesPer100Tiles = 5096,

		[Description("Map Ground Haste Effect Radius")]
		MapGroundHasteEffectRadius = 5097,
		[Description("Map Breach Rules")] MapBreachRules = 5098,

		[Description("Cannot Regenerate Energy Shield")]
		CannotRegenerateEnergyShield = 5099,

		[Description("Cannot Recharge Energy Shield")]
		CannotRechargeEnergyShield = 5100,

		[Description("Energy Shield Lost Per Minute %")]
		EnergyShieldLostPerMinutePct = 5101,

		[Description("Life Leech Applies To Energy Shield On Full Life")]
		LifeLeechAppliesToEnergyShieldOnFullLife = 5102,

		[Description("Virtual Leech Energy Shield Instead Of Life")]
		VirtualLeechEnergyShieldInsteadOfLife = 5103,

		[Description("Current Number Of Spinning Blades")]
		CurrentNumberOfSpinningBlades = 5104,

		[Description("Virtual Current Number Of Spinning Blades")]
		VirtualCurrentNumberOfSpinningBlades = 5105,

		[Description("Vaal Blade Vortex Has 10 Spinning Blades")]
		VaalBladeVortexHas10SpinningBlades = 5106,

		[Description("Fire Beam Additional Stack Damage +% Final")]
		FireBeamAdditionalStackDamagePosPctFinal = 5107,

		[Description("Number Of Blood Ravens To Summon")]
		NumberOfBloodRavensToSummon = 5108,
		[Description("Map Fishy Effect 0")] MapFishyEffect0 = 5109,

		[Description("Map Hidden Players Have Insanity")]
		MapHiddenPlayersHaveInsanity = 5110,

		[Description("Map Monster And Player Onslaught Effect +%")]
		MapMonsterAndPlayerOnslaughtEffectPosPct = 5111,

		[Description("Map Damage While Stationary +%")]
		MapDamageWhileStationaryPosPct = 5112,

		[Description("Map Damage Taken While Stationary +%")]
		MapDamageTakenWhileStationaryPosPct = 5113,

		[Description("Map Item Drop Quality Also Applies To Map Item Drop Rarity")]
		MapItemDropQualityAlsoAppliesToMapItemDropRarity = 5114,
		[Description("Map Has X% Quality")] MapHasXPctQuality = 5115,

		[Description("Map Unique Monsters Drop Corrupted Items")]
		MapUniqueMonstersDropCorruptedItems = 5116,

		[Description("Fire Beam Degen Spread To Enemies In Radius On Kill")]
		FireBeamDegenSpreadToEnemiesInRadiusOnKill = 5117,

		[Description("Fire Beam Enemy Fire Resistance % Per Stack")]
		FireBeamEnemyFireResistancePctPerStack = 5118,

		[Description("Fire Beam Cast Speed +%")]
		FireBeamCastSpeedPosPct = 5119,

		[Description("Map Corrupted Bosses Drop X Additional Vaal Items")]
		MapCorruptedBossesDropXAdditionalVaalItems = 5120,

		[Description("Map Strongboxes Are Corrupted")]
		MapStrongboxesAreCorrupted = 5121,

		[Description("Map Players Cannot Take Reflected Damage")]
		MapPlayersCannotTakeReflectedDamage = 5122,

		[Description("Map Player Flask Recovery Is Instant")]
		MapPlayerFlaskRecoveryIsInstant = 5123,

		[Description("Map Contains X Additional Packs With Mirrored Rare Monsters")]
		MapContainsXAdditionalPacksWithMirroredRareMonsters = 5124,

		[Description("Map Contains X Additional Healing Packs")]
		MapContainsXAdditionalHealingPacks = 5125,

		[Description("Map Contains X Additional Normal Packs")]
		MapContainsXAdditionalNormalPacks = 5126,

		[Description("Map Contains X Additional Magic Packs")]
		MapContainsXAdditionalMagicPacks = 5127,

		[Description("Map Contains X Additional Rare Packs")]
		MapContainsXAdditionalRarePacks = 5128,

		[Description("Map Contains X Additional Packs That Convert On Death")]
		MapContainsXAdditionalPacksThatConvertOnDeath = 5129,

		[Description("Map Contains X Additional Packs On Their Own Team")]
		MapContainsXAdditionalPacksOnTheirOwnTeam = 5130,

		[Description("Map On Complete Drop X Additional Maps")]
		MapOnCompleteDropXAdditionalMaps = 5131,

		[Description("Monster Converts On Death")]
		MonsterConvertsOnDeath = 5132,

		[Description("Flask Recovery Is Instant")]
		FlaskRecoveryIsInstant = 5133,
		[Description("Map Fishy Effect 1")] MapFishyEffect1 = 5134,
		[Description("Map Fishy Effect 2")] MapFishyEffect2 = 5135,
		[Description("Map Fishy Effect 3")] MapFishyEffect3 = 5136,

		[Description("Map Magic Pack Size +%")]
		MapMagicPackSizePosPct = 5137,

		[Description("Map Rogue Exiles Damage +%")]
		MapRogueExilesDamagePosPct = 5138,

		[Description("Map Rogue Exiles Maximum Life +%")]
		MapRogueExilesMaximumLifePosPct = 5139,

		[Description("Map Rogue Exiles Drop X Additional Jewels")]
		MapRogueExilesDropXAdditionalJewels = 5140,

		[Description("Monster Drop Additional Jewels")]
		MonsterDropAdditionalJewels = 5141,

		[Description("Map Strongbox Monsters Item Quantity +%")]
		MapStrongboxMonstersItemQuantityPosPct = 5142,

		[Description("Map Strongbox Monsters Actor Scale +%")]
		MapStrongboxMonstersActorScalePosPct = 5143,

		[Description("Map Strongbox Monsters Attack Speed +%")]
		MapStrongboxMonstersAttackSpeedPosPct = 5144,

		[Description("Map Strongbox Monsters Movement Velocity +%")]
		MapStrongboxMonstersMovementVelocityPosPct = 5145,

		[Description("Strongbox Monsters Item Quantity +%")]
		StrongboxMonstersItemQuantityPosPct = 5146,

		[Description("Strongbox Monsters Actor Scale +%")]
		StrongboxMonstersActorScalePosPct = 5147,

		[Description("Strongbox Monsters Attack Speed +%")]
		StrongboxMonstersAttackSpeedPosPct = 5148,

		[Description("Strongbox Monsters Movement Velocity +%")]
		StrongboxMonstersMovementVelocityPosPct = 5149,

		[Description("Damage +% Per Poison Stack")]
		DamagePosPctPerPoisonStack = 5150,

		[Description("Movement Velocity +% Per Poison Stack")]
		MovementVelocityPosPctPerPoisonStack = 5151,

		[Description("Map Damage +% Per Poison Stack")]
		MapDamagePosPctPerPoisonStack = 5152,

		[Description("Map Movement Velocity +% Per Poison Stack")]
		MapMovementVelocityPosPctPerPoisonStack = 5153,

		[Description("Map Contains X Additional Poison Packs")]
		MapContainsXAdditionalPoisonPacks = 5154,

		[Description("Inspiring Cry Enemy Count Override")]
		InspiringCryEnemyCountOverride = 5155,

		[Description("Map Area Contains X Additional Clusters Of Explosive Barrels")]
		MapAreaContainsXAdditionalClustersOfExplosiveBarrels = 5156,
		[Description("Map Bonus Barrel %")] MapBonusBarrelPct = 5157,

		[Description("Empowering Cry Physical Damage Added As Fire Damage %")]
		EmpoweringCryPhysicalDamageAddedAsFireDamagePct = 5158,

		[Description("Map Boss Accompanied By Bodyguards")]
		MapBossAccompaniedByBodyguards = 5159,

		[Description("Blade Vortex Hit Rate +% Per Blade")]
		BladeVortexHitRatePosPctPerBlade = 5160,

		[Description("Blade Vortex Damage +% Per Blade Final")]
		BladeVortexDamagePosPctPerBladeFinal = 5161,
		[Description("Golem Maximum Life +%")] GolemMaximumLifePosPct = 5162,

		[Description("Golem Life Regeneration Per Minute %")]
		GolemLifeRegenerationPerMinutePct = 5163,

		[Description("Have Summoned A Golem In Past 8 Seconds")]
		HaveSummonedAGolemInPast8Seconds = 5164,

		[Description("Damage +% If Golem Summoned In Past 8 Seconds")]
		DamagePosPctIfGolemSummonedInPast8Seconds = 5165,

		[Description("Golem Damage +% If Summoned In Past 8 Seconds")]
		GolemDamagePosPctIfSummonedInPast8Seconds = 5166,

		[Description("Golem Skill Cooldown Recovery +%")]
		GolemSkillCooldownRecoveryPosPct = 5167,

		[Description("Golem Cooldown Recovery +%")]
		GolemCooldownRecoveryPosPct = 5168,
		[Description("Golem Buff Effect +%")] GolemBuffEffectPosPct = 5169,

		[Description("Golem Attack And Cast Speed +%")]
		GolemAttackAndCastSpeedPosPct = 5170,

		[Description("Golem Physical Damage Reduction Rating")]
		GolemPhysicalDamageReductionRating = 5171,

		[Description("Primordial Jewel Count")]
		PrimordialJewelCount = 5172,

		[Description("Number Of Golems Allowed With 3 Primordial Jewels")]
		NumberOfGolemsAllowedWith3PrimordialJewels = 5173,

		[Description("Map Monster Curse Effect On Self +%")]
		MapMonsterCurseEffectOnSelfPosPct = 5174,

		[Description("Map Player Curse Effect On Self +%")]
		MapPlayerCurseEffectOnSelfPosPct = 5175,

		[Description("Thrown Shield Num Additional Projectiles")]
		ThrownShieldNumAdditionalProjectiles = 5176,

		[Description("Buff Damage While Stationery +%")]
		BuffDamageWhileStationeryPosPct = 5177,

		[Description("Buff Damage Taken While Stationery +%")]
		BuffDamageTakenWhileStationeryPosPct = 5178,

		[Description("Map Display Strongbox Monsters Are Enraged")]
		MapDisplayStrongboxMonstersAreEnraged = 5179,

		[Description("Celestial Footprints From Item")]
		CelestialFootprintsFromItem = 5180,

		[Description("Deal 1000 Chaos Damage Per Second For 10 Seconds On Hit")]
		Deal1000ChaosDamagePerSecondFor10SecondsOnHit = 5181,

		[Description("Map Strongboxes Minimum Rarity")]
		MapStrongboxesMinimumRarity = 5182,

		[Description("Map Area Contains X Additional Clusters Of Wealthy Barrels")]
		MapAreaContainsXAdditionalClustersOfWealthyBarrels = 5183,

		[Description("Map Area Contains X Additional Clusters Of Volatile Barrels")]
		MapAreaContainsXAdditionalClustersOfVolatileBarrels = 5184,

		[Description("Map Area Contains X Additional Clusters Of Bloodworm Barrels")]
		MapAreaContainsXAdditionalClustersOfBloodwormBarrels = 5185,

		[Description("Map Area Contains X Additional Clusters Of Parasite Barrels")]
		MapAreaContainsXAdditionalClustersOfParasiteBarrels = 5186,

		[Description("Map Area Contains X Additional Clusters Of Beacon Barrels")]
		MapAreaContainsXAdditionalClustersOfBeaconBarrels = 5187,

		[Description("Map Contains X Additional Rare Packs If Rare")]
		MapContainsXAdditionalRarePacksIfRare = 5188,

		[Description("Map Contains X Additional Magic Packs If Magic")]
		MapContainsXAdditionalMagicPacksIfMagic = 5189,

		[Description("Map Contains X Additional Normal Packs If Normal")]
		MapContainsXAdditionalNormalPacksIfNormal = 5190,

		[Description("Map Boss Drops X Additional Vaal Items")]
		MapBossDropsXAdditionalVaalItems = 5191,
		[Description("Fire Beam Length +%")] FireBeamLengthPosPct = 5192,
		[Description("Is Breach Monster")] IsBreachMonster = 5193,

		[Description("Cast Linked Spells On Shocked Enemy Kill %")]
		CastLinkedSpellsOnShockedEnemyKillPct = 5194,

		[Description("Map Equipment Drops Identified In Identified Areas")]
		MapEquipmentDropsIdentifiedInIdentifiedAreas = 5195,

		[Description("Map Items Drop Corrupted %")]
		MapItemsDropCorruptedPct = 5196,

		[Description("Doom Arrow Area Of Effect +% Final Per Frenzy Charge")]
		DoomArrowAreaOfEffectPosPctFinalPerFrenzyCharge = 5197,

		[Description("Bonespire Number Of Bone Piles To Spawn")]
		BonespireNumberOfBonePilesToSpawn = 5198,
		[Description("Mortar Cone Angle")] MortarConeAngle = 5199,

		[Description("Current Consume Charges")]
		CurrentConsumeCharges = 5200,

		[Description("Maximum Consume Charges")]
		MaximumConsumeCharges = 5201,

		[Description("Expend Consume Charges On Skill Use")]
		ExpendConsumeChargesOnSkillUse = 5202,

		[Description("Gain Consume Charges On Skill Use")]
		GainConsumeChargesOnSkillUse = 5203,

		[Description("Secondary Skill Effect Duration +%")]
		SecondarySkillEffectDurationPosPct = 5204,

		[Description("X Armour Per Active Totem")]
		XArmourPerActiveTotem = 5205,

		[Description("Map Pack Size +% In Unidentified Areas")]
		MapPackSizePosPctInUnidentifiedAreas = 5206,

		[Description("Chance To Dodge % At Max Charged Attack Stacks")]
		ChanceToDodgePctAtMaxChargedAttackStacks = 5207,

		[Description("Critical Strikes Deal No Damage")]
		CriticalStrikesDealNoDamage = 5208,

		[Description("Spell Damage +% If Have Crit Recently")]
		SpellDamagePosPctIfHaveCritRecently = 5209,

		[Description("Critical Strike Multiplier + If Have Dealt Non Crit Recently")]
		CriticalStrikeMultiplierPosIfHaveDealtNonCritRecently = 5210,

		[Description("Track Have Dealt Non Crit Recently")]
		TrackHaveDealtNonCritRecently = 5211,

		[Description("Have Dealt Non Crit Recently")]
		HaveDealtNonCritRecently = 5212,

		[Description("Total Base Armour Rating")]
		TotalBaseArmourRating = 5213,

		[Description("Combined Only Armour +%")]
		CombinedOnlyArmourPosPct = 5214,
		[Description("Combined Armour +%")] CombinedArmourPosPct = 5215,

		[Description("Combined Only Armour +% Final")]
		CombinedOnlyArmourPosPctFinal = 5216,

		[Description("Combined Evasion Rating +% Final")]
		CombinedEvasionRatingPosPctFinal = 5217,

		[Description("Combined Only Armour From Shield +%")]
		CombinedOnlyArmourFromShieldPosPct = 5218,

		[Description("Combined Armour From Shield +%")]
		CombinedArmourFromShieldPosPct = 5219,

		[Description("Armour Differs Against Projectiles")]
		ArmourDiffersAgainstProjectiles = 5220,

		[Description("Armour While Stationary")]
		ArmourWhileStationary = 5221,

		[Description("Mana Regeneration Rate +% While Stationary")]
		ManaRegenerationRatePosPctWhileStationary = 5222,

		[Description("Non Critical Strikes Deal No Damage")]
		NonCriticalStrikesDealNoDamage = 5223,

		[Description("Chilled Ground When Hit With Attack %")]
		ChilledGroundWhenHitWithAttackPct = 5224,

		[Description("Critical Strike Multiplier + Per 1% Block Chance")]
		CriticalStrikeMultiplierPosPer1PctBlockChance = 5225,

		[Description("Local Flask Unholy Might During Flask Effect")]
		LocalFlaskUnholyMightDuringFlaskEffect = 5226,

		[Description("Spell Minimum Added Cold Damage Per Power Charge")]
		SpellMinimumAddedColdDamagePerPowerCharge = 5227,

		[Description("Spell Maximum Added Cold Damage Per Power Charge")]
		SpellMaximumAddedColdDamagePerPowerCharge = 5228,

		[Description("Recover X Mana On Killing Frozen Enemy")]
		RecoverXManaOnKillingFrozenEnemy = 5229,

		[Description("Chance To Gain Power Charge On Killing Frozen Enemy %")]
		ChanceToGainPowerChargeOnKillingFrozenEnemyPct = 5230,

		[Description("Damage +% If You Have Frozen Enemy Recently")]
		DamagePosPctIfYouHaveFrozenEnemyRecently = 5231,

		[Description("Track Have Frozen Enemy Recently")]
		TrackHaveFrozenEnemyRecently = 5232,

		[Description("Have Frozen Enemy Recently")]
		HaveFrozenEnemyRecently = 5233,

		[Description("Maximum Added Lightning Damage Per 10 Int")]
		MaximumAddedLightningDamagePer10Int = 5234,

		[Description("Attack Speed +% Per 25 Dex")]
		AttackSpeedPosPctPer25Dex = 5235,

		[Description("Number Of Shocked Enemies Killed Recently")]
		NumberOfShockedEnemiesKilledRecently = 5236,

		[Description("Minimum Added Lightning Damage Per Shocked Enemy Killed Recently")]
		MinimumAddedLightningDamagePerShockedEnemyKilledRecently = 5237,

		[Description("Maximum Added Lightning Damage Per Shocked Enemy Killed Recently")]
		MaximumAddedLightningDamagePerShockedEnemyKilledRecently = 5238,
		[Description("Reflect Shocks")] ReflectShocks = 5239,

		[Description("Movement Speed +% While Bleeding")]
		MovementSpeedPosPctWhileBleeding = 5240,

		[Description("Physical Damage Taken +% While Moving")]
		PhysicalDamageTakenPosPctWhileMoving = 5241,

		[Description("Physical Damage Reduction Rating % While Not Moving")]
		PhysicalDamageReductionRatingPctWhileNotMoving = 5242,

		[Description("Display Max Fire Beam Stacks")]
		DisplayMaxFireBeamStacks = 5243,

		[Description("Display Max Blight Stacks")]
		DisplayMaxBlightStacks = 5244,

		[Description("Virtual Track Movement")]
		VirtualTrackMovement = 5245,
		[Description("Is Moving")] IsMoving = 5246,

		[Description("Mass Flicker Strike Number Of Teleports")]
		MassFlickerStrikeNumberOfTeleports = 5247,

		[Description("Blind Chilled Enemies On Hit %")]
		BlindChilledEnemiesOnHitPct = 5248,

		[Description("Cold Damage +% Per Frenzy Charge")]
		ColdDamagePosPctPerFrenzyCharge = 5249,

		[Description("Gain Frenzy Charge On Reaching Maximum Power Charges")]
		GainFrenzyChargeOnReachingMaximumPowerCharges = 5250,

		[Description("Gain Frenzy Charge On Hit While Bleeding")]
		GainFrenzyChargeOnHitWhileBleeding = 5251,

		[Description("Virtual Chaos Damage Does Not Bypass Energy Shield")]
		VirtualChaosDamageDoesNotBypassEnergyShield = 5252,

		[Description("Chaos Damage Does Not Bypass Energy Shield While Not Low Life Or Mana")]
		ChaosDamageDoesNotBypassEnergyShieldWhileNotLowLifeOrMana = 5253,

		[Description("Local Display Grants Level X Reckoning")]
		LocalDisplayGrantsLevelXReckoning = 5254,

		[Description("Reflect Shocks To Enemies In Radius")]
		ReflectShocksToEnemiesInRadius = 5255,

		[Description("Recover % Maximum Life On Killing Poisoned Enemy")]
		RecoverPctMaximumLifeOnKillingPoisonedEnemy = 5256,

		[Description("Minions Recover % Maximum Life On Killing Poisoned Enemy")]
		MinionsRecoverPctMaximumLifeOnKillingPoisonedEnemy = 5257,

		[Description("Recover X Life On Enemy Ignited")]
		RecoverXLifeOnEnemyIgnited = 5258,

		[Description("Cold Penetration % Vs Chilled Enemies")]
		ColdPenetrationPctVsChilledEnemies = 5259,

		[Description("Local Display Grants Level X Envy")]
		LocalDisplayGrantsLevelXEnvy = 5260,

		[Description("Cast On Cyclone Contact %")]
		CastOnCycloneContactPct = 5261,

		[Description("Cyclone Has Triggered Skill")]
		CycloneHasTriggeredSkill = 5262,

		[Description("Minions Chance To Poison On Hit %")]
		MinionsChanceToPoisonOnHitPct = 5263,

		[Description("X Armour If You Have Blocked Recently")]
		XArmourIfYouHaveBlockedRecently = 5264,

		[Description("Enemies Explode On Kill")]
		EnemiesExplodeOnKill = 5265,

		[Description("Local Display Attack With Level X Bone Nova On Bleeding Enemy Kill")]
		LocalDisplayAttackWithLevelXBoneNovaOnBleedingEnemyKill = 5266,

		[Description("Attack Trigger On Killing Bleeding Enemy %")]
		AttackTriggerOnKillingBleedingEnemyPct = 5267,

		[Description("Permanently Intimidate Enemy On Block")]
		PermanentlyIntimidateEnemyOnBlock = 5268,

		[Description("Receive Bleeding Chance % When Hit By Attack")]
		ReceiveBleedingChancePctWhenHitByAttack = 5269,

		[Description("Attacks Cause Bleeding Vs Cursed Enemies")]
		AttacksCauseBleedingVsCursedEnemies = 5270,

		[Description("Armour Increased By Uncapped Fire Resistance")]
		ArmourIncreasedByUncappedFireResistance = 5271,

		[Description("Evasion Rating Increased By Uncapped Cold Resistance")]
		EvasionRatingIncreasedByUncappedColdResistance = 5272,

		[Description("Critical Strike Chance Increased By Uncapped Lightning Resistance")]
		CriticalStrikeChanceIncreasedByUncappedLightningResistance = 5273,

		[Description("Combined Critical Strike Chance +%")]
		CombinedCriticalStrikeChancePosPct = 5274,

		[Description("Combined Critical Strike Chance +% Final")]
		CombinedCriticalStrikeChancePosPctFinal = 5275,
		[Description("Totems Cannot Evade")] TotemsCannotEvade = 5276,

		[Description("Disable Seek Seal Prophecies")]
		DisableSeekSealProphecies = 5277,

		[Description("Mortar Distance In Front Of Target")]
		MortarDistanceInFrontOfTarget = 5278,

		[Description("Apply Covered In Ash To Attacker When Hit %")]
		ApplyCoveredInAshToAttackerWhenHitPct = 5279,

		[Description("Covered In Ash Movement Speed +% Final")]
		CoveredInAshMovementSpeedPosPctFinal = 5280,

		[Description("Secondary Total Minimum Base Physical Damage")]
		SecondaryTotalMinimumBasePhysicalDamage = 5281,

		[Description("Secondary Total Maximum Base Physical Damage")]
		SecondaryTotalMaximumBasePhysicalDamage = 5282,

		[Description("Minimum Secondary Physical Damage Per 15 Strength")]
		MinimumSecondaryPhysicalDamagePer15Strength = 5283,

		[Description("Maximum Secondary Physical Damage Per 15 Strength")]
		MaximumSecondaryPhysicalDamagePer15Strength = 5284,

		[Description("Flame Geyser Number Of Splits")]
		FlameGeyserNumberOfSplits = 5285,

		[Description("Keystone Avatar Of Fire")]
		KeystoneAvatarOfFire = 5286,

		[Description("Keystone Eldritch Battery")]
		KeystoneEldritchBattery = 5287,

		[Description("Keystone Ancestral Bond")]
		KeystoneAncestralBond = 5288,

		[Description("Skeletal Chains No Minions Damage +% Final")]
		SkeletalChainsNoMinionsDamagePosPctFinal = 5289,

		[Description("Virtual Energy Shield Protects Mana")]
		VirtualEnergyShieldProtectsMana = 5290,

		[Description("Virtual Spend Energy Shield For Costs Before Mana")]
		VirtualSpendEnergyShieldForCostsBeforeMana = 5291,

		[Description("Shock Nova Skill Area Of Effect +% Per Contact Point")]
		ShockNovaSkillAreaOfEffectPosPctPerContactPoint = 5292,

		[Description("Spell Skills Deal No Damage")]
		SpellSkillsDealNoDamage = 5293,

		[Description("Ignite Proliferation Radius")]
		IgniteProliferationRadius = 5294,

		[Description("Base Ignite Proliferation Radius")]
		BaseIgniteProliferationRadius = 5295,

		[Description("Transition Objects At State")]
		TransitionObjectsAtState = 5296,

		[Description("Fire Beam Enemy Fire Resistance % At Max Stacks")]
		FireBeamEnemyFireResistancePctAtMaxStacks = 5297,

		[Description("Attack Damage +1% Per 300 Of Min Of Armour Or Evasion")]
		AttackDamagePos1PctPer300OfMinOfArmourOrEvasion = 5298,

		[Description("Chance To Fortify On Melee Stun %")]
		ChanceToFortifyOnMeleeStunPct = 5299,

		[Description("Gain Onslaught While You Have Fortify")]
		GainOnslaughtWhileYouHaveFortify = 5300,

		[Description("Local Six Linked Random Sockets")]
		LocalSixLinkedRandomSockets = 5301,

		[Description("Local Can Only Socket Corrupted Gems")]
		LocalCanOnlySocketCorruptedGems = 5302,

		[Description("Fire Beam Enemy Fire Resistance % Maximum")]
		FireBeamEnemyFireResistancePctMaximum = 5303,

		[Description("Proximity Shield Ground Lightning Duration Ms")]
		ProximityShieldGroundLightningDurationMs = 5304,

		[Description("Map Player Charges Gained +%")]
		MapPlayerChargesGainedPosPct = 5305,

		[Description("Curse Effect On Self +% Final")]
		CurseEffectOnSelfPosPctFinal = 5306,

		[Description("Map Monsters Curse Effect On Self +% Final")]
		MapMonstersCurseEffectOnSelfPosPctFinal = 5307,

		[Description("Map Monsters % Chance To Inflict Status Ailments")]
		MapMonstersPctChanceToInflictStatusAilments = 5308,

		[Description("Map Monsters Movement Speed Cannot Be Reduced Below Base")]
		MapMonstersMovementSpeedCannotBeReducedBelowBase = 5309,

		[Description("Map Monsters Cannot Be Taunted")]
		MapMonstersCannotBeTaunted = 5310,

		[Description("Map Monsters Always Ignite")]
		MapMonstersAlwaysIgnite = 5311,

		[Description("Map Monsters Additional Chaos Resistance")]
		MapMonstersAdditionalChaosResistance = 5312,

		[Description("Map Monsters Avoid Poison Blind Bleed %")]
		MapMonstersAvoidPoisonBlindBleedPct = 5313,
		[Description("Base Avoid Poison %")] BaseAvoidPoisonPct = 5314,

		[Description("Map Players Have Point Blank")]
		MapPlayersHavePointBlank = 5315,

		[Description("Map Players Block Chance +%")]
		MapPlayersBlockChancePosPct = 5316,

		[Description("Map Players Armour +% Final")]
		MapPlayersArmourPosPctFinal = 5317,

		[Description("Map Monsters Accuracy Rating +%")]
		MapMonstersAccuracyRatingPosPct = 5318,

		[Description("Map Players Extra Dodge Rolls")]
		MapPlayersExtraDodgeRolls = 5319,
		[Description("Extra Dodge Rolls")] ExtraDodgeRolls = 5320,

		[Description("Map Players Skill Area Of Effect +% Final")]
		MapPlayersSkillAreaOfEffectPosPctFinal = 5321,

		[Description("Cannot Gain Frenzy Charges")]
		CannotGainFrenzyCharges = 5322,

		[Description("Cannot Gain Power Charges")]
		CannotGainPowerCharges = 5323,

		[Description("Map Players Cannot Gain Power Charges")]
		MapPlayersCannotGainPowerCharges = 5324,

		[Description("Map Players Cannot Gain Frenzy Charges")]
		MapPlayersCannotGainFrenzyCharges = 5325,

		[Description("Map Players Cannot Gain Endurance Charges")]
		MapPlayersCannotGainEnduranceCharges = 5326,

		[Description("Map Players No Regeneration Including Es")]
		MapPlayersNoRegenerationIncludingEs = 5327,

		[Description("Map Player Life And Es Recovery Speed +% Final")]
		MapPlayerLifeAndEsRecoverySpeedPosPctFinal = 5328,
		[Description("Armour +% Final")] ArmourPosPctFinal = 5329,

		[Description("Map Packs Are Abomination Monsters")]
		MapPacksAreAbominationMonsters = 5330,

		[Description("Gain Frenzy Charge On Hitting Rare Or Unique Enemy %")]
		GainFrenzyChargeOnHittingRareOrUniqueEnemyPct = 5331,
		[Description("Onslaught Duration +%")] OnslaughtDurationPosPct = 5332,

		[Description("Curse On Hit Level 10 Vulnerability %")]
		CurseOnHitLevel10VulnerabilityPct = 5333,

		[Description("Local Item Stats Are Doubled In Breach")]
		LocalItemStatsAreDoubledInBreach = 5334,
		[Description("Cast On Crit %")] CastOnCritPct = 5335,

		[Description("Local Unique Jewel Cold And Lightning Resistance To Melee Damage")]
		LocalUniqueJewelColdAndLightningResistanceToMeleeDamage = 5336,

		[Description("Local Unique Jewel Fire And Lightning Resistance To Projectile Attack Damage")]
		LocalUniqueJewelFireAndLightningResistanceToProjectileAttackDamage = 5337,

		[Description("Local Unique Jewel Fire And Cold Resistance To Spell Damage")]
		LocalUniqueJewelFireAndColdResistanceToSpellDamage = 5338,

		[Description("Local Unique Jewel Fire Resistance Also Grants Block Chance Scaled %")]
		LocalUniqueJewelFireResistanceAlsoGrantsBlockChanceScaledPct = 5339,

		[Description("Local Unique Jewel Cold Resistance Also Grants Dodge Chance Scaled %")]
		LocalUniqueJewelColdResistanceAlsoGrantsDodgeChanceScaledPct = 5340,

		[Description("Local Unique Jewel Lightning Resistance Also Grants Block Spells Chance Scaled %")]
		LocalUniqueJewelLightningResistanceAlsoGrantsBlockSpellsChanceScaledPct = 5341,

		[Description("Local Unique Jewel Fire Resistance Also Grants Endurance Charge On Kill Chance")]
		LocalUniqueJewelFireResistanceAlsoGrantsEnduranceChargeOnKillChance = 5342,

		[Description("Local Unique Jewel Cold Resistance Also Grants Frenzy Charge On Kill Chance")]
		LocalUniqueJewelColdResistanceAlsoGrantsFrenzyChargeOnKillChance = 5343,

		[Description("Local Unique Jewel Lightning Resistance Also Grants Power Charge On Kill Chance")]
		LocalUniqueJewelLightningResistanceAlsoGrantsPowerChargeOnKillChance = 5344,

		[Description("Cast While Channelling Time Ms")]
		CastWhileChannellingTimeMs = 5345,

		[Description("Support Cast While Channelling Triggered Skill Damage +% Final")]
		SupportCastWhileChannellingTriggeredSkillDamagePosPctFinal = 5346,

		[Description("Number Of Spider Minions Allowed")]
		NumberOfSpiderMinionsAllowed = 5347,

		[Description("Number Of Active Spider Minions")]
		NumberOfActiveSpiderMinions = 5348,

		[Description("Local Display Raise Spider On Kill % Chance")]
		LocalDisplayRaiseSpiderOnKillPctChance = 5349,

		[Description("Local Display Cast Lightning On Critical Strike")]
		LocalDisplayCastLightningOnCriticalStrike = 5350,

		[Description("Your Spells Are Disabled")]
		YourSpellsAreDisabled = 5351,
		[Description("Monster Ruleset Id")] MonsterRulesetId = 5352,

		[Description("Map Monsters Additional Elemental Resistance")]
		MapMonstersAdditionalElementalResistance = 5353,

		[Description("Support Minion Totem Resistance Elemental Damage +% Final")]
		SupportMinionTotemResistanceElementalDamagePosPctFinal = 5354,

		[Description("Elemental Damage +% Final On Minion From Resistance Support")]
		ElementalDamagePosPctFinalOnMinionFromResistanceSupport = 5355,

		[Description("Goat Footprints From Item")]
		GoatFootprintsFromItem = 5356,

		[Description("Totem Ignores Cooldown")]
		TotemIgnoresCooldown = 5357,

		[Description("Totem Ignores Vaal Skill Cost")]
		TotemIgnoresVaalSkillCost = 5358,

		[Description("Attack Minimum Added Lightning Damage Per 10 Int")]
		AttackMinimumAddedLightningDamagePer10Int = 5359,

		[Description("Attack Maximum Added Lightning Damage Per 10 Int")]
		AttackMaximumAddedLightningDamagePer10Int = 5360,

		[Description("Fire Damage +% Per 20 Strength")]
		FireDamagePosPctPer20Strength = 5361,

		[Description("Mana Recharge Rate Per Minute With All Corrupted Equipped Items")]
		ManaRechargeRatePerMinuteWithAllCorruptedEquippedItems = 5362,

		[Description("Life Leech Permyriad Vs Poisoned Enemies")]
		LifeLeechPermyriadVsPoisonedEnemies = 5363,

		[Description("Minion Life Leech Permyriad Vs Poisoned Enemies")]
		MinionLifeLeechPermyriadVsPoisonedEnemies = 5364,

		[Description("Display Vaal Breach No Drops Xp")]
		DisplayVaalBreachNoDropsXp = 5365,

		[Description("Golems Larger Aggro Radius")]
		GolemsLargerAggroRadius = 5366,

		[Description("Maximum Life % To Convert To Maximum Energy Shield")]
		MaximumLifePctToConvertToMaximumEnergyShield = 5367,

		[Description("Display Abberaths Hooves Skill Level")]
		DisplayAbberathsHoovesSkillLevel = 5368,

		[Description("Cannot Be Used As Minion")]
		CannotBeUsedAsMinion = 5369,

		[Description("Breach Map Time To Portal Ms")]
		BreachMapTimeToPortalMs = 5370,

		[Description("Breach Map Initial Time Ms")]
		BreachMapInitialTimeMs = 5371,

		[Description("Breach Team Warp Buff Damage Taken +%")]
		BreachTeamWarpBuffDamageTakenPosPct = 5372,
		[Description("Local Poison On Hit %")] LocalPoisonOnHitPct = 5373,

		[Description("Main Hand Local Poison On Hit %")]
		MainHandLocalPoisonOnHitPct = 5374,

		[Description("Off Hand Local Poison On Hit %")]
		OffHandLocalPoisonOnHitPct = 5375,

		[Description("Breach Team Warp Buff Movement Velocity +%")]
		BreachTeamWarpBuffMovementVelocityPosPct = 5376,

		[Description("Breach Team Warp Buff Lightning Damage +%")]
		BreachTeamWarpBuffLightningDamagePosPct = 5377,

		[Description("Base Blade Vortex Hit Rate Ms")]
		BaseBladeVortexHitRateMs = 5378,

		[Description("Blade Vortex Hit Rate Ms")]
		BladeVortexHitRateMs = 5379,

		[Description("Additional Maximum All Resistances % With No Endurance Charges")]
		AdditionalMaximumAllResistancesPctWithNoEnduranceCharges = 5380,

		[Description("Spell Damage +% While Shocked")]
		SpellDamagePosPctWhileShocked = 5381,

		[Description("Display Skill Minions Level Is Corpse Level")]
		DisplaySkillMinionsLevelIsCorpseLevel = 5382,

		[Description("Monster Beyond Portal Chance +%")]
		MonsterBeyondPortalChancePosPct = 5383,

		[Description("Life Leech Uses Chaos Damage")]
		LifeLeechUsesChaosDamage = 5384,

		[Description("Base Cannot Gain Endurance Charges")]
		BaseCannotGainEnduranceCharges = 5385,

		[Description("Gain Onslaught While At Maximum Endurance Charges")]
		GainOnslaughtWhileAtMaximumEnduranceCharges = 5386,

		[Description("Number Of Zombies Allowed +1 Per X Strength")]
		NumberOfZombiesAllowedPos1PerXStrength = 5387,

		[Description("Minions Gain Your Strength")]
		MinionsGainYourStrength = 5388,

		[Description("Avarius Cast On Charge Contact")]
		AvariusCastOnChargeContact = 5389,

		[Description("Zombie Damage Leeched As Life To You Permyriad If Over 1000 Strength")]
		ZombieDamageLeechedAsLifeToYouPermyriadIfOver1000Strength = 5390,

		[Description("Virtual Minion Additional Strength")]
		VirtualMinionAdditionalStrength = 5391,

		[Description("Virtual Zombie Damage Leeched As Life To You Permyriad")]
		VirtualZombieDamageLeechedAsLifeToYouPermyriad = 5392,

		[Description("Base Bleed Duration +%")]
		BaseBleedDurationPosPct = 5393,

		[Description("Item Found Rarity +1% Per X Rampage Stacks")]
		ItemFoundRarityPos1PctPerXRampageStacks = 5394,
		[Description("Is Channelling")] IsChannelling = 5395,

		[Description("Warcries Knock Back Enemies")]
		WarcriesKnockBackEnemies = 5396,

		[Description("Map Monsters No Drops Or Experience")]
		MapMonstersNoDropsOrExperience = 5397,

		[Description("Off Hand Minimum Added Physical Damage Per 15 Shield Armour And Evasion Rating")]
		OffHandMinimumAddedPhysicalDamagePer15ShieldArmourAndEvasionRating = 5398,

		[Description("Off Hand Maximum Added Physical Damage Per 15 Shield Armour And Evasion Rating")]
		OffHandMaximumAddedPhysicalDamagePer15ShieldArmourAndEvasionRating = 5399,

		[Description("Off Hand Minimum Added Physical Damage Per 5 Shield Armour")]
		OffHandMinimumAddedPhysicalDamagePer5ShieldArmour = 5400,

		[Description("Off Hand Maximum Added Physical Damage Per 5 Shield Armour")]
		OffHandMaximumAddedPhysicalDamagePer5ShieldArmour = 5401,

		[Description("Off Hand Minimum Added Physical Damage Per 5 Shield Evasion Rating")]
		OffHandMinimumAddedPhysicalDamagePer5ShieldEvasionRating = 5402,

		[Description("Off Hand Maximum Added Physical Damage Per 5 Shield Evasion Rating")]
		OffHandMaximumAddedPhysicalDamagePer5ShieldEvasionRating = 5403,

		[Description("Gain Vaal Soul On Hit Cooldown Ms")]
		GainVaalSoulOnHitCooldownMs = 5404,

		[Description("Unique Spells Triggered On Shocked Kill")]
		UniqueSpellsTriggeredOnShockedKill = 5405,

		[Description("Maximum Life Per 2% Increased Item Found Rarity")]
		MaximumLifePer2PctIncreasedItemFoundRarity = 5406,

		[Description("Damage +% Per 1% Increased Item Found Quantity")]
		DamagePosPctPer1PctIncreasedItemFoundQuantity = 5407,

		[Description("Item Found Quantity +% Per Chest Opened Recently")]
		ItemFoundQuantityPosPctPerChestOpenedRecently = 5408,

		[Description("Number Of Chests Opened Recently")]
		NumberOfChestsOpenedRecently = 5409,

		[Description("Track Number Of Chests Opened Recently")]
		TrackNumberOfChestsOpenedRecently = 5410,

		[Description("Movement Speed +% Per Chest Opened Recently")]
		MovementSpeedPosPctPerChestOpenedRecently = 5411,

		[Description("Immune To Burning Shocks And Chilled Ground")]
		ImmuneToBurningShocksAndChilledGround = 5412,

		[Description("Maximum Life Per 10 Dexterity")]
		MaximumLifePer10Dexterity = 5413,

		[Description("Life Regeneration Per Minute While Moving")]
		LifeRegenerationPerMinuteWhileMoving = 5414,

		[Description("Chest Number Of Additional Pirate Uniques To Drop")]
		ChestNumberOfAdditionalPirateUniquesToDrop = 5415,

		[Description("Shrapnel Shot Number Of Additional Cones")]
		ShrapnelShotNumberOfAdditionalCones = 5416,

		[Description("Local Unique Jewel Shrapnel Shot Number Of Additional Cones With 50 Dex In Radius")]
		LocalUniqueJewelShrapnelShotNumberOfAdditionalConesWith50DexInRadius = 5417,

		[Description("Burning Arrow Additional Ignite Stacks")]
		BurningArrowAdditionalIgniteStacks = 5418,

		[Description("Local Unique Jewel Burning Arrow Additional Ignite Stacks With 50 Dex In Radius")]
		LocalUniqueJewelBurningArrowAdditionalIgniteStacksWith50DexInRadius = 5419,
		[Description("Cleave Fortify On Hit")] CleaveFortifyOnHit = 5420,

		[Description("Local Unique Jewel Cleave Fortify On Hit With 50 Str In Radius")]
		LocalUniqueJewelCleaveFortifyOnHitWith50StrInRadius = 5421,

		[Description("Cleave Skill Area Of Effect +% Per Nearby Enemy")]
		CleaveSkillAreaOfEffectPosPctPerNearbyEnemy = 5422,

		[Description("Local Unique Jewel Cleave Skill Area Of Effect +% Per Nearby Enemy With 50 Str In Radius")]
		LocalUniqueJewelCleaveSkillAreaOfEffectPosPctPerNearbyEnemyWith50StrInRadius = 5423,

		[Description("Freezing Pulse Number Of Additional Projectiles")]
		FreezingPulseNumberOfAdditionalProjectiles = 5424,

		[Description("Local Unique Jewel Freezing Pulse Number Of Additional Projectiles With 50 Int In Radius")]
		LocalUniqueJewelFreezingPulseNumberOfAdditionalProjectilesWith50IntInRadius = 5425,

		[Description("Freezing Pulse Damage +% If Enemy Shattered Recently")]
		FreezingPulseDamagePosPctIfEnemyShatteredRecently = 5426,

		[Description("Local Unique Jewel Freezing Pulse Damage +% If Enemy Shattered Recently With 50 Int In Radius")]
		LocalUniqueJewelFreezingPulseDamagePosPctIfEnemyShatteredRecentlyWith50IntInRadius = 5427,

		[Description("Local Unique Jewel Ice Shot Explosion Skill Area Of Effect +% With 50 Dex In Radius")]
		LocalUniqueJewelIceShotExplosionSkillAreaOfEffectPosPctWith50DexInRadius = 5428,

		[Description("Ice Shot Damage +% To Chilled Enemies")]
		IceShotDamagePosPctToChilledEnemies = 5429,

		[Description("Local Unique Jewel Ice Shot Damage +% To Chilled Enemies With 50 Dex In Radius")]
		LocalUniqueJewelIceShotDamagePosPctToChilledEnemiesWith50DexInRadius = 5430,

		[Description("Local Unique Jewel Molten Strike Number Of Additional Projectiles With 50 Str In Radius")]
		LocalUniqueJewelMoltenStrikeNumberOfAdditionalProjectilesWith50StrInRadius = 5431,

		[Description("Local Unique Jewel Molten Strike Skill Area Of Effect +% With 50 Str In Radius")]
		LocalUniqueJewelMoltenStrikeSkillAreaOfEffectPosPctWith50StrInRadius = 5432,

		[Description("Frost Blades Melee Cold Damage +% Per Frenzy Charge")]
		FrostBladesMeleeColdDamagePosPctPerFrenzyCharge = 5433,

		[Description("Local Unique Jewel Frost Blades Melee Cold Damage +% Per Frenzy Charge With 50 Dex In Radius")]
		LocalUniqueJewelFrostBladesMeleeColdDamagePosPctPerFrenzyChargeWith50DexInRadius = 5434,

		[Description("Dual Strike Melee Splash With Off Hand Weapon")]
		DualStrikeMeleeSplashWithOffHandWeapon = 5435,

		[Description("Local Unique Jewel Dual Strike Melee Splash With Off Hand Weapon With 50 Dex In Radius")]
		LocalUniqueJewelDualStrikeMeleeSplashWithOffHandWeaponWith50DexInRadius = 5436,

		[Description("Frostbolt Projectile Acceleration")]
		FrostboltProjectileAcceleration = 5437,

		[Description("Local Unique Jewel Frostbolt Projectile Acceleration With 50 Int In Radius")]
		LocalUniqueJewelFrostboltProjectileAccelerationWith50IntInRadius = 5438,

		[Description("Ethereal Knives Projectiles Nova")]
		EtherealKnivesProjectilesNova = 5439,

		[Description("Local Unique Jewel Ethereal Knives Projectiles Nova With 50 Dex In Radius")]
		LocalUniqueJewelEtherealKnivesProjectilesNovaWith50DexInRadius = 5440,

		[Description("Ethereal Knives Number Of Additional Projectiles")]
		EtherealKnivesNumberOfAdditionalProjectiles = 5441,

		[Description("Local Unique Jewel Ethereal Knives Number Of Additional Projectiles With 50 Dex In Radius")]
		LocalUniqueJewelEtherealKnivesNumberOfAdditionalProjectilesWith50DexInRadius = 5442,

		[Description("Ethereal Knives Projectile Speed +% Per Frenzy Charge")]
		EtherealKnivesProjectileSpeedPosPctPerFrenzyCharge = 5443,

		[Description("Local Unique Jewel Ethereal Knives Projectile Speed +% Per Frenzy Charge With 50 Dex In Radius")]
		LocalUniqueJewelEtherealKnivesProjectileSpeedPosPctPerFrenzyChargeWith50DexInRadius = 5444,

		[Description("Ethereal Knives Grant Frenzy Charge On Kill")]
		EtherealKnivesGrantFrenzyChargeOnKill = 5445,

		[Description("Local Unique Jewel Ethereal Knives Grant Frenzy Charge On Kill With 50 Dex In Radius")]
		LocalUniqueJewelEtherealKnivesGrantFrenzyChargeOnKillWith50DexInRadius = 5446,

		[Description("Lightning Tendrils Skill Area Of Effect +% Per Enemy Hit")]
		LightningTendrilsSkillAreaOfEffectPosPctPerEnemyHit = 5447,

		[Description("Local Unique Jewel Lightning Tendrils Skill Area Of Effect +% Per Enemy Hit With 50 Int In Radius")]
		LocalUniqueJewelLightningTendrilsSkillAreaOfEffectPosPctPerEnemyHitWith50IntInRadius = 5448,

		[Description("Magma Orb Skill Area Of Effect +% Per Bounce")]
		MagmaOrbSkillAreaOfEffectPosPctPerBounce = 5449,

		[Description("Local Unique Jewel Magma Orb Skill Area Of Effect +% Per Bounce With 50 Int In Radius")]
		LocalUniqueJewelMagmaOrbSkillAreaOfEffectPosPctPerBounceWith50IntInRadius = 5450,

		[Description("Glacial Hammer Melee Splash With Cold Damage")]
		GlacialHammerMeleeSplashWithColdDamage = 5451,

		[Description("Local Unique Jewel Glacial Hammer Melee Splash With Cold Damage With 50 Str In Radius")]
		LocalUniqueJewelGlacialHammerMeleeSplashWithColdDamageWith50StrInRadius = 5452,

		[Description("Glacial Hammer Physical Damage % To Convert To Cold")]
		GlacialHammerPhysicalDamagePctToConvertToCold = 5453,

		[Description("Local Unique Jewel Glacial Hammer Physical Damage % To Convert To Cold With 50 Str In Radius")]
		LocalUniqueJewelGlacialHammerPhysicalDamagePctToConvertToColdWith50StrInRadius = 5454,

		[Description("Blight Skill Area Of Effect +% After 1 Second Channelling")]
		BlightSkillAreaOfEffectPosPctAfter1SecondChannelling = 5455,

		[Description("Local Unique Jewel Blight Skill Area Of Effect +% After 1 Second Channelling With 50 Int In Radius")]
		LocalUniqueJewelBlightSkillAreaOfEffectPosPctAfter1SecondChannellingWith50IntInRadius = 5456,
		[Description("Fortify On Hit")] FortifyOnHit = 5457,

		[Description("Melee Splash Cold Damage Only")]
		MeleeSplashColdDamageOnly = 5458,

		[Description("Track Have Shattered Recently")]
		TrackHaveShatteredRecently = 5459,

		[Description("Have Shattered Recently")]
		HaveShatteredRecently = 5460,

		[Description("Can Gain Vaal Souls From No Experience Monsters")]
		CanGainVaalSoulsFromNoExperienceMonsters = 5461,
		[Description("Maim On Hit %")] MaimOnHitPct = 5462,

		[Description("Total Skill Area Of Effect Radius +% Including Final")]
		TotalSkillAreaOfEffectRadiusPosPctIncludingFinal = 5463,

		[Description("Melee Splash Off Hand Only")]
		MeleeSplashOffHandOnly = 5464,

		[Description("Classic Remaining Areas To Apply Leaguestone")]
		ClassicRemainingAreasToApplyLeaguestone = 5465,

		[Description("Map Spawn Leaguestones")]
		MapSpawnLeaguestones = 5466,

		[Description("Monster Can Spawn With Leaguestone")]
		MonsterCanSpawnWithLeaguestone = 5467,

		[Description("Monster No Leaguestone")]
		MonsterNoLeaguestone = 5468,

		[Description("Local Unique Jewel Shrapnel Shot Cone % Chance To Deal Double Damage With 50 Dex In Radius")]
		LocalUniqueJewelShrapnelShotConePctChanceToDealDoubleDamageWith50DexInRadius = 5469,

		[Description("Shrapnel Shot Cone % Chance To Deal Double Damage")]
		ShrapnelShotConePctChanceToDealDoubleDamage = 5470,

		[Description("Local Unique Jewel Shrapnel Shot Radius +% With 50 Dex In Radius")]
		LocalUniqueJewelShrapnelShotRadiusPosPctWith50DexInRadius = 5471,

		[Description("Endurance Charge On Kill Percent Chance While Holding Shield")]
		EnduranceChargeOnKillPercentChanceWhileHoldingShield = 5472,

		[Description("Frenzy Charge On Kill Percent Chance While Holding Shield")]
		FrenzyChargeOnKillPercentChanceWhileHoldingShield = 5473,

		[Description("Power Charge On Kill Percent Chance While Holding Shield")]
		PowerChargeOnKillPercentChanceWhileHoldingShield = 5474,

		[Description("Block Chance % While Holding Shield")]
		BlockChancePctWhileHoldingShield = 5475,

		[Description("Dodge Chance % While Holding Shield")]
		DodgeChancePctWhileHoldingShield = 5476,

		[Description("Block Spells Chance % While Holding Shield")]
		BlockSpellsChancePctWhileHoldingShield = 5477,

		[Description("Local Unique Flask Elemental Damage Taken +% Of Lowest Uncapped Resistance Type")]
		LocalUniqueFlaskElementalDamageTakenPosPctOfLowestUncappedResistanceType = 5478,

		[Description("Local Unique Flask Elemental Penetration % Of Highest Uncapped Resistance Type")]
		LocalUniqueFlaskElementalPenetrationPctOfHighestUncappedResistanceType = 5479,

		[Description("Elemental Damage Taken +% Of Lowest Uncapped Resistance Type")]
		ElementalDamageTakenPosPctOfLowestUncappedResistanceType = 5480,

		[Description("Elemental Penetration % Of Highest Uncapped Resistance Type")]
		ElementalPenetrationPctOfHighestUncappedResistanceType = 5481,

		[Description("Virtual Fire Damage Taken +% From Lowest Uncapped Resistance Type")]
		VirtualFireDamageTakenPosPctFromLowestUncappedResistanceType = 5482,

		[Description("Virtual Cold Damage Taken +% From Lowest Uncapped Resistance Type")]
		VirtualColdDamageTakenPosPctFromLowestUncappedResistanceType = 5483,

		[Description("Virtual Lightning Damage Taken +% From Lowest Uncapped Resistance Type")]
		VirtualLightningDamageTakenPosPctFromLowestUncappedResistanceType = 5484,

		[Description("Virtual Fire Penetration % From Highest Uncapped Resistance Type")]
		VirtualFirePenetrationPctFromHighestUncappedResistanceType = 5485,

		[Description("Virtual Cold Penetration % From Highest Uncapped Resistance Type")]
		VirtualColdPenetrationPctFromHighestUncappedResistanceType = 5486,

		[Description("Virtual Lightning Penetration % From Highest Uncapped Resistance Type")]
		VirtualLightningPenetrationPctFromHighestUncappedResistanceType = 5487,

		[Description("Start At Zero Energy Shield")]
		StartAtZeroEnergyShield = 5488,

		[Description("Map Number Of Additional Silver Coin Drops")]
		MapNumberOfAdditionalSilverCoinDrops = 5489,

		[Description("Map Monsters That Drop Silver Coin Drop X Additional Silver Coins")]
		MapMonstersThatDropSilverCoinDropXAdditionalSilverCoins = 5490,

		[Description("Map Item Quantity From Monsters That Drop Silver Coin +%")]
		MapItemQuantityFromMonstersThatDropSilverCoinPosPct = 5491,

		[Description("Local Unique Jewel Spark Number Of Additional Projectiles With 50 Int In Radius")]
		LocalUniqueJewelSparkNumberOfAdditionalProjectilesWith50IntInRadius = 5492,

		[Description("Spark Num Of Additional Projectiles In Chain")]
		SparkNumOfAdditionalProjectilesInChain = 5493,

		[Description("Local Unique Jewel Spark Number Of Additional Chains With 50 Int In Radius")]
		LocalUniqueJewelSparkNumberOfAdditionalChainsWith50IntInRadius = 5494,

		[Description("Monster Slam Cooldown Speed +%")]
		MonsterSlamCooldownSpeedPosPct = 5495,

		[Description("Zombie Slam Cooldown Speed +%")]
		ZombieSlamCooldownSpeedPosPct = 5496,

		[Description("Local Unique Jewel Zombie Slam Cooldown Speed +% With 50 Int In Radius")]
		LocalUniqueJewelZombieSlamCooldownSpeedPosPctWith50IntInRadius = 5497,

		[Description("Monster Slam Damage +%")]
		MonsterSlamDamagePosPct = 5498,
		[Description("Zombie Slam Damage +%")] ZombieSlamDamagePosPct = 5499,

		[Description("Local Unique Jewel Zombie Slam Damage +% With 50 Int In Radius")]
		LocalUniqueJewelZombieSlamDamagePosPctWith50IntInRadius = 5500,

		[Description("Map Leaguestone Override Base Num Rogue Exiles")]
		MapLeaguestoneOverrideBaseNumRogueExiles = 5501,

		[Description("Map Rogue Exiles Are Doubled")]
		MapRogueExilesAreDoubled = 5502,

		[Description("Map Rogue Exile Drop Skill Gem With Quality")]
		MapRogueExileDropSkillGemWithQuality = 5503,

		[Description("Map Rogue Exile Attack Cast And Movement Speed +%")]
		MapRogueExileAttackCastAndMovementSpeedPosPct = 5504,

		[Description("Map Leaguestone Rogue Exiles Dropped Item Rarity +% Final")]
		MapLeaguestoneRogueExilesDroppedItemRarityPosPctFinal = 5505,

		[Description("Monster Drop Skill Gem With Quality")]
		MonsterDropSkillGemWithQuality = 5506,

		[Description("Map Leaguestone Override Base Num Breaches")]
		MapLeaguestoneOverrideBaseNumBreaches = 5507,

		[Description("Map Contains Additional Breaches")]
		MapContainsAdditionalBreaches = 5508,

		[Description("Map Rare Breach Monsters Drop Additional Shards")]
		MapRareBreachMonstersDropAdditionalShards = 5509,
		[Description("Map Breach Has Boss")] MapBreachHasBoss = 5510,

		[Description("Map Breach Has Large Chest")]
		MapBreachHasLargeChest = 5511,

		[Description("Map Breach Monster Quantity +%")]
		MapBreachMonsterQuantityPosPct = 5512,

		[Description("Map Leaguestone Override Base Num Monoliths")]
		MapLeaguestoneOverrideBaseNumMonoliths = 5513,

		[Description("Map Essence Monsters Have Additional Essences")]
		MapEssenceMonstersHaveAdditionalEssences = 5514,

		[Description("Map Essence Monsters Are Corrupted")]
		MapEssenceMonstersAreCorrupted = 5515,

		[Description("Map Essence Monsters Higher Tier")]
		MapEssenceMonstersHigherTier = 5516,

		[Description("Fire Beam Rotation Speed +%")]
		FireBeamRotationSpeedPosPct = 5517,

		[Description("Fire Beam Charge Up Time Ms")]
		FireBeamChargeUpTimeMs = 5518,

		[Description("Map Leaguestone Override Base Num Talismans")]
		MapLeaguestoneOverrideBaseNumTalismans = 5519,

		[Description("Map Talismans Higher Tier")]
		MapTalismansHigherTier = 5520,

		[Description("Map Talismans Dropped As Rare")]
		MapTalismansDroppedAsRare = 5521,

		[Description("Map Contains Talisman Boss With Higher Tier")]
		MapContainsTalismanBossWithHigherTier = 5522,

		[Description("Virtual Fire Damage Taken +%")]
		VirtualFireDamageTakenPosPct = 5523,

		[Description("Virtual Chaos Damage Taken +%")]
		VirtualChaosDamageTakenPosPct = 5524,

		[Description("Virtual Lightning Damage Taken +%")]
		VirtualLightningDamageTakenPosPct = 5525,

		[Description("Virtual Cold Damage Taken +%")]
		VirtualColdDamageTakenPosPct = 5526,

		[Description("Local Display Socketed Gems Supported By Level X Endurance Charge On Stun")]
		LocalDisplaySocketedGemsSupportedByLevelXEnduranceChargeOnStun = 5527,

		[Description("Number Of Generic Limited Minions Allowed")]
		NumberOfGenericLimitedMinionsAllowed = 5528,

		[Description("Number Of Active Generic Limited Minions")]
		NumberOfActiveGenericLimitedMinions = 5529,

		[Description(
				"Local Unique Jewel Viper Strike Chance To Gain Unholy Might % On Hit Per Poison Stack On Enemy With 50 Dex In Radius")]
		LocalUniqueJewelViperStrikeChanceToGainUnholyMightPctOnHitPerPoisonStackOnEnemyWith50DexInRadius = 5530,

		[Description("Local Unique Jewel Ground Slam Chance To Gain Endurance Charge % On Stun With 50 Str In Radius")]
		LocalUniqueJewelGroundSlamChanceToGainEnduranceChargePctOnStunWith50StrInRadius = 5531,

		[Description("Viper Strike Chance To Gain Unholy Might % On Hit Per Poison Stack On Enemy")]
		ViperStrikeChanceToGainUnholyMightPctOnHitPerPoisonStackOnEnemy = 5532,

		[Description("Ground Slam Chance To Gain Endurance Charge % On Stun")]
		GroundSlamChanceToGainEnduranceChargePctOnStun = 5533,

		[Description("Classic Next Area Contains Talisman")]
		ClassicNextAreaContainsTalisman = 5534,

		[Description("Classic Next Area Contains Anarchy")]
		ClassicNextAreaContainsAnarchy = 5535,

		[Description("Map Area Contains Avatar Of Prophecy")]
		MapAreaContainsAvatarOfProphecy = 5536,

		[Description("Map Area Contains Avatar Of Breach")]
		MapAreaContainsAvatarOfBreach = 5537,

		[Description("Map Area Contains Avatar Of Essence")]
		MapAreaContainsAvatarOfEssence = 5538,

		[Description("Map Area Contains Avatar Of Perandus")]
		MapAreaContainsAvatarOfPerandus = 5539,

		[Description("Map Area Contains Avatar Of Anarchy")]
		MapAreaContainsAvatarOfAnarchy = 5540,

		[Description("Map Area Contains Avatar Of Talisman")]
		MapAreaContainsAvatarOfTalisman = 5541,

		[Description("Map Area Contains Avatar Of Tempest")]
		MapAreaContainsAvatarOfTempest = 5542,

		[Description("Map Random Area Prophecy")]
		MapRandomAreaProphecy = 5543,

		[Description("Map Contains Nevalis Monkey")]
		MapContainsNevalisMonkey = 5544,

		[Description("Armour +% While No Energy Shield")]
		ArmourPosPctWhileNoEnergyShield = 5545,

		[Description("Life Leech From Attack Damage Permyriad Vs Taunted Enemies")]
		LifeLeechFromAttackDamagePermyriadVsTauntedEnemies = 5546,

		[Description("Random Curse On Hit % Against Uncursed Enemies")]
		RandomCurseOnHitPctAgainstUncursedEnemies = 5547,

		[Description("Mana Leech From Attack Damage Permyriad Per Power Charge")]
		ManaLeechFromAttackDamagePermyriadPerPowerCharge = 5548,

		[Description("Virtual Life Leech From Attack Damage Permyriad")]
		VirtualLifeLeechFromAttackDamagePermyriad = 5549,

		[Description("Virtual Mana Leech From Attack Damage Permyriad")]
		VirtualManaLeechFromAttackDamagePermyriad = 5550,
		[Description("Gain X Life On Stun")] GainXLifeOnStun = 5551,

		[Description("Blood Offering % Of Life To Lose")]
		BloodOfferingPctOfLifeToLose = 5552,

		[Description("Blood Offering % Of Lost Life To Regenerate As Life Per Second")]
		BloodOfferingPctOfLostLifeToRegenerateAsLifePerSecond = 5553,

		[Description("Blood Offering Life Regenerated +% Final Per Corpse")]
		BloodOfferingLifeRegeneratedPosPctFinalPerCorpse = 5554,

		[Description("Damage +% Vs Chilled Enemies")]
		DamagePosPctVsChilledEnemies = 5555,

		[Description("Additional Block % While On Consecrated Ground")]
		AdditionalBlockPctWhileOnConsecratedGround = 5556,
		[Description("Warcry Buff Effect +%")] WarcryBuffEffectPosPct = 5557,

		[Description("Spell And Attack Minimum Added Fire Damage")]
		SpellAndAttackMinimumAddedFireDamage = 5558,

		[Description("Spell And Attack Maximum Added Fire Damage")]
		SpellAndAttackMaximumAddedFireDamage = 5559,

		[Description("Resist All Elements % With 200 Or More Strength")]
		ResistAllElementsPctWith200OrMoreStrength = 5560,

		[Description("Spell Block % If Blocked An Attack Recently")]
		SpellBlockPctIfBlockedAnAttackRecently = 5561,

		[Description("Track Have Blocked Spell Recently")]
		TrackHaveBlockedSpellRecently = 5562,

		[Description("Have Blocked Spell Recently")]
		HaveBlockedSpellRecently = 5563,

		[Description("Attack Block % If Blocked A Spell Recently")]
		AttackBlockPctIfBlockedASpellRecently = 5564,

		[Description("Life Regeneration Rate Per Minute % If Have Been Hit Recently")]
		LifeRegenerationRatePerMinutePctIfHaveBeenHitRecently = 5565,

		[Description("Life Regeneration Rate Per Minute % With 400 Or More Strength")]
		LifeRegenerationRatePerMinutePctWith400OrMoreStrength = 5566,

		[Description("Ground Tar When Hit % Chance")]
		GroundTarWhenHitPctChance = 5567,

		[Description("Spell And Attack Minimum Added Chaos Damage During Flask Effect")]
		SpellAndAttackMinimumAddedChaosDamageDuringFlaskEffect = 5568,

		[Description("Spell And Attack Maximum Added Chaos Damage During Flask Effect")]
		SpellAndAttackMaximumAddedChaosDamageDuringFlaskEffect = 5569,

		[Description("Fire Damage +% If You Have Been Hit Recently")]
		FireDamagePosPctIfYouHaveBeenHitRecently = 5570,

		[Description("Immune To Freeze And Chill While Ignited")]
		ImmuneToFreezeAndChillWhileIgnited = 5571,

		[Description("Fire Penetration % If You Have Blocked Recently")]
		FirePenetrationPctIfYouHaveBlockedRecently = 5572,

		[Description("Local Display Grants Level X Vengeance")]
		LocalDisplayGrantsLevelXVengeance = 5573,

		[Description("Gain X Power Charges On Using A Warcry")]
		GainXPowerChargesOnUsingAWarcry = 5574,

		[Description("Gain Onslaught Ms On Using A Warcry")]
		GainOnslaughtMsOnUsingAWarcry = 5575,

		[Description("Local Display Socketed Golem Buff Effect +%")]
		LocalDisplaySocketedGolemBuffEffectPosPct = 5576,

		[Description("Local Display Socketed Golem Chance To Taunt %")]
		LocalDisplaySocketedGolemChanceToTauntPct = 5577,

		[Description("Local Display Socketed Golem Life Regeneration Rate Per Minute %")]
		LocalDisplaySocketedGolemLifeRegenerationRatePerMinutePct = 5578,

		[Description("Minimum Added Cold Damage Vs Chilled Enemies")]
		MinimumAddedColdDamageVsChilledEnemies = 5579,

		[Description("Maximum Added Cold Damage Vs Chilled Enemies")]
		MaximumAddedColdDamageVsChilledEnemies = 5580,

		[Description("Map Area Contains Avatar Of Rampage")]
		MapAreaContainsAvatarOfRampage = 5581,

		[Description("Map Area Contains Avatar Of Beyond")]
		MapAreaContainsAvatarOfBeyond = 5582,

		[Description("Map Area Contains Avatar Of Onslaught")]
		MapAreaContainsAvatarOfOnslaught = 5583,

		[Description("Map Area Contains Avatar Of Ambush")]
		MapAreaContainsAvatarOfAmbush = 5584,

		[Description("Map Area Contains Avatar Of Bloodlines")]
		MapAreaContainsAvatarOfBloodlines = 5585,

		[Description("Map Area Contains Avatar Of Nemesis")]
		MapAreaContainsAvatarOfNemesis = 5586,

		[Description("Map Area Contains Avatar Of Torment")]
		MapAreaContainsAvatarOfTorment = 5587,

		[Description("Map Area Contains Avatar Of Domination")]
		MapAreaContainsAvatarOfDomination = 5588,

		[Description("Map Area Contains Avatar Of Invasion")]
		MapAreaContainsAvatarOfInvasion = 5589,

		[Description("Map Area Contains Avatar Of Warbands")]
		MapAreaContainsAvatarOfWarbands = 5590,

		[Description("Avoid Freeze And Chill % If You Have Used A Fire Skill Recently")]
		AvoidFreezeAndChillPctIfYouHaveUsedAFireSkillRecently = 5591,

		[Description("Track Have Used A Fire Skill Recently")]
		TrackHaveUsedAFireSkillRecently = 5592,

		[Description("Have Used A Fire Skill Recently")]
		HaveUsedAFireSkillRecently = 5593,

		[Description("Avoid Shock % While Chilled")]
		AvoidShockPctWhileChilled = 5594,

		[Description("Local Display Nearby Enemies Are Intimidated")]
		LocalDisplayNearbyEnemiesAreIntimidated = 5595,

		[Description("Chance To Shock Chilled Enemies %")]
		ChanceToShockChilledEnemiesPct = 5596,

		[Description("Map Area Contains Map Chest")]
		MapAreaContainsMapChest = 5597,

		[Description("Map Area Contains Unique Item Chest")]
		MapAreaContainsUniqueItemChest = 5598,

		[Description("Map Area Contains Currency Chest")]
		MapAreaContainsCurrencyChest = 5599,

		[Description("Map Area Contains Perandus Coin Chest")]
		MapAreaContainsPerandusCoinChest = 5600,

		[Description("Map Area Contains Jewellery Chest")]
		MapAreaContainsJewelleryChest = 5601,

		[Description("Perandus Double Number Of Coins Found")]
		PerandusDoubleNumberOfCoinsFound = 5602,

		[Description("Local Chill On Hit Ms If In Off Hand")]
		LocalChillOnHitMsIfInOffHand = 5603,

		[Description("Off Hand Local Chill On Hit Ms")]
		OffHandLocalChillOnHitMs = 5604,

		[Description("Movement Speed +% On Throwing Trap")]
		MovementSpeedPosPctOnThrowingTrap = 5605,

		[Description("Herald Of Thunder Buff Effect +%")]
		HeraldOfThunderBuffEffectPosPct = 5606,

		[Description("Local Display Movement Speed +% For You And Nearby Allies")]
		LocalDisplayMovementSpeedPosPctForYouAndNearbyAllies = 5607,

		[Description("Curse On Hit Level Flammability")]
		CurseOnHitLevelFlammability = 5608,

		[Description("Phasing On Trap Triggered By An Enemy Ms")]
		PhasingOnTrapTriggeredByAnEnemyMs = 5609,

		[Description("Global Attack Speed +% Per Level")]
		GlobalAttackSpeedPosPctPerLevel = 5610,

		[Description("Physical Damage +% Final For Minion")]
		PhysicalDamagePosPctFinalForMinion = 5611,

		[Description("Zombie Physical Damage +% Final")]
		ZombiePhysicalDamagePosPctFinal = 5612,

		[Description("Ground Tar When Hit Base Area Of Effect Radius")]
		GroundTarWhenHitBaseAreaOfEffectRadius = 5613,

		[Description("Ground Tar When Hit Duration Ms")]
		GroundTarWhenHitDurationMs = 5614,

		[Description("Ground Tar When Hit Movement Speed +%")]
		GroundTarWhenHitMovementSpeedPosPct = 5615,

		[Description("Chance To Gain Unholy Might On Block Ms")]
		ChanceToGainUnholyMightOnBlockMs = 5616,

		[Description("Old Dagger Implicit Critical Strike Chance +30%")]
		OldDaggerImplicitCriticalStrikeChancePos30Pct = 5617,

		[Description("Old Dagger Implicit Critical Strike Chance +40%")]
		OldDaggerImplicitCriticalStrikeChancePos40Pct = 5618,

		[Description("Old Dagger Implicit Critical Strike Chance +50%")]
		OldDaggerImplicitCriticalStrikeChancePos50Pct = 5619,

		[Description("Old Dagger Implicit Critical Strike Chance +30% From Main Hand")]
		OldDaggerImplicitCriticalStrikeChancePos30PctFromMainHand = 5620,

		[Description("Old Dagger Implicit Critical Strike Chance +40% From Main Hand")]
		OldDaggerImplicitCriticalStrikeChancePos40PctFromMainHand = 5621,

		[Description("Old Dagger Implicit Critical Strike Chance +50% From Main Hand")]
		OldDaggerImplicitCriticalStrikeChancePos50PctFromMainHand = 5622,

		[Description("Old Dagger Implicit Critical Strike Chance +30% From Off Hand")]
		OldDaggerImplicitCriticalStrikeChancePos30PctFromOffHand = 5623,

		[Description("Old Dagger Implicit Critical Strike Chance +40% From Off Hand")]
		OldDaggerImplicitCriticalStrikeChancePos40PctFromOffHand = 5624,

		[Description("Old Dagger Implicit Critical Strike Chance +50% From Off Hand")]
		OldDaggerImplicitCriticalStrikeChancePos50PctFromOffHand = 5625,

		[Description("Has Defender Conditional Damage Stats")]
		HasDefenderConditionalDamageStats = 5626,

		[Description("Area Transition Animation Index")]
		AreaTransitionAnimationIndex = 5627,

		[Description("Map Leaguestone Override Base Num Tormented Spirits")]
		MapLeaguestoneOverrideBaseNumTormentedSpirits = 5628,

		[Description("Map Leaguestone Additional Tormented Spirits")]
		MapLeaguestoneAdditionalTormentedSpirits = 5629,

		[Description("Map Random Unique Monster Is Possessed")]
		MapRandomUniqueMonsterIsPossessed = 5630,

		[Description("Map Tormented Spirits Drop X Additional Rare Items")]
		MapTormentedSpiritsDropXAdditionalRareItems = 5631,

		[Description("Map Area Contains Tormented Vaal Cultist")]
		MapAreaContainsTormentedVaalCultist = 5632,

		[Description("Map Area Contains Tormented Seditionist")]
		MapAreaContainsTormentedSeditionist = 5633,

		[Description("Map Area Contains Tormented Embezzler")]
		MapAreaContainsTormentedEmbezzler = 5634,

		[Description("Map Leaguestone Override Base Num Perandus Chests")]
		MapLeaguestoneOverrideBaseNumPerandusChests = 5635,

		[Description("Display Monster Uses Vaal Burning Arrow")]
		DisplayMonsterUsesVaalBurningArrow = 5636,

		[Description("Remove Parent Life On Death Permyriad")]
		RemoveParentLifeOnDeathPermyriad = 5637,

		[Description("Curse On Hit Level Projectile Weakness")]
		CurseOnHitLevelProjectileWeakness = 5638,

		[Description("Local Left Ring Slot Maximum Mana")]
		LocalLeftRingSlotMaximumMana = 5639,

		[Description("Local Right Ring Slot Energy Shield")]
		LocalRightRingSlotEnergyShield = 5640,

		[Description("Map Leaguestone Additional Breaches")]
		MapLeaguestoneAdditionalBreaches = 5641,

		[Description("Map Leaguestone Additional Monoliths")]
		MapLeaguestoneAdditionalMonoliths = 5642,

		[Description("Map Leaguestone Additional Talismans")]
		MapLeaguestoneAdditionalTalismans = 5643,

		[Description("Map Leaguestone Additional Rogue Exiles")]
		MapLeaguestoneAdditionalRogueExiles = 5644,

		[Description("Map Leaguestone Additional Perandus Chests")]
		MapLeaguestoneAdditionalPerandusChests = 5645,

		[Description("Local Left Ring Slot Mana Regeneration Rate Per Minute")]
		LocalLeftRingSlotManaRegenerationRatePerMinute = 5646,

		[Description("Local Right Ring Slot Maximum Mana")]
		LocalRightRingSlotMaximumMana = 5647,

		[Description("Local Left Ring Slot Energy Shield")]
		LocalLeftRingSlotEnergyShield = 5648,

		[Description("Local Display Cast Level X Consecrate On Crit")]
		LocalDisplayCastLevelXConsecrateOnCrit = 5649,
		[Description("Is Tormented Spirit")] IsTormentedSpirit = 5650,

		[Description("Shavronne Teleport Number Of Markers")]
		ShavronneTeleportNumberOfMarkers = 5651,
		[Description("Map Packs Are Spiders")] MapPacksAreSpiders = 5652,

		[Description("Map Packs Are Blackguards")]
		MapPacksAreBlackguards = 5653,

		[Description("Local Display Cast Level 1 Summon Lesser Shrine On Kill %")]
		LocalDisplayCastLevel1SummonLesserShrineOnKillPct = 5654,

		[Description("Shavronne Teleport No Teleport")]
		ShavronneTeleportNoTeleport = 5655,

		[Description("Debug Projectile Index Override")]
		DebugProjectileIndexOverride = 5656,

		[Description("Ground Slam Retarget After Contact Point")]
		GroundSlamRetargetAfterContactPoint = 5657,

		[Description("Map Leaguestone Override Base Num Warband Packs")]
		MapLeaguestoneOverrideBaseNumWarbandPacks = 5658,

		[Description("Map Leaguestone Additional Warband Packs")]
		MapLeaguestoneAdditionalWarbandPacks = 5659,

		[Description("Map Leaguestone Explicit Warband Type Override")]
		MapLeaguestoneExplicitWarbandTypeOverride = 5660,

		[Description("Map Leaguestone Contains Warband Leader")]
		MapLeaguestoneContainsWarbandLeader = 5661,

		[Description("Map Leaguestone Override Base Num Shrines")]
		MapLeaguestoneOverrideBaseNumShrines = 5662,

		[Description("Map Leaguestone Shrine Monster Rarity Override")]
		MapLeaguestoneShrineMonsterRarityOverride = 5663,

		[Description("Map Leaguestone Shrine Override Type")]
		MapLeaguestoneShrineOverrideType = 5664,
		[Description("Map Rampage Time +%")] MapRampageTimePosPct = 5665,

		[Description("Map Contains X Additional Animated Weapon Packs")]
		MapContainsXAdditionalAnimatedWeaponPacks = 5666,

		[Description("Map Leaguestones Currency Items Drop When First Reaching X Rampage Stacks")]
		MapLeaguestonesCurrencyItemsDropWhenFirstReachingXRampageStacks = 5667,

		[Description("Map Leaguestones Spawn Powerful Monster When Reaching X Rampage Stacks")]
		MapLeaguestonesSpawnPowerfulMonsterWhenReachingXRampageStacks = 5668,

		[Description("Map Contains Keepers Of The Trove Bloodline Pack")]
		MapContainsKeepersOfTheTroveBloodlinePack = 5669,

		[Description("Map Contains Wealthy Pack")]
		MapContainsWealthyPack = 5670,

		[Description("Map Leaguestone Implicit Tempest Random")]
		MapLeaguestoneImplicitTempestRandom = 5671,

		[Description("Map Leaguestone Explicit Tempest Type Override")]
		MapLeaguestoneExplicitTempestTypeOverride = 5672,

		[Description("Local Unique Jewel Frostbolt Additional Projectiles With 40 Int In Radius")]
		LocalUniqueJewelFrostboltAdditionalProjectilesWith40IntInRadius = 5673,

		[Description("Frostbolt Number Of Additional Projectiles")]
		FrostboltNumberOfAdditionalProjectiles = 5674,

		[Description("Skill Area Of Effect +% Final")]
		SkillAreaOfEffectPosPctFinal = 5675,

		[Description("Total Skill Area Of Effect +% Including Final")]
		TotalSkillAreaOfEffectPosPctIncludingFinal = 5676,

		[Description("Local Unique Jewel Magma Orb Additional Projectiles With 40 Int In Radius")]
		LocalUniqueJewelMagmaOrbAdditionalProjectilesWith40IntInRadius = 5677,

		[Description("Magma Orb Number Of Additional Projectiles")]
		MagmaOrbNumberOfAdditionalProjectiles = 5678,

		[Description("Curse On Hit Level Cold Weakness")]
		CurseOnHitLevelColdWeakness = 5679,

		[Description("Elemental Damage +% If Used A Warcry Recently")]
		ElementalDamagePosPctIfUsedAWarcryRecently = 5680,

		[Description("Local Display Socketed Golem Attack And Cast Speed +%")]
		LocalDisplaySocketedGolemAttackAndCastSpeedPosPct = 5681,

		[Description("Local Display Cast Animate Weapon On Kill % Chance")]
		LocalDisplayCastAnimateWeaponOnKillPctChance = 5682,

		[Description("Gain Onslaught Ms On Skill Use")]
		GainOnslaughtMsOnSkillUse = 5683,

		[Description("Local Display Socketed Golem Skill Grants Onslaught When Summoned")]
		LocalDisplaySocketedGolemSkillGrantsOnslaughtWhenSummoned = 5684,
		[Description("Has Unholy Might")] HasUnholyMight = 5685,

		[Description("Chest Drop Reliquary Items")]
		ChestDropReliquaryItems = 5686,

		[Description("Deal No Skill Dot Damage Over Time")]
		DealNoSkillDotDamageOverTime = 5687,

		[Description("Combined All Projectile Damage +%")]
		CombinedAllProjectileDamagePosPct = 5688,

		[Description("Combined All Projectile Damage +% Final")]
		CombinedAllProjectileDamagePosPctFinal = 5689,

		[Description("Combined All Area Damage +%")]
		CombinedAllAreaDamagePosPct = 5690,

		[Description("Combined All Area Damage +% Final")]
		CombinedAllAreaDamagePosPctFinal = 5691,

		[Description("Combined All Added Damage +% Final")]
		CombinedAllAddedDamagePosPctFinal = 5692,

		[Description("Combined Hit All Damage +%")]
		CombinedHitAllDamagePosPct = 5693,

		[Description("Combined Skill Dot All Damage Over Time +%")]
		CombinedSkillDotAllDamageOverTimePosPct = 5694,

		[Description("Combined Skill Dot All Damage Over Time +% Final")]
		CombinedSkillDotAllDamageOverTimePosPctFinal = 5695,

		[Description("Projectile Damage Modifiers Apply To Skill Dot")]
		ProjectileDamageModifiersApplyToSkillDot = 5696,

		[Description("Fire Beam Max Rotation Speed +%")]
		FireBeamMaxRotationSpeedPosPct = 5697,

		[Description("Map Player Onslaught On Kill %")]
		MapPlayerOnslaughtOnKillPct = 5698,

		[Description("Map Monster Attack Cast And Movement Speed +%")]
		MapMonsterAttackCastAndMovementSpeedPosPct = 5699,

		[Description("Map Rare Monsters Drop X Additional Rare Items")]
		MapRareMonstersDropXAdditionalRareItems = 5700,

		[Description("Map Area Contains X Rare Monsters With Inner Treasure")]
		MapAreaContainsXRareMonstersWithInnerTreasure = 5701,

		[Description("Map Leaguestone Invasion Boss Item Quantity And Rarity +% Final")]
		MapLeaguestoneInvasionBossItemQuantityAndRarityPosPctFinal = 5702,

		[Description("Map First Invasion Boss Killed Drops X Additional Currency")]
		MapFirstInvasionBossKilledDropsXAdditionalCurrency = 5703,

		[Description("Map Invasion Monsters Guarded By X Magic Packs")]
		MapInvasionMonstersGuardedByXMagicPacks = 5704,

		[Description("Map Leaguestone Override Base Num Strongboxes")]
		MapLeaguestoneOverrideBaseNumStrongboxes = 5705,

		[Description("Map Leaguestone Additional Strongboxes")]
		MapLeaguestoneAdditionalStrongboxes = 5706,

		[Description("Map First Strongbox Contains X Additional Rare Monsters")]
		MapFirstStrongboxContainsXAdditionalRareMonsters = 5707,

		[Description("Map Area Contains Gemcutters Strongbox")]
		MapAreaContainsGemcuttersStrongbox = 5708,

		[Description("Map Area Contains Cartographers Strongbox")]
		MapAreaContainsCartographersStrongbox = 5709,

		[Description("Map Area Contains Unique Strongbox")]
		MapAreaContainsUniqueStrongbox = 5710,

		[Description("Map Area Contains Arcanists Strongbox")]
		MapAreaContainsArcanistsStrongbox = 5711,

		[Description("Map Strongboxes Drop X Additional Rare Items")]
		MapStrongboxesDropXAdditionalRareItems = 5712,

		[Description("Map Leaguestone Beyond Monster Item Quantity And Rarity +% Final")]
		MapLeaguestoneBeyondMonsterItemQuantityAndRarityPosPctFinal = 5713,

		[Description("Map First Unique Beyond Boss Slain Drops X Beyond Uniques")]
		MapFirstUniqueBeyondBossSlainDropsXBeyondUniques = 5714,

		[Description("Map Leaguestone X Monsters Spawn Random Beyond Boss")]
		MapLeaguestoneXMonstersSpawnRandomBeyondBoss = 5715,

		[Description("Map Leaguestone X Monsters Spawn Abaxoth")]
		MapLeaguestoneXMonstersSpawnAbaxoth = 5716,

		[Description("Map Item Found Rarity +% Per 15 Rampage Stacks")]
		MapItemFoundRarityPosPctPer15RampageStacks = 5717,

		[Description("Item Found Rarity +% Per 15 Rampage Stacks")]
		ItemFoundRarityPosPctPer15RampageStacks = 5718,

		[Description("Leaguestone Spawn Beyond Monster On Death Index")]
		LeaguestoneSpawnBeyondMonsterOnDeathIndex = 5719,

		[Description("Map Contains Three Magic Packs With Attack Cast And Movement Speed +%")]
		MapContainsThreeMagicPacksWithAttackCastAndMovementSpeedPosPct = 5720,

		[Description("Map Contains Three Magic Packs With Item Quantity Of Dropped Items +% Final")]
		MapContainsThreeMagicPacksWithItemQuantityOfDroppedItemsPosPctFinal = 5721,

		[Description("Leaguestone Maximum Area Level")]
		LeaguestoneMaximumAreaLevel = 5722,

		[Description("Attack Minimum Added Physical Damage Per Level")]
		AttackMinimumAddedPhysicalDamagePerLevel = 5723,

		[Description("Attack Maximum Added Physical Damage Per Level")]
		AttackMaximumAddedPhysicalDamagePerLevel = 5724,

		[Description("Attack Minimum Added Fire Damage Per 10 Strength")]
		AttackMinimumAddedFireDamagePer10Strength = 5725,

		[Description("Attack Maximum Added Fire Damage Per 10 Strength")]
		AttackMaximumAddedFireDamagePer10Strength = 5726,

		[Description("Unique Ryuslathas Clutches Minimum Physical Attack Damage +% Final")]
		UniqueRyuslathasClutchesMinimumPhysicalAttackDamagePosPctFinal = 5727,

		[Description("Unique Ryuslathas Clutches Maximum Physical Attack Damage +% Final")]
		UniqueRyuslathasClutchesMaximumPhysicalAttackDamagePosPctFinal = 5728,
		[Description("Is Intimidated")] IsIntimidated = 5729,

		[Description("Local Unique Jewel Frost Blades Melee Damage Penetrates % Cold Resistance With 40 Dex In Radius")]
		LocalUniqueJewelFrostBladesMeleeDamagePenetratesPctColdResistanceWith40DexInRadius = 5730,

		[Description("Frost Blades Melee Damage Penetrates % Cold Resistance")]
		FrostBladesMeleeDamagePenetratesPctColdResistance = 5731,

		[Description("Melee Damage Penetrates % Cold Resistance")]
		MeleeDamagePenetratesPctColdResistance = 5732,

		[Description("Local Display Socketed Golem Skills Minions Life % To Add As Energy Shield")]
		LocalDisplaySocketedGolemSkillsMinionsLifePctToAddAsEnergyShield = 5733,

		[Description("Mana Leech Permyriad Vs Frozen Enemies")]
		ManaLeechPermyriadVsFrozenEnemies = 5734,

		[Description("Map Mini Monolith Monsters Are Magic")]
		MapMiniMonolithMonstersAreMagic = 5735,

		[Description("Map Shrines Grant A Random Additional Effect")]
		MapShrinesGrantARandomAdditionalEffect = 5736,

		[Description("Map Shrines Drop X Currency Items On Activation")]
		MapShrinesDropXCurrencyItemsOnActivation = 5737,

		[Description("Map Monsters Spawned With Talisman Drop Additional Rare Items")]
		MapMonstersSpawnedWithTalismanDropAdditionalRareItems = 5738,

		[Description("Chance To Cast On Kill %")]
		ChanceToCastOnKillPct = 5739,

		[Description("Map Warbands Packs Have Additional Grunts")]
		MapWarbandsPacksHaveAdditionalGrunts = 5740,

		[Description("Map Warbands Packs Have Additional Supports")]
		MapWarbandsPacksHaveAdditionalSupports = 5741,

		[Description("Map Warbands Packs Have Additional Elites")]
		MapWarbandsPacksHaveAdditionalElites = 5742,

		[Description("Map Leaguestone Warbands Packs Have Item Rarity +% Final")]
		MapLeaguestoneWarbandsPacksHaveItemRarityPosPctFinal = 5743,

		[Description("Map Leaguestone Warbands Packs Have Item Quantity +% Final")]
		MapLeaguestoneWarbandsPacksHaveItemQuantityPosPctFinal = 5744,

		[Description("Map Monsters Near Shrines Are Chilled")]
		MapMonstersNearShrinesAreChilled = 5745,

		[Description("Map Imprisoned Monsters Damage Taken +%")]
		MapImprisonedMonstersDamageTakenPosPct = 5746,

		[Description("Map Imprisoned Monsters Damage +%")]
		MapImprisonedMonstersDamagePosPct = 5747,

		[Description("Map Leaguestone Imprisoned Monsters Item Rarity +% Final")]
		MapLeaguestoneImprisonedMonstersItemRarityPosPctFinal = 5748,

		[Description("Map Leaguestone Imprisoned Monsters Item Quantity +% Final")]
		MapLeaguestoneImprisonedMonstersItemQuantityPosPctFinal = 5749,

		[Description("Map Leaguestone Strongboxes Rarity Override")]
		MapLeaguestoneStrongboxesRarityOverride = 5750,
		[Description("Has Shrine Effect")] HasShrineEffect = 5751,

		[Description("Map Player Dodge Chance % During Shrine Effect")]
		MapPlayerDodgeChancePctDuringShrineEffect = 5752,

		[Description("Dodge Chance % During Shrine Effect")]
		DodgeChancePctDuringShrineEffect = 5753,

		[Description("Map Player Damage +% Vs Breach Monsters")]
		MapPlayerDamagePosPctVsBreachMonsters = 5754,

		[Description("Map Player Damage Taken +% Vs Breach Monsters")]
		MapPlayerDamageTakenPosPctVsBreachMonsters = 5755,

		[Description("Damage +% Vs Breach Monsters")]
		DamagePosPctVsBreachMonsters = 5756,

		[Description("Damage Taken +% Vs Breach Monsters")]
		DamageTakenPosPctVsBreachMonsters = 5757,

		[Description("Map Rare Breach Monster Additional Breach Ring Drop Chance %")]
		MapRareBreachMonsterAdditionalBreachRingDropChancePct = 5758,

		[Description("Map Strongboxes Vaal Orb Drop Chance %")]
		MapStrongboxesVaalOrbDropChancePct = 5759,

		[Description("Map Player Shrine Effect Duration +%")]
		MapPlayerShrineEffectDurationPosPct = 5760,

		[Description("Monster Is Beyond Boss")]
		MonsterIsBeyondBoss = 5761,

		[Description("Active Skill Base Radius +")]
		ActiveSkillBaseRadiusPos = 5762,

		[Description("Map Leaguestone Area Contains X Additional Leaguestones")]
		MapLeaguestoneAreaContainsXAdditionalLeaguestones = 5763,

		[Description("Map Leaguestone Monolith Contains Essence Type")]
		MapLeaguestoneMonolithContainsEssenceType = 5764,

		[Description("Map Contains Uul Netol Breach")]
		MapContainsUulNetolBreach = 5765,

		[Description("Map Contains Chayula Breach")]
		MapContainsChayulaBreach = 5766,

		[Description("Number Of Animated Weapons Allowed")]
		NumberOfAnimatedWeaponsAllowed = 5767,

		[Description("Number Of Active Animated Weapons")]
		NumberOfActiveAnimatedWeapons = 5768,

		[Description("Map Leaguestone Perandus Chests Have Item Rarity +% Final")]
		MapLeaguestonePerandusChestsHaveItemRarityPosPctFinal = 5769,

		[Description("Map Leaguestone Perandus Chests Have Item Quantity +% Final")]
		MapLeaguestonePerandusChestsHaveItemQuantityPosPctFinal = 5770,

		[Description("Map Perandus Monsters Drop Perandus Coin Stack %")]
		MapPerandusMonstersDropPerandusCoinStackPct = 5771,

		[Description("Map Perandus Guards Are Rare")]
		MapPerandusGuardsAreRare = 5772,

		[Description("Map Contains Perandus Boss")]
		MapContainsPerandusBoss = 5773,

		[Description("Drop Perandus Coin Stack %")]
		DropPerandusCoinStackPct = 5774,

		[Description("Kills Count Twice For Rampage %")]
		KillsCountTwiceForRampagePct = 5775,

		[Description("Map Next Area Contains X Additional Voidspawn Of Abaxoth Packs")]
		MapNextAreaContainsXAdditionalVoidspawnOfAbaxothPacks = 5776,

		[Description("Map Next Area Contains X Additional Bearers Of The Guardian Packs")]
		MapNextAreaContainsXAdditionalBearersOfTheGuardianPacks = 5777,

		[Description("Map Gain Onslaught For X Ms On Killing Rare Monster")]
		MapGainOnslaughtForXMsOnKillingRareMonster = 5778,

		[Description("Gain Onslaught For X Ms On Killing Rare Monster")]
		GainOnslaughtForXMsOnKillingRareMonster = 5779,

		[Description("Monster Held Item Force No Drop Penalty")]
		MonsterHeldItemForceNoDropPenalty = 5780,

		[Description("Leaguestone Prefix Minimum Area Level")]
		LeaguestonePrefixMinimumAreaLevel = 5781,

		[Description("Leaguestone Suffix Minimum Area Level")]
		LeaguestoneSuffixMinimumAreaLevel = 5782,

		[Description("Map Rare Monsters Drop Rare Prismatic Ring On Death %")]
		MapRareMonstersDropRarePrismaticRingOnDeathPct = 5783,

		[Description("Drop Rare Prismatic Ring On Death %")]
		DropRarePrismaticRingOnDeathPct = 5784,

		[Description("Map Players Gain 1 Rare Monster Mods On Kill For 20 Seconds %")]
		MapPlayersGain1RareMonsterModsOnKillFor20SecondsPct = 5785,

		[Description("Gain 1 Rare Monster Mods On Kill For 20 Seconds %")]
		Gain1RareMonsterModsOnKillFor20SecondsPct = 5786,

		[Description("Monster Is Beyond Monster")]
		MonsterIsBeyondMonster = 5787,

		[Description("Map Spawn Beyond Boss When Beyond Boss Slain %")]
		MapSpawnBeyondBossWhenBeyondBossSlainPct = 5788,

		[Description("Map Damage Taken +% From Beyond Monsters")]
		MapDamageTakenPosPctFromBeyondMonsters = 5789,

		[Description("Damage Taken +% From Beyond Monsters")]
		DamageTakenPosPctFromBeyondMonsters = 5790,

		[Description("Map Monster Damage Taken +% While Possessed")]
		MapMonsterDamageTakenPosPctWhilePossessed = 5791,

		[Description("Monster Damage Taken +% While Possessed")]
		MonsterDamageTakenPosPctWhilePossessed = 5792,

		[Description("Map Invasion Bosses Drop X Additional Vaal Orbs")]
		MapInvasionBossesDropXAdditionalVaalOrbs = 5793,

		[Description("Map Invasion Bosses Dropped Items Are Fully Linked")]
		MapInvasionBossesDroppedItemsAreFullyLinked = 5794,

		[Description("Map Invasion Bosses Dropped Items Have X Additional Sockets")]
		MapInvasionBossesDroppedItemsHaveXAdditionalSockets = 5795,

		[Description("Is Holding Silver Coin")]
		IsHoldingSilverCoin = 5796,

		[Description("Map Monsters With Silver Coins Drop X Additional Rare Items")]
		MapMonstersWithSilverCoinsDropXAdditionalRareItems = 5797,

		[Description("Map Monsters With Silver Coins Drop X Additional Currency Items")]
		MapMonstersWithSilverCoinsDropXAdditionalCurrencyItems = 5798,

		[Description("Map Bloodline Packs Drop X Additional Rare Items")]
		MapBloodlinePacksDropXAdditionalRareItems = 5799,

		[Description("Map Bloodline Packs Drop X Additional Currency Items")]
		MapBloodlinePacksDropXAdditionalCurrencyItems = 5800,

		[Description("Map Player Attack Cast And Movement Speed +% During Onslaught")]
		MapPlayerAttackCastAndMovementSpeedPosPctDuringOnslaught = 5801,

		[Description("Attack Cast And Movement Speed +% During Onslaught")]
		AttackCastAndMovementSpeedPosPctDuringOnslaught = 5802,

		[Description("Map Leaguestone Additional Shrines")]
		MapLeaguestoneAdditionalShrines = 5803,

		[Description("Active Skill Area Of Effect Radius +% Final")]
		ActiveSkillAreaOfEffectRadiusPosPctFinal = 5804,

		[Description("Map Rare Monsters Are Hindered")]
		MapRareMonstersAreHindered = 5805,

		[Description("Map Players Movement Speed +%")]
		MapPlayersMovementSpeedPosPct = 5806,

		[Description("Map Magic Monsters Damage Taken +%")]
		MapMagicMonstersDamageTakenPosPct = 5807,

		[Description("Map Magic Monsters Are Maimed")]
		MapMagicMonstersAreMaimed = 5808,

		[Description("Map Players Gain Onslaught During Flask Effect")]
		MapPlayersGainOnslaughtDuringFlaskEffect = 5809,

		[Description("Map Players Gain Rare Monster Mods On Kill % Chance")]
		MapPlayersGainRareMonsterModsOnKillPctChance = 5810,

		[Description("Gain Rare Monster Mods On Kill % Chance")]
		GainRareMonsterModsOnKillPctChance = 5811,

		[Description("Map Invasion Bosses Are Twinned")]
		MapInvasionBossesAreTwinned = 5812,

		[Description("Map Tormented Spirits Movement Speed +%")]
		MapTormentedSpiritsMovementSpeedPosPct = 5813,

		[Description("Map Tormented Spirits Duration +%")]
		MapTormentedSpiritsDurationPosPct = 5814,

		[Description("Map Players Gain Onslaught After Opening A Strongbox Ms")]
		MapPlayersGainOnslaughtAfterOpeningAStrongboxMs = 5815,

		[Description("Gain Onslaught After Opening A Strongbox Ms")]
		GainOnslaughtAfterOpeningAStrongboxMs = 5816,

		[Description("Map Players Additional Spell Dodge %")]
		MapPlayersAdditionalSpellDodgePct = 5817,

		[Description("Map Rare Monsters Have Inner Treasure")]
		MapRareMonstersHaveInnerTreasure = 5818,

		[Description("Map Leaguestone Override Base Num Prophecy Coins")]
		MapLeaguestoneOverrideBaseNumProphecyCoins = 5819,

		[Description("Map Leaguestone Additional Prophecy Coins")]
		MapLeaguestoneAdditionalProphecyCoins = 5820,

		[Description("Map Leaguestone Override Base Num Invasion Bosses")]
		MapLeaguestoneOverrideBaseNumInvasionBosses = 5821,

		[Description("Map Leaguestone Additional Invasion Bosses")]
		MapLeaguestoneAdditionalInvasionBosses = 5822,

		[Description("Map Monster Beyond Portal Chance +%")]
		MapMonsterBeyondPortalChancePosPct = 5823,

		[Description("Local Unique Jewel Fireball Base Radius Up To + At Longer Ranges With 40 Int In Radius")]
		LocalUniqueJewelFireballBaseRadiusUpToPosAtLongerRangesWith40IntInRadius = 5824,

		[Description("Fireball Base Radius Up To + At Longer Ranges")]
		FireballBaseRadiusUpToPosAtLongerRanges = 5825,

		[Description("Local Display Cast Level X Shock Ground When Hit")]
		LocalDisplayCastLevelXShockGroundWhenHit = 5826,

		[Description("Curse With Enfeeble On Hit % Against Uncursed Enemies")]
		CurseWithEnfeebleOnHitPctAgainstUncursedEnemies = 5827,

		[Description("Map Rogue Exiles Drop Additional Currency Items With Quality")]
		MapRogueExilesDropAdditionalCurrencyItemsWithQuality = 5828,

		[Description("Map Rogue Exiles Dropped Items Are Duplicated")]
		MapRogueExilesDroppedItemsAreDuplicated = 5829,

		[Description("Map Rogue Exiles Dropped Items Are Corrupted")]
		MapRogueExilesDroppedItemsAreCorrupted = 5830,

		[Description("Map Rogue Exiles Dropped Items Are Fully Linked")]
		MapRogueExilesDroppedItemsAreFullyLinked = 5831,

		[Description("Drop Additional Vaal Orbs")]
		DropAdditionalVaalOrbs = 5832,

		[Description("Map Contains Additional Mandible Talisman")]
		MapContainsAdditionalMandibleTalisman = 5833,

		[Description("Map Contains Additional Chrysalis Talisman")]
		MapContainsAdditionalChrysalisTalisman = 5834,

		[Description("Map Contains Additional Writhing Talisman")]
		MapContainsAdditionalWrithingTalisman = 5835,

		[Description("Map Contains Additional Fangjaw Talisman")]
		MapContainsAdditionalFangjawTalisman = 5836,

		[Description("Map Contains Additional Clutching Talisman")]
		MapContainsAdditionalClutchingTalisman = 5837,

		[Description("Map Contains Additional Three Rat Talisman")]
		MapContainsAdditionalThreeRatTalisman = 5838,

		[Description("Map Contains Additional Unique Talisman")]
		MapContainsAdditionalUniqueTalisman = 5839,

		[Description("Map Tempest Frequency +%")]
		MapTempestFrequencyPosPct = 5840,

		[Description("Map Player Life Regeneration Rate Per Minute % Per 25 Rampage Stacks")]
		MapPlayerLifeRegenerationRatePerMinutePctPer25RampageStacks = 5841,

		[Description("Life Regeneration Rate Per Minute % Per 25 Rampage Stacks")]
		LifeRegenerationRatePerMinutePctPer25RampageStacks = 5842,

		[Description("Map Player Damage Taken +% While Rampaging")]
		MapPlayerDamageTakenPosPctWhileRampaging = 5843,

		[Description("Damage Taken +% While Rampaging")]
		DamageTakenPosPctWhileRampaging = 5844,

		[Description("Map Contains Corrupted Strongbox")]
		MapContainsCorruptedStrongbox = 5845,

		[Description("Number Of Monsters To Summon Override")]
		NumberOfMonstersToSummonOverride = 5846,

		[Description("Monster Beyond Portal Chance +% Final")]
		MonsterBeyondPortalChancePosPctFinal = 5847,

		[Description("Map Num Leaguestones Active")]
		MapNumLeaguestonesActive = 5848,

		[Description("Virtual Monster Dropped Item Rarity +%")]
		VirtualMonsterDroppedItemRarityPosPct = 5849,

		[Description("Virtual Monster Dropped Item Quantity +%")]
		VirtualMonsterDroppedItemQuantityPosPct = 5850,

		[Description("Virtual Chest Item Quantity +%")]
		VirtualChestItemQuantityPosPct = 5851,

		[Description("Virtual Chest Item Rarity +%")]
		VirtualChestItemRarityPosPct = 5852,

		[Description("Leaguestone Monster Dropped Item Rarity +% Final")]
		LeaguestoneMonsterDroppedItemRarityPosPctFinal = 5853,

		[Description("Leaguestone Monster Dropped Item Quantity +% Final")]
		LeaguestoneMonsterDroppedItemQuantityPosPctFinal = 5854,

		[Description("Leaguestone Chest Item Quantity +% Final")]
		LeaguestoneChestItemQuantityPosPctFinal = 5855,

		[Description("Leaguestone Chest Item Rarity +% Final")]
		LeaguestoneChestItemRarityPosPctFinal = 5856,

		[Description("Map Leaguestone Stone Circle % Chance")]
		MapLeaguestoneStoneCirclePctChance = 5857,

		[Description("Local Unique Jewel Frost Blades Projectile Speed +% With 40 Dex In Radius")]
		LocalUniqueJewelFrostBladesProjectileSpeedPosPctWith40DexInRadius = 5858,

		[Description("Local Unique Jewel Dual Strike Main Hand Deals Double Damage % With 40 Dex In Radius")]
		LocalUniqueJewelDualStrikeMainHandDealsDoubleDamagePctWith40DexInRadius = 5859,

		[Description("Dual Strike Main Hand Deals Double Damage %")]
		DualStrikeMainHandDealsDoubleDamagePct = 5860,

		[Description("Chance To Deal Double Damage %")]
		ChanceToDealDoubleDamagePct = 5861,

		[Description("Always Ignite While Burning")]
		AlwaysIgniteWhileBurning = 5862,
		[Description("Full Life Threshold")] FullLifeThreshold = 5863,

		[Description("Unique Rat Cage Chance To Squeak When Hit By Fire Damage")]
		UniqueRatCageChanceToSqueakWhenHitByFireDamage = 5864,

		[Description("Map Monster Slain Experience +%")]
		MapMonsterSlainExperiencePosPct = 5865,

		[Description("Map Imprisoned Monsters Action Speed +%")]
		MapImprisonedMonstersActionSpeedPosPct = 5866,

		[Description("Is Beyond Monster Daemon")]
		IsBeyondMonsterDaemon = 5867,

		[Description("Map Tempest Area Of Effect +% Visible")]
		MapTempestAreaOfEffectPosPctVisible = 5868,

		[Description("Fortify Applies To Nearby Allies For X Seconds")]
		FortifyAppliesToNearbyAlliesForXSeconds = 5869,

		[Description("Suppress Phasing Visual")]
		SuppressPhasingVisual = 5870,
		[Description("Show Phasing Visual")] ShowPhasingVisual = 5871,

		[Description("Energy Shield Has Started Recharging Recently")]
		EnergyShieldHasStartedRechargingRecently = 5872,

		[Description("Track Energy Shield Has Started Recharging Recently")]
		TrackEnergyShieldHasStartedRechargingRecently = 5873,

		[Description("Not Affected By Action Speed Modifiers")]
		NotAffectedByActionSpeedModifiers = 5874,

		[Description("Map Player Movement Velocity +%")]
		MapPlayerMovementVelocityPosPct = 5875,
		[Description("Lunaris Glaive Angle")] LunarisGlaiveAngle = 5876,

		[Description("Lunaris Glaive Acceleration X")]
		LunarisGlaiveAccelerationX = 5877,

		[Description("Lunaris Glaive Acceleration Y")]
		LunarisGlaiveAccelerationY = 5878,

		[Description("Maintain Projectile Direction When Using Contact Position")]
		MaintainProjectileDirectionWhenUsingContactPosition = 5879,
		[Description("Map Force Side Area")] MapForceSideArea = 5880,
		[Description("Map Num Sextant Mods")] MapNumSextantMods = 5881,

		[Description("Cannot Be Stunned If You Have Been Stunned Recently")]
		CannotBeStunnedIfYouHaveBeenStunnedRecently = 5882,

		[Description("Track Have Been Stunned Recently")]
		TrackHaveBeenStunnedRecently = 5883,

		[Description("Have Been Stunned Recently")]
		HaveBeenStunnedRecently = 5884,

		[Description("Cannot Be Frozen If You Have Been Frozen Recently")]
		CannotBeFrozenIfYouHaveBeenFrozenRecently = 5885,

		[Description("Track Have Been Frozen Recently")]
		TrackHaveBeenFrozenRecently = 5886,

		[Description("Have Been Frozen Recently")]
		HaveBeenFrozenRecently = 5887,

		[Description("Life And Energy Shield Recovery Rate +% If Stopped Taking Damage Over Time Recently")]
		LifeAndEnergyShieldRecoveryRatePosPctIfStoppedTakingDamageOverTimeRecently = 5888,

		[Description("Movement Speed +% While On Burning Ground")]
		MovementSpeedPosPctWhileOnBurningGround = 5889,

		[Description("Chaos Damage Over Time Resistance %")]
		ChaosDamageOverTimeResistancePct = 5890,

		[Description("While Stationary Gain Additional Physical Damage Reduction %")]
		WhileStationaryGainAdditionalPhysicalDamageReductionPct = 5891,

		[Description("While Stationary Gain Life Regeneration Rate Per Minute %")]
		WhileStationaryGainLifeRegenerationRatePerMinutePct = 5892,

		[Description("Fire Damage Taken +% While Moving")]
		FireDamageTakenPosPctWhileMoving = 5893,

		[Description("Cold And Lightning Damage Taken As Fire Damage When Hit % Chance")]
		ColdAndLightningDamageTakenAsFireDamageWhenHitPctChance = 5894,

		[Description("Life Flasks Gain X Charges Every 3 Seconds If You Have Not Used A Life Flask Recently")]
		LifeFlasksGainXChargesEvery3SecondsIfYouHaveNotUsedALifeFlaskRecently = 5895,

		[Description("Life Recovery +% From Flasks While On Low Life")]
		LifeRecoveryPosPctFromFlasksWhileOnLowLife = 5896,

		[Description("Virtual Flask Life To Recover +%")]
		VirtualFlaskLifeToRecoverPosPct = 5897,

		[Description("Additional % Chance To Evade Attacks If You Have Taken A Savage Hit Recently")]
		AdditionalPctChanceToEvadeAttacksIfYouHaveTakenASavageHitRecently = 5898,

		[Description("Physical Damage Reduction % Per Hit You Have Taken Recently")]
		PhysicalDamageReductionPctPerHitYouHaveTakenRecently = 5899,

		[Description("Curses Have No Effect On You For 4 Seconds Every 10 Seconds")]
		CursesHaveNoEffectOnYouFor4SecondsEvery10Seconds = 5900,

		[Description("Hinder Effect On Self +%")]
		HinderEffectOnSelfPosPct = 5901,

		[Description("Avoid Corrupted Blood % Chance")]
		AvoidCorruptedBloodPctChance = 5902,
		[Description("Avoid Maim % Chance")] AvoidMaimPctChance = 5903,

		[Description("Monster Ground Fire On Death Variation")]
		MonsterGroundFireOnDeathVariation = 5904,

		[Description("Traps Explode On Timeout")]
		TrapsExplodeOnTimeout = 5905,

		[Description("Physical Skill Dot Damage To Deal Per Minute")]
		PhysicalSkillDotDamageToDealPerMinute = 5906,

		[Description("Fire Skill Dot Damage To Deal Per Minute")]
		FireSkillDotDamageToDealPerMinute = 5907,

		[Description("Cold Skill Dot Damage To Deal Per Minute")]
		ColdSkillDotDamageToDealPerMinute = 5908,

		[Description("Lightning Skill Dot Damage To Deal Per Minute")]
		LightningSkillDotDamageToDealPerMinute = 5909,

		[Description("Chaos Skill Dot Damage To Deal Per Minute")]
		ChaosSkillDotDamageToDealPerMinute = 5910,

		[Description("Physical Area Damage To Deal Per Minute")]
		PhysicalAreaDamageToDealPerMinute = 5911,

		[Description("Fire Area Damage To Deal Per Minute")]
		FireAreaDamageToDealPerMinute = 5912,

		[Description("Cold Area Damage To Deal Per Minute")]
		ColdAreaDamageToDealPerMinute = 5913,

		[Description("Lightning Area Damage To Deal Per Minute")]
		LightningAreaDamageToDealPerMinute = 5914,

		[Description("Chaos Area Damage To Deal Per Minute")]
		ChaosAreaDamageToDealPerMinute = 5915,

		[Description("Physical Skill Dot Area Damage To Deal Per Minute")]
		PhysicalSkillDotAreaDamageToDealPerMinute = 5916,

		[Description("Fire Skill Dot Area Damage To Deal Per Minute")]
		FireSkillDotAreaDamageToDealPerMinute = 5917,

		[Description("Cold Skill Dot Area Damage To Deal Per Minute")]
		ColdSkillDotAreaDamageToDealPerMinute = 5918,

		[Description("Lightning Skill Dot Area Damage To Deal Per Minute")]
		LightningSkillDotAreaDamageToDealPerMinute = 5919,

		[Description("Chaos Skill Dot Area Damage To Deal Per Minute")]
		ChaosSkillDotAreaDamageToDealPerMinute = 5920,

		[Description("Combined Attack Elemental Damage Pluspercent")]
		CombinedAttackElementalDamagePluspercent = 5921,

		[Description("Combined Attack Lightning Damage Pluspercent")]
		CombinedAttackLightningDamagePluspercent = 5922,

		[Description("Combined Attack Lightning Damage Pluspercent Final")]
		CombinedAttackLightningDamagePluspercentFinal = 5923,

		[Description("Combined Skill Dot Elemental Damage Over Time +%")]
		CombinedSkillDotElementalDamageOverTimePosPct = 5924,

		[Description("Combined Skill Dot Fire Damage Over Time +%")]
		CombinedSkillDotFireDamageOverTimePosPct = 5925,

		[Description("Combined Skill Dot Cold Damage Over Time +%")]
		CombinedSkillDotColdDamageOverTimePosPct = 5926,

		[Description("Combined Skill Dot Lightning Damage Over Time +%")]
		CombinedSkillDotLightningDamageOverTimePosPct = 5927,

		[Description("Combined Skill Dot Lightning Damage Over Time +% Final")]
		CombinedSkillDotLightningDamageOverTimePosPctFinal = 5928,
		[Description("Ignite Damage +%")] IgniteDamagePosPct = 5929,

		[Description("Combined Ignite Damage Over Time +%")]
		CombinedIgniteDamageOverTimePosPct = 5930,
		[Description("Bleed Is Skill Dot")] BleedIsSkillDot = 5931,
		[Description("Ignite Is Skill Dot")] IgniteIsSkillDot = 5932,
		[Description("Poison Is Skill Dot")] PoisonIsSkillDot = 5933,

		[Description("Deal No Bleed Damage Over Time")]
		DealNoBleedDamageOverTime = 5934,

		[Description("Deal No Ignite Damage Over Time")]
		DealNoIgniteDamageOverTime = 5935,

		[Description("Deal No Poison Damage Over Time")]
		DealNoPoisonDamageOverTime = 5936,

		[Description("Minimum Bleed Damage To Deal Per Minute From Main Hand Physical Damage")]
		MinimumBleedDamageToDealPerMinuteFromMainHandPhysicalDamage = 5937,

		[Description("Maximum Bleed Damage To Deal Per Minute From Main Hand Physical Damage")]
		MaximumBleedDamageToDealPerMinuteFromMainHandPhysicalDamage = 5938,
		[Description("Keystone Ghost Reaver")] KeystoneGhostReaver = 5939,

		[Description("Infest On Hit Chance %")]
		InfestOnHitChancePct = 5940,

		[Description("Infest On Hit Duration Ms")]
		InfestOnHitDurationMs = 5941,

		[Description("Energy Shield Per Level")]
		EnergyShieldPerLevel = 5942,

		[Description("Minimum Bleed Damage To Deal Per Minute From Off Hand Physical Damage")]
		MinimumBleedDamageToDealPerMinuteFromOffHandPhysicalDamage = 5943,

		[Description("Maximum Bleed Damage To Deal Per Minute From Off Hand Physical Damage")]
		MaximumBleedDamageToDealPerMinuteFromOffHandPhysicalDamage = 5944,

		[Description("Virtual Physical Damage Can Ignite")]
		VirtualPhysicalDamageCanIgnite = 5945,

		[Description("Virtual Fire Damage Cannot Ignite")]
		VirtualFireDamageCannotIgnite = 5946,

		[Description("Virtual Cold Damage Can Ignite")]
		VirtualColdDamageCanIgnite = 5947,

		[Description("Virtual Lightning Damage Can Ignite")]
		VirtualLightningDamageCanIgnite = 5948,

		[Description("Virtual Chaos Damage Can Ignite")]
		VirtualChaosDamageCanIgnite = 5949,

		[Description("Minimum Ignite Damage To Deal Per Minute From Main Hand Physical Damage")]
		MinimumIgniteDamageToDealPerMinuteFromMainHandPhysicalDamage = 5950,

		[Description("Maximum Ignite Damage To Deal Per Minute From Main Hand Physical Damage")]
		MaximumIgniteDamageToDealPerMinuteFromMainHandPhysicalDamage = 5951,

		[Description("Minimum Ignite Damage To Deal Per Minute From Main Hand Fire Damage")]
		MinimumIgniteDamageToDealPerMinuteFromMainHandFireDamage = 5952,

		[Description("Maximum Ignite Damage To Deal Per Minute From Main Hand Fire Damage")]
		MaximumIgniteDamageToDealPerMinuteFromMainHandFireDamage = 5953,

		[Description("Minimum Ignite Damage To Deal Per Minute From Main Hand Cold Damage")]
		MinimumIgniteDamageToDealPerMinuteFromMainHandColdDamage = 5954,

		[Description("Maximum Ignite Damage To Deal Per Minute From Main Hand Cold Damage")]
		MaximumIgniteDamageToDealPerMinuteFromMainHandColdDamage = 5955,

		[Description("Minimum Ignite Damage To Deal Per Minute From Main Hand Lightning Damage")]
		MinimumIgniteDamageToDealPerMinuteFromMainHandLightningDamage = 5956,

		[Description("Maximum Ignite Damage To Deal Per Minute From Main Hand Lightning Damage")]
		MaximumIgniteDamageToDealPerMinuteFromMainHandLightningDamage = 5957,

		[Description("Minimum Ignite Damage To Deal Per Minute From Main Hand Chaos Damage")]
		MinimumIgniteDamageToDealPerMinuteFromMainHandChaosDamage = 5958,

		[Description("Maximum Ignite Damage To Deal Per Minute From Main Hand Chaos Damage")]
		MaximumIgniteDamageToDealPerMinuteFromMainHandChaosDamage = 5959,

		[Description("Minimum Ignite Damage To Deal Per Minute From Off Hand Physical Damage")]
		MinimumIgniteDamageToDealPerMinuteFromOffHandPhysicalDamage = 5960,

		[Description("Maximum Ignite Damage To Deal Per Minute From Off Hand Physical Damage")]
		MaximumIgniteDamageToDealPerMinuteFromOffHandPhysicalDamage = 5961,

		[Description("Minimum Ignite Damage To Deal Per Minute From Off Hand Fire Damage")]
		MinimumIgniteDamageToDealPerMinuteFromOffHandFireDamage = 5962,

		[Description("Maximum Ignite Damage To Deal Per Minute From Off Hand Fire Damage")]
		MaximumIgniteDamageToDealPerMinuteFromOffHandFireDamage = 5963,

		[Description("Minimum Ignite Damage To Deal Per Minute From Off Hand Cold Damage")]
		MinimumIgniteDamageToDealPerMinuteFromOffHandColdDamage = 5964,

		[Description("Maximum Ignite Damage To Deal Per Minute From Off Hand Cold Damage")]
		MaximumIgniteDamageToDealPerMinuteFromOffHandColdDamage = 5965,

		[Description("Minimum Ignite Damage To Deal Per Minute From Off Hand Lightning Damage")]
		MinimumIgniteDamageToDealPerMinuteFromOffHandLightningDamage = 5966,

		[Description("Maximum Ignite Damage To Deal Per Minute From Off Hand Lightning Damage")]
		MaximumIgniteDamageToDealPerMinuteFromOffHandLightningDamage = 5967,

		[Description("Minimum Ignite Damage To Deal Per Minute From Off Hand Chaos Damage")]
		MinimumIgniteDamageToDealPerMinuteFromOffHandChaosDamage = 5968,

		[Description("Maximum Ignite Damage To Deal Per Minute From Off Hand Chaos Damage")]
		MaximumIgniteDamageToDealPerMinuteFromOffHandChaosDamage = 5969,

		[Description("Minimum Ignite Damage To Deal Per Minute From Spell Physical Damage")]
		MinimumIgniteDamageToDealPerMinuteFromSpellPhysicalDamage = 5970,

		[Description("Maximum Ignite Damage To Deal Per Minute From Spell Physical Damage")]
		MaximumIgniteDamageToDealPerMinuteFromSpellPhysicalDamage = 5971,

		[Description("Minimum Ignite Damage To Deal Per Minute From Spell Fire Damage")]
		MinimumIgniteDamageToDealPerMinuteFromSpellFireDamage = 5972,

		[Description("Maximum Ignite Damage To Deal Per Minute From Spell Fire Damage")]
		MaximumIgniteDamageToDealPerMinuteFromSpellFireDamage = 5973,

		[Description("Minimum Ignite Damage To Deal Per Minute From Spell Cold Damage")]
		MinimumIgniteDamageToDealPerMinuteFromSpellColdDamage = 5974,

		[Description("Maximum Ignite Damage To Deal Per Minute From Spell Cold Damage")]
		MaximumIgniteDamageToDealPerMinuteFromSpellColdDamage = 5975,

		[Description("Minimum Ignite Damage To Deal Per Minute From Spell Lightning Damage")]
		MinimumIgniteDamageToDealPerMinuteFromSpellLightningDamage = 5976,

		[Description("Maximum Ignite Damage To Deal Per Minute From Spell Lightning Damage")]
		MaximumIgniteDamageToDealPerMinuteFromSpellLightningDamage = 5977,

		[Description("Minimum Ignite Damage To Deal Per Minute From Spell Chaos Damage")]
		MinimumIgniteDamageToDealPerMinuteFromSpellChaosDamage = 5978,

		[Description("Maximum Ignite Damage To Deal Per Minute From Spell Chaos Damage")]
		MaximumIgniteDamageToDealPerMinuteFromSpellChaosDamage = 5979,

		[Description("Minimum Ignite Damage To Deal Per Minute From Secondary Physical Damage")]
		MinimumIgniteDamageToDealPerMinuteFromSecondaryPhysicalDamage = 5980,

		[Description("Maximum Ignite Damage To Deal Per Minute From Secondary Physical Damage")]
		MaximumIgniteDamageToDealPerMinuteFromSecondaryPhysicalDamage = 5981,

		[Description("Minimum Ignite Damage To Deal Per Minute From Secondary Fire Damage")]
		MinimumIgniteDamageToDealPerMinuteFromSecondaryFireDamage = 5982,

		[Description("Maximum Ignite Damage To Deal Per Minute From Secondary Fire Damage")]
		MaximumIgniteDamageToDealPerMinuteFromSecondaryFireDamage = 5983,

		[Description("Minimum Ignite Damage To Deal Per Minute From Secondary Cold Damage")]
		MinimumIgniteDamageToDealPerMinuteFromSecondaryColdDamage = 5984,

		[Description("Maximum Ignite Damage To Deal Per Minute From Secondary Cold Damage")]
		MaximumIgniteDamageToDealPerMinuteFromSecondaryColdDamage = 5985,

		[Description("Minimum Ignite Damage To Deal Per Minute From Secondary Lightning Damage")]
		MinimumIgniteDamageToDealPerMinuteFromSecondaryLightningDamage = 5986,

		[Description("Maximum Ignite Damage To Deal Per Minute From Secondary Lightning Damage")]
		MaximumIgniteDamageToDealPerMinuteFromSecondaryLightningDamage = 5987,

		[Description("Minimum Ignite Damage To Deal Per Minute From Secondary Chaos Damage")]
		MinimumIgniteDamageToDealPerMinuteFromSecondaryChaosDamage = 5988,

		[Description("Maximum Ignite Damage To Deal Per Minute From Secondary Chaos Damage")]
		MaximumIgniteDamageToDealPerMinuteFromSecondaryChaosDamage = 5989,

		[Description("Global Total Minimum Added Chaos Damage")]
		GlobalTotalMinimumAddedChaosDamage = 5990,

		[Description("Global Total Maximum Added Chaos Damage")]
		GlobalTotalMaximumAddedChaosDamage = 5991,

		[Description("Minimum Ignite Damage To Deal Per Minute From Main Hand Damage")]
		MinimumIgniteDamageToDealPerMinuteFromMainHandDamage = 5992,

		[Description("Maximum Ignite Damage To Deal Per Minute From Main Hand Damage")]
		MaximumIgniteDamageToDealPerMinuteFromMainHandDamage = 5993,

		[Description("Minimum Ignite Damage To Deal Per Minute From Off Hand Damage")]
		MinimumIgniteDamageToDealPerMinuteFromOffHandDamage = 5994,

		[Description("Maximum Ignite Damage To Deal Per Minute From Off Hand Damage")]
		MaximumIgniteDamageToDealPerMinuteFromOffHandDamage = 5995,

		[Description("Minimum Ignite Damage To Deal Per Minute From Spell Damage")]
		MinimumIgniteDamageToDealPerMinuteFromSpellDamage = 5996,

		[Description("Maximum Ignite Damage To Deal Per Minute From Spell Damage")]
		MaximumIgniteDamageToDealPerMinuteFromSpellDamage = 5997,

		[Description("Minimum Ignite Damage To Deal Per Minute From Secondary Damage")]
		MinimumIgniteDamageToDealPerMinuteFromSecondaryDamage = 5998,

		[Description("Maximum Ignite Damage To Deal Per Minute From Secondary Damage")]
		MaximumIgniteDamageToDealPerMinuteFromSecondaryDamage = 5999,
		[Description("Virtual Always Ignite")] VirtualAlwaysIgnite = 6000,

		[Description("Trap Additional Random Duration Ms")]
		TrapAdditionalRandomDurationMs = 6001,

		[Description("Minions Hits Can Only Kill Ignited Enemies")]
		MinionsHitsCanOnlyKillIgnitedEnemies = 6002,

		[Description("Hits Can Only Kill Ignited Enemies")]
		HitsCanOnlyKillIgnitedEnemies = 6003,

		[Description("Additional Spell Block % While Cursed")]
		AdditionalSpellBlockPctWhileCursed = 6004,

		[Description("Additional Block % While Not Cursed")]
		AdditionalBlockPctWhileNotCursed = 6005,

		[Description("Ignite Damage From Attack Skills +%")]
		IgniteDamageFromAttackSkillsPosPct = 6006,

		[Description("Minimum Poison Damage To Deal Per Minute From Main Hand Physical Damage")]
		MinimumPoisonDamageToDealPerMinuteFromMainHandPhysicalDamage = 6007,

		[Description("Maximum Poison Damage To Deal Per Minute From Main Hand Physical Damage")]
		MaximumPoisonDamageToDealPerMinuteFromMainHandPhysicalDamage = 6008,

		[Description("Minimum Poison Damage To Deal Per Minute From Main Hand Fire Damage")]
		MinimumPoisonDamageToDealPerMinuteFromMainHandFireDamage = 6009,

		[Description("Maximum Poison Damage To Deal Per Minute From Main Hand Fire Damage")]
		MaximumPoisonDamageToDealPerMinuteFromMainHandFireDamage = 6010,

		[Description("Minimum Poison Damage To Deal Per Minute From Main Hand Cold Damage")]
		MinimumPoisonDamageToDealPerMinuteFromMainHandColdDamage = 6011,

		[Description("Maximum Poison Damage To Deal Per Minute From Main Hand Cold Damage")]
		MaximumPoisonDamageToDealPerMinuteFromMainHandColdDamage = 6012,

		[Description("Minimum Poison Damage To Deal Per Minute From Main Hand Lightning Damage")]
		MinimumPoisonDamageToDealPerMinuteFromMainHandLightningDamage = 6013,

		[Description("Maximum Poison Damage To Deal Per Minute From Main Hand Lightning Damage")]
		MaximumPoisonDamageToDealPerMinuteFromMainHandLightningDamage = 6014,

		[Description("Minimum Poison Damage To Deal Per Minute From Main Hand Chaos Damage")]
		MinimumPoisonDamageToDealPerMinuteFromMainHandChaosDamage = 6015,

		[Description("Maximum Poison Damage To Deal Per Minute From Main Hand Chaos Damage")]
		MaximumPoisonDamageToDealPerMinuteFromMainHandChaosDamage = 6016,

		[Description("Minimum Poison Damage To Deal Per Minute From Off Hand Physical Damage")]
		MinimumPoisonDamageToDealPerMinuteFromOffHandPhysicalDamage = 6017,

		[Description("Maximum Poison Damage To Deal Per Minute From Off Hand Physical Damage")]
		MaximumPoisonDamageToDealPerMinuteFromOffHandPhysicalDamage = 6018,

		[Description("Minimum Poison Damage To Deal Per Minute From Off Hand Fire Damage")]
		MinimumPoisonDamageToDealPerMinuteFromOffHandFireDamage = 6019,

		[Description("Maximum Poison Damage To Deal Per Minute From Off Hand Fire Damage")]
		MaximumPoisonDamageToDealPerMinuteFromOffHandFireDamage = 6020,

		[Description("Minimum Poison Damage To Deal Per Minute From Off Hand Cold Damage")]
		MinimumPoisonDamageToDealPerMinuteFromOffHandColdDamage = 6021,

		[Description("Maximum Poison Damage To Deal Per Minute From Off Hand Cold Damage")]
		MaximumPoisonDamageToDealPerMinuteFromOffHandColdDamage = 6022,

		[Description("Minimum Poison Damage To Deal Per Minute From Off Hand Lightning Damage")]
		MinimumPoisonDamageToDealPerMinuteFromOffHandLightningDamage = 6023,

		[Description("Maximum Poison Damage To Deal Per Minute From Off Hand Lightning Damage")]
		MaximumPoisonDamageToDealPerMinuteFromOffHandLightningDamage = 6024,

		[Description("Minimum Poison Damage To Deal Per Minute From Off Hand Chaos Damage")]
		MinimumPoisonDamageToDealPerMinuteFromOffHandChaosDamage = 6025,

		[Description("Maximum Poison Damage To Deal Per Minute From Off Hand Chaos Damage")]
		MaximumPoisonDamageToDealPerMinuteFromOffHandChaosDamage = 6026,

		[Description("Minimum Poison Damage To Deal Per Minute From Spell Physical Damage")]
		MinimumPoisonDamageToDealPerMinuteFromSpellPhysicalDamage = 6027,

		[Description("Maximum Poison Damage To Deal Per Minute From Spell Physical Damage")]
		MaximumPoisonDamageToDealPerMinuteFromSpellPhysicalDamage = 6028,

		[Description("Minimum Poison Damage To Deal Per Minute From Spell Fire Damage")]
		MinimumPoisonDamageToDealPerMinuteFromSpellFireDamage = 6029,

		[Description("Maximum Poison Damage To Deal Per Minute From Spell Fire Damage")]
		MaximumPoisonDamageToDealPerMinuteFromSpellFireDamage = 6030,

		[Description("Minimum Poison Damage To Deal Per Minute From Spell Cold Damage")]
		MinimumPoisonDamageToDealPerMinuteFromSpellColdDamage = 6031,

		[Description("Maximum Poison Damage To Deal Per Minute From Spell Cold Damage")]
		MaximumPoisonDamageToDealPerMinuteFromSpellColdDamage = 6032,

		[Description("Minimum Poison Damage To Deal Per Minute From Spell Lightning Damage")]
		MinimumPoisonDamageToDealPerMinuteFromSpellLightningDamage = 6033,

		[Description("Maximum Poison Damage To Deal Per Minute From Spell Lightning Damage")]
		MaximumPoisonDamageToDealPerMinuteFromSpellLightningDamage = 6034,

		[Description("Minimum Poison Damage To Deal Per Minute From Spell Chaos Damage")]
		MinimumPoisonDamageToDealPerMinuteFromSpellChaosDamage = 6035,

		[Description("Maximum Poison Damage To Deal Per Minute From Spell Chaos Damage")]
		MaximumPoisonDamageToDealPerMinuteFromSpellChaosDamage = 6036,

		[Description("Minimum Poison Damage To Deal Per Minute From Secondary Physical Damage")]
		MinimumPoisonDamageToDealPerMinuteFromSecondaryPhysicalDamage = 6037,

		[Description("Maximum Poison Damage To Deal Per Minute From Secondary Physical Damage")]
		MaximumPoisonDamageToDealPerMinuteFromSecondaryPhysicalDamage = 6038,

		[Description("Minimum Poison Damage To Deal Per Minute From Secondary Fire Damage")]
		MinimumPoisonDamageToDealPerMinuteFromSecondaryFireDamage = 6039,

		[Description("Maximum Poison Damage To Deal Per Minute From Secondary Fire Damage")]
		MaximumPoisonDamageToDealPerMinuteFromSecondaryFireDamage = 6040,

		[Description("Minimum Poison Damage To Deal Per Minute From Secondary Cold Damage")]
		MinimumPoisonDamageToDealPerMinuteFromSecondaryColdDamage = 6041,

		[Description("Maximum Poison Damage To Deal Per Minute From Secondary Cold Damage")]
		MaximumPoisonDamageToDealPerMinuteFromSecondaryColdDamage = 6042,

		[Description("Minimum Poison Damage To Deal Per Minute From Secondary Lightning Damage")]
		MinimumPoisonDamageToDealPerMinuteFromSecondaryLightningDamage = 6043,

		[Description("Maximum Poison Damage To Deal Per Minute From Secondary Lightning Damage")]
		MaximumPoisonDamageToDealPerMinuteFromSecondaryLightningDamage = 6044,

		[Description("Minimum Poison Damage To Deal Per Minute From Secondary Chaos Damage")]
		MinimumPoisonDamageToDealPerMinuteFromSecondaryChaosDamage = 6045,

		[Description("Maximum Poison Damage To Deal Per Minute From Secondary Chaos Damage")]
		MaximumPoisonDamageToDealPerMinuteFromSecondaryChaosDamage = 6046,

		[Description("Combined Poison Damage Over Time +%")]
		CombinedPoisonDamageOverTimePosPct = 6047,

		[Description("Poison Damage From Attack Skills +%")]
		PoisonDamageFromAttackSkillsPosPct = 6048,

		[Description("Virtual Physical Damage Cannot Poison")]
		VirtualPhysicalDamageCannotPoison = 6049,

		[Description("Virtual Fire Damage Can Poison")]
		VirtualFireDamageCanPoison = 6050,

		[Description("Virtual Cold Damage Can Poison")]
		VirtualColdDamageCanPoison = 6051,

		[Description("Virtual Lightning Damage Can Poison")]
		VirtualLightningDamageCanPoison = 6052,

		[Description("Virtual Chaos Damage Cannot Poison")]
		VirtualChaosDamageCannotPoison = 6053,

		[Description("Non Chaos Damage Cannot Poison")]
		NonChaosDamageCannotPoison = 6054,
		[Description("All Damage Can Poison")] AllDamageCanPoison = 6055,

		[Description("Minimum Poison Damage To Deal Per Minute From Main Hand Damage")]
		MinimumPoisonDamageToDealPerMinuteFromMainHandDamage = 6056,

		[Description("Maximum Poison Damage To Deal Per Minute From Main Hand Damage")]
		MaximumPoisonDamageToDealPerMinuteFromMainHandDamage = 6057,

		[Description("Minimum Poison Damage To Deal Per Minute From Off Hand Damage")]
		MinimumPoisonDamageToDealPerMinuteFromOffHandDamage = 6058,

		[Description("Maximum Poison Damage To Deal Per Minute From Off Hand Damage")]
		MaximumPoisonDamageToDealPerMinuteFromOffHandDamage = 6059,

		[Description("Minimum Poison Damage To Deal Per Minute From Spell Damage")]
		MinimumPoisonDamageToDealPerMinuteFromSpellDamage = 6060,

		[Description("Maximum Poison Damage To Deal Per Minute From Spell Damage")]
		MaximumPoisonDamageToDealPerMinuteFromSpellDamage = 6061,

		[Description("Minimum Poison Damage To Deal Per Minute From Secondary Damage")]
		MinimumPoisonDamageToDealPerMinuteFromSecondaryDamage = 6062,

		[Description("Maximum Poison Damage To Deal Per Minute From Secondary Damage")]
		MaximumPoisonDamageToDealPerMinuteFromSecondaryDamage = 6063,

		[Description("Minimum Poison Damage To Always Deal Per Minute From Main Hand Damage")]
		MinimumPoisonDamageToAlwaysDealPerMinuteFromMainHandDamage = 6064,

		[Description("Maximum Poison Damage To Always Deal Per Minute From Main Hand Damage")]
		MaximumPoisonDamageToAlwaysDealPerMinuteFromMainHandDamage = 6065,

		[Description("Minimum Poison Damage To Always Deal Per Minute From Off Hand Damage")]
		MinimumPoisonDamageToAlwaysDealPerMinuteFromOffHandDamage = 6066,

		[Description("Maximum Poison Damage To Always Deal Per Minute From Off Hand Damage")]
		MaximumPoisonDamageToAlwaysDealPerMinuteFromOffHandDamage = 6067,

		[Description("Minimum Poison Damage To Always Deal Per Minute From Spell Damage")]
		MinimumPoisonDamageToAlwaysDealPerMinuteFromSpellDamage = 6068,

		[Description("Maximum Poison Damage To Always Deal Per Minute From Spell Damage")]
		MaximumPoisonDamageToAlwaysDealPerMinuteFromSpellDamage = 6069,

		[Description("Minimum Poison Damage To Always Deal Per Minute From Secondary Damage")]
		MinimumPoisonDamageToAlwaysDealPerMinuteFromSecondaryDamage = 6070,

		[Description("Maximum Poison Damage To Always Deal Per Minute From Secondary Damage")]
		MaximumPoisonDamageToAlwaysDealPerMinuteFromSecondaryDamage = 6071,

		[Description("Ice Spear Second Form Damage +%")]
		IceSpearSecondFormDamagePosPct = 6072,

		[Description("Extra Damage Taken From Crit While No Power Charges +%")]
		ExtraDamageTakenFromCritWhileNoPowerChargesPosPct = 6073,

		[Description("Chest Display Weylams War")]
		ChestDisplayWeylamsWar = 6074,

		[Description("Minion Movement Speed +% Per 50 Dex")]
		MinionMovementSpeedPosPctPer50Dex = 6075,

		[Description("Minion Attack Speed +% Per 50 Dex")]
		MinionAttackSpeedPosPctPer50Dex = 6076,

		[Description("Main Hand Attack Minimum Added Lightning Damage Per 10 Int")]
		MainHandAttackMinimumAddedLightningDamagePer10Int = 6077,

		[Description("Main Hand Attack Maximum Added Lightning Damage Per 10 Int")]
		MainHandAttackMaximumAddedLightningDamagePer10Int = 6078,

		[Description("Off Hand Attack Minimum Added Lightning Damage Per 10 Int")]
		OffHandAttackMinimumAddedLightningDamagePer10Int = 6079,

		[Description("Off Hand Attack Maximum Added Lightning Damage Per 10 Int")]
		OffHandAttackMaximumAddedLightningDamagePer10Int = 6080,

		[Description("Main Hand Attack Minimum Added Fire Damage Per 10 Strength")]
		MainHandAttackMinimumAddedFireDamagePer10Strength = 6081,

		[Description("Main Hand Attack Maximum Added Fire Damage Per 10 Strength")]
		MainHandAttackMaximumAddedFireDamagePer10Strength = 6082,

		[Description("Off Hand Attack Minimum Added Fire Damage Per 10 Strength")]
		OffHandAttackMinimumAddedFireDamagePer10Strength = 6083,

		[Description("Off Hand Attack Maximum Added Fire Damage Per 10 Strength")]
		OffHandAttackMaximumAddedFireDamagePer10Strength = 6084,

		[Description("Fire Beam Start Angle Offset Variance")]
		FireBeamStartAngleOffsetVariance = 6085,

		[Description("Display Monster May Inflict Bleeding")]
		DisplayMonsterMayInflictBleeding = 6086,

		[Description("Combined Bleeding Damage Over Time +%")]
		CombinedBleedingDamageOverTimePosPct = 6087,

		[Description("Combined Bleeding Damage Over Time +% Final")]
		CombinedBleedingDamageOverTimePosPctFinal = 6088,
		[Description("Bleeding Damage +%")] BleedingDamagePosPct = 6089,

		[Description("Active Skill Bleeding Damage +% Final")]
		ActiveSkillBleedingDamagePosPctFinal = 6090,

		[Description("Frog God Number Of Orbs To Summon")]
		FrogGodNumberOfOrbsToSummon = 6091,

		[Description("Combined Ignite Damage Over Time +% Final")]
		CombinedIgniteDamageOverTimePosPctFinal = 6092,

		[Description("Physical Damage With Attack Skills +%")]
		PhysicalDamageWithAttackSkillsPosPct = 6093,

		[Description("Elemental Damage With Attack Skills +%")]
		ElementalDamageWithAttackSkillsPosPct = 6094,

		[Description("Fire Damage With Attack Skills +%")]
		FireDamageWithAttackSkillsPosPct = 6095,

		[Description("Cold Damage With Attack Skills +%")]
		ColdDamageWithAttackSkillsPosPct = 6096,

		[Description("Lightning Damage With Attack Skills +%")]
		LightningDamageWithAttackSkillsPosPct = 6097,

		[Description("Chaos Damage With Attack Skills +%")]
		ChaosDamageWithAttackSkillsPosPct = 6098,

		[Description("Doedre Aura Damage +% Final")]
		DoedreAuraDamagePosPctFinal = 6099,

		[Description("Base Fire Damage % Of Maximum Life Plus Maximum Es To Deal Per Minute")]
		BaseFireDamagePctOfMaximumLifePlusMaximumEsToDealPerMinute = 6100,

		[Description("Cast At Teleport Start %")]
		CastAtTeleportStartPct = 6101,

		[Description("Cast At Teleport End %")]
		CastAtTeleportEndPct = 6102,

		[Description("Summoned Monsters Are Parented To My Target")]
		SummonedMonstersAreParentedToMyTarget = 6103,

		[Description("Cast At Mortar Impact %")]
		CastAtMortarImpactPct = 6104,

		[Description("Mortar Has Triggered Skills")]
		MortarHasTriggeredSkills = 6105,

		[Description("Active Skill Base Attack Damage Final Permyriad")]
		ActiveSkillBaseAttackDamageFinalPermyriad = 6106,

		[Description("Map Bosses Have Summon Zombie Giant")]
		MapBossesHaveSummonZombieGiant = 6107,

		[Description("Monster Spawn Bloodlines Zombie Giant")]
		MonsterSpawnBloodlinesZombieGiant = 6108,

		[Description("Base Critical Degen Multiplier")]
		BaseCriticalDegenMultiplier = 6109,

		[Description("Critical Degen Multiplier From Main Hand")]
		CriticalDegenMultiplierFromMainHand = 6110,

		[Description("Critical Degen Multiplier From Off Hand")]
		CriticalDegenMultiplierFromOffHand = 6111,

		[Description("Critical Degen Multiplier From Spell")]
		CriticalDegenMultiplierFromSpell = 6112,

		[Description("Critical Degen Multiplier From Secondary")]
		CriticalDegenMultiplierFromSecondary = 6113,

		[Description("Monster Ignite Damage +% Final")]
		MonsterIgniteDamagePosPctFinal = 6114,

		[Description("Monster Bleeding Damage +% Final")]
		MonsterBleedingDamagePosPctFinal = 6115,

		[Description("Monster Poison Damage +% Final")]
		MonsterPoisonDamagePosPctFinal = 6116,

		[Description("Combined Poison Damage Over Time +% Final")]
		CombinedPoisonDamageOverTimePosPctFinal = 6117,

		[Description("Bleeding Moving Damage % Of Base Override")]
		BleedingMovingDamagePctOfBaseOverride = 6118,

		[Description("Active Skill If Used Through Frostbolt Damage +% Final")]
		ActiveSkillIfUsedThroughFrostboltDamagePosPctFinal = 6119,

		[Description("Used Through Frostbolt")]
		UsedThroughFrostbolt = 6120,

		[Description("Display Monster May Inflict Maim")]
		DisplayMonsterMayInflictMaim = 6121,

		[Description("Support Attack Skills Elemental Damage +% Final")]
		SupportAttackSkillsElementalDamagePosPctFinal = 6122,

		[Description("Elemental Damage With Attack Skills +% While Using Flask")]
		ElementalDamageWithAttackSkillsPosPctWhileUsingFlask = 6123,

		[Description("Support Burning Damage +% Final")]
		SupportBurningDamagePosPctFinal = 6124,

		[Description("Bleeding Skill Effect Duration")]
		BleedingSkillEffectDuration = 6125,

		[Description("Bleed Duration Is Skill Duration")]
		BleedDurationIsSkillDuration = 6126,

		[Description("Base All Ailment Duration +%")]
		BaseAllAilmentDurationPosPct = 6127,

		[Description("Shocked Enemies Explode For % Life As Lightning Damage")]
		ShockedEnemiesExplodeForPctLifeAsLightningDamage = 6128,

		[Description("Track Number Of Enemies Shocked Recently")]
		TrackNumberOfEnemiesShockedRecently = 6129,

		[Description("Number Of Enemies Shocked Recently")]
		NumberOfEnemiesShockedRecently = 6130,

		[Description("Damage +% If You Have Shocked Recently")]
		DamagePosPctIfYouHaveShockedRecently = 6131,

		[Description("Herald Mana Reservation Override 45%")]
		HeraldManaReservationOverride45Pct = 6132,

		[Description("Avoid Stun 35% Per Active Herald")]
		AvoidStun35PctPerActiveHerald = 6133,

		[Description("Number Of Active Heralds")]
		NumberOfActiveHeralds = 6134,
		[Description("Base Avoid Stun %")] BaseAvoidStunPct = 6135,

		[Description("Herald Of Ash Burning Damage +% Final")]
		HeraldOfAshBurningDamagePosPctFinal = 6136,

		[Description("Depair Bear Upheaval Movement Speed +%")]
		DepairBearUpheavalMovementSpeedPosPct = 6137,

		[Description("Virtual Ignite Faster Burn %")]
		VirtualIgniteFasterBurnPct = 6138,

		[Description("Kill Traps Mines And Totems On Death")]
		KillTrapsMinesAndTotemsOnDeath = 6139,

		[Description("Chest Drop X Divination Cards")]
		ChestDropXDivinationCards = 6140,

		[Description("Chest Drop Divination Cards With Full Stack Number X")]
		ChestDropDivinationCardsWithFullStackNumberX = 6141,
		[Description("Keystone Ailment Crit")] KeystoneAilmentCrit = 6142,

		[Description("Fire Beam Prioritise Players For Targeting")]
		FireBeamPrioritisePlayersForTargeting = 6143,

		[Description("Support Ignite Proliferation Radius")]
		SupportIgniteProliferationRadius = 6144,

		[Description("Support Maimed Enemies Physical Damage Taken +%")]
		SupportMaimedEnemiesPhysicalDamageTakenPosPct = 6145,

		[Description("Support Chance To Ignite Fire Damage +% Final")]
		SupportChanceToIgniteFireDamagePosPctFinal = 6146,

		[Description("Support Better Ailments Ailment Damage +% Final")]
		SupportBetterAilmentsAilmentDamagePosPctFinal = 6147,

		[Description("Support Better Ailments Hit Damage +% Final")]
		SupportBetterAilmentsHitDamagePosPctFinal = 6148,

		[Description("Additional Chaos Resistance Against Damage Over Time %")]
		AdditionalChaosResistanceAgainstDamageOverTimePct = 6149,

		[Description("From Code Active Skill Hit Damage +% Final")]
		FromCodeActiveSkillHitDamagePosPctFinal = 6150,
		[Description("Hit Damage +%")] HitDamagePosPct = 6151,

		[Description("Uncapped Chaos Damage Over Time Resistance %")]
		UncappedChaosDamageOverTimeResistancePct = 6152,

		[Description("Attack Cast Movement Speed +% If Taken A Savage Hit Recently")]
		AttackCastMovementSpeedPosPctIfTakenASavageHitRecently = 6153,

		[Description("Chaos Resistance % For You And Allies Affected By Your Auras")]
		ChaosResistancePctForYouAndAlliesAffectedByYourAuras = 6154,

		[Description("Additional Block Chance % For You And Allies Affected By Your Auras")]
		AdditionalBlockChancePctForYouAndAlliesAffectedByYourAuras = 6155,

		[Description("Attack Cast Movement Speed +% For You And Allies Affected By Your Auras")]
		AttackCastMovementSpeedPosPctForYouAndAlliesAffectedByYourAuras = 6156,

		[Description("Mana Regeneration Rate Per Minute If Used Movement Skill Recently")]
		ManaRegenerationRatePerMinuteIfUsedMovementSkillRecently = 6157,

		[Description("Movement Speed +% If Placed Trap Or Mine Recently")]
		MovementSpeedPosPctIfPlacedTrapOrMineRecently = 6158,

		[Description("Trap And Mine Damage +% If Armed For 4 Seconds")]
		TrapAndMineDamagePosPctIfArmedFor4Seconds = 6159,

		[Description("Skill Effect And Damaging Ailment Duration +%")]
		SkillEffectAndDamagingAilmentDurationPosPct = 6160,

		[Description("Active Skill Damage Over Time From Projectile Hits +% Final")]
		ActiveSkillDamageOverTimeFromProjectileHitsPosPctFinal = 6161,

		[Description("Trigger Spawners Time Between Min Ms")]
		TriggerSpawnersTimeBetweenMinMs = 6162,

		[Description("Trigger Spawners Time Between Max Ms")]
		TriggerSpawnersTimeBetweenMaxMs = 6163,

		[Description("Cast On Delayed Skill Trigger %")]
		CastOnDelayedSkillTriggerPct = 6164,

		[Description("Track Have Used Movement Skill Recently")]
		TrackHaveUsedMovementSkillRecently = 6165,

		[Description("Have Used Movement Skill Recently")]
		HaveUsedMovementSkillRecently = 6166,

		[Description("Track Have Placed Trap Or Mine Recently")]
		TrackHavePlacedTrapOrMineRecently = 6167,

		[Description("Have Placed Trap Or Mine Recently")]
		HavePlacedTrapOrMineRecently = 6168,

		[Description("Blast Rain No Los Required")]
		BlastRainNoLosRequired = 6169,

		[Description("Despair Bear Upheaval Physical Damage To Deal Per Minute")]
		DespairBearUpheavalPhysicalDamageToDealPerMinute = 6170,

		[Description("Number Of Additional Ignites Allowed")]
		NumberOfAdditionalIgnitesAllowed = 6171,

		[Description("Cast On Trigger Charge Event %")]
		CastOnTriggerChargeEventPct = 6172,

		[Description("Monster Can Drop Hinekoras Sight")]
		MonsterCanDropHinekorasSight = 6173,

		[Description("Support Efficacy Spell Damage +% Final")]
		SupportEfficacySpellDamagePosPctFinal = 6174,

		[Description("Support Efficacy Damage Over Time +% Final")]
		SupportEfficacyDamageOverTimePosPctFinal = 6175,

		[Description("Support Debilitate Poison Damage +% Final")]
		SupportDebilitatePoisonDamagePosPctFinal = 6176,

		[Description("Support Debilitate Hit Damage +% Final")]
		SupportDebilitateHitDamagePosPctFinal = 6177,

		[Description("Support Debilitate Hit Damage +% Final Per Poison Stack")]
		SupportDebilitateHitDamagePosPctFinalPerPoisonStack = 6178,

		[Description("Support Debilitate Hit Damage Max Poison Stacks")]
		SupportDebilitateHitDamageMaxPoisonStacks = 6179,

		[Description("Global Minimum Added Fire Damage Vs Burning Enemies")]
		GlobalMinimumAddedFireDamageVsBurningEnemies = 6180,

		[Description("Global Maximum Added Fire Damage Vs Burning Enemies")]
		GlobalMaximumAddedFireDamageVsBurningEnemies = 6181,

		[Description("Support Unbound Ailments Ailment Damage +% Final")]
		SupportUnboundAilmentsAilmentDamagePosPctFinal = 6182,

		[Description("Trigger Charge Additional Block Chance Against Projectiles %")]
		TriggerChargeAdditionalBlockChanceAgainstProjectilesPct = 6183,

		[Description("Chaos Damage Resistance Is Doubled")]
		ChaosDamageResistanceIsDoubled = 6184,

		[Description("Skill Area Of Effect +% While No Frenzy Charges")]
		SkillAreaOfEffectPosPctWhileNoFrenzyCharges = 6185,

		[Description("Global Critical Strike Multiplier + While You Have No Frenzy Charges")]
		GlobalCriticalStrikeMultiplierPosWhileYouHaveNoFrenzyCharges = 6186,

		[Description("Gain Maximum Power Charges On Power Charge Gained % Chance")]
		GainMaximumPowerChargesOnPowerChargeGainedPctChance = 6187,

		[Description("Damage +% Per Power Charge")]
		DamagePosPctPerPowerCharge = 6188,

		[Description("Base Fire Damage Can Poison")]
		BaseFireDamageCanPoison = 6189,

		[Description("Base Cold Damage Can Poison")]
		BaseColdDamageCanPoison = 6190,

		[Description("Base Lightning Damage Can Poison")]
		BaseLightningDamageCanPoison = 6191,

		[Description("Fire Skills Chance To Poison On Hit %")]
		FireSkillsChanceToPoisonOnHitPct = 6192,

		[Description("Cold Skills Chance To Poison On Hit %")]
		ColdSkillsChanceToPoisonOnHitPct = 6193,

		[Description("Lightning Skills Chance To Poison On Hit %")]
		LightningSkillsChanceToPoisonOnHitPct = 6194,

		[Description("Movement Attack Skills Attack Speed +%")]
		MovementAttackSkillsAttackSpeedPosPct = 6195,

		[Description("Local Socketed Herald Gem Level +")]
		LocalSocketedHeraldGemLevelPos = 6196,

		[Description("Cold Damage +% If You Have Used A Fire Skill Recently")]
		ColdDamagePosPctIfYouHaveUsedAFireSkillRecently = 6197,

		[Description("Fire Damage +% If You Have Used A Cold Skill Recently")]
		FireDamagePosPctIfYouHaveUsedAColdSkillRecently = 6198,

		[Description("Track Have Used A Cold Skill Recently")]
		TrackHaveUsedAColdSkillRecently = 6199,

		[Description("Have Used A Cold Skill Recently")]
		HaveUsedAColdSkillRecently = 6200,

		[Description("Support Maim Chance Physical Damage +% Final")]
		SupportMaimChancePhysicalDamagePosPctFinal = 6201,

		[Description("Support Brutality Physical Damage +% Final")]
		SupportBrutalityPhysicalDamagePosPctFinal = 6202,

		[Description("Summon Specific Monsters In Front Offset")]
		SummonSpecificMonstersInFrontOffset = 6203,

		[Description("Trap And Mine Damage Penetrates % Elemental Resistance")]
		TrapAndMineDamagePenetratesPctElementalResistance = 6204,

		[Description("Cooldown Speed +% Per Additional Player")]
		CooldownSpeedPosPctPerAdditionalPlayer = 6205,

		[Description("Total Damage Taken Per Minute To Mana")]
		TotalDamageTakenPerMinuteToMana = 6206,

		[Description("Total Damage Taken Per Minute That Bypasses Es")]
		TotalDamageTakenPerMinuteThatBypassesEs = 6207,

		[Description("Total Damage Taken Per Minute That Damages Es")]
		TotalDamageTakenPerMinuteThatDamagesEs = 6208,

		[Description("Total Nonlethal Damage Taken Per Minute That Damages Es")]
		TotalNonlethalDamageTakenPerMinuteThatDamagesEs = 6209,

		[Description("Enemies That Hit You With Attack Recently Attack Speed +%")]
		EnemiesThatHitYouWithAttackRecentlyAttackSpeedPosPct = 6210,

		[Description("Vaal Skill Soul Cost +%")]
		VaalSkillSoulCostPosPct = 6211,

		[Description("Has Attacker Projectile Attack Conditional Damage Stats")]
		HasAttackerProjectileAttackConditionalDamageStats = 6212,

		[Description("Has Attacker Conditional Damage Stats")]
		HasAttackerConditionalDamageStats = 6213,

		[Description("Has Attacker Projectile Spell Conditional Damage Stats")]
		HasAttackerProjectileSpellConditionalDamageStats = 6214,

		[Description("Number Of Projectiles Override")]
		NumberOfProjectilesOverride = 6215,

		[Description("Map Pantheon Flask Capture Boss Soul")]
		MapPantheonFlaskCaptureBossSoul = 6216,

		[Description("Physical Damage Over Time Taken +% While Moving")]
		PhysicalDamageOverTimeTakenPosPctWhileMoving = 6217,

		[Description("Physical Damage Reduction % If Only One Enemy Nearby")]
		PhysicalDamageReductionPctIfOnlyOneEnemyNearby = 6218,

		[Description("Take Half Area Damage From Hit % Chance")]
		TakeHalfAreaDamageFromHitPctChance = 6219,

		[Description("Elemental Damage Taken +% If Not Hit Recently")]
		ElementalDamageTakenPosPctIfNotHitRecently = 6220,

		[Description("Self Take No Extra Damage From Critical Strikes If Have Been Crit Recently")]
		SelfTakeNoExtraDamageFromCriticalStrikesIfHaveBeenCritRecently = 6221,

		[Description("Have Been Crit Recently")]
		HaveBeenCritRecently = 6222,

		[Description("Track Have Been Crit Recently")]
		TrackHaveBeenCritRecently = 6223,

		[Description("Avoid Ailments % From Crit")]
		AvoidAilmentsPctFromCrit = 6224,

		[Description("Physical Damage Reduction % Per Nearby Enemy")]
		PhysicalDamageReductionPctPerNearbyEnemy = 6225,

		[Description("Movement Speed +% Per Nearby Enemy")]
		MovementSpeedPosPctPerNearbyEnemy = 6226,

		[Description("Base Avoid Projectiles % Chance")]
		BaseAvoidProjectilesPctChance = 6227,

		[Description("Dodge Attacks And Spells % Chance If Have Been Hit Recently")]
		DodgeAttacksAndSpellsPctChanceIfHaveBeenHitRecently = 6228,

		[Description("Prevent Projectile Chaining % Chance")]
		PreventProjectileChainingPctChance = 6229,

		[Description("Avoid Chained Projectile % Chance")]
		AvoidChainedProjectilePctChance = 6230,

		[Description("Cold Damage Taken +% If Have Been Hit Recently")]
		ColdDamageTakenPosPctIfHaveBeenHitRecently = 6231,

		[Description("Reflect Chill And Freeze % Chance")]
		ReflectChillAndFreezePctChance = 6232,

		[Description("Virtual Self Take No Extra Damage From Critical Strikes")]
		VirtualSelfTakeNoExtraDamageFromCriticalStrikes = 6233,

		[Description("Projectile Spread Radius Per Additional Projectile")]
		ProjectileSpreadRadiusPerAdditionalProjectile = 6234,

		[Description("Trigger Cascade Number Of Spikes")]
		TriggerCascadeNumberOfSpikes = 6235,

		[Description("Trigger Cascade Ms Between Spikes")]
		TriggerCascadeMsBetweenSpikes = 6236,

		[Description("Cast On Trigger Cascade Event %")]
		CastOnTriggerCascadeEventPct = 6237,

		[Description("Trigger Cascade Behaviour Variation")]
		TriggerCascadeBehaviourVariation = 6238,

		[Description("Garukhan Number Of Tornadoes")]
		GarukhanNumberOfTornadoes = 6239,

		[Description("Map Pack Subindex Override")]
		MapPackSubindexOverride = 6240,
		[Description("Map Boss Override")] MapBossOverride = 6241,

		[Description("Map Daily Mission Master Level")]
		MapDailyMissionMasterLevel = 6242,

		[Description("Number Of Nearby Enemies")]
		NumberOfNearbyEnemies = 6243,

		[Description("Track Number Of Nearby Enemies")]
		TrackNumberOfNearbyEnemies = 6244,

		[Description("Volatile Flameblood Spawn Monster On Death Variation")]
		VolatileFlamebloodSpawnMonsterOnDeathVariation = 6245,

		[Description("Hit And Poison Damage +%")]
		HitAndPoisonDamagePosPct = 6246,

		[Description("Hit And Poison Damage +% Per Poison On Enemy")]
		HitAndPoisonDamagePosPctPerPoisonOnEnemy = 6247,

		[Description("Attack Minimum Added Physical Damage With Weapons")]
		AttackMinimumAddedPhysicalDamageWithWeapons = 6248,

		[Description("Attack Maximum Added Physical Damage With Weapons")]
		AttackMaximumAddedPhysicalDamageWithWeapons = 6249,

		[Description("Trigger On Projectile Loop Count")]
		TriggerOnProjectileLoopCount = 6250,

		[Description("Trigger On Projectile Death")]
		TriggerOnProjectileDeath = 6251,

		[Description("Base Number Of Beast Minions Allowed")]
		BaseNumberOfBeastMinionsAllowed = 6252,

		[Description("Number Of Beast Minions Allowed")]
		NumberOfBeastMinionsAllowed = 6253,

		[Description("Local Display Grants Summon Beast Companion")]
		LocalDisplayGrantsSummonBeastCompanion = 6254,

		[Description("Molten Shell Explosion Cooldown Ms")]
		MoltenShellExplosionCooldownMs = 6255,

		[Description("From Code Active Skill Hit And Ailment Damage +% Final")]
		FromCodeActiveSkillHitAndAilmentDamagePosPctFinal = 6256,

		[Description("Tornado Movement Velocity +%")]
		TornadoMovementVelocityPosPct = 6257,

		[Description("Monster Aggro Radius +%")]
		MonsterAggroRadiusPosPct = 6258,

		[Description("Ground Ice Art Variation")]
		GroundIceArtVariation = 6259,

		[Description("Additional Projectiles Fire Parallel X Dist")]
		AdditionalProjectilesFireParallelXDist = 6260,

		[Description("Additional Projectiles Fire Parallel Y Dist")]
		AdditionalProjectilesFireParallelYDist = 6261,

		[Description("From Code Active Skill Ailment Damage +% Final")]
		FromCodeActiveSkillAilmentDamagePosPctFinal = 6262,

		[Description("Flameblast Ailment Damage +% Final Per Stack")]
		FlameblastAilmentDamagePosPctFinalPerStack = 6263,
		[Description("Trigger Cascade A")] TriggerCascadeA = 6264,
		[Description("Trigger Cascade B")] TriggerCascadeB = 6265,
		[Description("Trigger Cascade C")] TriggerCascadeC = 6266,
		[Description("Trigger Cascade D")] TriggerCascadeD = 6267,
		[Description("Trigger Cascade Angle")] TriggerCascadeAngle = 6268,

		[Description("Local Use Skill On Hit %")]
		LocalUseSkillOnHitPct = 6269,

		[Description("Main Hand Use Skill On Hit %")]
		MainHandUseSkillOnHitPct = 6270,

		[Description("Off Hand Use Skill On Hit %")]
		OffHandUseSkillOnHitPct = 6271,

		[Description("Skill Has Trigger From Unique Item")]
		SkillHasTriggerFromUniqueItem = 6272,

		[Description("Local Display Use Level X Abyssal Cry On Hit")]
		LocalDisplayUseLevelXAbyssalCryOnHit = 6273,
		[Description("Accelerate Min")] AccelerateMin = 6274,
		[Description("Accelerate Max")] AccelerateMax = 6275,
		[Description("Accelerate Time")] AccelerateTime = 6276,
		[Description("Skill Is Minion Skill")] SkillIsMinionSkill = 6277,

		[Description("Minion Skill Mana Cost +%")]
		MinionSkillManaCostPosPct = 6278,

		[Description("Local Display Grants Skill Doryanis Touch Level")]
		LocalDisplayGrantsSkillDoryanisTouchLevel = 6279,

		[Description("Trigger Cascade Target Variation")]
		TriggerCascadeTargetVariation = 6280,

		[Description("Trigger Cascade Number Of Arms")]
		TriggerCascadeNumberOfArms = 6281,

		[Description("Trigger Cascade Angle Between Arms")]
		TriggerCascadeAngleBetweenArms = 6282,

		[Description("Support Ruthless Big Hit Max Count")]
		SupportRuthlessBigHitMaxCount = 6283,

		[Description("Melee Damage +% Final From Ruthless Blow")]
		MeleeDamagePosPctFinalFromRuthlessBlow = 6284,

		[Description("Stun Base Duration Override Ms")]
		StunBaseDurationOverrideMs = 6285,

		[Description("Support Ruthless Big Hit Stun Base Duration Override Ms")]
		SupportRuthlessBigHitStunBaseDurationOverrideMs = 6286,

		[Description("Support Ruthless Big Hit Damage +% Final")]
		SupportRuthlessBigHitDamagePosPctFinal = 6287,

		[Description("Support Scion Onslaught On Killing Blow % Chance")]
		SupportScionOnslaughtOnKillingBlowPctChance = 6288,

		[Description("Support Scion Onslaught On Killing Blow Duration Ms")]
		SupportScionOnslaughtOnKillingBlowDurationMs = 6289,

		[Description("Support Arcane Surge Gain Buff On Mana Use Threshold")]
		SupportArcaneSurgeGainBuffOnManaUseThreshold = 6290,

		[Description("Support Arcane Surge Spell Damage +% Final")]
		SupportArcaneSurgeSpellDamagePosPctFinal = 6291,

		[Description("Spell Damage +% Final From Arcane Surge")]
		SpellDamagePosPctFinalFromArcaneSurge = 6292,

		[Description("Support Arcane Surge Duration Ms")]
		SupportArcaneSurgeDurationMs = 6293,

		[Description("Support Arcane Surge Base Duration Ms")]
		SupportArcaneSurgeBaseDurationMs = 6294,

		[Description("Support Arcane Surge Cast Speed +%")]
		SupportArcaneSurgeCastSpeedPosPct = 6295,

		[Description("Support Arcane Surge Mana Regeneration Rate Per Minute %")]
		SupportArcaneSurgeManaRegenerationRatePerMinutePct = 6296,

		[Description("Hidden Monster Can Have Auras")]
		HiddenMonsterCanHaveAuras = 6297,

		[Description("Projectile Number Of Targets To Pierce")]
		ProjectileNumberOfTargetsToPierce = 6298,

		[Description("Arrow Number Of Targets To Pierce")]
		ArrowNumberOfTargetsToPierce = 6299,

		[Description("Projectile Base Number Of Targets To Pierce")]
		ProjectileBaseNumberOfTargetsToPierce = 6300,

		[Description("Arrow Base Number Of Targets To Pierce")]
		ArrowBaseNumberOfTargetsToPierce = 6301,
		[Description("Arrows Always Pierce")] ArrowsAlwaysPierce = 6302,

		[Description("Base Arrows Always Pierce")]
		BaseArrowsAlwaysPierce = 6303,
		[Description("Virtual Always Pierce")] VirtualAlwaysPierce = 6304,

		[Description("Support Ignite Prolif Ignite Damage +% Final")]
		SupportIgniteProlifIgniteDamagePosPctFinal = 6305,

		[Description("Combined Ailment All Damage Over Time +% Final")]
		CombinedAilmentAllDamageOverTimePosPctFinal = 6306,

		[Description("Projectiles Always Pierce You")]
		ProjectilesAlwaysPierceYou = 6307,

		[Description("Arrow Damage +% Vs Pierced Targets")]
		ArrowDamagePosPctVsPiercedTargets = 6308,

		[Description("Projectiles Pierce X Additional Targets While You Have Phasing")]
		ProjectilesPierceXAdditionalTargetsWhileYouHavePhasing = 6309,

		[Description("Quiver Projectiles Pierce 1 Additional Target")]
		QuiverProjectilesPierce1AdditionalTarget = 6310,

		[Description("Quiver Projectiles Pierce 2 Additional Targets")]
		QuiverProjectilesPierce2AdditionalTargets = 6311,

		[Description("Quiver Projectiles Pierce 3 Additional Targets")]
		QuiverProjectilesPierce3AdditionalTargets = 6312,

		[Description("Projectiles Pierce All Nearby Targets")]
		ProjectilesPierceAllNearbyTargets = 6313,

		[Description("Projectiles Pierce 1 Additional Target Per 10 Stat Value")]
		ProjectilesPierce1AdditionalTargetPer10StatValue = 6314,

		[Description("Projectiles Pierce 1 Additional Target Per 15 Stat Value")]
		ProjectilesPierce1AdditionalTargetPer15StatValue = 6315,

		[Description("Talisman Implicit Projectiles Pierce 1 Additional Target Per 10")]
		TalismanImplicitProjectilesPierce1AdditionalTargetPer10 = 6316,

		[Description("Blade Vortex Ailment Damage +% Per Blade Final")]
		BladeVortexAilmentDamagePosPctPerBladeFinal = 6317,
		[Description("Bladefall Width +%")] BladefallWidthPosPct = 6318,

		[Description("Lightning Strike Additional Pierce Per 10 Old")]
		LightningStrikeAdditionalPiercePer10Old = 6319,

		[Description("Lightning Strike Additional Pierce")]
		LightningStrikeAdditionalPierce = 6320,

		[Description("Lightning Trap Additional Pierce Per 10 Old")]
		LightningTrapAdditionalPiercePer10Old = 6321,

		[Description("Lightning Trap Additional Pierce")]
		LightningTrapAdditionalPierce = 6322,

		[Description("Support Poison Poison Damage +% Final")]
		SupportPoisonPoisonDamagePosPctFinal = 6323,

		[Description("Attacks Chance To Poison % On Max Frenzy Charges")]
		AttacksChanceToPoisonPctOnMaxFrenzyCharges = 6324,

		[Description("Chance To Poison % Vs Cursed Enemies")]
		ChanceToPoisonPctVsCursedEnemies = 6325,

		[Description("Chaos Damage Chance To Poison %")]
		ChaosDamageChanceToPoisonPct = 6326,

		[Description("Virtual Chance To Poison On Hit With Attacks %")]
		VirtualChanceToPoisonOnHitWithAttacksPct = 6327,

		[Description("Support Innervate Minimum Added Lightning Damage")]
		SupportInnervateMinimumAddedLightningDamage = 6328,

		[Description("Support Innervate Maximum Added Lightning Damage")]
		SupportInnervateMaximumAddedLightningDamage = 6329,

		[Description("Support Innervate Buff Duration Ms")]
		SupportInnervateBuffDurationMs = 6330,

		[Description("Support Innervate Buff Base Duration Ms")]
		SupportInnervateBuffBaseDurationMs = 6331,

		[Description("Local Unique Jewel Spark Projectiles Nova With 40 Int In Radius")]
		LocalUniqueJewelSparkProjectilesNovaWith40IntInRadius = 6332,

		[Description("Spark Projectiles Nova")]
		SparkProjectilesNova = 6333,

		[Description("Local Unique Jewel Spark Number Of Additional Projectiles With 40 Int In Radius")]
		LocalUniqueJewelSparkNumberOfAdditionalProjectilesWith40IntInRadius = 6334,

		[Description("Spark Number Of Additional Projectiles")]
		SparkNumberOfAdditionalProjectiles = 6335,

		[Description("Local Unique Jewel Blight Hinder Enemy Chaos Damage Taken +% With 40 Int In Radius")]
		LocalUniqueJewelBlightHinderEnemyChaosDamageTakenPosPctWith40IntInRadius = 6336,

		[Description("Blight Hinder Enemy Chaos Damage Taken +%")]
		BlightHinderEnemyChaosDamageTakenPosPct = 6337,

		[Description("Local Unique Jewel Blight Hinder Duration +% With 40 Int In Radius")]
		LocalUniqueJewelBlightHinderDurationPosPctWith40IntInRadius = 6338,

		[Description("Local Unique Jewel Split Arrow Projectiles Fire In Parallel X Dist With 40 Dex In Radius")]
		LocalUniqueJewelSplitArrowProjectilesFireInParallelXDistWith40DexInRadius = 6339,

		[Description("Split Arrow Projectiles Fire In Parallel X Dist")]
		SplitArrowProjectilesFireInParallelXDist = 6340,

		[Description("Local Unique Jewel Split Arrow Projectiles Fire In Parallel Y Dist With 40 Dex In Radius")]
		LocalUniqueJewelSplitArrowProjectilesFireInParallelYDistWith40DexInRadius = 6341,

		[Description("Split Arrow Projectiles Fire In Parallel Y Dist")]
		SplitArrowProjectilesFireInParallelYDist = 6342,

		[Description("Local Unique Jewel Fire Trap Number Of Additional Traps To Throw With 40 Dex In Radius")]
		LocalUniqueJewelFireTrapNumberOfAdditionalTrapsToThrowWith40DexInRadius = 6343,

		[Description("Fire Trap Number Of Additional Traps To Throw")]
		FireTrapNumberOfAdditionalTrapsToThrow = 6344,

		[Description("Piercing Projectiles Critical Strike Chance +%")]
		PiercingProjectilesCriticalStrikeChancePosPct = 6345,

		[Description("Arrow Damage +50% Vs Pierced Targets")]
		ArrowDamagePos50PctVsPiercedTargets = 6346,

		[Description("Arrows Pierce Additional Target")]
		ArrowsPierceAdditionalTarget = 6347,

		[Description("Ice Shot Additional Pierce Per 10 Old")]
		IceShotAdditionalPiercePer10Old = 6348,

		[Description("Local Unique Jewel Ice Shot Additional Pierce Per 10 Old With 40 Dex In Radius")]
		LocalUniqueJewelIceShotAdditionalPiercePer10OldWith40DexInRadius = 6349,

		[Description("Virtual Cooldown Modifier Ms")]
		VirtualCooldownModifierMs = 6350,

		[Description("Base Cooldown Modifier Ms")]
		BaseCooldownModifierMs = 6351,

		[Description("Summon Skeletons Cooldown Modifier Ms")]
		SummonSkeletonsCooldownModifierMs = 6352,

		[Description("Trigger Cascade Use Contact Points")]
		TriggerCascadeUseContactPoints = 6353,

		[Description("Arrows Pierce 1 Additional Target Per 10 Stat Value")]
		ArrowsPierce1AdditionalTargetPer10StatValue = 6354,

		[Description("Summon Skeletons Additional Warrior Skeleton % Chance")]
		SummonSkeletonsAdditionalWarriorSkeletonPctChance = 6355,
		[Description("Map Spawn Harbingers")] MapSpawnHarbingers = 6356,

		[Description("Map Num Extra Harbingers")]
		MapNumExtraHarbingers = 6357,
		[Description("Map Packs Are Lunaris")] MapPacksAreLunaris = 6358,
		[Description("Map Packs Are Solaris")] MapPacksAreSolaris = 6359,
		[Description("Map Packs Are Ghosts")] MapPacksAreGhosts = 6360,

		[Description("Skeletal Chains No Minions Radius +")]
		SkeletalChainsNoMinionsRadiusPos = 6361,

		[Description("Skeletal Chains No Minions Targets Self")]
		SkeletalChainsNoMinionsTargetsSelf = 6362,
		[Description("Ice Shot Pierce +")] IceShotPiercePos = 6363,

		[Description("Local Unique Jewel Ice Shot Pierce + With 40 Dex In Radius")]
		LocalUniqueJewelIceShotPiercePosWith40DexInRadius = 6364,

		[Description("Non Damaging Ailment Effect +%")]
		NonDamagingAilmentEffectPosPct = 6365,

		[Description("Bleeding Stacks Up To X Times")]
		BleedingStacksUpToXTimes = 6366,

		[Description("Energy Shield Recharge Start When Stunned")]
		EnergyShieldRechargeStartWhenStunned = 6367,

		[Description("No Extra Bleed Damage While Target Is Moving")]
		NoExtraBleedDamageWhileTargetIsMoving = 6368,

		[Description("Track Which Enemies Hit Index")]
		TrackWhichEnemiesHitIndex = 6369,

		[Description("Track Skill Used Index")]
		TrackSkillUsedIndex = 6370,

		[Description("Skill Behaviour Variation")]
		SkillBehaviourVariation = 6371,

		[Description("Trigger Skill Restriction")]
		TriggerSkillRestriction = 6372,

		[Description("Prophecy Monster Spawn Level")]
		ProphecyMonsterSpawnLevel = 6373,

		[Description("Number Of Skeletons Allowed Per 2 Old")]
		NumberOfSkeletonsAllowedPer2Old = 6374,

		[Description("Cast On Trigger Cascade Event")]
		CastOnTriggerCascadeEvent = 6375,

		[Description("Spark Skill Effect Duration +%")]
		SparkSkillEffectDurationPosPct = 6376,

		[Description("Support Innervate Gain Buff On Killing Shocked Enemy")]
		SupportInnervateGainBuffOnKillingShockedEnemy = 6377,

		[Description("Additional Critical Strike Chance Permyriad While At Maximum Power Charges")]
		AdditionalCriticalStrikeChancePermyriadWhileAtMaximumPowerCharges = 6378,

		[Description("Object Inherent Spell Damage +% Final Per Power Charge")]
		ObjectInherentSpellDamagePosPctFinalPerPowerCharge = 6379,

		[Description("Damage Over Time +% Per Frenzy Charge")]
		DamageOverTimePosPctPerFrenzyCharge = 6380,

		[Description("Damage Over Time +% Per Power Charge")]
		DamageOverTimePosPctPerPowerCharge = 6381,

		[Description("Gain Frenzy And Power Charge On Kill %")]
		GainFrenzyAndPowerChargeOnKillPct = 6382,

		[Description("Maximum Power And Frenzy Charges +")]
		MaximumPowerAndFrenzyChargesPos = 6383,

		[Description("Labyrinth Darkshrine Players Damage Taken From Labyrinth Traps +%")]
		LabyrinthDarkshrinePlayersDamageTakenFromLabyrinthTrapsPosPct = 6384,

		[Description("Labyrinth Darkshrine Boss Room Traps Are Disabled")]
		LabyrinthDarkshrineBossRoomTrapsAreDisabled = 6385,

		[Description("Labyrinth Darkshrine Players Have Shrine Row X Effect For This Labyrinth")]
		LabyrinthDarkshrinePlayersHaveShrineRowXEffectForThisLabyrinth = 6386,

		[Description("Labyrinth Darkshrine Divine Font Grants One Additional Enchantment Use To Player X")]
		LabyrinthDarkshrineDivineFontGrantsOneAdditionalEnchantmentUseToPlayerX = 6387,

		[Description("Labyrinth Darkshrine Izaro Drops X Additional Treasure Keys")]
		LabyrinthDarkshrineIzaroDropsXAdditionalTreasureKeys = 6388,

		[Description("Damage Taken From Labyrinth Traps +%")]
		DamageTakenFromLabyrinthTrapsPosPct = 6389,

		[Description("Labyrinth Darkshrine Izaro Dropped Unique Items +")]
		LabyrinthDarkshrineIzaroDroppedUniqueItemsPos = 6390,

		[Description("Convocation Max Number Of Minions To Teleport")]
		ConvocationMaxNumberOfMinionsToTeleport = 6391,

		[Description("Local Chance To Bleed On Hit 25%")]
		LocalChanceToBleedOnHit25Pct = 6392,

		[Description("Main Hand Local Chance To Bleed On Hit 25%")]
		MainHandLocalChanceToBleedOnHit25Pct = 6393,

		[Description("Off Hand Local Chance To Bleed On Hit 25%")]
		OffHandLocalChanceToBleedOnHit25Pct = 6394,

		[Description("Recover % Maximum Mana On Kill")]
		RecoverPctMaximumManaOnKill = 6395,

		[Description("Arctic Armour Chill When Hit Duration")]
		ArcticArmourChillWhenHitDuration = 6396,
		[Description("Debuff Time Passed +%")] DebuffTimePassedPosPct = 6397,
		[Description("Skill Is Channelled")] SkillIsChannelled = 6398,

		[Description("Channelled Skill Damage +%")]
		ChannelledSkillDamagePosPct = 6399,

		[Description("Local Display Socketed Gems Supported By X Innervate Level")]
		LocalDisplaySocketedGemsSupportedByXInnervateLevel = 6400,

		[Description("Local Display Summon Harbinger X On Equip")]
		LocalDisplaySummonHarbingerXOnEquip = 6401,

		[Description("Skeleton Movement Speed +%")]
		SkeletonMovementSpeedPosPct = 6402,

		[Description("Skeleton Attack Speed +%")]
		SkeletonAttackSpeedPosPct = 6403,

		[Description("Skeleton Cast Speed +%")]
		SkeletonCastSpeedPosPct = 6404,

		[Description("Physical Damage Over Time Taken +%")]
		PhysicalDamageOverTimeTakenPosPct = 6405,

		[Description("Summon Skeletons Additional Warrior Skeleton One Twentieth Chance")]
		SummonSkeletonsAdditionalWarriorSkeletonOneTwentiethChance = 6406,

		[Description("Leapslam Overshoot Distance")]
		LeapslamOvershootDistance = 6407,

		[Description("Skill Is Projectile Skill")]
		SkillIsProjectileSkill = 6408,

		[Description("Projectile Attack Skill Critical Strike Chance +%")]
		ProjectileAttackSkillCriticalStrikeChancePosPct = 6409,

		[Description("Storm Burst Avoid Interruption While Casting %")]
		StormBurstAvoidInterruptionWhileCastingPct = 6410,

		[Description("Storm Burst Area Of Effect +%")]
		StormBurstAreaOfEffectPosPct = 6411,

		[Description("Skeletal Chains Cast Speed +%")]
		SkeletalChainsCastSpeedPosPct = 6412,

		[Description("Skeletal Chains Area Of Effect +%")]
		SkeletalChainsAreaOfEffectPosPct = 6413,

		[Description("Unique Volkuurs Clutch Poison Duration +% Final")]
		UniqueVolkuursClutchPoisonDurationPosPctFinal = 6414,

		[Description("Combined Poison Duration +% Final")]
		CombinedPoisonDurationPosPctFinal = 6415,

		[Description("Local Display Trigger Level X Darktongue Kiss On Curse")]
		LocalDisplayTriggerLevelXDarktongueKissOnCurse = 6416,

		[Description("Cast When Cast Curse %")]
		CastWhenCastCursePct = 6417,

		[Description("Move Daemon Number Of Daemons To Spawn")]
		MoveDaemonNumberOfDaemonsToSpawn = 6418,

		[Description("Move Daemon Movement Speed")]
		MoveDaemonMovementSpeed = 6419,

		[Description("Move Daemon Distance To Travel")]
		MoveDaemonDistanceToTravel = 6420,

		[Description("Move Daemon Delay Between Daemons Ms")]
		MoveDaemonDelayBetweenDaemonsMs = 6421,
		[Description("Move Daemon Rotation")] MoveDaemonRotation = 6422,

		[Description("Move Daemon Rotation Per Daemon")]
		MoveDaemonRotationPerDaemon = 6423,

		[Description("Move Daemon End Rotation")]
		MoveDaemonEndRotation = 6424,

		[Description("Move Daemon End Rotation Per Daemon")]
		MoveDaemonEndRotationPerDaemon = 6425,
		[Description("Move Daemon X Offset")] MoveDaemonXOffset = 6426,
		[Description("Move Daemon Y Offset")] MoveDaemonYOffset = 6427,

		[Description("Move Daemon X Offset Per Daemon")]
		MoveDaemonXOffsetPerDaemon = 6428,

		[Description("Move Daemon Y Offset Per Daemon")]
		MoveDaemonYOffsetPerDaemon = 6429,

		[Description("Move Daemon Pivot Variation")]
		MoveDaemonPivotVariation = 6430,

		[Description("Harbinger Minion Damage Taken +% Final Min")]
		HarbingerMinionDamageTakenPosPctFinalMin = 6431,

		[Description("Harbinger Minion Damage Taken +% Final Max")]
		HarbingerMinionDamageTakenPosPctFinalMax = 6432,

		[Description("Harbinger Minion Damage Taken +% Final Time")]
		HarbingerMinionDamageTakenPosPctFinalTime = 6433,

		[Description("Harbinger Minion Rare Chance %")]
		HarbingerMinionRareChancePct = 6434,

		[Description("Harbinger Minion Magic Chance %")]
		HarbingerMinionMagicChancePct = 6435,

		[Description("Harbinger Minion Remove Parent Life On Death Permyriad")]
		HarbingerMinionRemoveParentLifeOnDeathPermyriad = 6436,

		[Description("Critical Strike Chance Increased By Lightning Resistance")]
		CriticalStrikeChanceIncreasedByLightningResistance = 6437,

		[Description("Piercing Projectiles Critical Strike Chance +100%")]
		PiercingProjectilesCriticalStrikeChancePos100Pct = 6438,
		[Description("Cast On Skill Use %")] CastOnSkillUsePct = 6439,

		[Description("Local Display Trigger Level X Void Gaze On Skill Use")]
		LocalDisplayTriggerLevelXVoidGazeOnSkillUse = 6440,

		[Description("Cannot Be Stunned If You Have Blocked A Stun Recently")]
		CannotBeStunnedIfYouHaveBlockedAStunRecently = 6441,

		[Description("Track Have Blocked A Stun Recently")]
		TrackHaveBlockedAStunRecently = 6442,

		[Description("Have Blocked A Stun Recently")]
		HaveBlockedAStunRecently = 6443,

		[Description("Local Display Trigger Level X Storm Cascade On Attack")]
		LocalDisplayTriggerLevelXStormCascadeOnAttack = 6444,

		[Description("Empty Action State Value")]
		EmptyActionStateValue = 6445,

		[Description("Minimum Added Chaos Damage Vs Enemies With 5+ Poisons")]
		MinimumAddedChaosDamageVsEnemiesWith5PosPoisons = 6446,

		[Description("Maximum Added Chaos Damage Vs Enemies With 5+ Poisons")]
		MaximumAddedChaosDamageVsEnemiesWith5PosPoisons = 6447,

		[Description("Main Hand Minimum Added Chaos Damage Vs Enemies With 5+ Poisons")]
		MainHandMinimumAddedChaosDamageVsEnemiesWith5PosPoisons = 6448,

		[Description("Main Hand Maximum Added Chaos Damage Vs Enemies With 5+ Poisons")]
		MainHandMaximumAddedChaosDamageVsEnemiesWith5PosPoisons = 6449,

		[Description("Off Hand Minimum Added Chaos Damage Vs Enemies With 5+ Poisons")]
		OffHandMinimumAddedChaosDamageVsEnemiesWith5PosPoisons = 6450,

		[Description("Off Hand Maximum Added Chaos Damage Vs Enemies With 5+ Poisons")]
		OffHandMaximumAddedChaosDamageVsEnemiesWith5PosPoisons = 6451,

		[Description("Life Leech From Attack Damage Permyriad Vs Poisoned Enemies")]
		LifeLeechFromAttackDamagePermyriadVsPoisonedEnemies = 6452,

		[Description("Poison Duration +% Per Power Charge")]
		PoisonDurationPosPctPerPowerCharge = 6453,

		[Description("Poison Damage +% Per Frenzy Charge")]
		PoisonDamagePosPctPerFrenzyCharge = 6454,

		[Description("Gain Frenzy Charge On Kill Vs Enemies With 5+ Poisons %")]
		GainFrenzyChargeOnKillVsEnemiesWith5PosPoisonsPct = 6455,

		[Description("Gain Power Charge On Kill Vs Enemies With Less Than 5 Poisons %")]
		GainPowerChargeOnKillVsEnemiesWithLessThan5PoisonsPct = 6456,

		[Description("Local Display Socketed Gems Supported By X Lesser Poison")]
		LocalDisplaySocketedGemsSupportedByXLesserPoison = 6457,

		[Description("Poison Duration +% With Over 150 Intelligence")]
		PoisonDurationPosPctWithOver150Intelligence = 6458,

		[Description("Poison Damage +% With Over 300 Dexterity")]
		PoisonDamagePosPctWithOver300Dexterity = 6459,

		[Description("Local Display Socketed Gems Supported By X Vile Toxins")]
		LocalDisplaySocketedGemsSupportedByXVileToxins = 6460,

		[Description("Local Display Grants Skill Blight Level")]
		LocalDisplayGrantsSkillBlightLevel = 6461,

		[Description("You Cannot Be Hindered")]
		YouCannotBeHindered = 6462,

		[Description("Support Melee Physical Damage Poison And Bleeding Damage +% Final From Melee Hits")]
		SupportMeleePhysicalDamagePoisonAndBleedingDamagePosPctFinalFromMeleeHits = 6463,

		[Description("Support Phys Proj Attack Damage Bleeing And Poison Damage +% Final From Projectile Hits")]
		SupportPhysProjAttackDamageBleeingAndPoisonDamagePosPctFinalFromProjectileHits = 6464,

		[Description("Support Ruthless Blow Bleeding Damage From Melee Hits +% Final")]
		SupportRuthlessBlowBleedingDamageFromMeleeHitsPosPctFinal = 6465,

		[Description("Melee Hit Bleeding Damage +% Final From Ruthless Blow")]
		MeleeHitBleedingDamagePosPctFinalFromRuthlessBlow = 6466,

		[Description("Support Chance To Bleed Bleeding Damage +% Final")]
		SupportChanceToBleedBleedingDamagePosPctFinal = 6467,

		[Description("Charged Dash Chance To Dodge % If Finished Channelling Recently")]
		ChargedDashChanceToDodgePctIfFinishedChannellingRecently = 6468,

		[Description("Charged Dash Area Of Effect Radius + Of Final Explosion")]
		ChargedDashAreaOfEffectRadiusPosOfFinalExplosion = 6469,

		[Description("Additional Physical Damage Reduction % If Not Player")]
		AdditionalPhysicalDamageReductionPctIfNotPlayer = 6470,

		[Description("Resist All Elements % If Not Player")]
		ResistAllElementsPctIfNotPlayer = 6471,

		[Description("Physical Damage % To Gain As Chaos While At Maximum Power Charges")]
		PhysicalDamagePctToGainAsChaosWhileAtMaximumPowerCharges = 6472,

		[Description("Attack Ailment Damage +% While Wielding Dagger")]
		AttackAilmentDamagePosPctWhileWieldingDagger = 6473,

		[Description("Attack Ailment Damage +% While Wielding Claw")]
		AttackAilmentDamagePosPctWhileWieldingClaw = 6474,

		[Description("Attack Ailment Damage +% While Wielding Sword")]
		AttackAilmentDamagePosPctWhileWieldingSword = 6475,

		[Description("Attack Ailment Damage +% While Wielding Bow")]
		AttackAilmentDamagePosPctWhileWieldingBow = 6476,

		[Description("Attack Ailment Damage +% While Wielding Axe")]
		AttackAilmentDamagePosPctWhileWieldingAxe = 6477,

		[Description("Attack Ailment Damage +% While Wielding Mace")]
		AttackAilmentDamagePosPctWhileWieldingMace = 6478,

		[Description("Attack Ailment Damage +% While Wielding One Handed Weapon")]
		AttackAilmentDamagePosPctWhileWieldingOneHandedWeapon = 6479,

		[Description("Attack Ailment Damage +% While Wielding Two Handed Weapon")]
		AttackAilmentDamagePosPctWhileWieldingTwoHandedWeapon = 6480,

		[Description("Attack Ailment Damage +% While Dual Wielding")]
		AttackAilmentDamagePosPctWhileDualWielding = 6481,

		[Description("Attack Ailment Damage +% While Holding Shield")]
		AttackAilmentDamagePosPctWhileHoldingShield = 6482,

		[Description("Attack Ailment Damage +% While Wielding Melee Weapon")]
		AttackAilmentDamagePosPctWhileWieldingMeleeWeapon = 6483,

		[Description("Combined Ailment Damage +% From Weapon Types")]
		CombinedAilmentDamagePosPctFromWeaponTypes = 6484,

		[Description("Immune To Status Ailments")]
		ImmuneToStatusAilments = 6485,

		[Description("Chance To Hit While Blinded +% Final")]
		ChanceToHitWhileBlindedPosPctFinal = 6486,

		[Description("Chance To Hit +% Final")]
		ChanceToHitPosPctFinal = 6487,

		[Description("Is Summoned Harbinger Monster")]
		IsSummonedHarbingerMonster = 6488,

		[Description("Ignored By Enemy Target Selection")]
		IgnoredByEnemyTargetSelection = 6489,

		[Description("Base Ignored By Enemy Target Selection")]
		BaseIgnoredByEnemyTargetSelection = 6490,

		[Description("Map Packs Have Belly Totems")]
		MapPacksHaveBellyTotems = 6491,

		[Description("Harbinger Minion Max Magic Count")]
		HarbingerMinionMaxMagicCount = 6492,

		[Description("Harbinger Minion Max Rare Count")]
		HarbingerMinionMaxRareCount = 6493,

		[Description("Cannot Be Stunned If Have Been Stunned Or Blocked Stunning Hit In Past 2 Seconds")]
		CannotBeStunnedIfHaveBeenStunnedOrBlockedStunningHitInPast2Seconds = 6494,

		[Description("Glacial Cascade Number Of Additional Bursts")]
		GlacialCascadeNumberOfAdditionalBursts = 6495,

		[Description("Local Unique Jewel Glacial Cascade Number Of Additional Bursts With 40 Int In Radius")]
		LocalUniqueJewelGlacialCascadeNumberOfAdditionalBurstsWith40IntInRadius = 6496,

		[Description("Number Of Active Beast Minions")]
		NumberOfActiveBeastMinions = 6497,

		[Description("Projectile Attacks Chance To Bleed On Hit % If You Have Beast Minion")]
		ProjectileAttacksChanceToBleedOnHitPctIfYouHaveBeastMinion = 6498,

		[Description("Attack Minimum Added Physical Damage If You Have Beast Minion")]
		AttackMinimumAddedPhysicalDamageIfYouHaveBeastMinion = 6499,

		[Description("Attack Maximum Added Physical Damage If You Have Beast Minion")]
		AttackMaximumAddedPhysicalDamageIfYouHaveBeastMinion = 6500,

		[Description("Projectile Attacks Chance To Maim On Hit % If You Have Beast Minion")]
		ProjectileAttacksChanceToMaimOnHitPctIfYouHaveBeastMinion = 6501,

		[Description("Attack And Movement Speed +% If You Have Beast Minion")]
		AttackAndMovementSpeedPosPctIfYouHaveBeastMinion = 6502,

		[Description("Projectile Attacks Chance To Poison On Hit % If You Have Beast Minion")]
		ProjectileAttacksChanceToPoisonOnHitPctIfYouHaveBeastMinion = 6503,

		[Description("Attack Minimum Added Chaos Damage If You Have Beast Minion")]
		AttackMinimumAddedChaosDamageIfYouHaveBeastMinion = 6504,

		[Description("Attack Maximum Added Chaos Damage If You Have Beast Minion")]
		AttackMaximumAddedChaosDamageIfYouHaveBeastMinion = 6505,

		[Description("Local Bleed On Critical Strike Chance %")]
		LocalBleedOnCriticalStrikeChancePct = 6506,

		[Description("Main Hand Local Bleed On Critical Strike Chance %")]
		MainHandLocalBleedOnCriticalStrikeChancePct = 6507,

		[Description("Off Hand Local Bleed On Critical Strike Chance %")]
		OffHandLocalBleedOnCriticalStrikeChancePct = 6508,

		[Description("Local Poison On Critical Strike Chance %")]
		LocalPoisonOnCriticalStrikeChancePct = 6509,

		[Description("Main Hand Local Poison On Critical Strike Chance %")]
		MainHandLocalPoisonOnCriticalStrikeChancePct = 6510,

		[Description("Off Hand Local Poison On Critical Strike Chance %")]
		OffHandLocalPoisonOnCriticalStrikeChancePct = 6511,

		[Description("Virtual Main Hand Chance To Bleed On Critical Strike %")]
		VirtualMainHandChanceToBleedOnCriticalStrikePct = 6512,

		[Description("Virtual Off Hand Chance To Bleed On Critical Strike %")]
		VirtualOffHandChanceToBleedOnCriticalStrikePct = 6513,

		[Description("Local Chance To Bleed On Crit 50%")]
		LocalChanceToBleedOnCrit50Pct = 6514,

		[Description("Main Hand Local Chance To Bleed On Crit 50%")]
		MainHandLocalChanceToBleedOnCrit50Pct = 6515,

		[Description("Off Hand Local Chance To Bleed On Crit 50%")]
		OffHandLocalChanceToBleedOnCrit50Pct = 6516,
		[Description("Cast On Attack Use %")] CastOnAttackUsePct = 6517,
		[Description("Ignite Slower Burn %")] IgniteSlowerBurnPct = 6518,

		[Description("Virtual Ignite Duration +% Final")]
		VirtualIgniteDurationPosPctFinal = 6519,

		[Description("Object Inherent Damage +% Final Per Frenzy Charge")]
		ObjectInherentDamagePosPctFinalPerFrenzyCharge = 6520,
		[Description("Local Maim On Hit %")] LocalMaimOnHitPct = 6521,

		[Description("Main Hand Local Maim On Hit %")]
		MainHandLocalMaimOnHitPct = 6522,

		[Description("Off Hand Local Maim On Hit %")]
		OffHandLocalMaimOnHitPct = 6523,

		[Description("Life Leech From Attack Damage Permyriad Vs Maimed Enemies")]
		LifeLeechFromAttackDamagePermyriadVsMaimedEnemies = 6524,

		[Description("Local Display Grants Skill Death Aura Level")]
		LocalDisplayGrantsSkillDeathAuraLevel = 6525,

		[Description("Chilled Ground Base Magnitude Override")]
		ChilledGroundBaseMagnitudeOverride = 6526,

		[Description("Shocked Ground Base Magnitude Override")]
		ShockedGroundBaseMagnitudeOverride = 6527,

		[Description("Harbinger Base Currency Shard Stack Tenths To Drop")]
		HarbingerBaseCurrencyShardStackTenthsToDrop = 6528,

		[Description("Charged Dash Damage +%")]
		ChargedDashDamagePosPct = 6529,
		[Description("Storm Burst Damage +%")] StormBurstDamagePosPct = 6530,

		[Description("Skeletal Chains Damage +%")]
		SkeletalChainsDamagePosPct = 6531,

		[Description("Whirling Blades Base Ground Chaos Damage To Deal Per Minute")]
		WhirlingBladesBaseGroundChaosDamageToDealPerMinute = 6532,

		[Description("Chill And Freeze Duration +%")]
		ChillAndFreezeDurationPosPct = 6533,

		[Description("Local Chance To Bleed On Hit 50%")]
		LocalChanceToBleedOnHit50Pct = 6534,

		[Description("Main Hand Local Chance To Bleed On Hit 50%")]
		MainHandLocalChanceToBleedOnHit50Pct = 6535,

		[Description("Off Hand Local Chance To Bleed On Hit 50%")]
		OffHandLocalChanceToBleedOnHit50Pct = 6536,

		[Description("Arrows That Pierce Chance To Bleed 25%")]
		ArrowsThatPierceChanceToBleed25Pct = 6537,

		[Description("Attacks Chance To Bleed 25% Vs Cursed Enemies")]
		AttacksChanceToBleed25PctVsCursedEnemies = 6538,
		[Description("Damage Taken +% Final")] DamageTakenPosPctFinal = 6539,

		[Description("Display One Harbinger Allowed")]
		DisplayOneHarbingerAllowed = 6540,

		[Description("Action Speed +% Minimum Value")]
		ActionSpeedPosPctMinimumValue = 6541,

		[Description("Shavronne Ball Lightning Held Projectile Damage +% Final")]
		ShavronneBallLightningHeldProjectileDamagePosPctFinal = 6542,

		[Description("Grant Rampage Kill To Parent On Hitting Unique Enemy %")]
		GrantRampageKillToParentOnHittingUniqueEnemyPct = 6543,

		[Description("Minion Grants Rampage Kill To Parent On Hitting Unique Enemy %")]
		MinionGrantsRampageKillToParentOnHittingUniqueEnemyPct = 6544,

		[Description("Monster Inherent Experience Granted +% Final Because Deleted On Death")]
		MonsterInherentExperienceGrantedPosPctFinalBecauseDeletedOnDeath = 6545,

		[Description("Monster Inherent Experience Granted +% Final If Deleted On Death")]
		MonsterInherentExperienceGrantedPosPctFinalIfDeletedOnDeath = 6546,

		[Description("Harbinger Minion Extra Monster Chance %")]
		HarbingerMinionExtraMonsterChancePct = 6547,

		[Description("Harbinger Minion Max Extra Monsters Count")]
		HarbingerMinionMaxExtraMonstersCount = 6548,

		[Description("Harbinger Minion Damage Taken +% Final")]
		HarbingerMinionDamageTakenPosPctFinal = 6549,

		[Description("Skill Global Actor Definition Index Override")]
		SkillGlobalActorDefinitionIndexOverride = 6550,

		[Description("Virtual Total Main Hand Chance To Bleed On Hit %")]
		VirtualTotalMainHandChanceToBleedOnHitPct = 6551,

		[Description("Virtual Total Off Hand Chance To Bleed On Hit %")]
		VirtualTotalOffHandChanceToBleedOnHitPct = 6552,

		[Description("Virtual Total Main Hand Chance To Ignite On Hit %")]
		VirtualTotalMainHandChanceToIgniteOnHitPct = 6553,

		[Description("Virtual Total Off Hand Chance To Ignite On Hit %")]
		VirtualTotalOffHandChanceToIgniteOnHitPct = 6554,

		[Description("Virtual Total Spell Chance To Ignite On Hit %")]
		VirtualTotalSpellChanceToIgniteOnHitPct = 6555,

		[Description("Virtual Total Secondary Chance To Ignite On Hit %")]
		VirtualTotalSecondaryChanceToIgniteOnHitPct = 6556,

		[Description("Virtual Total Main Hand Chance To Poison On Hit %")]
		VirtualTotalMainHandChanceToPoisonOnHitPct = 6557,

		[Description("Virtual Total Off Hand Chance To Poison On Hit %")]
		VirtualTotalOffHandChanceToPoisonOnHitPct = 6558,

		[Description("Virtual Total Spell Chance To Poison On Hit %")]
		VirtualTotalSpellChanceToPoisonOnHitPct = 6559,

		[Description("Virtual Total Secondary Chance To Poison On Hit %")]
		VirtualTotalSecondaryChanceToPoisonOnHitPct = 6560,

		[Description("Total Number Of Map Mods")]
		TotalNumberOfMapMods = 6561,

		[Description("Harbinger Currency Shard Stack Size +%")]
		HarbingerCurrencyShardStackSizePosPct = 6562,

		[Description("Map Force Monster Pack Index")]
		MapForceMonsterPackIndex = 6563,

		[Description("Volatile Dead Base Number Of Corpses To Consume")]
		VolatileDeadBaseNumberOfCorpsesToConsume = 6564,

		[Description("Chance To Cast When Your Trap Is Triggered %")]
		ChanceToCastWhenYourTrapIsTriggeredPct = 6565,

		[Description("Local Display Gain Power Charge On Spending Mana")]
		LocalDisplayGainPowerChargeOnSpendingMana = 6566,
		[Description("Is Untethered Pet")] IsUntetheredPet = 6567,
		[Description("Walk Emerge Distance")] WalkEmergeDistance = 6568,

		[Description("Walk Emerge Extra Distance")]
		WalkEmergeExtraDistance = 6569,

		[Description("Walk Emerge Height Offset")]
		WalkEmergeHeightOffset = 6570,
		[Description("Walk Emerge Tilt")] WalkEmergeTilt = 6571,

		[Description("Combined Armour And Evasion Rating +%")]
		CombinedArmourAndEvasionRatingPosPct = 6572,

		[Description("Herald Of Ash Burning % Overkill Damage Per Minute")]
		HeraldOfAshBurningPctOverkillDamagePerMinute = 6573,

		[Description("Local Display Grants Skill Scorching Ray Level")]
		LocalDisplayGrantsSkillScorchingRayLevel = 6574,

		[Description("Support Minion Maximum Life +% Final")]
		SupportMinionMaximumLifePosPctFinal = 6575,

		[Description("Max Life +% Final For Minion From Support")]
		MaxLifePosPctFinalForMinionFromSupport = 6576,

		[Description("Lightning Tendrils Channelled Larger Pulse Radius +")]
		LightningTendrilsChannelledLargerPulseRadiusPos = 6577,

		[Description("Lightning Tendrils Channelled Larger Pulse Damage +% Final")]
		LightningTendrilsChannelledLargerPulseDamagePosPctFinal = 6578,

		[Description("Discorectangle Slam Damage With Endurance Charge +% Final")]
		DiscorectangleSlamDamageWithEnduranceChargePosPctFinal = 6579,

		[Description("Discorectangle Slam Radius With Endurance Charge +")]
		DiscorectangleSlamRadiusWithEnduranceChargePos = 6580,

		[Description("Unearth Base Corpse Level")]
		UnearthBaseCorpseLevel = 6581,

		[Description("Map Tencent Event Shards Drop Rate")]
		MapTencentEventShardsDropRate = 6582,
		[Description("Is In Caustic Cloud")] IsInCausticCloud = 6583,

		[Description("Chaos Damage Taken Over Time +% While In Caustic Cloud")]
		ChaosDamageTakenOverTimePosPctWhileInCausticCloud = 6584,

		[Description("Local Can Socket Gems Ignoring Colour")]
		LocalCanSocketGemsIgnoringColour = 6585,

		[Description("Local No Attribute Requirements")]
		LocalNoAttributeRequirements = 6586,

		[Description("Local Socketed Gems In Red Sockets Get Level +")]
		LocalSocketedGemsInRedSocketsGetLevelPos = 6587,

		[Description("Local Socketed Gems In Green Sockets Get Quality %")]
		LocalSocketedGemsInGreenSocketsGetQualityPct = 6588,

		[Description("Local Socketed Gems In Blue Sockets Experience Gained +%")]
		LocalSocketedGemsInBlueSocketsExperienceGainedPosPct = 6589,

		[Description("Local Socketed Gems In White Sockets Get Nothing")]
		LocalSocketedGemsInWhiteSocketsGetNothing = 6590,

		[Description("Corpse Erruption Base Maximum Number Of Geyers")]
		CorpseErruptionBaseMaximumNumberOfGeyers = 6591,

		[Description("Thaumaturgy Rotation Active")]
		ThaumaturgyRotationActive = 6592,

		[Description("Thaumaturgy Rotation Buff Exists")]
		ThaumaturgyRotationBuffExists = 6593,

		[Description("Trigger On Delayed Blast")]
		TriggerOnDelayedBlast = 6594,

		[Description("Trigger On Delayed Blast %")]
		TriggerOnDelayedBlastPct = 6595,

		[Description("Delayed Blast Has Trigger")]
		DelayedBlastHasTrigger = 6596,
		[Description("Spirit Charge Tier")] SpiritChargeTier = 6597,

		[Description("Current Spirit Charges")]
		CurrentSpiritCharges = 6598,

		[Description("Maximum Spirit Charges")]
		MaximumSpiritCharges = 6599,

		[Description("Recover % Of Maximum Life On Gaining A Spirit Charge")]
		RecoverPctOfMaximumLifeOnGainingASpiritCharge = 6600,

		[Description("Corpse Skill Has Triggers")]
		CorpseSkillHasTriggers = 6601,

		[Description("Cast On Corpse Consume")]
		CastOnCorpseConsume = 6602,

		[Description("Cast On Corpse Consume %")]
		CastOnCorpseConsumePct = 6603,

		[Description("Cast On Damage Taken Also Tracks Dot")]
		CastOnDamageTakenAlsoTracksDot = 6604,

		[Description("Thrown Shield Projectile Max Distance")]
		ThrownShieldProjectileMaxDistance = 6605,

		[Description("Thrown Shield Projectile Fire Random Directions")]
		ThrownShieldProjectileFireRandomDirections = 6606,

		[Description("Thrown Shield Secondary Projectile Damage +% Final")]
		ThrownShieldSecondaryProjectileDamagePosPctFinal = 6607,

		[Description("Cast On Corpse Consume Id")]
		CastOnCorpseConsumeId = 6608,

		[Description("Gain Random Charge Per Second While Stationary")]
		GainRandomChargePerSecondWhileStationary = 6609,

		[Description("Lose All Charges On Starting Movement")]
		LoseAllChargesOnStartingMovement = 6610,

		[Description("Mana Regeneration Rate Per Minute Per Power Charge")]
		ManaRegenerationRatePerMinutePerPowerCharge = 6611,

		[Description("Spectre Maximum Life +")]
		SpectreMaximumLifePos = 6612,

		[Description("Accuracy Rating While At Maximum Frenzy Charges")]
		AccuracyRatingWhileAtMaximumFrenzyCharges = 6613,

		[Description("Display Map Inhabited By Solaris Fanatics")]
		DisplayMapInhabitedBySolarisFanatics = 6614,

		[Description("Display Map Inhabited By Lunaris Fanatics")]
		DisplayMapInhabitedByLunarisFanatics = 6615,

		[Description("Map Elder Boss Variation")]
		MapElderBossVariation = 6616,

		[Description("Ignite Triggered Ground Fire Base Damage Per Minute")]
		IgniteTriggeredGroundFireBaseDamagePerMinute = 6617,

		[Description("Virtual Shock Effect +%")]
		VirtualShockEffectPosPct = 6618,

		[Description("Virtual Chill Effect +%")]
		VirtualChillEffectPosPct = 6619,

		[Description("Local Unique Jewel Non Keystone Passive In Radius Effect +%")]
		LocalUniqueJewelNonKeystonePassiveInRadiusEffectPosPct = 6620,

		[Description("Local Unique Jewel Notable Passive In Radius Does Nothing")]
		LocalUniqueJewelNotablePassiveInRadiusDoesNothing = 6621,

		[Description("Passive Skill Does Nothing")]
		PassiveSkillDoesNothing = 6622,

		[Description("Local Unique Hungry Loop Number Of Gems To Consume")]
		LocalUniqueHungryLoopNumberOfGemsToConsume = 6623,

		[Description("Local Unique Hungry Loop Has Consumed Gem")]
		LocalUniqueHungryLoopHasConsumedGem = 6624,

		[Description("Local Display Socketed Gems Supported By Level X Greater Multiple Projectiles")]
		LocalDisplaySocketedGemsSupportedByLevelXGreaterMultipleProjectiles = 6625,

		[Description("Local Display Socketed Gems Supported By Level X Increased Critical Strikes")]
		LocalDisplaySocketedGemsSupportedByLevelXIncreasedCriticalStrikes = 6626,

		[Description("Local Display Socketed Gems Supported By Level X Item Quantity")]
		LocalDisplaySocketedGemsSupportedByLevelXItemQuantity = 6627,

		[Description("Local Display Socketed Gems Supported By Level X Item Rarity")]
		LocalDisplaySocketedGemsSupportedByLevelXItemRarity = 6628,

		[Description("Local Display Socketed Gems Supported By Level X Increased Duration")]
		LocalDisplaySocketedGemsSupportedByLevelXIncreasedDuration = 6629,

		[Description("Local Display Socketed Gems Supported By Level X Chance To Ignite")]
		LocalDisplaySocketedGemsSupportedByLevelXChanceToIgnite = 6630,

		[Description("Local Display Socketed Gems Supported By Level X Bloodlust")]
		LocalDisplaySocketedGemsSupportedByLevelXBloodlust = 6631,

		[Description("Local Display Socketed Gems Supported By Level X Life Gain On Hit")]
		LocalDisplaySocketedGemsSupportedByLevelXLifeGainOnHit = 6632,

		[Description("Local Display Socketed Gems Supported By Level X Culling Strike")]
		LocalDisplaySocketedGemsSupportedByLevelXCullingStrike = 6633,

		[Description("Local Display Socketed Gems Supported By Level X Point Blank")]
		LocalDisplaySocketedGemsSupportedByLevelXPointBlank = 6634,

		[Description("Local Display Socketed Gems Supported By Level X Iron Grip")]
		LocalDisplaySocketedGemsSupportedByLevelXIronGrip = 6635,

		[Description("Local Display Socketed Gems Supported By Level X Melee Damage On Full Life")]
		LocalDisplaySocketedGemsSupportedByLevelXMeleeDamageOnFullLife = 6636,

		[Description("Local Display Socketed Gems Supported By Level X Ranged Attack Totem")]
		LocalDisplaySocketedGemsSupportedByLevelXRangedAttackTotem = 6637,

		[Description("Local Display Socketed Gems Supported By Level X Fire Penetration")]
		LocalDisplaySocketedGemsSupportedByLevelXFirePenetration = 6638,

		[Description("Local Display Socketed Gems Supported By Level X Lightning Penetration")]
		LocalDisplaySocketedGemsSupportedByLevelXLightningPenetration = 6639,

		[Description("Local Display Socketed Gems Supported By Level X Chain")]
		LocalDisplaySocketedGemsSupportedByLevelXChain = 6640,

		[Description("Local Display Socketed Gems Supported By Level X Multicast")]
		LocalDisplaySocketedGemsSupportedByLevelXMulticast = 6641,

		[Description("Local Display Socketed Gems Supported By Level X Power Charge On Crit")]
		LocalDisplaySocketedGemsSupportedByLevelXPowerChargeOnCrit = 6642,

		[Description("Local Display Socketed Gems Supported By Level X Increased Burning Damage")]
		LocalDisplaySocketedGemsSupportedByLevelXIncreasedBurningDamage = 6643,

		[Description("Local Display Socketed Gems Supported By Level X Summon Elemental Resistance")]
		LocalDisplaySocketedGemsSupportedByLevelXSummonElementalResistance = 6644,

		[Description("Local Display Socketed Gems Supported By Level X Curse On Hit")]
		LocalDisplaySocketedGemsSupportedByLevelXCurseOnHit = 6645,

		[Description("Local Display Socketed Gems Supported By Level X Cast On Kill")]
		LocalDisplaySocketedGemsSupportedByLevelXCastOnKill = 6646,

		[Description("Local Display Socketed Gems Supported By Level X Multi Trap")]
		LocalDisplaySocketedGemsSupportedByLevelXMultiTrap = 6647,

		[Description("Local Display Socketed Gems Supported By Level X Empower")]
		LocalDisplaySocketedGemsSupportedByLevelXEmpower = 6648,

		[Description("Local Display Socketed Gems Supported By Level X Slower Projectiles")]
		LocalDisplaySocketedGemsSupportedByLevelXSlowerProjectiles = 6649,

		[Description("Local Display Socketed Gems Supported By Level X Reduced Duration")]
		LocalDisplaySocketedGemsSupportedByLevelXReducedDuration = 6650,

		[Description("Local Display Socketed Gems Supported By Level X Cast On Damage Taken")]
		LocalDisplaySocketedGemsSupportedByLevelXCastOnDamageTaken = 6651,

		[Description("Local Display Socketed Gems Supported By Level X Enhance")]
		LocalDisplaySocketedGemsSupportedByLevelXEnhance = 6652,

		[Description("Local Display Socketed Gems Supported By Level X Physical Projectile Attack Damage")]
		LocalDisplaySocketedGemsSupportedByLevelXPhysicalProjectileAttackDamage = 6653,

		[Description("Local Display Socketed Gems Supported By Level X Enlighten")]
		LocalDisplaySocketedGemsSupportedByLevelXEnlighten = 6654,

		[Description("Local Display Socketed Gems Supported By Level X Physical To Lightning")]
		LocalDisplaySocketedGemsSupportedByLevelXPhysicalToLightning = 6655,

		[Description("Local Display Socketed Gems Supported By Level X Trap And Mine Damage")]
		LocalDisplaySocketedGemsSupportedByLevelXTrapAndMineDamage = 6656,

		[Description("Local Display Socketed Gems Supported By Level X Poison")]
		LocalDisplaySocketedGemsSupportedByLevelXPoison = 6657,

		[Description("Local Display Socketed Gems Supported By Level X Void Manipulation")]
		LocalDisplaySocketedGemsSupportedByLevelXVoidManipulation = 6658,

		[Description("Local Display Socketed Gems Supported By Level X Rapid Decay")]
		LocalDisplaySocketedGemsSupportedByLevelXRapidDecay = 6659,

		[Description("Local Display Socketed Gems Supported By Level X Cluster Trap")]
		LocalDisplaySocketedGemsSupportedByLevelXClusterTrap = 6660,

		[Description("Local Display Socketed Gems Supported By Level X Elemental Focus")]
		LocalDisplaySocketedGemsSupportedByLevelXElementalFocus = 6661,

		[Description("Local Display Socketed Gems Supported By Level X Minefield")]
		LocalDisplaySocketedGemsSupportedByLevelXMinefield = 6662,

		[Description("Local Display Socketed Gems Supported By Level X Trap Cooldown")]
		LocalDisplaySocketedGemsSupportedByLevelXTrapCooldown = 6663,

		[Description("Local Display Socketed Gems Supported By Level X Cast While Channelling")]
		LocalDisplaySocketedGemsSupportedByLevelXCastWhileChannelling = 6664,

		[Description("Local Display Socketed Gems Supported By Level X Ignite Proliferation")]
		LocalDisplaySocketedGemsSupportedByLevelXIgniteProliferation = 6665,

		[Description("Local Display Socketed Gems Supported By Level X Chance To Bleed")]
		LocalDisplaySocketedGemsSupportedByLevelXChanceToBleed = 6666,

		[Description("Local Display Socketed Gems Supported By Level X Deadly Ailments")]
		LocalDisplaySocketedGemsSupportedByLevelXDeadlyAilments = 6667,

		[Description("Local Display Socketed Gems Supported By Level X Decay")]
		LocalDisplaySocketedGemsSupportedByLevelXDecay = 6668,

		[Description("Local Display Socketed Gems Supported By Level X Efficacy")]
		LocalDisplaySocketedGemsSupportedByLevelXEfficacy = 6669,

		[Description("Local Display Socketed Gems Supported By Level X Maim")]
		LocalDisplaySocketedGemsSupportedByLevelXMaim = 6670,

		[Description("Local Display Socketed Gems Supported By Level X Immolate")]
		LocalDisplaySocketedGemsSupportedByLevelXImmolate = 6671,

		[Description("Local Display Socketed Gems Supported By Level X Unbound Ailments")]
		LocalDisplaySocketedGemsSupportedByLevelXUnboundAilments = 6672,

		[Description("Local Display Socketed Gems Supported By Level X Brutality")]
		LocalDisplaySocketedGemsSupportedByLevelXBrutality = 6673,

		[Description("Local Display Socketed Gems Supported By Level X Ruthless")]
		LocalDisplaySocketedGemsSupportedByLevelXRuthless = 6674,

		[Description("Local Display Socketed Gems Supported By Level X Onslaught")]
		LocalDisplaySocketedGemsSupportedByLevelXOnslaught = 6675,

		[Description("Local Display Socketed Gems Supported By Level X Arcane Surge")]
		LocalDisplaySocketedGemsSupportedByLevelXArcaneSurge = 6676,

		[Description("Local Display Socketed Gems Supported By Level X Reduced Block Chance")]
		LocalDisplaySocketedGemsSupportedByLevelXReducedBlockChance = 6677,

		[Description("Spectral Throw Gain Vaal Soul For Vaal Spectral Throw On Hit %")]
		SpectralThrowGainVaalSoulForVaalSpectralThrowOnHitPct = 6678,

		[Description("Local Unique Jewel Spectral Throw Gain Vaal Soul For Vaal St On Hit % With 40 Dex In Radius")]
		LocalUniqueJewelSpectralThrowGainVaalSoulForVaalStOnHitPctWith40DexInRadius = 6679,

		[Description("Trigger Socketed Spell On Attack %")]
		TriggerSocketedSpellOnAttackPct = 6680,

		[Description("Main Hand Trigger Socketed Spell On Attack %")]
		MainHandTriggerSocketedSpellOnAttackPct = 6681,

		[Description("Off Hand Trigger Socketed Spell On Attack %")]
		OffHandTriggerSocketedSpellOnAttackPct = 6682,

		[Description("Local Attack Minimum Added Physical Damage Per 3 Levels")]
		LocalAttackMinimumAddedPhysicalDamagePer3Levels = 6683,

		[Description("Local Attack Maximum Added Physical Damage Per 3 Levels")]
		LocalAttackMaximumAddedPhysicalDamagePer3Levels = 6684,

		[Description("Main Hand Attack Minimum Added Physical Damage Per 3 Levels")]
		MainHandAttackMinimumAddedPhysicalDamagePer3Levels = 6685,

		[Description("Main Hand Attack Maximum Added Physical Damage Per 3 Levels")]
		MainHandAttackMaximumAddedPhysicalDamagePer3Levels = 6686,

		[Description("Off Hand Attack Minimum Added Physical Damage Per 3 Levels")]
		OffHandAttackMinimumAddedPhysicalDamagePer3Levels = 6687,

		[Description("Off Hand Attack Maximum Added Physical Damage Per 3 Levels")]
		OffHandAttackMaximumAddedPhysicalDamagePer3Levels = 6688,

		[Description("Local Poison Duration +% During Flask Effect")]
		LocalPoisonDurationPosPctDuringFlaskEffect = 6689,

		[Description("Local Grant Perfect Agony During Flask Effect")]
		LocalGrantPerfectAgonyDuringFlaskEffect = 6690,

		[Description("Local Chance To Poison On Hit % During Flask Effect")]
		LocalChanceToPoisonOnHitPctDuringFlaskEffect = 6691,

		[Description("Local No Critical Strike Multiplier During Flask Effect")]
		LocalNoCriticalStrikeMultiplierDuringFlaskEffect = 6692,

		[Description("Local Socketed Skill Gem Level +1 Per X Player Levels")]
		LocalSocketedSkillGemLevelPos1PerXPlayerLevels = 6693,
		[Description("Map Spawn Abysses")] MapSpawnAbysses = 6694,
		[Description("Map Num Extra Abysses")] MapNumExtraAbysses = 6695,

		[Description("Lightning Tendrils Channelled Larger Pulse Interval")]
		LightningTendrilsChannelledLargerPulseInterval = 6696,

		[Description("Local Has X Abyss Sockets")]
		LocalHasXAbyssSockets = 6697,

		[Description("Melee Skills Area Of Effect +%")]
		MeleeSkillsAreaOfEffectPosPct = 6698,
		[Description("Skill Is Melee Skill")] SkillIsMeleeSkill = 6699,

		[Description("Local Unique Jewel Melee Skills Area Of Effect +% With Passive Tree Connected To Marauder Start")]
		LocalUniqueJewelMeleeSkillsAreaOfEffectPosPctWithPassiveTreeConnectedToMarauderStart = 6700,

		[Description("Local Unique Jewel Life Leech From Attack Damage Permyriad With Passive Tree Connected To Duelist Start")]
		LocalUniqueJewelLifeLeechFromAttackDamagePermyriadWithPassiveTreeConnectedToDuelistStart = 6701,

		[Description("Local Unique Jewel Movement Speed +% With Passive Tree Connected To Ranger Start")]
		LocalUniqueJewelMovementSpeedPosPctWithPassiveTreeConnectedToRangerStart = 6702,

		[Description("Local Unique Jewel Additional Critical Strike Chance Permyriad With Passive Tree Connected To Shadow Start")]
		LocalUniqueJewelAdditionalCriticalStrikeChancePermyriadWithPassiveTreeConnectedToShadowStart = 6703,

		[Description("Local Unique Jewel Mana Regeneration Rate Per Minute % With Passive Tree Connected To Witch Start")]
		LocalUniqueJewelManaRegenerationRatePerMinutePctWithPassiveTreeConnectedToWitchStart = 6704,

		[Description("Local Unique Jewel Elemental Penetration % With Passive Tree Connected To Templar Start")]
		LocalUniqueJewelElementalPenetrationPctWithPassiveTreeConnectedToTemplarStart = 6705,

		[Description("Local Unique Jewel Additional All Attributes With Passive Tree Connected To Scion Start")]
		LocalUniqueJewelAdditionalAllAttributesWithPassiveTreeConnectedToScionStart = 6706,

		[Description("Local Unique Jewel Glacial Cascade Physical Damage % To Convert To Cold With 40 Int In Radius")]
		LocalUniqueJewelGlacialCascadePhysicalDamagePctToConvertToColdWith40IntInRadius = 6707,

		[Description("Attack Critical Strike Chance +% Per 200 Accuracy Rating")]
		AttackCriticalStrikeChancePosPctPer200AccuracyRating = 6708,

		[Description("Attack Minimum Added Physical Damage With Wands")]
		AttackMinimumAddedPhysicalDamageWithWands = 6709,

		[Description("Attack Maximum Added Physical Damage With Wands")]
		AttackMaximumAddedPhysicalDamageWithWands = 6710,

		[Description("Attack Minimum Added Physical Damage With Daggers")]
		AttackMinimumAddedPhysicalDamageWithDaggers = 6711,

		[Description("Attack Maximum Added Physical Damage With Daggers")]
		AttackMaximumAddedPhysicalDamageWithDaggers = 6712,

		[Description("Attack Minimum Added Physical Damage With Claws")]
		AttackMinimumAddedPhysicalDamageWithClaws = 6713,

		[Description("Attack Maximum Added Physical Damage With Claws")]
		AttackMaximumAddedPhysicalDamageWithClaws = 6714,

		[Description("Attack Minimum Added Physical Damage With Swords")]
		AttackMinimumAddedPhysicalDamageWithSwords = 6715,

		[Description("Attack Maximum Added Physical Damage With Swords")]
		AttackMaximumAddedPhysicalDamageWithSwords = 6716,

		[Description("Attack Minimum Added Physical Damage With Axes")]
		AttackMinimumAddedPhysicalDamageWithAxes = 6717,

		[Description("Attack Maximum Added Physical Damage With Axes")]
		AttackMaximumAddedPhysicalDamageWithAxes = 6718,

		[Description("Attack Minimum Added Physical Damage With Maces")]
		AttackMinimumAddedPhysicalDamageWithMaces = 6719,

		[Description("Attack Maximum Added Physical Damage With Maces")]
		AttackMaximumAddedPhysicalDamageWithMaces = 6720,

		[Description("Attack Minimum Added Physical Damage With Staves")]
		AttackMinimumAddedPhysicalDamageWithStaves = 6721,

		[Description("Attack Maximum Added Physical Damage With Staves")]
		AttackMaximumAddedPhysicalDamageWithStaves = 6722,

		[Description("Attack Minimum Added Lightning Damage With Daggers")]
		AttackMinimumAddedLightningDamageWithDaggers = 6723,

		[Description("Attack Maximum Added Lightning Damage With Daggers")]
		AttackMaximumAddedLightningDamageWithDaggers = 6724,

		[Description("Attack Minimum Added Lightning Damage With Claws")]
		AttackMinimumAddedLightningDamageWithClaws = 6725,

		[Description("Attack Maximum Added Lightning Damage With Claws")]
		AttackMaximumAddedLightningDamageWithClaws = 6726,

		[Description("Attack Minimum Added Lightning Damage With Bows")]
		AttackMinimumAddedLightningDamageWithBows = 6727,

		[Description("Attack Maximum Added Lightning Damage With Bows")]
		AttackMaximumAddedLightningDamageWithBows = 6728,

		[Description("Attack Minimum Added Lightning Damage With Swords")]
		AttackMinimumAddedLightningDamageWithSwords = 6729,

		[Description("Attack Maximum Added Lightning Damage With Swords")]
		AttackMaximumAddedLightningDamageWithSwords = 6730,

		[Description("Attack Minimum Added Lightning Damage With Axes")]
		AttackMinimumAddedLightningDamageWithAxes = 6731,

		[Description("Attack Maximum Added Lightning Damage With Axes")]
		AttackMaximumAddedLightningDamageWithAxes = 6732,

		[Description("Attack Minimum Added Lightning Damage With Maces")]
		AttackMinimumAddedLightningDamageWithMaces = 6733,

		[Description("Attack Maximum Added Lightning Damage With Maces")]
		AttackMaximumAddedLightningDamageWithMaces = 6734,

		[Description("Attack Minimum Added Lightning Damage With Staves")]
		AttackMinimumAddedLightningDamageWithStaves = 6735,

		[Description("Attack Maximum Added Lightning Damage With Staves")]
		AttackMaximumAddedLightningDamageWithStaves = 6736,

		[Description("Attack Minimum Added Fire Damage With Daggers")]
		AttackMinimumAddedFireDamageWithDaggers = 6737,

		[Description("Attack Maximum Added Fire Damage With Daggers")]
		AttackMaximumAddedFireDamageWithDaggers = 6738,

		[Description("Attack Minimum Added Fire Damage With Claws")]
		AttackMinimumAddedFireDamageWithClaws = 6739,

		[Description("Attack Maximum Added Fire Damage With Claws")]
		AttackMaximumAddedFireDamageWithClaws = 6740,

		[Description("Attack Minimum Added Fire Damage With Swords")]
		AttackMinimumAddedFireDamageWithSwords = 6741,

		[Description("Attack Maximum Added Fire Damage With Swords")]
		AttackMaximumAddedFireDamageWithSwords = 6742,

		[Description("Attack Minimum Added Fire Damage With Axes")]
		AttackMinimumAddedFireDamageWithAxes = 6743,

		[Description("Attack Maximum Added Fire Damage With Axes")]
		AttackMaximumAddedFireDamageWithAxes = 6744,

		[Description("Attack Minimum Added Fire Damage With Maces")]
		AttackMinimumAddedFireDamageWithMaces = 6745,

		[Description("Attack Maximum Added Fire Damage With Maces")]
		AttackMaximumAddedFireDamageWithMaces = 6746,

		[Description("Attack Minimum Added Fire Damage With Staves")]
		AttackMinimumAddedFireDamageWithStaves = 6747,

		[Description("Attack Maximum Added Fire Damage With Staves")]
		AttackMaximumAddedFireDamageWithStaves = 6748,

		[Description("Attack Minimum Added Cold Damage With Daggers")]
		AttackMinimumAddedColdDamageWithDaggers = 6749,

		[Description("Attack Maximum Added Cold Damage With Daggers")]
		AttackMaximumAddedColdDamageWithDaggers = 6750,

		[Description("Attack Minimum Added Cold Damage With Claws")]
		AttackMinimumAddedColdDamageWithClaws = 6751,

		[Description("Attack Maximum Added Cold Damage With Claws")]
		AttackMaximumAddedColdDamageWithClaws = 6752,

		[Description("Attack Minimum Added Cold Damage With Bows")]
		AttackMinimumAddedColdDamageWithBows = 6753,

		[Description("Attack Maximum Added Cold Damage With Bows")]
		AttackMaximumAddedColdDamageWithBows = 6754,

		[Description("Attack Minimum Added Cold Damage With Swords")]
		AttackMinimumAddedColdDamageWithSwords = 6755,

		[Description("Attack Maximum Added Cold Damage With Swords")]
		AttackMaximumAddedColdDamageWithSwords = 6756,

		[Description("Attack Minimum Added Cold Damage With Axes")]
		AttackMinimumAddedColdDamageWithAxes = 6757,

		[Description("Attack Maximum Added Cold Damage With Axes")]
		AttackMaximumAddedColdDamageWithAxes = 6758,

		[Description("Attack Minimum Added Cold Damage With Maces")]
		AttackMinimumAddedColdDamageWithMaces = 6759,

		[Description("Attack Maximum Added Cold Damage With Maces")]
		AttackMaximumAddedColdDamageWithMaces = 6760,

		[Description("Attack Minimum Added Cold Damage With Staves")]
		AttackMinimumAddedColdDamageWithStaves = 6761,

		[Description("Attack Maximum Added Cold Damage With Staves")]
		AttackMaximumAddedColdDamageWithStaves = 6762,

		[Description("Attack Minimum Added Physical Damage While Unarmed")]
		AttackMinimumAddedPhysicalDamageWhileUnarmed = 6763,

		[Description("Attack Maximum Added Physical Damage While Unarmed")]
		AttackMaximumAddedPhysicalDamageWhileUnarmed = 6764,

		[Description("Attack Minimum Added Physical Damage While Holding A Shield")]
		AttackMinimumAddedPhysicalDamageWhileHoldingAShield = 6765,

		[Description("Attack Maximum Added Physical Damage While Holding A Shield")]
		AttackMaximumAddedPhysicalDamageWhileHoldingAShield = 6766,

		[Description("Spell Minimum Added Fire Damage While Dual Wielding")]
		SpellMinimumAddedFireDamageWhileDualWielding = 6767,

		[Description("Spell Maximum Added Fire Damage While Dual Wielding")]
		SpellMaximumAddedFireDamageWhileDualWielding = 6768,

		[Description("Spell Minimum Added Cold Damage While Dual Wielding")]
		SpellMinimumAddedColdDamageWhileDualWielding = 6769,

		[Description("Spell Maximum Added Cold Damage While Dual Wielding")]
		SpellMaximumAddedColdDamageWhileDualWielding = 6770,

		[Description("Spell Minimum Added Lightning Damage While Dual Wielding")]
		SpellMinimumAddedLightningDamageWhileDualWielding = 6771,

		[Description("Spell Maximum Added Lightning Damage While Dual Wielding")]
		SpellMaximumAddedLightningDamageWhileDualWielding = 6772,

		[Description("Spell Minimum Added Physical Damage While Dual Wielding")]
		SpellMinimumAddedPhysicalDamageWhileDualWielding = 6773,

		[Description("Spell Maximum Added Physical Damage While Dual Wielding")]
		SpellMaximumAddedPhysicalDamageWhileDualWielding = 6774,

		[Description("Spell Minimum Added Chaos Damage While Dual Wielding")]
		SpellMinimumAddedChaosDamageWhileDualWielding = 6775,

		[Description("Spell Maximum Added Chaos Damage While Dual Wielding")]
		SpellMaximumAddedChaosDamageWhileDualWielding = 6776,

		[Description("Spell Minimum Added Fire Damage While Wielding Two Handed Weapon")]
		SpellMinimumAddedFireDamageWhileWieldingTwoHandedWeapon = 6777,

		[Description("Spell Maximum Added Fire Damage While Wielding Two Handed Weapon")]
		SpellMaximumAddedFireDamageWhileWieldingTwoHandedWeapon = 6778,

		[Description("Spell Minimum Added Cold Damage While Wielding Two Handed Weapon")]
		SpellMinimumAddedColdDamageWhileWieldingTwoHandedWeapon = 6779,

		[Description("Spell Maximum Added Cold Damage While Wielding Two Handed Weapon")]
		SpellMaximumAddedColdDamageWhileWieldingTwoHandedWeapon = 6780,

		[Description("Spell Minimum Added Lightning Damage While Wielding Two Handed Weapon")]
		SpellMinimumAddedLightningDamageWhileWieldingTwoHandedWeapon = 6781,

		[Description("Spell Maximum Added Lightning Damage While Wielding Two Handed Weapon")]
		SpellMaximumAddedLightningDamageWhileWieldingTwoHandedWeapon = 6782,

		[Description("Spell Minimum Added Physical Damage While Wielding Two Handed Weapon")]
		SpellMinimumAddedPhysicalDamageWhileWieldingTwoHandedWeapon = 6783,

		[Description("Spell Maximum Added Physical Damage While Wielding Two Handed Weapon")]
		SpellMaximumAddedPhysicalDamageWhileWieldingTwoHandedWeapon = 6784,

		[Description("Spell Minimum Added Chaos Damage While Wielding Two Handed Weapon")]
		SpellMinimumAddedChaosDamageWhileWieldingTwoHandedWeapon = 6785,

		[Description("Spell Maximum Added Chaos Damage While Wielding Two Handed Weapon")]
		SpellMaximumAddedChaosDamageWhileWieldingTwoHandedWeapon = 6786,

		[Description("Spell Minimum Added Fire Damage While Holding A Shield")]
		SpellMinimumAddedFireDamageWhileHoldingAShield = 6787,

		[Description("Spell Maximum Added Fire Damage While Holding A Shield")]
		SpellMaximumAddedFireDamageWhileHoldingAShield = 6788,

		[Description("Spell Minimum Added Cold Damage While Holding A Shield")]
		SpellMinimumAddedColdDamageWhileHoldingAShield = 6789,

		[Description("Spell Maximum Added Cold Damage While Holding A Shield")]
		SpellMaximumAddedColdDamageWhileHoldingAShield = 6790,

		[Description("Spell Minimum Added Lightning Damage While Holding A Shield")]
		SpellMinimumAddedLightningDamageWhileHoldingAShield = 6791,

		[Description("Spell Maximum Added Lightning Damage While Holding A Shield")]
		SpellMaximumAddedLightningDamageWhileHoldingAShield = 6792,

		[Description("Spell Minimum Added Physical Damage While Holding A Shield")]
		SpellMinimumAddedPhysicalDamageWhileHoldingAShield = 6793,

		[Description("Spell Maximum Added Physical Damage While Holding A Shield")]
		SpellMaximumAddedPhysicalDamageWhileHoldingAShield = 6794,

		[Description("Spell Minimum Added Chaos Damage While Holding A Shield")]
		SpellMinimumAddedChaosDamageWhileHoldingAShield = 6795,

		[Description("Spell Maximum Added Chaos Damage While Holding A Shield")]
		SpellMaximumAddedChaosDamageWhileHoldingAShield = 6796,

		[Description("Damage Over Time +% While Dual Wielding")]
		DamageOverTimePosPctWhileDualWielding = 6797,

		[Description("Damage Over Time +% While Wielding Two Handed Weapon")]
		DamageOverTimePosPctWhileWieldingTwoHandedWeapon = 6798,

		[Description("Damage Over Time +% While Holding A Shield")]
		DamageOverTimePosPctWhileHoldingAShield = 6799,

		[Description("Minion Global Minimum Added Fire Damage")]
		MinionGlobalMinimumAddedFireDamage = 6800,

		[Description("Minion Global Maximum Added Fire Damage")]
		MinionGlobalMaximumAddedFireDamage = 6801,

		[Description("Minion Global Minimum Added Cold Damage")]
		MinionGlobalMinimumAddedColdDamage = 6802,

		[Description("Minion Global Maximum Added Cold Damage")]
		MinionGlobalMaximumAddedColdDamage = 6803,

		[Description("Minion Global Minimum Added Lightning Damage")]
		MinionGlobalMinimumAddedLightningDamage = 6804,

		[Description("Minion Global Maximum Added Lightning Damage")]
		MinionGlobalMaximumAddedLightningDamage = 6805,

		[Description("Minion Global Minimum Added Physical Damage")]
		MinionGlobalMinimumAddedPhysicalDamage = 6806,

		[Description("Minion Global Maximum Added Physical Damage")]
		MinionGlobalMaximumAddedPhysicalDamage = 6807,

		[Description("Minion Global Minimum Added Chaos Damage")]
		MinionGlobalMinimumAddedChaosDamage = 6808,

		[Description("Minion Global Maximum Added Chaos Damage")]
		MinionGlobalMaximumAddedChaosDamage = 6809,

		[Description("Minion Life Regeneration Rate Per Second")]
		MinionLifeRegenerationRatePerSecond = 6810,

		[Description("Energy Shield Regeneration Rate Per Second")]
		EnergyShieldRegenerationRatePerSecond = 6811,

		[Description("Local Attack Cast Movement Speed +% During Flask Effect")]
		LocalAttackCastMovementSpeedPosPctDuringFlaskEffect = 6812,

		[Description("Local Attack Cast Movement Speed +% Per Second During Flask Effect")]
		LocalAttackCastMovementSpeedPosPctPerSecondDuringFlaskEffect = 6813,

		[Description("Damage +% Vs Abyssal Monsters")]
		DamagePosPctVsAbyssalMonsters = 6814,

		[Description("Minion Damage +% Vs Abyssal Monsters")]
		MinionDamagePosPctVsAbyssalMonsters = 6815,

		[Description("Additional Physical Damage Reduction % Vs Abyssal Monsters")]
		AdditionalPhysicalDamageReductionPctVsAbyssalMonsters = 6816,

		[Description("Attacker Conditional Damage Stats Requires Tags")]
		AttackerConditionalDamageStatsRequiresTags = 6817,

		[Description("Defender Conditional Damage Stats Requires Tags")]
		DefenderConditionalDamageStatsRequiresTags = 6818,

		[Description("Chance To Block Spells % If Damaged By A Hit Recently")]
		ChanceToBlockSpellsPctIfDamagedByAHitRecently = 6819,

		[Description("Track Have Been Damaged By A Hit Recently")]
		TrackHaveBeenDamagedByAHitRecently = 6820,

		[Description("Have Been Damaged By A Hit Recently")]
		HaveBeenDamagedByAHitRecently = 6821,

		[Description("Movement Speed +% If Have Not Taken Damage Recently")]
		MovementSpeedPosPctIfHaveNotTakenDamageRecently = 6822,

		[Description("Track Have Stopped Taking Damage Over Time Recently")]
		TrackHaveStoppedTakingDamageOverTimeRecently = 6823,

		[Description("Have Stopped Taking Damage Over Time Recently")]
		HaveStoppedTakingDamageOverTimeRecently = 6824,

		[Description("Is Currently Taking Damage Over Time")]
		IsCurrentlyTakingDamageOverTime = 6825,

		[Description("Damage +% If Enemy Killed Recently")]
		DamagePosPctIfEnemyKilledRecently = 6826,

		[Description("Critical Strike Multiplier + If Enemy Killed Recently")]
		CriticalStrikeMultiplierPosIfEnemyKilledRecently = 6827,

		[Description("Armour +% If Enemy Not Killed Recently")]
		ArmourPosPctIfEnemyNotKilledRecently = 6828,

		[Description("Accuracy Rating +% If Enemy Not Killed Recently")]
		AccuracyRatingPosPctIfEnemyNotKilledRecently = 6829,

		[Description("Damage Penetrates % Elemental Resistance If Enemy Not Killed Recently")]
		DamagePenetratesPctElementalResistanceIfEnemyNotKilledRecently = 6830,

		[Description("Cast Speed +% If Player Minion Has Been Killed Recently")]
		CastSpeedPosPctIfPlayerMinionHasBeenKilledRecently = 6831,

		[Description("Track Has Player Minion Been Killed Recently")]
		TrackHasPlayerMinionBeenKilledRecently = 6832,

		[Description("Has Player Minion Been Killed Recently")]
		HasPlayerMinionBeenKilledRecently = 6833,

		[Description("Minion Damage +% If Have Used A Minion Skill Recently")]
		MinionDamagePosPctIfHaveUsedAMinionSkillRecently = 6834,

		[Description("Track Have Used A Minion Skill Recently")]
		TrackHaveUsedAMinionSkillRecently = 6835,

		[Description("Have Used A Minion Skill Recently")]
		HaveUsedAMinionSkillRecently = 6836,

		[Description("Evasion Rating +% While Moving")]
		EvasionRatingPosPctWhileMoving = 6837,

		[Description("Mana Regeneration Rate +% While Moving")]
		ManaRegenerationRatePosPctWhileMoving = 6838,

		[Description("Life Regeneration Rate Per Minute % While Moving")]
		LifeRegenerationRatePerMinutePctWhileMoving = 6839,

		[Description("Physical Damage % To Add As Fire If Have Crit Recently")]
		PhysicalDamagePctToAddAsFireIfHaveCritRecently = 6840,

		[Description("Attack Speed +% If Have Crit Recently")]
		AttackSpeedPosPctIfHaveCritRecently = 6841,

		[Description("Cast Speed +% If Have Crit Recently")]
		CastSpeedPosPctIfHaveCritRecently = 6842,

		[Description("Critical Strike Chance +% If Have Not Crit Recently")]
		CriticalStrikeChancePosPctIfHaveNotCritRecently = 6843,

		[Description("Minion Attack And Cast Speed +% If You Or Minions Have Killed Enemy Recently")]
		MinionAttackAndCastSpeedPosPctIfYouOrMinionsHaveKilledEnemyRecently = 6844,

		[Description("Notify Parent Have Killed Enemy Recently")]
		NotifyParentHaveKilledEnemyRecently = 6845,

		[Description("Minion Has Killed Enemy Recently")]
		MinionHasKilledEnemyRecently = 6846,

		[Description("Attacks Chance To Blind On Hit %")]
		AttacksChanceToBlindOnHitPct = 6847,

		[Description("Attacks Chance To Taunt On Hit %")]
		AttacksChanceToTauntOnHitPct = 6848,

		[Description("Spells Chance To Hinder On Hit %")]
		SpellsChanceToHinderOnHitPct = 6849,

		[Description("Minion Attacks Chance To Blind On Hit %")]
		MinionAttacksChanceToBlindOnHitPct = 6850,

		[Description("Minion Attacks Chance To Taunt On Hit %")]
		MinionAttacksChanceToTauntOnHitPct = 6851,

		[Description("Minion Spells Chance To Hinder On Hit %")]
		MinionSpellsChanceToHinderOnHitPct = 6852,

		[Description("Desecrate Maximum Number Of Corpses")]
		DesecrateMaximumNumberOfCorpses = 6853,

		[Description("Additional Physical Damage Reduction % If Not Damaged By A Hit Recently")]
		AdditionalPhysicalDamageReductionPctIfNotDamagedByAHitRecently = 6854,
		[Description("Has Aegis Shield Type")] HasAegisShieldType = 6855,

		[Description("Local Display Cast Fire Aegis On Gain Skill")]
		LocalDisplayCastFireAegisOnGainSkill = 6856,

		[Description("Local Display Cast Cold Aegis On Gain Skill")]
		LocalDisplayCastColdAegisOnGainSkill = 6857,

		[Description("Local Display Cast Elemental Aegis On Gain Skill")]
		LocalDisplayCastElementalAegisOnGainSkill = 6858,

		[Description("Poison Reflected To Self")]
		PoisonReflectedToSelf = 6859,

		[Description("Bleeding Reflected To Self")]
		BleedingReflectedToSelf = 6860,

		[Description("Chaos Damage Resistance % Per Poison Stack")]
		ChaosDamageResistancePctPerPoisonStack = 6861,

		[Description("Armour +% While Bleeding")]
		ArmourPosPctWhileBleeding = 6862,
		[Description("Avoid Poison %")] AvoidPoisonPct = 6863,
		[Description("Cannot Be Frozen")] CannotBeFrozen = 6864,

		[Description("Local Display Grants Level X Curse Pillar Skill")]
		LocalDisplayGrantsLevelXCursePillarSkill = 6865,

		[Description("Local Socketed Active Skill Gem Level +")]
		LocalSocketedActiveSkillGemLevelPos = 6866,

		[Description("Local Socketed Active Skill Gem Quality +")]
		LocalSocketedActiveSkillGemQualityPos = 6867,

		[Description("Aegis Unique Shield Max Value")]
		AegisUniqueShieldMaxValue = 6868,

		[Description("Move Daemon Rotation Per Repeat")]
		MoveDaemonRotationPerRepeat = 6869,

		[Description("Move Daemon End Rotation Per Repeat")]
		MoveDaemonEndRotationPerRepeat = 6870,

		[Description("Move Daemon X Offset Per Repeat")]
		MoveDaemonXOffsetPerRepeat = 6871,

		[Description("Move Daemon Y Offset Per Repeat")]
		MoveDaemonYOffsetPerRepeat = 6872,
		[Description("Map Tier +5")] MapTierPos5 = 6873,
		[Description("Map Tier 16")] MapTier16 = 6874,

		[Description("Raised Spectre Max Level")]
		RaisedSpectreMaxLevel = 6875,

		[Description("Summon Specific Monsters In Front Angle Offset")]
		SummonSpecificMonstersInFrontAngleOffset = 6876,

		[Description("Move Daemon Random Xy Offset")]
		MoveDaemonRandomXyOffset = 6877,

		[Description("Move Daemon Random X Offset")]
		MoveDaemonRandomXOffset = 6878,

		[Description("Move Daemon Random Y Offset")]
		MoveDaemonRandomYOffset = 6879,

		[Description("Endurance Charge Slam Damage +% Final With Endurance Charge")]
		EnduranceChargeSlamDamagePosPctFinalWithEnduranceCharge = 6880,

		[Description("Generic Skill Trigger Skills With Id")]
		GenericSkillTriggerSkillsWithId = 6881,

		[Description("Generic Skill Trigger Id")]
		GenericSkillTriggerId = 6882,

		[Description("Generic Skill Trigger %")]
		GenericSkillTriggerPct = 6883,

		[Description("Projectile Swap From To Locations")]
		ProjectileSwapFromToLocations = 6884,

		[Description("Projectile Angle Variance")]
		ProjectileAngleVariance = 6885,

		[Description("Maligaro Combo Attack Third Hit Damage +% Final")]
		MaligaroComboAttackThirdHitDamagePosPctFinal = 6886,

		[Description("Minions Cannot Be Damaged")]
		MinionsCannotBeDamaged = 6887,

		[Description("Minions Deal No Damage")]
		MinionsDealNoDamage = 6888,

		[Description("Curse On Hit Level Assassins Mark")]
		CurseOnHitLevelAssassinsMark = 6889,

		[Description("Projectile Distance Override")]
		ProjectileDistanceOverride = 6890,

		[Description("Mortar Projectile Distance Override")]
		MortarProjectileDistanceOverride = 6891,

		[Description("Triggered Skill Use Animation Event")]
		TriggeredSkillUseAnimationEvent = 6892,

		[Description("Map Atlas Influence Type")]
		MapAtlasInfluenceType = 6893,

		[Description("Combo Attack First Hit Damage +% Final")]
		ComboAttackFirstHitDamagePosPctFinal = 6894,

		[Description("Support Storm Barrier Physical Damage Taken When Hit +% Final")]
		SupportStormBarrierPhysicalDamageTakenWhenHitPosPctFinal = 6895,

		[Description("Support Storm Barrier Lightning Damage Taken When Hit +% Final")]
		SupportStormBarrierLightningDamageTakenWhenHitPosPctFinal = 6896,

		[Description("Support Storm Barrier Gain Power Charge When Hit %")]
		SupportStormBarrierGainPowerChargeWhenHitPct = 6897,

		[Description("Gain Power Charge When Hit %")]
		GainPowerChargeWhenHitPct = 6898,

		[Description("Local Display Socketed Gems Supported By Level X Storm Barrier")]
		LocalDisplaySocketedGemsSupportedByLevelXStormBarrier = 6899,

		[Description("Gain Critical Strike Chance % For 2 Seconds When You Spend 800 Mana")]
		GainCriticalStrikeChancePctFor2SecondsWhenYouSpend800Mana = 6900,

		[Description("Virtual Maximum Life Leech Rate % Per Minute")]
		VirtualMaximumLifeLeechRatePctPerMinute = 6901,
		[Description("Keystone Vaal Pact")] KeystoneVaalPact = 6902,

		[Description("Life Leech Speed Is Doubled")]
		LifeLeechSpeedIsDoubled = 6903,

		[Description("Maximum Life Leech Rate % Per Minute Is Doubled")]
		MaximumLifeLeechRatePctPerMinuteIsDoubled = 6904,

		[Description("Spectres Have Base Duration Ms")]
		SpectresHaveBaseDurationMs = 6905,

		[Description("Spectres Critical Strike Chance +%")]
		SpectresCriticalStrikeChancePosPct = 6906,

		[Description("Gain Her Embrace For X Ms On Enemy Ignited")]
		GainHerEmbraceForXMsOnEnemyIgnited = 6907,
		[Description("Has Her Embrace")] HasHerEmbrace = 6908,

		[Description("% Maximum Es And Life Taken As Fire Damage Per Minute Per Level While In Her Embrace")]
		Pctmaximumesandlifetakenasfiredamageperminuteperlevelwhileinherembrace = 6909,

		[Description("Projectile Uses Contact Direction")]
		ProjectileUsesContactDirection = 6910,

		[Description("Spell Base Fire Damage % Maximum Life")]
		SpellBaseFireDamagePctMaximumLife = 6911,

		[Description("Additional Critical Strike Chance Per 10 Shield Maximum Energy Shield Permyriad")]
		AdditionalCriticalStrikeChancePer10ShieldMaximumEnergyShieldPermyriad = 6912,

		[Description("Bone Lance Skill Behaviour Variation")]
		BoneLanceSkillBehaviourVariation = 6913,

		[Description("Gain Armour Equal To Mana Reserved")]
		GainArmourEqualToManaReserved = 6914,

		[Description("Gain Vaal Pact If You Have Crit Recently")]
		GainVaalPactIfYouHaveCritRecently = 6915,

		[Description("Virtual Keystone Vaal Pact")]
		VirtualKeystoneVaalPact = 6916,

		[Description("Support Parallel Projectile Number Of Points Per Side")]
		SupportParallelProjectileNumberOfPointsPerSide = 6917,

		[Description("Support Spell Cascade Number Of Cascades Per Side")]
		SupportSpellCascadeNumberOfCascadesPerSide = 6918,

		[Description("Support Spell Cascade Area Of Effect +% Per Cascade")]
		SupportSpellCascadeAreaOfEffectPosPctPerCascade = 6919,

		[Description("Support Spell Cascade Area Of Effect +% Final")]
		SupportSpellCascadeAreaOfEffectPosPctFinal = 6920,

		[Description("Local Display Socketed Gems Supported By Level X Parallel Projectiles")]
		LocalDisplaySocketedGemsSupportedByLevelXParallelProjectiles = 6921,

		[Description("Local Display Socketed Gems Supported By Level X Spell Cascade")]
		LocalDisplaySocketedGemsSupportedByLevelXSpellCascade = 6922,

		[Description("Map Display Area Contains Unbridged Gaps To Cross")]
		MapDisplayAreaContainsUnbridgedGapsToCross = 6923,

		[Description("Map Players Movement Skills Cooldown Speed +%")]
		MapPlayersMovementSkillsCooldownSpeedPosPct = 6924,

		[Description("Movement Skills Cooldown Speed +%")]
		MovementSkillsCooldownSpeedPosPct = 6925,
		[Description("Map Packs Are Kitava")] MapPacksAreKitava = 6926,

		[Description("Map Packs Have Anomalies")]
		MapPacksHaveAnomalies = 6927,

		[Description("Map Shaper Influence Spawn Shaper Clone")]
		MapShaperInfluenceSpawnShaperClone = 6928,

		[Description("Map Shaper Influence Additional Packs Of Space Monsters")]
		MapShaperInfluenceAdditionalPacksOfSpaceMonsters = 6929,

		[Description("Map Shaper Influence Spawn Boss Pack")]
		MapShaperInfluenceSpawnBossPack = 6930,

		[Description("Map Shaper Influence Spawn Maelstrom Cell")]
		MapShaperInfluenceSpawnMaelstromCell = 6931,

		[Description("Grasping Vines Movement Speed +% Final")]
		GraspingVinesMovementSpeedPosPctFinal = 6932,

		[Description("Support Parallel Projectiles Damage +% Final")]
		SupportParallelProjectilesDamagePosPctFinal = 6933,

		[Description("Is Trigger Daemon When Hit Triggered Skill")]
		IsTriggerDaemonWhenHitTriggeredSkill = 6934,

		[Description("Trigger Daemon When Hit Triggered Skill Chance %")]
		TriggerDaemonWhenHitTriggeredSkillChancePct = 6935,

		[Description("Cannot Be Ignited With Strength Higher Than Dex")]
		CannotBeIgnitedWithStrengthHigherThanDex = 6936,

		[Description("Cannot Be Frozen With Dex Higher Than Int")]
		CannotBeFrozenWithDexHigherThanInt = 6937,

		[Description("Cannot Be Shocked With Int Higher Than Strength")]
		CannotBeShockedWithIntHigherThanStrength = 6938,

		[Description("Damage +% Per 5 Of Your Lowest Attribute")]
		DamagePosPctPer5OfYourLowestAttribute = 6939,
		[Description("Cannot Be Ignited")] CannotBeIgnited = 6940,

		[Description("Attacks With This Weapon Minimum Added Cold Damage Per 10 Dexterity")]
		AttacksWithThisWeaponMinimumAddedColdDamagePer10Dexterity = 6941,

		[Description("Attacks With This Weapon Maximum Added Cold Damage Per 10 Dexterity")]
		AttacksWithThisWeaponMaximumAddedColdDamagePer10Dexterity = 6942,

		[Description("Main Hand Attacks With This Weapon Minimum Added Cold Damage Per 10 Dexterity")]
		MainHandAttacksWithThisWeaponMinimumAddedColdDamagePer10Dexterity = 6943,

		[Description("Main Hand Attacks With This Weapon Maximum Added Cold Damage Per 10 Dexterity")]
		MainHandAttacksWithThisWeaponMaximumAddedColdDamagePer10Dexterity = 6944,

		[Description("Off Hand Attacks With This Weapon Minimum Added Cold Damage Per 10 Dexterity")]
		OffHandAttacksWithThisWeaponMinimumAddedColdDamagePer10Dexterity = 6945,

		[Description("Off Hand Attacks With This Weapon Maximum Added Cold Damage Per 10 Dexterity")]
		OffHandAttacksWithThisWeaponMaximumAddedColdDamagePer10Dexterity = 6946,

		[Description("Local Chaos Damage Taken Per Minute During Flask Effect")]
		LocalChaosDamageTakenPerMinuteDuringFlaskEffect = 6947,

		[Description("Melee Attack Number Of Spirit Strikes")]
		MeleeAttackNumberOfSpiritStrikes = 6948,
		[Description("Cannot Taunt Enemies")] CannotTauntEnemies = 6949,

		[Description("Minions Cannot Taunt Enemies")]
		MinionsCannotTauntEnemies = 6950,

		[Description("Base Number Of Support Ghosts Allowed")]
		BaseNumberOfSupportGhostsAllowed = 6951,

		[Description("Chance To Summon Support Ghost On Killing Blow %")]
		ChanceToSummonSupportGhostOnKillingBlowPct = 6952,

		[Description("Support Ghost Base Duration")]
		SupportGhostBaseDuration = 6953,

		[Description("Support Ghost Duration")]
		SupportGhostDuration = 6954,

		[Description("Skill Can Own Support Ghosts")]
		SkillCanOwnSupportGhosts = 6955,

		[Description("Local Display Socketed Gems Supported By Level X Spirit Strike")]
		LocalDisplaySocketedGemsSupportedByLevelXSpiritStrike = 6956,

		[Description("Local Display Socketed Gems Supported By Level X Summon Ghost On Kill")]
		LocalDisplaySocketedGemsSupportedByLevelXSummonGhostOnKill = 6957,

		[Description("Support Spirit Strike Damage +% Final")]
		SupportSpiritStrikeDamagePosPctFinal = 6958,

		[Description("Local Display Socketed Attacks Additional Critical Strike Chance")]
		LocalDisplaySocketedAttacksAdditionalCriticalStrikeChance = 6959,

		[Description("Local Display Socketed Attacks Critical Strike Multiplier +")]
		LocalDisplaySocketedAttacksCriticalStrikeMultiplierPos = 6960,

		[Description("Local Display Socketed Spells Additional Critical Strike Chance")]
		LocalDisplaySocketedSpellsAdditionalCriticalStrikeChance = 6961,

		[Description("Local Display Socketed Spells Critical Strike Multiplier +")]
		LocalDisplaySocketedSpellsCriticalStrikeMultiplierPos = 6962,

		[Description("Keystone Shared Suffering")]
		KeystoneSharedSuffering = 6963,

		[Description("All Damage Can Cause Elemental Ailments You Are Suffering From")]
		AllDamageCanCauseElementalAilmentsYouAreSufferingFrom = 6964,

		[Description("Base All Damage Can Cause Elemental Ailments You Are Suffering From")]
		BaseAllDamageCanCauseElementalAilmentsYouAreSufferingFrom = 6965,

		[Description("Always Inflict Elemental Ailments You Are Suffering From")]
		AlwaysInflictElementalAilmentsYouAreSufferingFrom = 6966,

		[Description("Base Always Inflict Elemental Ailments You Are Suffering From")]
		BaseAlwaysInflictElementalAilmentsYouAreSufferingFrom = 6967,

		[Description("Remove Elemental Ailments From You When You Inflict Them")]
		RemoveElementalAilmentsFromYouWhenYouInflictThem = 6968,

		[Description("Base Remove Elemental Ailments From You When You Inflict Them")]
		BaseRemoveElementalAilmentsFromYouWhenYouInflictThem = 6969,
		[Description("Geometry Attack Shape")] GeometryAttackShape = 6970,

		[Description("Geometry Attack Length")]
		GeometryAttackLength = 6971,
		[Description("Geometry Attack Width")] GeometryAttackWidth = 6972,

		[Description("Geometry Attack Arc Angle")]
		GeometryAttackArcAngle = 6973,

		[Description("Map Packs Have Tentacle Fiends")]
		MapPacksHaveTentacleFiends = 6974,
		[Description("No Movement Speed")] NoMovementSpeed = 6975,
		[Description("Unaffected By Shock")] UnaffectedByShock = 6976,

		[Description("Unaffected By Shocked Ground")]
		UnaffectedByShockedGround = 6977,

		[Description("Unaffected By Burning Ground")]
		UnaffectedByBurningGround = 6978,

		[Description("Unaffected By Chilled Ground")]
		UnaffectedByChilledGround = 6979,

		[Description("Unaffected By Desecrated Ground")]
		UnaffectedByDesecratedGround = 6980,

		[Description("Flammability Mana Reservation +%")]
		FlammabilityManaReservationPosPct = 6981,

		[Description("Frostbite Mana Reservation +%")]
		FrostbiteManaReservationPosPct = 6982,

		[Description("Conductivity Mana Reservation +%")]
		ConductivityManaReservationPosPct = 6983,

		[Description("Vulnerability Mana Reservation +%")]
		VulnerabilityManaReservationPosPct = 6984,

		[Description("Chaos Weakness Mana Reservation +%")]
		ChaosWeaknessManaReservationPosPct = 6985,

		[Description("Local Display Grants Skill Decoy Totem Level")]
		LocalDisplayGrantsSkillDecoyTotemLevel = 6986,

		[Description("Local Display Grants Skill Enduring Cry Level")]
		LocalDisplayGrantsSkillEnduringCryLevel = 6987,

		[Description("Local Display Grants Skill Rallying Cry Level")]
		LocalDisplayGrantsSkillRallyingCryLevel = 6988,

		[Description("Local Display Grants Skill Abyssal Cry Level")]
		LocalDisplayGrantsSkillAbyssalCryLevel = 6989,

		[Description("Local Display Grants Skill Herald Of Ash Level")]
		LocalDisplayGrantsSkillHeraldOfAshLevel = 6990,

		[Description("Local Display Grants Skill Herald Of Ice Level")]
		LocalDisplayGrantsSkillHeraldOfIceLevel = 6991,

		[Description("Local Display Grants Skill Herald Of Thunder Level")]
		LocalDisplayGrantsSkillHeraldOfThunderLevel = 6992,

		[Description("Curse On Hit Level Poachers Mark")]
		CurseOnHitLevelPoachersMark = 6993,

		[Description("Curse On Hit Level Warlords Mark")]
		CurseOnHitLevelWarlordsMark = 6994,

		[Description("Elemental Damage Can Shock")]
		ElementalDamageCanShock = 6995,

		[Description("Ailment Types Apply Damage Taken +%")]
		AilmentTypesApplyDamageTakenPosPct = 6996,

		[Description("Evasion Rating +% While Leeching")]
		EvasionRatingPosPctWhileLeeching = 6997,

		[Description("Blind Enemies When Hit % Chance")]
		BlindEnemiesWhenHitPctChance = 6998,

		[Description("Evasion Rating +% If You Have Hit An Enemy Recently")]
		EvasionRatingPosPctIfYouHaveHitAnEnemyRecently = 6999,

		[Description("Gain 1 Rare Monster Mod On Kill For 10 Seconds % Chance")]
		Gain1RareMonsterModOnKillFor10SecondsPctChance = 7000,

		[Description("Enemy Evasion +% If You Have Hit Them Recently")]
		EnemyEvasionPosPctIfYouHaveHitThemRecently = 7001,

		[Description("Critical Strike Multiplier + If Have Not Dealt Critical Strike Recently")]
		CriticalStrikeMultiplierPosIfHaveNotDealtCriticalStrikeRecently = 7002,

		[Description("Number Of Additional Arrows While Main Hand Accuracy Is 3000 Or More")]
		NumberOfAdditionalArrowsWhileMainHandAccuracyIs3000OrMore = 7003,

		[Description("Accuracy Rating Is Doubled")]
		AccuracyRatingIsDoubled = 7004,

		[Description("Melee Physical Damage +% Per 10 Strength While Fortified")]
		MeleePhysicalDamagePosPctPer10StrengthWhileFortified = 7005,

		[Description("Chance To Dodge Attacks % While Off Hand Is Empty")]
		ChanceToDodgeAttacksPctWhileOffHandIsEmpty = 7006,

		[Description("Cold Damage +% While Off Hand Is Empty")]
		ColdDamagePosPctWhileOffHandIsEmpty = 7007,

		[Description("Iron Reflexes Rotation Active")]
		IronReflexesRotationActive = 7008,

		[Description("Unique Bow Arborix Close Range Bow Damage +% Final While Have Iron Reflexes")]
		UniqueBowArborixCloseRangeBowDamagePosPctFinalWhileHaveIronReflexes = 7009,

		[Description("Unique Bow Arborix Close Range Bow Damage +% Final")]
		UniqueBowArborixCloseRangeBowDamagePosPctFinal = 7010,

		[Description("Virtual Player Far Shot")]
		VirtualPlayerFarShot = 7011,

		[Description("Gain Player Far Shot While Do Not Have Iron Reflexes")]
		GainPlayerFarShotWhileDoNotHaveIronReflexes = 7012,

		[Description("Attack Cast And Movement Speed +% While Do Not Have Iron Reflexes")]
		AttackCastAndMovementSpeedPosPctWhileDoNotHaveIronReflexes = 7013,

		[Description("Local Display Trigger Death Walk On Equip Level")]
		LocalDisplayTriggerDeathWalkOnEquipLevel = 7014,

		[Description("Number Of Melee Abyss Jewels")]
		NumberOfMeleeAbyssJewels = 7015,

		[Description("Number Of Ranged Abyss Jewels")]
		NumberOfRangedAbyssJewels = 7016,

		[Description("Number Of Caster Abyss Jewels")]
		NumberOfCasterAbyssJewels = 7017,

		[Description("Number Of Minion Abyss Jewels")]
		NumberOfMinionAbyssJewels = 7018,

		[Description("Number Of Abyss Jewels")]
		NumberOfAbyssJewels = 7019,

		[Description("Number Of Abyss Jewel Types")]
		NumberOfAbyssJewelTypes = 7020,

		[Description("Damage +% Per Abyss Jewel Type")]
		DamagePosPctPerAbyssJewelType = 7021,

		[Description("Support Spell Cascade Damage +% Final")]
		SupportSpellCascadeDamagePosPctFinal = 7022,

		[Description("Virtual Physical Damage Can Chill")]
		VirtualPhysicalDamageCanChill = 7023,

		[Description("Virtual Fire Damage Can Chill")]
		VirtualFireDamageCanChill = 7024,

		[Description("Virtual Cold Damage Cannot Chill")]
		VirtualColdDamageCannotChill = 7025,

		[Description("Virtual Lightning Damage Can Chill")]
		VirtualLightningDamageCanChill = 7026,

		[Description("Virtual Chaos Damage Can Chill")]
		VirtualChaosDamageCanChill = 7027,
		[Description("Fire Damage Can Chill")] FireDamageCanChill = 7028,

		[Description("Lightning Damage Can Chill")]
		LightningDamageCanChill = 7029,

		[Description("Virtual Physical Damage Can Freeze")]
		VirtualPhysicalDamageCanFreeze = 7030,

		[Description("Virtual Fire Damage Can Freeze")]
		VirtualFireDamageCanFreeze = 7031,

		[Description("Virtual Cold Damage Cannot Freeze")]
		VirtualColdDamageCannotFreeze = 7032,

		[Description("Virtual Lightning Damage Can Freeze")]
		VirtualLightningDamageCanFreeze = 7033,

		[Description("Virtual Chaos Damage Can Freeze")]
		VirtualChaosDamageCanFreeze = 7034,

		[Description("Physical Damage Can Freeze")]
		PhysicalDamageCanFreeze = 7035,

		[Description("Fire Damage Can Freeze")]
		FireDamageCanFreeze = 7036,

		[Description("Chaos Damage Can Freeze")]
		ChaosDamageCanFreeze = 7037,
		[Description("All Damage Can Freeze")] AllDamageCanFreeze = 7038,

		[Description("Virtual Physical Damage Can Shock")]
		VirtualPhysicalDamageCanShock = 7039,

		[Description("Virtual Fire Damage Can Shock")]
		VirtualFireDamageCanShock = 7040,

		[Description("Virtual Cold Damage Can Shock")]
		VirtualColdDamageCanShock = 7041,

		[Description("Virtual Lightning Damage Cannot Shock")]
		VirtualLightningDamageCannotShock = 7042,

		[Description("Virtual Chaos Damage Can Shock")]
		VirtualChaosDamageCanShock = 7043,
		[Description("Cold Damage Can Shock")] ColdDamageCanShock = 7044,

		[Description("Chaos Damage Cannot Poison")]
		ChaosDamageCannotPoison = 7045,

		[Description("Physical Damage Cannot Poison")]
		PhysicalDamageCannotPoison = 7046,

		[Description("Area Of Effect +% With 500 Or More Strength")]
		AreaOfEffectPosPctWith500OrMoreStrength = 7047,

		[Description("Area Of Effect +% If Have Stunned An Enemy Recently")]
		AreaOfEffectPosPctIfHaveStunnedAnEnemyRecently = 7048,

		[Description("Track Have Stunned An Enemy Recently")]
		TrackHaveStunnedAnEnemyRecently = 7049,

		[Description("Have Stunned An Enemy Recently")]
		HaveStunnedAnEnemyRecently = 7050,

		[Description("Chance To Gain Endurance Charge On Hit % Vs Bleeding Enemy")]
		ChanceToGainEnduranceChargeOnHitPctVsBleedingEnemy = 7051,

		[Description("Local Display Socketed Movement Skills Have No Mana Cost")]
		LocalDisplaySocketedMovementSkillsHaveNoManaCost = 7052,

		[Description("Local Hits With This Weapon Always Hit If Have Blocked Recently")]
		LocalHitsWithThisWeaponAlwaysHitIfHaveBlockedRecently = 7053,

		[Description("Main Hand Hits With This Weapon Always Hit If Have Blocked Recently")]
		MainHandHitsWithThisWeaponAlwaysHitIfHaveBlockedRecently = 7054,

		[Description("Off Hand Hits With This Weapon Always Hit If Have Blocked Recently")]
		OffHandHitsWithThisWeaponAlwaysHitIfHaveBlockedRecently = 7055,

		[Description("Additional Block % Per Endurance Charge")]
		AdditionalBlockPctPerEnduranceCharge = 7056,

		[Description("Attack Speed +% If Have Blocked Recently")]
		AttackSpeedPosPctIfHaveBlockedRecently = 7057,

		[Description("Local Display Trigger Level X Smoke Cloud On Trap Triggered")]
		LocalDisplayTriggerLevelXSmokeCloudOnTrapTriggered = 7058,

		[Description("Area Of Effect +% While Fortified")]
		AreaOfEffectPosPctWhileFortified = 7059,

		[Description("Melee Weapon Range + If You Have Killed Recently")]
		MeleeWeaponRangePosIfYouHaveKilledRecently = 7060,

		[Description("Melee Weapon Range + While Fortified")]
		MeleeWeaponRangePosWhileFortified = 7061,

		[Description("Stun Duration +% Per 15 Strength")]
		StunDurationPosPctPer15Strength = 7062,

		[Description("Stun Threshold Reduction +% With 500 Or More Strength")]
		StunThresholdReductionPosPctWith500OrMoreStrength = 7063,

		[Description("Area Of Effect +% Per Endurance Charge")]
		AreaOfEffectPosPctPerEnduranceCharge = 7064,

		[Description("Area Damage +% Per 12 Strength")]
		AreaDamagePosPctPer12Strength = 7065,

		[Description("Damage +% Vs Taunted Enemies")]
		DamagePosPctVsTauntedEnemies = 7066,

		[Description("Chance To Gain Endurance Charge When You Taunt Enemy %")]
		ChanceToGainEnduranceChargeWhenYouTauntEnemyPct = 7067,

		[Description("Attacks Chance To Bleed On Hit % Vs Taunted Enemies")]
		AttacksChanceToBleedOnHitPctVsTauntedEnemies = 7068,

		[Description("Bleed Damage +% Per Endurance Charge")]
		BleedDamagePosPctPerEnduranceCharge = 7069,

		[Description("Melee Movement Skill Chance To Fortify On Hit %")]
		MeleeMovementSkillChanceToFortifyOnHitPct = 7070,

		[Description("Melee Weapon Range + While At Maximum Frenzy Charges")]
		MeleeWeaponRangePosWhileAtMaximumFrenzyCharges = 7071,

		[Description("Poison Damage +% Vs Bleeding Enemies")]
		PoisonDamagePosPctVsBleedingEnemies = 7072,

		[Description("Additional Physical Damage Reduction % While Moving")]
		AdditionalPhysicalDamageReductionPctWhileMoving = 7073,

		[Description("Elemental Damage Taken +% While Stationary")]
		ElementalDamageTakenPosPctWhileStationary = 7074,

		[Description("Map Monsters Avoid Ailments %")]
		MapMonstersAvoidAilmentsPct = 7075,

		[Description("Number Of Endurance Charges To Gain Every 4 Seconds While Stationary")]
		NumberOfEnduranceChargesToGainEvery4SecondsWhileStationary = 7076,

		[Description("Maximum Life +% Per Abyssal Jewel Affecting You")]
		MaximumLifePosPctPerAbyssalJewelAffectingYou = 7077,

		[Description("Maximum Mana +% Per Abyssal Jewel Affecting You")]
		MaximumManaPosPctPerAbyssalJewelAffectingYou = 7078,

		[Description("Cast Speed +% During Flask Effect")]
		CastSpeedPosPctDuringFlaskEffect = 7079,

		[Description("Melee Damage +% During Flask Effect")]
		MeleeDamagePosPctDuringFlaskEffect = 7080,

		[Description("Projectile Attack Damage +% During Flask Effect")]
		ProjectileAttackDamagePosPctDuringFlaskEffect = 7081,

		[Description("Spell Damage +% During Flask Effect")]
		SpellDamagePosPctDuringFlaskEffect = 7082,

		[Description("Local Crits Have Culling Strike")]
		LocalCritsHaveCullingStrike = 7083,

		[Description("Main Hand Local Crits Have Culling Strike")]
		MainHandLocalCritsHaveCullingStrike = 7084,

		[Description("Off Hand Local Crits Have Culling Strike")]
		OffHandLocalCritsHaveCullingStrike = 7085,

		[Description("Global Minimum Added Fire Damage Vs Ignited Enemies")]
		GlobalMinimumAddedFireDamageVsIgnitedEnemies = 7086,

		[Description("Global Maximum Added Fire Damage Vs Ignited Enemies")]
		GlobalMaximumAddedFireDamageVsIgnitedEnemies = 7087,

		[Description("Global Minimum Added Cold Damage Vs Chilled Or Frozen Enemies")]
		GlobalMinimumAddedColdDamageVsChilledOrFrozenEnemies = 7088,

		[Description("Global Maximum Added Cold Damage Vs Chilled Or Frozen Enemies")]
		GlobalMaximumAddedColdDamageVsChilledOrFrozenEnemies = 7089,

		[Description("Global Minimum Added Lightning Damage Vs Shocked Enemies")]
		GlobalMinimumAddedLightningDamageVsShockedEnemies = 7090,

		[Description("Global Maximum Added Lightning Damage Vs Shocked Enemies")]
		GlobalMaximumAddedLightningDamageVsShockedEnemies = 7091,

		[Description("Chill Attackers For 4 Seconds On Block % Chance")]
		ChillAttackersFor4SecondsOnBlockPctChance = 7092,

		[Description("Shock Attackers For 4 Seconds On Block % Chance")]
		ShockAttackersFor4SecondsOnBlockPctChance = 7093,

		[Description("Damage +% Per 1% Block Chance")]
		DamagePosPctPer1PctBlockChance = 7094,

		[Description("Dodge Attacks Chance % If You Have Blocked Recently")]
		DodgeAttacksChancePctIfYouHaveBlockedRecently = 7095,

		[Description("Damage +% Per 15 Strength")]
		DamagePosPctPer15Strength = 7096,
		[Description("Damage +% Per 15 Dex")] DamagePosPctPer15Dex = 7097,
		[Description("Damage +% Per 15 Int")] DamagePosPctPer15Int = 7098,

		[Description("Additional Block % With 5 Or More Nearby Enemies")]
		AdditionalBlockPctWith5OrMoreNearbyEnemies = 7099,

		[Description("Gain Random Charge On Block")]
		GainRandomChargeOnBlock = 7100,

		[Description("Chance To Evade Attacks %")]
		ChanceToEvadeAttacksPct = 7101,

		[Description("Mana Gained On Spell Hit")]
		ManaGainedOnSpellHit = 7102,

		[Description("Remove Ignite And Burning On Flask Use")]
		RemoveIgniteAndBurningOnFlaskUse = 7103,

		[Description("Remove Chill And Freeze On Flask Use")]
		RemoveChillAndFreezeOnFlaskUse = 7104,

		[Description("Remove Shock On Flask Use")]
		RemoveShockOnFlaskUse = 7105,

		[Description("Number Of Equipped Elder Items")]
		NumberOfEquippedElderItems = 7106,

		[Description("Maximum Life Per Equipped Elder Item")]
		MaximumLifePerEquippedElderItem = 7107,

		[Description("Non Damaging Ailment Effect +% Per Equipped Elder Item")]
		NonDamagingAilmentEffectPosPctPerEquippedElderItem = 7108,

		[Description("Ailment Damage +% Per Equipped Elder Item")]
		AilmentDamagePosPctPerEquippedElderItem = 7109,

		[Description("Remove Random Ailment On Flask Use If All Equipped Items Are Elder")]
		RemoveRandomAilmentOnFlaskUseIfAllEquippedItemsAreElder = 7110,

		[Description("Virtual Freeze Effect +%")]
		VirtualFreezeEffectPosPct = 7111,

		[Description("Virtual Ignite Effect +%")]
		VirtualIgniteEffectPosPct = 7112,

		[Description("Virtual Poison Effect +%")]
		VirtualPoisonEffectPosPct = 7113,

		[Description("Virtual Bleed Effect +%")]
		VirtualBleedEffectPosPct = 7114,

		[Description("Virtual Minion Elemental Resistance %")]
		VirtualMinionElementalResistancePct = 7115,

		[Description("Minion Elemental Resistance 30%")]
		MinionElementalResistance30Pct = 7116,

		[Description("Strength Damage Bonus Grants Melee Physical Damage +3% Per 10 Strength Instead")]
		StrengthDamageBonusGrantsMeleePhysicalDamagePos3PctPer10StrengthInstead = 7117,

		[Description("Fortify Duration +% Per 10 Strength")]
		FortifyDurationPosPctPer10Strength = 7118,

		[Description("Attack Additional Critical Strike Chance Permyriad")]
		AttackAdditionalCriticalStrikeChancePermyriad = 7119,

		[Description("Spell Additional Critical Strike Chance Permyriad")]
		SpellAdditionalCriticalStrikeChancePermyriad = 7120,

		[Description("Virtual Fortify Duration +%")]
		VirtualFortifyDurationPosPct = 7121,

		[Description("Virtual Fortify Effect On Self +%")]
		VirtualFortifyEffectOnSelfPosPct = 7122,

		[Description("Fortify Effect On Self +% While Stationary")]
		FortifyEffectOnSelfPosPctWhileStationary = 7123,

		[Description("Remove Bleeding On Warcry")]
		RemoveBleedingOnWarcry = 7124,

		[Description("Chance To Gain Endurance Charge When You Stun Enemy %")]
		ChanceToGainEnduranceChargeWhenYouStunEnemyPct = 7125,

		[Description("Critical Strike Multiplier + If You Have Blocked Recently")]
		CriticalStrikeMultiplierPosIfYouHaveBlockedRecently = 7126,

		[Description("Bleeding Damage +% Vs Poisoned Enemies")]
		BleedingDamagePosPctVsPoisonedEnemies = 7127,

		[Description("Area Of Effect +% If You Have Blocked Recently")]
		AreaOfEffectPosPctIfYouHaveBlockedRecently = 7128,

		[Description("Elemental Damage +% Per Power Charge")]
		ElementalDamagePosPctPerPowerCharge = 7129,

		[Description("Elemental Damage +% Per 12 Int")]
		ElementalDamagePosPctPer12Int = 7130,

		[Description("Elemental Damage +% Per 12 Strength")]
		ElementalDamagePosPctPer12Strength = 7131,

		[Description("Elemental Damage Taken +% Per Endurance Charge")]
		ElementalDamageTakenPosPctPerEnduranceCharge = 7132,

		[Description("Additional Block % If You Have Crit Recently")]
		AdditionalBlockPctIfYouHaveCritRecently = 7133,

		[Description("Area Of Effect +% Per 50 Strength")]
		AreaOfEffectPosPctPer50Strength = 7134,

		[Description("Local Life Gain Per Target Vs Blinded Enemies")]
		LocalLifeGainPerTargetVsBlindedEnemies = 7135,

		[Description("Main Hand Local Life Gain Per Target Vs Blinded Enemies")]
		MainHandLocalLifeGainPerTargetVsBlindedEnemies = 7136,

		[Description("Off Hand Local Life Gain Per Target Vs Blinded Enemies")]
		OffHandLocalLifeGainPerTargetVsBlindedEnemies = 7137,

		[Description("Local Culling Strike If Crit Recently")]
		LocalCullingStrikeIfCritRecently = 7138,

		[Description("Main Hand Culling Strike If Crit Recently")]
		MainHandCullingStrikeIfCritRecently = 7139,

		[Description("Off Hand Culling Strike If Crit Recently")]
		OffHandCullingStrikeIfCritRecently = 7140,

		[Description("Support Mirage Archer Base Duration")]
		SupportMirageArcherBaseDuration = 7141,

		[Description("Support Mirage Archer Duration")]
		SupportMirageArcherDuration = 7142,

		[Description("Summon Mirage Archer On Hit")]
		SummonMirageArcherOnHit = 7143,

		[Description("Skill Can Own Mirage Archers")]
		SkillCanOwnMirageArchers = 7144,

		[Description("Number Of Mirage Archers Allowed")]
		NumberOfMirageArchersAllowed = 7145,

		[Description("Support Mirage Archer Damage +% Final")]
		SupportMirageArcherDamagePosPctFinal = 7146,

		[Description("Use Scaled Contact Offset")]
		UseScaledContactOffset = 7147,

		[Description("Local Culling Strike Vs Bleeding Enemies")]
		LocalCullingStrikeVsBleedingEnemies = 7148,

		[Description("Main Hand Culling Strike Vs Bleeding Enemies")]
		MainHandCullingStrikeVsBleedingEnemies = 7149,

		[Description("Off Hand Culling Strike Vs Bleeding Enemies")]
		OffHandCullingStrikeVsBleedingEnemies = 7150,

		[Description("Local Display Grants Level X Blood Offering Skill")]
		LocalDisplayGrantsLevelXBloodOfferingSkill = 7151,

		[Description("Active Skill Projectile Speed +% Variation Final")]
		ActiveSkillProjectileSpeedPosPctVariationFinal = 7152,

		[Description("Local Socketed Abyss Jewel Effect +%")]
		LocalSocketedAbyssJewelEffectPosPct = 7153,

		[Description("Non Piercing Projectiles Critical Strike Chance +%")]
		NonPiercingProjectilesCriticalStrikeChancePosPct = 7154,

		[Description("Local Evasion Rating And Energy Shield")]
		LocalEvasionRatingAndEnergyShield = 7155,

		[Description("Number Of Additional Projectiles If You Have Been Hit Recently")]
		NumberOfAdditionalProjectilesIfYouHaveBeenHitRecently = 7156,

		[Description("Gain Iron Reflexes While Stationary")]
		GainIronReflexesWhileStationary = 7157,

		[Description("Armour +% While Stationary")]
		ArmourPosPctWhileStationary = 7158,

		[Description("Number Of Additional Projectiles If You Have Used Movement Skill Recently")]
		NumberOfAdditionalProjectilesIfYouHaveUsedMovementSkillRecently = 7159,

		[Description("Virtual Keystone Iron Reflexes")]
		VirtualKeystoneIronReflexes = 7160,

		[Description("Attacks Intimidate On Hit %")]
		AttacksIntimidateOnHitPct = 7161,

		[Description("Local Attacks Intimidate On Hit For 4 Seconds With Melee Abyss Jewel Socketed")]
		LocalAttacksIntimidateOnHitFor4SecondsWithMeleeAbyssJewelSocketed = 7162,

		[Description("Local Attacks Maim On Hit For 4 Seconds With Ranged Abyss Jewel Socketed")]
		LocalAttacksMaimOnHitFor4SecondsWithRangedAbyssJewelSocketed = 7163,

		[Description("Elemental Overload Rotation Active")]
		ElementalOverloadRotationActive = 7164,

		[Description("Gain Resolute Technique While Do Not Have Elemental Overload")]
		GainResoluteTechniqueWhileDoNotHaveElementalOverload = 7165,

		[Description("Virtual Keystone Resolute Technique")]
		VirtualKeystoneResoluteTechnique = 7166,

		[Description("Local Minimum Added Physical Damage Vs Ignited Enemies")]
		LocalMinimumAddedPhysicalDamageVsIgnitedEnemies = 7167,

		[Description("Local Maximum Added Physical Damage Vs Ignited Enemies")]
		LocalMaximumAddedPhysicalDamageVsIgnitedEnemies = 7168,

		[Description("Local Minimum Added Fire Damage Vs Bleeding Enemies")]
		LocalMinimumAddedFireDamageVsBleedingEnemies = 7169,

		[Description("Local Maximum Added Fire Damage Vs Bleeding Enemies")]
		LocalMaximumAddedFireDamageVsBleedingEnemies = 7170,

		[Description("Main Hand Minimum Added Physical Damage Vs Ignited Enemies")]
		MainHandMinimumAddedPhysicalDamageVsIgnitedEnemies = 7171,

		[Description("Main Hand Maximum Added Physical Damage Vs Ignited Enemies")]
		MainHandMaximumAddedPhysicalDamageVsIgnitedEnemies = 7172,

		[Description("Main Hand Minimum Added Fire Damage Vs Bleeding Enemies")]
		MainHandMinimumAddedFireDamageVsBleedingEnemies = 7173,

		[Description("Main Hand Maximum Added Fire Damage Vs Bleeding Enemies")]
		MainHandMaximumAddedFireDamageVsBleedingEnemies = 7174,

		[Description("Off Hand Minimum Added Physical Damage Vs Ignited Enemies")]
		OffHandMinimumAddedPhysicalDamageVsIgnitedEnemies = 7175,

		[Description("Off Hand Maximum Added Physical Damage Vs Ignited Enemies")]
		OffHandMaximumAddedPhysicalDamageVsIgnitedEnemies = 7176,

		[Description("Off Hand Minimum Added Fire Damage Vs Bleeding Enemies")]
		OffHandMinimumAddedFireDamageVsBleedingEnemies = 7177,

		[Description("Off Hand Maximum Added Fire Damage Vs Bleeding Enemies")]
		OffHandMaximumAddedFireDamageVsBleedingEnemies = 7178,

		[Description("Local Chance Bleed On Hit % Vs Ignited Enemies")]
		LocalChanceBleedOnHitPctVsIgnitedEnemies = 7179,

		[Description("Main Hand Chance Bleed On Hit % Vs Ignited Enemies")]
		MainHandChanceBleedOnHitPctVsIgnitedEnemies = 7180,

		[Description("Off Hand Chance Bleed On Hit % Vs Ignited Enemies")]
		OffHandChanceBleedOnHitPctVsIgnitedEnemies = 7181,

		[Description("Avatar Of Fire Rotation Active")]
		AvatarOfFireRotationActive = 7182,

		[Description("Critical Strike Chance +% While You Have Avatar Of Fire")]
		CriticalStrikeChancePosPctWhileYouHaveAvatarOfFire = 7183,

		[Description("Physical Damage % To Convert To Fire While You Have Avatar Of Fire")]
		PhysicalDamagePctToConvertToFireWhileYouHaveAvatarOfFire = 7184,

		[Description("Armour While You Do Not Have Avatar Of Fire")]
		ArmourWhileYouDoNotHaveAvatarOfFire = 7185,

		[Description("Non Chaos Damage To Add As Chaos Damage %")]
		NonChaosDamageToAddAsChaosDamagePct = 7186,

		[Description("Projectile Non Chaos Damage To Add As Chaos Damage % Per Chain")]
		ProjectileNonChaosDamageToAddAsChaosDamagePctPerChain = 7187,

		[Description("Attack Speed +% If Enemy Killed Recently")]
		AttackSpeedPosPctIfEnemyKilledRecently = 7188,

		[Description("Critical Strike Chance +% If Enemy Killed Recently")]
		CriticalStrikeChancePosPctIfEnemyKilledRecently = 7189,

		[Description("Projectile Damage +% Per Pierced Enemy")]
		ProjectileDamagePosPctPerPiercedEnemy = 7190,

		[Description("Recover Energy Shield % On Kill")]
		RecoverEnergyShieldPctOnKill = 7191,

		[Description("Map Monsters Add Power Charge On Hit %")]
		MapMonstersAddPowerChargeOnHitPct = 7192,

		[Description("Map Monsters Add Frenzy Charge On Hit %")]
		MapMonstersAddFrenzyChargeOnHitPct = 7193,

		[Description("Map Monsters Add Endurance Charge On Hit %")]
		MapMonstersAddEnduranceChargeOnHitPct = 7194,

		[Description("Local Life Gain Per Target While Leeching")]
		LocalLifeGainPerTargetWhileLeeching = 7195,

		[Description("Main Hand Life Gain Per Target While Leeching")]
		MainHandLifeGainPerTargetWhileLeeching = 7196,

		[Description("Off Hand Life Gain Per Target While Leeching")]
		OffHandLifeGainPerTargetWhileLeeching = 7197,

		[Description("Local Display Socketed Gems Supported By Level X Mirage Archer")]
		LocalDisplaySocketedGemsSupportedByLevelXMirageArcher = 7198,
		[Description("Spectre Duration")] SpectreDuration = 7199,

		[Description("Arrows That Pierce Also Return")]
		ArrowsThatPierceAlsoReturn = 7200,

		[Description("Predict Totem Maximum Life")]
		PredictTotemMaximumLife = 7201,

		[Description("Unique Monster Dropped Item Rarity +%")]
		UniqueMonsterDroppedItemRarityPosPct = 7202,
		[Description("Cannot Block Spells")] CannotBlockSpells = 7203,

		[Description("Gain Endurance Charge % Chance When You Lose Fortify")]
		GainEnduranceChargePctChanceWhenYouLoseFortify = 7204,

		[Description("Affected By Determination")]
		AffectedByDetermination = 7205,
		[Description("Affected By Grace")] AffectedByGrace = 7206,

		[Description("Affected By Discipline")]
		AffectedByDiscipline = 7207,
		[Description("Affected By Wrath")] AffectedByWrath = 7208,
		[Description("Affected By Anger")] AffectedByAnger = 7209,
		[Description("Affected By Hatred")] AffectedByHatred = 7210,
		[Description("Affected By Vitality")] AffectedByVitality = 7211,
		[Description("Affected By Clarity")] AffectedByClarity = 7212,
		[Description("Affected By Haste")] AffectedByHaste = 7213,

		[Description("Affected By Purity Of Fire")]
		AffectedByPurityOfFire = 7214,

		[Description("Affected By Purity Of Ice")]
		AffectedByPurityOfIce = 7215,

		[Description("Affected By Purity Of Lightning")]
		AffectedByPurityOfLightning = 7216,

		[Description("Affected By Purity Of Elements")]
		AffectedByPurityOfElements = 7217,

		[Description("Additional Physical Damage Reduction % While Affected By Determination")]
		AdditionalPhysicalDamageReductionPctWhileAffectedByDetermination = 7218,

		[Description("Block % While Affected By Determination")]
		BlockPctWhileAffectedByDetermination = 7219,

		[Description("Extra Damage Taken From Crit +% While Affected By Determination")]
		ExtraDamageTakenFromCritPosPctWhileAffectedByDetermination = 7220,

		[Description("Chance To Evade Attacks % While Affected By Grace")]
		ChanceToEvadeAttacksPctWhileAffectedByGrace = 7221,

		[Description("Chance To Dodge Attacks % While Affected By Grace")]
		ChanceToDodgeAttacksPctWhileAffectedByGrace = 7222,

		[Description("Movement Speed +% While Affected By Grace")]
		MovementSpeedPosPctWhileAffectedByGrace = 7223,

		[Description("Unaffected By Vulnerability While Affected By Determination")]
		UnaffectedByVulnerabilityWhileAffectedByDetermination = 7224,

		[Description("Unaffected By Enfeeble While Affected By Grace")]
		UnaffectedByEnfeebleWhileAffectedByGrace = 7225,

		[Description("Unaffected By Temporal Chains While Affected By Haste")]
		UnaffectedByTemporalChainsWhileAffectedByHaste = 7226,

		[Description("Unaffected By Burning Ground While Affected By Purity Of Fire")]
		UnaffectedByBurningGroundWhileAffectedByPurityOfFire = 7227,

		[Description("Unaffected By Flammability While Affected By Purity Of Fire")]
		UnaffectedByFlammabilityWhileAffectedByPurityOfFire = 7228,

		[Description("Unaffected By Chilled Ground While Affected By Purity Of Ice")]
		UnaffectedByChilledGroundWhileAffectedByPurityOfIce = 7229,

		[Description("Unaffected By Frostbite While Affected By Purity Of Ice")]
		UnaffectedByFrostbiteWhileAffectedByPurityOfIce = 7230,

		[Description("Unaffected By Shocked Ground While Affected By Purity Of Lightning")]
		UnaffectedByShockedGroundWhileAffectedByPurityOfLightning = 7231,

		[Description("Unaffected By Conductivity While Affected By Purity Of Lightning")]
		UnaffectedByConductivityWhileAffectedByPurityOfLightning = 7232,

		[Description("Unaffected By Elemental Weakness While Affected By Purity Of Elements")]
		UnaffectedByElementalWeaknessWhileAffectedByPurityOfElements = 7233,

		[Description("Reduce Enemy Cold Resistance % While Affected By Hatred")]
		ReduceEnemyColdResistancePctWhileAffectedByHatred = 7234,

		[Description("Reduce Enemy Fire Resistance % While Affected By Anger")]
		ReduceEnemyFireResistancePctWhileAffectedByAnger = 7235,

		[Description("Reduce Enemy Lightning Resistance % While Affected By Wrath")]
		ReduceEnemyLightningResistancePctWhileAffectedByWrath = 7236,

		[Description("Energy Shield Regeneration Rate Per Minute % While Affected By Discipline")]
		EnergyShieldRegenerationRatePerMinutePctWhileAffectedByDiscipline = 7237,

		[Description("Chance To Block Spells % While Affected By Discipline")]
		ChanceToBlockSpellsPctWhileAffectedByDiscipline = 7238,

		[Description("Energy Shield Delay -% While Affected By Discipline")]
		EnergyShieldDelayNegPctWhileAffectedByDiscipline = 7239,

		[Description("Energy Shield Gain Per Target Hit While Affected By Discipline")]
		EnergyShieldGainPerTargetHitWhileAffectedByDiscipline = 7240,

		[Description("Mana Leech From Lightning Damage Permyriad While Affected By Wrath")]
		ManaLeechFromLightningDamagePermyriadWhileAffectedByWrath = 7241,

		[Description("Physical Damage % To Add As Lightning Damage While Affected By Wrath")]
		PhysicalDamagePctToAddAsLightningDamageWhileAffectedByWrath = 7242,

		[Description("Base Physical Damage % To Convert To Lightning While Affected By Wrath")]
		BasePhysicalDamagePctToConvertToLightningWhileAffectedByWrath = 7243,

		[Description("Virtual Non Skill Physical Damage % To Convert To Fire")]
		VirtualNonSkillPhysicalDamagePctToConvertToFire = 7244,

		[Description("Virtual Non Skill Physical Damage % To Convert To Cold")]
		VirtualNonSkillPhysicalDamagePctToConvertToCold = 7245,

		[Description("Virtual Non Skill Physical Damage % To Convert To Lightning")]
		VirtualNonSkillPhysicalDamagePctToConvertToLightning = 7246,

		[Description("Virtual Non Skill Physical Damage % To Convert To Chaos")]
		VirtualNonSkillPhysicalDamagePctToConvertToChaos = 7247,

		[Description("Virtual Non Skill Lightning Damage % To Convert To Fire")]
		VirtualNonSkillLightningDamagePctToConvertToFire = 7248,

		[Description("Virtual Non Skill Lightning Damage % To Convert To Cold")]
		VirtualNonSkillLightningDamagePctToConvertToCold = 7249,

		[Description("Virtual Non Skill Lightning Damage % To Convert To Chaos")]
		VirtualNonSkillLightningDamagePctToConvertToChaos = 7250,

		[Description("Virtual Non Skill Cold Damage % To Convert To Fire")]
		VirtualNonSkillColdDamagePctToConvertToFire = 7251,

		[Description("Virtual Non Skill Cold Damage % To Convert To Chaos")]
		VirtualNonSkillColdDamagePctToConvertToChaos = 7252,

		[Description("Virtual Non Skill Fire Damage % To Convert To Chaos")]
		VirtualNonSkillFireDamagePctToConvertToChaos = 7253,

		[Description("Base Physical Damage % To Convert To Fire While Affected By Anger")]
		BasePhysicalDamagePctToConvertToFireWhileAffectedByAnger = 7254,

		[Description("Physical Damage % To Add As Fire Damage While Affected By Anger")]
		PhysicalDamagePctToAddAsFireDamageWhileAffectedByAnger = 7255,

		[Description("Life Leech From Fire Damage Permyriad While Affected By Anger")]
		LifeLeechFromFireDamagePermyriadWhileAffectedByAnger = 7256,

		[Description("Minimum Added Cold Damage While Affected By Hatred")]
		MinimumAddedColdDamageWhileAffectedByHatred = 7257,

		[Description("Maximum Added Cold Damage While Affected By Hatred")]
		MaximumAddedColdDamageWhileAffectedByHatred = 7258,

		[Description("Base Physical Damage % To Convert To Cold While Affected By Hatred")]
		BasePhysicalDamagePctToConvertToColdWhileAffectedByHatred = 7259,

		[Description("Additional Critical Strike Chance Permyriad While Affected By Hatred")]
		AdditionalCriticalStrikeChancePermyriadWhileAffectedByHatred = 7260,

		[Description("Life Leech From Any Damage Permyriad While Affected By Vitality")]
		LifeLeechFromAnyDamagePermyriadWhileAffectedByVitality = 7261,

		[Description("Life Regeneration Per Minute While Affected By Vitality")]
		LifeRegenerationPerMinuteWhileAffectedByVitality = 7262,

		[Description("Life Recovery Rate +% While Affected By Vitality")]
		LifeRecoveryRatePosPctWhileAffectedByVitality = 7263,

		[Description("Life Gain Per Target Hit While Affected By Vitality")]
		LifeGainPerTargetHitWhileAffectedByVitality = 7264,

		[Description("Virtual Skill Mana Cost +")]
		VirtualSkillManaCostPos = 7265,

		[Description("Skill Mana Cost + While Affected By Clarity")]
		SkillManaCostPosWhileAffectedByClarity = 7266,

		[Description("Damage Removed From Mana Before Life % While Affected By Clarity")]
		DamageRemovedFromManaBeforeLifePctWhileAffectedByClarity = 7267,

		[Description("Recover 10% Mana On Skill Use % Chance While Affected By Clarity")]
		Recover10PctManaOnSkillUsePctChanceWhileAffectedByClarity = 7268,

		[Description("Maximum Mana % To Add To Energy Shield While Affected By Clarity")]
		MaximumManaPctToAddToEnergyShieldWhileAffectedByClarity = 7269,

		[Description("Chance To Dodge Spells % While Affected By Haste")]
		ChanceToDodgeSpellsPctWhileAffectedByHaste = 7270,

		[Description("Gain Onslaught On Kill Ms While Affected By Haste")]
		GainOnslaughtOnKillMsWhileAffectedByHaste = 7271,

		[Description("Gain Phasing While Affected By Haste")]
		GainPhasingWhileAffectedByHaste = 7272,

		[Description("Physical Damage Taken % As Fire While Affected By Purity Of Fire")]
		PhysicalDamageTakenPctAsFireWhileAffectedByPurityOfFire = 7273,

		[Description("Physical Damage Taken % As Cold While Affected By Purity Of Ice")]
		PhysicalDamageTakenPctAsColdWhileAffectedByPurityOfIce = 7274,

		[Description("Physical Damage Taken % As Lightning While Affected By Purity Of Lightning")]
		PhysicalDamageTakenPctAsLightningWhileAffectedByPurityOfLightning = 7275,

		[Description("Physical Damage Taken % As Fire While Affected By Purity Of Elements")]
		PhysicalDamageTakenPctAsFireWhileAffectedByPurityOfElements = 7276,

		[Description("Physical Damage Taken % As Cold While Affected By Purity Of Elements")]
		PhysicalDamageTakenPctAsColdWhileAffectedByPurityOfElements = 7277,

		[Description("Physical Damage Taken % As Lightning While Affected By Purity Of Elements")]
		PhysicalDamageTakenPctAsLightningWhileAffectedByPurityOfElements = 7278,

		[Description("Immune To Ignite While Affected By Purity Of Fire")]
		ImmuneToIgniteWhileAffectedByPurityOfFire = 7279,

		[Description("Immune To Freeze While Affected By Purity Of Ice")]
		ImmuneToFreezeWhileAffectedByPurityOfIce = 7280,

		[Description("Immune To Shock While Affected By Purity Of Lightning")]
		ImmuneToShockWhileAffectedByPurityOfLightning = 7281,

		[Description("Virtual Physical Damage Taken % As Fire")]
		VirtualPhysicalDamageTakenPctAsFire = 7282,

		[Description("Virtual Physical Damage Taken % As Cold")]
		VirtualPhysicalDamageTakenPctAsCold = 7283,

		[Description("Virtual Physical Damage Taken % As Lightning")]
		VirtualPhysicalDamageTakenPctAsLightning = 7284,
		[Description("Disable Rarity Epk")] DisableRarityEpk = 7285,

		[Description("Cannot Spawn Support Ghosts")]
		CannotSpawnSupportGhosts = 7286,

		[Description("Chance To Gain Frenzy Charge On Block %")]
		ChanceToGainFrenzyChargeOnBlockPct = 7287,

		[Description("Spell Damage +% Per 10 Strength")]
		SpellDamagePosPctPer10Strength = 7288,

		[Description("Spell Damage +% Per 16 Dex")]
		SpellDamagePosPctPer16Dex = 7289,

		[Description("Spell Damage +% Per 16 Strength")]
		SpellDamagePosPctPer16Strength = 7290,

		[Description("Spell Damage +% Per 16 Int")]
		SpellDamagePosPctPer16Int = 7291,

		[Description("Deal No Non Elemental Damage")]
		DealNoNonElementalDamage = 7292,

		[Description("Cast Speed +% If Enemy Killed Recently")]
		CastSpeedPosPctIfEnemyKilledRecently = 7293,

		[Description("Trigger On Skill Use % If You Have A Spirit Charge")]
		TriggerOnSkillUsePctIfYouHaveASpiritCharge = 7294,

		[Description("Map Force Private Seed Debug")]
		MapForcePrivateSeedDebug = 7295,

		[Description("Active Skill Display Aegis Variation")]
		ActiveSkillDisplayAegisVariation = 7296,

		[Description("Volatile Dead Number Of Corpses To Consume")]
		VolatileDeadNumberOfCorpsesToConsume = 7297,

		[Description("Unearth Additional Corpse Level")]
		UnearthAdditionalCorpseLevel = 7298,
		[Description("Unearth Corpse Level")] UnearthCorpseLevel = 7299,

		[Description("Corpse Erruption Maximum Number Of Geyers")]
		CorpseErruptionMaximumNumberOfGeyers = 7300,

		[Description("Base Number Of Effigies Allowed")]
		BaseNumberOfEffigiesAllowed = 7301,

		[Description("Visual Attached Elder Tentacles")]
		VisualAttachedElderTentacles = 7302,

		[Description("Map Elder Influence Additional Packs Of Elder Monsters")]
		MapElderInfluenceAdditionalPacksOfElderMonsters = 7303,
		[Description("Bone Lance Damage +%")] BoneLanceDamagePosPct = 7304,

		[Description("Corpse Eruption Damage +%")]
		CorpseEruptionDamagePosPct = 7305,

		[Description("Volatile Dead Damage +%")]
		VolatileDeadDamagePosPct = 7306,
		[Description("Corpse Warp Damage +%")] CorpseWarpDamagePosPct = 7307,

		[Description("Bone Lance Cast Speed +%")]
		BoneLanceCastSpeedPosPct = 7308,

		[Description("Corpse Eruption Cast Speed +%")]
		CorpseEruptionCastSpeedPosPct = 7309,

		[Description("Volatile Dead Cast Speed +%")]
		VolatileDeadCastSpeedPosPct = 7310,

		[Description("Corpse Warp Cast Speed +%")]
		CorpseWarpCastSpeedPosPct = 7311,

		[Description("Display Attack Block Chance")]
		DisplayAttackBlockChance = 7312,

		[Description("Display Spell Block Chance")]
		DisplaySpellBlockChance = 7313,

		[Description("Minimum Added Chaos Damage Taken")]
		MinimumAddedChaosDamageTaken = 7314,

		[Description("Maximum Added Chaos Damage Taken")]
		MaximumAddedChaosDamageTaken = 7315,

		[Description("Chance To Be Maimed When Hit %")]
		ChanceToBeMaimedWhenHitPct = 7316,

		[Description("Energy Shield Gained On Spell Hit")]
		EnergyShieldGainedOnSpellHit = 7317,

		[Description("Monster Spirit Charges Are Infinite")]
		MonsterSpiritChargesAreInfinite = 7318,

		[Description("Gain Spirit Charge On Kill % Chance")]
		GainSpiritChargeOnKillPctChance = 7319,

		[Description("Gain % Life When Spirit Charge Expires Or Consumed")]
		GainPctLifeWhenSpiritChargeExpiresOrConsumed = 7320,

		[Description("Local Display Trigger Level X Spirit Burst On Skill Use If Have Spirit Charge")]
		LocalDisplayTriggerLevelXSpiritBurstOnSkillUseIfHaveSpiritCharge = 7321,

		[Description("Maximum Spirit Charges Per Abyss Jewel Equipped")]
		MaximumSpiritChargesPerAbyssJewelEquipped = 7322,

		[Description("Local Display Socketed Gems Supported By Level X Elemental Penetration")]
		LocalDisplaySocketedGemsSupportedByLevelXElementalPenetration = 7323,

		[Description("Skill Used By Mirage Archer")]
		SkillUsedByMirageArcher = 7324,

		[Description("Support Mirage Archer Attack Speed +% Final")]
		SupportMirageArcherAttackSpeedPosPctFinal = 7325,

		[Description("Virtual Maximum Spirit Charges")]
		VirtualMaximumSpiritCharges = 7326,

		[Description("Gain Debilitating Presence Ms On Kill Vs Rare Or Unique Enemy")]
		GainDebilitatingPresenceMsOnKillVsRareOrUniqueEnemy = 7327,

		[Description("Cast Speed +% From Grasping Tentacles")]
		CastSpeedPosPctFromGraspingTentacles = 7328,

		[Description("Charge Elder Art Variation")]
		ChargeElderArtVariation = 7329,

		[Description("Virtual Projectile Additional Height Offset")]
		VirtualProjectileAdditionalHeightOffset = 7330,

		[Description("Local Display Trigger Level 20 Shade Form On Skill Use %")]
		LocalDisplayTriggerLevel20ShadeFormOnSkillUsePct = 7331,

		[Description("Mirage Archer Projectile Additional Height Offset")]
		MirageArcherProjectileAdditionalHeightOffset = 7332,

		[Description("Minimum Added Physical Damage Per Endurance Charge")]
		MinimumAddedPhysicalDamagePerEnduranceCharge = 7333,

		[Description("Maximum Added Physical Damage Per Endurance Charge")]
		MaximumAddedPhysicalDamagePerEnduranceCharge = 7334,

		[Description("Chaos Damage Resistance % Per Endurance Charge")]
		ChaosDamageResistancePctPerEnduranceCharge = 7335,

		[Description("Elemental Damage Taken From Hits +% Per Endurance Charge")]
		ElementalDamageTakenFromHitsPosPctPerEnduranceCharge = 7336,

		[Description("Physical Damage Reduction Rating Per Endurance Charge")]
		PhysicalDamageReductionRatingPerEnduranceCharge = 7337,

		[Description("Fire Damage Taken Per Minute Per Endurance Charge If You Have Been Hit Recently")]
		FireDamageTakenPerMinutePerEnduranceChargeIfYouHaveBeenHitRecently = 7338,

		[Description("Minimum Added Lightning Damage To Spells Per Power Charge")]
		MinimumAddedLightningDamageToSpellsPerPowerCharge = 7339,

		[Description("Maximum Added Lightning Damage To Spells Per Power Charge")]
		MaximumAddedLightningDamageToSpellsPerPowerCharge = 7340,

		[Description("Additional Spell Block % Per Power Charge")]
		AdditionalSpellBlockPctPerPowerCharge = 7341,

		[Description("Lightning Damage Taken Per Minute Per Power Charge If Have Crit Recently")]
		LightningDamageTakenPerMinutePerPowerChargeIfHaveCritRecently = 7342,

		[Description("Avoid Elemental Damage % Per Frenzy Charge")]
		AvoidElementalDamagePctPerFrenzyCharge = 7343,

		[Description("Life Leech From Attack Damage Permyriad Per Frenzy Charge")]
		LifeLeechFromAttackDamagePermyriadPerFrenzyCharge = 7344,

		[Description("Cold Damage Taken Per Minute Per Frenzy Charge While Moving")]
		ColdDamageTakenPerMinutePerFrenzyChargeWhileMoving = 7345,

		[Description("Raise Spectre Mana Cost +%")]
		RaiseSpectreManaCostPosPct = 7346,

		[Description("Map Packs Have Tentacle Minions")]
		MapPacksHaveTentacleMinions = 7347,

		[Description("Map Elder Influence Spawn Daemon")]
		MapElderInfluenceSpawnDaemon = 7348,

		[Description("Monster Has Oni Goroshi")]
		MonsterHasOniGoroshi = 7349,

		[Description("Skill User Maximum Life")]
		SkillUserMaximumLife = 7350,

		[Description("Local Display Grant Level X Petrification Statue")]
		LocalDisplayGrantLevelXPetrificationStatue = 7351,

		[Description("Chest Display Guarded By Dario")]
		ChestDisplayGuardedByDario = 7352,

		[Description("Base Physical Damage Over Time Taken +%")]
		BasePhysicalDamageOverTimeTakenPosPct = 7353,

		[Description("Ground Spores Art Variation")]
		GroundSporesArtVariation = 7354,

		[Description("Move Daemon Use Random Direction")]
		MoveDaemonUseRandomDirection = 7355,

		[Description("Disable Skill If Weapon Not Bow")]
		DisableSkillIfWeaponNotBow = 7356,

		[Description("Trigger On Skill Use From Chest %")]
		TriggerOnSkillUseFromChestPct = 7357,

		[Description("Thrown Weapon On Return Trigger Skills With Id")]
		ThrownWeaponOnReturnTriggerSkillsWithId = 7358,

		[Description("Thrown Weapon On Return Trigger Id")]
		ThrownWeaponOnReturnTriggerId = 7359,

		[Description("Thrown Weapon On Return Trigger %")]
		ThrownWeaponOnReturnTriggerPct = 7360,

		[Description("Skill Cannot Be Interrupted")]
		SkillCannotBeInterrupted = 7361,

		[Description("Skill Cannot Be Stunned")]
		SkillCannotBeStunned = 7362,

		[Description("Skill Cannot Be Knocked Back")]
		SkillCannotBeKnockedBack = 7363,

		[Description("Is Immobilised By Elder")]
		IsImmobilisedByElder = 7364,

		[Description("Recover % Maximum Life On Mana Flask Use")]
		RecoverPctMaximumLifeOnManaFlaskUse = 7365,

		[Description("Non Instant Mana Recovery From Flasks Also Recovers Life")]
		NonInstantManaRecoveryFromFlasksAlsoRecoversLife = 7366,

		[Description("Spell Damage +% Per 200 Mana Spent Recently")]
		SpellDamagePosPctPer200ManaSpentRecently = 7367,

		[Description("Mana Cost +% Per 200 Mana Spent Recently")]
		ManaCostPosPctPer200ManaSpentRecently = 7368,

		[Description("Virtual Track Mana Spent Recently")]
		VirtualTrackManaSpentRecently = 7369,

		[Description("Total Mana Spent Recently")]
		TotalManaSpentRecently = 7370,

		[Description("Left Ring Is Shaper Item")]
		LeftRingIsShaperItem = 7371,

		[Description("Left Ring Is Elder Item")]
		LeftRingIsElderItem = 7372,

		[Description("Right Ring Is Shaper Item")]
		RightRingIsShaperItem = 7373,

		[Description("Right Ring Is Elder Item")]
		RightRingIsElderItem = 7374,

		[Description("Cannot Be Stunned By Attacks If Other Ring Is Elder Item")]
		CannotBeStunnedByAttacksIfOtherRingIsElderItem = 7375,

		[Description("Cannot Be Stunned By Attacks If Left Ring Is Elder Item")]
		CannotBeStunnedByAttacksIfLeftRingIsElderItem = 7376,

		[Description("Cannot Be Stunned By Attacks If Right Ring Is Elder Item")]
		CannotBeStunnedByAttacksIfRightRingIsElderItem = 7377,

		[Description("Attack Damage +% If Other Ring Is Shaper Item")]
		AttackDamagePosPctIfOtherRingIsShaperItem = 7378,

		[Description("Attack Damage +% If Left Ring Is Shaper Item")]
		AttackDamagePosPctIfLeftRingIsShaperItem = 7379,

		[Description("Attack Damage +% If Right Ring Is Shaper Item")]
		AttackDamagePosPctIfRightRingIsShaperItem = 7380,

		[Description("Spell Damage +% If Other Ring Is Elder Item")]
		SpellDamagePosPctIfOtherRingIsElderItem = 7381,

		[Description("Spell Damage +% If Left Ring Is Elder Item")]
		SpellDamagePosPctIfLeftRingIsElderItem = 7382,

		[Description("Spell Damage +% If Right Ring Is Elder Item")]
		SpellDamagePosPctIfRightRingIsElderItem = 7383,

		[Description("Cannot Be Stunned By Spells If Other Ring Is Shaper Item")]
		CannotBeStunnedBySpellsIfOtherRingIsShaperItem = 7384,

		[Description("Cannot Be Stunned By Spells If Left Ring Is Shaper Item")]
		CannotBeStunnedBySpellsIfLeftRingIsShaperItem = 7385,

		[Description("Cannot Be Stunned By Spells If Right Ring Is Shaper Item")]
		CannotBeStunnedBySpellsIfRightRingIsShaperItem = 7386,

		[Description("Current Siphoning Charges")]
		CurrentSiphoningCharges = 7387,

		[Description("Virtual Maximum Siphoning Charges")]
		VirtualMaximumSiphoningCharges = 7388,

		[Description("Gain Siphoning Charge On Skill Use % Chance")]
		GainSiphoningChargeOnSkillUsePctChance = 7389,

		[Description("Maximum Siphoning Charges Per Elder Or Shaper Item Equipped")]
		MaximumSiphoningChargesPerElderOrShaperItemEquipped = 7390,

		[Description("Attack And Spell Minimum Added Physical Damage Per Siphoning Charge")]
		AttackAndSpellMinimumAddedPhysicalDamagePerSiphoningCharge = 7391,

		[Description("Attack And Spell Maximum Added Physical Damage Per Siphoning Charge")]
		AttackAndSpellMaximumAddedPhysicalDamagePerSiphoningCharge = 7392,

		[Description("Life Leech From Any Damage Permyriad Per Siphoning Charge")]
		LifeLeechFromAnyDamagePermyriadPerSiphoningCharge = 7393,

		[Description("Non Chaos Damage % To Add As Chaos Damage Per Siphoning Charge")]
		NonChaosDamagePctToAddAsChaosDamagePerSiphoningCharge = 7394,

		[Description("Additional Physical Damage Reduction Against Hits % Per Siphoning Charge")]
		AdditionalPhysicalDamageReductionAgainstHitsPctPerSiphoningCharge = 7395,

		[Description("Additional Physical Damage Reduction % Against Hits")]
		AdditionalPhysicalDamageReductionPctAgainstHits = 7396,

		[Description("Armour Differs Against Hits")]
		ArmourDiffersAgainstHits = 7397,

		[Description("Display Estimated Physical Damage Reduction Against Hits %")]
		DisplayEstimatedPhysicalDamageReductionAgainstHitsPct = 7398,

		[Description("Physical Damage Taken Per Minute Per Siphoning Charge If Have Used A Skill Recently")]
		PhysicalDamageTakenPerMinutePerSiphoningChargeIfHaveUsedASkillRecently = 7399,

		[Description("Track Have Used A Skill Recently")]
		TrackHaveUsedASkillRecently = 7400,

		[Description("Have Used A Skill Recently")]
		HaveUsedASkillRecently = 7401,

		[Description("Number Of Equipped Shaper Items")]
		NumberOfEquippedShaperItems = 7402,

		[Description("Virtual Physical Damage Taken Per Minute Per Siphoning Charge")]
		VirtualPhysicalDamageTakenPerMinutePerSiphoningCharge = 7403,

		[Description("Map Force Terrain Feature")]
		MapForceTerrainFeature = 7404,

		[Description("Local Display Trigger Level X Void Shot On Arrow Fire While You Have Void Arrow")]
		LocalDisplayTriggerLevelXVoidShotOnArrowFireWhileYouHaveVoidArrow = 7405,

		[Description("Trigger On Skill Use % If You Have A Void Arrow")]
		TriggerOnSkillUsePctIfYouHaveAVoidArrow = 7406,
		[Description("Current Void Arrows")] CurrentVoidArrows = 7407,
		[Description("Maximum Void Arrows")] MaximumVoidArrows = 7408,

		[Description("Local Display Grant Void Arrow Every X Ms")]
		LocalDisplayGrantVoidArrowEveryXMs = 7409,

		[Description("Local Display Trigger Tentacle Smash On Kill % Chance")]
		LocalDisplayTriggerTentacleSmashOnKillPctChance = 7410,

		[Description("Local Display Trigger Temporal Anomaly When Hit % Chance")]
		LocalDisplayTriggerTemporalAnomalyWhenHitPctChance = 7411,

		[Description("Local Display Trigger Void Sphere On Kill % Chance")]
		LocalDisplayTriggerVoidSphereOnKillPctChance = 7412,
		[Description("Despair Duration +%")] DespairDurationPosPct = 7413,

		[Description("Despair Curse Effect +%")]
		DespairCurseEffectPosPct = 7414,

		[Description("Cast When Hit % Target Self")]
		CastWhenHitPctTargetSelf = 7415,

		[Description("Inca Rock Spawn Chance %")]
		IncaRockSpawnChancePct = 7416,
		[Description("Inca Rock Spawn Limit")] IncaRockSpawnLimit = 7417,

		[Description("Volatile Dead Consume Additional Corpse")]
		VolatileDeadConsumeAdditionalCorpse = 7418,

		[Description("Virtual Chance To Evade Attacks %")]
		VirtualChanceToEvadeAttacksPct = 7419,

		[Description("Projectile Skill Dot Ground Caustic Area Damage Per Minute")]
		ProjectileSkillDotGroundCausticAreaDamagePerMinute = 7420,

		[Description("Cannot Be Stunned By Spells")]
		CannotBeStunnedBySpells = 7421,

		[Description("Cannot Be Stunned By Attacks")]
		CannotBeStunnedByAttacks = 7422,

		[Description("Reflected Physical Damage Taken +% While Affected By Determination")]
		ReflectedPhysicalDamageTakenPosPctWhileAffectedByDetermination = 7423,

		[Description("Virtual Physical Reflect Damage Taken +%")]
		VirtualPhysicalReflectDamageTakenPosPct = 7424,

		[Description("Armour + While Affected By Determination")]
		ArmourPosWhileAffectedByDetermination = 7425,

		[Description("Virtual Blind Enemies When Hit % Chance")]
		VirtualBlindEnemiesWhenHitPctChance = 7426,

		[Description("Blind Enemies When Hit While Affected By Grace % Chance")]
		BlindEnemiesWhenHitWhileAffectedByGracePctChance = 7427,

		[Description("Energy Shield Recovery Rate While Affected By Discipline +%")]
		EnergyShieldRecoveryRateWhileAffectedByDisciplinePosPct = 7428,

		[Description("Fire Damage +% While Affected By Anger")]
		FireDamagePosPctWhileAffectedByAnger = 7429,

		[Description("Critical Strike Multiplier + While Affected By Anger")]
		CriticalStrikeMultiplierPosWhileAffectedByAnger = 7430,

		[Description("Lightning Damage +% While Affected By Wrath")]
		LightningDamagePosPctWhileAffectedByWrath = 7431,

		[Description("Critical Strike Chance +% While Affected By Wrath")]
		CriticalStrikeChancePosPctWhileAffectedByWrath = 7432,

		[Description("Cold Damage +% While Affected By Hatred")]
		ColdDamagePosPctWhileAffectedByHatred = 7433,

		[Description("Flask Life Recovery +% While Affected By Vitality")]
		FlaskLifeRecoveryPosPctWhileAffectedByVitality = 7434,

		[Description("Mana Recovery Rate +% While Affected By Clarity")]
		ManaRecoveryRatePosPctWhileAffectedByClarity = 7435,

		[Description("Virtual Damage Taken Goes To Mana Over 4 Seconds %")]
		VirtualDamageTakenGoesToManaOver4SecondsPct = 7436,

		[Description("Damage Taken Goes To Mana Over 4 Seconds % While Affected By Clarity")]
		DamageTakenGoesToManaOver4SecondsPctWhileAffectedByClarity = 7437,

		[Description("Virtual Debuff Time Passed +%")]
		VirtualDebuffTimePassedPosPct = 7438,

		[Description("Debuff Time Passed -% While Affected By Haste")]
		DebuffTimePassedNegPctWhileAffectedByHaste = 7439,

		[Description("Movement Skills Cooldown Speed +% While Affected By Haste")]
		MovementSkillsCooldownSpeedPosPctWhileAffectedByHaste = 7440,

		[Description("Fire Reflect Damage Taken +%")]
		FireReflectDamageTakenPosPct = 7441,

		[Description("Lightning Reflect Damage Taken +%")]
		LightningReflectDamageTakenPosPct = 7442,

		[Description("Cold Reflect Damage Taken +%")]
		ColdReflectDamageTakenPosPct = 7443,

		[Description("Fire Reflect Damage Taken +% While Affected By Purity Of Fire")]
		FireReflectDamageTakenPosPctWhileAffectedByPurityOfFire = 7444,

		[Description("Lightning Reflect Damage Taken +% While Affected By Purity Of Lightning")]
		LightningReflectDamageTakenPosPctWhileAffectedByPurityOfLightning = 7445,

		[Description("Cold Reflect Damage Taken +% While Affected By Purity Of Ice")]
		ColdReflectDamageTakenPosPctWhileAffectedByPurityOfIce = 7446,

		[Description("Elemental Reflect Damage Taken +% While Affected By Purity Of Elements")]
		ElementalReflectDamageTakenPosPctWhileAffectedByPurityOfElements = 7447,

		[Description("Chaos Damage Resistance % While Affected By Purity Of Elements")]
		ChaosDamageResistancePctWhileAffectedByPurityOfElements = 7448,

		[Description("Intimidating Cry Attack Speed +% Per 100 Enemies")]
		IntimidatingCryAttackSpeedPosPctPer100Enemies = 7449,

		[Description("Local Display Grants Skill Intimidating Cry Level")]
		LocalDisplayGrantsSkillIntimidatingCryLevel = 7450,

		[Description("Map Spawn Bestiary Encounters")]
		MapSpawnBestiaryEncounters = 7451,

		[Description("Map Force Bestiary Encounter")]
		MapForceBestiaryEncounter = 7452,

		[Description("Local Display Grants Skill Cat Aspect Level")]
		LocalDisplayGrantsSkillCatAspectLevel = 7453,

		[Description("Local Display Grants Skill Bird Aspect Level")]
		LocalDisplayGrantsSkillBirdAspectLevel = 7454,
		[Description("Avoid Damage %")] AvoidDamagePct = 7455,

		[Description("Minion Chance To Deal Double Damage %")]
		MinionChanceToDealDoubleDamagePct = 7456,

		[Description("Local Display Grants Skill Spider Aspect Level")]
		LocalDisplayGrantsSkillSpiderAspectLevel = 7457,
		[Description("Damage +% Per 10 Dex")] DamagePosPctPer10Dex = 7458,

		[Description("Life Regeneration Per Minute While Ignited")]
		LifeRegenerationPerMinuteWhileIgnited = 7459,

		[Description("Chance To Deal Double Damage % Per 500 Strength")]
		ChanceToDealDoubleDamagePctPer500Strength = 7460,

		[Description("Virtual Chance To Deal Double Damage %")]
		VirtualChanceToDealDoubleDamagePct = 7461,

		[Description("Track Have Killed Cursed Enemy Recently")]
		TrackHaveKilledCursedEnemyRecently = 7462,

		[Description("Have Killed Cursed Enemy Recently")]
		HaveKilledCursedEnemyRecently = 7463,

		[Description("Elemental Damage +% If Cursed Enemy Killed Recently")]
		ElementalDamagePosPctIfCursedEnemyKilledRecently = 7464,

		[Description("Local Display Grants Skill Crab Aspect Level")]
		LocalDisplayGrantsSkillCrabAspectLevel = 7465,

		[Description("Current Crab Aspect Stacks")]
		CurrentCrabAspectStacks = 7466,

		[Description("Max Crab Aspect Stacks")]
		MaxCrabAspectStacks = 7467,

		[Description("Physical Damage Reduction % Per Crab Aspect Stack")]
		PhysicalDamageReductionPctPerCrabAspectStack = 7468,

		[Description("Raging Spirits Refresh Duration When They Kill Ignited Enemy")]
		RagingSpiritsRefreshDurationWhenTheyKillIgnitedEnemy = 7469,

		[Description("Add Frenzy Charge Every 50 Rampage Stacks")]
		AddFrenzyChargeEvery50RampageStacks = 7470,

		[Description("Area Of Effect +% Per 25 Rampage Stacks")]
		AreaOfEffectPosPctPer25RampageStacks = 7471,

		[Description("Traps Do Not Explode On Timeout")]
		TrapsDoNotExplodeOnTimeout = 7472,

		[Description("Cannot Be Ignited While Flame Golem Summoned")]
		CannotBeIgnitedWhileFlameGolemSummoned = 7473,

		[Description("Cannot Be Shocked While Lightning Golem Summoned")]
		CannotBeShockedWhileLightningGolemSummoned = 7474,

		[Description("Cannot Be Chilled Or Frozen While Ice Golem Summoned")]
		CannotBeChilledOrFrozenWhileIceGolemSummoned = 7475,
		[Description("Cannot Be Chilled")] CannotBeChilled = 7476,

		[Description("Attach Vines To Defender On Hit % Chance")]
		AttachVinesToDefenderOnHitPctChance = 7477,
		[Description("Unaffected By Curses")] UnaffectedByCurses = 7478,
		[Description("Chill Minimum Slow %")] ChillMinimumSlowPct = 7479,

		[Description("Shock Minimum Damage Taken Increase %")]
		ShockMinimumDamageTakenIncreasePct = 7480,
		[Description("Has Avians Flight")] HasAviansFlight = 7481,
		[Description("Has Avians Might")] HasAviansMight = 7482,

		[Description("Life Regeneration Per Minute While You Have Avians Flight")]
		LifeRegenerationPerMinuteWhileYouHaveAviansFlight = 7483,

		[Description("Mana Regeneration Rate Per Minute While You Have Avians Flight")]
		ManaRegenerationRatePerMinuteWhileYouHaveAviansFlight = 7484,

		[Description("Avians Flight Duration Ms +")]
		AviansFlightDurationMsPos = 7485,

		[Description("Avians Might Duration Ms +")]
		AviansMightDurationMsPos = 7486,

		[Description("Minimum Added Cold Damage While You Have Avians Might")]
		MinimumAddedColdDamageWhileYouHaveAviansMight = 7487,

		[Description("Maximum Added Cold Damage While You Have Avians Might")]
		MaximumAddedColdDamageWhileYouHaveAviansMight = 7488,

		[Description("Minimum Added Lightning Damage While You Have Avians Might")]
		MinimumAddedLightningDamageWhileYouHaveAviansMight = 7489,

		[Description("Maximum Added Lightning Damage While You Have Avians Might")]
		MaximumAddedLightningDamageWhileYouHaveAviansMight = 7490,

		[Description("Aspect Of The Avian Grants Avians Might And Avians Flight To Nearby Allies")]
		AspectOfTheAvianGrantsAviansMightAndAviansFlightToNearbyAllies = 7491,

		[Description("Aspect Of The Avian Buff Effect +%")]
		AspectOfTheAvianBuffEffectPosPct = 7492,

		[Description("Retaliation Godmode Ghost Duration Ms")]
		RetaliationGodmodeGhostDurationMs = 7493,
		[Description("Has Cats Stealth")] HasCatsStealth = 7494,

		[Description("Local Display Trigger Level 20 Tornado When You Gain Avians Flight Or Avians Might %")]
		LocalDisplayTriggerLevel20TornadoWhenYouGainAviansFlightOrAviansMightPct = 7495,

		[Description("Cast On Gain Avians Flight Or Avians Might %")]
		CastOnGainAviansFlightOrAviansMightPct = 7496,

		[Description("Gain Phasing While You Have Cats Stealth")]
		GainPhasingWhileYouHaveCatsStealth = 7497,

		[Description("Cats Stealth Duration Ms +")]
		CatsStealthDurationMsPos = 7498,

		[Description("Cat Aspect Reserves No Mana")]
		CatAspectReservesNoMana = 7499,

		[Description("Gain Maximum Frenzy And Power Charges When You Gain Cats Stealth")]
		GainMaximumFrenzyAndPowerChargesWhenYouGainCatsStealth = 7500,

		[Description("Override Off Hand Base Critical Strike Chance To 5%")]
		OverrideOffHandBaseCriticalStrikeChanceTo5Pct = 7501,

		[Description("Cannot Be Stunned If You Have 10 Or More Crab Charges")]
		CannotBeStunnedIfYouHave10OrMoreCrabCharges = 7502,

		[Description("Number Of Crab Charges Lost Recently")]
		NumberOfCrabChargesLostRecently = 7503,

		[Description("Cannot Lose Crab Charges If You Have Lost Crab Charges Recently")]
		CannotLoseCrabChargesIfYouHaveLostCrabChargesRecently = 7504,

		[Description("Do Not Lose Crab Charges When Hit")]
		DoNotLoseCrabChargesWhenHit = 7505,

		[Description("Damage +% Per Crab Charge")]
		DamagePosPctPerCrabCharge = 7506,

		[Description("Chance To Gain Max Crab Stacks When You Would Gain A Crab Stack %")]
		ChanceToGainMaxCrabStacksWhenYouWouldGainACrabStackPct = 7507,

		[Description("Additional Block % While You Have At Least 5 Crab Charges")]
		AdditionalBlockPctWhileYouHaveAtLeast5CrabCharges = 7508,

		[Description("Additional Block % While You Have At Least 10 Crab Charges")]
		AdditionalBlockPctWhileYouHaveAtLeast10CrabCharges = 7509,

		[Description("Number Of Crab Charges Lost When Hit")]
		NumberOfCrabChargesLostWhenHit = 7510,

		[Description("Life And Mana Leech From Attack Damage Permyriad If Killed Recently")]
		LifeAndManaLeechFromAttackDamagePermyriadIfKilledRecently = 7511,

		[Description("Monster Mortar Number Of Forks")]
		MonsterMortarNumberOfForks = 7512,

		[Description("Local Display Trigger Level X Intimidating Cry When You Lose Cats Stealth")]
		LocalDisplayTriggerLevelXIntimidatingCryWhenYouLoseCatsStealth = 7513,

		[Description("Cast On Lose Cats Stealth")]
		CastOnLoseCatsStealth = 7514,

		[Description("Movement Speed +% While You Have Cats Stealth")]
		MovementSpeedPosPctWhileYouHaveCatsStealth = 7515,

		[Description("Minimum Added Fire Damage To Attacks Per 10 Strength")]
		MinimumAddedFireDamageToAttacksPer10Strength = 7516,

		[Description("Maximum Added Fire Damage To Attacks Per 10 Strength")]
		MaximumAddedFireDamageToAttacksPer10Strength = 7517,

		[Description("Minimum Added Cold Damage To Attacks Per 10 Dexterity")]
		MinimumAddedColdDamageToAttacksPer10Dexterity = 7518,

		[Description("Maximum Added Cold Damage To Attacks Per 10 Dexterity")]
		MaximumAddedColdDamageToAttacksPer10Dexterity = 7519,

		[Description("Minimum Added Lightning Damage To Attacks Per 10 Intelligence")]
		MinimumAddedLightningDamageToAttacksPer10Intelligence = 7520,

		[Description("Maximum Added Lightning Damage To Attacks Per 10 Intelligence")]
		MaximumAddedLightningDamageToAttacksPer10Intelligence = 7521,
		[Description("Gain Rage On Kill")] GainRageOnKill = 7522,
		[Description("Maximum Rage")] MaximumRage = 7523,
		[Description("Current Rage")] CurrentRage = 7524,

		[Description("Attack Damage +% From Rage")]
		AttackDamagePosPctFromRage = 7525,

		[Description("Attack Speed +% From Rage")]
		AttackSpeedPosPctFromRage = 7526,

		[Description("Movement Speed +% From Rage")]
		MovementSpeedPosPctFromRage = 7527,

		[Description("Life Loss % Per Minute From Rage")]
		LifeLossPctPerMinuteFromRage = 7528,

		[Description("Gain Rage When You Use A Warcry")]
		GainRageWhenYouUseAWarcry = 7529,
		[Description("Rage Effects Doubled")] RageEffectsDoubled = 7530,

		[Description("Virtual Life Degeneration Per Minute")]
		VirtualLifeDegenerationPerMinute = 7531,

		[Description("Gain Rage On Hitting Rare Unique Enemy %")]
		GainRageOnHittingRareUniqueEnemyPct = 7532,

		[Description("Spectral Shield Throw Secondary Projectiles Pierce")]
		SpectralShieldThrowSecondaryProjectilesPierce = 7533,

		[Description("Herald Skills Mana Reservation +%")]
		HeraldSkillsManaReservationPosPct = 7534,

		[Description("Herald Effect On Self +%")]
		HeraldEffectOnSelfPosPct = 7535,

		[Description("Affected By Herald Of Ash")]
		AffectedByHeraldOfAsh = 7536,

		[Description("Affected By Herald Of Ice")]
		AffectedByHeraldOfIce = 7537,

		[Description("Affected By Herald Of Thunder")]
		AffectedByHeraldOfThunder = 7538,

		[Description("Damage Penetrates % Fire Resistance While Affected By Herald Of Ash")]
		DamagePenetratesPctFireResistanceWhileAffectedByHeraldOfAsh = 7539,

		[Description("Damage Penetrates % Cold Resistance While Affected By Herald Of Ice")]
		DamagePenetratesPctColdResistanceWhileAffectedByHeraldOfIce = 7540,

		[Description("Damage Penetrates % Lightning Resistance While Affected By Herald Of Thunder")]
		DamagePenetratesPctLightningResistanceWhileAffectedByHeraldOfThunder = 7541,

		[Description("Cannot Be Stunned With 25 Rage")]
		CannotBeStunnedWith25Rage = 7542,

		[Description("Monster Rarity Damage +% Final")]
		MonsterRarityDamagePosPctFinal = 7543,

		[Description("Counterattacks Deal Double Damage")]
		CounterattacksDealDoubleDamage = 7544,

		[Description("Owner Stacking Energy Shield Regeneration Rate Per Minute % On Kill For 4 Seconds")]
		OwnerStackingEnergyShieldRegenerationRatePerMinutePctOnKillFor4Seconds = 7545,

		[Description("Chance To Gain Random Standard Charge On Hit %")]
		ChanceToGainRandomStandardChargeOnHitPct = 7546,

		[Description("Blink And Mirror Arrow Cooldown Speed +%")]
		BlinkAndMirrorArrowCooldownSpeedPosPct = 7547,

		[Description("Elementalist Elemental Damage +% For 5 Seconds")]
		ElementalistElementalDamagePosPctFor5Seconds = 7548,

		[Description("Elementalist Area Of Effect +% For 5 Seconds")]
		ElementalistAreaOfEffectPosPctFor5Seconds = 7549,

		[Description("Immune To Elemental Ailments While On Consecrated Ground")]
		ImmuneToElementalAilmentsWhileOnConsecratedGround = 7550,

		[Description("Create Consecrated Ground On Hit % Vs Rare Or Unique Enemy")]
		CreateConsecratedGroundOnHitPctVsRareOrUniqueEnemy = 7551,

		[Description("Cannot Be Stunned While Fortified")]
		CannotBeStunnedWhileFortified = 7552,

		[Description("Armour And Evasion Rating + While Fortified")]
		ArmourAndEvasionRatingPosWhileFortified = 7553,

		[Description("Global Chance To Blind On Hit % Vs Bleeding Enemies")]
		GlobalChanceToBlindOnHitPctVsBleedingEnemies = 7554,

		[Description("Cannot Be Stunned By Blocked Hits")]
		CannotBeStunnedByBlockedHits = 7555,

		[Description("Gratuitous Violence Bleeding Damage +% Final")]
		GratuitousViolenceBleedingDamagePosPctFinal = 7556,

		[Description("Chance To Gain Onslaught On Hit % Vs Rare Or Unique Enemy")]
		ChanceToGainOnslaughtOnHitPctVsRareOrUniqueEnemy = 7557,

		[Description("Unaffected By Temporal Chains")]
		UnaffectedByTemporalChains = 7558,

		[Description("Apply Covered In Ash To Attacker On Hit % Vs Rare Or Unique Enemy")]
		ApplyCoveredInAshToAttackerOnHitPctVsRareOrUniqueEnemy = 7559,

		[Description("Gain Endurance Charge Per Second If Have Been Hit Recently")]
		GainEnduranceChargePerSecondIfHaveBeenHitRecently = 7560,

		[Description("Stun Duration +% Per Endurance Charge")]
		StunDurationPosPctPerEnduranceCharge = 7561,

		[Description("Chance To Gain Endurance Charge On Stun %")]
		ChanceToGainEnduranceChargeOnStunPct = 7562,

		[Description("Totem Maximum Energy Shield")]
		TotemMaximumEnergyShield = 7563,

		[Description("You And Totem Life Regeneration Rate Per Minute % Per Active Totem")]
		YouAndTotemLifeRegenerationRatePerMinutePctPerActiveTotem = 7564,

		[Description("Mana Regeneration Rate Per Minute % Per Active Totem")]
		ManaRegenerationRatePerMinutePctPerActiveTotem = 7565,

		[Description("Fire Damage +% Per Endurance Charge")]
		FireDamagePosPctPerEnduranceCharge = 7566,

		[Description("Track Have Taken Fire Damage From A Hit Recently")]
		TrackHaveTakenFireDamageFromAHitRecently = 7567,

		[Description("Have Taken Fire Damage From A Hit Recently")]
		HaveTakenFireDamageFromAHitRecently = 7568,

		[Description("Life Regeneration Rate Per Minute % If Have Taken Fire Damage From A Hit Recently")]
		LifeRegenerationRatePerMinutePctIfHaveTakenFireDamageFromAHitRecently = 7569,

		[Description("Local Display Every 10 Seconds Physical Damage % To Add As Fire For 3 Seconds")]
		LocalDisplayEvery10SecondsPhysicalDamagePctToAddAsFireFor3Seconds = 7570,

		[Description("Critical Strike Damage Cannot Be Reflected")]
		CriticalStrikeDamageCannotBeReflected = 7571,

		[Description("Damage +% If Only One Enemy Nearby")]
		DamagePosPctIfOnlyOneEnemyNearby = 7572,

		[Description("Self Take No Extra Damage From Critical Strikes If Only One Nearby Enemy")]
		SelfTakeNoExtraDamageFromCriticalStrikesIfOnlyOneNearbyEnemy = 7573,

		[Description("Poison Duration +% Per Poison Applied Recently")]
		PoisonDurationPosPctPerPoisonAppliedRecently = 7574,

		[Description("Additional Critical Strike Chance Permyriad Per Poison On Enemy Up To 2%")]
		AdditionalCriticalStrikeChancePermyriadPerPoisonOnEnemyUpTo2Pct = 7575,

		[Description("Physical Damage % To Add As Chaos Vs Poisoned Enemies")]
		PhysicalDamagePctToAddAsChaosVsPoisonedEnemies = 7576,

		[Description("Recover Permyriad Maximum Life Per Poison On Enemy On Kill")]
		RecoverPermyriadMaximumLifePerPoisonOnEnemyOnKill = 7577,

		[Description("Zombie Caustic Cloud On Death Maximum Life Per Minute To Deal As Chaos Damage %")]
		ZombieCausticCloudOnDeathMaximumLifePerMinuteToDealAsChaosDamagePct = 7578,

		[Description("Self Offering Effect +%")]
		SelfOfferingEffectPosPct = 7579,

		[Description("% Chance To Gain 25% Non Chaos Damage To Add As Chaos Damage")]
		Pctchancetogain25Pctnonchaosdamagetoaddaschaosdamage = 7580,

		[Description("% Chance To Gain 50% Non Chaos Damage To Add As Chaos Damage")]
		Pctchancetogain50Pctnonchaosdamagetoaddaschaosdamage = 7581,

		[Description("% Chance To Gain 100% Non Chaos Damage To Add As Chaos Damage")]
		Pctchancetogain100Pctnonchaosdamagetoaddaschaosdamage = 7582,

		[Description("Damage +% Per Active Golem")]
		DamagePosPctPerActiveGolem = 7583,

		[Description("Virtual Total Number Of Active Golems")]
		VirtualTotalNumberOfActiveGolems = 7584,
		[Description("Unaffected By Ignite")] UnaffectedByIgnite = 7585,

		[Description("Gain Accuracy Rating Equal To Strength")]
		GainAccuracyRatingEqualToStrength = 7586,

		[Description("Accuracy Rating +% If Have Crit In Past 8 Seconds")]
		AccuracyRatingPosPctIfHaveCritInPast8Seconds = 7587,

		[Description("Damage +% If Have Crit In Past 8 Seconds")]
		DamagePosPctIfHaveCritInPast8Seconds = 7588,

		[Description("Track Have Crit In Past 8 Seconds")]
		TrackHaveCritInPast8Seconds = 7589,

		[Description("Have Crit In Past 8 Seconds")]
		HaveCritInPast8Seconds = 7590,

		[Description("Virtual Accuracy Rating +%")]
		VirtualAccuracyRatingPosPct = 7591,

		[Description("Hierophant Mana Reservation +% Final")]
		HierophantManaReservationPosPctFinal = 7592,

		[Description("Elemental Penetration % If You Have A Power Charge")]
		ElementalPenetrationPctIfYouHaveAPowerCharge = 7593,

		[Description("Elemental Damage Taken +% If You Have An Endurance Charge")]
		ElementalDamageTakenPosPctIfYouHaveAnEnduranceCharge = 7594,

		[Description("Track Number Of Traps Triggered Recently")]
		TrackNumberOfTrapsTriggeredRecently = 7595,

		[Description("Number Of Traps Triggered Recently")]
		NumberOfTrapsTriggeredRecently = 7596,

		[Description("Track Number Of Mines Detonated Recently")]
		TrackNumberOfMinesDetonatedRecently = 7597,

		[Description("Number Of Mines Detonated Recently")]
		NumberOfMinesDetonatedRecently = 7598,

		[Description("Life Regeneration Rate Per Minute % Per Trap Triggered Recently Up To 20%")]
		LifeRegenerationRatePerMinutePctPerTrapTriggeredRecentlyUpTo20Pct = 7599,

		[Description("Life Regeneration Rate Per Minute % Per Mine Detonated Recently Up To 20%")]
		LifeRegenerationRatePerMinutePctPerMineDetonatedRecentlyUpTo20Pct = 7600,

		[Description("You And Allies Additional Block % If Have Attacked Recently")]
		YouAndAlliesAdditionalBlockPctIfHaveAttackedRecently = 7601,

		[Description("You And Allies Additional Spell Block % If Cast Spell Recently")]
		YouAndAlliesAdditionalSpellBlockPctIfCastSpellRecently = 7602,

		[Description("Movement Speed +% While You Have Energy Shield")]
		MovementSpeedPosPctWhileYouHaveEnergyShield = 7603,

		[Description("Chance To Dodge Attacks And Spells % While You Have Energy Shield")]
		ChanceToDodgeAttacksAndSpellsPctWhileYouHaveEnergyShield = 7604,

		[Description("Trickster Damage Over Time +% Final")]
		TricksterDamageOverTimePosPctFinal = 7605,

		[Description("Object Cannot Taunt Enemies")]
		ObjectCannotTauntEnemies = 7606,

		[Description("Cold Beam Retaliation Chilled Ground In Beam Duration Ms")]
		ColdBeamRetaliationChilledGroundInBeamDurationMs = 7607,

		[Description("Cold Beam Retaliation Chilled Ground In Area Duration Ms")]
		ColdBeamRetaliationChilledGroundInAreaDurationMs = 7608,

		[Description("Enemy Extra Damage Rolls When On Full Life")]
		EnemyExtraDamageRollsWhenOnFullLife = 7609,

		[Description("Burning Damage +% Per Non Shocked Enemy Shocked Recently")]
		BurningDamagePosPctPerNonShockedEnemyShockedRecently = 7610,

		[Description("Global Minimum Added Lightning Damage Vs Ignited Enemies")]
		GlobalMinimumAddedLightningDamageVsIgnitedEnemies = 7611,

		[Description("Global Maximum Added Lightning Damage Vs Ignited Enemies")]
		GlobalMaximumAddedLightningDamageVsIgnitedEnemies = 7612,

		[Description("Lightning Damage Can Ignite")]
		LightningDamageCanIgnite = 7613,

		[Description("Minimum Added Spell Fire Damage While No Life Is Reserved")]
		MinimumAddedSpellFireDamageWhileNoLifeIsReserved = 7614,

		[Description("Maximum Added Spell Fire Damage While No Life Is Reserved")]
		MaximumAddedSpellFireDamageWhileNoLifeIsReserved = 7615,

		[Description("Minimum Added Spell Cold Damage While No Life Is Reserved")]
		MinimumAddedSpellColdDamageWhileNoLifeIsReserved = 7616,

		[Description("Maximum Added Spell Cold Damage While No Life Is Reserved")]
		MaximumAddedSpellColdDamageWhileNoLifeIsReserved = 7617,

		[Description("Minimum Added Spell Lightning Damage While No Life Is Reserved")]
		MinimumAddedSpellLightningDamageWhileNoLifeIsReserved = 7618,

		[Description("Maximum Added Spell Lightning Damage While No Life Is Reserved")]
		MaximumAddedSpellLightningDamageWhileNoLifeIsReserved = 7619,

		[Description("Projectile Attack Damage +% With At Least 200 Dex")]
		ProjectileAttackDamagePosPctWithAtLeast200Dex = 7620,

		[Description("Critical Strike Chance +% With At Least 200 Int")]
		CriticalStrikeChancePosPctWithAtLeast200Int = 7621,

		[Description("Virtual Keystone Crimson Dance")]
		VirtualKeystoneCrimsonDance = 7622,

		[Description("Keystone Crimson Dance")]
		KeystoneCrimsonDance = 7623,

		[Description("Gain Crimson Dance If Have Dealt Critical Strike Recently")]
		GainCrimsonDanceIfHaveDealtCriticalStrikeRecently = 7624,

		[Description("Gain Crimson Dance While You Have Cat Stealth")]
		GainCrimsonDanceWhileYouHaveCatStealth = 7625,

		[Description("Virtual Bleeding Stacks Up To X Times")]
		VirtualBleedingStacksUpToXTimes = 7626,

		[Description("Gain Onslaught While On Low Life")]
		GainOnslaughtWhileOnLowLife = 7627,

		[Description("Hits Ignore Enemy Fire Resistance While You Are Ignited")]
		HitsIgnoreEnemyFireResistanceWhileYouAreIgnited = 7628,

		[Description("Virtual Hits Ignore Enemy Fire Resistance")]
		VirtualHitsIgnoreEnemyFireResistance = 7629,

		[Description("Override Maximum Damage Resistance %")]
		OverrideMaximumDamageResistancePct = 7630,

		[Description("Local Display Trigger Commandment Of Inferno On Crit %")]
		LocalDisplayTriggerCommandmentOfInfernoOnCritPct = 7631,

		[Description("Local Display Trigger Level X Icicle Nova On Kill Vs Frozen Enemy")]
		LocalDisplayTriggerLevelXIcicleNovaOnKillVsFrozenEnemy = 7632,

		[Description("Trigger On Kill Vs Frozen Enemy %")]
		TriggerOnKillVsFrozenEnemyPct = 7633,

		[Description("Attacks Bleed On Hit While You Have Cat Stealth")]
		AttacksBleedOnHitWhileYouHaveCatStealth = 7634,

		[Description("Hit And Ailment Damage +% Vs Bleeding Enemies")]
		HitAndAilmentDamagePosPctVsBleedingEnemies = 7635,

		[Description("Base Ailment Damage +%")]
		BaseAilmentDamagePosPct = 7636,

		[Description("Accuracy Rating Vs Bleeding Enemies")]
		AccuracyRatingVsBleedingEnemies = 7637,

		[Description("Gain % Total Phys Damage Prevented In The Past 10 Sec As Life Regen Per Sec")]
		GainPctTotalPhysDamagePreventedInThePast10SecAsLifeRegenPerSec = 7638,

		[Description("Total Armour Of Animated Guardians Items")]
		TotalArmourOfAnimatedGuardiansItems = 7639,

		[Description("Total Evasion Rating Of Animated Guardians Items")]
		TotalEvasionRatingOfAnimatedGuardiansItems = 7640,

		[Description("Total Maximum Energy Shield Of Animated Guardians Items")]
		TotalMaximumEnergyShieldOfAnimatedGuardiansItems = 7641,

		[Description("Animated Weapon Armour")]
		AnimatedWeaponArmour = 7642,

		[Description("Animated Weapon Evasion Rating")]
		AnimatedWeaponEvasionRating = 7643,

		[Description("Aniamted Weapon Maximum Energy Shield")]
		AniamtedWeaponMaximumEnergyShield = 7644,

		[Description("Defences From Animated Guardians Items Apply To Animated Weapon")]
		DefencesFromAnimatedGuardiansItemsApplyToAnimatedWeapon = 7645,

		[Description("Fire Projectile Retaliation Skill Visual Scale +% When Hit While Charging")]
		FireProjectileRetaliationSkillVisualScalePosPctWhenHitWhileCharging = 7646,

		[Description("Fire Projectile Retaliation Area Of Effect +% When Hit While Charging")]
		FireProjectileRetaliationAreaOfEffectPosPctWhenHitWhileCharging = 7647,

		[Description("Fire Projectile Retaliation Projectile Speed And Damage +% When Hit While Charging")]
		FireProjectileRetaliationProjectileSpeedAndDamagePosPctWhenHitWhileCharging = 7648,
		[Description("Gained Rage Recently")] GainedRageRecently = 7649,

		[Description("Local Display Trigger Level 20 Animate Guardian Weapon On Guardian Kill % Chance")]
		LocalDisplayTriggerLevel20AnimateGuardianWeaponOnGuardianKillPctChance = 7650,

		[Description("Chance To Trigger On Animate Guardian Kill %")]
		ChanceToTriggerOnAnimateGuardianKillPct = 7651,

		[Description("Animate Guardian And Weapon Track On Kill")]
		AnimateGuardianAndWeaponTrackOnKill = 7652,

		[Description("Local Display Trigger Level 20 Animate Guardian Weapon On Weapon Kill % Chance")]
		LocalDisplayTriggerLevel20AnimateGuardianWeaponOnWeaponKillPctChance = 7653,

		[Description("Chance To Trigger On Animate Weapon Kill %")]
		ChanceToTriggerOnAnimateWeaponKillPct = 7654,

		[Description("You Cannot Have Non Animated Minions")]
		YouCannotHaveNonAnimatedMinions = 7655,

		[Description("Animate Guardian Damage +% Per Animated Weapon")]
		AnimateGuardianDamagePosPctPerAnimatedWeapon = 7656,

		[Description("Animated Minions Melee Splash")]
		AnimatedMinionsMeleeSplash = 7657,

		[Description("Grant Animated Minion Melee Splash Damage +% Final For Splash")]
		GrantAnimatedMinionMeleeSplashDamagePosPctFinalForSplash = 7658,

		[Description("Animated Minion Melee Splash Damage +% Final For Splash")]
		AnimatedMinionMeleeSplashDamagePosPctFinalForSplash = 7659,

		[Description("Animated Minion Melee Splash Damage +% Final")]
		AnimatedMinionMeleeSplashDamagePosPctFinal = 7660,

		[Description("Number Of Active Animated Armour")]
		NumberOfActiveAnimatedArmour = 7661,

		[Description("Geometry Attack Use Orientation Direction")]
		GeometryAttackUseOrientationDirection = 7662,

		[Description("Virtual Elemental Reflect Damage Taken +%")]
		VirtualElementalReflectDamageTakenPosPct = 7663,

		[Description("Additional Critical Strike Chance Permyriad While Affected By Cat Aspect")]
		AdditionalCriticalStrikeChancePermyriadWhileAffectedByCatAspect = 7664,

		[Description("Virtual % Chance To Blind On Critical Strike")]
		VirtualPctChanceToBlindOnCriticalStrike = 7665,

		[Description("% Chance To Blind On Critical Strike While You Have Cats Stealth")]
		Pctchancetoblindoncriticalstrikewhileyouhavecatsstealth = 7666,
		[Description("Has Cat Aspect")] HasCatAspect = 7667,

		[Description("Hit And Ailment Damage +% Vs Blinded Enemies")]
		HitAndAilmentDamagePosPctVsBlindedEnemies = 7668,
		[Description("Has Adrenaline")] HasAdrenaline = 7669,

		[Description("Gain Adrenaline For X Seconds On Low Life Unless You Have Adrenaline")]
		GainAdrenalineForXSecondsOnLowLifeUnlessYouHaveAdrenaline = 7670,

		[Description("Remove Ailments And Burning On Gaining Adrenaline")]
		RemoveAilmentsAndBurningOnGainingAdrenaline = 7671,

		[Description("Attack Ailment Damage +% While Wielding Staff")]
		AttackAilmentDamagePosPctWhileWieldingStaff = 7672,

		[Description("Attack Ailment Damage +% While Wielding Wand")]
		AttackAilmentDamagePosPctWhileWieldingWand = 7673,

		[Description("Enemies Taunted By You Cannot Evade Attacks")]
		EnemiesTauntedByYouCannotEvadeAttacks = 7674,

		[Description("Spider Aspect Web Interval Ms")]
		SpiderAspectWebIntervalMs = 7675,

		[Description("Spider Aspect Max Web Count")]
		SpiderAspectMaxWebCount = 7676,

		[Description("Spider Aspect Debuff Duration +%")]
		SpiderAspectDebuffDurationPosPct = 7677,

		[Description("Energy Shield Gain When You Hit Enemy Affected By Spiders Web")]
		EnergyShieldGainWhenYouHitEnemyAffectedBySpidersWeb = 7678,

		[Description("Chill Effect Is Reversed")]
		ChillEffectIsReversed = 7679,
		[Description("Virtual On Low Life")] VirtualOnLowLife = 7680,

		[Description("You Count As Low Life While Not On Full Life")]
		YouCountAsLowLifeWhileNotOnFullLife = 7681,

		[Description("Mana Cost +% For Trap And Mine Skills")]
		ManaCostPosPctForTrapAndMineSkills = 7682,

		[Description("Gain Arcane Surge On Spell Hit By You Or Your Totems")]
		GainArcaneSurgeOnSpellHitByYouOrYourTotems = 7683,

		[Description("Spell Damage +% While You Have Arcane Surge")]
		SpellDamagePosPctWhileYouHaveArcaneSurge = 7684,

		[Description("Area Of Effect +% While You Have Arcane Surge")]
		AreaOfEffectPosPctWhileYouHaveArcaneSurge = 7685,

		[Description("Immune To Elemental Ailments While You Have Arcane Surge")]
		ImmuneToElementalAilmentsWhileYouHaveArcaneSurge = 7686,

		[Description("Chance To Gain Onslaught On Kill For 10 Seconds %")]
		ChanceToGainOnslaughtOnKillFor10SecondsPct = 7687,

		[Description("Curse On Hit Level Poachers Mark Bypass Hexproof")]
		CurseOnHitLevelPoachersMarkBypassHexproof = 7688,

		[Description("You Have No Armour Or Energy Shield")]
		YouHaveNoArmourOrEnergyShield = 7689,

		[Description("Chance To Trigger Socketed Spell On Bow Attack %")]
		ChanceToTriggerSocketedSpellOnBowAttackPct = 7690,

		[Description("Culling Strike On Enemies Affected By Poachers Mark")]
		CullingStrikeOnEnemiesAffectedByPoachersMark = 7691,

		[Description("Self Physical Damage On Movement Skill Use")]
		SelfPhysicalDamageOnMovementSkillUse = 7692,

		[Description("Grant Tailwind To Nearby Allies If Used Skill Recently")]
		GrantTailwindToNearbyAlliesIfUsedSkillRecently = 7693,

		[Description("Evasion Rating + While You Have Tailwind")]
		EvasionRatingPosWhileYouHaveTailwind = 7694,

		[Description("Tailwind Effect On Self +%")]
		TailwindEffectOnSelfPosPct = 7695,

		[Description("Enemies You Curse Have Malediction")]
		EnemiesYouCurseHaveMalediction = 7696,
		[Description("Has Arcane Surge")] HasArcaneSurge = 7697,

		[Description("Virtual Light Radius +%")]
		VirtualLightRadiusPosPct = 7698,

		[Description("Light Radius Increases Apply To Area Of Effect")]
		LightRadiusIncreasesApplyToAreaOfEffect = 7699,

		[Description("Local Display Trigger Level X Blinding Aura Skill On Equip")]
		LocalDisplayTriggerLevelXBlindingAuraSkillOnEquip = 7700,

		[Description("Minimum Added Chaos Damage Per Spiders Web On Enemy")]
		MinimumAddedChaosDamagePerSpidersWebOnEnemy = 7701,

		[Description("Maximum Added Chaos Damage Per Spiders Web On Enemy")]
		MaximumAddedChaosDamagePerSpidersWebOnEnemy = 7702,

		[Description("Hit And Ailment Damage +% Vs Enemies Affected By At Least 3 Spiders Webs")]
		HitAndAilmentDamagePosPctVsEnemiesAffectedByAtLeast3SpidersWebs = 7703,

		[Description("Damage +% For Enemies You Inflict Spiders Web Upon")]
		DamagePosPctForEnemiesYouInflictSpidersWebUpon = 7704,

		[Description("Spider Aspect Skill Area Of Effect +%")]
		SpiderAspectSkillAreaOfEffectPosPct = 7705,

		[Description("Resist All % For Enemies You Inflict Spiders Web Upon")]
		ResistAllPctForEnemiesYouInflictSpidersWebUpon = 7706,
		[Description("Resist All %")] ResistAllPct = 7707,

		[Description("Chance To Gain Power Charge On Hitting Enemy Affected By Spiders Web %")]
		ChanceToGainPowerChargeOnHittingEnemyAffectedBySpidersWebPct = 7708,

		[Description("Chance To Poison On Hit % Per Power Charge")]
		ChanceToPoisonOnHitPctPerPowerCharge = 7709,

		[Description("Poison Damage +% Per Power Charge")]
		PoisonDamagePosPctPerPowerCharge = 7710,

		[Description("Spider Aspect Web Interval Ms Override")]
		SpiderAspectWebIntervalMsOverride = 7711,

		[Description("Bestiary Net Variation")]
		BestiaryNetVariation = 7712,

		[Description("Virtual Golem Buff Effect +%")]
		VirtualGolemBuffEffectPosPct = 7713,

		[Description("Golem Buff Effect +% Per Summoned Golem")]
		GolemBuffEffectPosPctPerSummonedGolem = 7714,
		[Description("Has Tailwind")] HasTailwind = 7715,

		[Description("Summoned Skeletons Hits Cant Be Evaded")]
		SummonedSkeletonsHitsCantBeEvaded = 7716,

		[Description("Zombie Slam Area Of Effect +%")]
		ZombieSlamAreaOfEffectPosPct = 7717,

		[Description("Monster Slam Area Of Effect +%")]
		MonsterSlamAreaOfEffectPosPct = 7718,

		[Description("Additional Block % Per Hit You Have Blocked In Past 10 Seconds")]
		AdditionalBlockPctPerHitYouHaveBlockedInPast10Seconds = 7719,

		[Description("Herald Of Ash Spell Fire Damage +% Final")]
		HeraldOfAshSpellFireDamagePosPctFinal = 7720,
		[Description("Skill Uses Main Hand")] SkillUsesMainHand = 7721,
		[Description("Skill Uses Off Hand")] SkillUsesOffHand = 7722,

		[Description("Hundred Times Average Damage Per Spell Hit")]
		HundredTimesAverageDamagePerSpellHit = 7723,

		[Description("Hundred Times Average Damage Per Secondary Hit")]
		HundredTimesAverageDamagePerSecondaryHit = 7724,

		[Description("Hundred Times Average Damage Per Main Hand Hit")]
		HundredTimesAverageDamagePerMainHandHit = 7725,

		[Description("Hundred Times Average Damage Per Off Hand Hit")]
		HundredTimesAverageDamagePerOffHandHit = 7726,

		[Description("Life Leech From Spell Damage Permyriad While You Have Arcane Surge")]
		LifeLeechFromSpellDamagePermyriadWhileYouHaveArcaneSurge = 7727,

		[Description("Additional Spell Block %")]
		AdditionalSpellBlockPct = 7728,
		[Description("Cannot Pierce")] CannotPierce = 7729,

		[Description("Projectile Damage % For Each Remaining Chain")]
		ProjectileDamagePctForEachRemainingChain = 7730,

		[Description("Raging Spirits Always Ignite")]
		RagingSpiritsAlwaysIgnite = 7731,

		[Description("Reduce Enemy Fire Resistance % Vs Blinded Enemies")]
		ReduceEnemyFireResistancePctVsBlindedEnemies = 7732,

		[Description("Hits Cannot Be Evaded Vs Blinded Enemies")]
		HitsCannotBeEvadedVsBlindedEnemies = 7733,

		[Description("Base Body Armour Evasion Rating")]
		BaseBodyArmourEvasionRating = 7734,

		[Description("Base Helmet Maximum Energy Shield")]
		BaseHelmetMaximumEnergyShield = 7735,

		[Description("Evasion Rating + Per 1 Helmet Energy Shield")]
		EvasionRatingPosPer1HelmetEnergyShield = 7736,

		[Description("Maximum Energy Shield + Per 6 Body Armour Evasion Rating")]
		MaximumEnergyShieldPosPer6BodyArmourEvasionRating = 7737,

		[Description("Damage Taken +% If Have Not Been Hit Recently")]
		DamageTakenPosPctIfHaveNotBeenHitRecently = 7738,

		[Description("Cannot Be Stunned If Have Not Been Hit Recently")]
		CannotBeStunnedIfHaveNotBeenHitRecently = 7739,
		[Description("Map Num Grandmasters")] MapNumGrandmasters = 7740,
		[Description("Map Grandmaster Seed")] MapGrandmasterSeed = 7741,

		[Description("Minimum Added Fire Damage To Hits Vs Blinded Enemies")]
		MinimumAddedFireDamageToHitsVsBlindedEnemies = 7742,

		[Description("Maximum Added Fire Damage To Hits Vs Blinded Enemies")]
		MaximumAddedFireDamageToHitsVsBlindedEnemies = 7743,

		[Description("Main Hand Minimum Added Fire Damage To Hits Vs Blinded Enemies")]
		MainHandMinimumAddedFireDamageToHitsVsBlindedEnemies = 7744,

		[Description("Main Hand Maximum Added Fire Damage To Hits Vs Blinded Enemies")]
		MainHandMaximumAddedFireDamageToHitsVsBlindedEnemies = 7745,

		[Description("Off Hand Minimum Added Fire Damage To Hits Vs Blinded Enemies")]
		OffHandMinimumAddedFireDamageToHitsVsBlindedEnemies = 7746,

		[Description("Off Hand Maximum Added Fire Damage To Hits Vs Blinded Enemies")]
		OffHandMaximumAddedFireDamageToHitsVsBlindedEnemies = 7747,

		[Description("Light Radius Increases Apply To Accuracy")]
		LightRadiusIncreasesApplyToAccuracy = 7748,

		[Description("Endurance Charge On Melee Stun Damage +% Final Per Endurance Charge")]
		EnduranceChargeOnMeleeStunDamagePosPctFinalPerEnduranceCharge = 7749,

		[Description("Tectonic Slam Chance To Not Consume Endurance Charge %")]
		TectonicSlamChanceToNotConsumeEnduranceChargePct = 7750,

		[Description("% Number Of Raging Spirits Allowed")]
		Pctnumberofragingspiritsallowed = 7751,

		[Description("Manifest Dancing Dervish Number Of Additional Copies")]
		ManifestDancingDervishNumberOfAdditionalCopies = 7752,
		[Description("Map Is Zana Map")] MapIsZanaMap = 7753,
		[Description("Map Num Zana Mods")] MapNumZanaMods = 7754,

		[Description("Local Display Trigger Level X Curse Nova On Hit While Cursed")]
		LocalDisplayTriggerLevelXCurseNovaOnHitWhileCursed = 7755,

		[Description("Cast On Hit If Cursed %")]
		CastOnHitIfCursedPct = 7756,

		[Description("Base Life Recovery Per Minute From Flask")]
		BaseLifeRecoveryPerMinuteFromFlask = 7757,

		[Description("Base Mana Recovery Per Minute From Flask")]
		BaseManaRecoveryPerMinuteFromFlask = 7758,

		[Description("Tectonic Slam Damage +%")]
		TectonicSlamDamagePosPct = 7759,

		[Description("Tectonic Slam Area Of Effect +%")]
		TectonicSlamAreaOfEffectPosPct = 7760,

		[Description("Spectral Shield Throw Damage +%")]
		SpectralShieldThrowDamagePosPct = 7761,

		[Description("Spectral Shield Throw Projectile Speed +%")]
		SpectralShieldThrowProjectileSpeedPosPct = 7762,

		[Description("Spectral Shield Throw Num Of Additional Projectiles")]
		SpectralShieldThrowNumOfAdditionalProjectiles = 7763,

		[Description("Cannot Take Reflected Elemental Damage")]
		CannotTakeReflectedElementalDamage = 7764,

		[Description("Cannot Take Reflected Physical Damage")]
		CannotTakeReflectedPhysicalDamage = 7765,

		[Description("Golem Damage +% Per Active Golem")]
		GolemDamagePosPctPerActiveGolem = 7766,

		[Description("Tailwind Effect On Self +% For Each Skill Used Recently")]
		TailwindEffectOnSelfPosPctForEachSkillUsedRecently = 7767,

		[Description("Virtual Spider Aspect Web Interval Ms")]
		VirtualSpiderAspectWebIntervalMs = 7768,

		[Description("Aspect Of The Spider Web Count +")]
		AspectOfTheSpiderWebCountPos = 7769,

		[Description("Crab Aspect Crab Barrier Max +")]
		CrabAspectCrabBarrierMaxPos = 7770,

		[Description("Combined Skill Dot Fire Damage Over Time +% Final")]
		CombinedSkillDotFireDamageOverTimePosPctFinal = 7771,

		[Description("Shrapnel Trap Number Of Secondary Explosions")]
		ShrapnelTrapNumberOfSecondaryExplosions = 7772,

		[Description("Shrapnel Trap Number Of Additional Secondary Explosions")]
		ShrapnelTrapNumberOfAdditionalSecondaryExplosions = 7773,
		[Description("Virtual No Mana Cost")] VirtualNoManaCost = 7774,

		[Description("Life Loss % Per Minute")]
		LifeLossPctPerMinute = 7775,

		[Description("Map Spawn Incursion Encounters")]
		MapSpawnIncursionEncounters = 7776,

		[Description("Prevent Vaal Souls On Hit")]
		PreventVaalSoulsOnHit = 7777,

		[Description("Ignores Enemy Fire Resistance")]
		IgnoresEnemyFireResistance = 7778,

		[Description("Ignores Enemy Cold Resistance")]
		IgnoresEnemyColdResistance = 7779,

		[Description("Ignores Enemy Lightning Resistance")]
		IgnoresEnemyLightningResistance = 7780,

		[Description("Groundslam Damage To Close Targets +% Final")]
		GroundslamDamageToCloseTargetsPosPctFinal = 7781,
		[Description("Keystone Vaal Attacks")] KeystoneVaalAttacks = 7782,

		[Description("Grant Vaal Attack Soul On Hitting Rare Or Unique With Non Vaal Skill Every X Ms")]
		GrantVaalAttackSoulOnHittingRareOrUniqueWithNonVaalSkillEveryXMs = 7783,

		[Description("Grant Vaal Skill Use On Kill % With Non Vaal Skill")]
		GrantVaalSkillUseOnKillPctWithNonVaalSkill = 7784,
		[Description("Keystone Vaal Spells")] KeystoneVaalSpells = 7785,

		[Description("Non Vaal Skills Damage +% Final")]
		NonVaalSkillsDamagePosPctFinal = 7786,

		[Description("Gain Soul Regeneration For X Seconds On Hit Every 500 Ms")]
		GainSoulRegenerationForXSecondsOnHitEvery500Ms = 7787,

		[Description("Shrapnel Trap Damage +%")]
		ShrapnelTrapDamagePosPct = 7788,

		[Description("Shrapnel Trap Area Of Effect +%")]
		ShrapnelTrapAreaOfEffectPosPct = 7789,

		[Description("Lightning Tower Trap Damage +%")]
		LightningTowerTrapDamagePosPct = 7790,

		[Description("Lightning Tower Trap Duration +%")]
		LightningTowerTrapDurationPosPct = 7791,

		[Description("Lightning Tower Trap Cooldown Speed +%")]
		LightningTowerTrapCooldownSpeedPosPct = 7792,

		[Description("Lightning Tower Trap Base Interval Duration Ms")]
		LightningTowerTrapBaseIntervalDurationMs = 7793,

		[Description("Lightning Tower Trap Interval Duration Ms")]
		LightningTowerTrapIntervalDurationMs = 7794,

		[Description("Lightning Tower Trap Number Of Beams")]
		LightningTowerTrapNumberOfBeams = 7795,

		[Description("Lightning Tower Trap Additional Number Of Beams")]
		LightningTowerTrapAdditionalNumberOfBeams = 7796,

		[Description("Flamethrower Tower Trap Damage +%")]
		FlamethrowerTowerTrapDamagePosPct = 7797,

		[Description("Flamethrower Tower Trap Cooldown Speed +%")]
		FlamethrowerTowerTrapCooldownSpeedPosPct = 7798,

		[Description("Flamethrower Tower Trap Duration +%")]
		FlamethrowerTowerTrapDurationPosPct = 7799,

		[Description("Flamethrower Tower Trap Number Of Flamethrowers")]
		FlamethrowerTowerTrapNumberOfFlamethrowers = 7800,

		[Description("Flamethrower Tower Trap Number Of Additional Flamethrowers")]
		FlamethrowerTowerTrapNumberOfAdditionalFlamethrowers = 7801,

		[Description("Flamethrower Tower Trap Display Cast Speed Affects Rotation")]
		FlamethrowerTowerTrapDisplayCastSpeedAffectsRotation = 7802,

		[Description("Phys Cascade Trap Damage +%")]
		PhysCascadeTrapDamagePosPct = 7803,

		[Description("Phys Cascade Trap Cooldown Speed +%")]
		PhysCascadeTrapCooldownSpeedPosPct = 7804,

		[Description("Phys Cascade Trap Duration +%")]
		PhysCascadeTrapDurationPosPct = 7805,

		[Description("Phys Cascade Trap Number Of Cascades")]
		PhysCascadeTrapNumberOfCascades = 7806,

		[Description("Phys Cascade Trap Number Of Additional Cascades")]
		PhysCascadeTrapNumberOfAdditionalCascades = 7807,

		[Description("Phys Cascade Trap Base Interval Duration Ms")]
		PhysCascadeTrapBaseIntervalDurationMs = 7808,

		[Description("Phys Cascade Trap Interval Duration Ms")]
		PhysCascadeTrapIntervalDurationMs = 7809,

		[Description("Ice Siphon Trap Damage +%")]
		IceSiphonTrapDamagePosPct = 7810,

		[Description("Ice Siphon Trap Duration +%")]
		IceSiphonTrapDurationPosPct = 7811,

		[Description("Ice Siphon Trap Damage Taken +% Per Beam")]
		IceSiphonTrapDamageTakenPosPctPerBeam = 7812,

		[Description("Ice Siphon Trap Chill Effect +%")]
		IceSiphonTrapChillEffectPosPct = 7813,

		[Description("Ice Siphon Trap Max Beam Targets")]
		IceSiphonTrapMaxBeamTargets = 7814,

		[Description("Bear Trap Damage Taken +% From Traps And Mines")]
		BearTrapDamageTakenPosPctFromTrapsAndMines = 7815,

		[Description("Bear Trap Additional Damage Taken +% From Traps And Mines")]
		BearTrapAdditionalDamageTakenPosPctFromTrapsAndMines = 7816,

		[Description("Lightning Trap Lightning Resistance Penetration %")]
		LightningTrapLightningResistancePenetrationPct = 7817,

		[Description("Lightning Trap Shock Effect +%")]
		LightningTrapShockEffectPosPct = 7818,

		[Description("Fire Trap Burning Ground Duration +%")]
		FireTrapBurningGroundDurationPosPct = 7819,

		[Description("Charged Dash Damage +% Final")]
		ChargedDashDamagePosPctFinal = 7820,

		[Description("Charged Dash Damage +% Final Per Stack")]
		ChargedDashDamagePosPctFinalPerStack = 7821,

		[Description("Vaal Earthquake Number Of Aftershocks")]
		VaalEarthquakeNumberOfAftershocks = 7822,

		[Description("Vaal Earthquake Aftershock Delay Ms")]
		VaalEarthquakeAftershockDelayMs = 7823,
		[Description("Maim Effect +%")] MaimEffectPosPct = 7824,

		[Description("Hits Ignore My Fire Resistance")]
		HitsIgnoreMyFireResistance = 7825,

		[Description("Hits Ignore My Cold Resistance")]
		HitsIgnoreMyColdResistance = 7826,

		[Description("Hits Ignore My Lightning Resistance")]
		HitsIgnoreMyLightningResistance = 7827,
		[Description("spectating")] Spectating = 7828,

		[Description("Bear Trap Movement Speed +% Final")]
		BearTrapMovementSpeedPosPctFinal = 7829,

		[Description("Map Incursion Temple Room State")]
		MapIncursionTempleRoomState = 7830,

		[Description("Skill Hide User Buff Effects")]
		SkillHideUserBuffEffects = 7831,

		[Description("Critical Strike Chance +% Vs Shocked Enemies")]
		CriticalStrikeChancePosPctVsShockedEnemies = 7832,

		[Description("Flamethrower Trap Damage +% Final Vs Burning Enemies")]
		FlamethrowerTrapDamagePosPctFinalVsBurningEnemies = 7833,

		[Description("Flamethrower Trap Damage +% Final")]
		FlamethrowerTrapDamagePosPctFinal = 7834,

		[Description("Local Display Socketed Gems Supported By Level X Frenzy Power On Trap Trigger")]
		LocalDisplaySocketedGemsSupportedByLevelXFrenzyPowerOnTrapTrigger = 7835,

		[Description("Trap Throwing Speed +% Per Frenzy Charge")]
		TrapThrowingSpeedPosPctPerFrenzyCharge = 7836,

		[Description("Virtual Trap Throwing Speed +%")]
		VirtualTrapThrowingSpeedPosPct = 7837,

		[Description("Ancestral Call Art Variation")]
		AncestralCallArtVariation = 7838,

		[Description("Expanding Fire Cone Maximum Number Of Stages")]
		ExpandingFireConeMaximumNumberOfStages = 7839,

		[Description("Grant Expanding Fire Cone Release Ignite Damage +% Final")]
		GrantExpandingFireConeReleaseIgniteDamagePosPctFinal = 7840,

		[Description("Expanding Fire Cone Release Ignite Damage +% Final")]
		ExpandingFireConeReleaseIgniteDamagePosPctFinal = 7841,

		[Description("Expanding Fire Cone Release Hit Damage +% Final")]
		ExpandingFireConeReleaseHitDamagePosPctFinal = 7842,

		[Description("Trigger On Corpse Consume % Chance")]
		TriggerOnCorpseConsumePctChance = 7843,

		[Description("Local Display Trigger Level X Summon Phantasm On Corpse Consume")]
		LocalDisplayTriggerLevelXSummonPhantasmOnCorpseConsume = 7844,

		[Description("Cast Speed +% Per Corpse Consumed Recently")]
		CastSpeedPosPctPerCorpseConsumedRecently = 7845,

		[Description("You And Nearby Allies Life Regeneration Rate Per Minute % If Corpse Consumed Recently")]
		YouAndNearbyAlliesLifeRegenerationRatePerMinutePctIfCorpseConsumedRecently = 7846,

		[Description("Infernal Blow Infernal Blow Explosion Damage % Of Total Per Stack")]
		InfernalBlowInfernalBlowExplosionDamagePctOfTotalPerStack = 7847,

		[Description("Infernal Blow Explosion Damage % Of Total Per Stack")]
		InfernalBlowExplosionDamagePctOfTotalPerStack = 7848,

		[Description("Doubles Have Movement Speed +%")]
		DoublesHaveMovementSpeedPosPct = 7849,

		[Description("Lightning Tower Trap Cast Speed +%")]
		LightningTowerTrapCastSpeedPosPct = 7850,

		[Description("Flamethrower Tower Trap Cast Speed +%")]
		FlamethrowerTowerTrapCastSpeedPosPct = 7851,

		[Description("Vaal Righteous Fire Life And Es % To Lose On Use")]
		VaalRighteousFireLifeAndEsPctToLoseOnUse = 7852,

		[Description("Rain Of Arrows Additional Sequences")]
		RainOfArrowsAdditionalSequences = 7853,
		[Description("Cannot Gain Souls")] CannotGainSouls = 7854,

		[Description("Local Flask Gain X Vaal Souls On Use")]
		LocalFlaskGainXVaalSoulsOnUse = 7855,

		[Description("Local Flask No Mana Recovery During Effect")]
		LocalFlaskNoManaRecoveryDuringEffect = 7856,

		[Description("Local Flask Vaal Souls Gained Per Minute During Effect")]
		LocalFlaskVaalSoulsGainedPerMinuteDuringEffect = 7857,

		[Description("Ignites Apply Fire Resistance +")]
		IgnitesApplyFireResistancePos = 7858,

		[Description("Ignite Damage +% Vs Chilled Enemies")]
		IgniteDamagePosPctVsChilledEnemies = 7859,

		[Description("Flameblast Ignite Chance +% Per Stage")]
		FlameblastIgniteChancePosPctPerStage = 7860,

		[Description("Gain X Vaal Souls At 2% Life Thresholds")]
		GainXVaalSoulsAt2PctLifeThresholds = 7861,

		[Description("Disable Vaal Soul Gain At 2% Life Thresholds")]
		DisableVaalSoulGainAt2PctLifeThresholds = 7862,

		[Description("Local Physical Damage % To Convert To A Random Element")]
		LocalPhysicalDamagePctToConvertToARandomElement = 7863,

		[Description("Main Hand Physical Damage % To Convert To A Random Element")]
		MainHandPhysicalDamagePctToConvertToARandomElement = 7864,

		[Description("Off Hand Physical Damage % To Convert To A Random Element")]
		OffHandPhysicalDamagePctToConvertToARandomElement = 7865,

		[Description("Local Hits Always Inflict Elemental Ailments")]
		LocalHitsAlwaysInflictElementalAilments = 7866,

		[Description("Main Hand Hits Always Inflict Elemental Ailments")]
		MainHandHitsAlwaysInflictElementalAilments = 7867,

		[Description("Off Hand Hits Always Inflict Elemental Ailments")]
		OffHandHitsAlwaysInflictElementalAilments = 7868,
		[Description("No Mana Recovery")] NoManaRecovery = 7869,

		[Description("Active Skill Ignite Damage +% Final")]
		ActiveSkillIgniteDamagePosPctFinal = 7870,

		[Description("Chance To Be Poisoned %")]
		ChanceToBePoisonedPct = 7871,
		[Description("Poison Time Passed +%")] PoisonTimePassedPosPct = 7872,

		[Description("Additional Maximum All Resistances % While Poisoned")]
		AdditionalMaximumAllResistancesPctWhilePoisoned = 7873,

		[Description("Energy Shield Regeneration Rate Per Minute Per Poison Stack")]
		EnergyShieldRegenerationRatePerMinutePerPoisonStack = 7874,

		[Description("Bleeding Damage On Self Converted To Chaos")]
		BleedingDamageOnSelfConvertedToChaos = 7875,

		[Description("Maximum Life +% Per Equipped Corrupted Item")]
		MaximumLifePosPctPerEquippedCorruptedItem = 7876,

		[Description("Maximum Es +% Per Equipped Corrupted Item")]
		MaximumEsPosPctPerEquippedCorruptedItem = 7877,

		[Description("All Resistances % Per Equipped Corrupted Item")]
		AllResistancesPctPerEquippedCorruptedItem = 7878,

		[Description("Bleeding Damage Taken Per Minute")]
		BleedingDamageTakenPerMinute = 7879,

		[Description("Area Of Effect +% Per Enemy Killed Recently")]
		AreaOfEffectPosPctPerEnemyKilledRecently = 7880,

		[Description("You Have Zealots Oath If You Havent Been Hit Recently")]
		YouHaveZealotsOathIfYouHaventBeenHitRecently = 7881,

		[Description("No Energy Shield Recovery")]
		NoEnergyShieldRecovery = 7882,

		[Description("Life Regeneration Per Minute If You Have At Least 500 Maximum Energy Shield")]
		LifeRegenerationPerMinuteIfYouHaveAtLeast500MaximumEnergyShield = 7883,

		[Description("Life Regeneration Per Minute If You Have At Least 1000 Maximum Energy Shield")]
		LifeRegenerationPerMinuteIfYouHaveAtLeast1000MaximumEnergyShield = 7884,

		[Description("Life Regeneration Per Minute If You Have At Least 1500 Maximum Energy Shield")]
		LifeRegenerationPerMinuteIfYouHaveAtLeast1500MaximumEnergyShield = 7885,

		[Description("X To Maximum Life Per 2 Intelligence")]
		XToMaximumLifePer2Intelligence = 7886,

		[Description("Gain No Maximum Life From Strength")]
		GainNoMaximumLifeFromStrength = 7887,

		[Description("Gain No Maximum Mana From Intelligence")]
		GainNoMaximumManaFromIntelligence = 7888,

		[Description("Life Regeneration Rate Per Minute % Per 500 Maximum Energy Shield")]
		LifeRegenerationRatePerMinutePctPer500MaximumEnergyShield = 7889,
		[Description("Keystone Zealots Oath")] KeystoneZealotsOath = 7890,

		[Description("Number Of Enemies Killed Recently")]
		NumberOfEnemiesKilledRecently = 7891,

		[Description("Combined Cast Speed +%")]
		CombinedCastSpeedPosPct = 7892,

		[Description("Combined Cast Speed +% Final")]
		CombinedCastSpeedPosPctFinal = 7893,

		[Description("Additive Cast Speed Modifiers Apply To Trap Throwing Speed")]
		AdditiveCastSpeedModifiersApplyToTrapThrowingSpeed = 7894,

		[Description("% Chance To Gain Random Charge On Trap Triggered By An Enemy")]
		Pctchancetogainrandomchargeontraptriggeredbyanenemy = 7895,

		[Description("Trap Throw Skills Have Blood Magic")]
		TrapThrowSkillsHaveBloodMagic = 7896,

		[Description("Affected By Vulnerability")]
		AffectedByVulnerability = 7897,

		[Description("Enemy Extra Damage Rolls While Affected By Vulnerability")]
		EnemyExtraDamageRollsWhileAffectedByVulnerability = 7898,

		[Description("You Count As Low Life While Affected By Vulnerability")]
		YouCountAsLowLifeWhileAffectedByVulnerability = 7899,

		[Description("Self Cursed With Level X Vulnerability")]
		SelfCursedWithLevelXVulnerability = 7900,

		[Description("Ice Trap Cold Resistance Penetration %")]
		IceTrapColdResistancePenetrationPct = 7901,

		[Description("Life Gain Per Target If Have Used A Vaal Skill Recently")]
		LifeGainPerTargetIfHaveUsedAVaalSkillRecently = 7902,

		[Description("Movement Speed +% If Have Used A Vaal Skill Recently")]
		MovementSpeedPosPctIfHaveUsedAVaalSkillRecently = 7903,

		[Description("Have Used A Vaal Skill Recently")]
		HaveUsedAVaalSkillRecently = 7904,

		[Description("Track Have Used A Vaal Skill Recently")]
		TrackHaveUsedAVaalSkillRecently = 7905,

		[Description("Gain Power Charge On Vaal Skill Use %")]
		GainPowerChargeOnVaalSkillUsePct = 7906,

		[Description("Chaos Damage Can Ignite Chill And Shock")]
		ChaosDamageCanIgniteChillAndShock = 7907,

		[Description("Gain Soul Eater For X Ms On Vaal Skill Use")]
		GainSoulEaterForXMsOnVaalSkillUse = 7908,

		[Description("Local Hit Damage +% Vs Ignited Enemies")]
		LocalHitDamagePosPctVsIgnitedEnemies = 7909,

		[Description("Main Hand Hit Damage +% Vs Ignited Enemies")]
		MainHandHitDamagePosPctVsIgnitedEnemies = 7910,

		[Description("Off Hand Hit Damage +% Vs Ignited Enemies")]
		OffHandHitDamagePosPctVsIgnitedEnemies = 7911,

		[Description("Local Hit Damage +% Vs Frozen Enemies")]
		LocalHitDamagePosPctVsFrozenEnemies = 7912,

		[Description("Main Hand Hit Damage +% Vs Frozen Enemies")]
		MainHandHitDamagePosPctVsFrozenEnemies = 7913,

		[Description("Off Hand Hit Damage +% Vs Frozen Enemies")]
		OffHandHitDamagePosPctVsFrozenEnemies = 7914,

		[Description("Local Hit Damage +% Vs Shocked Enemies")]
		LocalHitDamagePosPctVsShockedEnemies = 7915,

		[Description("Main Hand Hit Damage +% Vs Shocked Enemies")]
		MainHandHitDamagePosPctVsShockedEnemies = 7916,

		[Description("Off Hand Hit Damage +% Vs Shocked Enemies")]
		OffHandHitDamagePosPctVsShockedEnemies = 7917,

		[Description("Summoned Skeletons Fire Damage % Of Maximum Life Taken Per Minute")]
		SummonedSkeletonsFireDamagePctOfMaximumLifeTakenPerMinute = 7918,

		[Description("Summoned Skeletons Cover In Ash On Hit %")]
		SummonedSkeletonsCoverInAshOnHitPct = 7919,

		[Description("Summoned Skeletons Have Avatar Of Fire")]
		SummonedSkeletonsHaveAvatarOfFire = 7920,
		[Description("Cover In Ash On Hit %")] CoverInAshOnHitPct = 7921,

		[Description("Local Socketed Trap And Mine Gem Level +")]
		LocalSocketedTrapAndMineGemLevelPos = 7922,
		[Description("Wrath Aura Effect +%")] WrathAuraEffectPosPct = 7923,
		[Description("Hatred Aura Effect +%")] HatredAuraEffectPosPct = 7924,

		[Description("Determination Aura Effect +%")]
		DeterminationAuraEffectPosPct = 7925,

		[Description("Discipline Aura Effect +%")]
		DisciplineAuraEffectPosPct = 7926,
		[Description("Grace Aura Effect +%")] GraceAuraEffectPosPct = 7927,

		[Description("Local Unique Jewel Critical Strike Multiplier + Per 10 Str Unallocated In Radius")]
		LocalUniqueJewelCriticalStrikeMultiplierPosPer10StrUnallocatedInRadius = 7928,

		[Description("Local Unique Jewel Additional Physical Damage Reduction % Per 10 Str Allocated In Radius")]
		LocalUniqueJewelAdditionalPhysicalDamageReductionPctPer10StrAllocatedInRadius = 7929,

		[Description("Local Unique Jewel Maximum Mana + Per 10 Dex Unallocated In Radius")]
		LocalUniqueJewelMaximumManaPosPer10DexUnallocatedInRadius = 7930,

		[Description("Local Unique Jewel Movement Speed +% Per 10 Dex Allocated In Radius")]
		LocalUniqueJewelMovementSpeedPosPctPer10DexAllocatedInRadius = 7931,

		[Description("Local Unique Jewel Accuracy Rating + Per 10 Int Unallocated In Radius")]
		LocalUniqueJewelAccuracyRatingPosPer10IntUnallocatedInRadius = 7932,

		[Description("Local Unique Jewel Energy Shield Regeneration Rate Per Minute % Per 10 Int Allocated In Radius")]
		LocalUniqueJewelEnergyShieldRegenerationRatePerMinutePctPer10IntAllocatedInRadius = 7933,

		[Description("Local Unique Jewel X Strength Per 1 Strength Allocated In Radius")]
		LocalUniqueJewelXStrengthPer1StrengthAllocatedInRadius = 7934,

		[Description("Local Unique Jewel X Dexterity Per 1 Dexterity Allocated In Radius")]
		LocalUniqueJewelXDexterityPer1DexterityAllocatedInRadius = 7935,

		[Description("Local Unique Jewel X Intelligence Per 1 Intelligence Allocated In Radius")]
		LocalUniqueJewelXIntelligencePer1IntelligenceAllocatedInRadius = 7936,

		[Description("Ground Vaal Cold Snap Art Variation")]
		GroundVaalColdSnapArtVariation = 7937,

		[Description("Elementalist Ignite Damage +% Final")]
		ElementalistIgniteDamagePosPctFinal = 7938,

		[Description("Ancestor Totem Ignores Stances")]
		AncestorTotemIgnoresStances = 7939,

		[Description("Skill Life Regeneration Per Minute Per Affected Enemy")]
		SkillLifeRegenerationPerMinutePerAffectedEnemy = 7940,

		[Description("Skill Mana Regeneration Per Minute Per Affected Enemy")]
		SkillManaRegenerationPerMinutePerAffectedEnemy = 7941,

		[Description("Skill Life Regeneration Per Minute With At Least 1 Affected Enemy")]
		SkillLifeRegenerationPerMinuteWithAtLeast1AffectedEnemy = 7942,

		[Description("Skill Mana Regeneration Per Minute With At Least 1 Affected Enemy")]
		SkillManaRegenerationPerMinuteWithAtLeast1AffectedEnemy = 7943,

		[Description("Skill Damage Taken +% Per Affected Enemy")]
		SkillDamageTakenPosPctPerAffectedEnemy = 7944,

		[Description("Blade Vortex Critical Strike Chance +% Per Blade")]
		BladeVortexCriticalStrikeChancePosPctPerBlade = 7945,

		[Description("Bladefall Critical Strike Chance +% Per Stage")]
		BladefallCriticalStrikeChancePosPctPerStage = 7946,

		[Description("Global Minimum Added Physical Damage Vs Bleeding Enemies")]
		GlobalMinimumAddedPhysicalDamageVsBleedingEnemies = 7947,

		[Description("Global Maximum Added Physical Damage Vs Bleeding Enemies")]
		GlobalMaximumAddedPhysicalDamageVsBleedingEnemies = 7948,

		[Description("Lacerate Hit And Ailment Damage +% Final Vs Bleeding Enemies")]
		LacerateHitAndAilmentDamagePosPctFinalVsBleedingEnemies = 7949,

		[Description("Cast Speed +% Final Per Frostbolt Destroyed Recently")]
		CastSpeedPosPctFinalPerFrostboltDestroyedRecently = 7950,

		[Description("Mana Cost +% Final Per Frostbolt Destroyed Recently")]
		ManaCostPosPctFinalPerFrostboltDestroyedRecently = 7951,

		[Description("Number Of Frostbolts Destroyed Recently")]
		NumberOfFrostboltsDestroyedRecently = 7952,

		[Description("Lacerate Hit And Ailment Damage +% Final")]
		LacerateHitAndAilmentDamagePosPctFinal = 7953,

		[Description("Dodge Attacks Chance % While Moving")]
		DodgeAttacksChancePctWhileMoving = 7954,

		[Description("Dodge Spells Chance % While Moving")]
		DodgeSpellsChancePctWhileMoving = 7955,

		[Description("Global Evasion Rating + While Moving")]
		GlobalEvasionRatingPosWhileMoving = 7956,

		[Description("Global Physical Damage Reduction Rating While Moving")]
		GlobalPhysicalDamageReductionRatingWhileMoving = 7957,

		[Description("Curse On Hit Level Despair")]
		CurseOnHitLevelDespair = 7958,

		[Description("Curse On Hit Level Enfeeble")]
		CurseOnHitLevelEnfeeble = 7959,

		[Description("Area Damage Taken From Hits +%")]
		AreaDamageTakenFromHitsPosPct = 7960,

		[Description("Projectile Damage +% Per Chain")]
		ProjectileDamagePosPctPerChain = 7961,

		[Description("Local Display Grants Level X Despair")]
		LocalDisplayGrantsLevelXDespair = 7962,

		[Description("Critical Strike Chance +% During Any Flask Effect")]
		CriticalStrikeChancePosPctDuringAnyFlaskEffect = 7963,

		[Description("Critical Strike Multiplier + During Any Flask Effect")]
		CriticalStrikeMultiplierPosDuringAnyFlaskEffect = 7964,

		[Description("Cannot Be Inflicted By Corrupted Blood")]
		CannotBeInflictedByCorruptedBlood = 7965,

		[Description("Gain X Frenzy Charges After Spending 200 Mana")]
		GainXFrenzyChargesAfterSpending200Mana = 7966,

		[Description("Local Socketed Duration Gem Level +")]
		LocalSocketedDurationGemLevelPos = 7967,

		[Description("Local Socketed Area Of Effect Gem Level +")]
		LocalSocketedAreaOfEffectGemLevelPos = 7968,

		[Description("Map Incursion Monster Data")]
		MapIncursionMonsterData = 7969,

		[Description("Local Display Has Additional Implicit Mod")]
		LocalDisplayHasAdditionalImplicitMod = 7970,

		[Description("Spark Chance To Force Alternate Angle Side %")]
		SparkChanceToForceAlternateAngleSidePct = 7971,

		[Description("Gain Onslaught While Not On Low Mana")]
		GainOnslaughtWhileNotOnLowMana = 7972,

		[Description("Dodge Attacks And Spell Chance % Per 500 Maximum Mana Up To 20")]
		DodgeAttacksAndSpellChancePctPer500MaximumManaUpTo20 = 7973,

		[Description("Ball Lightning Projectile Speed And Hit Frequency +% Final")]
		BallLightningProjectileSpeedAndHitFrequencyPosPctFinal = 7974,

		[Description("Arc Damage +% Final Per Chain")]
		ArcDamagePosPctFinalPerChain = 7975,

		[Description("Arc Damage +% Final For Each Remaining Chain")]
		ArcDamagePosPctFinalForEachRemainingChain = 7976,

		[Description("Chance To Gain Power Charge On Rare Or Unique Enemy Hit %")]
		ChanceToGainPowerChargeOnRareOrUniqueEnemyHitPct = 7977,

		[Description("Expanding Fire Cone Additional Maximum Number Of Stages")]
		ExpandingFireConeAdditionalMaximumNumberOfStages = 7978,

		[Description("Expanding Fire Cone Area Of Effect +%")]
		ExpandingFireConeAreaOfEffectPosPct = 7979,

		[Description("Elemental Hit Cannot Roll Fire Damage")]
		ElementalHitCannotRollFireDamage = 7980,

		[Description("Elemental Hit Cannot Roll Cold Damage")]
		ElementalHitCannotRollColdDamage = 7981,

		[Description("Elemental Hit Cannot Roll Lightning Damage")]
		ElementalHitCannotRollLightningDamage = 7982,

		[Description("Expanding Fire Cone Radius + Per Stage")]
		ExpandingFireConeRadiusPosPerStage = 7983,

		[Description("Expanding Fire Cone Angle +% Per Stage")]
		ExpandingFireConeAnglePosPctPerStage = 7984,

		[Description("Expanding Fire Cone Final Wave Always Ignite")]
		ExpandingFireConeFinalWaveAlwaysIgnite = 7985,

		[Description("Kill And Delete On Hit")]
		KillAndDeleteOnHit = 7986,

		[Description("Elemental Hit Damage +10% Final Per Enemy Elemental Ailment")]
		ElementalHitDamagePos10PctFinalPerEnemyElementalAilment = 7987,

		[Description("Elemental Hit Damage +% Final")]
		ElementalHitDamagePosPctFinal = 7988,

		[Description("Elemental Hit Area Of Effect +100% Final Vs Enemy With Associated Ailment")]
		ElementalHitAreaOfEffectPos100PctFinalVsEnemyWithAssociatedAilment = 7989,

		[Description("Support Power Charge On Crit Damage +% Final Per Power Charge")]
		SupportPowerChargeOnCritDamagePosPctFinalPerPowerCharge = 7990,

		[Description("Hinder Enemy Chaos Damage Taken +%")]
		HinderEnemyChaosDamageTakenPosPct = 7991,

		[Description("Local Display Grants Skill Vaal Impurity Of Fire Level")]
		LocalDisplayGrantsSkillVaalImpurityOfFireLevel = 7992,

		[Description("Local Display Grants Skill Vaal Impurity Of Ice Level")]
		LocalDisplayGrantsSkillVaalImpurityOfIceLevel = 7993,

		[Description("Local Display Grants Skill Vaal Impurity Of Lightning Level")]
		LocalDisplayGrantsSkillVaalImpurityOfLightningLevel = 7994,

		[Description("Support Hypothermia Cold Damage Over Time +% Final")]
		SupportHypothermiaColdDamageOverTimePosPctFinal = 7995,

		[Description("Ground Quicksand Art Variation")]
		GroundQuicksandArtVariation = 7996,

		[Description("Map Area Contains X Additional Clusters Of Explosive Eggs")]
		MapAreaContainsXAdditionalClustersOfExplosiveEggs = 7997,

		[Description("Trap Critical Strike Multiplier + Per Power Charge")]
		TrapCriticalStrikeMultiplierPosPerPowerCharge = 7998,

		[Description("Ignores Trap And Mine Cooldown Limit")]
		IgnoresTrapAndMineCooldownLimit = 7999,

		[Description("Vaal Righteous Fire Life And Es % As Damage Per Second")]
		VaalRighteousFireLifeAndEsPctAsDamagePerSecond = 8000,

		[Description("Molten Strike Projectile Animation Speed +%")]
		MoltenStrikeProjectileAnimationSpeedPosPct = 8001,

		[Description("Orb Of Storms Base Bolt Frequency Ms")]
		OrbOfStormsBaseBoltFrequencyMs = 8002,

		[Description("Orb Of Storms Bolt Frequency Ms")]
		OrbOfStormsBoltFrequencyMs = 8003,

		[Description("Orb Of Storms Cast Speed +%")]
		OrbOfStormsCastSpeedPosPct = 8004,

		[Description("Area Of Effect +% When Cast On Frostbolt")]
		AreaOfEffectPosPctWhenCastOnFrostbolt = 8005,

		[Description("Vortex Area Of Effect +% When Cast On Frostbolt")]
		VortexAreaOfEffectPosPctWhenCastOnFrostbolt = 8006,

		[Description("Skill Code Movement Speed +% Final")]
		SkillCodeMovementSpeedPosPctFinal = 8007,

		[Description("Charged Dash Movement Speed +% Final")]
		ChargedDashMovementSpeedPosPctFinal = 8008,

		[Description("Virtual Bladefall Number Of Volleys")]
		VirtualBladefallNumberOfVolleys = 8009,

		[Description("Bladefall Number Of Volleys")]
		BladefallNumberOfVolleys = 8010,

		[Description("Blade Vortex Critical Strike Multiplier + Per Blade")]
		BladeVortexCriticalStrikeMultiplierPosPerBlade = 8011,

		[Description("Critical Strike Multiplier + Per Blade")]
		CriticalStrikeMultiplierPosPerBlade = 8012,

		[Description("Double Strike Chance To Deal Double Damage % Vs Bleeding Enemies")]
		DoubleStrikeChanceToDealDoubleDamagePctVsBleedingEnemies = 8013,

		[Description("Chance To Deal Double Damage % Vs Bleeding Enemies")]
		ChanceToDealDoubleDamagePctVsBleedingEnemies = 8014,

		[Description("Arc Damage +% Per Chain")]
		ArcDamagePosPctPerChain = 8015,
		[Description("Damage +% Per Chain")] DamagePosPctPerChain = 8016,

		[Description("Petrification Statue Target Action Speed -%")]
		PetrificationStatueTargetActionSpeedNegPct = 8017,

		[Description("Petrification Statue Pertrify Duration Ms")]
		PetrificationStatuePertrifyDurationMs = 8018,

		[Description("Arc Enhanced Behaviour")]
		ArcEnhancedBehaviour = 8019,

		[Description("Storm Burst Number Of Additional Projectiles")]
		StormBurstNumberOfAdditionalProjectiles = 8020,

		[Description("Ball Lightning Number Of Additional Projectiles")]
		BallLightningNumberOfAdditionalProjectiles = 8021,

		[Description("Power Siphon Number Of Additional Projectiles")]
		PowerSiphonNumberOfAdditionalProjectiles = 8022,

		[Description("Ethereal Knives Projectile Base Number Of Targets To Pierce")]
		EtherealKnivesProjectileBaseNumberOfTargetsToPierce = 8023,

		[Description("Frost Bomb Buff Duration +%")]
		FrostBombBuffDurationPosPct = 8024,

		[Description("Chest Drop Additional Weapon Item Divination Cards")]
		ChestDropAdditionalWeaponItemDivinationCards = 8025,

		[Description("Chest Drop Additional Armour Item Divination Cards")]
		ChestDropAdditionalArmourItemDivinationCards = 8026,

		[Description("Map Non Unique Monster Life Regeneration Rate Per Minute %")]
		MapNonUniqueMonsterLifeRegenerationRatePerMinutePct = 8027,
		[Description("Map Packs Are Vaal")] MapPacksAreVaal = 8028,

		[Description("Translate Rotate Translate Speed +%")]
		TranslateRotateTranslateSpeedPosPct = 8029,

		[Description("Translate Rotate Rotation Angle Rate")]
		TranslateRotateRotationAngleRate = 8030,

		[Description("Chance To Gain Frenzy Charge On Killing Enemy Affected By Cold Snap Ground %")]
		ChanceToGainFrenzyChargeOnKillingEnemyAffectedByColdSnapGroundPct = 8031,

		[Description("Is On Ground Cold Snap")]
		IsOnGroundColdSnap = 8032,

		[Description("Translate Rotate Curvature Scale")]
		TranslateRotateCurvatureScale = 8033,

		[Description("Translate Rotate Curvature Path Distance")]
		TranslateRotateCurvaturePathDistance = 8034,

		[Description("Monster Uses Map Boss Difficulty Scaling")]
		MonsterUsesMapBossDifficultyScaling = 8035,

		[Description("Double Slash Minimum Added Physical Damage Vs Bleeding Enemies")]
		DoubleSlashMinimumAddedPhysicalDamageVsBleedingEnemies = 8036,

		[Description("Double Slash Maximum Added Physical Damage Vs Bleeding Enemies")]
		DoubleSlashMaximumAddedPhysicalDamageVsBleedingEnemies = 8037,

		[Description("Arc Extra Damage Rolls")]
		ArcExtraDamageRolls = 8038,

		[Description("Base Enemy Extra Damage Rolls")]
		BaseEnemyExtraDamageRolls = 8039,

		[Description("Charged Dash Channelling Damage At Full Stacks +% Final")]
		ChargedDashChannellingDamageAtFullStacksPosPctFinal = 8040,

		[Description("Map Tempest Massive Storm Weight")]
		MapTempestMassiveStormWeight = 8041,

		[Description("Map Tempest Tiny Storm Weight")]
		MapTempestTinyStormWeight = 8042,

		[Description("Map Tempest Crit Storm Weight")]
		MapTempestCritStormWeight = 8043,

		[Description("Map Tempest Replenishing Storm Weight")]
		MapTempestReplenishingStormWeight = 8044,

		[Description("Map Tempest Status Immunity Storm Weight")]
		MapTempestStatusImmunityStormWeight = 8045,

		[Description("Map Tempest Corrupted Drops Weight")]
		MapTempestCorruptedDropsWeight = 8046,

		[Description("Map Tempest Uber Rarity Storm Weight")]
		MapTempestUberRarityStormWeight = 8047,

		[Description("Local Unique Jewel Elemental Hit Cannot Roll Cold Damage With 40 Int + Str In Radius")]
		LocalUniqueJewelElementalHitCannotRollColdDamageWith40IntPosStrInRadius = 8048,

		[Description("Local Unique Jewel Elemental Hit Cannot Roll Fire Damage With 40 Int + Dex In Radius")]
		LocalUniqueJewelElementalHitCannotRollFireDamageWith40IntPosDexInRadius = 8049,

		[Description("Local Unique Jewel Elemental Hit Cannot Roll Lightning Damage With 40 Dex + Str In Radius")]
		LocalUniqueJewelElementalHitCannotRollLightningDamageWith40DexPosStrInRadius = 8050,

		[Description("Minion Do Not Remove Skill Specific Stats")]
		MinionDoNotRemoveSkillSpecificStats = 8051,

		[Description("Map Packs Are Mechanical Totems")]
		MapPacksAreMechanicalTotems = 8052,

		[Description("Vaal Earthquake Maximum Aftershocks")]
		VaalEarthquakeMaximumAftershocks = 8053,

		[Description("Rain Of Arrows Rain Of Arrows Additional Sequence Chance %")]
		RainOfArrowsRainOfArrowsAdditionalSequenceChancePct = 8054,

		[Description("Rain Of Arrows Additional Sequence Chance %")]
		RainOfArrowsAdditionalSequenceChancePct = 8055,

		[Description("Rain Of Arrows Sequences To Fire")]
		RainOfArrowsSequencesToFire = 8056,

		[Description("Local Unique Jewel Cold Snap Uses Gains Power Charges Instead Of Frenzy With 40 Int In Radius")]
		LocalUniqueJewelColdSnapUsesGainsPowerChargesInsteadOfFrenzyWith40IntInRadius = 8057,

		[Description("Cold Snap Uses And Gains Power Charges Instead Of Frenzy")]
		ColdSnapUsesAndGainsPowerChargesInsteadOfFrenzy = 8058,

		[Description("Active Skill Cooldown Bypass Type Override To Power Charge")]
		ActiveSkillCooldownBypassTypeOverrideToPowerCharge = 8059,

		[Description("Local Socketed Trap Gem Level +")]
		LocalSocketedTrapGemLevelPos = 8060,

		[Description("Elemental Hit No Physical Chaos Damage")]
		ElementalHitNoPhysicalChaosDamage = 8061,

		[Description("Elemental Hit Number Of Options")]
		ElementalHitNumberOfOptions = 8062,

		[Description("Local Unique Flask Vaal Skill Damage +% During Flask Effect")]
		LocalUniqueFlaskVaalSkillDamagePosPctDuringFlaskEffect = 8063,

		[Description("Local Unique Flask Vaal Skill Soul Cost +% During Flask Effect")]
		LocalUniqueFlaskVaalSkillSoulCostPosPctDuringFlaskEffect = 8064,

		[Description("Local Unique Flask Vaal Skill Soul Gain Preventation Duration +% During Flask Effect")]
		LocalUniqueFlaskVaalSkillSoulGainPreventationDurationPosPctDuringFlaskEffect = 8065,

		[Description("Vaal Skill Soul Gain Preventation Duration +%")]
		VaalSkillSoulGainPreventationDurationPosPct = 8066,

		[Description("Vaal Skill Does Not Apply Soul Gain Prevention")]
		VaalSkillDoesNotApplySoulGainPrevention = 8067,

		[Description("Local Unique Flask Vaal Skill Does Not Apply Soul Gain Prevention During Flask Effect")]
		LocalUniqueFlaskVaalSkillDoesNotApplySoulGainPreventionDuringFlaskEffect = 8068,

		[Description("Local Unique Soul Ripper Flask Cannot Gain Flask Charges During Flask Effect")]
		LocalUniqueSoulRipperFlaskCannotGainFlaskChargesDuringFlaskEffect = 8069,

		[Description("Using Flask Soul Ripper")]
		UsingFlaskSoulRipper = 8070,

		[Description("Monster Uses Architect Boss Difficulty Scaling")]
		MonsterUsesArchitectBossDifficultyScaling = 8071,

		[Description("Summon Specific Monsters Cannot Fail")]
		SummonSpecificMonstersCannotFail = 8072,

		[Description("Vaal Flameblast Radius + Per Stage")]
		VaalFlameblastRadiusPosPerStage = 8073,

		[Description("Vaal Righteous Fire Spell Damage +% Final")]
		VaalRighteousFireSpellDamagePosPctFinal = 8074,

		[Description("Vaal Cold Snap Gain Frenzy Charge Every Second If Enemy In Aura")]
		VaalColdSnapGainFrenzyChargeEverySecondIfEnemyInAura = 8075,

		[Description("Trigger Cascade Arm Angle Offset")]
		TriggerCascadeArmAngleOffset = 8076,

		[Description("Geometry Attack % Target Life To Deal As Additional Damage")]
		GeometryAttackPctTargetLifeToDealAsAdditionalDamage = 8077,

		[Description("Firestorm Target Radius Affected Only By Self")]
		FirestormTargetRadiusAffectedOnlyBySelf = 8078,

		[Description("Firestorm Explosion Radius Affected Only By Self")]
		FirestormExplosionRadiusAffectedOnlyBySelf = 8079,

		[Description("Omnitect Thruster Damage +% Final")]
		OmnitectThrusterDamagePosPctFinal = 8080,

		[Description("Skill Granted Omnitect Thruster Damage +% Final")]
		SkillGrantedOmnitectThrusterDamagePosPctFinal = 8081,

		[Description("Charged Dash Skill Inherent Movement Speed +% Final")]
		ChargedDashSkillInherentMovementSpeedPosPctFinal = 8082,

		[Description("Local Unique Flask Vaal Skill Damage +% Final During Flask Effect")]
		LocalUniqueFlaskVaalSkillDamagePosPctFinalDuringFlaskEffect = 8083,

		[Description("Soul Ripper Vaal Skill Damage +% Final")]
		SoulRipperVaalSkillDamagePosPctFinal = 8084,

		[Description("Vaal Storm Call Base Delay Ms")]
		VaalStormCallBaseDelayMs = 8085,

		[Description("Vaal Storm Call Delay Ms")]
		VaalStormCallDelayMs = 8086,

		[Description("Modifiers To Skill Effect Duration Also Affect Soul Prevention Duration")]
		ModifiersToSkillEffectDurationAlsoAffectSoulPreventionDuration = 8087,

		[Description("Modifiers To Buff Effect Duration Also Affect Soul Prevention Duration")]
		ModifiersToBuffEffectDurationAlsoAffectSoulPreventionDuration = 8088,

		[Description("Base Soul Prevention Time Ms")]
		BaseSoulPreventionTimeMs = 8089,

		[Description("Virtual Soul Prevention Time Ms")]
		VirtualSoulPreventionTimeMs = 8090,

		[Description("Map Atlas Influence Hash")]
		MapAtlasInfluenceHash = 8091,
		[Description("Effective Level")] EffectiveLevel = 8092,

		[Description("Effective Level Override")]
		EffectiveLevelOverride = 8093,

		[Description("Virtual Damage +% Final From Effective Level Permyriad")]
		VirtualDamagePosPctFinalFromEffectiveLevelPermyriad = 8094,

		[Description("Virtual Damage Taken +% Final From Effective Level")]
		VirtualDamageTakenPosPctFinalFromEffectiveLevel = 8095,

		[Description("Virtual Accuracy Rating +% Final From Effective Level")]
		VirtualAccuracyRatingPosPctFinalFromEffectiveLevel = 8096,

		[Description("Virtual Evasion Rating +% Final From Effective Level")]
		VirtualEvasionRatingPosPctFinalFromEffectiveLevel = 8097,

		[Description("Virtual Curse Effect +% Final From Effective Level")]
		VirtualCurseEffectPosPctFinalFromEffectiveLevel = 8098,

		[Description("Ignore Attacker Effective Level Modifiers")]
		IgnoreAttackerEffectiveLevelModifiers = 8099,

		[Description("Ignore Defender Effective Level Modifiers")]
		IgnoreDefenderEffectiveLevelModifiers = 8100,

		[Description("Physical Damage Taken Per Minute Unaffected By Level Scaling")]
		PhysicalDamageTakenPerMinuteUnaffectedByLevelScaling = 8101,

		[Description("Fire Damage Taken Per Minute Unaffected By Level Scaling")]
		FireDamageTakenPerMinuteUnaffectedByLevelScaling = 8102,

		[Description("Cold Damage Taken Per Minute Unaffected By Level Scaling")]
		ColdDamageTakenPerMinuteUnaffectedByLevelScaling = 8103,

		[Description("Lightning Damage Taken Per Minute Unaffected By Level Scaling")]
		LightningDamageTakenPerMinuteUnaffectedByLevelScaling = 8104,

		[Description("Chaos Damage Taken Per Minute Unaffected By Level Scaling")]
		ChaosDamageTakenPerMinuteUnaffectedByLevelScaling = 8105,

		[Description("Minion Owner Actual Level")]
		MinionOwnerActualLevel = 8106,

		[Description("Minion Owner Effective Level Override")]
		MinionOwnerEffectiveLevelOverride = 8107,

		[Description("Minion Owner Effective Level")]
		MinionOwnerEffectiveLevel = 8108,

		[Description("Map Delve % Degeneration Per Minute")]
		MapDelvePctDegenerationPerMinute = 8109,

		[Description("Base Unaffected By Delve Degeneration")]
		BaseUnaffectedByDelveDegeneration = 8110,
		[Description("Map Delve Rules")] MapDelveRules = 8111,

		[Description("Gain Endurance Charge On Melee Stun %")]
		GainEnduranceChargeOnMeleeStunPct = 8112,

		[Description("Intermediary Physical Damage To Deal Per Minute")]
		IntermediaryPhysicalDamageToDealPerMinute = 8113,

		[Description("Intermediary Physical Skill Dot Damage To Deal Per Minute")]
		IntermediaryPhysicalSkillDotDamageToDealPerMinute = 8114,

		[Description("Intermediary Physical Area Damage To Deal Per Minute")]
		IntermediaryPhysicalAreaDamageToDealPerMinute = 8115,

		[Description("Intermediary Physical Skill Dot Area Damage To Deal Per Minute")]
		IntermediaryPhysicalSkillDotAreaDamageToDealPerMinute = 8116,

		[Description("Intermediary Fire Damage To Deal Per Minute")]
		IntermediaryFireDamageToDealPerMinute = 8117,

		[Description("Intermediary Fire Skill Dot Damage To Deal Per Minute")]
		IntermediaryFireSkillDotDamageToDealPerMinute = 8118,

		[Description("Intermediary Fire Area Damage To Deal Per Minute")]
		IntermediaryFireAreaDamageToDealPerMinute = 8119,

		[Description("Intermediary Fire Skill Dot Area Damage To Deal Per Minute")]
		IntermediaryFireSkillDotAreaDamageToDealPerMinute = 8120,

		[Description("Intermediary Projectile Skill Dot Ground Fire Area Damage Per Minute")]
		IntermediaryProjectileSkillDotGroundFireAreaDamagePerMinute = 8121,

		[Description("Intermediary Cold Damage To Deal Per Minute")]
		IntermediaryColdDamageToDealPerMinute = 8122,

		[Description("Intermediary Cold Skill Dot Damage To Deal Per Minute")]
		IntermediaryColdSkillDotDamageToDealPerMinute = 8123,

		[Description("Intermediary Cold Area Damage To Deal Per Minute")]
		IntermediaryColdAreaDamageToDealPerMinute = 8124,

		[Description("Intermediary Cold Skill Dot Area Damage To Deal Per Minute")]
		IntermediaryColdSkillDotAreaDamageToDealPerMinute = 8125,

		[Description("Intermediary Lightning Damage To Deal Per Minute")]
		IntermediaryLightningDamageToDealPerMinute = 8126,

		[Description("Intermediary Lightning Skill Dot Damage To Deal Per Minute")]
		IntermediaryLightningSkillDotDamageToDealPerMinute = 8127,

		[Description("Intermediary Lightning Area Damage To Deal Per Minute")]
		IntermediaryLightningAreaDamageToDealPerMinute = 8128,

		[Description("Intermediary Lightning Skill Dot Area Damage To Deal Per Minute")]
		IntermediaryLightningSkillDotAreaDamageToDealPerMinute = 8129,

		[Description("Intermediary Chaos Damage To Deal Per Minute")]
		IntermediaryChaosDamageToDealPerMinute = 8130,

		[Description("Intermediary Chaos Skill Dot Damage To Deal Per Minute")]
		IntermediaryChaosSkillDotDamageToDealPerMinute = 8131,

		[Description("Intermediary Chaos Area Damage To Deal Per Minute")]
		IntermediaryChaosAreaDamageToDealPerMinute = 8132,

		[Description("Intermediary Chaos Skill Dot Area Damage To Deal Per Minute")]
		IntermediaryChaosSkillDotAreaDamageToDealPerMinute = 8133,

		[Description("Intermediary Projectile Skill Dot Ground Caustic Area Damage Per Minute")]
		IntermediaryProjectileSkillDotGroundCausticAreaDamagePerMinute = 8134,

		[Description("Map Area Underlevelled")]
		MapAreaUnderlevelled = 8135,

		[Description("Delve Monster Damage Taken +% Final")]
		DelveMonsterDamageTakenPosPctFinal = 8136,

		[Description("Base Ignite Damage Taken Per Minute")]
		BaseIgniteDamageTakenPerMinute = 8137,

		[Description("Base Poison Damage Taken Per Minute")]
		BasePoisonDamageTakenPerMinute = 8138,

		[Description("Base Self Chaos Damage Taken Per Minute")]
		BaseSelfChaosDamageTakenPerMinute = 8139,

		[Description("Base Number Of Clones Allowed")]
		BaseNumberOfClonesAllowed = 8140,

		[Description("Max Number Of Dominated Normal Monsters")]
		MaxNumberOfDominatedNormalMonsters = 8141,

		[Description("Max Number Of Dominated Magic Monsters")]
		MaxNumberOfDominatedMagicMonsters = 8142,

		[Description("Max Number Of Dominated Rare Monsters")]
		MaxNumberOfDominatedRareMonsters = 8143,

		[Description("Additional Max Number Of Dominated Magic Monsters")]
		AdditionalMaxNumberOfDominatedMagicMonsters = 8144,

		[Description("Additional Max Number Of Dominated Rare Monsters")]
		AdditionalMaxNumberOfDominatedRareMonsters = 8145,

		[Description("Number Of Dominated Monsters")]
		NumberOfDominatedMonsters = 8146,

		[Description("Number Of Dominated Normal Monsters")]
		NumberOfDominatedNormalMonsters = 8147,

		[Description("Number Of Dominated Magic Monsters")]
		NumberOfDominatedMagicMonsters = 8148,

		[Description("Number Of Dominated Rare Monsters")]
		NumberOfDominatedRareMonsters = 8149,

		[Description("Geometry Attack % Target Es To Deal As Additional Damage")]
		GeometryAttackPctTargetEsToDealAsAdditionalDamage = 8150,

		[Description("Minimum Added Lightning Damage From Skill")]
		MinimumAddedLightningDamageFromSkill = 8151,

		[Description("Maximum Added Lightning Damage From Skill")]
		MaximumAddedLightningDamageFromSkill = 8152,

		[Description("Base Chance To Shock % From Skill")]
		BaseChanceToShockPctFromSkill = 8153,

		[Description("Static Strike Number Of Beam Targets")]
		StaticStrikeNumberOfBeamTargets = 8154,

		[Description("Static Strike Additional Number Of Beam Targets")]
		StaticStrikeAdditionalNumberOfBeamTargets = 8155,

		[Description("Static Strike Base Zap Frequency Ms")]
		StaticStrikeBaseZapFrequencyMs = 8156,

		[Description("Static Strike Zap Speed +% Per Stack")]
		StaticStrikeZapSpeedPosPctPerStack = 8157,

		[Description("Local Jewel Copy Stats From Unallocated Non Notable Passives In Radius")]
		LocalJewelCopyStatsFromUnallocatedNonNotablePassivesInRadius = 8158,

		[Description("Local Jewel Allocated Non Notable Passives In Radius Grant Nothing")]
		LocalJewelAllocatedNonNotablePassivesInRadiusGrantNothing = 8159,

		[Description("Caustic Arrow Explode On Hit Base Area Of Effect Radius")]
		CausticArrowExplodeOnHitBaseAreaOfEffectRadius = 8160,

		[Description("Damage Over Time +% With Bow Skills")]
		DamageOverTimePosPctWithBowSkills = 8161,

		[Description("Damage Over Time +% With Attack Skills")]
		DamageOverTimePosPctWithAttackSkills = 8162,
		[Description("Skill Is Bow Skill")] SkillIsBowSkill = 8163,

		[Description("Map Players Cannot Gain Flask Charges")]
		MapPlayersCannotGainFlaskCharges = 8164,

		[Description("Cannot Gain Flask Charges")]
		CannotGainFlaskCharges = 8165,

		[Description("Trigger Socketed Warcry When Endurance Charge Expires Or Consumed % Chance")]
		TriggerSocketedWarcryWhenEnduranceChargeExpiresOrConsumedPctChance = 8166,

		[Description("Unique Socketed Warcry Triggered")]
		UniqueSocketedWarcryTriggered = 8167,

		[Description("Sacrifice % Maximum Life To Gain As Es On Spell Cast")]
		SacrificePctMaximumLifeToGainAsEsOnSpellCast = 8168,

		[Description("Unique Primordial Tether Golem Life +% Final")]
		UniquePrimordialTetherGolemLifePosPctFinal = 8169,

		[Description("Unique Primordial Tether Golem Damage +% Final")]
		UniquePrimordialTetherGolemDamagePosPctFinal = 8170,

		[Description("Golem Life +% Final From Unique Primordial Tether")]
		GolemLifePosPctFinalFromUniquePrimordialTether = 8171,

		[Description("Golem Damage +% Final From Unique Primordial Tether")]
		GolemDamagePosPctFinalFromUniquePrimordialTether = 8172,
		[Description("Golem Scale +%")] GolemScalePosPct = 8173,

		[Description("Virtual Current Number Of Keystones")]
		VirtualCurrentNumberOfKeystones = 8174,

		[Description("Additional Physical Damage Reduction % Per Keystone")]
		AdditionalPhysicalDamageReductionPctPerKeystone = 8175,

		[Description("Local Display Curse Enemies With Socketed Curse On Hit % Chance")]
		LocalDisplayCurseEnemiesWithSocketedCurseOnHitPctChance = 8176,

		[Description("Unique Curse Enemies With Socketed Curse On Hit % Chance")]
		UniqueCurseEnemiesWithSocketedCurseOnHitPctChance = 8177,

		[Description("Local Spells Gain Arcane Surge On Hit With Caster Abyss Jewel Socketed")]
		LocalSpellsGainArcaneSurgeOnHitWithCasterAbyssJewelSocketed = 8178,

		[Description("Gain Arcane Surge On Hit % Chance")]
		GainArcaneSurgeOnHitPctChance = 8179,

		[Description("Local Minion Accuracy Rating With Minion Abyss Jewel Socketed")]
		LocalMinionAccuracyRatingWithMinionAbyssJewelSocketed = 8180,

		[Description("Minion Accuracy Rating")]
		MinionAccuracyRating = 8181,
		[Description("Cannot Gain Bleeding")] CannotGainBleeding = 8182,

		[Description("Local Display Nearby Allies Extra Damage Rolls")]
		LocalDisplayNearbyAlliesExtraDamageRolls = 8183,

		[Description("Enemies Extra Damage Rolls With Lightning Damage")]
		EnemiesExtraDamageRollsWithLightningDamage = 8184,

		[Description("Number Of Additional Mines To Place With At Least 500 Int")]
		NumberOfAdditionalMinesToPlaceWithAtLeast500Int = 8185,

		[Description("Number Of Additional Mines To Place With At Least 500 Dex")]
		NumberOfAdditionalMinesToPlaceWithAtLeast500Dex = 8186,
		[Description("Delve In Antilight")] DelveInAntilight = 8187,

		[Description("Virtual Unaffected By Delve Degeneration")]
		VirtualUnaffectedByDelveDegeneration = 8188,

		[Description("Base Extra Damage Rolls")]
		BaseExtraDamageRolls = 8189,
		[Description("Delve Depth")] DelveDepth = 8190,

		[Description("Static Strike Beam Damage +% Final")]
		StaticStrikeBeamDamagePosPctFinal = 8191,

		[Description("Static Strike Beam Damage +% Final While Moving")]
		StaticStrikeBeamDamagePosPctFinalWhileMoving = 8192,

		[Description("Herald Of Agony Poison Damage +% Final")]
		HeraldOfAgonyPoisonDamagePosPctFinal = 8193,

		[Description("Herald Of Agony Add Stack On Poison")]
		HeraldOfAgonyAddStackOnPoison = 8194,

		[Description("Scorpion Minion Damage +%")]
		ScorpionMinionDamagePosPct = 8195,

		[Description("Scorpion Minion Attack Speed +%")]
		ScorpionMinionAttackSpeedPosPct = 8196,

		[Description("Scorpion Minion Minimum Added Physical Damage")]
		ScorpionMinionMinimumAddedPhysicalDamage = 8197,

		[Description("Scorpion Minion Maximum Added Physical Damage")]
		ScorpionMinionMaximumAddedPhysicalDamage = 8198,

		[Description("Base Number Of Herald Scorpions Allowed")]
		BaseNumberOfHeraldScorpionsAllowed = 8199,

		[Description("Number Of Herald Scorpions Allowed")]
		NumberOfHeraldScorpionsAllowed = 8200,
		[Description("Immune To Cheats")] ImmuneToCheats = 8201,

		[Description("Virulent Arrow Maximum Number Of Stacks")]
		VirulentArrowMaximumNumberOfStacks = 8202,

		[Description("Energy Shield Regeneration Rate +%")]
		EnergyShieldRegenerationRatePosPct = 8203,
		[Description("Is Dynamite Wall")] IsDynamiteWall = 8204,
		[Description("Dynamite Damage +%")] DynamiteDamagePosPct = 8205,

		[Description("Base Dynamite Damage Resistance %")]
		BaseDynamiteDamageResistancePct = 8206,

		[Description("Virtual Dynamite Damage Resistance %")]
		VirtualDynamiteDamageResistancePct = 8207,
		[Description("Base Skill Is Instant")] BaseSkillIsInstant = 8208,
		[Description("Skill Is Instant")] SkillIsInstant = 8209,

		[Description("Golem Movement Speed +%")]
		GolemMovementSpeedPosPct = 8210,

		[Description("Base Number Of Champions Of Light Allowed")]
		BaseNumberOfChampionsOfLightAllowed = 8211,

		[Description("Number Of Champions Of Light Allowed")]
		NumberOfChampionsOfLightAllowed = 8212,

		[Description("Herald Of Light Spell Minimum Added Physical Damage")]
		HeraldOfLightSpellMinimumAddedPhysicalDamage = 8213,

		[Description("Herald Of Light Spell Maximum Added Physical Damage")]
		HeraldOfLightSpellMaximumAddedPhysicalDamage = 8214,

		[Description("Herald Of Light Attack Minimum Added Physical Damage")]
		HeraldOfLightAttackMinimumAddedPhysicalDamage = 8215,

		[Description("Herald Of Light Attack Maximum Added Physical Damage")]
		HeraldOfLightAttackMaximumAddedPhysicalDamage = 8216,

		[Description("Herald Of Light Summon Champion On Kill")]
		HeraldOfLightSummonChampionOnKill = 8217,

		[Description("Herald Of Light Summon Champion On Unique Enemy Hit %")]
		HeraldOfLightSummonChampionOnUniqueEnemyHitPct = 8218,

		[Description("Rain Of Spores Vines Movement Speed +% Final")]
		RainOfSporesVinesMovementSpeedPosPctFinal = 8219,

		[Description("Dominating Blow Chance To Summon On Hitting Unqiue %")]
		DominatingBlowChanceToSummonOnHittingUnqiuePct = 8220,

		[Description("Virulent Arrow Pod Projectile Damage +% Final")]
		VirulentArrowPodProjectileDamagePosPctFinal = 8221,

		[Description("Virulent Arrow Damage +% Final Per Stage")]
		VirulentArrowDamagePosPctFinalPerStage = 8222,

		[Description("Virulent Arrow Number Of Additional Pod Projectiles")]
		VirulentArrowNumberOfAdditionalPodProjectiles = 8223,
		[Description("Delve Flare Id")] DelveFlareId = 8224,
		[Description("Delve Dynamite Id")] DelveDynamiteId = 8225,
		[Description("Maximum Spell Block %")] MaximumSpellBlockPct = 8226,

		[Description("Minion Accuracy Rating +%")]
		MinionAccuracyRatingPosPct = 8227,

		[Description("Modifiers To Totem Duration Also Affect Soul Prevention Duration")]
		ModifiersToTotemDurationAlsoAffectSoulPreventionDuration = 8228,
		[Description("In Grace Period")] InGracePeriod = 8229,

		[Description("Combined Base Spell Block %")]
		CombinedBaseSpellBlockPct = 8230,

		[Description("Spell Block Equals Attack Block")]
		SpellBlockEqualsAttackBlock = 8231,

		[Description("Local Item Sell Price Doubled")]
		LocalItemSellPriceDoubled = 8232,

		[Description("Base Number Of Relics Allowed")]
		BaseNumberOfRelicsAllowed = 8233,

		[Description("Number Of Relics Allowed")]
		NumberOfRelicsAllowed = 8234,

		[Description("Number Of Active Relics")]
		NumberOfActiveRelics = 8235,

		[Description("Holy Relic Trigger On Parent Attack %")]
		HolyRelicTriggerOnParentAttackPct = 8236,

		[Description("Local Display Nearby Enemy Fire Damage Resistance %")]
		LocalDisplayNearbyEnemyFireDamageResistancePct = 8237,

		[Description("Local Display Nearby Enemy Cold Damage Resistance %")]
		LocalDisplayNearbyEnemyColdDamageResistancePct = 8238,

		[Description("Local Display Nearby Enemy Lightning Damage Resistance %")]
		LocalDisplayNearbyEnemyLightningDamageResistancePct = 8239,

		[Description("Local Display Nearby Enemy Chaos Damage Resistance %")]
		LocalDisplayNearbyEnemyChaosDamageResistancePct = 8240,

		[Description("Local Display Nearby Enemy Physical Damage Taken +%")]
		LocalDisplayNearbyEnemyPhysicalDamageTakenPosPct = 8241,

		[Description("Chance To Intimidate On Hit %")]
		ChanceToIntimidateOnHitPct = 8242,

		[Description("Physical Damage Reduction Rating If You Have Hit An Enemy Recently")]
		PhysicalDamageReductionRatingIfYouHaveHitAnEnemyRecently = 8243,

		[Description("Evasion Rating + If You Have Hit An Enemy Recently")]
		EvasionRatingPosIfYouHaveHitAnEnemyRecently = 8244,

		[Description("Energy Shield Regeneration Rate Per Minute % If You Have Hit An Enemy Recently")]
		EnergyShieldRegenerationRatePerMinutePctIfYouHaveHitAnEnemyRecently = 8245,

		[Description("Maximum Energy Shield From Body Armour +%")]
		MaximumEnergyShieldFromBodyArmourPosPct = 8246,

		[Description("Base Body Armour Maximum Energy Shield")]
		BaseBodyArmourMaximumEnergyShield = 8247,

		[Description("Local Chance For Poison Damage +100% Final Inflicted With This Weapon")]
		LocalChanceForPoisonDamagePos100PctFinalInflictedWithThisWeapon = 8248,

		[Description("Local Chance For Bleeding Damage +100% Final Inflicted With This Weapon")]
		LocalChanceForBleedingDamagePos100PctFinalInflictedWithThisWeapon = 8249,

		[Description("Local Display Socketed Spell Damage +% Final")]
		LocalDisplaySocketedSpellDamagePosPctFinal = 8250,

		[Description("Local Display Socketed Attack Damage +% Final")]
		LocalDisplaySocketedAttackDamagePosPctFinal = 8251,

		[Description("Minimum Added Physical Damage Vs Poisoned Enemies")]
		MinimumAddedPhysicalDamageVsPoisonedEnemies = 8252,

		[Description("Maximum Added Physical Damage Vs Poisoned Enemies")]
		MaximumAddedPhysicalDamageVsPoisonedEnemies = 8253,

		[Description("Minimum Added Physical Damage Vs Bleeding Enemies")]
		MinimumAddedPhysicalDamageVsBleedingEnemies = 8254,

		[Description("Maximum Added Physical Damage Vs Bleeding Enemies")]
		MaximumAddedPhysicalDamageVsBleedingEnemies = 8255,

		[Description("Local Display Socketed Skills Cast Speed +%")]
		LocalDisplaySocketedSkillsCastSpeedPosPct = 8256,

		[Description("Local Display Socketed Spells Mana Cost +%")]
		LocalDisplaySocketedSpellsManaCostPosPct = 8257,

		[Description("Local Display Socketed Skills Attack Speed +%")]
		LocalDisplaySocketedSkillsAttackSpeedPosPct = 8258,

		[Description("Local Display Socketed Attacks Mana Cost +")]
		LocalDisplaySocketedAttacksManaCostPos = 8259,

		[Description("Maximum Spell Block Chance Per 50 Strength")]
		MaximumSpellBlockChancePer50Strength = 8260,

		[Description("Block Chance % Per 50 Strength")]
		BlockChancePctPer50Strength = 8261,

		[Description("Base Maximum Spell Block %")]
		BaseMaximumSpellBlockPct = 8262,

		[Description("Local Display Nearby Enemies Stun And Block Recovery +%")]
		LocalDisplayNearbyEnemiesStunAndBlockRecoveryPosPct = 8263,

		[Description("Local Display Nearby Enemies Flask Charges Granted +%")]
		LocalDisplayNearbyEnemiesFlaskChargesGrantedPosPct = 8264,

		[Description("Local Display Nearby Enemies Additional Chance To Take Critical Strike %")]
		LocalDisplayNearbyEnemiesAdditionalChanceToTakeCriticalStrikePct = 8265,

		[Description("Virtual Gain Flask Charge On Crit Chance %")]
		VirtualGainFlaskChargeOnCritChancePct = 8266,

		[Description("Gain Flask Charge On Crit Chance % While At Maximum Frenzy Charges")]
		GainFlaskChargeOnCritChancePctWhileAtMaximumFrenzyCharges = 8267,

		[Description("Movement Speed +% Per Endurance Charge")]
		MovementSpeedPosPctPerEnduranceCharge = 8268,

		[Description("Movement Speed +% Per Power Charge")]
		MovementSpeedPosPctPerPowerCharge = 8269,

		[Description("Life Regeneration Rate Per Minute % Per Power Charge")]
		LifeRegenerationRatePerMinutePctPerPowerCharge = 8270,

		[Description("Minimum Added Fire Damage Per Endurance Charge")]
		MinimumAddedFireDamagePerEnduranceCharge = 8271,

		[Description("Maximum Added Fire Damage Per Endurance Charge")]
		MaximumAddedFireDamagePerEnduranceCharge = 8272,

		[Description("Minimum Added Lightning Damage Per Power Charge")]
		MinimumAddedLightningDamagePerPowerCharge = 8273,

		[Description("Maximum Added Lightning Damage Per Power Charge")]
		MaximumAddedLightningDamagePerPowerCharge = 8274,

		[Description("Additional Attack Block % Per Endurance Charge")]
		AdditionalAttackBlockPctPerEnduranceCharge = 8275,

		[Description("Additional Attack Block % Per Frenzy Charge")]
		AdditionalAttackBlockPctPerFrenzyCharge = 8276,

		[Description("Additional Attack Block % Per Power Charge")]
		AdditionalAttackBlockPctPerPowerCharge = 8277,

		[Description("Chance To Dodge Attacks % Per Endurance Charge")]
		ChanceToDodgeAttacksPctPerEnduranceCharge = 8278,

		[Description("Chance To Dodge Attacks % Per Power Charge")]
		ChanceToDodgeAttacksPctPerPowerCharge = 8279,

		[Description("Fire Damage % To Add As Chaos Per Endurance Charge")]
		FireDamagePctToAddAsChaosPerEnduranceCharge = 8280,

		[Description("Cold Damage % To Add As Chaos Per Frenzy Charge")]
		ColdDamagePctToAddAsChaosPerFrenzyCharge = 8281,

		[Description("Lightning Damage % To Add As Chaos Per Power Charge")]
		LightningDamagePctToAddAsChaosPerPowerCharge = 8282,

		[Description("Physical Damage Reduction Rating +% Per Endurance Charge")]
		PhysicalDamageReductionRatingPosPctPerEnduranceCharge = 8283,

		[Description("Energy Shield +% Per Power Charge")]
		EnergyShieldPosPctPerPowerCharge = 8284,

		[Description("Gain Maximum Frenzy Charges On Frenzy Charge Gained % Chance")]
		GainMaximumFrenzyChargesOnFrenzyChargeGainedPctChance = 8285,

		[Description("Attack And Cast Speed +% Per Endurance Charge")]
		AttackAndCastSpeedPosPctPerEnduranceCharge = 8286,

		[Description("Attack And Cast Speed +% Per Power Charge")]
		AttackAndCastSpeedPosPctPerPowerCharge = 8287,

		[Description("Critical Strike Chance +% Per Endurance Charge")]
		CriticalStrikeChancePosPctPerEnduranceCharge = 8288,

		[Description("Critical Strike Chance +% Per Frenzy Charge")]
		CriticalStrikeChancePosPctPerFrenzyCharge = 8289,

		[Description("Physical Damage Reduction Percent Per Frenzy Charge")]
		PhysicalDamageReductionPercentPerFrenzyCharge = 8290,

		[Description("Physical Damage Reduction Percent Per Power Charge")]
		PhysicalDamageReductionPercentPerPowerCharge = 8291,

		[Description("Gain Vaal Pact While At Maximum Endurance Charges")]
		GainVaalPactWhileAtMaximumEnduranceCharges = 8292,

		[Description("Gain Iron Reflexes While At Maximum Frenzy Charges")]
		GainIronReflexesWhileAtMaximumFrenzyCharges = 8293,

		[Description("Gain Mind Over Matter While At Maximum Power Charges")]
		GainMindOverMatterWhileAtMaximumPowerCharges = 8294,

		[Description("Local Grants Aura Minimum Added Fire Damage Per Red Socket")]
		LocalGrantsAuraMinimumAddedFireDamagePerRedSocket = 8295,

		[Description("Local Grants Aura Maximum Added Fire Damage Per Red Socket")]
		LocalGrantsAuraMaximumAddedFireDamagePerRedSocket = 8296,

		[Description("Local Grants Aura Minimum Added Cold Damage Per Green Socket")]
		LocalGrantsAuraMinimumAddedColdDamagePerGreenSocket = 8297,

		[Description("Local Grants Aura Maximum Added Cold Damage Per Green Socket")]
		LocalGrantsAuraMaximumAddedColdDamagePerGreenSocket = 8298,

		[Description("Local Grants Aura Minimum Added Lightning Damage Per Blue Socket")]
		LocalGrantsAuraMinimumAddedLightningDamagePerBlueSocket = 8299,

		[Description("Local Grants Aura Maximum Added Lightning Damage Per Blue Socket")]
		LocalGrantsAuraMaximumAddedLightningDamagePerBlueSocket = 8300,

		[Description("Local Grants Aura Minimum Added Chaos Damage Per White Socket")]
		LocalGrantsAuraMinimumAddedChaosDamagePerWhiteSocket = 8301,

		[Description("Local Grants Aura Maximum Added Chaos Damage Per White Socket")]
		LocalGrantsAuraMaximumAddedChaosDamagePerWhiteSocket = 8302,

		[Description("Virtual Keystone Mind Over Matter")]
		VirtualKeystoneMindOverMatter = 8303,

		[Description("Delve Mod Spell Damage +% Final")]
		DelveModSpellDamagePosPctFinal = 8304,

		[Description("Delve Mod Attack Damage +% Final")]
		DelveModAttackDamagePosPctFinal = 8305,

		[Description("Delve Sulphite Capacity")]
		DelveSulphiteCapacity = 8306,
		[Description("Delve Flare Capacity")] DelveFlareCapacity = 8307,

		[Description("Delve Dynamite Capacity")]
		DelveDynamiteCapacity = 8308,
		[Description("Delve Light Radius +%")] DelveLightRadiusPosPct = 8309,
		[Description("Delve Flare Radius +%")] DelveFlareRadiusPosPct = 8310,

		[Description("Delve Dynamite Radius +%")]
		DelveDynamiteRadiusPosPct = 8311,

		[Description("Delve Dynamite Damage +%")]
		DelveDynamiteDamagePosPct = 8312,

		[Description("Delve Darkness Resistance %")]
		DelveDarknessResistancePct = 8313,

		[Description("Delve Flare Duration +%")]
		DelveFlareDurationPosPct = 8314,

		[Description("Physical Damage Reduction Rating Per 5 Evasion On Shield")]
		PhysicalDamageReductionRatingPer5EvasionOnShield = 8315,

		[Description("Evasion Rating + Per 5 Maximum Energy Shield On Shield")]
		EvasionRatingPosPer5MaximumEnergyShieldOnShield = 8316,

		[Description("Maximum Energy Shield + Per 5 Armour On Shield")]
		MaximumEnergyShieldPosPer5ArmourOnShield = 8317,

		[Description("Life Leech From Spell Damage Permyriad If Shield Has 30% Block Chance")]
		LifeLeechFromSpellDamagePermyriadIfShieldHas30PctBlockChance = 8318,

		[Description("Local Display Nearby Enemies All Resistances %")]
		LocalDisplayNearbyEnemiesAllResistancesPct = 8319,

		[Description("Support Phys Chaos Projectile Spell Physical Projectile Damage +% Final")]
		SupportPhysChaosProjectileSpellPhysicalProjectileDamagePosPctFinal = 8320,

		[Description("Support Phys Chaos Projectile Physical Damage Over Time +% Final")]
		SupportPhysChaosProjectilePhysicalDamageOverTimePosPctFinal = 8321,

		[Description("Support Phys Chaos Projectile Chaos Damage Over Time +% Final")]
		SupportPhysChaosProjectileChaosDamageOverTimePosPctFinal = 8322,

		[Description("Combined Spell Physical Damage Pluspercent Final")]
		CombinedSpellPhysicalDamagePluspercentFinal = 8323,

		[Description("Chance To Double Armour Effect On Hit %")]
		ChanceToDoubleArmourEffectOnHitPct = 8324,

		[Description("Minion Targeting Use Parent Location")]
		MinionTargetingUseParentLocation = 8325,

		[Description("Minion Aggro Range Scaled By Distance To Parent Target")]
		MinionAggroRangeScaledByDistanceToParentTarget = 8326,

		[Description("Support Chaos Attacks Damage +% Final")]
		SupportChaosAttacksDamagePosPctFinal = 8327,

		[Description("Intimidate On Hit Chance With Attacks While At Maximum Endurance Charges %")]
		IntimidateOnHitChanceWithAttacksWhileAtMaximumEnduranceChargesPct = 8328,

		[Description("Gain Onslaught On Hit Chance While At Maximum Frenzy Charges %")]
		GainOnslaughtOnHitChanceWhileAtMaximumFrenzyChargesPct = 8329,

		[Description("Gain Arcane Surge On Hit Chance With Spells While At Maximum Power Charges %")]
		GainArcaneSurgeOnHitChanceWithSpellsWhileAtMaximumPowerChargesPct = 8330,

		[Description("Number Of Additional Curses Allowed While At Maximum Power Charges")]
		NumberOfAdditionalCursesAllowedWhileAtMaximumPowerCharges = 8331,

		[Description("Virtual Number Of Additional Curses Allowed")]
		VirtualNumberOfAdditionalCursesAllowed = 8332,

		[Description("On Weapon Global Damage +%")]
		OnWeaponGlobalDamagePosPct = 8333,

		[Description("Anger Reserves No Mana")]
		AngerReservesNoMana = 8334,

		[Description("Clarity Reserves No Mana")]
		ClarityReservesNoMana = 8335,

		[Description("Determination Reserves No Mana")]
		DeterminationReservesNoMana = 8336,

		[Description("Discipline Reserves No Mana")]
		DisciplineReservesNoMana = 8337,

		[Description("Grace Reserves No Mana")]
		GraceReservesNoMana = 8338,

		[Description("Haste Reserves No Mana")]
		HasteReservesNoMana = 8339,

		[Description("Hatred Reserves No Mana")]
		HatredReservesNoMana = 8340,

		[Description("Purity Of Elements Reserves No Mana")]
		PurityOfElementsReservesNoMana = 8341,

		[Description("Purity Of Fire Reserves No Mana")]
		PurityOfFireReservesNoMana = 8342,

		[Description("Purity Of Ice Reserves No Mana")]
		PurityOfIceReservesNoMana = 8343,

		[Description("Purity Of Lightning Reserves No Mana")]
		PurityOfLightningReservesNoMana = 8344,

		[Description("Vitality Reserves No Mana")]
		VitalityReservesNoMana = 8345,

		[Description("Wrath Reserves No Mana")]
		WrathReservesNoMana = 8346,
		[Description("Envy Reserves No Mana")] EnvyReservesNoMana = 8347,

		[Description("Local Display Socketed Gems Supported By Level X Chaos Attacks")]
		LocalDisplaySocketedGemsSupportedByLevelXChaosAttacks = 8348,

		[Description("Have Your Skills Crit Recently")]
		HaveYourSkillsCritRecently = 8349,

		[Description("Track Have Your Skills Crit Recently")]
		TrackHaveYourSkillsCritRecently = 8350,

		[Description("Delve Flare Duration Ms +")]
		DelveFlareDurationMsPos = 8351,

		[Description("Display Map Augmentable Boss")]
		DisplayMapAugmentableBoss = 8352,

		[Description("Virtual Poison Damage +100% Final Chance")]
		VirtualPoisonDamagePos100PctFinalChance = 8353,

		[Description("Pathfinder Poison Damage +100% Final Chance During Flask Effect")]
		PathfinderPoisonDamagePos100PctFinalChanceDuringFlaskEffect = 8354,

		[Description("Chaos Skills Area Of Effect +%")]
		ChaosSkillsAreaOfEffectPosPct = 8355,

		[Description("Minions Chance To Intimidate On Hit %")]
		MinionsChanceToIntimidateOnHitPct = 8356,

		[Description("You And Nearby Allies Life Regeneration Rate Per Minute % If You Hit An Enemy Recently")]
		YouAndNearbyAlliesLifeRegenerationRatePerMinutePctIfYouHitAnEnemyRecently = 8357,

		[Description("Herald Of Light Buff Effect +%")]
		HeraldOfLightBuffEffectPosPct = 8358,

		[Description("Herald Of Light Minion Area Of Effect +%")]
		HeraldOfLightMinionAreaOfEffectPosPct = 8359,

		[Description("Area Of Effect +% Per Active Herald Of Light Minion")]
		AreaOfEffectPosPctPerActiveHeraldOfLightMinion = 8360,

		[Description("Herald Of Light And Dominating Blow Minions Use Holy Slam")]
		HeraldOfLightAndDominatingBlowMinionsUseHolySlam = 8361,

		[Description("Herald Of Agony Buff Drop Off Speed +%")]
		HeraldOfAgonyBuffDropOffSpeedPosPct = 8362,

		[Description("Damage +% Final With At Least 1 Nearby Ally")]
		DamagePosPctFinalWithAtLeast1NearbyAlly = 8363,

		[Description("Number Of Nearby Allies")]
		NumberOfNearbyAllies = 8364,

		[Description("Track Number Of Nearby Allies")]
		TrackNumberOfNearbyAllies = 8365,

		[Description("Override Turn Duration Ms")]
		OverrideTurnDurationMs = 8366,

		[Description("Minimum Rain Of Spores Movement Speed +% Final Cap")]
		MinimumRainOfSporesMovementSpeedPosPctFinalCap = 8367,

		[Description("Number Of Active Herald Of Light Minions")]
		NumberOfActiveHeraldOfLightMinions = 8368,
		[Description("Uses Holy Slam Skill")] UsesHolySlamSkill = 8369,

		[Description("Secondary Minion Duration")]
		SecondaryMinionDuration = 8370,

		[Description("Apply Azurite Debuff On Hit Ms")]
		ApplyAzuriteDebuffOnHitMs = 8371,

		[Description("Delve Monster Life +% Final")]
		DelveMonsterLifePosPctFinal = 8372,

		[Description("Delve Monster Damage +% Final")]
		DelveMonsterDamagePosPctFinal = 8373,

		[Description("Additive Modifiers To Bow Damage Also Apply To Minions")]
		AdditiveModifiersToBowDamageAlsoApplyToMinions = 8374,
		[Description("Minion Bow Damage +%")] MinionBowDamagePosPct = 8375,

		[Description("Minion Physical Bow Damage +%")]
		MinionPhysicalBowDamagePosPct = 8376,

		[Description("Minion Fire Bow Damage +%")]
		MinionFireBowDamagePosPct = 8377,

		[Description("Minion Cold Bow Damage +%")]
		MinionColdBowDamagePosPct = 8378,

		[Description("Minion Lightning Bow Damage +%")]
		MinionLightningBowDamagePosPct = 8379,

		[Description("Minion Chaos Bow Damage +%")]
		MinionChaosBowDamagePosPct = 8380,

		[Description("Minion Elemental Bow Damage +%")]
		MinionElementalBowDamagePosPct = 8381,

		[Description("Lightning Bow Damage +%")]
		LightningBowDamagePosPct = 8382,
		[Description("Chaos Bow Damage +%")] ChaosBowDamagePosPct = 8383,

		[Description("Current Delve Degen Stacks")]
		CurrentDelveDegenStacks = 8384,

		[Description("Max Delve Degen Stacks")]
		MaxDelveDegenStacks = 8385,
		[Description("Spell Block Luck")] SpellBlockLuck = 8386,
		[Description("Base Spell Block Luck")] BaseSpellBlockLuck = 8387,

		[Description("Current Azurite Debuff Stacks")]
		CurrentAzuriteDebuffStacks = 8388,

		[Description("Max Azurite Debuff Stacks")]
		MaxAzuriteDebuffStacks = 8389,

		[Description("Ascendancy Pathfinder Chaos Damage With Attack Skills +% Final")]
		AscendancyPathfinderChaosDamageWithAttackSkillsPosPctFinal = 8390,

		[Description("Monster Ignores Delve Darkness Mechanic")]
		MonsterIgnoresDelveDarknessMechanic = 8391,

		[Description("Skill Withered Duration Ms")]
		SkillWitheredDurationMs = 8392,

		[Description("Support Withered Base Duration Ms")]
		SupportWitheredBaseDurationMs = 8393,

		[Description("Withered On Hit Chance %")]
		WitheredOnHitChancePct = 8394,

		[Description("Combined Attack Speed +%")]
		CombinedAttackSpeedPosPct = 8395,

		[Description("Combined Main Hand Attack Speed +%")]
		CombinedMainHandAttackSpeedPosPct = 8396,

		[Description("Combined Off Hand Attack Speed +%")]
		CombinedOffHandAttackSpeedPosPct = 8397,

		[Description("Combined Attack Speed +% Final")]
		CombinedAttackSpeedPosPctFinal = 8398,

		[Description("Distribute Additional Projectiles Over Contact Points")]
		DistributeAdditionalProjectilesOverContactPoints = 8399,

		[Description("Number Of Blood Meteors To Create")]
		NumberOfBloodMeteorsToCreate = 8400,

		[Description("Number Of Blood Meteors To Fire")]
		NumberOfBloodMeteorsToFire = 8401,
		[Description("No Experience Gain")] NoExperienceGain = 8402,

		[Description("Delve Darkness Damage Taken Per Minute")]
		DelveDarknessDamageTakenPerMinute = 8403,

		[Description("Delve Base Darkness Damage Percent Of Maximum Life Taken Per Minute")]
		DelveBaseDarknessDamagePercentOfMaximumLifeTakenPerMinute = 8404,

		[Description("Delve Base Darkness Damage Percent Of Maximum Energy Shield Taken Per Minute")]
		DelveBaseDarknessDamagePercentOfMaximumEnergyShieldTakenPerMinute = 8405,

		[Description("Delve Total Darkness Damage Taken Per Minute")]
		DelveTotalDarknessDamageTakenPerMinute = 8406,

		[Description("Holy Relic Cooldown Recovery +%")]
		HolyRelicCooldownRecoveryPosPct = 8407,

		[Description("Smite Chance For Lighting To Strike Extra Target %")]
		SmiteChanceForLightingToStrikeExtraTargetPct = 8408,
		[Description("Smite Aura Effect +%")] SmiteAuraEffectPosPct = 8409,

		[Description("Holy Path Teleport Range +%")]
		HolyPathTeleportRangePosPct = 8410,

		[Description("Holy Relic Area Of Effect +%")]
		HolyRelicAreaOfEffectPosPct = 8411,
		[Description("Holy Relic Damage +%")] HolyRelicDamagePosPct = 8412,

		[Description("Holy Relic Buff Effect +%")]
		HolyRelicBuffEffectPosPct = 8413,

		[Description("Mana Regeneration Rate Per Minute % If Enemy Hit Recently")]
		ManaRegenerationRatePerMinutePctIfEnemyHitRecently = 8414,

		[Description("Movement Speed +% If Enemy Hit Recently")]
		MovementSpeedPosPctIfEnemyHitRecently = 8415,

		[Description("Attack And Cast Speed +% If Enemy Hit Recently")]
		AttackAndCastSpeedPosPctIfEnemyHitRecently = 8416,

		[Description("Cannot Be Shocked Or Ignited While Moving")]
		CannotBeShockedOrIgnitedWhileMoving = 8417,

		[Description("Cannot Be Chilled Or Frozen While Moving")]
		CannotBeChilledOrFrozenWhileMoving = 8418,

		[Description("Chance To Gain Onslaught On Flask Use %")]
		ChanceToGainOnslaughtOnFlaskUsePct = 8419,

		[Description("Add Frenzy Charge When Hit %")]
		AddFrenzyChargeWhenHitPct = 8420,

		[Description("Mana Regeneration Rate Per Minute If Enemy Hit Recently")]
		ManaRegenerationRatePerMinuteIfEnemyHitRecently = 8421,

		[Description("Curse On Hit Level Frostbite")]
		CurseOnHitLevelFrostbite = 8422,

		[Description("Curse On Hit Level Conductivity")]
		CurseOnHitLevelConductivity = 8423,

		[Description("Gain Spirit Charge Every X Ms")]
		GainSpiritChargeEveryXMs = 8424,

		[Description("Lose Spirit Charges On Savage Hit Taken")]
		LoseSpiritChargesOnSavageHitTaken = 8425,

		[Description("Gain % Es When Spirit Charge Expires Or Consumed")]
		GainPctEsWhenSpiritChargeExpiresOrConsumed = 8426,

		[Description("Skill Buff Grants Chance To Poison %")]
		SkillBuffGrantsChanceToPoisonPct = 8427,

		[Description("Active Skill Withered Base Duration Ms")]
		ActiveSkillWitheredBaseDurationMs = 8428,

		[Description("Caustic Arrow Withered Base Duration Ms")]
		CausticArrowWitheredBaseDurationMs = 8429,

		[Description("Caustic Arrow Withered On Hit %")]
		CausticArrowWitheredOnHitPct = 8430,

		[Description("Herald Scorpion Number Of Additional Projectiles")]
		HeraldScorpionNumberOfAdditionalProjectiles = 8431,

		[Description("Virulent Arrow Chance To Poison % Per Stage")]
		VirulentArrowChanceToPoisonPctPerStage = 8432,

		[Description("Virulent Arrow Additional Spores At Max Stages")]
		VirulentArrowAdditionalSporesAtMaxStages = 8433,
		[Description("Smite Damage +%")] SmiteDamagePosPct = 8434,

		[Description("Consecrated Path Damage +%")]
		ConsecratedPathDamagePosPct = 8435,

		[Description("Consecrated Path Area Of Effect +%")]
		ConsecratedPathAreaOfEffectPosPct = 8436,

		[Description("Herald Of Purity Mana Reservation +%")]
		HeraldOfPurityManaReservationPosPct = 8437,

		[Description("Herald Of Agony Mana Reservation +%")]
		HeraldOfAgonyManaReservationPosPct = 8438,

		[Description("Scourge Arrow Damage +%")]
		ScourgeArrowDamagePosPct = 8439,
		[Description("Toxic Rain Damage +%")] ToxicRainDamagePosPct = 8440,

		[Description("Toxic Rain Num Of Additional Projectiles")]
		ToxicRainNumOfAdditionalProjectiles = 8441,

		[Description("Toxic Rain Physical Damage % To Add As Chaos")]
		ToxicRainPhysicalDamagePctToAddAsChaos = 8442,

		[Description("Number Of Support Ghosts Allowed")]
		NumberOfSupportGhostsAllowed = 8443,
		[Description("Player In Breach")] PlayerInBreach = 8444,

		[Description("Virtual Spread Poison To Nearby Enemies On Kill")]
		VirtualSpreadPoisonToNearbyEnemiesOnKill = 8445,

		[Description("Unique Spread Poison To Nearby Enemies During Flask Effect")]
		UniqueSpreadPoisonToNearbyEnemiesDuringFlaskEffect = 8446,

		[Description("Elemental Hit Deals 50% Less Fire Damage")]
		ElementalHitDeals50PctLessFireDamage = 8447,

		[Description("Elemental Hit Deals 50% Less Cold Damage")]
		ElementalHitDeals50PctLessColdDamage = 8448,

		[Description("Elemental Hit Deals 50% Less Lightning Damage")]
		ElementalHitDeals50PctLessLightningDamage = 8449,

		[Description("Local Unique Jewel Elemental Hit 50% Less Fire Damage Per 40 Int And Dex")]
		LocalUniqueJewelElementalHit50PctLessFireDamagePer40IntAndDex = 8450,

		[Description("Local Unique Jewel Elemental Hit 50% Less Cold Damage Per 40 Str And Int")]
		LocalUniqueJewelElementalHit50PctLessColdDamagePer40StrAndInt = 8451,

		[Description("Local Unique Jewel Elemental Hit 50% Less Lightning Damage Per 40 Str And Dex")]
		LocalUniqueJewelElementalHit50PctLessLightningDamagePer40StrAndDex = 8452,

		[Description("Active Skill Fire Damage +% Final From Skill Specific Stat")]
		ActiveSkillFireDamagePosPctFinalFromSkillSpecificStat = 8453,

		[Description("Active Skill Cold Damage +% Final From Skill Specific Stat")]
		ActiveSkillColdDamagePosPctFinalFromSkillSpecificStat = 8454,

		[Description("Active Skill Lightning Damage +% Final From Skill Specific Stat")]
		ActiveSkillLightningDamagePosPctFinalFromSkillSpecificStat = 8455,

		[Description("Spell Block % While On Low Life")]
		SpellBlockPctWhileOnLowLife = 8456,

		[Description("Base Block Chance % From Shield")]
		BaseBlockChancePctFromShield = 8457,

		[Description("Skill Deals 50% Less Fire Damage")]
		SkillDeals50PctLessFireDamage = 8458,

		[Description("Skill Deals 50% Less Cold Damage")]
		SkillDeals50PctLessColdDamage = 8459,

		[Description("Skill Deals 50% Less Lightning Damage")]
		SkillDeals50PctLessLightningDamage = 8460,
		[Description("Melee Variation")] MeleeVariation = 8461,

		[Description("Map Monsters Penetrate Elemental Resistances %")]
		MapMonstersPenetrateElementalResistancesPct = 8462,

		[Description("Map Monsters Remove Charges On Hit %")]
		MapMonstersRemoveChargesOnHitPct = 8463,

		[Description("Boss Maximum Life +% Final")]
		BossMaximumLifePosPctFinal = 8464,

		[Description("Spell Block With Bow %")]
		SpellBlockWithBowPct = 8465,

		[Description("Affected By Herald Of Agony")]
		AffectedByHeraldOfAgony = 8466,

		[Description("Affected By Herald Of Purity")]
		AffectedByHeraldOfPurity = 8467,

		[Description("Delve Monster Curse Effect +% Final")]
		DelveMonsterCurseEffectPosPctFinal = 8468
	}
}