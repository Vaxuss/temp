using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produkt
{
    public class Produkt
    {
        string nazwa, jednostka_miary;
        double cena, vat = 0.22, zysk;
        DateTime data;

        public Produkt()
        {
            Console.WriteLine("Podaj nazwe: ");
            nazwa = Console.ReadLine();
            Console.WriteLine("Podaj jednostke miary: ");
            jednostka_miary = Console.ReadLine();
            Console.WriteLine("Podaj cena: ");
            cena = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj date: ");
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
    internal class Program
    {
        static void Main(string[] args)
        {
            Produkt p1 = new Produkt();
            p1.wypiszDane();
            Produkt p2 = new Produkt();
            p2.Clone(p1);
            p2.wypiszDane();
            Console.ReadLine();
        }
    }
}
