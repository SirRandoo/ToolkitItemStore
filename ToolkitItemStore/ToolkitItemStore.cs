using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace ToolkitItemStore
{
    public class ToolkitItemStore : Mod
    {
        public ToolkitItemStore(ModContentPack content) : base(content)
        {
            GetSettings<ToolkitItemStoreSettings>();
        }

        public override void DoSettingsWindowContents(Rect inRect)
        {
            GetSettings<ToolkitItemStoreSettings>().DoWindowContents(inRect);
        }
    }
}
