using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zamowienie
{
    public class Sprzedaz
    {
        string nazwa;
        int ilosc;
        decimal cena;

        public Sprzedaz(string p, int a, decimal sP)
        {
            this.nazwa = p;
            this.ilosc = a;
            this.cena = sP;
        }

        public void wypiszDane()
        {
            Console.WriteLine(nazwa);
            Console.WriteLine("ilosc: " + ilosc);
            Console.WriteLine("cena: " + cena);
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Podaj nazwe produktu: ");
            string nazwa = Console.ReadLine();
            Console.WriteLine("Podaj jego ilosc: ");
            int ilosc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj jego cene: ");
            decimal cena = Convert.ToDecimal(Console.ReadLine());
            Sprzedaz sp = new Sprzedaz(nazwa, ilosc, cena);
            Console.WriteLine("Dane produktu: ");
            sp.wypiszDane();
            Console.ReadLine();
        }
    }
}
