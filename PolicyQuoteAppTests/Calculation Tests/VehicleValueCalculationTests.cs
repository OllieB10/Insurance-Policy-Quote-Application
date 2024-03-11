using InsurancePolicyQuote.Logic;
using InsurancePolicyQuoteUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyQuoteAppTests
{
    [TestClass]
    public class VehicleValueCalculationTests
    {
        IVehicle vehicle = Factory.CreateVehicle();
        ICalculation calculation = Factory.Calculation();

        [TestMethod]
        public void CalculateVehicleValue_09999_ShouldMatch()
        {
            // Assess
            vehicle.EstimatedValue = 5032;

            // Act
            decimal outcome = 1000.00M * calculation.CalculateVehicleValue(vehicle);

            //Assert
            Assert.AreEqual(1050.00M, outcome);
        }

        [TestMethod]
        public void CalculateVehicleValue_09999_ShouldNotMatch()
        {
            // Assess
            vehicle.EstimatedValue = 5000.00M;
          
            // Act
            decimal outcome = 1000.00M * calculation.CalculateVehicleValue(vehicle);

            //Assert
            Assert.AreNotEqual(1049.00M, outcome);
        }

        [TestMethod]
        public void CalculateVehicleValue_1000019999_ShouldMatch()
        {
            // Assess
            vehicle.EstimatedValue = 13500.00M;

            // Act
            decimal outcome = 1000.00M * calculation.CalculateVehicleValue(vehicle);

            //Assert
            Assert.AreEqual(1020.00M, outcome);
        }

        [TestMethod]
        public void CalculateVehicleValue_1000019999_ShouldNotMatch()
        {
            // Assess
            vehicle.EstimatedValue = 5000.00M;

            // Act
            decimal outcome = 1000.00M * calculation.CalculateVehicleValue(vehicle);

            //Assert
            Assert.AreNotEqual(1049.00M, outcome);
        }

        [TestMethod]
        public void CalculateVehicleValue_20000Plus_ShouldMatch()
        {
            // Assess
            vehicle.EstimatedValue = 22543.16M;

            // Act
            decimal outcome = 1000.00M * calculation.CalculateVehicleValue(vehicle);

            //Assert
            Assert.AreEqual(1030.00M, outcome);
        }

        [TestMethod]
        public void CalculateVehicleValue_20000Plus_ShouldNotMatch()
        {
            // Assess
            vehicle.EstimatedValue = 21500.25M;

            // Act
            decimal outcome = 1000.00M * calculation.CalculateVehicleValue(vehicle);

            //Assert
            Assert.AreNotEqual(1049.00M, outcome);
        }
    }
}
