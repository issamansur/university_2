using System;
using System.Collections.Generic;

namespace MethodsForSorting4
{
    class Program
    {
        static void BlockSort(List<int> array)
        {
            // инициализация листа листов
            List<int>[] listOfLists = new List<int>[5] { new List<int>(),
                new List<int>(), new List<int>(), new List<int>(), new List<int>()
            };
            // поиск максимума, минимума и их разности
            int min = int.MaxValue, max = int.MinValue;
            foreach (int x in array)
            {
                if (x < min)
                    min = x;
                if (x > max)
                    max = x;
            }
            // нахождения интервалов для распределения в каждый блок
            int z = (max - min) / 5;

            // сортировка по блокам
            foreach (int x in array)
            {
                int index = (x - min) / z;
                if (index != 5)
                    listOfLists[index].Add(x);
                else
                    listOfLists[4].Add(x);
            }
            
            // очистка входного массива
            array.Clear();

            // перенос элементов из отсортированных блоков в входной лист
            foreach (List<int> list in listOfLists)
            {
                list.Sort();
                foreach (int x in list)
                {
                    array.Add(x);
                }
            }
        }

        static void RadixSort(List<int> array)
        {
            int range = 10; // длина алфавита сортируемого массива (0-9)
            // инициализация словаря списков и самих списков
            Dictionary<int, List<int>> dictOfLists;
            int n = 0;

            for (int i = 1; n != array.Count; i *= 10)
            {
                dictOfLists = new Dictionary<int, List<int>>();
                for (int j = 0; j < range; j++)
                    dictOfLists[j] = new List<int>();
                
                foreach (int x in array)
                    dictOfLists[x / i % 10].Add(x);

                n = dictOfLists[0].Count;

                array.Clear();
                foreach (List<int> list in dictOfLists.Values)
                    foreach (int x in list)
                        array.Add(x);
            }
        }

        static void Main(string[] args)
        {
            List<int> array1 = new List<int> { 10, 7, 5, 3, 2, 4, 0 };
            // блочная сортировка (проверка)
            BlockSort(array1);
            foreach (int x in array1)
            {
                Console.Write(x + " "); // 0 2 3 4 5 7 10
            }
            Console.WriteLine();
            // поразрядная сортировка (проверка)
            List<int> array2 = new List<int> { 100, 97, 3, 28, 15, 17, 6, 127 };
            RadixSort(array2);
            foreach (int x in array2)
            {
                Console.Write(x + " "); // 3 6 15 17 28 97 100 127
            }
            Console.WriteLine();
        }
    }
}
