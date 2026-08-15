/* Write a program in C# to make such a pattern like a pyramid with an asterisk by getting line's number 
Test Data
Please enter number of lines : 5

      *      
     ***     
    *****    
   *******   
  *********
*/

using System;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter number of lines : ");
            int line = Convert.ToInt32(Console.ReadLine());

            for(int i=1 ; i <= line ; i++)
            {
                for(int j = line - i ; j > 0 ; j-- )
                {
                    Console.Write(" ");
                }
                for(int k = 1 ; k <= 2*i-1 ; k++ )
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            
        }

        
    }
}

