using System;

namespace _8._Divisible_by_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{a} X {i} = {a*i}");
            }
        }
    }
}
