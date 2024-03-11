using InsurancePolicyQuote.Logic;
using InsurancePolicyQuoteUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PolicyQuoteAppTests
{
    [TestClass]
    public class DriverAgeCalculationTests
    {
        IDateHelper dateHelper = Factory.CreateDateHelper();

        [TestMethod]
        public void CalculateDriverAge_AtInception_ShouldMatch()
        {
            DateTime startDate = new DateTime(2024, 02, 15);
            DateTime birthDate = new DateTime(1993, 8, 6);

            int yearAtInception = dateHelper.GetAgeDifference(birthDate, startDate);

            Assert.AreEqual(30, yearAtInception);
        }
    }
}
