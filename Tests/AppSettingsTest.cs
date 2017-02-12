using System.Collections.Generic;
using ConfigureMe;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests.SiteSettings;

namespace Tests
{
    [TestClass]
    public class AppSettingsTest
    {

        [TestMethod]
        public void StringTest_ReturnsCorrectValue_WhenKeyIsValid()
        {

            string result = AppSettings.GetString(CoreConfig.ServerErrorMessage);

            Assert.AreEqual("There was an error processing your request.", result);

        }

        [TestMethod]
        public void StringListTest_ReturnsCorrectValue_WhenKeyIsValid()
        {

            string[] result = AppSettings.GetStringList(AdminConfig.PeopleWithPower, ',');

            Assert.AreEqual(result[0], "Greg");
            Assert.AreEqual(result[1], "Trump");
        }

        [TestMethod]
        public void BoolTest_ReturnsCorrectValue_WhenKeyIsValid()
        {
            bool result = AppSettings.GetBool(BlogConfig.BlogsEnabled);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntTest_ReturnsCorrectValue_WhenKeyIsValid()
        {
            int result = AppSettings.GetInt(BlogConfig.MaxBlogsPerPage);

            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void FloatTest_ReturnsCorrectValue_WhenKeyIsValid()
        {
            float result = AppSettings.GetFloat(AdminConfig.BabySubscription);

            Assert.AreEqual(4.95F, result);
        }

        [TestMethod]
        public void DoubleTest_ReturnsCorrectValue_WhenKeyIsValid()
        {
            double result = AppSettings.GetDouble(AdminConfig.StandardSubscription);

            Assert.AreEqual(19.95D, result);
        }

        [TestMethod]
        public void DecimalTest_ReturnsCorrectValue_WhenKeyIsValid()
        {
            decimal result = AppSettings.GetDecimal(AdminConfig.PremiumSubscription);

            Assert.AreEqual(49.95M, result);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void StringListTest_ThrowsException_WhenKeyIsNotFound()
        {
            AppSettings.GetStringList(CoreConfig.ImNotInConfigFile, ';');
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void BoolTest_ThrowsException_WhenKeyIsNotFound()
        {
            AppSettings.GetBool(CoreConfig.ImNotInConfigFile);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void IntTest_ThrowsException_WhenKeyIsNotFound()
        {
            AppSettings.GetInt(CoreConfig.ImNotInConfigFile);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void FloatTest_ThrowsException_WhenKeyIsNotFound()
        {
            AppSettings.GetFloat(CoreConfig.ImNotInConfigFile);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void DoubleTest_ThrowsException_WhenKeyIsNotFound()
        {
            AppSettings.GetDouble(CoreConfig.ImNotInConfigFile);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void DecimalTest_ThrowsException_WhenKeyIsNotFound()
        {
            AppSettings.GetDecimal(CoreConfig.ImNotInConfigFile);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void GuidTest_ThrowsException_WhenKeyIsNotFound()
        {
            AppSettings.GetGuid(CoreConfig.ImNotInConfigFile);
        }
    }
}
