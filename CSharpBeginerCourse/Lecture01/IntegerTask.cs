using System;

namespace Lecture01
{
    class IntegerTask
    {
        public static int Integer4(int a, int b)
        {
            var n = a / b;
            return n;
        }

        public static int Integer5(int a, int b)
        {
            var n = a % b;
            return n;
        }

        public static string Integer6(int a)
        {
            var units = a % 10;
            var tens = a / 10;
            var result = "Tens is " + tens + " and units is " + units;
            return result;
        }

        public static int GetDigit(int a, int position)//Integer10, integer17, integer 18
        {
            var newa = a / (int) Math.Pow(10, position - 1);
            var digit = newa % 10;
            return digit;
        }

        public static int Integer15(int a)
        {
            var a1 = GetDigit(a, 2);
            var a2 = GetDigit(a, 3);
            var a3 = GetDigit(a, 1);
            var newa = a1 * 100 + a2 * 10 + a3;
            return newa;
        }

        public static int Integer28(int day, int januaryFirst)//24_25_26_27
        {
            var dayOfWeek = day / 7 - januaryFirst + 2;
            return dayOfWeek;
        }
    }
}
