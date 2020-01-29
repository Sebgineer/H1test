using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1arrays_øvelse3
{
    class Program
    {
        static List<string> DrengeNavne = new List<string>();
        static List<string> PigeNavne = new List<string>();
        static void Main(string[] args)
        {
            while (true)
            {
                int valg;
                string NewName;

                Console.WriteLine("Options\n1: Søg på name\n2: Tilføj drenge navn\n3: Tilføj pige navn");
                Int32.TryParse(Console.ReadLine(), out valg);
                switch (valg)
                {
                    case 1:
                        Console.Write("Søg på et Navn: ");
                        string SøgNavn = Console.ReadLine().ToLower();
                        if (DrengeNavne.Contains(SøgNavn) || PigeNavne.Contains(SøgNavn))
                        {
                            Console.WriteLine("Ja den findes i databasen");
                        }
                        else
                        {
                            Console.WriteLine("Den findes ikke i databasen");
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Write("Tilføj drenge Navn: ");
                        NewName = Console.ReadLine();
                        DrengeNavne.Add(NewName.ToLower());
                        break;
                    case 3:
                        Console.Write("Tilføj pige Navn: ");
                        NewName = Console.ReadLine();
                        PigeNavne.Add(NewName.ToLower());
                        break;
                }
                Console.Clear();
            }
        }
    }
}
