using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            
            int max = GetMax(firstNumber, secondNumber,thirdNumber);

            Console.WriteLine(max);
        }

        static int GetMax(int number1, int number2,int number3)
        {
            int x = Math.Max(number1, Math.Max(number2, number3));
            return x;
        }

    }
}

