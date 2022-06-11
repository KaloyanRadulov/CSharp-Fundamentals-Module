using System;

namespace _3._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            string[] b = a.Split(" ");
            double[] arr = new double[b.Length];
            for (int i = 0; i < b.Length; i++)
            {
                arr[i] = Convert.ToDouble(b[i]);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]*10 % 10 > 4)
                Console.WriteLine($"{arr[i]} => {Math.Ceiling(arr[i])}");
                else
                    Console.WriteLine($"{arr[i]} => {Math.Floor(arr[i])}");
            }
        }
    }
}
