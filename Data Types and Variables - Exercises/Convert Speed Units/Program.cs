using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int time = (hours * 3600 + minutes * 60 + seconds);

            float metersPersecond = (float)meters / time;
            float kilometersPerHour = ((float)meters / 1000) /((float)time/3600);
            float milesPerHour = ((float)meters / 1609) / ((float)time / 3600);
            Console.WriteLine(metersPersecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);



        }
       
    }
}
