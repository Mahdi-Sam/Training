using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight in kg :");
            var weight = Convert.ToDouble(Console.ReadLine());
            if(weight <=0){
                Console.WriteLine("You entered invalid number for weight . Please enter your weight again : ");
                weight = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Enter your hight in meter :");
            var hight = Convert.ToDouble(Console.ReadLine());
             if(hight <=0){
                Console.WriteLine("You entered invalid number for hight . Please enter your hight again : ");
                hight = Convert.ToDouble(Console.ReadLine());
            }
            var bmi = Math.Round(weight / Math.Pow(hight, 2), 2) ;
            string status = null ;
            if(bmi <= 18.4){
                status = "Underweight";
            }
            else if (bmi <= 24.9){
                status = "Normal";
            }
            else if (bmi <= 39.9){
                status = "overweight";
            }
            else if(bmi >= 40){
                status = "Obese";
            }

            Console.WriteLine($"your BMI is {bmi} and you are {status}");  
            
        }
    }
}