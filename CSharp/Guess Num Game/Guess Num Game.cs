using System;

namespace C__Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuous = ' ';
            do
            {
                Random random = new Random();
                int number = random.Next(1, 101);
                Console.WriteLine("guess a number between 1_100 : ");
                int guess = Convert.ToInt32(Console.ReadLine());
                int round = 1;
                while (number != guess)
                {
                    if (guess > number)
                    {
                        Console.WriteLine($"{guess} is high . guess again : ");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine($"{guess} is low . guess again : ");
                    }
                    guess = Convert.ToInt32(Console.ReadLine());
                    round++;
                }
                Console.WriteLine($"Congratulation . you guessed true in round {round}  ^_^ ");
                Console.WriteLine("do you want to play again ? (y/n) ");
                continuous = Convert.ToChar(Console.ReadLine());
            }
            while (continuous == 'y' || continuous == 'Y');
        }
    }
}