using System;

namespace _2._Pounds_to_Dollars
{
    internal class Program
    {
        public static object F3 { get; private set; }

        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            a *= 1.31;
            Console.WriteLine($"{a:f3}");
        }
    }
}
