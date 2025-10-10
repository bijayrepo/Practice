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
        public static void Run()
        {
            InterviewQuestions iq = new InterviewQuestions();
            iq.ReverseString("Bijay");
            iq.FindDuplicateCharacters("Programming");
            iq.LargestAndSmallestInArray(new int[]{ 34, -2, 45, 0, 11, -9, 78 });
            iq.StringPalindrome("madam");
        }
    }
}
