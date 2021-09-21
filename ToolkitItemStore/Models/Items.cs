using Newtonsoft.Json;
using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace ToolkitItemStore.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Items
    {
        [JsonProperty]
        public List<Item> AllItems { get; set; }

        internal static void GenerateItems(List<Item> loadedItems)
        {
            Items items = new Items();
            items.AllItems = new List<Item>();

            IEnumerable<ThingDef> tradeableitems = from t in DefDatabase<ThingDef>.AllDefs
                                                   where (t.tradeability.TraderCanSell() || ThingSetMakerUtility.CanGenerate(t)) && (t.building == null || t.Minifiable)
                                                   select t;

            foreach (ThingDef item in tradeableitems)
            {
                if (item.BaseMarketValue <= 0f)
                {
                    continue;
                }

                if (loadedItems != null)
                {
                    Item loadedItem = loadedItems.Find((itm) => itm.DefName.Equals(item.defName, StringComparison.InvariantCultureIgnoreCase));
                    if (loadedItem != null)
                    {
                        items.AllItems.Add(new Item()
                        {
                            DefName = item.defName,
                            Price = loadedItem.Price,
                            Def = item
                        });
                        continue;
                    }
                }

                items.AllItems.Add(new Item()
                {
                    DefName = item.defName,
                    Price = (int)Math.Ceiling(item.BaseMarketValue),
                    Def = item
                });
            }

            ToolkitItemStoreSettings.items = items;
        }
    }
}
