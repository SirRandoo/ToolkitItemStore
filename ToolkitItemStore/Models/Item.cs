using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace ToolkitItemStore.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Item
    {
        [JsonProperty]
        public string DefName { get; set; }

        [JsonProperty]
        public int Price { get; set; }

        public ThingDef Def { get; set; }
    }
}
