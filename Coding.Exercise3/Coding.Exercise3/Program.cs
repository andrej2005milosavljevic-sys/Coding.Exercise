//Transaction Log Builder
//In this exercise, you are provided with a method called BuildLog in the TransactionLogBuilder class. 
//The method takes a list of integer arrays as an argument,
//where each array contains exactly two elements:
// the ItemID(an integer) and Quantity Sold (an integer).

//Your task is to:

//Complete the BuildLog method that iterates over each transaction.

//The method should append a string for each transaction to a StringBuilder in the following format:
//"Transaction: ItemID is {itemID} and Quantity sold is {quantitySold}".
//Ensure that the method throws an ArgumentException when a transaction does not have exactly two elements or if either the ItemID or Quantity Sold is negative.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int[]> transactions = new List<int[]>();
            transactions.Add(new int[] { 244, 15 });
            transactions.Add(new int[] { -534, 15});
            TransactionLogBuilder build = new TransactionLogBuilder();
            try
            {
                string result = build.BuildLog(transactions);
                Console.WriteLine(result);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
