using InsurancePolicyQuote.Logic;
using InsurancePolicyQuoteUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyQuoteAppTests
{
    [TestClass]
    public class VehicleTransmissionTest
    {
        IVehicleInputDetails vehicleInputDetails = Factory.CreateVehicleInputDetails();

        [TestMethod]
        public void VehicleTransmission_Manual_ShouldMatch()
        {
            VehicleTransmission vehicleTransmission = vehicleInputDetails.GetValidVehicleTransmission("MANUAL");

            //Assert
            Assert.AreEqual(VehicleTransmission.Manual, vehicleTransmission);
        }

        [TestMethod]
        public void VehicleTransmission_Manual_ShouldNotMatch()
        {
            VehicleTransmission vehicleTransmission = vehicleInputDetails.GetValidVehicleTransmission("Automatic");

            //Assert
            Assert.AreNotEqual(VehicleTransmission.Manual, vehicleTransmission);
        }

        [TestMethod]
        public void VehicleTransmission_Automatic_ShouldMatch()
        {
            VehicleTransmission vehicleTransmission = vehicleInputDetails.GetValidVehicleTransmission("AUTOMATIC");

            //Assert
            Assert.AreEqual(VehicleTransmission.Automatic, vehicleTransmission);
        }

        [TestMethod]
        public void VehicleTransmission_Automatic_ShouldNotMatch()
        {
            VehicleTransmission vehicleTransmission = vehicleInputDetails.GetValidVehicleTransmission("Automatic");

            //Assert
            Assert.AreNotEqual(VehicleTransmission.Manual, vehicleTransmission);
        }
    }
}
