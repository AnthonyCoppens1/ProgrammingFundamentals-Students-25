using System;

namespace Huisdieren
{
    public abstract class Huisdier
    {
        public string Naam { get; set; }

        public Huisdier(string naam)
        {
            Naam = naam;
        }

        public abstract string Maakgeluid();

        public override string ToString()
        {
            return $"{Naam} en ik ben een {GetType().Name}";
        }

    }

    public class Kat: Huisdier
    {

        public Kat(string naam): base(naam)
        {
        }

        public override string Maakgeluid()
        {
            return "Miauw";
        }

        //public string Miauw() => "Miauw"; --> ook perfect mogelijk als methode
    }

    public class Hond: Huisdier
    {

        public Hond(string naam): base(naam)
        {
        }

        public override string Maakgeluid()
        {
            return "woef";
        }
    }

    public class Walvis: Huisdier
    {
        public Walvis(string naam): base(naam)
        {
            Naam = naam;
        }

        public override string Maakgeluid() => "HUUUUUAAAAAWHHHHH";
    }


    public class Persoon
    {
        //prop + tab voor 1 property aan te maken
        public string Voornaam { get; set; }   
        public string Achternaam { get; set; }
        public DateOnly Geboortedatum { get; set; }
        public List<Huisdier> Dieren {get; set;} = new();
        

        //ctor + tab voor constructor aan te maken
        public Persoon(string voornaam, string achternaam, DateOnly geboortedatum)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
            Geboortedatum = geboortedatum;
        }

        public override string ToString()
        {
            return $"{Voornaam} {Achternaam}";
        }


    }
}