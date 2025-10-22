using System;
using System.IO;
using System.Runtime.InteropServices;

namespace HarryPotter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*We willen een file doorlezen tot op een bepaald punt. Alles van de gelezen file tot dat punt
            moet worden overgeschreven naar een nieuw bestand. Lijn: 25 --> Harry-25.txt
            */

            //WHILE
            int teller = 0;
            int lijnen = Convert.ToInt32(Console.ReadLine());
            StreamReader read = File.OpenText(@"HarryPotter.txt"); //@ toevoegen als je bv spaties in de naam hebt
            StreamWriter schrijf = File.CreateText($"Harry-{lijnen}.txt");

            while (teller < lijnen)
            {
                schrijf.WriteLine(teller + " " + read.ReadLine());
                teller++;
            }

            schrijf.Close();
            read.Close();


            //FOREACH
            teller = 0;
            lijnen = Convert.ToInt32(Console.ReadLine());
            schrijf = File.CreateText($"Harry-{lijnen}-FOREACH.txt");

            foreach (string lijn in File.ReadLines("HarryPotter.txt"))
            {
                if (teller < lijnen)
                {
                    schrijf.WriteLine(teller + " " + lijn);
                    teller++;
                }
                else
                {
                    break;
                }
            }
            schrijf.Close();



            //COMBO MET CSV --> inlezen en ermee leren werkenµ

            foreach (var item in File.ReadLines("Characters.csv"))
            {
                if (item.Contains("Gryffindor"))
                {
                    int eerstePuntKomma = item.IndexOf(';'); //zoek naar de index van eerste ; in item per lijn
                    string substring = item.Substring(eerstePuntKomma + 1);
                    int tweedePuntKomma = substring.IndexOf(';'); //eerste ; in de substring die start bij naam

                    Console.WriteLine(substring.Substring(0, tweedePuntKomma));
                }
            }




        }
    }
}