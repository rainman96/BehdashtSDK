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
    public class GetHealthCareProviderInfo
    {

        private Service service;
        [TestMethod]
        public void GetPersonInfo_OK()
        {
            service = new Service();
            var result = service.GetHealthCareProviderInfo(new DO_IDENTIFIER {ID= "100122", Type= "MD" });
            Assert.IsNotNull(result);
            Console.WriteLine(result.FirstName, result.LastName);
        }
        [TestMethod]
        public void GetPersonInfo_Bad_Req()
        {
            service = new Service();
            try
            {
                var result = service.GetHealthCareProviderInfo(new DO_IDENTIFIER { ID = "100", Type = "TR" });

            }
            catch (NullReferenceException ex)
            {
                StringAssert.Equals(ex.Message, "اطلاعات یافت نشد");
                return;
            }
            Assert.Fail("the expected exception was not thrown");
        }
        [TestMethod]
        public void GetPersonInfo_ID_Empty()
        {
            service = new Service();
            try
            {
                var result = service.GetHealthCareProviderInfo(new DO_IDENTIFIER { ID = "", Type = "" });

            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "The value of");
                return;
            }
            Assert.Fail("the expected exception was not thrown");
        }
        [TestMethod]
        public void GetPersonInfo_Type_Empty()
        {
            service = new Service();
            try
            {
                var result = service.GetHealthCareProviderInfo(new DO_IDENTIFIER { ID = "", Type = "" });

            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "The value of");
                return;
            }
            Assert.Fail("the expected exception was not thrown");
        }
        [TestMethod]
        public void GetPersonInfo_Null()
        {
            service = new Service();
            try
            {
                var result = service.GetHealthCareProviderInfo(null);

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
