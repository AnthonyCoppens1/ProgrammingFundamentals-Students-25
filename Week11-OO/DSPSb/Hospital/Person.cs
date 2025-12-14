using System;

namespace HospitalDatabase
{
    public class Other: Person
    {
        public string Role { get; set; }


        public Other(string name, DateOnly bd, string phone, string city, char gender, 
        string role): base(name, bd, phone, city, gender)
        {
            Role = role;
        }
        public override string ToString()
        {
            return $"Other: {Name} who is {Age} years old\n- Currently here as a : {Role}\n";
        }
    }

    public class Nurse: Person
    {
        public string Department { get; set; }
        public bool Working { get; set; }


        public Nurse(string name, DateOnly bd, string phone, string city, char gender, 
        string department, bool working): base(name, bd, phone, city, gender)
        {
            Department = department;
            Working = working;
        }
        public override string ToString()
        {
            return $"NURSE: {Name} who is {Age} years old\n- DEP: {Department} / Currently working? {Working}\n";
        }
    }

    public class Doctor: Person
    {
        public string Department { get; set; }
        public string Specialization { get; set; }


        public Doctor(string name, DateOnly bd, string phone, string city, char gender, 
        string department, string specialization): base(name, bd, phone, city, gender)
        {
            Department = department;
            Specialization = specialization;
        }
        public override string ToString()
        {
            return $"DOCTOR: {Name} who is {Age} years old\n- DEP: {Department} / SPEC: {Specialization}\n";
        }
    }

    public class Patient: Person
    {
        public string Condition { get; set; }
        public string Treatment { get; set; }
        public int Pain { get; set; }

        public Patient(string name, DateOnly bd, string phone, string city, char gender, 
        string condition, string treatment, int pain): base(name, bd, phone, city, gender)
        {
            Condition = condition;
            Treatment = treatment;
            Pain = pain;
        }
        public override string ToString()
        {
            return $"PATIENT: {Name} who is {Age} years old\n- PROBLEM: {Condition} / TREATMENT: {Treatment}\n"
            + $"- And has a pain scale of {Pain}\n";
        }
    }


    public class Person
    {
        public string Name { get; set; }
        public int Age { get {return CalcAge();} }
        private DateOnly BD { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public char Gender { get; set; }

        public Person()
        {
            Name = "John Doe";
            BD = new DateOnly(1990, 02, 20);
            Phone = "+32476859031";
            City = "Mechelen";
            Gender = 'M';
        }

        public Person(string name, DateOnly bd, string phone, string city, char gender)
        {
            Name = name; BD = bd; Phone = phone; City = city; Gender = gender;
        }

        public override string ToString()
        {
            return $"Name: {Name} -Age: {Age} - City: {City}";
        }

        private int CalcAge()
        {
            DateTime now = DateTime.Now;
            int age = now.Year - BD.Year;
            if (now.Year < BD.Year + age)
            {
                age--;
            }
            return age;
        }
    }
}