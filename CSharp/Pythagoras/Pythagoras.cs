using System;

namespace Pythagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side A : ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter side B : ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The chord is {Math.Round(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)), 2)} ");

        }
    }
}