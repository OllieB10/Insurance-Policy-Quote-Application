using InsurancePolicyQuote.Logic;
using InsurancePolicyQuoteUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyQuoteAppTests
{
    [TestClass]
    public class MinimumPremiumCalculationCheckTests
    {
        IMinimumPremiumChecker minimumPremium = Factory.CreateMinimumPremiumChecker();
        ICalculation calculation = Factory.Calculation();

        [TestMethod]
        public void CheckMinimumPremium_NCBNewBadge_ShouldNotReplaceValue()
        {
            // Apply
            NCB ncb = NCB.NewBadge;

            // Act
            var output = minimumPremium.CheckMinimumPremium(1000.00M, calculation.CalculateMinimumPremium(ncb));

            // Assert
            Assert.AreEqual(1000.00M, output);
        }

        [TestMethod]
        public void CheckMinimumPremium_NCBNewBadge_ShouldReplaceValue()
        {
            // Apply
            NCB ncb = NCB.NewBadge;

            // Act
            var output = minimumPremium.CheckMinimumPremium(899.00M, calculation.CalculateMinimumPremium(ncb));

            // Assert
            Assert.AreNotEqual(899.00M, output);
        }

        [TestMethod]
        public void CheckMinimumPremium_NCBZero_ShouldNotReplaceValue()
        {
            // Apply
            NCB ncb = NCB.Zero;

            // Act
            var output = minimumPremium.CheckMinimumPremium(1200.00M, calculation.CalculateMinimumPremium(ncb));

            // Assert
            Assert.AreEqual(1200.00M, output);
        }

        [TestMethod]
        public void CheckMinimumPremium_NCBZero_ShouldReplaceValue()
        {
            // Apply
            NCB ncb = NCB.Zero;

            // Act
            var output = minimumPremium.CheckMinimumPremium(500.00M, calculation.CalculateMinimumPremium(ncb));

            // Assert
            Assert.AreNotEqual(700.00M, output);
        }

        [TestMethod]
        public void CheckMinimumPremium_NCBOne_ShouldNotReplaceValue()
        {
            // Apply
            NCB ncb = NCB.One;

            // Act
            var output = minimumPremium.CheckMinimumPremium(1000.00M, calculation.CalculateMinimumPremium(ncb));

            // Assert
            Assert.AreEqual(1000.00M, output);
        }

        [TestMethod]
        public void CheckMinimumPremium_NCBOne_ShouldReplaceValue()
        {
            // Apply
            NCB ncb = NCB.One;

            // Act
            var output = minimumPremium.CheckMinimumPremium(500.00M, calculation.CalculateMinimumPremium(ncb));

            // Assert
            Assert.AreNotEqual(500.00M, output);
        }
    }
}
