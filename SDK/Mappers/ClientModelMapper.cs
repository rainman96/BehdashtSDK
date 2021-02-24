using Newtonsoft.Json;
using Ditas.SDK.DataModel;
using System;
using System.Linq;
using System.Text;

namespace Ditas.SDK.Mappers
{
    internal class ClientModelMapper
    {
        internal static T ToClientResponse<T, U>(U input)
        {
            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(input));
        }

        internal static PersonVO ToPersonVo(GetEstelam3Response input)
        {
            var response = input;
            return new PersonVO
            {
                BirthDate = GetDateFromText(response.BirthDate),
                DeathDate = null, // GetDateFromText(response.DeathDate),
                DeathStatus = GetDeathFromText(response.DeathStatus),
                Father_FirstName = GetStringFromBase64(response.FatherName),
                FirstName = GetStringFromBase64(response.Name),
                Gender = GetGender(response.Gender),
                LastName = GetStringFromBase64(response.Family),
                NationalCode = response.NationalCode,
                Nationality = new DO_CODED_TEXT { Coded_string = response.NationalCode, },//TODO:IMP:Compelete Nationality property
                OtherIdentifier = new PersonIdentifierVO[0],//TODO:IMP:Compelete OtherIdentifier property
            };
        }

        private static string GetStringFromBase64(string input)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(input));
        }

        private static bool GetDeathFromText(string[] deathStatus)
        {
            return (deathStatus?.FirstOrDefault() ?? "0") == "0" ? false : true;
        }

        private static DO_CODED_TEXT GetGender(string gender)
        {
            return new DO_CODED_TEXT { Coded_string = gender, Terminology_id = "", Value = (gender == "1" ? "مرد" : (gender == "2") ? "زن" : "تعریف نشده") };
        }

        private static DO_DATE GetDateFromText(string deathDate)
        {
            return new DO_DATE
            {
                Year = int.Parse(deathDate.Substring(0, 4)),
                Month = int.Parse(deathDate.Substring(4, 2)),
                Day = int.Parse(deathDate.Substring(6, 2)),
            };
        }

        internal static ResultVO ToResultVo(PrescriptionTaminResponse response)
        {
            if (response == null) return new ResultVO { ErrorMessage = "Server no response" };
            return new ResultVO {CompositionUID = response?.HeadEprscId,ErrorMessage = response?.FullErrorMessage};
        }
        internal static ResultVO ToResultVo(DrugSalamatResponse response)
        {
            if (response == null) return new ResultVO { ErrorMessage = "Server no response" };
            return new ResultVO
            {
                CompositionUID = response?.TrackingID?.ID,
                ErrorMessage = response?.ErrPos,
                MessageUID = response?.Description,
            };
        }

        internal static HealthcareProviderVO HealthcareProviderVO(MemberInfoByMcResponse response)
        {
            var input = response.ReturnValue;
            return new HealthcareProviderVO
            {
                FirstName = input?.FirstName,
                FullName = input?.FirstName + " " + input?.LastName,
                LastName = input?.LastName,
                Specialty = new DO_CODED_TEXT { Coded_string = input.SpecialityCodes.FirstOrDefault() },
                ContactPoint = null,
                Identifier = new DO_IDENTIFIER { ID = input.McCode },
                Role = null
            };
        }
    }
}
