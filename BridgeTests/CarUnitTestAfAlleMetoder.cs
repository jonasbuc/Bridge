using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bridge;
using System;

namespace CarUnitTestAfAlleMetoder
{
    [TestClass()]
    public class CarUnitTestAfAlleMetoder
    {
        [TestMethod()]
        public void PriceTest()
        {
            // Arrange
            var car = new Car();

            // Act
            var price = car.Price();

            // Assert
            Assert.AreEqual(230, price);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            // Arrange
            var car = new Car();

            // Act
            var vehicleType = car.VehicleType();

            // Assert
            Assert.AreEqual("Car", vehicleType);
        }
    }
}
