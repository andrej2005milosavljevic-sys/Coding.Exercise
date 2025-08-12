using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertToDouble(string input)
        {
            if (!double.TryParse(input, out double result)) throw new ArgumentException("Invalid input. Please enter a valid number.");
            return result;
        }
    }
}
