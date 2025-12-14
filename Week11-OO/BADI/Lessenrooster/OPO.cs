using System;

namespace Lessenrooster
{
    public class Docent
    {
        public string Naam{get; set;}

        public double BMI {get; set;}

        public Docent(string naam, double bmi)
        {
            Naam = naam;
            BMI = bmi;
        }
    }

    public enum DagenVanDeWeek
    {
        Maandag = 0,
        Dinsdag = 1,
        Woensdag = 2,
        Donderdag = 3,
        Vrijdag = 4,
        Zaterdag = 5,
        Zondag = 6
    }

    public class Tijd
    {
        int UU;
        int MM;

        public int BerekenUren
        {
            get
            {
                return UU;
            }
            set
            {
                if ((value >= 0) && (value <= 23))
                {
                    UU = value;
                }
            }
        }
        public int BerekenMinuten
        {
            get
            {
                return MM;
            }
            set
            {
                if ((value >= 0) && (value <= 59))
                {
                    MM = value;
                }
            }
        }

        public Tijd (int uu, int mm)
        {
            BerekenUren = uu;
            BerekenMinuten = mm;
        }

        public Tijd(Tijd startuur, int voegtoe)
        {
            BerekenUren = startuur.BerekenUren + voegtoe;
            BerekenMinuten = startuur.BerekenMinuten;
        }

        public override string ToString()
        {
            return $"{BerekenUren}:{BerekenMinuten}";
        }

    }

    public class Student: Docent
    {
        public OPO[] Lessen {get; set;}

        public Student(string naam, double bmi, OPO[] lessen): base(naam, bmi)
        {
            Lessen = lessen;
        }

        public override string ToString()
        {
            string s = $"Student: {Naam} met bmi {BMI}";
            foreach(var les in Lessen)
            {
                s += $"{les}\n";
            }
            return s;
        }
    }


    public class OPO
    {
        //vaknummer startuur duur naam D lokaal
        public string Vaknummer { get; set; }
        public Tijd Startuur {get; set;}
        public int Duur {get; set;}
        public string Naam {get; set;}
        public Docent D {get; set;}
        public string Lokaal {get; set;}
        public DagenVanDeWeek Dag {get; set;}

        public OPO (string naam, string vaknummer, string lokaal, Tijd startuur, int duur, DagenVanDeWeek dag, Docent d)
        {
            Naam = naam;
            Vaknummer = vaknummer;
            Lokaal = lokaal;
            Startuur = startuur;
            Duur = duur;
            Dag = dag;
            D = d;
        }

        public override string ToString()
        {
            string s = "";
            s += $"\nVak: {Naam}";
            s += $"\n-{D.Naam} met BMI van {D.BMI}";
            s += $"\n-{Lokaal}";
            s += $"\n-{Dag}";
            
            Tijd Einduur = new Tijd(Startuur, Duur);
            s += $"\n-{Startuur}-{Einduur}\n";
            return s;
        }

    }
}