using System;
namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number :");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter power :");
            int pow = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"{num}^{pow} = {power(num, pow)}");

            Console.WriteLine($"max num is {findMax(enterArray())}");
            Console.WriteLine($"min num is {findMin(enterArray())}");

        }

        static int power(int x, int y)
        {
            int result = 1 ;
            for(int i=1; i <= y; i++ )
            {
                result *= x ;
            }
            return result ;
        }
        
        static int[] enterArray ()
        {
            Console.WriteLine("Please enter array length :");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"enter argument {i+1} :");
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            return myArray ;
        }

        static int findMax(int[] x)
        {
            int max = x[0] ;
            foreach(int num in x)
            {
                if(num > max)
                    max = num;
            }
            return max ;
        }

        static int findMin(int[] x)
        {
            int Min = x[0] ;
            foreach(int num in x)
            {
                if(num < Min)
                    Min = num;
            }
            return Min ;
        }
        
    }
}
