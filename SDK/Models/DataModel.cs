using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.ComponentModel;
//using System.Web.Services;
//using System.Web.Services.Protocols;
using System.Xml.Serialization;


namespace SDK
{
    internal partial class VersionControl
    {
        public int Version_Datamodel = 6;
    }
}

// this is outside
namespace SDK.DataModel
{


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
            private string outputTypeField;

            private string outputTypeAssemblyQualifiedNameField;

            private object outputField;

            private bool isArrayField;

            private byte[] outputObjectByteField;

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
            private DO_IDENTIFIER hIDField;

            private DO_IDENTIFIER hCPIDField;

            private DO_IDENTIFIER hCFIDField;

            private DO_IDENTIFIER parentHIDField;

            private DO_DATE_TIME issueDateField;

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
            private string issuerField;

            private string assignerField;

            private string idField;

            private string typeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string Issuer
            {
                get
                {
                    return this.issuerField;
                }
                set
                {
                    this.issuerField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string Assigner
            {
                get
                {
                    return this.assignerField;
                }
                set
                {
                    this.assignerField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class DO_DATE_TIME
        {
            private System.Nullable<int> yearField;

            private System.Nullable<int> monthField;

            private System.Nullable<int> dayField;

            private System.Nullable<int> hourField;

            private System.Nullable<int> minuteField;

            private System.Nullable<int> secondField;

            private string iSOStringField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> Year
            {
                get
                {
                    return this.yearField;
                }
                set
                {
                    this.yearField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> Month
            {
                get
                {
                    return this.monthField;
                }
                set
                {
                    this.monthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> Day
            {
                get
                {
                    return this.dayField;
                }
                set
                {
                    this.dayField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> Hour
            {
                get
                {
                    return this.hourField;
                }
                set
                {
                    this.hourField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> Minute
            {
                get
                {
                    return this.minuteField;
                }
                set
                {
                    this.minuteField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> Second
            {
                get
                {
                    return this.secondField;
                }
                set
                {
                    this.secondField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string ISOString
            {
                get
                {
                    return this.iSOStringField;
                }
                set
                {
                    this.iSOStringField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class EducationGeneralInfoVO
        {
            private string _StudentIDField;

            private DO_DATE _GraduationDateField;

            private DO_DATE graduationDateField;

            private string studentIDField;

            private PersonVO personInfoField;

            private DO_CODEABLE_CONCEPT universityNameField;

            private DO_IDENTIFIER university_SIAMIDField;

            private DO_CODED_TEXT university_CountryField;

            private DO_CODED_TEXT educationFieldField;

            private DO_CODED_TEXT educationLevelField;

            private DO_CODED_TEXT areaOfInterestField;

            private DO_CODED_TEXT educationLevelTypeField;

            private DO_DATE educationStartDateField;

            private System.Nullable<double> averageField;

            private string descriptionField;

            private UndefinedDataVO[] extraPropertiesField;

            /// <remarks/>
            public string _StudentID
            {
                get
                {
                    return this._StudentIDField;
                }
                set
                {
                    this._StudentIDField = value;
                }
            }

            /// <remarks/>
            public DO_DATE _GraduationDate
            {
                get
                {
                    return this._GraduationDateField;
                }
                set
                {
                    this._GraduationDateField = value;
                }
            }

            /// <remarks/>
            public DO_DATE GraduationDate
            {
                get
                {
                    return this.graduationDateField;
                }
                set
                {
                    this.graduationDateField = value;
                }
            }

            /// <remarks/>
            public string StudentID
            {
                get
                {
                    return this.studentIDField;
                }
                set
                {
                    this.studentIDField = value;
                }
            }

            /// <remarks/>
            public PersonVO PersonInfo
            {
                get
                {
                    return this.personInfoField;
                }
                set
                {
                    this.personInfoField = value;
                }
            }

            /// <remarks/>
            public DO_CODEABLE_CONCEPT UniversityName
            {
                get
                {
                    return this.universityNameField;
                }
                set
                {
                    this.universityNameField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER University_SIAMID
            {
                get
                {
                    return this.university_SIAMIDField;
                }
                set
                {
                    this.university_SIAMIDField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT University_Country
            {
                get
                {
                    return this.university_CountryField;
                }
                set
                {
                    this.university_CountryField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT EducationField
            {
                get
                {
                    return this.educationFieldField;
                }
                set
                {
                    this.educationFieldField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT EducationLevel
            {
                get
                {
                    return this.educationLevelField;
                }
                set
                {
                    this.educationLevelField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT AreaOfInterest
            {
                get
                {
                    return this.areaOfInterestField;
                }
                set
                {
                    this.areaOfInterestField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT EducationLevelType
            {
                get
                {
                    return this.educationLevelTypeField;
                }
                set
                {
                    this.educationLevelTypeField = value;
                }
            }

            /// <remarks/>
            public DO_DATE EducationStartDate
            {
                get
                {
                    return this.educationStartDateField;
                }
                set
                {
                    this.educationStartDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<double> Average
            {
                get
                {
                    return this.averageField;
                }
                set
                {
                    this.averageField = value;
                }
            }

            /// <remarks/>
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            public UndefinedDataVO[] ExtraProperties
            {
                get
                {
                    return this.extraPropertiesField;
                }
                set
                {
                    this.extraPropertiesField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class DO_DATE
        {
            private System.Nullable<int> yearField;

            private System.Nullable<int> monthField;

            private System.Nullable<int> dayField;

            private string iSOStringField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> Year
            {
                get
                {
                    return this.yearField;
                }
                set
                {
                    this.yearField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> Month
            {
                get
                {
                    return this.monthField;
                }
                set
                {
                    this.monthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> Day
            {
                get
                {
                    return this.dayField;
                }
                set
                {
                    this.dayField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string ISOString
            {
                get
                {
                    return this.iSOStringField;
                }
                set
                {
                    this.iSOStringField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class PersonVO
        {
            private System.Nullable<bool> deathStatusField;

            private DO_DATE deathDateField;

            private PersonIdentifierVO[] otherIdentifierField;

            private DO_CODED_TEXT nationalityField;

            private DO_DATE birthDateField;

            private string father_FirstNameField;

            private DO_CODED_TEXT genderField;

            private string firstNameField;

            private string lastNameField;

            private string nationalCodeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<bool> DeathStatus
            {
                get
                {
                    return this.deathStatusField;
                }
                set
                {
                    this.deathStatusField = value;
                }
            }

            /// <remarks/>
            public DO_DATE DeathDate
            {
                get
                {
                    return this.deathDateField;
                }
                set
                {
                    this.deathDateField = value;
                }
            }

            /// <remarks/>
            public PersonIdentifierVO[] OtherIdentifier
            {
                get
                {
                    return this.otherIdentifierField;
                }
                set
                {
                    this.otherIdentifierField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Nationality
            {
                get
                {
                    return this.nationalityField;
                }
                set
                {
                    this.nationalityField = value;
                }
            }

            /// <remarks/>
            public DO_DATE BirthDate
            {
                get
                {
                    return this.birthDateField;
                }
                set
                {
                    this.birthDateField = value;
                }
            }

            /// <remarks/>
            public string Father_FirstName
            {
                get
                {
                    return this.father_FirstNameField;
                }
                set
                {
                    this.father_FirstNameField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Gender
            {
                get
                {
                    return this.genderField;
                }
                set
                {
                    this.genderField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string FirstName
            {
                get
                {
                    return this.firstNameField;
                }
                set
                {
                    this.firstNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string LastName
            {
                get
                {
                    return this.lastNameField;
                }
                set
                {
                    this.lastNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string NationalCode
            {
                get
                {
                    return this.nationalCodeField;
                }
                set
                {
                    this.nationalCodeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class PersonIdentifierVO
        {
            private DO_IDENTIFIER identifierField;

            private DO_DATE expireDateField;

            private DO_DATE issueDateField;

            private System.Nullable<bool> expiredField;

            private string serialNumberField;

            /// <remarks/>
            public DO_IDENTIFIER Identifier
            {
                get
                {
                    return this.identifierField;
                }
                set
                {
                    this.identifierField = value;
                }
            }

            /// <remarks/>
            public DO_DATE ExpireDate
            {
                get
                {
                    return this.expireDateField;
                }
                set
                {
                    this.expireDateField = value;
                }
            }

            /// <remarks/>
            public DO_DATE IssueDate
            {
                get
                {
                    return this.issueDateField;
                }
                set
                {
                    this.issueDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<bool> Expired
            {
                get
                {
                    return this.expiredField;
                }
                set
                {
                    this.expiredField = value;
                }
            }

            /// <remarks/>
            public string SerialNumber
            {
                get
                {
                    return this.serialNumberField;
                }
                set
                {
                    this.serialNumberField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class DO_CODEABLE_CONCEPT
        {
            private string textField;

            private DO_CODED_TEXT codingField;

            /// <remarks/>
            public string Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Coding
            {
                get
                {
                    return this.codingField;
                }
                set
                {
                    this.codingField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class UndefinedDataVO
        {
            private DO_CODED_TEXT elementField;

            private string valueField;

            /// <remarks/>
            public DO_CODED_TEXT Element
            {
                get
                {
                    return this.elementField;
                }
                set
                {
                    this.elementField = value;
                }
            }

            /// <remarks/>
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class LegalPersonInfoVO
        {
            private string nameField;

            private string followupNoField;

            private string nationalCodeField;

            private DO_CODED_TEXT statusField;

            private DO_DATE establishmentDateField;

            private DO_DATE registerDateField;

            private string registerNumberField;

            private string addressField;

            private string postalCodeField;

            private DO_DATE lastModifiedDateField;

            /// <remarks/>
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public string FollowupNo
            {
                get
                {
                    return this.followupNoField;
                }
                set
                {
                    this.followupNoField = value;
                }
            }

            /// <remarks/>
            public string NationalCode
            {
                get
                {
                    return this.nationalCodeField;
                }
                set
                {
                    this.nationalCodeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            public DO_DATE EstablishmentDate
            {
                get
                {
                    return this.establishmentDateField;
                }
                set
                {
                    this.establishmentDateField = value;
                }
            }

            /// <remarks/>
            public DO_DATE RegisterDate
            {
                get
                {
                    return this.registerDateField;
                }
                set
                {
                    this.registerDateField = value;
                }
            }

            /// <remarks/>
            public string RegisterNumber
            {
                get
                {
                    return this.registerNumberField;
                }
                set
                {
                    this.registerNumberField = value;
                }
            }

            /// <remarks/>
            public string Address
            {
                get
                {
                    return this.addressField;
                }
                set
                {
                    this.addressField = value;
                }
            }

            /// <remarks/>
            public string PostalCode
            {
                get
                {
                    return this.postalCodeField;
                }
                set
                {
                    this.postalCodeField = value;
                }
            }

            /// <remarks/>
            public DO_DATE LastModifiedDate
            {
                get
                {
                    return this.lastModifiedDateField;
                }
                set
                {
                    this.lastModifiedDateField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class VeteranInfoVO
        {
            private PersonVO personInfoField;

            private DO_CODED_TEXT veteranQuotaField;

            /// <remarks/>
            public PersonVO PersonInfo
            {
                get
                {
                    return this.personInfoField;
                }
                set
                {
                    this.personInfoField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT VeteranQuota
            {
                get
                {
                    return this.veteranQuotaField;
                }
                set
                {
                    this.veteranQuotaField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class VeteranStatusVO
        {
            private System.Nullable<bool> isMartyrField;

            private System.Nullable<bool> isCaptiveField;

            private System.Nullable<bool> isMissingField;

            private System.Nullable<bool> isDisabledField;

            private System.Nullable<bool> isReleasedField;

            private System.Nullable<int> disabledPercentField;

            private System.Nullable<int> captivityDurationDaysField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<bool> IsMartyr
            {
                get
                {
                    return this.isMartyrField;
                }
                set
                {
                    this.isMartyrField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<bool> IsCaptive
            {
                get
                {
                    return this.isCaptiveField;
                }
                set
                {
                    this.isCaptiveField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<bool> IsMissing
            {
                get
                {
                    return this.isMissingField;
                }
                set
                {
                    this.isMissingField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<bool> IsDisabled
            {
                get
                {
                    return this.isDisabledField;
                }
                set
                {
                    this.isDisabledField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<bool> IsReleased
            {
                get
                {
                    return this.isReleasedField;
                }
                set
                {
                    this.isReleasedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> DisabledPercent
            {
                get
                {
                    return this.disabledPercentField;
                }
                set
                {
                    this.disabledPercentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> CaptivityDurationDays
            {
                get
                {
                    return this.captivityDurationDaysField;
                }
                set
                {
                    this.captivityDurationDaysField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class VeteranGeneralInfoVO
        {
            private PersonVO personInfoField;

            private DO_IDENTIFIER applicantIDField;

            private VeteranStatusVO veteranStatusField;

            private VeteranStatusVO veteranSiblingStatusField;

            private VeteranStatusVO veteranParentStatusField;

            private VeteranStatusVO veteranChildStatusField;

            private VeteranStatusVO veteranSpouseStatusField;

            /// <remarks/>
            public PersonVO PersonInfo
            {
                get
                {
                    return this.personInfoField;
                }
                set
                {
                    this.personInfoField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER ApplicantID
            {
                get
                {
                    return this.applicantIDField;
                }
                set
                {
                    this.applicantIDField = value;
                }
            }

            /// <remarks/>
            public VeteranStatusVO VeteranStatus
            {
                get
                {
                    return this.veteranStatusField;
                }
                set
                {
                    this.veteranStatusField = value;
                }
            }

            /// <remarks/>
            public VeteranStatusVO VeteranSiblingStatus
            {
                get
                {
                    return this.veteranSiblingStatusField;
                }
                set
                {
                    this.veteranSiblingStatusField = value;
                }
            }

            /// <remarks/>
            public VeteranStatusVO VeteranParentStatus
            {
                get
                {
                    return this.veteranParentStatusField;
                }
                set
                {
                    this.veteranParentStatusField = value;
                }
            }

            /// <remarks/>
            public VeteranStatusVO VeteranChildStatus
            {
                get
                {
                    return this.veteranChildStatusField;
                }
                set
                {
                    this.veteranChildStatusField = value;
                }
            }

            /// <remarks/>
            public VeteranStatusVO VeteranSpouseStatus
            {
                get
                {
                    return this.veteranSpouseStatusField;
                }
                set
                {
                    this.veteranSpouseStatusField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class PostalAddressVO
        {
            private HighLevelAreaVO highLevelAreaField;

            private AddressDetailsVO addressDetailsField;

            /// <remarks/>
            public HighLevelAreaVO HighLevelArea
            {
                get
                {
                    return this.highLevelAreaField;
                }
                set
                {
                    this.highLevelAreaField = value;
                }
            }

            /// <remarks/>
            public AddressDetailsVO AddressDetails
            {
                get
                {
                    return this.addressDetailsField;
                }
                set
                {
                    this.addressDetailsField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class HighLevelAreaVO
        {
            private DO_CODED_TEXT nationalAreaCodeField;

            private DO_CODED_TEXT countryField;

            private DO_CODED_TEXT provinceField;

            private DO_CODED_TEXT cityField;

            private DO_CODED_TEXT townField;

            private DO_CODED_TEXT districtField;

            private DO_CODED_TEXT ruralAreaField;

            private DO_CODED_TEXT villageField;

            /// <remarks/>
            public DO_CODED_TEXT NationalAreaCode
            {
                get
                {
                    return this.nationalAreaCodeField;
                }
                set
                {
                    this.nationalAreaCodeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Country
            {
                get
                {
                    return this.countryField;
                }
                set
                {
                    this.countryField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Province
            {
                get
                {
                    return this.provinceField;
                }
                set
                {
                    this.provinceField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT City
            {
                get
                {
                    return this.cityField;
                }
                set
                {
                    this.cityField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Town
            {
                get
                {
                    return this.townField;
                }
                set
                {
                    this.townField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT District
            {
                get
                {
                    return this.districtField;
                }
                set
                {
                    this.districtField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT RuralArea
            {
                get
                {
                    return this.ruralAreaField;
                }
                set
                {
                    this.ruralAreaField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Village
            {
                get
                {
                    return this.villageField;
                }
                set
                {
                    this.villageField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class AddressDetailsVO
        {
            private string avenueField;

            private string buildingNameField;

            private string descriptionField;

            private string floorNoField;

            private string houseNoField;

            private string preAvenueField;

            private string sideFloorField;

            private string parishField;

            private DO_IDENTIFIER postalCodeField;

            /// <remarks/>
            public string Avenue
            {
                get
                {
                    return this.avenueField;
                }
                set
                {
                    this.avenueField = value;
                }
            }

            /// <remarks/>
            public string BuildingName
            {
                get
                {
                    return this.buildingNameField;
                }
                set
                {
                    this.buildingNameField = value;
                }
            }

            /// <remarks/>
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            public string FloorNo
            {
                get
                {
                    return this.floorNoField;
                }
                set
                {
                    this.floorNoField = value;
                }
            }

            /// <remarks/>
            public string HouseNo
            {
                get
                {
                    return this.houseNoField;
                }
                set
                {
                    this.houseNoField = value;
                }
            }

            /// <remarks/>
            public string PreAvenue
            {
                get
                {
                    return this.preAvenueField;
                }
                set
                {
                    this.preAvenueField = value;
                }
            }

            /// <remarks/>
            public string SideFloor
            {
                get
                {
                    return this.sideFloorField;
                }
                set
                {
                    this.sideFloorField = value;
                }
            }

            /// <remarks/>
            public string Parish
            {
                get
                {
                    return this.parishField;
                }
                set
                {
                    this.parishField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER PostalCode
            {
                get
                {
                    return this.postalCodeField;
                }
                set
                {
                    this.postalCodeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class PhoneAddressVO
        {
            private string operatorNameField;

            private string phoneNumberField;

            private DO_IDENTIFIER postalCodeField;

            private string addressDetailField;

            /// <remarks/>
            public string OperatorName
            {
                get
                {
                    return this.operatorNameField;
                }
                set
                {
                    this.operatorNameField = value;
                }
            }

            /// <remarks/>
            public string PhoneNumber
            {
                get
                {
                    return this.phoneNumberField;
                }
                set
                {
                    this.phoneNumberField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER PostalCode
            {
                get
                {
                    return this.postalCodeField;
                }
                set
                {
                    this.postalCodeField = value;
                }
            }

            /// <remarks/>
            public string AddressDetail
            {
                get
                {
                    return this.addressDetailField;
                }
                set
                {
                    this.addressDetailField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class MobileLocationVO
        {
            private string operatorNameField;

            private string mobileNumberField;

            private DO_DATE_TIME dateTimeField;

            private GeographicalCoordinatesVO locationField;

            private HighLevelAreaVO highLevelAddressField;

            private string addressDetailField;

            /// <remarks/>
            public string OperatorName
            {
                get
                {
                    return this.operatorNameField;
                }
                set
                {
                    this.operatorNameField = value;
                }
            }

            /// <remarks/>
            public string MobileNumber
            {
                get
                {
                    return this.mobileNumberField;
                }
                set
                {
                    this.mobileNumberField = value;
                }
            }

            /// <remarks/>
            public DO_DATE_TIME DateTime
            {
                get
                {
                    return this.dateTimeField;
                }
                set
                {
                    this.dateTimeField = value;
                }
            }

            /// <remarks/>
            public GeographicalCoordinatesVO Location
            {
                get
                {
                    return this.locationField;
                }
                set
                {
                    this.locationField = value;
                }
            }

            /// <remarks/>
            public HighLevelAreaVO HighLevelAddress
            {
                get
                {
                    return this.highLevelAddressField;
                }
                set
                {
                    this.highLevelAddressField = value;
                }
            }

            /// <remarks/>
            public string AddressDetail
            {
                get
                {
                    return this.addressDetailField;
                }
                set
                {
                    this.addressDetailField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class GeographicalCoordinatesVO
        {
            private System.Nullable<double> latitudeField;

            private System.Nullable<double> longitudeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<double> Latitude
            {
                get
                {
                    return this.latitudeField;
                }
                set
                {
                    this.latitudeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<double> Longitude
            {
                get
                {
                    return this.longitudeField;
                }
                set
                {
                    this.longitudeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class UserCallCountVO
        {
            private MethodCallLimitationVO callLimitationField;

            private DO_DATE lastDayCallField;

            private int totalCallField;

            private int lastDayCallCountField;

            private int failedCallCountField;

            /// <remarks/>
            public MethodCallLimitationVO CallLimitation
            {
                get
                {
                    return this.callLimitationField;
                }
                set
                {
                    this.callLimitationField = value;
                }
            }

            /// <remarks/>
            public DO_DATE LastDayCall
            {
                get
                {
                    return this.lastDayCallField;
                }
                set
                {
                    this.lastDayCallField = value;
                }
            }

            /// <remarks/>
            public int TotalCall
            {
                get
                {
                    return this.totalCallField;
                }
                set
                {
                    this.totalCallField = value;
                }
            }

            /// <remarks/>
            public int LastDayCallCount
            {
                get
                {
                    return this.lastDayCallCountField;
                }
                set
                {
                    this.lastDayCallCountField = value;
                }
            }

            /// <remarks/>
            public int FailedCallCount
            {
                get
                {
                    return this.failedCallCountField;
                }
                set
                {
                    this.failedCallCountField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class MethodCallLimitationVO
        {
            private MethodVO methodField;

            private int limitCallPerDayField;

            private int limitTotalCallField;

            /// <remarks/>
            public MethodVO Method
            {
                get
                {
                    return this.methodField;
                }
                set
                {
                    this.methodField = value;
                }
            }

            /// <remarks/>
            public int LimitCallPerDay
            {
                get
                {
                    return this.limitCallPerDayField;
                }
                set
                {
                    this.limitCallPerDayField = value;
                }
            }

            /// <remarks/>
            public int LimitTotalCall
            {
                get
                {
                    return this.limitTotalCallField;
                }
                set
                {
                    this.limitTotalCallField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class MethodVO
        {
            private string methodNameField;

            private string serviceNameField;

            /// <remarks/>
            public string MethodName
            {
                get
                {
                    return this.methodNameField;
                }
                set
                {
                    this.methodNameField = value;
                }
            }

            /// <remarks/>
            public string ServiceName
            {
                get
                {
                    return this.serviceNameField;
                }
                set
                {
                    this.serviceNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class MethodCallPackageVO
        {
            private string packageNameField;

            private MethodCallLimitationVO[] callLimitationField;

            /// <remarks/>
            public string PackageName
            {
                get
                {
                    return this.packageNameField;
                }
                set
                {
                    this.packageNameField = value;
                }
            }

            /// <remarks/>
            public MethodCallLimitationVO[] CallLimitation
            {
                get
                {
                    return this.callLimitationField;
                }
                set
                {
                    this.callLimitationField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://it.behdasht.gov.ir/")]
        public partial class EquipmentMessageResultVO
        {
            private byte[] channelField;

            private string messageIDField;

            private string errorMessageField;

            private string nEINField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArray()]
            public byte[] Channel
            {
                get
                {
                    return this.channelField;
                }
                set
                {
                    this.channelField = value;
                }
            }

            /// <remarks/>
            public string MessageID
            {
                get
                {
                    return this.messageIDField;
                }
                set
                {
                    this.messageIDField = value;
                }
            }

            /// <remarks/>
            public string ErrorMessage
            {
                get
                {
                    return this.errorMessageField;
                }
                set
                {
                    this.errorMessageField = value;
                }
            }

            /// <remarks/>
            public string NEIN
            {
                get
                {
                    return this.nEINField;
                }
                set
                {
                    this.nEINField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://it.behdasht.gov.ir/")]
        public partial class EquipmentMessageIdentifierVO
        {
            private string nEINField;

            private DO_CODED_TEXT statusField;

            private DO_IDENTIFIER systemIDField;

            private DO_IDENTIFIER locationIDField;

            private SignatureVO signField;

            /// <remarks/>
            public string NEIN
            {
                get
                {
                    return this.nEINField;
                }
                set
                {
                    this.nEINField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER SystemID
            {
                get
                {
                    return this.systemIDField;
                }
                set
                {
                    this.systemIDField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER LocationID
            {
                get
                {
                    return this.locationIDField;
                }
                set
                {
                    this.locationIDField = value;
                }
            }

            /// <remarks/>
            public SignatureVO Sign
            {
                get
                {
                    return this.signField;
                }
                set
                {
                    this.signField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://it.behdasht.gov.ir/")]
        public partial class OrganizationUnitVO
        {
            private string nameField;

            private DO_IDENTIFIER identificationField;

            /// <remarks/>
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER Identification
            {
                get
                {
                    return this.identificationField;
                }
                set
                {
                    this.identificationField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://it.behdasht.gov.ir/")]
        public partial class OrganizationLocationVO
        {
            private OrganizationUnitVO parentOrganizationField;

            private OrganizationUnitVO organizationField;

            private DO_CODED_TEXT organizationTypeField;

            private OrganizationUnitVO departmentField;

            private DO_CODED_TEXT departmentTypeField;

            private OrganizationUnitVO buildingField;

            private string roomField;

            /// <remarks/>
            public OrganizationUnitVO ParentOrganization
            {
                get
                {
                    return this.parentOrganizationField;
                }
                set
                {
                    this.parentOrganizationField = value;
                }
            }

            /// <remarks/>
            public OrganizationUnitVO Organization
            {
                get
                {
                    return this.organizationField;
                }
                set
                {
                    this.organizationField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT OrganizationType
            {
                get
                {
                    return this.organizationTypeField;
                }
                set
                {
                    this.organizationTypeField = value;
                }
            }

            /// <remarks/>
            public OrganizationUnitVO Department
            {
                get
                {
                    return this.departmentField;
                }
                set
                {
                    this.departmentField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT DepartmentType
            {
                get
                {
                    return this.departmentTypeField;
                }
                set
                {
                    this.departmentTypeField = value;
                }
            }

            /// <remarks/>
            public OrganizationUnitVO Building
            {
                get
                {
                    return this.buildingField;
                }
                set
                {
                    this.buildingField = value;
                }
            }

            /// <remarks/>
            public string Room
            {
                get
                {
                    return this.roomField;
                }
                set
                {
                    this.roomField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://it.behdasht.gov.ir/")]
        public partial class MedicalEquipmentInfoVO
        {
            private string localEquipmentInventoryNumberField;

            private string nationalEquipmentInventoryNumberField;

            private DO_CODED_TEXT equipmentTypeField;

            private DO_CODED_TEXT equipmentStatusField;

            private DO_CODED_TEXT inactiveReasonField;

            private string inactiveReasonDescriptionField;

            private DO_CODED_TEXT equipmentCodeField;

            private DO_CODED_TEXT equipmentUseField;

            private string modelNumberField;

            private DO_CODEABLE_CONCEPT markField;

            private string manufacturerSerialNumberField;

            private DO_QUANTITY purchasePriceField;

            private string manufacturerNameField;

            private DO_IDENTIFIER manufacturerIdentifierField;

            private string vendorNameField;

            private DO_IDENTIFIER vendorIdentifierField;

            private string agentCompanyNameField;

            private DO_IDENTIFIER agentCompanyIdentifierField;

            private DO_DATE installationDateField;

            private DO_DATE operationDateField;

            private DO_DATE purchaseDateField;

            private DO_DATE constructionDateField;

            private DO_DATE warrantyExpirationDateField;

            private OrganizationLocationVO locationField;

            private DO_CODED_TEXT manufacturerCountryField;

            private UndefinedDataVO[] extraPropertiesField;

            /// <remarks/>
            public string LocalEquipmentInventoryNumber
            {
                get
                {
                    return this.localEquipmentInventoryNumberField;
                }
                set
                {
                    this.localEquipmentInventoryNumberField = value;
                }
            }

            /// <remarks/>
            public string NationalEquipmentInventoryNumber
            {
                get
                {
                    return this.nationalEquipmentInventoryNumberField;
                }
                set
                {
                    this.nationalEquipmentInventoryNumberField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT EquipmentType
            {
                get
                {
                    return this.equipmentTypeField;
                }
                set
                {
                    this.equipmentTypeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT EquipmentStatus
            {
                get
                {
                    return this.equipmentStatusField;
                }
                set
                {
                    this.equipmentStatusField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT InactiveReason
            {
                get
                {
                    return this.inactiveReasonField;
                }
                set
                {
                    this.inactiveReasonField = value;
                }
            }

            /// <remarks/>
            public string InactiveReasonDescription
            {
                get
                {
                    return this.inactiveReasonDescriptionField;
                }
                set
                {
                    this.inactiveReasonDescriptionField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT EquipmentCode
            {
                get
                {
                    return this.equipmentCodeField;
                }
                set
                {
                    this.equipmentCodeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT EquipmentUse
            {
                get
                {
                    return this.equipmentUseField;
                }
                set
                {
                    this.equipmentUseField = value;
                }
            }

            /// <remarks/>
            public string ModelNumber
            {
                get
                {
                    return this.modelNumberField;
                }
                set
                {
                    this.modelNumberField = value;
                }
            }

            /// <remarks/>
            public DO_CODEABLE_CONCEPT Mark
            {
                get
                {
                    return this.markField;
                }
                set
                {
                    this.markField = value;
                }
            }

            /// <remarks/>
            public string ManufacturerSerialNumber
            {
                get
                {
                    return this.manufacturerSerialNumberField;
                }
                set
                {
                    this.manufacturerSerialNumberField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY PurchasePrice
            {
                get
                {
                    return this.purchasePriceField;
                }
                set
                {
                    this.purchasePriceField = value;
                }
            }

            /// <remarks/>
            public string ManufacturerName
            {
                get
                {
                    return this.manufacturerNameField;
                }
                set
                {
                    this.manufacturerNameField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER ManufacturerIdentifier
            {
                get
                {
                    return this.manufacturerIdentifierField;
                }
                set
                {
                    this.manufacturerIdentifierField = value;
                }
            }

            /// <remarks/>
            public string VendorName
            {
                get
                {
                    return this.vendorNameField;
                }
                set
                {
                    this.vendorNameField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER VendorIdentifier
            {
                get
                {
                    return this.vendorIdentifierField;
                }
                set
                {
                    this.vendorIdentifierField = value;
                }
            }

            /// <remarks/>
            public string AgentCompanyName
            {
                get
                {
                    return this.agentCompanyNameField;
                }
                set
                {
                    this.agentCompanyNameField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER AgentCompanyIdentifier
            {
                get
                {
                    return this.agentCompanyIdentifierField;
                }
                set
                {
                    this.agentCompanyIdentifierField = value;
                }
            }

            /// <remarks/>
            public DO_DATE InstallationDate
            {
                get
                {
                    return this.installationDateField;
                }
                set
                {
                    this.installationDateField = value;
                }
            }

            /// <remarks/>
            public DO_DATE OperationDate
            {
                get
                {
                    return this.operationDateField;
                }
                set
                {
                    this.operationDateField = value;
                }
            }

            /// <remarks/>
            public DO_DATE PurchaseDate
            {
                get
                {
                    return this.purchaseDateField;
                }
                set
                {
                    this.purchaseDateField = value;
                }
            }

            /// <remarks/>
            public DO_DATE ConstructionDate
            {
                get
                {
                    return this.constructionDateField;
                }
                set
                {
                    this.constructionDateField = value;
                }
            }

            /// <remarks/>
            public DO_DATE WarrantyExpirationDate
            {
                get
                {
                    return this.warrantyExpirationDateField;
                }
                set
                {
                    this.warrantyExpirationDateField = value;
                }
            }

            /// <remarks/>
            public OrganizationLocationVO Location
            {
                get
                {
                    return this.locationField;
                }
                set
                {
                    this.locationField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT ManufacturerCountry
            {
                get
                {
                    return this.manufacturerCountryField;
                }
                set
                {
                    this.manufacturerCountryField = value;
                }
            }

            /// <remarks/>
            public UndefinedDataVO[] ExtraProperties
            {
                get
                {
                    return this.extraPropertiesField;
                }
                set
                {
                    this.extraPropertiesField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class DO_QUANTITY
        {
            private System.Nullable<double> magnitudeField;

            private string magnitudeStatusField;

            private string unitField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<double> Magnitude
            {
                get
                {
                    return this.magnitudeField;
                }
                set
                {
                    this.magnitudeField = value;
                }
            }

            /// <remarks/>
            public string MagnitudeStatus
            {
                get
                {
                    return this.magnitudeStatusField;
                }
                set
                {
                    this.magnitudeStatusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string Unit
            {
                get
                {
                    return this.unitField;
                }
                set
                {
                    this.unitField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://it.behdasht.gov.ir/")]
        public partial class EquipmentInventoryMessageVO
        {
            private MedicalEquipmentInfoVO equipmentInfoField;

            private EquipmentMessageIdentifierVO messageIdentifierField;

            /// <remarks/>
            public MedicalEquipmentInfoVO EquipmentInfo
            {
                get
                {
                    return this.equipmentInfoField;
                }
                set
                {
                    this.equipmentInfoField = value;
                }
            }

            /// <remarks/>
            public EquipmentMessageIdentifierVO MessageIdentifier
            {
                get
                {
                    return this.messageIdentifierField;
                }
                set
                {
                    this.messageIdentifierField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class DrugInfoVO
        {
            private string drugGenericNameField;

            private string licenseOwnerCompanyNameField;

            private DO_IDENTIFIER licenseOwnerCompanyIDField;

            private string producerCompanyNameField;

            private DO_IDENTIFIER producerCompanyIDField;

            private DO_CODED_TEXT iRCField;

            private DO_CODED_TEXT gTINField;

            private DO_QUANTITY consumerPriceField;

            private DO_QUANTITY distributerPriceField;

            private DO_QUANTITY pharmacyPriceField;

            private string faFullTradeNameField;

            private string enFullTradeNameField;

            /// <remarks/>
            public string DrugGenericName
            {
                get
                {
                    return this.drugGenericNameField;
                }
                set
                {
                    this.drugGenericNameField = value;
                }
            }

            /// <remarks/>
            public string LicenseOwnerCompanyName
            {
                get
                {
                    return this.licenseOwnerCompanyNameField;
                }
                set
                {
                    this.licenseOwnerCompanyNameField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER LicenseOwnerCompanyID
            {
                get
                {
                    return this.licenseOwnerCompanyIDField;
                }
                set
                {
                    this.licenseOwnerCompanyIDField = value;
                }
            }

            /// <remarks/>
            public string ProducerCompanyName
            {
                get
                {
                    return this.producerCompanyNameField;
                }
                set
                {
                    this.producerCompanyNameField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER ProducerCompanyID
            {
                get
                {
                    return this.producerCompanyIDField;
                }
                set
                {
                    this.producerCompanyIDField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT IRC
            {
                get
                {
                    return this.iRCField;
                }
                set
                {
                    this.iRCField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT GTIN
            {
                get
                {
                    return this.gTINField;
                }
                set
                {
                    this.gTINField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY ConsumerPrice
            {
                get
                {
                    return this.consumerPriceField;
                }
                set
                {
                    this.consumerPriceField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY DistributerPrice
            {
                get
                {
                    return this.distributerPriceField;
                }
                set
                {
                    this.distributerPriceField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY PharmacyPrice
            {
                get
                {
                    return this.pharmacyPriceField;
                }
                set
                {
                    this.pharmacyPriceField = value;
                }
            }

            /// <remarks/>
            public string FaFullTradeName
            {
                get
                {
                    return this.faFullTradeNameField;
                }
                set
                {
                    this.faFullTradeNameField = value;
                }
            }

            /// <remarks/>
            public string EnFullTradeName
            {
                get
                {
                    return this.enFullTradeNameField;
                }
                set
                {
                    this.enFullTradeNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class EquipmentInfoVO
        {
            private string licenseOwnerCompanyNameField;

            private DO_IDENTIFIER licenseOwnerCompanyIDField;

            private string producerCompanyNameField;

            private DO_IDENTIFIER producerCompanyIDField;

            private DO_CODED_TEXT producerCountryField;

            private DO_CODED_TEXT iRCField;

            private DO_CODED_TEXT gTINField;

            private string faFullTradeNameField;

            private string enFullTradeNameField;

            /// <remarks/>
            public string LicenseOwnerCompanyName
            {
                get
                {
                    return this.licenseOwnerCompanyNameField;
                }
                set
                {
                    this.licenseOwnerCompanyNameField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER LicenseOwnerCompanyID
            {
                get
                {
                    return this.licenseOwnerCompanyIDField;
                }
                set
                {
                    this.licenseOwnerCompanyIDField = value;
                }
            }

            /// <remarks/>
            public string ProducerCompanyName
            {
                get
                {
                    return this.producerCompanyNameField;
                }
                set
                {
                    this.producerCompanyNameField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER ProducerCompanyID
            {
                get
                {
                    return this.producerCompanyIDField;
                }
                set
                {
                    this.producerCompanyIDField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT ProducerCountry
            {
                get
                {
                    return this.producerCountryField;
                }
                set
                {
                    this.producerCountryField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT IRC
            {
                get
                {
                    return this.iRCField;
                }
                set
                {
                    this.iRCField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT GTIN
            {
                get
                {
                    return this.gTINField;
                }
                set
                {
                    this.gTINField = value;
                }
            }

            /// <remarks/>
            public string FaFullTradeName
            {
                get
                {
                    return this.faFullTradeNameField;
                }
                set
                {
                    this.faFullTradeNameField = value;
                }
            }

            /// <remarks/>
            public string EnFullTradeName
            {
                get
                {
                    return this.enFullTradeNameField;
                }
                set
                {
                    this.enFullTradeNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://sepas.behdasht.gov.ir/")]
        public partial class HealthInsuranceClaimIdentifierVO
        {
            private string idField;

            private string errorMessageField;

            private byte[] channelField;

            private System.Nullable<DateTime> dateTimeForResponseField;

            /// <remarks/>
            public string ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            public string ErrorMessage
            {
                get
                {
                    return this.errorMessageField;
                }
                set
                {
                    this.errorMessageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArray()]
            public byte[] Channel
            {
                get
                {
                    return this.channelField;
                }
                set
                {
                    this.channelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<DateTime> DateTimeForResponse
            {
                get
                {
                    return this.dateTimeForResponseField;
                }
                set
                {
                    this.dateTimeForResponseField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class CoverageServiceDetailsVO
        {
            private string pKIDField;

            private DO_CODED_TEXT serviceField;

            private DO_QUANTITY basicInsuranceContributionField;

            private DO_QUANTITY patientContributionField;

            private DO_QUANTITY totalChargeField;

            private QuantitiesVO[] otherCostsField;

            private RelativeCostVO[] relativeCostField;

            private InquiryResultVO[] inquiryResultField;

            private DO_QUANTITY serviceCountField;

            private CoverageServiceDetailsVO[] relatedServiceField;

            private DO_IDENTIFIER confirmationIDField;

            private DO_DATE confirmationIDExpirationDateField;

            /// <remarks/>
            public string PKID
            {
                get
                {
                    return this.pKIDField;
                }
                set
                {
                    this.pKIDField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Service
            {
                get
                {
                    return this.serviceField;
                }
                set
                {
                    this.serviceField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY BasicInsuranceContribution
            {
                get
                {
                    return this.basicInsuranceContributionField;
                }
                set
                {
                    this.basicInsuranceContributionField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY PatientContribution
            {
                get
                {
                    return this.patientContributionField;
                }
                set
                {
                    this.patientContributionField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY TotalCharge
            {
                get
                {
                    return this.totalChargeField;
                }
                set
                {
                    this.totalChargeField = value;
                }
            }

            /// <remarks/>
            public QuantitiesVO[] OtherCosts
            {
                get
                {
                    return this.otherCostsField;
                }
                set
                {
                    this.otherCostsField = value;
                }
            }

            /// <remarks/>
            public RelativeCostVO[] RelativeCost
            {
                get
                {
                    return this.relativeCostField;
                }
                set
                {
                    this.relativeCostField = value;
                }
            }

            /// <remarks/>
            public InquiryResultVO[] InquiryResult
            {
                get
                {
                    return this.inquiryResultField;
                }
                set
                {
                    this.inquiryResultField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY ServiceCount
            {
                get
                {
                    return this.serviceCountField;
                }
                set
                {
                    this.serviceCountField = value;
                }
            }

            /// <remarks/>
            public CoverageServiceDetailsVO[] RelatedService
            {
                get
                {
                    return this.relatedServiceField;
                }
                set
                {
                    this.relatedServiceField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER ConfirmationID
            {
                get
                {
                    return this.confirmationIDField;
                }
                set
                {
                    this.confirmationIDField = value;
                }
            }

            /// <remarks/>
            public DO_DATE ConfirmationIDExpirationDate
            {
                get
                {
                    return this.confirmationIDExpirationDateField;
                }
                set
                {
                    this.confirmationIDExpirationDateField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class QuantitiesVO
        {
            private DO_CODED_TEXT nameField;

            private DO_QUANTITY valueField;

            /// <remarks/>
            public DO_CODED_TEXT Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class RelativeCostVO
        {
            private System.Nullable<double> kValueField;

            private DO_CODED_TEXT kTypeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<double> KValue
            {
                get
                {
                    return this.kValueField;
                }
                set
                {
                    this.kValueField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT KType
            {
                get
                {
                    return this.kTypeField;
                }
                set
                {
                    this.kTypeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class InquiryResultVO
        {
            private DO_IDENTIFIER ruleIDField;

            private string messageIDField;

            private string messageField;

            private DateTime timeField;

            private DO_CODED_TEXT messageTypeField;

            private DO_CODED_TEXT ruleTypeField;

            private DO_IDENTIFIER confirmationIDField;

            private DO_DATE confirmationIDExpirationDateField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public DO_IDENTIFIER RuleID
            {
                get
                {
                    return this.ruleIDField;
                }
                set
                {
                    this.ruleIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public string MessageID
            {
                get
                {
                    return this.messageIDField;
                }
                set
                {
                    this.messageIDField = value;
                }
            }

            /// <remarks/>
            public string Message
            {
                get
                {
                    return this.messageField;
                }
                set
                {
                    this.messageField = value;
                }
            }

            /// <remarks/>
            public DateTime Time
            {
                get
                {
                    return this.timeField;
                }
                set
                {
                    this.timeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT MessageType
            {
                get
                {
                    return this.messageTypeField;
                }
                set
                {
                    this.messageTypeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT RuleType
            {
                get
                {
                    return this.ruleTypeField;
                }
                set
                {
                    this.ruleTypeField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER ConfirmationID
            {
                get
                {
                    return this.confirmationIDField;
                }
                set
                {
                    this.confirmationIDField = value;
                }
            }

            /// <remarks/>
            public DO_DATE ConfirmationIDExpirationDate
            {
                get
                {
                    return this.confirmationIDExpirationDateField;
                }
                set
                {
                    this.confirmationIDExpirationDateField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class CoverageServiceGroupRowVO
        {
            private DO_QUANTITY patientContributionField;

            private QuantitiesVO[] otherCostsField;

            private DO_QUANTITY basicInsuranceContributionField;

            private DO_QUANTITY serviceCountField;

            private DO_CODED_TEXT serviceTypeField;

            private DO_QUANTITY totalChargeField;

            /// <remarks/>
            public DO_QUANTITY PatientContribution
            {
                get
                {
                    return this.patientContributionField;
                }
                set
                {
                    this.patientContributionField = value;
                }
            }

            /// <remarks/>
            public QuantitiesVO[] OtherCosts
            {
                get
                {
                    return this.otherCostsField;
                }
                set
                {
                    this.otherCostsField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY BasicInsuranceContribution
            {
                get
                {
                    return this.basicInsuranceContributionField;
                }
                set
                {
                    this.basicInsuranceContributionField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY ServiceCount
            {
                get
                {
                    return this.serviceCountField;
                }
                set
                {
                    this.serviceCountField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT ServiceType
            {
                get
                {
                    return this.serviceTypeField;
                }
                set
                {
                    this.serviceTypeField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY TotalCharge
            {
                get
                {
                    return this.totalChargeField;
                }
                set
                {
                    this.totalChargeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class CoverageSummaryVO
        {
            private QuantitiesVO[] totalOtherCostsField;

            private DO_QUANTITY totalBasicInsuranceContributionField;

            private DO_QUANTITY totalPatientContributionField;

            private DO_QUANTITY totalChargeField;

            private CoverageServiceGroupRowVO[] coverageServiceGroupField;

            private InquiryResultVO[] inquiryResultField;

            /// <remarks/>
            public QuantitiesVO[] TotalOtherCosts
            {
                get
                {
                    return this.totalOtherCostsField;
                }
                set
                {
                    this.totalOtherCostsField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY TotalBasicInsuranceContribution
            {
                get
                {
                    return this.totalBasicInsuranceContributionField;
                }
                set
                {
                    this.totalBasicInsuranceContributionField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY TotalPatientContribution
            {
                get
                {
                    return this.totalPatientContributionField;
                }
                set
                {
                    this.totalPatientContributionField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY TotalCharge
            {
                get
                {
                    return this.totalChargeField;
                }
                set
                {
                    this.totalChargeField = value;
                }
            }

            /// <remarks/>
            public CoverageServiceGroupRowVO[] CoverageServiceGroup
            {
                get
                {
                    return this.coverageServiceGroupField;
                }
                set
                {
                    this.coverageServiceGroupField = value;
                }
            }

            /// <remarks/>
            public InquiryResultVO[] InquiryResult
            {
                get
                {
                    return this.inquiryResultField;
                }
                set
                {
                    this.inquiryResultField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class InsuranceCoverageVO
        {
            private DO_CODED_TEXT inquiryStateField;

            private InquiryResultVO[] inquiryResultField;

            private DO_IDENTIFIER trackingIDField;

            private DO_DATE trackingIDExpirationDateField;

            private CoverageSummaryVO coverageSummaryField;

            private CoverageServiceDetailsVO[] servicesField;

            private string descriptionField;

            /// <remarks/>
            public DO_CODED_TEXT InquiryState
            {
                get
                {
                    return this.inquiryStateField;
                }
                set
                {
                    this.inquiryStateField = value;
                }
            }

            /// <remarks/>
            public InquiryResultVO[] InquiryResult
            {
                get
                {
                    return this.inquiryResultField;
                }
                set
                {
                    this.inquiryResultField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER TrackingID
            {
                get
                {
                    return this.trackingIDField;
                }
                set
                {
                    this.trackingIDField = value;
                }
            }

            /// <remarks/>
            public DO_DATE TrackingIDExpirationDate
            {
                get
                {
                    return this.trackingIDExpirationDateField;
                }
                set
                {
                    this.trackingIDExpirationDateField = value;
                }
            }

            /// <remarks/>
            public CoverageSummaryVO CoverageSummary
            {
                get
                {
                    return this.coverageSummaryField;
                }
                set
                {
                    this.coverageSummaryField = value;
                }
            }

            /// <remarks/>
            public CoverageServiceDetailsVO[] Services
            {
                get
                {
                    return this.servicesField;
                }
                set
                {
                    this.servicesField = value;
                }
            }

            /// <remarks/>
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://POCSRA.MOHME.IR/")]
        public partial class SystemVO
        {
            private string commercialNameField;

            private string certificateIDField;

            private DO_CODED_TEXT productTypeField;

            private string companyNameField;

            private DO_IDENTIFIER companyIDField;

            private DO_IDENTIFIER systemIDField;

            private bool approvedField;

            private bool lockField;

            /// <remarks/>
            public string CommercialName
            {
                get
                {
                    return this.commercialNameField;
                }
                set
                {
                    this.commercialNameField = value;
                }
            }

            /// <remarks/>
            public string CertificateID
            {
                get
                {
                    return this.certificateIDField;
                }
                set
                {
                    this.certificateIDField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT ProductType
            {
                get
                {
                    return this.productTypeField;
                }
                set
                {
                    this.productTypeField = value;
                }
            }

            /// <remarks/>
            public string CompanyName
            {
                get
                {
                    return this.companyNameField;
                }
                set
                {
                    this.companyNameField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER CompanyID
            {
                get
                {
                    return this.companyIDField;
                }
                set
                {
                    this.companyIDField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER SystemID
            {
                get
                {
                    return this.systemIDField;
                }
                set
                {
                    this.systemIDField = value;
                }
            }

            /// <remarks/>
            public bool Approved
            {
                get
                {
                    return this.approvedField;
                }
                set
                {
                    this.approvedField = value;
                }
            }

            /// <remarks/>
            public bool Lock
            {
                get
                {
                    return this.lockField;
                }
                set
                {
                    this.lockField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ExtendedPropertyVO
        {
            private string elementField;

            private string valueFieldField;

            /// <remarks/>
            public string Element
            {
                get
                {
                    return this.elementField;
                }
                set
                {
                    this.elementField = value;
                }
            }

            /// <remarks/>
            public string ValueField
            {
                get
                {
                    return this.valueFieldField;
                }
                set
                {
                    this.valueFieldField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class OrganizationDetailVO
        {
            private DO_IDENTIFIER organizationIDField;

            private DO_IDENTIFIER hierarchicalOrganizationIDField;

            private string nameField;

            private DO_CODED_TEXT typeField;

            private HighLevelAreaVO areaField;

            private DO_CODED_TEXT dependencyTypeField;

            private DO_CODED_TEXT allegianceTypeField;

            private DO_CODED_TEXT ownershipStatusField;

            private DO_IDENTIFIER ownerOrganizationIDField;

            private DO_IDENTIFIER observerOrganizationIDField;

            private DO_CODED_TEXT specialtyField;

            private DO_CODED_TEXT[] specialtyTypeField;

            private DO_CODED_TEXT activityStatusField;

            private string postalCodeField;

            private double longitudeField;

            private double latitudeField;

            private DO_DATE establishmentDateField;

            private DO_DATE activationDateField;

            private DO_IDENTIFIER[] otherIdentityInfoField;

            private ExtendedPropertyVO[] extendendPropertyField;

            /// <remarks/>
            public DO_IDENTIFIER OrganizationID
            {
                get
                {
                    return this.organizationIDField;
                }
                set
                {
                    this.organizationIDField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER HierarchicalOrganizationID
            {
                get
                {
                    return this.hierarchicalOrganizationIDField;
                }
                set
                {
                    this.hierarchicalOrganizationIDField = value;
                }
            }

            /// <remarks/>
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            public HighLevelAreaVO Area
            {
                get
                {
                    return this.areaField;
                }
                set
                {
                    this.areaField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT DependencyType
            {
                get
                {
                    return this.dependencyTypeField;
                }
                set
                {
                    this.dependencyTypeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT AllegianceType
            {
                get
                {
                    return this.allegianceTypeField;
                }
                set
                {
                    this.allegianceTypeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT OwnershipStatus
            {
                get
                {
                    return this.ownershipStatusField;
                }
                set
                {
                    this.ownershipStatusField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER OwnerOrganizationID
            {
                get
                {
                    return this.ownerOrganizationIDField;
                }
                set
                {
                    this.ownerOrganizationIDField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER ObserverOrganizationID
            {
                get
                {
                    return this.observerOrganizationIDField;
                }
                set
                {
                    this.observerOrganizationIDField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Specialty
            {
                get
                {
                    return this.specialtyField;
                }
                set
                {
                    this.specialtyField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT[] SpecialtyType
            {
                get
                {
                    return this.specialtyTypeField;
                }
                set
                {
                    this.specialtyTypeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT ActivityStatus
            {
                get
                {
                    return this.activityStatusField;
                }
                set
                {
                    this.activityStatusField = value;
                }
            }

            /// <remarks/>
            public string PostalCode
            {
                get
                {
                    return this.postalCodeField;
                }
                set
                {
                    this.postalCodeField = value;
                }
            }

            /// <remarks/>
            public double Longitude
            {
                get
                {
                    return this.longitudeField;
                }
                set
                {
                    this.longitudeField = value;
                }
            }

            /// <remarks/>
            public double Latitude
            {
                get
                {
                    return this.latitudeField;
                }
                set
                {
                    this.latitudeField = value;
                }
            }

            /// <remarks/>
            public DO_DATE EstablishmentDate
            {
                get
                {
                    return this.establishmentDateField;
                }
                set
                {
                    this.establishmentDateField = value;
                }
            }

            /// <remarks/>
            public DO_DATE ActivationDate
            {
                get
                {
                    return this.activationDateField;
                }
                set
                {
                    this.activationDateField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER[] OtherIdentityInfo
            {
                get
                {
                    return this.otherIdentityInfoField;
                }
                set
                {
                    this.otherIdentityInfoField = value;
                }
            }

            /// <remarks/>
            public ExtendedPropertyVO[] ExtendendProperty
            {
                get
                {
                    return this.extendendPropertyField;
                }
                set
                {
                    this.extendendPropertyField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class NationalHospitalStatusVO
        {
            private DO_IDENTIFIER hospitalField;

            private string hospitalNameField;

            private DO_IDENTIFIER systemField;

            private DO_CODED_TEXT wardTypeField;

            private string wardNameField;

            private string roomField;

            private string bedNumberField;

            private DO_CODED_TEXT bedTypeField;

            private DO_IDENTIFIER bedUniqIDField;

            private DO_CODED_TEXT bedStatusChangeField;

            private System.Nullable<DateTime> bedChangeTimeField;

            private string medicalRecordNumberField;

            private string nationalCodeField;

            private DO_IDENTIFIER hIDField;

            /// <remarks/>
            public DO_IDENTIFIER Hospital
            {
                get
                {
                    return this.hospitalField;
                }
                set
                {
                    this.hospitalField = value;
                }
            }

            /// <remarks/>
            public string HospitalName
            {
                get
                {
                    return this.hospitalNameField;
                }
                set
                {
                    this.hospitalNameField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER System
            {
                get
                {
                    return this.systemField;
                }
                set
                {
                    this.systemField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT WardType
            {
                get
                {
                    return this.wardTypeField;
                }
                set
                {
                    this.wardTypeField = value;
                }
            }

            /// <remarks/>
            public string WardName
            {
                get
                {
                    return this.wardNameField;
                }
                set
                {
                    this.wardNameField = value;
                }
            }

            /// <remarks/>
            public string Room
            {
                get
                {
                    return this.roomField;
                }
                set
                {
                    this.roomField = value;
                }
            }

            /// <remarks/>
            public string BedNumber
            {
                get
                {
                    return this.bedNumberField;
                }
                set
                {
                    this.bedNumberField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT BedType
            {
                get
                {
                    return this.bedTypeField;
                }
                set
                {
                    this.bedTypeField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER BedUniqID
            {
                get
                {
                    return this.bedUniqIDField;
                }
                set
                {
                    this.bedUniqIDField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT BedStatusChange
            {
                get
                {
                    return this.bedStatusChangeField;
                }
                set
                {
                    this.bedStatusChangeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<DateTime> BedChangeTime
            {
                get
                {
                    return this.bedChangeTimeField;
                }
                set
                {
                    this.bedChangeTimeField = value;
                }
            }

            /// <remarks/>
            public string MedicalRecordNumber
            {
                get
                {
                    return this.medicalRecordNumberField;
                }
                set
                {
                    this.medicalRecordNumberField = value;
                }
            }

            /// <remarks/>
            public string NationalCode
            {
                get
                {
                    return this.nationalCodeField;
                }
                set
                {
                    this.nationalCodeField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER HID
            {
                get
                {
                    return this.hIDField;
                }
                set
                {
                    this.hIDField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class PersonAppointmentVO
        {
            private PersonInfoVO personField;

            private DO_IDENTIFIER hIDField;

            private HealthcareProviderVO providerField;

            private HealthOrganizationUnitVO healthcareFacillityField;

            private DO_DATE_TIME dateTimeField;

            private int durationField;

            private string queueNumberField;

            private string trackingQeueIDField;

            /// <remarks/>
            public PersonInfoVO Person
            {
                get
                {
                    return this.personField;
                }
                set
                {
                    this.personField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER HID
            {
                get
                {
                    return this.hIDField;
                }
                set
                {
                    this.hIDField = value;
                }
            }

            /// <remarks/>
            public HealthcareProviderVO Provider
            {
                get
                {
                    return this.providerField;
                }
                set
                {
                    this.providerField = value;
                }
            }

            /// <remarks/>
            public HealthOrganizationUnitVO HealthcareFacillity
            {
                get
                {
                    return this.healthcareFacillityField;
                }
                set
                {
                    this.healthcareFacillityField = value;
                }
            }

            /// <remarks/>
            public DO_DATE_TIME DateTime
            {
                get
                {
                    return this.dateTimeField;
                }
                set
                {
                    this.dateTimeField = value;
                }
            }

            /// <remarks/>
            public int Duration
            {
                get
                {
                    return this.durationField;
                }
                set
                {
                    this.durationField = value;
                }
            }

            /// <remarks/>
            public string QueueNumber
            {
                get
                {
                    return this.queueNumberField;
                }
                set
                {
                    this.queueNumberField = value;
                }
            }

            /// <remarks/>
            public string TrackingQeueID
            {
                get
                {
                    return this.trackingQeueIDField;
                }
                set
                {
                    this.trackingQeueIDField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class PersonInfoVO
        {
            private ElectronicContactVO[] otherContactsField;

            private DO_IDENTIFIER[] otherIdentifierField;

            private HighLevelAreaVO birthPlaceAreaField;

            private DO_CODED_TEXT religionField;

            private DO_CODED_TEXT maritalStatusField;

            private DO_CODED_TEXT nationalityField;

            private DO_DATE birthDateField;

            private DO_TIME birthTimeField;

            private DO_CODED_TEXT birthdateAccuracyField;

            private string father_FirstNameField;

            private string father_LastNameField;

            private string mother_FirstNameField;

            private string mother_LastNameField;

            private string fullNameField;

            private string postalCodeField;

            private DO_CODED_TEXT genderField;

            private DO_CODED_TEXT jobField;

            private string jobDescribtionField;

            private string fullAddressField;

            private HighLevelAreaVO livingPlaceAreaField;

            private string iDCardNumberField;

            private HighLevelAreaVO iDIssueAreaField;

            private string homeTelField;

            private string mobileNumberField;

            private DO_CODED_TEXT educationLevelField;

            private string firstNameField;

            private string lastNameField;

            private string nationalCodeField;

            /// <remarks/>
            public ElectronicContactVO[] OtherContacts
            {
                get
                {
                    return this.otherContactsField;
                }
                set
                {
                    this.otherContactsField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER[] OtherIdentifier
            {
                get
                {
                    return this.otherIdentifierField;
                }
                set
                {
                    this.otherIdentifierField = value;
                }
            }

            /// <remarks/>
            public HighLevelAreaVO BirthPlaceArea
            {
                get
                {
                    return this.birthPlaceAreaField;
                }
                set
                {
                    this.birthPlaceAreaField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Religion
            {
                get
                {
                    return this.religionField;
                }
                set
                {
                    this.religionField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT MaritalStatus
            {
                get
                {
                    return this.maritalStatusField;
                }
                set
                {
                    this.maritalStatusField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Nationality
            {
                get
                {
                    return this.nationalityField;
                }
                set
                {
                    this.nationalityField = value;
                }
            }

            /// <remarks/>
            public DO_DATE BirthDate
            {
                get
                {
                    return this.birthDateField;
                }
                set
                {
                    this.birthDateField = value;
                }
            }

            /// <remarks/>
            public DO_TIME BirthTime
            {
                get
                {
                    return this.birthTimeField;
                }
                set
                {
                    this.birthTimeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT BirthdateAccuracy
            {
                get
                {
                    return this.birthdateAccuracyField;
                }
                set
                {
                    this.birthdateAccuracyField = value;
                }
            }

            /// <remarks/>
            public string Father_FirstName
            {
                get
                {
                    return this.father_FirstNameField;
                }
                set
                {
                    this.father_FirstNameField = value;
                }
            }

            /// <remarks/>
            public string Father_LastName
            {
                get
                {
                    return this.father_LastNameField;
                }
                set
                {
                    this.father_LastNameField = value;
                }
            }

            /// <remarks/>
            public string Mother_FirstName
            {
                get
                {
                    return this.mother_FirstNameField;
                }
                set
                {
                    this.mother_FirstNameField = value;
                }
            }

            /// <remarks/>
            public string Mother_LastName
            {
                get
                {
                    return this.mother_LastNameField;
                }
                set
                {
                    this.mother_LastNameField = value;
                }
            }

            /// <remarks/>
            public string FullName
            {
                get
                {
                    return this.fullNameField;
                }
                set
                {
                    this.fullNameField = value;
                }
            }

            /// <remarks/>
            public string PostalCode
            {
                get
                {
                    return this.postalCodeField;
                }
                set
                {
                    this.postalCodeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Gender
            {
                get
                {
                    return this.genderField;
                }
                set
                {
                    this.genderField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Job
            {
                get
                {
                    return this.jobField;
                }
                set
                {
                    this.jobField = value;
                }
            }

            /// <remarks/>
            public string JobDescribtion
            {
                get
                {
                    return this.jobDescribtionField;
                }
                set
                {
                    this.jobDescribtionField = value;
                }
            }

            /// <remarks/>
            public string FullAddress
            {
                get
                {
                    return this.fullAddressField;
                }
                set
                {
                    this.fullAddressField = value;
                }
            }

            /// <remarks/>
            public HighLevelAreaVO LivingPlaceArea
            {
                get
                {
                    return this.livingPlaceAreaField;
                }
                set
                {
                    this.livingPlaceAreaField = value;
                }
            }

            /// <remarks/>
            public string IDCardNumber
            {
                get
                {
                    return this.iDCardNumberField;
                }
                set
                {
                    this.iDCardNumberField = value;
                }
            }

            /// <remarks/>
            public HighLevelAreaVO IDIssueArea
            {
                get
                {
                    return this.iDIssueAreaField;
                }
                set
                {
                    this.iDIssueAreaField = value;
                }
            }

            /// <remarks/>
            public string HomeTel
            {
                get
                {
                    return this.homeTelField;
                }
                set
                {
                    this.homeTelField = value;
                }
            }

            /// <remarks/>
            public string MobileNumber
            {
                get
                {
                    return this.mobileNumberField;
                }
                set
                {
                    this.mobileNumberField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT EducationLevel
            {
                get
                {
                    return this.educationLevelField;
                }
                set
                {
                    this.educationLevelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string FirstName
            {
                get
                {
                    return this.firstNameField;
                }
                set
                {
                    this.firstNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string LastName
            {
                get
                {
                    return this.lastNameField;
                }
                set
                {
                    this.lastNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string NationalCode
            {
                get
                {
                    return this.nationalCodeField;
                }
                set
                {
                    this.nationalCodeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ElectronicContactVO
        {
            private DO_CODED_TEXT mediumTypeField;

            private DO_CODED_TEXT usageField;

            private string detailField;

            /// <remarks/>
            public DO_CODED_TEXT MediumType
            {
                get
                {
                    return this.mediumTypeField;
                }
                set
                {
                    this.mediumTypeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Usage
            {
                get
                {
                    return this.usageField;
                }
                set
                {
                    this.usageField = value;
                }
            }

            /// <remarks/>
            public string Detail
            {
                get
                {
                    return this.detailField;
                }
                set
                {
                    this.detailField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class DO_TIME
        {
            private string iSOStringField;

            private System.Nullable<int> hourField;

            private System.Nullable<int> minuteField;

            private System.Nullable<int> secondField;

            /// <remarks/>
            public string ISOString
            {
                get
                {
                    return this.iSOStringField;
                }
                set
                {
                    this.iSOStringField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> Hour
            {
                get
                {
                    return this.hourField;
                }
                set
                {
                    this.hourField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> Minute
            {
                get
                {
                    return this.minuteField;
                }
                set
                {
                    this.minuteField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> Second
            {
                get
                {
                    return this.secondField;
                }
                set
                {
                    this.secondField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class HealthcareProviderVO
        {
            private DO_CODED_TEXT specialtyField;

            private DO_IDENTIFIER identifierField;

            private DO_CODED_TEXT roleField;

            private ElectronicContactVO[] contactPointField;

            private string firstNameField;

            private string lastNameField;

            private string fullNameField;

            /// <remarks/>
            public DO_CODED_TEXT Specialty
            {
                get
                {
                    return this.specialtyField;
                }
                set
                {
                    this.specialtyField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER Identifier
            {
                get
                {
                    return this.identifierField;
                }
                set
                {
                    this.identifierField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Role
            {
                get
                {
                    return this.roleField;
                }
                set
                {
                    this.roleField = value;
                }
            }

            /// <remarks/>
            public ElectronicContactVO[] ContactPoint
            {
                get
                {
                    return this.contactPointField;
                }
                set
                {
                    this.contactPointField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string FirstName
            {
                get
                {
                    return this.firstNameField;
                }
                set
                {
                    this.firstNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string LastName
            {
                get
                {
                    return this.lastNameField;
                }
                set
                {
                    this.lastNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string FullName
            {
                get
                {
                    return this.fullNameField;
                }
                set
                {
                    this.fullNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class HealthOrganizationUnitVO
        {
            private string nameField;

            private DO_IDENTIFIER idField;

            private string internalIDField;

            private HighLevelAreaVO locationField;

            private string addressField;

            private string internalAddressField;

            private DO_CODED_TEXT typeField;

            private System.Nullable<double> latitudeField;

            private System.Nullable<double> longitudeField;

            private DO_CODED_TEXT departmentTypeField;

            private string departmentNameField;

            /// <remarks/>
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            public string InternalID
            {
                get
                {
                    return this.internalIDField;
                }
                set
                {
                    this.internalIDField = value;
                }
            }

            /// <remarks/>
            public HighLevelAreaVO Location
            {
                get
                {
                    return this.locationField;
                }
                set
                {
                    this.locationField = value;
                }
            }

            /// <remarks/>
            public string Address
            {
                get
                {
                    return this.addressField;
                }
                set
                {
                    this.addressField = value;
                }
            }

            /// <remarks/>
            public string InternalAddress
            {
                get
                {
                    return this.internalAddressField;
                }
                set
                {
                    this.internalAddressField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<double> Latitude
            {
                get
                {
                    return this.latitudeField;
                }
                set
                {
                    this.latitudeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<double> Longitude
            {
                get
                {
                    return this.longitudeField;
                }
                set
                {
                    this.longitudeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT DepartmentType
            {
                get
                {
                    return this.departmentTypeField;
                }
                set
                {
                    this.departmentTypeField = value;
                }
            }

            /// <remarks/>
            public string DepartmentName
            {
                get
                {
                    return this.departmentNameField;
                }
                set
                {
                    this.departmentNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ScheduleBlockVO
        {
            private HealthcareProviderVO providerField;

            private HealthOrganizationUnitVO healthcareFacillityField;

            private DO_DATE_TIME dateTimeField;

            private int durationField;

            private string queueNumberField;

            private string localIDField;

            private DO_CODED_TEXT quotaField;

            private DO_CODED_TEXT serviceField;

            private string trackingQueueIDField;

            private DO_DATE_TIME bookingExpiryDateField;

            private DO_DATE_TIME bookingStartDateField;

            /// <remarks/>
            public HealthcareProviderVO Provider
            {
                get
                {
                    return this.providerField;
                }
                set
                {
                    this.providerField = value;
                }
            }

            /// <remarks/>
            public HealthOrganizationUnitVO HealthcareFacillity
            {
                get
                {
                    return this.healthcareFacillityField;
                }
                set
                {
                    this.healthcareFacillityField = value;
                }
            }

            /// <remarks/>
            public DO_DATE_TIME DateTime
            {
                get
                {
                    return this.dateTimeField;
                }
                set
                {
                    this.dateTimeField = value;
                }
            }

            /// <remarks/>
            public int Duration
            {
                get
                {
                    return this.durationField;
                }
                set
                {
                    this.durationField = value;
                }
            }

            /// <remarks/>
            public string QueueNumber
            {
                get
                {
                    return this.queueNumberField;
                }
                set
                {
                    this.queueNumberField = value;
                }
            }

            /// <remarks/>
            public string LocalID
            {
                get
                {
                    return this.localIDField;
                }
                set
                {
                    this.localIDField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Quota
            {
                get
                {
                    return this.quotaField;
                }
                set
                {
                    this.quotaField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Service
            {
                get
                {
                    return this.serviceField;
                }
                set
                {
                    this.serviceField = value;
                }
            }

            /// <remarks/>
            public string TrackingQueueID
            {
                get
                {
                    return this.trackingQueueIDField;
                }
                set
                {
                    this.trackingQueueIDField = value;
                }
            }

            /// <remarks/>
            public DO_DATE_TIME BookingExpiryDate
            {
                get
                {
                    return this.bookingExpiryDateField;
                }
                set
                {
                    this.bookingExpiryDateField = value;
                }
            }

            /// <remarks/>
            public DO_DATE_TIME BookingStartDate
            {
                get
                {
                    return this.bookingStartDateField;
                }
                set
                {
                    this.bookingStartDateField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ValidationResultVO
        {
            private string messageIDField;

            private string errorMessageField;

            private string normalizedErrorMessageField;

            private string errorCategoryTypeField;

            private string errorCategoryCriticalField;

            private string errorCategorySourceField;

            private string errorDescriptionField;

            private string errorSolutionField;

            /// <remarks/>
            public string MessageID
            {
                get
                {
                    return this.messageIDField;
                }
                set
                {
                    this.messageIDField = value;
                }
            }

            /// <remarks/>
            public string ErrorMessage
            {
                get
                {
                    return this.errorMessageField;
                }
                set
                {
                    this.errorMessageField = value;
                }
            }

            /// <remarks/>
            public string NormalizedErrorMessage
            {
                get
                {
                    return this.normalizedErrorMessageField;
                }
                set
                {
                    this.normalizedErrorMessageField = value;
                }
            }

            /// <remarks/>
            public string ErrorCategoryType
            {
                get
                {
                    return this.errorCategoryTypeField;
                }
                set
                {
                    this.errorCategoryTypeField = value;
                }
            }

            /// <remarks/>
            public string ErrorCategoryCritical
            {
                get
                {
                    return this.errorCategoryCriticalField;
                }
                set
                {
                    this.errorCategoryCriticalField = value;
                }
            }

            /// <remarks/>
            public string ErrorCategorySource
            {
                get
                {
                    return this.errorCategorySourceField;
                }
                set
                {
                    this.errorCategorySourceField = value;
                }
            }

            /// <remarks/>
            public string ErrorDescription
            {
                get
                {
                    return this.errorDescriptionField;
                }
                set
                {
                    this.errorDescriptionField = value;
                }
            }

            /// <remarks/>
            public string ErrorSolution
            {
                get
                {
                    return this.errorSolutionField;
                }
                set
                {
                    this.errorSolutionField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class PatientTransferInfoVO
        {
            private DO_CODED_TEXT missionResultField;

            private OrganizationVO destinationField;

            private DO_DATE_TIME deliveryTimeField;

            private HealthcareProviderVO receiverProviderField;

            private string noteField;

            /// <remarks/>
            public DO_CODED_TEXT MissionResult
            {
                get
                {
                    return this.missionResultField;
                }
                set
                {
                    this.missionResultField = value;
                }
            }

            /// <remarks/>
            public OrganizationVO Destination
            {
                get
                {
                    return this.destinationField;
                }
                set
                {
                    this.destinationField = value;
                }
            }

            /// <remarks/>
            public DO_DATE_TIME DeliveryTime
            {
                get
                {
                    return this.deliveryTimeField;
                }
                set
                {
                    this.deliveryTimeField = value;
                }
            }

            /// <remarks/>
            public HealthcareProviderVO ReceiverProvider
            {
                get
                {
                    return this.receiverProviderField;
                }
                set
                {
                    this.receiverProviderField = value;
                }
            }

            /// <remarks/>
            public string Note
            {
                get
                {
                    return this.noteField;
                }
                set
                {
                    this.noteField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class OrganizationVO
        {
            private string nameField;

            private DO_IDENTIFIER idField;

            private DO_CODED_TEXT typeField;

            private HighLevelAreaVO locationField;

            private string portablePositionField;

            /// <remarks/>
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            public HighLevelAreaVO Location
            {
                get
                {
                    return this.locationField;
                }
                set
                {
                    this.locationField = value;
                }
            }

            /// <remarks/>
            public string PortablePosition
            {
                get
                {
                    return this.portablePositionField;
                }
                set
                {
                    this.portablePositionField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class AmbulanceServiceCompositionVO
        {
            private AdmissionVO admissionField;

            private DiagnosisVO[] diagnosisField;

            private ClinicalFindingGeneralVO[] clinicalFindingField;

            private ChiefComplaintVO chiefComplaintField;

            private PMHVO[] pMHField;

            private QuestionnaireVO[] questionnaireField;

            private DrugHistoryVO[] drugHistoryField;

            private AdverseReactionVO[] adverseReactionField;

            private PhysicalExamVO[] pHEXField;

            private DrugTreatmentReportVO[] medicationOrderedReportField;

            private GeneralActionReportVO[] generalActionReportField;

            private DrugTreatmentReportVO[] drugTreatmentReportField;

            private PatientTransferInfoVO patientTransferInfoField;

            private LabTestResultVO[] laboratoryField;

            /// <remarks/>
            public AdmissionVO Admission
            {
                get
                {
                    return this.admissionField;
                }
                set
                {
                    this.admissionField = value;
                }
            }

            /// <remarks/>
            public DiagnosisVO[] Diagnosis
            {
                get
                {
                    return this.diagnosisField;
                }
                set
                {
                    this.diagnosisField = value;
                }
            }

            /// <remarks/>
            public ClinicalFindingGeneralVO[] ClinicalFinding
            {
                get
                {
                    return this.clinicalFindingField;
                }
                set
                {
                    this.clinicalFindingField = value;
                }
            }

            /// <remarks/>
            public ChiefComplaintVO ChiefComplaint
            {
                get
                {
                    return this.chiefComplaintField;
                }
                set
                {
                    this.chiefComplaintField = value;
                }
            }

            /// <remarks/>
            public PMHVO[] PMH
            {
                get
                {
                    return this.pMHField;
                }
                set
                {
                    this.pMHField = value;
                }
            }

            /// <remarks/>
            public QuestionnaireVO[] Questionnaire
            {
                get
                {
                    return this.questionnaireField;
                }
                set
                {
                    this.questionnaireField = value;
                }
            }

            /// <remarks/>
            public DrugHistoryVO[] DrugHistory
            {
                get
                {
                    return this.drugHistoryField;
                }
                set
                {
                    this.drugHistoryField = value;
                }
            }

            /// <remarks/>
            public AdverseReactionVO[] AdverseReaction
            {
                get
                {
                    return this.adverseReactionField;
                }
                set
                {
                    this.adverseReactionField = value;
                }
            }

            /// <remarks/>
            public PhysicalExamVO[] PHEX
            {
                get
                {
                    return this.pHEXField;
                }
                set
                {
                    this.pHEXField = value;
                }
            }

            /// <remarks/>
            public DrugTreatmentReportVO[] MedicationOrderedReport
            {
                get
                {
                    return this.medicationOrderedReportField;
                }
                set
                {
                    this.medicationOrderedReportField = value;
                }
            }

            /// <remarks/>
            public GeneralActionReportVO[] GeneralActionReport
            {
                get
                {
                    return this.generalActionReportField;
                }
                set
                {
                    this.generalActionReportField = value;
                }
            }

            /// <remarks/>
            public DrugTreatmentReportVO[] DrugTreatmentReport
            {
                get
                {
                    return this.drugTreatmentReportField;
                }
                set
                {
                    this.drugTreatmentReportField = value;
                }
            }

            /// <remarks/>
            public PatientTransferInfoVO PatientTransferInfo
            {
                get
                {
                    return this.patientTransferInfoField;
                }
                set
                {
                    this.patientTransferInfoField = value;
                }
            }

            /// <remarks/>
            public LabTestResultVO[] Laboratory
            {
                get
                {
                    return this.laboratoryField;
                }
                set
                {
                    this.laboratoryField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class AdmissionVO
        {
            private DO_CODEABLE_CONCEPT arrivalModeField;

            private HealthcareProviderVO[] otherParticipationField;

            private DO_IDENTIFIER eMSIDField;

            private DateTimePointVO[] otherDateTimeField;

            private DO_DATE admissionDateField;

            private DO_TIME admissionTimeField;

            private DO_CODED_TEXT admissionTypeField;

            private string medicalRecordNumberField;

            private OrganizationVO instituteField;

            private DO_CODED_TEXT reasonForEncounterField;

            private HealthcareProviderVO admittingDoctorField;

            private HealthcareProviderVO referringDoctorField;

            private HealthcareProviderVO attendingDoctorField;

            private HospitalWardVO admissionWardField;

            private LocationVO patientLocationField;

            /// <remarks/>
            public DO_CODEABLE_CONCEPT ArrivalMode
            {
                get
                {
                    return this.arrivalModeField;
                }
                set
                {
                    this.arrivalModeField = value;
                }
            }

            /// <remarks/>
            public HealthcareProviderVO[] OtherParticipation
            {
                get
                {
                    return this.otherParticipationField;
                }
                set
                {
                    this.otherParticipationField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER EMSID
            {
                get
                {
                    return this.eMSIDField;
                }
                set
                {
                    this.eMSIDField = value;
                }
            }

            /// <remarks/>
            public DateTimePointVO[] OtherDateTime
            {
                get
                {
                    return this.otherDateTimeField;
                }
                set
                {
                    this.otherDateTimeField = value;
                }
            }

            /// <remarks/>
            public DO_DATE AdmissionDate
            {
                get
                {
                    return this.admissionDateField;
                }
                set
                {
                    this.admissionDateField = value;
                }
            }

            /// <remarks/>
            public DO_TIME AdmissionTime
            {
                get
                {
                    return this.admissionTimeField;
                }
                set
                {
                    this.admissionTimeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT AdmissionType
            {
                get
                {
                    return this.admissionTypeField;
                }
                set
                {
                    this.admissionTypeField = value;
                }
            }

            /// <remarks/>
            public string MedicalRecordNumber
            {
                get
                {
                    return this.medicalRecordNumberField;
                }
                set
                {
                    this.medicalRecordNumberField = value;
                }
            }

            /// <remarks/>
            public OrganizationVO Institute
            {
                get
                {
                    return this.instituteField;
                }
                set
                {
                    this.instituteField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT ReasonForEncounter
            {
                get
                {
                    return this.reasonForEncounterField;
                }
                set
                {
                    this.reasonForEncounterField = value;
                }
            }

            /// <remarks/>
            public HealthcareProviderVO AdmittingDoctor
            {
                get
                {
                    return this.admittingDoctorField;
                }
                set
                {
                    this.admittingDoctorField = value;
                }
            }

            /// <remarks/>
            public HealthcareProviderVO ReferringDoctor
            {
                get
                {
                    return this.referringDoctorField;
                }
                set
                {
                    this.referringDoctorField = value;
                }
            }

            /// <remarks/>
            public HealthcareProviderVO AttendingDoctor
            {
                get
                {
                    return this.attendingDoctorField;
                }
                set
                {
                    this.attendingDoctorField = value;
                }
            }

            /// <remarks/>
            public HospitalWardVO AdmissionWard
            {
                get
                {
                    return this.admissionWardField;
                }
                set
                {
                    this.admissionWardField = value;
                }
            }

            /// <remarks/>
            public LocationVO PatientLocation
            {
                get
                {
                    return this.patientLocationField;
                }
                set
                {
                    this.patientLocationField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class DateTimePointVO
        {
            private DO_CODED_TEXT pointField;

            private DO_DATE pointDateField;

            private DO_TIME pointTimeField;

            /// <remarks/>
            public DO_CODED_TEXT Point
            {
                get
                {
                    return this.pointField;
                }
                set
                {
                    this.pointField = value;
                }
            }

            /// <remarks/>
            public DO_DATE PointDate
            {
                get
                {
                    return this.pointDateField;
                }
                set
                {
                    this.pointDateField = value;
                }
            }

            /// <remarks/>
            public DO_TIME PointTime
            {
                get
                {
                    return this.pointTimeField;
                }
                set
                {
                    this.pointTimeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class HospitalWardVO
        {
            private string nameField;

            private DO_CODED_TEXT typeField;

            private string roomField;

            private string bedField;

            /// <remarks/>
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            public string Room
            {
                get
                {
                    return this.roomField;
                }
                set
                {
                    this.roomField = value;
                }
            }

            /// <remarks/>
            public string Bed
            {
                get
                {
                    return this.bedField;
                }
                set
                {
                    this.bedField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class LocationVO
        {
            private string nameField;

            private DO_CODED_TEXT typeField;

            private GeographicalCoordinatesVO coordinationField;

            private HighLevelAreaVO areaAddressField;

            private string fullAddressField;

            /// <remarks/>
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            public GeographicalCoordinatesVO Coordination
            {
                get
                {
                    return this.coordinationField;
                }
                set
                {
                    this.coordinationField = value;
                }
            }

            /// <remarks/>
            public HighLevelAreaVO AreaAddress
            {
                get
                {
                    return this.areaAddressField;
                }
                set
                {
                    this.areaAddressField = value;
                }
            }

            /// <remarks/>
            public string FullAddress
            {
                get
                {
                    return this.fullAddressField;
                }
                set
                {
                    this.fullAddressField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class DiagnosisVO
        {
            private DO_CODED_TEXT diagnosisField;

            private string commentField;

            private DO_CODED_TEXT statusField;

            private DO_DATE diagnosisDateField;

            private DO_TIME diagnosisTimeField;

            private DO_ORDINAL severityField;

            /// <remarks/>
            public DO_CODED_TEXT Diagnosis
            {
                get
                {
                    return this.diagnosisField;
                }
                set
                {
                    this.diagnosisField = value;
                }
            }

            /// <remarks/>
            public string Comment
            {
                get
                {
                    return this.commentField;
                }
                set
                {
                    this.commentField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            public DO_DATE DiagnosisDate
            {
                get
                {
                    return this.diagnosisDateField;
                }
                set
                {
                    this.diagnosisDateField = value;
                }
            }

            /// <remarks/>
            public DO_TIME DiagnosisTime
            {
                get
                {
                    return this.diagnosisTimeField;
                }
                set
                {
                    this.diagnosisTimeField = value;
                }
            }

            /// <remarks/>
            public DO_ORDINAL Severity
            {
                get
                {
                    return this.severityField;
                }
                set
                {
                    this.severityField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class DO_ORDINAL
        {
            private DO_CODED_TEXT symbolField;

            private System.Nullable<int> valueField;

            /// <remarks/>
            public DO_CODED_TEXT Symbol
            {
                get
                {
                    return this.symbolField;
                }
                set
                {
                    this.symbolField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ClinicalFindingGeneralVO
        {
            private DO_QUANTITY ageOfOnsetField;

            private System.Nullable<bool> nillSignificantField;

            private DO_QUANTITY onsetDuration2PresentField;

            private DO_CODED_TEXT findingField;

            private string descriptionField;

            private DO_DATE dateofOnsetField;

            private DO_TIME timeofOnsetField;

            private DO_ORDINAL severityField;

            private AnatomicalLocationVO[] anatomicalLocationField;

            private DO_DATE resolutionDateField;

            private DO_TIME resolutionTimeField;

            /// <remarks/>
            public DO_QUANTITY AgeOfOnset
            {
                get
                {
                    return this.ageOfOnsetField;
                }
                set
                {
                    this.ageOfOnsetField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<bool> NillSignificant
            {
                get
                {
                    return this.nillSignificantField;
                }
                set
                {
                    this.nillSignificantField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY OnsetDuration2Present
            {
                get
                {
                    return this.onsetDuration2PresentField;
                }
                set
                {
                    this.onsetDuration2PresentField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Finding
            {
                get
                {
                    return this.findingField;
                }
                set
                {
                    this.findingField = value;
                }
            }

            /// <remarks/>
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            public DO_DATE DateofOnset
            {
                get
                {
                    return this.dateofOnsetField;
                }
                set
                {
                    this.dateofOnsetField = value;
                }
            }

            /// <remarks/>
            public DO_TIME TimeofOnset
            {
                get
                {
                    return this.timeofOnsetField;
                }
                set
                {
                    this.timeofOnsetField = value;
                }
            }

            /// <remarks/>
            public DO_ORDINAL Severity
            {
                get
                {
                    return this.severityField;
                }
                set
                {
                    this.severityField = value;
                }
            }

            /// <remarks/>
            public AnatomicalLocationVO[] AnatomicalLocation
            {
                get
                {
                    return this.anatomicalLocationField;
                }
                set
                {
                    this.anatomicalLocationField = value;
                }
            }

            /// <remarks/>
            public DO_DATE ResolutionDate
            {
                get
                {
                    return this.resolutionDateField;
                }
                set
                {
                    this.resolutionDateField = value;
                }
            }

            /// <remarks/>
            public DO_TIME ResolutionTime
            {
                get
                {
                    return this.resolutionTimeField;
                }
                set
                {
                    this.resolutionTimeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class AnatomicalLocationVO
        {
            private DO_CODED_TEXT bodySiteField;

            private DO_CODED_TEXT lateralityField;

            /// <remarks/>
            public DO_CODED_TEXT BodySite
            {
                get
                {
                    return this.bodySiteField;
                }
                set
                {
                    this.bodySiteField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Laterality
            {
                get
                {
                    return this.lateralityField;
                }
                set
                {
                    this.lateralityField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ChiefComplaintVO
        {
            private DO_CODED_TEXT[] symptomsField;

            private DO_DATE dateofOnsetField;

            private DO_TIME timeofOnsetField;

            private string descriptionField;

            /// <remarks/>
            public DO_CODED_TEXT[] Symptoms
            {
                get
                {
                    return this.symptomsField;
                }
                set
                {
                    this.symptomsField = value;
                }
            }

            /// <remarks/>
            public DO_DATE DateofOnset
            {
                get
                {
                    return this.dateofOnsetField;
                }
                set
                {
                    this.dateofOnsetField = value;
                }
            }

            /// <remarks/>
            public DO_TIME TimeofOnset
            {
                get
                {
                    return this.timeofOnsetField;
                }
                set
                {
                    this.timeofOnsetField = value;
                }
            }

            /// <remarks/>
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class PMHVO
        {
            private DO_CODED_TEXT conditionField;

            private string descriptionField;

            private DO_DATE dateofOnsetField;

            private DO_QUANTITY onsetDurationToPresentField;

            /// <remarks/>
            public DO_CODED_TEXT Condition
            {
                get
                {
                    return this.conditionField;
                }
                set
                {
                    this.conditionField = value;
                }
            }

            /// <remarks/>
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            public DO_DATE DateofOnset
            {
                get
                {
                    return this.dateofOnsetField;
                }
                set
                {
                    this.dateofOnsetField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY OnsetDurationToPresent
            {
                get
                {
                    return this.onsetDurationToPresentField;
                }
                set
                {
                    this.onsetDurationToPresentField = value;
                }
            }
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
            private DO_CODED_TEXT questionCategoryField;

            private DO_CODED_TEXT questionSubCategoryField;

            private string questionDescField;

            private DO_CODED_TEXT questionCodeField;

            /// <remarks/>
            public DO_CODED_TEXT QuestionCategory
            {
                get
                {
                    return this.questionCategoryField;
                }
                set
                {
                    this.questionCategoryField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT QuestionSubCategory
            {
                get
                {
                    return this.questionSubCategoryField;
                }
                set
                {
                    this.questionSubCategoryField = value;
                }
            }

            /// <remarks/>
            public string QuestionDesc
            {
                get
                {
                    return this.questionDescField;
                }
                set
                {
                    this.questionDescField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT QuestionCode
            {
                get
                {
                    return this.questionCodeField;
                }
                set
                {
                    this.questionCodeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class QuestionnaireBooleanVO : QuestionnaireVO
        {
            private System.Nullable<bool> answerField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<bool> Answer
            {
                get
                {
                    return this.answerField;
                }
                set
                {
                    this.answerField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class QuestionnaireQuantityVO : QuestionnaireVO
        {
            private DO_QUANTITY answerField;

            /// <remarks/>
            public DO_QUANTITY Answer
            {
                get
                {
                    return this.answerField;
                }
                set
                {
                    this.answerField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class QuestionnaireCSVO : QuestionnaireVO
        {
            private DO_CODED_TEXT answerField;

            /// <remarks/>
            public DO_CODED_TEXT Answer
            {
                get
                {
                    return this.answerField;
                }
                set
                {
                    this.answerField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class DrugHistoryVO
        {
            private DO_CODED_TEXT medicationField;

            private DO_CODED_TEXT routeofadministrationField;

            /// <remarks/>
            public DO_CODED_TEXT Medication
            {
                get
                {
                    return this.medicationField;
                }
                set
                {
                    this.medicationField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Routeofadministration
            {
                get
                {
                    return this.routeofadministrationField;
                }
                set
                {
                    this.routeofadministrationField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class AdverseReactionVO
        {
            private DO_CODED_TEXT reactionField;

            private DO_CODED_TEXT reactionCategoryField;

            private string descriptionField;

            private DO_ORDINAL severityField;

            private DO_CODED_TEXT causativeAgentField;

            private DO_CODED_TEXT causativeAgentCategoryField;

            /// <remarks/>
            public DO_CODED_TEXT Reaction
            {
                get
                {
                    return this.reactionField;
                }
                set
                {
                    this.reactionField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT ReactionCategory
            {
                get
                {
                    return this.reactionCategoryField;
                }
                set
                {
                    this.reactionCategoryField = value;
                }
            }

            /// <remarks/>
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            public DO_ORDINAL Severity
            {
                get
                {
                    return this.severityField;
                }
                set
                {
                    this.severityField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT CausativeAgent
            {
                get
                {
                    return this.causativeAgentField;
                }
                set
                {
                    this.causativeAgentField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT CausativeAgentCategory
            {
                get
                {
                    return this.causativeAgentCategoryField;
                }
                set
                {
                    this.causativeAgentCategoryField = value;
                }
            }
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
            private DO_DATE observationDateField;

            private DO_TIME observationTimeField;

            /// <remarks/>
            public DO_DATE ObservationDate
            {
                get
                {
                    return this.observationDateField;
                }
                set
                {
                    this.observationDateField = value;
                }
            }

            /// <remarks/>
            public DO_TIME ObservationTime
            {
                get
                {
                    return this.observationTimeField;
                }
                set
                {
                    this.observationTimeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class PulseVO : PhysicalExamVO
        {
            private System.Nullable<bool> is_Pulse_PresentField;

            private DO_QUANTITY pulseRateField;

            private DO_CODED_TEXT regularityField;

            private DO_CODED_TEXT volumeField;

            private DO_CODED_TEXT characterField;

            private string clinicalDescriptionField;

            private DO_CODED_TEXT positionField;

            private DO_CODED_TEXT locationOfMeasurementField;

            private DO_CODED_TEXT methodField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<bool> Is_Pulse_Present
            {
                get
                {
                    return this.is_Pulse_PresentField;
                }
                set
                {
                    this.is_Pulse_PresentField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY PulseRate
            {
                get
                {
                    return this.pulseRateField;
                }
                set
                {
                    this.pulseRateField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Regularity
            {
                get
                {
                    return this.regularityField;
                }
                set
                {
                    this.regularityField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Volume
            {
                get
                {
                    return this.volumeField;
                }
                set
                {
                    this.volumeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Character
            {
                get
                {
                    return this.characterField;
                }
                set
                {
                    this.characterField = value;
                }
            }

            /// <remarks/>
            public string ClinicalDescription
            {
                get
                {
                    return this.clinicalDescriptionField;
                }
                set
                {
                    this.clinicalDescriptionField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Position
            {
                get
                {
                    return this.positionField;
                }
                set
                {
                    this.positionField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT LocationOfMeasurement
            {
                get
                {
                    return this.locationOfMeasurementField;
                }
                set
                {
                    this.locationOfMeasurementField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Method
            {
                get
                {
                    return this.methodField;
                }
                set
                {
                    this.methodField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class GeneralAssessmentVO : PhysicalExamVO
        {
            private ScoreDetailsVO[] scoreDetailsField;

            private DO_CODED_TEXT assessmentTypeField;

            private DO_CODED_TEXT scaleSystemField;

            private string totalValueField;

            private string commentField;

            /// <remarks/>
            public ScoreDetailsVO[] ScoreDetails
            {
                get
                {
                    return this.scoreDetailsField;
                }
                set
                {
                    this.scoreDetailsField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT AssessmentType
            {
                get
                {
                    return this.assessmentTypeField;
                }
                set
                {
                    this.assessmentTypeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT ScaleSystem
            {
                get
                {
                    return this.scaleSystemField;
                }
                set
                {
                    this.scaleSystemField = value;
                }
            }

            /// <remarks/>
            public string TotalValue
            {
                get
                {
                    return this.totalValueField;
                }
                set
                {
                    this.totalValueField = value;
                }
            }

            /// <remarks/>
            public string Comment
            {
                get
                {
                    return this.commentField;
                }
                set
                {
                    this.commentField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ScoreDetailsVO
        {
            private DO_CODED_TEXT conceptField;

            private string conceptValueField;

            /// <remarks/>
            public DO_CODED_TEXT Concept
            {
                get
                {
                    return this.conceptField;
                }
                set
                {
                    this.conceptField = value;
                }
            }

            /// <remarks/>
            public string ConceptValue
            {
                get
                {
                    return this.conceptValueField;
                }
                set
                {
                    this.conceptValueField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class PulseOximetryVO : PhysicalExamVO
        {
            private DO_QUANTITY spO2Field;

            private DO_CODEABLE_CONCEPT bodySiteField;

            private DO_CODEABLE_CONCEPT patientStatusField;

            /// <remarks/>
            public DO_QUANTITY SpO2
            {
                get
                {
                    return this.spO2Field;
                }
                set
                {
                    this.spO2Field = value;
                }
            }

            /// <remarks/>
            public DO_CODEABLE_CONCEPT BodySite
            {
                get
                {
                    return this.bodySiteField;
                }
                set
                {
                    this.bodySiteField = value;
                }
            }

            /// <remarks/>
            public DO_CODEABLE_CONCEPT PatientStatus
            {
                get
                {
                    return this.patientStatusField;
                }
                set
                {
                    this.patientStatusField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class Height_WeightVO : PhysicalExamVO
        {
            private DO_QUANTITY heightField;

            private DO_QUANTITY weightField;

            /// <remarks/>
            public DO_QUANTITY Height
            {
                get
                {
                    return this.heightField;
                }
                set
                {
                    this.heightField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY Weight
            {
                get
                {
                    return this.weightField;
                }
                set
                {
                    this.weightField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class Waist_HipVO : PhysicalExamVO
        {
            private DO_QUANTITY waistCircumferenceField;

            private DO_QUANTITY hipCircumferenceField;

            /// <remarks/>
            public DO_QUANTITY WaistCircumference
            {
                get
                {
                    return this.waistCircumferenceField;
                }
                set
                {
                    this.waistCircumferenceField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY HipCircumference
            {
                get
                {
                    return this.hipCircumferenceField;
                }
                set
                {
                    this.hipCircumferenceField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class VitalSignsVO : PhysicalExamVO
        {
            private DO_QUANTITY pulseRateField;

            private DO_QUANTITY respiratoryRateField;

            private DO_QUANTITY temperatureField;

            private DO_CODED_TEXT temperatureLocationField;

            /// <remarks/>
            public DO_QUANTITY PulseRate
            {
                get
                {
                    return this.pulseRateField;
                }
                set
                {
                    this.pulseRateField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY RespiratoryRate
            {
                get
                {
                    return this.respiratoryRateField;
                }
                set
                {
                    this.respiratoryRateField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY Temperature
            {
                get
                {
                    return this.temperatureField;
                }
                set
                {
                    this.temperatureField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT TemperatureLocation
            {
                get
                {
                    return this.temperatureLocationField;
                }
                set
                {
                    this.temperatureLocationField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class BloodPressureVO : PhysicalExamVO
        {
            private DO_QUANTITY systolicBPField;

            private DO_QUANTITY diastolicBPField;

            private DO_CODED_TEXT positionField;

            /// <remarks/>
            public DO_QUANTITY SystolicBP
            {
                get
                {
                    return this.systolicBPField;
                }
                set
                {
                    this.systolicBPField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY DiastolicBP
            {
                get
                {
                    return this.diastolicBPField;
                }
                set
                {
                    this.diastolicBPField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Position
            {
                get
                {
                    return this.positionField;
                }
                set
                {
                    this.positionField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class DrugTreatmentReportVO
        {
            private System.Nullable<int> totalNumberField;

            private DO_CODED_TEXT sahpeField;

            private DO_DATE useStartDateField;

            private DO_TIME useStartTimeField;

            private DO_DATE useEndDateField;

            private DO_TIME useEndTimeField;

            private DO_CODED_TEXT drugNameField;

            private string drugGenericNameField;

            private DO_QUANTITY dosageField;

            private DO_QUANTITY dosageTotalField;

            private DO_CODED_TEXT frequencyField;

            private DO_CODED_TEXT routeField;

            private DO_QUANTITY longTermField;

            private string descriptionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> totalNumber
            {
                get
                {
                    return this.totalNumberField;
                }
                set
                {
                    this.totalNumberField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Sahpe
            {
                get
                {
                    return this.sahpeField;
                }
                set
                {
                    this.sahpeField = value;
                }
            }

            /// <remarks/>
            public DO_DATE UseStartDate
            {
                get
                {
                    return this.useStartDateField;
                }
                set
                {
                    this.useStartDateField = value;
                }
            }

            /// <remarks/>
            public DO_TIME UseStartTime
            {
                get
                {
                    return this.useStartTimeField;
                }
                set
                {
                    this.useStartTimeField = value;
                }
            }

            /// <remarks/>
            public DO_DATE UseEndDate
            {
                get
                {
                    return this.useEndDateField;
                }
                set
                {
                    this.useEndDateField = value;
                }
            }

            /// <remarks/>
            public DO_TIME UseEndTime
            {
                get
                {
                    return this.useEndTimeField;
                }
                set
                {
                    this.useEndTimeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT DrugName
            {
                get
                {
                    return this.drugNameField;
                }
                set
                {
                    this.drugNameField = value;
                }
            }

            /// <remarks/>
            public string DrugGenericName
            {
                get
                {
                    return this.drugGenericNameField;
                }
                set
                {
                    this.drugGenericNameField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY Dosage
            {
                get
                {
                    return this.dosageField;
                }
                set
                {
                    this.dosageField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY DosageTotal
            {
                get
                {
                    return this.dosageTotalField;
                }
                set
                {
                    this.dosageTotalField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Frequency
            {
                get
                {
                    return this.frequencyField;
                }
                set
                {
                    this.frequencyField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Route
            {
                get
                {
                    return this.routeField;
                }
                set
                {
                    this.routeField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY LongTerm
            {
                get
                {
                    return this.longTermField;
                }
                set
                {
                    this.longTermField = value;
                }
            }

            /// <remarks/>
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class GeneralActionReportVO
        {
            private DO_DATE startDateField;

            private DO_TIME startTimeField;

            private DO_DATE endDateField;

            private DO_TIME endTimeField;

            private DO_CODED_TEXT actionNameField;

            private string actionDescriptionField;

            private DO_QUANTITY timeTakenField;

            /// <remarks/>
            public DO_DATE StartDate
            {
                get
                {
                    return this.startDateField;
                }
                set
                {
                    this.startDateField = value;
                }
            }

            /// <remarks/>
            public DO_TIME StartTime
            {
                get
                {
                    return this.startTimeField;
                }
                set
                {
                    this.startTimeField = value;
                }
            }

            /// <remarks/>
            public DO_DATE EndDate
            {
                get
                {
                    return this.endDateField;
                }
                set
                {
                    this.endDateField = value;
                }
            }

            /// <remarks/>
            public DO_TIME EndTime
            {
                get
                {
                    return this.endTimeField;
                }
                set
                {
                    this.endTimeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT ActionName
            {
                get
                {
                    return this.actionNameField;
                }
                set
                {
                    this.actionNameField = value;
                }
            }

            /// <remarks/>
            public string ActionDescription
            {
                get
                {
                    return this.actionDescriptionField;
                }
                set
                {
                    this.actionDescriptionField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY TimeTaken
            {
                get
                {
                    return this.timeTakenField;
                }
                set
                {
                    this.timeTakenField = value;
                }
            }
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
            private DO_DATE_TIME dateTimeResultField;

            private SpecimenDetailsVO specimenField;

            private LaboratoryProtocolVO protocolField;

            /// <remarks/>
            public DO_DATE_TIME DateTimeResult
            {
                get
                {
                    return this.dateTimeResultField;
                }
                set
                {
                    this.dateTimeResultField = value;
                }
            }

            /// <remarks/>
            public SpecimenDetailsVO Specimen
            {
                get
                {
                    return this.specimenField;
                }
                set
                {
                    this.specimenField = value;
                }
            }

            /// <remarks/>
            public LaboratoryProtocolVO protocol
            {
                get
                {
                    return this.protocolField;
                }
                set
                {
                    this.protocolField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class SpecimenDetailsVO
        {
            private DO_CODED_TEXT specimenTissueTypeField;

            private DO_CODED_TEXT adequacyForTestingField;

            private DO_CODED_TEXT collectionProcedureField;

            private DO_DATE dateofCollectionField;

            private DO_TIME timeofCollectionField;

            private string specimenIdentifierField;

            /// <remarks/>
            public DO_CODED_TEXT SpecimenTissueType
            {
                get
                {
                    return this.specimenTissueTypeField;
                }
                set
                {
                    this.specimenTissueTypeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT AdequacyForTesting
            {
                get
                {
                    return this.adequacyForTestingField;
                }
                set
                {
                    this.adequacyForTestingField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT CollectionProcedure
            {
                get
                {
                    return this.collectionProcedureField;
                }
                set
                {
                    this.collectionProcedureField = value;
                }
            }

            /// <remarks/>
            public DO_DATE DateofCollection
            {
                get
                {
                    return this.dateofCollectionField;
                }
                set
                {
                    this.dateofCollectionField = value;
                }
            }

            /// <remarks/>
            public DO_TIME TimeofCollection
            {
                get
                {
                    return this.timeofCollectionField;
                }
                set
                {
                    this.timeofCollectionField = value;
                }
            }

            /// <remarks/>
            public string SpecimenIdentifier
            {
                get
                {
                    return this.specimenIdentifierField;
                }
                set
                {
                    this.specimenIdentifierField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class LaboratoryProtocolVO
        {
            private DO_DATE receiptDateField;

            private DO_TIME receiptTimeField;

            private DO_DATE processDateField;

            private DO_TIME processTimeField;

            private DO_CODED_TEXT methodField;

            private string methodDescriptionField;

            /// <remarks/>
            public DO_DATE ReceiptDate
            {
                get
                {
                    return this.receiptDateField;
                }
                set
                {
                    this.receiptDateField = value;
                }
            }

            /// <remarks/>
            public DO_TIME ReceiptTime
            {
                get
                {
                    return this.receiptTimeField;
                }
                set
                {
                    this.receiptTimeField = value;
                }
            }

            /// <remarks/>
            public DO_DATE ProcessDate
            {
                get
                {
                    return this.processDateField;
                }
                set
                {
                    this.processDateField = value;
                }
            }

            /// <remarks/>
            public DO_TIME ProcessTime
            {
                get
                {
                    return this.processTimeField;
                }
                set
                {
                    this.processTimeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Method
            {
                get
                {
                    return this.methodField;
                }
                set
                {
                    this.methodField = value;
                }
            }

            /// <remarks/>
            public string MethodDescription
            {
                get
                {
                    return this.methodDescriptionField;
                }
                set
                {
                    this.methodDescriptionField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class UAVO : LabTestResultVO
        {
            private DO_CODED_TEXT colorField;

            private DO_CODED_TEXT clarityField;

            private DO_ORDINAL concentrationField;

            private DO_INTERVALINT rBCsField;

            private DO_INTERVALINT wBCsField;

            private DO_INTERVALINT epithelialCellsField;

            private DO_ORDINAL microorganismsField;

            private DO_INTERVALINT castField;

            private DO_INTERVALINT crystalsField;

            private DO_QUANTITY specificGravityField;

            private DO_PROPORTION phField;

            private DO_ORDINAL proteinField;

            private DO_ORDINAL glucoseField;

            private DO_ORDINAL ketonesField;

            private DO_ORDINAL leukocyteEsteraseField;

            private DO_ORDINAL nitriteField;

            private DO_ORDINAL bilirubinField;

            private DO_ORDINAL urobilinogenField;

            private DO_ORDINAL bloodField;

            private string commentField;

            /// <remarks/>
            public DO_CODED_TEXT Color
            {
                get
                {
                    return this.colorField;
                }
                set
                {
                    this.colorField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Clarity
            {
                get
                {
                    return this.clarityField;
                }
                set
                {
                    this.clarityField = value;
                }
            }

            /// <remarks/>
            public DO_ORDINAL Concentration
            {
                get
                {
                    return this.concentrationField;
                }
                set
                {
                    this.concentrationField = value;
                }
            }

            /// <remarks/>
            public DO_INTERVALINT RBCs
            {
                get
                {
                    return this.rBCsField;
                }
                set
                {
                    this.rBCsField = value;
                }
            }

            /// <remarks/>
            public DO_INTERVALINT WBCs
            {
                get
                {
                    return this.wBCsField;
                }
                set
                {
                    this.wBCsField = value;
                }
            }

            /// <remarks/>
            public DO_INTERVALINT EpithelialCells
            {
                get
                {
                    return this.epithelialCellsField;
                }
                set
                {
                    this.epithelialCellsField = value;
                }
            }

            /// <remarks/>
            public DO_ORDINAL Microorganisms
            {
                get
                {
                    return this.microorganismsField;
                }
                set
                {
                    this.microorganismsField = value;
                }
            }

            /// <remarks/>
            public DO_INTERVALINT Cast
            {
                get
                {
                    return this.castField;
                }
                set
                {
                    this.castField = value;
                }
            }

            /// <remarks/>
            public DO_INTERVALINT Crystals
            {
                get
                {
                    return this.crystalsField;
                }
                set
                {
                    this.crystalsField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY SpecificGravity
            {
                get
                {
                    return this.specificGravityField;
                }
                set
                {
                    this.specificGravityField = value;
                }
            }

            /// <remarks/>
            public DO_PROPORTION PH
            {
                get
                {
                    return this.phField;
                }
                set
                {
                    this.phField = value;
                }
            }

            /// <remarks/>
            public DO_ORDINAL Protein
            {
                get
                {
                    return this.proteinField;
                }
                set
                {
                    this.proteinField = value;
                }
            }

            /// <remarks/>
            public DO_ORDINAL Glucose
            {
                get
                {
                    return this.glucoseField;
                }
                set
                {
                    this.glucoseField = value;
                }
            }

            /// <remarks/>
            public DO_ORDINAL Ketones
            {
                get
                {
                    return this.ketonesField;
                }
                set
                {
                    this.ketonesField = value;
                }
            }

            /// <remarks/>
            public DO_ORDINAL LeukocyteEsterase
            {
                get
                {
                    return this.leukocyteEsteraseField;
                }
                set
                {
                    this.leukocyteEsteraseField = value;
                }
            }

            /// <remarks/>
            public DO_ORDINAL Nitrite
            {
                get
                {
                    return this.nitriteField;
                }
                set
                {
                    this.nitriteField = value;
                }
            }

            /// <remarks/>
            public DO_ORDINAL Bilirubin
            {
                get
                {
                    return this.bilirubinField;
                }
                set
                {
                    this.bilirubinField = value;
                }
            }

            /// <remarks/>
            public DO_ORDINAL Urobilinogen
            {
                get
                {
                    return this.urobilinogenField;
                }
                set
                {
                    this.urobilinogenField = value;
                }
            }

            /// <remarks/>
            public DO_ORDINAL Blood
            {
                get
                {
                    return this.bloodField;
                }
                set
                {
                    this.bloodField = value;
                }
            }

            /// <remarks/>
            public string Comment
            {
                get
                {
                    return this.commentField;
                }
                set
                {
                    this.commentField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class DO_INTERVALINT
        {
            private System.Nullable<int> lowerValueField;

            private System.Nullable<int> upperValueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> lowerValue
            {
                get
                {
                    return this.lowerValueField;
                }
                set
                {
                    this.lowerValueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> upperValue
            {
                get
                {
                    return this.upperValueField;
                }
                set
                {
                    this.upperValueField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class DO_PROPORTION
        {
            private System.Nullable<double> numeratorField;

            private System.Nullable<double> denominatorField;

            private System.Nullable<int> typeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<double> numerator
            {
                get
                {
                    return this.numeratorField;
                }
                set
                {
                    this.numeratorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<double> denominator
            {
                get
                {
                    return this.denominatorField;
                }
                set
                {
                    this.denominatorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class LiverFunctionVO : LabTestResultVO
        {
            private DO_QUANTITY globulinsField;

            private DO_QUANTITY totalProteinField;

            private DO_QUANTITY lactateDehydrogenaseField;

            private DO_QUANTITY gammaGlutamylTransferaseField;

            private DO_QUANTITY albuminField;

            private DO_QUANTITY alkalinePhosphataseField;

            private DO_QUANTITY directBilirubinField;

            private DO_QUANTITY indirectBilirubinField;

            private DO_QUANTITY totalBilirubinField;

            private DO_QUANTITY sGOTField;

            private DO_QUANTITY sGPTField;

            /// <remarks/>
            public DO_QUANTITY Globulins
            {
                get
                {
                    return this.globulinsField;
                }
                set
                {
                    this.globulinsField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY TotalProtein
            {
                get
                {
                    return this.totalProteinField;
                }
                set
                {
                    this.totalProteinField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY LactateDehydrogenase
            {
                get
                {
                    return this.lactateDehydrogenaseField;
                }
                set
                {
                    this.lactateDehydrogenaseField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY GammaGlutamylTransferase
            {
                get
                {
                    return this.gammaGlutamylTransferaseField;
                }
                set
                {
                    this.gammaGlutamylTransferaseField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY Albumin
            {
                get
                {
                    return this.albuminField;
                }
                set
                {
                    this.albuminField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY AlkalinePhosphatase
            {
                get
                {
                    return this.alkalinePhosphataseField;
                }
                set
                {
                    this.alkalinePhosphataseField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY DirectBilirubin
            {
                get
                {
                    return this.directBilirubinField;
                }
                set
                {
                    this.directBilirubinField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY IndirectBilirubin
            {
                get
                {
                    return this.indirectBilirubinField;
                }
                set
                {
                    this.indirectBilirubinField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY TotalBilirubin
            {
                get
                {
                    return this.totalBilirubinField;
                }
                set
                {
                    this.totalBilirubinField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY SGOT
            {
                get
                {
                    return this.sGOTField;
                }
                set
                {
                    this.sGOTField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY SGPT
            {
                get
                {
                    return this.sGPTField;
                }
                set
                {
                    this.sGPTField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class BloodLipidsVO : LabTestResultVO
        {
            private DO_QUANTITY totalCholestrolField;

            private DO_QUANTITY triglyceridesField;

            private DO_QUANTITY hDLField;

            private DO_QUANTITY lDLField;

            private DO_QUANTITY vLDLField;

            /// <remarks/>
            public DO_QUANTITY TotalCholestrol
            {
                get
                {
                    return this.totalCholestrolField;
                }
                set
                {
                    this.totalCholestrolField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY Triglycerides
            {
                get
                {
                    return this.triglyceridesField;
                }
                set
                {
                    this.triglyceridesField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY HDL
            {
                get
                {
                    return this.hDLField;
                }
                set
                {
                    this.hDLField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY LDL
            {
                get
                {
                    return this.lDLField;
                }
                set
                {
                    this.lDLField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY VLDL
            {
                get
                {
                    return this.vLDLField;
                }
                set
                {
                    this.vLDLField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class GeneralLaboratoryResultVO : LabTestResultVO
        {
            private LaboratoryResultRowVO[] laboratoryResultRowField;

            private DO_CODED_TEXT laboratoryPanelField;

            /// <remarks/>
            public LaboratoryResultRowVO[] LaboratoryResultRow
            {
                get
                {
                    return this.laboratoryResultRowField;
                }
                set
                {
                    this.laboratoryResultRowField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT LaboratoryPanel
            {
                get
                {
                    return this.laboratoryPanelField;
                }
                set
                {
                    this.laboratoryPanelField = value;
                }
            }
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
            private System.Nullable<int> testSequenceField;

            private DO_CODED_TEXT testPanelField;

            private DO_CODED_TEXT testNameField;

            private string commentField;

            private DO_CODED_TEXT statusField;

            private DO_CODED_TEXT resultStatusField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> TestSequence
            {
                get
                {
                    return this.testSequenceField;
                }
                set
                {
                    this.testSequenceField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT TestPanel
            {
                get
                {
                    return this.testPanelField;
                }
                set
                {
                    this.testPanelField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT TestName
            {
                get
                {
                    return this.testNameField;
                }
                set
                {
                    this.testNameField = value;
                }
            }

            /// <remarks/>
            public string Comment
            {
                get
                {
                    return this.commentField;
                }
                set
                {
                    this.commentField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT ResultStatus
            {
                get
                {
                    return this.resultStatusField;
                }
                set
                {
                    this.resultStatusField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class LaboratoryResultRowOrdinalVO : LaboratoryResultRowVO
        {
            private DO_ORDINAL testResultField;

            private ReferenceRangeVO[] referenceRangeField;

            /// <remarks/>
            public DO_ORDINAL TestResult
            {
                get
                {
                    return this.testResultField;
                }
                set
                {
                    this.testResultField = value;
                }
            }

            /// <remarks/>
            public ReferenceRangeVO[] ReferenceRange
            {
                get
                {
                    return this.referenceRangeField;
                }
                set
                {
                    this.referenceRangeField = value;
                }
            }
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
            private DO_CODED_TEXT ageRangeField;

            private DO_CODED_TEXT genderField;

            private DO_CODED_TEXT speciesField;

            private DO_CODED_TEXT subSpeciesField;

            private DO_CODED_TEXT hormonalPhaseField;

            private DO_CODED_TEXT gestationAgeRangeField;

            private string conditionField;

            private string descriptionField;

            private DO_CODED_TEXT referenceStatusField;

            private string lowRangeDescriptiveField;

            private string highRangeDescriptiveField;

            /// <remarks/>
            public DO_CODED_TEXT AgeRange
            {
                get
                {
                    return this.ageRangeField;
                }
                set
                {
                    this.ageRangeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Gender
            {
                get
                {
                    return this.genderField;
                }
                set
                {
                    this.genderField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Species
            {
                get
                {
                    return this.speciesField;
                }
                set
                {
                    this.speciesField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT SubSpecies
            {
                get
                {
                    return this.subSpeciesField;
                }
                set
                {
                    this.subSpeciesField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT HormonalPhase
            {
                get
                {
                    return this.hormonalPhaseField;
                }
                set
                {
                    this.hormonalPhaseField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT GestationAgeRange
            {
                get
                {
                    return this.gestationAgeRangeField;
                }
                set
                {
                    this.gestationAgeRangeField = value;
                }
            }

            /// <remarks/>
            public string Condition
            {
                get
                {
                    return this.conditionField;
                }
                set
                {
                    this.conditionField = value;
                }
            }

            /// <remarks/>
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT ReferenceStatus
            {
                get
                {
                    return this.referenceStatusField;
                }
                set
                {
                    this.referenceStatusField = value;
                }
            }

            /// <remarks/>
            public string LowRangeDescriptive
            {
                get
                {
                    return this.lowRangeDescriptiveField;
                }
                set
                {
                    this.lowRangeDescriptiveField = value;
                }
            }

            /// <remarks/>
            public string HighRangeDescriptive
            {
                get
                {
                    return this.highRangeDescriptiveField;
                }
                set
                {
                    this.highRangeDescriptiveField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ReferenceRangeNumericVO : ReferenceRangeVO
        {
            private System.Nullable<int> lowNumbericRangeField;

            private System.Nullable<int> highNumbericRangeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> LowNumbericRange
            {
                get
                {
                    return this.lowNumbericRangeField;
                }
                set
                {
                    this.lowNumbericRangeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> HighNumbericRange
            {
                get
                {
                    return this.highNumbericRangeField;
                }
                set
                {
                    this.highNumbericRangeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ReferenceRangeQualityVO : ReferenceRangeVO
        {
            private DO_QUANTITY lowQuantityRangeField;

            private DO_QUANTITY highQuantityRangeField;

            /// <remarks/>
            public DO_QUANTITY LowQuantityRange
            {
                get
                {
                    return this.lowQuantityRangeField;
                }
                set
                {
                    this.lowQuantityRangeField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY HighQuantityRange
            {
                get
                {
                    return this.highQuantityRangeField;
                }
                set
                {
                    this.highQuantityRangeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class LaboratoryResultRowProportionVO : LaboratoryResultRowVO
        {
            private DO_PROPORTION testResultField;

            private ReferenceRangeVO[] referenceRangeField;

            /// <remarks/>
            public DO_PROPORTION TestResult
            {
                get
                {
                    return this.testResultField;
                }
                set
                {
                    this.testResultField = value;
                }
            }

            /// <remarks/>
            public ReferenceRangeVO[] ReferenceRange
            {
                get
                {
                    return this.referenceRangeField;
                }
                set
                {
                    this.referenceRangeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class LaboratoryResultRowBooleanVO : LaboratoryResultRowVO
        {
            private System.Nullable<bool> testResultField;

            private ReferenceRangeVO[] referenceRangeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<bool> TestResult
            {
                get
                {
                    return this.testResultField;
                }
                set
                {
                    this.testResultField = value;
                }
            }

            /// <remarks/>
            public ReferenceRangeVO[] ReferenceRange
            {
                get
                {
                    return this.referenceRangeField;
                }
                set
                {
                    this.referenceRangeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class LaboratoryResultRowCodedVO : LaboratoryResultRowVO
        {
            private DO_CODED_TEXT testResultField;

            private ReferenceRangeVO[] referenceRangeField;

            /// <remarks/>
            public DO_CODED_TEXT TestResult
            {
                get
                {
                    return this.testResultField;
                }
                set
                {
                    this.testResultField = value;
                }
            }

            /// <remarks/>
            public ReferenceRangeVO[] ReferenceRange
            {
                get
                {
                    return this.referenceRangeField;
                }
                set
                {
                    this.referenceRangeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class LaboratoryResultRowCountVO : LaboratoryResultRowVO
        {
            private System.Nullable<int> testResultField;

            private ReferenceRangeVO[] referenceRangeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> TestResult
            {
                get
                {
                    return this.testResultField;
                }
                set
                {
                    this.testResultField = value;
                }
            }

            /// <remarks/>
            public ReferenceRangeVO[] ReferenceRange
            {
                get
                {
                    return this.referenceRangeField;
                }
                set
                {
                    this.referenceRangeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class LaboratoryResultRowQuantityVO : LaboratoryResultRowVO
        {
            private DO_QUANTITY testResultField;

            private ReferenceRangeVO[] referenceRangeField;

            /// <remarks/>
            public DO_QUANTITY TestResult
            {
                get
                {
                    return this.testResultField;
                }
                set
                {
                    this.testResultField = value;
                }
            }

            /// <remarks/>
            public ReferenceRangeVO[] ReferenceRange
            {
                get
                {
                    return this.referenceRangeField;
                }
                set
                {
                    this.referenceRangeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class PathologyVO : LabTestResultVO
        {
            private string microscopicExaminationField;

            private string macroscopicExaminationField;

            private string clinicalInformationField;

            private PathologyDiagnosisVO[] pathologyDiagnosisField;

            /// <remarks/>
            public string MicroscopicExamination
            {
                get
                {
                    return this.microscopicExaminationField;
                }
                set
                {
                    this.microscopicExaminationField = value;
                }
            }

            /// <remarks/>
            public string MacroscopicExamination
            {
                get
                {
                    return this.macroscopicExaminationField;
                }
                set
                {
                    this.macroscopicExaminationField = value;
                }
            }

            /// <remarks/>
            public string ClinicalInformation
            {
                get
                {
                    return this.clinicalInformationField;
                }
                set
                {
                    this.clinicalInformationField = value;
                }
            }

            /// <remarks/>
            public PathologyDiagnosisVO[] PathologyDiagnosis
            {
                get
                {
                    return this.pathologyDiagnosisField;
                }
                set
                {
                    this.pathologyDiagnosisField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class PathologyDiagnosisVO
        {
            private string diagnosisDescriptionField;

            private DO_CODED_TEXT diagnosisField;

            private DO_CODED_TEXT topographyField;

            private DO_CODED_TEXT topographyLateralityField;

            private DO_CODED_TEXT morphologyField;

            private DO_CODED_TEXT morphologyDifferentiationField;

            /// <remarks/>
            public string DiagnosisDescription
            {
                get
                {
                    return this.diagnosisDescriptionField;
                }
                set
                {
                    this.diagnosisDescriptionField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Diagnosis
            {
                get
                {
                    return this.diagnosisField;
                }
                set
                {
                    this.diagnosisField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Topography
            {
                get
                {
                    return this.topographyField;
                }
                set
                {
                    this.topographyField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT TopographyLaterality
            {
                get
                {
                    return this.topographyLateralityField;
                }
                set
                {
                    this.topographyLateralityField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Morphology
            {
                get
                {
                    return this.morphologyField;
                }
                set
                {
                    this.morphologyField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT MorphologyDifferentiation
            {
                get
                {
                    return this.morphologyDifferentiationField;
                }
                set
                {
                    this.morphologyDifferentiationField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class MicrobiologicalCultureVO : LabTestResultVO
        {
            private MicrobialFindingVO microbialFindingField;

            private DO_CODED_TEXT cultureTypeField;

            private DO_QUANTITY colonyCountField;

            private AntibiogramVO[] antibiogramsField;

            private DO_CODED_TEXT growthDurationTypeField;

            /// <remarks/>
            public MicrobialFindingVO MicrobialFinding
            {
                get
                {
                    return this.microbialFindingField;
                }
                set
                {
                    this.microbialFindingField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT CultureType
            {
                get
                {
                    return this.cultureTypeField;
                }
                set
                {
                    this.cultureTypeField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY ColonyCount
            {
                get
                {
                    return this.colonyCountField;
                }
                set
                {
                    this.colonyCountField = value;
                }
            }

            /// <remarks/>
            public AntibiogramVO[] Antibiograms
            {
                get
                {
                    return this.antibiogramsField;
                }
                set
                {
                    this.antibiogramsField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT GrowthDurationType
            {
                get
                {
                    return this.growthDurationTypeField;
                }
                set
                {
                    this.growthDurationTypeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class MicrobialFindingVO
        {
            private DO_CODED_TEXT organismField;

            private DO_CODED_TEXT bioTypeField;

            /// <remarks/>
            public DO_CODED_TEXT Organism
            {
                get
                {
                    return this.organismField;
                }
                set
                {
                    this.organismField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT BioType
            {
                get
                {
                    return this.bioTypeField;
                }
                set
                {
                    this.bioTypeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class AntibiogramVO
        {
            private DO_CODED_TEXT agentField;

            private DO_CODED_TEXT sensitivityField;

            /// <remarks/>
            public DO_CODED_TEXT Agent
            {
                get
                {
                    return this.agentField;
                }
                set
                {
                    this.agentField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Sensitivity
            {
                get
                {
                    return this.sensitivityField;
                }
                set
                {
                    this.sensitivityField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class BloodSugarVO : LabTestResultVO
        {
            private BSVO[] bsField;

            private DO_CODED_TEXT testSpecified1Field;

            private string commentField;

            /// <remarks/>
            public BSVO[] BS
            {
                get
                {
                    return this.bsField;
                }
                set
                {
                    this.bsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("TestSpecified")]
            public DO_CODED_TEXT TestSpecified1
            {
                get
                {
                    return this.testSpecified1Field;
                }
                set
                {
                    this.testSpecified1Field = value;
                }
            }

            /// <remarks/>
            public string Comment
            {
                get
                {
                    return this.commentField;
                }
                set
                {
                    this.commentField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class BSVO
        {
            private DO_QUANTITY bloodGlucoseLevelField;

            private DO_CODED_TEXT timingField;

            /// <remarks/>
            public DO_QUANTITY BloodGlucoseLevel
            {
                get
                {
                    return this.bloodGlucoseLevelField;
                }
                set
                {
                    this.bloodGlucoseLevelField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Timing
            {
                get
                {
                    return this.timingField;
                }
                set
                {
                    this.timingField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class SingleBooleanVO : LabTestResultVO
        {
            private DO_CODED_TEXT labTestNameField;

            private System.Nullable<bool> labValueField;

            /// <remarks/>
            public DO_CODED_TEXT LabTestName
            {
                get
                {
                    return this.labTestNameField;
                }
                set
                {
                    this.labTestNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<bool> LabValue
            {
                get
                {
                    return this.labValueField;
                }
                set
                {
                    this.labValueField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class SingleQuantityVO : LabTestResultVO
        {
            private DO_CODED_TEXT labTestNameField;

            private DO_QUANTITY labValueField;

            /// <remarks/>
            public DO_CODED_TEXT LabTestName
            {
                get
                {
                    return this.labTestNameField;
                }
                set
                {
                    this.labTestNameField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY LabValue
            {
                get
                {
                    return this.labValueField;
                }
                set
                {
                    this.labValueField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class CoagulationVO : LabTestResultVO
        {
            private DO_QUANTITY ptField;

            private DO_QUANTITY pTTField;

            private DO_PROPORTION iNRField;

            /// <remarks/>
            public DO_QUANTITY PT
            {
                get
                {
                    return this.ptField;
                }
                set
                {
                    this.ptField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY PTT
            {
                get
                {
                    return this.pTTField;
                }
                set
                {
                    this.pTTField = value;
                }
            }

            /// <remarks/>
            public DO_PROPORTION INR
            {
                get
                {
                    return this.iNRField;
                }
                set
                {
                    this.iNRField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class UA24HVO : LabTestResultVO
        {
            private DO_QUANTITY protienField;

            private DO_QUANTITY ceratininField;

            private DO_QUANTITY volumeField;

            /// <remarks/>
            public DO_QUANTITY Protien
            {
                get
                {
                    return this.protienField;
                }
                set
                {
                    this.protienField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY Ceratinin
            {
                get
                {
                    return this.ceratininField;
                }
                set
                {
                    this.ceratininField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY Volume
            {
                get
                {
                    return this.volumeField;
                }
                set
                {
                    this.volumeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class BloodGroupVO : LabTestResultVO
        {
            private DO_CODED_TEXT aBOField;

            private DO_CODED_TEXT rhesusFactorField;

            /// <remarks/>
            public DO_CODED_TEXT ABO
            {
                get
                {
                    return this.aBOField;
                }
                set
                {
                    this.aBOField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT RhesusFactor
            {
                get
                {
                    return this.rhesusFactorField;
                }
                set
                {
                    this.rhesusFactorField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ThrombinTimeVO : LabTestResultVO
        {
            private DO_QUANTITY bleedingTimeField;

            private DO_QUANTITY clottingTimeField;

            /// <remarks/>
            public DO_QUANTITY BleedingTime
            {
                get
                {
                    return this.bleedingTimeField;
                }
                set
                {
                    this.bleedingTimeField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY ClottingTime
            {
                get
                {
                    return this.clottingTimeField;
                }
                set
                {
                    this.clottingTimeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ThyroidVO : LabTestResultVO
        {
            private DO_QUANTITY freeT4Field;

            private DO_QUANTITY freeT3Field;

            private DO_QUANTITY tSHField;

            private DO_QUANTITY totalT4Field;

            private DO_QUANTITY totalT3Field;

            /// <remarks/>
            public DO_QUANTITY FreeT4
            {
                get
                {
                    return this.freeT4Field;
                }
                set
                {
                    this.freeT4Field = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY FreeT3
            {
                get
                {
                    return this.freeT3Field;
                }
                set
                {
                    this.freeT3Field = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY TSH
            {
                get
                {
                    return this.tSHField;
                }
                set
                {
                    this.tSHField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY TotalT4
            {
                get
                {
                    return this.totalT4Field;
                }
                set
                {
                    this.totalT4Field = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY TotalT3
            {
                get
                {
                    return this.totalT3Field;
                }
                set
                {
                    this.totalT3Field = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class CBCVO : LabTestResultVO
        {
            private DO_QUANTITY wBCField;

            private DO_QUANTITY rBCField;

            private DO_QUANTITY hemoglobinField;

            private DO_QUANTITY plateletField;

            private DO_QUANTITY hematocritField;

            private DO_QUANTITY mCVField;

            private DO_QUANTITY mCHField;

            private DO_QUANTITY mCHCField;

            private DO_PROPORTION neutrophilsField;

            private DO_PROPORTION lymphocytesField;

            private DO_PROPORTION monocytesField;

            private DO_PROPORTION eosinophilsField;

            private DO_PROPORTION basophilsField;

            private string microscopicFeaturesField;

            /// <remarks/>
            public DO_QUANTITY WBC
            {
                get
                {
                    return this.wBCField;
                }
                set
                {
                    this.wBCField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY RBC
            {
                get
                {
                    return this.rBCField;
                }
                set
                {
                    this.rBCField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY Hemoglobin
            {
                get
                {
                    return this.hemoglobinField;
                }
                set
                {
                    this.hemoglobinField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY Platelet
            {
                get
                {
                    return this.plateletField;
                }
                set
                {
                    this.plateletField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY Hematocrit
            {
                get
                {
                    return this.hematocritField;
                }
                set
                {
                    this.hematocritField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY MCV
            {
                get
                {
                    return this.mCVField;
                }
                set
                {
                    this.mCVField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY MCH
            {
                get
                {
                    return this.mCHField;
                }
                set
                {
                    this.mCHField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY MCHC
            {
                get
                {
                    return this.mCHCField;
                }
                set
                {
                    this.mCHCField = value;
                }
            }

            /// <remarks/>
            public DO_PROPORTION Neutrophils
            {
                get
                {
                    return this.neutrophilsField;
                }
                set
                {
                    this.neutrophilsField = value;
                }
            }

            /// <remarks/>
            public DO_PROPORTION Lymphocytes
            {
                get
                {
                    return this.lymphocytesField;
                }
                set
                {
                    this.lymphocytesField = value;
                }
            }

            /// <remarks/>
            public DO_PROPORTION Monocytes
            {
                get
                {
                    return this.monocytesField;
                }
                set
                {
                    this.monocytesField = value;
                }
            }

            /// <remarks/>
            public DO_PROPORTION Eosinophils
            {
                get
                {
                    return this.eosinophilsField;
                }
                set
                {
                    this.eosinophilsField = value;
                }
            }

            /// <remarks/>
            public DO_PROPORTION Basophils
            {
                get
                {
                    return this.basophilsField;
                }
                set
                {
                    this.basophilsField = value;
                }
            }

            /// <remarks/>
            public string MicroscopicFeatures
            {
                get
                {
                    return this.microscopicFeaturesField;
                }
                set
                {
                    this.microscopicFeaturesField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class AmbulanceServiceMessageVO
        {
            private PersonInfoVO personField;

            private MessageIdentifierVO msgIDField;

            private AmbulanceServiceCompositionVO compositionField;

            private System.Xml.Serialization.XmlSerializerNamespaces xmlnsField;

            /// <remarks/>
            public PersonInfoVO Person
            {
                get
                {
                    return this.personField;
                }
                set
                {
                    this.personField = value;
                }
            }

            /// <remarks/>
            public MessageIdentifierVO MsgID
            {
                get
                {
                    return this.msgIDField;
                }
                set
                {
                    this.msgIDField = value;
                }
            }

            /// <remarks/>
            public AmbulanceServiceCompositionVO Composition
            {
                get
                {
                    return this.compositionField;
                }
                set
                {
                    this.compositionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlNamespaceDeclarations()]
            public System.Xml.Serialization.XmlSerializerNamespaces xmlns
            {
                get
                {
                    return this.xmlnsField;
                }
                set
                {
                    this.xmlnsField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class MessageIdentifierVO
        {
            private DO_CODED_TEXT versionLifecycleStateField;

            private System.Nullable<bool> iS_QueriableField;

            private SignatureVO compositionSignatureField;

            private DO_IDENTIFIER systemIDField;

            private DO_IDENTIFIER healthCareFacilityIDField;

            private string patientUIDField;

            private string compositionUIDField;

            private ProviderInfoVO committerField;

            /// <remarks/>
            public DO_CODED_TEXT VersionLifecycleState
            {
                get
                {
                    return this.versionLifecycleStateField;
                }
                set
                {
                    this.versionLifecycleStateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<bool> IS_Queriable
            {
                get
                {
                    return this.iS_QueriableField;
                }
                set
                {
                    this.iS_QueriableField = value;
                }
            }

            /// <remarks/>
            public SignatureVO CompositionSignature
            {
                get
                {
                    return this.compositionSignatureField;
                }
                set
                {
                    this.compositionSignatureField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER SystemID
            {
                get
                {
                    return this.systemIDField;
                }
                set
                {
                    this.systemIDField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER HealthCareFacilityID
            {
                get
                {
                    return this.healthCareFacilityIDField;
                }
                set
                {
                    this.healthCareFacilityIDField = value;
                }
            }

            /// <remarks/>
            public string PatientUID
            {
                get
                {
                    return this.patientUIDField;
                }
                set
                {
                    this.patientUIDField = value;
                }
            }

            /// <remarks/>
            public string CompositionUID
            {
                get
                {
                    return this.compositionUIDField;
                }
                set
                {
                    this.compositionUIDField = value;
                }
            }

            /// <remarks/>
            public ProviderInfoVO Committer
            {
                get
                {
                    return this.committerField;
                }
                set
                {
                    this.committerField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ProviderInfoVO
        {
            private DO_IDENTIFIER identifierField;

            private ElectronicContactVO[] contactPointField;

            private string firstNameField;

            private string lastNameField;

            private string fullNameField;

            /// <remarks/>
            public DO_IDENTIFIER Identifier
            {
                get
                {
                    return this.identifierField;
                }
                set
                {
                    this.identifierField = value;
                }
            }

            /// <remarks/>
            public ElectronicContactVO[] ContactPoint
            {
                get
                {
                    return this.contactPointField;
                }
                set
                {
                    this.contactPointField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string FirstName
            {
                get
                {
                    return this.firstNameField;
                }
                set
                {
                    this.firstNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string LastName
            {
                get
                {
                    return this.lastNameField;
                }
                set
                {
                    this.lastNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string FullName
            {
                get
                {
                    return this.fullNameField;
                }
                set
                {
                    this.fullNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ImagingPrescriptionRowVO
        {
            private DO_CODED_TEXT serviceField;

            private DO_CODEABLE_CONCEPT[] serviceDetailField;

            private AnatomicalLocationVO[] anatomicalLocationField;

            private string noteField;

            private string patientInstructionField;

            /// <remarks/>
            public DO_CODED_TEXT Service
            {
                get
                {
                    return this.serviceField;
                }
                set
                {
                    this.serviceField = value;
                }
            }

            /// <remarks/>
            public DO_CODEABLE_CONCEPT[] ServiceDetail
            {
                get
                {
                    return this.serviceDetailField;
                }
                set
                {
                    this.serviceDetailField = value;
                }
            }

            /// <remarks/>
            public AnatomicalLocationVO[] AnatomicalLocation
            {
                get
                {
                    return this.anatomicalLocationField;
                }
                set
                {
                    this.anatomicalLocationField = value;
                }
            }

            /// <remarks/>
            public string Note
            {
                get
                {
                    return this.noteField;
                }
                set
                {
                    this.noteField = value;
                }
            }

            /// <remarks/>
            public string PatientInstruction
            {
                get
                {
                    return this.patientInstructionField;
                }
                set
                {
                    this.patientInstructionField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ImagingPrescriptionsVO
        {
            private string noteField;

            private DO_CODED_TEXT statusField;

            private DO_CODED_TEXT priorityField;

            private ProviderInfoVO prescriberField;

            private DO_DATE_TIME issueDateTimeField;

            private DO_IDENTIFIER ePrescriptionIDField;

            private ImagingPrescriptionRowVO[] ordersField;

            private DO_DATE expiryDateField;

            /// <remarks/>
            public string Note
            {
                get
                {
                    return this.noteField;
                }
                set
                {
                    this.noteField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Priority
            {
                get
                {
                    return this.priorityField;
                }
                set
                {
                    this.priorityField = value;
                }
            }

            /// <remarks/>
            public ProviderInfoVO Prescriber
            {
                get
                {
                    return this.prescriberField;
                }
                set
                {
                    this.prescriberField = value;
                }
            }

            /// <remarks/>
            public DO_DATE_TIME IssueDateTime
            {
                get
                {
                    return this.issueDateTimeField;
                }
                set
                {
                    this.issueDateTimeField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER ePrescriptionID
            {
                get
                {
                    return this.ePrescriptionIDField;
                }
                set
                {
                    this.ePrescriptionIDField = value;
                }
            }

            /// <remarks/>
            public ImagingPrescriptionRowVO[] Orders
            {
                get
                {
                    return this.ordersField;
                }
                set
                {
                    this.ordersField = value;
                }
            }

            /// <remarks/>
            public DO_DATE ExpiryDate
            {
                get
                {
                    return this.expiryDateField;
                }
                set
                {
                    this.expiryDateField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ImagingPrescriptionCompositionVO
        {
            private AdmissionVO admissionField;

            private InsuranceVO insuranceField;

            private ImagingPrescriptionsVO servicePrescriptionsField;

            private DiagnosisVO[] diagnosisField;

            /// <remarks/>
            public AdmissionVO Admission
            {
                get
                {
                    return this.admissionField;
                }
                set
                {
                    this.admissionField = value;
                }
            }

            /// <remarks/>
            public InsuranceVO Insurance
            {
                get
                {
                    return this.insuranceField;
                }
                set
                {
                    this.insuranceField = value;
                }
            }

            /// <remarks/>
            public ImagingPrescriptionsVO ServicePrescriptions
            {
                get
                {
                    return this.servicePrescriptionsField;
                }
                set
                {
                    this.servicePrescriptionsField = value;
                }
            }

            /// <remarks/>
            public DiagnosisVO[] Diagnosis
            {
                get
                {
                    return this.diagnosisField;
                }
                set
                {
                    this.diagnosisField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class InsuranceVO
        {
            private DO_QUANTITY insuranceContributionField;

            private QuantitiesVO[] insuranceOtherCostsField;

            private DO_CODED_TEXT insurerField;

            private DO_CODED_TEXT insuranceBoxField;

            private string insuranceBookletSerialNumberField;

            private DO_DATE insuranceExpirationDateField;

            private string insuredNumberField;

            private DO_IDENTIFIER sHEBADField;

            /// <remarks/>
            public DO_QUANTITY InsuranceContribution
            {
                get
                {
                    return this.insuranceContributionField;
                }
                set
                {
                    this.insuranceContributionField = value;
                }
            }

            /// <remarks/>
            public QuantitiesVO[] InsuranceOtherCosts
            {
                get
                {
                    return this.insuranceOtherCostsField;
                }
                set
                {
                    this.insuranceOtherCostsField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Insurer
            {
                get
                {
                    return this.insurerField;
                }
                set
                {
                    this.insurerField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT InsuranceBox
            {
                get
                {
                    return this.insuranceBoxField;
                }
                set
                {
                    this.insuranceBoxField = value;
                }
            }

            /// <remarks/>
            public string InsuranceBookletSerialNumber
            {
                get
                {
                    return this.insuranceBookletSerialNumberField;
                }
                set
                {
                    this.insuranceBookletSerialNumberField = value;
                }
            }

            /// <remarks/>
            public DO_DATE InsuranceExpirationDate
            {
                get
                {
                    return this.insuranceExpirationDateField;
                }
                set
                {
                    this.insuranceExpirationDateField = value;
                }
            }

            /// <remarks/>
            public string InsuredNumber
            {
                get
                {
                    return this.insuredNumberField;
                }
                set
                {
                    this.insuredNumberField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER SHEBAD
            {
                get
                {
                    return this.sHEBADField;
                }
                set
                {
                    this.sHEBADField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ImagingPrescriptionsMessageVO
        {
            private PersonInfoVO personField;

            private MessageIdentifierVO msgIDField;

            private ImagingPrescriptionCompositionVO compositionField;

            private System.Xml.Serialization.XmlSerializerNamespaces xmlnsField;

            /// <remarks/>
            public PersonInfoVO Person
            {
                get
                {
                    return this.personField;
                }
                set
                {
                    this.personField = value;
                }
            }

            /// <remarks/>
            public MessageIdentifierVO MsgID
            {
                get
                {
                    return this.msgIDField;
                }
                set
                {
                    this.msgIDField = value;
                }
            }

            /// <remarks/>
            public ImagingPrescriptionCompositionVO Composition
            {
                get
                {
                    return this.compositionField;
                }
                set
                {
                    this.compositionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlNamespaceDeclarations()]
            public System.Xml.Serialization.XmlSerializerNamespaces xmlns
            {
                get
                {
                    return this.xmlnsField;
                }
                set
                {
                    this.xmlnsField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ServicePrescriptionRowVO
        {
            private System.Nullable<bool> doNotPerformField;

            private DO_CODED_TEXT serviceField;

            private System.Nullable<int> serviceAmountField;

            private DO_CODED_TEXT methodField;

            private AnatomicalLocationVO[] anatomicalLocationField;

            private DO_CODEABLE_CONCEPT[] asNeededField;

            private DO_CODEABLE_CONCEPT[] reasonCodeField;

            private string noteField;

            private string patientInstructionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<bool> DoNotPerform
            {
                get
                {
                    return this.doNotPerformField;
                }
                set
                {
                    this.doNotPerformField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Service
            {
                get
                {
                    return this.serviceField;
                }
                set
                {
                    this.serviceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> ServiceAmount
            {
                get
                {
                    return this.serviceAmountField;
                }
                set
                {
                    this.serviceAmountField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Method
            {
                get
                {
                    return this.methodField;
                }
                set
                {
                    this.methodField = value;
                }
            }

            /// <remarks/>
            public AnatomicalLocationVO[] AnatomicalLocation
            {
                get
                {
                    return this.anatomicalLocationField;
                }
                set
                {
                    this.anatomicalLocationField = value;
                }
            }

            /// <remarks/>
            public DO_CODEABLE_CONCEPT[] AsNeeded
            {
                get
                {
                    return this.asNeededField;
                }
                set
                {
                    this.asNeededField = value;
                }
            }

            /// <remarks/>
            public DO_CODEABLE_CONCEPT[] ReasonCode
            {
                get
                {
                    return this.reasonCodeField;
                }
                set
                {
                    this.reasonCodeField = value;
                }
            }

            /// <remarks/>
            public string Note
            {
                get
                {
                    return this.noteField;
                }
                set
                {
                    this.noteField = value;
                }
            }

            /// <remarks/>
            public string PatientInstruction
            {
                get
                {
                    return this.patientInstructionField;
                }
                set
                {
                    this.patientInstructionField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ServicePrescriptionsVO
        {
            private string noteField;

            private DO_CODED_TEXT statusField;

            private DO_CODED_TEXT intentField;

            private DO_CODEABLE_CONCEPT categoryField;

            private DO_CODED_TEXT priorityField;

            private DO_CODEABLE_CONCEPT locationCodeField;

            private SpecimenDetailsVO specimenField;

            private ProviderInfoVO prescriberField;

            private DO_DATE_TIME issueDateTimeField;

            private DO_IDENTIFIER ePrescriptionIDField;

            private ServicePrescriptionRowVO[] ordersField;

            private DO_DATE expiryDateField;

            private System.Nullable<int> repeatsField;

            /// <remarks/>
            public string Note
            {
                get
                {
                    return this.noteField;
                }
                set
                {
                    this.noteField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Intent
            {
                get
                {
                    return this.intentField;
                }
                set
                {
                    this.intentField = value;
                }
            }

            /// <remarks/>
            public DO_CODEABLE_CONCEPT Category
            {
                get
                {
                    return this.categoryField;
                }
                set
                {
                    this.categoryField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Priority
            {
                get
                {
                    return this.priorityField;
                }
                set
                {
                    this.priorityField = value;
                }
            }

            /// <remarks/>
            public DO_CODEABLE_CONCEPT LocationCode
            {
                get
                {
                    return this.locationCodeField;
                }
                set
                {
                    this.locationCodeField = value;
                }
            }

            /// <remarks/>
            public SpecimenDetailsVO Specimen
            {
                get
                {
                    return this.specimenField;
                }
                set
                {
                    this.specimenField = value;
                }
            }

            /// <remarks/>
            public ProviderInfoVO Prescriber
            {
                get
                {
                    return this.prescriberField;
                }
                set
                {
                    this.prescriberField = value;
                }
            }

            /// <remarks/>
            public DO_DATE_TIME IssueDateTime
            {
                get
                {
                    return this.issueDateTimeField;
                }
                set
                {
                    this.issueDateTimeField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER ePrescriptionID
            {
                get
                {
                    return this.ePrescriptionIDField;
                }
                set
                {
                    this.ePrescriptionIDField = value;
                }
            }

            /// <remarks/>
            public ServicePrescriptionRowVO[] Orders
            {
                get
                {
                    return this.ordersField;
                }
                set
                {
                    this.ordersField = value;
                }
            }

            /// <remarks/>
            public DO_DATE ExpiryDate
            {
                get
                {
                    return this.expiryDateField;
                }
                set
                {
                    this.expiryDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> Repeats
            {
                get
                {
                    return this.repeatsField;
                }
                set
                {
                    this.repeatsField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ServicePrescriptionsCompositionVO
        {
            private DiagnosisVO[] diagnosisField;

            private AdmissionVO admissionField;

            private InsuranceVO insuranceField;

            private ServicePrescriptionsVO servicePrescriptionsField;

            /// <remarks/>
            public DiagnosisVO[] Diagnosis
            {
                get
                {
                    return this.diagnosisField;
                }
                set
                {
                    this.diagnosisField = value;
                }
            }

            /// <remarks/>
            public AdmissionVO Admission
            {
                get
                {
                    return this.admissionField;
                }
                set
                {
                    this.admissionField = value;
                }
            }

            /// <remarks/>
            public InsuranceVO Insurance
            {
                get
                {
                    return this.insuranceField;
                }
                set
                {
                    this.insuranceField = value;
                }
            }

            /// <remarks/>
            public ServicePrescriptionsVO ServicePrescriptions
            {
                get
                {
                    return this.servicePrescriptionsField;
                }
                set
                {
                    this.servicePrescriptionsField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class LaboratoryPrescriptionsMessageVO
        {
            private PersonInfoVO personField;

            private MessageIdentifierVO msgIDField;

            private ServicePrescriptionsCompositionVO compositionField;

            private System.Xml.Serialization.XmlSerializerNamespaces xmlnsField;

            /// <remarks/>
            public PersonInfoVO Person
            {
                get
                {
                    return this.personField;
                }
                set
                {
                    this.personField = value;
                }
            }

            /// <remarks/>
            public MessageIdentifierVO MsgID
            {
                get
                {
                    return this.msgIDField;
                }
                set
                {
                    this.msgIDField = value;
                }
            }

            /// <remarks/>
            public ServicePrescriptionsCompositionVO Composition
            {
                get
                {
                    return this.compositionField;
                }
                set
                {
                    this.compositionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlNamespaceDeclarations()]
            public System.Xml.Serialization.XmlSerializerNamespaces xmlns
            {
                get
                {
                    return this.xmlnsField;
                }
                set
                {
                    this.xmlnsField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ComplicationVO
        {
            private DO_CODED_TEXT complicationField;

            private string descriptionField;

            private DO_ORDINAL severityField;

            private DO_CODED_TEXT causativeAgentField;

            /// <remarks/>
            public DO_CODED_TEXT Complication
            {
                get
                {
                    return this.complicationField;
                }
                set
                {
                    this.complicationField = value;
                }
            }

            /// <remarks/>
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            public DO_ORDINAL Severity
            {
                get
                {
                    return this.severityField;
                }
                set
                {
                    this.severityField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT CausativeAgent
            {
                get
                {
                    return this.causativeAgentField;
                }
                set
                {
                    this.causativeAgentField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ObstetricHistoryVO
        {
            private System.Nullable<int> gravidField;

            private System.Nullable<int> paraField;

            private System.Nullable<int> abortionField;

            private System.Nullable<int> liveChildField;

            private System.Nullable<int> deathChildField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> Gravid
            {
                get
                {
                    return this.gravidField;
                }
                set
                {
                    this.gravidField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> Para
            {
                get
                {
                    return this.paraField;
                }
                set
                {
                    this.paraField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> Abortion
            {
                get
                {
                    return this.abortionField;
                }
                set
                {
                    this.abortionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> LiveChild
            {
                get
                {
                    return this.liveChildField;
                }
                set
                {
                    this.liveChildField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> DeathChild
            {
                get
                {
                    return this.deathChildField;
                }
                set
                {
                    this.deathChildField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class TravelHistoryVO
        {
            private DO_DATE startDateField;

            private DO_DATE endDateField;

            private HighLevelAreaVO destinationField;

            /// <remarks/>
            public DO_DATE StartDate
            {
                get
                {
                    return this.startDateField;
                }
                set
                {
                    this.startDateField = value;
                }
            }

            /// <remarks/>
            public DO_DATE EndDate
            {
                get
                {
                    return this.endDateField;
                }
                set
                {
                    this.endDateField = value;
                }
            }

            /// <remarks/>
            public HighLevelAreaVO Destination
            {
                get
                {
                    return this.destinationField;
                }
                set
                {
                    this.destinationField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class VaccinationVO
        {
            private DO_CODED_TEXT vaccinationPlanField;

            private DO_CODED_TEXT planCourseField;

            private DO_CODED_TEXT vaccineField;

            private DO_DATE_TIME dateOfInjectionField;

            private string descriptionField;

            /// <remarks/>
            public DO_CODED_TEXT VaccinationPlan
            {
                get
                {
                    return this.vaccinationPlanField;
                }
                set
                {
                    this.vaccinationPlanField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT PlanCourse
            {
                get
                {
                    return this.planCourseField;
                }
                set
                {
                    this.planCourseField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Vaccine
            {
                get
                {
                    return this.vaccineField;
                }
                set
                {
                    this.vaccineField = value;
                }
            }

            /// <remarks/>
            public DO_DATE_TIME DateOfInjection
            {
                get
                {
                    return this.dateOfInjectionField;
                }
                set
                {
                    this.dateOfInjectionField = value;
                }
            }

            /// <remarks/>
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class GeneralCaseCompositionVO
        {
            private VaccinationVO[] vaccinationField;

            private QuestionnaireVO[] questionnaireField;

            private GeneralActionReportVO[] procedureField;

            private LabRequestVO labRequestField;

            private TravelHistoryVO[] travelHistoryField;

            private DrugTreatmentReportVO[] drugTreatmentReportField;

            private AdverseReactionVO[] adverseReactionField;

            private BasicDeathDetailsVO deathField;

            private ClinicalFindingGeneralVO[] clinicalFindingField;

            private PhysicalExamVO[] physicalExamsField;

            private ObstetricHistoryVO obstetricHistoryField;

            private AbuseHistoryVO[] abuseHistoryField;

            private AdmissionVO admissionField;

            private DischargeVO dischargeField;

            private PMHVO[] pastMedicalHistoryField;

            private FamilyHistoryVO[] familyHistoryField;

            private ChiefComplaintVO chiefComplaintField;

            private LabTestResultVO[] labResultField;

            private ComplicationVO[] complicationField;

            private DiagnosisVO[] diagnosisField;

            private MedicationOrderedReportVO[] drugOrderedField;

            private InsuranceVO[] insuranceField;

            private DrugHistoryVO[] drugHistoryField;

            /// <remarks/>
            public VaccinationVO[] Vaccination
            {
                get
                {
                    return this.vaccinationField;
                }
                set
                {
                    this.vaccinationField = value;
                }
            }

            /// <remarks/>
            public QuestionnaireVO[] Questionnaire
            {
                get
                {
                    return this.questionnaireField;
                }
                set
                {
                    this.questionnaireField = value;
                }
            }

            /// <remarks/>
            public GeneralActionReportVO[] Procedure
            {
                get
                {
                    return this.procedureField;
                }
                set
                {
                    this.procedureField = value;
                }
            }

            /// <remarks/>
            public LabRequestVO LabRequest
            {
                get
                {
                    return this.labRequestField;
                }
                set
                {
                    this.labRequestField = value;
                }
            }

            /// <remarks/>
            public TravelHistoryVO[] TravelHistory
            {
                get
                {
                    return this.travelHistoryField;
                }
                set
                {
                    this.travelHistoryField = value;
                }
            }

            /// <remarks/>
            public DrugTreatmentReportVO[] DrugTreatmentReport
            {
                get
                {
                    return this.drugTreatmentReportField;
                }
                set
                {
                    this.drugTreatmentReportField = value;
                }
            }

            /// <remarks/>
            public AdverseReactionVO[] AdverseReaction
            {
                get
                {
                    return this.adverseReactionField;
                }
                set
                {
                    this.adverseReactionField = value;
                }
            }

            /// <remarks/>
            public BasicDeathDetailsVO Death
            {
                get
                {
                    return this.deathField;
                }
                set
                {
                    this.deathField = value;
                }
            }

            /// <remarks/>
            public ClinicalFindingGeneralVO[] ClinicalFinding
            {
                get
                {
                    return this.clinicalFindingField;
                }
                set
                {
                    this.clinicalFindingField = value;
                }
            }

            /// <remarks/>
            public PhysicalExamVO[] PhysicalExams
            {
                get
                {
                    return this.physicalExamsField;
                }
                set
                {
                    this.physicalExamsField = value;
                }
            }

            /// <remarks/>
            public ObstetricHistoryVO ObstetricHistory
            {
                get
                {
                    return this.obstetricHistoryField;
                }
                set
                {
                    this.obstetricHistoryField = value;
                }
            }

            /// <remarks/>
            public AbuseHistoryVO[] AbuseHistory
            {
                get
                {
                    return this.abuseHistoryField;
                }
                set
                {
                    this.abuseHistoryField = value;
                }
            }

            /// <remarks/>
            public AdmissionVO Admission
            {
                get
                {
                    return this.admissionField;
                }
                set
                {
                    this.admissionField = value;
                }
            }

            /// <remarks/>
            public DischargeVO Discharge
            {
                get
                {
                    return this.dischargeField;
                }
                set
                {
                    this.dischargeField = value;
                }
            }

            /// <remarks/>
            public PMHVO[] PastMedicalHistory
            {
                get
                {
                    return this.pastMedicalHistoryField;
                }
                set
                {
                    this.pastMedicalHistoryField = value;
                }
            }

            /// <remarks/>
            public FamilyHistoryVO[] FamilyHistory
            {
                get
                {
                    return this.familyHistoryField;
                }
                set
                {
                    this.familyHistoryField = value;
                }
            }

            /// <remarks/>
            public ChiefComplaintVO ChiefComplaint
            {
                get
                {
                    return this.chiefComplaintField;
                }
                set
                {
                    this.chiefComplaintField = value;
                }
            }

            /// <remarks/>
            public LabTestResultVO[] LabResult
            {
                get
                {
                    return this.labResultField;
                }
                set
                {
                    this.labResultField = value;
                }
            }

            /// <remarks/>
            public ComplicationVO[] Complication
            {
                get
                {
                    return this.complicationField;
                }
                set
                {
                    this.complicationField = value;
                }
            }

            /// <remarks/>
            public DiagnosisVO[] Diagnosis
            {
                get
                {
                    return this.diagnosisField;
                }
                set
                {
                    this.diagnosisField = value;
                }
            }

            /// <remarks/>
            public MedicationOrderedReportVO[] DrugOrdered
            {
                get
                {
                    return this.drugOrderedField;
                }
                set
                {
                    this.drugOrderedField = value;
                }
            }

            /// <remarks/>
            public InsuranceVO[] Insurance
            {
                get
                {
                    return this.insuranceField;
                }
                set
                {
                    this.insuranceField = value;
                }
            }

            /// <remarks/>
            public DrugHistoryVO[] DrugHistory
            {
                get
                {
                    return this.drugHistoryField;
                }
                set
                {
                    this.drugHistoryField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class LabRequestVO
        {
            private DO_DATE specimenDateField;

            private DO_TIME specimenTimeField;

            private DO_CODED_TEXT specimenTypeField;

            private string specimenCodeField;

            private SpecimenDetailsVO specimenField;

            /// <remarks/>
            public DO_DATE SpecimenDate
            {
                get
                {
                    return this.specimenDateField;
                }
                set
                {
                    this.specimenDateField = value;
                }
            }

            /// <remarks/>
            public DO_TIME SpecimenTime
            {
                get
                {
                    return this.specimenTimeField;
                }
                set
                {
                    this.specimenTimeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT SpecimenType
            {
                get
                {
                    return this.specimenTypeField;
                }
                set
                {
                    this.specimenTypeField = value;
                }
            }

            /// <remarks/>
            public string SpecimenCode
            {
                get
                {
                    return this.specimenCodeField;
                }
                set
                {
                    this.specimenCodeField = value;
                }
            }

            /// <remarks/>
            public SpecimenDetailsVO Specimen
            {
                get
                {
                    return this.specimenField;
                }
                set
                {
                    this.specimenField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class BasicDeathDetailsVO
        {
            private DO_DATE deathDateField;

            private DO_TIME deathTimeField;

            private DO_CODED_TEXT deathLocationField;

            private DO_CODED_TEXT hospitalWardField;

            private CauseVO[] causeField;

            /// <remarks/>
            public DO_DATE DeathDate
            {
                get
                {
                    return this.deathDateField;
                }
                set
                {
                    this.deathDateField = value;
                }
            }

            /// <remarks/>
            public DO_TIME DeathTime
            {
                get
                {
                    return this.deathTimeField;
                }
                set
                {
                    this.deathTimeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT DeathLocation
            {
                get
                {
                    return this.deathLocationField;
                }
                set
                {
                    this.deathLocationField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT HospitalWard
            {
                get
                {
                    return this.hospitalWardField;
                }
                set
                {
                    this.hospitalWardField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
            public CauseVO[] Cause
            {
                get
                {
                    return this.causeField;
                }
                set
                {
                    this.causeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class CauseVO
        {
            private DO_CODED_TEXT causeField;

            private DO_CODED_TEXT statusField;

            /// <remarks/>
            public DO_CODED_TEXT Cause
            {
                get
                {
                    return this.causeField;
                }
                set
                {
                    this.causeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class AbuseHistoryVO
        {
            private DO_QUANTITY abuseDurationField;

            private DO_CODED_TEXT substanceTypeField;

            private DO_QUANTITY amountOfAbuseField;

            private DO_DATE startDateField;

            private DO_DATE quitDateField;

            /// <remarks/>
            public DO_QUANTITY AbuseDuration
            {
                get
                {
                    return this.abuseDurationField;
                }
                set
                {
                    this.abuseDurationField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT SubstanceType
            {
                get
                {
                    return this.substanceTypeField;
                }
                set
                {
                    this.substanceTypeField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY AmountOfAbuse
            {
                get
                {
                    return this.amountOfAbuseField;
                }
                set
                {
                    this.amountOfAbuseField = value;
                }
            }

            /// <remarks/>
            public DO_DATE StartDate
            {
                get
                {
                    return this.startDateField;
                }
                set
                {
                    this.startDateField = value;
                }
            }

            /// <remarks/>
            public DO_DATE QuitDate
            {
                get
                {
                    return this.quitDateField;
                }
                set
                {
                    this.quitDateField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class DischargeVO
        {
            private DO_TIME dischargeTimeField;

            private DO_DATE dischargeDateField;

            private DO_CODED_TEXT conditionOnDischargeField;

            /// <remarks/>
            public DO_TIME DischargeTime
            {
                get
                {
                    return this.dischargeTimeField;
                }
                set
                {
                    this.dischargeTimeField = value;
                }
            }

            /// <remarks/>
            public DO_DATE DischargeDate
            {
                get
                {
                    return this.dischargeDateField;
                }
                set
                {
                    this.dischargeDateField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT ConditionOnDischarge
            {
                get
                {
                    return this.conditionOnDischargeField;
                }
                set
                {
                    this.conditionOnDischargeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class FamilyHistoryVO
        {
            private DO_CODED_TEXT conditionField;

            private string descriptionField;

            private DO_CODED_TEXT relatedPersonField;

            private System.Nullable<bool> is_CauseofDeathField;

            /// <remarks/>
            public DO_CODED_TEXT Condition
            {
                get
                {
                    return this.conditionField;
                }
                set
                {
                    this.conditionField = value;
                }
            }

            /// <remarks/>
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT RelatedPerson
            {
                get
                {
                    return this.relatedPersonField;
                }
                set
                {
                    this.relatedPersonField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<bool> Is_CauseofDeath
            {
                get
                {
                    return this.is_CauseofDeathField;
                }
                set
                {
                    this.is_CauseofDeathField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class MedicationOrderedReportVO
        {
            private System.Nullable<int> totalNumberField;

            private DO_CODED_TEXT sahpeField;

            private DO_DATE administrationDateField;

            private DO_TIME administrationTimeField;

            private DO_CODED_TEXT drugNameField;

            private string drugGenericNameField;

            private DO_QUANTITY dosageField;

            private DO_CODED_TEXT frequencyField;

            private DO_CODED_TEXT routeField;

            private DO_QUANTITY longTermField;

            private string descriptionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> totalNumber
            {
                get
                {
                    return this.totalNumberField;
                }
                set
                {
                    this.totalNumberField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Sahpe
            {
                get
                {
                    return this.sahpeField;
                }
                set
                {
                    this.sahpeField = value;
                }
            }

            /// <remarks/>
            public DO_DATE AdministrationDate
            {
                get
                {
                    return this.administrationDateField;
                }
                set
                {
                    this.administrationDateField = value;
                }
            }

            /// <remarks/>
            public DO_TIME AdministrationTime
            {
                get
                {
                    return this.administrationTimeField;
                }
                set
                {
                    this.administrationTimeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT DrugName
            {
                get
                {
                    return this.drugNameField;
                }
                set
                {
                    this.drugNameField = value;
                }
            }

            /// <remarks/>
            public string DrugGenericName
            {
                get
                {
                    return this.drugGenericNameField;
                }
                set
                {
                    this.drugGenericNameField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY Dosage
            {
                get
                {
                    return this.dosageField;
                }
                set
                {
                    this.dosageField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Frequency
            {
                get
                {
                    return this.frequencyField;
                }
                set
                {
                    this.frequencyField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Route
            {
                get
                {
                    return this.routeField;
                }
                set
                {
                    this.routeField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY LongTerm
            {
                get
                {
                    return this.longTermField;
                }
                set
                {
                    this.longTermField = value;
                }
            }

            /// <remarks/>
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class SOAPMessageVO
        {
            private PersonInfoVO personField;

            private MessageIdentifierVO msgIDField;

            private GeneralCaseCompositionVO compositionField;

            private System.Xml.Serialization.XmlSerializerNamespaces xmlnsField;

            /// <remarks/>
            public PersonInfoVO Person
            {
                get
                {
                    return this.personField;
                }
                set
                {
                    this.personField = value;
                }
            }

            /// <remarks/>
            public MessageIdentifierVO MsgID
            {
                get
                {
                    return this.msgIDField;
                }
                set
                {
                    this.msgIDField = value;
                }
            }

            /// <remarks/>
            public GeneralCaseCompositionVO Composition
            {
                get
                {
                    return this.compositionField;
                }
                set
                {
                    this.compositionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlNamespaceDeclarations()]
            public System.Xml.Serialization.XmlSerializerNamespaces xmlns
            {
                get
                {
                    return this.xmlnsField;
                }
                set
                {
                    this.xmlnsField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class TriageSummaryVO
        {
            private DO_CODED_TEXT triageSystemField;

            private string triageLevelField;

            private DO_DATE_TIME triageTimeField;

            private HealthcareProviderVO providerField;

            private DO_CODED_TEXT dispositionField;

            private DO_DATE_TIME dispositionTimeField;

            private DO_CODED_TEXT precautionTypeField;

            private string triageIDField;

            private string commentField;

            /// <remarks/>
            public DO_CODED_TEXT TriageSystem
            {
                get
                {
                    return this.triageSystemField;
                }
                set
                {
                    this.triageSystemField = value;
                }
            }

            /// <remarks/>
            public string TriageLevel
            {
                get
                {
                    return this.triageLevelField;
                }
                set
                {
                    this.triageLevelField = value;
                }
            }

            /// <remarks/>
            public DO_DATE_TIME TriageTime
            {
                get
                {
                    return this.triageTimeField;
                }
                set
                {
                    this.triageTimeField = value;
                }
            }

            /// <remarks/>
            public HealthcareProviderVO Provider
            {
                get
                {
                    return this.providerField;
                }
                set
                {
                    this.providerField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Disposition
            {
                get
                {
                    return this.dispositionField;
                }
                set
                {
                    this.dispositionField = value;
                }
            }

            /// <remarks/>
            public DO_DATE_TIME DispositionTime
            {
                get
                {
                    return this.dispositionTimeField;
                }
                set
                {
                    this.dispositionTimeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT PrecautionType
            {
                get
                {
                    return this.precautionTypeField;
                }
                set
                {
                    this.precautionTypeField = value;
                }
            }

            /// <remarks/>
            public string TriageID
            {
                get
                {
                    return this.triageIDField;
                }
                set
                {
                    this.triageIDField = value;
                }
            }

            /// <remarks/>
            public string Comment
            {
                get
                {
                    return this.commentField;
                }
                set
                {
                    this.commentField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class TriageEncounterVO
        {
            private ClinicalFindingGeneralVO[] clinicalFindingField;

            private ChiefComplaintVO chiefComplaintField;

            private PMHVO[] pMHField;

            private QuestionnaireVO[] questionnaireField;

            private TriageSummaryVO triageSummaryField;

            private DrugHistoryVO[] drugHistoryField;

            private AdverseReactionVO[] adverseReactionField;

            private VitalSignsVO vitalSignField;

            private BloodPressureVO bloodPressureField;

            private PulseOximetryVO pulseOximetryField;

            private BloodSugarVO bsField;

            private GeneralAssessmentVO[] assessmentField;

            /// <remarks/>
            public ClinicalFindingGeneralVO[] ClinicalFinding
            {
                get
                {
                    return this.clinicalFindingField;
                }
                set
                {
                    this.clinicalFindingField = value;
                }
            }

            /// <remarks/>
            public ChiefComplaintVO ChiefComplaint
            {
                get
                {
                    return this.chiefComplaintField;
                }
                set
                {
                    this.chiefComplaintField = value;
                }
            }

            /// <remarks/>
            public PMHVO[] PMH
            {
                get
                {
                    return this.pMHField;
                }
                set
                {
                    this.pMHField = value;
                }
            }

            /// <remarks/>
            public QuestionnaireVO[] Questionnaire
            {
                get
                {
                    return this.questionnaireField;
                }
                set
                {
                    this.questionnaireField = value;
                }
            }

            /// <remarks/>
            public TriageSummaryVO TriageSummary
            {
                get
                {
                    return this.triageSummaryField;
                }
                set
                {
                    this.triageSummaryField = value;
                }
            }

            /// <remarks/>
            public DrugHistoryVO[] DrugHistory
            {
                get
                {
                    return this.drugHistoryField;
                }
                set
                {
                    this.drugHistoryField = value;
                }
            }

            /// <remarks/>
            public AdverseReactionVO[] AdverseReaction
            {
                get
                {
                    return this.adverseReactionField;
                }
                set
                {
                    this.adverseReactionField = value;
                }
            }

            /// <remarks/>
            public VitalSignsVO VitalSign
            {
                get
                {
                    return this.vitalSignField;
                }
                set
                {
                    this.vitalSignField = value;
                }
            }

            /// <remarks/>
            public BloodPressureVO BloodPressure
            {
                get
                {
                    return this.bloodPressureField;
                }
                set
                {
                    this.bloodPressureField = value;
                }
            }

            /// <remarks/>
            public PulseOximetryVO PulseOximetry
            {
                get
                {
                    return this.pulseOximetryField;
                }
                set
                {
                    this.pulseOximetryField = value;
                }
            }

            /// <remarks/>
            public BloodSugarVO BS
            {
                get
                {
                    return this.bsField;
                }
                set
                {
                    this.bsField = value;
                }
            }

            /// <remarks/>
            public GeneralAssessmentVO[] Assessment
            {
                get
                {
                    return this.assessmentField;
                }
                set
                {
                    this.assessmentField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class AdmittedCompositionVO
        {
            private AdmissionVO admissionField;

            private InsuranceVO[] insuranceField;

            private DiagnosisVO[] diagnosisField;

            private TriageEncounterVO triageEncounterField;

            /// <remarks/>
            public AdmissionVO Admission
            {
                get
                {
                    return this.admissionField;
                }
                set
                {
                    this.admissionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
            public InsuranceVO[] Insurance
            {
                get
                {
                    return this.insuranceField;
                }
                set
                {
                    this.insuranceField = value;
                }
            }

            /// <remarks/>
            public DiagnosisVO[] Diagnosis
            {
                get
                {
                    return this.diagnosisField;
                }
                set
                {
                    this.diagnosisField = value;
                }
            }

            /// <remarks/>
            public TriageEncounterVO TriageEncounter
            {
                get
                {
                    return this.triageEncounterField;
                }
                set
                {
                    this.triageEncounterField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class AdmittedMessageVO
        {
            private PersonInfoVO personField;

            private MessageIdentifierVO msgIDField;

            private AdmittedCompositionVO compositionField;

            private System.Xml.Serialization.XmlSerializerNamespaces xmlnsField;

            /// <remarks/>
            public PersonInfoVO Person
            {
                get
                {
                    return this.personField;
                }
                set
                {
                    this.personField = value;
                }
            }

            /// <remarks/>
            public MessageIdentifierVO MsgID
            {
                get
                {
                    return this.msgIDField;
                }
                set
                {
                    this.msgIDField = value;
                }
            }

            /// <remarks/>
            public AdmittedCompositionVO Composition
            {
                get
                {
                    return this.compositionField;
                }
                set
                {
                    this.compositionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlNamespaceDeclarations()]
            public System.Xml.Serialization.XmlSerializerNamespaces xmlns
            {
                get
                {
                    return this.xmlnsField;
                }
                set
                {
                    this.xmlnsField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ReimbursementServiceDetailsVO
        {
            private InsuranceDeductionVO[] deductionField;

            private OrganizationVO extraLocationField;

            private DO_CODED_TEXT provisionMethodField;

            private ReimbursementServiceDetailsVO[] relatedServiceField;

            private string pKIDField;

            private RelativeCostVO[] relativeCostField;

            private QuantitiesVO[] otherCostsField;

            private DO_QUANTITY basicInsuranceContributionField;

            private string bedField;

            private DO_QUANTITY serviceCountField;

            private DO_QUANTITY patientContributionField;

            private string roomField;

            private DO_CODED_TEXT serviceField;

            private DO_DATE startDateField;

            private DO_TIME startTimeField;

            private DO_DATE endDateField;

            private DO_TIME endTimeField;

            private DO_CODED_TEXT serviceTypeField;

            private DO_QUANTITY totalChargeField;

            private DO_CODED_TEXT wardTypeField;

            private string wardNameField;

            private HealthcareProviderVO serviceProviderField;

            /// <remarks/>
            public InsuranceDeductionVO[] Deduction
            {
                get
                {
                    return this.deductionField;
                }
                set
                {
                    this.deductionField = value;
                }
            }

            /// <remarks/>
            public OrganizationVO ExtraLocation
            {
                get
                {
                    return this.extraLocationField;
                }
                set
                {
                    this.extraLocationField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT ProvisionMethod
            {
                get
                {
                    return this.provisionMethodField;
                }
                set
                {
                    this.provisionMethodField = value;
                }
            }

            /// <remarks/>
            public ReimbursementServiceDetailsVO[] RelatedService
            {
                get
                {
                    return this.relatedServiceField;
                }
                set
                {
                    this.relatedServiceField = value;
                }
            }

            /// <remarks/>
            public string PKID
            {
                get
                {
                    return this.pKIDField;
                }
                set
                {
                    this.pKIDField = value;
                }
            }

            /// <remarks/>
            public RelativeCostVO[] RelativeCost
            {
                get
                {
                    return this.relativeCostField;
                }
                set
                {
                    this.relativeCostField = value;
                }
            }

            /// <remarks/>
            public QuantitiesVO[] OtherCosts
            {
                get
                {
                    return this.otherCostsField;
                }
                set
                {
                    this.otherCostsField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY BasicInsuranceContribution
            {
                get
                {
                    return this.basicInsuranceContributionField;
                }
                set
                {
                    this.basicInsuranceContributionField = value;
                }
            }

            /// <remarks/>
            public string Bed
            {
                get
                {
                    return this.bedField;
                }
                set
                {
                    this.bedField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY ServiceCount
            {
                get
                {
                    return this.serviceCountField;
                }
                set
                {
                    this.serviceCountField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY PatientContribution
            {
                get
                {
                    return this.patientContributionField;
                }
                set
                {
                    this.patientContributionField = value;
                }
            }

            /// <remarks/>
            public string Room
            {
                get
                {
                    return this.roomField;
                }
                set
                {
                    this.roomField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Service
            {
                get
                {
                    return this.serviceField;
                }
                set
                {
                    this.serviceField = value;
                }
            }

            /// <remarks/>
            public DO_DATE StartDate
            {
                get
                {
                    return this.startDateField;
                }
                set
                {
                    this.startDateField = value;
                }
            }

            /// <remarks/>
            public DO_TIME StartTime
            {
                get
                {
                    return this.startTimeField;
                }
                set
                {
                    this.startTimeField = value;
                }
            }

            /// <remarks/>
            public DO_DATE EndDate
            {
                get
                {
                    return this.endDateField;
                }
                set
                {
                    this.endDateField = value;
                }
            }

            /// <remarks/>
            public DO_TIME EndTime
            {
                get
                {
                    return this.endTimeField;
                }
                set
                {
                    this.endTimeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT ServiceType
            {
                get
                {
                    return this.serviceTypeField;
                }
                set
                {
                    this.serviceTypeField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY TotalCharge
            {
                get
                {
                    return this.totalChargeField;
                }
                set
                {
                    this.totalChargeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT WardType
            {
                get
                {
                    return this.wardTypeField;
                }
                set
                {
                    this.wardTypeField = value;
                }
            }

            /// <remarks/>
            public string WardName
            {
                get
                {
                    return this.wardNameField;
                }
                set
                {
                    this.wardNameField = value;
                }
            }

            /// <remarks/>
            public HealthcareProviderVO ServiceProvider
            {
                get
                {
                    return this.serviceProviderField;
                }
                set
                {
                    this.serviceProviderField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class InsuranceDeductionVO
        {
            private DO_QUANTITY deductionField;

            private DO_CODED_TEXT deductionTypeField;

            private DO_IDENTIFIER ruleIDField;

            private string deductionDescriptionField;

            /// <remarks/>
            public DO_QUANTITY Deduction
            {
                get
                {
                    return this.deductionField;
                }
                set
                {
                    this.deductionField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT DeductionType
            {
                get
                {
                    return this.deductionTypeField;
                }
                set
                {
                    this.deductionTypeField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER RuleID
            {
                get
                {
                    return this.ruleIDField;
                }
                set
                {
                    this.ruleIDField = value;
                }
            }

            /// <remarks/>
            public string DeductionDescription
            {
                get
                {
                    return this.deductionDescriptionField;
                }
                set
                {
                    this.deductionDescriptionField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ReimbursementServiceGroupRowVO
        {
            private InsuranceDeductionVO deductionField;

            private DO_QUANTITY patientContributionField;

            private QuantitiesVO[] otherCostsField;

            private DO_QUANTITY basicInsuranceContributionField;

            private DO_QUANTITY serviceCountField;

            private DO_CODED_TEXT serviceTypeField;

            private DO_QUANTITY totalChargeField;

            /// <remarks/>
            public InsuranceDeductionVO Deduction
            {
                get
                {
                    return this.deductionField;
                }
                set
                {
                    this.deductionField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY PatientContribution
            {
                get
                {
                    return this.patientContributionField;
                }
                set
                {
                    this.patientContributionField = value;
                }
            }

            /// <remarks/>
            public QuantitiesVO[] OtherCosts
            {
                get
                {
                    return this.otherCostsField;
                }
                set
                {
                    this.otherCostsField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY BasicInsuranceContribution
            {
                get
                {
                    return this.basicInsuranceContributionField;
                }
                set
                {
                    this.basicInsuranceContributionField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY ServiceCount
            {
                get
                {
                    return this.serviceCountField;
                }
                set
                {
                    this.serviceCountField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT ServiceType
            {
                get
                {
                    return this.serviceTypeField;
                }
                set
                {
                    this.serviceTypeField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY TotalCharge
            {
                get
                {
                    return this.totalChargeField;
                }
                set
                {
                    this.totalChargeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ReimbursementSummaryVO
        {
            private InsuranceDeductionVO totalDeductionField;

            private QuantitiesVO[] totalOtherCostsField;

            private DO_CODED_TEXT insurerField;

            private DO_CODED_TEXT insurerBoxField;

            private DO_QUANTITY totalBasicInsuranceContributionField;

            private int hospitalAccreditationField;

            private DO_CODED_TEXT medicalRecordTypeField;

            private DO_CODED_TEXT globalPackageField;

            private DO_QUANTITY totalPatientContributionField;

            private DO_QUANTITY totalChargeField;

            private ReimbursementServiceGroupRowVO[] reimbursementServiceGroupRowField;

            /// <remarks/>
            public InsuranceDeductionVO TotalDeduction
            {
                get
                {
                    return this.totalDeductionField;
                }
                set
                {
                    this.totalDeductionField = value;
                }
            }

            /// <remarks/>
            public QuantitiesVO[] TotalOtherCosts
            {
                get
                {
                    return this.totalOtherCostsField;
                }
                set
                {
                    this.totalOtherCostsField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Insurer
            {
                get
                {
                    return this.insurerField;
                }
                set
                {
                    this.insurerField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT InsurerBox
            {
                get
                {
                    return this.insurerBoxField;
                }
                set
                {
                    this.insurerBoxField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY TotalBasicInsuranceContribution
            {
                get
                {
                    return this.totalBasicInsuranceContributionField;
                }
                set
                {
                    this.totalBasicInsuranceContributionField = value;
                }
            }

            /// <remarks/>
            public int HospitalAccreditation
            {
                get
                {
                    return this.hospitalAccreditationField;
                }
                set
                {
                    this.hospitalAccreditationField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT MedicalRecordType
            {
                get
                {
                    return this.medicalRecordTypeField;
                }
                set
                {
                    this.medicalRecordTypeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT GlobalPackage
            {
                get
                {
                    return this.globalPackageField;
                }
                set
                {
                    this.globalPackageField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY TotalPatientContribution
            {
                get
                {
                    return this.totalPatientContributionField;
                }
                set
                {
                    this.totalPatientContributionField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY TotalCharge
            {
                get
                {
                    return this.totalChargeField;
                }
                set
                {
                    this.totalChargeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
            public ReimbursementServiceGroupRowVO[] ReimbursementServiceGroupRow
            {
                get
                {
                    return this.reimbursementServiceGroupRowField;
                }
                set
                {
                    this.reimbursementServiceGroupRowField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class InsurerReimbursementCompositionVO
        {
            private AdmissionVO admissionField;

            private DischargeVO dischargeField;

            private ReimbursementSummaryVO reimbursementSummaryField;

            private ReimbursementServiceDetailsVO[] reimbursementServicesField;

            private InsuranceVO[] insuranceField;

            private BasicDeathDetailsVO deathField;

            private DiagnosisVO[] diagnosisField;

            /// <remarks/>
            public AdmissionVO Admission
            {
                get
                {
                    return this.admissionField;
                }
                set
                {
                    this.admissionField = value;
                }
            }

            /// <remarks/>
            public DischargeVO Discharge
            {
                get
                {
                    return this.dischargeField;
                }
                set
                {
                    this.dischargeField = value;
                }
            }

            /// <remarks/>
            public ReimbursementSummaryVO ReimbursementSummary
            {
                get
                {
                    return this.reimbursementSummaryField;
                }
                set
                {
                    this.reimbursementSummaryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
            public ReimbursementServiceDetailsVO[] ReimbursementServices
            {
                get
                {
                    return this.reimbursementServicesField;
                }
                set
                {
                    this.reimbursementServicesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
            public InsuranceVO[] Insurance
            {
                get
                {
                    return this.insuranceField;
                }
                set
                {
                    this.insuranceField = value;
                }
            }

            /// <remarks/>
            public BasicDeathDetailsVO Death
            {
                get
                {
                    return this.deathField;
                }
                set
                {
                    this.deathField = value;
                }
            }

            /// <remarks/>
            public DiagnosisVO[] Diagnosis
            {
                get
                {
                    return this.diagnosisField;
                }
                set
                {
                    this.diagnosisField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class InsurerReimbursementMessageVO
        {
            private PersonInfoVO personField;

            private MessageIdentifierVO msgIDField;

            private InsurerReimbursementCompositionVO compositionField;

            private System.Xml.Serialization.XmlSerializerNamespaces xmlnsField;

            /// <remarks/>
            public PersonInfoVO Person
            {
                get
                {
                    return this.personField;
                }
                set
                {
                    this.personField = value;
                }
            }

            /// <remarks/>
            public MessageIdentifierVO MsgID
            {
                get
                {
                    return this.msgIDField;
                }
                set
                {
                    this.msgIDField = value;
                }
            }

            /// <remarks/>
            public InsurerReimbursementCompositionVO Composition
            {
                get
                {
                    return this.compositionField;
                }
                set
                {
                    this.compositionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlNamespaceDeclarations()]
            public System.Xml.Serialization.XmlSerializerNamespaces xmlns
            {
                get
                {
                    return this.xmlnsField;
                }
                set
                {
                    this.xmlnsField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ServiceGroupRowVO
        {
            private DO_QUANTITY patientContributionField;

            private QuantitiesVO[] otherCostsField;

            private DO_QUANTITY basicInsuranceContributionField;

            private DO_QUANTITY serviceCountField;

            private DO_CODED_TEXT serviceTypeField;

            private DO_QUANTITY totalChargeField;

            /// <remarks/>
            public DO_QUANTITY PatientContribution
            {
                get
                {
                    return this.patientContributionField;
                }
                set
                {
                    this.patientContributionField = value;
                }
            }

            /// <remarks/>
            public QuantitiesVO[] OtherCosts
            {
                get
                {
                    return this.otherCostsField;
                }
                set
                {
                    this.otherCostsField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY BasicInsuranceContribution
            {
                get
                {
                    return this.basicInsuranceContributionField;
                }
                set
                {
                    this.basicInsuranceContributionField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY ServiceCount
            {
                get
                {
                    return this.serviceCountField;
                }
                set
                {
                    this.serviceCountField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT ServiceType
            {
                get
                {
                    return this.serviceTypeField;
                }
                set
                {
                    this.serviceTypeField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY TotalCharge
            {
                get
                {
                    return this.totalChargeField;
                }
                set
                {
                    this.totalChargeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class BillSummaryVO
        {
            private QuantitiesVO[] totalOtherCostsField;

            private DO_CODED_TEXT insurerField;

            private DO_CODED_TEXT insurerBoxField;

            private DO_QUANTITY totalBasicInsuranceContributionField;

            private int hospitalAccreditationField;

            private DO_CODED_TEXT medicalRecordTypeField;

            private DO_CODED_TEXT globalPackageField;

            private DO_QUANTITY totalPatientContributionField;

            private DO_QUANTITY totalChargeField;

            private ServiceGroupRowVO[] serviceGroupRowField;

            /// <remarks/>
            public QuantitiesVO[] TotalOtherCosts
            {
                get
                {
                    return this.totalOtherCostsField;
                }
                set
                {
                    this.totalOtherCostsField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Insurer
            {
                get
                {
                    return this.insurerField;
                }
                set
                {
                    this.insurerField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT InsurerBox
            {
                get
                {
                    return this.insurerBoxField;
                }
                set
                {
                    this.insurerBoxField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY TotalBasicInsuranceContribution
            {
                get
                {
                    return this.totalBasicInsuranceContributionField;
                }
                set
                {
                    this.totalBasicInsuranceContributionField = value;
                }
            }

            /// <remarks/>
            public int HospitalAccreditation
            {
                get
                {
                    return this.hospitalAccreditationField;
                }
                set
                {
                    this.hospitalAccreditationField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT MedicalRecordType
            {
                get
                {
                    return this.medicalRecordTypeField;
                }
                set
                {
                    this.medicalRecordTypeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT GlobalPackage
            {
                get
                {
                    return this.globalPackageField;
                }
                set
                {
                    this.globalPackageField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY TotalPatientContribution
            {
                get
                {
                    return this.totalPatientContributionField;
                }
                set
                {
                    this.totalPatientContributionField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY TotalCharge
            {
                get
                {
                    return this.totalChargeField;
                }
                set
                {
                    this.totalChargeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
            public ServiceGroupRowVO[] ServiceGroupRow
            {
                get
                {
                    return this.serviceGroupRowField;
                }
                set
                {
                    this.serviceGroupRowField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class BillPatientCompositionVO
        {
            private AdmissionVO admissionField;

            private DischargeVO dischargeField;

            private BillSummaryVO billSummaryField;

            private ServiceDetailsVO[] billServicesField;

            private InsuranceVO[] insuranceField;

            private BasicDeathDetailsVO deathField;

            private DiagnosisVO[] diagnosisField;

            /// <remarks/>
            public AdmissionVO Admission
            {
                get
                {
                    return this.admissionField;
                }
                set
                {
                    this.admissionField = value;
                }
            }

            /// <remarks/>
            public DischargeVO Discharge
            {
                get
                {
                    return this.dischargeField;
                }
                set
                {
                    this.dischargeField = value;
                }
            }

            /// <remarks/>
            public BillSummaryVO BillSummary
            {
                get
                {
                    return this.billSummaryField;
                }
                set
                {
                    this.billSummaryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
            public ServiceDetailsVO[] BillServices
            {
                get
                {
                    return this.billServicesField;
                }
                set
                {
                    this.billServicesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
            public InsuranceVO[] Insurance
            {
                get
                {
                    return this.insuranceField;
                }
                set
                {
                    this.insuranceField = value;
                }
            }

            /// <remarks/>
            public BasicDeathDetailsVO Death
            {
                get
                {
                    return this.deathField;
                }
                set
                {
                    this.deathField = value;
                }
            }

            /// <remarks/>
            public DiagnosisVO[] Diagnosis
            {
                get
                {
                    return this.diagnosisField;
                }
                set
                {
                    this.diagnosisField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ServiceDetailsVO
        {
            private string batchNumberField;

            private OrganizationVO extraLocationField;

            private ServiceDetailsVO[] relatedServiceField;

            private DO_CODED_TEXT provisionMethodField;

            private DO_IDENTIFIER confirmationIDField;

            private HealthcareProviderVO[] otherParticipationField;

            private string pKIDField;

            private RelativeCostVO[] relativeCostField;

            private QuantitiesVO[] otherCostsField;

            private DO_QUANTITY basicInsuranceContributionField;

            private string bedField;

            private DO_QUANTITY serviceCountField;

            private DO_QUANTITY patientContributionField;

            private string roomField;

            private DO_CODED_TEXT serviceField;

            private DO_DATE startDateField;

            private DO_TIME startTimeField;

            private DO_DATE endDateField;

            private DO_TIME endTimeField;

            private DO_CODED_TEXT serviceTypeField;

            private DO_QUANTITY totalChargeField;

            private DO_CODED_TEXT wardTypeField;

            private string wardNameField;

            private HealthcareProviderVO serviceProviderField;

            /// <remarks/>
            public string BatchNumber
            {
                get
                {
                    return this.batchNumberField;
                }
                set
                {
                    this.batchNumberField = value;
                }
            }

            /// <remarks/>
            public OrganizationVO ExtraLocation
            {
                get
                {
                    return this.extraLocationField;
                }
                set
                {
                    this.extraLocationField = value;
                }
            }

            /// <remarks/>
            public ServiceDetailsVO[] RelatedService
            {
                get
                {
                    return this.relatedServiceField;
                }
                set
                {
                    this.relatedServiceField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT ProvisionMethod
            {
                get
                {
                    return this.provisionMethodField;
                }
                set
                {
                    this.provisionMethodField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER ConfirmationID
            {
                get
                {
                    return this.confirmationIDField;
                }
                set
                {
                    this.confirmationIDField = value;
                }
            }

            /// <remarks/>
            public HealthcareProviderVO[] OtherParticipation
            {
                get
                {
                    return this.otherParticipationField;
                }
                set
                {
                    this.otherParticipationField = value;
                }
            }

            /// <remarks/>
            public string PKID
            {
                get
                {
                    return this.pKIDField;
                }
                set
                {
                    this.pKIDField = value;
                }
            }

            /// <remarks/>
            public RelativeCostVO[] RelativeCost
            {
                get
                {
                    return this.relativeCostField;
                }
                set
                {
                    this.relativeCostField = value;
                }
            }

            /// <remarks/>
            public QuantitiesVO[] OtherCosts
            {
                get
                {
                    return this.otherCostsField;
                }
                set
                {
                    this.otherCostsField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY BasicInsuranceContribution
            {
                get
                {
                    return this.basicInsuranceContributionField;
                }
                set
                {
                    this.basicInsuranceContributionField = value;
                }
            }

            /// <remarks/>
            public string Bed
            {
                get
                {
                    return this.bedField;
                }
                set
                {
                    this.bedField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY ServiceCount
            {
                get
                {
                    return this.serviceCountField;
                }
                set
                {
                    this.serviceCountField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY PatientContribution
            {
                get
                {
                    return this.patientContributionField;
                }
                set
                {
                    this.patientContributionField = value;
                }
            }

            /// <remarks/>
            public string Room
            {
                get
                {
                    return this.roomField;
                }
                set
                {
                    this.roomField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Service
            {
                get
                {
                    return this.serviceField;
                }
                set
                {
                    this.serviceField = value;
                }
            }

            /// <remarks/>
            public DO_DATE StartDate
            {
                get
                {
                    return this.startDateField;
                }
                set
                {
                    this.startDateField = value;
                }
            }

            /// <remarks/>
            public DO_TIME StartTime
            {
                get
                {
                    return this.startTimeField;
                }
                set
                {
                    this.startTimeField = value;
                }
            }

            /// <remarks/>
            public DO_DATE EndDate
            {
                get
                {
                    return this.endDateField;
                }
                set
                {
                    this.endDateField = value;
                }
            }

            /// <remarks/>
            public DO_TIME EndTime
            {
                get
                {
                    return this.endTimeField;
                }
                set
                {
                    this.endTimeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT ServiceType
            {
                get
                {
                    return this.serviceTypeField;
                }
                set
                {
                    this.serviceTypeField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY TotalCharge
            {
                get
                {
                    return this.totalChargeField;
                }
                set
                {
                    this.totalChargeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT WardType
            {
                get
                {
                    return this.wardTypeField;
                }
                set
                {
                    this.wardTypeField = value;
                }
            }

            /// <remarks/>
            public string WardName
            {
                get
                {
                    return this.wardNameField;
                }
                set
                {
                    this.wardNameField = value;
                }
            }

            /// <remarks/>
            public HealthcareProviderVO ServiceProvider
            {
                get
                {
                    return this.serviceProviderField;
                }
                set
                {
                    this.serviceProviderField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class PatientBillMessageVO
        {
            private PersonInfoVO personField;

            private MessageIdentifierVO msgIDField;

            private BillPatientCompositionVO compositionField;

            private System.Xml.Serialization.XmlSerializerNamespaces xmlnsField;

            /// <remarks/>
            public PersonInfoVO Person
            {
                get
                {
                    return this.personField;
                }
                set
                {
                    this.personField = value;
                }
            }

            /// <remarks/>
            public MessageIdentifierVO MsgID
            {
                get
                {
                    return this.msgIDField;
                }
                set
                {
                    this.msgIDField = value;
                }
            }

            /// <remarks/>
            public BillPatientCompositionVO Composition
            {
                get
                {
                    return this.compositionField;
                }
                set
                {
                    this.compositionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlNamespaceDeclarations()]
            public System.Xml.Serialization.XmlSerializerNamespaces xmlns
            {
                get
                {
                    return this.xmlnsField;
                }
                set
                {
                    this.xmlnsField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class InfantDeliveryVO
        {
            private DO_QUANTITY infantWeightField;

            private System.Nullable<int> deliveryPriorityField;

            private DO_CODED_TEXT deliveryAgentField;

            private DO_CODED_TEXT deliveryLocationField;

            private System.Nullable<int> deliveryNumberField;

            /// <remarks/>
            public DO_QUANTITY InfantWeight
            {
                get
                {
                    return this.infantWeightField;
                }
                set
                {
                    this.infantWeightField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> DeliveryPriority
            {
                get
                {
                    return this.deliveryPriorityField;
                }
                set
                {
                    this.deliveryPriorityField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT DeliveryAgent
            {
                get
                {
                    return this.deliveryAgentField;
                }
                set
                {
                    this.deliveryAgentField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT DeliveryLocation
            {
                get
                {
                    return this.deliveryLocationField;
                }
                set
                {
                    this.deliveryLocationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> DeliveryNumber
            {
                get
                {
                    return this.deliveryNumberField;
                }
                set
                {
                    this.deliveryNumberField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class DeathCauseVO
        {
            private DO_QUANTITY duration2DeathField;

            private DO_CODED_TEXT causeField;

            private DO_CODED_TEXT statusField;

            /// <remarks/>
            public DO_QUANTITY Duration2Death
            {
                get
                {
                    return this.duration2DeathField;
                }
                set
                {
                    this.duration2DeathField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Cause
            {
                get
                {
                    return this.causeField;
                }
                set
                {
                    this.causeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class DeathCertificateCompositionVO
        {
            private string householdHeadNationalcodeField;

            private DO_CODED_TEXT livingLocationTypeField;

            private DO_CODED_TEXT sourceOfNotificationField;

            private OrganizationVO organizationRegistrerField;

            private DO_DATE certificateIssueDateField;

            private HighLevelAreaVO deathAreaField;

            private HealthcareProviderVO individualRegistrerField;

            private HealthcareProviderVO burialAttesterDetailsField;

            private string certificateSerialNumberField;

            private string commentField;

            private DO_DATE deathDateField;

            private DO_TIME deathTimeField;

            private DO_CODED_TEXT deathLocationField;

            private DeathCauseVO[] causeOfDeathField;

            private PMHVO[] relatedConditionField;

            private PersonInfoVO motherField;

            private InfantDeliveryVO infantDeliveryInfoField;

            /// <remarks/>
            public string HouseholdHeadNationalcode
            {
                get
                {
                    return this.householdHeadNationalcodeField;
                }
                set
                {
                    this.householdHeadNationalcodeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT LivingLocationType
            {
                get
                {
                    return this.livingLocationTypeField;
                }
                set
                {
                    this.livingLocationTypeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT SourceOfNotification
            {
                get
                {
                    return this.sourceOfNotificationField;
                }
                set
                {
                    this.sourceOfNotificationField = value;
                }
            }

            /// <remarks/>
            public OrganizationVO OrganizationRegistrer
            {
                get
                {
                    return this.organizationRegistrerField;
                }
                set
                {
                    this.organizationRegistrerField = value;
                }
            }

            /// <remarks/>
            public DO_DATE CertificateIssueDate
            {
                get
                {
                    return this.certificateIssueDateField;
                }
                set
                {
                    this.certificateIssueDateField = value;
                }
            }

            /// <remarks/>
            public HighLevelAreaVO DeathArea
            {
                get
                {
                    return this.deathAreaField;
                }
                set
                {
                    this.deathAreaField = value;
                }
            }

            /// <remarks/>
            public HealthcareProviderVO IndividualRegistrer
            {
                get
                {
                    return this.individualRegistrerField;
                }
                set
                {
                    this.individualRegistrerField = value;
                }
            }

            /// <remarks/>
            public HealthcareProviderVO BurialAttesterDetails
            {
                get
                {
                    return this.burialAttesterDetailsField;
                }
                set
                {
                    this.burialAttesterDetailsField = value;
                }
            }

            /// <remarks/>
            public string CertificateSerialNumber
            {
                get
                {
                    return this.certificateSerialNumberField;
                }
                set
                {
                    this.certificateSerialNumberField = value;
                }
            }

            /// <remarks/>
            public string Comment
            {
                get
                {
                    return this.commentField;
                }
                set
                {
                    this.commentField = value;
                }
            }

            /// <remarks/>
            public DO_DATE DeathDate
            {
                get
                {
                    return this.deathDateField;
                }
                set
                {
                    this.deathDateField = value;
                }
            }

            /// <remarks/>
            public DO_TIME DeathTime
            {
                get
                {
                    return this.deathTimeField;
                }
                set
                {
                    this.deathTimeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT DeathLocation
            {
                get
                {
                    return this.deathLocationField;
                }
                set
                {
                    this.deathLocationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItem(IsNullable = false)]
            public DeathCauseVO[] CauseOfDeath
            {
                get
                {
                    return this.causeOfDeathField;
                }
                set
                {
                    this.causeOfDeathField = value;
                }
            }

            /// <remarks/>
            public PMHVO[] relatedCondition
            {
                get
                {
                    return this.relatedConditionField;
                }
                set
                {
                    this.relatedConditionField = value;
                }
            }

            /// <remarks/>
            public PersonInfoVO Mother
            {
                get
                {
                    return this.motherField;
                }
                set
                {
                    this.motherField = value;
                }
            }

            /// <remarks/>
            public InfantDeliveryVO InfantDeliveryInfo
            {
                get
                {
                    return this.infantDeliveryInfoField;
                }
                set
                {
                    this.infantDeliveryInfoField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class DeathCertificateMessageVO
        {
            private PersonInfoVO personField;

            private MessageIdentifierVO msgIDField;

            private DeathCertificateCompositionVO compositionField;

            /// <remarks/>
            public PersonInfoVO Person
            {
                get
                {
                    return this.personField;
                }
                set
                {
                    this.personField = value;
                }
            }

            /// <remarks/>
            public MessageIdentifierVO MsgID
            {
                get
                {
                    return this.msgIDField;
                }
                set
                {
                    this.msgIDField = value;
                }
            }

            /// <remarks/>
            public DeathCertificateCompositionVO Composition
            {
                get
                {
                    return this.compositionField;
                }
                set
                {
                    this.compositionField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class LaboratoryResultCompositionVO
        {
            private LabRequestVO labRequestField;

            private AdmissionVO admissionField;

            private LabTestResultVO[] labResultField;

            private DiagnosisVO[] diagnosisField;

            private InsuranceVO[] insuranceField;

            /// <remarks/>
            public LabRequestVO LabRequest
            {
                get
                {
                    return this.labRequestField;
                }
                set
                {
                    this.labRequestField = value;
                }
            }

            /// <remarks/>
            public AdmissionVO Admission
            {
                get
                {
                    return this.admissionField;
                }
                set
                {
                    this.admissionField = value;
                }
            }

            /// <remarks/>
            public LabTestResultVO[] LabResult
            {
                get
                {
                    return this.labResultField;
                }
                set
                {
                    this.labResultField = value;
                }
            }

            /// <remarks/>
            public DiagnosisVO[] Diagnosis
            {
                get
                {
                    return this.diagnosisField;
                }
                set
                {
                    this.diagnosisField = value;
                }
            }

            /// <remarks/>
            public InsuranceVO[] Insurance
            {
                get
                {
                    return this.insuranceField;
                }
                set
                {
                    this.insuranceField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class LaboratoryResultMessageVO
        {
            private PersonInfoVO personField;

            private MessageIdentifierVO msgIDField;

            private LaboratoryResultCompositionVO compositionField;

            private System.Xml.Serialization.XmlSerializerNamespaces xmlnsField;

            /// <remarks/>
            public PersonInfoVO Person
            {
                get
                {
                    return this.personField;
                }
                set
                {
                    this.personField = value;
                }
            }

            /// <remarks/>
            public MessageIdentifierVO MsgID
            {
                get
                {
                    return this.msgIDField;
                }
                set
                {
                    this.msgIDField = value;
                }
            }

            /// <remarks/>
            public LaboratoryResultCompositionVO Composition
            {
                get
                {
                    return this.compositionField;
                }
                set
                {
                    this.compositionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlNamespaceDeclarations()]
            public System.Xml.Serialization.XmlSerializerNamespaces xmlns
            {
                get
                {
                    return this.xmlnsField;
                }
                set
                {
                    this.xmlnsField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class DentalDiagnosisVO
        {
            private ToothVO toothField;

            private DiagnosisVO[] diagnosisField;

            private string commentField;

            /// <remarks/>
            public ToothVO Tooth
            {
                get
                {
                    return this.toothField;
                }
                set
                {
                    this.toothField = value;
                }
            }

            /// <remarks/>
            public DiagnosisVO[] Diagnosis
            {
                get
                {
                    return this.diagnosisField;
                }
                set
                {
                    this.diagnosisField = value;
                }
            }

            /// <remarks/>
            public string Comment
            {
                get
                {
                    return this.commentField;
                }
                set
                {
                    this.commentField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ToothVO
        {
            private DO_CODED_TEXT toothNameField;

            private DO_CODED_TEXT partField;

            private DO_CODED_TEXT segmentField;

            private System.Nullable<bool> isMissingToothField;

            /// <remarks/>
            public DO_CODED_TEXT ToothName
            {
                get
                {
                    return this.toothNameField;
                }
                set
                {
                    this.toothNameField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Part
            {
                get
                {
                    return this.partField;
                }
                set
                {
                    this.partField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Segment
            {
                get
                {
                    return this.segmentField;
                }
                set
                {
                    this.segmentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<bool> IsMissingTooth
            {
                get
                {
                    return this.isMissingToothField;
                }
                set
                {
                    this.isMissingToothField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class DentalTreatmentVO
        {
            private ToothVO toothField;

            private ServiceDetailsVO[] treatmentField;

            private string commentField;

            /// <remarks/>
            public ToothVO Tooth
            {
                get
                {
                    return this.toothField;
                }
                set
                {
                    this.toothField = value;
                }
            }

            /// <remarks/>
            public ServiceDetailsVO[] Treatment
            {
                get
                {
                    return this.treatmentField;
                }
                set
                {
                    this.treatmentField = value;
                }
            }

            /// <remarks/>
            public string Comment
            {
                get
                {
                    return this.commentField;
                }
                set
                {
                    this.commentField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class DentalCompositionVO
        {
            private DentalTreatmentVO[] dentalTreatmentField;

            private DentalDiagnosisVO[] dentalDiagnosisField;

            private AbuseHistoryVO[] abuseHistoryField;

            private AdmissionVO admissionField;

            private PMHVO[] pastMedicalHistoryField;

            private FamilyHistoryVO[] familyHistoryField;

            private DiagnosisVO[] diagnosisField;

            private MedicationOrderedReportVO[] drugOrderedField;

            private InsuranceVO[] insuranceField;

            private DrugHistoryVO[] drugHistoryField;

            private AdverseReactionVO[] adverseReactionField;

            /// <remarks/>
            public DentalTreatmentVO[] DentalTreatment
            {
                get
                {
                    return this.dentalTreatmentField;
                }
                set
                {
                    this.dentalTreatmentField = value;
                }
            }

            /// <remarks/>
            public DentalDiagnosisVO[] DentalDiagnosis
            {
                get
                {
                    return this.dentalDiagnosisField;
                }
                set
                {
                    this.dentalDiagnosisField = value;
                }
            }

            /// <remarks/>
            public AbuseHistoryVO[] AbuseHistory
            {
                get
                {
                    return this.abuseHistoryField;
                }
                set
                {
                    this.abuseHistoryField = value;
                }
            }

            /// <remarks/>
            public AdmissionVO Admission
            {
                get
                {
                    return this.admissionField;
                }
                set
                {
                    this.admissionField = value;
                }
            }

            /// <remarks/>
            public PMHVO[] PastMedicalHistory
            {
                get
                {
                    return this.pastMedicalHistoryField;
                }
                set
                {
                    this.pastMedicalHistoryField = value;
                }
            }

            /// <remarks/>
            public FamilyHistoryVO[] FamilyHistory
            {
                get
                {
                    return this.familyHistoryField;
                }
                set
                {
                    this.familyHistoryField = value;
                }
            }

            /// <remarks/>
            public DiagnosisVO[] Diagnosis
            {
                get
                {
                    return this.diagnosisField;
                }
                set
                {
                    this.diagnosisField = value;
                }
            }

            /// <remarks/>
            public MedicationOrderedReportVO[] DrugOrdered
            {
                get
                {
                    return this.drugOrderedField;
                }
                set
                {
                    this.drugOrderedField = value;
                }
            }

            /// <remarks/>
            public InsuranceVO[] Insurance
            {
                get
                {
                    return this.insuranceField;
                }
                set
                {
                    this.insuranceField = value;
                }
            }

            /// <remarks/>
            public DrugHistoryVO[] DrugHistory
            {
                get
                {
                    return this.drugHistoryField;
                }
                set
                {
                    this.drugHistoryField = value;
                }
            }

            /// <remarks/>
            public AdverseReactionVO[] AdverseReaction
            {
                get
                {
                    return this.adverseReactionField;
                }
                set
                {
                    this.adverseReactionField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class DentalCareMessageVO
        {
            private PersonInfoVO personField;

            private MessageIdentifierVO msgIDField;

            private DentalCompositionVO compositionField;

            private System.Xml.Serialization.XmlSerializerNamespaces xmlnsField;

            /// <remarks/>
            public PersonInfoVO Person
            {
                get
                {
                    return this.personField;
                }
                set
                {
                    this.personField = value;
                }
            }

            /// <remarks/>
            public MessageIdentifierVO MsgID
            {
                get
                {
                    return this.msgIDField;
                }
                set
                {
                    this.msgIDField = value;
                }
            }

            /// <remarks/>
            public DentalCompositionVO Composition
            {
                get
                {
                    return this.compositionField;
                }
                set
                {
                    this.compositionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlNamespaceDeclarations()]
            public System.Xml.Serialization.XmlSerializerNamespaces xmlns
            {
                get
                {
                    return this.xmlnsField;
                }
                set
                {
                    this.xmlnsField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class FollowupPlanVO
        {
            private DO_CODED_TEXT typeField;

            private DO_DATE nextEncounterDateField;

            private DO_TIME nextEncounterTimeField;

            private DO_QUANTITY nextEncounterField;

            private string descriptionField;

            /// <remarks/>
            public DO_CODED_TEXT Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            public DO_DATE NextEncounterDate
            {
                get
                {
                    return this.nextEncounterDateField;
                }
                set
                {
                    this.nextEncounterDateField = value;
                }
            }

            /// <remarks/>
            public DO_TIME NextEncounterTime
            {
                get
                {
                    return this.nextEncounterTimeField;
                }
                set
                {
                    this.nextEncounterTimeField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY NextEncounter
            {
                get
                {
                    return this.nextEncounterField;
                }
                set
                {
                    this.nextEncounterField = value;
                }
            }

            /// <remarks/>
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ReferralFeedbackCompositionVO
        {
            private FollowupPlanVO followupPlanField;

            private DO_IDENTIFIER referralIDField;

            private GeneralActionReportVO[] careActionField;

            private ClinicalFindingGeneralVO[] clinicalFindingField;

            private AbuseHistoryVO[] abuseHistoryField;

            private AdmissionVO admissionField;

            private PMHVO[] pastMedicalHistoryField;

            private FamilyHistoryVO[] familyHistoryField;

            private DiagnosisVO[] diagnosisField;

            private MedicationOrderedReportVO[] drugOrderedField;

            private InsuranceVO insuranceField;

            private DrugHistoryVO[] drugHistoryField;

            /// <remarks/>
            public FollowupPlanVO FollowupPlan
            {
                get
                {
                    return this.followupPlanField;
                }
                set
                {
                    this.followupPlanField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER ReferralID
            {
                get
                {
                    return this.referralIDField;
                }
                set
                {
                    this.referralIDField = value;
                }
            }

            /// <remarks/>
            public GeneralActionReportVO[] CareAction
            {
                get
                {
                    return this.careActionField;
                }
                set
                {
                    this.careActionField = value;
                }
            }

            /// <remarks/>
            public ClinicalFindingGeneralVO[] ClinicalFinding
            {
                get
                {
                    return this.clinicalFindingField;
                }
                set
                {
                    this.clinicalFindingField = value;
                }
            }

            /// <remarks/>
            public AbuseHistoryVO[] AbuseHistory
            {
                get
                {
                    return this.abuseHistoryField;
                }
                set
                {
                    this.abuseHistoryField = value;
                }
            }

            /// <remarks/>
            public AdmissionVO Admission
            {
                get
                {
                    return this.admissionField;
                }
                set
                {
                    this.admissionField = value;
                }
            }

            /// <remarks/>
            public PMHVO[] PastMedicalHistory
            {
                get
                {
                    return this.pastMedicalHistoryField;
                }
                set
                {
                    this.pastMedicalHistoryField = value;
                }
            }

            /// <remarks/>
            public FamilyHistoryVO[] FamilyHistory
            {
                get
                {
                    return this.familyHistoryField;
                }
                set
                {
                    this.familyHistoryField = value;
                }
            }

            /// <remarks/>
            public DiagnosisVO[] Diagnosis
            {
                get
                {
                    return this.diagnosisField;
                }
                set
                {
                    this.diagnosisField = value;
                }
            }

            /// <remarks/>
            public MedicationOrderedReportVO[] DrugOrdered
            {
                get
                {
                    return this.drugOrderedField;
                }
                set
                {
                    this.drugOrderedField = value;
                }
            }

            /// <remarks/>
            public InsuranceVO Insurance
            {
                get
                {
                    return this.insuranceField;
                }
                set
                {
                    this.insuranceField = value;
                }
            }

            /// <remarks/>
            public DrugHistoryVO[] DrugHistory
            {
                get
                {
                    return this.drugHistoryField;
                }
                set
                {
                    this.drugHistoryField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ReferralFeedbackMessageVO
        {
            private PersonInfoVO personField;

            private MessageIdentifierVO msgIDField;

            private ReferralFeedbackCompositionVO compositionField;

            private System.Xml.Serialization.XmlSerializerNamespaces xmlnsField;

            /// <remarks/>
            public PersonInfoVO Person
            {
                get
                {
                    return this.personField;
                }
                set
                {
                    this.personField = value;
                }
            }

            /// <remarks/>
            public MessageIdentifierVO MsgID
            {
                get
                {
                    return this.msgIDField;
                }
                set
                {
                    this.msgIDField = value;
                }
            }

            /// <remarks/>
            public ReferralFeedbackCompositionVO Composition
            {
                get
                {
                    return this.compositionField;
                }
                set
                {
                    this.compositionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlNamespaceDeclarations()]
            public System.Xml.Serialization.XmlSerializerNamespaces xmlns
            {
                get
                {
                    return this.xmlnsField;
                }
                set
                {
                    this.xmlnsField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ReferralInfoVO
        {
            private DO_DATE referredDateField;

            private DO_TIME referredTimeField;

            private DO_CODED_TEXT referredReasonField;

            private DO_CODED_TEXT referredTypeField;

            private OrganizationVO referredFacilityField;

            private HealthcareProviderVO referredProviderField;

            private string descriptionField;

            /// <remarks/>
            public DO_DATE ReferredDate
            {
                get
                {
                    return this.referredDateField;
                }
                set
                {
                    this.referredDateField = value;
                }
            }

            /// <remarks/>
            public DO_TIME ReferredTime
            {
                get
                {
                    return this.referredTimeField;
                }
                set
                {
                    this.referredTimeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT ReferredReason
            {
                get
                {
                    return this.referredReasonField;
                }
                set
                {
                    this.referredReasonField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT ReferredType
            {
                get
                {
                    return this.referredTypeField;
                }
                set
                {
                    this.referredTypeField = value;
                }
            }

            /// <remarks/>
            public OrganizationVO ReferredFacility
            {
                get
                {
                    return this.referredFacilityField;
                }
                set
                {
                    this.referredFacilityField = value;
                }
            }

            /// <remarks/>
            public HealthcareProviderVO ReferredProvider
            {
                get
                {
                    return this.referredProviderField;
                }
                set
                {
                    this.referredProviderField = value;
                }
            }

            /// <remarks/>
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ReferralCompositionVO
        {
            private PhysicalExamVO[] physicalExamsField;

            private DO_IDENTIFIER referralIDField;

            private ReferralInfoVO referralInfoField;

            private GeneralActionReportVO[] careActionField;

            private ClinicalFindingGeneralVO[] clinicalFindingField;

            private AbuseHistoryVO[] abuseHistoryField;

            private AdmissionVO admissionField;

            private PMHVO[] pastMedicalHistoryField;

            private FamilyHistoryVO[] familyHistoryField;

            private DiagnosisVO[] diagnosisField;

            private MedicationOrderedReportVO[] drugOrderedField;

            private InsuranceVO insuranceField;

            private DrugHistoryVO[] drugHistoryField;

            private AdverseReactionVO[] adverseReactionField;

            /// <remarks/>
            public PhysicalExamVO[] PhysicalExams
            {
                get
                {
                    return this.physicalExamsField;
                }
                set
                {
                    this.physicalExamsField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER ReferralID
            {
                get
                {
                    return this.referralIDField;
                }
                set
                {
                    this.referralIDField = value;
                }
            }

            /// <remarks/>
            public ReferralInfoVO ReferralInfo
            {
                get
                {
                    return this.referralInfoField;
                }
                set
                {
                    this.referralInfoField = value;
                }
            }

            /// <remarks/>
            public GeneralActionReportVO[] CareAction
            {
                get
                {
                    return this.careActionField;
                }
                set
                {
                    this.careActionField = value;
                }
            }

            /// <remarks/>
            public ClinicalFindingGeneralVO[] ClinicalFinding
            {
                get
                {
                    return this.clinicalFindingField;
                }
                set
                {
                    this.clinicalFindingField = value;
                }
            }

            /// <remarks/>
            public AbuseHistoryVO[] AbuseHistory
            {
                get
                {
                    return this.abuseHistoryField;
                }
                set
                {
                    this.abuseHistoryField = value;
                }
            }

            /// <remarks/>
            public AdmissionVO Admission
            {
                get
                {
                    return this.admissionField;
                }
                set
                {
                    this.admissionField = value;
                }
            }

            /// <remarks/>
            public PMHVO[] PastMedicalHistory
            {
                get
                {
                    return this.pastMedicalHistoryField;
                }
                set
                {
                    this.pastMedicalHistoryField = value;
                }
            }

            /// <remarks/>
            public FamilyHistoryVO[] FamilyHistory
            {
                get
                {
                    return this.familyHistoryField;
                }
                set
                {
                    this.familyHistoryField = value;
                }
            }

            /// <remarks/>
            public DiagnosisVO[] Diagnosis
            {
                get
                {
                    return this.diagnosisField;
                }
                set
                {
                    this.diagnosisField = value;
                }
            }

            /// <remarks/>
            public MedicationOrderedReportVO[] DrugOrdered
            {
                get
                {
                    return this.drugOrderedField;
                }
                set
                {
                    this.drugOrderedField = value;
                }
            }

            /// <remarks/>
            public InsuranceVO Insurance
            {
                get
                {
                    return this.insuranceField;
                }
                set
                {
                    this.insuranceField = value;
                }
            }

            /// <remarks/>
            public DrugHistoryVO[] DrugHistory
            {
                get
                {
                    return this.drugHistoryField;
                }
                set
                {
                    this.drugHistoryField = value;
                }
            }

            /// <remarks/>
            public AdverseReactionVO[] AdverseReaction
            {
                get
                {
                    return this.adverseReactionField;
                }
                set
                {
                    this.adverseReactionField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ReferralCaseMessageVO
        {
            private PersonInfoVO personField;

            private MessageIdentifierVO msgIDField;

            private ReferralCompositionVO compositionField;

            private System.Xml.Serialization.XmlSerializerNamespaces xmlnsField;

            /// <remarks/>
            public PersonInfoVO Person
            {
                get
                {
                    return this.personField;
                }
                set
                {
                    this.personField = value;
                }
            }

            /// <remarks/>
            public MessageIdentifierVO MsgID
            {
                get
                {
                    return this.msgIDField;
                }
                set
                {
                    this.msgIDField = value;
                }
            }

            /// <remarks/>
            public ReferralCompositionVO Composition
            {
                get
                {
                    return this.compositionField;
                }
                set
                {
                    this.compositionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlNamespaceDeclarations()]
            public System.Xml.Serialization.XmlSerializerNamespaces xmlns
            {
                get
                {
                    return this.xmlnsField;
                }
                set
                {
                    this.xmlnsField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class IngredientVO
        {
            private DO_CODEABLE_CONCEPT itemField;

            private DO_CODED_TEXT roleField;

            private DO_QUANTITY amountField;

            private DO_QUANTITY amountMaxField;

            /// <remarks/>
            public DO_CODEABLE_CONCEPT Item
            {
                get
                {
                    return this.itemField;
                }
                set
                {
                    this.itemField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Role
            {
                get
                {
                    return this.roleField;
                }
                set
                {
                    this.roleField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY Amount
            {
                get
                {
                    return this.amountField;
                }
                set
                {
                    this.amountField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY AmountMax
            {
                get
                {
                    return this.amountMaxField;
                }
                set
                {
                    this.amountMaxField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class MedicationPrescriptionRowVO
        {
            private DO_CODEABLE_CONCEPT asNeededField;

            private DO_CODED_TEXT priorityField;

            private DO_CODED_TEXT substitutionField;

            private DO_CODEABLE_CONCEPT siteField;

            private DO_CODEABLE_CONCEPT methodField;

            private DO_CODEABLE_CONCEPT reasonCodeField;

            private string patientInstructionField;

            private IngredientVO[] ingredientField;

            private DO_CODED_TEXT shapeField;

            private DO_CODED_TEXT drugNameField;

            private DO_CODED_TEXT productCodeField;

            private string drugNameDescriptionField;

            private DO_QUANTITY dosageField;

            private DO_CODED_TEXT frequencyField;

            private DO_CODED_TEXT routeField;

            private string descriptionField;

            private DO_QUANTITY totalNumberField;

            /// <remarks/>
            public DO_CODEABLE_CONCEPT AsNeeded
            {
                get
                {
                    return this.asNeededField;
                }
                set
                {
                    this.asNeededField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Priority
            {
                get
                {
                    return this.priorityField;
                }
                set
                {
                    this.priorityField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Substitution
            {
                get
                {
                    return this.substitutionField;
                }
                set
                {
                    this.substitutionField = value;
                }
            }

            /// <remarks/>
            public DO_CODEABLE_CONCEPT Site
            {
                get
                {
                    return this.siteField;
                }
                set
                {
                    this.siteField = value;
                }
            }

            /// <remarks/>
            public DO_CODEABLE_CONCEPT Method
            {
                get
                {
                    return this.methodField;
                }
                set
                {
                    this.methodField = value;
                }
            }

            /// <remarks/>
            public DO_CODEABLE_CONCEPT ReasonCode
            {
                get
                {
                    return this.reasonCodeField;
                }
                set
                {
                    this.reasonCodeField = value;
                }
            }

            /// <remarks/>
            public string PatientInstruction
            {
                get
                {
                    return this.patientInstructionField;
                }
                set
                {
                    this.patientInstructionField = value;
                }
            }

            /// <remarks/>
            public IngredientVO[] Ingredient
            {
                get
                {
                    return this.ingredientField;
                }
                set
                {
                    this.ingredientField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Shape
            {
                get
                {
                    return this.shapeField;
                }
                set
                {
                    this.shapeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT DrugName
            {
                get
                {
                    return this.drugNameField;
                }
                set
                {
                    this.drugNameField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT ProductCode
            {
                get
                {
                    return this.productCodeField;
                }
                set
                {
                    this.productCodeField = value;
                }
            }

            /// <remarks/>
            public string DrugNameDescription
            {
                get
                {
                    return this.drugNameDescriptionField;
                }
                set
                {
                    this.drugNameDescriptionField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY Dosage
            {
                get
                {
                    return this.dosageField;
                }
                set
                {
                    this.dosageField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Frequency
            {
                get
                {
                    return this.frequencyField;
                }
                set
                {
                    this.frequencyField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Route
            {
                get
                {
                    return this.routeField;
                }
                set
                {
                    this.routeField = value;
                }
            }

            /// <remarks/>
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY TotalNumber
            {
                get
                {
                    return this.totalNumberField;
                }
                set
                {
                    this.totalNumberField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class MedicationPrescriptionsVO
        {
            private ProviderInfoVO prescriberField;

            private DO_DATE issueDateField;

            private DO_TIME issueTimeField;

            private string ePrescriptionIDField;

            private MedicationPrescriptionRowVO[] ordersField;

            private DO_DATE expiryDateField;

            private System.Nullable<int> repeatsField;

            /// <remarks/>
            public ProviderInfoVO Prescriber
            {
                get
                {
                    return this.prescriberField;
                }
                set
                {
                    this.prescriberField = value;
                }
            }

            /// <remarks/>
            public DO_DATE IssueDate
            {
                get
                {
                    return this.issueDateField;
                }
                set
                {
                    this.issueDateField = value;
                }
            }

            /// <remarks/>
            public DO_TIME IssueTime
            {
                get
                {
                    return this.issueTimeField;
                }
                set
                {
                    this.issueTimeField = value;
                }
            }

            /// <remarks/>
            public string ePrescriptionID
            {
                get
                {
                    return this.ePrescriptionIDField;
                }
                set
                {
                    this.ePrescriptionIDField = value;
                }
            }

            /// <remarks/>
            public MedicationPrescriptionRowVO[] Orders
            {
                get
                {
                    return this.ordersField;
                }
                set
                {
                    this.ordersField = value;
                }
            }

            /// <remarks/>
            public DO_DATE ExpiryDate
            {
                get
                {
                    return this.expiryDateField;
                }
                set
                {
                    this.expiryDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(IsNullable = true)]
            public System.Nullable<int> Repeats
            {
                get
                {
                    return this.repeatsField;
                }
                set
                {
                    this.repeatsField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class MedicationPrescriptionsCompositionVO
        {
            private AdmissionVO admissionField;

            private InsuranceVO insuranceField;

            private MedicationPrescriptionsVO medicationPrescriptionsField;

            private DiagnosisVO[] diagnosisField;

            /// <remarks/>
            public AdmissionVO Admission
            {
                get
                {
                    return this.admissionField;
                }
                set
                {
                    this.admissionField = value;
                }
            }

            /// <remarks/>
            public InsuranceVO Insurance
            {
                get
                {
                    return this.insuranceField;
                }
                set
                {
                    this.insuranceField = value;
                }
            }

            /// <remarks/>
            public MedicationPrescriptionsVO MedicationPrescriptions
            {
                get
                {
                    return this.medicationPrescriptionsField;
                }
                set
                {
                    this.medicationPrescriptionsField = value;
                }
            }

            /// <remarks/>
            public DiagnosisVO[] Diagnosis
            {
                get
                {
                    return this.diagnosisField;
                }
                set
                {
                    this.diagnosisField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class MedicationPrescriptionsMessageVO
        {
            private PersonInfoVO personField;

            private MessageIdentifierVO msgIDField;

            private MedicationPrescriptionsCompositionVO compositionField;

            private System.Xml.Serialization.XmlSerializerNamespaces xmlnsField;

            /// <remarks/>
            public PersonInfoVO Person
            {
                get
                {
                    return this.personField;
                }
                set
                {
                    this.personField = value;
                }
            }

            /// <remarks/>
            public MessageIdentifierVO MsgID
            {
                get
                {
                    return this.msgIDField;
                }
                set
                {
                    this.msgIDField = value;
                }
            }

            /// <remarks/>
            public MedicationPrescriptionsCompositionVO Composition
            {
                get
                {
                    return this.compositionField;
                }
                set
                {
                    this.compositionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlNamespaceDeclarations()]
            public System.Xml.Serialization.XmlSerializerNamespaces xmlns
            {
                get
                {
                    return this.xmlnsField;
                }
                set
                {
                    this.xmlnsField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class MedicationDispensedVO
        {
            private MedicationDispensedVO[] compoundedProductField;

            private DO_IDENTIFIER confirmationIDField;

            private CostDetailsVO[] costsField;

            private DO_CODED_TEXT shapeField;

            private DO_CODED_TEXT drugNameField;

            private DO_CODED_TEXT productCodeField;

            private string drugNameDescriptionField;

            private DO_QUANTITY dosageField;

            private DO_CODED_TEXT frequencyField;

            private DO_CODED_TEXT routeField;

            private string descriptionField;

            private DO_QUANTITY totalNumberField;

            private DO_QUANTITY totalCostField;

            private DO_QUANTITY insuranceCostField;

            private DO_QUANTITY patientCostField;

            private MedicationDispensedVO replaceMedicationField;

            private string batchNumberField;

            /// <remarks/>
            public MedicationDispensedVO[] CompoundedProduct
            {
                get
                {
                    return this.compoundedProductField;
                }
                set
                {
                    this.compoundedProductField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER ConfirmationID
            {
                get
                {
                    return this.confirmationIDField;
                }
                set
                {
                    this.confirmationIDField = value;
                }
            }

            /// <remarks/>
            public CostDetailsVO[] Costs
            {
                get
                {
                    return this.costsField;
                }
                set
                {
                    this.costsField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Shape
            {
                get
                {
                    return this.shapeField;
                }
                set
                {
                    this.shapeField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT DrugName
            {
                get
                {
                    return this.drugNameField;
                }
                set
                {
                    this.drugNameField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT ProductCode
            {
                get
                {
                    return this.productCodeField;
                }
                set
                {
                    this.productCodeField = value;
                }
            }

            /// <remarks/>
            public string DrugNameDescription
            {
                get
                {
                    return this.drugNameDescriptionField;
                }
                set
                {
                    this.drugNameDescriptionField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY Dosage
            {
                get
                {
                    return this.dosageField;
                }
                set
                {
                    this.dosageField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Frequency
            {
                get
                {
                    return this.frequencyField;
                }
                set
                {
                    this.frequencyField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Route
            {
                get
                {
                    return this.routeField;
                }
                set
                {
                    this.routeField = value;
                }
            }

            /// <remarks/>
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY TotalNumber
            {
                get
                {
                    return this.totalNumberField;
                }
                set
                {
                    this.totalNumberField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY TotalCost
            {
                get
                {
                    return this.totalCostField;
                }
                set
                {
                    this.totalCostField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY InsuranceCost
            {
                get
                {
                    return this.insuranceCostField;
                }
                set
                {
                    this.insuranceCostField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY PatientCost
            {
                get
                {
                    return this.patientCostField;
                }
                set
                {
                    this.patientCostField = value;
                }
            }

            /// <remarks/>
            public MedicationDispensedVO ReplaceMedication
            {
                get
                {
                    return this.replaceMedicationField;
                }
                set
                {
                    this.replaceMedicationField = value;
                }
            }

            /// <remarks/>
            public string BatchNumber
            {
                get
                {
                    return this.batchNumberField;
                }
                set
                {
                    this.batchNumberField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class CostDetailsVO
        {
            private DO_CODED_TEXT nameField;

            private DO_QUANTITY priceField;

            /// <remarks/>
            public DO_CODED_TEXT Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY Price
            {
                get
                {
                    return this.priceField;
                }
                set
                {
                    this.priceField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class DispensedPrescriptionsVO
        {
            private CostDetailsVO[] costsField;

            private DO_QUANTITY insuranceCostField;

            private DO_QUANTITY patientCostField;

            private ProviderInfoVO prescribingPhysiciansField;

            private DO_QUANTITY pharmacyTechnicalCostField;

            private DO_QUANTITY totalCostField;

            private ProviderInfoVO pharmacyTechniciansField;

            private DO_DATE dateDispenseField;

            private DO_TIME timeDispenseField;

            private string serialNumberField;

            private string ePrescriptionIDField;

            private MedicationDispensedVO[] medicationDispensedField;

            /// <remarks/>
            public CostDetailsVO[] Costs
            {
                get
                {
                    return this.costsField;
                }
                set
                {
                    this.costsField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY InsuranceCost
            {
                get
                {
                    return this.insuranceCostField;
                }
                set
                {
                    this.insuranceCostField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY PatientCost
            {
                get
                {
                    return this.patientCostField;
                }
                set
                {
                    this.patientCostField = value;
                }
            }

            /// <remarks/>
            public ProviderInfoVO PrescribingPhysicians
            {
                get
                {
                    return this.prescribingPhysiciansField;
                }
                set
                {
                    this.prescribingPhysiciansField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY PharmacyTechnicalCost
            {
                get
                {
                    return this.pharmacyTechnicalCostField;
                }
                set
                {
                    this.pharmacyTechnicalCostField = value;
                }
            }

            /// <remarks/>
            public DO_QUANTITY TotalCost
            {
                get
                {
                    return this.totalCostField;
                }
                set
                {
                    this.totalCostField = value;
                }
            }

            /// <remarks/>
            public ProviderInfoVO PharmacyTechnicians
            {
                get
                {
                    return this.pharmacyTechniciansField;
                }
                set
                {
                    this.pharmacyTechniciansField = value;
                }
            }

            /// <remarks/>
            public DO_DATE DateDispense
            {
                get
                {
                    return this.dateDispenseField;
                }
                set
                {
                    this.dateDispenseField = value;
                }
            }

            /// <remarks/>
            public DO_TIME TimeDispense
            {
                get
                {
                    return this.timeDispenseField;
                }
                set
                {
                    this.timeDispenseField = value;
                }
            }

            /// <remarks/>
            public string SerialNumber
            {
                get
                {
                    return this.serialNumberField;
                }
                set
                {
                    this.serialNumberField = value;
                }
            }

            /// <remarks/>
            public string ePrescriptionID
            {
                get
                {
                    return this.ePrescriptionIDField;
                }
                set
                {
                    this.ePrescriptionIDField = value;
                }
            }

            /// <remarks/>
            public MedicationDispensedVO[] MedicationDispensed
            {
                get
                {
                    return this.medicationDispensedField;
                }
                set
                {
                    this.medicationDispensedField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class DispensedPrescriptionsCompositionVO
        {
            private AdmissionVO admissionField;

            private InsuranceVO insuranceField;

            private DispensedPrescriptionsVO dispensedPrescriptionsField;

            /// <remarks/>
            public AdmissionVO Admission
            {
                get
                {
                    return this.admissionField;
                }
                set
                {
                    this.admissionField = value;
                }
            }

            /// <remarks/>
            public InsuranceVO Insurance
            {
                get
                {
                    return this.insuranceField;
                }
                set
                {
                    this.insuranceField = value;
                }
            }

            /// <remarks/>
            public DispensedPrescriptionsVO DispensedPrescriptions
            {
                get
                {
                    return this.dispensedPrescriptionsField;
                }
                set
                {
                    this.dispensedPrescriptionsField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class DispensedPrescriptionsMessageVO
        {
            private DispensedPrescriptionsCompositionVO compositionField;

            private MessageIdentifierVO msgIDField;

            private PersonInfoVO personField;

            /// <remarks/>
            public DispensedPrescriptionsCompositionVO Composition
            {
                get
                {
                    return this.compositionField;
                }
                set
                {
                    this.compositionField = value;
                }
            }

            /// <remarks/>
            public MessageIdentifierVO MsgID
            {
                get
                {
                    return this.msgIDField;
                }
                set
                {
                    this.msgIDField = value;
                }
            }

            /// <remarks/>
            public PersonInfoVO Person
            {
                get
                {
                    return this.personField;
                }
                set
                {
                    this.personField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ResultVO
        {
            private string messageUIDField;

            private string errorMessageField;

            private string compositionUIDField;

            private string patientUIDField;

            /// <remarks/>
            public string MessageUID
            {
                get
                {
                    return this.messageUIDField;
                }
                set
                {
                    this.messageUIDField = value;
                }
            }

            /// <remarks/>
            public string ErrorMessage
            {
                get
                {
                    return this.errorMessageField;
                }
                set
                {
                    this.errorMessageField = value;
                }
            }

            /// <remarks/>
            public string CompositionUID
            {
                get
                {
                    return this.compositionUIDField;
                }
                set
                {
                    this.compositionUIDField = value;
                }
            }

            /// <remarks/>
            public string patientUID
            {
                get
                {
                    return this.patientUIDField;
                }
                set
                {
                    this.patientUIDField = value;
                }
            }
        }





        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class ReserveHIDlistVO
        {
            private DO_IDENTIFIER[] hIDField;

            private DO_DATE validDateField;

            /// <remarks/>
            public DO_IDENTIFIER[] HID
            {
                get
                {
                    return this.hIDField;
                }
                set
                {
                    this.hIDField = value;
                }
            }

            /// <remarks/>
            public DO_DATE ValidDate
            {
                get
                {
                    return this.validDateField;
                }
                set
                {
                    this.validDateField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.1")]
        [System.Serializable()]
        [System.Diagnostics.DebuggerStepThrough()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
        public partial class InsuranceInquiryVO
        {
            private string firstNameField;

            private string lastNameField;

            private string nationalcodeField;

            private DO_DATE birthDateField;

            private DO_CODED_TEXT insurerField;

            private DO_CODED_TEXT insurerBoxField;

            private DO_IDENTIFIER insuranceNumberField;

            private DO_DATE expirationDateField;

            private DO_CODED_TEXT genderField;

            private DO_CODED_TEXT maritalStatusField;

            private string pictureB64Field;

            private string addressField;

            private string postalCodeField;

            private string errorMessageField;

            private string recommendationMessageField;

            private string inquiryIDField;

            private UndefinedDataVO[] extraPropertiesField;

            /// <remarks/>
            public string FirstName
            {
                get
                {
                    return this.firstNameField;
                }
                set
                {
                    this.firstNameField = value;
                }
            }

            /// <remarks/>
            public string LastName
            {
                get
                {
                    return this.lastNameField;
                }
                set
                {
                    this.lastNameField = value;
                }
            }

            /// <remarks/>
            public string Nationalcode
            {
                get
                {
                    return this.nationalcodeField;
                }
                set
                {
                    this.nationalcodeField = value;
                }
            }

            /// <remarks/>
            public DO_DATE BirthDate
            {
                get
                {
                    return this.birthDateField;
                }
                set
                {
                    this.birthDateField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Insurer
            {
                get
                {
                    return this.insurerField;
                }
                set
                {
                    this.insurerField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT InsurerBox
            {
                get
                {
                    return this.insurerBoxField;
                }
                set
                {
                    this.insurerBoxField = value;
                }
            }

            /// <remarks/>
            public DO_IDENTIFIER InsuranceNumber
            {
                get
                {
                    return this.insuranceNumberField;
                }
                set
                {
                    this.insuranceNumberField = value;
                }
            }

            /// <remarks/>
            public DO_DATE ExpirationDate
            {
                get
                {
                    return this.expirationDateField;
                }
                set
                {
                    this.expirationDateField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT Gender
            {
                get
                {
                    return this.genderField;
                }
                set
                {
                    this.genderField = value;
                }
            }

            /// <remarks/>
            public DO_CODED_TEXT MaritalStatus
            {
                get
                {
                    return this.maritalStatusField;
                }
                set
                {
                    this.maritalStatusField = value;
                }
            }

            /// <remarks/>
            public string PictureB64
            {
                get
                {
                    return this.pictureB64Field;
                }
                set
                {
                    this.pictureB64Field = value;
                }
            }

            /// <remarks/>
            public string Address
            {
                get
                {
                    return this.addressField;
                }
                set
                {
                    this.addressField = value;
                }
            }

            /// <remarks/>
            public string PostalCode
            {
                get
                {
                    return this.postalCodeField;
                }
                set
                {
                    this.postalCodeField = value;
                }
            }

            /// <remarks/>
            public string ErrorMessage
            {
                get
                {
                    return this.errorMessageField;
                }
                set
                {
                    this.errorMessageField = value;
                }
            }

            /// <remarks/>
            public string RecommendationMessage
            {
                get
                {
                    return this.recommendationMessageField;
                }
                set
                {
                    this.recommendationMessageField = value;
                }
            }

            /// <remarks/>
            public string InquiryID
            {
                get
                {
                    return this.inquiryIDField;
                }
                set
                {
                    this.inquiryIDField = value;
                }
            }

            /// <remarks/>
            public UndefinedDataVO[] ExtraProperties
            {
                get
                {
                    return this.extraPropertiesField;
                }
                set
                {
                    this.extraPropertiesField = value;
                }
            }
    }
}
