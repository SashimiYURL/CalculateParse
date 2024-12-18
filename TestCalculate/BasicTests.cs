
namespace TestCalculate
{
    public class BasicTests
    {
        [Theory]
        [InlineData("2+2", "4")]
        [InlineData("2-2", "0")]
        [InlineData("2 / 2", "1")]
        [InlineData("2*2", "4")]
        public void Calculate_OneOperationWithTwoNumbers(string expression, string result) => Check(expression, result);

        [Theory]
        [InlineData("6*3-2", "16")]
        [InlineData("15-3*4", "3")]
        [InlineData("3 * 10 / 2", "15")]
        [InlineData("18/2-4", "5")]
        [InlineData("20/5/4", "1")]
        [InlineData("25/5-6", "-1")]
        public void CalculateTwoOperationWithThreeNumbers(string expression, string result) => Check(expression, result);

        private void Check(string expression, string result) => Assert.Equal(result, new Calculator(expression).Calculate());
    }
}