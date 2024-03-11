using InsurancePolicyQuote.Logic;
using InsurancePolicyQuoteUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyQuoteAppTests
{
    [TestClass]
    public class YearOfManufactureTests
    {
        IDateFormats dateFormats = Factory.CreateDateFormats();

        [TestMethod]
        public void YearManufacture_ShouldNotMatch()
        {
            int year = dateFormats.GetYear("1995");

            Assert.AreNotEqual(1996, year);
        }
    }
}
