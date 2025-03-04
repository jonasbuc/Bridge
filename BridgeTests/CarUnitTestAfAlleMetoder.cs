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
            var car = new Car { Date = new DateTime(2025, 3, 4) }; // A weekday

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

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void LicenseplateTooLongTest()
        {
            // Arrange
            var car = new Car();

            // Act
            car.Licenseplate = "ABCDEFGH"; // 8 characters, should throw exception
        }

        [TestMethod()]
        public void LicenseplateValidTest()
        {
            // Arrange
            var car = new Car();

            // Act
            car.Licenseplate = "ABC1234"; // 7 characters, should be valid

            // Assert
            Assert.AreEqual("ABC1234", car.Licenseplate);
        }

        [TestMethod()]
        public void PriceWithBrobizzTest()
        {
            // Arrange
            var car = new Car { IsBrobizzUsed = true, Date = new DateTime(2025, 3, 4) }; // A weekday

            // Act
            var price = car.Price();

            // Assert
            Assert.AreEqual(207, price, 0.01); // 10% discount on 230 is 207
        }

        [TestMethod()]
        public void PriceWithWeekendDiscountTest()
        {
            // Arrange
            var car = new Car { Date = new DateTime(2025, 3, 8) }; // A Saturday

            // Act
            var price = car.Price();

            // Assert
            Assert.AreEqual(195.5, price, 0.01); // 15% discount on 230 is 195.5
        }

        [TestMethod()]
        public void PriceWithWeekendAndBrobizzDiscountTest()
        {
            // Arrange
            var car = new Car { IsBrobizzUsed = true, Date = new DateTime(2025, 3, 8) }; // A Saturday

            // Act
            var price = car.Price();

            // Assert
            Assert.AreEqual(175.95, price, 0.01); // 15% discount on 230 is 195.5, then 10% discount on 195.5 is 175.95
        }
    }
}
