/*
 * 
 * Быстрый линейный, бинарные и поиск прыжками в упорядоченном массиве
 * 
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace LabRabota5_2
{
    class Program
    {
        // делегат-маска для функций
        delegate int Func(int[] array, int x);

        // Функция секундомера
        static double TimeFunc(Func func, int[] array, int element, int numberOfRepeats = 5)
        {
            // секундомер
            Stopwatch sw = new Stopwatch();
            // время работы
            double time = 0;

            // пустой прогон
            func(array, element);

            // получение общего времени
            for (int i = 1; i <= numberOfRepeats; i++)
            {
                sw.Reset();
                sw.Start();

                func(array, element);

                sw.Stop();

                // суммируем время работы алгоритма
                time += sw.ElapsedTicks;
            }
            // определяем среднее время работы алгоритма
            time /= numberOfRepeats;

            return time;
        }


        // основная функция
        static void Main(string[] args)
        {
            Random rand = new Random();

            // список для хранения количества элементов массива
            List<int> n = new List<int> { 1000, 2000, 3000, 4000, 5000 };
            
            foreach (Func func in new Func[] { Methods.FastLinearMethod, Methods.IterativeBinaryMethod,
                Methods.RecursiveBinaryMethod, Methods.JumpingMethod})
            {
                if (func == Methods.FastLinearMethod)
                    Console.WriteLine("[---------           Быстрый линейный поиск          ---------]");
                else if (func == Methods.IterativeBinaryMethod)
                    Console.WriteLine("[---------        Итерационный бинарный поиск        ---------]");
                else if (func == Methods.RecursiveBinaryMethod)
                    Console.WriteLine("[---------        Рекурсивный бинарный поиск         ---------]");
                else if (func == Methods.JumpingMethod)
                    Console.WriteLine("[---------          Поиск методом прыжками           ---------]");
                foreach (int k in n)
                {
                    Console.WriteLine("----------  Количество элементов массива: {0}  ----------", k);

                    int[] array = new int[k];
                    int searchedElement;
                    
                    // худший случай
                    for (int i = 0; i < k; i++)
                        array[i] = i;
                    searchedElement = k;

                    double timeWork = TimeFunc(func, array, searchedElement);
                    Console.WriteLine("Время работы алгоритма в худшем случае: {0}", timeWork);
                }
                Console.WriteLine();
            }
            

            Console.ReadKey();
        }
    }
}