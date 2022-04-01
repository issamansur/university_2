using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsForSorting
{
    public class Methods
    {
        public delegate void Func(int[] array);

        public static Func[] AllFunc = new Func[] { StupidSort, BubbleSort, 
        CocktailSort, InsertionSort, GnomeSort, SelectionSort, CombSort, 
        ShellSort};

        public static void StupidSort(int[] array)
        {
            int i = 0, tmp;
            while (i < array.Length - 1)
            {
                if (array[i + 1] < array[i])
                {
                    tmp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = tmp;
                    i = 0;
                }
                else i++;
            }
        }

        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < array.Length - 1 - i; j++)
                    if (array[j] > array[j + 1])
                    {
                        int x = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = x;
                    }
        }

        public static void CocktailSort(int[] array)
        {
            int left = 0,
                 right = array.Length - 1;
            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int x = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = x;
                    }
                }
                right--;
                for (int i = right; i > left; i--)
                {
                    if (array[i - 1] > array[i])
                    {
                        int x = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = x;
                    }
                }
            }
        }

        public static void InsertionSort(int[] array)
        {
            int x;
            int j;
            for (int i = 1; i < array.Length; i++)
            {
                x = array[i];
                j = i;
                while (j > 0 && array[j - 1] > x)
                {
                    int z = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = z;
                    j -= 1;
                }
                array[j] = x;
            }
        }

        public static void GnomeSort(int[] array)
        {
            var i = 1;
            var nextIndex = i + 1;

            while (i < array.Length)
            {
                if (array[i - 1] < array[i])
                {
                    i = nextIndex;
                    nextIndex++;
                }
                else
                {
                    int x = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = x;
                    i--;
                    if (i == 0)
                    {
                        i = nextIndex;
                        nextIndex++;
                    }
                }
            }
        }



        public static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; ++i)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; ++j)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                int x = array[i];
                array[i] = array[min];
                array[min] = x;
            }
        }

        public static void CombSort(int[] array)
        {
            double gap = array.Length;
            bool swaps = true;
            while (gap > 1 || swaps)
            {
                gap /= 1.247330950103979;
                if (gap < 1) { gap = 1; }
                int i = 0;
                swaps = false;
                while (i + gap < array.Length)
                {
                    int igap = i + (int)gap;
                    if (array[i] > array[igap])
                    {
                        int swap = array[i];
                        array[i] = array[igap];
                        array[igap] = swap;
                        swaps = true;
                    }
                    i++;
                }
            }
        }

        public static void ShellSort(int[] array)
        {
            int n = array.Length;
            for (int step = n / 2; step > 0; step /= 2)
            {
                for (int i = step; i < n; i++)
                {
                    for (int j = i - step; j >= 0 && array[j] > array[j + step]; j -= step)
                    {
                        int x = array[j];
                        array[j] = array[j + step];
                        array[j + step] = x;
                    }
                }
            }
        }


    }
}
