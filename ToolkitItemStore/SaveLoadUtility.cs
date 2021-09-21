using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolkitCore.Database;
using ToolkitItemStore.Models;
using Verse;

namespace ToolkitItemStore
{
    [StaticConstructorOnStartup]
    static class SaveLoadUtility
    {
        static readonly string itemFileName = "Items";

        static readonly Mod mod = LoadedModManager.GetMod<ToolkitItemStore>();

        static SaveLoadUtility()
        {
            LoadAll();
        }

        internal static void LoadAll()
        {
            if (DatabaseController.LoadObject<Items>(itemFileName, mod, out Items items))
            {
                Items.GenerateItems(items.AllItems);
            } else
            {
                Items.GenerateItems(null);
            }
        }

        internal static void SaveAll()
        {
            DatabaseController.SaveObject(ToolkitItemStoreSettings.items, itemFileName, mod);
            mod.WriteSettings();
        }
    }
}
