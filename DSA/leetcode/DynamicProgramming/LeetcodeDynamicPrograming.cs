using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.leetcode.DynamicProgramming
{
    public class LeetcodeDynamicPrograming : ILeetcodeDynamicProgramming
    {
        public int ClimbStairs(int n)
        {
            if (n <= 2) return n;
            int first = 1;
            int second = 2;
            for (int i = 3; i <= n; i++)
            {
                int third = first + second;
                first = second;
                second = third;
            }
            return second;
        }
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> triangle = new List<IList<int>>();
            IList<int> rowCopy = new List<int>();
            for (int i = 0; i < numRows; i++)
            {
                IList<int> row = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        row.Add(1);
                    }
                    else
                    {
                        row.Add(triangle[i - 1][j - 1] + triangle[i - 1][j]);
                    }
                }
                rowCopy = row.ToList(); // Create a copy of the row
                triangle.Add(row);
            }
            rowCopy = triangle[triangle.Count - 1]; // Create a copy of the row
            return triangle;
        }
        public int MaxProfit(int[] prices)
        {
            int max = 0;
            int minPrice = int.MaxValue;
            foreach (int price in prices)
            {
                if (price < minPrice)
                {
                    minPrice = price;
                }
                else if (price - minPrice > max)
                {
                    max = price - minPrice;
                }
            }
            return max;
        }

        public int Fib(int n)
        {
            if (n <= 1)
                return n;

            int a = 0, b = 1;
            for (int i = 2; i <= n; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }
            return b;
        }
        public int[] CountBits(int n)
        {
            int[] ans = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                ans[i] = ans[i & (i - 1)] + 1;
            }
            return ans;
        }
    }
}
