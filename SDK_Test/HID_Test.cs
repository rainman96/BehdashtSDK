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
    public class HID_Test
    {
        private Service service;

        [TestMethod]
        public void GetHID_OK()
        {
            service = new Service();
            var result = service.GetHID("2092359551",//2092359551
                new DO_IDENTIFIER { Assigner = "", ID = "11116", Issuer = "", Type = "" },
                new DO_CODED_TEXT { Coded_string = "1" },
                new DO_IDENTIFIER { Assigner = "", ID = "3E87DC76-A67A-4A77-B0F6-39D6AEBF2A42", Issuer = "", Type = "" });
            Assert.IsNotNull(result);
            Console.WriteLine(result.ID);
        }
        [TestMethod]
        public void GetHID_BadNationalCode()
        {
            service = new Service();
            try
            {
                var result = service.GetHID("0000000000",
    new DO_IDENTIFIER { Assigner = "", ID = "11116", Issuer = "", Type = "" },
    new DO_CODED_TEXT { Coded_string = "1" },
    new DO_IDENTIFIER { Assigner = "", ID = "3E87DC76-A67A-4A77-B0F6-39D6AEBF2A42", Issuer = "", Type = "" });
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "The value of");

                return;
            }
            Assert.Fail("the expected exception was not thrown");

        }
        [TestMethod]
        public void GetHID_Health_Null()
        {
            service = new Service();
            try
            {
                var result = service.GetHID("2092359551", null,
    new DO_CODED_TEXT { Coded_string = "1" },
    new DO_IDENTIFIER { Assigner = "", ID = "3E87DC76-A67A-4A77-B0F6-39D6AEBF2A42", Issuer = "", Type = "" });
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "The value of");

                return;
            }
            Assert.Fail("the expected exception was not thrown");

        }
        [TestMethod]
        public void GetHID_Issuer_Null()
        {
            service = new Service();
            try
            {
                var result = service.GetHID("2092359551",
                    new DO_IDENTIFIER { Assigner = "", ID = "11116", Issuer = "", Type = "" },
                    null,
                    new DO_IDENTIFIER { Assigner = "", ID = "3E87DC76-A67A-4A77-B0F6-39D6AEBF2A42", Issuer = "", Type = "" });
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "The value of");

                return;
            }
            Assert.Fail("the expected exception was not thrown");

        }
        public void GetHID_Refferal_Null()
        {
            service = new Service();
            try
            {
                var result = service.GetHID("2092359551",
                    new DO_IDENTIFIER { Assigner = "", ID = "11116", Issuer = "", Type = "" },
                    new DO_CODED_TEXT { Coded_string = "1" },
                    null);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "The value of");

                return;
            }
            Assert.Fail("the expected exception was not thrown");

        }
    }
}
