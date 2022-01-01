using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingDemos
{
    internal class SortingsDemo
    {
        public static void RunSort()
        {
            MergeSort(Samples()[8]);
            PrintOut(Samples()[8]);
            //foreach (var element in Samples())
            //{
            //    BubbleSort(element);
            //    PrintOut(element);
            //}
        }
        public static void BubbleSort(int[] array)
        {
            for (int partIndex = array.Length - 1; partIndex > 0; partIndex--)
            {
                for (int i = 0; i < partIndex; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                }
            }
        }

        public static void SelectionSort(int[] array)
        {
            for (int partIndex = array.Length - 1; partIndex > 0; partIndex--)
            {
                int largestAt = 0;
                for (int i = 1; i <= partIndex; i++)
                {
                    if (array[i] > array[largestAt])
                    {
                        largestAt = i;
                    }
                }
                Swap(array, largestAt, partIndex);
            }
        }

        public static void InsertionSort(int[] array)
        {
            for (int partIndex = 1; partIndex < array.Length; partIndex++)
            {
                int curUnsorted = array[partIndex];
                int i = 0;
                for (i = partIndex; i > 0 && array[i - 1] > curUnsorted; i--)
                {
                    array[i] = array[i - 1];
                }

                array[i] = curUnsorted;
            }
        }

        public static void ShellSort(int[] array)
        {
            int gap = 1;
            while (gap < array.Length / 3)
                gap = 3 * gap + 1;

            while (gap >= 1)
            {
                for (int i = gap; i < array.Length; i++)
                {
                    for (int j = i; j >= gap && array[j] < array[j - gap]; j -= gap)
                    {
                        Swap(array, j, j - gap);
                    }

                }
                gap /= 3;
            }
        }

        public static void MergeSort(int[] array) {
            Sortarray(array, 0, array.Length - 1);
        }

        private static void Sortarray(int[] array, int left, int right) {

            if (right>left) {
                int mid = (right + left) / 2;
                Sortarray(array, left, mid);
                Sortarray(array,mid+1, right);
                MergeArrays(array, left, (mid + 1), right);
            }
        }

        private static void MergeArrays(int[] array, int left, int mid, int right) {
            int[] temp=new int[array.Length];
            int leftEnd=mid-1, elementsCount=(right-left+1), tempPosition=left;

            while (left <=leftEnd && mid<=right) {
                if (array[left]<=array[mid]) {
                    temp[tempPosition++] = array[left++];
                } else {
                    temp[tempPosition++] = array[mid++];
                }
            }
            while (left <=leftEnd)
                temp[tempPosition++] = array[left++];

            while (mid<=right)
                temp[tempPosition++]=array[mid++];

            for (int i = 0; i < elementsCount; i++) {
                array[right] = temp[right];
                right--;
            }
        }

        private static int[][] Samples()
        {
            int[][] samples = new int[9][];
            samples[0] = new[] { 1 };
            samples[1] = new[] { 2, 1 };
            samples[2] = new[] { 2, 1, 3 };
            samples[3] = new[] { 1, 1, 1 };
            samples[4] = new[] { 2, -1, 3, 3 };
            samples[5] = new[] { 4, -5, 3, 3 };
            samples[6] = new[] { 0, -5, 3, 3 };
            samples[7] = new[] { 0, -5, 3, 0 };
            samples[8] = new[] { 3, 2, 5, 5, 1, 0, 7, 8 };

            return samples;
        }

        private static void PrintOut(int[] array)
        {
            Console.WriteLine("-----TRACE-----\n");
            foreach (var el in array)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine("\n----------------------\n");
        }
        private static void Swap(int[] array, int i, int j)
        {
            if (i == j)
                return;
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
