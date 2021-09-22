using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0, n = 0;
            Console.WriteLine("Введите размеры массива (m*n):");
            
            while (m < 2)
            {
                Console.WriteLine("m (m>1):");
                m = Int32.Parse(Console.ReadLine());
            }
            while (n < 2)
            {
                Console.WriteLine("n (n>1):");
                n = Int32.Parse(Console.ReadLine());
            }
               
            int[,] a = new int[m, n];
            int s = m * n;
            int c = 0;
            int k = 0;
            
            while (true)
            {
                for (int i = 0+k; i < m-k; i++)
                {
                    c++;
                    a[k, i] = c;
                    if (c == s)
                        break;
                }
                if (c == s)
                    break;

                for (int i = 1+k; i < n-k; i++)
                {
                    c++;
                    a[i, n-1-k] = c;
                    if (c == s)
                        break;
                }
                if (c == s)
                    break;

                for (int i = m-2-k; i >= 0+k; i--)
                {
                    c++;
                    a[m-1-k, i] = c;
                    if (c == s)
                        break;
                }
                if (c == s)
                    break;

                for (int i = n-2-k; i >= 1+k; i--)
                {
                    c++;
                    a[i, k] = c;
                    if (c == s)
                        break;
                }
                if (c == s)
                    break;

                k++;
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0, 3}  ", a[i, j]);
                }
                Console.WriteLine();
            }

            /*
            Console.WriteLine("Повторить? 1 - да, иначе - нет");
            i = Int32.Parse(Console.ReadLine());
            if (i == 1)
                goto m;
            */
        }
    }
}
