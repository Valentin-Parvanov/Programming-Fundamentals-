using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger fact = 1;
        
            for (int i = n; i >1 ; i--)
            {
                fact = BigInteger.Multiply(i, fact);
            }
            Console.WriteLine(fact);
        }
    }
}
