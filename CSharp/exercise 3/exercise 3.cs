/*
Write a program in C# to display the pattern like right angle triangle with  getting a number.

Test Data
Enter a number : 4
Expected Output :
1
12
123
1234

*/
using System;

namespace Ttaining
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number :");
            int x = Convert.ToInt32(Console.ReadLine());

            for(int i = 1 ; i <= x ; i++)
            {
                for(int j = 1 ; j <= i ; j++)
                {
                    Console.Write(j);
                }
                Console.Write("\n");
            }

        
        }
    }
}
