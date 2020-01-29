using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace H1arrays_øvelse1
{
    class Program
    {

        static string[] Brugre = { "root", "admin", "Sebgineer" };
        static string[] Password = { "root", "AdminErSej", "ZEBBER" };
        static void Main(string[] args)
        {
            string inputBrugre, inputPassword;
            int PasswordForsøg = 3;
            int brugreID = 0;
            bool IsBrugre = false;
            bool IsPassword = false;

            Console.WriteLine("Velkommen Til Mit HighTeck System");

            Thread.Sleep(2000);

            do
            {
                Console.Clear();
                Console.Write("Login\nBrugre: ");
                inputBrugre = Console.ReadLine();
                for (int i = 0; i < Brugre.Length; i++)
                {
                    if (inputBrugre == Brugre[i])
                    {
                        IsBrugre = true;
                        brugreID = i;
                    }
                }
            } while (!IsBrugre);

            do
            {
                Console.Write("Password: ");
                inputPassword = Console.ReadLine();
                if (inputPassword == Password[brugreID])
                {
                    Console.WriteLine($"Velkommen tilbage {inputBrugre}.");
                    IsPassword = true;
                }
                else
                {
                    PasswordForsøg--;
                }
                if (PasswordForsøg <= 0)
                {
                    Console.WriteLine("Du har desværre ikke adgang\nDu gættet lidt for mange gange  derfor vil programmet vil nu selvdestruere");
                    Thread.Sleep(1000);
                    Console.WriteLine("3");
                    Console.Beep();
                    Thread.Sleep(1000);
                    Console.WriteLine("2");
                    Console.Beep();
                    Thread.Sleep(1000);
                    Console.WriteLine("1");
                    Console.Beep();
                    Thread.Sleep(1000);
                    Console.WriteLine("BOOOM!!!");
                    Thread.Sleep(100);
                    Environment.Exit(0);
                }
            } while (!IsPassword);



            Console.WriteLine("Nu hvor du er kommet her ind, så skal du bare vide at du ikke kan en SKID");
            Console.ReadKey();
        }
    }
}
