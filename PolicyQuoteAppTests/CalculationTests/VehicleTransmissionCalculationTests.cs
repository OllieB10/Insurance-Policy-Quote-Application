using InsurancePolicyQuote.Logic;
using InsurancePolicyQuoteUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyQuoteAppTests
{
    [TestClass]
    public class VehicleTransmissionCalculationTests
    {
        ICalculation calculation = Factory.Calculation();

        [TestMethod]
        public void CalculateVehicleTransmission_Automatic_ShouldMatch()
        {
            // Apply
            VehicleTransmission vehicleTransmission = VehicleTransmission.Automatic;

            //Act
            var outcome = 1000.00M * calculation.CalculateVehicleTransmissionRate(vehicleTransmission);

            // Assert
            Assert.AreEqual(1020.00M, outcome);

        }

        [TestMethod]
        public void CalculateVehicleTransmission_Automatic_ShouldNotMatch()
        {
            // Apply
            VehicleTransmission vehicleTransmission = VehicleTransmission.Automatic;

            //Act
            var outcome = 1000 * calculation.CalculateVehicleTransmissionRate(vehicleTransmission);

            // Assert
            Assert.AreNotEqual(22000.00M, outcome);

        }

        [TestMethod]
        public void CalculateVehicleTransmission_Manual_ShouldMatch()
        {
            // Apply
            VehicleTransmission vehicleTransmission = VehicleTransmission.Manual;

            //Act
            var outcome = 1000 * calculation.CalculateVehicleTransmissionRate(vehicleTransmission);

            // Assert
            Assert.AreEqual(1050.00M, outcome);

        }

        [TestMethod]
        public void CalculateVehicleTransmission_Manual_ShouldNotMatch()
        {
            // Apply
            VehicleTransmission vehicleTransmission = VehicleTransmission.Manual;

            //Act
            var outcome = 1000 * calculation.CalculateVehicleTransmissionRate(vehicleTransmission);

            // Assert
            Assert.AreNotEqual(22000.00M, outcome);

        }
    }
}
