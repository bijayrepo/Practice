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
        }
    }
}
