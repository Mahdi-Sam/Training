// Write a program in C# to get length of array and its elements then sort and print it



using System;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter length of array : ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            int[] myNumbers = new int [arrayLength];

            inputNumbers(myNumbers);
            Array.Sort(myNumbers);
            Console.Write("Array sorted : { ");
            printNumbers(myNumbers);

        }
        static void inputNumbers (int[] numbers)
        {
            for(int i = 0 ; i < numbers.Length ; i++)
            {
                Console.WriteLine($"{i+1}_ Please enter a number : ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void printNumbers(int[] numbers)
        {
            for(int i = 0 ; i < numbers.Length ; i++)
            {

                Console.Write(numbers[i] );
                if(i == numbers.Length - 1 )
                {
                    Console.Write(" }");
                }
                else 
                {
                    Console.Write(" , ");
                }
            }
        }            


        
    }
}

