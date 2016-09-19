using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']' },
                                                                  StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();
            foreach (var word in words)
            {
                var isAllLowerCase = 0;
                var isAllUpperrCase = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLower(word[i]))
                    {
                        isAllUpperrCase++;
                    }
                    else if (char.IsUpper(word[i]))
                    {
                        isAllLowerCase++;
                    }
                }

                       if (isAllLowerCase == word.Length)
                        {
                            lowerCase.Add(word);
                        }
                        else if (isAllUpperrCase == word.Length)
                        {
                            upperCase.Add(word);
                        }
                        else
                        {
                            mixedCase.Add(word);
                        }
                    }


                    Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
                    Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
                    Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));

                }
            }
        }
    

