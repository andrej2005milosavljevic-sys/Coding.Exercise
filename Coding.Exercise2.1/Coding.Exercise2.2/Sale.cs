using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Exercise2._2
{
    internal struct Sale
    {
        public string itemSold;
        public double saleAmount;

        public Sale(string itemsold, double saleamount)
        {
            itemSold = itemsold;
            saleAmount = saleamount;
        }
        public double GetSaleAmount()
        {
            return saleAmount;
        }

    }
}
