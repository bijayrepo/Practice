using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Interview
{
    internal class InterviewQuestions : InterviewQuestionsBase
    {
        public override void ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            //Array.Reverse(charArray);
            for (int i = 0, j = charArray.Length - 1; i < j; i++, j--)
            {
                char temp = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = temp;
            }
            string reversedString = new string(charArray);
            Console.WriteLine("Reversed string: " + reversedString);
        }
        public override void FindDuplicateCharacters(string input)
        {
            var characterCount = new Dictionary<char, int>();
            foreach (char c in input)
            {
                if (characterCount.ContainsKey(c))
                {
                    characterCount[c]++;
                }
                else
                {
                    characterCount[c] = 1;
                }
            }
            foreach (char c in characterCount.Keys)
            {
                Console.WriteLine($"Character: {c}, Count: {characterCount[c]}");
            }
            var duplicates = characterCount.Where(kvp => kvp.Value > 1).Select(kvp => kvp.Key);
            Console.WriteLine("Duplicate characters: " + string.Join(", ", duplicates));
        }
        public override void LargestAndSmallestInArray(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                Console.WriteLine("Array is empty.");
                return;
            }
            int largest = numbers[0];
            int smallest = numbers[0];
            foreach (int num in numbers)
            {
                if (num > largest)
                {
                    largest = num;
                }
                if (num < smallest)
                {
                    smallest = num;
                }
            }
            Console.WriteLine($"Largest number: {largest}, Smallest number: {smallest}");
        }
        public override void StringPalindrome(string input)
        {
            char[] charArray = input.ToCharArray();
            int left = 0,right=input.Length-1;
            while(left<right)
            {
                if(charArray[left]!=charArray[right])
                {
                    Console.WriteLine($"The string '{input}' is not a palindrome.");
                    return;
                }
                left++;
                right--;
            }
            Console.WriteLine($"The string '{input}' is a palindrome.");
        }
        public override void RemoveDuplicatesFromArray(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                Console.WriteLine("Array is empty.");
                return;
            }
            //HashSet<int> uniqueNumbers = new HashSet<int>(numbers);
            //int[] result = uniqueNumbers.ToArray();
            int[] result = { };
            foreach (int num in numbers)
            {
               if(!result.Contains(num))
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = num;
                }
            }
            Console.WriteLine("Original array: " + string.Join(", ", numbers)+"Array after removing duplicates: " + string.Join(", ", result));
        }
        public override void FindFrequentCharacter(string input)
        {
            //base.FindFrequentCharacter(input);
            var characterCount = new Dictionary<char, int>();
            foreach (char c in input)
            {
                if (characterCount.ContainsKey(c))
                {
                    characterCount[c]++;
                }
                else
                {
                    characterCount[c] = 1;
                }
            }
            char mostFrequentChar = characterCount.OrderByDescending(kvp => kvp.Value).First().Key;
            Console.WriteLine("Orginal String:"+input+"Most Frequent Character : "+ mostFrequentChar);
        }
        //Sorting Algorithms & Searching Algorithms
        public void BubbleSort(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        // Swap numbers[j] and numbers[j+1]
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Array after Bubble Sort: " + string.Join(", ", numbers));
        }
        public void SelectionSort(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }
                // Swap numbers[i] and numbers[minIndex]
                int temp = numbers[i];
                numbers[i] = numbers[minIndex];
                numbers[minIndex] = temp;
            }
            Console.WriteLine("Array after Selection Sort: " + string.Join(", ", numbers));
        }
        public void BinarySearch(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (numbers[mid] == target)
                {
                    Console.WriteLine($"Element {target} found at index {mid}.");
                    return;
                }
                if (numbers[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            Console.WriteLine($"Element {target} not found in the array.");
        }
        public void DutchFlagSort(int[] arr)
        {
            int low = 0, mid = 0, high = arr.Length - 1;

            while (mid <= high)
            {
                if (arr[mid] == 0)
                {
                    Swap(arr, low, mid);
                    low++;
                    mid++;
                }
                else if (arr[mid] == 1)
                {
                    mid++;
                }
                else
                { // arr[mid] == 2
                    Swap(arr, mid, high);
                    high--;
                }
            }

        }
        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        //Mathmatical &  Logical Problems
        private void CheckPrime(int number)
        {
            if (number <= 1)
            {
                Console.WriteLine($"{number} is not a prime number.");
                return;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine($"{number} is not a prime number.");
                    return;
                }
            }
            Console.WriteLine($"{number} is a prime number.");
        }
        private void FindFactorial(int number)
        {
            if (number < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
                return;
            }
            long factorial = 1;
            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Factorial of {number} is {factorial}.");
        }
        private void CheckAmstrong(int number)
        {
            int originalNumber = number;
            int sum = 0;
            int digits = number.ToString().Length;
            while (number > 0)
            {
                int digit = number % 10;
                sum += (int)Math.Pow(digit, digits);
                number /= 10;
            }
            if (sum == originalNumber)
            {
                Console.WriteLine($"{originalNumber} is an Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{originalNumber} is not an Armstrong number.");
            }
        }
        private void SumofDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine("Sum of digits: " + sum);
        }
        //Recussion Problems
        protected void Fibonacci(int n)
        {
            int result = FibonacciReturn(n);
            Console.WriteLine($"Fibonacci number at position {n} is {result}");
        }
        protected int FibonacciReturn(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Input should be a positive integer.");
                return 0;
            }
            else if (n == 1)
            {
                return 0;
            }
            else if (n == 2)
            {
                return 1;
            }
            else
            {
                return FibonacciReturn(n - 1) + FibonacciReturn(n - 2);
            }
        }
        protected void Factorial(int n)
        {
            int result = FactorialReturn(n);
            Console.WriteLine($"Factorial of {n} is {result}");
        }
        protected int FactorialReturn(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
                return 1;
            }
            else if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * FactorialReturn(n - 1);
            }
        }
        protected void TowerOfHanoi(int n, char source, char destination, char auxiliary)
        {
            if (n == 1)
            {
                Console.WriteLine($"Move disk 1 from rod {source} to rod {destination}");
                return;
            }
            TowerOfHanoi(n - 1, source, auxiliary, destination);
            Console.WriteLine($"Move disk {n} from rod {source} to rod {destination}");
            TowerOfHanoi(n - 1, auxiliary, destination, source);
        }
        public static void Run()
        {
            InterviewQuestions iq = new InterviewQuestions();
            iq.ReverseString("Bijay");
            iq.FindDuplicateCharacters("Programming");
            iq.LargestAndSmallestInArray(new int[]{ 34, -2, 45, 0, 11, -9, 78 });
            iq.StringPalindrome("madam");
            iq.RemoveDuplicatesFromArray(new int[] { 1, 2, 3, 2, 4, 1, 5, 3 });
            iq.FindFrequentCharacter("hello world");
            //Sorting Algorithms & Searching Algorithms
            iq.BubbleSort(new int[] { 64, 34, 25, 12, 22, 11, 90 });
            iq.SelectionSort(new int[] { 64, 25, 12, 22, 11 });
            iq.BinarySearch(new int[] { 11, 12, 22, 25, 34, 64, 90 }, 25);
            iq.DutchFlagSort(new int[] { 2, 0, 1, 2, 1, 0 });
            //Mathmatical &  Logical Problems
            iq.CheckPrime(29);
            iq.FindFactorial(5);
            iq.CheckAmstrong(153);
            iq.SumofDigits(12345);
            //Recussion Problems
            iq.Fibonacci(7);
            iq.Factorial(5);
            iq.TowerOfHanoi(3, 'A', 'C', 'B');
            //Linked List Problems
            InterviewQuestionIntermediate iqi = new InterviewQuestionIntermediate();
            iqi.ReverseLinkedList(new List<int> { 1, 2, 3, 4, 5 });
            iqi.DetectCycleInLinkedList(new List<int> { 1, 2, 3, 4, 5 });
            iqi.FindMiddleOfLinkedList(new List<int> { 1, 2, 3, 4, 5 });
        }
    }
    internal class InterviewQuestionIntermediate: InterviewQuestionsBase
    {
        internal void ReverseLinkedList(List<int>list)
        {
            Console.WriteLine("Original Linked List: " + string.Join("->", list));
            list.Reverse();
            Console.WriteLine("Reversed Linked List: " + string.Join("->", list));
        }
        internal void DetectCycleInLinkedList(List<int> list)
        {
            // This is a placeholder implementation as List<int> does not support cycles.
            Console.WriteLine("Detecting cycle in Linked List is not applicable for List<int>.");
        }
        internal void FindMiddleOfLinkedList(List<int> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Linked List is empty.");
                return;
            }
            int midIndex = list.Count / 2;
            Console.WriteLine($"Middle element of the Linked List is: {list[midIndex]}");
        }
    }
}
