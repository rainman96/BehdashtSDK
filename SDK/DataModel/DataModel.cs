using System;
using System.Xml.Serialization;


namespace Ditas.SDK
{
    internal partial class VersionControl
    {
        public int Version_Datamodel = 6;
    }
}
// this is outside
namespace Ditas.SDK.DataModel
{
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/")]
    public class DO_CODED_TEXT
    {
        [XmlAttribute]
        public string Value { get; set; }
        [XmlAttribute]
        public string Terminology_id { get; set; }
        [XmlAttribute]
        public string Coded_string { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/")]
    public partial class InputPackage
    {
        /// <remarks/>
        public string CommandName { get; set; }
        /// <remarks/>
        public string InputType { get; set; }
        /// <remarks/>
        public object Inputs { get; set; }
        /// <remarks/>
        public bool IsArray { get; set; }
        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/")]
        public partial class OutputPackage
        {
            /// <remarks/>
            public string OutputType { get; set; }
            /// <remarks/>
            public string OutputTypeAssemblyQualifiedName { get; set; }
            /// <remarks/>
            public object Output { get; set; }
            /// <remarks/>
            public bool IsArray { get; set; }
            /// <remarks/>
            [System.Xml.Serialization.XmlElement(DataType = "base64Binary")]
            public byte[] OutputObjectByte { get; set; }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class HIDPathVO
    {
        /// <remarks/>
        public DO_IDENTIFIER HID { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER HCPID { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER HCFID { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER ParentHID { get; set; }
        /// <remarks/>
        public DO_DATE_TIME IssueDate { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class DO_IDENTIFIER
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Issuer { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Assigner { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string ID { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Type { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class DO_DATE_TIME
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> Year { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> Month { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> Day { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> Hour { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> Minute { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> Second { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string ISOString { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class EducationGeneralInfoVO
    {
        /// <remarks/>
        public string _StudentID { get; set; }
        /// <remarks/>
        public DO_DATE _GraduationDate { get; set; }
        /// <remarks/>
        public DO_DATE GraduationDate { get; set; }
        /// <remarks/>
        public string StudentID { get; set; }
        /// <remarks/>
        public PersonVO PersonInfo { get; set; }
        /// <remarks/>
        public DO_CODEABLE_CONCEPT UniversityName { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER University_SIAMID { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT University_Country { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT EducationField { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT EducationLevel { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT AreaOfInterest { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT EducationLevelType { get; set; }
        /// <remarks/>
        public DO_DATE EducationStartDate { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<double> Average { get; set; }
        /// <remarks/>
        public string Description { get; set; }
        /// <remarks/>
        public UndefinedDataVO[] ExtraProperties { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class DO_DATE
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> Year { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> Month { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> Day { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string ISOString { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class PersonVO
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<bool> DeathStatus { get; set; }
        /// <remarks/>
        public DO_DATE DeathDate { get; set; }
        /// <remarks/>
        public PersonIdentifierVO[] OtherIdentifier { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Nationality { get; set; }
        /// <remarks/>
        public DO_DATE BirthDate { get; set; }
        /// <remarks/>
        public string Father_FirstName { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Gender { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string FirstName { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string LastName { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string NationalCode { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class PersonIdentifierVO
    {
        /// <remarks/>
        public DO_IDENTIFIER Identifier { get; set; }
        /// <remarks/>
        public DO_DATE ExpireDate { get; set; }
        /// <remarks/>
        public DO_DATE IssueDate { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<bool> Expired { get; set; }
        /// <remarks/>
        public string SerialNumber { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class DO_CODEABLE_CONCEPT
    {
        /// <remarks/>
        public string Text { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Coding { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class UndefinedDataVO
    {
        /// <remarks/>
        public DO_CODED_TEXT Element { get; set; }
        /// <remarks/>
        public string Value { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class LegalPersonInfoVO
    {
        /// <remarks/>
        public string Name { get; set; }
        /// <remarks/>
        public string FollowupNo { get; set; }
        /// <remarks/>
        public string NationalCode { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Status { get; set; }
        /// <remarks/>
        public DO_DATE EstablishmentDate { get; set; }
        /// <remarks/>
        public DO_DATE RegisterDate { get; set; }
        /// <remarks/>
        public string RegisterNumber { get; set; }
        /// <remarks/>
        public string Address { get; set; }
        /// <remarks/>
        public string PostalCode { get; set; }
        /// <remarks/>
        public DO_DATE LastModifiedDate { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class VeteranInfoVO
    {
     
        /// <remarks/>
        public PersonVO PersonInfo { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT VeteranQuota { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class VeteranStatusVO
    {
   
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<bool> IsMartyr { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<bool> IsCaptive { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<bool> IsMissing { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<bool> IsDisabled { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<bool> IsReleased { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> DisabledPercent { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> CaptivityDurationDays { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class VeteranGeneralInfoVO
    {
       
        /// <remarks/>
        public PersonVO PersonInfo { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER ApplicantID { get; set; }
        /// <remarks/>
        public VeteranStatusVO VeteranStatus { get; set; }
        /// <remarks/>
        public VeteranStatusVO VeteranSiblingStatus { get; set; }
        /// <remarks/>
        public VeteranStatusVO VeteranParentStatus { get; set; }
        /// <remarks/>
        public VeteranStatusVO VeteranChildStatus { get; set; }
        /// <remarks/>
        public VeteranStatusVO VeteranSpouseStatus { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class PostalAddressVO
    {
       
        /// <remarks/>
        public HighLevelAreaVO HighLevelArea { get; set; }
        /// <remarks/>
        public AddressDetailsVO AddressDetails { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class HighLevelAreaVO
    {
      
        /// <remarks/>
        public DO_CODED_TEXT NationalAreaCode { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Country { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Province { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT City { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Town { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT District { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT RuralArea { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Village { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class AddressDetailsVO
    {
      
        /// <remarks/>
        public string Avenue { get; set; }
        /// <remarks/>
        public string BuildingName { get; set; }
        /// <remarks/>
        public string Description { get; set; }
        /// <remarks/>
        public string FloorNo { get; set; }
        /// <remarks/>
        public string HouseNo { get; set; }
        /// <remarks/>
        public string PreAvenue { get; set; }
        /// <remarks/>
        public string SideFloor { get; set; }
        /// <remarks/>
        public string Parish { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER PostalCode { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class PhoneAddressVO
    {
        /// <remarks/>
        public string OperatorName { get; set; }
        /// <remarks/>
        public string PhoneNumber { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER PostalCode { get; set; }
        /// <remarks/>
        public string AddressDetail { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class MobileLocationVO
    {
        /// <remarks/>
        public string OperatorName { get; set; }
        /// <remarks/>
        public string MobileNumber { get; set; }
        /// <remarks/>
        public DO_DATE_TIME DateTime { get; set; }
        /// <remarks/>
        public GeographicalCoordinatesVO Location { get; set; }
        /// <remarks/>
        public HighLevelAreaVO HighLevelAddress { get; set; }
        /// <remarks/>
        public string AddressDetail { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class GeographicalCoordinatesVO
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<double> Latitude { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<double> Longitude { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class UserCallCountVO
    {
        /// <remarks/>
        public MethodCallLimitationVO CallLimitation { get; set; }
        /// <remarks/>
        public DO_DATE LastDayCall { get; set; }
        /// <remarks/>
        public int TotalCall { get; set; }
        /// <remarks/>
        public int LastDayCallCount { get; set; }
        /// <remarks/>
        public int FailedCallCount { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class MethodCallLimitationVO
    {
        /// <remarks/>
        public MethodVO Method { get; set; }
        /// <remarks/>
        public int LimitCallPerDay { get; set; }
        /// <remarks/>
        public int LimitTotalCall { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class MethodVO
    {
        /// <remarks/>
        public string methodName { get; set; }
        /// <remarks/>
        public string ServiceName { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class MethodCallPackageVO
    {
        /// <remarks/>
        public string PackageName { get; set; }
        /// <remarks/>
        public MethodCallLimitationVO[] CallLimitation { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://it.behdasht.gov.ir/")]
    public partial class EquipmentMessageResultVO
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlArray()]
        public byte[] Channel { get; set; }
        /// <remarks/>
        public string MessageID { get; set; }
        /// <remarks/>
        public string ErrorMessage { get; set; }
        /// <remarks/>
        public string NEIN { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://it.behdasht.gov.ir/")]
    public partial class EquipmentMessageIdentifierVO
    {
        /// <remarks/>
        public string NEIN { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Status { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER SystemID { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER LocationID { get; set; }
        /// <remarks/>
        public SignatureVO Sign { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://it.behdasht.gov.ir/")]
    public partial class OrganizationUnitVO
    {
        /// <remarks/>
        public string Name { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER Identification { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://it.behdasht.gov.ir/")]
    public partial class OrganizationLocationVO
    {
        /// <remarks/>
        public OrganizationUnitVO ParentOrganization { get; set; }
        /// <remarks/>
        public OrganizationUnitVO Organization { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT OrganizationType { get; set; }
        /// <remarks/>
        public OrganizationUnitVO Department { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT DepartmentType { get; set; }
        /// <remarks/>
        public OrganizationUnitVO Building { get; set; }
        /// <remarks/>
        public string Room { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://it.behdasht.gov.ir/")]
    public partial class MedicalEquipmentInfoVO
    {
        /// <remarks/>
        public string LocalEquipmentInventoryNumber { get; set; }
        /// <remarks/>
        public string NationalEquipmentInventoryNumber { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT EquipmentType { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT EquipmentStatus { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT InactiveReason { get; set; }
        /// <remarks/>
        public string InactiveReasonDescription { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT EquipmentCode { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT EquipmentUse { get; set; }
        /// <remarks/>
        public string ModelNumber { get; set; }
        /// <remarks/>
        public DO_CODEABLE_CONCEPT Mark { get; set; }
        /// <remarks/>
        public string ManufacturerSerialNumber { get; set; }
        /// <remarks/>
        public DO_QUANTITY PurchasePrice { get; set; }
        /// <remarks/>
        public string ManufacturerName { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER ManufacturerIdentifier { get; set; }
        /// <remarks/>
        public string VendorName { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER VendorIdentifier { get; set; }
        /// <remarks/>
        public string AgentCompanyName { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER AgentCompanyIdentifier { get; set; }
        /// <remarks/>
        public DO_DATE InstallationDate { get; set; }
        /// <remarks/>
        public DO_DATE OperationDate { get; set; }
        /// <remarks/>
        public DO_DATE PurchaseDate { get; set; }
        /// <remarks/>
        public DO_DATE ConstructionDate { get; set; }
        /// <remarks/>
        public DO_DATE WarrantyExpirationDate { get; set; }
        /// <remarks/>
        public OrganizationLocationVO Location { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT ManufacturerCountry { get; set; }
        /// <remarks/>
        public UndefinedDataVO[] ExtraProperties { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class DO_QUANTITY
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<double> Magnitude { get; set; }
        /// <remarks/>
        public string MagnitudeStatus { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Unit { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://it.behdasht.gov.ir/")]
    public partial class EquipmentInventoryMessageVO
    {
        /// <remarks/>
        public MedicalEquipmentInfoVO EquipmentInfo { get; set; }
        /// <remarks/>
        public EquipmentMessageIdentifierVO MessageIdentifier { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class DrugInfoVO
    {
        /// <remarks/>
        public string DrugGenericName { get; set; }
        /// <remarks/>
        public string LicenseOwnerCompanyName { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER LicenseOwnerCompanyID { get; set; }
        /// <remarks/>
        public string ProducerCompanyName { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER ProducerCompanyID { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT IRC { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT GTIN { get; set; }
        /// <remarks/>
        public DO_QUANTITY ConsumerPrice { get; set; }
        /// <remarks/>
        public DO_QUANTITY DistributerPrice { get; set; }
        /// <remarks/>
        public DO_QUANTITY PharmacyPrice { get; set; }
        /// <remarks/>
        public string FaFullTradeName { get; set; }
        /// <remarks/>
        public string EnFullTradeName { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class EquipmentInfoVO
    {
        /// <remarks/>
        public string LicenseOwnerCompanyName { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER LicenseOwnerCompanyID { get; set; }
        /// <remarks/>
        public string ProducerCompanyName { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER ProducerCompanyID { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT ProducerCountry { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT IRC { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT GTIN { get; set; }
        /// <remarks/>
        public string FaFullTradeName { get; set; }
        /// <remarks/>
        public string EnFullTradeName { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://sepas.behdasht.gov.ir/")]
    public partial class HealthInsuranceClaimIdentifierVO
    {
        /// <remarks/>
        public string ID { get; set; }
        /// <remarks/>
        public string ErrorMessage { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlArray()]
        public byte[] Channel { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<DateTime> DateTimeForResponse { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class CoverageServiceDetailsVO
    {
        /// <remarks/>
        public string PKID { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Service { get; set; }
        /// <remarks/>
        public DO_QUANTITY BasicInsuranceContribution { get; set; }
        /// <remarks/>
        public DO_QUANTITY PatientContribution { get; set; }
        /// <remarks/>
        public DO_QUANTITY TotalCharge { get; set; }
        /// <remarks/>
        public QuantitiesVO[] OtherCosts { get; set; }
        /// <remarks/>
        public RelativeCostVO[] RelativeCost { get; set; }
        /// <remarks/>
        public InquiryResultVO[] InquiryResult { get; set; }
        /// <remarks/>
        public DO_QUANTITY ServiceCount { get; set; }
        /// <remarks/>
        public CoverageServiceDetailsVO[] RelatedService { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER ConfirmationID { get; set; }
        /// <remarks/>
        public DO_DATE ConfirmationIDExpirationDate { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class QuantitiesVO
    {
        /// <remarks/>
        public DO_CODED_TEXT Name { get; set; }
        /// <remarks/>
        public DO_QUANTITY Value { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class RelativeCostVO
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<double> KValue { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT KType { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class InquiryResultVO
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public DO_IDENTIFIER RuleID { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public string MessageID { get; set; }
        /// <remarks/>
        public string Message { get; set; }
        /// <remarks/>
        public DateTime Time { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT MessageType { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT RuleType { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER ConfirmationID { get; set; }
        /// <remarks/>
        public DO_DATE ConfirmationIDExpirationDate { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class CoverageServiceGroupRowVO
    {
        /// <remarks/>
        public DO_QUANTITY PatientContribution { get; set; }
        /// <remarks/>
        public QuantitiesVO[] OtherCosts { get; set; }
        /// <remarks/>
        public DO_QUANTITY BasicInsuranceContribution { get; set; }
        /// <remarks/>
        public DO_QUANTITY ServiceCount { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT ServiceType { get; set; }
        /// <remarks/>
        public DO_QUANTITY TotalCharge { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class CoverageSummaryVO
    {
        /// <remarks/>
        public QuantitiesVO[] TotalOtherCosts { get; set; }
        /// <remarks/>
        public DO_QUANTITY TotalBasicInsuranceContribution { get; set; }
        /// <remarks/>
        public DO_QUANTITY TotalPatientContribution { get; set; }
        /// <remarks/>
        public DO_QUANTITY TotalCharge { get; set; }
        /// <remarks/>
        public CoverageServiceGroupRowVO[] CoverageServiceGroup { get; set; }
        /// <remarks/>
        public InquiryResultVO[] InquiryResult { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class InsuranceCoverageVO
    {
        /// <remarks/>
        public DO_CODED_TEXT InquiryState { get; set; }
        /// <remarks/>
        public InquiryResultVO[] InquiryResult { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER TrackingID { get; set; }
        /// <remarks/>
        public DO_DATE TrackingIDExpirationDate { get; set; }
        /// <remarks/>
        public CoverageSummaryVO CoverageSummary { get; set; }
        /// <remarks/>
        public CoverageServiceDetailsVO[] Services { get; set; }
        /// <remarks/>
        public string Description { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://POCSRA.MOHME.IR/")]
    public partial class SystemVO
    {
        /// <remarks/>
        public string CommercialName { get; set; }
        /// <remarks/>
        public string CertificateID { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT ProductType { get; set; }
        /// <remarks/>
        public string CompanyName { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER CompanyID { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER SystemID { get; set; }
        /// <remarks/>
        public bool Approved { get; set; }
        /// <remarks/>
        public bool Lock { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ExtendedPropertyVO
    {
        /// <remarks/>
        public string Element { get; set; }
        /// <remarks/>
        public string ValueField { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class OrganizationDetailVO
    {
        /// <remarks/>
        public DO_IDENTIFIER OrganizationID { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER HierarchicalOrganizationID { get; set; }
        /// <remarks/>
        public string Name { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Type { get; set; }
        /// <remarks/>
        public HighLevelAreaVO Area { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT DependencyType { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT AllegianceType { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT OwnershipStatus { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER OwnerOrganizationID { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER ObserverOrganizationID { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Specialty { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT[] SpecialtyType { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT ActivityStatus { get; set; }
        /// <remarks/>
        public string PostalCode { get; set; }
        /// <remarks/>
        public double Longitude { get; set; }
        /// <remarks/>
        public double Latitude { get; set; }
        /// <remarks/>
        public DO_DATE EstablishmentDate { get; set; }
        /// <remarks/>
        public DO_DATE ActivationDate { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER[] OtherIdentityInfo { get; set; }
        /// <remarks/>
        public ExtendedPropertyVO[] ExtendendProperty { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class NationalHospitalStatusVO
    {
        /// <remarks/>
        public DO_IDENTIFIER Hospital { get; set; }
        /// <remarks/>
        public string HospitalName { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER System { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT WardType { get; set; }
        /// <remarks/>
        public string WardName { get; set; }
        /// <remarks/>
        public string Room { get; set; }
        /// <remarks/>
        public string BedNumber { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT BedType { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER BedUniqID { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT BedStatusChange { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<DateTime> BedChangeTime { get; set; }
        /// <remarks/>
        public string MedicalRecordNumber { get; set; }
        /// <remarks/>
        public string NationalCode { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER HID { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class PersonAppointmentVO
    {
        /// <remarks/>
        public PersonInfoVO Person { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER HID { get; set; }
        /// <remarks/>
        public HealthcareProviderVO Provider { get; set; }
        /// <remarks/>
        public HealthOrganizationUnitVO HealthcareFacillity { get; set; }
        /// <remarks/>
        public DO_DATE_TIME DateTime { get; set; }
        /// <remarks/>
        public int Duration { get; set; }
        /// <remarks/>
        public string QueueNumber { get; set; }
        /// <remarks/>
        public string TrackingQeueID { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class PersonInfoVO
    {
        /// <remarks/>
        public ElectronicContactVO[] OtherContacts { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER[] OtherIdentifier { get; set; }
        /// <remarks/>
        public HighLevelAreaVO BirthPlaceArea { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Religion { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT MaritalStatus { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Nationality { get; set; }
        /// <remarks/>
        public DO_DATE BirthDate { get; set; }
        /// <remarks/>
        public DO_TIME BirthTime { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT BirthdateAccuracy { get; set; }
        /// <remarks/>
        public string Father_FirstName { get; set; }
        /// <remarks/>
        public string Father_LastName { get; set; }
        /// <remarks/>
        public string Mother_FirstName { get; set; }
        /// <remarks/>
        public string Mother_LastName { get; set; }
        /// <remarks/>
        public string FullName { get; set; }
        /// <remarks/>
        public string PostalCode { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Gender { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Job { get; set; }
        /// <remarks/>
        public string JobDescribtion { get; set; }
        /// <remarks/>
        public string FullAddress { get; set; }
        /// <remarks/>
        public HighLevelAreaVO LivingPlaceArea { get; set; }
        /// <remarks/>
        public string IDCardNumber { get; set; }
        /// <remarks/>
        public HighLevelAreaVO IDIssueArea { get; set; }
        /// <remarks/>
        public string HomeTel { get; set; }
        /// <remarks/>
        public string MobileNumber { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT EducationLevel { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string FirstName { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string LastName { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string NationalCode { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ElectronicContactVO
    {
        /// <remarks/>
        public DO_CODED_TEXT MediumType { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Usage { get; set; }
        /// <remarks/>
        public string Detail { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class DO_TIME
    {
        /// <remarks/>
        public string ISOString { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> Hour { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> Minute { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> Second { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class HealthcareProviderVO
    {
        /// <remarks/>
        public DO_CODED_TEXT Specialty { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER Identifier { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Role { get; set; }
        /// <remarks/>
        public ElectronicContactVO[] ContactPoint { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string FirstName { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string LastName { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string FullName { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class HealthOrganizationUnitVO
    {
        /// <remarks/>
        public string Name { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER ID { get; set; }
        /// <remarks/>
        public string InternalID { get; set; }
        /// <remarks/>
        public HighLevelAreaVO Location { get; set; }
        /// <remarks/>
        public string Address { get; set; }
        /// <remarks/>
        public string InternalAddress { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Type { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<double> Latitude { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<double> Longitude { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT DepartmentType { get; set; }
        /// <remarks/>
        public string DepartmentName { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ScheduleBlockVO
    {
        /// <remarks/>
        public HealthcareProviderVO Provider { get; set; }
        /// <remarks/>
        public HealthOrganizationUnitVO HealthcareFacillity { get; set; }
        /// <remarks/>
        public DO_DATE_TIME DateTime { get; set; }
        /// <remarks/>
        public int Duration { get; set; }
        /// <remarks/>
        public string QueueNumber { get; set; }
        /// <remarks/>
        public string LocalID { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Quota { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Service { get; set; }
        /// <remarks/>
        public string TrackingQueueID { get; set; }
        /// <remarks/>
        public DO_DATE_TIME BookingExpiryDate { get; set; }
        /// <remarks/>
        public DO_DATE_TIME BookingStartDate { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ValidationResultVO
    {
        /// <remarks/>
        public string MessageID { get; set; }
        /// <remarks/>
        public string ErrorMessage { get; set; }
        /// <remarks/>
        public string NormalizedErrorMessage { get; set; }
        /// <remarks/>
        public string ErrorCategoryType { get; set; }
        /// <remarks/>
        public string ErrorCategoryCritical { get; set; }
        /// <remarks/>
        public string ErrorCategorySource { get; set; }
        /// <remarks/>
        public string ErrorDescription { get; set; }
        /// <remarks/>
        public string ErrorSolution { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class PatientTransferInfoVO
    {
        /// <remarks/>
        public DO_CODED_TEXT MissionResult { get; set; }
        /// <remarks/>
        public OrganizationVO Destination { get; set; }
        /// <remarks/>
        public DO_DATE_TIME DeliveryTime { get; set; }
        /// <remarks/>
        public HealthcareProviderVO ReceiverProvider { get; set; }
        /// <remarks/>
        public string Note { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class OrganizationVO
    {
        /// <remarks/>
        public string Name { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER ID { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Type { get; set; }
        /// <remarks/>
        public HighLevelAreaVO Location { get; set; }
        /// <remarks/>
        public string PortablePosition { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class AmbulanceServiceCompositionVO
    {
        /// <remarks/>
        public AdmissionVO Admission { get; set; }
        /// <remarks/>
        public DiagnosisVO[] Diagnosis { get; set; }
        /// <remarks/>
        public ClinicalFindingGeneralVO[] ClinicalFinding { get; set; }
        /// <remarks/>
        public ChiefComplaintVO ChiefComplaint { get; set; }
        /// <remarks/>
        public PMHVO[] PMH { get; set; }
        /// <remarks/>
        public QuestionnaireVO[] Questionnaire { get; set; }
        /// <remarks/>
        public DrugHistoryVO[] DrugHistory { get; set; }
        /// <remarks/>
        public AdverseReactionVO[] AdverseReaction { get; set; }
        /// <remarks/>
        public PhysicalExamVO[] PHEX { get; set; }
        /// <remarks/>
        public DrugTreatmentReportVO[] MedicationOrderedReport { get; set; }
        /// <remarks/>
        public GeneralActionReportVO[] GeneralActionReport { get; set; }
        /// <remarks/>
        public DrugTreatmentReportVO[] DrugTreatmentReport { get; set; }
        /// <remarks/>
        public PatientTransferInfoVO PatientTransferInfo { get; set; }
        /// <remarks/>
        public LabTestResultVO[] Laboratory { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class AdmissionVO
    {
        /// <remarks/>
        public DO_CODEABLE_CONCEPT ArrivalMode { get; set; }
        /// <remarks/>
        public HealthcareProviderVO[] OtherParticipation { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER EMSID { get; set; }
        /// <remarks/>
        public DateTimePointVO[] OtherDateTime { get; set; }
        /// <remarks/>
        public DO_DATE AdmissionDate { get; set; }
        /// <remarks/>
        public DO_TIME AdmissionTime { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT AdmissionType { get; set; }
        /// <remarks/>
        public string MedicalRecordNumber { get; set; }
        /// <remarks/>
        public OrganizationVO Institute { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT ReasonForEncounter { get; set; }
        /// <remarks/>
        public HealthcareProviderVO AdmittingDoctor { get; set; }
        /// <remarks/>
        public HealthcareProviderVO ReferringDoctor { get; set; }
        /// <remarks/>
        public HealthcareProviderVO AttendingDoctor { get; set; }
        /// <remarks/>
        public HospitalWardVO AdmissionWard { get; set; }
        /// <remarks/>
        public LocationVO PatientLocation { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class DateTimePointVO
    {
        /// <remarks/>
        public DO_CODED_TEXT Point { get; set; }
        /// <remarks/>
        public DO_DATE PointDate { get; set; }
        /// <remarks/>
        public DO_TIME PointTime { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class HospitalWardVO
    {
        /// <remarks/>
        public string Name { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Type { get; set; }
        /// <remarks/>
        public string Room { get; set; }
        /// <remarks/>
        public string Bed { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class LocationVO
    {
        /// <remarks/>
        public string Name { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Type { get; set; }
        /// <remarks/>
        public GeographicalCoordinatesVO Coordination { get; set; }
        /// <remarks/>
        public HighLevelAreaVO AreaAddress { get; set; }
        /// <remarks/>
        public string FullAddress { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class DiagnosisVO
    {
        /// <remarks/>
        public DO_CODED_TEXT Diagnosis { get; set; }
        /// <remarks/>
        public string Comment { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Status { get; set; }
        /// <remarks/>
        public DO_DATE DiagnosisDate { get; set; }
        /// <remarks/>
        public DO_TIME DiagnosisTime { get; set; }
        /// <remarks/>
        public DO_ORDINAL Severity { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class DO_ORDINAL
    {
        /// <remarks/>
        public DO_CODED_TEXT Symbol { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> Value { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ClinicalFindingGeneralVO
    {
        /// <remarks/>
        public DO_QUANTITY AgeOfOnset { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<bool> NillSignificant { get; set; }
        /// <remarks/>
        public DO_QUANTITY OnsetDuration2Present { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Finding { get; set; }
        /// <remarks/>
        public string Description { get; set; }
        /// <remarks/>
        public DO_DATE DateofOnset { get; set; }
        /// <remarks/>
        public DO_TIME TimeofOnset { get; set; }
        /// <remarks/>
        public DO_ORDINAL Severity { get; set; }
        /// <remarks/>
        public AnatomicalLocationVO[] AnatomicalLocation { get; set; }
        /// <remarks/>
        public DO_DATE ResolutionDate { get; set; }
        /// <remarks/>
        public DO_TIME ResolutionTime { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class AnatomicalLocationVO
    {
        /// <remarks/>
        public DO_CODED_TEXT BodySite { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Laterality { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ChiefComplaintVO
    {
        /// <remarks/>
        public DO_CODED_TEXT[] Symptoms { get; set; }
        /// <remarks/>
        public DO_DATE DateofOnset { get; set; }
        /// <remarks/>
        public DO_TIME TimeofOnset { get; set; }
        /// <remarks/>
        public string Description { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class PMHVO
    {
        /// <remarks/>
        public DO_CODED_TEXT Condition { get; set; }
        /// <remarks/>
        public string Description { get; set; }
        /// <remarks/>
        public DO_DATE DateofOnset { get; set; }
        /// <remarks/>
        public DO_QUANTITY OnsetDurationToPresent { get; set; }
    }
    /// <remarks/>
    [System.Xml.Serialization.XmlInclude(typeof(QuestionnaireBooleanVO))]
    [System.Xml.Serialization.XmlInclude(typeof(QuestionnaireQuantityVO))]
    [System.Xml.Serialization.XmlInclude(typeof(QuestionnaireCSVO))]
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public abstract partial class QuestionnaireVO
    {
        /// <remarks/>
        public DO_CODED_TEXT QuestionCategory { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT QuestionSubCategory { get; set; }
        /// <remarks/>
        public string QuestionDesc { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT QuestionCode { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class QuestionnaireBooleanVO : QuestionnaireVO
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<bool> Answer { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class QuestionnaireQuantityVO : QuestionnaireVO
    {
        /// <remarks/>
        public DO_QUANTITY Answer { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class QuestionnaireCSVO : QuestionnaireVO
    {
        /// <remarks/>
        public DO_CODED_TEXT Answer { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class DrugHistoryVO
    {
        /// <remarks/>
        public DO_CODED_TEXT Medication { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Routeofadministration { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class AdverseReactionVO
    {
        /// <remarks/>
        public DO_CODED_TEXT Reaction { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT ReactionCategory { get; set; }
        /// <remarks/>
        public string Description { get; set; }
        /// <remarks/>
        public DO_ORDINAL Severity { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT CausativeAgent { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT CausativeAgentCategory { get; set; }
    }
    /// <remarks/>
    [System.Xml.Serialization.XmlInclude(typeof(PulseVO))]
    [System.Xml.Serialization.XmlInclude(typeof(GeneralAssessmentVO))]
    [System.Xml.Serialization.XmlInclude(typeof(PulseOximetryVO))]
    [System.Xml.Serialization.XmlInclude(typeof(Height_WeightVO))]
    [System.Xml.Serialization.XmlInclude(typeof(Waist_HipVO))]
    [System.Xml.Serialization.XmlInclude(typeof(VitalSignsVO))]
    [System.Xml.Serialization.XmlInclude(typeof(BloodPressureVO))]
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public abstract partial class PhysicalExamVO
    {
        /// <remarks/>
        public DO_DATE ObservationDate { get; set; }
        /// <remarks/>
        public DO_TIME ObservationTime { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class PulseVO : PhysicalExamVO
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<bool> Is_Pulse_Present { get; set; }
        /// <remarks/>
        public DO_QUANTITY PulseRate { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Regularity { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Volume { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Character { get; set; }
        /// <remarks/>
        public string ClinicalDescription { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Position { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT LocationOfMeasurement { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Method { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class GeneralAssessmentVO : PhysicalExamVO
    {
        /// <remarks/>
        public ScoreDetailsVO[] ScoreDetails { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT AssessmentType { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT ScaleSystem { get; set; }
        /// <remarks/>
        public string TotalValue { get; set; }
        /// <remarks/>
        public string Comment { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ScoreDetailsVO
    {
        /// <remarks/>
        public DO_CODED_TEXT Concept { get; set; }
        /// <remarks/>
        public string ConceptValue { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class PulseOximetryVO : PhysicalExamVO
    {
        /// <remarks/>
        public DO_QUANTITY SpO2 { get; set; }
        /// <remarks/>
        public DO_CODEABLE_CONCEPT BodySite { get; set; }
        /// <remarks/>
        public DO_CODEABLE_CONCEPT PatientStatus { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class Height_WeightVO : PhysicalExamVO
    {
        /// <remarks/>
        public DO_QUANTITY Height { get; set; }
        /// <remarks/>
        public DO_QUANTITY Weight { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class Waist_HipVO : PhysicalExamVO
    {
        /// <remarks/>
        public DO_QUANTITY WaistCircumference { get; set; }
        /// <remarks/>
        public DO_QUANTITY HipCircumference { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class VitalSignsVO : PhysicalExamVO
    {
        /// <remarks/>
        public DO_QUANTITY PulseRate { get; set; }
        /// <remarks/>
        public DO_QUANTITY RespiratoryRate { get; set; }
        /// <remarks/>
        public DO_QUANTITY Temperature { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT TemperatureLocation { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class BloodPressureVO : PhysicalExamVO
    {
        /// <remarks/>
        public DO_QUANTITY SystolicBP { get; set; }
        /// <remarks/>
        public DO_QUANTITY DiastolicBP { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Position { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class DrugTreatmentReportVO
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> totalNumber { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Sahpe { get; set; }
        /// <remarks/>
        public DO_DATE UseStartDate { get; set; }
        /// <remarks/>
        public DO_TIME UseStartTime { get; set; }
        /// <remarks/>
        public DO_DATE UseEndDate { get; set; }
        /// <remarks/>
        public DO_TIME UseEndTime { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT DrugName { get; set; }
        /// <remarks/>
        public string DrugGenericName { get; set; }
        /// <remarks/>
        public DO_QUANTITY Dosage { get; set; }
        /// <remarks/>
        public DO_QUANTITY DosageTotal { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Frequency { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Route { get; set; }
        /// <remarks/>
        public DO_QUANTITY LongTerm { get; set; }
        /// <remarks/>
        public string Description { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class GeneralActionReportVO
    {
        /// <remarks/>
        public DO_DATE StartDate { get; set; }
        /// <remarks/>
        public DO_TIME StartTime { get; set; }
        /// <remarks/>
        public DO_DATE EndDate { get; set; }
        /// <remarks/>
        public DO_TIME EndTime { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT ActionName { get; set; }
        /// <remarks/>
        public string ActionDescription { get; set; }
        /// <remarks/>
        public DO_QUANTITY TimeTaken { get; set; }
    }
    /// <remarks/>
    [System.Xml.Serialization.XmlInclude(typeof(UAVO))]
    [System.Xml.Serialization.XmlInclude(typeof(LiverFunctionVO))]
    [System.Xml.Serialization.XmlInclude(typeof(BloodLipidsVO))]
    [System.Xml.Serialization.XmlInclude(typeof(GeneralLaboratoryResultVO))]
    [System.Xml.Serialization.XmlInclude(typeof(PathologyVO))]
    [System.Xml.Serialization.XmlInclude(typeof(MicrobiologicalCultureVO))]
    [System.Xml.Serialization.XmlInclude(typeof(BloodSugarVO))]
    [System.Xml.Serialization.XmlInclude(typeof(SingleBooleanVO))]
    [System.Xml.Serialization.XmlInclude(typeof(SingleQuantityVO))]
    [System.Xml.Serialization.XmlInclude(typeof(CoagulationVO))]
    [System.Xml.Serialization.XmlInclude(typeof(UA24HVO))]
    [System.Xml.Serialization.XmlInclude(typeof(BloodGroupVO))]
    [System.Xml.Serialization.XmlInclude(typeof(ThrombinTimeVO))]
    [System.Xml.Serialization.XmlInclude(typeof(ThyroidVO))]
    [System.Xml.Serialization.XmlInclude(typeof(CBCVO))]
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public abstract partial class LabTestResultVO
    {
        /// <remarks/>
        public DO_DATE_TIME DateTimeResult { get; set; }
        /// <remarks/>
        public SpecimenDetailsVO Specimen { get; set; }
        /// <remarks/>
        public LaboratoryProtocolVO protocol { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class SpecimenDetailsVO
    {
        /// <remarks/>
        public DO_CODED_TEXT SpecimenTissueType { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT AdequacyForTesting { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT CollectionProcedure { get; set; }
        /// <remarks/>
        public DO_DATE DateofCollection { get; set; }
        /// <remarks/>
        public DO_TIME TimeofCollection { get; set; }
        /// <remarks/>
        public string SpecimenIdentifier { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class LaboratoryProtocolVO
    {
        /// <remarks/>
        public DO_DATE ReceiptDate { get; set; }
        /// <remarks/>
        public DO_TIME ReceiptTime { get; set; }
        /// <remarks/>
        public DO_DATE ProcessDate { get; set; }
        /// <remarks/>
        public DO_TIME ProcessTime { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Method { get; set; }
        /// <remarks/>
        public string MethodDescription { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class UAVO : LabTestResultVO
    {
        /// <remarks/>
        public DO_CODED_TEXT Color { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Clarity { get; set; }
        /// <remarks/>
        public DO_ORDINAL Concentration { get; set; }
        /// <remarks/>
        public DO_INTERVALINT RBCs { get; set; }
        /// <remarks/>
        public DO_INTERVALINT WBCs { get; set; }
        /// <remarks/>
        public DO_INTERVALINT EpithelialCells { get; set; }
        /// <remarks/>
        public DO_ORDINAL Microorganisms { get; set; }
        /// <remarks/>
        public DO_INTERVALINT Cast { get; set; }
        /// <remarks/>
        public DO_INTERVALINT Crystals { get; set; }
        /// <remarks/>
        public DO_QUANTITY SpecificGravity { get; set; }
        /// <remarks/>
        public DO_PROPORTION PH { get; set; }
        /// <remarks/>
        public DO_ORDINAL Protein { get; set; }
        /// <remarks/>
        public DO_ORDINAL Glucose { get; set; }
        /// <remarks/>
        public DO_ORDINAL Ketones { get; set; }
        /// <remarks/>
        public DO_ORDINAL LeukocyteEsterase { get; set; }
        /// <remarks/>
        public DO_ORDINAL Nitrite { get; set; }
        /// <remarks/>
        public DO_ORDINAL Bilirubin { get; set; }
        /// <remarks/>
        public DO_ORDINAL Urobilinogen { get; set; }
        /// <remarks/>
        public DO_ORDINAL Blood { get; set; }
        /// <remarks/>
        public string Comment { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class DO_INTERVALINT
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> lowerValue { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> upperValue { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class DO_PROPORTION
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<double> numerator { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<double> denominator { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> type { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class LiverFunctionVO : LabTestResultVO
    {
        /// <remarks/>
        public DO_QUANTITY Globulins { get; set; }
        /// <remarks/>
        public DO_QUANTITY TotalProtein { get; set; }
        /// <remarks/>
        public DO_QUANTITY LactateDehydrogenase { get; set; }
        /// <remarks/>
        public DO_QUANTITY GammaGlutamylTransferase { get; set; }
        /// <remarks/>
        public DO_QUANTITY Albumin { get; set; }
        /// <remarks/>
        public DO_QUANTITY AlkalinePhosphatase { get; set; }
        /// <remarks/>
        public DO_QUANTITY DirectBilirubin { get; set; }
        /// <remarks/>
        public DO_QUANTITY IndirectBilirubin { get; set; }
        /// <remarks/>
        public DO_QUANTITY TotalBilirubin { get; set; }
        /// <remarks/>
        public DO_QUANTITY SGOT { get; set; }
        /// <remarks/>
        public DO_QUANTITY SGPT { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class BloodLipidsVO : LabTestResultVO
    {
        /// <remarks/>
        public DO_QUANTITY TotalCholestrol { get; set; }
        /// <remarks/>
        public DO_QUANTITY Triglycerides { get; set; }
        /// <remarks/>
        public DO_QUANTITY HDL { get; set; }
        /// <remarks/>
        public DO_QUANTITY LDL { get; set; }
        /// <remarks/>
        public DO_QUANTITY VLDL { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class GeneralLaboratoryResultVO : LabTestResultVO
    {
        /// <remarks/>
        public LaboratoryResultRowVO[] LaboratoryResultRow { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT LaboratoryPanel { get; set; }
    }
    /// <remarks/>
    [System.Xml.Serialization.XmlInclude(typeof(LaboratoryResultRowOrdinalVO))]
    [System.Xml.Serialization.XmlInclude(typeof(LaboratoryResultRowProportionVO))]
    [System.Xml.Serialization.XmlInclude(typeof(LaboratoryResultRowBooleanVO))]
    [System.Xml.Serialization.XmlInclude(typeof(LaboratoryResultRowCodedVO))]
    [System.Xml.Serialization.XmlInclude(typeof(LaboratoryResultRowCountVO))]
    [System.Xml.Serialization.XmlInclude(typeof(LaboratoryResultRowQuantityVO))]
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public abstract partial class LaboratoryResultRowVO
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> TestSequence { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT TestPanel { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT TestName { get; set; }
        /// <remarks/>
        public string Comment { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Status { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT ResultStatus { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class LaboratoryResultRowOrdinalVO : LaboratoryResultRowVO
    {
        /// <remarks/>
        public DO_ORDINAL TestResult { get; set; }
        /// <remarks/>
        public ReferenceRangeVO[] ReferenceRange { get; set; }
    }
    /// <remarks/>
    [System.Xml.Serialization.XmlInclude(typeof(ReferenceRangeNumericVO))]
    [System.Xml.Serialization.XmlInclude(typeof(ReferenceRangeQualityVO))]
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ReferenceRangeVO
    {
        /// <remarks/>
        public DO_CODED_TEXT AgeRange { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Gender { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Species { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT SubSpecies { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT HormonalPhase { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT GestationAgeRange { get; set; }
        /// <remarks/>
        public string Condition { get; set; }
        /// <remarks/>
        public string Description { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT ReferenceStatus { get; set; }
        /// <remarks/>
        public string LowRangeDescriptive { get; set; }
        /// <remarks/>
        public string HighRangeDescriptive { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ReferenceRangeNumericVO : ReferenceRangeVO
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> LowNumbericRange { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> HighNumbericRange { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ReferenceRangeQualityVO : ReferenceRangeVO
    {
        /// <remarks/>
        public DO_QUANTITY LowQuantityRange { get; set; }
        /// <remarks/>
        public DO_QUANTITY HighQuantityRange { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class LaboratoryResultRowProportionVO : LaboratoryResultRowVO
    {
        /// <remarks/>
        public DO_PROPORTION TestResult { get; set; }
        /// <remarks/>
        public ReferenceRangeVO[] ReferenceRange { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class LaboratoryResultRowBooleanVO : LaboratoryResultRowVO
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<bool> TestResult { get; set; }
        /// <remarks/>
        public ReferenceRangeVO[] ReferenceRange { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class LaboratoryResultRowCodedVO : LaboratoryResultRowVO
    {
        /// <remarks/>
        public DO_CODED_TEXT TestResult { get; set; }
        /// <remarks/>
        public ReferenceRangeVO[] ReferenceRange { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class LaboratoryResultRowCountVO : LaboratoryResultRowVO
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> TestResult { get; set; }
        /// <remarks/>
        public ReferenceRangeVO[] ReferenceRange { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class LaboratoryResultRowQuantityVO : LaboratoryResultRowVO
    {
        /// <remarks/>
        public DO_QUANTITY TestResult { get; set; }
        /// <remarks/>
        public ReferenceRangeVO[] ReferenceRange { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class PathologyVO : LabTestResultVO
    {
        /// <remarks/>
        public string MicroscopicExamination { get; set; }
        /// <remarks/>
        public string MacroscopicExamination { get; set; }
        /// <remarks/>
        public string ClinicalInformation { get; set; }
        /// <remarks/>
        public PathologyDiagnosisVO[] PathologyDiagnosis { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class PathologyDiagnosisVO
    {
        /// <remarks/>
        public string DiagnosisDescription { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Diagnosis { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Topography { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT TopographyLaterality { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Morphology { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT MorphologyDifferentiation { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class MicrobiologicalCultureVO : LabTestResultVO
    {
        /// <remarks/>
        public MicrobialFindingVO MicrobialFinding { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT CultureType { get; set; }
        /// <remarks/>
        public DO_QUANTITY ColonyCount { get; set; }
        /// <remarks/>
        public AntibiogramVO[] Antibiograms { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT GrowthDurationType { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class MicrobialFindingVO
    {
        /// <remarks/>
        public DO_CODED_TEXT Organism { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT BioType { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class AntibiogramVO
    {
        /// <remarks/>
        public DO_CODED_TEXT Agent { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Sensitivity { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class BloodSugarVO : LabTestResultVO
    {
        /// <remarks/>
        public BSVO[] BS { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("TestSpecified")]
        public DO_CODED_TEXT TestSpecified1 { get; set; }
        /// <remarks/>
        public string Comment { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class BSVO
    {
        /// <remarks/>
        public DO_QUANTITY BloodGlucoseLevel { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Timing { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class SingleBooleanVO : LabTestResultVO
    {
        /// <remarks/>
        public DO_CODED_TEXT LabTestName { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<bool> LabValue { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class SingleQuantityVO : LabTestResultVO
    {
        /// <remarks/>
        public DO_CODED_TEXT LabTestName { get; set; }
        /// <remarks/>
        public DO_QUANTITY LabValue { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class CoagulationVO : LabTestResultVO
    {
        /// <remarks/>
        public DO_QUANTITY PT { get; set; }
        /// <remarks/>
        public DO_QUANTITY PTT { get; set; }
        /// <remarks/>
        public DO_PROPORTION INR { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class UA24HVO : LabTestResultVO
    {
        /// <remarks/>
        public DO_QUANTITY Protien { get; set; }
        /// <remarks/>
        public DO_QUANTITY Ceratinin { get; set; }
        /// <remarks/>
        public DO_QUANTITY Volume { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class BloodGroupVO : LabTestResultVO
    {
        /// <remarks/>
        public DO_CODED_TEXT ABO { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT RhesusFactor { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ThrombinTimeVO : LabTestResultVO
    {
        /// <remarks/>
        public DO_QUANTITY BleedingTime { get; set; }
        /// <remarks/>
        public DO_QUANTITY ClottingTime { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ThyroidVO : LabTestResultVO
    {
        /// <remarks/>
        public DO_QUANTITY FreeT4 { get; set; }
        /// <remarks/>
        public DO_QUANTITY FreeT3 { get; set; }
        /// <remarks/>
        public DO_QUANTITY TSH { get; set; }
        /// <remarks/>
        public DO_QUANTITY TotalT4 { get; set; }
        /// <remarks/>
        public DO_QUANTITY TotalT3 { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class CBCVO : LabTestResultVO
    {
        /// <remarks/>
        public DO_QUANTITY WBC { get; set; }
        /// <remarks/>
        public DO_QUANTITY RBC { get; set; }
        /// <remarks/>
        public DO_QUANTITY Hemoglobin { get; set; }
        /// <remarks/>
        public DO_QUANTITY Platelet { get; set; }
        /// <remarks/>
        public DO_QUANTITY Hematocrit { get; set; }
        /// <remarks/>
        public DO_QUANTITY MCV { get; set; }
        /// <remarks/>
        public DO_QUANTITY MCH { get; set; }
        /// <remarks/>
        public DO_QUANTITY MCHC { get; set; }
        /// <remarks/>
        public DO_PROPORTION Neutrophils { get; set; }
        /// <remarks/>
        public DO_PROPORTION Lymphocytes { get; set; }
        /// <remarks/>
        public DO_PROPORTION Monocytes { get; set; }
        /// <remarks/>
        public DO_PROPORTION Eosinophils { get; set; }
        /// <remarks/>
        public DO_PROPORTION Basophils { get; set; }
        /// <remarks/>
        public string MicroscopicFeatures { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class AmbulanceServiceMessageVO
    {
        /// <remarks/>
        public PersonInfoVO Person { get; set; }
        /// <remarks/>
        public MessageIdentifierVO MsgID { get; set; }
        /// <remarks/>
        public AmbulanceServiceCompositionVO Composition { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlNamespaceDeclarations()]
        public System.Xml.Serialization.XmlSerializerNamespaces xmlns { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class MessageIdentifierVO
    {
        /// <remarks/>
        public DO_CODED_TEXT VersionLifecycleState { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<bool> IS_Queriable { get; set; }
        /// <remarks/>
        public SignatureVO CompositionSignature { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER SystemID { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER HealthCareFacilityID { get; set; }
        /// <remarks/>
        public string PatientUID { get; set; }
        /// <remarks/>
        public string CompositionUID { get; set; }
        /// <remarks/>
        public ProviderInfoVO Committer { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ProviderInfoVO
    {
        /// <remarks/>
        public DO_IDENTIFIER Identifier { get; set; }
        /// <remarks/>
        public ElectronicContactVO[] ContactPoint { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string FirstName { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string LastName { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string FullName { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ImagingPrescriptionRowVO
    {
        /// <remarks/>
        public DO_CODED_TEXT Service { get; set; }
        /// <remarks/>
        public DO_CODEABLE_CONCEPT[] ServiceDetail { get; set; }
        /// <remarks/>
        public AnatomicalLocationVO[] AnatomicalLocation { get; set; }
        /// <remarks/>
        public string Note { get; set; }
        /// <remarks/>
        public string PatientInstruction { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ImagingPrescriptionsVO
    {
        /// <remarks/>
        public string Note { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Status { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Priority { get; set; }
        /// <remarks/>
        public ProviderInfoVO Prescriber { get; set; }
        /// <remarks/>
        public DO_DATE_TIME IssueDateTime { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER ePrescriptionID { get; set; }
        /// <remarks/>
        public ImagingPrescriptionRowVO[] Orders { get; set; }
        /// <remarks/>
        public DO_DATE ExpiryDate { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ImagingPrescriptionCompositionVO
    {
        /// <remarks/>
        public AdmissionVO Admission { get; set; }
        /// <remarks/>
        public InsuranceVO Insurance { get; set; }
        /// <remarks/>
        public ImagingPrescriptionsVO ServicePrescriptions { get; set; }
        /// <remarks/>
        public DiagnosisVO[] Diagnosis { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class InsuranceVO
    {
        /// <remarks/>
        public DO_QUANTITY InsuranceContribution { get; set; }
        /// <remarks/>
        public QuantitiesVO[] InsuranceOtherCosts { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Insurer { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT InsuranceBox { get; set; }
        /// <remarks/>
        public string InsuranceBookletSerialNumber { get; set; }
        /// <remarks/>
        public DO_DATE InsuranceExpirationDate { get; set; }
        /// <remarks/>
        public string InsuredNumber { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER SHEBAD { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ImagingPrescriptionsMessageVO
    {
        /// <remarks/>
        public PersonInfoVO Person { get; set; }
        /// <remarks/>
        public MessageIdentifierVO MsgID { get; set; }
        /// <remarks/>
        public ImagingPrescriptionCompositionVO Composition { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlNamespaceDeclarations()]
        public System.Xml.Serialization.XmlSerializerNamespaces xmlns { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ServicePrescriptionRowVO
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<bool> DoNotPerform { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Service { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> ServiceAmount { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Method { get; set; }
        /// <remarks/>
        public AnatomicalLocationVO[] AnatomicalLocation { get; set; }
        /// <remarks/>
        public DO_CODEABLE_CONCEPT[] AsNeeded { get; set; }
        /// <remarks/>
        public DO_CODEABLE_CONCEPT[] ReasonCode { get; set; }
        /// <remarks/>
        public string Note { get; set; }
        /// <remarks/>
        public string PatientInstruction { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ServicePrescriptionsVO
    {
        /// <remarks/>
        public string Note { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Status { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Intent { get; set; }
        /// <remarks/>
        public DO_CODEABLE_CONCEPT Category { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Priority { get; set; }
        /// <remarks/>
        public DO_CODEABLE_CONCEPT LocationCode { get; set; }
        /// <remarks/>
        public SpecimenDetailsVO Specimen { get; set; }
        /// <remarks/>
        public ProviderInfoVO Prescriber { get; set; }
        /// <remarks/>
        public DO_DATE_TIME IssueDateTime { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER ePrescriptionID { get; set; }
        /// <remarks/>
        public ServicePrescriptionRowVO[] Orders { get; set; }
        /// <remarks/>
        public DO_DATE ExpiryDate { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> Repeats { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ServicePrescriptionsCompositionVO
    {
        /// <remarks/>
        public DiagnosisVO[] Diagnosis { get; set; }
        /// <remarks/>
        public AdmissionVO Admission { get; set; }
        /// <remarks/>
        public InsuranceVO Insurance { get; set; }
        /// <remarks/>
        public ServicePrescriptionsVO ServicePrescriptions { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class LaboratoryPrescriptionsMessageVO
    {
        /// <remarks/>
        public PersonInfoVO Person { get; set; }
        /// <remarks/>
        public MessageIdentifierVO MsgID { get; set; }
        /// <remarks/>
        public ServicePrescriptionsCompositionVO Composition { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlNamespaceDeclarations()]
        public System.Xml.Serialization.XmlSerializerNamespaces xmlns { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ComplicationVO
    {
        /// <remarks/>
        public DO_CODED_TEXT Complication { get; set; }
        /// <remarks/>
        public string Description { get; set; }
        /// <remarks/>
        public DO_ORDINAL Severity { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT CausativeAgent { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ObstetricHistoryVO
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> Gravid { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> Para { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> Abortion { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> LiveChild { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> DeathChild { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class TravelHistoryVO
    {
        /// <remarks/>
        public DO_DATE StartDate { get; set; }
        /// <remarks/>
        public DO_DATE EndDate { get; set; }
        /// <remarks/>
        public HighLevelAreaVO Destination { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class VaccinationVO
    {
        /// <remarks/>
        public DO_CODED_TEXT VaccinationPlan { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT PlanCourse { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Vaccine { get; set; }
        /// <remarks/>
        public DO_DATE_TIME DateOfInjection { get; set; }
        /// <remarks/>
        public string Description { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class GeneralCaseCompositionVO
    {
        /// <remarks/>
        public VaccinationVO[] Vaccination { get; set; }
        /// <remarks/>
        public QuestionnaireVO[] Questionnaire { get; set; }
        /// <remarks/>
        public GeneralActionReportVO[] Procedure { get; set; }
        /// <remarks/>
        public LabRequestVO LabRequest { get; set; }
        /// <remarks/>
        public TravelHistoryVO[] TravelHistory { get; set; }
        /// <remarks/>
        public DrugTreatmentReportVO[] DrugTreatmentReport { get; set; }
        /// <remarks/>
        public AdverseReactionVO[] AdverseReaction { get; set; }
        /// <remarks/>
        public BasicDeathDetailsVO Death { get; set; }
        /// <remarks/>
        public ClinicalFindingGeneralVO[] ClinicalFinding { get; set; }
        /// <remarks/>
        public PhysicalExamVO[] PhysicalExams { get; set; }
        /// <remarks/>
        public ObstetricHistoryVO ObstetricHistory { get; set; }
        /// <remarks/>
        public AbuseHistoryVO[] AbuseHistory { get; set; }
        /// <remarks/>
        public AdmissionVO Admission { get; set; }
        /// <remarks/>
        public DischargeVO Discharge { get; set; }
        /// <remarks/>
        public PMHVO[] PastMedicalHistory { get; set; }
        /// <remarks/>
        public FamilyHistoryVO[] FamilyHistory { get; set; }
        /// <remarks/>
        public ChiefComplaintVO ChiefComplaint { get; set; }
        /// <remarks/>
        public LabTestResultVO[] LabResult { get; set; }
        /// <remarks/>
        public ComplicationVO[] Complication { get; set; }
        /// <remarks/>
        public DiagnosisVO[] Diagnosis { get; set; }
        /// <remarks/>
        public MedicationOrderedReportVO[] DrugOrdered { get; set; }
        /// <remarks/>
        public InsuranceVO[] Insurance { get; set; }
        /// <remarks/>
        public DrugHistoryVO[] DrugHistory { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class LabRequestVO
    {
        /// <remarks/>
        public DO_DATE SpecimenDate { get; set; }
        /// <remarks/>
        public DO_TIME SpecimenTime { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT SpecimenType { get; set; }
        /// <remarks/>
        public string SpecimenCode { get; set; }
        /// <remarks/>
        public SpecimenDetailsVO Specimen { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class BasicDeathDetailsVO
    {
        /// <remarks/>
        public DO_DATE DeathDate { get; set; }
        /// <remarks/>
        public DO_TIME DeathTime { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT DeathLocation { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT HospitalWard { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
        public CauseVO[] Cause { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class CauseVO
    {
        /// <remarks/>
        public DO_CODED_TEXT Cause { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Status { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class AbuseHistoryVO
    {
        /// <remarks/>
        public DO_QUANTITY AbuseDuration { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT SubstanceType { get; set; }
        /// <remarks/>
        public DO_QUANTITY AmountOfAbuse { get; set; }
        /// <remarks/>
        public DO_DATE StartDate { get; set; }
        /// <remarks/>
        public DO_DATE QuitDate { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class DischargeVO
    {
        /// <remarks/>
        public DO_TIME DischargeTime { get; set; }
        /// <remarks/>
        public DO_DATE DischargeDate { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT ConditionOnDischarge { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class FamilyHistoryVO
    {
        /// <remarks/>
        public DO_CODED_TEXT Condition { get; set; }
        /// <remarks/>
        public string Description { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT RelatedPerson { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<bool> Is_CauseofDeath { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class MedicationOrderedReportVO
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> totalNumber { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Sahpe { get; set; }
        /// <remarks/>
        public DO_DATE AdministrationDate { get; set; }
        /// <remarks/>
        public DO_TIME AdministrationTime { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT DrugName { get; set; }
        /// <remarks/>
        public string DrugGenericName { get; set; }
        /// <remarks/>
        public DO_QUANTITY Dosage { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Frequency { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Route { get; set; }
        /// <remarks/>
        public DO_QUANTITY LongTerm { get; set; }
        /// <remarks/>
        public string Description { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class SOAPMessageVO
    {
        /// <remarks/>
        public PersonInfoVO Person { get; set; }
        /// <remarks/>
        public MessageIdentifierVO MsgID { get; set; }
        /// <remarks/>
        public GeneralCaseCompositionVO Composition { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlNamespaceDeclarations()]
        public System.Xml.Serialization.XmlSerializerNamespaces xmlns { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class TriageSummaryVO
    {
        /// <remarks/>
        public DO_CODED_TEXT TriageSystem { get; set; }
        /// <remarks/>
        public string TriageLevel { get; set; }
        /// <remarks/>
        public DO_DATE_TIME TriageTime { get; set; }
        /// <remarks/>
        public HealthcareProviderVO Provider { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Disposition { get; set; }
        /// <remarks/>
        public DO_DATE_TIME DispositionTime { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT PrecautionType { get; set; }
        /// <remarks/>
        public string TriageID { get; set; }
        /// <remarks/>
        public string Comment { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class TriageEncounterVO
    {
        /// <remarks/>
        public ClinicalFindingGeneralVO[] ClinicalFinding { get; set; }
        /// <remarks/>
        public ChiefComplaintVO ChiefComplaint { get; set; }
        /// <remarks/>
        public PMHVO[] PMH { get; set; }
        /// <remarks/>
        public QuestionnaireVO[] Questionnaire { get; set; }
        /// <remarks/>
        public TriageSummaryVO TriageSummary { get; set; }
        /// <remarks/>
        public DrugHistoryVO[] DrugHistory { get; set; }
        /// <remarks/>
        public AdverseReactionVO[] AdverseReaction { get; set; }
        /// <remarks/>
        public VitalSignsVO VitalSign { get; set; }
        /// <remarks/>
        public BloodPressureVO BloodPressure { get; set; }
        /// <remarks/>
        public PulseOximetryVO PulseOximetry { get; set; }
        /// <remarks/>
        public BloodSugarVO BS { get; set; }
        /// <remarks/>
        public GeneralAssessmentVO[] Assessment { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class AdmittedCompositionVO
    {
        /// <remarks/>
        public AdmissionVO Admission { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
        public InsuranceVO[] Insurance { get; set; }
        /// <remarks/>
        public DiagnosisVO[] Diagnosis { get; set; }
        /// <remarks/>
        public TriageEncounterVO TriageEncounter { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class AdmittedMessageVO
    {
        /// <remarks/>
        public PersonInfoVO Person { get; set; }
        /// <remarks/>
        public MessageIdentifierVO MsgID { get; set; }
        /// <remarks/>
        public AdmittedCompositionVO Composition { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlNamespaceDeclarations()]
        public System.Xml.Serialization.XmlSerializerNamespaces xmlns { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ReimbursementServiceDetailsVO
    {
        /// <remarks/>
        public InsuranceDeductionVO[] Deduction { get; set; }
        /// <remarks/>
        public OrganizationVO ExtraLocation { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT ProvisionMethod { get; set; }
        /// <remarks/>
        public ReimbursementServiceDetailsVO[] RelatedService { get; set; }
        /// <remarks/>
        public string PKID { get; set; }
        /// <remarks/>
        public RelativeCostVO[] RelativeCost { get; set; }
        /// <remarks/>
        public QuantitiesVO[] OtherCosts { get; set; }
        /// <remarks/>
        public DO_QUANTITY BasicInsuranceContribution { get; set; }
        /// <remarks/>
        public string Bed { get; set; }
        /// <remarks/>
        public DO_QUANTITY ServiceCount { get; set; }
        /// <remarks/>
        public DO_QUANTITY PatientContribution { get; set; }
        /// <remarks/>
        public string Room { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Service { get; set; }
        /// <remarks/>
        public DO_DATE StartDate { get; set; }
        /// <remarks/>
        public DO_TIME StartTime { get; set; }
        /// <remarks/>
        public DO_DATE EndDate { get; set; }
        /// <remarks/>
        public DO_TIME EndTime { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT ServiceType { get; set; }
        /// <remarks/>
        public DO_QUANTITY TotalCharge { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT WardType { get; set; }
        /// <remarks/>
        public string WardName { get; set; }
        /// <remarks/>
        public HealthcareProviderVO ServiceProvider { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class InsuranceDeductionVO
    {
        /// <remarks/>
        public DO_QUANTITY Deduction { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT DeductionType { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER RuleID { get; set; }
        /// <remarks/>
        public string DeductionDescription { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ReimbursementServiceGroupRowVO
    {
        /// <remarks/>
        public InsuranceDeductionVO Deduction { get; set; }
        /// <remarks/>
        public DO_QUANTITY PatientContribution { get; set; }
        /// <remarks/>
        public QuantitiesVO[] OtherCosts { get; set; }
        /// <remarks/>
        public DO_QUANTITY BasicInsuranceContribution { get; set; }
        /// <remarks/>
        public DO_QUANTITY ServiceCount { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT ServiceType { get; set; }
        /// <remarks/>
        public DO_QUANTITY TotalCharge { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ReimbursementSummaryVO
    {
        /// <remarks/>
        public InsuranceDeductionVO TotalDeduction { get; set; }
        /// <remarks/>
        public QuantitiesVO[] TotalOtherCosts { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Insurer { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT InsurerBox { get; set; }
        /// <remarks/>
        public DO_QUANTITY TotalBasicInsuranceContribution { get; set; }
        /// <remarks/>
        public int HospitalAccreditation { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT MedicalRecordType { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT GlobalPackage { get; set; }
        /// <remarks/>
        public DO_QUANTITY TotalPatientContribution { get; set; }
        /// <remarks/>
        public DO_QUANTITY TotalCharge { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
        public ReimbursementServiceGroupRowVO[] ReimbursementServiceGroupRow { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class InsurerReimbursementCompositionVO
    {
        /// <remarks/>
        public AdmissionVO Admission { get; set; }
        /// <remarks/>
        public DischargeVO Discharge { get; set; }
        /// <remarks/>
        public ReimbursementSummaryVO ReimbursementSummary { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
        public ReimbursementServiceDetailsVO[] ReimbursementServices { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
        public InsuranceVO[] Insurance { get; set; }
        /// <remarks/>
        public BasicDeathDetailsVO Death { get; set; }
        /// <remarks/>
        public DiagnosisVO[] Diagnosis { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class InsurerReimbursementMessageVO
    {
        /// <remarks/>
        public PersonInfoVO Person { get; set; }
        /// <remarks/>
        public MessageIdentifierVO MsgID { get; set; }
        /// <remarks/>
        public InsurerReimbursementCompositionVO Composition { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlNamespaceDeclarations()]
        public System.Xml.Serialization.XmlSerializerNamespaces xmlns { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ServiceGroupRowVO
    {
        /// <remarks/>
        public DO_QUANTITY PatientContribution { get; set; }
        /// <remarks/>
        public QuantitiesVO[] OtherCosts { get; set; }
        /// <remarks/>
        public DO_QUANTITY BasicInsuranceContribution { get; set; }
        /// <remarks/>
        public DO_QUANTITY ServiceCount { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT ServiceType { get; set; }
        /// <remarks/>
        public DO_QUANTITY TotalCharge { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class BillSummaryVO
    {
        /// <remarks/>
        public QuantitiesVO[] TotalOtherCosts { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Insurer { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT InsurerBox { get; set; }
        /// <remarks/>
        public DO_QUANTITY TotalBasicInsuranceContribution { get; set; }
        /// <remarks/>
        public int HospitalAccreditation { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT MedicalRecordType { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT GlobalPackage { get; set; }
        /// <remarks/>
        public DO_QUANTITY TotalPatientContribution { get; set; }
        /// <remarks/>
        public DO_QUANTITY TotalCharge { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
        public ServiceGroupRowVO[] ServiceGroupRow { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class BillPatientCompositionVO
    {
        /// <remarks/>
        public AdmissionVO Admission { get; set; }
        /// <remarks/>
        public DischargeVO Discharge { get; set; }
        /// <remarks/>
        public BillSummaryVO BillSummary { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
        public ServiceDetailsVO[] BillServices { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
        public InsuranceVO[] Insurance { get; set; }
        /// <remarks/>
        public BasicDeathDetailsVO Death { get; set; }
        /// <remarks/>
        public DiagnosisVO[] Diagnosis { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ServiceDetailsVO
    {
        /// <remarks/>
        public string BatchNumber { get; set; }
        /// <remarks/>
        public OrganizationVO ExtraLocation { get; set; }
        /// <remarks/>
        public ServiceDetailsVO[] RelatedService { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT ProvisionMethod { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER ConfirmationID { get; set; }
        /// <remarks/>
        public HealthcareProviderVO[] OtherParticipation { get; set; }
        /// <remarks/>
        public string PKID { get; set; }
        /// <remarks/>
        public RelativeCostVO[] RelativeCost { get; set; }
        /// <remarks/>
        public QuantitiesVO[] OtherCosts { get; set; }
        /// <remarks/>
        public DO_QUANTITY BasicInsuranceContribution { get; set; }
        /// <remarks/>
        public string Bed { get; set; }
        /// <remarks/>
        public DO_QUANTITY ServiceCount { get; set; }
        /// <remarks/>
        public DO_QUANTITY PatientContribution { get; set; }
        /// <remarks/>
        public string Room { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Service { get; set; }
        /// <remarks/>
        public DO_DATE StartDate { get; set; }
        /// <remarks/>
        public DO_TIME StartTime { get; set; }
        /// <remarks/>
        public DO_DATE EndDate { get; set; }
        /// <remarks/>
        public DO_TIME EndTime { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT ServiceType { get; set; }
        /// <remarks/>
        public DO_QUANTITY TotalCharge { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT WardType { get; set; }
        /// <remarks/>
        public string WardName { get; set; }
        /// <remarks/>
        public HealthcareProviderVO ServiceProvider { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class PatientBillMessageVO
    {
        /// <remarks/>
        public PersonInfoVO Person { get; set; }
        /// <remarks/>
        public MessageIdentifierVO MsgID { get; set; }
        /// <remarks/>
        public BillPatientCompositionVO Composition { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlNamespaceDeclarations()]
        public System.Xml.Serialization.XmlSerializerNamespaces xmlns { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class InfantDeliveryVO
    {
        /// <remarks/>
        public DO_QUANTITY InfantWeight { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> DeliveryPriority { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT DeliveryAgent { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT DeliveryLocation { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> DeliveryNumber { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class DeathCauseVO
    {
        /// <remarks/>
        public DO_QUANTITY Duration2Death { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Cause { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Status { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class DeathCertificateCompositionVO
    {
        /// <remarks/>
        public string HouseholdHeadNationalcode { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT LivingLocationType { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT SourceOfNotification { get; set; }
        /// <remarks/>
        public OrganizationVO OrganizationRegistrer { get; set; }
        /// <remarks/>
        public DO_DATE CertificateIssueDate { get; set; }
        /// <remarks/>
        public HighLevelAreaVO DeathArea { get; set; }
        /// <remarks/>
        public HealthcareProviderVO IndividualRegistrer { get; set; }
        /// <remarks/>
        public HealthcareProviderVO BurialAttesterDetails { get; set; }
        /// <remarks/>
        public string CertificateSerialNumber { get; set; }
        /// <remarks/>
        public string Comment { get; set; }
        /// <remarks/>
        public DO_DATE DeathDate { get; set; }
        /// <remarks/>
        public DO_TIME DeathTime { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT DeathLocation { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
        public DeathCauseVO[] CauseOfDeath { get; set; }
        /// <remarks/>
        public PMHVO[] relatedCondition { get; set; }
        /// <remarks/>
        public PersonInfoVO Mother { get; set; }
        /// <remarks/>
        public InfantDeliveryVO InfantDeliveryInfo { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class DeathCertificateMessageVO
    {
        /// <remarks/>
        public PersonInfoVO Person { get; set; }
        /// <remarks/>
        public MessageIdentifierVO MsgID { get; set; }
        /// <remarks/>
        public DeathCertificateCompositionVO Composition { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class LaboratoryResultCompositionVO
    {
        /// <remarks/>
        public LabRequestVO LabRequest { get; set; }
        /// <remarks/>
        public AdmissionVO Admission { get; set; }
        /// <remarks/>
        public LabTestResultVO[] LabResult { get; set; }
        /// <remarks/>
        public DiagnosisVO[] Diagnosis { get; set; }
        /// <remarks/>
        public InsuranceVO[] Insurance { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class LaboratoryResultMessageVO
    {
        /// <remarks/>
        public PersonInfoVO Person { get; set; }
        /// <remarks/>
        public MessageIdentifierVO MsgID { get; set; }
        /// <remarks/>
        public LaboratoryResultCompositionVO Composition { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlNamespaceDeclarations()]
        public System.Xml.Serialization.XmlSerializerNamespaces xmlns { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class DentalDiagnosisVO
    {
        /// <remarks/>
        public ToothVO Tooth { get; set; }
        /// <remarks/>
        public DiagnosisVO[] Diagnosis { get; set; }
        /// <remarks/>
        public string Comment { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ToothVO
    {
        /// <remarks/>
        public DO_CODED_TEXT ToothName { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Part { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Segment { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<bool> IsMissingTooth { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class DentalTreatmentVO
    {
        /// <remarks/>
        public ToothVO Tooth { get; set; }
        /// <remarks/>
        public ServiceDetailsVO[] Treatment { get; set; }
        /// <remarks/>
        public string Comment { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class DentalCompositionVO
    {
        /// <remarks/>
        public DentalTreatmentVO[] DentalTreatment { get; set; }
        /// <remarks/>
        public DentalDiagnosisVO[] DentalDiagnosis { get; set; }
        /// <remarks/>
        public AbuseHistoryVO[] AbuseHistory { get; set; }
        /// <remarks/>
        public AdmissionVO Admission { get; set; }
        /// <remarks/>
        public PMHVO[] PastMedicalHistory { get; set; }
        /// <remarks/>
        public FamilyHistoryVO[] FamilyHistory { get; set; }
        /// <remarks/>
        public DiagnosisVO[] Diagnosis { get; set; }
        /// <remarks/>
        public MedicationOrderedReportVO[] DrugOrdered { get; set; }
        /// <remarks/>
        public InsuranceVO[] Insurance { get; set; }
        /// <remarks/>
        public DrugHistoryVO[] DrugHistory { get; set; }
        /// <remarks/>
        public AdverseReactionVO[] AdverseReaction { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class DentalCareMessageVO
    {
        /// <remarks/>
        public PersonInfoVO Person { get; set; }
        /// <remarks/>
        public MessageIdentifierVO MsgID { get; set; }
        /// <remarks/>
        public DentalCompositionVO Composition { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlNamespaceDeclarations()]
        public System.Xml.Serialization.XmlSerializerNamespaces xmlns { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class FollowupPlanVO
    {
        /// <remarks/>
        public DO_CODED_TEXT Type { get; set; }
        /// <remarks/>
        public DO_DATE NextEncounterDate { get; set; }
        /// <remarks/>
        public DO_TIME NextEncounterTime { get; set; }
        /// <remarks/>
        public DO_QUANTITY NextEncounter { get; set; }
        /// <remarks/>
        public string Description { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ReferralFeedbackCompositionVO
    {
        /// <remarks/>
        public FollowupPlanVO FollowupPlan { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER ReferralID { get; set; }
        /// <remarks/>
        public GeneralActionReportVO[] CareAction { get; set; }
        /// <remarks/>
        public ClinicalFindingGeneralVO[] ClinicalFinding { get; set; }
        /// <remarks/>
        public AbuseHistoryVO[] AbuseHistory { get; set; }
        /// <remarks/>
        public AdmissionVO Admission { get; set; }
        /// <remarks/>
        public PMHVO[] PastMedicalHistory { get; set; }
        /// <remarks/>
        public FamilyHistoryVO[] FamilyHistory { get; set; }
        /// <remarks/>
        public DiagnosisVO[] Diagnosis { get; set; }
        /// <remarks/>
        public MedicationOrderedReportVO[] DrugOrdered { get; set; }
        /// <remarks/>
        public InsuranceVO Insurance { get; set; }
        /// <remarks/>
        public DrugHistoryVO[] DrugHistory { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ReferralFeedbackMessageVO
    {
        /// <remarks/>
        public PersonInfoVO Person { get; set; }
        /// <remarks/>
        public MessageIdentifierVO MsgID { get; set; }
        /// <remarks/>
        public ReferralFeedbackCompositionVO Composition { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlNamespaceDeclarations()]
        public System.Xml.Serialization.XmlSerializerNamespaces xmlns { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ReferralInfoVO
    {
        /// <remarks/>
        public DO_DATE ReferredDate { get; set; }
        /// <remarks/>
        public DO_TIME ReferredTime { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT ReferredReason { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT ReferredType { get; set; }
        /// <remarks/>
        public OrganizationVO ReferredFacility { get; set; }
        /// <remarks/>
        public HealthcareProviderVO ReferredProvider { get; set; }
        /// <remarks/>
        public string Description { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ReferralCompositionVO
    {
        /// <remarks/>
        public PhysicalExamVO[] PhysicalExams { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER ReferralID { get; set; }
        /// <remarks/>
        public ReferralInfoVO ReferralInfo { get; set; }
        /// <remarks/>
        public GeneralActionReportVO[] CareAction { get; set; }
        /// <remarks/>
        public ClinicalFindingGeneralVO[] ClinicalFinding { get; set; }
        /// <remarks/>
        public AbuseHistoryVO[] AbuseHistory { get; set; }
        /// <remarks/>
        public AdmissionVO Admission { get; set; }
        /// <remarks/>
        public PMHVO[] PastMedicalHistory { get; set; }
        /// <remarks/>
        public FamilyHistoryVO[] FamilyHistory { get; set; }
        /// <remarks/>
        public DiagnosisVO[] Diagnosis { get; set; }
        /// <remarks/>
        public MedicationOrderedReportVO[] DrugOrdered { get; set; }
        /// <remarks/>
        public InsuranceVO Insurance { get; set; }
        /// <remarks/>
        public DrugHistoryVO[] DrugHistory { get; set; }
        /// <remarks/>
        public AdverseReactionVO[] AdverseReaction { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ReferralCaseMessageVO
    {
        /// <remarks/>
        public PersonInfoVO Person { get; set; }
        /// <remarks/>
        public MessageIdentifierVO MsgID { get; set; }
        /// <remarks/>
        public ReferralCompositionVO Composition { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlNamespaceDeclarations()]
        public System.Xml.Serialization.XmlSerializerNamespaces xmlns { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class IngredientVO
    {
        /// <remarks/>
        public DO_CODEABLE_CONCEPT Item { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Role { get; set; }
        /// <remarks/>
        public DO_QUANTITY Amount { get; set; }
        /// <remarks/>
        public DO_QUANTITY AmountMax { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class MedicationPrescriptionRowVO
    {
        /// <remarks/>
        public DO_CODEABLE_CONCEPT AsNeeded { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Priority { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Substitution { get; set; }
        /// <remarks/>
        public DO_CODEABLE_CONCEPT Site { get; set; }
        /// <remarks/>
        public DO_CODEABLE_CONCEPT Method { get; set; }
        /// <remarks/>
        public DO_CODEABLE_CONCEPT ReasonCode { get; set; }
        /// <remarks/>
        public string PatientInstruction { get; set; }
        /// <remarks/>
        public IngredientVO[] Ingredient { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Shape { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT DrugName { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT ProductCode { get; set; }
        /// <remarks/>
        public string DrugNameDescription { get; set; }
        /// <remarks/>
        public DO_QUANTITY Dosage { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Frequency { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Route { get; set; }
        /// <remarks/>
        public string Description { get; set; }
        /// <remarks/>
        public DO_QUANTITY TotalNumber { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class MedicationPrescriptionsVO
    {
        /// <remarks/>
        public ProviderInfoVO Prescriber { get; set; }
        /// <remarks/>
        public DO_DATE IssueDate { get; set; }
        /// <remarks/>
        public DO_TIME IssueTime { get; set; }
        /// <remarks/>
        public string ePrescriptionID { get; set; }
        /// <remarks/>
        public MedicationPrescriptionRowVO[] Orders { get; set; }
        /// <remarks/>
        public DO_DATE ExpiryDate { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public System.Nullable<int> Repeats { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class MedicationPrescriptionsCompositionVO
    {
        /// <remarks/>
        public AdmissionVO Admission { get; set; }
        /// <remarks/>
        public InsuranceVO Insurance { get; set; }
        /// <remarks/>
        public MedicationPrescriptionsVO MedicationPrescriptions { get; set; }
        /// <remarks/>
        public DiagnosisVO[] Diagnosis { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class MedicationPrescriptionsMessageVO
    {
        /// <remarks/>
        public PersonInfoVO Person { get; set; }
        /// <remarks/>
        public MessageIdentifierVO MsgID { get; set; }
        /// <remarks/>
        public MedicationPrescriptionsCompositionVO Composition { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlNamespaceDeclarations()]
        public System.Xml.Serialization.XmlSerializerNamespaces xmlns { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class MedicationDispensedVO
    {
        /// <remarks/>
        public MedicationDispensedVO[] CompoundedProduct { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER ConfirmationID { get; set; }
        /// <remarks/>
        public CostDetailsVO[] Costs { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Shape { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT DrugName { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT ProductCode { get; set; }
        /// <remarks/>
        public string DrugNameDescription { get; set; }
        /// <remarks/>
        public DO_QUANTITY Dosage { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Frequency { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Route { get; set; }
        /// <remarks/>
        public string Description { get; set; }
        /// <remarks/>
        public DO_QUANTITY TotalNumber { get; set; }
        /// <remarks/>
        public DO_QUANTITY TotalCost { get; set; }
        /// <remarks/>
        public DO_QUANTITY InsuranceCost { get; set; }
        /// <remarks/>
        public DO_QUANTITY PatientCost { get; set; }
        /// <remarks/>
        public MedicationDispensedVO ReplaceMedication { get; set; }
        /// <remarks/>
        public string BatchNumber { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class CostDetailsVO
    {
        /// <remarks/>
        public DO_CODED_TEXT Name { get; set; }
        /// <remarks/>
        public DO_QUANTITY Price { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class DispensedPrescriptionsVO
    {
        /// <remarks/>
        public CostDetailsVO[] Costs { get; set; }
        /// <remarks/>
        public DO_QUANTITY InsuranceCost { get; set; }
        /// <remarks/>
        public DO_QUANTITY PatientCost { get; set; }
        /// <remarks/>
        public ProviderInfoVO PrescribingPhysicians { get; set; }
        /// <remarks/>
        public DO_QUANTITY PharmacyTechnicalCost { get; set; }
        /// <remarks/>
        public DO_QUANTITY TotalCost { get; set; }
        /// <remarks/>
        public ProviderInfoVO PharmacyTechnicians { get; set; }
        /// <remarks/>
        public DO_DATE DateDispense { get; set; }
        /// <remarks/>
        public DO_TIME TimeDispense { get; set; }
        /// <remarks/>
        public string SerialNumber { get; set; }
        /// <remarks/>
        public string ePrescriptionID { get; set; }
        /// <remarks/>
        public MedicationDispensedVO[] MedicationDispensed { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class DispensedPrescriptionsCompositionVO
    {
        /// <remarks/>
        public AdmissionVO Admission { get; set; }
        /// <remarks/>
        public InsuranceVO Insurance { get; set; }
        /// <remarks/>
        public DispensedPrescriptionsVO DispensedPrescriptions { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class DispensedPrescriptionsMessageVO
    {
        /// <remarks/>
        public DispensedPrescriptionsCompositionVO Composition { get; set; }
        /// <remarks/>
        public MessageIdentifierVO MsgID { get; set; }
        /// <remarks/>
        public PersonInfoVO Person { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ResultVO
    {
        /// <remarks/>
        public string MessageUID { get; set; }
        /// <remarks/>
        public string ErrorMessage { get; set; }
        /// <remarks/>
        public string CompositionUID { get; set; }
        /// <remarks/>
        public string patientUID { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class ReserveHIDlistVO
    {
        /// <remarks/>
        public DO_IDENTIFIER[] HID { get; set; }
        /// <remarks/>
        public DO_DATE ValidDate { get; set; }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    public partial class InsuranceInquiryVO
    {
        /// <remarks/>
        public string FirstName { get; set; }
        /// <remarks/>
        public string LastName { get; set; }
        /// <remarks/>
        public string Nationalcode { get; set; }
        /// <remarks/>
        public DO_DATE BirthDate { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Insurer { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT InsurerBox { get; set; }
        /// <remarks/>
        public DO_IDENTIFIER InsuranceNumber { get; set; }
        /// <remarks/>
        public DO_DATE ExpirationDate { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT Gender { get; set; }
        /// <remarks/>
        public DO_CODED_TEXT MaritalStatus { get; set; }
        /// <remarks/>
        public string PictureB64 { get; set; }
        /// <remarks/>
        public string Address { get; set; }
        /// <remarks/>
        public string PostalCode { get; set; }
        /// <remarks/>
        public string ErrorMessage { get; set; }
        /// <remarks/>
        public string RecommendationMessage { get; set; }
        /// <remarks/>
        public string InquiryID { get; set; }
        /// <remarks/>
        public UndefinedDataVO[] ExtraProperties { get; set; }


    }
}
