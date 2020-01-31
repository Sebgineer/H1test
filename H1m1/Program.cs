using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1m1
{
    class Program
    {
        static double tal1;
        static int tal2;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Protens Udregner");

                Console.Write("Vælg et tal: ");
                tal1 = AskofTal();

                Console.Write("Vælg et Potens: ");
                Int32.TryParse(AskofTal().ToString(), out tal2);

                Console.WriteLine($"Ja det blev {Calculate(tal1, tal2)}");

                Console.ReadKey();
                Console.Clear();
            }
        }

        static double Calculate(double tal, int protensen)
        {
            double result = tal;

            for (int i = 0; i < protensen - 1; i++)
            {
                result *= tal;
            }

            return result;
        }

        static double AskofTal()
        {
            double result = 0;

            Double.TryParse(Console.ReadLine(), out result);

            return result;
        }
    }
}
