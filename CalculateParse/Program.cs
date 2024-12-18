using CalculateParse;
using System;
using TestCalculate;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        var calc = new Calculator(input);
        Console.WriteLine(calc.Calculate());
    }
}