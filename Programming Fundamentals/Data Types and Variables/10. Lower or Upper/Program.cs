using System;

namespace _10._Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = Convert.ToChar(Console.ReadLine());
            if(Char.IsUpper(a))
                Console.WriteLine("upper-case");
            else Console.WriteLine("lower-case");
        }
    }
}
