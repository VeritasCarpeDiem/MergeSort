using System;
using System.Collections.Generic;

namespace DeleteMeMergeSort
{
    class Program
    {
        static void MergeSort(List<int> nums)
        {
            if (nums.Count < 2) //this also accounts for when list is empty
                return;

            int mid = nums.Count / 2;
            var left = new List<int>();
            var right = new List<int>();

            for (int i = 0; i < mid; i++)
            {
                left.Add(nums[i]);
            }

            for (int i = mid; i < nums.Count; i++)
            {
                right.Add(nums[i]);
            }

            MergeSort(left);
            MergeSort(right);
            Merge(left, right, nums);
        }

        private static void Merge(List<int> left, List<int> right, List<int> nums)
        {
            nums.Clear(); //have to clear list since list is passed by ref

            int i = 0;
            int j = 0;

            while(i < left.Count && j < right.Count)
            {
                if (left[i] < right[j])
                {
                    nums.Add(left[i]);
                    i++;
                }
                else
                {
                    nums.Add(right[j]);
                    j++;
                }
            }

            while(i < left.Count)
            {
                nums.Add(left[i]);
                i++;
            }

            while(j < right.Count)
            {
                nums.Add(right[j]);
                j++;
            }
        }

        static void Main(string[] args)
        {
            //int[] arr = new int[]{ 7,6, 5, 4, 3, 2, 1 };
            var arr = new List<int>{ 7,6, 5, 4, 3, 2, 1 };
            //mergeSort<int> Array = new mergeSort<int>();

            //arr = MergeSort<int>.Mergesort(arr);
            MergeSort(arr);

            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            
        }
    }
}
