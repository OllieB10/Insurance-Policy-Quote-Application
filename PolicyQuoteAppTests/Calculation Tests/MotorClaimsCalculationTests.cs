using InsurancePolicyQuote.Logic;
using InsurancePolicyQuoteUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PolicyQuoteAppTests
{
    [TestClass]
    public class MotorClaimsCalculationTests
    {
        ICalculation calculation = Factory.Calculation();

        [TestMethod]
        public void CalculateMotorClaims_NCBNewBadge_ClaimsFaultZero_ClaimsNonFaultZero_ShouldMatch()
        {
            List<MotorClaim> motorClaims = new List<MotorClaim>();
            //motorClaims.Add(new MotorClaim { AtFault = false });

            NCB ncb = NCB.NewBadge;

            var output = 1000.00M * calculation.CalculateClaimsRate(motorClaims, ncb);

            Assert.AreEqual(1000.00M, output);
        }

        [TestMethod]
        public void CalculateMotorClaims_NCBNewBadge_ClaimsFaultZero_ClaimsNonFaultZero_ShouldNotMatch()
        {
            List<MotorClaim> motorClaims = new List<MotorClaim>();
            //motorClaims.Add(new MotorClaim { AtFault = false });

            NCB ncb = NCB.NewBadge;

            var output = 1000.00M * calculation.CalculateClaimsRate(motorClaims, ncb);

            Assert.AreNotEqual(1040.00M, output);
        }
    }
}
