using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Exercise4
{
    internal class TallestBuildingFinder
    {
        public int TallestBuilding(int[]buildings, int n)
        {
            for(int x = 0; x < n;x++)
            {
                int minHeight = buildings.Min();

                for (int i = 0; i < buildings.Length; i++)
                {
                    if (buildings[i] == minHeight)
                    {
                        buildings[i]++;
                    }
                }
                
            }
            Array.Sort(buildings);
            return buildings.Max();

        }
    }
}
