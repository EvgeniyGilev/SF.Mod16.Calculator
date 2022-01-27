using System;
using NUnit.Framework;

namespace SF.Mod16.Calculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        /// <summary>
        /// Additional_S the must return correct value.
        /// </summary>
        [Test]
        public void Additional_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Additional(300, 10) == 310);
        }

        /// <summary>
        /// Subtraction_S the must return correct value.
        /// </summary>
        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Subtraction(300, 10) == 290);
        }

        /// <summary>
        /// Miltiplication_S the must return correct value.
        /// </summary>
        [Test]
        public void Miltiplication_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Miltiplication(2, 2) == 4);
        }

        /// <summary>
        /// Miltiplication_S the must return zero if one value zero.
        /// </summary>
        [Test]
        public void Miltiplication_MustReturnZeroIfOneValueZero()
        {
            Calculator calculator = new Calculator();
            Assert.That((calculator.Miltiplication(0, 2) == 0) && (calculator.Miltiplication(2, 0) == 0));
        }

        /// <summary>
        /// Division_S the must return correct value.
        /// </summary>
        [Test]
        public void Division_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(200, 10) == 20);
        }

        /// <summary>
        /// Division_S the must throw exception.
        /// </summary>
        [Test]
        public void Division_MustThrowException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }

    }
}
