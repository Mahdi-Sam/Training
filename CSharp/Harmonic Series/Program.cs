/* Write a program in C# to display the n terms of harmonic series and their sum. 
Test Data :
Please enter number of terms : 5
Expected Output :
1/1 + 1/2 + 1/3 + 1/4 + 1/5 = 2/283
*/

using System;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter number of terms : ");
            int n = Convert.ToInt32(Console.ReadLine());

            double sum = 0 ;
            for(int i=1 ; i <= n ; i++)
            {
                sum += (double) 1/i ;
                Console.Write($"1/{i}");
                if(i != n)
                {
                    Console.Write(" + ");
                }
                
            }
            Console.Write(" = " + Math.Round(sum, 3));
        }

        
    }
}

