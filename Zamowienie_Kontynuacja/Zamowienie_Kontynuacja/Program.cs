using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamowienie_Kontynuacja
{
    public class Osoba
    {
        public string imie, nazwisko;

        Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public Osoba()
        {
            Console.WriteLine("Podaj imie: ");
            imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: ");
            nazwisko = Console.ReadLine();
        }
    }
    public class Produkt
    {
        public string nazwa, jednostka_miary;
        public double cena, vat = 0.22, zysk;
        DateTime data;

        public Produkt()
        {
            Console.WriteLine("Podaj nazwe produktu: ");
            nazwa = Console.ReadLine();
            Console.WriteLine("Podaj jednostke miary produktu: ");
            jednostka_miary = Console.ReadLine();
            Console.WriteLine("Podaj cene produktu: ");
            cena = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj date ważności produktu: ");
            data = Convert.ToDateTime(Console.ReadLine());
        }

        public Produkt(string pNazwa, string pJednostka_miary, double pCena, DateTime pData)
        {
            this.nazwa = pNazwa;
            this.cena = pCena;
            this.jednostka_miary = pJednostka_miary;
            this.data = pData;
            zysk = cena - (cena * vat);
        }

        public void wypiszDane()
        {
            Console.WriteLine("nazwa: " + nazwa);
            Console.WriteLine("jednostka miary: " + jednostka_miary);
            Console.WriteLine("cena: " + cena);
            Console.WriteLine("vat: " + vat);
            Console.WriteLine("zysk: " + zysk);
            Console.WriteLine("data: " + data);
        }

        public void Clone(Produkt produkt)
        {
            this.nazwa = produkt.nazwa;
            this.cena = produkt.cena;
            this.jednostka_miary = produkt.jednostka_miary;
            this.data = produkt.data;
            this.zysk = produkt.zysk;
        }
    }

    public class Sprzedaz
    {
        Produkt produkt;
        int ilosc;
        Osoba klient;

        public Sprzedaz(Produkt p, int a, Osoba k)
        {
            this.produkt = p;
            this.ilosc = a;
            this.klient = k;
        }

        public void wypiszDane()
        {
            Console.WriteLine(produkt.nazwa.ToString());
            Console.WriteLine("ilosc: " + ilosc);
            Console.WriteLine("cena: " + produkt.cena);
            Console.WriteLine("klient: " + klient.imie + " " + klient.nazwisko);
        }
    }
    class Program
    {
        static void Main()
        {
            Osoba o1 = new Osoba();
            Produkt p1 = new Produkt();
            Console.WriteLine("Podaj jego ilosc: ");
            int ilosc = Convert.ToInt32(Console.ReadLine());
            Sprzedaz sp = new Sprzedaz(p1, ilosc, o1);
            Console.WriteLine("Dane produktu: ");
            sp.wypiszDane();
            Console.ReadLine();
        }
    }
}
