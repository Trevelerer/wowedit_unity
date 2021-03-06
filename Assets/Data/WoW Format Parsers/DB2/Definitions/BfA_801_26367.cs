public static partial class DB2
{
	public static class Definitions_BfA_801_26367
	{
		public class _Achievement
		{
			string Description;
			string Title;
			string Reward;
			int Flags;
			ushort InstanceId;
			ushort Supercedes;
			ushort Category;
			ushort UiOrder;
			ushort SharesCriteria;
			byte Faction;
			byte MinimumCriteria;
			byte Points;
			int ID;
			int IconFileId;
			int CriteriaTree;
		}
		public class _Achievement_Category
		{
			string Name;
			ushort Parent;
			byte UiOrder;
			int ID;
		}
		public class _AdventureJournal
		{
			int ID;
			string Name;
			string Description;
			string ButtonText;
			string RewardDescription;
			string ContinueDescription;
			int TextureFileDataId;
			int[] BonusPlayerConditionId = new int[2];
			int ItemId;
			ushort LfgDungeonId;
			ushort QuestId;
			ushort BattleMasterListId;
			ushort CurrencyType;
			ushort WorldMapAreaId;
			byte Type;
			byte Flags;
			byte ButtonActionType;
			byte PriorityMin;
			byte PriorityMax;
			byte[] BonusValue = new byte[2];
			byte CurrencyQuantity;
			int PlayerConditionId;
			int ItemQuantity;
		}
		public class _AdventureMapPOI
		{
			int ID;
			string Title;
			string Description;
			float[] WorldPosition = new float[2];
			int RewardItemId;
			uint MapId;
			byte Type;
			int PlayerConditionId;
			int QuestId;
			int LfgDungeonId;
			int UiTextureAtlasMemberId;
			int UiTextureKitId;
			int AreaTableId;
		}
		public class _AlliedRace
		{
			int BannerColor;
			int ID;
			int RaceId;
			int CrestTextureId;
			int ModelBackgroundTextureId;
			int MaleCreatureDisplayId;
			int FemaleCreatureDisplayId;
			int UiUnlockAchievementId;
		}
		public class _AlliedRaceRacialAbility
		{
			int ID;
			string Name;
			string Description;
			byte OrderIndex;
			int IconFileDataId;
		}
		public class _AnimationData
		{
			int ID;
			uint[] Flags = new uint[2];
			ushort BehaviorId;
			ushort Fallback;
			byte BehaviorTier;
		}
		public class _AnimKit
		{
			int ID;
			int OneShotDuration;
			ushort OneShotStopAnimKitId;
			ushort LowDefAnimKitId;
		}
		public class _AnimKitBoneSet
		{
			int ID;
			string Name;
			byte BoneDataId;
			byte ParentAnimKitBoneSetId;
			byte ExtraBoneCount;
			byte AltAnimKitBoneSetId;
		}
		public class _AnimKitBoneSetAlias
		{
			int ID;
			byte BoneDataId;
			byte AnimKitBoneSetId;
		}
		public class _AnimKitConfig
		{
			int ID;
			int ConfigFlags;
		}
		public class _AnimKitConfigBoneSet
		{
			int ID;
			ushort AnimKitPriorityId;
			byte AnimKitBoneSetId;
		}
		public class _AnimKitPriority
		{
			int ID;
			byte Priority;
		}
		public class _AnimKitReplacement
		{
			ushort SrcAnimKitId;
			ushort DstAnimKitId;
			ushort Flags;
			int ID;
		}
		public class _AnimKitSegment
		{
			int ID;
			int AnimStartTime;
			int EndConditionParam;
			int EndConditionDelay;
			float Speed;
			uint OverrideConfigFlags;
			ushort ParentAnimKitId;
			ushort AnimId;
			ushort AnimKitConfigId;
			ushort SegmentFlags;
			ushort BlendInTimeMs;
			ushort BlendOutTimeMs;
			byte OrderIndex;
			byte StartCondition;
			byte StartConditionParam;
			byte EndCondition;
			byte ForcedVariation;
			byte LoopToSegmentIndex;
			int StartConditionDelay;
		}
		public class _AnimReplacement
		{
			ushort SrcAnimId;
			ushort DstAnimId;
			ushort Flags;
			int ID;
		}
		public class _AnimReplacementSet
		{
			int ID;
			byte ExecOrder;
		}
		public class _AreaFarClipOverride
		{
			int AreaId;
			float MinFarClip;
			float MinHorizonStart;
			int Flags;
			int ID;
		}
		public class _AreaGroupMember
		{
			int ID;
			ushort AreaId;
		}
		public class _AreaPOI
		{
			string Name;
			string Description;
			int ID;
			float[] Pos = new float[3];
			int Flags;
			int PoiDataType;
			int PoiData;
			ushort ContinentId;
			ushort AreaId;
			ushort WorldStateId;
			byte Importance;
			byte Icon;
			int PortLocId;
			int PlayerConditionId;
			int UiTextureAtlasMemberId;
			int WmoGroupId;
		}
		public class _AreaPOIState
		{
			int ID;
			string Description;
			byte WorldStateValue;
			byte IconEnumValue;
			int UiTextureAtlasMemberId;
		}
		public class _AreaTable
		{
			int ID;
			string ZoneName;
			string AreaName;
			uint[] Flags = new uint[2];
			float AmbientMultiplier;
			ushort ContinentId;
			ushort ParentAreaId;
			ushort AreaBit;
			ushort AmbienceId;
			ushort UwAmbience;
			ushort ZoneMusic;
			ushort UwZoneMusic;
			ushort IntroSound;
			ushort[] LiquidTypeId = new ushort[4];
			ushort PvpCombatWorldStateId;
			byte SoundProviderPref;
			byte SoundProviderPrefUnderwater;
			byte ExplorationLevel;
			byte FactionGroupMask;
			byte MountFlags;
			byte WildBattlePetLevelMin;
			byte WildBattlePetLevelMax;
			byte WindSettingsId;
			int UwIntroSound;
		}
		public class _AreaTrigger
		{
			float[] Pos = new float[3];
			float Radius;
			float BoxLength;
			float BoxWidth;
			float BoxHeight;
			float BoxYaw;
			ushort ContinentId;
			ushort PhaseId;
			ushort PhaseGroupId;
			ushort ShapeId;
			ushort AreaTriggerActionSetId;
			byte PhaseUseFlags;
			byte ShapeType;
			byte Flags;
			int ID;
		}
		public class _AreaTriggerActionSet
		{
			int ID;
			ushort Flags;
		}
		public class _AreaTriggerBox
		{
			int ID;
			float[] Extents = new float[3];
		}
		public class _AreaTriggerCreateProperties
		{
			int ID;
			ushort StartShapeId;
			byte ShapeType;
		}
		public class _AreaTriggerCylinder
		{
			int ID;
			float Radius;
			float Height;
			float ZOffset;
		}
		public class _AreaTriggerSphere
		{
			int ID;
			float MaxRadius;
		}
		public class _ArmorLocation
		{
			int ID;
			float Clothmodifier;
			float Leathermodifier;
			float Chainmodifier;
			float Platemodifier;
			float Modifier;
		}
		public class _Artifact
		{
			int ID;
			string Name;
			uint UiNameColor;
			uint UiBarOverlayColor;
			int UiBarBackgroundColor;
			ushort UiTextureKitId;
			ushort ChrSpecializationId;
			byte Flags;
			byte ArtifactCategoryId;
			int UiModelSceneId;
			int SpellVisualKitId;
		}
		public class _ArtifactAppearance
		{
			string Name;
			uint UiSwatchColor;
			float UiModelSaturation;
			float UiModelOpacity;
			int OverrideShapeshiftDisplayId;
			ushort ArtifactAppearanceSetId;
			ushort UiCameraId;
			byte DisplayIndex;
			byte ItemAppearanceModifierId;
			byte OverrideShapeshiftFormId;
			byte Flags;
			int ID;
			int UnlockPlayerConditionId;
			int UiItemAppearanceId;
			int UiAltItemAppearanceId;
		}
		public class _ArtifactAppearanceSet
		{
			string Name;
			string Description;
			ushort UiCameraId;
			ushort AltHandUICameraId;
			byte DisplayIndex;
			byte ForgeAttachmentOverride;
			byte Flags;
			int ID;
		}
		public class _ArtifactCategory
		{
			int ID;
			ushort XpMultCurrencyId;
			ushort XpMultCurveId;
		}
		public class _ArtifactPower
		{
			float[] DisplayPos = new float[2];
			byte ArtifactId;
			byte MaxPurchasableRank;
			byte Flags;
			byte Tier;
			int ID;
			int Label;
		}
		public class _ArtifactPowerLink
		{
			int ID;
			ushort PowerA;
			ushort PowerB;
		}
		public class _ArtifactPowerPicker
		{
			int ID;
			int PlayerConditionId;
		}
		public class _ArtifactPowerRank
		{
			int ID;
			int SpellId;
			float AuraPointsOverride;
			ushort ItemBonusListId;
			byte RankIndex;
		}
		public class _ArtifactQuestXP
		{
			int ID;
			int[] Difficulty = new int[10];
		}
		public class _ArtifactTier
		{
			int ID;
			int ArtifactTier;
			int MaxNumTraits;
			int MaxArtifactKnowledge;
			int KnowledgePlayerCondition;
			int MinimumEmpowerKnowledge;
		}
		public class _ArtifactUnlock
		{
			int ID;
			ushort ItemBonusListId;
			byte PowerRank;
			int PowerId;
			int PlayerConditionId;
		}
		public class _AuctionHouse
		{
			int ID;
			string Name;
			ushort FactionId;
			byte DepositRate;
			byte ConsignmentRate;
		}
		public class _AzeriteEmpoweredItem
		{
			int ID;
			int ItemId;
			int AzeriteTierUnlockSetId;
			int AzeritePowerSetId;
		}
		public class _AzeriteItem
		{
			int ID;
			int ItemId;
		}
		public class _AzeriteItemMilestonePower
		{
			int ID;
			ushort AzeritePowerId;
			byte RequiredLevel;
		}
		public class _AzeritePower
		{
			int ID;
			int SpellId;
			int ItemBonusListId;
		}
		public class _AzeritePowerSetMember
		{
			int ID;
			ushort AzeritePowerId;
			byte Class;
			byte Tier;
			byte OrderIndex;
		}
		public class _AzeriteTierUnlock
		{
			int ID;
			byte ItemCreationContext;
			byte Tier;
			byte AzeriteLevel;
		}
		public class _BankBagSlotPrices
		{
			int ID;
			int Cost;
		}
		public class _BannedAddOns
		{
			int ID;
			string Name;
			string Version;
			byte Flags;
		}
		public class _BarberShopStyle
		{
			string DisplayName;
			string Description;
			float CostModifier;
			byte Type;
			byte Race;
			byte Sex;
			byte Data;
			int ID;
		}
		public class _BattlemasterList
		{
			int ID;
			string Name;
			string GameType;
			string ShortDescription;
			string LongDescription;
			int IconFileDataId;
			ushort[] MapId = new ushort[16];
			ushort HolidayWorldState;
			ushort RequiredPlayerConditionId;
			byte InstanceType;
			byte MinLevel;
			byte MaxLevel;
			byte RatedPlayers;
			byte MinPlayers;
			byte MaxPlayers;
			byte GroupsAllowed;
			byte MaxGroupSize;
			byte Flags;
		}
		public class _BattlePetAbility
		{
			int ID;
			string Name;
			string Description;
			int IconFileDataId;
			ushort BattlePetVisualId;
			byte PetTypeEnum;
			byte Flags;
			int Cooldown;
		}
		public class _BattlePetAbilityEffect
		{
			ushort BattlePetAbilityTurnId;
			ushort BattlePetEffectPropertiesId;
			ushort AuraBattlePetAbilityId;
			ushort BattlePetVisualId;
			ushort[] Param = new ushort[6];
			byte OrderIndex;
			int ID;
		}
		public class _BattlePetAbilityState
		{
			int ID;
			uint Value;
			byte BattlePetStateId;
		}
		public class _BattlePetAbilityTurn
		{
			ushort BattlePetAbilityId;
			ushort BattlePetVisualId;
			byte OrderIndex;
			byte TurnTypeEnum;
			byte EventTypeEnum;
			int ID;
		}
		public class _BattlePetBreedQuality
		{
			int ID;
			float StateMultiplier;
			byte QualityEnum;
		}
		public class _BattlePetBreedState
		{
			int ID;
			ushort Value;
			byte BattlePetStateId;
		}
		public class _BattlePetDisplayOverride
		{
			int ID;
			int BattlePetSpeciesId;
			int PlayerConditionId;
			int CreatureDisplayInfoId;
			byte PriorityCategory;
		}
		public class _BattlePetEffectProperties
		{
			int ID;
			string[] ParamLabel = new string[6];
			ushort BattlePetVisualId;
			byte[] ParamTypeEnum = new byte[6];
		}
		public class _BattlePetNPCTeamMember
		{
			int ID;
			string Name;
		}
		public class _BattlePetSpecies
		{
			string Description;
			string SourceText;
			int CreatureId;
			int SummonSpellId;
			int IconFileDataId;
			ushort Flags;
			byte PetTypeEnum;
			byte SourceTypeEnum;
			int ID;
			int CardUIModelSceneId;
			int LoadoutUIModelSceneId;
		}
		public class _BattlePetSpeciesState
		{
			int ID;
			uint Value;
			byte BattlePetStateId;
		}
		public class _BattlePetSpeciesXAbility
		{
			int ID;
			ushort BattlePetAbilityId;
			byte RequiredLevel;
			byte SlotEnum;
		}
		public class _BattlePetState
		{
			int ID;
			string LuaName;
			ushort Flags;
			ushort BattlePetVisualId;
		}
		public class _BattlePetVisual
		{
			int ID;
			string SceneScriptFunction;
			int SpellVisualId;
			ushort CastMilliSeconds;
			ushort ImpactMilliSeconds;
			ushort SceneScriptPackageId;
			byte RangeTypeEnum;
			byte Flags;
		}
		public class _BeamEffect
		{
			int ID;
			int BeamId;
			float SourceMinDistance;
			float FixedLength;
			int Flags;
			int SourceOffset;
			int DestOffset;
			int SourceAttachId;
			int DestAttachId;
			int SourcePositionerId;
			int DestPositionerId;
		}
		public class _BoneWindModifierModel
		{
			int ID;
			int FileDataId;
			int BoneWindModifierId;
		}
		public class _BoneWindModifiers
		{
			int ID;
			float[] Multiplier = new float[3];
			float PhaseMultiplier;
		}
		public class _BonusRoll
		{
			int ID;
			int CurrencyTypesId;
			int CurrencyCost;
			int JournalEncounterId;
			int JournalInstanceId;
		}
		public class _Bounty
		{
			int ID;
			int IconFileDataId;
			ushort QuestId;
			ushort FactionId;
			int TurninPlayerConditionId;
		}
		public class _BountySet
		{
			int ID;
			ushort LockedQuestId;
			int VisiblePlayerConditionId;
		}
		public class _BroadcastText
		{
			string Text;
			string Text1;
			int ID;
			int[] SoundEntriesId = new int[2];
			ushort EmotesId;
			ushort[] EmoteId = new ushort[3];
			ushort[] EmoteDelay = new ushort[3];
			byte LanguageId;
			byte Flags;
			int ConditionId;
		}
		public class _BroadcastTextVOState
		{
			int ID;
			byte State;
		}
		public class _CameraEffect
		{
			int ID;
			byte Flags;
		}
		public class _CameraEffectEntry
		{
			int ID;
			float Duration;
			float Delay;
			float Phase;
			float Amplitude;
			float AmplitudeB;
			float Frequency;
			float RadiusMin;
			float RadiusMax;
			ushort AmplitudeCurveId;
			byte OrderIndex;
			byte Flags;
			byte EffectType;
			byte DirectionType;
			byte MovementType;
			byte AttenuationType;
		}
		public class _CameraMode
		{
			int ID;
			float[] PositionOffset = new float[3];
			float[] TargetOffset = new float[3];
			float PositionSmoothing;
			float RotationSmoothing;
			float FieldOfView;
			ushort Flags;
			byte Type;
			byte LockedPositionOffsetBase;
			byte LockedPositionOffsetDirection;
			byte LockedTargetOffsetBase;
			byte LockedTargetOffsetDirection;
		}
		public class _CastableRaidBuffs
		{
			int ID;
			int CastingSpellId;
		}
		public class _CelestialBody
		{
			int BaseFileDataId;
			float BodyBaseScale;
			float[] Position = new float[3];
			int[] GlowMaskFileDataId = new int[2];
			float[] GlowMaskScale = new float[2];
			int[] GlowModifiedFileDataId = new int[2];
			int AtmosphericMaskFileDataId;
			int AtmosphericModifiedFileDataId;
			float[] ScrollURate = new float[2];
			float[] ScrollVRate = new float[2];
			float RotateRate;
			float AtmosphericMaskScale;
			int LightMaskFileDataId;
			ushort SkyArrayBand;
			int ID;
		}
		public class _Cfg_Categories
		{
			int ID;
			string Name;
			ushort LocaleMask;
			byte CreateCharsetMask;
			byte ExistingCharsetMask;
			byte Flags;
		}
		public class _Cfg_Configs
		{
			int ID;
			float MaxDamageReductionPctPhysical;
			ushort PlayerAttackSpeedBase;
			byte PlayerKillingAllowed;
			byte Roleplaying;
		}
		public class _Cfg_Regions
		{
			int ID;
			string Tag;
			int Raidorigin;
			int ChallengeOrigin;
			ushort RegionId;
			byte RegionGroupMask;
		}
		public class _CharacterFaceBoneSet
		{
			int ID;
			int ModelFileDataId;
			int BoneSetFileDataId;
			byte SexId;
			byte FaceVariationIndex;
		}
		public class _CharacterFacialHairStyles
		{
			int ID;
			uint[] Geoset = new uint[5];
			byte RaceId;
			byte SexId;
			byte VariationId;
		}
		public class _CharacterLoadout
		{
			int ID;
			ulong RaceMask;
			byte ChrClassId;
			byte Purpose;
		}
		public class _CharacterLoadoutItem
		{
			int ID;
			int ItemId;
			ushort CharacterLoadoutId;
		}
		public class _CharacterServiceInfo
		{
			int ID;
			string FlowTitle;
			string PopupTitle;
			string PopupDescription;
			int BoostType;
			int IconFileDataId;
			int Priority;
			int Flags;
			int ProfessionLevel;
			int BoostLevel;
			int Expansion;
			int PopupUITextureKitId;
		}
		public class _CharBaseInfo
		{
			int ID;
			byte RaceId;
			byte ClassId;
		}
		public class _CharBaseSection
		{
			int ID;
			byte LayoutResType;
			byte VariationEnum;
			byte ResolutionVariationEnum;
		}
		public class _CharComponentTextureLayouts
		{
			int ID;
			ushort Width;
			ushort Height;
		}
		public class _CharComponentTextureSections
		{
			int ID;
			int OverlapSectionMask;
			ushort X;
			ushort Y;
			ushort Width;
			ushort Height;
			byte CharComponentTextureLayoutId;
			byte SectionType;
		}
		public class _CharHairGeosets
		{
			int ID;
			int HdCustomGeoFileDataId;
			byte RaceId;
			byte SexId;
			byte VariationId;
			byte GeosetId;
			byte Showscalp;
			byte VariationType;
			byte GeosetType;
			byte ColorIndex;
			int CustomGeoFileDataId;
		}
		public class _CharSections
		{
			int ID;
			int[] MaterialResourcesId = new int[3];
			ushort Flags;
			byte RaceId;
			byte SexId;
			byte BaseSection;
			byte VariationIndex;
			byte ColorIndex;
		}
		public class _CharShipment
		{
			int ID;
			int DummyItemId;
			int TreasureId;
			int SpellId;
			int OnCompleteSpellId;
			int Duration;
			ushort ContainerId;
			ushort GarrFollowerId;
			byte MaxShipments;
			byte Flags;
		}
		public class _CharShipmentContainer
		{
			int ID;
			string Description;
			string PendingText;
			int WorkingSpellVisualId;
			ushort UiTextureKitId;
			ushort SmallDisplayInfoId;
			ushort MediumDisplayInfoId;
			ushort LargeDisplayInfoId;
			ushort WorkingDisplayInfoId;
			ushort CrossFactionId;
			byte GarrTypeId;
			byte GarrBuildingType;
			byte BaseCapacity;
			byte MediumThreshold;
			byte LargeThreshold;
			byte Faction;
			int CompleteSpellVisualId;
		}
		public class _CharStartOutfit
		{
			int ID;
			int[] ItemId = new int[24];
			int PetDisplayId;
			byte ClassId;
			byte SexId;
			byte OutfitId;
			byte PetFamilyId;
		}
		public class _CharTitles
		{
			int ID;
			string Name;
			string Name1;
			ushort MaskId;
			byte Flags;
		}
		public class _ChatChannels
		{
			int ID;
			string Name;
			string Shortcut;
			int Flags;
			byte FactionGroup;
		}
		public class _ChatProfanity
		{
			int ID;
			string Text;
			byte Language;
		}
		public class _ChrClasses
		{
			string Name;
			string Filename;
			string NameMale;
			string NameFemale;
			string PetNameToken;
			int CreateScreenFileDataId;
			int SelectScreenFileDataId;
			int IconFileDataId;
			int LowResScreenFileDataId;
			int StartingLevel;
			ushort Flags;
			ushort CinematicSequenceId;
			ushort DefaultSpec;
			byte PrimaryStatPriority;
			byte DisplayPower;
			byte RangedAttackPowerPerAgility;
			byte AttackPowerPerAgility;
			byte AttackPowerPerStrength;
			byte SpellClassSet;
			int ID;
		}
		public class _ChrClassesXPowerTypes
		{
			int ID;
			byte PowerType;
		}
		public class _ChrClassRaceSex
		{
			int ID;
			byte ClassId;
			byte RaceId;
			byte Sex;
			int Flags;
			int SoundId;
			int VoiceSoundFilterId;
		}
		public class _ChrClassTitle
		{
			int ID;
			string NameMale;
			string NameFemale;
			byte ChrClassId;
		}
		public class _ChrClassUIDisplay
		{
			int ID;
			byte ChrClassesId;
			int AdvGuidePlayerConditionId;
			int SplashPlayerConditionId;
		}
		public class _ChrClassVillain
		{
			int ID;
			string Name;
			byte ChrClassId;
			byte Gender;
		}
		public class _ChrCustomization
		{
			int ID;
			string Name;
			int Sex;
			int BaseSection;
			int UiCustomizationType;
			int Flags;
			int[] ComponentSection = new int[3];
		}
		public class _ChrRaces
		{
			string ClientPrefix;
			string ClientFileString;
			string Name;
			string NameFemale;
			string NameLowercase;
			string NameFemaleLowercase;
			int Flags;
			int MaleDisplayId;
			int FemaleDisplayId;
			int CreateScreenFileDataId;
			int SelectScreenFileDataId;
			float[] MaleCustomizeOffset = new float[3];
			float[] FemaleCustomizeOffset = new float[3];
			int LowResScreenFileDataId;
			int StartingLevel;
			int UiDisplayOrder;
			float MaleModelFallbackArmor2Scale;
			float FemaleModelFallbackArmor2Scale;
			ushort FactionId;
			ushort CinematicSequenceId;
			ushort ResSicknessSpellId;
			ushort SplashSoundId;
			byte BaseLanguage;
			byte CreatureType;
			byte Alliance;
			byte RaceRelated;
			byte UnalteredVisualRaceId;
			byte CharComponentTextureLayoutId;
			byte CharComponentTexLayoutHiResId;
			byte DefaultClassId;
			byte NeutralRaceId;
			byte MaleModelFallbackRaceId;
			byte MaleModelFallbackSex;
			byte FemaleModelFallbackRaceId;
			byte FemaleModelFallbackSex;
			byte MaleTextureFallbackRaceId;
			byte MaleTextureFallbackSex;
			byte FemaleTextureFallbackRaceId;
			byte FemaleTextureFallbackSex;
			int ID;
			int HighResMaleDisplayId;
			int HighResFemaleDisplayId;
			int HeritageArmorAchievementId;
			int FemaleSkeletonFileDataId;
			int MaleSkeletonFileDataId;
			int[] AlteredFormStartVisualKitId = new int[3];
			int[] AlteredFormFinishVisualKitId = new int[3];
		}
		public class _ChrSpecialization
		{
			string Name;
			string FemaleName;
			string Description;
			int[] MasterySpellId = new int[2];
			byte ClassId;
			byte OrderIndex;
			byte PetTalentType;
			byte Role;
			byte PrimaryStatPriority;
			int ID;
			int Flags;
			int SpellIconFileId;
			int AnimReplacements;
		}
		public class _ChrUpgradeBucket
		{
			ushort ChrSpecializationId;
			int ID;
		}
		public class _ChrUpgradeBucketSpell
		{
			int ID;
			int SpellId;
		}
		public class _ChrUpgradeTier
		{
			string DisplayName;
			byte OrderIndex;
			byte NumTalents;
			int ID;
		}
		public class _CinematicCamera
		{
			int ID;
			int SoundId;
			float[] Origin = new float[3];
			float OriginFacing;
			int FileDataId;
		}
		public class _CinematicSequences
		{
			int ID;
			int SoundId;
			ushort[] Camera = new ushort[8];
		}
		public class _ClientSceneEffect
		{
			int ID;
			int SceneScriptPackageId;
		}
		public class _CloakDampening
		{
			int ID;
			float[] Angle = new float[5];
			float[] Dampening = new float[5];
			float[] TailAngle = new float[2];
			float[] TailDampening = new float[2];
			float TabardAngle;
			float TabardDampening;
			float ExpectedWeaponSize;
		}
		public class _CombatCondition
		{
			int ID;
			ushort WorldStateExpressionId;
			ushort SelfConditionId;
			ushort TargetConditionId;
			ushort[] FriendConditionId = new ushort[2];
			ushort[] EnemyConditionId = new ushort[2];
			byte[] FriendConditionOp = new byte[2];
			byte[] FriendConditionCount = new byte[2];
			byte FriendConditionLogic;
			byte[] EnemyConditionOp = new byte[2];
			byte[] EnemyConditionCount = new byte[2];
			byte EnemyConditionLogic;
		}
		public class _CommentatorStartLocation
		{
			int ID;
			float[] Pos = new float[3];
			int MapId;
		}
		public class _CommentatorTrackedCooldown
		{
			int ID;
			byte Priority;
			byte Flags;
			int SpellId;
		}
		public class _ComponentModelFileData
		{
			int ID;
			byte GenderIndex;
			byte ClassId;
			byte RaceId;
			byte PositionIndex;
		}
		public class _ComponentTextureFileData
		{
			int ID;
			byte GenderIndex;
			byte ClassId;
			byte RaceId;
		}
		public class _ConfigurationWarning
		{
			int ID;
			string Warning;
			int Type;
		}
		public class _ContentTuning
		{
			int ID;
			int MinLevel;
			int MaxLevel;
			int Flags;
			int ExpectedStatModId;
		}
		public class _Contribution
		{
			string Description;
			string Name;
			int ID;
			int ManagedWorldStateInputId;
			int[] UiTextureAtlasMemberId = new int[4];
			int OrderIndex;
		}
		public class _ConversationLine
		{
			int ID;
			int BroadcastTextId;
			int SpellVisualKitId;
			uint AdditionalDuration;
			ushort NextConversationLineId;
			ushort AnimKitId;
			byte SpeechType;
			byte StartAnimation;
			byte EndAnimation;
		}
		public class _Creature
		{
			int ID;
			string Name;
			string NameAlt;
			string Title;
			string TitleAlt;
			int[] DisplayId = new int[4];
			float[] DisplayProbability = new float[4];
			int[] AlwaysItem = new int[3];
			int MountCreatureId;
			byte Classification;
			byte CreatureType;
			byte CreatureFamily;
			byte StartAnimState;
		}
		public class _CreatureDifficulty
		{
			int ID;
			uint[] Flags = new uint[7];
			ushort FactionId;
			byte ExpansionId;
			byte MinLevel;
			byte MaxLevel;
			int ContentTuningId;
		}
		public class _CreatureDisplayInfo
		{
			int ID;
			float CreatureModelScale;
			ushort ModelId;
			ushort NPCSoundId;
			byte SizeClass;
			byte Flags;
			byte Gender;
			ushort SoundId;
			byte CreatureModelAlpha;
			byte BloodId;
			int ExtendedDisplayInfoId;
			ushort ParticleColorId;
			int PortraitCreatureDisplayInfoId;
			int PortraitTextureFileDataId;
			ushort ObjectEffectPackageId;
			ushort AnimReplacementSetId;
			int StateSpellVisualKitId;
			float PlayerOverrideScale;
			float PetInstanceScale;
			byte UnarmedWeaponType;
			int MountPoofSpellVisualKitId;
			int DissolveEffectId;
			int[] TextureVariationFileDataId = new int[3];
		}
		public class _CreatureDisplayInfoCond
		{
			int ID;
			ulong RaceMask;
			uint[] CustomOption0Mask = new uint[2];
			int[] CustomOption1Mask = new int[2];
			int[] CustomOption2Mask = new int[2];
			byte OrderIndex;
			byte Gender;
			int ClassMask;
			int SkinColorMask;
			int HairColorMask;
			int HairStyleMask;
			int FaceStyleMask;
			int FacialHairStyleMask;
			int CreatureModelDataId;
			int[] TextureVariationFileDataId = new int[3];
		}
		public class _CreatureDisplayInfoEvt
		{
			int ID;
			int Fourcc;
			int SpellVisualKitId;
			byte Flags;
		}
		public class _CreatureDisplayInfoExtra
		{
			int ID;
			int BakeMaterialResourcesId;
			int HDBakeMaterialResourcesId;
			byte DisplayRaceId;
			byte DisplaySexId;
			byte DisplayClassId;
			byte SkinId;
			byte FaceId;
			byte HairStyleId;
			byte HairColorId;
			byte FacialHairId;
			byte[] CustomDisplayOption = new byte[3];
			byte Flags;
		}
		public class _CreatureDisplayInfoGeosetData
		{
			int ID;
			byte GeosetIndex;
			byte GeosetValue;
		}
		public class _CreatureDisplayInfoTrn
		{
			int ID;
			int DstCreatureDisplayInfoId;
			float MaxTime;
			int DissolveEffectId;
			int StartVisualKitId;
			int FinishVisualKitId;
		}
		public class _CreatureDispXUiCamera
		{
			int ID;
			int CreatureDisplayInfoId;
			ushort UiCameraId;
		}
		public class _CreatureFamily
		{
			int ID;
			string Name;
			float MinScale;
			float MaxScale;
			int IconFileId;
			ushort[] SkillLine = new ushort[2];
			ushort PetFoodMask;
			byte MinScaleLevel;
			byte MaxScaleLevel;
			byte PetTalentType;
		}
		public class _CreatureImmunities
		{
			int ID;
			int[] Mechanic = new int[2];
			byte School;
			byte MechanicsAllowed;
			byte EffectsAllowed;
			byte StatesAllowed;
			byte Flags;
			int DispelType;
			int[] Effect = new int[9];
			int[] State = new int[16];
		}
		public class _CreatureModelData
		{
			int ID;
			float FootprintTextureLength;
			float FootprintTextureWidth;
			float FootprintParticleScale;
			float CollisionWidth;
			float CollisionHeight;
			float WorldEffectScale;
			float HoverHeight;
			float AttachedEffectScale;
			float ModelScale;
			float MissileCollisionRadius;
			float MissileCollisionPush;
			float MissileCollisionRaise;
			float MountHeight;
			float OverrideLootEffectScale;
			float OverrideNameScale;
			float OverrideSelectionRadius;
			float TamedPetBaseScale;
			float[] GeoBox = new float[6];
			int Flags;
			int FileDataId;
			int BloodId;
			int FootprintTextureId;
			int FoleyMaterialId;
			int FootstepCameraEffectId;
			int DeathThudCameraEffectId;
			int SoundId;
			int SizeClass;
			int CreatureGeosetDataId;
		}
		public class _CreatureMovementInfo
		{
			int ID;
			float SmoothFacingChaseRate;
		}
		public class _CreatureSoundData
		{
			int ID;
			float FidgetDelaySecondsMin;
			float FidgetDelaySecondsMax;
			byte CreatureImpactType;
			int SoundExertionId;
			int SoundExertionCriticalId;
			int SoundInjuryId;
			int SoundInjuryCriticalId;
			int SoundInjuryCrushingBlowId;
			int SoundDeathId;
			int SoundStunId;
			int SoundStandId;
			int SoundFootstepId;
			int SoundAggroId;
			int SoundWingFlapId;
			int SoundWingGlideId;
			int SoundAlertId;
			int SoundJumpStartId;
			int SoundJumpEndId;
			int SoundPetAttackId;
			int SoundPetOrderId;
			int SoundPetDismissId;
			int LoopSoundId;
			int BirthSoundId;
			int SpellCastDirectedSoundId;
			int SubmergeSoundId;
			int SubmergedSoundId;
			int WindupSoundId;
			int WindupCriticalSoundId;
			int ChargeSoundId;
			int ChargeCriticalSoundId;
			int BattleShoutSoundId;
			int BattleShoutCriticalSoundId;
			int TauntSoundId;
			int CreatureSoundDataIDPet;
			int NPCSoundId;
			int[] SoundFidget = new int[5];
			int[] CustomAttack = new int[4];
		}
		public class _CreatureType
		{
			int ID;
			string Name;
			byte Flags;
		}
		public class _CreatureXContribution
		{
			int ID;
			int ContributionId;
		}
		public class _CreatureXDisplayInfo
		{
			int ID;
			int CreatureDisplayInfoId;
			float Probability;
			float Scale;
			byte OrderIndex;
		}
		public class _Criteria
		{
			int ID;
			int Asset;
			int ModifierTreeId;
			int StartAsset;
			uint FailAsset;
			ushort StartTimer;
			ushort EligibilityWorldStateId;
			byte Type;
			byte StartEvent;
			byte FailEvent;
			byte Flags;
			byte EligibilityWorldStateValue;
		}
		public class _CriteriaTree
		{
			int ID;
			string Description;
			int Amount;
			ushort Flags;
			byte Operator;
			int Parent;
			int CriteriaId;
			int OrderIndex;
		}
		public class _CriteriaTreeXEffect
		{
			int ID;
			ushort WorldEffectId;
		}
		public class _CurrencyCategory
		{
			int ID;
			string Name;
			byte Flags;
			byte ExpansionId;
		}
		public class _CurrencyContainer
		{
			int ID;
			string ContainerName;
			string ContainerDescription;
			int MinAmount;
			int MaxAmount;
			int ContainerIconId;
			int ContainerQuality;
		}
		public class _CurrencyTypes
		{
			int ID;
			string Name;
			string Description;
			int MaxQty;
			int MaxEarnablePerWeek;
			int Flags;
			byte CategoryId;
			byte SpellCategory;
			byte Quality;
			int InventoryIconFileId;
			int SpellWeight;
		}
		public class _Curve
		{
			int ID;
			byte Type;
			byte Flags;
		}
		public class _CurvePoint
		{
			int ID;
			float[] Pos = new float[2];
			ushort CurveId;
			byte OrderIndex;
		}
		public class _DeathThudLookups
		{
			int ID;
			byte SizeClass;
			byte TerrainTypeSoundId;
			int SoundEntryId;
			int SoundEntryIDWater;
		}
		public class _DecalProperties
		{
			int ID;
			int FileDataId;
			float ModX;
			float InnerRadius;
			float OuterRadius;
			float Rim;
			float Gain;
			float Scale;
			float FadeIn;
			float FadeOut;
			byte Priority;
			byte BlendMode;
			int TopTextureBlendSetId;
			int BotTextureBlendSetId;
			int Flags;
			int GameFlags;
			int CasterDecalPropertiesId;
		}
		public class _DeclinedWord
		{
			string Word;
			int ID;
		}
		public class _DeclinedWordCases
		{
			int ID;
			string DeclinedWord;
			byte CaseIndex;
		}
		public class _DestructibleModelData
		{
			int ID;
			ushort State1Wmo;
			ushort State2Wmo;
			ushort State3Wmo;
			ushort State0Wmo;
			ushort HealEffectSpeed;
			byte State0ImpactEffectDoodadSet;
			byte State0AmbientDoodadSet;
			byte State1DestructionDoodadSet;
			byte State1ImpactEffectDoodadSet;
			byte State1AmbientDoodadSet;
			byte State2DestructionDoodadSet;
			byte State2ImpactEffectDoodadSet;
			byte State2AmbientDoodadSet;
			byte State3InitDoodadSet;
			byte State3AmbientDoodadSet;
			byte EjectDirection;
			byte DoNotHighlight;
			byte HealEffect;
			byte State0NameSet;
			byte State1NameSet;
			byte State2NameSet;
			byte State3NameSet;
		}
		public class _DeviceBlacklist
		{
			int ID;
			ushort VendorId;
			ushort DeviceId;
		}
		public class _DeviceDefaultSettings
		{
			int ID;
			ushort VendorId;
			ushort DeviceId;
			byte DefaultSetting;
		}
		public class _Difficulty
		{
			int ID;
			string Name;
			ushort GroupSizeHealthCurveId;
			ushort GroupSizeDmgCurveId;
			ushort GroupSizeSpellPointsCurveId;
			byte InstanceType;
			byte OrderIndex;
			byte OldEnumValue;
			byte FallbackDifficultyId;
			byte MinPlayers;
			byte MaxPlayers;
			byte Flags;
			byte ItemContext;
			byte ToggleDifficultyId;
		}
		public class _DissolveEffect
		{
			int ID;
			float Ramp;
			float StartValue;
			float EndValue;
			float FadeInTime;
			float FadeOutTime;
			float Duration;
			float Scale;
			float FresnelIntensity;
			byte AttachId;
			byte ProjectionType;
			int TextureBlendSetId;
			int Flags;
			int CurveId;
			int Priority;
		}
		public class _DriverBlacklist
		{
			int ID;
			int DriverVersionHi;
			int DriverVersionLow;
			ushort VendorId;
			byte DeviceId;
			byte OsVersion;
			byte OsBits;
			byte Flags;
		}
		public class _DungeonEncounter
		{
			string Name;
			int CreatureDisplayId;
			ushort MapId;
			byte DifficultyId;
			byte Bit;
			byte Flags;
			int ID;
			int OrderIndex;
			int SpellIconFileId;
		}
		public class _DurabilityCosts
		{
			int ID;
			ushort[] WeaponSubClassCost = new ushort[21];
			ushort[] ArmorSubClassCost = new ushort[8];
		}
		public class _DurabilityQuality
		{
			int ID;
			float Data;
		}
		public class _EdgeGlowEffect
		{
			int ID;
			float Duration;
			float FadeIn;
			float FadeOut;
			float FresnelCoefficient;
			float GlowRed;
			float GlowGreen;
			float GlowBlue;
			float GlowAlpha;
			float GlowMultiplier;
			float InitialDelay;
			byte Flags;
			int CurveId;
			int Priority;
		}
		public class _Emotes
		{
			int ID;
			ulong RaceMask;
			string EmoteSlashCommand;
			int EmoteFlags;
			int SpellVisualKitId;
			ushort AnimId;
			byte EmoteSpecProc;
			int EmoteSpecProcParam;
			int EventSoundId;
			int ClassMask;
		}
		public class _EmotesText
		{
			int ID;
			string Name;
			ushort EmoteId;
		}
		public class _EmotesTextData
		{
			int ID;
			string Text;
			byte RelationshipFlags;
		}
		public class _EmotesTextSound
		{
			int ID;
			byte RaceId;
			byte ClassId;
			byte SexId;
			int SoundId;
		}
		public class _EnvironmentalDamage
		{
			int ID;
			ushort VisualKitId;
			byte EnumId;
		}
		public class _Exhaustion
		{
			string Name;
			string CombatLogText;
			uint Xp;
			float Factor;
			float OutdoorHours;
			float InnHours;
			float Threshold;
			int ID;
		}
		public class _ExpectedStat
		{
			int ID;
			uint ExpansionId;
			float CreatureHealth;
			float PlayerHealth;
			float CreatureAutoAttackDps;
			float CreatureArmor;
			float PlayerMana;
			float PlayerPrimaryStat;
			float PlayerSecondaryStat;
			float ArmorConstant;
			float CreatureSpellDamage;
		}
		public class _ExpectedStatMod
		{
			int ID;
			float CreatureHealthMod;
			float PlayerHealthMod;
			float CreatureAutoAttackDPSMod;
			float CreatureArmorMod;
			float PlayerManaMod;
			float PlayerPrimaryStatMod;
			float PlayerSecondaryStatMod;
			float ArmorConstantMod;
			float CreatureSpellDamageMod;
		}
		public class _Faction
		{
			ulong[] ReputationRaceMask = new ulong[4];
			string Name;
			string Description;
			int ID;
			int[] ReputationBase = new int[4];
			int[] ReputationMax = new int[4];
			float[] ParentFactionMod = new float[2];
			ushort ReputationIndex;
			ushort[] ReputationClassMask = new ushort[4];
			ushort[] ReputationFlags = new ushort[4];
			ushort ParentFactionId;
			ushort ParagonFactionId;
			byte[] ParentFactionCap = new byte[2];
			byte Expansion;
			byte FriendshipRepId;
			byte Flags;
		}
		public class _FactionGroup
		{
			string InternalName;
			string Name;
			int ID;
			byte MaskId;
			int HonorCurrencyTextureFileId;
			int ConquestCurrencyTextureFileId;
		}
		public class _FactionTemplate
		{
			int ID;
			ushort Faction;
			ushort Flags;
			ushort[] Enemies = new ushort[4];
			ushort[] Friend = new ushort[4];
			byte FactionGroup;
			byte FriendGroup;
			byte EnemyGroup;
		}
		public class _FootprintTextures
		{
			int ID;
			int FileDataId;
			int TextureBlendsetId;
			int Flags;
		}
		public class _FootstepTerrainLookup
		{
			int ID;
			ushort CreatureFootstepId;
			byte TerrainSoundId;
			int SoundId;
			int SoundIDSplash;
		}
		public class _FriendshipRepReaction
		{
			int ID;
			string Reaction;
			ushort ReactionThreshold;
			byte FriendshipRepId;
		}
		public class _FriendshipReputation
		{
			string Description;
			int TextureFileId;
			ushort FactionId;
			int ID;
		}
		public class _FullScreenEffect
		{
			int ID;
			float Saturation;
			float GammaRed;
			float GammaGreen;
			float GammaBlue;
			float MaskOffsetY;
			float MaskSizeMultiplier;
			float MaskPower;
			float ColorMultiplyRed;
			float ColorMultiplyGreen;
			float ColorMultiplyBlue;
			float ColorMultiplyOffsetY;
			float ColorMultiplyMultiplier;
			float ColorMultiplyPower;
			float ColorAdditionRed;
			float ColorAdditionGreen;
			float ColorAdditionBlue;
			float ColorAdditionOffsetY;
			float ColorAdditionMultiplier;
			float ColorAdditionPower;
			float BlurIntensity;
			float BlurOffsetY;
			float BlurMultiplier;
			float BlurPower;
			int Flags;
			int EffectFadeInMs;
			int EffectFadeOutMs;
			int TextureBlendSetId;
		}
		public class _GameObjectArtKit
		{
			int ID;
			int AttachModelFileId;
			int[] TextureVariationFileId = new int[3];
		}
		public class _GameObjectDiffAnimMap
		{
			int ID;
			ushort AttachmentDisplayId;
			byte DifficultyId;
			byte Animation;
		}
		public class _GameObjectDisplayInfo
		{
			int ID;
			int FileDataId;
			float OverrideLootEffectScale;
			float OverrideNameScale;
			float[] GeoBox = new float[6];
			ushort ObjectEffectPackageId;
		}
		public class _GameObjectDisplayInfoXSoundKit
		{
			int ID;
			byte EventIndex;
			int SoundKitId;
		}
		public class _GameObjects
		{
			string Name;
			float[] Pos = new float[3];
			float[] Rot = new float[4];
			float Scale;
			uint[] PropValue = new uint[8];
			ushort OwnerId;
			ushort DisplayId;
			ushort PhaseId;
			ushort PhaseGroupId;
			byte TypeId;
			byte PhaseUseFlags;
			int ID;
		}
		public class _GameTips
		{
			int ID;
			string Text;
			ushort MinLevel;
			ushort MaxLevel;
			byte SortIndex;
		}
		public class _GarrAbility
		{
			string Name;
			string Description;
			int IconFileDataId;
			ushort FactionChangeGarrAbilityId;
			ushort Flags;
			byte GarrAbilityCategoryId;
			byte GarrFollowerTypeId;
			int ID;
		}
		public class _GarrAbilityCategory
		{
			int ID;
			string Name;
		}
		public class _GarrAbilityEffect
		{
			float CombatWeightBase;
			float CombatWeightMax;
			float ActionValueFlat;
			int ActionRecordId;
			ushort GarrAbilityId;
			byte AbilityAction;
			byte AbilityTargetType;
			byte GarrMechanicTypeId;
			byte ActionRace;
			byte ActionHours;
			byte Flags;
			int ID;
		}
		public class _GarrBuilding
		{
			int ID;
			string HordeName;
			string AllianceName;
			string Description;
			string Tooltip;
			int HordeGameObjectId;
			int AllianceGameObjectId;
			int IconFileDataId;
			ushort CurrencyTypeId;
			ushort HordeUiTextureKitId;
			ushort AllianceUiTextureKitId;
			ushort AllianceSceneScriptPackageId;
			ushort HordeSceneScriptPackageId;
			ushort GarrAbilityId;
			ushort BonusGarrAbilityId;
			ushort GoldCost;
			byte GarrTypeId;
			byte BuildingType;
			byte GarrSiteId;
			byte UpgradeLevel;
			byte ShipmentCapacity;
			byte Flags;
			int BuildSeconds;
			int CurrencyQty;
			int MaxAssignments;
		}
		public class _GarrBuildingDoodadSet
		{
			int ID;
			byte GarrBuildingId;
			byte Type;
			byte HordeDoodadSet;
			byte AllianceDoodadSet;
			byte SpecializationId;
		}
		public class _GarrBuildingPlotInst
		{
			float[] MapOffset = new float[2];
			ushort GarrSiteLevelPlotInstId;
			ushort UiTextureAtlasMemberId;
			byte GarrBuildingId;
			int ID;
		}
		public class _GarrClassSpec
		{
			string ClassSpec;
			string ClassSpecMale;
			string ClassSpecFemale;
			ushort UiTextureAtlasMemberId;
			ushort GarrFollItemSetId;
			byte FollowerClassLimit;
			byte Flags;
			int ID;
		}
		public class _GarrClassSpecPlayerCond
		{
			int ID;
			string Name;
			int IconFileDataId;
			byte OrderIndex;
			int GarrClassSpecId;
			int PlayerConditionId;
			int FlavorGarrStringId;
		}
		public class _GarrEncounter
		{
			string Name;
			int CreatureId;
			int PortraitFileDataId;
			float UiAnimScale;
			float UiAnimHeight;
			int ID;
			int UiTextureKitId;
		}
		public class _GarrEncounterSetXEncounter
		{
			int ID;
			int GarrEncounterId;
		}
		public class _GarrEncounterXMechanic
		{
			int ID;
			byte GarrMechanicId;
			byte GarrMechanicSetId;
		}
		public class _GarrFollItemSetMember
		{
			int ID;
			int ItemId;
			ushort MinItemLevel;
			byte ItemSlot;
		}
		public class _GarrFollower
		{
			string HordeSourceText;
			string AllianceSourceText;
			string TitleName;
			int HordeCreatureId;
			int AllianceCreatureId;
			int HordeIconFileDataId;
			int AllianceIconFileDataId;
			int HordeSlottingBroadcastTextId;
			int AllySlottingBroadcastTextId;
			ushort ItemLevelWeapon;
			ushort ItemLevelArmor;
			ushort HordeGarrFollItemSetId;
			ushort AllianceGarrFollItemSetId;
			ushort HordeUITextureKitId;
			ushort AllianceUITextureKitId;
			byte GarrTypeId;
			byte GarrFollowerTypeId;
			byte HordeGarrFollRaceId;
			byte AllianceGarrFollRaceId;
			byte HordeGarrClassSpecId;
			byte AllianceGarrClassSpecId;
			byte Quality;
			byte FollowerLevel;
			byte HordeSourceTypeEnum;
			byte AllianceSourceTypeEnum;
			byte Vitality;
			byte HordeFlavorGarrStringId;
			byte AllianceFlavorGarrStringId;
			byte ChrClassId;
			byte Flags;
			byte Gender;
			int ID;
		}
		public class _GarrFollowerLevelXP
		{
			int ID;
			ushort XpToNextLevel;
			ushort ShipmentXP;
			byte GarrFollowerTypeId;
			byte FollowerLevel;
		}
		public class _GarrFollowerQuality
		{
			int ID;
			int XpToNextQuality;
			ushort ShipmentXP;
			byte Quality;
			byte GarrFollowerTypeId;
			byte AbilityCount;
			byte TraitCount;
			int ClassSpecId;
		}
		public class _GarrFollowerSetXFollower
		{
			int GarrFollowerId;
		}
		public class _GarrFollowerType
		{
			int ID;
			ushort MaxItemLevel;
			byte GarrTypeId;
			byte MaxFollowers;
			byte MaxFollowerBuildingType;
			byte LevelRangeBias;
			byte ItemLevelRangeBias;
			byte Flags;
		}
		public class _GarrFollowerUICreature
		{
			int ID;
			int CreatureId;
			float Scale;
			byte OrderIndex;
			byte FactionIndex;
			byte Flags;
		}
		public class _GarrFollowerXAbility
		{
			int ID;
			ushort GarrAbilityId;
			byte FactionIndex;
		}
		public class _GarrFollSupportSpell
		{
			int ID;
			int HordeSpellId;
			int AllianceSpellId;
			byte OrderIndex;
		}
		public class _GarrItemLevelUpgradeData
		{
			int ID;
			int Operation;
			int MinItemLevel;
			int MaxItemLevel;
			int FollowerTypeId;
		}
		public class _GarrMechanic
		{
			int ID;
			float Factor;
			byte GarrMechanicTypeId;
			int GarrAbilityId;
		}
		public class _GarrMechanicSetXMechanic
		{
			byte GarrMechanicId;
			int ID;
		}
		public class _GarrMechanicType
		{
			string Name;
			string Description;
			int IconFileDataId;
			byte Category;
			int ID;
		}
		public class _GarrMission
		{
			string Name;
			string Location;
			string Description;
			int MissionDuration;
			int OfferDuration;
			float[] MapPos = new float[2];
			float[] WorldPos = new float[2];
			ushort MissionCostCurrencyTypesId;
			ushort UiTextureKitId;
			ushort TargetItemLevel;
			byte GarrTypeId;
			byte GarrMissionTypeId;
			byte GarrFollowerTypeId;
			byte MaxFollowers;
			byte OfferedGarrMissionTextureId;
			byte EnvGarrMechanicTypeId;
			byte TargetLevel;
			byte BaseCompletionChance;
			byte FollowerDeathChance;
			int ID;
			int MissionCost;
			int EnvGarrMechanicId;
			int PlayerConditionId;
			int TravelDuration;
			int BaseFollowerXP;
			int OvermaxRewardPackId;
			int AreaId;
			int Flags;
		}
		public class _GarrMissionTexture
		{
			int ID;
			float[] Pos = new float[2];
			ushort UiTextureKitId;
		}
		public class _GarrMissionType
		{
			int ID;
			string Name;
			ushort UiTextureAtlasMemberId;
			ushort UiTextureKitId;
		}
		public class _GarrMissionXEncounter
		{
			byte OrderIndex;
			int ID;
			int GarrEncounterId;
			int GarrEncounterSetId;
		}
		public class _GarrMissionXFollower
		{
			int ID;
			int GarrFollowerId;
			int GarrFollowerSetId;
		}
		public class _GarrMssnBonusAbility
		{
			int ID;
			float Radius;
			int DurationSecs;
			ushort GarrAbilityId;
			byte GarrFollowerTypeId;
			byte GarrMissionTextureId;
		}
		public class _GarrPlot
		{
			int ID;
			string Name;
			int HordeConstructObjId;
			int AllianceConstructObjId;
			byte PlotType;
			byte Flags;
			byte UiCategoryId;
			int[] UpgradeRequirement = new int[2];
		}
		public class _GarrPlotBuilding
		{
			int ID;
			byte GarrPlotId;
			byte GarrBuildingId;
		}
		public class _GarrPlotInstance
		{
			int ID;
			string Name;
			byte GarrPlotId;
		}
		public class _GarrPlotUICategory
		{
			int ID;
			string CategoryName;
			byte PlotType;
		}
		public class _GarrSiteLevel
		{
			int ID;
			float[] TownHallUiPos = new float[2];
			ushort MapId;
			ushort UpgradeMovieId;
			ushort UiTextureKitId;
			ushort UpgradeCost;
			ushort UpgradeGoldCost;
			byte GarrSiteId;
			byte GarrLevel;
			byte MaxBuildingLevel;
		}
		public class _GarrSiteLevelPlotInst
		{
			int ID;
			float[] UiMarkerPos = new float[2];
			ushort GarrSiteLevelId;
			byte GarrPlotInstanceId;
			byte UiMarkerSize;
		}
		public class _GarrSpecialization
		{
			int ID;
			string Name;
			string Tooltip;
			float[] Param = new float[2];
			int IconFileDataId;
			byte BuildingType;
			byte SpecType;
			byte RequiredUpgradeLevel;
		}
		public class _GarrString
		{
			int ID;
			string Text;
		}
		public class _GarrTalent
		{
			string Name;
			string Description;
			int IconFileDataId;
			int ResearchDurationSecs;
			byte Tier;
			byte UiOrder;
			byte Flags;
			int ID;
			int GarrTalentTreeId;
			int PlayerConditionId;
			int GarrAbilityId;
			int PerkSpellId;
			int PerkPlayerConditionId;
			int ResearchGoldCost;
			int ResearchCost;
			int ResearchCostCurrencyTypesId;
			int RespecDurationSecs;
			int RespecGoldCost;
			int RespecCost;
			int RespecCostCurrencyTypesId;
		}
		public class _GarrTalentTree
		{
			int ID;
			ushort UiTextureKitId;
			byte MaxTiers;
			byte UiOrder;
			int GarrTypeId;
			int ClassId;
		}
		public class _GarrType
		{
			int ID;
			int PrimaryCurrencyTypeId;
			int SecondaryCurrencyTypeId;
			int ExpansionId;
			int Flags;
			int[] MapIDs = new int[2];
		}
		public class _GarrUiAnimClassInfo
		{
			int ID;
			float ImpactDelaySecs;
			byte GarrClassSpecId;
			byte MovementType;
			int CastKit;
			int ImpactKit;
			int TargetImpactKit;
		}
		public class _GarrUiAnimRaceInfo
		{
			int ID;
			float MaleScale;
			float MaleHeight;
			float FemaleScale;
			float FemaleHeight;
			float MaleSingleModelScale;
			float MaleSingleModelHeight;
			float FemaleSingleModelScale;
			float FemaleSingleModelHeight;
			float MaleFollowerPageScale;
			float MaleFollowerPageHeight;
			float FemaleFollowerPageScale;
			float FemaleFollowerPageHeight;
			byte GarrFollRaceId;
		}
		public class _GemProperties
		{
			int ID;
			int Type;
			ushort EnchantId;
			ushort MinItemLevel;
		}
		public class _GlobalStrings
		{
			int ID;
			string BaseTag;
			string TagText;
			byte Flags;
		}
		public class _GlyphBindableSpell
		{
			int ID;
			int SpellId;
		}
		public class _GlyphExclusiveCategory
		{
			int ID;
			string Name;
		}
		public class _GlyphProperties
		{
			int ID;
			int SpellId;
			ushort SpellIconId;
			byte GlyphType;
			byte GlyphExclusiveCategoryId;
		}
		public class _GlyphRequiredSpec
		{
			int ID;
			ushort ChrSpecializationId;
		}
		public class _GMSurveyAnswers
		{
			int ID;
			string Answer;
			byte SortIndex;
		}
		public class _GMSurveyCurrentSurvey
		{
			int ID;
			byte GmsurveyId;
		}
		public class _GMSurveyQuestions
		{
			int ID;
			string Question;
		}
		public class _GMSurveySurveys
		{
			int ID;
			byte[] Q = new byte[15];
		}
		public class _GroundEffectDoodad
		{
			int ID;
			float Animscale;
			float PushScale;
			byte Flags;
			int ModelFileId;
		}
		public class _GroundEffectTexture
		{
			int ID;
			ushort[] DoodadId = new ushort[4];
			byte[] DoodadWeight = new byte[4];
			byte Sound;
			int Density;
		}
		public class _GroupFinderActivity
		{
			int ID;
			string FullName;
			string ShortName;
			ushort MinGearLevelSuggestion;
			ushort MapId;
			ushort AreaId;
			byte GroupFinderCategoryId;
			byte OrderIndex;
			byte GroupFinderActivityGrpId;
			byte MinLevel;
			byte MaxLevelSuggestion;
			byte Flags;
			byte DifficultyId;
			byte MaxPlayers;
			byte DisplayType;
		}
		public class _GroupFinderActivityGrp
		{
			int ID;
			string Name;
			byte OrderIndex;
		}
		public class _GroupFinderCategory
		{
			int ID;
			string Name;
			byte OrderIndex;
			byte Flags;
		}
		public class _GuildColorBackground
		{
			int ID;
			byte Red;
			byte Blue;
			byte Green;
		}
		public class _GuildColorBorder
		{
			int ID;
			byte Red;
			byte Blue;
			byte Green;
		}
		public class _GuildColorEmblem
		{
			int ID;
			byte Red;
			byte Blue;
			byte Green;
		}
		public class _GuildPerkSpells
		{
			int ID;
			int SpellId;
		}
		public class _Heirloom
		{
			string SourceText;
			int ItemId;
			int LegacyUpgradedItemId;
			int StaticUpgradedItemId;
			int[] UpgradeItemId = new int[3];
			int LegacyItemId;
			ushort[] UpgradeItemBonusListId = new ushort[3];
			byte SourceTypeEnum;
			byte Flags;
			int ID;
		}
		public class _HelmetAnimScaling
		{
			int ID;
			float Amount;
			int RaceId;
		}
		public class _HelmetGeosetVisData
		{
			int ID;
			uint[] HideGeoset = new uint[9];
		}
		public class _HighlightColor
		{
			int ID;
			uint StartColor;
			uint MidColor;
			int EndColor;
			byte Type;
			byte Flags;
		}
		public class _HolidayDescriptions
		{
			int ID;
			string Description;
		}
		public class _HolidayNames
		{
			int ID;
			string Name;
		}
		public class _Holidays
		{
			int ID;
			int[] Date = new int[16];
			ushort[] Duration = new ushort[10];
			ushort Region;
			byte Looping;
			byte[] CalendarFlags = new byte[10];
			byte Priority;
			byte CalendarFilterType;
			byte Flags;
			int HolidayNameId;
			int HolidayDescriptionId;
			int[] TextureFileDataId = new int[3];
		}
		public class _Hotfixes
		{
			int ID;
			string Tablename;
			int ObjectId;
			int Flags;
		}
		public class _ImportPriceArmor
		{
			int ID;
			float ClothModifier;
			float LeatherModifier;
			float ChainModifier;
			float PlateModifier;
		}
		public class _ImportPriceQuality
		{
			int ID;
			float Data;
		}
		public class _ImportPriceShield
		{
			int ID;
			float Data;
		}
		public class _ImportPriceWeapon
		{
			int ID;
			float Data;
		}
		public class _InvasionClientData
		{
			string Name;
			float[] IconLocation = new float[2];
			int ID;
			int WorldStateId;
			int UiTextureAtlasMemberId;
			int ScenarioId;
			int WorldQuestId;
			int WorldStateValue;
			int InvasionEnabledWorldStateId;
		}
		public class _Item
		{
			int ID;
			int IconFileDataId;
			byte ClassId;
			byte SubclassId;
			byte Material;
			byte InventoryType;
			byte SheatheType;
			byte SoundOverrideSubclassId;
			byte ItemGroupSoundsId;
		}
		public class _ItemAppearance
		{
			int ID;
			int ItemDisplayInfoId;
			int DefaultIconFileDataId;
			int UiOrder;
			byte DisplayType;
		}
		public class _ItemAppearanceXUiCamera
		{
			int ID;
			ushort ItemAppearanceId;
			ushort UiCameraId;
		}
		public class _ItemArmorQuality
		{
			int ID;
			float[] Qualitymod = new float[7];
			ushort ItemLevel;
		}
		public class _ItemArmorShield
		{
			int ID;
			float[] Quality = new float[7];
			ushort ItemLevel;
		}
		public class _ItemArmorTotal
		{
			int ID;
			float Cloth;
			float Leather;
			float Mail;
			float Plate;
			ushort ItemLevel;
		}
		public class _ItemBagFamily
		{
			int ID;
			string Name;
		}
		public class _ItemBonus
		{
			int ID;
			uint[] Value = new uint[3];
			ushort ParentItemBonusListId;
			byte Type;
			byte OrderIndex;
		}
		public class _ItemBonusListLevelDelta
		{
			ushort ItemLevelDelta;
			int ID;
		}
		public class _ItemBonusTreeNode
		{
			int ID;
			ushort ChildItemBonusTreeId;
			ushort ChildItemBonusListId;
			ushort ChildItemLevelSelectorId;
			byte ItemContext;
		}
		public class _ItemChildEquipment
		{
			int ID;
			int ChildItemId;
			byte ChildItemEquipSlot;
		}
		public class _ItemClass
		{
			int ID;
			string ClassName;
			float PriceModifier;
			byte ClassId;
			byte Flags;
		}
		public class _ItemContextPickerEntry
		{
			int ID;
			byte ItemCreationContext;
			byte OrderIndex;
			int PVal;
			int Flags;
			int PlayerConditionId;
		}
		public class _ItemCurrencyCost
		{
			int ID;
			int ItemId;
		}
		public class _ItemDamageAmmo
		{
			int ID;
			float[] Quality = new float[7];
			ushort ItemLevel;
		}
		public class _ItemDamageOneHand
		{
			int ID;
			float[] Quality = new float[7];
			ushort ItemLevel;
		}
		public class _ItemDamageOneHandCaster
		{
			int ID;
			float[] Quality = new float[7];
			ushort ItemLevel;
		}
		public class _ItemDamageTwoHand
		{
			int ID;
			float[] Quality = new float[7];
			ushort ItemLevel;
		}
		public class _ItemDamageTwoHandCaster
		{
			int ID;
			float[] Quality = new float[7];
			ushort ItemLevel;
		}
		public class _ItemDisenchantLoot
		{
			int ID;
			ushort MinLevel;
			ushort MaxLevel;
			ushort SkillRequired;
			byte Subclass;
			byte Quality;
			byte ExpansionId;
		}
		public class _ItemDisplayInfo
		{
			int ID;
			int ModelType1;
			int ItemVisual;
			int ParticleColorId;
			int ItemRangedDisplayInfoId;
			int OverrideSwooshSoundKitId;
			int SheatheTransformMatrixId;
			int StateSpellVisualKitId;
			int SheathedSpellVisualKitId;
			int UnsheathedSpellVisualKitId;
			int Flags;
			int[] ModelResourcesId = new int[2];
			int[] ModelMaterialResourcesId = new int[2];
			int[] GeosetGroup = new int[4];
			int[] AttachmentGeosetGroup = new int[4];
			int[] HelmetGeosetVis = new int[2];
		}
		public class _ItemDisplayInfoMaterialRes
		{
			int ID;
			int MaterialResourcesId;
			byte ComponentSection;
		}
		public class _ItemDisplayXUiCamera
		{
			int ID;
			int ItemDisplayInfoId;
			ushort UiCameraId;
		}
		public class _ItemEffect
		{
			int ID;
			uint CoolDownMSec;
			uint CategoryCoolDownMSec;
			int SpellId;
			ushort Charges;
			ushort SpellCategoryId;
			ushort ChrSpecializationId;
			byte LegacySlotIndex;
			byte TriggerType;
		}
		public class _ItemExtendedCost
		{
			int ID;
			int[] ItemId = new int[5];
			int[] CurrencyCount = new int[5];
			ushort RequiredArenaRating;
			ushort[] ItemCount = new ushort[5];
			ushort[] CurrencyId = new ushort[5];
			byte ArenaBracket;
			byte Flags;
			byte MinFactionId;
			byte MinReputation;
			byte RequiredAchievement;
		}
		public class _ItemGroupSounds
		{
			int ID;
			int[] Sound = new int[4];
		}
		public class _ItemLevelSelector
		{
			int ID;
			ushort MinItemLevel;
			ushort ItemLevelSelectorQualitySetId;
		}
		public class _ItemLevelSelectorQuality
		{
			int ID;
			int QualityItemBonusListId;
			byte Quality;
		}
		public class _ItemLevelSelectorQualitySet
		{
			int ID;
			ushort IlvlRare;
			ushort IlvlEpic;
		}
		public class _ItemLimitCategory
		{
			int ID;
			string Name;
			byte Quantity;
			byte Flags;
		}
		public class _ItemLimitCategoryCondition
		{
			int ID;
			byte AddQuantity;
			int PlayerConditionId;
		}
		public class _ItemModifiedAppearance
		{
			int ItemId;
			int ID;
			byte ItemAppearanceModifierId;
			ushort ItemAppearanceId;
			byte OrderIndex;
			byte TransmogSourceTypeEnum;
		}
		public class _ItemModifiedAppearanceExtra
		{
			int ID;
			int IconFileDataId;
			int UnequippedIconFileDataId;
			byte SheatheType;
			byte DisplayWeaponSubclassId;
			byte DisplayInventoryType;
		}
		public class _ItemNameDescription
		{
			int ID;
			string Description;
			uint Color;
		}
		public class _ItemPetFood
		{
			int ID;
			string Name;
		}
		public class _ItemPriceBase
		{
			int ID;
			float Armor;
			float Weapon;
			ushort ItemLevel;
		}
		public class _ItemRandomProperties
		{
			int ID;
			string Name;
			ushort[] Enchantment = new ushort[5];
		}
		public class _ItemRandomSuffix
		{
			int ID;
			string Name;
			ushort[] Enchantment = new ushort[5];
			ushort[] AllocationPct = new ushort[5];
		}
		public class _ItemRangedDisplayInfo
		{
			int ID;
			int CastSpellVisualId;
			int AutoAttackSpellVisualId;
			int QuiverFileDataId;
			int MissileSpellVisualEffectNameId;
		}
		public class _ItemSearchName
		{
			ulong AllowableRace;
			string Display;
			int ID;
			uint[] Flags = new uint[3];
			ushort ItemLevel;
			byte OverallQualityId;
			byte ExpansionId;
			byte RequiredLevel;
			ushort MinFactionId;
			byte MinReputation;
			int AllowableClass;
			ushort RequiredSkill;
			ushort RequiredSkillRank;
			int RequiredAbility;
		}
		public class _ItemSet
		{
			int ID;
			string Name;
			int[] ItemId = new int[17];
			ushort RequiredSkillRank;
			int SetFlags;
			int RequiredSkill;
		}
		public class _ItemSetSpell
		{
			int ID;
			int SpellId;
			ushort ChrSpecId;
			byte Threshold;
		}
		public class _ItemSparse
		{
			int ID;
			ulong AllowableRace;
			string Description;
			string Display3;
			string Display2;
			string Display1;
			string Display;
			float DmgVariance;
			int DurationInInventory;
			float QualityModifier;
			int BagFamily;
			float ItemRange;
			float[] StatPercentageOfSocket = new float[10];
			int[] StatPercentEditor = new int[10];
			int Stackable;
			int MaxCount;
			int RequiredAbility;
			int SellPrice;
			int BuyPrice;
			int VendorStackCount;
			float PriceVariance;
			float PriceRandomValue;
			uint[] Flags = new uint[4];
			ushort ItemNameDescriptionId;
			ushort RequiredTransmogHoliday;
			ushort RequiredHoliday;
			ushort LimitCategory;
			ushort GemProperties;
			ushort SocketMatchEnchantmentId;
			ushort TotemCategoryId;
			ushort InstanceBound;
			ushort ZoneBound;
			ushort ItemSet;
			ushort ItemRandomSuffixGroupId;
			ushort RandomSelect;
			ushort LockId;
			ushort StartQuestId;
			ushort PageId;
			ushort ItemDelay;
			ushort ScalingStatDistributionId;
			ushort MinFactionId;
			ushort RequiredSkillRank;
			ushort RequiredSkill;
			ushort ItemLevel;
			ushort AllowableClass;
			byte ExpansionId;
			byte ArtifactId;
			byte SpellWeight;
			byte SpellWeightCategory;
			byte[] SocketType = new byte[3];
			byte SheatheType;
			byte Material;
			byte PageMaterialId;
			byte LanguageId;
			byte Bonding;
			byte DamageDamageType;
			byte[] StatModifierBonusStat = new byte[10];
			byte ContainerSlots;
			byte MinReputation;
			byte RequiredPVPMedal;
			byte RequiredPVPRank;
			byte RequiredLevel;
			byte InventoryType;
			byte OverallQualityId;
		}
		public class _ItemSpec
		{
			int ID;
			ushort SpecializationId;
			byte MinLevel;
			byte MaxLevel;
			byte ItemType;
			byte PrimaryStat;
			byte SecondaryStat;
		}
		public class _ItemSpecOverride
		{
			int ID;
			ushort SpecId;
		}
		public class _ItemSubClass
		{
			int ID;
			string DisplayName;
			string VerboseName;
			ushort Flags;
			byte ClassId;
			byte SubClassId;
			byte AuctionHouseSortOrder;
			byte PrerequisiteProficiency;
			byte DisplayFlags;
			byte WeaponSwingSize;
			byte PostrequisiteProficiency;
		}
		public class _ItemSubClassMask
		{
			int ID;
			string Name;
			int Mask;
			byte ClassId;
		}
		public class _ItemUpgrade
		{
			int ID;
			int CurrencyAmount;
			ushort PrerequisiteId;
			ushort CurrencyType;
			byte ItemUpgradePathId;
			byte ItemLevelIncrement;
		}
		public class _ItemVisuals
		{
			int ID;
			int[] ModelFileId = new int[5];
		}
		public class _ItemXBonusTree
		{
			int ID;
			ushort ItemBonusTreeId;
		}
		public class _JournalEncounter
		{
			int ID;
			string Name;
			string Description;
			float[] Map = new float[2];
			ushort JournalInstanceId;
			ushort FirstSectionId;
			ushort UiMapId;
			byte Flags;
			byte DifficultyMask;
			int OrderIndex;
			int MapDisplayConditionId;
		}
		public class _JournalEncounterCreature
		{
			string Name;
			string Description;
			int CreatureDisplayInfoId;
			int FileDataId;
			ushort JournalEncounterId;
			byte OrderIndex;
			int ID;
			int UiModelSceneId;
		}
		public class _JournalEncounterItem
		{
			int ItemId;
			ushort JournalEncounterId;
			byte FactionMask;
			byte Flags;
			byte DifficultyMask;
			int ID;
		}
		public class _JournalEncounterSection
		{
			int ID;
			string Title;
			string BodyText;
			int IconCreatureDisplayInfoId;
			int SpellId;
			int IconFileDataId;
			ushort JournalEncounterId;
			ushort ParentSectionId;
			ushort FirstChildSectionId;
			ushort NextSiblingSectionId;
			ushort Flags;
			ushort IconFlags;
			byte OrderIndex;
			byte Type;
			byte DifficultyMask;
			int UiModelSceneId;
		}
		public class _JournalEncounterXDifficulty
		{
			int ID;
			byte DifficultyId;
		}
		public class _JournalEncounterXMapLoc
		{
			int ID;
			float[] Map = new float[2];
			byte Flags;
			int JournalEncounterId;
			int MapDisplayConditionId;
		}
		public class _JournalInstance
		{
			string Name;
			string Description;
			int BackgroundFileDataId;
			int ButtonFileDataId;
			int ButtonSmallFileDataId;
			int LoreFileDataId;
			ushort MapId;
			ushort AreaId;
			byte OrderIndex;
			byte Flags;
			int ID;
		}
		public class _JournalItemXDifficulty
		{
			int ID;
			byte DifficultyId;
		}
		public class _JournalSectionXDifficulty
		{
			int ID;
			byte DifficultyId;
		}
		public class _JournalTier
		{
			int ID;
			string Name;
		}
		public class _JournalTierXInstance
		{
			int ID;
			ushort JournalTierId;
			ushort JournalInstanceId;
		}
		public class _KeyChain
		{
			int ID;
			byte[] Key = new byte[32];
		}
		public class _KeystoneAffix
		{
			int ID;
			string Name;
			string Description;
			int Filedataid;
		}
		public class _Languages
		{
			string Name;
			int ID;
		}
		public class _LanguageWords
		{
			int ID;
			string Word;
			byte LanguageId;
		}
		public class _LfgDungeonExpansion
		{
			int ID;
			ushort RandomId;
			byte ExpansionLevel;
			byte HardLevelMin;
			byte HardLevelMax;
			int TargetLevelMin;
			int TargetLevelMax;
		}
		public class _LfgDungeonGroup
		{
			int ID;
			string Name;
			ushort OrderIndex;
			byte Typeid;
			byte ParentGroupId;
		}
		public class _LfgDungeons
		{
			int ID;
			string Name;
			string Description;
			uint Flags;
			float MinGear;
			int RequiredPlayerConditionId;
			ushort MaxLevel;
			ushort MapId;
			ushort TargetLevelMax;
			ushort RandomId;
			ushort ScenarioId;
			ushort FinalEncounterId;
			ushort BonusReputationAmount;
			ushort MentorItemLevel;
			byte MinLevel;
			byte TypeId;
			byte Subtype;
			byte Faction;
			byte ExpansionLevel;
			byte DifficultyId;
			byte GroupId;
			byte OrderIndex;
			byte TargetLevel;
			byte TargetLevelMin;
			byte CountTank;
			byte CountHealer;
			byte CountDamage;
			byte MinCountTank;
			byte MinCountHealer;
			byte MinCountDamage;
			byte MentorCharLevel;
			int IconTextureFileId;
			int RewardsBgTextureFileId;
			int PopupBgTextureFileId;
		}
		public class _LfgDungeonsGroupingMap
		{
			int ID;
			ushort RandomLfgDungeonsId;
			byte GroupId;
		}
		public class _LfgRoleRequirement
		{
			int ID;
			byte RoleType;
			int PlayerConditionId;
		}
		public class _Light
		{
			int ID;
			float[] GameCoords = new float[3];
			float GameFalloffStart;
			float GameFalloffEnd;
			ushort ContinentId;
			ushort[] LightParamsId = new ushort[8];
		}
		public class _LightData
		{
			int ID;
			int DirectColor;
			int AmbientColor;
			int SkyTopColor;
			int SkyMiddleColor;
			int SkyBand1Color;
			uint SkyBand2Color;
			int SkySmogColor;
			int SkyFogColor;
			int SunColor;
			int CloudSunColor;
			int CloudEmissiveColor;
			int CloudLayer1AmbientColor;
			int CloudLayer2AmbientColor;
			int OceanCloseColor;
			int OceanFarColor;
			int RiverCloseColor;
			int RiverFarColor;
			uint ShadowOpacity;
			float FogEnd;
			float FogScaler;
			float FogDensity;
			float FogHeight;
			float FogHeightScaler;
			float FogHeightDensity;
			float SunFogAngle;
			float CloudDensity;
			int ColorGradingFileDataId;
			int HorizonAmbientColor;
			int GroundAmbientColor;
			int EndFogColor;
			float EndFogColorDistance;
			int SunFogColor;
			int FogHeightColor;
			ushort LightParamId;
			ushort Time;
		}
		public class _LightParams
		{
			float Glow;
			float WaterShallowAlpha;
			float WaterDeepAlpha;
			float OceanShallowAlpha;
			float OceanDeepAlpha;
			float[] OverrideCelestialSphere = new float[3];
			ushort LightSkyboxId;
			byte HighlightSky;
			byte CloudTypeId;
			byte Flags;
			int ID;
		}
		public class _LightSkybox
		{
			int ID;
			string Name;
			int SkyboxFileDataId;
			int CelestialSkyboxFileDataId;
			byte Flags;
		}
		public class _LiquidMaterial
		{
			int ID;
			byte Flags;
			byte LVF;
		}
		public class _LiquidObject
		{
			int ID;
			float FlowDirection;
			float FlowSpeed;
			ushort LiquidTypeId;
			byte Fishable;
			byte Reflection;
		}
		public class _LiquidType
		{
			int ID;
			string Name;
			string[] Texture = new string[6];
			int SpellId;
			float MaxDarkenDepth;
			float FogDarkenIntensity;
			float AmbDarkenIntensity;
			float DirDarkenIntensity;
			float ParticleScale;
			int MinimapStaticCol;
			int[] Color = new int[2];
			float[] Float = new float[18];
			int[] Int = new int[4];
			float[] Coefficient = new float[4];
			ushort Flags;
			ushort LightId;
			byte SoundBank;
			byte ParticleMovement;
			byte ParticleTexSlots;
			byte MaterialId;
			byte[] FrameCountTexture = new byte[6];
			int SoundId;
		}
		public class _LoadingScreens
		{
			int ID;
			int NarrowScreenFileDataId;
			int WideScreenFileDataId;
			int WideScreen169FileDataId;
		}
		public class _LoadingScreenTaxiSplines
		{
			int ID;
			float[] LocX = new float[10];
			float[] LocY = new float[10];
			ushort PathId;
			ushort LoadingScreenId;
			byte LegIndex;
		}
		public class _Locale
		{
			int ID;
			int FontFileDataId;
			byte WowLocale;
			byte ClientDisplayExpansion;
			byte Secondary;
		}
		public class _Location
		{
			int ID;
			float[] Pos = new float[3];
			float[] Rot = new float[3];
		}
		public class _Lock
		{
			int ID;
			int[] Index = new int[8];
			ushort[] Skill = new ushort[8];
			byte[] Type = new byte[8];
			byte[] Action = new byte[8];
		}
		public class _LockType
		{
			string Name;
			string ResourceName;
			string Verb;
			string CursorName;
			int ID;
		}
		public class _LookAtController
		{
			int ID;
			float ReactionEnableDistance;
			float ReactionGiveupDistance;
			float TorsoSpeedFactor;
			float HeadSpeedFactor;
			ushort ReactionEnableFOVDeg;
			ushort ReactionGiveupTimeMS;
			ushort ReactionIgnoreTimeMinMS;
			ushort ReactionIgnoreTimeMaxMS;
			byte MaxTorsoYaw;
			byte MaxTorsoYawWhileMoving;
			byte MaxHeadYaw;
			byte MaxHeadPitch;
			byte Flags;
			int ReactionWarmUpTimeMSMin;
			int ReactionWarmUpTimeMSMax;
			int ReactionGiveupFOVDeg;
			int MaxTorsoPitchUp;
			int MaxTorsoPitchDown;
		}
		public class _MailTemplate
		{
			int ID;
			string Body;
		}
		public class _ManagedWorldState
		{
			int CurrentStageWorldStateId;
			int ProgressWorldStateId;
			int UpTimeSecs;
			int DownTimeSecs;
			int OccurrencesWorldStateId;
			int AccumulationStateTargetValue;
			int DepletionStateTargetValue;
			int AccumulationAmountPerMinute;
			int DepletionAmountPerMinute;
			int ID;
		}
		public class _ManagedWorldStateBuff
		{
			int ID;
			int BuffSpellId;
			int OccurrenceValue;
			int PlayerConditionId;
		}
		public class _ManagedWorldStateInput
		{
			int ID;
			int ManagedWorldStateId;
			int QuestId;
			int ValidInputConditionId;
		}
		public class _ManifestInterfaceActionIcon
		{
			int ID;
		}
		public class _ManifestInterfaceData
		{
			int ID;
			string FilePath;
			string FileName;
		}
		public class _ManifestInterfaceItemIcon
		{
			int ID;
		}
		public class _ManifestInterfaceTOCData
		{
			int ID;
			string FilePath;
		}
		public class _ManifestMP3
		{
			int ID;
		}
		public class _Map
		{
			int ID;
			string Directory;
			string MapName;
			string MapDescription0;
			string MapDescription1;
			string PvpShortDescription;
			string PvpLongDescription;
			uint[] Flags = new uint[2];
			float MinimapIconScale;
			float[] Corpse = new float[2];
			int ZmpFileDataId;
			ushort AreaTableId;
			ushort LoadingScreenId;
			ushort TimeOfDayOverride;
			ushort ParentMapId;
			ushort CosmeticParentMapId;
			ushort CorpseMapId;
			ushort WindSettingsId;
			byte MapType;
			byte InstanceType;
			byte ExpansionId;
			byte TimeOffset;
			byte MaxPlayers;
		}
		public class _MapCelestialBody
		{
			int ID;
			ushort CelestialBodyId;
			int PlayerConditionId;
		}
		public class _MapChallengeMode
		{
			string Name;
			int ID;
			ushort MapId;
			ushort[] CriteriaCount = new ushort[3];
			byte Flags;
		}
		public class _MapDifficulty
		{
			int ID;
			string Message;
			byte DifficultyId;
			byte LockId;
			byte ResetInterval;
			byte MaxPlayers;
			byte ItemContext;
			byte Flags;
			int ItemContextPickerId;
		}
		public class _MapDifficultyXCondition
		{
			int ID;
			string FailureDescription;
			int PlayerConditionId;
			int OrderIndex;
		}
		public class _MapLoadingScreen
		{
			int ID;
			float[] Min = new float[2];
			float[] Max = new float[2];
			int LoadingScreenId;
			int OrderIndex;
		}
		public class _MarketingPromotionsXLocale
		{
			int ID;
			string AcceptURL;
			int AdTexture;
			int LogoTexture;
			int AcceptButtonTexture;
			int DeclineButtonTexture;
			byte PromotionId;
			byte LocaleId;
		}
		public class _Material
		{
			int ID;
			byte Flags;
			int FoleySoundId;
			int SheatheSoundId;
			int UnsheatheSoundId;
		}
		public class _MinorTalent
		{
			int ID;
			int SpellId;
			int OrderIndex;
		}
		public class _MissileTargeting
		{
			int ID;
			float TurnLingering;
			float PitchLingering;
			float MouseLingering;
			float EndOpacity;
			float ArcSpeed;
			float ArcRepeat;
			float ArcWidth;
			float[] ImpactRadius = new float[2];
			float ImpactTexRadius;
			int ArcTextureFileId;
			int ImpactTextureFileId;
			int[] ImpactModelFileId = new int[2];
		}
		public class _ModelAnimCloakDampening
		{
			int ID;
			int AnimationDataId;
			int CloakDampeningId;
		}
		public class _ModelFileData
		{
			byte Flags;
			byte LodCount;
			int ID;
			int ModelResourcesId;
		}
		public class _ModelRibbonQuality
		{
			int ID;
			byte RibbonQualityId;
		}
		public class _ModifierTree
		{
			int ID;
			int Parent;
			uint Asset;
			int SecondaryAsset;
			byte Operator;
			byte Amount;
			byte Type;
			byte TertiaryAsset;
		}
		public class _Mount
		{
			string Name;
			string SourceText;
			string Description;
			int SourceSpellId;
			float MountFlyRideHeight;
			ushort MountTypeId;
			ushort Flags;
			byte SourceTypeEnum;
			int ID;
			int PlayerConditionId;
			int UiModelSceneId;
		}
		public class _MountCapability
		{
			int ReqSpellKnownId;
			int ModSpellAuraId;
			ushort ReqRidingSkill;
			ushort ReqAreaId;
			ushort ReqMapId;
			byte Flags;
			int ID;
			int ReqSpellAuraId;
		}
		public class _MountTypeXCapability
		{
			int ID;
			ushort MountTypeId;
			ushort MountCapabilityId;
			byte OrderIndex;
		}
		public class _MountXDisplay
		{
			int ID;
			int CreatureDisplayInfoId;
			int PlayerConditionId;
		}
		public class _Movie
		{
			int ID;
			int AudioFileDataId;
			int SubtitleFileDataId;
			byte Volume;
			byte KeyId;
		}
		public class _MovieFileData
		{
			int ID;
			ushort Resolution;
		}
		public class _MovieVariation
		{
			int ID;
			int FileDataId;
			int OverlayFileDataId;
		}
		public class _MultiStateProperties
		{
			int ID;
			float[] Offset = new float[3];
			byte StateIndex;
			int GameObjectId;
			int GameEventId;
			float Facing;
			int TransitionInId;
			int TransitionOutId;
			int CollisionHull;
			int Flags;
		}
		public class _MultiTransitionProperties
		{
			int ID;
			int TransitionType;
			int DurationMS;
		}
		public class _NameGen
		{
			int ID;
			string Name;
			byte RaceId;
			byte Sex;
		}
		public class _NamesProfanity
		{
			int ID;
			string Name;
			byte Language;
		}
		public class _NamesReserved
		{
			int ID;
			string Name;
		}
		public class _NamesReservedLocale
		{
			int ID;
			string Name;
			byte LocaleMask;
		}
		public class _NpcModelItemSlotDisplayInfo
		{
			int ID;
			int ItemDisplayInfoId;
			byte ItemSlot;
		}
		public class _NPCSounds
		{
			int ID;
			int[] SoundId = new int[4];
		}
		public class _NumTalentsAtLevel
		{
			int ID;
			int NumTalents;
			int NumTalentsDeathKnight;
			int NumTalentsDemonHunter;
		}
		public class _ObjectEffect
		{
			int ID;
			float[] Offset = new float[3];
			ushort ObjectEffectGroupId;
			byte TriggerType;
			byte EventType;
			byte EffectRecType;
			byte Attachment;
			int EffectRecId;
			int ObjectEffectModifierId;
		}
		public class _ObjectEffectModifier
		{
			int ID;
			float[] Param = new float[4];
			byte InputType;
			byte MapType;
			byte OutputType;
		}
		public class _ObjectEffectPackageElem
		{
			int ID;
			ushort ObjectEffectPackageId;
			ushort ObjectEffectGroupId;
			ushort StateType;
		}
		public class _OutlineEffect
		{
			int ID;
			int PassiveHighlightColorId;
			int HighlightColorId;
			int Priority;
			int Flags;
			float Range;
			int[] UnitConditionId = new int[2];
		}
		public class _OverrideSpellData
		{
			int ID;
			int[] Spells = new int[10];
			uint PlayerActionBarFileDataId;
			byte Flags;
		}
		public class _PageTextMaterial
		{
			int ID;
			string Name;
		}
		public class _PaperDollItemFrame
		{
			int ID;
			string ItemButtonName;
			byte SlotNumber;
			int SlotIconFileId;
		}
		public class _ParagonReputation
		{
			int ID;
			int LevelThreshold;
			int QuestId;
			int FactionId;
		}
		public class _ParticleColor
		{
			int ID;
			uint[] Start = new uint[3];
			uint[] Mid = new uint[3];
			int[] End = new int[3];
		}
		public class _Path
		{
			int ID;
			byte Type;
			byte SplineType;
			byte Red;
			byte Green;
			byte Blue;
			byte Alpha;
			byte Flags;
		}
		public class _PathNode
		{
			int ID;
			int LocationId;
			ushort PathId;
			ushort Sequence;
		}
		public class _PathNodeProperty
		{
			ushort PathId;
			ushort Sequence;
			byte PropertyIndex;
			int ID;
			int Value;
		}
		public class _PathProperty
		{
			int Value;
			ushort PathId;
			byte PropertyIndex;
			int ID;
		}
		public class _Phase
		{
			int ID;
			ushort Flags;
		}
		public class _PhaseShiftZoneSounds
		{
			int ID;
			ushort AreaId;
			ushort PhaseId;
			ushort PhaseGroupId;
			ushort SoundAmbienceId;
			ushort UwSoundAmbienceId;
			byte WmoAreaId;
			byte PhaseUseFlags;
			byte SoundProviderPreferencesId;
			byte UwSoundProviderPreferencesId;
			int ZoneIntroMusicId;
			int ZoneMusicId;
			int UwZoneIntroMusicId;
			int UwZoneMusicId;
		}
		public class _PhaseXPhaseGroup
		{
			int ID;
			ushort PhaseId;
		}
		public class _PlayerCondition
		{
			ulong RaceMask;
			string FailureDescription;
			int ID;
			byte Flags;
			ushort MinLevel;
			ushort MaxLevel;
			int ClassMask;
			int SkillLogic;
			byte LanguageId;
			byte MinLanguage;
			int MaxLanguage;
			ushort MaxFactionId;
			byte MaxReputation;
			int ReputationLogic;
			byte CurrentPvpFaction;
			byte PvpMedal;
			int PrevQuestLogic;
			int CurrQuestLogic;
			int CurrentCompletedQuestLogic;
			int SpellLogic;
			int ItemLogic;
			byte ItemFlags;
			int AuraSpellLogic;
			ushort WorldStateExpressionId;
			byte WeatherId;
			byte PartyStatus;
			byte LifetimeMaxPVPRank;
			int AchievementLogic;
			byte Gender;
			byte NativeGender;
			int AreaLogic;
			int LfgLogic;
			int CurrencyLogic;
			ushort QuestKillId;
			int QuestKillLogic;
			byte MinExpansionLevel;
			byte MaxExpansionLevel;
			int MinAvgItemLevel;
			int MaxAvgItemLevel;
			ushort MinAvgEquippedItemLevel;
			ushort MaxAvgEquippedItemLevel;
			byte PhaseUseFlags;
			ushort PhaseId;
			int PhaseGroupId;
			byte ChrSpecializationIndex;
			byte ChrSpecializationRole;
			int ModifierTreeId;
			byte PowerType;
			byte PowerTypeComp;
			byte PowerTypeValue;
			int WeaponSubclassMask;
			byte MaxGuildLevel;
			byte MinGuildLevel;
			byte MaxExpansionTier;
			byte MinExpansionTier;
			byte MinPVPRank;
			byte MaxPVPRank;
			ushort[] SkillId = new ushort[4];
			ushort[] MinSkill = new ushort[4];
			ushort[] MaxSkill = new ushort[4];
			int[] MinFactionId = new int[3];
			byte[] MinReputation = new byte[3];
			ushort[] PrevQuestId = new ushort[4];
			ushort[] CurrQuestId = new ushort[4];
			ushort[] CurrentCompletedQuestId = new ushort[4];
			int[] SpellId = new int[4];
			int[] ItemId = new int[4];
			int[] ItemCount = new int[4];
			ushort[] Explored = new ushort[2];
			int[] Time = new int[2];
			int[] AuraSpellId = new int[4];
			byte[] AuraStacks = new byte[4];
			ushort[] Achievement = new ushort[4];
			ushort[] AreaId = new ushort[4];
			byte[] LfgStatus = new byte[4];
			byte[] LfgCompare = new byte[4];
			int[] LfgValue = new int[4];
			int[] CurrencyId = new int[4];
			int[] CurrencyCount = new int[4];
			int[] QuestKillMonster = new int[6];
			int[] MovementFlags = new int[2];
		}
		public class _Positioner
		{
			int ID;
			float StartLife;
			ushort FirstStateId;
			byte Flags;
			byte StartLifePercent;
		}
		public class _PositionerState
		{
			int ID;
			float EndLife;
			byte EndLifePercent;
			int NextStateId;
			int TransformMatrixId;
			int PosEntryId;
			int RotEntryId;
			int ScaleEntryId;
			int Flags;
		}
		public class _PositionerStateEntry
		{
			int ID;
			float ParamA;
			float ParamB;
			ushort SrcValType;
			ushort SrcVal;
			ushort DstValType;
			ushort DstVal;
			byte EntryType;
			byte Style;
			byte SrcType;
			byte DstType;
			int CurveId;
		}
		public class _PowerDisplay
		{
			int ID;
			string GlobalStringBaseTag;
			byte ActualType;
			byte Red;
			byte Green;
			byte Blue;
		}
		public class _PowerType
		{
			int ID;
			string NameGlobalStringTag;
			string CostGlobalStringTag;
			float RegenPeace;
			float RegenCombat;
			ushort MaxBasePower;
			ushort RegenInterruptTimeMS;
			ushort Flags;
			byte PowerTypeEnum;
			byte MinPower;
			byte CenterPower;
			byte DefaultPower;
			byte DisplayModifier;
		}
		public class _PrestigeLevelInfo
		{
			int ID;
			string Name;
			int BadgeTextureFileDataId;
			byte PrestigeLevel;
			byte Flags;
		}
		public class _PvpBracketTypes
		{
			int ID;
			byte BracketId;
			int[] WeeklyQuestId = new int[4];
		}
		public class _PvpDifficulty
		{
			int ID;
			byte RangeIndex;
			byte MinLevel;
			byte MaxLevel;
		}
		public class _PvpItem
		{
			int ID;
			int ItemId;
			byte ItemLevelDelta;
		}
		public class _PvpReward
		{
			int ID;
			int HonorLevel;
			int PrestigeLevel;
			int RewardPackId;
		}
		public class _PvpScalingEffect
		{
			int ID;
			float Value;
			int SpecializationId;
			int PvpScalingEffectTypeId;
		}
		public class _PvpScalingEffectType
		{
			int ID;
			string Name;
		}
		public class _PvpTalent
		{
			string Description;
			int ID;
			int SpecId;
			int SpellId;
			int OverridesSpellId;
			int Flags;
			int ActionBarSpellId;
			int PvpTalentCategoryId;
			int LevelRequired;
		}
		public class _PvpTalentCategory
		{
			int ID;
			byte TalentSlotMask;
		}
		public class _PvpTalentSlotUnlock
		{
			int ID;
			byte Slot;
			int LevelRequired;
			int DeathKnightLevelRequired;
			int DemonHunterLevelRequired;
		}
		public class _QuestFactionReward
		{
			int ID;
			ushort[] Difficulty = new ushort[10];
		}
		public class _QuestFeedbackEffect
		{
			int ID;
			int FileDataId;
			ushort MinimapAtlasMemberId;
			byte AttachPoint;
			byte PassiveHighlightColorType;
			byte Priority;
			byte Flags;
		}
		public class _QuestInfo
		{
			int ID;
			string InfoName;
			ushort Profession;
			byte Type;
			byte Modifiers;
		}
		public class _QuestLine
		{
			int ID;
			string Name;
		}
		public class _QuestLineXQuest
		{
			int ID;
			int QuestLineId;
			int QuestId;
			int OrderIndex;
		}
		public class _QuestMoneyReward
		{
			int ID;
			int[] Difficulty = new int[10];
		}
		public class _QuestObjective
		{
			int ID;
			string Description;
			int Amount;
			int ObjectId;
			byte Type;
			byte OrderIndex;
			byte Flags;
			byte StorageIndex;
		}
		public class _QuestPackageItem
		{
			int ID;
			int ItemId;
			ushort PackageId;
			byte DisplayType;
			int ItemQuantity;
		}
		public class _QuestPOIBlob
		{
			int ID;
			ushort MapId;
			byte NumPoints;
			int UiMapId;
			int QuestId;
			int ObjectiveIndex;
			int PlayerConditionId;
		}
		public class _QuestPOIPoint
		{
			int ID;
			ushort X;
			ushort Y;
		}
		public class _QuestSort
		{
			int ID;
			string SortName;
			byte UiOrderIndex;
		}
		public class _QuestV2
		{
			int ID;
			ushort UniqueBitFlag;
		}
		public class _QuestV2CliTask
		{
			ulong FiltRaces;
			string QuestTitle;
			string BulletText;
			int ConditionId;
			int FiltCompletedQuestLogic;
			int StartItem;
			ushort UniqueBitFlag;
			ushort FiltClasses;
			ushort[] FiltCompletedQuest = new ushort[3];
			ushort FiltMinSkillId;
			ushort WorldStateExpressionId;
			byte FiltActiveQuest;
			byte FiltMaxFactionId;
			byte FiltMaxFactionValue;
			byte FiltMaxLevel;
			byte FiltMinFactionId;
			byte FiltMinFactionValue;
			byte FiltMinLevel;
			byte FiltMinSkillValue;
			byte FiltNonActiveQuest;
			int ID;
			int BreadCrumbId;
			int QuestInfoId;
			int ContentTuningId;
		}
		public class _QuestXGroupActivity
		{
			int ID;
			int QuestId;
			int GroupFinderActivityId;
		}
		public class _QuestXP
		{
			int ID;
			ushort[] Difficulty = new ushort[10];
		}
		public class _RandPropPoints
		{
			int ID;
			int[] Epic = new int[5];
			int[] Superior = new int[5];
			int[] Good = new int[5];
		}
		public class _RelicSlotTierRequirement
		{
			int ID;
			int PlayerConditionId;
			byte RelicIndex;
			byte RelicTier;
		}
		public class _RelicTalent
		{
			int ID;
			ushort ArtifactPowerId;
			byte ArtifactPowerLabel;
			int Type;
			int PVal;
			int Flags;
		}
		public class _ResearchBranch
		{
			int ID;
			string Name;
			int ItemId;
			ushort CurrencyId;
			byte ResearchFieldId;
			int TextureFileId;
			int BigTextureFileId;
		}
		public class _ResearchField
		{
			string Name;
			byte Slot;
			int ID;
		}
		public class _ResearchProject
		{
			string Name;
			string Description;
			int SpellId;
			ushort ResearchBranchId;
			byte Rarity;
			byte NumSockets;
			int ID;
			int TextureFileId;
			int RequiredWeight;
		}
		public class _ResearchSite
		{
			int ID;
			string Name;
			int QuestPoiBlobId;
			ushort MapId;
			int AreaPOIIconEnum;
		}
		public class _Resistances
		{
			int ID;
			string Name;
			byte Flags;
			int FizzleSoundId;
		}
		public class _RewardPack
		{
			int ID;
			int Money;
			float ArtifactXPMultiplier;
			byte ArtifactXPDifficulty;
			byte ArtifactXPCategoryId;
			int CharTitleId;
			int TreasurePickerId;
		}
		public class _RewardPackXCurrencyType
		{
			int ID;
			int CurrencyTypeId;
			int Quantity;
		}
		public class _RewardPackXItem
		{
			int ID;
			int ItemId;
			int ItemQuantity;
		}
		public class _RibbonQuality
		{
			int ID;
			float MaxSampleTimeDelta;
			float AngleThreshold;
			float MinDistancePerSlice;
			byte NumStrips;
			int Flags;
		}
		public class _RulesetItemUpgrade
		{
			int ID;
			int ItemId;
			ushort ItemUpgradeId;
		}
		public class _ScalingStatDistribution
		{
			int ID;
			ushort PlayerLevelToItemLevelCurveId;
			int MinLevel;
			int MaxLevel;
		}
		public class _Scenario
		{
			int ID;
			string Name;
			ushort AreaTableId;
			byte Type;
			byte Flags;
		}
		public class _ScenarioEventEntry
		{
			int ID;
			int TriggerAsset;
			byte TriggerType;
		}
		public class _ScenarioStep
		{
			int ID;
			string Description;
			string Title;
			ushort ScenarioId;
			ushort RewardQuestId;
			ushort Supersedes;
			byte OrderIndex;
			byte Flags;
			int Criteriatreeid;
			int RelatedStep;
			int VisibilityPlayerConditionId;
		}
		public class _SceneScript
		{
			int ID;
			ushort FirstSceneScriptId;
			ushort NextSceneScriptId;
		}
		public class _SceneScriptGlobalText
		{
			int ID;
			string Name;
			string Script;
		}
		public class _SceneScriptPackage
		{
			int ID;
			string Name;
		}
		public class _SceneScriptPackageMember
		{
			int ID;
			ushort SceneScriptPackageId;
			ushort SceneScriptId;
			ushort ChildSceneScriptPackageId;
			byte OrderIndex;
		}
		public class _SceneScriptText
		{
			int ID;
			string Name;
			string Script;
		}
		public class _ScheduledInterval
		{
			int ID;
			int Flags;
			int RepeatType;
			int DurationSecs;
			int OffsetSecs;
			int DateAlignmentType;
		}
		public class _ScheduledWorldState
		{
			int ID;
			int ScheduledWorldStateGroupId;
			int WorldStateId;
			int Value;
			int DurationSecs;
			int Weight;
			int UniqueCategory;
			int Flags;
			int OrderIndex;
		}
		public class _ScheduledWorldStateGroup
		{
			int ID;
			int Flags;
			int ScheduledIntervalId;
			int SelectionType;
			int SelectionCount;
			int Priority;
		}
		public class _ScheduledWorldStateXUniqCat
		{
			int ID;
			int ScheduledUniqueCategoryId;
		}
		public class _ScreenEffect
		{
			int ID;
			string Name;
			uint[] Param = new uint[4];
			ushort LightParamsId;
			ushort LightParamsFadeIn;
			ushort LightParamsFadeOut;
			ushort TimeOfDayOverride;
			byte Effect;
			byte EffectMask;
			byte LightFlags;
			int FullScreenEffectId;
			int SoundAmbienceId;
			int ZoneMusicId;
		}
		public class _ScreenLocation
		{
			int ID;
			string Name;
		}
		public class _SDReplacementModel
		{
			int ID;
			int SdFileDataId;
		}
		public class _SeamlessSite
		{
			int ID;
			int MapId;
		}
		public class _ServerMessages
		{
			int ID;
			string Text;
		}
		public class _ShadowyEffect
		{
			int ID;
			uint PrimaryColor;
			uint SecondaryColor;
			float Duration;
			float Value;
			float FadeInTime;
			float FadeOutTime;
			float InnerStrength;
			float OuterStrength;
			float InitialDelay;
			byte AttachPos;
			byte Flags;
			int CurveId;
			int Priority;
		}
		public class _SiegeableProperties
		{
			int ID;
			int Health;
			int DamageSpellVisualKitId;
			int HealingSpellVisualKitId;
			int Flags;
		}
		public class _SkillLine
		{
			int ID;
			string DisplayName;
			string AlternateVerb;
			string Description;
			string HordeDisplayName;
			ushort Flags;
			byte CategoryId;
			byte CanLink;
			int SpellIconFileId;
			int ParentSkillLineId;
			int ParentTierIndex;
		}
		public class _SkillLineAbility
		{
			ulong RaceMask;
			int ID;
			int Spell;
			int SupercedesSpell;
			ushort SkillLine;
			ushort TrivialSkillLineRankHigh;
			ushort TrivialSkillLineRankLow;
			ushort UniqueBit;
			ushort TradeSkillCategoryId;
			byte NumSkillUps;
			ushort MinSkillLineRank;
			int ClassMask;
			byte AcquireMethod;
			byte Flags;
			ushort SkillupSkillLineId;
		}
		public class _SkillRaceClassInfo
		{
			int ID;
			ulong RaceMask;
			ushort SkillId;
			ushort Flags;
			ushort SkillTierId;
			byte Availability;
			byte MinLevel;
			int ClassMask;
		}
		public class _SoundAmbience
		{
			int ID;
			byte Flags;
			int SoundFilterId;
			int FlavorSoundFilterId;
			int[] AmbienceId = new int[2];
			int[] AmbienceStartId = new int[2];
			int[] AmbienceStopId = new int[2];
		}
		public class _SoundAmbienceFlavor
		{
			int ID;
			int SoundEntriesIDDay;
			int SoundEntriesIDNight;
		}
		public class _SoundBus
		{
			float DefaultVolume;
			byte Flags;
			byte DefaultPriority;
			byte DefaultPriorityPenalty;
			byte DefaultPlaybackLimit;
			byte BusEnumId;
			int ID;
		}
		public class _SoundBusOverride
		{
			int ID;
			float Volume;
			byte PlaybackLimit;
			byte Priority;
			byte PriorityPenalty;
			int SoundBusId;
			int PlayerConditionId;
		}
		public class _SoundEmitterPillPoints
		{
			int ID;
			float[] Position = new float[3];
			ushort SoundEmittersId;
		}
		public class _SoundEmitters
		{
			string Name;
			float[] Position = new float[3];
			float[] Direction = new float[3];
			ushort WorldStateExpressionId;
			ushort PhaseId;
			byte EmitterType;
			byte PhaseUseFlags;
			byte Flags;
			int ID;
			int SoundEntriesId;
			int PhaseGroupId;
		}
		public class _SoundEnvelope
		{
			int ID;
			int SoundKitId;
			int CurveId;
			ushort DecayIndex;
			ushort SustainIndex;
			ushort ReleaseIndex;
			byte EnvelopeType;
			int Flags;
		}
		public class _SoundFilter
		{
			int ID;
			string Name;
		}
		public class _SoundFilterElem
		{
			int ID;
			float[] Params = new float[9];
			byte FilterType;
		}
		public class _SoundKit
		{
			int ID;
			float VolumeFloat;
			float MinDistance;
			float DistanceCutoff;
			ushort Flags;
			byte SoundType;
			byte DialogType;
			byte EAXDef;
			int SoundKitAdvancedId;
			float VolumeVariationPlus;
			float VolumeVariationMinus;
			float PitchVariationPlus;
			float PitchVariationMinus;
			float PitchAdjust;
			ushort BusOverwriteId;
			byte MaxInstances;
		}
		public class _SoundKitAdvanced
		{
			int ID;
			float InnerRadius2D;
			float OuterRadius2D;
			float DuckToSFX;
			float DuckToMusic;
			float InnerRadiusOfInfluence;
			float OuterRadiusOfInfluence;
			int TimeToDuck;
			int TimeToUnduck;
			byte Usage;
			int SoundKitId;
			int TimeA;
			int TimeB;
			int TimeC;
			int TimeD;
			int RandomOffsetRange;
			int TimeIntervalMin;
			int TimeIntervalMax;
			int DelayMin;
			int DelayMax;
			byte VolumeSliderCategory;
			float DuckToAmbience;
			float DuckToDialog;
			float DuckToSuppressors;
			float InsideAngle;
			float OutsideAngle;
			float OutsideVolume;
			byte MinRandomPosOffset;
			ushort MaxRandomPosOffset;
			int MsOffset;
			int TimeCooldownMin;
			int TimeCooldownMax;
			byte MaxInstancesBehavior;
			byte VolumeControlType;
			int VolumeFadeInTimeMin;
			int VolumeFadeInTimeMax;
			int VolumeFadeInCurveId;
			int VolumeFadeOutTimeMin;
			int VolumeFadeOutTimeMax;
			int VolumeFadeOutCurveId;
			float ChanceToPlay;
		}
		public class _SoundKitChild
		{
			int ID;
			int SoundKitId;
			int ParentSoundKitId;
		}
		public class _SoundKitEntry
		{
			int ID;
			int SoundKitId;
			int FileDataId;
			byte Frequency;
			float Volume;
		}
		public class _SoundKitFallback
		{
			int ID;
			int SoundKitId;
			int FallbackSoundKitId;
		}
		public class _SoundKitName
		{
			int ID;
			string Name;
		}
		public class _SoundOverride
		{
			int ID;
			ushort ZoneIntroMusicId;
			ushort ZoneMusicId;
			ushort SoundAmbienceId;
			byte SoundProviderPreferencesId;
		}
		public class _SoundProviderPreferences
		{
			int ID;
			string Description;
			float EAXDecayTime;
			float EAX2EnvironmentSize;
			float EAX2EnvironmentDiffusion;
			float EAX2DecayHFRatio;
			float EAX2ReflectionsDelay;
			float EAX2ReverbDelay;
			float EAX2RoomRolloff;
			float EAX2AirAbsorption;
			float EAX3DecayLFRatio;
			float EAX3EchoTime;
			float EAX3EchoDepth;
			float EAX3ModulationTime;
			float EAX3ModulationDepth;
			float EAX3HFReference;
			float EAX3LFReference;
			ushort EAX2Room;
			ushort EAX2RoomHF;
			ushort EAX2Reflections;
			ushort EAX2Reverb;
			ushort Flags;
			byte EAXEnvironmentSelection;
			byte EAX3RoomLF;
		}
		public class _SourceInfo
		{
			int ID;
			string SourceText;
			byte PvpFaction;
			byte SourceTypeEnum;
		}
		public class _SpamMessages
		{
			int ID;
			string Text;
		}
		public class _SpecializationSpells
		{
			string Description;
			int SpellId;
			int OverridesSpellId;
			ushort SpecId;
			byte DisplayOrder;
			int ID;
		}
		public class _Spell
		{
			int ID;
			string NameSubtext;
			string Description;
			string AuraDescription;
		}
		public class _SpellActionBarPref
		{
			int ID;
			int SpellId;
			ushort PreferredActionBarMask;
		}
		public class _SpellActivationOverlay
		{
			int ID;
			int SpellId;
			int OverlayFileDataId;
			uint Color;
			float Scale;
			uint[] IconHighlightSpellClassMask = new uint[4];
			byte ScreenLocationId;
			byte TriggerType;
			int SoundEntriesId;
		}
		public class _SpellAuraOptions
		{
			int ID;
			int ProcCategoryRecovery;
			uint ProcCharges;
			uint[] ProcTypeMask = new uint[2];
			ushort CumulativeAura;
			ushort SpellProcsPerMinuteId;
			byte DifficultyId;
			byte ProcChance;
		}
		public class _SpellAuraRestrictions
		{
			int ID;
			int CasterAuraSpell;
			int TargetAuraSpell;
			int ExcludeCasterAuraSpell;
			int ExcludeTargetAuraSpell;
			byte DifficultyId;
			byte CasterAuraState;
			byte TargetAuraState;
			byte ExcludeCasterAuraState;
			byte ExcludeTargetAuraState;
		}
		public class _SpellAuraVisibility
		{
			byte Type;
			byte Flags;
			int ID;
		}
		public class _SpellAuraVisXChrSpec
		{
			int ID;
			ushort ChrSpecializationId;
		}
		public class _SpellCastingRequirements
		{
			int ID;
			int SpellId;
			ushort MinFactionId;
			ushort RequiredAreasId;
			ushort RequiresSpellFocus;
			byte FacingCasterFlags;
			byte MinReputation;
			byte RequiredAuraVision;
		}
		public class _SpellCastTimes
		{
			int ID;
			uint Base;
			uint Minimum;
			ushort PerLevel;
		}
		public class _SpellCategories
		{
			int ID;
			ushort Category;
			ushort StartRecoveryCategory;
			ushort ChargeCategory;
			byte DifficultyId;
			byte DefenseType;
			byte DispelType;
			byte Mechanic;
			byte PreventionType;
		}
		public class _SpellCategory
		{
			int ID;
			string Name;
			int ChargeRecoveryTime;
			byte Flags;
			byte UsesPerWeek;
			byte MaxCharges;
			int TypeMask;
		}
		public class _SpellChainEffects
		{
			int ID;
			float AvgSegLen;
			float NoiseScale;
			float TexCoordScale;
			int SegDuration;
			int Flags;
			float JointOffsetRadius;
			float MinorJointScale;
			float MajorJointScale;
			float JointMoveSpeed;
			float JointSmoothness;
			float MinDurationBetweenJointJumps;
			float MaxDurationBetweenJointJumps;
			float WaveHeight;
			float WaveFreq;
			float WaveSpeed;
			float MinWaveAngle;
			float MaxWaveAngle;
			float MinWaveSpin;
			float MaxWaveSpin;
			float ArcHeight;
			float MinArcAngle;
			float MaxArcAngle;
			float MinArcSpin;
			float MaxArcSpin;
			float DelayBetweenEffects;
			float MinFlickerOnDuration;
			float MaxFlickerOnDuration;
			float MinFlickerOffDuration;
			float MaxFlickerOffDuration;
			float PulseSpeed;
			float PulseOnLength;
			float PulseFadeLength;
			float WavePhase;
			float TimePerFlipFrame;
			float VariancePerFlipFrame;
			float[] TextureCoordScaleU = new float[3];
			float[] TextureCoordScaleV = new float[3];
			float[] TextureRepeatLengthU = new float[3];
			float[] TextureRepeatLengthV = new float[3];
			int TextureParticleFileDataId;
			float StartWidth;
			float EndWidth;
			float ParticleScaleMultiplier;
			float ParticleEmissionRateMultiplier;
			ushort SegDelay;
			ushort JointCount;
			ushort[] SpellChainEffectId = new ushort[11];
			ushort WidthScaleCurveId;
			byte JointsPerMinorJoint;
			byte MinorJointsPerMajorJoint;
			byte Alpha;
			byte Red;
			byte Green;
			byte Blue;
			byte BlendMode;
			byte RenderLayer;
			byte NumFlipFramesU;
			byte NumFlipFramesV;
			int SoundKitId;
			int[] TextureFileDataId = new int[3];
		}
		public class _SpellClassOptions
		{
			int ID;
			int SpellId;
			uint[] SpellClassMask = new uint[4];
			byte SpellClassSet;
			int ModalNextSpell;
		}
		public class _SpellCooldowns
		{
			int ID;
			int CategoryRecoveryTime;
			int RecoveryTime;
			int StartRecoveryTime;
			byte DifficultyId;
		}
		public class _SpellDescriptionVariables
		{
			int ID;
			string Variables;
		}
		public class _SpellDispelType
		{
			int ID;
			string Name;
			string InternalName;
			byte ImmunityPossible;
			byte Mask;
		}
		public class _SpellDuration
		{
			int ID;
			uint Duration;
			uint MaxDuration;
			uint DurationPerLevel;
		}
		public class _SpellEffect
		{
			int ID;
			int DifficultyId;
			int EffectIndex;
			int Effect;
			float EffectAmplitude;
			int EffectAttributes;
			int EffectAura;
			int EffectAuraPeriod;
			int EffectBasePoints;
			float EffectBonusCoefficient;
			float EffectChainAmplitude;
			int EffectChainTargets;
			int EffectDieSides;
			int EffectItemType;
			int EffectMechanic;
			float EffectPointsPerResource;
			float EffectPosFacing;
			float EffectRealPointsPerLevel;
			int EffectTriggerSpell;
			float BonusCoefficientFromAP;
			float PvpMultiplier;
			float Coefficient;
			float Variance;
			float ResourceCoefficient;
			float GroupSizeBasePointsCoefficient;
			int[] EffectMiscValue = new int[2];
			int[] EffectRadiusIndex = new int[2];
			int[] EffectSpellClassMask = new int[4];
			int[] ImplicitTarget = new int[2];
		}
		public class _SpellEffectAutoDescription
		{
			int ID;
			string EffectDescription;
			string AuraDescription;
			int SpellEffectType;
			int AuraEffectType;
			int EffectOrderIndex;
			int AuraOrderIndex;
			byte PointsSign;
			byte TargetType;
			byte SchoolMask;
		}
		public class _SpellEffectEmission
		{
			int ID;
			float EmissionRate;
			float ModelScale;
			ushort AreaModelId;
			byte Flags;
		}
		public class _SpellEquippedItems
		{
			int ID;
			int SpellId;
			int EquippedItemInvTypes;
			int EquippedItemSubclass;
			byte EquippedItemClass;
		}
		public class _SpellFlyout
		{
			int ID;
			ulong RaceMask;
			string Name;
			string Description;
			byte Flags;
			int ClassMask;
			int SpellIconFileId;
		}
		public class _SpellFlyoutItem
		{
			int ID;
			int SpellId;
			byte Slot;
		}
		public class _SpellFocusObject
		{
			int ID;
			string Name;
		}
		public class _SpellInterrupts
		{
			int ID;
			byte DifficultyId;
			ushort InterruptFlags;
			int[] AuraInterruptFlags = new int[2];
			int[] ChannelInterruptFlags = new int[2];
		}
		public class _SpellItemEnchantment
		{
			int ID;
			string Name;
			string HordeName;
			int[] EffectArg = new int[3];
			float[] EffectScalingPoints = new float[3];
			int TransmogCost;
			int IconFileDataId;
			ushort[] EffectPointsMin = new ushort[3];
			ushort ItemVisual;
			ushort Flags;
			ushort RequiredSkillId;
			ushort RequiredSkillRank;
			ushort ItemLevel;
			byte Charges;
			byte[] Effect = new byte[3];
			byte ScalingClass;
			byte ScalingClassRestricted;
			byte ConditionId;
			byte MinLevel;
			byte MaxLevel;
			int TransmogPlayerConditionId;
		}
		public class _SpellItemEnchantmentCondition
		{
			int ID;
			int[] LtOperand = new int[5];
			byte[] LtOperandType = new byte[5];
			byte[] Operator = new byte[5];
			byte[] RtOperandType = new byte[5];
			byte[] RtOperand = new byte[5];
			byte[] Logic = new byte[5];
		}
		public class _SpellKeyboundOverride
		{
			int ID;
			string Function;
			int Data;
			byte Type;
		}
		public class _SpellLabel
		{
			int ID;
			int LabelId;
		}
		public class _SpellLearnSpell
		{
			int ID;
			int SpellId;
			int LearnSpellId;
			int OverridesSpellId;
		}
		public class _SpellLevels
		{
			int ID;
			ushort BaseLevel;
			ushort MaxLevel;
			ushort SpellLevel;
			byte DifficultyId;
			byte MaxPassiveAuraLevel;
		}
		public class _SpellMechanic
		{
			int ID;
			string StateName;
		}
		public class _SpellMisc
		{
			int ID;
			byte DifficultyId;
			ushort CastingTimeIndex;
			ushort DurationIndex;
			ushort RangeIndex;
			byte SchoolMask;
			float Speed;
			float LaunchDelay;
			int SpellIconFileDataId;
			int ActiveIconFileDataId;
			int[] Attributes = new int[14];
		}
		public class _SpellMissile
		{
			int ID;
			int SpellId;
			float DefaultPitchMin;
			float DefaultPitchMax;
			float DefaultSpeedMin;
			float DefaultSpeedMax;
			float RandomizeFacingMin;
			float RandomizeFacingMax;
			float RandomizePitchMin;
			float RandomizePitchMax;
			float RandomizeSpeedMin;
			float RandomizeSpeedMax;
			float Gravity;
			float MaxDuration;
			float CollisionRadius;
			byte Flags;
		}
		public class _SpellMissileMotion
		{
			int ID;
			string Name;
			string ScriptBody;
			byte Flags;
			byte MissileCount;
		}
		public class _SpellName
		{
			int ID;
			string Name;
		}
		public class _SpellPower
		{
			uint ManaCost;
			float PowerCostPct;
			float PowerCostMaxPct;
			float PowerPctPerSecond;
			int RequiredAuraSpellId;
			byte OrderIndex;
			byte PowerType;
			int ID;
			uint ManaCostPerLevel;
			int ManaPerSecond;
			int PowerDisplayId;
			int AltPowerBarId;
			int OptionalCost;
		}
		public class _SpellPowerDifficulty
		{
			byte DifficultyId;
			byte OrderIndex;
			int ID;
		}
		public class _SpellProceduralEffect
		{
			float[] Value = new float[4];
			byte Type;
			int ID;
		}
		public class _SpellProcsPerMinute
		{
			int ID;
			float BaseProcRate;
			byte Flags;
		}
		public class _SpellProcsPerMinuteMod
		{
			int ID;
			float Coeff;
			ushort Param;
			byte Type;
		}
		public class _SpellRadius
		{
			int ID;
			float Radius;
			float RadiusPerLevel;
			float RadiusMin;
			float RadiusMax;
		}
		public class _SpellRange
		{
			int ID;
			string DisplayName;
			string DisplayNameShort;
			float[] RangeMin = new float[2];
			float[] RangeMax = new float[2];
			byte Flags;
		}
		public class _SpellReagents
		{
			int ID;
			int SpellId;
			int[] Reagent = new int[8];
			ushort[] ReagentCount = new ushort[8];
		}
		public class _SpellReagentsCurrency
		{
			int ID;
			int SpellId;
			ushort CurrencyTypesId;
			ushort CurrencyCount;
		}
		public class _SpellScaling
		{
			int ID;
			int SpellId;
			ushort ScalesFromItemLevel;
			int Class;
			int MinScalingLevel;
			int MaxScalingLevel;
		}
		public class _SpellShapeshift
		{
			int ID;
			int SpellId;
			uint[] ShapeshiftExclude = new uint[2];
			uint[] ShapeshiftMask = new uint[2];
			byte StanceBarOrder;
		}
		public class _SpellShapeshiftForm
		{
			int ID;
			string Name;
			int Flags;
			float DamageVariance;
			ushort CombatRoundTime;
			ushort MountTypeId;
			byte CreatureType;
			byte BonusActionBar;
			int AttackIconFileId;
			int[] CreatureDisplayId = new int[4];
			int[] PresetSpellId = new int[8];
		}
		public class _SpellSpecialUnitEffect
		{
			int ID;
			ushort SpellVisualEffectNameId;
			int PositionerId;
		}
		public class _SpellTargetRestrictions
		{
			int ID;
			float ConeDegrees;
			int Targets;
			float Width;
			ushort TargetCreatureType;
			byte DifficultyId;
			byte MaxTargets;
			int MaxTargetLevel;
		}
		public class _SpellTotems
		{
			int ID;
			int SpellId;
			int[] Totem = new int[2];
			ushort[] RequiredTotemCategoryId = new ushort[2];
		}
		public class _SpellVisual
		{
			int ID;
			int Flags;
			float[] MissileCastOffset = new float[3];
			float[] MissileImpactOffset = new float[3];
			ushort SpellVisualMissileSetId;
			byte MissileAttachment;
			byte MissileDestinationAttachment;
			int AnimEventSoundId;
			int MissileCastPositionerId;
			int MissileImpactPositionerId;
			int MissileTargetingKit;
			int HostileSpellVisualId;
			int CasterSpellVisualId;
			ushort DamageNumberDelay;
			int LowViolenceSpellVisualId;
		}
		public class _SpellVisualAnim
		{
			int ID;
			ushort InitialAnimId;
			ushort LoopAnimId;
			ushort AnimKitId;
		}
		public class _SpellVisualColorEffect
		{
			int ID;
			float Duration;
			uint Color;
			float ColorMultiplier;
			ushort RedCurveId;
			ushort GreenCurveId;
			ushort BlueCurveId;
			ushort AlphaCurveId;
			ushort OpacityCurveId;
			byte Flags;
			byte Type;
			int PositionerId;
		}
		public class _SpellVisualEffectName
		{
			int ID;
			int ModelFileDataId;
			float BaseMissileSpeed;
			float Scale;
			float MinAllowedScale;
			float MaxAllowedScale;
			float Alpha;
			int Flags;
			int TextureFileDataId;
			float EffectRadius;
			int Type;
			int GenericId;
			int RibbonQualityId;
			int DissolveEffectId;
			int ModelPosition;
		}
		public class _SpellVisualEvent
		{
			int ID;
			int StartEvent;
			int EndEvent;
			int StartMinOffsetMs;
			int StartMaxOffsetMs;
			int EndMinOffsetMs;
			int EndMaxOffsetMs;
			int TargetType;
			int SpellVisualKitId;
		}
		public class _SpellVisualKit
		{
			int ID;
			int Flags;
			float FallbackPriority;
			int FallbackSpellVisualKitId;
			ushort DelayMin;
			ushort DelayMax;
		}
		public class _SpellVisualKitAreaModel
		{
			int ID;
			int ModelFileDataId;
			float EmissionRate;
			float Spacing;
			float ModelScale;
			ushort LifeTime;
			byte Flags;
		}
		public class _SpellVisualKitEffect
		{
			int ID;
			int EffectType;
			int Effect;
		}
		public class _SpellVisualKitModelAttach
		{
			float[] Offset = new float[3];
			float[] OffsetVariation = new float[3];
			int ID;
			ushort SpellVisualEffectNameId;
			byte AttachmentId;
			ushort PositionerId;
			float Yaw;
			float Pitch;
			float Roll;
			float YawVariation;
			float PitchVariation;
			float RollVariation;
			float Scale;
			float ScaleVariation;
			ushort StartAnimId;
			ushort AnimId;
			ushort EndAnimId;
			ushort AnimKitId;
			byte Flags;
			int LowDefModelAttachId;
			float StartDelay;
		}
		public class _SpellVisualMissile
		{
			uint FollowGroundHeight;
			int FollowGroundDropSpeed;
			int Flags;
			float[] CastOffset = new float[3];
			float[] ImpactOffset = new float[3];
			ushort SpellVisualEffectNameId;
			ushort CastPositionerId;
			ushort ImpactPositionerId;
			ushort FollowGroundApproach;
			ushort SpellMissileMotionId;
			byte Attachment;
			byte DestinationAttachment;
			int ID;
			int SoundEntriesId;
			int AnimKitId;
		}
		public class _SpellXDescriptionVariables
		{
			int ID;
			int SpellId;
			int SpellDescriptionVariablesId;
		}
		public class _SpellXSpellVisual
		{
			int SpellVisualId;
			int ID;
			byte DifficultyId;
			float Probability;
			byte Flags;
			byte Priority;
			int SpellIconFileId;
			int ActiveIconFileId;
			ushort ViewerUnitConditionId;
			int ViewerPlayerConditionId;
			ushort CasterUnitConditionId;
			int CasterPlayerConditionId;
		}
		public class _StartupFiles
		{
			int ID;
			int FileDataId;
			int Locale;
			int BytesRequired;
		}
		public class _Startup_Strings
		{
			int ID;
			string Name;
			string Message;
		}
		public class _Stationery
		{
			int ID;
			byte Flags;
			int ItemId;
			int[] TextureFileDataId = new int[2];
		}
		public class _SummonProperties
		{
			int ID;
			uint Flags;
			int Control;
			int Faction;
			int Title;
			int Slot;
		}
		public class _TactKey
		{
			int ID;
			byte[] Key = new byte[16];
		}
		public class _TactKeyLookup
		{
			int ID;
			byte[] TACTId = new byte[8];
		}
		public class _Talent
		{
			int ID;
			string Description;
			int SpellId;
			int OverridesSpellId;
			ushort SpecId;
			byte TierId;
			byte Flags;
			byte ColumnIndex;
			byte[] CategoryMask = new byte[2];
			byte ClassId;
		}
		public class _TaxiNodes
		{
			string Name;
			int ID;
			float[] Pos = new float[3];
			int[] MountCreatureId = new int[2];
			float[] MapOffset = new float[2];
			float Facing;
			float[] FlightMapOffset = new float[2];
			ushort ContinentId;
			ushort ConditionId;
			ushort CharacterBitNumber;
			byte Flags;
			int UiTextureKitId;
			int SpecialIconConditionId;
		}
		public class _TaxiPath
		{
			ushort FromTaxiNode;
			ushort ToTaxiNode;
			int ID;
			int Cost;
		}
		public class _TaxiPathNode
		{
			float[] Loc = new float[3];
			ushort PathId;
			ushort ContinentId;
			byte NodeIndex;
			int ID;
			byte Flags;
			int Delay;
			ushort ArrivalEventId;
			ushort DepartureEventId;
		}
		public class _TerrainMaterial
		{
			int ID;
			byte Shader;
			int EnvMapDiffuseFileId;
			int EnvMapSpecularFileId;
		}
		public class _TerrainType
		{
			int ID;
			string TerrainDesc;
			ushort FootstepSprayRun;
			ushort FootstepSprayWalk;
			byte SoundId;
			byte Flags;
		}
		public class _TerrainTypeSounds
		{
			int ID;
			string Name;
		}
		public class _TextureBlendSet
		{
			int ID;
			int[] TextureFileDataId = new int[3];
			float[] TextureScrollRateU = new float[3];
			float[] TextureScrollRateV = new float[3];
			float[] TextureScaleU = new float[3];
			float[] TextureScaleV = new float[3];
			float[] ModX = new float[4];
			byte SwizzleRed;
			byte SwizzleGreen;
			byte SwizzleBlue;
			byte SwizzleAlpha;
		}
		public class _TextureFileData
		{
			int ID;
			byte UsageType;
			int MaterialResourcesId;
		}
		public class _TotemCategory
		{
			int ID;
			string Name;
			uint TotemCategoryMask;
			byte TotemCategoryType;
		}
		public class _Toy
		{
			string SourceText;
			int ItemId;
			byte Flags;
			byte SourceTypeEnum;
			int ID;
		}
		public class _TradeSkillCategory
		{
			string Name;
			string HordeName;
			int ID;
			ushort ParentTradeSkillCategoryId;
			ushort SkillLineId;
			ushort OrderIndex;
			byte Flags;
		}
		public class _TradeSkillItem
		{
			int ID;
			ushort ItemLevel;
			byte RequiredLevel;
		}
		public class _TransformMatrix
		{
			int ID;
			float[] Pos = new float[3];
			float Yaw;
			float Pitch;
			float Roll;
			float Scale;
		}
		public class _TransmogHoliday
		{
			int ID;
			int RequiredTransmogHoliday;
		}
		public class _TransmogSet
		{
			string Name;
			ushort ParentTransmogSetId;
			ushort UiOrder;
			byte ExpansionId;
			int ID;
			int ClassMask;
			int TrackingQuestId;
			int Flags;
			int TransmogSetGroupId;
			int ItemNameDescriptionId;
		}
		public class _TransmogSetGroup
		{
			string Name;
			int ID;
		}
		public class _TransmogSetItem
		{
			int ID;
			int TransmogSetId;
			int ItemModifiedAppearanceId;
			int Flags;
		}
		public class _TransportAnimation
		{
			int ID;
			int TimeIndex;
			float[] Pos = new float[3];
			byte SequenceId;
		}
		public class _TransportPhysics
		{
			int ID;
			float WaveAmp;
			float WaveTimeScale;
			float RollAmp;
			float RollTimeScale;
			float PitchAmp;
			float PitchTimeScale;
			float MaxBank;
			float MaxBankTurnSpeed;
			float SpeedDampThresh;
			float SpeedDamp;
		}
		public class _TransportRotation
		{
			int ID;
			int TimeIndex;
			float[] Rot = new float[4];
		}
		public class _Trophy
		{
			int ID;
			string Name;
			ushort GameObjectDisplayInfoId;
			byte TrophyTypeId;
			int PlayerConditionId;
		}
		public class _UiCamera
		{
			int ID;
			string Name;
			float[] Pos = new float[3];
			float[] LookAt = new float[3];
			float[] Up = new float[3];
			ushort AnimFrame;
			byte UiCameraTypeId;
			byte AnimVariation;
			byte Flags;
			int AnimId;
		}
		public class _UiCameraType
		{
			int ID;
			string Name;
			int Width;
			int Height;
		}
		public class _UiCamFbackTransmogChrRace
		{
			int ID;
			ushort UiCameraId;
			byte ChrRaceId;
			byte Gender;
			byte InventoryType;
			byte Variation;
		}
		public class _UiCamFbackTransmogWeapon
		{
			int ID;
			ushort UiCameraId;
			byte ItemClass;
			byte ItemSubclass;
			byte InventoryType;
		}
		public class _UiCanvas
		{
			int ID;
			ushort Width;
			ushort Height;
		}
		public class _UIExpansionDisplayInfo
		{
			int ID;
			int ExpansionLogo;
			int ExpansionBanner;
			int ExpansionLevel;
		}
		public class _UIExpansionDisplayInfoIcon
		{
			int ID;
			string FeatureDescription;
			int ParentId;
			int FeatureIcon;
		}
		public class _UiMap
		{
			string Name;
			int ID;
			int ParentUiMapId;
			int Flags;
			int System;
			int Type;
			int LevelRangeMin;
			int LevelRangeMax;
			int BountySetId;
			int BountyDisplayLocation;
			int VisibilityPlayerConditionId;
			byte HelpTextPosition;
			int BkgFileDataId;
		}
		public class _UiMapArt
		{
			int ID;
			int HighlightFileDataId;
			int UiMapArtStyleId;
		}
		public class _UiMapArtStyleLayer
		{
			int ID;
			float MinScale;
			float MaxScale;
			int AdditionalZoomSteps;
			ushort LayerWidth;
			ushort LayerHeight;
			ushort TileWidth;
			ushort TileHeight;
			byte LayerIndex;
		}
		public class _UiMapArtTile
		{
			int ID;
			int FileDataId;
			byte RowIndex;
			byte ColIndex;
			byte LayerIndex;
		}
		public class _UiMapAssignment
		{
			int ID;
			int UiMapId;
			uint OrderIndex;
			float[] UiMin = new float[2];
			float[] UiMax = new float[2];
			int MapId;
			int AreaId;
			int WmoDoodadPlacementId;
			int WmoGroupId;
			float[] Region = new float[6];
		}
		public class _UiMapFogOfWar
		{
			int ID;
			int UiMapId;
			int PlayerConditionId;
			int UiMapFogOfWarVisId;
		}
		public class _UiMapFogOfWarVisualization
		{
			int ID;
			float MaskScalar;
			int BackgroundAtlasId;
			int MaskAtlasId;
		}
		public class _UiMapGroupMember
		{
			int ID;
			string Name;
			int UiMapGroupId;
			int UiMapId;
			int FloorIndex;
			byte RelativeHeightIndex;
		}
		public class _UiMapPOI
		{
			int ContinentId;
			float[] WorldLoc = new float[3];
			int UiTextureAtlasMemberId;
			int Flags;
			ushort PoiDataType;
			ushort PoiData;
			int ID;
		}
		public class _UiMapXMapArt
		{
			int ID;
			int PhaseId;
			int UiMapArtId;
		}
		public class _UiModelScene
		{
			int ID;
			byte UiSystemType;
			byte Flags;
		}
		public class _UiModelSceneActor
		{
			string ScriptTag;
			float[] Position = new float[3];
			float OrientationYaw;
			float OrientationPitch;
			float OrientationRoll;
			float NormalizedScale;
			byte Flags;
			int ID;
			int UiModelSceneActorDisplayId;
		}
		public class _UiModelSceneActorDisplay
		{
			int ID;
			float Alpha;
			float Scale;
			float AnimSpeed;
			int AnimationId;
			int SequenceVariation;
		}
		public class _UiModelSceneCamera
		{
			string ScriptTag;
			float[] Target = new float[3];
			float Yaw;
			float Pitch;
			float Roll;
			float[] ZoomedTargetOffset = new float[3];
			float ZoomedYawOffset;
			float ZoomedPitchOffset;
			float ZoomedRollOffset;
			float ZoomDistance;
			float MinZoomDistance;
			float MaxZoomDistance;
			byte Flags;
			byte CameraType;
			int ID;
		}
		public class _UiPartyPose
		{
			int ID;
			int UiWidgetSetId;
			int UiModelSceneId;
		}
		public class _UiTextureAtlas
		{
			int ID;
			int FileDataId;
			ushort AtlasWidth;
			ushort AtlasHeight;
			byte UiCanvasId;
		}
		public class _UiTextureAtlasElement
		{
			string Name;
			int ID;
		}
		public class _UiTextureAtlasMember
		{
			string CommittedName;
			int ID;
			ushort UiTextureAtlasId;
			ushort CommittedLeft;
			ushort CommittedRight;
			ushort CommittedTop;
			ushort CommittedBottom;
			ushort UiTextureAtlasElementId;
			byte CommittedFlags;
			byte UiCanvasId;
		}
		public class _UiTextureKit
		{
			int ID;
			string KitPrefix;
		}
		public class _UiWidget
		{
			int ID;
			int VisId;
			uint MapId;
			int PlayerConditionId;
			int OrderIndex;
			ushort ParentSetId;
		}
		public class _UiWidgetConstantSource
		{
			int ID;
			int Value;
			ushort ReqId;
		}
		public class _UiWidgetDataSource
		{
			int ID;
			ushort ReqId;
			ushort SourceId;
			byte SourceType;
		}
		public class _UiWidgetStringSource
		{
			int ID;
			string Value;
			ushort ReqId;
		}
		public class _UiWidgetVisualization
		{
			int ID;
			int TextureKit;
			byte VisType;
		}
		public class _UnitBlood
		{
			int ID;
			int PlayerCritBloodSpurtId;
			int PlayerHitBloodSpurtId;
			int DefaultBloodSpurtId;
			int PlayerOmniCritBloodSpurtId;
			int PlayerOmniHitBloodSpurtId;
			int DefaultOmniBloodSpurtId;
		}
		public class _UnitBloodLevels
		{
			int ID;
			byte[] Violencelevel = new byte[3];
		}
		public class _UnitCondition
		{
			int ID;
			int[] Value = new int[8];
			byte Flags;
			byte[] Variable = new byte[8];
			byte[] Op = new byte[8];
		}
		public class _UnitPowerBar
		{
			int ID;
			string Name;
			string Cost;
			string OutOfError;
			string ToolTip;
			float RegenerationPeace;
			float RegenerationCombat;
			int[] FileDataId = new int[6];
			uint[] Color = new uint[6];
			float StartInset;
			float EndInset;
			ushort StartPower;
			ushort Flags;
			byte CenterPower;
			byte BarType;
			int MinPower;
			int MaxPower;
		}
		public class _Vehicle
		{
			int ID;
			uint Flags;
			float TurnSpeed;
			float PitchSpeed;
			float PitchMin;
			float PitchMax;
			float MouseLookOffsetPitch;
			float CameraFadeDistScalarMin;
			float CameraFadeDistScalarMax;
			float CameraPitchOffset;
			float FacingLimitRight;
			float FacingLimitLeft;
			float CameraYawOffset;
			ushort[] SeatId = new ushort[8];
			ushort[] PowerDisplayId = new ushort[3];
			ushort VehicleUIIndicatorId;
			byte FlagsB;
			byte UiLocomotionType;
			int MissileTargetingId;
		}
		public class _VehicleSeat
		{
			int ID;
			uint Flags;
			uint FlagsB;
			uint FlagsC;
			float[] AttachmentOffset = new float[3];
			float EnterPreDelay;
			float EnterSpeed;
			float EnterGravity;
			float EnterMinDuration;
			float EnterMaxDuration;
			float EnterMinArcHeight;
			float EnterMaxArcHeight;
			float ExitPreDelay;
			float ExitSpeed;
			float ExitGravity;
			float ExitMinDuration;
			float ExitMaxDuration;
			float ExitMinArcHeight;
			float ExitMaxArcHeight;
			float PassengerYaw;
			float PassengerPitch;
			float PassengerRoll;
			float VehicleEnterAnimDelay;
			float VehicleExitAnimDelay;
			int UiSkinFileDataId;
			float CameraEnteringDelay;
			float CameraEnteringDuration;
			float CameraExitingDelay;
			float CameraExitingDuration;
			float[] CameraOffset = new float[3];
			float CameraPosChaseRate;
			float CameraFacingChaseRate;
			float CameraEnteringZoom;
			float CameraSeatZoomMin;
			float CameraSeatZoomMax;
			ushort EnterAnimStart;
			ushort EnterAnimLoop;
			ushort RideAnimStart;
			ushort RideAnimLoop;
			ushort RideUpperAnimStart;
			ushort RideUpperAnimLoop;
			ushort ExitAnimStart;
			ushort ExitAnimLoop;
			ushort ExitAnimEnd;
			ushort VehicleEnterAnim;
			ushort VehicleExitAnim;
			ushort VehicleRideAnimLoop;
			ushort EnterAnimKitId;
			ushort RideAnimKitId;
			ushort ExitAnimKitId;
			ushort VehicleEnterAnimKitId;
			ushort VehicleRideAnimKitId;
			ushort VehicleExitAnimKitId;
			ushort CameraModeId;
			byte AttachmentId;
			byte VehicleEnterAnimBone;
			byte VehicleExitAnimBone;
			byte VehicleRideAnimLoopBone;
			byte PassengerAttachmentId;
			byte VehicleAbilityDisplay;
			int EnterUISoundId;
			int ExitUISoundId;
		}
		public class _VehicleUIIndicator
		{
			int ID;
			int BackgroundTextureFileId;
		}
		public class _VehicleUIIndSeat
		{
			int ID;
			float XPos;
			float YPos;
			byte VirtualSeatIndex;
		}
		public class _Vignette
		{
			int ID;
			string Name;
			float MaxHeight;
			float MinHeight;
			int PlayerConditionId;
			int VisibleTrackingQuestId;
			int QuestFeedbackEffectId;
			int Flags;
		}
		public class _VirtualAttachment
		{
			int ID;
			string Name;
			ushort PositionerId;
		}
		public class _VirtualAttachmentCustomization
		{
			int ID;
			int FileDataId;
			ushort VirtualAttachmentId;
			ushort PositionerId;
		}
		public class _VocalUISounds
		{
			int ID;
			byte VocalUIEnum;
			byte RaceId;
			byte ClassId;
			int[] NormalSoundId = new int[2];
		}
		public class _WbAccessControlList
		{
			int ID;
			string URL;
			ushort GrantFlags;
			byte RevokeFlags;
			byte WowEditInternal;
			byte RegionId;
		}
		public class _WbCertWhitelist
		{
			int ID;
			string Domain;
			byte GrantAccess;
			byte RevokeAccess;
			byte WowEditInternal;
		}
		public class _WeaponImpactSounds
		{
			int ID;
			byte WeaponSubClassId;
			byte ParrySoundType;
			byte ImpactSource;
			int[] ImpactSoundId = new int[11];
			int[] CritImpactSoundId = new int[11];
			int[] PierceImpactSoundId = new int[11];
			int[] PierceCritImpactSoundId = new int[11];
		}
		public class _WeaponSwingSounds2
		{
			int ID;
			byte SwingType;
			byte Crit;
			int SoundId;
		}
		public class _WeaponTrail
		{
			int ID;
			int FileDataId;
			float Roll;
			float Pitch;
			float Yaw;
			int[] TextureFileDataId = new int[3];
			float[] TextureScrollRateU = new float[3];
			float[] TextureScrollRateV = new float[3];
			float[] TextureScaleU = new float[3];
			float[] TextureScaleV = new float[3];
		}
		public class _WeaponTrailModelDef
		{
			int ID;
			int LowDefFileDataId;
			ushort WeaponTrailId;
		}
		public class _WeaponTrailParam
		{
			int ID;
			float Duration;
			float FadeOutTime;
			float EdgeLifeSpan;
			float InitialDelay;
			float SmoothSampleAngle;
			byte Hand;
			byte OverrideAttachTop;
			byte OverrideAttachBot;
			byte Flags;
		}
		public class _Weather
		{
			int ID;
			float[] Intensity = new float[2];
			float TransitionSkyBox;
			float[] EffectColor = new float[3];
			float Scale;
			float Volatility;
			float TwinkleIntensity;
			float FallModifier;
			float RotationalSpeed;
			int ParticulateFileDataId;
			float VolumeEdgeFadeStart;
			int OverrideColor;
			int OverrideCount;
			float OverrideOpacity;
			int VolumeFlags;
			int LightningId;
			ushort SoundAmbienceId;
			byte Type;
			byte EffectType;
			byte WindSettingsId;
			int AmbienceId;
			int EffectTextureFileDataId;
		}
		public class _WeatherXParticulate
		{
			int ID;
			int FileDataId;
		}
		public class _WindSettings
		{
			int ID;
			float BaseMag;
			float[] BaseDir = new float[3];
			float VarianceMagOver;
			float VarianceMagUnder;
			float[] VarianceDir = new float[3];
			float MaxStepMag;
			float[] MaxStepDir = new float[3];
			float Frequency;
			float Duration;
			byte Flags;
		}
		public class _WMOAreaTable
		{
			string AreaName;
			uint WmoGroupId;
			ushort WmoId;
			ushort AmbienceId;
			ushort UwAmbience;
			ushort ZoneMusic;
			ushort IntroSound;
			ushort UwIntroSound;
			ushort AreaTableId;
			byte NameSetId;
			byte SoundProviderPref;
			byte SoundProviderPrefUnderwater;
			byte Flags;
			int ID;
			int UwZoneMusic;
		}
		public class _WmoMinimapTexture
		{
			int ID;
			int FileDataId;
			ushort GroupNum;
			byte BlockX;
			byte BlockY;
		}
		public class _WorldBossLockout
		{
			int ID;
			string Name;
			ushort TrackingQuestId;
		}
		public class _WorldChunkSounds
		{
			int ID;
			ushort MapId;
			byte SoundOverrideId;
			byte ChunkX;
			byte ChunkY;
			byte SubChunkX;
			byte SubChunkY;
		}
		public class _WorldEffect
		{
			int ID;
			uint TargetAsset;
			ushort CombatConditionId;
			byte WhenToDisplay;
			byte TargetType;
			int QuestFeedbackEffectId;
			int PlayerConditionId;
		}
		public class _WorldElapsedTimer
		{
			int ID;
			string Name;
			byte Type;
			byte Flags;
		}
		public class _WorldMapOverlay
		{
			int ID;
			ushort TextureWidth;
			ushort TextureHeight;
			int UiMapArtId;
			int OffsetX;
			int OffsetY;
			int HitRectTop;
			int HitRectBottom;
			int HitRectLeft;
			int HitRectRight;
			int PlayerConditionId;
			int Flags;
			int[] AreaId = new int[4];
		}
		public class _WorldMapOverlayTile
		{
			int ID;
			int FileDataId;
			byte RowIndex;
			byte ColIndex;
			byte LayerIndex;
		}
		public class _WorldSafeLocs
		{
			int ID;
			string Name;
			float X;
			float Y;
			float Z;
			float Rotation;
			ushort MapId;
		}
		public class _WorldState
		{
			int ID;
		}
		public class _WorldStateExpression
		{
			int ID;
			string Expression;
		}
		public class _WorldStateUI
		{
			string Icon;
			string String;
			string Tooltip;
			string DynamicTooltip;
			string ExtendedUI;
			ushort MapId;
			ushort AreaId;
			ushort StateVariable;
			ushort[] ExtendedUIStateVariable = new ushort[3];
			ushort PhaseId;
			ushort PhaseGroupId;
			byte Type;
			byte OrderIndex;
			byte PhaseUseFlags;
			int ID;
			int DynamicIconFileId;
			int DynamicFlashIconFileId;
		}
		public class _WorldStateZoneSounds
		{
			int ID;
			int WmoAreaId;
			ushort WorldStateId;
			ushort WorldStateValue;
			ushort AreaId;
			ushort ZoneIntroMusicId;
			ushort ZoneMusicId;
			ushort SoundAmbienceId;
			byte SoundProviderPreferencesId;
		}
		public class _World_PVP_Area
		{
			int ID;
			ushort AreaId;
			ushort NextTimeWorldstate;
			ushort GameTimeWorldstate;
			ushort BattlePopulateTime;
			ushort MapId;
			byte MinLevel;
			byte MaxLevel;
		}
		public class _ZoneIntroMusicTable
		{
			int ID;
			string Name;
			ushort MinDelayMinutes;
			byte Priority;
			int SoundId;
		}
		public class _ZoneLight
		{
			int ID;
			string Name;
			ushort MapId;
			ushort LightId;
			byte Flags;
		}
		public class _ZoneLightPoint
		{
			int ID;
			float[] Pos = new float[2];
			byte PointOrder;
		}
		public class _ZoneMusic
		{
			int ID;
			string SetName;
			int[] SilenceIntervalMin = new int[2];
			int[] SilenceIntervalMax = new int[2];
			int[] Sounds = new int[2];
		}
		public class _ZoneStory
		{
			int ID;
			int DisplayAchievementId;
			int DisplayWorldMapAreaId;
			byte PlayerFactionGroupId;
		}
	}
}
