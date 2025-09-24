using System;

namespace InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Console.WriteLine();
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            //CONVERSIONS
            Console.Write("Enter a number: ");
            string answer = Console.ReadLine();
            int number = Convert.ToInt32(answer);
            Console.WriteLine(number + 10);

            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number * number);

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(number > 10 && number <= 100); //&& --> AND --> both cases need to be true
            int result = number / 10;
            Console.WriteLine(result >= 7 || result <= 10);// || --> OR --> at least 1 of the cases needs to be true


            //INPUT CONVERSION
            Console.Write("Enter a byte: ");
            byte b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine(b);

            Console.Write("Enter a short: ");
            short s = Convert.ToInt16(Console.ReadLine()); //16 bits, 2 bytes = length of short
            Console.WriteLine(s);

            Console.Write("Enter a long: ");
            long l = Convert.ToInt64(Console.ReadLine()); //64 bits, 8 bytes = max length of long
            Console.WriteLine(l);

            //byte = byte / int16 = short / int32 = int / int64 = long

            Console.WriteLine("Enter a character: ");
            char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(c);


            //implicit and explicit conversion
            Console.WriteLine(l); //implicit conversion --> pc changes it to string itself
            Console.WriteLine(l.ToString()); //explicit conversion! --> force it yourself

            Console.WriteLine(c);
            Console.WriteLine((int)c);
            //casting a datatype into another, but beware of problems.


            //int nameToNumber = (int)name; --> impossible
            //int stringNumber = (int)"89"; --> never works
            int stringNumber = Convert.ToInt32("89");
            Console.WriteLine(stringNumber + 5);

            number = (int)78.9023482348;
            double DD = (double)78;

            double X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(X + 10);


            //DATING AGE CALCULATOR
            Console.Write("Enter your OWN age: "); //no lying!
            int age = Convert.ToInt32(Console.ReadLine());
            int datingAge = age / 2 + 7;
            Console.WriteLine($"You are allowed to date people of the age: {datingAge}" +
            $"! BUT BEWARE OF ILLEGAL TERITORY");



        }
    }
}