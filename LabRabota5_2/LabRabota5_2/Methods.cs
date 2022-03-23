using System;
using System.Collections.Generic;
using System.Text;

namespace LabRabota5_2
{
    public class Methods
    {
        // метод быстрого линейного поиска
        public static int FastLinearMethod(int[] array, int x)
        {
            int i = 0, len = array.Length;
            while (i < len-1 && array[i] < x)
            {
                i++;
            }

            if (array[i] == x)
                return i;
            else
                return -1;
        }

        // медод итерационного бинарного поиска
        public static int IterativeBinaryMethod(int[] array, int x)
        {
            int i1 = 0, i2 = array.Length - 1, i = -1;
            while (i1 != i2)
            {
                int i_n = (i1 + i2) / 2;

                if (array[i_n] == x)
                    i = i_n;
                if (array[i_n] >= x)
                    i2 = i_n;
                else
                    i1 = i_n;
                if (i2 - i1 == 1 && array[i1] != x)
                {
                    i1 = i2;
                    if (array[i2] == x)
                        i = i2;
                }
            }
            return i;
        }

        // медод рекурсивного бинарного поиска
        public static int RecursiveBinaryMethod(int[] array, int x)
        {
            int i1 = 0, i2 = array.Length - 1;
            int i = -1;
            int Recursive(int i1, int i2)
            {
                int i_n = (i1 + i2) / 2;

                if (array[i_n] == x)
                    i = i_n;
                if (array[i_n] >= x)
                    i2 = i_n;
                else
                    i1 = i_n;
                if (i2 - i1 == 1 && array[i1] != x)
                {
                    i1 = i2;
                    if (array[i2] == x)
                        i = i2;
                }

                if (i1 != i2)
                    i = Recursive(i1, i2);
                return i;
            }
            i = Recursive(i1, i2);
            return i;
        }

        // медод поиска с прыжками
        public static int JumpingMethod(int[] array, int x)
        {
            int i1 = 0, i2 = array.Length - 1;
            int i_n = (int)Math.Floor(Math.Sqrt(i2 - i1));
            while (array[i_n] < x && i_n != i2)
            {
                i1 = i_n;
                i_n = i1 + (int)Math.Sqrt(i2 - i1);
                if (i_n > i2)
                    i_n = i2;
            }
            i2 = i_n;

            while (i1 < i2 && array[i1] < x)
            {
                i1++;
            }

            if (array[i1] == x)
                return i1;
            else
                return -1;
        }
    }
}
