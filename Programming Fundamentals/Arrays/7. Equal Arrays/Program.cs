using System;

namespace _3._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            string[] a2 = a.Split(" ");
            var b = Console.ReadLine();
            string[] b2 = a.Split(" ");
            int[] arr = new int[a2.Length];
            int[] arr2 = new int[b2.Length];
            for (int i = 0; i < a2.Length; i++)
            {
                arr[i] = Convert.ToInt32(a2[i]);
                arr2[i] = Convert.ToInt32(b2[i]);
            }
            int suma = 0;
            for (int i = 0; i < arr.Length; i++)
            {suma += arr[i];
               if(arr[i] != arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index.");
                    suma = int.MaxValue;
                    break;
                }
            }
            if (suma != int.MaxValue) Console.WriteLine($"Arrays are identical. Sum: {suma}");
        }
    }
}
