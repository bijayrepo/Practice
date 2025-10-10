using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Interview
{
    public abstract class InterviewQuestionsBase: IInterviewQuestions
    {
        public virtual void ReverseString(string input)
        {
            Console.WriteLine("Reversing the string: " + input);
        }
        public virtual void FindDuplicateCharacters(string input)
        {
            Console.WriteLine("Finding duplicate characters in the string: " + input);
        }
        public virtual void LargestAndSmallestInArray(int[] numbers)
        {
            Console.WriteLine("Finding largest and smallest in the array: " + string.Join(", ", numbers));
        }
        public virtual void StringPalindrome(string input)
        {
            Console.WriteLine("Checking if the string is a palindrome: " + input);
        }
        public virtual void RemoveDuplicatesFromArray(int[] numbers)
        {
            Console.WriteLine("Removing duplicates from the array: " + string.Join(", ", numbers));
        }
        public virtual void FindFrequentCharacter(string input)
        {
            Console.WriteLine("Finding the most frequent character in the string: " + input);
        }
        //Sorting Algorithms & Searching Algorithms
        public void BubbleSort(int[] numbers) { }
        public void SelectionSort(int[] numbers) { }
        public void BinarySearch(int[] numbers, int target) { }
        public void DutchFlagSort(int[] numbers) { }
        //Mathmatical &  Logical Problems
        private void CheckPrime(int number) { }
        private void FindFactorial(int number) { }
        private void CheckAmstrong(int number) { }
        private void SumofDigits(int number) { }
        //Recussion Problems
        protected void Fibonacci(int n) { }
        protected void Factorial(int n) { }
        protected void TowerOfHanoi(int n, char source, char destination, char auxiliary) { }

    }
    internal interface IInterviewQuestions
    {
        public void ReverseString(string input);
        public void FindDuplicateCharacters(string input);
        public void LargestAndSmallestInArray(int[] numbers);
        public void StringPalindrome(string input);
        public void RemoveDuplicatesFromArray(int[] numbers);
        public void FindFrequentCharacter(string input);
        //Sorting Algorithms & Searching Algorithms
        public void BubbleSort(int[] numbers);
        public void SelectionSort(int[] numbers);
        public void BinarySearch(int[] numbers, int target) { }
        public void DutchFlagSort(int[] numbers) { }
        //Mathmatical &  Logical Problems
        private void CheckPrime(int number) { }
        private void FindFactorial(int number) { }
        private void CheckAmstrong(int number) { }
        private void SumofDigits(int number) { }
        //Recussion Problems
        protected void Fibonacci(int n) { }
        protected void Factorial(int n) { }
        protected void TowerOfHanoi(int n, char source, char destination, char auxiliary) { }

    }

}
