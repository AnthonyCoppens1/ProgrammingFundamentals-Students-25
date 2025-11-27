using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            //first check on variables
            //string variants
            //variable without value = declaration
            string name;

            //adding a value to it = initialization
            name = "Jean";
            name = "Divine"; //changing a value doesn't require
            //you to declare it again

            Console.WriteLine(name);


            //NUMBER BASED VARIABLES AND DATATYPES
            int x, y; //declare multiple variables
            x = 5; y = 8;

            Console.WriteLine(x);

            short shortNumber = 1298;
            byte B = 18;
            //B = 260; --> too big for the datatype, max is 255, min is 0

            Console.WriteLine(B + shortNumber);

            double doubleNumber = 40.78625484901836;
            //float floatNumber = doubleNumber; --> won't work and too big to store in a float

            float floatNumber = 56.8907f; //requires the f behind it, standard decimal is double

            Console.WriteLine(doubleNumber);
            Console.WriteLine(floatNumber);

            Console.WriteLine($"x = {x} and y = {y}");
            //Console.WriteLine("x = {0} and y = {1}", x, y); another option 

            // ++ and -- --> addition and subtraction
            Console.WriteLine("x = " + x);
            x++; //x = x + 1
            Console.WriteLine("x = " + x);
            --x;
            Console.WriteLine("x = " + x);

            //postfix and prefix
            Console.WriteLine($"x++ results in {x++}");
            Console.WriteLine($"++x results in {++x}");
            Console.WriteLine($"x-- results in {x--}");
            Console.WriteLine($"--x results in {--x}");


            //OPERATIONS
            //arithmetic operations
            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} - {y} = {x - y}");
            Console.WriteLine($"{x} * {y} = {x * y}");
            x = 11;
            y = 2;
            Console.WriteLine($"{x} / {y} = {x / y}");
            //5.5 is the real answer, however we see 5
            //division between 2 whole numbers is a whole division // INTEGER DIVISION
            //if you want to see the actual result, AT LEAST one needs to be a double

            //modulo
            Console.WriteLine($"10  % 9 = {10 % 9}"); //10 / 9 = 1 --> remainder = 1
            Console.WriteLine($"10  % 8 = {10 % 8}"); //10 / 8 = 1 --> remainder = 2
            Console.WriteLine($"10  % 7 = {10 % 7}"); //10 / 7 = 1 --> remainder = 3
            Console.WriteLine($"10  % 6 = {10 % 6}"); //10 / 6 = 1 --> remainder = 4
            Console.WriteLine($"10  % 5 = {10 % 5}"); //10 / 5 = 2 --> remainder = 0
            Console.WriteLine($"10  % 4 = {10 % 4}"); //10 / 4 = 2 --> remainder = 2

            //Console.WriteLine($"10 % 0 = {10 % 0}"); --> doesn't work, cannot divide by 0

            //modulo without the % operator
            int resultAfterDivision = 10 / 3;
            Console.WriteLine($"10 % 3 = {10 - (resultAfterDivision * 3)}");

            //COMPOUND OPERATORS
            Console.WriteLine($"x starts at {x}");
            x += 10; // x = x + 10;
            Console.WriteLine($"x += 10 --> {x}"); //21

            x -= 7; // x = x - 7;
            Console.WriteLine($"x -= 7 --> {x}"); //14

            x *= 4; // x = x * 4;
            Console.WriteLine($"x *= 4 --> {x}"); //56

            x /= 7; // x = x / 7;
            Console.WriteLine($"x /= 7 --> {x}"); //8

            x %= 5; // x = x % 5;
            Console.WriteLine($"x %= 5 --> {x}"); //3


            //compound operators for strings and such
            name = "Harry";
            name += " Potter"; //careful --> no space and is added at the back
            Console.WriteLine(name);

            name = "Potter" + name;
            Console.WriteLine(name);


            //COMPARISSON OPERATORS
            Console.WriteLine($"x = {x} and y = {y}");
            Console.WriteLine($"x < y --> {x < y}"); //FALSE
            Console.WriteLine($"x > y --> {x > y}"); //TRUE
            Console.WriteLine($"x <= y --> {x <= y}"); //FALSE
            Console.WriteLine($"x >= y --> {x >= y}"); //TRUE
            Console.WriteLine($"x == y --> {x == y}"); //FALSE
            Console.WriteLine($"x != y --> {x != y}"); //TRUE

            Console.WriteLine($""" 'a' == "a" """);
            //comparing strings and characters does not work
            //however chars and int does work, because every char has a decimal value
            Console.WriteLine($"{'a' == 97}");

            //weird things...
            Console.WriteLine(5 + 5); //10
            Console.WriteLine("5" + 5); //55
            Console.WriteLine('5' + 5); //58 (ascii value of 5 is 53) 
            // --> if we do 'a' + 5 --> 102
            Console.WriteLine('5' + '5'); //106 --> add up both decimal values
            Console.WriteLine("" + 5 + 5); //55
            Console.WriteLine("" + (5 + 5)); //10
            Console.WriteLine('a' + 'b' + 'c');

            //characters in strings
            name = "Elizabeth";
            char firstChar = name[0];
            Console.WriteLine($"First char of {name} is {firstChar}");

            char letter = name[2]; //i

            firstChar = name.ElementAt(0);
            Console.WriteLine($"First char of {name} is {firstChar}");

            char lastChar = name[8]; //rarily used because you dont always know length 
            // -1 DOES NOT WORK
            Console.WriteLine($"last char of {name} is {lastChar}");
            lastChar = name[name.Length - 1];
            Console.WriteLine($"last char of {name} is {lastChar}");
















        }
    }
}