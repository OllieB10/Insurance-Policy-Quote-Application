using InsurancePolicyQuote.Logic;
using InsurancePolicyQuoteUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolicyQuoteAppTests
{
    [TestClass]
    public class MotorConvictionsCalculation
    {
        ICalculation calculation = Factory.Calculation();
        [TestMethod]
        public void CalculateMotorConvictions_1_ShouldMatch()
        {
            // Assess
            int motorConvictions = 1;

            //Act
            decimal output = 1000.00M * calculation.CalculateMotorConvictions(motorConvictions);

            // Assert
            Assert.AreEqual(1050.00M, output);
        }

        [TestMethod]
        public void CalculateMotorConvictions_1_ShouldNotMatch()
        {
            // Assess
            int motorConvictions = 1;

            //Act
            decimal output = 1000.00M * calculation.CalculateMotorConvictions(motorConvictions);

            // Assert
            Assert.AreNotEqual(1025.00M, output);
        }

        [TestMethod]
        public void CalculateMotorConvictions_0_ShouldMatch()
        {
            // Assess
            int motorConvictions = 0;

            //Act
            decimal output = 1000.00M * calculation.CalculateMotorConvictions(motorConvictions);

            // Assert
            Assert.AreEqual(1000.00M, output);
        }

        [TestMethod]
        public void CalculateMotorConvictions_0_ShouldNotMatch()
        {
            // Assess
            int motorConvictions = 0;

            //Act
            decimal output = 1000.00M * calculation.CalculateMotorConvictions(motorConvictions);

            // Assert
            Assert.AreNotEqual(1025.00M, output);
        }

        [TestMethod]
        public void CalculateMotorConvictions_2_ShouldMatch()
        {
            // Assess
            int motorConvictions = 2;

            //Act
            decimal output = 1000.00M * calculation.CalculateMotorConvictions(motorConvictions);

            // Assert
            Assert.AreEqual(1100.00M, output);
        }

        [TestMethod]
        public void CalculateMotorConvictions_2_ShouldNotMatch()
        {
            // Assess
            int motorConvictions = 2;

            //Act
            decimal output = 1000.00M * calculation.CalculateMotorConvictions(motorConvictions);

            // Assert
            Assert.AreNotEqual(1025.00M, output);
        }
    }
}
