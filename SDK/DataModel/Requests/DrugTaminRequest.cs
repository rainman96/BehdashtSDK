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

    public class DrugTaminRequest:IJsonProducer
    {
        [JsonProperty("patient")]
        public string Patient { get; set; }
        [JsonProperty("mobile")]
        public string Mobile { get; set; }
        [JsonProperty("prescType")]
        public Presctype PrescType { get; set; }
        [JsonProperty("prescDate")]
        public string PrescDate { get; set; }
        [JsonProperty("docId")]
        public string DocId { get; set; }
        [JsonProperty("docMobileNo")]
        public string DocMobileNo { get; set; }
        [JsonProperty("docNationalCode")]
        public string DocNationalCode { get; set; }
        [JsonProperty("comments")]
        public string Comments { get; set; }
        [JsonProperty("expireDate")]
        public string ExpireDate { get; set; }
        [JsonProperty("siamId")]

        public string SiamID { get; set; }
        [JsonProperty("noteDetailEprscs")]
        public Notedetaileprsc[] NoteDetailEprscs { get; set; }

        public string ToJson()
        {
            return Utilities.ToJson(this);
        }
    }

    public class Presctype
    {
        [JsonProperty("prescTypeId")]
        public int PrescTypeId { get; set; }
    }

    public class Notedetaileprsc
    {
        [JsonProperty("srvId")]
        public Srvid SrvId { get; set; }
        [JsonProperty("srvQty")]
        public int SrvQty { get; set; }
        [JsonProperty("timesAday")]
        public Timesaday TimesAday { get; set; }
        [JsonProperty("repeat")]
        public int Repeat { get; set; }
        [JsonProperty("drugInstruction")]
        public Druginstruction DrugInstruction { get; set; }
    }

    public class Srvid
    {
        [JsonProperty("srvType")]
        public Srvtype SrvType { get; set; }
        [JsonProperty("srvCode")]
        public string SrvCode { get; set; }
    }

    public class Srvtype
    {
        [JsonProperty("srvType")]
        public string SrvType { get; set; }
    }

    public class Timesaday
    {
        [JsonProperty("drugAmntId")]
        public int DrugAmntId { get; set; }
    }

    public class Druginstruction
    {
        [JsonProperty("drugInstId")]
        public int DrugInstId { get; set; }
    }

}
