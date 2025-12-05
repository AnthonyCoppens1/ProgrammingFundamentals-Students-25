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


            string[] fruits = {"banana", "apple", "kiwi", "pear", "dragonfruit"};
            Print(fruits);

            double[] doubles = {3.1, 2.8, 17.5, 12.31};
            Print(doubles);

            bool[] bools = {true, true, true, false, false, true, true, false, true, false};
            Print(bools);
            Array.Sort(bools);
            Print(bools);


            //a method that automatically fills an array
            int size = Convert.ToInt32(Console.ReadLine());
            // printing immediatly after return --> Print(filledUp(size));
            int[] intjes = filledUp(size);
            Print(intjes);


            if (!Int32.TryParse(Console.ReadLine(), out size))
            {
                intjes = filledUp();
                Print(intjes);
            }
            else
            {
                intjes = filledUp(size);
                Print(intjes);
            }

            (intjes, int[] sorted) = filledAndSorted(size);
            Print(sorted);


            //different example of returning multiple values with a method

            (int Adt, int sub, int multi, int div) = MASSIVE(15, 20);
            Console.WriteLine(Adt + div);


            //premium discount calculator
            double PRICE = 1.80;
            Console.WriteLine($"Price before school discount {PRICE}€");
            discount(ref PRICE);
            Console.WriteLine($"Price AFTER school discount {PRICE}€");


            //another example --> IF ALREADY A REFERENCE TYPE, NO NEED TO ADD ref. 
            string[] store = {"banana"};
            Console.WriteLine($"This tiny store has the following objects: {store[0]}");
            fruitMultiplier(store);
            Console.WriteLine($"Now the store has: {store[0]}");


            //out in the new context --> old context was TryParse
            calc(5, 10, out int adding, out int subbing);
            Console.WriteLine($"added: {adding} and subbed: {subbing}");


            //more on optional parameters
            ADD(12, z:100, y: 15);

            //params --> allows more a type of raw input to be pushed as a specific type of array.
            //2,2,1,4,3,6,8,1
            loopdiloop(2,2,1,4,3,6,8,1);

        }

        static void loopdiloop(params int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "-");
            }
            Console.WriteLine();
        }

        static void ADD(int x = 10, int y = 20, int z = 50)
        {
            Console.WriteLine(x + y + z);
        }

        static void calc(int x, int y, out int adding, out int subbing)
        {
            adding = x + y;
            subbing = x - y;
        }



        //careful if already a ref type, it doesn't need ref and pushes the location.
        static void fruitMultiplier(string[] store)
        {
            store[0] += "s";
        }



        static void discount(ref double PRICE)
        {
            PRICE -= 0.20;
        }


        static (int, int, int, int) MASSIVE(int first, int second)
        {
            int Adt = first + second;
            int sub = first - second;
            int multi = first * second;
            int div = first / second;
            
            return(Adt, sub, multi, div);
        }

        static (int[], int[]) filledAndSorted(int size = 3)
        {
            Random rd = new Random();
            int[] intjes = new int[size];

            for (int i = 0; i < intjes.Length; i++)
            {
                intjes[i] = rd.Next(0, 101);
                
            }
            int[] sorted = intjes;
            Array.Sort(intjes);

            return (intjes, sorted);            
        }


        static int[] filledUp(int size = 3)
        {
            Random rd = new Random();
            int[] intjes = new int[size];

            for (int i = 0; i < intjes.Length; i++)
            {
                intjes[i] = rd.Next(0, 101);
            }
            Array.Sort(intjes);
            return intjes;
            // DO NOT DO THIS, DEAD CODE if behind return --> Array.Sort(intjes);
        }




        static void Print(bool[] doubles)
        {
            foreach (var item in doubles)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();            
        }
        static void Print(double[] doubles)
        {
            foreach (var item in doubles)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();            
        }

        static void Print(string[] strings)
        {
            foreach (var item in strings)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
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