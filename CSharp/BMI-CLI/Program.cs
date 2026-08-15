using System;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            double heigth, weigth;
            switch (args.Length)
            {
                case 0:
                    invalid();
                    break;
                case 1:
                    if (args[0] == "bmi")
                        helps();
                    else
                        invalid();
                    break;
                case 2:
                    switch (args[1])
                    {
                        case "--helps":
                            helps();
                            break;
                        case "--version":
                            Console.WriteLine("Curent version is 1.0 ");
                            break;
                        case "--heigth":
                            Console
                                .WriteLine("Entered information  is not complete");
                            break;
                        case "--weigth":
                            Console
                                .WriteLine("Entered information  is not complete");
                            break;
                        default:
                            invalid();
                            break;
                    }
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Entered information  is not complete");
                    break;
                case 5:
                    switch (args[1])
                    {
                        case "--heigth":
                            heigth = Convert.ToDouble(args[2]);
                            if (args[3] == "--weigth")
                            {
                                weigth = Convert.ToDouble(args[4]);
                                bmiStatus (weigth, heigth);
                            }
                            else
                            {
                                invalid();
                            }
                            break;
                        case "--weigth":
                            weigth = Convert.ToDouble(args[2]);
                            if (args[3] == "--heigth")
                            {
                                heigth = Convert.ToDouble(args[4]);
                                bmiStatus (weigth, heigth);
                            }
                            else
                            {
                                invalid();
                            }
                            break;
                        default:
                            invalid();
                            break;
                    }
                    break;
                default:
                    invalid();
                    break;
            }
        }

        static void helps()
        {
            Console.WriteLine("Use these switches to run program");
            Console.WriteLine("--heigth         Your heigth (meter)");
            Console.WriteLine("--weigth         Your weigth (kilograms)");
            Console.WriteLine("--version        Show curent version");
            Console.WriteLine("--helps          Show command list");
        }

        static void invalid()
        {
            Console.WriteLine("\nInvalid command :( ");
            Console.WriteLine("use --helps switch to show help\n");
        }

        static void bmiStatus(double weigth, double heigth)
        {
            var bmi = Math.Round(weigth / Math.Pow(heigth, 2), 2);
            string status = null;
            if (bmi <= 18.4)
            {
                status = "Underweight";
            }
            else if (bmi <= 24.9)
            {
                status = "Normal";
            }
            else if (bmi < 40)
            {
                status = "overweight";
            }
            else if (bmi >= 40)
            {
                status = "Obese";
            }

            Console.WriteLine($"Your BMI is {bmi} and your status is {status}");
        }
    }
}
