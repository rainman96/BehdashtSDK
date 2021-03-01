using Ditas.SDK;
using Ditas.SDK.DataModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SDK_Test
{
    [TestClass]
    public class GetHIDurgent_Test
    {
        private Service service;

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
        public void GetHIDurgent_PersonNull()
        {
            service = new Service();
            try
            {
                var result = service.GetHIDurgent(
                     null,
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
        public void GetHIDurgent_HealthNull()
        {
            service = new Service();
            try
            {
                var result = service.GetHIDurgent(
                    new DO_IDENTIFIER { Assigner = "", ID = "4160262661", Issuer = "", Type = "" },
                    null,
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
        public void GetHIDurgent_InsurrerNull()
        {
            service = new Service();
            try
            {
                var result = service.GetHIDurgent(
                    new DO_IDENTIFIER { Assigner = "", ID = "4160262661", Issuer = "", Type = "" },
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
        [TestMethod]
        public void GetHIDurgent_RefferalNull()
        {
            service = new Service();
            try
            {
                var result = service.GetHIDurgent(
                    new DO_IDENTIFIER { Assigner = "", ID = "4160262661", Issuer = "", Type = "" },
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
