using System;

namespace Extra_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 0 to 999 : ");
            int x = Convert.ToInt32(Console.ReadLine());

            while (x > 999 || x < 0)
            {
                Console
                    .WriteLine("you entered wrong number . Enter a number between 0 to 999 again : ");
                x = Convert.ToInt32(Console.ReadLine());
            }

            string letter = null;
            int yekan = x % 10;
            int dahgan = ((x - yekan) % 100) / 10;
            int sadgan = ((x - dahgan * 10 - yekan) % 1000) / 100;

            switch (sadgan)
            {
                case 0:
                    letter = null;
                    break;
                case 1:
                    letter = "Sad";
                    break;
                case 2:
                    letter = "Devist";
                    break;
                case 3:
                    letter = "Sisad";
                    break;
                case 4:
                    letter = "Chaharsad";
                    break;
                case 5:
                    letter = "Pansad";
                    break;
                case 6:
                    letter = "Sheshsad";
                    break;
                case 7:
                    letter = "Haftsad";
                    break;
                case 8:
                    letter = "Hashtsad";
                    break;
                case 9:
                    letter = "Nohsad";
                    break;
            }

            if ((yekan != 0 || dahgan != 0) && sadgan != 0)
            {
                letter += "_o_";
            }

            switch (dahgan)
            {
                case 0:
                    letter += null;
                    break;
                case 1:
                    switch (yekan)
                    {
                        case 0:
                            letter += "Dah";
                            break;
                        case 1:
                            letter += "Yazdah";
                            break;
                        case 2:
                            letter += "Davazdah";
                            break;
                        case 3:
                            letter += "Sizdah";
                            break;
                        case 4:
                            letter += "Chahardah";
                            break;
                        case 5:
                            letter += "Panzdah";
                            break;
                        case 6:
                            letter += "Shanzdah";
                            break;
                        case 7:
                            letter += "Hefdah";
                            break;
                        case 8:
                            letter += "Hejdah";
                            break;
                        case 9:
                            letter += "Noozdah";
                            break;
                    }
                    break;
                case 2:
                    letter += "Bist";
                    break;
                case 3:
                    letter += "Si";
                    break;
                case 4:
                    letter += "Chehel";
                    break;
                case 5:
                    letter += "Panjah";
                    break;
                case 6:
                    letter += "Shast";
                    break;
                case 7:
                    letter += "Haftad";
                    break;
                case 8:
                    letter += "Hashtad";
                    break;
                case 9:
                    letter += "Navad";
                    break;
            }

            if (yekan != 0 && dahgan != 0 && dahgan != 1)
            {
                letter += "_o_";
            }

            if (dahgan != 1)
            {
                switch (yekan)
                {
                    case 0:
                        if (sadgan == 0 && dahgan == 0)
                        {
                            letter = "Sefr";
                        }
                        break;
                    case 1:
                        letter += "Yek";
                        break;
                    case 2:
                        letter += "Do";
                        break;
                    case 3:
                        letter += "Se";
                        break;
                    case 4:
                        letter += "Chahar";
                        break;
                    case 5:
                        letter += "Panj";
                        break;
                    case 6:
                        letter += "Shesh";
                        break;
                    case 7:
                        letter += "Haft";
                        break;
                    case 8:
                        letter += "Hasht";
                        break;
                    case 9:
                        letter += "Noh";
                        break;
                }
            }

            Console.WriteLine($"Your number is \" {letter} \"");
        }
    }
}
