using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Matrix_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var r =int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            var matrix = new char[r][];
            var letter = 'A';

            for (int row= 0; row < r; row++)
            {
                matrix[row] = new char[c];
                for (int col = 0; col < c; col++)
                {
                    matrix[row][col] = letter;
                    letter++;
                }
            }
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }
    }
}
