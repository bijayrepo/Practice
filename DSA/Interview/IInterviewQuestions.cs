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
    }
    internal interface IInterviewQuestions
    {
        public void ReverseString(string input);
        public void FindDuplicateCharacters(string input);
        
    }
}
