using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_Letters_in_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine().ToLower();
            var count = new int[str.Max() + 1];

            for (int i = 0; i < str.Length; i++)
            {
                count[str[i]]++;
            }

            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 0)
                {
                    Console.WriteLine($"{(char)i} -> {count[i]}");
                }
            }
            
        }
    }
}
