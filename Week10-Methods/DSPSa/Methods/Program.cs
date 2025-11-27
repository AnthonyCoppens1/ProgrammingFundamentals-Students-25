using System;

namespace Methods
{
    internal class Program
    {
        static int[] numbers = {4, 5, 1, 0, 2, 3};
        static void Main(string[] args)
        {
            HelloWorld();
            Console.WriteLine(Add(5, 10));
            int answer = Add(201, 99);
            Console.WriteLine(answer + 15);

            Print();
            Array.Sort(numbers);
            Print();
            Array.Reverse(numbers);
            Print();
        }

        static void Print()
        {
            foreach (var item in numbers)
            {
                Console.Write(item + "**");
            }
            Console.WriteLine();
        }



        //VOID METHOD DOESNT RETURN ANYTHING, JUST EXECUTES SOMETHING
        /*static void Add(int number1, int number2)
        {
            int answer = number1 + number2;
            Console.WriteLine(answer);
        }*/

        //ANYTHING BUT A VOID METHOD
        static int Add(int number1, int number2)
        {
            int answer = number1 + number2;
            Console.WriteLine(numbers[2]);
            return answer;

        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

    }
}