using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LosoweSlowa
{
    public class Gra
    {
        public string scramble(string slowo)
        {
            Random r = new Random();
            string random = new string(slowo.ToCharArray().OrderBy(s => (r.Next(2) % 2) == 0).ToArray());
            Console.WriteLine("String = {0}", slowo);

            return random;
        }

        public int gameplay(string slowo, string scrambled)
        {
            Console.WriteLine("Zgadnij słowo: " + scrambled);
            string proba = Console.ReadLine();
            if(proba == slowo)
            {
                Console.WriteLine("Brawo!");
                Console.ReadLine();
                return 0;
            }
            else
            {
                Console.WriteLine("Źle!");
                return gameplay(slowo, scrambled);
            }
        }
    }
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Wpisz słowo: ");
            string slowo = Console.ReadLine();
            string scrambled = "";
            Gra G = new Gra();
            scrambled = G.scramble(slowo);
            Console.Clear();
            G.gameplay(slowo, scrambled);
        }
    }
}
