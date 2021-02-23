using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ditas.SDK.DataModel
{


    public class InsuranceInfromationResponse
    {
        [JsonProperty("data")]
        public Data CullUpInsuranceInfromationData { get; set; }
        [JsonProperty("status")]
        public Status Status { get; set; }
    }

    public class Data
    {
        [JsonProperty("data")]
        public InsuranceInfromation[] InsuranceInfromations { get; set; }
        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
        [JsonProperty("waitTime")]
        public int WaitTime { get; set; }
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }
        [JsonProperty("message")]
        public string[] Message { get; set; }
    }

    public class InsuranceInfromation
    {
        [JsonProperty("nationalcode")]
        public string Nationalcode { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("fatherName")]
        public string FatherName { get; set; }
        [JsonProperty("idNumber")]
        public string IdNumber { get; set; }
        [JsonProperty("responsibleFirstName")]
        public string ResponsibleFirstName { get; set; }
        [JsonProperty("responsibleLastName")]
        public string ResponsibleLastName { get; set; }
        [JsonProperty("birthDate")]
        public DO_DATE BirthDate { get; set; }
        [JsonProperty("deathDate")]
        public DO_DATE DeathDate { get; set; }
        [JsonProperty("gender")]
        public DO_CODED_TEXT Gender { get; set; }
        [JsonProperty("maritalStatus")]
        public DO_CODED_TEXT MaritalStatus { get; set; }
        [JsonProperty("insurer")]
        public DO_CODED_TEXT Insurer { get; set; }
        [JsonProperty("insuranceNumber")]
        public DO_IDENTIFIER InsuranceNumber { get; set; }
        [JsonProperty("insuranceNumber2")]
        public DO_IDENTIFIER InsuranceNumber2 { get; set; }
        [JsonProperty("insurerBox")]
        public DO_CODED_TEXT InsurerBox { get; set; }
        [JsonProperty("expirationDate")]
        public DO_DATE ExpirationDate { get; set; }
        [JsonProperty("provinceInsurance")]
        public DO_CODED_TEXT ProvinceInsurance { get; set; }
        [JsonProperty("postalCode")]
        public string InquiryID { get; set; }
        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
        [JsonProperty("province")]
        public string Province { get; set; }
        [JsonProperty("provinceCode")]
        public string ProvinceCode { get; set; }
        [JsonProperty("branch")]
        public string Branch { get; set; }
        [JsonProperty("branchCode")]
        public string BranchCode { get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }
        [JsonProperty("extraProperties")]
        public Extraproperty[] ExtraProperties { get; set; }
    }

    public class Extraproperty
    {
        [JsonProperty("element")]
        public DO_CODED_TEXT Element { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Status
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
    }

}
