using Ditas.SDK.DataModel;
using System;

namespace Ditas.SDKTest
{
    internal class TestModels
    {
        internal static SOAPMessageVO GetSIYABModel()
        {
            return new SOAPMessageVO
            {
                Person = new PersonInfoVO
                {
                    FirstName = "klj",
                    LastName = "فرخیان",
                    NationalCode = "2295519233",
                    BirthDate = new DO_DATE
                    {
                        Year = 1361,
                        Day = 15,
                        Month = 4
                    },
                    Gender = new DO_CODED_TEXT
                    {
                        Value = "زن",
                        Terminology_id = "thritaEHR.gender",
                        Coded_string = "2"
                    },
                    IDCardNumber = "66",
                    MobileNumber = "09121544568",
                    Nationality = new DO_CODED_TEXT
                    {
                        Value = "IRAN, ISLAMIC REPUBLIC OF",
                        Terminology_id = "ISO_3166-1",
                        Coded_string = "IR"
                    }
                },
                MsgID = new MessageIdentifierVO
                {
                    IS_Queriable = true,
                    SystemID = new DO_IDENTIFIER
                    {
                        Issuer = "MOHME_IT",
                        Assigner = "MOHME_IT",
                        ID = "4E794D6F-45A2-1186-817C-5E34E3FCF8AC",
                        Type = "System_ID"
                    },
                    Committer = new ProviderInfoVO
                    {
                        FirstName = "ارسال کننده",
                        LastName = "اطلاعات",
                        Identifier = new DO_IDENTIFIER
                        {
                            Issuer = "National_Org_Civil_Reg",
                            Assigner = "National_Org_Civil_Reg",
                            ID = "2755695137",
                            Type = "National_Code"
                        }
                    }
                },
                Composition = new GeneralCaseCompositionVO
                {
                    Questionnaire = new QuestionnaireVO[]
                        {
                           new QuestionnaireBooleanVO{
                               QuestionCategory=new DO_CODED_TEXT
                               {
                                  Value="مراقبت آسم" ,
                                   Terminology_id="thritaEHR.QuestionCategory",
                                   Coded_string="11"
                               },
                               QuestionCode=new DO_CODED_TEXT
                               {
                                   Value="آيا طي هفته گذشته علائم آسم (سرفه، تنگي نفس و خس خس سينه) در ساعات بيداري داشته ايد؟",
                                   Terminology_id="thritaEHR.QuestionCode",
                                   Coded_string="11.0"
                               },
                               Answer=true,
                           },

                        },
                    ClinicalFinding = new ClinicalFindingGeneralVO[]
                        {
                        new ClinicalFindingGeneralVO
                            {
                                NillSignificant=true,
                                Finding=new DO_CODED_TEXT
                                {
                                    Value = "Precordial pain" ,
                                    Terminology_id = "icd10",
                                    Coded_string = "R07.2"
                                },
                                DateofOnset=new DO_DATE
                                {
                                    Day=20,Month=5,Year=1397
                                },
                            },
                        },
                    AbuseHistory = new AbuseHistoryVO[]
                        {
                        new AbuseHistoryVO
                            {
                                StartDate = new DO_DATE { Day = 1, Month = 1, Year = 1391 },
                                SubstanceType = new DO_CODED_TEXT
                                {
                                    Coded_string = "Cigarette smoking tobacco (substance)",
                                    Terminology_id = "SNOMEDCT",
                                    Value = "66562002"
                                }
                            }
                        },
                    Admission = new AdmissionVO
                    {
                        AdmissionDate = new DO_DATE
                        {
                            Year = 1397,
                            Month = 10,
                            Day = 24
                        },
                        AdmissionTime = new DO_TIME
                        {
                            Hour = 10,
                            Minute = 20,
                            Second = 0,
                        },
                        AdmissionType = new DO_CODED_TEXT
                        {
                            Value = "سرپایی",
                            Terminology_id = "thritaEHR.admissionType",
                            Coded_string = "1"
                        },
                        MedicalRecordNumber = "126789",
                        Institute = new OrganizationVO
                        {
                            Name = "مرکز ارائه دهنده خدمت مجازی جهت تبادل اطلاعات تستی",
                            ID = new DO_IDENTIFIER
                            {
                                Issuer = "MOHME_IT",
                                Assigner = "MOHME_IT",
                                ID = "d2fb9548-6544-41b1-a8df-c68945fee716",
                                Type = "Org_ID"
                            }
                        },
                        AttendingDoctor = new HealthcareProviderVO
                        {
                            FirstName = "دکتر",
                            LastName = "چهراسن",
                            Specialty = new DO_CODED_TEXT
                            {
                                Value = "متخصص ارتوپدی",
                                Terminology_id = "thritaEHR.specialty",
                                Coded_string = "171108"
                            },
                            Identifier = new DO_IDENTIFIER
                            {
                                Issuer = "Med_Council",
                                Assigner = "Med_Council",
                                ID = "114088",
                                Type = "Med_ID"
                            }
                        }
                    },
                    FamilyHistory = new FamilyHistoryVO[]
                        {
                        new FamilyHistoryVO
                        {
                            Condition=new DO_CODED_TEXT
                            {
                                Value="Type 1 diabetes mellitus",
                                Terminology_id="ICD10",
                                Coded_string="E10"
                            },
                            RelatedPerson=new DO_CODED_TEXT
                            {
                                Value="همسر",
                                Terminology_id="ThritaEHR.RelatedPerson",
                                Coded_string="29"
                            },
                            Is_CauseofDeath=true
                        }
                        },
                    LabResult = new LabTestResultVO[]
                        {

                        new BloodSugarVO
                        {
                            DateTimeResult=new DO_DATE_TIME
                            {
                                Year=1398,
                                Month=10,
                                Day=24,
                                Hour=11,
                                Minute=31,
                                Second=52
                            },
                            BS=new BSVO[]
                            {
                                new BSVO
                                {
                                    BloodGlucoseLevel=new DO_QUANTITY
                                    {
                                        Magnitude=110,
                                        Unit="mg"
                                    },
                                    Timing=new DO_CODED_TEXT{
                                        Value="120 minute blood glucose measurement",
                                        Terminology_id="SNOMEDCT",
                                        Coded_string="313545000" }
                                }
                            },
                            TestSpecified1=new DO_CODED_TEXT
                            {
                                Value="Blood sugar level(BS)",
                                Terminology_id="SNOMEDCT" ,
                                Coded_string="33747003"
                            }
                        }
                        },
                    Complication = new ComplicationVO[]
                        {
                        new ComplicationVO
                        {
                            Complication=new DO_CODED_TEXT
                            {
                                Value="Respiratory Disorder, Unspecified" ,
                                Terminology_id="ICD10" ,
                                Coded_string="J98.9"
                            }
                        }
                        },
                    Diagnosis = new DiagnosisVO[]
                        {
                        new DiagnosisVO
                        {
                            Diagnosis=new DO_CODED_TEXT
                            {
                                Value="Malignant neoplasm: Colon, unspecified" ,
                                Terminology_id="ICD10" ,
                                Coded_string="C18.9"
                            },
                            Status=new DO_CODED_TEXT
                            {
                                Value="تشخیص نهایی" ,
                                Terminology_id="thritaEHR.daignosis.status",
                                Coded_string="3"
                            }
                        }
                        },
                    Insurance = new InsuranceVO[]
                        {
                        new InsuranceVO
                        {
                            Insurer=new DO_CODED_TEXT{
                                Value="تأمین اجتماعی" ,
                                Terminology_id="thritaEHR.Insurer",
                                Coded_string="1" },
                            InsuranceBox=new DO_CODED_TEXT{
                                Value="بیمه اجباری",
                                Terminology_id="thritaEHR.InsuranceBox",
                                Coded_string="1"},
                            InsuredNumber="0037622492",
                            SHEBAD=new DO_IDENTIFIER{
                            Issuer="TAMIN",
                                Assigner="TAMIN",
                                ID="1984EZVYT",
                                Type="HID"}
                        }
                        }
                },
            };
        }
    }
}