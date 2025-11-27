using System;

namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sentence = Console.ReadLine().Split(' ');
            for (int i = 0; i < sentence.Length; i++)
            {
                string reverse = "";
                string word = sentence[i];

                for (int j = word.Length-1; j >= 0; j--)
                {
                    reverse += word[j];
                }
                sentence[i] = reverse;
            }

            foreach (var item in sentence)
            {
                Console.Write(item + " ");
            }
        }
    }
}