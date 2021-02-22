using Ditas.SDK.Helper;
using Ditas.SDK.IServices;

namespace Ditas.SDK.DataModel
{
    public class LoginRequest:IValidation,IJsonProducer
    {
        public string Password { get; set; }
        public string Username { get; set; }

        public (bool State, string Message, string FieldName) IsValid()
        {
            if (string.IsNullOrEmpty(Username))
                return Constants.Messages.ValueIsNullMessage(nameof(Username));
            if (string.IsNullOrEmpty(Password))
                return Constants.Messages.ValueIsNullMessage(nameof(Password));
            return Constants.Messages.OK;
        }

        public string ToJson()
        {
            return Utilities.ToJson(this);

        }
    }
}
