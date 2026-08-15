using System;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            status(getRanks(), getSuits());
        }

        static int[] getRanks()
        {
            int[] x = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Please enter a number from 1 to 13 :");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }
            return x;
        }

        static char[] getSuits()
        {
            char[] x = new char[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Please enter a char from a to d :");
                x[i] = Convert.ToChar(Console.ReadLine());
            }
            return x;
        }

        static void status(int[] x, char[] y)
        {
            string status = " ";
            for (int i = 0; i < 2; i++)
            {
                switch (i)
                {
                    case 0:
                        int count = 1;
                        for (int j = 1; j < 5; j++)
                        {
                            if (y[0] == y[j]) count++;
                        }
                        if (count == 5) status = "Flush";
                        break;
                    case 1:
                        count = 0;
                        for (int k = 0; k < 4; k++)
                        {
                            count = 1;
                            for (int w = k + 1; w < 5; w++)
                            {
                                if (x[k] == x[w]) count++;
                            }
                            if (count >= 3)
                            {
                                status = "three of kind";
                                break;
                            }
                            else if (count == 2) status = "Pair";
                        }

                        if (count == 1 && status != "Pair")
                            status = "Any single card";
                        break;
                }
                if (status == "Flush") break;
            }
            Console.WriteLine("status is : " + status);
        }
    }
}
