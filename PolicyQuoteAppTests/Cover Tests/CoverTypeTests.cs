using InsurancePolicyQuote.Logic;
using InsurancePolicyQuoteUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyQuoteAppTests
{
    [TestClass]
    public class CoverTypeTests
    {
        ICoverInputDetails coverInputDetails = Factory.CreateCoverInputDetails();

        [TestMethod]
        public void CoverType_Comprehensive_ShouldMatch()
        {
            // Assess
            CoverType cover = coverInputDetails.GetCoverType("Comprehensive");

            //Assert
            Assert.AreEqual(CoverType.Comprehensive, cover);
        }

        [TestMethod]
        public void CoverType_Comprehensive_ShouldNotMatch()
        {
            // Assess
            CoverType cover = coverInputDetails.GetCoverType("THIRD PARTY FIRE and THEFT");

            //Assert
            Assert.AreNotEqual(CoverType.Comprehensive, cover);
        }

        [TestMethod]
        public void CoverType_ThirdPartyFireTheft_ShouldMatch()
        {
            // Assess
            CoverType cover = coverInputDetails.GetCoverType("THIRD PARTY FIRE and THEFT");

            //Assert
            Assert.AreEqual(CoverType.ThirdPartyFireAndTheft, cover);
        }

        [TestMethod]
        public void CoverType_ThirdPartyFireTheft_ShouldNotMatch()
        {
            // Assess
            CoverType cover = coverInputDetails.GetCoverType("THIRD PARTY FIRE and THEFT");

            //Assert
            Assert.AreNotEqual(CoverType.Comprehensive, cover);
        }

        [TestMethod]
        public void CoverType_ThirdPartyOnly_ShouldMatch()
        {
            // Assess
            CoverType cover = coverInputDetails.GetCoverType("THIRD PARTY ONLY");

            //Assert
            Assert.AreEqual(CoverType.ThirdPartyOnly, cover);
        }

        [TestMethod]
        public void CoverType_ThirdPartyOnly_ShouldNotMatch()
        {
            // Assess
            CoverType cover = coverInputDetails.GetCoverType("THIRD PARTY ONLY");

            //Assert
            Assert.AreNotEqual(CoverType.Comprehensive, cover);
        }
    }
}
