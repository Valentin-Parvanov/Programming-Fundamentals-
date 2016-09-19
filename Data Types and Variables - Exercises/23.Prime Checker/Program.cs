using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));

              
            }

        static long Fib(  int n)
        {
           if(n <2)
            {
                return 1;
            }

            return  Fib(n - 1) + Fib(n - 2);
        }
    }
    }

