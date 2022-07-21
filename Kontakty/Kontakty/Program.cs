using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontakty
{
    public class Kontakt
    {
        List<string> nazwa = new List<string>();
        List<int> numer = new List<int>();

        public Kontakt()
        {

        }

        public void add(string pNazwa, int pNumer)
        {
            nazwa.Add(pNazwa);
            numer.Add(pNumer);
        }

        public void findByNumber(int pNumer)
        {
            bool found = false;
            for (int i = 0; i < numer.Count; i++)
            {
                if(numer[i] == pNumer)
                {
                    Console.WriteLine(nazwa[i]);
                    found = true;
                }
            }
            if (found == false) Console.WriteLine("Nie ma takiego numeru");
        }

        public void show()
        {
            for (int i = 0; i < numer.Count; i++)
            {
                Console.WriteLine("Nazwa: " + nazwa[i] + " kontakt: " + numer[i]);
            }
        }

        public void findByName(string pNazwa)
        {
            bool found = false;
            for (int i = 0; i < nazwa.Count; i++)
            {
                if (nazwa[i] == pNazwa)
                {
                    Console.WriteLine(numer[i]);
                    found = true;
                }
            }
            if(found == false) Console.WriteLine("Nie ma takiego numeru");
        }
    }

    internal class Program
    {
        public static Kontakt k = new Kontakt();
        static int Main()
        {
            int wybor, num;
            Console.Clear();
            Console.WriteLine("Wpisz numer przy akcji by ją wywołać");
            Console.WriteLine("1. Pokaż kontakty");
            Console.WriteLine("2. Dodaj kontakt");
            Console.WriteLine("3. Pokaż kontakt po nazwie");
            Console.WriteLine("4. Pokaż kontakt po numerze");
            wybor = Convert.ToInt32(Console.ReadLine());

            switch (wybor)
            {
                case 1:
                    k.show();
                    Console.ReadLine();
                    return Main();
                case 2:
                    Console.WriteLine("Podaj nazwe kontaktu: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Podaj numer kontaktu: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    k.add(n,num);
                    return Main();
                case 3:
                    Console.WriteLine("Podaj nazwe kontaktu: ");
                    string n1 = Console.ReadLine();
                    k.findByName(n1);
                    Console.ReadLine();
                    return Main();
                case 4:
                    Console.WriteLine("Podaj nazwe kontaktu: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    k.findByNumber(num);
                    Console.ReadLine();
                    return Main();
                default:
                    return Main();
            }
        }
    }
}
