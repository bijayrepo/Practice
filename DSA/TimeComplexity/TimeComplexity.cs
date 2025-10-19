using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.TimeComplexity
{
    public class RunTimeComplexityMedium
    {
        public static void Run()
        {
            TimeComplexity tc = new TimeComplexity();
            tc.CountingSort();
            tc.InsertionSort();
        }
    }
    internal class TimeComplexity : RunTimeComplexity
    {
        public void CountingSort()
        {
            int[] arr = { 4, 2, 2, 8, 3, 3, 1 };
            int max = arr.Max();
            int min = arr.Min();
            int range = max - min + 1;
            int[] count = new int[range];
            int[] output = new int[arr.Length];
            // Store the count of each number
            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i] - min]++;
            }
            // Change count[i] so that it now contains actual position of this number in output array
            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }
            // Build the output array
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                output[count[arr[i] - min] - 1] = arr[i];
                count[arr[i] - min]--;
            }
            // Copy the output array to arr, so that arr now contains sorted numbers
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = output[i];
            }
            Console.WriteLine("Sorted array: " + string.Join(", ", arr));
        }
        public void InsertionSort()
        {
            int[] arr = { 2, 3, 7, 1, 8 };
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;
                // Move elements of arr[0..i-1], that are greater than key,
                // to one position ahead of their current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
                Console.WriteLine($"Iteration {i}: " + string.Join(", ", arr));
            }
            Console.WriteLine("Sorted array: " + string.Join(", ", arr));
        }
    }
}
