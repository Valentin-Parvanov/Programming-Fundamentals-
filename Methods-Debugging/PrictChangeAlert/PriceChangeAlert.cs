using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class PriceChangeAlert
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal significanceThreshold = decimal.Parse(Console.ReadLine());
            decimal lastPrice = decimal.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                decimal numbers = decimal.Parse(Console.ReadLine());
                decimal theDifferenceOfNumbers = Proc(lastPrice, numbers);
                bool isSignificantDifference = isDif(theDifferenceOfNumbers, significanceThreshold);

                string message = GetMessage(numbers, lastPrice, theDifferenceOfNumbers, isSignificantDifference);
                Console.WriteLine(message);
                lastPrice = numbers;
            }

        }

    private static string GetMessage(decimal numbers, decimal lastPrice, decimal theDifferenceOfNumbers, bool isSignificantDifference)
    {
        string result = "";
        if (theDifferenceOfNumbers == 0)
        {
            result = string.Format("NO CHANGE: {0}", numbers);
        }
        else if (!isSignificantDifference)
        {
            result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, numbers, theDifferenceOfNumbers * 100);
        }
        else if (isSignificantDifference && (theDifferenceOfNumbers > 0))
        {
            result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, numbers, theDifferenceOfNumbers * 100);
        }
        else if (isSignificantDifference && (theDifferenceOfNumbers < 0))
        { 
            result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, numbers, theDifferenceOfNumbers * 100);
        }  
            return result;
        }
        private static bool isDif(decimal theDifferenceOfNumbers, decimal significanceThreshold)
        {
            if (Math.Abs(theDifferenceOfNumbers) >= significanceThreshold)
            {
                return true;
            }
            return false;
        }

        private static decimal Proc(decimal lastPrice, decimal numbers)
        {
            decimal difference = (numbers - lastPrice) / lastPrice;
            return difference;
        }
    }



    

