/* 
*/
using System;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a roman number : ");
            string romanNum = Console.ReadLine();
            romanNum = romanNum.ToUpper();
            int result = 0 ;
            for(int i = 0 ; i < romanNum.Length ; i++)
            {
                char num2 = i != romanNum.Length - 1 ? romanNum[i+1] : ' ';
                switch(romanNum[i])
                {
                    case 'I' : 
                        if(num2 == 'V')
                        {
                            result += 4 ;
                            i++ ;
                        }
                        else if(num2 == 'X')
                        {
                            result += 9 ;
                            i++ ;
                        }
                        else 
                        {
                            result++ ;
                        }
                        break;
                    case 'V' :
                        result += 5 ;
                        break ;
                    case 'X' :
                        if(num2 == 'L')
                        {
                            result += 40 ;
                            i++ ;
                        }
                        else if(num2 == 'C')
                        {
                            result += 90 ;
                            i++ ;
                        }
                        else 
                        {
                            result += 10 ;
                        }
                        break;
                    case 'L' :
                        result += 50 ;
                        break ;
                    case 'C' :
                        if(num2 == 'D')
                        {
                            result += 400 ;
                            i++ ;
                        }
                        else if(num2 == 'M')
                        {
                            result += 900 ;
                            i++ ;
                        }
                        else 
                        {
                            result += 100 ;
                        }
                        break;
                    case 'D' :
                        result += 500 ;
                        break ;
                    case 'M' :
                        result += 1000 ;
                        break ;
                }
            }
            Console.WriteLine(romanNum + " = " + result);
            
        }
    }
}
