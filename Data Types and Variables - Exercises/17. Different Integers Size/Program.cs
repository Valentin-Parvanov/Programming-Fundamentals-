using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            var inptut = Console.ReadLine();
            StringBuilder output = new StringBuilder();

            sbyte testSbyte;
            if(sbyte.TryParse(inptut,out testSbyte))
            {
                output.AppendLine("* sbyte");
            }

            byte testByte;
            if(byte.TryParse(inptut,out testByte))
            {
                output.AppendLine("* byte");
            }

            short testShort;
            if(short.TryParse(inptut,out testShort))
            {
                output.AppendLine("* short");
            }

            ushort testUshort;
            if(ushort.TryParse(inptut,out testUshort))
            {
                output.AppendLine("* ushort");
            }

            int testInt;
            if(int.TryParse(inptut,out testInt))
            {
                output.AppendLine("* int");
            }

            uint testUint;
            if(uint.TryParse(inptut,out testUint))
            {
                output.AppendLine("* uint");
            }

            long testLong;
            if (long.TryParse(inptut, out testLong))
            {
                output.AppendLine("* long");
            }

            if (output.Length > 0)
            {

                output.Insert(0, inptut + " can fit in:\n");
                Console.WriteLine(output.ToString());
            }
            else
            {
                Console.WriteLine("{0} can't fit in any type", inptut);
            }
        }
    }
}
