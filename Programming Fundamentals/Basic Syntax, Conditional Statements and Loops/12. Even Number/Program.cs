using System;

namespace _12._Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a= 1;
            while (a % 2 != 0)
            {
                a = Convert.ToInt32(Console.ReadLine());
                if(a % 2 == 1)
                Console.WriteLine("Please write an even number.");
            }
            Console.WriteLine(Math.Abs(a));
            
        }
    }
}
