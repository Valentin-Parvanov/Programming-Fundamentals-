using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvensbyOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sumEvens = GetSumOfEvenDigits(Math.Abs(number));
            int sumOdds = GetSumOfOddDigits(Math.Abs(number));
            Console.WriteLine(sumOdds * sumEvens);

        }

        private static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            while(number > 0)
            {
                int lastDigit = number % 10;
                if(lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }

        private static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            while(number>0)
            {
              int lastGidits = number % 10;
                
                    if(lastGidits % 2 != 0)
                    {
                        sum += lastGidits;
                    }
                    number /= 10;
                }
                    return sum;
            }
        }

       
}
    

