using InsurancePolicyQuote.Logic;
using InsurancePolicyQuoteUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyQuoteAppTests
{
    [TestClass]
    public class GenderTests
    {
        IPersonInputDetails personInputDetails = Factory.CreatePersonInputDetails();

        [TestMethod]
        public void Gender_Male_Tests_ShouldMatch()
        {
            // Assess
            string genderAnswer = "MALE";

            // Act
            Gender gender = personInputDetails.GetValidGender(genderAnswer);

            //Assert
            Assert.AreEqual(Gender.Male, gender);
        }

        [TestMethod]
        public void Gender_Male_Tests_ShouldNotMatch()
        {
            // Assess
            string genderAnswer = "FEMALE";

            // Act
            Gender gender = personInputDetails.GetValidGender(genderAnswer);

            //Assert
            Assert.AreNotEqual(Gender.Male, gender);
        }

        [TestMethod]
        public void Gender_Female_Tests_ShouldMatch()
        {
            // Assess
            string genderAnswer = "female";

            // Act
            Gender gender = personInputDetails.GetValidGender(genderAnswer);

            //Assert
            Assert.AreEqual(Gender.Female, gender);
        }

        [TestMethod]
        public void Gender_Female_Tests_ShouldNotMatch()
        {
            // Assess
            string genderAnswer = "Male";

            // Act
            Gender gender = personInputDetails.GetValidGender(genderAnswer);

            //Assert
            Assert.AreNotEqual(Gender.Female, gender);
        }

        [TestMethod]
        public void Gender_Other_Tests_ShouldMatch()
        {
            // Assess
            string genderAnswer = "otheR";

            // Act
            Gender gender = personInputDetails.GetValidGender(genderAnswer);

            //Assert
            Assert.AreEqual(Gender.Other, gender);
        }

        [TestMethod]
        public void Gender_Other_Tests_ShouldNotMatch()
        {
            // Assess
            string genderAnswer = "OTHER";

            // Act
            Gender gender = personInputDetails.GetValidGender(genderAnswer);

            //Assert
            Assert.AreNotEqual(Gender.Female, gender);
        }
    }
}
