using System;

namespace Lecture01
{
    public class Boolean
    {
        public static bool BoolTask13(int a, int b, int c)
        {
            return Math.Abs(a) == a || Math.Abs(b) == b || Math.Abs(c) == c;
        }

        public static bool BoolTask14(int a, int b, int c)
        {
            return a > 0 && b < 0 && c < 0 || b > 0 && a < 0 && c < 0 || c > 0 && a < 0 && b < 0;
            //return (Math.Abs(a * b * c) == a * b * c) && (a < 0 || b < 0 || c < 0); //except 0
        }

        public static bool BoolTask15(int a, int b, int c)
        {
            return a < 0 && b > 0 && c > 0 || b < 0 && a > 0 && c > 0 || c < 0 && a > 0 && b > 0;
            //return (Math.Abs(a * b * c) == a * b * c) && (a > 0 || b > 0 || c > 0); //except 0
        }

        public static bool BoolTask16(int a)
        {
            return a % 2 == 0 && a / 10 > 0;
        }

        public static bool BoolTask17(int a)
        {
            return a % 2 == 1 && a / 100 > 0;
        }
    }
}
