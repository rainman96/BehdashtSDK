using Ditas.SDK.Helper;
using Ditas.SDK.IServices;
using Newtonsoft.Json;

namespace Ditas.SDK.DataModel
{
    public class RequestPersonInformation : IValidation, IJsonProducer
    {
        [JsonProperty("personInformation")]
        public PersonInformationRequest PersonInformation { get; set; }

        public (bool State, string Message, string FieldName) IsValid()
        {
            if (!Utilities.ValidateIranianNationalCode(PersonInformation.NationalCode))
                return Constants.Messages.ValueIsNullMessage(nameof(PersonInformation.NationalCode));
            if (PersonInformation.BirthDate.ToString().Length != 8)
                return Constants.Messages.ValueIsNullMessage(nameof(PersonInformation.BirthDate));
            return Constants.Messages.OK;
        }
        public string ToJson()
        {
            return Utilities.ToJson(this);

        }

    }
}
