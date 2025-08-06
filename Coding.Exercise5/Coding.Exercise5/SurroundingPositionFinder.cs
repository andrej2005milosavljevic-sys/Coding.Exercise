using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Exercise5
{
    internal class SurroundingPositionFinder
    {
        public List<int[]> FindSurroundingPositions(int[,] arr, int[] position)
        {
            if (position == null || position.Length != 2)
            {
                throw new ArgumentException("Invalid input. Please provide valid position. "
            }

            int row = position[0];
            int col = position[1];

            int Rows = arr.GetLength(0);
            int Cols = arr.GetLength(1);
            if (row < 0 || row >= Rows || col < 0 || col >= Cols)
            {
                throw new ArgumentException("Invalid input. Please provide valid position.");
            }
            List<int[]> udlr = new List<int[]>();

            if (row - 1 >= 0)
            {
                udlr.Add(new int[] { row - 1, col });
            }
            if (row + 1 >= 0)
            {
                udlr.Add(new int[] { row + 1, col });
            }
            if (col - 1 >= 0)
            {
                udlr.Add(new int[] { row, col - 1 });
            }
            if (col + 1 >= 0)
            {
                udlr.Add(new int[] { row, col + 1 });
            }
            return udlr;
        }

    }
}
