using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(double firstNumber, double secondNumber, string operation)
        {
            switch (operation.ToLower())
            {
                case "add":
                    return firstNumber + secondNumber;
                case "subtract":
                    return firstNumber - secondNumber;
                case "multiply":
                    return firstNumber * secondNumber;
                case "divide":
                    if (secondNumber == 0) throw new DivideByZeroException("Cannot divide by zero.");
                    return firstNumber / secondNumber;
                default:
                    throw new ArgumentException("Invalid operation. Please use add, subtract, multiply, or divide.");
            }
        }
    }
}
