/*
 * 10. 8).	В базе данных хранятся номера сотрудников, которым была выписана премия за месяц. 
 * Проверить, не попал ли кто-либо из сотрудников в эту базу дважды.
 * 
 * P.S. Считаем, что список не упорядочен
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LabRabota4_1
{
    class Program
    {
        delegate bool Func(int[] array);

        static double TimeFunc(Func func, int[] array, int number=5)
        {
            // секундомер
            Stopwatch sw = new Stopwatch();
            // время работы
            double time = 0;

            func(array);

            for (int i = 1; i <= number; i++)
            {
                sw.Reset();
                //засекаем время начала работы алгоритма
                sw.Start();

                func(array);

                // останавливаем время 
                sw.Stop();
                // суммируем время работы алгоритма
                time += sw.ElapsedMilliseconds;
            }
            // определяем среднее время работы алгоритма
            time /= number;

            return time;
        }

        static bool Check(int[] array)
        {
            // результат повторения персонала в БД
            bool check = false;

            if (array.Length > 1)
                for (int first = 0; first < array.Length - 1; first++)
                {
                    for (int second = first + 1; second < array.Length; second++)
                        if (array[first] == array[second])
                        {
                            check = true;
                            break;
                        }

                    if (check)
                        break;
                }
            return check;
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            // список для хранения количества элементов массива
            List<int> n = new List<int> { 10000, 20000, 30000, 40000, 50000 };
            double timeWork = 0;

            foreach (int k in n)
            {
                Console.WriteLine("----------     Количество элементов массива {0}    ---------- ", k);
                int[] mas = new int[k];
                

                // средний случай
                
                for (int i = 0; i < mas.Length; i++)
                    mas[i] = rand.Next(0, 5 * k);

                timeWork = TimeFunc(Check, mas);
                Console.WriteLine("Время работы алгоритма в среднем случае {0}", timeWork);

                // лучший случай
                for (int i = 0; i < mas.Length; i++)
                    mas[i] = i;
                mas[1] = 0;

                timeWork = TimeFunc(Check, mas);
                Console.WriteLine("Время работы алгоритма в лучшем случае {0}", timeWork);

                // худший случай
                for (int i = 0; i < mas.Length; i++)
                    mas[i] = i;

                timeWork = TimeFunc(Check, mas);
                Console.WriteLine("Время работы алгоритма в худшем случае {0}", timeWork);
            }
            Console.ReadLine();
        }
    }
}
