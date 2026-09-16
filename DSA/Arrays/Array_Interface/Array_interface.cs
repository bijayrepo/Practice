using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays.Array_Interface
{
    public interface Array_interface
    {
        public int[] SmallerNumbersThanCurrent(int[] nums);
        public IList<int> FindDisappearedNumbers(int[] nums);
    }
}
