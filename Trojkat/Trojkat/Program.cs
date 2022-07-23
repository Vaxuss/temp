using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trojkat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj 3 cyfry całkowite dodatnie: ");
            Console.WriteLine("Liczba 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Liczba 2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Liczba 3: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if(a >= b && a >= c)
            {
                if ((b * b) + (c * c) == a * a)
                {
                    Console.WriteLine("Podano 3 pitagorejską dobra robota!");
                }
                else Console.WriteLine("Nie podano 3 pitagorejskiej");
            }
            else if(b >= a && b >= c)
            {
                if ((a * a) + (c * c) == b * b)
                {
                    Console.WriteLine("Podano 3 pitagorejską dobra robota!");
                }
                else Console.WriteLine("Nie podano 3 pitagorejskiej");
            }
            else if(c >= b && c >= a)
            {
                if ((b * b) + (a * a) == c * c)
                {
                    Console.WriteLine("Podano 3 pitagorejską dobra robota!");
                }
                else Console.WriteLine("Nie podano 3 pitagorejskiej");
            }
            Console.ReadLine();
        }
    }
}
