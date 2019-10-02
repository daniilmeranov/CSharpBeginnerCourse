using System;
using System.Runtime.InteropServices;

namespace IfSwitchForWhile
{
    class IfSwitch
    {
        public static int? IfTask13(int a, int b, int c)
        {
            if ((a < b && a > c) || (a > b && a < c)) return a;
            if ((b < a && b > c) || (b > a && b < c)) return b;
            if ((c < b && c > a) || (c > b && c < a)) return c;
            return null;
        }

        public static double Min(double a, double b, double c)
        {
            var ret = a;
            if (b < a && b < c) ret = b;
            if (c < a && c < b) ret = c;
            return ret;
        }
        public static double Max(double a, double b, double c)
        {
            var ret = a;
            if (b > a && b > c) ret = b;
            if (c > a && c > b) ret = c;
            return ret;
        }

        public static string IfTask14(double a, double b, double c)
        {
            return "Minimum is " + Min(a, b, c) + " and maximum is " + Max(a, b, c);
        }

        public static double IfTask15(double a, double b, double c)
        {
            return a + b + c - Min(a, b, c);
        }

        public static string IfTask16(double a, double b, double c)
        {
            double newA;
            double newB;
            double newC;
            if (a < b && b < c)
            {
                newA = a * 2;
                newB = b * 2;
                newC = c * 2;
            }
            else
            {
                newA = -a;
                newB = -b;
                newC = -c;
            }

            return "New values are a=" + newA + ", b=" + newB + ", c=" + newC;
        }

        public static string IfTask17(double a, double b, double c)
        {
            double newA;
            double newB;
            double newC;
            if (a < b && b < c || a > b && b > c)
            {
                newA = a * 2;
                newB = b * 2;
                newC = c * 2;
            }
            else
            {
                newA = -a;
                newB = -b;
                newC = -c;
            }

            return "New values are a=" + newA + ", b=" + newB + ", c=" + newC;
        }


        public static void CaseTask13(int n, double value)
        {
            double a, c, h, s;
            switch (n)
            {
                case 1:
                    a = value;
                    c = a * Math.Sqrt(2);
                    h = a * Math.Sqrt(2) / 2;
                    s = a * a / 2;
                    break;
                case 2:
                    c = value;
                    a = c / Math.Sqrt(2);
                    h = c / 2;
                    s = c * c / 4;
                    break;
                case 3:
                    h = value;
                    a = 2 * h / Math.Sqrt(2);
                    c = 2 * h;
                    s = h * h;
                    break;
                case 4:
                    s = value;
                    a = Math.Sqrt(2 * s);
                    c = 2 * Math.Sqrt(s);
                    h = Math.Sqrt(s);
                    break;
                default:
                    Console.WriteLine("Something wrong!");
                    return;
            }

            Console.WriteLine("Results is: a=" + a + ", c=" + c + ", h=" + h + ", S=" + s);
        }
        public static void CaseTask14(int n, double value)
        {
            double a, r1, r2, s;
            switch (n)
            {
                case 1:
                    a = value;
                    r1 = a * Math.Sqrt(3) / 6;
                    r2 = a * Math.Sqrt(3) / 3;
                    s = a * a * Math.Sqrt(3) / 4;
                    break;
                case 2:
                    r1 = value;
                    a = 6 * r1 / Math.Sqrt(3);
                    r2 = 2 * r1;
                    s = 3 * Math.Sqrt(3) * r1 * r1;
                    break;
                case 3:
                    r2 = value;
                    a = 3 * r2 / Math.Sqrt(3);
                    r1 = r2 / 2;
                    s = 3 * Math.Sqrt(3) * r2 * r2 / 4;
                    break;
                case 4:
                    s = value;
                    a = 2 * Math.Sqrt(s/ Math.Sqrt(3));
                    r1 = Math.Sqrt(s / (3 * Math.Sqrt(3)));
                    r2 = 2 * Math.Sqrt(s / (3 * Math.Sqrt(3)));
                    break;
                default:
                    Console.WriteLine("Something wrong!");
                    return;
            }

            Console.WriteLine("Results is: a=" + a + ", R1=" + r1 + ", R2=" + r2 + ", S=" + s);
        }


        public static void CaseTask15(int m, int n)
        {
            Console.Write("This is ");
            switch (n)
            {
                case 6:
                    Console.Write("six ");
                    break;
                case 7:
                    Console.Write("seven ");
                    break;
                case 8:
                    Console.Write("eight ");
                    break;
                case 9:
                    Console.Write("nine ");
                    break;
                case 10:
                    Console.Write("ten ");
                    break;
                case 11:
                    Console.Write("jack ");
                    break;
                case 12:
                    Console.Write("queen ");
                    break;
                case 13:
                    Console.Write("king ");
                    break;
                case 14:
                    Console.Write("ace ");
                    break;
                default:
                    Console.WriteLine("Something wrong!");
                    return;
            }

            switch (m)
            {
                case 1:
                    Console.WriteLine("of spades!");
                    break;
                case 2:
                    Console.WriteLine("of clubs!");
                    break;
                case 3:
                    Console.WriteLine("of diamonds!");
                    break;
                case 4:
                    Console.WriteLine("of hearts!");
                    break;
                default:
                    Console.WriteLine("Something wrong!");
                    return;
            }
        }

        public static void CaseTask16(int age)
        {
            Console.Write("Вам " + age);
            if (age / 10 % 10 == 1)
                Console.WriteLine(" років");
            else
                switch (age % 10)
                {
                    case 1:
                        Console.WriteLine(" рік");
                        break;
                    case 2:
                    case 3:
                    case 4:
                        Console.WriteLine(" роки");
                        break;
                    default:
                        Console.WriteLine(" років");
                        break;
                }
        }

        public static void CaseTask17(int a)
        {
            Console.Write("Треба зробити " + a);
            if (a / 10 % 10 == 1)
                Console.WriteLine(" завдань");//заданий
            else
                switch (a % 10)
                {
                    case 1:
                        Console.WriteLine(" завдання");//задание
                        break;
                    case 2:
                    case 3:
                    case 4:
                        Console.WriteLine(" завдання");//задания
                        break;
                    default:
                        Console.WriteLine(" завдань");//заданий
                        break;
                }

        }
    }
}
