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
        public void BracketExceptions(string expression)
        {
            var calculator = new Calculator(expression);
            Assert.Throws<InvalidOperationException>(() => calculator.Calculate());
        }
        [Theory]
        [InlineData("5 + 9 ? 5")]
        [InlineData("4*3 + 5 * a4")]
        [InlineData("12 % 4")]
        public void UnsupportedOperation(string expression)
        {
            var calculator = new Calculator(expression);
            Assert.Throws<InvalidOperationException>(() => calculator.Calculate());
        }
        [Fact]
        public void DivisionByZero()
        {
            var calculator = new Calculator("5 / 0");
            Assert.Throws<DivideByZeroException>(() => calculator.Calculate());
        }
        [Fact]
        public void EmptyExpression()
        {
            var calculator = new Calculator("");
            Assert.Throws<InvalidOperationException>(() => calculator.Calculate());
        }
        [Fact]
        public void InvalidExpression()
        {
            var calculator = new Calculator("1 + + 4");
            Assert.Throws<InvalidOperationException>(() => calculator.Calculate());
        }
    }
}
