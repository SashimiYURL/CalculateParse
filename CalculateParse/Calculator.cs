using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculate
{
    public class Calculator(string expression)
    {
        private string[] _expression = expression.Split();

        public string Calculate()
        {
            int result;
            var num1 = int.Parse(_expression[0]);
            var num2 = int.Parse(_expression[2]);
            var operation = _expression[1];
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    result = 0;
                    break;
            }
            return result.ToString();

        }
    }
}
