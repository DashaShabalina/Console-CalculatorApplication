using System;
using Xunit;

namespace CalculatorLibraryTests
{
    public class CalculatorLibraryTest
    {
        [Fact]
        public void ShouldCreateCalculator()
        {
            CalculatorLibrary.Calculator calculator = new CalculatorLibrary.Calculator();
            Assert.NotNull(calculator);
            calculator.Finish();
        }

        [Fact]
        public void ShouldCountCorrectly()
        {
            CalculatorLibrary.Calculator calculator = new CalculatorLibrary.Calculator();
            Assert.Equal(2, calculator.DoOperation(1, 1, "a"));
            Assert.Equal(0, calculator.DoOperation(1, 1, "s"));
            Assert.Equal(1, calculator.DoOperation(1, 1, "m"));
            Assert.Equal(1, calculator.DoOperation(1, 1, "d"));
            Assert.Equal(0, calculator.DoOperation(1, 0, "m"));
            Assert.Equal(4, calculator.DoOperation(-2, -2, "m"));
            Assert.Equal(double.NaN, calculator.DoOperation(1, 0, "d"));
            Assert.Equal(double.NaN, calculator.DoOperation(1, 1, "?"));
            calculator.Finish();
        }
    }
}
