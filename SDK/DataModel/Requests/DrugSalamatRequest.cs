using Ditas.SDK.Helper;
using Ditas.SDK.IServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ditas.SDK.DataModel
{

    public class DrugSalamatRequest:IJsonProducer
    {
        [JsonProperty("XmlText")]
        public string XmlText { get; set; }
        [JsonProperty("checkPoint")]
        public object CheckPoint { get; set; }
        [JsonProperty("SavePriscription")]
        public bool SavePriscription { get; set; }
        [JsonProperty("userName")]
        public string UserName { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }

        public string ToJson()
        {
            return Utilities.ToJson(this);

        }
    }

}
