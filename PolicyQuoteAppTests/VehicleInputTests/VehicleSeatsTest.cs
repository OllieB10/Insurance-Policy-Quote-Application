using InsurancePolicyQuote.Logic;
using InsurancePolicyQuoteUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyQuoteAppTests
{
    [TestClass]
    public class VehicleSeatsTest
    {
        IVehicleInputDetails vehicleInputDetails = Factory.CreateVehicleInputDetails();

        [TestMethod]
        public void VehicleSeats_5_ShouldMatch()
        {
            // Assess
            string seats = "5";

            // Act
            var outcome = vehicleInputDetails.GetNumberOfSeats(seats);

            // Assert
            Assert.AreEqual(5, outcome);
        }

        [TestMethod]
        public void VehicleSeats_6_ShouldMatch()
        {
            // Assess
            string seats = "6";

            // Act
            var outcome = vehicleInputDetails.GetNumberOfSeats(seats);

            // Assert
            Assert.AreEqual(6, outcome);
        }
    }
}
