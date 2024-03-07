using InsurancePolicyQuote.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InsurancePolicyQuoteUI;

namespace PolicyQuoteAppTests
{
    [TestClass]
    public class NCBTests
    {
        ICoverInputDetails coverInputDetails = Factory.CreateCoverInputDetails();

        [TestMethod]
        public void NCB2Test()
        {
            // Assess
            string ncdAnswer = "2";

            // Act
            NCB ncb = coverInputDetails.GetNCDAmount(ncdAnswer);

            // Assert
            Assert.AreEqual(NCB.Two, ncb);
        }

        [TestMethod]
        public void NCB1Test()
        {
            // Assess
            string ncdAnswer = "1";

            // Act
            NCB ncb = coverInputDetails.GetNCDAmount(ncdAnswer);

            // Assert
            Assert.AreEqual(NCB.One, ncb);
        }

        [TestMethod]
        public void NCB0Test()
        {
            // Assess
            string ncdAnswer = "0";

            // Act
            NCB ncb = coverInputDetails.GetNCDAmount(ncdAnswer);

            // Assert
            Assert.AreEqual(NCB.Zero, ncb);
        }
    }
}
