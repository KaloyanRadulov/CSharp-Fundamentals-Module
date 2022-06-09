using System;

namespace _3._Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int y = a * 100;
            double d = y * 365.2422;
            int h = (int)d * 24;
            int m = h * 60;
            Console.WriteLine($"{a} centuries = {y} years = {(int)d} days = {h} hours = {m} minutes");

        }
    }
}
