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
    public class SavePatientBill_Test
    {
        private Service service;

        [TestMethod]
        public void GetHID_OK()
        {
            service = new Service();
            var result = service.SavePatientBill(Ditas.SDK.Helper.Utilities.GetModelFromXmlFile<PatientBillMessageVO>(@"XmlSamplePackets\PatientBill\1.xml"));
            Assert.IsNotNull(result);
        }
    
    }
}
