using NUnit.Framework;
using System;


namespace Calculator.Tests
{
    public class CalculatorTest
    {
        Calculator calculator = new Calculator();

        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            Assert.That(calculator.Additional(20, 10) == 30);
        }

        [Test]
        public void SubstractionMustReturnCorrectValue()
        {
            Assert.True(calculator.Subtraction(20, 10) == 10);

        }

        [Test]
        public void MiltiplicationMustReturnCorrectionValue()
        {
            Assert.True(calculator.Miltiplication(20, 10) == 200);
        }

        [Test]
        public void DivisionMustReturnCorrectionValue()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Division(20, 0));
            Assert.True(calculator.Division(20, 10) == 2);
        }
    }
}
