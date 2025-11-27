using System;

namespace Duplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MmmmmmMeeeeEcccchhhhhhHHHHHhhhheeeeeelllllllLeeeeNNNn
            //  MmeEchHlLNn

            string word = Console.ReadLine();
            string unique = "";

            for (int i = 0; i < word.Length; i++)
            {
                if (!unique.Contains(word[i]))
                {
                    unique += word[i];
                }
            }

            Console.WriteLine(unique);
        }
    }
}