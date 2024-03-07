using InsurancePolicyQuote.Logic;
using InsurancePolicyQuoteUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyQuoteAppTests
{
    [TestClass]
    public class LastNameTests
    {
        IValidateUserInput validateUserInput = Factory.ValidateUserInput();

        [TestMethod]
        public void ValidInput_LastName_Tests()
        {
            // Arrange
            string lastName = "Brennan";

            // Act
            string actual = validateUserInput.GetValidUserInput(lastName);

            // Assert
            Assert.AreEqual(lastName, actual);
        }

        [TestMethod]
        public void InValidInput_LastName_Tests()
        {
            // Arrange
            string lastName = "Brennn(*&^%";

            // Act
            string actual = validateUserInput.GetValidUserInput("Brennn(*&^%");

            // Assert
            Assert.AreEqual(lastName, actual);
        }
    }
}
