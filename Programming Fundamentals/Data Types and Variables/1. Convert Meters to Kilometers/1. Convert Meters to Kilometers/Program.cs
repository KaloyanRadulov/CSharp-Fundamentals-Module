using System;

namespace _1._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            a /= 1000;
            Console.WriteLine($"{a:f2}");
        }
    }
}
