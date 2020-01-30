using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1gæt1tal
{
    class Program
    {
        static Random rnd = new Random();
        
        static void Main(string[] args)
        {
            while (true)
            {
                int number = 0;
                int trys = 0;
                bool ifrigtigt = false;
                Console.WriteLine("Klik Enter så Finder jeg et tal du skal gætte!");
                Console.ReadKey();

                number = rnd.Next(1, 10000);

                while (!ifrigtigt)
                {
                    Console.Clear();
                    Console.Write("Jamen Gæt forfanden: ");

                    int Utal;
                    Int32.TryParse(Console.ReadLine(), out Utal);

                    if (Utal == number)
                    {
                        ifrigtigt = true;
                    }
                    else if (Utal > number)
                    {
                        Console.WriteLine("Du gættet lidt for højt!");
                        trys++;
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Du gættet lidt for lavt!");
                        trys++;
                        Console.ReadKey();
                    }
                }
                Console.WriteLine($"Fandens også du gættet rigtigt.\nDu brugte {trys} forsøg");
                Console.ReadKey();
            }
        }
    }
}
