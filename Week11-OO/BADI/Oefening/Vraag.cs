using System;

namespace Oefening
{
    public class Examenvragen
    {
        public Examenvragen(){}

        public void Futd(string sequence) //wat komt er binnen: "1-5 2-10 3-15 5-25 6-30 7-35 8-40 9-45"
        {
            string[] array = sequence.Split(" ");
            //in de array zit: {"1-5", "2-10", "3-15"}
            Dictionary<int, int> D = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                string[] tijdelijlk = array[i].Split("-");
                D.Add(Convert.ToInt32(tijdelijlk[0]), Convert.ToInt32(tijdelijlk[1]));
            }

            int somVanKeys = 0;
            foreach (var pair in D)
            {
                somVanKeys += pair.Key;
            }

            int ontbrekendeKey = 45 - somVanKeys;
            if (D.ContainsKey(1))
            {
                Console.WriteLine($"{ontbrekendeKey}-{D[1]*ontbrekendeKey}");
            }
            else
            {
                int waarde = D[2] / 2;
                Console.WriteLine($"{ontbrekendeKey}-{waarde*ontbrekendeKey}");
            }
            
        }
    }
}