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
    public class CallUpInsurance_Test
    {

        private Service service;
        [TestMethod]
        public void CallupInsurance_OK()
        {
            service = new Service();
            var result = service.CallupInsurance(
                new DO_IDENTIFIER
                {
                    Issuer = "National_Org_Civil_Reg",
                    Assigner = "National_Org_Civil_Reg",
                    ID = "0079506453",
                    Type = "National_Code"
                },
                new DO_IDENTIFIER
                {
                    Issuer = "MOHME_IT",
                    Assigner = "MOHME_IT",
                    ID = "3E87DC76-A67A-4A77-B0F6-39D6AEBF2A42",
                    Type = "Org_ID"
                }
                );
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void CallupInsurance_No_Insurance()
        {
            service = new Service();
            var result = service.CallupInsurance(
            new DO_IDENTIFIER
            {
                Issuer = "National_Org_Civil_Reg",
                Assigner = "National_Org_Civil_Reg",
                ID = "4569962343",
                Type = "National_Code"
            },
            new DO_IDENTIFIER
            {
                Issuer = "MOHME_IT",
                Assigner = "MOHME_IT",
                ID = "3E87DC76-A67A-4A77-B0F6-39D6AEBF2A42",
                Type = "Org_ID"
            }
            );
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void CallupInsurance_Bad_NIN_Req()
        {
            service = new Service();
            try
            {
                var result = service.CallupInsurance(
                new DO_IDENTIFIER
                {
                    Issuer = "National_Org_Civil_Reg",
                    Assigner = "National_Org_Civil_Reg",
                    ID = "0079506453",
                    Type = "National_Code"
                },
                new DO_IDENTIFIER
                {
                    Issuer = "MOHME_IT",
                    Assigner = "MOHME_IT",
                    ID = "3E87DC76-A67A-4A77-B0F6-",
                    Type = "Org_ID"
                }
                );

            }
            catch (NullReferenceException ex)
            {
                StringAssert.Equals(ex.Message, "اطلاعات یافت نشد");
                return;
            }
            Assert.Fail("the expected exception was not thrown");
        }
        [TestMethod]
        public void CallupInsurance_Bad_PID_Req()
        {
            service = new Service();
            try
            {
                var result = service.CallupInsurance(
                new DO_IDENTIFIER
                {
                    Issuer = "National_Org_Civil_Reg",
                    Assigner = "National_Org_Civil_Reg",
                    ID = "00795",
                    Type = "National_Code"
                },
                new DO_IDENTIFIER
                {
                    Issuer = "MOHME_IT",
                    Assigner = "MOHME_IT",
                    ID = "3E87DC76-A67A-4A77-B0F6-39D6AEBF2A42",
                    Type = "Org_ID"
                }
                );

            }
            catch (NullReferenceException ex)
            {
                StringAssert.Equals(ex.Message, "اطلاعات یافت نشد");
                return;
            }
            Assert.Fail("the expected exception was not thrown");
        }
        [TestMethod]
        public void CallupInsurance_ID_Empty()
        {
            service = new Service();
            try
            {
                var result = service.CallupInsurance(
                new DO_IDENTIFIER
                {
                    Issuer = "National_Org_Civil_Reg",
                    Assigner = "National_Org_Civil_Reg",
                    ID = "0079506453",
                    Type = "National_Code"
                },
                new DO_IDENTIFIER
                {
                    Issuer = "MOHME_IT",
                    Assigner = "MOHME_IT",
                    ID = "3E87DC76-A67A-4A77-B0F6-39D6AEBF2A42",
                    Type = "Org_ID"
                }
                );

            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "The value of");
                return;
            }
            Assert.Fail("the expected exception was not thrown");
        }
        [TestMethod]
        public void CallupInsurance_Type_Empty()
        {
            service = new Service();
            try
            {
                var result = service.CallupInsurance(
                new DO_IDENTIFIER
                {
                    Issuer = "National_Org_Civil_Reg",
                    Assigner = "National_Org_Civil_Reg",
                    ID = "0079506453",
                    Type = "National_Code"
                },
                new DO_IDENTIFIER
                {
                    Issuer = "MOHME_IT",
                    Assigner = "MOHME_IT",
                    ID = "3E87DC76-A67A-4A77-B0F6-39D6AEBF2A42",
                    Type = "Org_ID"
                }
                );

            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "The value of");
                return;
            }
            Assert.Fail("the expected exception was not thrown");
        }
        [TestMethod]
        public void CallupInsurance_Null()
        {
            service = new Service();
            try
            {
                var result = service.CallupInsurance(
                null,
                null
                );

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
