/*
 Write a program in C# to get a number and make such a pattern like right angle triangle with number increased by 1
Test Data
Enter a number : 4
Expected Output :
1
2 3
4 5 6
7 8 9 10

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

            int sum = 0 ;
            for(int i = 1 ; i <= x ; i++)
            {
                for(int j = 1 ; j <= i ; j++)
                {
                    Console.Write(++sum + " ");
                }
                Console.Write("\n");
            }

        
        }
    }
}
