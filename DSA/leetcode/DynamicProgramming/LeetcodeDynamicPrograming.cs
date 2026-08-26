using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.leetcode.DynamicProgramming
{
    public class LeetcodeDynamicPrograming: ILeetcodeDynamicProgramming
    {
        public int ClimbStairs(int n)
        {
           if(n<=2) return n;
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
                triangle.Add(row);
            }
            return triangle;
        }
    }
}
