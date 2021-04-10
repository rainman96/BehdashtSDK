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
using System.Globalization;
using Ditas.SDK.Helper;
namespace Ditas.SDK.Mappers
{
    internal class ServiceModelMapper
    {
        internal static DrugTaminRequest ToPrescriptionTamin(MedicationPrescriptionsMessageVO medicationPrescriptionsMessage)
        {
            if (medicationPrescriptionsMessage == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(medicationPrescriptionsMessage)).Message);

            var nationalCode = medicationPrescriptionsMessage?.Person?.NationalCode;
            if (!Utilities.ValidateIranianNationalCode(nationalCode))
                throw new SdkException(Constants.Messages.InvalidFieldValue(nameof(nationalCode)).Message);

            var reps = medicationPrescriptionsMessage?.Composition?.MedicationPrescriptions?.Repeats;
            int repeat = reps.HasValue ? reps.Value : 0;
            var prescription = GetNotedetailePrescription(medicationPrescriptionsMessage?.Composition?.MedicationPrescriptions?.Orders, repeat, "01");
            return new DrugTaminRequest
            {
                Comments = "Send Ditas",
                SiamID = AppConfiguration.LocationID,
                DocId = medicationPrescriptionsMessage?.Composition?.Admission?.AdmittingDoctor?.Identifier?.ID,
                DocMobileNo = medicationPrescriptionsMessage?.MsgID?.Committer?.ContactPoint?.First()?.Detail,
                DocNationalCode = null,
                ExpireDate = GetExpireDate(),
                Mobile = medicationPrescriptionsMessage?.Person?.MobileNumber,
                NoteDetailEprscs = prescription,
                Patient = nationalCode,
                PrescDate = GetPrescDate(medicationPrescriptionsMessage?.Composition?.MedicationPrescriptions?.IssueDate),
                PrescType = new Presctype { PrescTypeId = (int)(prescription != null ? Constants.Enumarations.PrescType.Drug : Constants.Enumarations.PrescType.Visit) }
            };
        }

        private static string GetExpireDate()
        {
            var date = DateTime.Now.AddDays(60);
            var persianDate = new PersianCalendar();
            return $"{persianDate.GetYear(date)}{persianDate.GetMonth(date).ToString("00")}{persianDate.GetDayOfMonth(date).ToString("00")}";
        }

