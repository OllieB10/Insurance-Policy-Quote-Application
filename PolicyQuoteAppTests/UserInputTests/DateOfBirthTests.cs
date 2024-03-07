using InsurancePolicyQuote.Logic;
using InsurancePolicyQuoteUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PolicyQuoteAppTests
{
    [TestClass]
    public class DateOfBirthTests
    {
        IDateFormats dateFormats = Factory.CreateDateFormats();

        [TestMethod]
        public void DateOfBirth_ShouldMatch()
        {
            string dateOfBirthAnswer = "06081993";

            var dob = dateFormats.GetValidDate(dateOfBirthAnswer);

            var date = new DateTime(1993, 8, 6, 00, 00, 00);

            Assert.AreEqual(date, dob);
        }
    }
}
