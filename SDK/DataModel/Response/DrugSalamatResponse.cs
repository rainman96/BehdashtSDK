using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ditas.SDK.DataModel
{
    public class DrugSalamatResponse
    {
        [JsonProperty("TrackingID")]
        public DO_IDENTIFIER TrackingID { get; set; }
        [JsonProperty("TrackingIDExpirationDate")]
        public DO_DATE TrackingIDExpirationDate { get; set; }
        [JsonProperty("InquiryResult")]
        public Inquiryresult[] InquiryResult { get; set; }
        [JsonProperty("Services")]
        public Service[] Services { get; set; }
        [JsonProperty("Description")]
        public string Description { get; set; }
        [JsonProperty("ErrPos")]
        public string ErrPos { get; set; }
    }


    public class Inquiryresult
    {
        [JsonProperty("ConfirmationID")]
        public DO_IDENTIFIER ConfirmationID { get; set; }
        [JsonProperty("ConfirmationIDExpirationDate")]
        public DO_DATE ConfirmationIDExpirationDate { get; set; }
        [JsonProperty("RuleType")]
        public DO_CODED_TEXT RuleType { get; set; }
        [JsonProperty("MessageType")]
        public DO_CODED_TEXT MessageType { get; set; }
        [JsonProperty("Time")]
        public DateTime Time { get; set; }
        [JsonProperty("MessageID")]
        public string MessageID { get; set; }
        [JsonProperty("Message")]
        public string Message { get; set; }
        [JsonProperty("MoreInfo")]
        public string MoreInfo { get; set; }
    }
    public class ServiceSalamat
    {
        [JsonProperty("Service")]
        public DO_CODED_TEXT Service { get; set; }
        [JsonProperty("ServiceCount")]
        public DO_QUANTITY ServiceCount { get; set; }
        [JsonProperty("InquiryResult")]
        public Inquiryresult[] InquiryResult { get; set; }
    }
}
