using System;

namespace InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Console.Write("Geef een naam: ");
            string naam = Console.ReadLine();

            //omzetten
            Console.Write("Geef een getal: ");
            int getal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(getal + 5);

            Console.Write("Geef een byte: ");
            byte b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine(b);

            Console.Write("Geef een short: ");
            short s = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(s);

            //byte --> .ToByte // short --> 16 bit // int --> 32 bit // long --> 64 bit

            //impliciete omzetting of expliciete omzetting
            Console.WriteLine(s); //impliciet
            Console.WriteLine(s.ToString()); //expliciet

            Console.Write("Geen een character: ");
            string antwoord = Console.ReadLine();
            char c = Convert.ToChar(antwoord);
            Console.WriteLine(c);
            Console.WriteLine((int)c); //ascii waarde

            //int naamNaarGetal = (int)naam; --> werkt nooit
            //int stringGetal = (int)"89";  --> werkt nooit
            getal = (int)78.234234;
            double doubleGetal = (double)78;

            Console.WriteLine(doubleGetal);

            double D = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(D + 3.2);


            //MET WIE MAG IK DATING REGEL
            //PAS WEL OP VOOR GEVAAR!!!
            int leeftijd = Convert.ToInt32(Console.ReadLine());
            int okeOmTeDaten = leeftijd / 2 + 7;

            Console.WriteLine($"Beste, je bent {leeftijd} jaar oud" +
            $" en je mag mensen daten van {okeOmTeDaten}! PAS WEL OP VOOR ILLEGALE PRAKTIJKEN!");



        }
    }
}