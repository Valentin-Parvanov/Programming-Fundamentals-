using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Debugging
{
    public class BlankReceipt
    {
        public static void Main(string[] args)
        {
            PrintReceipHeader();
            PrintReceipBody();
            PrintReceipFooter();

        }

        private static void PrintReceipFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine('\u00A9'+" SoftUni");
        }

        private static void PrintReceipBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        private static void PrintReceipHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
    }
}

