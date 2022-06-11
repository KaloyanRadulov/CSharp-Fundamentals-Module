using System;

namespace _1._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int a = Convert.ToInt32(Console.ReadLine());
            if(a > 0 && a < 8) Console.WriteLine(names[a-1]);
            else Console.WriteLine("Invalid day!");
        }
    }
}
