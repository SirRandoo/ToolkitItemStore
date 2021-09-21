using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolkitItemStore.Models;
using UnityEngine;
using Verse;

namespace ToolkitItemStore
{
    public class ToolkitItemStoreSettings : ModSettings
    {
        public static Items items;
        public void DoWindowContents(Rect inRect)
        {
            Listing_Standard listing = new Listing_Standard();
            listing.Begin(inRect);

            listing.End();
        }

        public override void ExposeData()
        {
            
        }
    }
}
