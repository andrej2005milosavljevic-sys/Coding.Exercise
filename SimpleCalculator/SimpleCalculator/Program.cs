using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            InputConverter inputConverter = new InputConverter();
            CalculatorEngine calculatorEngigne = new CalculatorEngine();

            double firstNumber = inputConverter.ConvertToDouble(Console.ReadLine());
            double secondNumber = inputConverter.ConvertToDouble(Console.ReadLine());
            string operation = Console.ReadLine();

            double result = calculatorEngigne.Calculate(firstNumber, secondNumber, operation);
            Console.WriteLine($"Result: {result}");
        }
    }
}
