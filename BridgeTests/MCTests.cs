using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bridge;
using System;

namespace MCUnitTestAfAlleMetoder
{
    [TestClass()]
    public class MCUnitTestAfAlleMetoder
    {
        [TestMethod()]
        public void PriceTest()
        {
            // Arrange
            var mC = new MC();

            // Act
            var price = mC.Price();

            // Assert
            Assert.AreEqual(120, price);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            // Arrange
            var mC = new MC();

            // Act
            var vehicleType = mC.vihicleType();

            // Assert
            Assert.AreEqual("MC", vehicleType);
        }
    }
}
