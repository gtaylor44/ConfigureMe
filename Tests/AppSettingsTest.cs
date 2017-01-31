using System.Collections.Generic;
using ConfigureMe;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests.SiteSettings;

namespace Tests
{
    [TestClass]
    public class AppSettingsTest
    {
        private IAppSettings _appSettings;

        [TestInitialize]
        public void TestInitialize()
        {
            _appSettings = new AppSettings();
        }

        [TestMethod]
        public void StringTest_ReturnsCorrectValue_WhenKeyIsValid()
        {

            string result = _appSettings.GetString(CoreConfig.ServerErrorMessage);

            Assert.AreEqual("There was an error processing your request.", result);

        }

        [TestMethod]
        public void StringListTest_ReturnsCorrectValue_WhenKeyIsValid()
        {

            string[] result = _appSettings.GetStringList(AdminConfig.PeopleWithPower, ',');

            Assert.AreEqual(result[0], "Greg");
            Assert.AreEqual(result[1], "Trump");
        }

        [TestMethod]
        public void BoolTest_ReturnsCorrectValue_WhenKeyIsValid()
        {
            bool result = _appSettings.GetBool(BlogConfig.BlogsEnabled);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntTest_ReturnsCorrectValue_WhenKeyIsValid()
        {
            int result = _appSettings.GetInt(BlogConfig.MaxBlogsPerPage);

            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void FloatTest_ReturnsCorrectValue_WhenKeyIsValid()
        {
            float result = _appSettings.GetFloat(AdminConfig.BabySubscription);

            Assert.AreEqual(4.95F, result);
        }

        [TestMethod]
        public void DoubleTest_ReturnsCorrectValue_WhenKeyIsValid()
        {
            double result = _appSettings.GetDouble(AdminConfig.StandardSubscription);

            Assert.AreEqual(19.95D, result);
        }

        [TestMethod]
        public void DecimalTest_ReturnsCorrectValue_WhenKeyIsValid()
        {
            decimal result = _appSettings.GetDecimal(AdminConfig.PremiumSubscription);

            Assert.AreEqual(49.95M, result);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void StringListTest_ThrowsException_WhenKeyIsNotFound()
        {
            _appSettings.GetStringList(CoreConfig.ImNotInConfigFile, ';');
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void BoolTest_ThrowsException_WhenKeyIsNotFound()
        {
            _appSettings.GetBool(CoreConfig.ImNotInConfigFile);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void IntTest_ThrowsException_WhenKeyIsNotFound()
        {
            _appSettings.GetInt(CoreConfig.ImNotInConfigFile);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void FloatTest_ThrowsException_WhenKeyIsNotFound()
        {
            _appSettings.GetFloat(CoreConfig.ImNotInConfigFile);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void DoubleTest_ThrowsException_WhenKeyIsNotFound()
        {
            _appSettings.GetDouble(CoreConfig.ImNotInConfigFile);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void DecimalTest_ThrowsException_WhenKeyIsNotFound()
        {
            _appSettings.GetDecimal(CoreConfig.ImNotInConfigFile);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void GuidTest_ThrowsException_WhenKeyIsNotFound()
        {
            _appSettings.GetGuid(CoreConfig.ImNotInConfigFile);
        }
    }
}
