using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = arr.Length / 4;

            var rowLeft = arr.Take(k).Reverse();
            var rowRigh = arr.Reverse().Take(k);

            int[] row1 = rowLeft.Concat(rowRigh).ToArray();
            int[] row2 = arr.Skip(k).Take(2 * k).ToArray();

            var sumArr = row1.Select((x, index) => x + row2[index]);
            Console.WriteLine(string.Join(" ",sumArr));
        }
    }
}
