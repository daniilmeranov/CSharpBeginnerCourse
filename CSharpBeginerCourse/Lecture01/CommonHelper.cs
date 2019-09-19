using System;

namespace Lecture01
{
    class CommonHelper
    {
        public static string GetValue(string prompt)
        {
            Console.Write(prompt);
            var value = Console.ReadLine();
            return value;
        }

        public static void Print(string value)
        {
            Console.WriteLine(value);
        }
    }
}
