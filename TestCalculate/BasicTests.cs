
namespace TestCalculate
{
    public class BasicTests
    {
        [Theory]
        [InlineData("2 + 2", "4")]
        [InlineData("2 - 2", "0")]
        [InlineData("2 / 2", "1")]
        [InlineData("2 * 2", "4")]
        public void Calculate_OneOperationWithTwoNumbers(string expression, string result)
        {
            var calculator = new Calculator(expression);
            Assert.Equal(result, calculator.Calculate());
        }

        [Theory]
        [InlineData("6*3-2", "16")]
        [InlineData("15-3*4", "3")]
        [InlineData("3 * 10 / 2", "15")]
        [InlineData("18/2-4", "5")]
        [InlineData("20/5/4", "1")]
        [InlineData("25/5-6", "-1")]
        public void Calculate_TwoOperationWithThreeNumbers(string expression, string result)
        {
            var calculator = new Calculator(expression);

            Assert.Equal(result, calculator.Calculate());
        }
    }
}