using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haslo
{
    internal class Program
    {
        static int proby = 3;
        static int Main()
        {
            Console.WriteLine("Podaj nazwe urzytkownika: ");
            string user = Console.ReadLine();
            Console.WriteLine("Podaj Haslo: ");
            string pass = Console.ReadLine();

            if (pass != "haslo" && proby > 1)
            {
                Console.Clear();
                Console.WriteLine("Złe hasło! pozostałe proby: " + --proby);
                return Main();
            }
            else if (pass == "haslo")
            {
                if(user == "admin")
                {
                    Console.WriteLine("Admin? serio?");
                    Console.ReadLine();
                }
            }
            else if (proby == 0) Environment.Exit(0);
            return 0;
        }
    }
}
