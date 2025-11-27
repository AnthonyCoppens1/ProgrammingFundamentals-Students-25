using System;
using System.IO;

namespace Recap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = File.ReadAllText("tekst.txt");
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
            
            int lijn = Convert.ToInt32(Console.ReadLine());
            string[] heleFile = File.ReadAllLines("tekst.txt");
            
            StreamReader sr = File.OpenText("tekst.txt");
            
        }
    }
}