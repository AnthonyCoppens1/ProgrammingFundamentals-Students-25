using System;

namespace ifStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OPTION 1 - if-statements --> singular conditions
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 50)
            {
                Console.WriteLine("Wow, what a small number");
            }
            else if (number == 50)
            {
                Console.WriteLine("Your number appears to be exactly 50");
            }
            else
            {
                Console.WriteLine("An amazingly big number");
            }

            //always need else before any other if-statement
            if (number < 100)
            {
                Console.WriteLine("SMALL");
            }
            else if (number > 0) //make sure to add else in front of here, otherwise both will be printed
            //if the number is between 0 and 100
            {
                Console.WriteLine("BIG");
            }


            //option 2 --> if inside of else
            if (number < 50)
            {
                Console.WriteLine("smaller than 50");
            }
            else
            {
                if (number == 50)
                {
                    Console.WriteLine("equal to 50");
                }
                else
                {
                    Console.WriteLine("Greater than 50");
                }
            }


            //option 3 --> combine if-statements
            if (number != 50)
            {
                if (number < 50)
                {
                    Console.WriteLine("super small");
                }
                else
                {
                    Console.WriteLine("super big");
                }
            }
            else
            {
                Console.WriteLine("exactly 50");
            }


            //option 4 - if in else #2
            if (number > 50)
            {
                Console.WriteLine("greater");
            }
            else
            {
                if (number < 50)
                {
                    Console.WriteLine("smaller");
                }
                else
                {
                    Console.WriteLine("equal");
                }
            }


            //Combining checks or conditions
            //check if number is (not) equal to 50
            //option 1
            if (number == 50)
            {
                Console.WriteLine("equal to 50");
            }
            else
            {
                Console.WriteLine("NOT equal to 50");
            }

            //option 2 --> || or
            if (number < 50 || number > 50)
            {
                Console.WriteLine("number is NOT equal to 50");
            }
            else
            {
                Console.WriteLine("number is equal to 50");
            }


            //option 3
            if (number != 50)
            {
                Console.WriteLine("NOT");
            }
            else
            {
                Console.WriteLine("YES");
            }

            //option 4 --> not operator --> !
            if (!(number == 50))
            {
                Console.WriteLine("not equal to 50");
            }
            else
            {
                Console.WriteLine("equal to 50");
            }

            //option 5 --> combinations of multiple conditions that need to be met! --> &&
            if ((number < 51) && (number > 49))
            {
                Console.WriteLine("number is 50");
            }
            else
            {
                Console.WriteLine("number is NOT 50");
            }

            //option 6 --> option 5 but more limited --> all have to be true
            if (!(number < 50) && !(number > 50) && (number == 50))
            {
                Console.WriteLine("number is 50");
            }
            else
            {
                Console.WriteLine("number is NOT 50");
            }

            //option 7 --> bool
            bool condition = number != 50;
            if (condition) //condition == true --> execute
            {
                Console.WriteLine("Number is not equal to 50");
            }
            else
            {
                Console.WriteLine("Number is equal to 50");
            }

            //option 8 --> bool with !
            if (!condition)
            {
                Console.WriteLine("50");
            }
            else
            {
                Console.WriteLine("NOT 50");
            }
        }
    }
}