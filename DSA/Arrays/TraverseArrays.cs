using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    internal class TraverseArrays
    {
        public static void Traverse()
        {
            int[] ary = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            for (int i = 0; i < ary.Length; i++)
            {
                Console.Write(ary[i]);
            }
        }
    }
}
