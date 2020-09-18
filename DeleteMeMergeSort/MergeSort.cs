using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DeleteMeMergeSort
{
    class mergeSort<T> where T : IComparable<T>
    {
        public static T[] MergeSort(T[] numbers)
        {

            if (numbers.Length < 2)
            {
                return numbers;
            }
            int mid = numbers.Length / 2;
            T[] left = new T[numbers.Length - mid];
            T[] right = new T[mid];

            List<T> leftSide = new List<T>();

            List<T> RightSide = new List<T>();


            for (int i = 0; i < numbers.Length; i++)
            {
                if (i < left.Length)
                {
                    leftSide[i] = numbers[i];
                }
                else
                {
                    right[i - left.Length] = numbers[i];
                }
            }

            return Merge(MergeSort(left), MergeSort(right));

        }

        private static T[] Merge(T[] left, T[] right)
        {

            T[] SortedArray = new T[left.Length + right.Length];
            int LeftIndex = 0;
            int RightIndex = 0;
            int SortedArrayIndex = 0;
            while (LeftIndex < left.Length || RightIndex < right.Length)
            {
                if (left[LeftIndex].CompareTo(right[RightIndex]) < 0) //-1 is <, 0 is =, 1 is >
                {

                    SortedArray[SortedArrayIndex] = left[LeftIndex];

                    SortedArrayIndex++;
                }

                else
                {
                    SortedArray[SortedArrayIndex] = right[RightIndex];

                    SortedArrayIndex++;
                }
            }

        }


    }
}
