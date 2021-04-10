using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ditas.SDK;
using Ditas.SDK.DataModel;
using System;
using System.IO;
using System.Reflection.Emit;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.Threading;

namespace Ditas.SDK_Test
{
    [TestClass]
    public class UnitTest1
    {
        private Service service;

        [TestMethod]
        public void SaveSIYABReport_OK()
        {
            service = new Service();
            var result = service.SaveSIYABReport(Ditas.SDK.Helper.Utilities.GetModelFromXmlFile<SOAPMessageVO>(@"XmlSamplePackets\SIYABReport\1.xml"));
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void VerifyHIDStatus_OK()
        {
            service = new Service();
            var result = service.VerifyHIDStatus(
                new DO_IDENTIFIER { Assigner = "TAMIN", ID = "19946YI6XR", Issuer = "TAMIN", Type = "HID" },
                "4313179801"
                );
            result = service.VerifyHIDStatus(
                new DO_IDENTIFIER { Assigner = "TAMIN", ID = "19946YI6XR", Issuer = "TAMIN", Type = "HID" },
                new DO_IDENTIFIER { Assigner = "National_Org_Civil_Reg", Type = "National_Code", Issuer = "National_Org_Civil_Reg", ID = "4313179801" }
                );
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void EliminateHID_OK()
        {
            service = new Service();
            try
            {
                var result = service.EliminateHID(
                 "4313179801",
                 new DO_IDENTIFIER { Assigner = "TAMIN", ID = "19946YI6XR", Issuer = "TAMIN", Type = "HID" },
                 new DO_CODED_TEXT { Coded_string = "مرد", Terminology_id = "1", Value = "HL" },
                 ""
                 );
                result = service.EliminateHID(
                    new DO_IDENTIFIER { Assigner = "National_Org_Civil_Reg", Type = "National_Code", Issuer = "National_Org_Civil_Reg", ID = "4313179801" },
                    new DO_IDENTIFIER { Assigner = "TAMIN", ID = "19946YI6XR", Issuer = "TAMIN", Type = "HID" },
                    new DO_CODED_TEXT { Coded_string = "مرد", Terminology_id = "1", Value = "HL" },
                    ""
                    );
                Assert.IsNotNull(result);
            }
            catch (SdkException ex)
            {
                StringAssert.Contains(ex.Message, "قبلا");
                throw;
            }

        }

        [TestMethod]
        public void UpdateHID_OK()
        {
            try
            {
                service = new Service();
                var result = service.UpdateHID(
                    new DO_IDENTIFIER
                    {
                        Assigner = "TAMIN",
                        ID = "19946Y6ZF7",
                        Issuer = "TAMIN",
                        Type = "HID"
                    },
                    "4313179801",
                    new DO_IDENTIFIER
                    {
                        Assigner = "Med_Council",
                        ID = "11116",
                        Issuer = "Med_Council",
                        Type = "Med_ID"
                    },
                    new DO_CODED_TEXT
                    {
                        Coded_string = "تامین اجتماعی",
                        Terminology_id = "thritaEHR.Insurer",
                        Value = "1"
                    }, null
                    );
                result = service.UpdateHID(
                    new DO_IDENTIFIER
                    {
                        Assigner = "TAMIN",
                        ID = "19946Y6ZF7",
                        Issuer = "TAMIN",
                        Type = "HID"
                    },
                    new DO_IDENTIFIER
                    {
                        Assigner = "National_Org_Civil_Reg",
                        Type = "National_Code",
                        Issuer = "National_Org_Civil_Reg",
                        ID = "4313179801"
                    },

                    new DO_IDENTIFIER
                    {
                        Assigner = "Med_Council",
                        ID = "11116",
                        Issuer = "Med_Council",
                        Type = "Med_ID"
                    },
                    new DO_CODED_TEXT
                    {
                        Coded_string = "تامین اجتماعی",
                        Terminology_id = "thritaEHR.Insurer",
                        Value = "1"
                    }, null
                    );
                Assert.IsNotNull(result);
            }
            catch (SdkException ex)
            {
                StringAssert.Contains(ex.Messages[0], "رزرو قابل انجام می باشد");
                return;
            }
        }

        [TestMethod]
        public void GenerateBatchHID_OK()
        {
            try
            {
                service = new Service();
                var result = service.GenerateBatchHID(
                    new DO_CODED_TEXT
                    {
                        Coded_string= "1",
                        Terminology_id = "thritaEHR.Insurer",
                        Value = "تامین اجتماعی",},10
                    );
                Assert.IsNotNull(result);
            }
            catch (SdkException ex)
            {
                StringAssert.Contains(ex.Messages[0], "رزرو قابل انجام می باشد");
                return;
            }
        }
        //[TestMethod]
        //public void RefreshToken()
        //{
        //    service = new Service();
        //    var result = service.GetHID("2092359551",
        //        new DO_IDENTIFIER { Assigner = "", ID = "11116", Issuer = "", Type = "" },
        //        new DO_CODED_TEXT { Coded_string = "1" },
        //        new DO_IDENTIFIER { Assigner = "", ID = "3E87DC76-A67A-4A77-B0F6-39D6AEBF2A42", Issuer = "", Type = "" });
        //    Thread.Sleep(355 * 1000);
        //    result = service.GetHID("2092359551",
        //        new DO_IDENTIFIER { Assigner = "", ID = "11116", Issuer = "", Type = "" },
        //        new DO_CODED_TEXT { Coded_string = "1" },
        //        new DO_IDENTIFIER { Assigner = "", ID = "3E87DC76-A67A-4A77-B0F6-39D6AEBF2A42", Issuer = "", Type = "" });

        //    Assert.IsNotNull(result);
        //    Console.WriteLine(result.ID);
        //}
        //private Service service;
        //[TestMethod]
        //public void GetPersonInfo()
        //{
        //    service = new Service();
        //    var result = service.GetPersonByBirth("4569962343", 13650630);
        //    Assert.IsNotNull(result);
        //    Console.WriteLine(result.FirstName, result.LastName);
        //}
        //[TestMethod]
        //public void StressTest()
        //{
        //    service = new Service();
        //    for (int i = 0; i < 100; i++)
        //    {
        //        var result = service.GetPersonByBirth("4569962343", 13650630);
        //        Assert.IsNotNull(result);
        //        Console.WriteLine(result.FirstName, result.LastName);
        //    }
        //}


        //[TestMethod]
        //public void GetDrugSalamat()
        //{
        //    var model = SDK.Helper.Utilities.GetModelFromXmlFile<MedicationPrescriptionsMessageVO>("req.txt");
        //    service = new Service();
        //    var result = service.SaveMedicationPrescription(model);
        //    Assert.IsNotNull(result);
        //}




    }
}
