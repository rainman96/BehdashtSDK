using Newtonsoft.Json;
using Ditas.SDK.DataModel;
using Ditas.SDK.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Ditas.SDK.Mappers
{
    internal class ServiceModelMapper
    {
        internal static DrugTaminRequest ToDrugTamin(MedicationPrescriptionsMessageVO medicationPrescriptionsMessage)
        {
            if (medicationPrescriptionsMessage == null)
                throw new ArgumentException(Constants.Messages.ValueIsNullMessage(nameof(medicationPrescriptionsMessage)).Message);

            int repeat = medicationPrescriptionsMessage?.Composition?.MedicationPrescriptions?.Repeats.Value ?? 0;
            return new DrugTaminRequest
            {
                Comments = "Send Ditas",
                SiamID = AppConfiguration.LocationID,
                DocId = medicationPrescriptionsMessage?.Composition?.Admission?.AdmittingDoctor?.Identifier?.ID,
                DocMobileNo = medicationPrescriptionsMessage?.MsgID?.Committer?.ContactPoint?.First()?.Detail,
                DocNationalCode = null,
                Mobile = medicationPrescriptionsMessage?.Person?.MobileNumber,
                NoteDetailEprscs = GetNotedetaileprsc(medicationPrescriptionsMessage?.Composition?.MedicationPrescriptions?.Orders, repeat),
                Patient = medicationPrescriptionsMessage.Person.NationalCode,
                PrescDate = GetPrescDate(medicationPrescriptionsMessage?.Composition?.MedicationPrescriptions?.IssueDate),
                PrescType = new Presctype { PrescTypeId = (int)Constants.Enumarations.PrescType.Drug }
            };
        }
        internal static DrugTaminRequest ToVisitTamin(MedicationPrescriptionsMessageVO medicationPrescriptionsMessage)
        {
            if (medicationPrescriptionsMessage == null)
                throw new ArgumentException(Constants.Messages.ValueIsNullMessage(nameof(medicationPrescriptionsMessage)).Message);

            return new DrugTaminRequest
            {
                Comments = "Send Ditas",
                SiamID = AppConfiguration.LocationID,
                DocId = medicationPrescriptionsMessage?.Composition?.Admission?.AdmittingDoctor?.Identifier?.ID,
                DocMobileNo = medicationPrescriptionsMessage?.MsgID?.Committer?.ContactPoint?.First()?.Detail,
                DocNationalCode = null,
                Mobile = medicationPrescriptionsMessage?.Person?.MobileNumber,
                NoteDetailEprscs = null,
                Patient = medicationPrescriptionsMessage.Person.NationalCode,
                PrescDate = GetPrescDate(medicationPrescriptionsMessage?.Composition?.MedicationPrescriptions?.IssueDate),
                PrescType = new Presctype { PrescTypeId = (int)Constants.Enumarations.PrescType.Visit }
            };
        }
        private static string GetPrescDate(DO_DATE issueDate)
        {
            if (issueDate == null)
                throw new ArgumentException(Constants.Messages.ValueIsNullMessage(nameof(issueDate)).Message);
            return $"{issueDate.Year}{issueDate.Month}{issueDate.Day}";
        }

        internal static DrugSalamatRequest ToDrugSalamat(MedicationPrescriptionsMessageVO medicationPrescriptionsMessage)
        {
            if (medicationPrescriptionsMessage == null)
                throw new ArgumentException(Constants.Messages.ValueIsNullMessage(nameof(medicationPrescriptionsMessage)).Message);


            return new DrugSalamatRequest
            {
                SavePriscription = true,
                XmlText = Utilities.ToXmlString(medicationPrescriptionsMessage)
            };
        }

        private static Notedetaileprsc[] GetNotedetaileprsc(MedicationPrescriptionRowVO[] orders, int repeat)
        {
            if (orders == null)
                throw new ArgumentException(Constants.Messages.ValueIsNullMessage(nameof(orders)).Message);


            return orders.Select(s => new Notedetaileprsc
            {
                DrugInstruction = new Druginstruction
                {
                    DrugInstId = Utilities.ToIntSafe(s?.Method?.Coding?.Coded_string, "Method.Coding.Coded_string")
                },
                Repeat = repeat,
                SrvId = new Srvid
                {
                    SrvCode = s.ProductCode.Coded_string,
                    SrvType = new Srvtype
                    {
                        SrvType = "01"
                    }
                },
                SrvQty = (int)s.TotalNumber.Magnitude.Value,
                TimesAday = new Timesaday { DrugAmntId = Utilities.ToIntSafe(s.Frequency.Coded_string, "s.Frequency.Coded_string") }
            }
                ).ToArray();
        }
        internal static HIDRequest GetHIDRequest(DO_IDENTIFIER personID, DO_IDENTIFIER healthCareProvider, DO_CODED_TEXT insurer, DO_IDENTIFIER orgID)
        {
            if (personID == null)
                throw new ArgumentException(Constants.Messages.ValueIsNullMessage(nameof(personID)).Message);
            if (healthCareProvider == null)
                throw new ArgumentException(Constants.Messages.ValueIsNullMessage(nameof(healthCareProvider)).Message);
            if (insurer == null)
                throw new ArgumentException(Constants.Messages.ValueIsNullMessage(nameof(insurer)).Message);
            if (orgID == null)
                throw new ArgumentException(Constants.Messages.ValueIsNullMessage(nameof(orgID)).Message);

            return new HIDRequest
            {
                ClientIp = Utilities.GetClientIp(),
                AppUser = "ditas",
                HcpID = healthCareProvider,
                InsurerID = insurer,
                OrgID = orgID,
                PersonID = personID
            };
        }

        internal static HIDRequest GetHIDRequest(string nationalCode, DO_IDENTIFIER healthCareFacilityID, DO_CODED_TEXT insurer, DO_IDENTIFIER orgID)
        {
            if (!Utilities.ValidateIranianNationalCode(nationalCode))
                throw new ArgumentException(Constants.Messages.ValueIsNullMessage(nameof(nationalCode)).Message);
            if (healthCareFacilityID == null)
                throw new ArgumentException(Constants.Messages.ValueIsNullMessage(nameof(healthCareFacilityID)).Message);
            if (insurer == null)
                throw new ArgumentException(Constants.Messages.ValueIsNullMessage(nameof(insurer)).Message);
            if (orgID == null)
                throw new ArgumentException(Constants.Messages.ValueIsNullMessage(nameof(orgID)).Message);

            return new HIDRequest
            {
                ClientIp = Utilities.GetClientIp(),
                AppUser = "ditas",
                HcpID = healthCareFacilityID,
                InsurerID = insurer,
                OrgID = orgID,
                PersonID = new DO_IDENTIFIER { ID = nationalCode, Assigner = "National_Org_Civil_Reg", Issuer = "National_Org_Civil_Reg", Type = "National_Code" }
            };
        }

        internal static InsuranceInquiryRequest ToInsuranceRequest(DO_IDENTIFIER personID, DO_IDENTIFIER providerID, DO_IDENTIFIER healthcarefacility)
        {
            if (personID == null)
                throw new ArgumentException(Constants.Messages.ValueIsNullMessage(nameof(personID)).Message);
            if (providerID == null)
                throw new ArgumentException(Constants.Messages.ValueIsNullMessage(nameof(providerID)).Message);
            if (healthcarefacility == null)
                throw new ArgumentException(Constants.Messages.ValueIsNullMessage(nameof(healthcarefacility)).Message);
            return new InsuranceInquiryRequest
            {
                ClientIp = Utilities.GetClientIp(),
                AppUser = "ditas",
                ForceUpdate = "false",
                HcpID = healthcarefacility,
                OrgID = providerID,
                PersonID = personID
            };
        }

        internal static RequestPersonInformation GetPersonRequest(string nationalCode, int birthYear)
        {
            if (!Utilities.ValidateIranianNationalCode(nationalCode))
                throw new ArgumentException(Constants.Messages.ValueIsNullMessage(nameof(nationalCode)).Message);
            if (birthYear < 1 || birthYear.ToString().Length != 8)
                throw new ArgumentException(Constants.Messages.InvalidFieldValue(nameof(birthYear)).Message);

            return new RequestPersonInformation
            {
                PersonInformation = new PersonInformationRequest
                {
                    NationalCode = nationalCode,
                    BirthDate = birthYear.ToString()
                }
            };
        }

        internal static MemberInfoByMcRequest GetMemberInfoRequest(DO_IDENTIFIER providerID)
        {
            if (providerID == null)
                throw new ArgumentException(Constants.Messages.ValueIsNullMessage(nameof(providerID)).Message);
            if (string.IsNullOrEmpty(providerID.ID))
                throw new ArgumentException(Constants.Messages.ValueIsNullMessage(nameof(providerID.ID)).Message);
            if (string.IsNullOrEmpty(providerID.Type))
                throw new ArgumentException(Constants.Messages.ValueIsNullMessage(nameof(providerID.Type)).Message);
            return new MemberInfoByMcRequest
            {
                McCodeNumeric = providerID.ID,
                McCodeTypeEn = providerID.Type
            };
        }
    }
}
