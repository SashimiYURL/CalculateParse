
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
    }
}