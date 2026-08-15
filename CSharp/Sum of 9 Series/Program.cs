/* Write a program in C# to display the sum of the series [ 9 + 99 + 999 + 9999 ...]. 
Test Data :
Please enter number of terms :5
Expected Output :
9 + 99 + 999 + 9999 + 99999 = 111105

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

            string str = "9" ;
            int sum = 0 ;
            for(int i=1 ; i <= n ; i++)
            {
                if(i != 1)
                {
                str += "9" ; 
                }
                int num = Convert.ToInt32(str);
                sum += num ;
                Console.Write(str);
                if(i != n)
                {
                    Console.Write(" + ");
                }
                
            }
            Console.Write(" = " + sum);
        }

        
    }
}

