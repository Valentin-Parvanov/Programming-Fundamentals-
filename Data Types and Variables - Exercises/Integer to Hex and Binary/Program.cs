using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number =int.Parse(Console.ReadLine());
            string hexdicimal = Convert.ToString(number,16).ToUpper();
            string finallyNumber = Convert.ToString(number,2);

            Console.WriteLine(hexdicimal);
            Console.WriteLine(finallyNumber);
        }
    }
}
