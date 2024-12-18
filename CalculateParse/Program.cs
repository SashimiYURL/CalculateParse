using CalculateParse;
using System;
using TestCalculate;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        var calc = new Calculator(input);
        try
        {
            var result = calc.Calculate();
            Console.WriteLine($"Результат:{result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка:{ex.Message}");
        }
    }
}