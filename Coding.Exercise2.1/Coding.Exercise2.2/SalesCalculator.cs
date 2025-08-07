using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Exercise2._2
{
    internal class SalesCalculator
    {
        private Sale[] Sales;
        public SalesCalculator(Sale[] sales)
        {
            if (sales == null) throw new ArgumentNullException("Sales data cannot be null.");
            foreach (Sale s in sales)
            {
                if (string.IsNullOrWhiteSpace(s.itemSold) || s.saleAmount < 0) throw new ArgumentException("Invalid sale data.");

            }
            Sales = sales;


        }
        public double CalculateTotalSales()
        {
            double totalSales = 0;
            foreach (Sale s in Sales)
            {
                totalSales += s.GetSaleAmount();
            }
            return totalSales;
        }
    }
}
