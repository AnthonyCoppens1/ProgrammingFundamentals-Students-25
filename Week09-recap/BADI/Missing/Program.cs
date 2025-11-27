using System;

namespace Missing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 OPTIES
            //OPTIE 1
            int[] x = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            int totaal = 45;

            for (int i = 0; i < x.Length; i++)
            {
                totaal -= x[i];
            }
            if (totaal == 0)
            {
                Console.WriteLine("Geen missing link");
            }
            else
            {
                Console.WriteLine(totaal);
            }


            //OPTIE 2 --> voorbeeld waarbij meerdere getallen kunnen ontbreken
            string[] s = Console.ReadLine().Split(' ');
            int[] getallen = new int[s.Length];

            int[] origineel = {1, 2, 3, 4, 5, 6, 7, 8, 9};

            for (int i = 0; i < getallen.Length; i++)
            {
                getallen[i] = Convert.ToInt32(s[i]);
            }

            List<int> missing = new List<int>();
            for (int i = 0; i < origineel.Length; i++)
            {
                if (!getallen.Contains(origineel[i]))
                {
                    missing.Add(origineel[i]);
                }
            }

            if (missing.Count == 0)
            {
                Console.WriteLine("Geen missing link");
            }
            else
            {
                foreach (var item in missing)
                {
                    Console.Write(item + " ");
                }
            }
            
        }
    }
}