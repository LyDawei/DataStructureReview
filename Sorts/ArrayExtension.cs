using System;

namespace DataStructureReview
{
    public static class ArrayExtension
    {
        private static void Swap(int[] arr, int indexA, int indexB)
        {
            var temp = arr[indexA];
            arr[indexA] = arr[indexB];
            arr[indexB] = temp;
        }

        public static void BubbleSort(this int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j, j + 1);
                    }
                }
            }
        }

        public static int[] Merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            var result = new int[resultLength];

            var indexLeft = 0;
            var indexRight = 0;
            var indexResult = 0;

            while (indexLeft < left.Length || indexRight < right.Length)
            {

                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }

                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }


        public static int[] MergeSort(this int[] arr)
        {

            if (arr.Length <= 1)
            {
                return arr;
            }

            var result = new int[arr.Length];
            var mid = arr.Length / 2;
            var left = new int[mid];
            int[] right;
            if (arr.Length % 2 == 0)
            {
                right = new int[mid];
            }
            else
            {
                right = new int[mid + 1];
            }

            for (var i = 0; i < mid; i++)
            {
                left[i] = arr[i];
            }

            var x = 0;
            for (var i = mid; i < arr.Length; i++)
            {
                right[x] = arr[i];
                x++;
            }

            left = MergeSort(left);
            right = MergeSort(right);

            result = Merge(left, right);
            return result;
        }

        public static void Entries(this int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}