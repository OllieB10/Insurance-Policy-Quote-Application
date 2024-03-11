using InsurancePolicyQuote.Logic;
using InsurancePolicyQuoteUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyQuoteAppTests
{
    [TestClass]
    public class VehicleValueTests
    {
        IVehicleInputDetails vehicleInputDetails = Factory.CreateVehicleInputDetails();

        [TestMethod]
        public void Estimated_Vehicle_Value_ShouldMatch()
        {
            // Assess
           decimal estimatedValue = vehicleInputDetails.GetEstimatedVehicleValue("10000");

            //Assert
            Assert.AreEqual(10000.00M, estimatedValue);
        }

        [TestMethod]
        public void Estimated_Vehicle_Value_ShouldNotMatch()
        {
            // Assess
            decimal estimatedValue = vehicleInputDetails.GetEstimatedVehicleValue("10000");

            //Assert
            Assert.AreNotEqual(11000.00M, estimatedValue);
        }
    }
}
