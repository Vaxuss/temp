using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia3
{
    ////////////////////
    // Zadanie 1
    //////////////////// 

    //class Program
    //{
    //    public static double a, h, pole;
    //    static void Main(string[] args)
    //    {
    //        czytaj_dane();
    //        przetworz_dane();
    //        wyswietl_wynik();
    //    }

    //    public static void czytaj_dane()
    //    {
    //        Console.WriteLine("Podaj podstawe trojkata");
    //        a = Convert.ToDouble(Console.ReadLine());
    //        Console.WriteLine("Podaj wysokosc trojkata");
    //        h = Convert.ToDouble(Console.ReadLine());
    //    }
    //    public static void przetworz_dane()
    //    {
    //        pole = a * h * 0.5;
    //    }
    //    public static void wyswietl_wynik()
    //    {
    //        Console.WriteLine("Pole trujkata to: " + pole);
    //        Convert.ToDouble(Console.ReadLine());
    //    }
    //}


    class Program
    {
        public static double a, b, c, x1, x2, delta;
        public static byte liczbaPierwiastkow;
        static void Main(string[] args)
        {
            czytaj_dane();
            przetworz_dane();
            wyswietl_wynik();
        }

        public static void czytaj_dane()
        {
            Console.WriteLine("Podaj a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj c");
            c = Convert.ToDouble(Console.ReadLine());
        }
        public static void przetworz_dane()
        {
            delta = (b * b) - 4 * a * c;
            if(delta < 0)
            {
                liczbaPierwiastkow = 0;
            }
            else
            {
                switch (delta)
                {
                    case 0:
                        x1 = -b / (2 * a);
                        liczbaPierwiastkow = 1;
                        break;
                    default:
                        x1 = (-b - Math.Sqrt(delta)) / 2 * a;
                        x2 = (-b + Math.Sqrt(delta)) / 2 * a;
                        liczbaPierwiastkow = 2;
                        break;
                }
            }
            
        }
        public static void wyswietl_wynik()
        {
            Console.WriteLine("Dla wprowadzonych liczb: ");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            switch (liczbaPierwiastkow)
            {
                case 0:
                    Console.WriteLine("Funkcja nie ma pierwiastków");
                    break;
                case 1:
                    Console.WriteLine("Funkcja ma jeden pierwiastek: ");
                    Console.WriteLine("x1 = " + x1);
                    break;
                case 2:
                    Console.WriteLine("Funkcja ma dwa pierwiastki: ");
                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x1 = " + x2);
                    break;
            }
            Console.ReadLine();
        }
    }
}
