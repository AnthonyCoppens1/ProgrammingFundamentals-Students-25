using System;
using System.Collections.Generic;
using System.Security;

namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DICTIONARIES!
            Dictionary<int, string> strings = new Dictionary<int, string>();
            strings.Add(8, "eight");
            strings.Add(3, "three");
            strings.Add(2, "fifteen");
            strings.Add(66, "test");
            strings.Add(17, "Anthony");

            Console.WriteLine(strings[8]); //works only with the key, index 0 will cause an error! UNLESS YOU ADD KEY 0

            //print keys
            foreach (int key in strings.Keys)
            {
                Console.WriteLine(key);
            }

            //print values
            foreach (string value in strings.Values)
            {
                Console.WriteLine(value);
            }

            //printing pairs
            foreach (var pair in strings)
            {
                Console.WriteLine($"{pair.Key} OR value: {pair.Value}");
            }
            Console.WriteLine();

            //another way of printing pairs
            for (int i = 0; i < strings.Count; i++)
            {
                Console.WriteLine(strings.ElementAt(i)); //add .Value or .Key to access a specific element!
            }


            strings[2] = "two";
            strings[88] = "Coppens";

            foreach (var pair in strings)
            {
                Console.WriteLine(pair.Value);
            }
            Console.WriteLine();

            //removing elements!
            strings.Remove(88); //removes everything of a key

            foreach (var pair in strings)
            {
                Console.WriteLine(pair.Value);
            }
            Console.WriteLine();


            //removing but saving
            strings.Remove(17, out string name);
            Console.WriteLine(name);

            foreach (var pair in strings)
            {
                Console.WriteLine(pair.Value);
            }
            Console.WriteLine();

            if (strings.ContainsKey(8)) // .ContainsValue = to find the value in a dictionary 
            //beware, keys are unique, but values can be the same for multiple keys
            {
                Console.WriteLine(strings[8]);
            }


            Dictionary<string, double> doubles = new Dictionary<string, double> { { "a", 3.2 },
            { "c", 8.1 }, { "bdg", 10.1 } };

            foreach (var pair in doubles)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }


            //isogram example
            //an isogram is a word or a sentence in which every letter only appears max 1 time

            string word = Console.ReadLine();
            //WORD IS BLESSING
            Dictionary<char, int> counter = new Dictionary<char, int>();

            for (int i = 0; i < word.Length; i++)
            {
                if (counter.ContainsKey(word[i]))
                {
                    counter[word[i]]++;
                }
                else
                {
                    counter[word[i]] = 1;
                }
            }


            string s = "";
            foreach (var pair in counter)
            {
                if (pair.Value > 1)
                {
                    s += pair.Key;
                }
            }

            if (s == "")
            {
                Console.WriteLine("ISOGRAM");
            }
            else
            {
                Console.WriteLine(s);
            }





        }
    }
}