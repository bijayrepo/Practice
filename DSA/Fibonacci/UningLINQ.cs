using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Fibonacci
{
    internal class UningLINQ
    {
        public static void Run()
        {
            Console.WriteLine("Enter the number of terms in the Fibonacci sequence:");
            int n = Convert.ToInt32(Console.ReadLine());
           var fibonacci=new int[n];
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            Enumerable.Range(2,n-2).ToList().ForEach(i =>
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            });
            Console.WriteLine("Fibonacci sequence:");
            Console.WriteLine(string.Join(" ", fibonacci));
        }
    }
}
