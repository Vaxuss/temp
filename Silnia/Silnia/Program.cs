using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
////
//
////
namespace Silnia
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Prosze podać liczbe całkowitą");
            string input = Console.ReadLine();
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == '-')
                {
                    Console.WriteLine("Błąd. Podano liczbe ujemną.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
            int liczba = Convert.ToInt32(input);
            int wynik = 1;
            for (int i = 1; i <= liczba; i++)
            {
                wynik *= i;
            }
            Console.WriteLine("Silnia to: " + wynik);
            Console.ReadLine();
        }
    }
}
