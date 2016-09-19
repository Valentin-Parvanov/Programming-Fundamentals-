using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split('|').ToList();
            var result = new List<string>();
            numbers.Reverse();
            
            foreach (var num in numbers)
            {
                var removeSpace = num.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToList();
                result.AddRange(removeSpace);
            }

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
