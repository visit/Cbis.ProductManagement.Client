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

        [TestMethod]
        public void CreateNuberOfBars()
        {
            InformationDataFactory fac = new InformationDataFactory();
            var item = fac.CreateNumberOfBars(5);

            Assert.AreEqual(new InformationDataInt(CultureInfo.InvariantCulture, 133, 5), item);
        }

        [TestMethod]
        public void CreateNuberOfConferenceRooms()
        {
            InformationDataFactory fac = new InformationDataFactory();
            var item = fac.CreateNumberOfConferenceRooms(5);

            Assert.AreEqual(new InformationDataInt(CultureInfo.InvariantCulture, 132, 5), item);
        }

        [TestMethod]
        public void CreateNuberOfFloors()
        {
            InformationDataFactory fac = new InformationDataFactory();
            var item = fac.CreateNumberOfFloors(5);

            Assert.AreEqual(new InformationDataInt(CultureInfo.InvariantCulture, 131, 5), item);
        }

        [TestMethod]
        public void CreateNuberOfRooms()
        {
            InformationDataFactory fac = new InformationDataFactory();
            var item = fac.CreateNumberOfRooms(5);

            Assert.AreEqual(new InformationDataInt(CultureInfo.InvariantCulture, 130, 5), item);
        }
    }
}
