using Ditas.SDK.Helper;
using Ditas.SDK.IServices;

namespace Ditas.SDK.Services
{
    internal class ApiRequest:IValidation
    {
        internal ApiRequest(string jsonBody)
        {
            JsonBody = jsonBody;
        }
        internal string JsonBody { get; set; }

        public (bool State, string Message, string FieldName) IsValid()
        {
                if (string.IsNullOrEmpty(JsonBody))
                    return (false, "value is null or empty", nameof(JsonBody));
                return (true, "", "");
        }
    }
}