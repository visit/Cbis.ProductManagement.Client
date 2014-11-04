using System;
using System.Globalization;
using Cbis.ProductManagement.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cbis.ProductManagement.Client_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //InformationDataFactory fac = new InformationDataFactory();
            //BoolAttributesFactory boolFac = new BoolAttributesFactory();
            // boolFac.CreateLocationNearAirport()
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreateStarRatingTooLow()
        {
            InformationDataFactory fac = new InformationDataFactory();
            fac.CreateStarRating(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreateStarRatingTooHigh()
        {
            InformationDataFactory fac = new InformationDataFactory();
            fac.CreateStarRating(6);
        }

        [TestMethod]
        public void CreateStarRatingLow()
        {
            InformationDataFactory fac = new InformationDataFactory();
            var item = fac.CreateStarRating(1);

            Assert.AreEqual(new InformationDataInt(CultureInfo.InvariantCulture, 151, 1), item);
        }

        [TestMethod]
        public void CreateStarRatingHigh()
        {
            InformationDataFactory fac = new InformationDataFactory();
            var item = fac.CreateStarRating(5);

            Assert.AreEqual(new InformationDataInt(CultureInfo.InvariantCulture, 151, 5), item);
        }
    }
}
