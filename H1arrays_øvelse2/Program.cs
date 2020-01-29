using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1arrays_øvelse2
{
    class Program
    {
        static string[] DrengeNavne = { "william", "oliver", "noah", "emil", "victor", "magnus", "frederik", "mikkel", "lucas", "alexander", "oscar", "mathias", "sebastian", "malte", "elias", "christian", "mads", "gustav", "villads" };
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Søg på et Drenge Navn: ");
                string SøgNavn = Console.ReadLine().ToLower();
                if (DrengeNavne.Contains(SøgNavn))
                {
                    Console.WriteLine("Ja den findes i databasen");
                }
                else
                {
                    Console.WriteLine("Den findes ikke i databasen");
                }
            }
        }
    }
}
