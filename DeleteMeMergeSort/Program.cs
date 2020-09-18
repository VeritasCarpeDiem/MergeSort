using System;

namespace DeleteMeMergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[]{ 5, 4, 3, 2, 1 };
            //mergeSort<int> Array = new mergeSort<int>();
            MergeSort<int>.MergeSort(arr);
            
        }
    }
}
