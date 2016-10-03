using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignofIntegerNumber
{
   public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintSight(n);
         }

       static void PrintSight(int number)
        {
            if(number>0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if(number<0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
