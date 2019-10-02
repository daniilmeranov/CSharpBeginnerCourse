using System;
using Microsoft.Win32;

namespace IfSwitchForWhile
{
    class ForWhile
    {
        public static double ForTask13(int n)
        {
            var res = 0.0;
            for (var i = 0; i < n; ++i)
            {
                res += Math.Pow(-1, i) * (1 + 0.1 * (i + 1));
            }

            return res;
        }

        public static int ForTask14(int n)
        {
            var res = 1;
            for (var i = 0; i <= n; ++i)
            {
                res += 2 * i - 1;
                Console.WriteLine(i + "^2=" + res);
            }

            return res;
        }

        public static double ForTask15(double a, int n)
        {
            var res = a;
            for (var i = 2; i <= n; ++i)
            {
                res *= a;
            }

            return res;
        }

        public static double ForTask16(double a, int n)
        {
            var res = a;
            for (var i = 2; i <= n; ++i)
            {
                res *= a;
                Console.WriteLine(a + "^" + i + "=" + res);
            }

            return res;

        }

        public static double ForTask17(double a, int n)
        {
            double res = 1;
            for (var i = 1; i <= n; ++i)
            {
                res += Math.Pow(a, i);
            }

            return res;
        }

        public static int WhileTask13(double a)
        {
            double res = 1;
            var k = 1;
            while (res <= a)
            {
                res += 1.0 / ++k;
            }

            Console.WriteLine("Minimal sum>" + a + " is " + res + " where k=" + k);

            return k;
        }
        public static int WhileTask14(double a)
        {
            double res = 1;
            var k = 1;
            while (res + 1.0 / (k + 1) < a)
            {
                res += 1.0 / ++k;
            }

            Console.WriteLine("Maximal sum<" + a + " is " + res + " where k=" + k);

            return k;
        }

        public static int WhileTask15(double p)
        {
            var s = 1000.0;
            var k = 0;
            while (s <= 1100)
            {
                s += s * p / 100;
                ++k;
            }

            Console.WriteLine("Value s=" + s + " after " + k + " months");
            return k;
        }
        public static int WhileTask16(double p)
        {
            var c = 10.0;
            var s = c;
            var k = 1;
            while (s < 200)
            {
                c += c * p / 100;
                s += c;
                ++k;
            }

            Console.WriteLine("Distance is s=" + s + " after " + k + " days");
            return k;
        }

        public static void WhileTask17(int n)
        {
            var val = n;
            var pos = 0;
            while (val > 0)
            {
                Console.WriteLine(++pos + " digit is " + val % 10);
                val /= 10;
            }
        }
    }
}
