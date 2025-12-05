using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string question = Console.ReadLine();
            switch (question)
            {
                case "Prime":
                    int n = Convert.ToInt32(Console.ReadLine());
                    string numbers = PrimeNumbers(n);
                    Console.WriteLine(numbers);
                break;

                case "Factorial":
                    int x = Convert.ToInt32(Console.ReadLine());
                    int factorial = Factorial(x);
                    Console.WriteLine(factorial);
                break;

                default:
                    Console.WriteLine("crazy input");
                break;
            }
        }

        static int Factorial(int x)
        {
            int factorial = 1;
            for (int i = 1; i <= x; i++)
            {
                factorial *= i;
            }

            return factorial;
        }



        static string PrimeNumbers(int n)
        {
            //we get 27, we need to know which are primenumbers between 2 and 27 (or given number)
            //2 3 5 7 11 13 17 19 23
            string primes = "";
            int counter = 0;
            for (int i = 2; i < n; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }
                }

                if (counter == 1)
                {
                    primes += i + " ";
                    //primes += Convert.ToString(i); --> also works
                }
                counter = 0;
            }

            return primes;
        }

    }
}