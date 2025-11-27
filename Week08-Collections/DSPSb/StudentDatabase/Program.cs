using System;
using System.Collections.Generic;

namespace StudentDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a student database that allows you to add elements of a person / student
            //adjust/update elements or lastly be able to delete them!

            string action = Console.ReadLine();

            List<string> name = new List<string>();
            List<string> courses = new List<string>();
            List<DateTime> birthday = new List<DateTime>();
            List<long> phonenumber = new List<long>();

            while (action != "END")
            {
                if (action == "INSERT")
                {
                    Console.Write("Name: "); name.Add(Console.ReadLine());
                    Console.Write("Courses: "); courses.Add(Console.ReadLine());
                    Console.Write("Birthday: "); birthday.Add(Convert.ToDateTime(Console.ReadLine()));
                    Console.Write("Phonenumber: "); phonenumber.Add(Convert.ToInt64(Console.ReadLine()));

                    Console.WriteLine($"Your student number is: {name.Count}");
                }
                else if (action == "UPDATE")
                {
                    Console.Write("Which student number do you want to access? ");
                    int studentnr = Convert.ToInt32(Console.ReadLine());

                    Console.Write($"What element do you want to change? ('OKAY' to stop): ");
                    string updateaction = Console.ReadLine();

                    while (updateaction != "OKAY")
                    {
                        if (updateaction == "NAME")
                        {
                            Console.Write("Name: "); name[studentnr - 1] = Console.ReadLine();
                        }
                        else if (updateaction == "COURSES")
                        {
                            Console.Write("Courses: "); courses[studentnr - 1] = Console.ReadLine();
                        }
                        else if (updateaction == "BIRTHDAY")
                        {
                            Console.Write("Birthday: "); birthday[studentnr - 1] = Convert.ToDateTime(Console.ReadLine());
                        }
                        else if (updateaction == "PHONE")
                        {
                            Console.Write("Phone: "); phonenumber[studentnr - 1] = Convert.ToInt64(Console.ReadLine());
                        }
                        updateaction = Console.ReadLine();
                    }
                }
                else if (action == "DELETE")
                {
                    Console.Write("Which student number do you want to DELETE? ");
                    int studentnr = Convert.ToInt32(Console.ReadLine());

                    name[studentnr - 1] = "";
                    courses[studentnr - 1] = "";
                    birthday[studentnr - 1] = new DateTime();
                    phonenumber[studentnr - 1] = 0;

                }
                else
                {
                    Console.WriteLine("Try again, this is not a correct command!");
                }
                action = Console.ReadLine();
            }

            Console.WriteLine($"Session has ended, this is your student database!");
            for (int i = 0; i < name.Count; i++)
            {
                Console.WriteLine($"Name: {name[i]} / Courses: {courses[i]} / " +
                $"Birthday: {DateOnly.FromDateTime(birthday[i])} / Phonenumber: {phonenumber[i]}");
            }
        }
    }
}