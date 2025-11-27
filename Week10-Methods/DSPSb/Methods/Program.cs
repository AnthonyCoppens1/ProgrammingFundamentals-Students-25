using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int returnedSum = Addition(n1, n2) + 30;
            Console.WriteLine(returnedSum);

            int[] numbers = {3, 2, 5, 1, 8, 9, 7, 4, 6};
            Print(numbers);
            Array.Sort(numbers);
            Print(numbers);
            Array.Reverse(numbers);
            Print(numbers);
        }

        static void Print(int[] numbers)
        {
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }


        static int Addition(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        /*static void Addition(int number1, int number2)
        {
            int sum = number1 + number2;
            Console.WriteLine(sum);
        }*/

        /*static void Addition()
        {
            int sum = 2 + 5;
            Console.WriteLine(sum);
        }*/

        static void HelloWorld()
        {
            Console.WriteLine("Mambo Jambo");
        }




    }
}