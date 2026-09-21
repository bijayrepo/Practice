using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.leetcode.List
{
    public class List_Leadcode : IList_leadcode
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            // Iterative merge using a dummy head
            ListNode dummy = new ListNode();
            ListNode tail = dummy;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    tail.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    tail.next = list2;
                    list2 = list2.next;
                }
                tail = tail.next;
            }

            // attach remaining nodes
            tail.next = list1 ?? list2;

            return dummy.next;
        }

        public IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrEmpty(digits))
                return new List<string>();
            string[] mapping = new string[]
            {
                "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"
            };
            List<string> result = new List<string>();
            Dictionary<char, string> map = new Dictionary<char, string>();
            for (int i = 0; i < mapping.Length; i++)
            {
                map.Add(i.ToString()[0], mapping[i]);
            }
            Backtrack(digits, 0, "", result, map);
            return result;
        }
        private void Backtrack(string digits, int index, string current, List<string> result, Dictionary<char, string> map)
        {
            if (index == digits.Length)
            {
                result.Add(current);
                return;
            }

            string letters = map[digits[index]];

            foreach (char ch in letters)
            {
                Backtrack(digits, index + 1, current + ch, result, map);
            }
        }
    }
}
