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

        [TestMethod]
        public void RefreshToken()
        {
            service = new Service();
            var result = service.GetHID("4160262661",
                new DO_IDENTIFIER { Assigner = "", ID = "11116", Issuer = "", Type = "" },
                new DO_CODED_TEXT { Coded_string = "1" },
                new DO_IDENTIFIER { Assigner = "", ID = "3E87DC76-A67A-4A77-B0F6-39D6AEBF2A42", Issuer = "", Type = "" });
            Thread.Sleep(355 * 1000);
            result = service.GetHID("4160262661",
                new DO_IDENTIFIER { Assigner = "", ID = "11116", Issuer = "", Type = "" },
                new DO_CODED_TEXT { Coded_string = "1" },
                new DO_IDENTIFIER { Assigner = "", ID = "3E87DC76-A67A-4A77-B0F6-39D6AEBF2A42", Issuer = "", Type = "" });

            Assert.IsNotNull(result);
            Console.WriteLine(result.ID);
        }
        private Service service;
        [TestMethod]
        public void GetPersonInfo()
        {
            service = new Service();
            var result = service.GetPersonByBirth("4569962343", 13650630);
            Assert.IsNotNull(result);
            Console.WriteLine(result.FirstName, result.LastName);
        }
        [TestMethod]
        public void StressTest()
        {
            service = new Service();
            for (int i = 0; i < 100; i++)
            {
                var result = service.GetPersonByBirth("4569962343", 13650630);
                Assert.IsNotNull(result);
                Console.WriteLine(result.FirstName, result.LastName);
            }
        }
        [TestMethod]
        public void GetHID()
        {
            service = new Service();
            var result = service.GetHID("4160262661",
                new DO_IDENTIFIER { Assigner = "", ID = "11116", Issuer = "", Type = "" },
                new DO_CODED_TEXT { Coded_string = "1" },
                new DO_IDENTIFIER { Assigner = "", ID = "3E87DC76-A67A-4A77-B0F6-39D6AEBF2A42", Issuer = "", Type = "" });
            Thread.Sleep(1*1000);
            result = service.GetHID("4160262661",
                new DO_IDENTIFIER { Assigner = "", ID = "11116", Issuer = "", Type = "" },
                new DO_CODED_TEXT { Coded_string = "1" },
                new DO_IDENTIFIER { Assigner = "", ID = "3E87DC76-A67A-4A77-B0F6-39D6AEBF2A42", Issuer = "", Type = "" });

            Assert.IsNotNull(result);
            Console.WriteLine(result.ID);
        }
        [TestMethod]
        public void GetHIDurgent()
        {
            service = new Service();
            var result = service.GetHIDurgent(
                new DO_IDENTIFIER { Assigner = "", ID = "4160262661", Issuer = "", Type = "" },
                new DO_IDENTIFIER { Assigner = "", ID = "11116", Issuer = "", Type = "" },
                new DO_CODED_TEXT { Coded_string = "1" },
                new DO_IDENTIFIER { Assigner = "", ID = "3E87DC76-A67A-4A77-B0F6-39D6AEBF2A42", Issuer = "", Type = "" });

            Assert.IsNotNull(result);
            Console.WriteLine(result.ID);
        }
        [TestMethod]
        public void GetDrugSalamat()
        {
            var model = SDK.Helper.Utilities.GetModelFromXmlFile<MedicationPrescriptionsMessageVO>("req.txt");
            service = new Service();
            var result = service.SaveMedicationPrescription(model);
            Assert.IsNotNull(result);
        }




    }
}
