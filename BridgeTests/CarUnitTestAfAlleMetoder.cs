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
            // Arrange (Opsætning)
            var car = new Car { Date = new DateTime(2025, 3, 4) }; // En hverdag

            // Act (Handling)
            var price = car.Price();

            // Assert (Bekræftelse)
            Assert.AreEqual(230, price);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            // Arrange (Opsætning)
            var car = new Car();

            // Act (Handling)
            var vehicleType = car.VehicleType();

            // Assert (Bekræftelse)
            Assert.AreEqual("Car", vehicleType);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void LicenseplateTooLongTest()
        {
            // Arrange (Opsætning)
            var car = new Car();

            // Act (Handling)
            car.Licenseplate = "ABCDEFGH"; // 8 tegn, bør kaste en undtagelse
        }

        [TestMethod()]
        public void LicenseplateValidTest()
        {
            // Arrange (Opsætning)
            var car = new Car();

            // Act (Handling)
            car.Licenseplate = "ABC1234"; // 7 tegn, bør være gyldig

            // Assert (Bekræftelse)
            Assert.AreEqual("ABC1234", car.Licenseplate);
        }

        [TestMethod()]
        public void PriceWithBrobizzTest()
        {
            // Arrange (Opsætning)
            var car = new Car { IsBrobizzUsed = true, Date = new DateTime(2025, 3, 4) }; // En hverdag

            // Act (Handling)
            var price = car.Price();

            // Assert (Bekræftelse)
            Assert.AreEqual(207, price, 0.01); // 10% rabat på 230 er 207
        }

        [TestMethod()]
        public void PriceWithWeekendDiscountTest()
        {
            // Arrange (Opsætning)
            var car = new Car { Date = new DateTime(2025, 3, 8) }; // En lørdag

            // Act (Handling)
            var price = car.Price();

            // Assert (Bekræftelse)
            Assert.AreEqual(195.5, price, 0.01); // 15% rabat på 230 er 195.5
        }

        [TestMethod()]
        public void PriceWithWeekendAndBrobizzDiscountTest()
        {
            // Arrange (Opsætning)
            var car = new Car { IsBrobizzUsed = true, Date = new DateTime(2025, 3, 8) }; // En lørdag

            // Act (Handling)
            var price = car.Price();

            // Assert (Bekræftelse)
            Assert.AreEqual(175.95, price, 0.01); // 15% rabat på 230 er 195.5, derefter 10% rabat på 195.5 er 175.95
        }
    }
}

