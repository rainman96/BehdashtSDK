using Newtonsoft.Json;

namespace Ditas.SDK.DataModel
{
    public class GetEstelam3Response
    {
        [JsonProperty("bookNo")]
        public string BookNo { get; set; }
        [JsonProperty("fatherName")]
        public string FatherName { get; set; }
        [JsonProperty("officeName")]
        public string OfficeName { get; set; }
        [JsonProperty("gender")]
        public string Gender { get; set; }
        [JsonProperty("deathStatus")]
        public string[] DeathStatus { get; set; }
        [JsonProperty("officeCode")]
        public string OfficeCode { get; set; }
        [JsonProperty("shenasnameNo")]
        public string ShenasnameNo { get; set; }
        [JsonProperty("bookRow")]
        public string[] BookRow { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }
        [JsonProperty("nin")]
        public string NationalCode { get; set; }
        [JsonProperty("shenasnameSerial")]
        public string ShenasnameSerial { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("shenasnameSeri")]
        public string ShenasnameSeri { get; set; }
        [JsonProperty("family")]
        public string Family { get; set; }
    }







}
