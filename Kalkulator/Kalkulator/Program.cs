using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    public class Kalk
    {
        public void oblicz()
        {
            string wzor, polWzoru = "";
            string[] temp = new string[0];
            int ktoreDzialanie = 0, polowa = 0;
            Console.WriteLine("Napisz obliczenia z '-', '+', '/', '*' liczby i znaki oddziel spacją, operacje wyłącznie na liczbach naturalnych: ");
            wzor = Console.ReadLine();
            temp = wzor.Split(' ');
            for(int i = 0; i < temp.Length; i++)
            {
                if(temp[i] == "-")
                {
                    polowa = i;
                    ktoreDzialanie = 1;
                }
                if (temp[i] == "+")
                {
                    polowa = i;
                    ktoreDzialanie = 2;
                }
                if (temp[i] == "*")
                {
                    polowa = i;
                    ktoreDzialanie = 3;
                }
                if (temp[i] == "/")
                {
                    polowa = i;
                    ktoreDzialanie = 4;
                }
            }

            for(int i = 0; i < polowa; i++)
            {
                polWzoru += temp[i];
            }
            double p1 = Convert.ToInt32(polWzoru);
            polWzoru = "";
            for (int i = polowa+1; i < temp.Length; i++)
            {
                polWzoru += temp[i];
            }
            double p2 = Convert.ToInt32(polWzoru);
            switch (ktoreDzialanie)
            {
                case 1:
                    p1 -= p2;
                    break;
                case 2:
                    p1 += p2;
                    break;
                case 3:
                    p1 *= p2;
                    break;
                case 4:
                    p1 /= p2;
                    break;
            }
            Console.WriteLine("Wynik to: " + p1);
        }

        public void potega()
        {
            Console.WriteLine("Podaj liczbe ptęgowaną(naturalną): ");
            int podstawa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj potęge(naturalną): ");
            int potega = Convert.ToInt32(Console.ReadLine());

            double wynik = Math.Pow(podstawa, potega);

            Console.WriteLine("Wynik to: " + wynik);
        }

        public void pierwiastek()
        {
            Console.WriteLine("Podaj liczbe do pierwiastkowania(naturalną): ");
            double podstawa = Convert.ToDouble(Console.ReadLine());
            podstawa = Math.Sqrt(podstawa);
            Console.WriteLine("Wynik to: " + podstawa);
        }

        public void silnia()
        {
            Console.WriteLine("Podaj liczbe by obliczyć jej silnie(naturalną): ");
            int podstawa = Convert.ToInt32(Console.ReadLine());
            int wynik = 1;
            for(int i = 1; i <= podstawa; i++)
            {
                wynik *= i;
            }
            Console.WriteLine("Wynik to: " + wynik);
        }
    }

    internal class Program
    {
        public static Kalk k = new Kalk();
        static int Main()
        {
            Console.Clear();
            int wybor = 0;
            Console.WriteLine("Jakie obliczenia chcesz wprowadzić? Wpisz odpowiadającą liczbe");
            Console.WriteLine("1. zwykłe obliczenia");
            Console.WriteLine("2. obliczenie potęgi");
            Console.WriteLine("3. obliczenie pierwaistka");
            Console.WriteLine("4. obliczenie silni");
            wybor = Convert.ToInt32(Console.ReadLine());

            switch (wybor)
            {
                case 1:
                    k.oblicz();
                    Console.ReadLine();
                    return Main();
                case 2:
                    k.potega();
                    Console.ReadLine();
                    return Main();
                case 3:
                    k.pierwiastek();
                    Console.ReadLine();
                    return Main();
                case 4:
                    k.silnia();
                    Console.ReadLine();
                    return Main();
                default:
                    return Main();
            }
        }
    }
}















//for (int i = 0; i < wzor.Length; i++)
//{
//    if (wzor[i] == ' ')
//    {
//        czyDzielic = true;
//    }
//}

//if (czyDzielic == true)
//{
//    temp = wzor.Split(' ');
//}
//else
//{
//    temp = wzor.Split('/');
//}