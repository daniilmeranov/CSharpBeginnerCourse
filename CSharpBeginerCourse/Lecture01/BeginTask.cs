using System;

namespace Lecture01
{
    class BeginTask
    {
        const double pi = 3.14;

        public static int GetSquare(int a)
        {
            var s = a * a;
            return s;
        }

        public static int GetSquare(int a, int b)
        {
            var s = a * b;
            return s;
        }

        public static int GetPerimeter(int a)
        {
            var p = a * 4;
            return p;
        }

        public static int GetPerimeter(int a, int b)
        {
            var p = (a + b) * 2;
            return p;
        }

        public static double GetHypotenuse(double a, double b)
        {
            var c = Math.Sqrt(a * a + b * b);
            return c;
        }

        public static double GetPerimeter(double a, double b, double c)
        {
            var p = a + b + c;
            return p;
        }

        public static string Begin12(double a, double b)
        {
            var c = GetHypotenuse(a, b);
            var p = GetPerimeter(a, b, c);
            var result = "Hypotenuse is " + c + "; Perimeter is " + p;
            return result;
        }

        public static double Begin25(double x)
        {
            var y = Math.Pow(x, 6) * 3 - Math.Pow(x, 2) * 6 - 7;
            return y;
        }

        public static double Begin29(double a)
        {
            var rad = pi / 180 * a;
            return rad;
        }

        public static double Begin30(double a)
        {
            var grad = a / pi * 180;
            return grad;
        }

        public static int GetThirdParameterLimit(int a, int b)
        {
            var c = b * b / (4 * a);
            return c;
        }

        public static int GetDiscriminant(int a, int b, int c)
        {
            var d = b * b - 4 * a * c;
            return d;
        }

        public static string Begin39(int a, int b, int c)
        {
            var discriminant = GetDiscriminant(a, b, c);
            var x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            var x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            var result = "Results are " + x1 + " and " + x2;
            return result;
        }
    }
}
