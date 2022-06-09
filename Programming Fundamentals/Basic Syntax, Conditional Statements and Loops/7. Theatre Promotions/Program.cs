using System;

namespace _5._Month_Printer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int b = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case "Weekday":
                    if (b >= 0 && b <= 18)
                        Console.WriteLine("12$");
                    else if (b > 18 && b <= 64)
                        Console.WriteLine("18$");
                    else if(b > 64 && b <= 122)
                        Console.WriteLine("12$");
                    else Console.WriteLine("Error!");
                    break;

                case "Weekend":
                    if (b >= 0 && b <= 18)
                        Console.WriteLine("15$");
                    else if (b > 18 && b <= 64)
                        Console.WriteLine("20$");
                    else if (b > 64 && b <= 122)
                        Console.WriteLine("15$");
                    else Console.WriteLine("Error!");
                    break;
                case "Holiday":

                    if (b >= 0 && b <= 18)
                        Console.WriteLine("5$");
                    else if (b > 18 && b <= 64)
                        Console.WriteLine("12$");
                    else if (b > 64 && b <= 122)
                        Console.WriteLine("10$");
                    else Console.WriteLine("Error!");
                    break;
            }
        }
    }
}
