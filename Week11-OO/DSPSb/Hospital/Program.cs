using System;

namespace HospitalDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor Ondrej = new Doctor("Ondrej", new DateOnly(2004, 09, 28), "+32469696940", "Zilina", 'M', 
            "Otonolingonarology", "Otonolingonarologist");
            Other Dries = new Other("Dries", new DateOnly(2006, 07, 07), "+32478978997", "Keerbergen", 'M', "Visitor");
            Patient Anthony = new Patient("Anthony", new DateOnly(1995, 07, 31), "+32476859862", "Hoboken", 'M', 
            "Broken and missing arm", "Impossible to help, maybe a kiss on it", 9);
            Nurse Maxim = new Nurse("Maxim", new DateOnly(2008, 04, 26), "+32890654321", "Donetsk", 'M', 
            "Cardiology", true);
            Patient Rafaw = new Patient("Rafaw", new DateOnly(2004, 01, 28), "+32786543214", "Zamosc", 
            'M', "Braindamage from Arduino", "More Arduino", 5);
            Patient Alex = new Patient("Alex", new DateOnly(2007, 03, 27), "+32675676767", "Chisinau", 'M', "Broken toe", "Reattaching Frankstein style", 2);
            Nurse Andy = new Nurse("Andy", new DateOnly(1997, 06, 10), "+32789899056", "Taipei", 'M', "Old crazy people department and co", false);

            List<Person> people = new List<Person>{Ondrej, Dries, Anthony, Maxim, Rafaw, Alex, Andy};
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}