using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[9];

            for (int i = 0; i < 9; i++)
            {
                tal[i] = i;
            }
            Console.WriteLine(tal[5]);
            tal[5] *= 2;

            Console.ReadKey();
        }
    }
}
