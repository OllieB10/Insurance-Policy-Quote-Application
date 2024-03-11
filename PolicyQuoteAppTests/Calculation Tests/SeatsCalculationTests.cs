using InsurancePolicyQuote.Logic;
using InsurancePolicyQuoteUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyQuoteAppTests
{
    [TestClass]
    public class SeatsCalculationTests
    {
        IVehicle vehicle = Factory.CreateVehicle();
        ICalculation calculation = Factory.Calculation();

        [TestMethod]
        public void CalculateSeats_Five_ShouldMatch()
        {
            // Arrange
            vehicle.NoOfSeats = 5;

            // Act
            var outcome = 1000.00M * calculation.CalculateVehicleSeatsRate(vehicle);

            // Assert
            Assert.AreEqual(1080.00M, outcome);
        }

        [TestMethod]
        public void CalculateSeats_Five_ShouldNotMatch()
        {
            // Arrange
            vehicle.NoOfSeats = 5;

            // Act
            var outcome = 1000.00M * calculation.CalculateVehicleSeatsRate(vehicle);

            // Assert
            Assert.AreNotEqual(1200.01M, outcome);
        }

        [TestMethod]
        public void CalculateSeats_Six_ShouldMatch()
        {
            // Arrange
            vehicle.NoOfSeats = 6;

            // Act
            var outcome = 1000.00M * calculation.CalculateVehicleSeatsRate(vehicle);

            // Assert
            Assert.AreEqual(1120.00M, outcome);
        }

        [TestMethod]
        public void CalculateSeats_Six_ShouldNotMatch()
        {
            // Arrange
            vehicle.NoOfSeats = 6;

            // Act
            var outcome = 1000.00M * calculation.CalculateVehicleSeatsRate(vehicle);

            // Assert
            Assert.AreNotEqual(2490.00M, outcome);
        }

        [TestMethod]
        public void CalculateSeats_Seven_ShouldMatch()
        {
            // Arrange
            vehicle.NoOfSeats = 7;
            
            // Act
            var outcome = 1000.00M * calculation.CalculateVehicleSeatsRate(vehicle);

            // Assert
            Assert.AreEqual(1140.00M, outcome);
        }

        [TestMethod]
        public void CalculateSeats_Seven_ShouldNotMatch()
        {
            // Arrange
            vehicle.NoOfSeats = 7;

            // Act
            var outcome = 1000.00M * calculation.CalculateVehicleSeatsRate(vehicle);

            // Assert
            Assert.AreNotEqual(0.25M, outcome);
        }

        [TestMethod]
        public void CalculateSeats_Eight_ShouldMatch()
        {
            // Arrange
            vehicle.NoOfSeats = 8;

            // Act
            var outcome = 1000.00M * calculation.CalculateVehicleSeatsRate(vehicle);

            // Assert
            Assert.AreEqual(1160.00M, outcome);
        }

        [TestMethod]
        public void CalculateSeats_Eight_ShouldNotMatch()
        {
            // Arrange
            vehicle.NoOfSeats = 8;

            // Act
            var outcome = 1000.00M * calculation.CalculateVehicleSeatsRate(vehicle);

            // Assert
            Assert.AreNotEqual(2490.00M, outcome);
        }

        [TestMethod]
        public void CalculateSeats_Nine_ShouldMatch()
        {
            // Arrange
            vehicle.NoOfSeats = 9;

            // Act
            var outcome = 1000.00M * calculation.CalculateVehicleSeatsRate(vehicle);

            // Assert
            Assert.AreEqual(1180.00M, outcome);
        }

        [TestMethod]
        public void CalculateSeats_Nine_ShouldNotMatch()
        {
            // Arrange
            vehicle.NoOfSeats = 9;

            // Act
            var outcome = 1000.00M * calculation.CalculateVehicleSeatsRate(vehicle);

            // Assert
            Assert.AreNotEqual(2490.00M, outcome);
        }
    }
}
