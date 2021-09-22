using System;

namespace IMD
{
    class Program1
    {
        static void Main(string[] args)
        {
            int count = 0;
            int n = 0;
            while (n < 3)
            {
                Console.WriteLine("Введите размер квадратного массива (минимум 3):");
                n = Int32.Parse(Console.ReadLine());
            }
            int s = n * n;

            int[] a = new int[s];
            Random rand = new Random();
            int i;

        m:
            i = 0;

            while (i < s)
            {
                a[i] = rand.Next(1, s+1);

                for (int ip = 0; ip < i; ip++)
                {
                    if (a[i] == a[ip])
                    {
                        i--;
                        break;
                    }
                }
                i++;
            }

            int sum = 0;
            int sumd1 = 0;
            int sumd2 = 0;

            Console.WriteLine("Массив:");
            for (i = 0; i < s; i++)
            {
                Console.Write(a[i] + " ");
                if (i != 0 && (i+1) % n == 0)
                    Console.WriteLine();

                sum += a[i];

                if (i % (n + 1) == 0)
                    sumd1 += a[i];

                if (i % (n - 1) == 0)
                    sumd2 += a[i];
            }
            sumd2 -= a[0] + a[s-1];
            int sumr = sum / n;

            if ((sumr == sumd1) && (sumd1 == sumd2))
            {
                for (i = 0; i < n; i++)
                {
                    int sumi = 0;
                    int sumj = 0;
                    for (int j = 0; j < n; j++)
                    {
                        sumi += a[i * n + j];
                        sumj += a[j * n + i];
                    }
                    if ((sumr != sumi) || (sumr != sumj))
                    {
                        Console.WriteLine("Квадрат НЕ магический");
                        goto m;
                        count++;
                    }
                }
            }
            else
            {
                Console.WriteLine("Квадрат НЕ магический");
                count++;
                goto m;
            }

            Console.WriteLine("Квадрат магический");
            Console.WriteLine(count++);
            /*
            Console.WriteLine("Повторить? 1 - да, иначе - нет");
            i = Int32.Parse(Console.ReadLine());
            if (i == 1)
                goto m;
            */
        }
    }
}