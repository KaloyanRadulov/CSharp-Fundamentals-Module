using System;

namespace _8._Divisible_by_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int suma = 0;
            int b = 1;
            for (int i = 0; i < a; i ++)
            {
                Console.WriteLine(b);
                suma += b;
                b += 2;
                
            }
            Console.WriteLine("Sum: " + suma);
        }
    }
}
