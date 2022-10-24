using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wektor_Dziedziczenie
{
    public class Wektor
    {
        int n;
        double[] dane;
        double suma = 0.0;

        public Wektor(int n, double[] dane)
        {
            this.n = n;
            this.dane = dane;
        }
        public void show()
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("dane nr " + i + ":" + dane[i]);
            }
        }
        public double Sum()
        {
            for (int i = 0; i < n; i++)
            {
                suma += dane[i];
            }
            return suma;
        }
        public void add(Wektor w)
        {
            double[] newDane = new double[n + w.n];
            for (int i = 0; i < n; i++)
            {
                newDane[i] = dane[i];
            }
            int j = 0;
            for (int i = n; i < n + w.n; i++)
            {
                newDane[i] = w.dane[j++];
            }
            dane = newDane;
            n = n + w.n;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] dane = new double[2];
            dane[0] = 1.5;
            dane[1] = 1.5;
            Wektor wektor = new Wektor(2, dane);
            wektor.show();
            Wektor w2 = new Wektor(2, dane);
            wektor.add(w2);
            wektor.show();
            double suma = wektor.Sum();
            Console.WriteLine("Suma wektorow to: " + suma);
            Console.ReadLine();
        }
    }
}
