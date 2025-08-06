using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Exercise3
{
    internal class TransactionLogBuilder
    {
        public string BuildLog(List<int[]> transactions)
        {
            StringBuilder idAndQuantity = new StringBuilder();

            for (int i = 0; i < transactions.Count; i++)
            {
                if (transactions[i].Length != 2)
                {
                    throw new ArgumentException("Invalid transaction data");
                }
                int id = transactions[i][0];
                if (id < 0)
                {
                    throw new ArgumentException("Item id cant be negative");

                }
                int quantity = transactions[i][1];
                if (quantity < 0)
                {
                    throw new ArgumentException("Quantity sold cant be negative");
                }
                idAndQuantity.AppendLine($"Item ID is {id} and quantity sold is {quantity}");
            }
            return idAndQuantity.ToString();
        }
    }
}
