using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables and how to declare
            //2 ways, either declare first, then initialize
            //other way would be to do it all in one go

            //declaring first
            int x, y;

            //initialization
            x = 5;
            y = 8;

            //doing it in one go
            string name = "Michelle";
            Console.WriteLine(name);

            byte B = 254; //max is 255, anything higher or anything lower than 0 wont work
            short S = 23487;
            int number = 89;
            long L = 23487642387; //2 to the power of 63 max --> around 5 quintillion

            Console.WriteLine($"x = {x} and y = {y}");
            //++ or -- --> addition or subtraction
            Console.WriteLine($"x = " + x);
            x++; //x = x + 1
            Console.WriteLine($"x = " + x);
            --x; //x = x - 1
            Console.WriteLine($"x = " + x);

            //POSTFIX AND PREFIX NOT ON A DIFFERENT LINE
            Console.WriteLine($"x++ results in: {x++}");
            Console.WriteLine($"++x results in: {++x}");
            Console.WriteLine($"x-- results in: {x--}");
            Console.WriteLine($"--x results in: {--x}");

            //arithmetic operators
            // + - * / %
            //x = 5 / y = 8
            Console.WriteLine($"x + y = {x + y}");//13
            Console.WriteLine($"x - y = {x - y}");//-3
            Console.WriteLine($"x * y = {x * y}");//40
            Console.WriteLine($"x / y = {x / y}");//0
            Console.WriteLine($"x % y = {x % y}");//5

            //more examples on modulo --> %
            Console.WriteLine($"10 % 9 = {10 % 9}");
            Console.WriteLine($"10 % 8 = {10 % 8}");
            Console.WriteLine($"10 % 7 = {10 % 7}");
            Console.WriteLine($"10 % 6 = {10 % 6}");
            Console.WriteLine($"10 % 5 = {10 % 5}");
            Console.WriteLine($"10 % 4 = {10 % 4}");

            //alternative way of finding the remainder
            int result = 10 / 4;
            Console.WriteLine($"10 % 4 = {10 - (result * 4)}");

            Console.WriteLine($"Starting point of x: {x}");
            //compound operators
            x += 10; // --> x = x + 4
            Console.WriteLine(x);
            x -= 7; // --> x = x - 7
            Console.WriteLine(x);
            x *= 4; // --> x = x * 4
            Console.WriteLine(x);
            x /= 3; // --> x = x / 3
            Console.WriteLine(x);
            x %= 5; // --> x = x % 5
            Console.WriteLine(x);


            //compound operators for strings
            name = "Anthony";
            name += "Coppens"; //careful --> output is AnthonyCoppens
            Console.WriteLine(name);

            name = "Coppens " + name; //adding in front
            Console.WriteLine(name);

            //comparisson operators
            // < > <= >= == !=
            x = 3;
            y = 5;
            double z = 3.0;
            Console.WriteLine(x < y);
            Console.WriteLine(x > y);
            Console.WriteLine(x <= y);
            Console.WriteLine(x >= y);
            Console.WriteLine(x != y);
            Console.WriteLine(z == x); //check double vs int of same number

            //WEIRD STUFF, OOOOH SPOOKY
            Console.WriteLine(5 + 5); //10
            Console.WriteLine('5' + 5); //58
            Console.WriteLine('a' + 5); //a = 97 --> 102 --> ascii value of a + 5
            Console.WriteLine('a' + 'b' + 'c'); //294

            Console.WriteLine("5" + 5); //55
            Console.WriteLine("" + 5 + 5); //55 --> any piece of text in calc = all text
            Console.WriteLine("" + (5 + 5)); //10


            //characters in a string
            name = "Elizabeth";
            char firstChar = name[0];
            Console.WriteLine($"First char of {name} is {firstChar}");

            //another way of first char
            firstChar = name.ElementAt(0);
            Console.WriteLine($"First char of {name} is {firstChar}");

            char lastChar = name[8]; //BAD CODING, you don't always know the length
            lastChar = name[name.Length - 1]; //length = 9, indexes go 0 - 8, you have to subtract 1
            Console.WriteLine($"Last char of {name} is {lastChar}");

            lastChar = name[-1];
            Console.WriteLine(lastChar);
        }
    }
}