        private static string GetPrescDate(DO_DATE issueDate)
        {
            if (issueDate == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(issueDate)).Message);
            return $"{issueDate.Year}{issueDate.Month}{issueDate.Day}";
        }

        internal static DrugSalamatRequest ToDrugSalamat(MedicationPrescriptionsMessageVO medicationPrescriptionsMessage)
        {
            if (medicationPrescriptionsMessage == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(medicationPrescriptionsMessage)).Message);


            return new DrugSalamatRequest
            {
                SavePriscription = true,
                XmlText = Utilities.ToXmlString(medicationPrescriptionsMessage)
            };
        }

        private static Notedetaileprsc[] GetNotedetailePrescription(MedicationPrescriptionRowVO[] orders, int repeat, string srvType)
        {
            if (orders == null)
                return null;


            return orders.Select(s => new Notedetaileprsc
            {
                DrugInstruction = new Druginstruction
                {
                    DrugInstId = Utilities.ToIntSafe(s?.Method?.Coding?.Coded_string, "Method.Coding.Coded_string")
                },
                Repeat = repeat,
                SrvId = new Srvid
                {
                    SrvCode = s?.ProductCode?.Coded_string,
                    SrvType = new Srvtype
                    {
                        SrvType = srvType
                    }
                },
                SrvQty = (int)(s?.TotalNumber?.Magnitude.HasValue ?? false ? s?.TotalNumber?.Magnitude.Value : 0),
                TimesAday = new Timesaday { DrugAmntId = Utilities.ToIntSafe(s?.Frequency?.Coded_string, "Frequency.Coded_string") }
            }
                ).ToArray();
        }
        private static Notedetaileprsc[] GetServicePrescriptionsOrder(ServicePrescriptionRowVO[] orders, int repeat, string srvType)
        {
            if (orders == null)
                return null;


            return orders.Select(s => new Notedetaileprsc
            {
                Repeat = repeat,
                SrvId = new Srvid
                {
                    SrvCode = s?.Service?.Coded_string,
                    SrvType = new Srvtype
                    {
                        SrvType = srvType
                    }
                },
                SrvQty = (int)(s?.ServiceAmount.HasValue ?? false ? s?.ServiceAmount.Value : 0),
                ParTarifGrp = new ParTarifGrp { ParGrpCode = "000" }
            }
                ).ToArray();
        }
        internal static HIDRequest GetHIDRequest(DO_IDENTIFIER personID, DO_IDENTIFIER healthCareProvider, DO_CODED_TEXT insurer, DO_IDENTIFIER orgID)
        {
            if (personID == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(personID)).Message);
            if (healthCareProvider == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(healthCareProvider)).Message);
            if (insurer == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(insurer)).Message);
            if (orgID == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(orgID)).Message);

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
                throw new SdkException(Constants.Messages.InvalidFieldValue(nameof(nationalCode)).Message);
            if (healthCareFacilityID == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(healthCareFacilityID)).Message);
            if (insurer == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(insurer)).Message);
            if (orgID == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(orgID)).Message);

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

        internal static DrugTaminRequest ToLaboratoryTamin(LaboratoryPrescriptionsMessageVO laboratoryPrescriptionsMessageVO)
        {
            if (laboratoryPrescriptionsMessageVO == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(laboratoryPrescriptionsMessageVO)).Message);

            var nationalCode = laboratoryPrescriptionsMessageVO?.Person?.NationalCode;
            if (!Utilities.ValidateIranianNationalCode(nationalCode))
                throw new SdkException(Constants.Messages.InvalidFieldValue(nameof(nationalCode)).Message);

            var reps = laboratoryPrescriptionsMessageVO?.Composition?.ServicePrescriptions?.Repeats;
            int repeat = reps.HasValue ? reps.Value : 0;
            var prescription = GetServicePrescriptionsOrder(laboratoryPrescriptionsMessageVO?.Composition?.ServicePrescriptions?.Orders, repeat, "02");
            var date = laboratoryPrescriptionsMessageVO?.Composition?.ServicePrescriptions?.IssueDateTime;
            DO_DATE dO_DATE = new DO_DATE
            {
                Day = date.Day,
                Month = date.Month,
                Year = date.Year
            };
            return new DrugTaminRequest
            {
                Comments = "Send Ditas",
                SiamID = AppConfiguration.LocationID,
                DocId = laboratoryPrescriptionsMessageVO?.Composition?.Admission?.AdmittingDoctor?.Identifier?.ID,
                DocMobileNo = laboratoryPrescriptionsMessageVO?.MsgID?.Committer?.ContactPoint?.First()?.Detail,
                DocNationalCode = null,
                ExpireDate = GetExpireDate(),
                Mobile = laboratoryPrescriptionsMessageVO?.Person?.MobileNumber,
                NoteDetailEprscs = prescription,
                Patient = nationalCode,
                PrescDate = GetPrescDate(dO_DATE),
                PrescType = new Presctype { PrescTypeId = (int)(prescription != null ? Constants.Enumarations.PrescType.Drug : Constants.Enumarations.PrescType.Visit) }
            };
        }



        internal static InsuranceInquiryRequest ToInsuranceRequest(DO_IDENTIFIER personID, DO_IDENTIFIER providerID, DO_IDENTIFIER healthcarefacility)
        {
            if (personID == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(personID)).Message);
            if (!Utilities.ValidateIranianNationalCode(personID.ID))
                throw new SdkException(Constants.Messages.InvalidFieldValue(nameof(personID.ID)).Message);
            if (providerID == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(providerID)).Message);
            if (string.IsNullOrEmpty(providerID.ID))
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(providerID.ID)).Message);

            return new InsuranceInquiryRequest
            {
                ClientIp = Utilities.GetClientIp(),
                AppUser = "ditas",
                ForceUpdate = "false",
                HcpID = providerID,
                OrgID = healthcarefacility,
                PersonID = personID
            };
        }

        internal static RequestPersonInformation GetPersonRequest(string nationalCode, int birthYear)
        {
            if (!Utilities.ValidateIranianNationalCode(nationalCode))
                throw new SdkException(Constants.Messages.InvalidFieldValue(nameof(nationalCode)).Message);
            if (birthYear < 1 || birthYear.ToString().Length != 8)
                throw new SdkException(Constants.Messages.InvalidFieldValue(nameof(birthYear)).Message);

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
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(providerID)).Message);
            if (string.IsNullOrEmpty(providerID.ID))
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(providerID.ID)).Message);
            if (string.IsNullOrEmpty(providerID.Type))
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(providerID.Type)).Message);
            return new MemberInfoByMcRequest
            {
                McCodeNumeric = providerID.ID,
                McCodeTypeEn = providerID.Type
            };
        }

        internal static SaveSepasSecureRequest SaveSepasSecureRequest(object message)
        {
            if (message == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(message)).Message);
            //if (string.IsNullOrEmpty(providerID.ID))
            //    throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(providerID.ID)).Message);
            //if (string.IsNullOrEmpty(providerID.Type))
            //    throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(providerID.Type)).Message);

            string key, iv, data;
            (key, iv, data) = message.AesEncryptData();
            return new SaveSepasSecureRequest
            {
                ContentType = "Thrita.DM.Message.PatientBillMessageVO",
                IPClient = Utilities.GetClientIp(),
                IPServer = Utilities.GetClientIp(),
                LocationID = AppConfiguration.LocationID,
                SystemID = AppConfiguration.SystemId,
                Data = data,
                IV = iv,
                Key = key,
            };
        }

        internal static BatchHIDRequest GetBatchHIDRequest(DO_CODED_TEXT insurer, DO_IDENTIFIER orgID, int count)
        {
            if (insurer == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(insurer)).Message);
            if (orgID == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(orgID)).Message);

            return new BatchHIDRequest
            {
                ClientIp = Utilities.GetClientIp(),
                AppUser = "ditas",
                Count = count,
                InsurerID = insurer,
                OrgID = orgID,
            };
        }


        internal static UpdateHIDRequest GetUpdateHIDRequest(DO_IDENTIFIER HID, string nationalCode, DO_IDENTIFIER healthCareFacilityID, DO_CODED_TEXT insurer, DO_IDENTIFIER orgID)
        {
            if (!Utilities.ValidateIranianNationalCode(nationalCode))
                throw new SdkException(Constants.Messages.InvalidFieldValue(nameof(nationalCode)).Message);
            if (healthCareFacilityID == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(healthCareFacilityID)).Message);
            if (insurer == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(insurer)).Message);
            if (orgID == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(orgID)).Message);
            if (HID == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(HID)).Message);

            return new UpdateHIDRequest
            {
                ClientIp = Utilities.GetClientIp(),
                AppUser = "ditas",
                HcpID = healthCareFacilityID,
                InsurerID = insurer,
                OrgID = orgID,
                HID = HID,
                PersonID = new DO_IDENTIFIER { ID = nationalCode, Assigner = "National_Org_Civil_Reg", Issuer = "National_Org_Civil_Reg", Type = "National_Code" }
            };
        }
        internal static UpdateHIDRequest GetUpdateHIDRequest(DO_IDENTIFIER HID, DO_IDENTIFIER PersonId, DO_IDENTIFIER healthCareFacilityID, DO_CODED_TEXT insurer, DO_IDENTIFIER orgID)
        {
            if (!Utilities.ValidateIranianNationalCode(PersonId.ID))
                throw new SdkException(Constants.Messages.InvalidFieldValue(nameof(PersonId)).Message);
            if (healthCareFacilityID == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(healthCareFacilityID)).Message);
            if (insurer == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(insurer)).Message);
            if (orgID == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(orgID)).Message);
            if (HID == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(HID)).Message);

            return new UpdateHIDRequest
            {
                ClientIp = Utilities.GetClientIp(),
                AppUser = "ditas",
                HcpID = healthCareFacilityID,
                InsurerID = insurer,
                OrgID = orgID,
                HID = HID,
                PersonID = PersonId
            };
        }
        internal static EliminateHIDRequest GetEliminateHIDRequest(string nationalCode, DO_IDENTIFIER HID, DO_CODED_TEXT reason, DO_IDENTIFIER orgID)
        {

            if (!Utilities.ValidateIranianNationalCode(nationalCode))
                throw new SdkException(Constants.Messages.InvalidFieldValue(nameof(nationalCode)).Message);
            if (reason == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(orgID)).Message);
            if (HID == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(HID)).Message);
            if (orgID == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(orgID)).Message);
            return new EliminateHIDRequest
            {
                ClientIp = Utilities.GetClientIp(),
                AppUser = "ditas",
                OrgID = orgID,
                Reason = reason,
                HID = HID,
                PersonID = new DO_IDENTIFIER { ID = nationalCode, Assigner = "National_Org_Civil_Reg", Issuer = "National_Org_Civil_Reg", Type = "National_Code" }
            };
        }
        internal static EliminateHIDRequest GetEliminateHIDRequest(DO_IDENTIFIER PersonId, DO_IDENTIFIER HID, DO_CODED_TEXT reason, DO_IDENTIFIER orgID)
        {
            if (PersonId == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(PersonId)).Message);
            if (!Utilities.ValidateIranianNationalCode(PersonId.ID))
                throw new SdkException(Constants.Messages.InvalidFieldValue(nameof(PersonId)).Message);
            if (reason == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(orgID)).Message);
            if (HID == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(HID)).Message);
            if (orgID == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(orgID)).Message);
            return new EliminateHIDRequest
            {
                ClientIp = Utilities.GetClientIp(),
                AppUser = "ditas",
                OrgID = orgID,
                Reason = reason,
                HID = HID,
                PersonID = PersonId
            };
        }

        internal static VerifyHIDRequest GetVerifyHIDRequest(string nationalCode, DO_IDENTIFIER HID, DO_IDENTIFIER orgID)
        {
            if (!Utilities.ValidateIranianNationalCode(nationalCode))
                throw new SdkException(Constants.Messages.InvalidFieldValue(nameof(nationalCode)).Message);
            if (orgID == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(orgID)).Message);
            if (HID == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(HID)).Message);

            return new VerifyHIDRequest
            {
                ClientIp = Utilities.GetClientIp(),
                AppUser = "ditas",
                OrgID = orgID,
                HID = HID,
                PersonID = new DO_IDENTIFIER { ID = nationalCode, Assigner = "National_Org_Civil_Reg", Issuer = "National_Org_Civil_Reg", Type = "National_Code" }
            };
        }
        internal static VerifyHIDRequest GetVerifyHIDRequest(DO_IDENTIFIER PersonId, DO_IDENTIFIER HID, DO_IDENTIFIER orgID)
        {
            if (PersonId == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(PersonId)).Message);
            if (!Utilities.ValidateIranianNationalCode(PersonId?.ID))
                throw new SdkException(Constants.Messages.InvalidFieldValue(nameof(PersonId.ID)).Message);
            if (orgID == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(orgID)).Message);
            if (HID == null)
                throw new SdkException(Constants.Messages.ValueIsNullMessage(nameof(HID)).Message);

            return new VerifyHIDRequest
            {
                ClientIp = Utilities.GetClientIp(),
                AppUser = "ditas",
                OrgID = orgID,
                HID = HID,
                PersonID = PersonId
            };
        }
    }
}
