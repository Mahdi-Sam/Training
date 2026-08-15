using System;
using System.Linq;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                matchResult(userHand(), computerHand());

            }
            while (loading() == "Y"); 
            Console.WriteLine("Thanks for playing .");
        }

        static string userHand ()
        {
            Console.WriteLine("Enter ROCK , PAPER or SCISSORS : ");
            string userHand = Console.ReadLine();
            Console.WriteLine($"Player : {userHand.ToUpper()}");
            return userHand.ToUpper() ;

        }

        static string computerHand ()
        {
            Random random = new Random();
            int x = random.Next(1, 4);
            string computerHand = null;
            switch(x)
            {
                case 1 : 
                    computerHand = "ROCK";
                    break;
                case 2 :
                    computerHand = "PAPER";
                    break;
                case 3 :
                    computerHand = "SCISSORS";
                    break;

            }
            Console.WriteLine($"computer : {computerHand}");
            return computerHand;
        }

        static void matchResult (string userHand, string computerHand)
        {
            switch (userHand)
            {
                case "ROCK" :
                    switch(computerHand)
                    {
                        case "ROCK":
                            Console.WriteLine("It's a draw !!");
                            break;
                        case "PAPER":
                            Console.WriteLine("You losed !!");
                            break;
                        case "SCISSORS":
                            Console.WriteLine("You won !!");
                            break;

                    }
                    break;
                case "PAPER" :
                    switch(computerHand)
                    {
                        case "ROCK":
                            Console.WriteLine("You won !!");
                            break;
                        case "PAPER":
                            Console.WriteLine("It's a draw !!");
                            break;
                        case "SCISSORS":
                            Console.WriteLine("You losed !!");
                            break;

                    }
                    break;
                case "SCISSORS" :
                    switch(computerHand)
                    {
                        case "ROCK":
                            Console.WriteLine("You losed !!");
                            break;
                        case "PAPER":
                            Console.WriteLine("You won !!");
                            break;
                        case "SCISSORS":
                            Console.WriteLine("It's a draw !!");
                            break;

                    }
                    break;
                
            }
        }

        static string loading ()
        {
            Console.WriteLine("Would you like to play again (Y/N) :");
            string x = Console.ReadLine();
            return x.ToUpper();
        }
    }
}
