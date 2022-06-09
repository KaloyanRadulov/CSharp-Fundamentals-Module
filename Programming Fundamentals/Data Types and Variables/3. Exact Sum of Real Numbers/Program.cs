using System;

namespace _3._Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            double y = 0;
            for(int i = 0; i < a; i++)
            {
                double b = Convert.ToDouble(Console.ReadLine());
                y += b;
            }
            Console.WriteLine(y);
        }
    }
}
