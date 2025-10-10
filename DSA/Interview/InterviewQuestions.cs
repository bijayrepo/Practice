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
            Array.Reverse(charArray);
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
            var duplicates = characterCount.Where(kvp => kvp.Value > 1).Select(kvp => kvp.Key);
            Console.WriteLine("Duplicate characters: " + string.Join(", ", duplicates));
        }
        public static void Run()
        {
            InterviewQuestions iq = new InterviewQuestions();
            iq.ReverseString("Hello World");
            //iq.FindDuplicateCharacters("Programming");
        }
    }
}
