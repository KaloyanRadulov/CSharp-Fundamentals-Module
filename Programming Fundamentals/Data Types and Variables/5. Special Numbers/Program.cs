using System;

namespace _5._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            for(int i = 1; i <= c; i++)
            {
                b = i;
                while (b != 0)
                {
                    a += b % 10;
                    b /= 10;
                }
                if(a % 5 == 0 || a % 7 == 0 || a % 11 == 0)Console.WriteLine($"{i} -> True");
                else Console.WriteLine($"{i} -> False");
                a = 0;
            }
        }
    }
}
