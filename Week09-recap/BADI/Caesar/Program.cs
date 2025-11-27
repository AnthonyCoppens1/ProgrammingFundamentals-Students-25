using System;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Caesar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getal = Convert.ToInt32(Console.ReadLine());
            string woord = Console.ReadLine().ToUpper();
            bool controle = woord.All(Char.IsLetter);

            if (controle)
            {
                char[] woordGesplitst = woord.ToCharArray();
                char[] alfabet = new char[26];
                int teller = 65;

                for (int i = 0; i < alfabet.Length; i++)
                {
                    alfabet[i] = (char)teller; //zorgt dat je gaat van getal (ascii) gaat naar letter
                    teller++;
                }

                int correct = getal % 26;
                int index = 0;
                for (int i = 0; i < woordGesplitst.Length; i++)
                {
                    char huidigCharacter = woordGesplitst[i];
                    for (int j = 0; j < alfabet.Length; j++)
                    {
                        if (huidigCharacter == alfabet[j])
                        {
                            index = Array.IndexOf(alfabet, huidigCharacter);
                            
                            //de universele optie van woordGesplitst[i] = alfabet[(j + correct + 26) % 26]; zou ook
                            //altijd werken voor alles
                            //optie 1 --> getal tussen 0 en 26
                            if ((index + correct) >= 0 && (index + correct) < 26)
                            {
                                woordGesplitst[i] = alfabet[j + correct];
                            }
                            //optie 2 --> getal hoger dan 26
                            else if ((index + correct) >= 26)
                            {
                                woordGesplitst[i] = alfabet[correct];
                            }
                            //optie 3 --> getal kleiner dan 0
                            else if ((index + correct) < 0)
                            {
                                woordGesplitst[i] = alfabet[(j + correct + 26) % 26];
                            }
                        }
                    }
                }

                foreach (char c in woordGesplitst)
                {
                    Console.Write(c);
                }

                /*string geenidee = "azertyuiopqsdfghjklmwxcvbn";
                char[] iets = geenidee.ToCharArray();
                Array.Sort(iets);

                List<char> ch = new List<char>();
                for (int i = 65; i <= 90; i++)
                {
                    ch.Add((char)i);
                }*/
            }
            else
            {
                Console.WriteLine("crazy input");
            }



        }
    }
}