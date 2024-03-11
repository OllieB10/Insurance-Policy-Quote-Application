using InsurancePolicyQuote.Logic;
using InsurancePolicyQuoteUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyQuoteAppTests
{
    [TestClass]
    public class BaseRateTests
    {
        ICalculation calculation = Factory.Calculation();

        [TestMethod]
        public void CalculateBaseRate_NCBNewBadge_ShouldMatchNetPremium()
        {
            // Arrange
            NCB ncb = NCB.NewBadge;

            // Act
            decimal netPremium = calculation.CalculateBaseRate(ncb);

            // Assert
            Assert.AreEqual(2200.00M, netPremium);
        }

        [TestMethod]
        public void CalculateBaseRate_NCBNewBadge_ShouldNotMatchNetPremium()
        {
            // Arrange
            NCB ncb = NCB.NewBadge;

            // Act
            decimal netPremium = calculation.CalculateBaseRate(ncb);

            // Assert
            Assert.AreNotEqual(2100.00M, netPremium);
        }

        [TestMethod]
        public void CalculateBaseRate_NCBZero_ShouldMatchNetPremium()
        {
            // Arrange
            NCB ncb = NCB.Zero;

            // Act
            decimal netPremium = calculation.CalculateBaseRate(ncb);

            // Assert
            Assert.AreEqual(2000.00M, netPremium);
        }

        [TestMethod]
        public void CalculateBaseRate_NCBZero_ShouldNotMatchNetPremium()
        {
            // Arrange
            NCB ncb = NCB.Zero;

            // Act
            decimal netPremium = calculation.CalculateBaseRate(ncb);

            // Assert
            Assert.AreNotEqual(2100.00M, netPremium);
        }

        [TestMethod]
        public void CalculateBaseRate_NCBOne_ShouldMatchNetPremium()
        {
            // Arrange
            NCB ncb = NCB.One;

            // Act
            decimal netPremium = calculation.CalculateBaseRate(ncb);

            // Assert
            Assert.AreEqual(1800.00M, netPremium);
        }

        [TestMethod]
        public void CalculateBaseRate_NCBOne_ShouldNotMatchNetPremium()
        {
            // Arrange
            NCB ncb = NCB.One;

            // Act
            decimal netPremium = calculation.CalculateBaseRate(ncb);

            // Assert
            Assert.AreNotEqual(1850.00M, netPremium);
        }

        [TestMethod]
        public void CalculateBaseRate_NCBTwo_ShouldMatchNetPremium()
        {
            // Arrange
            NCB ncb = NCB.Two;

            // Act
            decimal netPremium = calculation.CalculateBaseRate(ncb);

            // Assert
            Assert.AreEqual(1700.00M, netPremium);
        }

        [TestMethod]
        public void CalculateBaseRate_NCBTwo_ShouldNotMatchNetPremium()
        {
            // Arrange
            NCB ncb = NCB.Two;

            // Act
            decimal netPremium = calculation.CalculateBaseRate(ncb);

            // Assert
            Assert.AreNotEqual(1720.00M, netPremium);
        }

        [TestMethod]
        public void CalculateBaseRate_NCBThree_ShouldMatchNetPremium()
        {
            // Arrange
            NCB ncb = NCB.Three;

            // Act
            decimal netPremium = calculation.CalculateBaseRate(ncb);

            // Assert
            Assert.AreEqual(1650.00M, netPremium);
        }

        [TestMethod]
        public void CalculateBaseRate_NCBThree_ShouldNotMatchNetPremium()
        {
            // Arrange
            NCB ncb = NCB.Three;

            // Act
            decimal netPremium = calculation.CalculateBaseRate(ncb);

            // Assert
            Assert.AreNotEqual(2100.00M, netPremium);
        }

        [TestMethod]
        public void CalculateBaseRate_NCBFour_ShouldMatchNetPremium()
        {
            // Arrange
            NCB ncb = NCB.Four;

            // Act
            decimal netPremium = calculation.CalculateBaseRate(ncb);

            // Assert
            Assert.AreEqual(1600.00M, netPremium);
        }

        [TestMethod]
        public void CalculateBaseRate_NCBFour_ShouldNotMatchNetPremium()
        {
            // Arrange
            NCB ncb = NCB.Four;

            // Act
            decimal netPremium = calculation.CalculateBaseRate(ncb);

            // Assert
            Assert.AreNotEqual(2100.00M, netPremium);
        }

        [TestMethod]
        public void CalculateBaseRate_NCBFive_ShouldMatchNetPremium()
        {
            // Arrange
            NCB ncb = NCB.Five;

            // Act
            decimal netPremium = calculation.CalculateBaseRate(ncb);

            // Assert
            Assert.AreEqual(1600.00M, netPremium);
        }

        [TestMethod]
        public void CalculateBaseRate_NCBFive_ShouldNotMatchNetPremium()
        {
            // Arrange
            NCB ncb = NCB.Five;

            // Act
            decimal netPremium = calculation.CalculateBaseRate(ncb);

            // Assert
            Assert.AreNotEqual(2100.00M, netPremium);
        }

        [TestMethod]
        public void CalculateBaseRate_NCBSixPlus_ShouldMatchNetPremium()
        {
            // Arrange
            NCB ncb = NCB.SixPlus;

            // Act
            decimal netPremium = calculation.CalculateBaseRate(ncb);

            // Assert
            Assert.AreEqual(1600.00M, netPremium);
        }

        [TestMethod]
        public void CalculateBaseRate_NCBSixPlus_ShouldNotMatchNetPremium()
        {
            // Arrange
            NCB ncb = NCB.SixPlus;

            // Act
            decimal netPremium = calculation.CalculateBaseRate(ncb);

            // Assert
            Assert.AreNotEqual(2100.00M, netPremium);
        }
    }
}
