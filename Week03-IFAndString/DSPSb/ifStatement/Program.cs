using System;

namespace ifStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 50)
            {
                Console.WriteLine("Number is smaller than 50");
            }
            else if (number > 50)
            {
                Console.WriteLine("Number is bigger than 50");
            }
            else
            {
                Console.WriteLine("Number is exactly 50");
            }


            //if my number is 50, it will print both smaller as well as bigger, because
            //seperate if-statement are met! every IF is on it's own. 
            /*if (number < 60)
            {
                Console.WriteLine("Smaller");
            }
            if (number > 40)
            {
                Console.WriteLine("Bigger");
            }*/


            //option 2 --> nesting 
            if (number < 50)
            {
                Console.WriteLine("SMALL");
            }
            else
            {
                if (number > 50)
                {
                    Console.WriteLine("BIG");
                }
                else
                {
                    Console.WriteLine("50");
                }
            }

            //option 3 --> nesting but if-statement inside your if
            if (number != 50)
            {
                if (number > 50)
                {
                    Console.WriteLine("GREAT");
                }
                else
                {
                    Console.WriteLine("LITTLE");
                }
            }
            else
            {
                Console.WriteLine("5 and a 0");
            }

            //combining conditions in one statement
            //option 1
            if (number == 50)
            {
                Console.WriteLine("Yes this is 50");
            }
            else
            {
                Console.WriteLine("Definitely not 50");
            }

            //option 2
            if (number > 50 || number < 50)
            {
                Console.WriteLine("not equal to 50");
            }
            else
            {
                Console.WriteLine("equal to 50");
            }

            //option 3
            if (number != 50)
            {
                Console.WriteLine("different");
            }
            else
            {
                Console.WriteLine("equal");
            }

            //option 4
            if (!(number == 50))
            {
                Console.WriteLine("number is not equal to 50");
            }
            else
            {
                Console.WriteLine("Number is equal to 50");
            }

            //option 5
            if (!(number < 50) && !(number > 50))
            {
                Console.WriteLine("number is equal 50");
            }
            else
            {
                Console.WriteLine("number is not equal to 50");
            }

            //option 6
            //True or False --> boolean --> bool 
            bool condition = number != 50; //if my chosen number is 50, False is saved here
            if (condition)
            {
                Console.WriteLine("different from 50");
            }
            else
            {
                Console.WriteLine("50");
            }

            //option 7
            if (!condition)
            {
                Console.WriteLine("number 50");
            }
            else
            {
                Console.WriteLine("NOT 50");
            }


        }
    }
}