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
            var vehicleType = mC.VehicleType();

            // Assert
            Assert.AreEqual("MC", vehicleType);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void LicenseplateTooLongTest()
        {
            // Arrange
            var mC = new MC();

            // Act
            mC.Licenseplate = "ABCDEFGH"; // 8 characters, should throw exception
        }

        [TestMethod()]
        public void LicenseplateValidTest()
        {
            // Arrange
            var mC = new MC();

            // Act
            mC.Licenseplate = "ABC1234"; // 7 characters, should be valid

            // Assert
            Assert.AreEqual("ABC1234", mC.Licenseplate);
        }

        [TestMethod()]
        public void PriceWithBrobizzTest()
        {
            // Arrange
            var mC = new MC { IsBrobizzUsed = true };

            // Act
            var price = mC.Price();

            // Assert
            Assert.AreEqual(108, price, 0.01); // 10% discount on 120 is 108
        }
    }
}
