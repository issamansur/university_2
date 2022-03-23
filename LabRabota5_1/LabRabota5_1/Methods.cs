using System;
using System.Collections.Generic;
using System.Text;

namespace LabRabota5_1
{
    public class Methods
    {
        // метод линейного поиска
        public static int LinearMethod(int[] array, int x)
        {
            int i = 0, len = array.Length;
            while (i < len && array[i] != x)
            {
                i++;
            }

            if (i != len)
                return i;
            else
                return -1;
        }

        // медод быстрого линейного поиска
        public static int FastLinearMethod(int[] array, int x)
        {
            int i = 0;
            while (array[i] != x)
            {
                i++;
            }

            if (i != array.Length - 1)
                return i;
            else
                return -1;
        }
    }
}
