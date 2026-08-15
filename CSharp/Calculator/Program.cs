using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            char loading ;
            do
            {
                Console.Clear();
                Console.WriteLine("------------------ \nCalculator Pragram \n------------------");

                var num1 = new Number();
                var num2 = new Number();
                var opr = new Oprand();

                try
                {
                    opr.action(num1.getNum(), num2.getNum(), opr.getOprand());
                }
                catch(FormatException)
                {
                    Console.WriteLine("That was not a valid type");
                }
                Number.count = 0 ;

                Console.WriteLine("Would you like you to continue ? (y/n) ");
                loading = Convert.ToChar(Console.ReadLine());
            }while(loading == 'y');
            if(loading != 'n')
            {
                Console.WriteLine("You entered wrong character");
            }
        }
    }
    public class Number
    {
        public static int count ;
        int Num ;
        public int getNum ()
        {
            count++ ;
            Console.Write($"Enter number {count} : " );
            Num = Convert.ToInt32(Console.ReadLine());
            return Num ;
        }
    }
    public class Oprand 
    {
        char oprand ;
        public char getOprand()
        {
            Console.WriteLine("Options : \n\t + : Add \n\t - : Substract \n\t * : Multiply \n\t / : Divide ");
            Console.Write("Enter an option : ");
            oprand = Convert.ToChar(Console.ReadLine());
            return oprand ;
        }
        public void action (int num1 , int num2 , char oprand)
        {
            double result ;
            void printResult ()
            {
                Console.WriteLine(num1 + $" {oprand} " + num2 + " = " + result);
            }
            switch(oprand)
            {
                case '+' : result = num1 + num2 ; printResult() ; break ;
                case '-' : result = num1 - num2 ; printResult() ; break ;
                case '*' : result = num1 * num2 ; printResult() ; break ;
                case '/' : result = Math.Round((double) num1 / num2 , 2); printResult() ; break ;
                default : Console.WriteLine("That was not a valid option"); break ;
            }
        }
    }
}
