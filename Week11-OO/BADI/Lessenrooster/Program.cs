using System;
using System.Security.Cryptography;

namespace Lessenrooster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Docent Collin = new Docent("Collin Van der Vorst", 20);
            Docent Anthony = new Docent("Anthony Coppens", 26.8);
            Docent Elke = new Docent("Elke Boonen", 22);
            Docent Andy = new Docent("Andy", 25);
            Docent Inge = new Docent("Inge van den Bossche", 22);
            Docent Ben = new Docent("Ben Van Erck", 20);

            OPO Databases = new OPO("Databases", "YB0612", "C2.11", new Tijd(13,45), 3, DagenVanDeWeek.Donderdag
            , Collin);
            OPO PF = new OPO("Programming Fundamentals", "YP1408", "C2.11", new Tijd(10,45), 2, DagenVanDeWeek.Vrijdag,Anthony);
            OPO Scripting = new OPO("Scripting", "YB1401", "C2.24", new Tijd(16,00), 3, DagenVanDeWeek.Dinsdag, Elke);
            OPO PO = new OPO("PO", "YB0007", "C0.07", new Tijd(06, 00), 2, DagenVanDeWeek.Maandag, Andy);
            OPO DigitalSkills = new OPO("Digital Skills", "YP0982", "C3.14", new Tijd(9,30), 2, DagenVanDeWeek.Woensdag, Inge);
            OPO ComputingFundamentals = new OPO("Computing Fundamentals", "YB2671", "C3.11", new Tijd(13, 45), 2, DagenVanDeWeek.Vrijdag, Ben);

            Student AndyStudent = new Student("Andy", 25, new OPO[] {Databases, PF, Scripting, PO, DigitalSkills, ComputingFundamentals});

            Console.WriteLine(AndyStudent);
            /*for(int i = 0; i <= (int)DagenVanDeWeek.Zondag; i++)
            {
                
            }*/
        }
    }
}