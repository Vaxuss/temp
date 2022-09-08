using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/////
///Wiele programów w jednym pliku dla ułatwienia sprawdzania
////
namespace Cwiczenia_5
{
    internal class Program
    {
        /// <summary>
        /// Zadanie 1
        /// </summary>
        //static void Main()
        //{
        //    Console.WriteLine("Prosze podać liczbe całkowitą");
        //    string input = Console.ReadLine();
        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        if (input[i] == '-')
        //        {
        //            Console.WriteLine("Błąd. Podano liczbe ujemną.");
        //            Console.ReadLine();
        //            Environment.Exit(0);
        //        }
        //    }
        //    int liczba = Convert.ToInt32(input);
        //    int wynik = 1;
        //    for (int i = 1; i <= liczba; i++)
        //    {
        //        wynik *= i;
        //    }
        //    Console.WriteLine("Silnia to: " + wynik);
        //    Console.ReadLine();
        //}


        /// <summary>
        /// Zadanie 2
        /// </summary>
        //static void Main()
        //{
        //    Console.WriteLine("Prosze podać liczbe rzutów kostką");
        //    int input = Convert.ToInt32(Console.ReadLine());
        //    Random rand = new Random();
        //    for (int i = 0; i < input; i++)
        //    {
        //        Console.WriteLine(rand.Next(1, 7));
        //    }
        //    Console.ReadLine();
        //}


        /// <summary>
        /// Zadanie 3
        /// </summary>
        //static void Main()
        //{
        //    Console.WriteLine("Prosze podać długość tablicy");
        //    int input = Convert.ToInt32(Console.ReadLine());
        //    double[] losowe = new double[input];
        //    double min = 1;
        //    int indexMin = 0;
        //    Random rand = new Random();
        //    for (int i = 0; i < input; i++)
        //    {  
        //        losowe[i] = rand.NextDouble();
        //        //Console.WriteLine(losowe[i]);
        //    }

        //    for (int i = 0; i < input; i++)
        //    {
        //        for(int j = 0; j < input; j++)
        //        {
        //            if (losowe[j] < min)
        //            {
        //                min = losowe[j];
        //                indexMin = j;
        //            }
        //        }
        //    }

        //    Console.WriteLine("Liczba minimalna to: " + min + " Jej pozycja w tablicy to: " + indexMin);
        //    Console.WriteLine("Tablica liczb losowych: ");
        //    for (int i = 0; i < input; i++)
        //    {
        //        Console.WriteLine(losowe[i]);
        //    }
        //    Console.ReadLine();
        //}


        /// <summary>
        /// Zadanie 4 
        /// + Chyba się powtórzyło z zadania 10 z ćwiczeń 2;
        /// </summary>
        //static void Main(string[] args)
        //{
        //    string[] imiona = { "Ala", "Agata", "Ela", "Gienia", "Ola", "Ela", "Tola", "Ela" };

        //    Console.WriteLine("Pierwsze wystąpieie imieia jest na indexie: " + Array.IndexOf(imiona, "Ala"));
        //    Console.WriteLine("Pierwsze wystąpieie imieia jest na indexie: " + Array.IndexOf(imiona, "Ela"));
        //    Console.WriteLine("Pierwsze wystąpieie imieia jest na indexie: " + Array.IndexOf(imiona, "Władysław"));
        //    Console.ReadLine();
        //}

        /// <summary>
        /// Zadanie 5
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Prosze podać jakiś tekst: ");
            string tekst = Console.ReadLine();
            string tekstbez = "";
            List<char> znakiInter = new List<char>();
            List<char> biale = new List<char>();
            List<int> pozycjeInter = new List<int>(); 
            List<int> pozycjeBiale = new List<int>();
            List<string> wynik = new List<string>();
            for(int i = 0; i < tekst.Length; i++)
            {
                if(tekst[i] == '.' || tekst[i] == '!' || tekst[i] == '?' || tekst[i] == ';' || tekst[i] == ':' || tekst[i] == '"' || tekst[i] == ',')
                {
                    znakiInter.Add(tekst[i]);
                    tekstbez = tekst.Replace(tekst[i], ' ');
                    pozycjeInter.Add(i);
                }
                if (tekst[i] == ' ')
                {
                    biale.Add(tekst[i]);
                    pozycjeBiale.Add(i);
                }
            }

            string[] tekstTemp = tekstbez.Split(' ');
            int j = 0, b = 0, t = 0;
            for (int i = 0; i < tekst.Length; i++)
            {
                if (j < znakiInter.Count)
                {
                    if(tekst[i] == znakiInter[j]) wynik.Add(znakiInter[j++].ToString());
                }
                if (b < biale.Count)
                {
                    if(tekst[i] == biale[b]) wynik.Add(biale[b++].ToString());
                }
                if(i < tekstTemp.Length)
                {
                    wynik.Add(tekstTemp[t++]);
                }             
            }
            string[] zdanie = wynik.ToArray();
            for (int i = 0; i < zdanie.Length; i++)
            {
                Console.WriteLine(zdanie[i]);
            }
            Console.ReadLine();
        }
    }
}