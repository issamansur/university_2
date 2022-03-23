/*
*
* Линейный и быстрый линейный (с барьером) поиски в неупорядоченном массиве
*
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace LabRabota5_1
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
                time += sw.ElapsedMilliseconds;
            }
            // определяем среднее время работы алгоритма
            time /= numberOfRepeats;

            return time;
        }

        // основная функция
        static void Main()
        {
            Random rand = new Random();

            // список для хранения количества элементов массива
            List<int> n = new List<int> { 1000000, 2000000, 3000000, 4000000, 5000000 };

            foreach (int k in n)
            {
                Console.WriteLine("----------  Количество элементов массива: {0}  ----------", k);


                Console.WriteLine("[---------     Линейный метод  (обычный)           ---------]");

                int[] array = new int[k];
                int[] arrayPlusOne = new int[k + 1];
                int searchedElement;

                // средний случай
                for (int i = 0; i < k; i++)
                    array[i] = rand.Next(k);
                searchedElement = rand.Next(k);

                double timeWork = TimeFunc(Methods.LinearMethod, array, searchedElement);
                Console.WriteLine("Время работы алгоритма в среднем случае: {0}", timeWork);


                // худший случай
                for (int i = 0; i < k; i++)
                    array[i] = i;
                searchedElement = k;

                timeWork = TimeFunc(Methods.LinearMethod, array, searchedElement);
                Console.WriteLine("Время работы алгоритма в худшем случае: {0}", timeWork);


                Console.WriteLine("[---------     Линейный метод с барьером           ---------]");

                // средний случай
                for (int i = 0; i < k; i++)
                    array[i] = rand.Next(k);
                searchedElement = rand.Next(k);

                // подготовка барьера
                for (int i = 0; i < k; i++)
                    arrayPlusOne[i] = array[i];
                arrayPlusOne[k] = searchedElement;

                timeWork = TimeFunc(Methods.FastLinearMethod, arrayPlusOne, searchedElement);
                Console.WriteLine("Время работы алгоритма в среднем случае: {0}", timeWork);


                // худший случай
                for (int i = 0; i < array.Length; i++)
                    array[i] = i;
                searchedElement = k;

                // подготовка барьера
                for (int i = 0; i < k; i++)
                    arrayPlusOne[i] = array[i];
                arrayPlusOne[k] = searchedElement;

                timeWork = TimeFunc(Methods.FastLinearMethod, arrayPlusOne, searchedElement);
                Console.WriteLine("Время работы алгоритма в худшем случае: {0}", timeWork);
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}