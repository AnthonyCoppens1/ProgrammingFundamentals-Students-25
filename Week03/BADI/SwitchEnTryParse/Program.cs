using System;

namespace SwitchEnTryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weekdag = (int)DateTime.Now.DayOfWeek;

            DateTime datum = DateTime.Now;
            Console.WriteLine(datum);
            DateTime gisteren = new DateTime(2025, 09, 30);
            Console.WriteLine(gisteren.Year);

            DateTime geboortedatum = new DateTime(1995, 07, 31);
        }
    }
}