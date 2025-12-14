using System;

namespace Ziekenhuis
{
    public class Ziekenhuis
    {
        public List<Persoon> Personen { get; private set; }
        public string Naam { get; set; }
        public string Adres { get; set; }

        public Ziekenhuis(string naam, string adres)
        {
            Naam = naam;
            Adres = adres;
            Personen = new List<Persoon>();
        }

        public Ziekenhuis(string naam, string adres, List<Persoon> personen)
        {
            Naam = naam;
            Adres = adres;
            Personen = personen;
        }

        public void VoegToe(Persoon p)
        {
            Personen.Add(p);
        }

        public List<Patiënt> WieZijnMijnPatiënten()
        {
            List<Patiënt> patiënten = new List<Patiënt>();
            foreach (Persoon p in Personen)
            {
                if (p is Patiënt)
                {
                    patiënten.Add((Patiënt)p);
                }
            }

            return patiënten;
        }

        public List<Persoon> WieZijnMijnPersoneelsleden()
        {
            List<Persoon> personeel = new List<Persoon>();
            foreach (Persoon p in Personen)
            {
                if (p is Dokter || p is Verpleegster)
                {
                    personeel.Add(p);
                }
            }

            return personeel;
        }

        public override string ToString()
        {
            string s = $"ZIEKENHUIS: {Naam}\n";
            foreach (Persoon p in Personen)
            {
                s += $"** {p}\n";
            }
            return s;
        }

    }
}