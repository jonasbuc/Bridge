using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundTicketLibrary;
using System;

namespace OresundTicketLibraryTests
{
    [TestClass()]
    public class OresundMCTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            // Arrange
            var mc = new OresundMC();

            // Act
            var price = mc.Price();

            // Assert
            Assert.AreEqual(235, price);
        }

        [TestMethod()]
        public void PriceWithBrobizzTest()
        {
            // Arrange
            var mc = new OresundMC { IsBrobizzUsed = true };

            // Act
            var price = mc.Price();

            // Assert
            Assert.AreEqual(92, price);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            // Arrange
            var mc = new OresundMC();

            // Act
            var vehicleType = mc.VehicleType();

            // Assert
            Assert.AreEqual("Oresund MC", vehicleType);
        }
    }
}
