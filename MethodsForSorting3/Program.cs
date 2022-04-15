using System;
using System.Collections.Generic;

namespace MethodsForSorting2
{
    class Program
    {
        public static void CountingSorting(int[] array)
        {
            int min = array[0];
            int max = array[0];
            foreach (int x in array)
            {
                if (x < min)
                    min = x;
                if (x > max)
                    max = x;
            }

            int size = max - min + 1;
            int[] array_2 = new int[size];


            foreach (int x in array)
                array_2[x - min] += 1;


            int i = 0;
            for (int count = 0; count < size; count++)
            {
                while (array_2[count] > 0)
                {
                    array_2[count] -= 1;
                    array[i] = count + min;
                    i += 1;
                }
            }
        }

        public static void PigeonSorting(int[] array)
        {
            SortedDictionary<int, int> sortedDict = new SortedDictionary<int, int>();

            foreach (int x in array)
                if (sortedDict.ContainsKey(x))
                    sortedDict[x] += 1;
                else
                    sortedDict[x] = 1;


            int i = 0;
            foreach (int count in sortedDict.Keys)
            {
                for (int x = 0; x < sortedDict[count]; x++)
                {
                    array[i] = count;
                    i += 1;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 2, 4, 3, 7, 0, 1, 10, 15, 21 };
            CountingSorting(array);
            foreach (int x in array)
                Console.Write(x + " ");
            Console.WriteLine();

            array = new int[] { 2, 2, 4, 3, 7, 0, 1, 10, 15, 21 };
            PigeonSorting(array);
            foreach (int x in array)
                Console.Write(x + " ");
        }
    }
}
