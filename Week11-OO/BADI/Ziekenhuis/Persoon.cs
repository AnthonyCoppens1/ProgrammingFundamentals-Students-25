using System;

namespace Ziekenhuis
{
    public enum Departement
    {
        MentaalOnstabieleBejaarden, 
        FanRoom,
        FysiekGehandicapteBejaarden,
        Pediatrie,
        Gynaecologie,
        Spoed,
        Oncologie,
        Psychiatrie,
        Spreadsheets
    }


    public class Dokter: Persoon
    {
        public string Diploma { get; set; }
        public string Specialiteit { get; set; }

        public Dokter(DateOnly geboortedatum, string bloedtype, string naam, string adres, string diploma, string specialiteit): base(geboortedatum, bloedtype, naam, adres)
        {
            Diploma = diploma;
            Specialiteit = specialiteit;
        }
        public override string ToString()
        {
            return $"Dokter: {Naam}, specialisatie {Specialiteit}, heeft destijds {Diploma} gestudeerd\n";
        }
    }

    public class Patiënt: Persoon
    {
        public string Reden { get; set; }
        public string Allergie { get; set; }
        public string Oplossing { get; set; }
        public int Urgentie { get; set; } //schaal van 1 - 10
        public string Medicatie { get; set; }

        public Patiënt(DateOnly geboortedatum, string bloedtype, string naam, string adres, string reden, string allergie, string oplossing, int urgentie, string medicatie): base(geboortedatum, bloedtype, naam, adres)
        {
            Reden = reden;
            Allergie = allergie;
            Oplossing = oplossing;
            Urgentie = urgentie;
            Medicatie = medicatie;
        }

        public override string ToString()
        {
            return $"PATIËNT: {Naam} - Leeftijd: {Leeftijd}\n- Reden: {Reden} - Oplossing: {Oplossing}\n- Pas op voor: {Allergie}\n";
        }
    }

    public class Verpleegster: Persoon
    {
        public Departement Afdeling { get; set; }

        public Verpleegster(DateOnly geboortedatum, string bloedtype, string naam, string adres, Departement afdeling): base(geboortedatum, bloedtype, naam, adres)
        {
            Afdeling = afdeling;
        }

        public override string ToString()
        {
            return $"Verpleegster: {Naam}, werkt in {Afdeling}, is {Leeftijd} jaar oud en woont in {Adres}\n";
        }
    }

    public class Persoon
    {
        //prop + tab voor shortcut nieuwe property
        private DateOnly Geboortedatum { get; set; }
        public string Bloedtype { get; set; }
        public string Naam { get; set; }
        public string Adres { get; set; }
        public int Leeftijd { get {return BerekenLeeftijd();} }

        //ctor + tab voor constructor
        public Persoon()
        {
            Geboortedatum = new DateOnly(2000, 01, 01);
            Bloedtype = "O-";
            Naam = "John Doe";
            Adres = "Paddengatstraat 33, 2810 Willebroek";
        }

        public Persoon(DateOnly geboortedatum, string bloedtype, string naam, string adres)
        {
            Geboortedatum = geboortedatum;
            Bloedtype = bloedtype;
            Naam = naam;
            Adres = adres;
        }

        /*public void Print()
        {
            Console.WriteLine($"{Naam} - {Adres}");
        }*/

        public override string ToString()
        {
            return $"{Naam} - {Adres}";
        }

        private int BerekenLeeftijd()
        {
            DateTime nu = DateTime.Now;
            int leeftijd = nu.Year - Geboortedatum.Year;
            if (nu.Year < Geboortedatum.Year + leeftijd)
            {
                leeftijd--;
            }
            return leeftijd;
        }

    }
}