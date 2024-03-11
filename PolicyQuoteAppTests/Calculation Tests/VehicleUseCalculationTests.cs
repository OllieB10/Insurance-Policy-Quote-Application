using InsurancePolicyQuote.Logic;
using InsurancePolicyQuoteUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyQuoteAppTests
{
    [TestClass]
    public class VehicleUseCalculationTests
    {
        ICalculation calculation = Factory.Calculation();
        IVehicle vehicle = Factory.CreateVehicle();

       [TestMethod]
        public void CalculateVehicleUse_Private_ShouldMatch()
        {
            // Arrange
            vehicle.VehicleUsage = VehicleUse.PrivateHire;
            
            // Act
            decimal actual = 1000.00M * calculation.CalculateVehicleUse(vehicle.VehicleUsage);

            // Assert
            Assert.AreEqual(1120.00M, actual);
        }

        [TestMethod]
        public void CalculateVehicleUse_Private_ShouldNotMatch()
        {
            // Arrange
            vehicle.VehicleUsage = VehicleUse.PrivateHire;

            // Act
            decimal actual = 1000.00M * calculation.CalculateVehicleUse(vehicle.VehicleUsage);

            // Assert
            Assert.AreNotEqual(1116.00M, actual);
        }

        [TestMethod]
        public void CalculateVehicleUse_Public_ShouldMatch()
        {
            // Arrange
            vehicle.VehicleUsage = VehicleUse.PublicHire;

            // Act
            decimal actual = 1000.00M * calculation.CalculateVehicleUse(vehicle.VehicleUsage);

            // Assert
            Assert.AreEqual(1100.00M, actual);
        }

        [TestMethod]
        public void CalculateVehicleUse_Public_ShouldNotMatch()
        {
            // Arrange
            vehicle.VehicleUsage = VehicleUse.PublicHire;

            // Act
            decimal actual = 1000.00M * calculation.CalculateVehicleUse(vehicle.VehicleUsage);

            // Assert
            Assert.AreNotEqual(1750.00M, actual);
        }

        [TestMethod]
        public void CalculateVehicleUse_Other_ShouldMatch()
        {
            // Arrange
            vehicle.VehicleUsage = VehicleUse.Other;

            // Act
            decimal actual = 1000.00M * calculation.CalculateVehicleUse(vehicle.VehicleUsage);

            // Assert
            Assert.AreEqual(1150.00M, actual);
        }

        [TestMethod]
        public void CalculateVehicleUse_Other_ShouldNotMatch()
        {
            // Arrange
            vehicle.VehicleUsage = VehicleUse.Other;

            // Act
            decimal actual = 1000.00M * calculation.CalculateVehicleUse(vehicle.VehicleUsage);

            // Assert
            Assert.AreNotEqual(1750.00M, actual);
        }
    }
}
