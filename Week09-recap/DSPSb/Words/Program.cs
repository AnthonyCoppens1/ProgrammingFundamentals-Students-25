using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(Console.ReadLine()).ToLower();
            string chars = Console.ReadLine();
            int length = Convert.ToInt32(Console.ReadLine());

            Regex rx = new Regex(@"\b[A-z]{" + Convert.ToString(length) + @"}\b");
            MatchCollection matches = rx.Matches(text);

            string[] AllWords = new string[matches.Count];
            string[] goodWords = new string[matches.Count];

            for (int i = 0; i < matches.Count; i++)
            {
                AllWords[i] = Convert.ToString(matches[i]);
            }

            bool flag = true;
            int index = 0;
            for (int i = 0; i < AllWords.Length; i++)
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    if (!AllWords[i].Contains(chars[j]))
                    {
                        flag = false;
                    }
                }
                if (flag == true && !goodWords.Contains(AllWords[i]))
                {
                    goodWords[index] = AllWords[i];
                    index++;
                }
                flag = true;
            }
            for (int i = 0; i < index; i++)
            {
                Console.Write(goodWords[i] + " ");
            }


        }
    }
}