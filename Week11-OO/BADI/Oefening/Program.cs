using System;

namespace Oefening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vraag = Console.ReadLine();
            Examenvragen examen = new Examenvragen();
                
            switch (vraag)
            {
                case "A":
                string sequence = Console.ReadLine();
                examen.Futd(sequence);
                break;

                case "B":

                break;

                default:
                    Console.WriteLine("crazy input");
                break;
            }
        }
    }
}