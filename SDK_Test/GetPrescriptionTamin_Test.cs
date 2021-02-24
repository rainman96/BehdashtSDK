using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ditas.SDK;
using Ditas.SDK.DataModel;
using System;
using System.IO;
using System.Reflection.Emit;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.Threading;
using Ditas.SDK.Helper;

namespace Ditas.SDK_Test
{
    [TestClass]
    public class GetPrescriptionTamin_Test
    {
        private Service service;

        [TestMethod]
        public void SaveMedicationPrescription_OK()
        {
            service = new Service();
            var result = service.SaveMedicationPrescription(Utilities.GetModelFromXmlFile<MedicationPrescriptionsMessageVO>("PrescriptionReq.txt"));
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void GetHID_BadNationalCode()
        {
            service = new Service();
            try
            {
                var result = service.GetHID("4160262661",
    new DO_IDENTIFIER { Assigner = "", ID = "11116", Issuer = "", Type = "" },
    new DO_CODED_TEXT { Coded_string = "1" },
    new DO_IDENTIFIER { Assigner = "", ID = "3E87DC76-A67A-4A77-B0F6-39D6AEBF2A42", Issuer = "", Type = "" });
                result = service.GetHID("62661",
                    new DO_IDENTIFIER { Assigner = "", ID = "11116", Issuer = "", Type = "" },
                    new DO_CODED_TEXT { Coded_string = "1" },
                    new DO_IDENTIFIER { Assigner = "", ID = "3E87DC76-A67A-4A77-B0F6-39D6AEBF2A42", Issuer = "", Type = "" });
                result = service.GetHID("62661555555555555",
                    new DO_IDENTIFIER { Assigner = "", ID = "11116", Issuer = "", Type = "" },
                    new DO_CODED_TEXT { Coded_string = "1" },
                    new DO_IDENTIFIER { Assigner = "", ID = "3E87DC76-A67A-4A77-B0F6-39D6AEBF2A42", Issuer = "", Type = "" });
                result = service.GetHID("62661555555555555",
                    new DO_IDENTIFIER { Assigner = "", ID = "11116", Issuer = "", Type = "" },
                    new DO_CODED_TEXT { Coded_string = "1" },
                    new DO_IDENTIFIER { Assigner = "", ID = "3E87DC76-A67A-4A77-B0F6-39D6AEBF2A42", Issuer = "", Type = "" });
            }
            catch (ArgumentException ex)
            {
                StringAssert.Contains(ex.Message, "The value of");

                return;
            }
            Assert.Fail("the expected exception was not thrown");

        }

    }
}
