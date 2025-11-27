using System;

namespace SatorSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
            string[] str; //temporariy save spot for each line of my matrix that i'm building in here
            string[,] strings = new string[5,5];


            //filling the 2D square matrix
            for (int i = 0; i < strings.GetLength(0); i++)
            {
                str = Console.ReadLine().ToLower().Split(' ');
                if (str.Length != 5)
                {
                    throw new IndexOutOfRangeException();
                }
                for (int j = 0; j < strings.GetLength(1); j++)
                {
                    if (Int32.TryParse(str[j], out int nr))
                    {
                        throw new FormatException();
                    }
                    strings[i,j] = str[j];
                }
            }


            //THE ACTUAL CHECKS
            int counter = 0;
            for (int i = 1; i <= strings.GetLength(0); i++)
            {
                for (int j = 1; j <= strings.GetLength(1); j++)
                {
                    if (strings[i-1, j-1] == strings[strings.GetLength(0) - i, strings.GetLength(1) - j])
                    {
                        counter++;
                    }
                }
            }

            if (counter == 25)
            {
                Console.WriteLine("This is a correct satorsquare");
            }
            else
            {
                Console.WriteLine("This is NOT a correct satorsquare");
            }
            }
            catch (FormatException)
            {
                
            }
            catch (IndexOutOfRangeException)
            {
                
            }
            catch (Exception)
            {
                
            }
            

            

            
        }
    }
}