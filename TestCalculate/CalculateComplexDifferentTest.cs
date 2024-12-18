using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculate
{
    public class CalculateComplexDifferentTest
    {
        [Theory]
        [InlineData("(8*2)+4", "20")]
        [InlineData("3*(4/2)", "6")]
        [InlineData("(3+14) + (2*8)", "33")]
        [InlineData("(25-18)* (10/2)", "35")]
        [InlineData("(5+3)/(3+1)", "2")]
        public void ExpressionWithBracket(string expression, string result)=> Check(expression, result);

        [Theory]
        [InlineData("5*6-10", "20")]
        [InlineData("25+4*3", "37")]
        [InlineData("(35-10)*2", "50")]
        [InlineData("10*3/2", "15")]
        [InlineData("18/(8+1)", "2")]
        public void ExpressionPriorityTest(string expression, string result)=> Check(expression, result);
       
        [Theory]
        [InlineData("1/2 + 9/3", "3,5")]
        [InlineData("35-10/4", "32,5")]
        [InlineData("4,35 * 2,2 + 10/4", "12,07")]
        [InlineData("20,5/4,1", "5")]
        [InlineData("7/2+1", "4,5")]
        public void ExpressionFractionalNumTest(string expression, string result)=> Check(expression, result);

        [Theory]
        [InlineData("-5", "-5")]
        [InlineData("-(-1 + 8)", "-7")]
        [InlineData("(10*3 + 5) + (-10 + 5)", "30")]
        [InlineData("-(7+11)", "-18")]
        [InlineData("7-3", "4")]
        [InlineData("(-1)*5", "-5")]

        public void UnaryMinusTest(string expression, string result) => Check(expression, result);

        private void Check(string expression, string result)
        {
            var calculator = new Calculator(expression);
            Assert.Equal(result, calculator.Calculate());
        }
    }
}
