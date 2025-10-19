using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.TimeComplexity
{
    internal interface ITimeComplexity
    {
        public void CountingSort();
        public void InsertionSort();
    }
    public abstract class RunTimeComplexity: ITimeComplexity
    {
        public void CountingSort() { }
        public void InsertionSort() { }
    }
}
