using InsurancePolicyQuote.Logic;
using InsurancePolicyQuoteUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyQuoteAppTests
{ 
    [TestClass]
    public class RelationshipStatusTests
    {
        IPersonInputDetails personInputDetails = Factory.CreatePersonInputDetails();

        [TestMethod] 
        public void RelationshipStatus_Single_ShouldMatch()
        {
            // Assume
            string relationshipStatus = "SINGLE";

            var output = personInputDetails.GetValidRelationshipStatus(relationshipStatus);

            // Assert
            Assert.AreEqual(RelationshipStatus.Single, output);
        }

        [TestMethod]
        public void RelationshipStatus_Married_ShouldNotMatch()
        {
            // Assume
            string relationshipStatus = "MARRIED";

            var output = personInputDetails.GetValidRelationshipStatus(relationshipStatus);

            // Assert
            Assert.AreNotEqual(RelationshipStatus.Single, output);
        }

        [TestMethod]
        public void RelationshipStatus_Separated_ShouldNotMatch()
        {
            // Assume
            string relationshipStatus = "SEPARATED";

            var output = personInputDetails.GetValidRelationshipStatus(relationshipStatus);

            // Assert
            Assert.AreNotEqual(RelationshipStatus.Separated, output);
        }

        [TestMethod]
        public void RelationshipStatus_Divorced_ShouldMatch()
        {
            // Assume
            string relationshipStatus = "DIVorced ";

            var output = personInputDetails.GetValidRelationshipStatus(relationshipStatus);

            // Assert
            Assert.AreEqual(RelationshipStatus.Divorced, output);
        }
    }
}
