using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace ToolkitItemStore
{
    [StaticConstructorOnStartup]
    static class HarmonyPatches
    {
        static HarmonyPatches()
        {
            Harmony harmony = new Harmony("com.rimworld.mod.hodlhodl.toolkit.itemstore");

            harmony.Patch(
                original: AccessTools.Method(type: typeof(ToolkitCore.Database.DatabaseController), name: "SaveToolkit"),
                    postfix: new HarmonyMethod(typeof(HarmonyPatches), nameof(SaveGame_PostFix))
                );

            harmony.Patch(
                    original: AccessTools.Method(type: typeof(ToolkitCore.Database.DatabaseController), name: "LoadToolkit"),
                    postfix: new HarmonyMethod(typeof(HarmonyPatches), nameof(LoadGame_PostFix))
                );
        }

        static void SaveGame_PostFix()
        {
            SaveLoadUtility.SaveAll();
        }

        static void LoadGame_PostFix()
        {
            SaveLoadUtility.LoadAll();
        }
    }
}
