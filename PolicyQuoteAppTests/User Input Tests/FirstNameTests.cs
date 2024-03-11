using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyQuoteAppTests
{
    [TestClass]
    public class PersonDetailsTest
    {
        IValidateUserInput ValidateUserInput = Factory.ValidateUserInput();
    
        [TestMethod]
        public void GetValidUserInput_GetValid_ReturnString()
        {
            //Arrange
            string userInput = "Ollie";

            //Act
            string firstName = ValidateUserInput.GetValidUserInput(userInput);

            //Assert
            Assert.AreEqual(userInput, firstName);         
        }
    }
}
