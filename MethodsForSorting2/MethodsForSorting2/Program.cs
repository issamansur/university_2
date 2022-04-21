using System;

namespace MethodsForSorting2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 7, 9, 1, 4, 3, 9, 8, 0 };
            Methods.Quicksort(array, 0, array.Length - 1);
            foreach (int x in array)
                Console.Write(x + " ");
            Console.WriteLine();

            array = new int[] { 5, 7, 9, 1, 4, 3, 9, 8, 0 };
            Methods.MergeSort(array, 0, array.Length - 1);
            foreach (int x in array)
                Console.Write(x + " ");
            Console.WriteLine();

            double[] array1 = new double[] { 5, 7, 9, 1, 4, 3, 9, 8, 0 };
            Methods.Sorting(array1, array1.Length);
            foreach (int x in array)
                Console.Write(x + " ");
        }
    }
}
