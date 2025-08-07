using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    internal class LinearSearch
    {
        public static bool Linear(int num)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    Console.WriteLine($"Element {num} found at index {i}");
                    return true;
                }
            }
            return false;
        }
        

    }
}
