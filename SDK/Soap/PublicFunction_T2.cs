using SDK.AdditionalTools.Basic;
using SDK.AdditionalTools.Basic.Extra;
using SDK.AdditionalTools.Encryption;
using SDK.DataModel;
using SDK.Mappers;
using System;
using System.Configuration;
using System.Net;
namespace SDK.Soap
{
    public partial class Service
    {
        private readonly IAdaptorFactory adaptorFactory;
        public Service()
        {
            adaptorFactory = new SoapAdaptorFactory();

            try
            {
                DateTime currentDatatime = DateTime.Now;
                TimeSpan diff = currentDatatime.Subtract(Configuration.CertificationExpirationDate());
                if (Configuration.Certification_Is_Unlimited == false)
                {
                    if (diff.TotalDays > 0)
                        throw new Exception("SDK Certificate is expired.");
                }
                Chronometer Time = new Chronometer();
                //Urls = new SDK.URL();
                // VariableService = new Variable();
                _log("Service New Time", Time);
            }
            catch (Exception ex)
            {
                throw new Exception("Error at Service. ", ex);
            }
        }

        /// <summary>
        ///          This method is designed to interchange the SIYAB reports for PHC systems. It is designed so that the primary healthcare services that are provided to the patient as well as any clinical findings, physical exams, etc. for the pateints' encounters.
        ///          </summary>
        ///          <param name="SOAPReport">This argument is of type SOAPMessageVO, and is designed to the purpose of exchanging the primary healthcare services provided by GPs or family physicians and primary healthcare facilities.</param>
        ///          <returns>The method returns an object of type ResultVO. ResultVO models the response of SEPAS nodes either successful or unsuccessful.</returns>
        public ResultVO SaveSIYABReport(SOAPMessageVO SOAPReport)
        {
            var url = ConfigurationManager.AppSettings["SIYABWebServiceURL"];
            var srv = adaptorFactory.GetWebService<WCF_SIYABService.SIYABServiceSoapChannel>(url);
            try
            {
                DO_IDENTIFIER Location = GetHealthCareFacility();
                //var srv= new WCF_SIYABService.SIYABServiceSoapClient(WCF_SIYABService.SIYABServiceSoapClient.EndpointConfiguration.SIYABServiceSoap);
                // srv.Url = url;
                //Dim v As New Variable
                var headerMessageVOValue = new HeaderMessageVO();
                headerMessageVOValue.Sender = new SystemSenderVO();
                string systemId = "";

                systemId = SOAPReport.MsgID.SystemID.ID;// VariableService.GetSystemID();
                headerMessageVOValue.Sender.SystemID = systemId;
                headerMessageVOValue.Sender.LocationID = Location.ID;
                headerMessageVOValue.Sender.URL = "0";
                // '-------------------------(Begin-PrimaryDefinition)------------------------'
                DO_IDENTIFIER SystemID, LocationID;
                SystemID = new DO_IDENTIFIER
                {
                    Assigner = "MOHME_IT",
                    ID = headerMessageVOValue.Sender.SystemID,
                    Issuer = "MOHME_IT",
                    Type = "System_ID"
                };
                LocationID = new DO_IDENTIFIER
                {
                    Assigner = "MOHME_IT",
                    ID = headerMessageVOValue.Sender.LocationID,
                    Issuer = "MOHME_IT",
                    Type = "Org_ID"
                };
                //'-------------------------(End-PrimaryDefinition)------------------------'
                //'-------------------------(Begin-MsgID)------------------------'
                if (SOAPReport == null) throw new Exception("Object is null.");
                if (SOAPReport.MsgID == null) throw new Exception("MsgID is null.");
                SOAPReport.MsgID.HealthCareFacilityID = LocationID;
                SOAPReport.MsgID.SystemID = SystemID;
                //'-------------------------(End-MsgID)------------------------'
                DataModel.ResultVO result;
                var sec = new Crypto();
                byte[] b;
                b = sec.SecuredObject(SOAPReport);
                WCF_SIYABService.SaveSIYABReportSecureRequest secureRequest = new WCF_SIYABService.SaveSIYABReportSecureRequest
                {
                    data = b,
                    HeaderMessageVO = ServiceModelMapper.ToServiceHeader<WCF_SIYABService.HeaderMessageVO>(headerMessageVOValue)
                };
                var response = srv.SaveSIYABReportSecure(secureRequest);
                result = ClientModelMapper.ToClientResponse<ResultVO, WCF_SIYABService.ResultVO>(response.SaveSIYABReportSecureResult);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(MainFx.CreateException("SaveSIYABReport", ex));
            }
        }
        /// <summary>
        ///          This method is developed to exchange the BillSaummary data of patient encounters to healthcare faclities either inpatient or outpatients. The costs and contributions of all entities involved in heathcare delivery process including the patient, the basic insurance, the complemtary insurance, etc are detailed through this method.
        ///          </summary>
        ///          <param name="PatientBillMessage">This argument is of type PatientBillMessageVO which consists of demographics, insurance, admission, discharge, diagnosis, billsummary, service details, etc.</param>
        ///          <returns>The method returns an object of type ResultVO. ResultVO models the response of SEPAS nodes either successful or unsuccessful.</returns>
        public ResultVO SavePatientBill(PatientBillMessageVO PatientBillMessage)
        {
            try
            {
                DO_IDENTIFIER Location = GetHealthCareFacility();
                var url = ConfigurationManager.AppSettings["BillPatientServiceURL"];
                var srv = adaptorFactory.GetWebService<WCF_BillPatientService.BillPatientServiceSoapChannel>(url);

                // Dim v As New Variable
                var headerMessageVOValue = new HeaderMessageVO();
                headerMessageVOValue.Sender = new SystemSenderVO();
                headerMessageVOValue.Sender.SystemID = PatientBillMessage.MsgID.SystemID.ID;// VariableService.GetSystemID();
                headerMessageVOValue.Sender.LocationID = Location.ID;
                headerMessageVOValue.Sender.URL = "0";
                // -------------------------(Begin-PrimaryDefinition)------------------------'
                DO_IDENTIFIER SystemID, LocationID;
                SystemID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.SystemID, Issuer = "MOHME_IT", Type = "System_ID" };
                LocationID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.LocationID, Issuer = "MOHME_IT", Type = "Org_ID" };
                // -------------------------(End-PrimaryDefinition)------------------------'
                // -------------------------(Begin-MsgID)------------------------'
                if (PatientBillMessage == null)
                    throw new Exception("Object is null.");
                if (PatientBillMessage.MsgID == null)
                    throw new Exception("MsgID is null.");
                PatientBillMessage.MsgID.HealthCareFacilityID = LocationID;
                PatientBillMessage.MsgID.SystemID = SystemID;
                // -------------------------(End-MsgID)------------------------'
                ResultVO result;
                Crypto sec = new Crypto();
                byte[] b;
                b = sec.SecuredObject(PatientBillMessage);
                var secureRequest = new WCF_BillPatientService.SavePatientBillSecureRequest
                {
                    data = b,
                    HeaderMessageVO = ServiceModelMapper.ToServiceHeader<WCF_BillPatientService.HeaderMessageVO>(headerMessageVOValue)
                };
                var response = srv.SavePatientBillSecure(secureRequest);
                result = ClientModelMapper.ToClientResponse<ResultVO, WCF_BillPatientService.ResultVO>(response.SavePatientBillSecureResult);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(MainFx.CreateException("SavePatientBill", ex));
            }
        }
        /// <summary>
        ///          This method is used to save the patient admissions to inpatient facilities. this method is called when an event of patient admission in hospitals is trigerred.
        ///          </summary>
        ///          <param name="AdmittedMessage">The argument to save admitted message is of typ AdmittedMessageVO. It consists of petient demographic info, Insurance data and admission information.</param>
        ///          <returns>The method returns an object of type ResultVO. ResultVO models the response of SEPAS nodes either successful or unsuccessful.</returns>
        public ResultVO SaveAdmittedMessage(AdmittedMessageVO AdmittedMessage)
        {
            try
            {

                DO_IDENTIFIER Location = GetHealthCareFacility();
                var url = ConfigurationManager.AppSettings["AdmittedServiceURL"];
                var srv = adaptorFactory.GetWebService<WCF_AdmittedService.AdmittedServiceSoapChannel>(url);
                var headerMessageVOValue = new HeaderMessageVO();
                headerMessageVOValue = new HeaderMessageVO();
                headerMessageVOValue.Sender = new SystemSenderVO();
                headerMessageVOValue.Sender.SystemID = VariableService.GetSystemID();
                headerMessageVOValue.Sender.LocationID = Location.ID;
                headerMessageVOValue.Sender.URL = "0";
                // -------------------------(Begin-PrimaryDefinition)------------------------'
                DO_IDENTIFIER SystemID, LocationID;
                SystemID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.SystemID, Issuer = "MOHME_IT", Type = "System_ID" };
                LocationID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.LocationID, Issuer = "MOHME_IT", Type = "Org_ID" };
                // -------------------------(End-PrimaryDefinition)------------------------'
                // -------------------------(Begin-MsgID)------------------------'
                if (AdmittedMessage == null)
                    throw new Exception("Object is null.");
                if (AdmittedMessage.MsgID == null)
                    throw new Exception("MsgID is null.");
                AdmittedMessage.MsgID.HealthCareFacilityID = LocationID;
                AdmittedMessage.MsgID.SystemID = SystemID;
                // -------------------------(End-MsgID)------------------------'
                ResultVO result;
                Crypto sec = new Crypto();
                byte[] b;
                b = sec.SecuredObject(AdmittedMessage);
                var secureRequest = new WCF_AdmittedService.SaveAdmittedMessageSecureRequest
                {
                    data = b,
                    HeaderMessageVO = ServiceModelMapper.ToServiceHeader<WCF_AdmittedService.HeaderMessageVO>(headerMessageVOValue)
                };
                var response = srv.SaveAdmittedMessageSecure(secureRequest);
                result = ClientModelMapper.ToClientResponse<ResultVO, WCF_AdmittedService.ResultVO>(response.SaveAdmittedMessageSecureResult);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(MainFx.CreateException("SaveAdmittedMessage", ex));
            }
        }
        /// <summary>
        ///          This method is used to exchange the data regarding death certificates of individuals.
        ///          </summary>
        ///          <param name="DeathCertificateMessage">This argument is of type DeathCertificateMessageVO. This type is developed to specify the information regarding death status, underlying causes of death, person's demographic, burial attestation, etc.</param>
        ///          <returns>The method returns an object of type ResultVO. ResultVO models the response of SEPAS nodes either successful or unsuccessful.</returns>
        public ResultVO SaveDeathCertificate(DeathCertificateMessageVO DeathCertificateMessage)
        {
            try
            {

                DO_IDENTIFIER Location = GetHealthCareFacility();
                var url = ConfigurationManager.AppSettings["DeathCertificateServiceURL"];
                var srv = adaptorFactory.GetWebService<WCF_DeathCertificate.DeathCertificateServiceSoapChannel>(url);


                // Dim v As New Variable
                var headerMessageVOValue = new HeaderMessageVO();
                headerMessageVOValue.Sender = new SystemSenderVO();
                headerMessageVOValue.Sender.SystemID = VariableService.GetSystemID();
                headerMessageVOValue.Sender.LocationID = Location.ID;
                headerMessageVOValue.Sender.URL = "0";
                // -------------------------(Begin-PrimaryDefinition)------------------------'
                DO_IDENTIFIER SystemID, LocationID;
                SystemID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.SystemID, Issuer = "MOHME_IT", Type = "System_ID" };
                LocationID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.LocationID, Issuer = "MOHME_IT", Type = "Org_ID" };
                // -------------------------(End-PrimaryDefinition)------------------------'
                // -------------------------(Begin-MsgID)------------------------'
                if (DeathCertificateMessage == null)
                    throw new Exception("Object is null.");
                if (DeathCertificateMessage.MsgID == null)
                    throw new Exception("MsgID is null.");
                DeathCertificateMessage.MsgID.HealthCareFacilityID = LocationID;
                DeathCertificateMessage.MsgID.SystemID = SystemID;
                // -------------------------(End-MsgID)------------------------'
                ResultVO result;
                Crypto sec = new Crypto();
                byte[] b;
                b = sec.SecuredObject(DeathCertificateMessage);
                var secureRequest = new WCF_DeathCertificate.SaveDeathCertificateSecureRequest
                {
                    data = b,
                    HeaderMessageVO = ServiceModelMapper.ToServiceHeader<WCF_DeathCertificate.HeaderMessageVO>(headerMessageVOValue)
                };
                var response = srv.SaveDeathCertificateSecure(secureRequest);
                result = ClientModelMapper.ToClientResponse<ResultVO, WCF_DeathCertificate.ResultVO>(response.SaveDeathCertificateSecureResult);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(MainFx.CreateException("SaveDeathCertificate", ex));
            }
        }
        /// <summary>
        ///          This method is to exchange the care data regarding dental healthcare services.
        ///          </summary>
        ///          <param name="DentalCareMessage">The argument of this method is of type DentaCareMessageVO that consists of several other classes including the patient's demographic, admissions, dental diagnosis, treatment plans, etc.</param>
        ///          <returns>The method returns an object of type ResultVO. ResultVO models the response of SEPAS nodes either successful or unsuccessful.</returns>
        public ResultVO SaveDentalCase(DentalCareMessageVO DentalCareMessage)
        {
            try
            {
                DO_IDENTIFIER Location = GetHealthCareFacility();
                var url = ConfigurationManager.AppSettings["DeathCertificateServiceURL"];
                var srv = adaptorFactory.GetWebService<WCF_DentalCaseService.DentalCaseServiceSoapChannel>(url);
                //"/DentalCaseService.asmx";
                // Dim v As New Variable
                var headerMessageVOValue = new HeaderMessageVO();
                headerMessageVOValue.Sender = new SystemSenderVO();
                headerMessageVOValue.Sender.SystemID = VariableService.GetSystemID();
                headerMessageVOValue.Sender.LocationID = Location.ID;
                headerMessageVOValue.Sender.URL = "0";
                // -------------------------(Begin-PrimaryDefinition)------------------------'
                DO_IDENTIFIER SystemID, LocationID;
                SystemID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.SystemID, Issuer = "MOHME_IT", Type = "System_ID" };
                LocationID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.LocationID, Issuer = "MOHME_IT", Type = "Org_ID" };
                // -------------------------(End-PrimaryDefinition)------------------------'
                // -------------------------(Begin-MsgID)------------------------'
                if (DentalCareMessage == null)
                    throw new Exception("Object is null.");
                if (DentalCareMessage.MsgID == null)
                    throw new Exception("MsgID is null.");
                DentalCareMessage.MsgID.HealthCareFacilityID = LocationID;
                DentalCareMessage.MsgID.SystemID = SystemID;
                // -------------------------(End-MsgID)------------------------'
                ResultVO result;
                Crypto sec = new Crypto();
                byte[] b;
                b = sec.SecuredObject(DentalCareMessage);
                var secureRequest = new WCF_DentalCaseService.SaveDentalCaseSecureRequest
                {
                    data = b,
                    HeaderMessageVO = ServiceModelMapper.ToServiceHeader<WCF_DentalCaseService.HeaderMessageVO>(headerMessageVOValue)
                };
                var response = srv.SaveDentalCaseSecure(secureRequest);
                result = ClientModelMapper.ToClientResponse<ResultVO, WCF_DentalCaseService.ResultVO>(response.SaveDentalCaseSecureResult);

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(MainFx.CreateException("SaveDentalCase", ex));
            }
        }
        /// <summary>
        ///          This method is developed to exchange the dispensed prescription. It is designed to be used by pharmacies to send the dispensed medications data along with their costs.
        ///          </summary>
        ///          <param name="DispensedPrescriptionsMessage">The argument of this method is of type DispensedPrescriptionMessageVO. it consists of several classes including: patient demographic, dispensed prescriptions data, costs per medicinal products, insurance data of the patient, etc.</param>
        ///          <returns>The method returns an object of type ResultVO. ResultVO models the response of SEPAS nodes either successful or unsuccessful.</returns>
        public ResultVO SaveDispensedPrescription(DispensedPrescriptionsMessageVO DispensedPrescriptionsMessage)
        {
            try
            {
                DO_IDENTIFIER Location = GetHealthCareFacility();
                var url = ConfigurationManager.AppSettings["DispensedPrescriptionServiceURL"];
                var srv = adaptorFactory.GetWebService<WCF_DispenseDprescriptionService.DispensedPrescriptionServiceSoapChannel>(url);

                // "/DispensedPrescriptionService.asmx";
                // Dim v As New Variable
                var headerMessageVOValue = new HeaderMessageVO();
                headerMessageVOValue.Sender = new SystemSenderVO();
                headerMessageVOValue.Sender.SystemID = VariableService.GetSystemID();
                headerMessageVOValue.Sender.LocationID = Location.ID;
                headerMessageVOValue.Sender.URL = "0";
                // -------------------------(Begin-PrimaryDefinition)------------------------'
                // Dim LocationName As String
                // LocationName = "مرکز ارائه دهنده خدمت مجازی جهت تبادل اطلاعات تستی"
                DO_IDENTIFIER SystemID, LocationID;
                SystemID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.SystemID, Issuer = "MOHME_IT", Type = "System_ID" };
                LocationID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.LocationID, Issuer = "MOHME_IT", Type = "Org_ID" };
                // -------------------------(End-PrimaryDefinition)------------------------'
                // -------------------------(Begin-MsgID)------------------------'
                if (DispensedPrescriptionsMessage == null)
                    throw new Exception("Object is null.");
                if (DispensedPrescriptionsMessage.MsgID == null)
                    throw new Exception("MsgID is null.");
                DispensedPrescriptionsMessage.MsgID.HealthCareFacilityID = LocationID;
                DispensedPrescriptionsMessage.MsgID.SystemID = SystemID;
                // -------------------------(End-MsgID)------------------------'
                // '------------------------ - (Begin - Institute)------------------------'
                // If DispensedPrescriptionsMessage.Composition.Admission.Institute Is Nothing Then DispensedPrescriptionsMessage.Composition.Admission.Institute = New OrganizationVO
                // DispensedPrescriptionsMessage.Composition.Admission.Institute.ID = New DO_IDENTIFIER
                // DispensedPrescriptionsMessage.Composition.Admission.Institute.ID = LocationID
                // DispensedPrescriptionsMessage.Composition.Admission.Institute.Name = LocationName
                // '------------------------ - (Begin - Institute)------------------------'
                ResultVO result;
                Crypto sec = new Crypto();
                byte[] b;
                b = sec.SecuredObject(DispensedPrescriptionsMessage);
                var secureRequest = new WCF_DispenseDprescriptionService.SaveDispensedPrescriptionSecureRequest
                {
                    data = b,
                    HeaderMessageVO = ServiceModelMapper.ToServiceHeader<WCF_DispenseDprescriptionService.HeaderMessageVO>(headerMessageVOValue)
                };
                var response = srv.SaveDispensedPrescriptionSecure(secureRequest);
                result = ClientModelMapper.ToClientResponse<ResultVO, WCF_DispenseDprescriptionService.ResultVO>(response.SaveDispensedPrescriptionSecureResult);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(MainFx.CreateException("SaveDispensedPrescriptionSecure", ex));
            }
        }
        /// <summary>        
        ///          This method is designed to send the insurer reimbursement for patient bills.        
        ///          </summary>        
        ///          <param name="InsurerReimbursementMessage">This argument specifies the reimbursement info. This argument is of type InsurerReimbursementMessageVO.</param>        
        ///          <returns>The method returns the result of the transaction as a ResultVO.</returns>
        public ResultVO SendInsurerReimbursement(InsurerReimbursementMessageVO InsurerReimbursementMessage)
        {
            try
            {
                DO_IDENTIFIER Location = GetHealthCareFacility();
                var url = ConfigurationManager.AppSettings["InsurerReimbursementServiceURL"];
                var srv = adaptorFactory.GetWebService<WCF_InsurerReimbursementService.InsurerReimbursementServiceSoapChannel>(url);

                //"/InsurerReimbursementService.asmx";
                // Dim v As New Variable
                var headerMessageVOValue = new HeaderMessageVO();
                headerMessageVOValue.Sender = new SystemSenderVO();
                headerMessageVOValue.Sender.SystemID = VariableService.GetSystemID();
                headerMessageVOValue.Sender.LocationID = Location.ID;
                headerMessageVOValue.Sender.URL = "0";
                // -------------------------(Begin-PrimaryDefinition)------------------------'
                DO_IDENTIFIER SystemID, LocationID;
                SystemID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.SystemID, Issuer = "MOHME_IT", Type = "System_ID" };
                LocationID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.LocationID, Issuer = "MOHME_IT", Type = "Org_ID" };
                // -------------------------(End-PrimaryDefinition)------------------------'
                // -------------------------(Begin-MsgID)------------------------'
                if (InsurerReimbursementMessage == null)
                    throw new Exception("Object is null.");
                if (InsurerReimbursementMessage.MsgID == null)
                    throw new Exception("MsgID is null.");
                InsurerReimbursementMessage.MsgID.HealthCareFacilityID = LocationID;
                InsurerReimbursementMessage.MsgID.SystemID = SystemID;
                // -------------------------(End-MsgID)------------------------'
                Data Encrypt_SymmetricKeyStr = new Data();
                Data k = new Data(), iv = new Data();
                // -------------------------------------Generate HeaderMessage --------------------------------
                if (Configuration.Security_Mode == Configuration.SecurityMode.PowerSecurity)
                    headerMessageVOValue.Sender.URL = "http://ca.mohme.gov.ir/1/" + Encrypt_SymmetricKeyStr.ToBase64();
                // -------------------------------------Generate HeaderMessage --------------------------------
                // -------------------------------------Encrypt Message--------------------------------
                byte[] b;
                SimpleSecureShell ssl = new SimpleSecureShell();
                b = ssl.Dastine(InsurerReimbursementMessage);
                // -------------------------------------Encrypt Message--------------------------------
                // -------------------------------------Send Message to SEPAS if needed--------------------------------
                var secureRequest = new WCF_InsurerReimbursementService.SaveInsurerReimbursementSecureRequest
                {
                    data = b,
                    HeaderMessageVO = ServiceModelMapper.ToServiceHeader<WCF_InsurerReimbursementService.HeaderMessageVO>(headerMessageVOValue)
                };
                var response = srv.SaveInsurerReimbursementSecure(secureRequest);
                return ClientModelMapper.ToClientResponse<ResultVO, WCF_InsurerReimbursementService.ResultVO>(response.SaveInsurerReimbursementSecureResult);
            }
            // -------------------------------------Send Message to SEPAS if needed--------------------------------
            catch (Exception ex)
            {
                throw new Exception(MainFx.CreateException("SendInsurerReimbursement", ex));
            }
        }
        /// <summary>        
        ///          This method is designed to save the laboratory prescriptions.        
        ///          </summary>        
        ///          <param name="LaboratoryPrescriptionsMessage">This argument specifies the laboratoty prescription. This argument is of type LaboratoryPrescriptionsMessageVO.</param>        
        ///          <returns>The method returns the result of the transaction as a ResultVO.</returns>
        public ResultVO SaveLaboratoryPrescriptions(LaboratoryPrescriptionsMessageVO LaboratoryPrescriptionsMessage)
        {
            try
            {
                DO_IDENTIFIER Location = GetHealthCareFacility();
                var url = ConfigurationManager.AppSettings["LaboratoryPrescriptionServiceURL"];
                var srv = adaptorFactory.GetWebService<WCF_LaboratoryPrescriptionService.LaboratoryPrescriptionServiceSoapChannel>(url);
                // "/LaboratoryPrescriptionService.asmx";
                // Dim v As New Variable
                var headerMessageVOValue = new HeaderMessageVO();
                headerMessageVOValue.Sender = new SystemSenderVO();
                headerMessageVOValue.Sender.SystemID = LaboratoryPrescriptionsMessage.MsgID.SystemID.ID;// VariableService.GetSystemID();
                headerMessageVOValue.Sender.LocationID = Location.ID;
                headerMessageVOValue.Sender.URL = "0";
                // -------------------------(Begin-PrimaryDefinition)------------------------'
                DO_IDENTIFIER SystemID, LocationID;
                SystemID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.SystemID, Issuer = "MOHME_IT", Type = "System_ID" };
                LocationID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.LocationID, Issuer = "MOHME_IT", Type = "Org_ID" };
                // -------------------------(End-PrimaryDefinition)------------------------'
                // -------------------------(Begin-MsgID)------------------------'
                if (LaboratoryPrescriptionsMessage == null)
                    throw new Exception("Object is null.");
                if (LaboratoryPrescriptionsMessage.MsgID == null)
                    throw new Exception("MsgID is null.");
                LaboratoryPrescriptionsMessage.MsgID.HealthCareFacilityID = LocationID;
                LaboratoryPrescriptionsMessage.MsgID.SystemID = SystemID;
                // -------------------------(End-MsgID)------------------------'
                Data Encrypt_SymmetricKeyStr = new Data();
                Data k = new Data(), iv = new Data();
                // -------------------------------------Generate HeaderMessage --------------------------------
                // -------------------------------------Generate HeaderMessage IP Temp --------------------------------
                IPHostEntry IPHost = Dns.GetHostEntry(Dns.GetHostName());
                headerMessageVOValue.Sender.IP = IPHost.AddressList[0].ToString(); // InternalIP
                // -------------------------------------Generate HeaderMessage IP Temp --------------------------------
                if (Configuration.Security_Mode == Configuration.SecurityMode.PowerSecurity)
                    headerMessageVOValue.Sender.URL = "http://ca.mohme.gov.ir/1/" + Encrypt_SymmetricKeyStr.ToBase64();
                // -------------------------------------Generate HeaderMessage --------------------------------
                // -------------------------------------Encrypt Message--------------------------------
                byte[] b;
                SimpleSecureShell ssl = new SimpleSecureShell();
                b = ssl.Dastine(LaboratoryPrescriptionsMessage);
                // -------------------------------------Encrypt Message--------------------------------
                // -------------------------------------Send Message to SEPAS if needed--------------------------------
                var secureRequest = new WCF_LaboratoryPrescriptionService.SaveLaboratoryPrescriptionSecureRequest
                {
                    data = b,
                    HeaderMessageVO = ServiceModelMapper.ToServiceHeader<WCF_LaboratoryPrescriptionService.HeaderMessageVO>(headerMessageVOValue)
                };
                var response = srv.SaveLaboratoryPrescriptionSecure(secureRequest);
                return ClientModelMapper.ToClientResponse<ResultVO, WCF_LaboratoryPrescriptionService.ResultVO>(response.SaveLaboratoryPrescriptionSecureResult);
            }
            // -------------------------------------Send Message to SEPAS if needed--------------------------------
            catch (Exception ex)
            {
                throw new Exception(MainFx.CreateException("SaveLaboratoryPrescriptions", ex));
            }
        }
        /// <summary>
        ///          This method is developed to save the laboratory result tests. this method can accept any type of medical laboratory results from microbial to pathology test,, etc.
        ///          </summary>
        ///          <param name="LaboratoryResultMessage">The LaboratoryResultMessageVO is the data type of the input argument. it is designed so that it can exchange any type of test. This class consists of several other classes such as petient's demographic, lab test result, specimen details, admission, insurance, etc. the lab test result is an abstract class that all medical lab tets are the specializations of it.</param>
        ///          <returns>The method returns an object of type ResultVO. ResultVO models the response of SEPAS nodes either successful or unsuccessful.</returns>
        public ResultVO SaveLaboratoryResult(LaboratoryResultMessageVO LaboratoryResultMessage)
        {
            try
            {
                DO_IDENTIFIER Location = GetHealthCareFacility();
                var url = ConfigurationManager.AppSettings["LaboratoryResultServiceURL"];
                var srv = adaptorFactory.GetWebService<WCF_LaboratoryResultService.LaboratoryResultServiceSoapChannel>(url);

                // "/LaboratoryResultService.asmx";
                // Dim v As New Variable
                var headerMessageVOValue = new HeaderMessageVO();
                headerMessageVOValue.Sender = new SystemSenderVO();
                headerMessageVOValue.Sender.SystemID = LaboratoryResultMessage.MsgID.SystemID.ID;// VariableService.GetSystemID();
                headerMessageVOValue.Sender.LocationID = Location.ID;
                headerMessageVOValue.Sender.URL = "0";
                // -------------------------(Begin-PrimaryDefinition)------------------------'
                DO_IDENTIFIER SystemID, LocationID;
                SystemID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.SystemID, Issuer = "MOHME_IT", Type = "System_ID" };
                LocationID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.LocationID, Issuer = "MOHME_IT", Type = "Org_ID" };
                // -------------------------(End-PrimaryDefinition)------------------------'
                // -------------------------(Begin-MsgID)------------------------'
                if (LaboratoryResultMessage == null)
                    throw new Exception("Object is null.");
                if (LaboratoryResultMessage.MsgID == null)
                    throw new Exception("MsgID is null.");
                LaboratoryResultMessage.MsgID.HealthCareFacilityID = LocationID;
                LaboratoryResultMessage.MsgID.SystemID = SystemID;
                // -------------------------(End-MsgID)------------------------'
                ResultVO result;
                Crypto sec = new Crypto();
                byte[] b;
                b = sec.SecuredObject(LaboratoryResultMessage);
                var secureRequest = new WCF_LaboratoryResultService.SaveLaboratoryResultSecureRequest
                {
                    data = b,
                    HeaderMessageVO = ServiceModelMapper.ToServiceHeader<WCF_LaboratoryResultService.HeaderMessageVO>(headerMessageVOValue)
                };
                var response = srv.SaveLaboratoryResultSecure(secureRequest);
                result = ClientModelMapper.ToClientResponse<ResultVO, WCF_LaboratoryResultService.ResultVO>(response.SaveLaboratoryResultSecureResult);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(MainFx.CreateException("SaveLaboratoryResult", ex));
            }
        }
        /// <summary>        
        ///          This method is designed to save the medical imaging prescriptions.        
        ///          </summary>        
        ///          <param name="ImagingPrescriptionsMessage">This argument specifies the imaging prescriptions. This argument is of type ImagingPrescriptionsMessageVO.</param>        
        ///          <returns>The method returns the result of the transaction as a ResultVO.</returns>
        public ResultVO SaveMedicalImagingPrescriptions(ImagingPrescriptionsMessageVO ImagingPrescriptionsMessage)
        {
            try
            {
                DO_IDENTIFIER Location = GetHealthCareFacility();
                var url = ConfigurationManager.AppSettings["MedicalImagePrescriptionServiceURL"];
                var srv = adaptorFactory.GetWebService<WCF_MedicalImagePrescriptionService.MedicalImagePrescriptionServiceSoapChannel>(url);
                //"/MedicalImagePrescriptionService.asmx";
                // Dim v As New Variable
                var headerMessageVOValue = new HeaderMessageVO();
                headerMessageVOValue.Sender = new SystemSenderVO();
                headerMessageVOValue.Sender.SystemID = VariableService.GetSystemID();
                headerMessageVOValue.Sender.LocationID = Location.ID;
                headerMessageVOValue.Sender.URL = "0";
                // -------------------------(Begin-PrimaryDefinition)------------------------'
                DO_IDENTIFIER SystemID, LocationID;
                SystemID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.SystemID, Issuer = "MOHME_IT", Type = "System_ID" };
                LocationID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.LocationID, Issuer = "MOHME_IT", Type = "Org_ID" };
                // -------------------------(End-PrimaryDefinition)------------------------'
                // -------------------------(Begin-MsgID)------------------------'
                if (ImagingPrescriptionsMessage == null)
                    throw new Exception("Object is null.");
                if (ImagingPrescriptionsMessage.MsgID == null)
                    throw new Exception("MsgID is null.");
                ImagingPrescriptionsMessage.MsgID.HealthCareFacilityID = LocationID;
                ImagingPrescriptionsMessage.MsgID.SystemID = SystemID;
                // -------------------------(End-MsgID)------------------------'
                Data Encrypt_SymmetricKeyStr = new Data();
                Data k = new Data(), iv = new Data();
                // -------------------------------------Generate HeaderMessage --------------------------------
                // -------------------------------------Generate HeaderMessage IP Temp --------------------------------
                IPHostEntry IPHost = Dns.GetHostEntry(Dns.GetHostName());
                headerMessageVOValue.Sender.IP = IPHost.AddressList[0].ToString(); // InternalIP
                // -------------------------------------Generate HeaderMessage IP Temp --------------------------------
                if (Configuration.Security_Mode == Configuration.SecurityMode.PowerSecurity)
                    headerMessageVOValue.Sender.URL = "http://ca.mohme.gov.ir/1/" + Encrypt_SymmetricKeyStr.ToBase64();
                // -------------------------------------Generate HeaderMessage --------------------------------
                // -------------------------------------Encrypt Message--------------------------------
                byte[] b;
                SimpleSecureShell ssl = new SimpleSecureShell();
                b = ssl.Dastine(ImagingPrescriptionsMessage);
                // -------------------------------------Encrypt Message--------------------------------
                // -------------------------------------Send Message to SEPAS if needed--------------------------------
                var secureRequest = new WCF_MedicalImagePrescriptionService.SaveMedicalImagePrescriptionSecureRequest
                {
                    data = b,
                    HeaderMessageVO = ServiceModelMapper.ToServiceHeader<WCF_MedicalImagePrescriptionService.HeaderMessageVO>(headerMessageVOValue)
                };
                var response = srv.SaveMedicalImagePrescriptionSecure(secureRequest);
                return ClientModelMapper.ToClientResponse<ResultVO, WCF_MedicalImagePrescriptionService.ResultVO>(response.SaveMedicalImagePrescriptionSecureResult);
            }
            // -------------------------------------Send Message to SEPAS if needed--------------------------------
            catch (Exception ex)
            {
                throw new Exception(MainFx.CreateException("SaveMedicalImagingPrescriptions", ex));
            }
        }
        /// <summary>
        ///          This method is developed in order to exchange the prescribed medications. This method has particular usage in eprescription that manages the whole process from prescribing the medicinal product to dispensing it.
        ///          </summary>
        ///          <param name="MedicationPrescriptionsMessage">MedicationPrescriptionMessageVO is the input argument that is used to send the data regarding prescribed medicinal products.</param>
        ///          <returns>The method returns an object of type ResultVO. ResultVO models the response of SEPAS nodes either successful or unsuccessful.</returns>
        public ResultVO SaveMedicationPrescription(MedicationPrescriptionsMessageVO MedicationPrescriptionsMessage)
        {
            try
            {
                DO_IDENTIFIER Location = GetHealthCareFacility();
                var url = ConfigurationManager.AppSettings["MedicationPrescriptionServiceURL"];
                var srv = adaptorFactory.GetWebService<WCF_MedicationPrescriptionService.MedicationPrescriptionServiceSoapChannel>(url);
                // "/MedicationPrescriptionService.asmx";
                // Dim v As New Variable
                var headerMessageVOValue = new HeaderMessageVO();
                headerMessageVOValue.Sender = new SystemSenderVO();
                headerMessageVOValue.Sender.SystemID = VariableService.GetSystemID();
                headerMessageVOValue.Sender.LocationID = Location.ID;
                headerMessageVOValue.Sender.URL = "0";
                // -------------------------(Begin-PrimaryDefinition)------------------------'
                DO_IDENTIFIER SystemID, LocationID;
                SystemID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.SystemID, Issuer = "MOHME_IT", Type = "System_ID" };
                LocationID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.LocationID, Issuer = "MOHME_IT", Type = "Org_ID" };
                // -------------------------(End-PrimaryDefinition)------------------------'
                // -------------------------(Begin-MsgID)------------------------'
                if (MedicationPrescriptionsMessage == null)
                    throw new Exception("Object is null.");
                if (MedicationPrescriptionsMessage.MsgID == null)
                    throw new Exception("MsgID is null.");
                MedicationPrescriptionsMessage.MsgID.HealthCareFacilityID = LocationID;
                MedicationPrescriptionsMessage.MsgID.SystemID = SystemID;
                // -------------------------(End-MsgID)------------------------'
                ResultVO result;
                Crypto sec = new Crypto();
                byte[] b;
                b = sec.SecuredObject(MedicationPrescriptionsMessage);
                var secureRequest = new WCF_MedicationPrescriptionService.SaveMedicationPrescriptionSecureRequest
                {
                    data = b,
                    HeaderMessageVO = ServiceModelMapper.ToServiceHeader<WCF_MedicationPrescriptionService.HeaderMessageVO>(headerMessageVOValue)
                };
                var response = srv.SaveMedicationPrescriptionSecure(secureRequest);
                result = ClientModelMapper.ToClientResponse<ResultVO, WCF_MedicationPrescriptionService.ResultVO>(response.SaveMedicationPrescriptionSecureResult);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(MainFx.CreateException("SaveMedicationPrescription", ex));
            }
        }
        /// <summary>
        ///          This method is designed to send the pathology reports. The pathology reports are for malignant and benign specimen.
        ///          </summary>
        ///          <param name="PathologyReport">The argument is of type LaboratoryResultMessageVO. Only pathology results are allowed to to be exchanged by this method.</param>
        ///          <returns>The method returns an object of type ResultVO. ResultVO models the response of SEPAS nodes either successful or unsuccessful.</returns>
        public ResultVO SavePathologyReport(LaboratoryResultMessageVO PathologyReport)
        {
            try
            {
                DO_IDENTIFIER Location = GetHealthCareFacility();
                var url = ConfigurationManager.AppSettings["PathologyCaseReportServiceURL"];
                var srv = adaptorFactory.GetWebService<WCF_PathologyCaseReportService.PathologyCaseReportServiceSoapChannel>(url);

                //"/PathologyCaseReportService.asmx";
                // Dim v As New Variable
                var headerMessageVOValue = new HeaderMessageVO();
                headerMessageVOValue.Sender = new SystemSenderVO();
                headerMessageVOValue.Sender.SystemID = PathologyReport.MsgID.SystemID.ID;// VariableService.GetSystemID();
                headerMessageVOValue.Sender.LocationID = Location.ID;
                headerMessageVOValue.Sender.URL = "0";
                // -------------------------(Begin-PrimaryDefinition)------------------------'
                DO_IDENTIFIER SystemID, LocationID;
                SystemID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.SystemID, Issuer = "MOHME_IT", Type = "System_ID" };
                LocationID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.LocationID, Issuer = "MOHME_IT", Type = "Org_ID" };
                // -------------------------(End-PrimaryDefinition)------------------------'
                // -------------------------(Begin-MsgID)------------------------'
                if (PathologyReport == null)
                    throw new Exception("Object is null.");
                if (PathologyReport.MsgID == null)
                    throw new Exception("MsgID is null.");
                PathologyReport.MsgID.HealthCareFacilityID = LocationID;
                PathologyReport.MsgID.SystemID = SystemID;
                // -------------------------(End-MsgID)------------------------'
                ResultVO result;
                Crypto sec = new Crypto();
                byte[] b;
                b = sec.SecuredObject(PathologyReport);
                var secureRequest = new WCF_PathologyCaseReportService.SavePathologyReportSecureRequest
                {
                    data = b,
                    HeaderMessageVO = ServiceModelMapper.ToServiceHeader<WCF_PathologyCaseReportService.HeaderMessageVO>(headerMessageVOValue)
                };
                var response = srv.SavePathologyReportSecure(secureRequest);
                result = ClientModelMapper.ToClientResponse<ResultVO, WCF_PathologyCaseReportService.ResultVO>(response.SavePathologyReportSecureResult);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(MainFx.CreateException("SavePathologyReport", ex));
            }
        }
        /// <summary>
        ///          This method is used to exchange the patient that is referref from a primary healthcare facility for the secondary healthcare service to a specialist.
        ///          </summary>
        ///          <param name="ReferralCaseMessage">This argument specifies the patient's encunter to the primary healthcare facilities from which the patient is being referred.</param>
        ///          <returns>The method returns an object of type ResultVO. ResultVO models the response of SEPAS nodes either successful or unsuccessful.</returns>
        public ResultVO ReferPatientRecord(ReferralCaseMessageVO ReferralCaseMessage)
        {
            try
            {
                DO_IDENTIFIER Location = GetHealthCareFacility();
                var url = ConfigurationManager.AppSettings["ReferralCaseServiceURL"];
                var srv = adaptorFactory.GetWebService<WCF_ReferralCaseService.ReferralCaseServiceSoapChannel>(url);

                // "/ReferralCaseService.asmx";
                // Dim v As New Variable
                var headerMessageVOValue = new HeaderMessageVO();
                headerMessageVOValue.Sender = new SystemSenderVO();
                headerMessageVOValue.Sender.SystemID = VariableService.GetSystemID();
                headerMessageVOValue.Sender.LocationID = Location.ID;
                headerMessageVOValue.Sender.URL = "0";
                // -------------------------(Begin-PrimaryDefinition)------------------------'
                DO_IDENTIFIER SystemID, LocationID;
                SystemID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.SystemID, Issuer = "MOHME_IT", Type = "System_ID" };
                LocationID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.LocationID, Issuer = "MOHME_IT", Type = "Org_ID" };
                // -------------------------(End-PrimaryDefinition)------------------------'
                // -------------------------(Begin-MsgID)------------------------'
                if (ReferralCaseMessage == null)
                    throw new Exception("Object is null.");
                if (ReferralCaseMessage.MsgID == null)
                    throw new Exception("MsgID is null.");
                ReferralCaseMessage.MsgID.HealthCareFacilityID = LocationID;
                ReferralCaseMessage.MsgID.SystemID = SystemID;
                // -------------------------(End-MsgID)------------------------'
                Data Encrypt_SymmetricKeyStr = new Data();
                Data k = new Data(), iv = new Data();
                // -------------------------------------Generate HeaderMessage --------------------------------
                // -------------------------------------Generate HeaderMessage IP Temp --------------------------------
                IPHostEntry IPHost = Dns.GetHostEntry(Dns.GetHostName());
                headerMessageVOValue.Sender.IP = IPHost.AddressList[0].ToString(); // InternalIP
                // -------------------------------------Generate HeaderMessage IP Temp --------------------------------
                if (Configuration.Security_Mode == Configuration.SecurityMode.PowerSecurity)
                    headerMessageVOValue.Sender.URL = "http://ca.mohme.gov.ir/1/" + Encrypt_SymmetricKeyStr.ToBase64();
                // -------------------------------------Generate HeaderMessage --------------------------------
                // -------------------------------------Encrypt Message--------------------------------
                byte[] b;
                SimpleSecureShell ssl = new SimpleSecureShell();
                b = ssl.Dastine(ReferralCaseMessage);
                // -------------------------------------Encrypt Message--------------------------------
                // -------------------------------------Send Message to SEPAS if needed--------------------------------
                var secureRequest = new WCF_ReferralCaseService.SaveReferralCaseSecureRequest
                {
                    data = b,
                    HeaderMessageVO = ServiceModelMapper.ToServiceHeader<WCF_ReferralCaseService.HeaderMessageVO>(headerMessageVOValue)
                };
                var response = srv.SaveReferralCaseSecure(secureRequest);
                return ClientModelMapper.ToClientResponse<ResultVO, WCF_ReferralCaseService.ResultVO>(response.SaveReferralCaseSecureResult);
            }
            // -------------------------------------Send Message to SEPAS if needed--------------------------------
            catch (Exception ex)
            {
                throw new Exception(MainFx.CreateException("ReferPatientRecord", ex));
            }
        }
        /// <summary>
        ///          This method is used to submit the feedback of the healthcare provider regarding the referred patient, so that the family physician of the patient could get informed if the patient is treated and what is goint to be the follow up plan.
        ///          </summary>
        ///          <param name="ReferralFeedbackMessage">In order to submit the feedback of the specialist, it is necessary to declare it in a correct format. the correct datatype for feedback is ReferralFeedbackMessageVO. The patinet's demographics, admission, insurance as well as the follow up plan is specified through this compound class.</ param >
        ///          <returns>The method returns an object of type ResultVO. ResultVO models the response of SEPAS nodes either successful or unsuccessful.</returns>
        public ResultVO SendFeedbackPatientRecord(ReferralFeedbackMessageVO ReferralFeedbackMessage)
        {
            try
            {
                DO_IDENTIFIER Location = GetHealthCareFacility();
                var url = ConfigurationManager.AppSettings["ReferralFeedbackServiceURL"];
                var srv = adaptorFactory.GetWebService<WCF_ReferralFeedbackService.ReferralFeedbackServiceSoapChannel>(url);
                //"/ReferralFeedbackService.asmx";
                // Dim v As New Variable
                var headerMessageVOValue = new HeaderMessageVO();
                headerMessageVOValue.Sender = new SystemSenderVO();
                headerMessageVOValue.Sender.SystemID = VariableService.GetSystemID();
                headerMessageVOValue.Sender.LocationID = Location.ID;
                headerMessageVOValue.Sender.URL = "0";
                // -------------------------(Begin-PrimaryDefinition)------------------------'
                DO_IDENTIFIER SystemID, LocationID;
                SystemID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.SystemID, Issuer = "MOHME_IT", Type = "System_ID" };
                LocationID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.LocationID, Issuer = "MOHME_IT", Type = "Org_ID" };
                // -------------------------(End-PrimaryDefinition)------------------------'
                // -------------------------(Begin-MsgID)------------------------'
                if (ReferralFeedbackMessage == null)
                    throw new Exception("Object is null.");
                if (ReferralFeedbackMessage.MsgID == null)
                    throw new Exception("MsgID is null.");
                ReferralFeedbackMessage.MsgID.HealthCareFacilityID = LocationID;
                ReferralFeedbackMessage.MsgID.SystemID = SystemID;
                // -------------------------(End-MsgID)------------------------'
                Data Encrypt_SymmetricKeyStr = new Data();
                Data k = new Data(), iv = new Data();
                // -------------------------------------Encrypt Message--------------------------------
                byte[] b;
                SimpleSecureShell ssl = new SimpleSecureShell();
                b = ssl.Dastine(ReferralFeedbackMessage);
                // -------------------------------------Encrypt Message--------------------------------
                // -------------------------------------Send Message to SEPAS if needed--------------------------------
                var secureRequest = new WCF_ReferralFeedbackService.SaveReferralFeedbackSecureRequest
                {
                    data = b,
                    HeaderMessageVO = ServiceModelMapper.ToServiceHeader<WCF_ReferralFeedbackService.HeaderMessageVO>(headerMessageVOValue)
                };
                var response = srv.SaveReferralFeedbackSecure(secureRequest);
                return ClientModelMapper.ToClientResponse<ResultVO, WCF_ReferralFeedbackService.ResultVO>(response.SaveReferralFeedbackSecureResult);
            }
            // -------------------------------------Send Message to SEPAS if needed--------------------------------
            catch (Exception ex)
            {
                throw new Exception(MainFx.CreateException("SendFeedbackRecord", ex));
            }
        }
        /// <summary>
        ///          This method is designed to save and exchange the clinical data regarding the patients' encounters.
        ///          </summary>
        ///          <param name="SOAPReport">This argument is to exchange the SOAP messages. SOAP stands for "Subjective Objective Assessment, Plan" which are the building blocks of the actions taken by clinical healthcare providers.</param>
        ///          <returns>The method returns an object of type ResultVO. ResultVO models the response of SEPAS nodes either successful or unsuccessful.</returns>
        public ResultVO SaveSOAPReport(SOAPMessageVO SOAPReport)
        {
            try
            {
                DO_IDENTIFIER Location = GetHealthCareFacility();
                var url = ConfigurationManager.AppSettings["SOAPServiceURL"];
                var srv = adaptorFactory.GetWebService<WCF_SOAPservice.SOAPServiceSoapChannel>(url);
                //"/SOAPService.asmx";
                // Dim v As New Variable
                var headerMessageVOValue = new HeaderMessageVO();
                headerMessageVOValue.Sender = new SystemSenderVO();
                headerMessageVOValue.Sender.SystemID = VariableService.GetSystemID();
                headerMessageVOValue.Sender.LocationID = Location.ID;
                headerMessageVOValue.Sender.URL = "0";
                // -------------------------(Begin-PrimaryDefinition)------------------------'
                DO_IDENTIFIER SystemID, LocationID;
                SystemID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.SystemID, Issuer = "MOHME_IT", Type = "System_ID" };
                LocationID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.LocationID, Issuer = "MOHME_IT", Type = "Org_ID" };
                // -------------------------(End-PrimaryDefinition)------------------------'
                // -------------------------(Begin-MsgID)------------------------'
                if (SOAPReport == null)
                    throw new Exception("Object is null.");
                if (SOAPReport.MsgID == null)
                    throw new Exception("MsgID is null.");
                SOAPReport.MsgID.HealthCareFacilityID = LocationID;
                SOAPReport.MsgID.SystemID = SystemID;
                // -------------------------(End-MsgID)------------------------'
                ResultVO result;
                Crypto sec = new Crypto();
                byte[] b;
                b = sec.SecuredObject(SOAPReport);
                var secureRequest = new WCF_SOAPservice.SaveSOAPReportSecureRequest
                {
                    data = b,
                    HeaderMessageVO = ServiceModelMapper.ToServiceHeader<WCF_SOAPservice.HeaderMessageVO>(headerMessageVOValue)
                };
                var response = srv.SaveSOAPReportSecure(secureRequest);
                result = ClientModelMapper.ToClientResponse<ResultVO, WCF_SOAPservice.ResultVO>(response.SaveSOAPReportSecureResult);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(MainFx.CreateException("SaveSOAPReportSecure", ex));
            }
        }

        #region NotUsed
        //public bool CancerInquiry(DO_IDENTIFIER PersonID)
        //{
        //    string MethodName = "CancerInquiry";
        //    var url = ConfigurationManager.AppSettings["SIYABWebServiceURL"];
        //    //var url = Urls.URL_MOHMEService();
        //    var Srv = adaptorFactory.GetWebService<WCF_SIYABService.SIYABServiceSoapChannel>(url);
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        GeneralResponseMessageVO r;
        //        r = Srv.CancerInquiry_T2(PersonID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to get the updates of specific terminolgy from a baseline date.        
        /////          </summary>        
        /////          <param name="Terminology">This argument specifies the terminology. This argument is of type String.</param>        
        /////          <param name="FromDate">This argument specifies the baseline date. This argument is of type DO_DATE_TIME.</param>        
        /////          <returns>The method returns an array of triple code, value, and terminology as DO_CODED_TEXT.</returns>
        //public DO_CODED_TEXT[] SearchTerminology(string Terminology, DO_DATE_TIME FromDate)
        //{
        //    string MethodName = "SearchTerminology";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.MOHME.MOHMEServicesT2 Srv = new ClientWebService.MOHME.MOHMEServicesT2();  // Service Define
        //        Srv.Url = Urls.URL_MOHMEService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        GeneralResponseMessageVO r;
        //        r = Srv.SearchTerminology_T2(Terminology, FromDate); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to get the value of a code for a specified terminology.        
        /////          </summary>        
        /////          <param name="Terminology">This argument specifies the terminology. This argument is of type String.</param>        
        /////          <param name="Code">This argument specifies the code in the specified terminology. This argument is of type String.</param>        
        /////          <returns>The method returns the value of the code as a String.</returns>
        //public string GetTerminologyValue(string Terminology, string Code)
        //{
        //    string MethodName = "GetTerminologyValue";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.MOHME.MOHMEServicesT2 Srv = new ClientWebService.MOHME.MOHMEServicesT2();  // Service Define
        //        Srv.Url = Urls.URL_MOHMEService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        GeneralResponseMessageVO r;
        //        r = Srv.GetTerminologyValue_T2(Terminology, Code); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        //public bool ValidateCode(DO_CODED_TEXT CodedText)
        //{
        //    string MethodName = "ValidateCode";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.MOHME.MOHMEServicesT2 Srv = new ClientWebService.MOHME.MOHMEServicesT2();  // Service Define
        //        Srv.Url = Urls.URL_MOHMEService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        GeneralResponseMessageVO r;
        //        r = Srv.ValidateCTS_T2(CodedText); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to get the list of updated terminologies since a specific date.        
        /////          </summary>        
        /////          <param name="FromDate">This argument specifies the date from which the inquiry should be executed. This argument is of type DO_DATE_TIME.</param>        
        /////          <returns>The method returns the list of treminolgies as an array of DO_IDENTIFIERs.</returns>
        //public string[] GetTerminologies(DO_DATE_TIME FromDate)
        //{
        //    string MethodName = "GetTerminologies";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.MOHME.MOHMEServicesT2 Srv = new ClientWebService.MOHME.MOHMEServicesT2();  // Service Define
        //        Srv.Url = Urls.URL_MOHMEService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        GeneralResponseMessageVO r;
        //        r = Srv.GetTerminologies_T2(FromDate); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to get the educational degree information of the grauduated students for the medical universities.
        /////          </summary>        
        /////          <param name="PersonID">This argument specifies the identifier of the person. This argument is of type DO_IDENTIFIER.</param>        
        /////          <returns>The detailed degree information is returned in terms of EducationGeneralInfoVO.</returns>
        //public EducationGeneralInfoVO[] GetEducationDegreeInfo(DO_IDENTIFIER PersonID)
        //{
        //    string MethodName = "GetEducationDegreeInfo";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.MOHME.MOHMEServicesT2 Srv = new ClientWebService.MOHME.MOHMEServicesT2();  // Service Define
        //        Srv.Url = Urls.URL_MOHMEService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        GeneralResponseMessageVO r;
        //        r = Srv.GetEducationDegreeInfo_T2(PersonID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to get the graduated students information by the person identifier.        
        /////          </summary>        
        /////          <param name="PersonID">This argument specifies the person unique identifier i.e. national code. This argument is of type DO_IDENTIFIER.</param>        
        /////          <param name="EducationLevel">This argument specifies the education levele of the person. This argument is of type DO_IDENTIFIER.</param>
        /////          <returns>The method returns the detailed information as a EducationGeneralInfoVO.</returns>
        //public EducationGeneralInfoVO[] GetGraduateInfo(DO_IDENTIFIER PersonID, DO_CODED_TEXT EducationLevel)
        //{
        //    string MethodName = "GetGraduateInfo";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.MOHME.MOHMEServicesT2 Srv = new ClientWebService.MOHME.MOHMEServicesT2();   // Service Define
        //        Srv.Url = Urls.URL_MOHMEService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        GeneralResponseMessageVO r;
        //        r = Srv.GetGraduateInfo_T2(PersonID, EducationLevel); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        //public bool CheckIsGraduate(DO_IDENTIFIER PersonID, DO_IDENTIFIER UniversityID, DO_CODED_TEXT EducationLevel, DO_CODED_TEXT EducationField)
        //{
        //    string MethodName = "CheckIsGraduate";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.MOHME.MOHMEServicesT2 Srv = new ClientWebService.MOHME.MOHMEServicesT2();   // Service Define
        //        Srv.Url = Urls.URL_MOHMEService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        GeneralResponseMessageVO r;
        //        r = Srv.CheckIsGraduate_T2(PersonID, UniversityID, EducationLevel, EducationField); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to get enrollmenet confirmation enquiries and returns the education info of the person.        
        /////          </summary>        
        /////          <param name="PersonID">This argument specifies person indentifier i.e. national code. This argument is of type DO_IDENTIFIER.</param>        
        /////          <returns>The method returns the education information of the person in trems of EducationGeneralInfoVO.</returns>
        //public EducationGeneralInfoVO[] GetEnrollmentConfirmationInfo(DO_IDENTIFIER PersonID)
        //{
        //    string MethodName = "GetEnrollmentConfirmationInfo";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.MOHME.MOHMEServicesT2 Srv = new ClientWebService.MOHME.MOHMEServicesT2();   // Service Define
        //        Srv.Url = Urls.URL_MOHMEService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        GeneralResponseMessageVO r;
        //        r = Srv.GetEnrollmentConfirmationInfo_T2(PersonID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is used to get the healthcare provider info, based on the healthcare provider ID.
        /////          </summary>
        /////          <remarks>This method requests the information from the Medical Council data repository thus the data is exactly represented as Medical Council responds to the requests.</remarks>
        /////          <param name="ProviderID">The argument to this method is the identifier of the healthcare provider. The healthcare provider identifier is RWI (Real World Identifier) and the data type is DO_IDENTIFIER.</param>
        /////          <returns>This method returns the healthcare provider information. The data type is HealthcareProviderVO.</returns>
        //public HealthcareProviderVO GetHealthCareProviderInfo(DO_IDENTIFIER ProviderID)
        //{
        //    string MethodName = "GetHealthCareProviderInfo";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.MOHME.MOHMEServicesT2 Srv = new ClientWebService.MOHME.MOHMEServicesT2();   // Service Define
        //        Srv.Url = Urls.URL_MOHMEService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (ProviderID == null)
        //                throw new Exception("Argument is missing.");
        //            if (ProviderID.Type != "")
        //            {
        //                if (ProviderID.Type.ToUpper == "National_Code".ToUpper())
        //                    MainFx.CheckNationalCode(ProviderID.ID);
        //            }
        //            if (ProviderID == null)
        //                throw new Exception("Argument is missing.");
        //            if (Healthcarefacility == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetHealthCareProviderInfo_T2(ProviderID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method retrieves the information regarding pharmaceutical products by their IRCs.
        /////          </summary>
        /////          <param name="DrugIRC">This argument specifies the IRC code in DO_CODED_TEXT format.</param>
        /////          <returns>This method returns the information as DrugInfoVO format.</returns>
        //public DrugInfoVO GetDrugInfoByIRC(string DrugIRC)
        //{
        //    string MethodName = "GetDrugInfoByIRC";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.MOHME.MOHMEServicesT2 Srv = new ClientWebService.MOHME.MOHMEServicesT2(); // Service Define
        //        Srv.Url = Urls.URL_MOHMEService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetDrugInfoByIRC_T2(DrugIRC); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method retrieves the medical equipment information by IRC.
        /////          </summary>
        /////          <param name="EquipmentIRC">The argument of the method is to specify the IRC code of the medical equipment in DO_CODED_TEXT.</param>
        /////          <returns>This method returns the medical equipment details as EquipmentInfoVO class.</returns>
        //public EquipmentInfoVO GetEquipmentInfoByIRC(string EquipmentIRC)
        //{
        //    string MethodName = "GetEquipmentInfoByIRC";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.MOHME.MOHMEServicesT2 Srv = new ClientWebService.MOHME.MOHMEServicesT2(); // Service Define
        //        Srv.Url = Urls.URL_MOHMEService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetEquipmentInfoByIRC_T2(EquipmentIRC); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        //public bool CheckSIMCardOwner(DO_IDENTIFIER PersonID, string MobileNumber)
        //{
        //    string MethodName = "CheckSIMCardOwner";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.NIX.NIXServicesT2 Srv = new ClientWebService.NIX.NIXServicesT2();  // Service Define
        //        Srv.Url = Urls.URL_NIXService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        GeneralResponseMessageVO r;
        //        r = Srv.CheckSIMCardOwner_T2(PersonID, MobileNumber); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        //public bool CheckSIMCardOwner(string NationalCode, string MobileNumber)
        //{
        //    string MethodName = "CheckSIMCardOwner";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.NIX.NIXServicesT2 Srv = new ClientWebService.NIX.NIXServicesT2();  // Service Define
        //        Srv.Url = Urls.URL_NIXService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER PersonID = new DO_IDENTIFIER() { ID = NationalCode, Assigner = "National_Org_Civil_Reg", Issuer = "National_Org_Civil_Reg", Type = "National_Code" };
        //        r = Srv.CheckSIMCardOwner_T2(PersonID, MobileNumber); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to get the address of the geographical locations by their corresponding postal code.        
        /////          </summary>        
        /////          <param name="PostalCode">This argument specifies the postal code of the geographical location. This argument is of type String.</param>        
        /////          <returns> This method returns the address details of the location as PostalAddressVO class. </returns>
        //public PostalAddressVO GetAddressByPostalCode(string PostalCode)
        //{
        //    string MethodName = "GetAddressByPostalCode";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.NIX.NIXServicesT2 Srv = new ClientWebService.NIX.NIXServicesT2();  // Service Define
        //        Srv.Url = Urls.URL_NIXService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetAddressByPostalCode_T2(PostalCode); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to get the image of the person by national code.        
        /////          </summary>        
        /////          <param name="NationalCode">This argument specifies the person identifier as national code. This argument is of type String.</param>        
        /////          <param name="Serial">This argument specifies the serial number of the person SSID Card. This argument is of type String.</param>        
        /////          <returns>Image data as an array of Byte.</returns>
        //public byte[] GetImageByNationalCode(string NationalCode, string Serial)
        //{
        //    string MethodName = "GetImageByNationalCode";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.NIX.NIXServicesT2 Srv = new ClientWebService.NIX.NIXServicesT2();  // Service Define
        //        Srv.Url = Urls.URL_NIXService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetImageByNationalCode_T2(NationalCode, Serial); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        //public GeographicalCoordinatesVO GetLocationByPostalCode(string PostalCode)
        //{
        //    string MethodName = "GetLocationByPostalCode";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.NIX.NIXServicesT2 Srv = new ClientWebService.NIX.NIXServicesT2();  // Service Define
        //        Srv.Url = Urls.URL_NIXService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetLocationByPostalCode_T2(PostalCode); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to get the location of the person by mobile number.        
        /////          </summary>        
        /////          <param name="MobileNumber">This argument specifies the mobile number of the person. This argument is of type String.</param>        
        /////          <returns>The method returns the location of the person as a MobileLocationVO.</returns>
        //public MobileLocationVO GetMobileLocationInfo(string MobileNumber)
        //{
        //    string MethodName = "GetMobileLocationInfo";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.NIX.NIXServicesT2 Srv = new ClientWebService.NIX.NIXServicesT2();  // Service Define
        //        Srv.Url = Urls.URL_NIXService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetMobileLocationInfo_T2(MobileNumber); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to get the address by phone number.
        /////          </summary>        
        /////          <param name="PhoneNumber">This argument specifies the phone number. This argument is of type String.</param>        
        /////          <returns>The method returns the address details as a PhoneAddressVO.</returns>
        //public PhoneAddressVO GetPhoneAddress(string PhoneNumber)
        //{
        //    string MethodName = "GetPhoneAddress";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.NIX.NIXServicesT2 Srv = new ClientWebService.NIX.NIXServicesT2();  // Service Define
        //        Srv.Url = Urls.URL_NIXService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetPhoneAddress_T2(PhoneNumber); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to get the identities of the legal entities.        
        /////          </summary>        
        /////          <param name="NationalCode">This argument specifies the national code of the legal entities. This argument is of type String.</param>        
        /////          <returns>The method returns the detailed information of the legal entities as a LegalPersonInfoVO.</returns>
        //public LegalPersonInfoVO GetLegalPersonInfoByNationalCode(string NationalCode)
        //{
        //    string MethodName = "GetLegalPersonInfoByNationalCode";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.NIX.NIXServicesT2 Srv = new ClientWebService.NIX.NIXServicesT2(); // Service Define
        //        Srv.Url = Urls.URL_NIXService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        GeneralResponseMessageVO r;
        //        r = Srv.GetLegalPersonInfoByNationalCode_T2(NationalCode); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to get the veteran information by person national code.        
        /////          </summary>        
        /////          <param name="NationalCode">This argument specifies the national code of the person. This argument is of type String.</param>        
        /////          <returns>The detailed information of the veteran as a VeteranGeneralInfoVO.</returns>
        //public VeteranGeneralInfoVO GetVeteranGeneralInfoByNationalCode(string NationalCode)
        //{
        //    string MethodName = "GetVeteranGeneralInfoByNationalCode";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.NIX.NIXServicesT2 Srv = new ClientWebService.NIX.NIXServicesT2();  // Service Define
        //        Srv.Url = Urls.URL_NIXService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetVeteranGeneralInfoByNationalCode_T2(NationalCode); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to get the veteran info by national code.        
        /////          </summary>        
        /////          <param name="NationalCode">This argument specifies the person national code. This argument is of type String.</param>        
        /////          <returns>The information of the veteran as a VeteranInfoVO.</returns>
        //public VeteranInfoVO GetVeteranInfoByNationalCode(string NationalCode)
        //{
        //    string MethodName = "GetVeteranInfoByNationalCode";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.NIX.NIXServicesT2 Srv = new ClientWebService.NIX.NIXServicesT2();  // Service Define
        //        Srv.Url = Urls.URL_NIXService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetVeteranInfoByNationalCode_T2(NationalCode); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is used to retrieve the demographic information of the patient by national code and birth year.
        /////          </summary>
        /////          <param name="NationalCode">The national code of the person is mentioned through this argument in string format.</param>
        /////          <param name="BirthYear">The birth year is specified through this argument in integer format.</param>
        /////          <returns>The demographic information is returned in PersonVO class.</returns>
        //public PersonVO GetPersonByBirth(string NationalCode, int BirthYear)
        //{
        //    string MethodName = "GetPersonByBirth";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.PMI.ServiceT2 Srv = new ClientWebService.PMI.ServiceT2(); // Service Define
        //        Srv.Url = Urls.URL_PMIService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetPersonByBirth_MC_T2(Healthcarefacility, NationalCode, BirthYear); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to verify the person info with NOCR data.        
        /////          </summary>        
        /////          <param name="NationalCode">This argument specifies person national code. This argument is of type String.</param>        
        /////          <param name="FirstName">This argument specifies the first name of the person. This argument is of type String.</param>        
        /////          <param name="LastName">This argument specifies the last name of the person. This argument is of type String.</param>  
        /////          <param name="BirthYear">This argument specifies the birth year of the person. This argument is of type Integer.</param>        
        /////          <returns>The method returns boolean indicating either the transaction was successful or not.</returns>
        //public bool VerifyPersonInfo(string NationalCode, string FirstName, string LastName, int BirthYear)
        //{
        //    string MethodName = "VerifyPersonInfo";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.PMI.ServiceT2 Srv = new ClientWebService.PMI.ServiceT2(); // Service Define
        //        Srv.Url = Urls.URL_PMIService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.VerifyPersonInfo_T2(NationalCode, FirstName, LastName, BirthYear); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is to get the Insurance info regarding any patient.
        /////          </summary>
        /////          <remarks>The array of the patient's data is returned based on the input arguments if the patient deserves to receive the healthcare service and the provider is eligible to provide the healthcare service, too.</remarks>
        /////          <param name="PersonID">This argument is designed to specify the Patient's unique identifier. This identifier should be a Real World Identifier (RWI). National code is among the most common identifiers. RWIs are technically defined with DO_IDENTIFIER data type.</param>
        /////          <param name="ProviderID">This arguement is to specify the heathcare provider ID. The provider ID must be declared in DO_IDENTIFIER format.</param>
        /////          <returns>It returns an array of patient's Insurance data, i.e. basic and complementary.</returns>
        //public InsuranceInquiryVO[] CallupInsurance(DO_IDENTIFIER PersonID, DO_IDENTIFIER ProviderID)
        //{
        //    string MethodName = "CallupInsurance";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.InsuranceGate.InsuranceGateT2 Srv = new ClientWebService.InsuranceGate.InsuranceGateT2(); // Service Define
        //        Srv.Url = Urls.URL_InsuranceGateService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (PersonID == null)
        //                throw new Exception("Argument is missing.");
        //            if (PersonID.Type != "")
        //            {
        //                if (PersonID.Type.ToUpper == "National_Code".ToUpper())
        //                    MainFx.CheckNationalCode(PersonID.ID);
        //            }
        //            if (ProviderID == null)
        //                throw new Exception("Argument is missing.");
        //            if (Healthcarefacility == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.CallupInsurance_T2(Healthcarefacility, PersonID, ProviderID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is to get the Insurance info regarding any patient.
        /////          </summary>
        /////          <remarks>The array of the patient's data is returned based on the input arguments if the patient deserves to receive the healthcare service and the provider is eligible to provide the healthcare service, too.</remarks>
        /////          <param name="NationalCode">This arguement is to specify the nationalcode of the patient in string format.</param>
        /////          <param name="ProviderID">This arguement is to specify the heathcare provider ID. The provider ID must be declared in DO_IDENTIFIER format.</param>
        /////          <returns>It returns an array of patient's Insurance data, i.e. basic and complementary.</returns>
        //public InsuranceInquiryVO[] CallupInsurance(string NationalCode, DO_IDENTIFIER ProviderID)
        //{
        //    string MethodName = "CallupInsurance";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.InsuranceGate.InsuranceGateT2 Srv = new ClientWebService.InsuranceGate.InsuranceGateT2(); // Service Define
        //        Srv.Url = Urls.URL_InsuranceGateService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (NationalCode == "")
        //                throw new Exception("Argument is missing.");
        //            MainFx.CheckNationalCode(NationalCode);
        //            if (ProviderID == null)
        //                throw new Exception("Argument is missing.");
        //            if (Healthcarefacility == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        DO_IDENTIFIER PersonID = new DO_IDENTIFIER() { ID = NationalCode, Assigner = "National_Org_Civil_Reg", Issuer = "National_Org_Civil_Reg", Type = "National_Code" };
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.CallupInsurance_T2(Healthcarefacility, PersonID, ProviderID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is used to generate HID for a patient's encounter. This method can be used for both the inpatient and outpatient encounters.
        /////          </summary>
        /////          <param name="NationalCode">This argument specifies the patient's national code. the data type is in string format.</param>
        /////          <param name="HealthCareProvider">The argument to this method is the identifier of the healthcare provider. The healthcare provider identifier is RWI (Real World Identifier) and the data type is DO_IDENTIFIER.</param>
        /////          <param name="Insurer">The first argument to this method is to specify the insurer type in DO_CODED_TEXT format. The coding is available on http://coding.behdasht.gov.ir . The terminology is thritaEHR.insurer</param>
        /////          <param name="ReferralID">This property is used to for the referred patients. If the patient has encountered a healthcare facility by referral system, it is mandatory to specify the referralID of the patient.</param>
        /////          <returns>The method returns a Health Tracking ID called HID and the data type is DO_IDENTIFIER.</returns>
        //public DO_IDENTIFIER GetHIDurgent(string NationalCode, DO_IDENTIFIER HealthCareProvider, DO_CODED_TEXT Insurer, DO_IDENTIFIER ReferralID)
        //{
        //    string MethodName = "GetHIDurgent";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.InsuranceGate.InsuranceGateT2 Srv = new ClientWebService.InsuranceGate.InsuranceGateT2(); // Service Define
        //        Srv.Url = Urls.URL_InsuranceGateService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (NationalCode == "")
        //                throw new Exception("Argument is missing.");
        //            MainFx.CheckNationalCode(NationalCode);
        //            if (HealthCareProvider == null)
        //                throw new Exception("Argument is missing.");
        //            if (Healthcarefacility == null)
        //                throw new Exception("Argument is missing.");
        //            if (Insurer == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        DO_IDENTIFIER PersonID = new DO_IDENTIFIER() { ID = NationalCode, Assigner = "National_Org_Civil_Reg", Issuer = "National_Org_Civil_Reg", Type = "National_Code" };
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetHIDurgent_T2(Healthcarefacility, PersonID, HealthCareProvider, Insurer, ReferralID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is used to generate HID for a patient's encounter. This method can be used for both the inpatient and outpatient encounters.
        /////          </summary>
        /////          <param name="PersonID">This argument is designed to specify the Patient's unique identifier. This identifier should be a Real World Identifier (RWI). National code is among the most common identifiers. RWIs are technically defined with DO_IDENTIFIER data type.</param>
        /////          <param name="HealthCareProvider">The argument to this method is the identifier of the healthcare provider. The healthcare provider identifier is RWI (Real World Identifier) and the data type is DO_IDENTIFIER.</param>
        /////          <param name="Insurer">The first argument to this method is to specify the insurer type in DO_CODED_TEXT format. The coding is available on http://coding.behdasht.gov.ir . The terminology is thritaEHR.insurer</param>
        /////          <param name="ReferralID">This property is used to for the referred patients. If the patient has encountered a healthcare facility by referral system, it is mandatory to specify the referralID of the patient.</param>
        /////          <returns>The method returns a Health Tracking ID called HID and the data type is DO_IDENTIFIER.</returns>
        //public DO_IDENTIFIER GetHIDurgent(DO_IDENTIFIER PersonID, DO_IDENTIFIER HealthCareProvider, DO_CODED_TEXT Insurer, DO_IDENTIFIER ReferralID)
        //{
        //    string MethodName = "GetHIDurgent";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.InsuranceGate.InsuranceGateT2 Srv = new ClientWebService.InsuranceGate.InsuranceGateT2(); // Service Define
        //        Srv.Url = Urls.URL_InsuranceGateService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (PersonID == null)
        //                throw new Exception("Argument is missing.");
        //            if (PersonID.Type != "")
        //            {
        //                if (PersonID.Type.ToUpper == "National_Code".ToUpper())
        //                    MainFx.CheckNationalCode(PersonID.ID);
        //            }
        //            if (HealthCareProvider == null)
        //                throw new Exception("Argument is missing.");
        //            if (Healthcarefacility == null)
        //                throw new Exception("Argument is missing.");
        //            if (Insurer == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetHIDurgent_T2(Healthcarefacility, PersonID, HealthCareProvider, Insurer, ReferralID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is used to generate HID for a patient's encounter. This method can be used for both the inpatient and outpatient encounters.
        /////          </summary>
        /////          <param name="NationalCode">This argument specifies the patient's national code. the data type is in string format.</param>
        /////          <param name="HealthCareProvider">The argument to this method is the identifier of the healthcare provider. The healthcare provider identifier is RWI (Real World Identifier) and the data type is DO_IDENTIFIER.</param>
        /////          <param name="Insurer">The first argument to this method is to specify the insurer type in DO_CODED_TEXT format. The coding is available on http://coding.behdasht.gov.ir . The terminology is thritaEHR.insurer</param>
        /////          <param name="InquiryID">The inquiryID is the property that is returned by the callupinsurance method. the data type is string.</param>
        /////          <param name="ReferralID">This property is used to for the referred patients. If the patient has encountered a healthcare facility by referral system, it is mandatory to specify the referralID of the patient.</param>
        /////          <returns>The method returns a Health Tracking ID called HID and the data type is DO_IDENTIFIER.</returns>
        //public DO_IDENTIFIER GetHID(string NationalCode, DO_IDENTIFIER HealthCareProvider, DO_CODED_TEXT Insurer, string InquiryID, DO_IDENTIFIER ReferralID)
        //{
        //    string MethodName = "GetHID";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.InsuranceGate.InsuranceGateT2 Srv = new ClientWebService.InsuranceGate.InsuranceGateT2(); // Service Define
        //        Srv.Url = Urls.URL_InsuranceGateService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (NationalCode == "")
        //                throw new Exception("Argument is missing.");
        //            MainFx.CheckNationalCode(NationalCode);
        //            if (HealthCareProvider == null)
        //                throw new Exception("Argument is missing.");
        //            if (Healthcarefacility == null)
        //                throw new Exception("Argument is missing.");
        //            if (Insurer == null)
        //                throw new Exception("Argument is missing.");
        //            if (InquiryID == "")
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        DO_IDENTIFIER PersonID = new DO_IDENTIFIER() { ID = NationalCode, Assigner = "National_Org_Civil_Reg", Issuer = "National_Org_Civil_Reg", Type = "National_Code" };
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetHID_T2(Healthcarefacility, PersonID, HealthCareProvider, Insurer, InquiryID, ReferralID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is used to generate HID for a patient's encounter. This method can be used for both the inpatient and outpatient encounters.
        /////          </summary>
        /////          <param name="PersonID">This argument is designed to specify the Patient's unique identifier. This identifier should be a Real World Identifier (RWI). National code is among the most common identifiers. RWIs are technically defined with DO_IDENTIFIER data type.</param>
        /////          <param name="HealthCareProvider">The argument to this method is the identifier of the healthcare provider. The healthcare provider identifier is RWI (Real World Identifier) and the data type is DO_IDENTIFIER.</param>
        /////          <param name="Insurer">The first argument to this method is to specify the insurer type in DO_CODED_TEXT format. The coding is available on http://coding.behdasht.gov.ir . The terminology is thritaEHR.insurer</param>
        /////          <param name="InquiryID">The inquiryID is the property that is returned by the callupinsurance method. the data type is string.</param>
        /////          <param name="ReferralID">This property is used to for the referred patients. If the patient has encountered a healthcare facility by referral system, it is mandatory to specify the referralID of the patient.</param>
        /////          <returns>The method returns a Health Tracking ID called HID and the data type is DO_IDENTIFIER.</returns>
        //public DO_IDENTIFIER GetHID(DO_IDENTIFIER PersonID, DO_IDENTIFIER HealthCareProvider, DO_CODED_TEXT Insurer, string InquiryID, DO_IDENTIFIER ReferralID)
        //{
        //    string MethodName = "GetHID";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.InsuranceGate.InsuranceGateT2 Srv = new ClientWebService.InsuranceGate.InsuranceGateT2(); // Service Define
        //        Srv.Url = Urls.URL_InsuranceGateService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (PersonID == null)
        //                throw new Exception("Argument is missing.");
        //            if (PersonID.Type != "")
        //            {
        //                if (PersonID.Type.ToUpper == "National_Code".ToUpper())
        //                    MainFx.CheckNationalCode(PersonID.ID);
        //            }
        //            if (HealthCareProvider == null)
        //                throw new Exception("Argument is missing.");
        //            if (Healthcarefacility == null)
        //                throw new Exception("Argument is missing.");
        //            if (Insurer == null)
        //                throw new Exception("Argument is missing.");
        //            if (InquiryID == "")
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetHID_T2(Healthcarefacility, PersonID, HealthCareProvider, Insurer, InquiryID, ReferralID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to send the health insurance claim analysis.        
        /////          </summary>        
        /////          <param name="PatientBill">This argument specifies the billing information regarding the patient encounter. This argument is of type PatientBillMessageVO.</param>        
        /////          <param name="InquiryState">This argument specifies the Inquiry state. This argument is of type DO_CODED_TEXT.</param>        
        /////          <returns>Identifier of the analysis result as a HealthInsuranceClaimIdentifierVO.</returns>
        //public HealthInsuranceClaimIdentifierVO SendHealthInsuranceClaim(PatientBillMessageVO PatientBill, DO_CODED_TEXT InquiryState)
        //{
        //    string MethodName = "SendHealthInsuranceClaim";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.HICA.ServiceT2 Srv = new ClientWebService.HICA.ServiceT2(); // Service Define
        //        Srv.Url = Urls.URL_HICAService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (PatientBill == null)
        //                throw new Exception("Argument is missing.");
        //            if (Healthcarefacility == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        byte[] Data;
        //        Crypto sec = new Crypto();
        //        Data = sec.SecuredObject(PatientBill);
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.SendHealthInsuranceClaimSecure_T2(Data, InquiryState); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        //public InsuranceCoverageVO GetHealthInsuranceClaimAnalysis(string ID)
        //{
        //    string MethodName = "GetHealthInsuranceClaimAnalysis";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.HICA.ServiceT2 Srv = new ClientWebService.HICA.ServiceT2(); // Service Define
        //        Srv.Url = Urls.URL_HICAService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (ID == null)
        //                throw new Exception("Argument is missing.");
        //            if (Healthcarefacility == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetHealthInsuranceClaimAnalysis_T2(ID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is used to generate a list of batch HIDs as reserved HIDs to be used when the Insurance Services are not available.
        /////          </summary>
        /////          <param name="Insurer">The first argument to this method is to specify the insurer type in DO_CODED_TEXT format. The coding is available on http://coding.behdasht.gov.ir . The terminology is thritaEHR.insurer</param>
        /////          <param name="Count">The number of the required reserved HIDs is specified through this argument.</param>
        /////          <returns>The output is a list of reserved HIDs. The datatype to this object is ReserveHIDlistVO</returns>
        //public ReserveHIDlistVO GenerateBatchHID(DO_CODED_TEXT Insurer, int Count)
        //{
        //    string MethodName = "GenerateBatchHID";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.InsuranceGate.InsuranceGateT2 Srv = new ClientWebService.InsuranceGate.InsuranceGateT2(); // Service Define
        //        Srv.Url = Urls.URL_InsuranceGateService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (Healthcarefacility == null)
        //                throw new Exception("Argument is missing.");
        //            if (Insurer == null)
        //                throw new Exception("Argument is missing.");
        //            if (Count < 1)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GenerateBatchHID_T2(Healthcarefacility, Insurer, Count); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is used to update the HID. It is used in case a reserved HID is used previously for a patinet encounter and thus it is necessary to update that HID to get confirmations.
        /////          </summary>
        /////          <param name="HID">Specifies the HID that requires update. The data type is DO_IDENTIFIER.</param>
        /////          <param name="nationalCode">This argument specifies the patient's national code. the data type is in string format.</param>
        /////          <param name="HealthCareProvider">The argument to this method is the identifier of the healthcare provider. The healthcare provider identifier is RWI (Real World Identifier) and the data type is DO_IDENTIFIER.</param>
        /////          <param name="Insurer">one of the arguments to this method is to specify the insurer type in DO_CODED_TEXT format. The coding is available on http://coding.behdasht.gov.ir . The terminology is thritaEHR.insurer</param>
        /////          <returns>The method returns boolean which indicates if the process was successful.</returns>
        //public bool UpdateHID(DO_IDENTIFIER HID, string nationalCode, DO_IDENTIFIER HealthCareProvider, DO_CODED_TEXT Insurer, DO_IDENTIFIER ReferralID)
        //{
        //    string MethodName = "UpdateHID";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.InsuranceGate.InsuranceGateT2 Srv = new ClientWebService.InsuranceGate.InsuranceGateT2(); // Service Define
        //        Srv.Url = Urls.URL_InsuranceGateService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (HID == null)
        //                throw new Exception("Argument is missing.");
        //            if (nationalCode == "")
        //                throw new Exception("Argument is missing.");
        //            MainFx.CheckNationalCode(nationalCode);
        //            if (HealthCareProvider == null)
        //                throw new Exception("Argument is missing.");
        //            if (Healthcarefacility == null)
        //                throw new Exception("Argument is missing.");
        //            if (Insurer == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        DO_IDENTIFIER PersonID = new DO_IDENTIFIER() { ID = nationalCode, Assigner = "National_Org_Civil_Reg", Issuer = "National_Org_Civil_Reg", Type = "National_Code" };
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.UpdateHID_T2(Healthcarefacility, HID, PersonID, HealthCareProvider, Insurer, ReferralID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is used to update the HID. It is used in case a reserved HID is used previously for a patinet encounter and thus it is necessary to update that HID to get confirmations.
        /////          </summary>
        /////          <param name="HID">Specifies the HID that requires update. The data type is DO_IDENTIFIER.</param>
        /////          <param name="PersonID">This argument is designed to specify the Patient's unique identifier. This identifier should be a Real World Identifier (RWI). National code is among the most common identifiers. RWIs are technically defined with DO_IDENTIFIER data type.</param>
        /////          <param name="HealthCareProvider">The argument to this method is the identifier of the healthcare provider. The healthcare provider identifier is RWI (Real World Identifier) and the data type is DO_IDENTIFIER.</param>
        /////          <param name="Insurer">one of the arguments to this method is to specify the insurer type in DO_CODED_TEXT format. The coding is available on http://coding.behdasht.gov.ir . The terminology is thritaEHR.insurer</param>
        /////          <returns>The method returns boolean which indicates if the process was successful.</returns>
        //public bool UpdateHID(DO_IDENTIFIER HID, DO_IDENTIFIER PersonID, DO_IDENTIFIER HealthCareProvider, DO_CODED_TEXT Insurer, DO_IDENTIFIER ReferralID)
        //{
        //    string MethodName = "UpdateHID";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.InsuranceGate.InsuranceGateT2 Srv = new ClientWebService.InsuranceGate.InsuranceGateT2(); // Service Define
        //        Srv.Url = Urls.URL_InsuranceGateService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (PersonID == null)
        //                throw new Exception("Argument is missing.");
        //            if (PersonID.Type != "")
        //            {
        //                if (PersonID.Type.ToUpper == "National_Code".ToUpper())
        //                    MainFx.CheckNationalCode(PersonID.ID);
        //            }
        //            if (HID == null)
        //                throw new Exception("Argument is missing.");
        //            if (HealthCareProvider == null)
        //                throw new Exception("Argument is missing.");
        //            if (Healthcarefacility == null)
        //                throw new Exception("Argument is missing.");
        //            if (Insurer == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.UpdateHID_T2(Healthcarefacility, HID, PersonID, HealthCareProvider, Insurer, ReferralID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method eliminates the HID that is produced based on the patient and the healthcare provider's eligiblity.
        /////          </summary>
        /////          <param name="NationalCode">This arguement is to specify the nationalcode of the patient in string format.</param>
        /////          <param name="HID">The HID is the Health Tracking ID that is assigned to any patient encounter to the healthcare system. This ID is generated based on the patient's and the healthcare provider's eligiblity to receive/provide healthcare services. Generating this ID corresponds to using the patient's insurance booklet.</param>
        /////          <param name="Reason">In order to eliminate an assigned HID, a reason should be prvided to specify why the ID is being eliminated. The reason should be specified with DO_CODED_TEXT data type.</param>
        /////          <param name="Description">The additional description on the elimination process and the additional comments can be specified through the Description argument.</param>
        /////          <returns>The result of the method is boolean which specifies if the elimination process was successful or not.</returns>
        //public bool EliminateHID(string NationalCode, DO_IDENTIFIER HID, DO_CODED_TEXT Reason, string Description)
        //{
        //    string MethodName = "EliminateHID";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.InsuranceGate.InsuranceGateT2 Srv = new ClientWebService.InsuranceGate.InsuranceGateT2(); // Service Define
        //        Srv.Url = Urls.URL_InsuranceGateService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (NationalCode == "")
        //                throw new Exception("Argument is missing.");
        //            MainFx.CheckNationalCode(NationalCode);
        //            if (HID == null)
        //                throw new Exception("Argument is missing.");
        //            if (Reason == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        DO_IDENTIFIER PersonID = new DO_IDENTIFIER() { ID = NationalCode, Assigner = "National_Org_Civil_Reg", Issuer = "National_Org_Civil_Reg", Type = "National_Code" };
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.EliminateHID_T2(Healthcarefacility, PersonID, HID, Reason, Description); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method eliminates the HID that is produced based on the patient and the healthcare provider's eligiblity.
        /////          </summary>
        /////          <param name="PersonID">This argument is designed to specify the Patient's unique identifier. This identifier should be a Real World Identifier (RWI). National code is among the most common identifiers. RWIs are technically defined with DO_IDENTIFIER data type.</param>
        /////          <param name="HID">The HID is the Health Tracking ID that is assigned to any patient encounter to the healthcare system. This ID is generated based on the patient's and the healthcare provider's eligiblity to receive/provide healthcare services. Generating this ID corresponds to using the patient's insurance booklet.</param>
        /////          <param name="Reason">In order to eliminate an assigned HID, a reason should be prvided to specify why the ID is being eliminated. The reason should be specified with DO_CODED_TEXT data type.</param>
        /////          <param name="Description">The additional description on the elimination process and the additional comments can be specified through the Description argument.</param>
        /////          <returns>The result of the method is boolean which specifies if the elimination process was successful or not.</returns>
        //public bool EliminateHID(DO_IDENTIFIER PersonID, DO_IDENTIFIER HID, DO_CODED_TEXT Reason, string Description)
        //{
        //    string MethodName = "EliminateHID";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.InsuranceGate.InsuranceGateT2 Srv = new ClientWebService.InsuranceGate.InsuranceGateT2(); // Service Define
        //        Srv.Url = Urls.URL_InsuranceGateService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (PersonID == null)
        //                throw new Exception("Argument is missing.");
        //            if (PersonID.Type != "")
        //            {
        //                if (PersonID.Type.ToUpper == "National_Code".ToUpper())
        //                    MainFx.CheckNationalCode(PersonID.ID);
        //            }
        //            if (HID == null)
        //                throw new Exception("Argument is missing.");
        //            if (Reason == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.EliminateHID_T2(Healthcarefacility, PersonID, HID, Reason, Description); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is used to update the status of HID to mention if it confirmed, or rejected, etc.
        /////          </summary>
        /////          <param name="HID">indicates the HID that is going to be verified. It is of type DO_IDENTIFIER.</param>
        /////          <param name="NationalCode">This argument specifies the patient's national code. the data type is in string format.</param>
        /////          <returns>This method returns the status of the HID as DO_CODED_TEXT. The terminology is available on http://coding.behdasht.gov.ir</returns>
        //public DO_CODED_TEXT VerifyHIDStatus(DO_IDENTIFIER HID, string NationalCode)
        //{
        //    string MethodName = "VerifyHIDStatus";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.InsuranceGate.InsuranceGateT2 Srv = new ClientWebService.InsuranceGate.InsuranceGateT2(); // Service Define
        //        Srv.Url = Urls.URL_InsuranceGateService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (NationalCode == "")
        //                throw new Exception("Argument is missing.");
        //            MainFx.CheckNationalCode(NationalCode);
        //            if (HID == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        DO_IDENTIFIER PersonID = new DO_IDENTIFIER() { ID = NationalCode, Assigner = "National_Org_Civil_Reg", Issuer = "National_Org_Civil_Reg", Type = "National_Code" };
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.VerifyHIDStatus_T2(Healthcarefacility, HID, PersonID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is used to update the status of HID to mention if it confirmed, or rejected, etc.
        /////          </summary>
        /////          <param name="HID">indicates the HID that is going to be verified. It is of type DO_IDENTIFIER.</param>
        /////          <param name="PersonID">This argument is designed to specify the Patient's unique identifier. This identifier should be a Real World Identifier (RWI). National code is among the most common identifiers. RWIs are technically defined with DO_IDENTIFIER data type.</param>
        /////          <returns>This method returns the status of the HID as DO_CODED_TEXT. The terminology is available on http://coding.behdasht.gov.ir</returns>
        //public DO_CODED_TEXT VerifyHIDStatus(DO_IDENTIFIER HID, DO_IDENTIFIER PersonID)
        //{
        //    string MethodName = "VerifyHIDStatus";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.InsuranceGate.InsuranceGateT2 Srv = new ClientWebService.InsuranceGate.InsuranceGateT2(); // Service Define
        //        Srv.Url = Urls.URL_InsuranceGateService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (PersonID == null)
        //                throw new Exception("Argument is missing.");
        //            if (PersonID.Type != "")
        //            {
        //                if (PersonID.Type.ToUpper == "National_Code".ToUpper())
        //                    MainFx.CheckNationalCode(PersonID.ID);
        //            }
        //            if (HID == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.VerifyHIDStatus_T2(Healthcarefacility, HID, PersonID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to get the frequency of the HID usages.        
        /////          </summary>        
        /////          <param name="HID">This argument specifies the health identifier of each patient encounter. This argument is of type DO_IDENTIFIER.</param>        
        /////          <returns>The method returns the frequency as Integer.</returns>
        //public int HIDUsedCount(DO_IDENTIFIER HID)
        //{
        //    string MethodName = "HIDUsedCount";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.InsuranceGate.InsuranceGateT2 Srv = new ClientWebService.InsuranceGate.InsuranceGateT2(); // Service Define
        //        Srv.Url = Urls.URL_InsuranceGateService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (HID == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        GeneralResponseMessageVO r;
        //        r = Srv.HIDUsedCount_T2(Healthcarefacility, HID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to get the referral path based on an existing referralID.        
        /////          </summary>        
        /////          <param name="HID">This argument specifies the referralID as HID. This argument is of type DO_IDENTIFIER.</param>        
        /////          <returns>The method retruns the array of referral path as a HIDPathVO.</returns>
        //public HIDPathVO[] GetReferralPath(DO_IDENTIFIER HID)
        //{
        //    string MethodName = "GetReferralPath";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.InsuranceGate.InsuranceGateT2 Srv = new ClientWebService.InsuranceGate.InsuranceGateT2();  // Service Define
        //        Srv.Url = Urls.URL_InsuranceGateService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (HID == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        GeneralResponseMessageVO r;
        //        r = Srv.GetReferralPath_T2(Healthcarefacility, HID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}

        ///// <summary>
        /////          This method is used to electronically retrieve the prescribe medications by a unique identifier which is HID.
        /////          </summary>
        /////          <param name="HID">The HID is the Health Tracking ID that is assigned to any patient encounter to the healthcare system. This ID is generated based on the patient's and the healthcare provider's eligiblity to receive/provide healthcare services. Generating this ID corresponds to using the patient's insurance booklet.</param>
        /////          <returns>The method returns the MedicationPrescrptionMessageVO which contains the object of the prescribed medicinal products as well as the patient's demographic, etc.</returns>
        //public MedicationPrescriptionsMessageVO GetPrescriptionMessageByHID(DO_IDENTIFIER HID)
        //{
        //    try
        //    {
        //        DO_IDENTIFIER Location = GetHealthCareFacility();
        //        // -------------------------------------Generate HeaderMessage --------------------------------
        //        SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2 CESrv = new SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2();
        //        CESrv.Url = Urls.URL_CEMI_ePrescription;
        //        MainFx Fx = new MainFx();
        //        CEheaderMessageVOValue = new HeaderMessageVO();
        //        CEheaderMessageVOValue.Sender = new SystemSenderVO();
        //        CEheaderMessageVOValue.Sender.SystemID = v.GetSystemID();
        //        CEheaderMessageVOValue.Sender.LocationID = Location.ID;
        //        v.ManageTokeninHeader(CEheaderMessageVOValue);
        //        string KP = _ExtractKeyPair(CEheaderMessageVOValue);
        //        // -------------------------------------Generate HeaderMessage --------------------------------
        //        // -------------------------------------Get Message directly From SEPAS if needed--------------------------------
        //        GeneralResponseMessageVO r;
        //        r = CESrv.GetMessageA_T2(HID);
        //        object GM = _ReturnGeneralResponseMessage(r, KP);
        //        // -------------------------------------Get Message directly From SEPAS if needed--------------------------------
        //        if (GM == null)
        //            return null/* TODO Change to default(_) if this is not a reference type */;
        //        AdditionalTools.Basic.Extra.determined SSL = new AdditionalTools.Basic.Extra.determined();
        //        switch (GM.ContentType)
        //        {
        //            case "Thrita.DM.Message.MedicationPrescriptionsMessageVO":
        //                {
        //                    MedicationPrescriptionsMessageVO obj = new MedicationPrescriptionsMessageVO();
        //                    switch (GM.ContentAlgorithm)
        //                    {
        //                        case 1  // XMLString
        //                       :
        //                            {
        //                                obj = AdditionalTools.Basic.ObjectSerializeFunction.SerializeByte2Object(GM.Content, obj.GetType);
        //                                break;
        //                            }
        //                        case 2 // EncryptedXMLString
        //                 :
        //                            {
        //                                obj = SSL.TaggedObject(GM.Content, obj.GetType);
        //                                break;
        //                            }
        //                        default:
        //                            {
        //                                throw new Exception("Error at recognize ContentAlgorithm.");
        //                                break;
        //                            }
        //                    }
        //                    return obj;
        //                }
        //            default:
        //                {
        //                    throw new Exception("This type of Message is not define cross enterprise.");
        //                    break;
        //                }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException("GetPrescriptionMessageByHID", ex));
        //    }
        //}

        //public DO_IDENTIFIER[] GetActivePrescriptionIDByNationalCode(string NationalCode)
        //{
        //    string MethodName = "GetActivePrescriptionIDByNationalCode";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2 Srv = new SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_CEMI_ePrescription; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (NationalCode == "")
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetActiveCEIDByNationalCode_T2(NationalCode); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        //public DO_IDENTIFIER[] GetActivePrescriptionIDByPersonIdentifier(DO_IDENTIFIER PersonIdentifier)
        //{
        //    string MethodName = "GetActivePrescriptionIDByPersonIdentifier";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2 Srv = new SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_CEMI_ePrescription; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (PersonIdentifier == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetActiveCEIDByPersonIdentifier_T2(PersonIdentifier); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}

        ///// <summary>
        /////          The method GetFeedbackPatientRecord is defined to retun the patient encounter to the secondary healthcare facility as a feedback to the primary healthcare facilitiy.
        /////          </summary>
        /////          <param name="HID">
        /////          The input argument to GetFeedbackPatient Record is HID. The feedback data should be returned based on a unique identifier. This uniqueIdentifier is called HID by which the patient's data is referref from primary healthcare facility to the secondary healthcare facility.
        /////          HID is of tyoe DO_IDENTIFIER which consists of 4 attributes.
        /////          </param>
        /////          <returns>the returned datatype is ReferralFeedbackMessageVO which is designed to model the patient encounter as feedback message.</returns>
        //public ReferralFeedbackMessageVO GetFeedbackPatienRecord(DO_IDENTIFIER HID)
        //{
        //    try
        //    {
        //        DO_IDENTIFIER Location = GetHealthCareFacility();
        //        // -------------------------------------Generate HeaderMessage --------------------------------
        //        SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2 CESrv = new SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2();
        //        CESrv.Url = Urls.URL_CEMI_Referral;
        //        // Dim v As New Variable
        //        MainFx Fx = new MainFx();
        //        CEheaderMessageVOValue = new HeaderMessageVO();
        //        CEheaderMessageVOValue.Sender = new SystemSenderVO();
        //        CEheaderMessageVOValue.Sender.SystemID = v.GetSystemID();
        //        CEheaderMessageVOValue.Sender.LocationID = Location.ID;
        //        v.ManageTokeninHeader(CEheaderMessageVOValue);
        //        string KP = _ExtractKeyPair(CEheaderMessageVOValue);
        //        // -------------------------------------Generate HeaderMessage IP Temp --------------------------------
        //        IPHostEntry IPHost = Dns.GetHostByName(Dns.GetHostName());
        //        CEheaderMessageVOValue.Sender.IP = IPHost.AddressList[0].ToString(); // InternalIP
        //                                                                             // -------------------------------------Generate HeaderMessage IP Temp --------------------------------
        //                                                                             // -------------------------------------Generate HeaderMessage --------------------------------
        //                                                                             // -------------------------------------Get Message directly From SEPAS if needed--------------------------------
        //        GeneralResponseMessageVO r;
        //        r = CESrv.GetMessageB_T2(HID);
        //        // Dim GM() As EHRGateGeneralMessageVO
        //        object GM = _ReturnGeneralResponseMessage(r, KP);
        //        // -------------------------------------Get Message directly From SEPAS if needed--------------------------------
        //        if (GM == null)
        //            return null/* TODO Change to default(_) if this is not a reference type */;
        //        if (GM.Length == 0)
        //            return null/* TODO Change to default(_) if this is not a reference type */;
        //        AdditionalTools.Basic.Extra.determined SSL = new AdditionalTools.Basic.Extra.determined();
        //        switch (GM(0).ContentType)
        //        {
        //            case "Thrita.DM.Message.ReferralFeedbackMessageVO":
        //                {
        //                    ReferralFeedbackMessageVO obj = new ReferralFeedbackMessageVO();
        //                    switch (GM(0).ContentAlgorithm)
        //                    {
        //                        case 1  // XMLString
        //                       :
        //                            {
        //                                obj = AdditionalTools.Basic.ObjectSerializeFunction.SerializeByte2Object(GM.Content, obj.GetType);
        //                                break;
        //                            }
        //                        case 2 // EncryptedXMLString
        //                 :
        //                            {
        //                                obj = SSL.TaggedObject(GM(0).Content, obj.GetType);
        //                                break;
        //                            }
        //                        default:
        //                            {
        //                                throw new Exception("Error at recognize ContentAlgorithm.");
        //                                break;
        //                            }
        //                    }
        //                    return obj;
        //                }
        //            default:
        //                {
        //                    throw new Exception("This type of Message is not define cross enterprise.");
        //                    break;
        //                }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException("GetFeedbackRecord", ex));
        //    }
        //}
        ///// <summary>
        /////          This method retrieves the information of the referred patient by a ReferralID which is HID of type DO_IDENTIFIER.
        /////          </summary>
        /////          <param name="ReferralID">The referralID is the unique identifier by which the referral information is retrieved.</param>
        /////          <returns>The referral information is exchanged in ReferralCaseMessageVO format.</returns>
        //public ReferralCaseMessageVO GetReferralPatientRecord(DO_IDENTIFIER ReferralID)
        //{
        //    try
        //    {
        //        DO_IDENTIFIER Location = GetHealthCareFacility();
        //        // -------------------------------------Generate HeaderMessage --------------------------------
        //        SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2 CESrv = new SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2();
        //        CESrv.Url = Urls.URL_CEMI_Referral;
        //        MainFx Fx = new MainFx();
        //        CEheaderMessageVOValue = new HeaderMessageVO();
        //        CEheaderMessageVOValue.Sender = new SystemSenderVO();
        //        CEheaderMessageVOValue.Sender.SystemID = v.GetSystemID();
        //        CEheaderMessageVOValue.Sender.LocationID = Location.ID;
        //        v.ManageTokeninHeader(CEheaderMessageVOValue);
        //        string KP = _ExtractKeyPair(CEheaderMessageVOValue);
        //        // -------------------------------------Generate HeaderMessage --------------------------------
        //        // -------------------------------------Get Message directly From SEPAS if needed--------------------------------
        //        GeneralResponseMessageVO r;
        //        r = CESrv.GetMessageA_T2(ReferralID);
        //        object GM = _ReturnGeneralResponseMessage(r, KP);
        //        // -------------------------------------Get Message directly From SEPAS if needed--------------------------------
        //        if (GM == null)
        //            return null/* TODO Change to default(_) if this is not a reference type */;
        //        AdditionalTools.Basic.Extra.determined SSL = new AdditionalTools.Basic.Extra.determined();
        //        switch (GM.ContentType)
        //        {
        //            case "Thrita.DM.Message.ReferralCaseMessageVO":
        //                {
        //                    ReferralCaseMessageVO obj = new ReferralCaseMessageVO();
        //                    switch (GM.ContentAlgorithm)
        //                    {
        //                        case 1  // XMLString
        //                       :
        //                            {
        //                                obj = AdditionalTools.Basic.ObjectSerializeFunction.SerializeByte2Object(GM.Content, obj.GetType);
        //                                break;
        //                            }
        //                        case 2 // EncryptedXMLString
        //                 :
        //                            {
        //                                obj = SSL.TaggedObject(GM.Content, obj.GetType);
        //                                break;
        //                            }
        //                        default:
        //                            {
        //                                throw new Exception("Error at recognize ContentAlgorithm.");
        //                                break;
        //                            }
        //                    }
        //                    return obj;
        //                }
        //            default:
        //                {
        //                    throw new Exception("This type of Message is not define cross enterprise.");
        //                    break;
        //                }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException("GetPatientRecordByCEID", ex));
        //    }
        //}

        ///// <summary>
        /////          This method is used to retrieve tha referred patient's HID from his/her national code.
        /////          </summary>
        /////          <param name="NationalCode">The patient's national code is the input argument of this method. The national code should be specified in string format.</param>
        /////          <returns>The method returns a list of HIDs that have not any feedback yet.</returns>
        //public DO_IDENTIFIER[] GetActiveReferralIDByNationalCode(string NationalCode)
        //{
        //    string MethodName = "GetActiveReferralIDByNationalCode";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2 Srv = new SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2(); // Service Define
        //        Srv.Url = Urls.URL_CEMI_Referral; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (NationalCode == "")
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetActiveCEIDByNationalCode_T2(NationalCode); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        //public DO_IDENTIFIER[] GetActiveReferralIDByPersonIdentifier(DO_IDENTIFIER PersonIdentifier)
        //{
        //    string MethodName = "GetActiveReferralIDByPersonIdentifier";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2 Srv = new SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2(); // Service Define
        //        Srv.Url = Urls.URL_CEMI_Referral; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (PersonIdentifier == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetActiveCEIDByPersonIdentifier_T2(PersonIdentifier); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}


        ///// <summary>        
        /////          This method is designed to get laboratory prescriptions by HID.        
        /////          </summary>        
        /////          <param name="HID">This argument specifies the prescription unique identifier. This argument is of type DO_IDENTIFIER.</param>        
        /////          <returns>The method returns the Lab preswcription as LaboratoryPrescriptionsMessageVO.</returns>
        //public LaboratoryPrescriptionsMessageVO GetLaboratoryPrescriptionByHID(DO_IDENTIFIER HID)
        //{
        //    try
        //    {
        //        DO_IDENTIFIER Location = GetHealthCareFacility();
        //        // -------------------------------------Generate HeaderMessage --------------------------------
        //        SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2 CESrv = new SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2();
        //        CESrv.Url = Urls.URL_CEMI_LabPrescriptions;
        //        MainFx Fx = new MainFx();
        //        CEheaderMessageVOValue = new HeaderMessageVO();
        //        CEheaderMessageVOValue.Sender = new SystemSenderVO();
        //        CEheaderMessageVOValue.Sender.SystemID = v.GetSystemID();
        //        CEheaderMessageVOValue.Sender.LocationID = Location.ID;
        //        v.ManageTokeninHeader(CEheaderMessageVOValue);
        //        string KP = _ExtractKeyPair(CEheaderMessageVOValue);
        //        // -------------------------------------Generate HeaderMessage --------------------------------
        //        // -------------------------------------Get Message directly From SEPAS if needed--------------------------------
        //        GeneralResponseMessageVO r;
        //        r = CESrv.GetMessageA_T2(HID);
        //        object GM = _ReturnGeneralResponseMessage(r, KP);
        //        // -------------------------------------Get Message directly From SEPAS if needed--------------------------------
        //        if (GM == null)
        //            return null/* TODO Change to default(_) if this is not a reference type */;
        //        AdditionalTools.Basic.Extra.determined SSL = new AdditionalTools.Basic.Extra.determined();
        //        switch (GM.ContentType)
        //        {
        //            case "Thrita.DM.Message.LaboratoryPrescriptionsMessageVO":
        //                {
        //                    LaboratoryPrescriptionsMessageVO obj = new LaboratoryPrescriptionsMessageVO();
        //                    switch (GM.ContentAlgorithm)
        //                    {
        //                        case 1  // XMLString
        //                       :
        //                            {
        //                                obj = AdditionalTools.Basic.ObjectSerializeFunction.SerializeByte2Object(GM.Content, obj.GetType);
        //                                break;
        //                            }
        //                        case 2 // EncryptedXMLString
        //                 :
        //                            {
        //                                obj = SSL.TaggedObject(GM.Content, obj.GetType);
        //                                break;
        //                            }
        //                        default:
        //                            {
        //                                throw new Exception("Error at recognize ContentAlgorithm.");
        //                                break;
        //                            }
        //                    }
        //                    return obj;
        //                }
        //            default:
        //                {
        //                    throw new Exception("This type of Message is not define cross enterprise.");
        //                    break;
        //                }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException("GetLaboratoryPrescriptionByHID", ex));
        //    }
        //}
        ///// <summary>
        /////          This method retrieves the information of the laboratory test of patient by a HID which is HID of type DO_IDENTIFIER.
        /////          </summary>
        /////          <param name="HID">The HID is the unique identifier by which the laboratory information is retrieved.</param>
        /////          <returns>The laboratory information is exchanged in LaboratoryResultMessageVO format.</returns>
        //public LaboratoryResultMessageVO GetLaboratoryResult(DO_IDENTIFIER HID)
        //{
        //    try
        //    {
        //        DO_IDENTIFIER Location = GetHealthCareFacility();
        //        // -------------------------------------Generate HeaderMessage --------------------------------
        //        SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2 CESrv = new SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2();
        //        CESrv.Url = Urls.URL_CEMI_LabPrescriptions;
        //        // Dim v As New Variable
        //        MainFx Fx = new MainFx();
        //        CEheaderMessageVOValue = new HeaderMessageVO();
        //        CEheaderMessageVOValue.Sender = new SystemSenderVO();
        //        CEheaderMessageVOValue.Sender.SystemID = v.GetSystemID();
        //        CEheaderMessageVOValue.Sender.LocationID = Location.ID;
        //        v.ManageTokeninHeader(CEheaderMessageVOValue);
        //        string KP = _ExtractKeyPair(CEheaderMessageVOValue);
        //        // -------------------------------------Generate HeaderMessage IP Temp --------------------------------
        //        IPHostEntry IPHost = Dns.GetHostByName(Dns.GetHostName());
        //        CEheaderMessageVOValue.Sender.IP = IPHost.AddressList[0].ToString(); // InternalIP
        //                                                                             // -------------------------------------Generate HeaderMessage IP Temp --------------------------------
        //                                                                             // -------------------------------------Generate HeaderMessage --------------------------------
        //                                                                             // -------------------------------------Get Message directly From SEPAS if needed--------------------------------
        //        GeneralResponseMessageVO r;
        //        r = CESrv.GetMessageB_T2(HID);
        //        // Dim GM() As EHRGateGeneralMessageVO
        //        object GM = _ReturnGeneralResponseMessage(r, KP);
        //        // -------------------------------------Get Message directly From SEPAS if needed--------------------------------
        //        if (GM == null)
        //            return null/* TODO Change to default(_) if this is not a reference type */;
        //        if (GM.Length == 0)
        //            return null/* TODO Change to default(_) if this is not a reference type */;
        //        AdditionalTools.Basic.Extra.determined SSL = new AdditionalTools.Basic.Extra.determined();
        //        switch (GM(0).ContentType)
        //        {
        //            case "Thrita.DM.Message.LaboratoryResultMessageVO":
        //                {
        //                    LaboratoryResultMessageVO obj = new LaboratoryResultMessageVO();
        //                    switch (GM(0).ContentAlgorithm)
        //                    {
        //                        case 1  // XMLString
        //                       :
        //                            {
        //                                obj = AdditionalTools.Basic.ObjectSerializeFunction.SerializeByte2Object(GM.Content, obj.GetType);
        //                                break;
        //                            }
        //                        case 2 // EncryptedXMLString
        //                 :
        //                            {
        //                                obj = SSL.TaggedObject(GM(0).Content, obj.GetType);
        //                                break;
        //                            }
        //                        default:
        //                            {
        //                                throw new Exception("Error at recognize ContentAlgorithm.");
        //                                break;
        //                            }
        //                    }
        //                    return obj;
        //                }
        //            default:
        //                {
        //                    throw new Exception("This type of Message is not define cross enterprise.");
        //                    break;
        //                }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException("GetLaboratoryResult", ex));
        //    }
        //}
        //public DO_IDENTIFIER[] GetActiveLaboratoryPrescriptionIDByNationalCode(string NationalCode)
        //{
        //    string MethodName = "GetActiveLaboratoryPrescriptionIDByNationalCode";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2 Srv = new SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_CEMI_LabPrescriptions; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (NationalCode == "")
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetActiveCEIDByNationalCode_T2(NationalCode); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        //public DO_IDENTIFIER[] GetActiveLaboratoryPrescriptionIDByPersonIdentifier(DO_IDENTIFIER PersonIdentifier)
        //{
        //    string MethodName = "GetActiveLaboratoryPrescriptionIDByPersonIdentifier";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2 Srv = new SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_CEMI_LabPrescriptions; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (PersonIdentifier == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetActiveCEIDByPersonIdentifier_T2(PersonIdentifier); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}


        ///// <summary>        
        /////          This method is designed to get the medical imaging prescriptions by prescription unique identifier.        
        /////          </summary>        
        /////          <param name="HID">This argument specifies the prescription identifier. This argument is of type DO_IDENTIFIER.</param>        
        /////          <returns>The method returns the medical imaging prescription as a ImagingPrescriptionsMessageVO.</returns>
        //public ImagingPrescriptionsMessageVO GetMedicalImagingPrescriptions(DO_IDENTIFIER HID)
        //{
        //    try
        //    {
        //        DO_IDENTIFIER Location = GetHealthCareFacility();
        //        // -------------------------------------Generate HeaderMessage --------------------------------
        //        SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2 CESrv = new SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2();
        //        CESrv.Url = Urls.URL_CEMI_MedicalImagingPrescriptions;
        //        MainFx Fx = new MainFx();
        //        CEheaderMessageVOValue = new HeaderMessageVO();
        //        CEheaderMessageVOValue.Sender = new SystemSenderVO();
        //        CEheaderMessageVOValue.Sender.SystemID = v.GetSystemID();
        //        CEheaderMessageVOValue.Sender.LocationID = Location.ID;
        //        v.ManageTokeninHeader(CEheaderMessageVOValue);
        //        string KP = _ExtractKeyPair(CEheaderMessageVOValue);
        //        // -------------------------------------Generate HeaderMessage --------------------------------
        //        // -------------------------------------Get Message directly From SEPAS if needed--------------------------------
        //        GeneralResponseMessageVO r;
        //        r = CESrv.GetMessageA_T2(HID);
        //        object GM = _ReturnGeneralResponseMessage(r, KP);
        //        // -------------------------------------Get Message directly From SEPAS if needed--------------------------------
        //        if (GM == null)
        //            return null/* TODO Change to default(_) if this is not a reference type */;
        //        AdditionalTools.Basic.Extra.determined SSL = new AdditionalTools.Basic.Extra.determined();
        //        switch (GM.ContentType)
        //        {
        //            case "Thrita.DM.Message.ImagingPrescriptionsMessageVO":
        //                {
        //                    ImagingPrescriptionsMessageVO obj = new ImagingPrescriptionsMessageVO();
        //                    switch (GM.ContentAlgorithm)
        //                    {
        //                        case 1  // XMLString
        //                       :
        //                            {
        //                                obj = AdditionalTools.Basic.ObjectSerializeFunction.SerializeByte2Object(GM.Content, obj.GetType);
        //                                break;
        //                            }
        //                        case 2 // EncryptedXMLString
        //                 :
        //                            {
        //                                obj = SSL.TaggedObject(GM.Content, obj.GetType);
        //                                break;
        //                            }
        //                        default:
        //                            {
        //                                throw new Exception("Error at recognize ContentAlgorithm.");
        //                                break;
        //                            }
        //                    }
        //                    return obj;
        //                }
        //            default:
        //                {
        //                    throw new Exception("This type of Message is not define cross enterprise.");
        //                    break;
        //                }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException("GetMedicalImagingPrescriptions", ex));
        //    }
        //}
        //public DO_IDENTIFIER[] GetActiveMedicalImagingPrescriptionIDByNationalCode(string NationalCode)
        //{
        //    string MethodName = "GetActiveMedicalImagingPrescriptionIDByNationalCode";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2 Srv = new SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_CEMI_MedicalImagingPrescriptions; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (NationalCode == "")
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetActiveCEIDByNationalCode_T2(NationalCode); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        //public DO_IDENTIFIER[] GetActiveMedicalImagingPrescriptionIDByPersonIdentifier(DO_IDENTIFIER PersonIdentifier)
        //{
        //    string MethodName = "GetActiveMedicalImagingPrescriptionIDByPersonIdentifier";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2 Srv = new SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_CEMI_MedicalImagingPrescriptions; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (PersonIdentifier == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetActiveCEIDByPersonIdentifier_T2(PersonIdentifier); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is designed to check the validation rules on the data message that is going to be submitted through other EHR operators e.g. SavePatientBill, SavePathologyReport, etc.
        /////          </summary>
        /////          <param name="Obj">This argument is of type Object so that any Object Type could be exchanged. some examples are: PatientBillMessageVO, LaboratoryResultMessageVO, etc.</param>
        /////          <param name="ValidationType">This argument specifies the validation type which is of DO_CODED_TEXT to show what type of validation should be performed on data message. For more information please refer to: http://coding.behdasht.gov.ir</param>
        /////          <returns>It returns the result as ValidationResultVO. consisting of the result of the validation and the relevant messages.</returns>
        //public ValidationResultVO SepasValidator(object Obj, DO_CODED_TEXT ValidationType)
        //{
        //    string MethodName = "SepasValidator";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.SepasErrorTranscriber.ServiceT2 Srv = new ClientWebService.SepasErrorTranscriber.ServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_SepasErrorTranscriberService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (Obj == null)
        //                throw new Exception("Argument is missing.");
        //            if (Healthcarefacility == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        Crypto sec = new Crypto();
        //        byte[] b;
        //        b = sec.SecuredObject(Obj);
        //        string DM;
        //        DM = "Thrita.DM.Message." + Obj.GetType().Name;
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.SepasErrorTranscriberSecure_T2(b, DM, ValidationType); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        Time.EventStart();
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("...Build GeneralResponseMessage Time", Time);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }// ---------Function Name
        //}





        ///// <summary>        
        /////          This method is designed to get ambulance mission information for further use of the hospital information systems.
        /////          </summary>
        /////          <param name="EMSID">This argument specifies the ambulance emergency admission unique identifier. This argument is of type DO_IDENTIFIER.</param>
        /////          <returns>The ambulance mission info is returned in terms of AmbulanceServiceMessageVO.</returns>
        //public AmbulanceServiceMessageVO GetAmbulanceMission(DO_IDENTIFIER EMSID)
        //{
        //    try
        //    {
        //        DO_IDENTIFIER Location = GetHealthCareFacility();
        //        // -------------------------------------Generate HeaderMessage --------------------------------
        //        SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2 CESrv = new SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2();
        //        CESrv.Url = "Urls"; // .URL_CEMI_ePrescription
        //                            // Critical_ToDo
        //        MainFx Fx = new MainFx();
        //        CEheaderMessageVOValue = new HeaderMessageVO();
        //        CEheaderMessageVOValue.Sender = new SystemSenderVO();
        //        CEheaderMessageVOValue.Sender.SystemID = v.GetSystemID();
        //        CEheaderMessageVOValue.Sender.LocationID = Location.ID;
        //        v.ManageTokeninHeader(CEheaderMessageVOValue);
        //        string KP = _ExtractKeyPair(CEheaderMessageVOValue);
        //        // -------------------------------------Generate HeaderMessage --------------------------------
        //        // -------------------------------------Get Message directly From SEPAS if needed--------------------------------
        //        GeneralResponseMessageVO r;
        //        r = CESrv.GetMessageA_T2(EMSID);
        //        object GM = _ReturnGeneralResponseMessage(r, KP);
        //        // -------------------------------------Get Message directly From SEPAS if needed--------------------------------
        //        if (GM == null)
        //            return null/* TODO Change to default(_) if this is not a reference type */;
        //        AdditionalTools.Basic.Extra.determined SSL = new AdditionalTools.Basic.Extra.determined();
        //        switch (GM.ContentType)
        //        {
        //            case "Thrita.DM.Message.AmbulanceServiceMessageVO":
        //                {
        //                    AmbulanceServiceMessageVO obj = new AmbulanceServiceMessageVO();
        //                    switch (GM.ContentAlgorithm)
        //                    {
        //                        case 1  // XMLString
        //                       :
        //                            {
        //                                obj = AdditionalTools.Basic.ObjectSerializeFunction.SerializeByte2Object(GM.Content, obj.GetType);
        //                                break;
        //                            }
        //                        case 2 // EncryptedXMLString
        //                 :
        //                            {
        //                                obj = SSL.TaggedObject(GM.Content, obj.GetType);
        //                                break;
        //                            }
        //                        default:
        //                            {
        //                                throw new Exception("Error at recognize ContentAlgorithm.");
        //                                break;
        //                            }
        //                    }
        //                    return obj;
        //                }
        //            default:
        //                {
        //                    throw new Exception("This type of Message is not define cross enterprise.");
        //                    break;
        //                }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException("GetAmbulanceMission", ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to save the ambulance mission.        
        /////          </summary>        
        /////          <param name="AmbulanceMessage">This argument specifies the Information of the mission. This argument is of type AmbulanceServiceMessageVO.</param>        
        /////          <returns>The method returns the result of the transaction as a ResultVO.</returns>
        //public ResultVO SaveAmbulanceMission(AmbulanceServiceMessageVO AmbulanceMessage)
        //{
        //    try
        //    {
        //        DO_IDENTIFIER Location = GetHealthCareFacility();
        //        ClientWebService.SepasGate.MergAdaptorService srv = new ClientWebService.SepasGate.MergAdaptorService();
        //        srv.Url = GetUrlSepasNode() + "/AmbulanceService.asmx";
        //        // Dim v As New Variable
        //        var headerMessageVOValue = new HeaderMessageVO();
        //        headerMessageVOValue.Sender = new SystemSenderVO();
        //        headerMessageVOValue.Sender.SystemID = v.GetSystemID();
        //        headerMessageVOValue.Sender.LocationID = Location.ID;
        //        headerMessageVOValue.Sender.URL = "0";
        //        // -------------------------(Begin-PrimaryDefinition)------------------------'
        //        DO_IDENTIFIER SystemID, LocationID;
        //        SystemID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.SystemID, Issuer = "MOHME_IT", Type = "System_ID" };
        //        LocationID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.LocationID, Issuer = "MOHME_IT", Type = "Org_ID" };
        //        // -------------------------(End-PrimaryDefinition)------------------------'
        //        // -------------------------(Begin-MsgID)------------------------'
        //        if (AmbulanceMessage == null)
        //            throw new Exception("Object is null.");
        //        if (AmbulanceMessage.MsgID == null)
        //            throw new Exception("MsgID is null.");
        //        AmbulanceMessage.MsgID.HealthCareFacilityID = LocationID;
        //        AmbulanceMessage.MsgID.SystemID = SystemID;
        //        // -------------------------(End-MsgID)------------------------'
        //        ResultVO result;
        //        Crypto sec = new Crypto();
        //        byte[] b;
        //        b = sec.SecuredObject(AmbulanceMessage);
        //        result = srv.SaveAmbulanceMessageSecure(b);
        //        return result;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException("SaveAmbulanceMission", ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to retrieve the patient admission information from the hospital.        
        /////          </summary>        
        /////          <param name="EMSID">This argument specifies the ambulance emergency admission unique identifier. This argument is of type DO_IDENTIFIER.</param>        
        /////          <returns>The admitted message is returned in terms of AdmittedMessageVO.</returns>
        //public AdmittedMessageVO GetAdmittedMessage(DO_IDENTIFIER EMSID)
        //{
        //    try
        //    {
        //        DO_IDENTIFIER Location = GetHealthCareFacility();
        //        // -------------------------------------Generate HeaderMessage --------------------------------
        //        SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2 CESrv = new SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2();
        //        CESrv.Url = "Urls"; // .URL_CEMI_ePrescription
        //                            // Critical_ToDo
        //        MainFx Fx = new MainFx();
        //        CEheaderMessageVOValue = new HeaderMessageVO();
        //        CEheaderMessageVOValue.Sender = new SystemSenderVO();
        //        CEheaderMessageVOValue.Sender.SystemID = v.GetSystemID();
        //        CEheaderMessageVOValue.Sender.LocationID = Location.ID;
        //        v.ManageTokeninHeader(CEheaderMessageVOValue);
        //        string KP = _ExtractKeyPair(CEheaderMessageVOValue);
        //        // -------------------------------------Generate HeaderMessage --------------------------------
        //        // -------------------------------------Get Message directly From SEPAS if needed--------------------------------
        //        GeneralResponseMessageVO r;
        //        r = CESrv.GetMessageA_T2(EMSID);
        //        object GM = _ReturnGeneralResponseMessage(r, KP);
        //        // -------------------------------------Get Message directly From SEPAS if needed--------------------------------
        //        if (GM == null)
        //            return null/* TODO Change to default(_) if this is not a reference type */;
        //        AdditionalTools.Basic.Extra.determined SSL = new AdditionalTools.Basic.Extra.determined();
        //        switch (GM.ContentType)
        //        {
        //            case "Thrita.DM.Message.AdmittedMessageVO":
        //                {
        //                    AdmittedMessageVO obj = new AdmittedMessageVO();
        //                    switch (GM.ContentAlgorithm)
        //                    {
        //                        case 1  // XMLString
        //                       :
        //                            {
        //                                obj = AdditionalTools.Basic.ObjectSerializeFunction.SerializeByte2Object(GM.Content, obj.GetType);
        //                                break;
        //                            }
        //                        case 2 // EncryptedXMLString
        //                 :
        //                            {
        //                                obj = SSL.TaggedObject(GM.Content, obj.GetType);
        //                                break;
        //                            }
        //                        default:
        //                            {
        //                                throw new Exception("Error at recognize ContentAlgorithm.");
        //                                break;
        //                            }
        //                    }
        //                    return obj;
        //                }
        //            default:
        //                {
        //                    throw new Exception("This type of Message is not define cross enterprise.");
        //                    break;
        //                }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException("GetAdmittedMessage", ex));
        //    }
        //}
        ///// <summary>
        /////          This method is to get the reimbursement produced by the Insurer organization by HID.
        /////          </summary>
        /////          <param name="HID">This argument specifies the HID as DO_IDENTIFIER.</param>
        /////          <returns>The method returns the medical record object as Insurer Reimbursement MessageVO class.</returns>
        //public InsurerReimbursementMessageVO GetInsurerReimbursement(DO_IDENTIFIER HID)
        //{
        //    try
        //    {
        //        DO_IDENTIFIER Location = GetHealthCareFacility();
        //        // -------------------------------------Generate HeaderMessage --------------------------------
        //        SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2 CESrv = new SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2();
        //        CESrv.Url = Urls.URL_CEMI_EMIRE;
        //        MainFx Fx = new MainFx();
        //        CEheaderMessageVOValue = new HeaderMessageVO();
        //        CEheaderMessageVOValue.Sender = new SystemSenderVO();
        //        CEheaderMessageVOValue.Sender.SystemID = v.GetSystemID();
        //        CEheaderMessageVOValue.Sender.LocationID = Location.ID;
        //        v.ManageTokeninHeader(CEheaderMessageVOValue);
        //        string KP = _ExtractKeyPair(CEheaderMessageVOValue);
        //        // -------------------------------------Generate HeaderMessage --------------------------------
        //        // -------------------------------------Generate HeaderMessage IP Temp --------------------------------
        //        IPHostEntry IPHost = Dns.GetHostByName(Dns.GetHostName());
        //        CEheaderMessageVOValue.Sender.IP = IPHost.AddressList[0].ToString(); // InternalIP
        //                                                                             // -------------------------------------Generate HeaderMessage IP Temp --------------------------------
        //                                                                             // -------------------------------------Get Message directly From SEPAS if needed--------------------------------
        //        GeneralResponseMessageVO r;
        //        r = CESrv.GetMessageB_T2(HID);
        //        // Dim GM() As EHRGateGeneralMessageVO
        //        object GM = _ReturnGeneralResponseMessage(r, KP);
        //        // -------------------------------------Get Message directly From SEPAS if needed--------------------------------
        //        if (GM == null)
        //            return null/* TODO Change to default(_) if this is not a reference type */;
        //        if (GM.Length == 0)
        //            return null/* TODO Change to default(_) if this is not a reference type */;
        //        AdditionalTools.Basic.Extra.determined SSL = new AdditionalTools.Basic.Extra.determined();
        //        switch (GM(0).ContentType)
        //        {
        //            case "Thrita.DM.Message.InsurerReimbursementMessageVO":
        //                {
        //                    InsurerReimbursementMessageVO obj = new InsurerReimbursementMessageVO();
        //                    switch (GM(0).ContentAlgorithm)
        //                    {
        //                        case 1  // XMLString
        //                       :
        //                            {
        //                                obj = AdditionalTools.Basic.ObjectSerializeFunction.SerializeByte2Object(GM.Content, obj.GetType);
        //                                break;
        //                            }
        //                        case 2 // EncryptedXMLString
        //                 :
        //                            {
        //                                obj = SSL.TaggedObject(GM(0).Content, obj.GetType);
        //                                break;
        //                            }
        //                        default:
        //                            {
        //                                throw new Exception("Error at recognize ContentAlgorithm.");
        //                                break;
        //                            }
        //                    }
        //                    return obj;
        //                }
        //            default:
        //                {
        //                    throw new Exception("This type of Message is not define cross enterprise.");
        //                    break;
        //                }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException("GetInsurerReimbursement", ex));
        //    }
        //}
        ///// <summary>
        /////          This method is designed to retrieve active HIDs for reimbusement by National Code.
        /////          </summary>
        /////          <param name="NationalCode">This argument indicates the national code is string format.</param>
        /////          <returns>The method returns an array of HIDs as DO_IDENTIFIER.</returns>
        //public DO_IDENTIFIER[] GetActiveInsurerReimbursementHIDByNationalCode(string NationalCode)
        //{
        //    string MethodName = "GetActiveInsurerReimbursementHIDByNationalCode";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2 Srv = new SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_CEMI_EMIRE; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (NationalCode == "")
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetActiveCEIDByNationalCode_T2(NationalCode); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        //public DO_IDENTIFIER[] GetActiveInsurerReimbursementHIDByPersonIdentifier(DO_IDENTIFIER PersonIdentifier)
        //{
        //    string MethodName = "GetActiveInsurerReimbursementHIDByPersonIdentifier";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2 Srv = new SDK.ClientWebService.SepasGate.General_CEMI.WebServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_CEMI_EMIRE; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (PersonIdentifier == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetActiveCEIDByPersonIdentifier_T2(PersonIdentifier); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}


        ///// <summary>
        /////          This method is used to add the healthcare providers' available timetable.
        /////          </summary>
        /////          <remarks>The healthcae providers' available time table is called a Schedule Block.</remarks>
        /////          <param name="Provider">The informaion regarding the healthcare provider is exchanged by this attribute. This argument is of type HealthcareProviderVO. It is noteworthy to mention that only the providerID is mandatory in this class of datatype.</param>
        /////          <param name="HealthcareFacilityUnit">This argument is used to specify the information the healthcare facility for which the time table is exchanged. This arguement is of type HealthOrganizationUnitVO. This datatype is used to manage the organizational structure of outpatient healthcare facilities such as clinics, physicians office, etc. any healthcare facility is identified by a unique Identifer which is of type DO_IDENTIFIER. The healthcarefacilityID is mandatory in this class.</param>
        /////          <param name="StartDateTime">This argument is used to inform the start time of the schedule block. It is used to specify the sart time of the potential appointment. This argument is of tyoe DO_DATE_TIME. All partes of DO_DATE_TIME is mandatory.</param>
        /////          <param name="DurationPerPatient">This argument specifies the time duration of the service to be provided by the healthcare provider in the specified schedule block. this argument is of type integer.</param>
        /////          <param name="QueueNumber">This argument specified the local qeueu number for each schedule block. This argument is not mandatory but in case any health qeueue  management system needs to specify the assigned qeueue number to any schedule block, it is possible through this argument. It is of type Integer.</param>
        /////          <param name="Service">This argument is used to specify the health service that is to be provided by the healthcare provider. this argument is of type DO_CODED_TEXT. The termonology of the service is of type RVU3. The coding is available on: http://coding.behdasht.gov.ir</param>
        /////          <param name="Quota">This argument is used to specify the Quota. Quota is defined as the share of the schedule block that are define for any means of appointments inquiry, such as Internet appointments, Referral System Appointments, USSD Appointments, etc.</param>
        /////          <param name="LocalID">This argument is to specify the uniqueidetifier that might be assigned to any schedule block. This argument is of type string and is not mandatory.</param>
        /////          <param name="BookingStartDate">This argument specifies the time since which the booking can be started. It is of type DO_DATE_TIME</param>
        /////          <param name="BookingExpiryDate">This argument specified the expiry date regarding the booking time of the specified schedule block. It is of type DO_DATE_TIME.</param>
        /////          <returns>A successful add retuns a unique identifier called tracking qeueue ID</returns>
        //public string AddProviderScheduling(HealthcareProviderVO Provider, HealthOrganizationUnitVO HealthcareFacilityUnit, DO_DATE_TIME StartDateTime, int DurationPerPatient, int QueueNumber, DO_CODED_TEXT Service, DO_CODED_TEXT Quota, string LocalID, DO_DATE_TIME BookingStartDate, DO_DATE_TIME BookingExpiryDate)
        //{
        //    string MethodName = "AddProviderScheduling";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.HQS.HealthQueueServiceT2 Srv = new ClientWebService.HQS.HealthQueueServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_HealthQueueService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (HealthcareFacilityUnit == null)
        //                throw new Exception("Argument is missing.");
        //            if (HealthcareFacilityUnit.ID.ID.ToUpper != Healthcarefacility.ID.ToUpper)
        //                throw new Exception("HCF ID is mismatch.");
        //            if (Provider == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.AddProviderScheduling_T2(Provider, HealthcareFacilityUnit, StartDateTime, DurationPerPatient, QueueNumber, Service, Quota, LocalID, BookingStartDate, BookingExpiryDate); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is used to retrieve the list of appointments are set for a healthcare facility
        /////          </summary>
        /////          <param name="HealthcareFacilityUnit">This argument is used to specify the information the healthcare facility for which the time table is exchanged. This arguement is of type HealthOrganizationUnitVO. This datatype is used to manage the organizational structure of outpatient healthcare facilities such as clinics, physicians office, etc. any healthcare facility is identified by a unique Identifer which is of type DO_IDENTIFIER. The healthcarefacilityID is mandatory in this class.</param>
        /////          <param name="Provider">The informaion regarding the healthcare provider is exchanged by this attribute. This argument is of type HealthcareProviderVO. It is noteworthy to mention that only the providerID is mandatory in this class of datatype.</param>
        /////          <param name="StartDateTime">This argument is used to inform the start time of the schedule block. It is used to specify the sart time of the potential appointment. This argument is of tyoe DO_DATE_TIME. All partes of DO_DATE_TIME is mandatory.</param>
        /////          <param name="EndDateTime">This argument is used to inform the end time frame. It is used to specify the end time period to retrive the list of person appointment based on the time period specified. This argument is of type DO_DATE_TIME. All partes of DO_DATE_TIME is mandatory.</param>
        /////          <param name="Service">This argument is used to specify the health service that is to be provided by the healthcare provider. this argument is of type DO_CODED_TEXT.</param>
        /////          <returns>A list of appointments is returned. The data type is an array of PersonAppointmentVO.</returns>
        //public PersonAppointmentVO[] GetAppointments(HealthOrganizationUnitVO HealthcareFacilityUnit, HealthcareProviderVO Provider, DO_DATE_TIME StartDateTime, DO_DATE_TIME EndDateTime, DO_CODED_TEXT Service)
        //{
        //    string MethodName = "GetAppointments";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.HQS.HealthQueueServiceT2 Srv = new ClientWebService.HQS.HealthQueueServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_HealthQueueService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (HealthcareFacilityUnit == null)
        //                throw new Exception("Argument is missing.");
        //            if (HealthcareFacilityUnit.ID.ID.ToUpper != Healthcarefacility.ID.ToUpper)
        //                throw new Exception("HCF ID is mismatch.");
        //            if (Provider == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetAppointments_T2(HealthcareFacilityUnit, Provider, StartDateTime, EndDateTime, Service); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is used to retrieve the appointment information by specifying the tracking qeueue ID.
        /////          </summary>
        /////          <remarks>This method is common among those health qeueue systems that are providing electronic appointment services through websites or mobile applications.</remarks>
        /////          <param name="TQID">Specifies the tracking QeueueID as an input in string format.</param>
        /////          <returns>This method returns a person appointment.</returns>
        //public PersonAppointmentVO GetAppointmentByTQID(string TQID)
        //{
        //    string MethodName = "GetAppointmentByTQID";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.HQS.HealthQueueServiceT2 Srv = new ClientWebService.HQS.HealthQueueServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_HealthQueueService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (TQID == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetAppointmentByTQID_T2(TQID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is used to cancel a provider scheduling. this method can cancel the time even if an appointment is set to it. Thus, it must be used with caution.
        /////          </summary>
        /////          <param name="TrackingQueueID">Specifies the tracking QeueueID of the schedule block as an input in string format.</param>
        /////          <param name="Reason">In order to eliminate an assigned HID, a reason should be prvided to specify why the ID is being eliminated. The reason should be specified with DO_CODED_TEXT data type.</param>
        /////          <returns>The result of this method is in boolean format.</returns>
        //public bool RemoveProviderScheduling(string TrackingQueueID, DO_CODED_TEXT Reason)
        //{
        //    string MethodName = "RemoveProviderScheduling";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.HQS.HealthQueueServiceT2 Srv = new ClientWebService.HQS.HealthQueueServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_HealthQueueService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (TrackingQueueID == null)
        //                throw new Exception("Argument is missing.");
        //            if (Reason == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.RemoveProviderScheduling_T2(TrackingQueueID, Reason); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method synchronizes the list of removed appointmets that the patient has already canceled through the PHC systems, or other health qeueue inquiry systems.
        /////          </summary>
        /////          <param name="StartDateTime">The start time frame for which the available time is searched. This argument is of type DO_DATE_TIME.</param>
        /////          <param name="EndDateTime">The end time frame for which the available time is searched. This argument is of type DO_DATE_TIME.</param>
        /////          <returns>The output of the method is an array of Tracking Qeueue IDs that are canceled by the patient.</returns>
        //public string[] GetRemovedAppointmentList(DO_DATE_TIME StartDateTime, DO_DATE_TIME EndDateTime)
        //{
        //    string MethodName = "GetRemovedAppointmentList";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.HQS.HealthQueueServiceT2 Srv = new ClientWebService.HQS.HealthQueueServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_HealthQueueService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetRemovedAppointmentList_T2(Healthcarefacility, StartDateTime, EndDateTime); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is used to specify the status of the appointment. It can be called regularly, to update the status of the appointment from the patients encounter untill getting visited by the specialits.
        /////          </summary>
        /////          <param name="TrackingQueueID">It indicates the unique identifier of the appointment which is going to be updated.</param>
        /////          <param name="Status">The status of the appointment is specified in this argument. It is of type DO_CODED_TEXT and the terminology is HQS. For further information regarding the terminology please refer to http://coding.behdasht.gov.ir</param>
        /////          <returns>this method retuns boolean which indicates whether the update process was successful or not.</returns>
        //public bool SetAppointmentStatus(string TrackingQueueID, DO_CODED_TEXT Status)
        //{
        //    string MethodName = "SetAppointmentStatus";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.HQS.HealthQueueServiceT2 Srv = new ClientWebService.HQS.HealthQueueServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_HealthQueueService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (TrackingQueueID == null)
        //                throw new Exception("Argument is missing.");
        //            if (Status == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.SetAppointmentStatus_T2(TrackingQueueID, Status); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is used to get the status of an appointment.
        /////          </summary>
        /////          <remarks>The status of any appointment is set while the patient oes to the healthcare facility and it is updated when any stage is updated, for example the patient has come to healthcare facility ontime based on the appointment data, or the patient is in the waiting list to be visited by the specialist, etc.</remarks>
        /////          <param name="TrackingQID">Specifies the tracking QeueueID as an input in string format.</param>
        /////          <returns>The output of this method is DO_CODED_TEXT</returns>
        //public DO_CODED_TEXT GetAppointmentStatus(string TrackingQID)
        //{
        //    string MethodName = "GetAppointmentStatus";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.HQS.HealthQueueServiceT2 Srv = new ClientWebService.HQS.HealthQueueServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_HealthQueueService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (TrackingQID == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetAppointmentStatus_T2(TrackingQID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is used to synchronise the available time table of healthcare providers per specialty, service, date time, etc.
        /////          </summary>
        /////          <param name="Provider">The informaion regarding the healthcare provider is exchanged by this attribute. This argument is of type HealthcareProviderVO. It is noteworthy to mention that only the providerID is mandatory in this class of datatype.</param>
        /////          <param name="HealthcareFacilityUnit">This argument is used to specify the information the healthcare facility for which the time table is exchanged. This arguement is of type HealthOrganizationUnitVO. This datatype is used to manage the organizational structure of outpatient healthcare facilities such as clinics, physicians office, etc. any healthcare facility is identified by a unique Identifer which is of type DO_IDENTIFIER. The healthcarefacilityID is mandatory in this class.</param>
        /////          <param name="StartDateTime">The start time frame for which the available time is searched. This argument is of type DO_DATE_TIME.</param>
        /////          <param name="EndDateTime">The end time frame for which the available time is searched. This argument is of type DO_DATE_TIME.</param>
        /////          <param name="Service">This argument is used to specify the health service that is to be provided by the healthcare provider. this argument is of type DO_CODED_TEXT. The termonology of the service is of type RVU3. The coding is available on: http://coding.behdasht.gov.ir</param>
        /////          <returns>The method returns an array of scheduleBlockVO based on the inputs of the method.</returns>
        //public ScheduleBlockVO[] GetProviderScheduling(HealthcareProviderVO Provider, HealthOrganizationUnitVO HealthcareFacilityUnit, DO_DATE_TIME StartDateTime, DO_DATE_TIME EndDateTime, DO_CODED_TEXT Service)
        //{
        //    string MethodName = "GetProviderScheduling";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.HQS.HealthQueueServiceT2 Srv = new ClientWebService.HQS.HealthQueueServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_HealthQueueService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (Provider == null)
        //                throw new Exception("Argument is missing.");
        //            if (HealthcareFacilityUnit == null)
        //                throw new Exception("Argument is missing.");
        //            if (Service == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetProviderScheduling_T2(Provider, HealthcareFacilityUnit, StartDateTime, EndDateTime, Service); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is used to set an appointment for a patient based on the available time of a specific healthcare provider.
        /////          </summary>
        /////          <param name="Person">This argument is of type PersonInfoVO and is used to specify the demographic data of the petient who is booking an appointment. The patient's national code is mandatory.</param>
        /////          <param name="TrackingQueueID">The unique identifier ragrding the health care provider's available time is mentioned in this argument in String format.</param>
        /////          <param name="HID">This argument is mandatory for the patients who are booking an appointment in referral system. it is of type DO_IDENTIFIER and indicates the patient's referral ID.</param>
        /////          <param name="AppointmentType">The Appointment Type must be specified in this argument. It is used to specify the payment type of the appointment. It is of type DO_CODED_TEXT and the proper terminology for it is HQS. further information regarding this terminology is available on: http://coding.behdasht.gov.ir</param>
        /////          <param name="Deposit">This argument is used to specify the amount of the cost that is payed by the patient while booking the appointment.</param>
        /////          <returns>this method returns a boolean value which indicates if the operation was successful or not.</returns>
        //public bool SetAppointment(PersonInfoVO Person, string TrackingQueueID, DO_IDENTIFIER HID, DO_CODED_TEXT AppointmentType, DO_QUANTITY Deposit)
        //{
        //    string MethodName = "SetAppointment";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.HQS.HealthQueueServiceT2 Srv = new ClientWebService.HQS.HealthQueueServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_HealthQueueService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (Person == null)
        //                throw new Exception("Argument is missing.");
        //            if (TrackingQueueID == null)
        //                throw new Exception("Argument is missing.");
        //            if (HID == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.SetAppointment_T2(Person, TrackingQueueID, HID, AppointmentType, Deposit); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is used to cancel a patient's appointment.
        /////          </summary>
        /////          <param name="TrackingQueueID">Specifies the tracking QeueueID as an input in string format.</param>
        /////          <param name="PersonID">This argument is designed to specify the Patient's unique identifier. This identifier should be a Real World Identifier (RWI). National code is among the most common identifiers. RWIs are technically defined with DO_IDENTIFIER data type.</param>
        /////          <param name="Reason">In order to eliminate an assigned HID, a reason should be prvided to specify why the ID is being eliminated. The reason should be specified with DO_CODED_TEXT data type.</param>
        /////          <returns>The result of the method is boolean which indicates success or failure of the cancelation process.</returns>
        //public bool RemoveAppointment(string TrackingQueueID, DO_IDENTIFIER PersonID, DO_CODED_TEXT Reason)
        //{
        //    string MethodName = "RemoveAppointment";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.HQS.HealthQueueServiceT2 Srv = new ClientWebService.HQS.HealthQueueServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_HealthQueueService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (TrackingQueueID == null)
        //                throw new Exception("Argument is missing.");
        //            if (PersonID == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.RemoveAppointment_T2(TrackingQueueID, PersonID, Reason); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method synchronizes the list of removed provider schedulings that the providing healthcare facilities have already canceled through the PHC systems, or other health qeueue inquiry systems.
        /////          </summary>
        /////          <param name="HealthCareFacilityID">This argument is used to specify the information the healthcare facility for which the time table is exchanged. This arguement is of type DO_IDENTIFIER. which is mandatory.</param>
        /////          <param name="StartDateTime">The start time frame for which the available time is searched. This argument is of type DO_DATE_TIME.</param>
        /////          <param name="EndDateTime">The end time frame for which the available time is searched. This argument is of type DO_DATE_TIME.</param>
        //public string[] GetRemovedProviderSchedulingList(DO_IDENTIFIER HealthCareFacilityID, DO_DATE_TIME StartDateTime, DO_DATE_TIME EndDateTime)
        //{
        //    // Critical_ToDO :check Healthcarefacility
        //    string MethodName = "GetRemovedProviderSchedulingList";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.HQS.HealthQueueServiceT2 Srv = new ClientWebService.HQS.HealthQueueServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_HealthQueueService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (StartDateTime == null)
        //                throw new Exception("Argument is missing.");
        //            if (EndDateTime == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetRemovedProviderSchedulingList_T2(HealthCareFacilityID, StartDateTime, EndDateTime); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is used to retrive the available provider schedulings based on the distance of the patient from the healthcare facilities.
        /////          </summary>
        /////          <remarks>This method is common for the mobile applications.</remarks>
        /////          <param name="Specialty">The specialty of the healthcare provider that the patient needs services from, is mentioned through this argument. The data type of specialty is DO_CODED_TEXT. The coding is thritaEHR.Specialty. The list of the coding is available on: http://coding.behdasht.gov.ir</param>
        /////          <param name="StartDateTime">The start time frame for which the available time is searched. This argument is of type DO_DATE_TIME.</param>
        /////          <param name="EndDateTime">The end time frame for which the available time is searched. This argument is of type DO_DATE_TIME.</param>
        /////          <param name="Service">This argument is used to specify the health service that is to be provided by the healthcare provider. this argument is of type DO_CODED_TEXT. The termonology of the service is of type RVU3. The coding is available on: http://coding.behdasht.gov.ir</param>
        /////          <param name="Latitude">This argument specifies the latitude of the patient inquiring available times. The latitude is specified in double format.</param>
        /////          <param name="Longitude">This argument specifies the longitude of the patient inquiring available times. The longitude in double format.</param>
        /////          <param name="Distance">The distance by which the patient is looking for the near healthcare facility. The distance is mentioned in meters in DO_QUANTITY format.</param>
        /////          <returns>The method returns an array of schedule block to be used in the inquirer system.</returns>
        //public ScheduleBlockVO[] GetNearProviderScheduling(DO_CODED_TEXT Specialty, DO_DATE_TIME StartDateTime, DO_DATE_TIME EndDateTime, DO_CODED_TEXT Service, double Latitude, double Longitude, DO_QUANTITY Distance)
        //{
        //    string MethodName = "GetNearProviderScheduling";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.HQS.HealthQueueServiceT2 Srv = new ClientWebService.HQS.HealthQueueServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_HealthQueueService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (Specialty == null)
        //                throw new Exception("Argument is missing.");
        //            if (StartDateTime == null)
        //                throw new Exception("Argument is missing.");
        //            if (EndDateTime == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetNearProviderScheduling_T2(Specialty, StartDateTime, EndDateTime, Service, Latitude, Longitude, Distance); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is used to synchronise the available time table of healthcare providers per specialty, service, date time, and the geographic location the providing healthcare facility
        /////          </summary>
        /////          <param name="Provider">The informaion regarding the healthcare provider is exchanged by this attribute. This argument is of type HealthcareProviderVO. It is noteworthy to mention that only the providerID is mandatory in this class of datatype.</param>
        /////          <param name="StartDateTime">The start time frame for which the available time is searched. This argument is of type DO_DATE_TIME.</param>
        /////          <param name="EndDateTime">The end time frame for which the available time is searched. This argument is of type DO_DATE_TIME.</param>
        /////          <param name="Service">This argument is used to specify the health service that is to be provided by the healthcare provider. this argument is of type DO_CODED_TEXT. The termonology of the service is of type RVU3. The coding is available on: http://coding.behdasht.gov.ir</param>
        /////          <param name="Location">The geographical location of the providing healthcare facility. The data type is of HighLevelAreaVO class.</param>
        /////          <returns>The method returns an array of scheduleBlockVO based on the inputs of the method.</returns>
        //public ScheduleBlockVO[] GetProviderSchedulingByLocation(HealthcareProviderVO Provider, DO_DATE_TIME StartDateTime, DO_DATE_TIME EndDateTime, DO_CODED_TEXT Service, HighLevelAreaVO Location)
        //{
        //    string MethodName = "GetProviderSchedulingByLocation";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.HQS.HealthQueueServiceT2 Srv = new ClientWebService.HQS.HealthQueueServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_HealthQueueService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        try
        //        {
        //            if (Provider == null)
        //                throw new Exception("Argument is missing.");
        //            if (StartDateTime == null)
        //                throw new Exception("Argument is missing.");
        //            if (EndDateTime == null)
        //                throw new Exception("Argument is missing.");
        //            if (Service == null)
        //                throw new Exception("Argument is missing.");
        //            if (Location == null)
        //                throw new Exception("Argument is missing.");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error at SDK Validation. ", ex);
        //        }
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetProviderSchedulingByLocation_T2(Provider, StartDateTime, EndDateTime, Service, Location); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is used to specify the status of the hospital beds.
        /////          </summary>
        /////          <param name="Bed">This argement is used to specify the hospital beds along with their status. It is of Tyoe NationalHospitalStatusVO</param>
        /////          <returns>if the transaction is successful, the method returns a unique identifier that indicates the success transaction. this identifier can be used for further transactions of the specific bed.</returns>
        //public DO_IDENTIFIER SetHospitalBed(NationalHospitalStatusVO Bed)
        //{
        //    try
        //    {
        //        DO_IDENTIFIER Location = GetHealthCareFacility();
        //        ClientWebService.ServiceHospitalBeds.ServiceHospitalBeds srv = new ClientWebService.ServiceHospitalBeds.ServiceHospitalBeds();
        //        srv.Url = Urls.URL_HospitalBedService;
        //        // 'Dim v As New Variable
        //        // headerMessageVOValue = New HeaderMessageVO
        //        // headerMessageVOValue.Sender = New SystemSenderVO
        //        // headerMessageVOValue.Sender.SystemID = v.GetSystemID
        //        // headerMessageVOValue.Sender.LocationID = Location.ID
        //        // headerMessageVOValue.Sender.URL = "0"
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        // -------------------------(Begin-PrimaryDefinition)------------------------'
        //        DO_IDENTIFIER SystemID, LocationID;
        //        SystemID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.SystemID, Issuer = "MOHME_IT", Type = "System_ID" };
        //        LocationID = new DO_IDENTIFIER() { Assigner = "MOHME_IT", ID = headerMessageVOValue.Sender.LocationID, Issuer = "MOHME_IT", Type = "Org_ID" };
        //        // -------------------------(End-PrimaryDefinition)------------------------'
        //        // -------------------------(Begin-MsgID)------------------------'
        //        if (Bed == null)
        //            throw new Exception("Object is null.");
        //        if (Bed.Hospital == null)
        //            throw new Exception("MsgID is null.");
        //        Bed.Hospital = LocationID;
        //        // -------------------------(End-MsgID)------------------------'
        //        GeneralResponseMessageVO r;
        //        Crypto sec = new Crypto();
        //        byte[] b;
        //        b = sec.SecuredObject(Bed);
        //        r = srv.SetHospitalBedSecure_T2(b);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        return result;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException("SetHospitalBed", ex));
        //    }
        //}
        ///// <summary>
        /////          This method is used to register healthcare facilities in SIAM datawarhouse.
        /////          </summary>
        /////          <param name="OrganizationDetail">This argument specifies the detailed information regarding the healthcare facility which is of type OrganizationDetailVO.</param>
        /////          <returns>The method returns a unique identifier as healthcare facility ID in DO_IDENTIFIER format.</returns>
        //public DO_IDENTIFIER AddOrganization(OrganizationDetailVO OrganizationDetail)
        //{
        //    string MethodName = "AddOrganization";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.SIAM.OrganizationT2 Srv = new ClientWebService.SIAM.OrganizationT2();  // Service Define
        //        Srv.Url = Urls.URL_SIAMService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.AddOrganization_T2(OrganizationDetail); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to update the organization information.        
        /////          </summary>        
        /////          <param name="OrganizationDetail">This argument specifies the organization Details. This argument is of type OrganizationDetailVO.</param>        
        /////          <returns>The method returns boolean indicating either the transaction was successful or not.</returns>
        //public bool UpdateOrganization(OrganizationDetailVO OrganizationDetail)
        //{
        //    string MethodName = "UpdateOrganization";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.SIAM.OrganizationT2 Srv = new ClientWebService.SIAM.OrganizationT2();  // Service Define
        //        Srv.Url = Urls.URL_SIAMService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.UpdateOrganization_T2(OrganizationDetail); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is to get the child organizations underneath the organizations.
        /////          </summary>
        /////          <param name="ParentOrganizationID">The first argument indocates the parent organization as DO_IDENTIFIER.</param>
        /////          <param name="OrganizationType">The second argement show the type of the organization in DO_CODED_TEXT format.</param>
        /////          <param name="FromDate">The last argument is used to retrieve the list based on a prespecified date.</param>
        /////          <returns>This method returuns a list of organization IDs in DO_IDENTIFIER format.</returns>
        //public DO_IDENTIFIER[] GetChildOrganizations(DO_IDENTIFIER ParentOrganizationID, DO_CODED_TEXT OrganizationType, DO_DATE_TIME FromDate)
        //{
        //    string MethodName = "GetChildOrganizations";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.SIAM.OrganizationT2 Srv = new ClientWebService.SIAM.OrganizationT2();  // Service Define
        //        Srv.Url = Urls.URL_SIAMService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetChildOrganizations_T2(ParentOrganizationID, OrganizationType, FromDate); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to get the Organization information by its unique identifier.        
        /////          </summary>        
        /////          <param name="OrganizationID">This argument specifies the organization unique identifier. This argument is of type DO_IDENTIFIER.</param>        
        /////          <returns>The method returns the detailed information of the organization as a OrganizationDetailVO.</returns>
        //public OrganizationDetailVO GetOrganization(DO_IDENTIFIER OrganizationID)
        //{
        //    string MethodName = "GetOrganization";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.SIAM.OrganizationT2 Srv = new ClientWebService.SIAM.OrganizationT2();  // Service Define
        //        Srv.Url = Urls.URL_SIAMService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetOrganization_T2(OrganizationID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to get the parent organization of any organization.        
        /////          </summary>        
        /////          <param name="OrganizationID">This argument specifies the organization uniqueidentifier. This argument is of type DO_IDENTIFIER.</param>        
        /////          <returns>The method returns the parent organization uniqueidentifier as a DO_IDENTIFIER.</returns>
        //public DO_IDENTIFIER GetParentOrganization(DO_IDENTIFIER OrganizationID)
        //{
        //    string MethodName = "GetParentOrganization";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.SIAM.OrganizationT2 Srv = new ClientWebService.SIAM.OrganizationT2();  // Service Define
        //        Srv.Url = Urls.URL_SIAMService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetParentOrganization_T2(OrganizationID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is designed to register new System and return its corresponding system ID.
        /////          </summary>
        /////          <param name="System">This argument specifies the Information System Details. This argument is of type SystemVO.</param>
        /////          <returns>Identifier of the System as a DO_IDENTIFIER.</returns>
        //public DO_IDENTIFIER AddNewSystem(SystemVO System)
        //{
        //    string MethodName = "AddNewSystem";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.POCSRA.WebServiceT2 Srv = new ClientWebService.POCSRA.WebServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_POCSRAService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        // Critical_ToDO AddNewSystem
        //        // r = Srv.AddNewSystem_T2(System) '---------------------------Service Call
        //        throw new Exception("Error 0");
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is used to add the system being used in any healthcare facility.
        /////          </summary>
        /////          <param name="OrganizationID">The first argument to the method is the unique identifier of the organization. It is of type DO_IDENTIFIER.</param>
        /////          <param name="SystemID">The second argument specifies the unique identifier of the information system being used at any healthcare facility.</param>
        /////          <param name="SystemVersion">This argument indicates the version of the infromation system being used at any healthcare facility.</param>
        /////          <returns>The method returns boolean value indicating whether the operation was successful or not.</returns>
        //public bool AddOrganizationSystem(DO_IDENTIFIER OrganizationID, DO_IDENTIFIER SystemID, string SystemVersion)
        //{
        //    string MethodName = "AddOrganizationSystem";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.POCSRA.WebServiceT2 Srv = new ClientWebService.POCSRA.WebServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_POCSRAService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.AddOrganizationSystem_T2(OrganizationID, SystemID, SystemVersion); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is used to approve and enable the previously registerd information system.
        /////          </summary>
        /////          <param name="SystemID">This argumnet specifies the information system unique identifier in DO_IDENTIFIER data type.</param>
        /////          <returns>This method returns True or False indicating whether the operation was successful or not.</returns>
        //public bool ApproveSystem(DO_IDENTIFIER SystemID)
        //{
        //    string MethodName = "ApproveSystem";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.POCSRA.WebServiceT2 Srv = new ClientWebService.POCSRA.WebServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_POCSRAService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.ApproveSystem_T2(SystemID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is used to delete the previous relation between a healthcare facility and an information system by the IDs of them.
        /////          </summary>
        /////          <param name="OrganizationID">This argument specifies the healthcare facility ID as a DO_IDENTIFIER.</param>
        /////          <param name="SystemID">This argument specifies the System ID as a DO_IDENTIFIER.</param>
        /////          <returns>This method returns True or False indicating whether the opration was successful or not.</returns>
        //public bool DeleteOrganizationSystem(DO_IDENTIFIER OrganizationID, DO_IDENTIFIER SystemID)
        //{
        //    string MethodName = "DeleteOrganizationSystem";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.POCSRA.WebServiceT2 Srv = new ClientWebService.POCSRA.WebServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_POCSRAService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.DeleteOrganizationSystem_T2(OrganizationID, SystemID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>
        /////          This method is used to disapprove an information system so that it would not be able to exchange data through available services.
        /////          </summary>
        /////          <param name="SystemID">This argument specifies the unique identifier of the information system</param>
        /////          <returns>The method returns True or False indicating whether the operation was successful or not.</returns>
        //public bool DisapproveSystem(DO_IDENTIFIER SystemID)
        //{
        //    string MethodName = "DisapproveSystem";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.POCSRA.WebServiceT2 Srv = new ClientWebService.POCSRA.WebServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_POCSRAService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.DisapproveSystem_T2(SystemID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to update the system information.        
        /////          </summary>        
        /////          <param name="SystemID">This argument specifies the system identifier. This argument is of type DO_IDENTIFIER.</param>        
        /////          <param name="System">This argument specifies the system details. This argument is of type SystemVO.</param>
        /////          <returns>The method returns boolean indicating either the transaction was successful or not.</returns>
        //public bool UpdateSystem(DO_IDENTIFIER SystemID, SystemVO System)
        //{
        //    string MethodName = "UpdateSystem";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.POCSRA.WebServiceT2 Srv = new ClientWebService.POCSRA.WebServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_POCSRAService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.UpdateSystem_T2(SystemID, System); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to get the organization IDs associated with a specific system ID.        
        /////          </summary>        
        /////          <param name="SystemID">This argument specifies the System ID. This argument is of type DO_IDENTIFIER.</param>        
        /////          <returns>The method returns an array of Organization IDs as DO_IDENTIFIER.</returns>
        //public DO_IDENTIFIER[] GetOrganizationIDs(DO_IDENTIFIER SystemID)
        //{
        //    string MethodName = "GetOrganizationIDs";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.POCSRA.WebServiceT2 Srv = new ClientWebService.POCSRA.WebServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_POCSRAService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetOrganizationIDs_T2(SystemID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to get the system information by its system id.        
        /////          </summary>        
        /////          <param name="SystemID">This argument specifies the uniqueidentifier of the system. This argument is of type DO_IDENTIFIER.</param>        
        /////          <returns>The method returns an array of system information as SystemVO.</returns>
        //public SystemVO[] GetSystem(DO_IDENTIFIER SystemID)
        //{
        //    string MethodName = "GetSystem";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.POCSRA.WebServiceT2 Srv = new ClientWebService.POCSRA.WebServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_POCSRAService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetSystem_T2(SystemID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to get the list of System IDs per POCS type.        
        /////          </summary>        
        /////          <param name="POCSType">This argument specifies the the type of point of care system. This argument is of type DO_CODED_TEXT.</param>        
        /////          <returns>The method returns an array of systemIDs as DO_IDENTIFIER.</returns>
        //public DO_IDENTIFIER[] GetSystemIDs(DO_CODED_TEXT POCSType)
        //{
        //    string MethodName = "GetSystemIDs";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.POCSRA.WebServiceT2 Srv = new ClientWebService.POCSRA.WebServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_POCSRAService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetSystemIDs_T2(POCSType); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to get the system IDs per organization.        
        /////          </summary>        
        /////          <param name="OrganizationID">This argument specifies the organization unique identifier. This argument is of type DO_IDENTIFIER.</param>        
        /////          <returns>The method returns an array of systems IDs as DO_IDENTIFIER.</returns>
        //public DO_IDENTIFIER[] GetSystemIDsByOrganization(DO_IDENTIFIER OrganizationID)
        //{
        //    string MethodName = "GetSystemIDsByOrganization";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.POCSRA.WebServiceT2 Srv = new ClientWebService.POCSRA.WebServiceT2();  // Service Define
        //        Srv.Url = Urls.URL_POCSRAService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetSystemIDsByOrganization_T2(OrganizationID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        //public string CallHIX(string msg)
        //{
        //    string MethodName = "CallHIX";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.HIX.HIXManagment Srv = new ClientWebService.HIX.HIXManagment();  // Service Define
        //        Srv.Url = Urls.URL_HIXSampleService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.CallHIX(msg); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }// ---------Function Name
        //}
        ///// <summary>
        /////          This method is used to add new DITASRA user info, based on the user's personal Info.
        /////          </summary>
        /////          <remarks>This method submits the user information to the DITASRA data repository and returns the UserID.</remarks>
        /////          <param name="UserName">The argument to this method is the username generated by the DITASRA system and the data type is String.</param>
        /////          <param name="UserPassword">The argument to this method is the password of the user, generated by the DITASRA system and the data type is String.</param>
        /////          <param name="UserTitle">The argument to this method is the title of the user, generated by the DITASRA system and the data type is String.</param>
        /////          <param name="FirstName">The argument to this method is the first name of the user, generated by the DITASRA system and the data type is String.</param>
        /////          <param name="LastName">The argument to this method is the last name of the user, generated by the DITASRA system and the data type is String.</param>
        /////          <param name="NationalCode">The argument to this method is the national code of the user, generated by the DITASRA system and the data type is String. This property is mandatory.</param>
        /////          <param name="Email">The argument to this method is the email of the user, generated by the DITASRA system and the data type is String. </param>
        /////          <param name="Mobile">The argument to this method is the mobile number of the user, generated by the DITASRA system and the data type is String. </param>
        /////          <param name="Tel">The argument to this method is the telephone number of the user, generated by the DITASRA system and the data type is String. </param>
        /////          <param name="OrgID">The argument to this method is the Organization Unique Identifier of the user, to which the user belongs. The OrganizationID should be consistent with SIAM and the data type is DO_IDENTIFIER. </param>
        /////          <param name="RoleID">The argument to this method is the roles of the user in the DITASRA system and the data type is an array of Strings. </param>
        /////          <param name="PostID">The argument to this method is the post of the user in the selected organization, in the DITASRA system and the data type is String. </param>
        /////          <returns>This method returns the UserID of the DITASRA system. The data type is String.</returns>
        //public string AddNewUser(string UserName, string UserPassword, string UserTitle, string FirstName, string LastName, string NationalCode, string Email, string Mobile, string Tel, DO_IDENTIFIER OrgID, string[] RoleID, string PostID)
        //{
        //    string MethodName = "AddNewUser";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.DITASRA.ServiceT2 Srv = new ClientWebService.DITASRA.ServiceT2(); // Service Define
        //        Srv.Url = Urls.URL_DITASRAService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.AddNewUser_T2(UserName, UserPassword, UserTitle, FirstName, LastName, NationalCode, Email, Mobile, Tel, OrgID, RoleID, PostID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        //public bool EditUser(string UserID, string UserName, string UserPassword, string UserTitle, string FirstName, string LastName, string NationalCode, string Email, string Mobile, string Tel, string[] RoleID, string PostID)
        //{
        //    string MethodName = "EditUser";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.DITASRA.ServiceT2 Srv = new ClientWebService.DITASRA.ServiceT2(); // Service Define
        //        Srv.Url = Urls.URL_DITASRAService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.EditUser_T2(UserID, UserName, UserPassword, UserTitle, FirstName, LastName, NationalCode, Email, Mobile, Tel, RoleID, PostID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to get the list of available the SDKs per Point of Care System type.        
        /////          </summary>        
        /////          <param name="POCSType">This argument specifies the type of the point of care system. This argument is of type DO_CODED_TEXT.</param>        
        /////          <returns>The method returns an array of SDKs as DO_CODED_TEXT.</returns>
        //public DO_CODED_TEXT[] GetSDKList(DO_CODED_TEXT POCSType)
        //{
        //    string MethodName = "GetSDKList";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.DITASRA.ServiceT2 Srv = new ClientWebService.DITASRA.ServiceT2(); // Service Define
        //        Srv.Url = Urls.URL_DITASRAService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetSDKList_T2(POCSType); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to get the list of available services per SDK type.        
        /////          </summary>        
        /////          <param name="SDKType">This argument specifies the type of the SDK. This argument is of type DO_CODED_TEXT.</param>        
        /////          <returns>The method returns an array of available services as MethodVO.</returns>
        //public MethodVO[] GetServiceList(DO_CODED_TEXT SDKType)
        //{
        //    string MethodName = "GetServiceList";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.DITASRA.ServiceT2 Srv = new ClientWebService.DITASRA.ServiceT2(); // Service Define
        //        Srv.Url = Urls.URL_DITASRAService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetServiceList_T2(SDKType); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to register the information of an issued token.        
        /////          </summary>        
        /////          <param name="SystemID">This argument specifies identifier of the system. This argument is of type DO_IDENTIFIER.</param>        
        /////          <param name="LocationID">This argument specifies identifier of the location. This argument is of type DO_IDENTIFIER.</param>
        /////          <param name="UserID">This argument specifies identifier of the user in DITASRA. This argument is of type String.</param>
        /////          <param name="PackageName">This argument specifies name of the service package. This argument is of type String.</param>
        /////          <param name="SDKType">This argument specifies the type of the SDK. This argument is of type DO_CODED_TEXT.</param>
        /////          <returns>The method returns boolean indicating either the tranaction was successful or not.</returns>
        //public bool RegisterToken(DO_IDENTIFIER SystemID, DO_IDENTIFIER LocationID, string UserID, string PackageName, DO_CODED_TEXT SDKType)
        //{
        //    string MethodName = "RegisterToken";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.DITASRA.ServiceT2 Srv = new ClientWebService.DITASRA.ServiceT2(); // Service Define
        //        Srv.Url = Urls.URL_DITASRAService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.RegisterToken_T2(SystemID, LocationID, PackageName, UserID, SDKType); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to revoke an already issued token for a user.        
        /////          </summary>        
        /////          <param name="UserID">This argument specifies the user uniqueidentifier in DITASRA. This argument is of type String.</param>        
        /////          <returns>The method returns boolean indicating either the transaction was successful of not.</returns>
        //public bool RevokeToken(string UserID)
        //{
        //    string MethodName = "RevokeToken";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.DITASRA.ServiceT2 Srv = new ClientWebService.DITASRA.ServiceT2(); // Service Define
        //        Srv.Url = Urls.URL_DITASRAService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.RevokeToken_T2(UserID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        //public bool ApproveUser(string UserID)
        //{
        //    string MethodName = "ApproveUser";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.DITASRA.ServiceT2 Srv = new ClientWebService.DITASRA.ServiceT2(); // Service Define
        //        Srv.Url = Urls.URL_DITASRAService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.ApproveUser_T2(UserID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        //public bool DisapproveUser(string UserID)
        //{
        //    string MethodName = "DisapproveUser";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.DITASRA.ServiceT2 Srv = new ClientWebService.DITASRA.ServiceT2(); // Service Define
        //        Srv.Url = Urls.URL_DITASRAService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.DisapproveUser_T2(UserID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to get the packages of service calls per SDK Type.        
        /////          </summary>        
        /////          <param name="SDKType">This argument specifies the type of the SDK. This argument is of type DO_CODED_TEXT.</param>        
        /////          <returns>The method returns an array of packages each as a MethodCallPackageVO.</returns>
        //public MethodCallPackageVO[] GetPackages(DO_CODED_TEXT SDKType)
        //{
        //    string MethodName = "GetPackages";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.DITASRA.ServiceT2 Srv = new ClientWebService.DITASRA.ServiceT2(); // Service Define
        //        Srv.Url = Urls.URL_DITASRAService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetPackages_T2(SDKType); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to update the package for each system in any healthcare facility.        
        /////          </summary>        
        /////          <param name="SystemID">This argument specifies the systemID. This argument is of type DO_IDENTIFIER.</param>        
        /////          <param name="LocationID">This argument specifies the healthcare facility. This argument is of type DO_IDENTIFIER.</param>  
        /////          <param name="PackageName">This argument specifies the name of the package. This argument is of type String.</param>  
        /////          <param name="UserID">This argument specifies the id of the user in DITASRA. This argument is of type String.</param>  
        /////          <param name="SDKType">This argument specifies the type of the SDK. This argument is of type DO_CODED_TEXT.</param>  
        /////          <returns>The method returns boolean indicating either the transaction was successful or not.</returns>
        //public bool UpdatePackage(DO_IDENTIFIER SystemID, DO_IDENTIFIER LocationID, string PackageName, string UserID, DO_CODED_TEXT SDKType)
        //{
        //    string MethodName = "UpdatePackage";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.DITASRA.ServiceT2 Srv = new ClientWebService.DITASRA.ServiceT2(); // Service Define
        //        Srv.Url = Urls.URL_DITASRAService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.UpdatePackage_T2(SystemID, LocationID, PackageName, UserID, SDKType); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        ///// <summary>        
        /////          This method is designed to get the call count of the user.        
        /////          </summary>        
        /////          <param name="UserID">This argument specifies the userID according to DITASRA. This argument is of type String.</param>        
        /////          <returns>The method returns the call count and detailed information as an array of UserCallCountVOs.</returns>
        //public UserCallCountVO[] GetUserCallCount(string UserID)
        //{
        //    string MethodName = "GetUserCallCount";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.DITASRA.ServiceT2 Srv = new ClientWebService.DITASRA.ServiceT2(); // Service Define
        //        Srv.Url = Urls.URL_DITASRAService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.GetUserCallCount_T2(UserID); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}
        //public EquipmentMessageResultVO SubmitEquipment(EquipmentInventoryMessageVO EquipmentInventoryMessage)
        //{
        //    string MethodName = "SubmitEquipment";
        //    try
        //    {
        //        // ------------------------part1------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer TimeTotal = new SDK.AdditionalTools.Basic.Chronometer();
        //        DO_IDENTIFIER Healthcarefacility = GetHealthCareFacility();
        //        ClientWebService.MEMS.ServiceT2 Srv = new ClientWebService.MEMS.ServiceT2(); // Service Define
        //        Srv.Url = Urls.URL_MEMSService; // -------------------'Service URL
        //        string KP = "";
        //        headerMessageVOValue = _CreateHeader();
        //        KP = _ExtractKeyPair(headerMessageVOValue);
        //        GeneralResponseMessageVO r;
        //        // ------------------------part1------------------------------------------
        //        Crypto sec = new Crypto();
        //        byte[] b;
        //        b = sec.SecuredObject(EquipmentInventoryMessage);
        //        // ------------------------part2------------------------------------------
        //        SDK.AdditionalTools.Basic.Chronometer Time = new SDK.AdditionalTools.Basic.Chronometer();
        //        r = Srv.SubmitEquipmentSecure_T2(b); // ---------------------------Service Call
        //        _WL("...Call Service Time [" + MethodName + "]", Time);
        //        object result = _ReturnGeneralResponseMessage(r, KP);
        //        _WL("CallHIX Total Time", TimeTotal);
        //        return result;
        //    }
        //    // ------------------------part2------------------------------------------
        //    catch (Exception ex)
        //    {
        //        throw new Exception(MainFx.CreateException(MethodName, ex));
        //    }
        //}

        #endregion

    }
}