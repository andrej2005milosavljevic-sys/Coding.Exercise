using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Exercise
{
    internal class SalesAnalysis
    {
        public readonly List<string> ItemsSold;

        public const char Separator = ':';

        public SalesAnalysis(List<string> itemsSold)
        {
            ItemsSold = itemsSold;
        }
        public double ComputeAllIncome()
        {
            if (ItemsSold == null || !ItemsSold.Any()) return 0;

            double total = 0;

            foreach (var item in ItemsSold) {
                var Item = item.Split(Separator);
                if (Item.Length < 2 || string.IsNullOrWhiteSpace(Item[1])) continue;

                if (double.TryParse(Item[1], out double price){
                    if (price > 0)
                    {
                        total += price;
                    }
                }

            }
            return total;
        }
        
    }
}
