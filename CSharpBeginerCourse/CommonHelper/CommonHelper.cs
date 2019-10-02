using System;

namespace CommonHelper
{
    public class CommonHelper
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
