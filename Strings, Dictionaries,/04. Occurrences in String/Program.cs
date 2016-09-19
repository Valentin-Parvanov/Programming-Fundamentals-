using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Occurrences_in_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var tex = Console.ReadLine().ToLower();
            var w = Console.ReadLine().ToLower();
            var counter = 0;
            var starPos = 0;
            while(true)
            {
                var pos = tex.IndexOf(w,starPos);

                if (pos == -1)
                {
                    break;
                }
                else
                {
                    counter++;
                    starPos = pos + 1;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
