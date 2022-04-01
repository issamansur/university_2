using System;
using System.Diagnostics;

namespace MethodsForSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array;

            foreach (Methods.Func func in Methods.AllFunc)
            {
                array = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
                func(array);
                foreach (int x in array)
                    Console.Write(x + " ");
                Console.WriteLine();
            }
        }
    }
}
