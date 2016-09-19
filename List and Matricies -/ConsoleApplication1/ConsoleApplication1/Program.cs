using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var newNumber = new List<int>();

            foreach (var positiveNumbers in number)
            {
                if(positiveNumbers>=0)
                {
                    newNumber.Add(positiveNumbers);
                }
            }
           newNumber.Reverse();

            if(newNumber.Count>0)
            {
                Console.WriteLine(string.Join(" " , newNumber));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
