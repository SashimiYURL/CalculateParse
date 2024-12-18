using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CalculateParse;

namespace TestCalculate
{
    public class Calculator(string expression)
    {
        private string _expression = expression;

        public string Calculate()
        {
            string postfixString = ExpressionReversePolish.GetPostfixExpression(_expression);
            return CalculatePostfixString(postfixString).ToString();
        }
        private double CalculatePostfixString(string input)
        {
            double result = 0; //Результат
            Stack<double> temp = new Stack<double>();
            for (int i = 0; i < input.Length; i++)//Для каждого символа в строке
            {
                //Если цифра, то читаем все число и записываем на вершину стека
                if (Char.IsDigit(input[i]))
                {
                    string a = string.Empty;
                    while (!ExpressionReversePolish.IsDelimeter(input[i]) && !ExpressionReversePolish.IsOperator(input[i])) //Пока не разделитель
                    {
                        a += input[i]; //Добавляем
                        i++;
                        if (i == input.Length) break;
                    }
                    temp.Push(double.Parse(a)); //Записываем в стек
                    i--;
                }
                else if (ExpressionReversePolish.IsOperator(input[i])) //Если символ - оператор
                {
                    //Берем два последних значения из стека
                    double a = temp.Pop();
                    double b = temp.Pop();
                    switch (input[i]) //И производим над ними действие, согласно оператору
                    {
                        case '+': result = b + a; break;
                        case '-': result = b - a; break;
                        case '*': result = b * a; break;
                        case '/': result = (a != 0) ? b / a : throw new DivideByZeroException("Деление на ноль!"); break;
                        case '^': result = double.Parse(Math.Pow(double.Parse(b.ToString()), double.Parse(a.ToString())).ToString()); break;
                    }
                    temp.Push(result); //Результат вычисления записываем обратно в стек
                }
            }
            return temp.Peek(); //Забираем результат всех вычислений из стека и возвращаем его
        }
    }
}
