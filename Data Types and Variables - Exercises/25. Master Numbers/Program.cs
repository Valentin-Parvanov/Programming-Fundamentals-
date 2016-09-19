using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.Master_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (IsPalindrom(i) && ContainsEvenDigit(i) && SumOfDigits(i))
                {
                    Console.WriteLine(i);
                }
            }

       
                }
            }
            return IsPalindrom;
        }
        static bool SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num = num / 10;

                if (sum % 7 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }

            static bool ContainsEvenDigit(int num)
        {
                string number = num.ToString();
                bool containEven = false;

                for (int i = 0; i < number.Length; i++)
                {
                    int digits = number[i] - 48;
                    if (digits % 2 == 0)
                    {
                        containEven = true;
                        break;

                    }
                }

                if (containEven)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
        }
    }
}

