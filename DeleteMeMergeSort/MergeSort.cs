using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DeleteMeMergeSort
{
    class MergeSort<T> where T : IComparable<T>
    {
        public static T[] Mergesort(T[] numbers)
        {

            if (numbers.Length < 2) //base case
            {
                return numbers;
            }
            int mid = numbers.Length / 2;
            T[] left = new T[numbers.Length - mid];
            T[] right = new T[mid];


            for (int i = 0; i < numbers.Length; i++)
            {
                if (i < left.Length)
                {
                    left[i] = numbers[i];
                }
                else
                {
                    right[i - left.Length] = numbers[i];
                }
            }

            return Merge(Mergesort(left), Mergesort(right)); //recursively call merge on sorted parts of the array

        }

        private static T[] Merge(T[] left, T[] right)
        {

            T[] SortedArray = new T[left.Length + right.Length];
            int LeftIndex = 0;
            int RightIndex = 0;
            int SortedArrayIndex = 0;

            while (LeftIndex < left.Length && RightIndex < right.Length)
            {
                
                if (left[LeftIndex].CompareTo(right[RightIndex]) <0) //-1 is <, 0 is =, 1 is >
                {

                    SortedArray[SortedArrayIndex] = left[LeftIndex];

                    LeftIndex++;
                }

                else
                {
                    SortedArray[SortedArrayIndex] = right[RightIndex];

                    RightIndex++;
                }
                SortedArrayIndex++;
            }

            while(LeftIndex< left.Length)
            {
                SortedArray[SortedArrayIndex] = left[LeftIndex];
                LeftIndex++;
                SortedArrayIndex++;
            }
            while(RightIndex<right.Length)
            {
                SortedArray[SortedArrayIndex] = right[RightIndex];

                SortedArrayIndex++;
                RightIndex++;
            }
            return SortedArray;

        }


    }
}
