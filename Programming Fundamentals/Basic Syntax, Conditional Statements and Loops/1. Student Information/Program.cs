using System;

namespace Student_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ime = Console.ReadLine();
            int god = Convert.ToInt32(Console.ReadLine());
            double grade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Name: {ime}, Age: {god}, Grade: {grade:f2}");
        }
    }
}
