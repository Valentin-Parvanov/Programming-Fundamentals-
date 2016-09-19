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
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n));

        }

        private static bool IsPrime(long n)
        {
            long N = (long)Math.Sqrt(n);
            if(n<=1)
            {
                return false;
            }
            else if(n>2)
            {
                for (long i = 2; i <= N; i++)
                {
                    if(n%i==0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
