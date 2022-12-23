using Newtonsoft.Json;
using ResurrectedEternalSkeens.Configs.ConfigSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ResurrectedEternalSkeens.GenericObjects
{
    public class Offsets
    {


        #region "signatures"
        public int m_dwGetAllClasses; // = 0xDB101C;
        public int dwViewMatrix;// 0x4D93824;
        public int dwEntityList;// 0x4DA1F24;
        public int dwRadarBase;// 0x51D6C9C;//0x518810C;
        public int dwGlowObjectManager;// 0x52EA520;//0x529A1D0;
        public int dwPlayerResource;// 0x31D17E0;
        public int dwForceJump;// 0x524BE84;
        public int dwForceAttack;// 0x31D3460;
        public int dwForceLeft;
        public int dwForceRight;
        public int dwGameRulesProxy;// 0x52BF16C;
        public int dwGlobalVars;// 0x58ECE8;  
        public int dwClientState;// 0x58EFE4;
        //force_spectator_glow
        public int dwForceGlow;// 0x3AD962;
        public int dwPlayerInfo;// 0x52C0;
        public int dwModelPrecacheTable;// 0x52A4;
        public int m_dwConvarTable;// 0x2F0F8;
        public int m_engineCvar;// 0x3E9EC;
        #endregion



        public int dwClientState_Map = 0x28C;
        public int dwClientState_MapDirectory = 0x188;
        public int dwClientState_MaxPlayer = 0x388;
        public int dwClientState_ViewAngles = 0x4D90;

        public int m_dwLocalPlayerIndex = 0x180;
        public int m_dwIndex = 0x64;
        public int m_bDormant = 0xED;
        public int GameState = 0x108;// 0x108;
        public int EntitySize = 0x10;


        public int m_aimPunchAngle => m_Local + g_Globals.NetVars["DT_Local::m_aimPunchAngle"]; // 0x302C;
        public int m_aimPunchAngleVel => m_Local + g_Globals.NetVars["DT_Local::m_aimPunchAngleVel"]; // 0x3038;

        //public int m_iDefaultFOV;// 0x3208;
        //public int m_flFOVRate;// 0x3000;
        //public int m_model_ambient_min;// 0x59205C;
        public int m_pStudioHdr;// 0x294C;


        public int m_clrRender => g_Globals.NetVars["DT_TestTraceline::m_clrRender"];
        public int m_vecOrigin => g_Globals.NetVars["DT_TestTraceline::m_vecOrigin"];
        public int m_flSpawnTime => g_Globals.NetVars["DT_ParticleSmokeGrenade::m_flSpawnTime"];
        public int m_FadeStartTime => g_Globals.NetVars["DT_ParticleSmokeGrenade::m_FadeStartTime"];
        public int m_FadeEndTime => g_Globals.NetVars["DT_ParticleSmokeGrenade::m_FadeEndTime"];
        public int m_MinColor => g_Globals.NetVars["DT_ParticleSmokeGrenade::m_MinColor"];
        public int m_MaxColor => g_Globals.NetVars["DT_ParticleSmokeGrenade::m_MaxColor"];
        public int m_CurrentStage => g_Globals.NetVars["DT_ParticleSmokeGrenade::m_CurrentStage"];
        public int m_EnvWindShared => g_Globals.NetVars["DT_EnvWind::m_EnvWindShared"];
        public int m_OriginalOwnerXuidLow => g_Globals.NetVars["DT_BaseAttributableItem::m_OriginalOwnerXuidLow"];
        public int m_OriginalOwnerXuidHigh => g_Globals.NetVars["DT_BaseAttributableItem::m_OriginalOwnerXuidHigh"];
        public int m_nFallbackPaintKit => g_Globals.NetVars["DT_BaseAttributableItem::m_nFallbackPaintKit"];
        public int m_nFallbackSeed => g_Globals.NetVars["DT_BaseAttributableItem::m_nFallbackSeed"];
        public int m_flFallbackWear => g_Globals.NetVars["DT_BaseAttributableItem::m_flFallbackWear"];
        public int m_nFallbackStatTrak => g_Globals.NetVars["DT_BaseAttributableItem::m_nFallbackStatTrak"];
        public int m_fAccuracyPenalty => g_Globals.NetVars["DT_WeaponCSBase::m_fAccuracyPenalty"];
        public int m_fLastShotTime => g_Globals.NetVars["DT_WeaponCSBase::m_fLastShotTime"];
        public int m_bStartedArming => g_Globals.NetVars["DT_WeaponC4::m_bStartedArming"];
        public int m_bBombPlacedAnimation => g_Globals.NetVars["DT_WeaponC4::m_bBombPlacedAnimation"];
        public int m_fArmedTime => g_Globals.NetVars["DT_WeaponC4::m_fArmedTime"];
        public int m_bShowC4LED => g_Globals.NetVars["DT_WeaponC4::m_bShowC4LED"];
        public int m_bIsPlantingViaUse => g_Globals.NetVars["DT_WeaponC4::m_bIsPlantingViaUse"];
        public int m_vecDirection => g_Globals.NetVars["DT_EnvGasCanister::m_vecDirection"];
        public int m_bBombTicking => g_Globals.NetVars["DT_PlantedC4::m_bBombTicking"];
        public int m_nBombSite => g_Globals.NetVars["DT_PlantedC4::m_nBombSite"];
        public int m_flC4Blow => g_Globals.NetVars["DT_PlantedC4::m_flC4Blow"];
        public int m_flTimerLength => g_Globals.NetVars["DT_PlantedC4::m_flTimerLength"];
        public int m_flDefuseLength => g_Globals.NetVars["DT_PlantedC4::m_flDefuseLength"];
        public int m_flDefuseCountDown => g_Globals.NetVars["DT_PlantedC4::m_flDefuseCountDown"];
        public int m_bBombDefused => g_Globals.NetVars["DT_PlantedC4::m_bBombDefused"];
        public int m_hBombDefuser => g_Globals.NetVars["DT_PlantedC4::m_hBombDefuser"];
        public int m_iScore => g_Globals.NetVars["DT_CSPlayerResource::m_iScore"];
        public int m_iCompetitiveRanking => g_Globals.NetVars["DT_CSPlayerResource::m_iCompetitiveRanking"];
        public int m_iCompetitiveWins => g_Globals.NetVars["DT_CSPlayerResource::m_iCompetitiveWins"];
        public int m_szClan => g_Globals.NetVars["DT_CSPlayerResource::m_szClan"];
        public int m_bKilledByTaser => g_Globals.NetVars["DT_CSPlayer::m_bKilledByTaser"];
        public int m_bGunGameImmunity => g_Globals.NetVars["DT_CSPlayer::m_bGunGameImmunity"];
        public int m_szArmsModel => g_Globals.NetVars["DT_CSPlayer::m_szArmsModel"];
        public int m_nModelIndex => g_Globals.NetVars["DT_CSRagdoll::m_nModelIndex"];
        public int m_iTeamNum => g_Globals.NetVars["DT_CSRagdoll::m_iTeamNum"];
        public int m_fFlags => g_Globals.NetVars["DT_CHostage::m_fFlags"];


        public int m_clrOverlay => g_Globals.NetVars["DT_Sun::m_clrOverlay"];
        public int m_vDirection => g_Globals.NetVars["DT_Sun::m_vDirection"];
        public int m_bOn => g_Globals.NetVars["DT_Sun::m_bOn"];
        public int m_nSize => g_Globals.NetVars["DT_Sun::m_nSize"];
        public int m_nOverlaySize => g_Globals.NetVars["DT_Sun::m_nOverlaySize"];
        public int m_nMaterial => g_Globals.NetVars["DT_Sun::m_nMaterial"];
        public int m_nOverlayMaterial => g_Globals.NetVars["DT_Sun::m_nOverlayMaterial"];
        public int m_flLightScale => g_Globals.NetVars["DT_SpotlightEnd::m_flLightScale"];
        public int m_Radius => g_Globals.NetVars["DT_SpotlightEnd::m_Radius"];
        public int m_minFalloff => g_Globals.NetVars["DT_SpatialEntity::m_minFalloff"];
        public int m_maxFalloff => g_Globals.NetVars["DT_SpatialEntity::m_maxFalloff"];
        public int m_flCurWeight => g_Globals.NetVars["DT_SpatialEntity::m_flCurWeight"];
        public int m_shadowColor => g_Globals.NetVars["DT_ShadowControl::m_shadowColor"];
        public int m_flShadowMaxDist => g_Globals.NetVars["DT_ShadowControl::m_flShadowMaxDist"];
        public int m_bDisableShadows => g_Globals.NetVars["DT_ShadowControl::m_bDisableShadows"];
        public int m_bEnableLocalLightShadows => g_Globals.NetVars["DT_ShadowControl::m_bEnableLocalLightShadows"];
        public int m_iParentAttachment => g_Globals.NetVars["DT_RopeKeyframe::m_iParentAttachment"];
        public int m_iPing => g_Globals.NetVars["DT_PlayerResource::m_iPing"];
        public int m_iKills => g_Globals.NetVars["DT_PlayerResource::m_iKills"];
        public int m_iAssists => g_Globals.NetVars["DT_PlayerResource::m_iAssists"];
        public int m_iDeaths => g_Globals.NetVars["DT_PlayerResource::m_iDeaths"];
        public int m_fEffects => g_Globals.NetVars["DT_ParticleSystem::m_fEffects"];
        public int m_angRotation => g_Globals.NetVars["DT_ParticleSystem::m_angRotation"];
        public int m_bShouldGlow => g_Globals.NetVars["DT_Item::m_bShouldGlow"];
        public int m_vecVelocity => g_Globals.NetVars["DT_FuncMoveLinear::m_vecVelocity"];
       
        public int m_iFOV => g_Globals.NetVars["DT_BasePlayer::m_iFOV"];
        public int m_iFOVStart => g_Globals.NetVars["DT_BasePlayer::m_iFOVStart"];
        public int m_nRenderMode => g_Globals.NetVars["DT_BaseEntity::m_nRenderMode"];
        public int m_nRenderFX => g_Globals.NetVars["DT_BaseEntity::m_nRenderFX"];
        public int m_iName => g_Globals.NetVars["DT_BaseEntity::m_iName"];
        public int m_nSequence => g_Globals.NetVars["DT_BaseAnimating::m_nSequence"];
        public int m_nSkin => g_Globals.NetVars["DT_BaseAnimating::m_nSkin"];
        public int m_nBody => g_Globals.NetVars["DT_BaseAnimating::m_nBody"];
        public int m_flPlaybackRate => g_Globals.NetVars["DT_BaseAnimating::m_flPlaybackRate"];
        public int m_nNewSequenceParity => g_Globals.NetVars["DT_BaseAnimating::m_nNewSequenceParity"];
        public int m_nResetEventsParity => g_Globals.NetVars["DT_BaseAnimating::m_nResetEventsParity"];
        public int m_nMuzzleFlashParity => g_Globals.NetVars["DT_BaseAnimating::m_nMuzzleFlashParity"];
        public int m_ScaleType => g_Globals.NetVars["DT_BaseAnimating::m_ScaleType"];
        
        public int m_hWeapon => g_Globals.NetVars["DT_BaseViewModel::m_hWeapon"];
        public int m_nViewModelIndex => g_Globals.NetVars["DT_BaseViewModel::m_nViewModelIndex"];
        public int m_nAnimationParity => g_Globals.NetVars["DT_BaseViewModel::m_nAnimationParity"];
        public int m_hOwner => g_Globals.NetVars["DT_BaseViewModel::m_hOwner"];
        public int m_bShouldIgnoreOffsetAndAccuracy => g_Globals.NetVars["DT_BaseViewModel::m_bShouldIgnoreOffsetAndAccuracy"];
        public int m_flDamage => g_Globals.NetVars["DT_BaseGrenade::m_flDamage"];
        public int m_DmgRadius => g_Globals.NetVars["DT_BaseGrenade::m_DmgRadius"];
        public int m_bIsLive => g_Globals.NetVars["DT_BaseGrenade::m_bIsLive"];
        public int m_hThrower => g_Globals.NetVars["DT_BaseGrenade::m_hThrower"];
        public int m_iViewModelIndex => g_Globals.NetVars["DT_BaseCombatWeapon::m_iViewModelIndex"];
        public int m_iState => g_Globals.NetVars["DT_BaseCombatWeapon::m_iState"];

        public int m_vecViewOffset => g_Globals.NetVars["DT_LocalPlayerExclusive::m_vecViewOffset[0]"];// 0x108;
        //public int m_viewPunchAngle;// 0x3020;

        public int m_lifeState => g_Globals.NetVars["DT_BasePlayer::m_lifeState"];// 0x25F;
        public int m_Local => g_Globals.NetVars["DT_LocalPlayerExclusive::m_Local"];// 0x2FBC;
        public int m_bIsScoped => g_Globals.NetVars["DT_CSPlayer::m_bIsScoped"];// 0x3928;
        public int m_iHealth => g_Globals.NetVars["DT_BasePlayer::m_iHealth"];// 0x100;
        public int m_ArmorValue => g_Globals.NetVars["DT_CSPlayer::m_ArmorValue"];// 0xB378;
        public int m_iShotsFired => g_Globals.NetVars["DT_CSLocalPlayerExclusive::m_iShotsFired"];// 0xA390;


        public int m_bHasDefuser => g_Globals.NetVars["DT_CSPlayer::m_bHasDefuser"];// 0xB388;
        public int m_bHasHelmet => g_Globals.NetVars["DT_CSPlayer::m_bHasHelmet"];// 0xB36C;
        public int m_bInReload => m_flNextPrimaryAttack + 109;// 0x32A5;
        public int m_bIsDefusing => g_Globals.NetVars["DT_CSPlayer::m_bIsDefusing"];// 0x3930;
        public int m_bIsWalking => g_Globals.NetVars["DT_CSPlayer::m_bIsWalking"];// 0x3929;
        public int m_dwBoneMatrix=> g_Globals.NetVars["DT_BaseAnimating::m_nForceBone"] + 28;// 0x26A8;
        public int m_bSpotted => g_Globals.NetVars["DT_BaseEntity::m_bSpotted"];// 0x93D;
        public int m_bSpottedByMask => g_Globals.NetVars["DT_BaseEntity::m_bSpottedByMask"];// 0x980;
        public int m_hActiveWeapon => g_Globals.NetVars["DT_BaseCombatCharacter::m_hActiveWeapon"];// 0x2EF8;
        public int m_hMyWeapons => g_Globals.NetVars["DT_BaseCombatCharacter::m_hMyWeapons"];// 0x2DF8;
        public int m_hViewModel => g_Globals.NetVars["DT_BasePlayer::m_hViewModel[0]"];// 0x32F8;

        public int m_flFlashDuration => g_Globals.NetVars["DT_CSPlayer::m_flFlashDuration"];// 0xA420;
        public int m_flFlashMaxAlpha => g_Globals.NetVars["DT_CSPlayer::m_flFlashMaxAlpha"];// 0xA41C;

        public int m_flModelScale => g_Globals.NetVars["DT_BaseAnimating::m_flModelScale"];// 0x2748;

        public int m_nTickBase => g_Globals.NetVars["DT_LocalPlayerExclusive::m_nTickBase"];// 0x3430;


        //this is quite retarded

        private int m_Item => g_Globals.NetVars["DT_AttributeContainer::m_Item"] + g_Globals.NetVars["DT_BaseAttributableItem::m_AttributeManager"];



        public int m_iItemDefinitionIndex => m_Item + g_Globals.NetVars["DT_ScriptCreatedItem::m_iItemDefinitionIndex"];// 0x2FAA;
        public int m_iEntityLevel => m_Item + g_Globals.NetVars["DT_ScriptCreatedItem::m_iEntityLevel"];// 0x2FB0;
        public int m_iItemIDHigh => m_Item + g_Globals.NetVars["DT_ScriptCreatedItem::m_iItemIDHigh"];// 0x2FC0;
        public int m_iItemIDLow => m_Item + g_Globals.NetVars["DT_ScriptCreatedItem::m_iItemIDLow"];// 0x2FC4;
        public int m_iAccountId => m_Item + g_Globals.NetVars["DT_ScriptCreatedItem::m_iAccountID"];// 0x2FC8;
        public int m_iEntityQuality => m_Item + g_Globals.NetVars["DT_ScriptCreatedItem::m_iEntityQuality"];// 0x2FAC;
        public int m_bInitialized;// 0x2FD4;
        public int m_szCustomName => m_Item + g_Globals.NetVars["DT_ScriptCreatedItem::m_szCustomName"];// 0x303C;

        public int m_flNextPrimaryAttack => g_Globals.NetVars["DT_LocalActiveWeaponData::m_flNextPrimaryAttack"];// 0x3238;
        public int m_flNextSecondaryAttack => g_Globals.NetVars["DT_LocalActiveWeaponData::m_flNextSecondaryAttack"];// 0x323C;
        public int m_flTimeWeaponIdle => g_Globals.NetVars["DT_LocalActiveWeaponData::m_flTimeWeaponIdle"];// 0x3274;

        public int m_iClip => g_Globals.NetVars["DT_BaseCombatWeapon::m_iClip1"];// 0x3264;
        public int m_iClip2 => g_Globals.NetVars["DT_BaseCombatWeapon::m_iClip2"];// 0x3268;
                                                                                  //public int m_fAccuracyPenalty;// 0x3330;// (float )
                                                                                  //public int m_fLastShotTime;// 0x33A8;// (float )
        public int m_iWeaponOrigin => g_Globals.NetVars["DT_BaseCombatWeapon::m_iWeaponOrigin"];// 0x32C8;


        public int m_hObserverTarget => g_Globals.NetVars["DT_BasePlayer::m_hObserverTarget"];// 0x338C;
        public int m_iObserverMode => g_Globals.NetVars["DT_BasePlayer::m_iObserverMode"];// 0x3378;
        public int m_iAccount => g_Globals.NetVars["DT_CSPlayer::m_iAccount"];// 0xB364;
        public int m_totalHitsOnServer => g_Globals.NetVars[
            "DT_CSPlayer::m_totalHitsOnServer"];// 0xA3A8;
        public int m_iNumRoundKills => g_Globals.NetVars["DT_CSPlayer::m_iNumRoundKills"];// 0x3954;
        public int m_iNumRoundKillsHeadshots => g_Globals.NetVars["DT_CSPlayer::m_iNumRoundKillsHeadshots"];// 0x3958;


        public int m_nLastConcurrentKilled;// 0xB3B0;
        public int m_hViewEntity => g_Globals.NetVars["DT_BasePlayer::m_hViewEntity"];// 0x333C;
        public int m_nLastKillerIndex;// 0xB3AC;



        public int m_flBeamHDRColorScale => g_Globals.NetVars["DT_Beam::m_flHDRColorScale"];// 0x09DC;//(float )



        public int m_SpatialEntityVecOrigin => g_Globals.NetVars["DT_SpatialEntity::m_vecOrigin"];// 0x09D8;



        public static Offsets Load()
        {

            //if (!System.IO.File.Exists(g_Globals.Offsets))
            //    Serializer.SaveJson(new Offsets(), g_Globals.Offsets);

            if (!System.IO.File.Exists(g_Globals.Signatures))
                Serializer.SaveJson(Generators.CreateModulePattern(), g_Globals.Signatures);

            return new Offsets();

        }

    }
}
