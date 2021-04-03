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
            try
            {
                service = new Service();
                var result = service.SaveMedicationPrescription(Utilities.GetModelFromXmlFile<MedicationPrescriptionsMessageVO>("PrescriptionReq.txt"));
                Assert.IsNotNull(result);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [TestMethod]
        public void SaveMedicationPrescription_Json()
        {
            try
            {
                service = new Service();
                var result = service.SaveMedicationPrescription(Utilities.JsonTextToModel<MedicationPrescriptionsMessageVO>(File.ReadAllText("JsonPrescriptionReq.txt")));
                Assert.IsNotNull(result);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Parameter name:");

                return;
            }
            Assert.Fail("the expected exception was not thrown");
        }


    }
}
