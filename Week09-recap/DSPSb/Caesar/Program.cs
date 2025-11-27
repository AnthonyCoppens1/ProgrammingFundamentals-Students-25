using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;

namespace Caesar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //first input --> number, second input --> word, 3rd is response

            int number = Convert.ToInt32(Console.ReadLine());
            string word = Console.ReadLine().ToUpper();

            if (word.All(Char.IsLetter))
            {
                char[] split = word.ToCharArray();
                int simpleNumber = number % 26;

                //couple options of filling a list or array with akphabet

                char[] alphabet = new char[26];
                for (int i = 65; i < 90; i++)
                {
                    alphabet[i] = (char)i;
                }

                /*string alpha = "azertyuiopqsdfghjklmwxcvbn";
                char[] alphabet = alpha.ToCharArray();
                Array.Sort(alphabet);

                List<char> alphabet = new List<char>();
                for (int i = 65; i < 90; i++)
                {
                    alphabet.Add((char)i);
                }*/

                for (int i = 0; i < split.Length; i++) //going through sugar or word letter by letter
                {   
                    char currentLetter = split[i];
                    int index = 0;

                    for (int j = 0; j < alphabet.Length; j++)
                    {
                        if (currentLetter == alphabet[j])
                        {
                            index = j;
                            split[i] = alphabet[(index + simpleNumber + 26) % 26];
                        }
                    }

                }

            }
        }
    }
}