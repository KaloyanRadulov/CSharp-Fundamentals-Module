using System;

namespace Back_in_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            b += 30;
            if(b >= 60) { b -= 60; a++; };
            if (a == 24) a = 0;
            Console.WriteLine($"{a}:{b}");
        }
    }
}
