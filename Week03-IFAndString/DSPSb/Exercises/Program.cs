using System;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Exercise 1, heatwave detection system
            enter 5 temperatures --> double
            out of those 5 --> all of them have to be >= 25
            3 out of the 5 ALSO have to be >= 30

            heatwave message: CAREFUL YOUR HAIR MIGHT LIGHT ON FIRE!
            try and use an if-statement that checks your days!
            */
            /*double temp1 = Convert.ToDouble(Console.ReadLine());
            double temp2 = Convert.ToDouble(Console.ReadLine());
            double temp3 = Convert.ToDouble(Console.ReadLine());
            double temp4 = Convert.ToDouble(Console.ReadLine());
            double temp5 = Convert.ToDouble(Console.ReadLine());*/

            
            Double.TryParse(Console.ReadLine(), out double temp1);
            Double.TryParse(Console.ReadLine(), out double temp2);
            Double.TryParse(Console.ReadLine(), out double temp3);
            Double.TryParse(Console.ReadLine(), out double temp4);
            Double.TryParse(Console.ReadLine(), out double temp5);

            int daysHigherThan30 = 0;

            if (temp1 >= 25 && temp2 >= 25 && temp3 >= 25 && temp4 >= 25 && temp5 >= 25)
            {
                if (temp1 >= 30)
                {
                    daysHigherThan30++; //daysHigherThan30 = DaysHigherThan30 + 1
                }
                if (temp2 >= 30)
                {
                    daysHigherThan30++; //daysHigherThan30 = DaysHigherThan30 + 1
                }
                if (temp3 >= 30)
                {
                    daysHigherThan30++; //daysHigherThan30 = DaysHigherThan30 + 1
                }
                if (temp4 >= 30)
                {
                    daysHigherThan30++; //daysHigherThan30 = DaysHigherThan30 + 1
                }
                if (temp5 >= 30)
                {
                    daysHigherThan30++; //daysHigherThan30 = DaysHigherThan30 + 1
                }

                if (daysHigherThan30 >= 3)
                {
                    Console.WriteLine("HEATWAVE ALERT");
                }
                else
                {
                    Console.WriteLine("NO HEATWAVE");
                }
            }
            else
            {
                Console.WriteLine("NO HEATWAVE OR WRONG NUMBERS");
            }


        }
    }
}