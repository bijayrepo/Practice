using DSA.Arrays;
using DSA.Arrays.Array_Interface;
using DSA.leetcode;
using DSA.leetcode.Algorithms;
using DSA.leetcode.DynamicProgramming;
using DSA.LINQ;
using DSA.List;
using Microsoft.Extensions.DependencyInjection;

namespace DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.DynamicProgrammingAddApplicationServices();
            var serviceProvider = services.BuildServiceProvider();
            //Fibonacci Series
            //Fibonacci.RecursiveApproach.Run();
            //Fibonacci.IteractiveApproach.Run();
            //Fibonacci.DynamicProgramming.Run();
            //Fibonacci.UningLINQ.Run();
            //Fibonacci Series End
            //Arrays
            //TraverseArrays.Traverse();
            //LinearSearch.Linear(5);
            //ReversingList.Run();
            //LinqQuery.Linq();
            //TimeComplexity
            //TimeComplexity.RunTimeComplexityMedium.Run();
            //InterviewQuestions
            //Interview.InterviewQuestions.Run();
            //Leetcode
            RunMedium.Run();
            //Console.WriteLine();
            //Dynamic Programming
            //ILeetcodeDynamicProgramming leetcodeDynamicProgramming = new LeetcodeDynamicPrograming();
           
            var dynamicProgramming = serviceProvider.GetRequiredService<ILeetcodeDynamicProgramming>();
            var arrayService = serviceProvider.GetRequiredService<Array_interface>();
            Console.WriteLine(dynamicProgramming.ClimbStairs(5));
            Console.WriteLine(string.Join(", ", dynamicProgramming.Generate(3).Select(row => string.Join(", ", row))));
            Console.WriteLine("Stock maximum profit: " + dynamicProgramming.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 }));
            Console.WriteLine(dynamicProgramming.Fib(3));
            Console.WriteLine(dynamicProgramming.MinCostClimbingStairs(new int[] {1, 100, 1, 1, 1, 100, 1, 1, 100, 1 }));
            Console.WriteLine(dynamicProgramming.IsSubsequence("abc", "ahbgdc"));
            //DynamicProgramming End
            //Array Service
            arrayService.SmallerNumbersThanCurrent(new int[] { 8, 1, 2, 2, 3 });
            Console.WriteLine("Disappeared numbers: " + string.Join(", ", arrayService.FindDisappearedNumbers(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 })));
            var algorithimsLeddcode = serviceProvider.GetRequiredService<IAlgorithms_leedcode>();
            algorithimsLeddcode.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });
        }
    }
}
