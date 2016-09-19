using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings__Dictionaries_
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("str[{0}] -> '{1}'",i,str[i]);
            }
        }
    }
}
