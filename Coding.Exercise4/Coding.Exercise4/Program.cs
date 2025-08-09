//Tallest Building Finder
//You are given an array of integers which represent the heights of a set of buildings in a skyline.

//The buildings are all different heights and are not guaranteed to always be sorted.

//The goal is to find the building that would be the highest after a series of "growth spurts".

//Each growth spurt increases the height of a building by 1 unit. However, these growth spurts only affect the smallest building in the skyline.

//If there are multiple buildings of the same smallest height, they all simultaneously grow in the same growth spurt.

//For example, if there are three buildings of height 2, and a growth spurt occurs, then all three buildings become height 3.

//Write a C# program to find the new highest building after n growth spurts have occurred.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] buildings = { 4, 2, 7, 2, 5 };
            int n = 3;

            TallestBuildingFinder finder = new TallestBuildingFinder();

            int tallest = finder.TallestBuilding(buildings, n);

            Console.WriteLine($"Tallest building after {n} growth spurts: {tallest}");

            Console.WriteLine("Final  1 sorted building heights: ");
            foreach (int height in buildings)
            {
                Console.Write(height + " ");
            }
        }
    }
}
