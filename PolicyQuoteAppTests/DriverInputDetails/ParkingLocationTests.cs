using InsurancePolicyQuote.Logic;
using InsurancePolicyQuoteUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyQuoteAppTests
{
    [TestClass]
    public class ParkingLocationTests
    {
        IVehicleParkingLocationHandler vehicleParkingLocationHandler = Factory.CreateVehicleParkingLocationHandler();

        [TestMethod]
        public void ParkingLocations_Street_ShouldMatch()
        {
            bool homeTrue = true;

            ParkingLocations parkingOvernight = vehicleParkingLocationHandler.GetParkingLocationOvernight(homeTrue);

            //Assert 
            Assert.AreEqual(ParkingLocations.Street, parkingOvernight);
        }

        [TestMethod]
        public void ParkingLocations_Street_ShouldNotMatch()
        {
            bool homeTrue = true;

            ParkingLocations parkingOvernight = vehicleParkingLocationHandler.GetParkingLocationOvernight(homeTrue);

            //Assert 
            Assert.AreNotEqual(ParkingLocations.Carpark, parkingOvernight);
        }

        [TestMethod]
        public void ParkingLocations_CarPark_ShouldMatch()
        {
            bool homeTrue = false;

            ParkingLocations parkingOvernight = vehicleParkingLocationHandler.GetParkingLocationOvernight(homeTrue);

            //Assert 
            Assert.AreEqual(ParkingLocations.Other, parkingOvernight);
        }

        [TestMethod]
        public void ParkingLocations_CarPark_ShouldNotMatch()
        {
            bool homeTrue = false;

            ParkingLocations parkingOvernight = vehicleParkingLocationHandler.GetParkingLocationOvernight(homeTrue);

            //Assert 
            Assert.AreNotEqual(ParkingLocations.Street, parkingOvernight);
        }
    }
}
