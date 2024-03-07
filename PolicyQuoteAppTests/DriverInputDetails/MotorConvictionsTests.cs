using InsurancePolicyQuote.Logic;
using InsurancePolicyQuoteUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyQuoteAppTests
{
    [TestClass]
    public class MotorConvictionsTests
    {
        IValidateUserInput validateUserInput = Factory.ValidateUserInput();
        [TestMethod]
        public void MotorConvictionsTests_2_ShouldMatch()
        {
            // Assess
            int motorConvictions = validateUserInput.GetValidInteger("2");

            //Assert
            Assert.AreEqual(2, motorConvictions);
        }
    }
}
