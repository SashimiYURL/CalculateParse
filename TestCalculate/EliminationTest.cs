using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculate
{
    public class EliminationTest
    {
        [Theory]
        [InlineData("(2*3))+4")]
        [InlineData("4*((10/2)")]
        [InlineData("((2+2)*2))")]
        [InlineData(")(2*2)(")]
        [InlineData("(34*23+5)((3+5)(+4)")]
        public void BracketExceptions(string expression) => TrowInvalidOperationException(expression);
        [Theory]
        [InlineData("5 + 9 ? 5")]
        [InlineData("4*3 + 5 * a4")]
        [InlineData("12 % 4")]
        public void UnsupportedOperation(string expression) => TrowInvalidOperationException(expression);
        [Fact]
        public void DivisionByZero()
        {
            var calculator = new Calculator("5 / 0");
            Assert.Throws<DivideByZeroException>(() => calculator.Calculate());
        }
        [Fact]
        public void EmptyExpression() => TrowInvalidOperationException("");
        [Fact]
        public void InvalidExpression() => TrowInvalidOperationException("1 + + 4");

        private void TrowInvalidOperationException(string exception) => Assert.Throws<InvalidOperationException>(() => new Calculator(exception).Calculate());
    }
}
