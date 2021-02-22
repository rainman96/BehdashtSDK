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
    public class GetPerson_Test
    {

        private Service service;
        [TestMethod]
        public void GetPersonInfo_OK()
        {
            service = new Service();
            var result = service.GetPersonByBirth("4569962343", 13650630);
            Assert.IsNotNull(result);
            Console.WriteLine(result.FirstName, result.LastName);
        }
        [TestMethod]
        public void GetPersonInfo_LessNationlCode()
        {
            service = new Service();
            try
            {
                var result = service.GetPersonByBirth("45699", 13650630);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "The value of");
                return;
            }
            Assert.Fail("the expected exception was not thrown");
        }
        [TestMethod]
        public void GetPersonInfo_LongNationlCode()
        {
            service = new Service();
            try
            {
                var result = service.GetPersonByBirth("45665465465464599", 13650630);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "The value of");
                return;
            }
            Assert.Fail("the expected exception was not thrown");
        }
        [TestMethod]
        public void GetPersonInfo_InvalidNationlCode()
        {
            service = new Service();
            try
            {
                var result = service.GetPersonByBirth("asdasd", 13650630);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "The value of");
                return;
            }
            Assert.Fail("the expected exception was not thrown");
        }
        [TestMethod]
        public void GetPersonInfo_EmptyNationlCode()
        {
            service = new Service();
            try
            {
                var result = service.GetPersonByBirth("", 13650630);
            }
            catch (ArgumentException ex)
            {
                StringAssert.Contains(ex.Message, "The value of");
                return;
            }
            Assert.Fail("the expected exception was not thrown");
        }
        [TestMethod]
        public void GetPersonInfo_NullNationlCode()
        {
            service = new Service();
            try
            {
                var result = service.GetPersonByBirth(null, 13650630);

            }
            catch (ArgumentException ex)
            {
                StringAssert.Contains(ex.Message, "The value of");
                return;
            }
            Assert.Fail("the expected exception was not thrown");
        }
        [TestMethod]
        public void GetPersonInfo_BadDate()
        {
            service = new Service();
            try
            {
                var result = service.GetPersonByBirth("4569962343", 0);
            }
            catch (ArgumentException ex)
            {
                StringAssert.StartsWith(ex.Message, "Invalid");
                return;
            }
            Assert.Fail("the expected exception was not thrown");
        }
        [TestMethod]
        public void GetPersonInfo_NegetiveDate()
        {
            service = new Service();
            try
            {
                var result = service.GetPersonByBirth("4569962343", -10);
            }
            catch (ArgumentException ex)
            {
                StringAssert.StartsWith(ex.Message, "Invalid");
                return;
            }
            Assert.Fail("the expected exception was not thrown");
        }
        [TestMethod]
        public void GetPersonInfo_TotalBadReq()
        {
            service = new Service();
            try
            {
                var result = service.GetPersonByBirth("", -10);
            }
            catch (ArgumentException ex)
            {
                if (ex.Message.StartsWith("The value of"))
                {
                    StringAssert.Contains(ex.Message, "The value of");
                    return;
                }

                if (ex.Message.StartsWith("Invalid"))
                {
                    StringAssert.StartsWith(ex.Message, "Invalid");
                    return;
                }
            }

            Assert.Fail("the expected exception was not thrown");
        }
    }
}
