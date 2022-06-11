using System;

namespace _3._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            string[] b = a.Split(" ");
            int[] arr = new int[b.Length];
            int suma = 0;
            for (int i = 0; i < b.Length; i++)
            {
                arr[i] = Convert.ToInt32(b[i]);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    suma += arr[i];
            }
            Console.WriteLine(suma);
        }
    }
}
