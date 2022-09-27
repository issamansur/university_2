using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    static public class Numeric
    {
        public delegate double Func(double x);

        static public double PolDel(Func f, double a, double b, double eps)
        {
            double c = (a + b) / 2;
            while (b - a > 0.0000000000001)
            {
                if (f(a) * f(c) < 0)
                    b = c;
                else
                    a = c;
                c = (a + b) / 2;
            }
            return (a + b) / 2;
        }

        static public double Sec(Func f, double a, double b, double eps)
        {
            while (b - a > 0.0000000000001)
            {
                a = b - (b - a) * f (b) / (f(b)- f (a));
                b = a - (a - b) * f(a) / (f(a) - f(b));
            }

            return b;
        }



        static public double Kas(Func f, Func df, double a, double b, double eps)
        {
            double c = (a + b) / 2;
            while (f(c) > 0.0000000000001)
                c = c - f(c) / df(c);

            return c;
        }
    }
}
