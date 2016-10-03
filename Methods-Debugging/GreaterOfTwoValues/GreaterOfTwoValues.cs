using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfTwoValues
{
    public class GreaterOfTwoValues
    {
        public static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                char result = GetMax(firstChar, secondChar);
                Console.WriteLine(result);
            }
            else if (type == "int")
            {
                int firstInt = int.Parse(Console.ReadLine());
                int secondInt = int.Parse(Console.ReadLine());
                int result = GetMax(firstInt, secondInt);
                Console.WriteLine(result);
            }
            else if (type == "string")
            {
                string firstString = Console.ReadLine();
                string secondstring = Console.ReadLine();
                string result = GetMax(firstString, secondstring);
                Console.WriteLine(result);

            }
        }

        private static string GetMax(string firstString, string secondstring)
        {
            if (firstString.CompareTo(secondstring) > 0)
            {
                return firstString;
            }
            return secondstring;
        }

        private static int GetMax(int firstInt, int secondInt)
        {
            if(firstInt.CompareTo(secondInt)>=0)
            {
                return firstInt;
            }
            return secondInt;
        }

        private static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar.CompareTo(secondChar) >=0)
            {
                return firstChar;
            }
            return secondChar;
        }
    }
}
