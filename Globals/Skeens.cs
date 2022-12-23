using ResurrectedEternalSkeens.Skills.GamePlaySkillMods;
using ResurrectedEternalSkeens.Configs.ConfigSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResurrectedEternalSkeens.Globals
{
    public static class Skeens
    {
        //public static Dictionary<string, xSkin> Container = new Dictionary<string, xSkin>();

        public static Dictionary<ItemDefinitionIndex, xSkin> Create()
        {
            if (System.IO.File.Exists(g_Globals.Skeens))
            {

                return Convert(Serializer.LoadJson<Dictionary<string, xSkin>>(g_Globals.Skeens));
            }
            Dictionary<string, xSkin> SkinDictionary = new Dictionary<string, xSkin>();
            SkinDictionary.Add(ItemDefinitionIndex.AWP.ToString(), new xSkin() { fallBackPaint = 344 });
            SkinDictionary.Add(ItemDefinitionIndex.SSG08.ToString(), new xSkin() { fallBackPaint = 222 });
            SkinDictionary.Add(ItemDefinitionIndex.G3SG1.ToString(), new xSkin() { fallBackPaint = 294 });
            SkinDictionary.Add(ItemDefinitionIndex.SCAR20.ToString(), new xSkin() { fallBackPaint = 312 });

            SkinDictionary.Add(ItemDefinitionIndex.M4A4.ToString(), new xSkin() { fallBackPaint = 844 });
            SkinDictionary.Add(ItemDefinitionIndex.M4A1S.ToString(), new xSkin() { fallBackPaint = 946 }); //548
            SkinDictionary.Add(ItemDefinitionIndex.GALILAR.ToString(), new xSkin() { fallBackPaint = 379 });
            SkinDictionary.Add(ItemDefinitionIndex.FAMAS.ToString(), new xSkin() { fallBackPaint = 919 });
            SkinDictionary.Add(ItemDefinitionIndex.AK47.ToString(), new xSkin() { fallBackPaint = 675 });
            SkinDictionary.Add(ItemDefinitionIndex.AUG.ToString(), new xSkin() { fallBackPaint = 455 });
            //SkinDictionary.Add(ItemDefinitionIndex.G3SG1, new xSkin() { fallBackPaint = 294 });           
            SkinDictionary.Add(ItemDefinitionIndex.SG553.ToString(), new xSkin() { fallBackPaint = 750 });


            SkinDictionary.Add(ItemDefinitionIndex.CZ75AUTO.ToString(), new xSkin() { fallBackPaint = 643 });
            SkinDictionary.Add(ItemDefinitionIndex.DEAGLE.ToString(), new xSkin() { fallBackPaint = 711 });
            SkinDictionary.Add(ItemDefinitionIndex.DUALBERETTAS.ToString(), new xSkin() { fallBackPaint = 658 });
            SkinDictionary.Add(ItemDefinitionIndex.GLOCK18.ToString(), new xSkin() { fallBackPaint = 957 });
            SkinDictionary.Add(ItemDefinitionIndex.P2000.ToString(), new xSkin() { fallBackPaint = 211 });
            SkinDictionary.Add(ItemDefinitionIndex.P250.ToString(), new xSkin() { fallBackPaint = 678 });
            SkinDictionary.Add(ItemDefinitionIndex.FIVESEVEN.ToString(), new xSkin() { fallBackPaint = 660 });
            SkinDictionary.Add(ItemDefinitionIndex.TEC9.ToString(), new xSkin() { fallBackPaint = 889 });
            SkinDictionary.Add(ItemDefinitionIndex.USPS.ToString(), new xSkin() { fallBackPaint = 504 });
            SkinDictionary.Add(ItemDefinitionIndex.R8Revolver.ToString(), new xSkin() { fallBackPaint = 522 });


            SkinDictionary.Add(ItemDefinitionIndex.P90.ToString(), new xSkin() { fallBackPaint = 156 });
            SkinDictionary.Add(ItemDefinitionIndex.MP7.ToString(), new xSkin() { fallBackPaint = 481 });
            SkinDictionary.Add(ItemDefinitionIndex.MP9.ToString(), new xSkin() { fallBackPaint = 734 });
            SkinDictionary.Add(ItemDefinitionIndex.PPBIZON.ToString(), new xSkin() { fallBackPaint = 542 });
            SkinDictionary.Add(ItemDefinitionIndex.UMP45.ToString(), new xSkin() { fallBackPaint = 802 });
            SkinDictionary.Add(ItemDefinitionIndex.MAC10.ToString(), new xSkin() { fallBackPaint = 898 });
            SkinDictionary.Add(ItemDefinitionIndex.MP5SD.ToString(), new xSkin() { fallBackPaint = 810 });


            SkinDictionary.Add(ItemDefinitionIndex.MAG7.ToString(), new xSkin() { fallBackPaint = 737 });
            SkinDictionary.Add(ItemDefinitionIndex.SAWEDOFF.ToString(), new xSkin() { fallBackPaint = 256 });
            SkinDictionary.Add(ItemDefinitionIndex.XM1014.ToString(), new xSkin() { fallBackPaint = 393 });
            SkinDictionary.Add(ItemDefinitionIndex.NOVA.ToString(), new xSkin() { fallBackPaint = 537 });

            SkinDictionary.Add(ItemDefinitionIndex.M249.ToString(), new xSkin() { fallBackPaint = 452 });
            SkinDictionary.Add(ItemDefinitionIndex.NEGEV.ToString(), new xSkin() { fallBackPaint = 763 });


            SkinDictionary.Add(ItemDefinitionIndex.KNIFE_BAYONET.ToString(), new xSkin() { fallBackPaint = 573 });
            SkinDictionary.Add(ItemDefinitionIndex.KNIFE_FLIP.ToString(), new xSkin() { fallBackPaint = 572 });
            SkinDictionary.Add(ItemDefinitionIndex.KNIFE_GUT.ToString(), new xSkin() { fallBackPaint = 575 });
            SkinDictionary.Add(ItemDefinitionIndex.KNIFE_KARAMBIT.ToString(), new xSkin() { fallBackPaint = 417 });
            SkinDictionary.Add(ItemDefinitionIndex.KNIFE_M9_BAYONET.ToString(), new xSkin() { fallBackPaint = 577 });
            SkinDictionary.Add(ItemDefinitionIndex.KNIFE_TACTICAL.ToString(), new xSkin() { fallBackPaint = 42 });
            SkinDictionary.Add(ItemDefinitionIndex.KNIFE_FALCHION.ToString(), new xSkin() { fallBackPaint = 413 });
            SkinDictionary.Add(ItemDefinitionIndex.KNIFE_SURVIVAL_BOWIE.ToString(), new xSkin() { fallBackPaint = 420 });
            SkinDictionary.Add(ItemDefinitionIndex.KNIFE_BUTTERFLY.ToString(), new xSkin() { fallBackPaint = 409 });
            SkinDictionary.Add(ItemDefinitionIndex.KNIFE_PUSH.ToString(), new xSkin() { fallBackPaint = 98 });
            SkinDictionary.Add(ItemDefinitionIndex.KNIFE_NOMAD.ToString(), new xSkin() { fallBackPaint = 38 });
            SkinDictionary.Add(ItemDefinitionIndex.KNIFE_SKELETON.ToString(), new xSkin() { fallBackPaint = 59 });
            SkinDictionary.Add(ItemDefinitionIndex.KNIFE_SURVIVAL.ToString(), new xSkin() { fallBackPaint = 38 });
            SkinDictionary.Add(ItemDefinitionIndex.KNIFE_STILETTO.ToString(), new xSkin() { fallBackPaint = 577 });
            SkinDictionary.Add(ItemDefinitionIndex.KNIFE_GYPSY_JACKKNIFE.ToString(), new xSkin() { fallBackPaint = 413 });
            SkinDictionary.Add(ItemDefinitionIndex.KNIFE_URSUS.ToString(), new xSkin() { fallBackPaint = 573 });
            SkinDictionary.Add(ItemDefinitionIndex.KNIFE_WIDOWMAKER.ToString(), new xSkin() { fallBackPaint = 573 });
            Serializer.SaveJson(SkinDictionary, g_Globals.Skeens);
            return Create();

        }

        private static Dictionary<ItemDefinitionIndex, xSkin> Convert(Dictionary<string, xSkin> _pack)
        {
            var _hashtable = new Dictionary<ItemDefinitionIndex, xSkin>();
            foreach (var item in _pack)
            {
                if (Enum.TryParse<ItemDefinitionIndex>(item.Key, out var idx))
                    _hashtable.Add(idx, item.Value);
            }
            return _hashtable;
        }
    }
}
