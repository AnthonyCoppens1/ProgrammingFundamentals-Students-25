using System;

namespace FilesSchrijven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter stroom = File.CreateText("file.txt");
            stroom.WriteLine("Dit is een tekstbestand");
            stroom.WriteLine("Met meer tekst");
            stroom.Write("En nog veel meer");
            stroom.Write("Zonder dat je het door hebt!!!");

            stroom.Close();

            //file aanmaken op locatie
            stroom = File.CreateText(@"C:\test\file.txt");
            stroom.WriteLine("Beetje tekst op mijn c-schijf");
            stroom.Close();


            //bestand op bureaublad
            string bureaublad = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string pad = Path.Combine(bureaublad, "file.txt");
            //@ + C:\Users\antho\OneDrive\Bureaublad + \file.txt --> actie die Path.Combine maakt
            stroom = File.CreateText(pad);
            stroom.WriteLine("TEKST OP BUREAUBLAD");
            stroom.Close();


            //controle of een bestand bestaat
            if (File.Exists(pad))
            {
                stroom = File.AppendText(pad);
                stroom.WriteLine("Extra info op dit bestand");
                stroom.Close();
            }


            //files deleten van een bepaalde folder
            string muziek = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            pad = Path.Combine(muziek, "file.txt");

            stroom = File.CreateText(pad);
            stroom.WriteLine("MUZIEK TESTJE");
            stroom.Close();

            if (File.Exists(pad))
            {
                File.Delete(pad);
            }

            


        }
    }
}