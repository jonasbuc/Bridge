using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundTicketLibrary;
using System;

namespace OresundTicketLibraryTests
{
    [TestClass()]
    public class OresundCarTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            // Arrange 
            var car = new OresundCar();

            // Act 
            var price = car.Price();

            // Assert 
            Assert.AreEqual(460, price);
        }

        [TestMethod()]
        public void PriceWithBrobizzTest()
        {
            // Arrange 
            var car = new OresundCar { IsBrobizzUsed = true };

            // Act 
            var price = car.Price();

            // Assert 
            Assert.AreEqual(178, price);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            // Arrange 
            var car = new OresundCar();

            // Act 
            var vehicleType = car.VehicleType();

            // Assert 
            Assert.AreEqual("Oresund car", vehicleType);
        }
    }
}
