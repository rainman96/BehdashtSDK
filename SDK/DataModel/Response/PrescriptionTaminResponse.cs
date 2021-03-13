using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ditas.SDK.DataModel
{
    internal class PrescriptionTaminResponse
    {
        [JsonProperty("error_Msg")]
        public string ErrorMessage { get; set; }

        [JsonProperty("error_Code")]
        public string ErrorCode { get; set; }

        [JsonProperty("complemantary_Msg")]
        public string ComplemantaryMsg { get; set; }

        [JsonProperty("head_EPRSC_ID")]
        public string HeadEprscId { get; set; }

        internal string FullErrorMessage => $"ErrorCode:[{ErrorCode}], ErrorMessage:[{ErrorMessage}], ComplemantaryMsg:[{ComplemantaryMsg}]"?.Trim();
    }
}
