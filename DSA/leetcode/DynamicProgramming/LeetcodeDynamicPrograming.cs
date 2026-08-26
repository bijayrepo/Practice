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
    }
}
