using System;

namespace _3._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            string[] b = a.Split(" ");
            string[] c = new string[b.Length];
            int j = 0;
            for (int i = b.Length-1; i >= 0; i--)
            {
                c[j] = b[i];
                j++;
            }
            for(int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + " ");
            }
        }
    }
}
