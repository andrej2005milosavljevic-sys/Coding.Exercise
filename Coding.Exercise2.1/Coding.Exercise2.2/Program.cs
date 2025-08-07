//Create a struct named Sale with two fields: itemSold(string) and saleAmount(double). The Sale struct should also have a method GetSaleAmount() which returns the sale amount for a single sale.

//Create a class named SalesCalculator that takes an array of Sale structs as its constructor argument and stores it in a private field.The SalesCalculator should have a method CalculateTotalSales() that calculates the total sales amount by summing up the sale amounts of each sale in the array.

//Be sure to include necessary validations in your SalesCalculator. If the sales array passed to the constructor is null, throw an ArgumentNullException with the message "Sales data cannot be null." Additionally, if any Sale struct in the array has a null or empty itemSold field or saleAmount is negative throw an ArgumentException with the message "Invalid sale data."

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Exercise2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
