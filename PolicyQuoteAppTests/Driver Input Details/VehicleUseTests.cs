using InsurancePolicyQuote.Logic;
using InsurancePolicyQuoteUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyQuoteAppTests
{
    [TestClass]
    public class VehicleUseTests
    {
        IVehicleInputDetails vehicleInputDetails = Factory.CreateVehicleInputDetails();

        [TestMethod]
        public void VehicleUse_Private_ShouldMatch()
        {
            VehicleUse vehicleUse = vehicleInputDetails.GetVehicleUsage("Private");

            Assert.AreEqual(VehicleUse.PrivateHire, vehicleUse);
        }

        [TestMethod]
        public void VehicleUse_Private_ShouldNotMatch()
        {
            VehicleUse vehicleUse = vehicleInputDetails.GetVehicleUsage("Private");

            Assert.AreNotEqual(VehicleUse.PublicHire, vehicleUse);
        }

        [TestMethod]
        public void VehicleUse_Public_ShouldMatch()
        {
            VehicleUse vehicleUse = vehicleInputDetails.GetVehicleUsage("PUBLIC");

            Assert.AreEqual(VehicleUse.PublicHire, vehicleUse);
        }

        [TestMethod]
        public void VehicleUse_Public_ShouldNotMatch()
        {
            VehicleUse vehicleUse = vehicleInputDetails.GetVehicleUsage("PUBLIC");

            Assert.AreNotEqual(VehicleUse.PrivateHire, vehicleUse);
        }

        [TestMethod]
        public void VehicleUse_Other_ShouldMatch()
        {
            VehicleUse vehicleUse = vehicleInputDetails.GetVehicleUsage("OTHER");

            Assert.AreEqual(VehicleUse.Other, vehicleUse);
        }

        [TestMethod]
        public void VehicleUse_Other_ShouldNotMatch()
        {
            VehicleUse vehicleUse = vehicleInputDetails.GetVehicleUsage("Other");

            Assert.AreNotEqual(VehicleUse.PrivateHire, vehicleUse);
        }
    }
}
