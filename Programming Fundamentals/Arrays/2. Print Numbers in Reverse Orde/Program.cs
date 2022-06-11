using System;

namespace _1._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int[] names = new int[a];
            for(int i = 0; i < names.Length; i++)
            {
                names[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = names.Length - 1; i >= 0; i--)
            {
                Console.Write(names[i] + " ");
            }
        }
    }
}
