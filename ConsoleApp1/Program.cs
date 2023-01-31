using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "test";
            int a = 23;
            double b = 23.4;
            bool c = false;

            var value = Console.ReadLine();
            Console.WriteLine(value);
            Console.WriteLine($"Вы ввели число {value}");
            Console.ReadLine();
        }
    }
}