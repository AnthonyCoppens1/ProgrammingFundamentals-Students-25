using System;

namespace InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            //reading input --> standard always a string
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            Console.Write("Enter a number: ");
            string number = Console.ReadLine();
            Console.WriteLine(number + 5);

            int N = Convert.ToInt32(number);
            Console.WriteLine(N + 5);

            //input conversion
            Console.Write("Enter a byte: ");
            string answer = Console.ReadLine();
            byte b = Convert.ToByte(answer);
            Console.WriteLine(b);

            Console.Write("Enter a short: ");
            short s = Convert.ToInt16(Console.ReadLine());

            //implicit conversion
            Console.WriteLine(s);
            //explicit conversion
            Console.WriteLine(s.ToString());

            string word = "Check" + s;
            Console.WriteLine(word);

            Console.Write("Enter a character: ");
            char c = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(c);
            Console.WriteLine((int)c); //ascii value

            //int nameToNumber = (int)name; //never works!!!
            //int stringNumber = (int)"89"; //never works!!!

            //N has int as datatype
            N = (int)78.8989;
            Console.WriteLine(N);

            double doubleNumber = (double)78;
            Console.WriteLine(doubleNumber);

            double n1 = Convert.ToDouble(Console.ReadLine());
            double n2 = Convert.ToDouble(Console.ReadLine());
            double n3 = Convert.ToDouble(Console.ReadLine());

            double sum = n1 + n2 + n3;
            Console.WriteLine(sum);
            //careful with . and , for decimal split, system has to be in ENG

            Console.WriteLine(Math.Floor(5.8));

            Console.WriteLine();
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            int valid = age / 2 + 7;
            Console.WriteLine($"Your age is {age} and you are allowed" +
            $"to date people of the age {valid}!");
            Console.WriteLine("PLEASE BE CAREFUL!");


            


        }
    }
}