using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.leetcode.Array
{
    interface IArray_LeadCode
    {
        public int removeDuplicates(int[] nums);
        public int RemoveElement(int[] nums, int val);
        public int SearchInsert(int[] nums, int target);
        public int[] plusOne(int[] digits);
    }
}
