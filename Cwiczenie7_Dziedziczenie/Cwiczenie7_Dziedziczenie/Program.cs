using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie7_Dziedziczenie
{
    class Osoba
    {
        public string imie, nazwisko;

        public Osoba(){
        }

        public Osoba(string pimie, string pnazwisko)
        {
            this.imie = pimie;
            this.nazwisko = pnazwisko;
        }

        public void wczytaj()
        {
            Console.WriteLine("Wpisz Imie");
            imie = Console.ReadLine();
            Console.WriteLine("Wpisz nazwisko");
            nazwisko = Console.ReadLine();
        }

        public void wypisz()
        {
            Console.WriteLine("Imie i nazwisko: " + imie + " " + nazwisko);
        }
    }

    class Kadra : Osoba
    {
        public string wyksztalcenie, stanowisko;
        public string imie, nazwisko;
        Osoba osoba;
        public Kadra(Osoba posoba) : base(posoba.imie, posoba.nazwisko)
        {
            this.osoba = posoba;
            this.imie = posoba.imie;
            this.nazwisko = posoba.nazwisko;
        }

        public void wczytaj1()
        {
            Console.WriteLine("Wpisz stanowisko");
            stanowisko = Console.ReadLine();
            Console.WriteLine("Wpisz wyksztalcenie");
            wyksztalcenie = Console.ReadLine();
        }

        public void wypisz1()
        {
            Console.WriteLine("Wykształcenie: " + wyksztalcenie);
            Console.WriteLine("Stanowisko: " + stanowisko);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba o1 = new Osoba("Jan", "Kowalski");
            Kadra k1 = new Kadra(o1);
            k1.wczytaj1();

            k1.wypisz();
            k1.wypisz1();
            Console.ReadKey();
        }
    }
}
