using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem18
    {
        public int FindMaximumTotal(string triangle)
        {
            var rows = triangle.Split("\n")
                .Select(x=>x.Split(" ").Select(x=>int.Parse(x)).ToArray())
                .ToArray();

            for(int i=rows.Length-1; i>=1;i--)
            {
                ReduceLastRow(rows, i);
            }

            return rows[0][0];
        }

        private void ReduceLastRow(int[][] triangle, int row)
        {
            row++;
            for(int i=0;i<triangle[row-2].Length;i++)
            {
                int maxChild = 0;
                if(triangle[row - 1][i] > triangle[row - 1][i+1])
                {
                    maxChild = triangle[row - 1][i];
                }
                else
                {
                    maxChild = triangle[row - 1][i+1];
                }
                triangle[row - 2][i] += maxChild;
            }

        }
    }
}
