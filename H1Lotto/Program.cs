using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Lotto
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            while (true)
            {

                int[] VinderKupon = new int[7];
                int[,] dinKupon = new int[7, 5];

                for (int i = 0; i < VinderKupon.Length; i++)
                {
                    VinderKupon[i] = rnd.Next(1, 21);
                }

                Console.WriteLine("Klik Enter for at købe et lotto kupon");
                Console.ReadKey();

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        dinKupon[j, i] = rnd.Next(1, 21);
                    }
                }

                Console.Clear();
                Console.WriteLine("her er dine Kuponer");
                for (int i = 0; i < 5; i++)
                {
                    string resutat = "";
                    for (int j = 0; j < 7; j++)
                    {
                        resutat += $"{dinKupon[j, i]} ";
                    }
                    Console.WriteLine($"{i + 1}: {resutat}");
                }

                Console.WriteLine("\nKlik Enter for at se om du vandt");
                Console.ReadKey();

                for (int i = 0; i < 5; i++)
                {
                    int rightCount = 0;
                    for (int j = 0; j < 7; j++)
                    {
                        if (dinKupon[j, i] == VinderKupon[j])
                        {
                            rightCount++;
                        }
                    }
                    if (rightCount >= 7)
                    {
                        Console.WriteLine($"OG VI HAR EN VINDER TADAAAAA. Det var Kupon {i}");
                    }
                    else
                    {
                        Console.WriteLine($"Kupon {i + 1} havde {rightCount} rigtige");
                    }
                }

                Console.WriteLine($"Dette er vinder kuponen {VinderKupon[0]} {VinderKupon[1]} {VinderKupon[2]} {VinderKupon[3]} {VinderKupon[4]} {VinderKupon[5]} {VinderKupon[6]}");

                Console.WriteLine("\nKlik Enter for at prøve igen");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
