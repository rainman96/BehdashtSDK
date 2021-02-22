using Newtonsoft.Json;

namespace Ditas.SDK.DataModel
{
    public class PersonInformationRequest : BaseResponse
    {
        [JsonProperty("nin")]
        public string NationalCode { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("family")]
        public string Family { get; set; }
        [JsonProperty("fatherName")]
        public string FatherName { get; set; }
        [JsonProperty("shenasnameSeri")]
        public string ShenasnameSeri { get; set; }
        [JsonProperty("shenasnameNo")]
        public string ShenasnameNo { get; set; }
        [JsonProperty("shenasnameSerial")]
        public string ShenasnameSerial { get; set; }
        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }
        [JsonProperty("gender")]
        public string Gender { get; set; }
        [JsonProperty("officeCode")]
        public string OfficeCode { get; set; }
        [JsonProperty("bookNo")]
        public string BookNo { get; set; }
        [JsonProperty("bookRow")]
        public string BookRow { get; set; }
        [JsonProperty("nameHasPerfix")]
        public string NameHasPerfix { get; set; }
        [JsonProperty("nameHasPostfix")]
        public string NameHasPostfix { get; set; }
        [JsonProperty("familyHasPerfix")]
        public string FamilyHasPerfix { get; set; }
        [JsonProperty("familyHasPostfix")]
        public string FamilyHasPostfix { get; set; }
        [JsonProperty("deathStatus")]
        public string DeathStatus { get; set; }
        [JsonProperty("message")]
        public new string Message { get; set; }
        [JsonProperty("exceptionMessage")]
        public string ExceptionMessage { get; set; }
        [JsonProperty("deathDate")]
        public string DeathDate { get; set; }
    }
}
