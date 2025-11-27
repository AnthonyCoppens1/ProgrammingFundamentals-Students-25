using System;
using System.Runtime;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //2
            //sugar
            //OUTPUT: UWICT
            try
            {
                int nr = Convert.ToInt32(Console.ReadLine());
                string str = Console.ReadLine().ToUpper();

                bool alphaCheck = str.All(Char.IsLetter);
                if (alphaCheck)
                {
                    char[] ch = str.ToCharArray();
                    int[] numbers = new int[ch.Length];
                    char[] alpha = new char[26];
                    int x = 65; //ascii of uppercase A

                    for (int i = 0; i < alpha.Length; i++)
                    {
                        char c = (char)x;
                        alpha[i] = c;
                        x++;
                    }

                    int r = nr % 26; //always going back to a number between 0 and 26
                    for (int i = 0; i < ch.Length; i++)
                    {
                        char character = ch[i];
                        for (int j = 0; j < alpha.Length; j++)
                        {
                            if (character == alpha[j])
                            {
                                int index = Array.IndexOf(alpha, character);
                                if ((index + r) >= 0 && (index + r) < 26)
                                {
                                    ch[i] = alpha[j + r];
                                    Console.Write(ch[i]);
                                }
                                else if ((index + r) < 0)
                                {
                                    ch[i] = alpha[(j + r + 26) % 26];
                                    Console.Write(ch[i]);
                                }
                                else if ((index + r) >= 26)
                                {
                                    ch[i] = alpha[r];
                                    Console.Write(ch[i]);
                                }
                            }
                        }
                    }

                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong format");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index of out range");
            }
            catch (Exception)
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}