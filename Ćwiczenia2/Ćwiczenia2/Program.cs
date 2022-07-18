using System;

namespace Ćwiczenia2
{
    class Program
    {
        //--------------------------
        //Zadanie 1 
        //--------------------------
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Program wyświetla elementy tablicy jednowymiarowej 10_elementowej.");
        //    int[] dane = new int[10];
        //    for(int i = 0; i < 10; i++)
        //    {
        //        dane[i] = i;
        //        Console.WriteLine("dane[" + i + "] = " + dane[i]);
        //    }
        //}


        //--------------------------
        //Zadanie 2
        //--------------------------
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Program wyświetla elementy tablicy jednowymiarowej 10_elementowej.");
        //    int[] dane = new int[10];
        //    int x = 0;
        //    for (int i = 9; i >= 0; i--)
        //    {
        //        dane[x] = i;
        //        Console.WriteLine("dane[" + x + "] = " + dane[x++]);
        //    }
        //}


        //--------------------------
        //Zadanie 3
        //--------------------------
        //static void Main(string[] args)
        //{
        //    int temp, suma = 0;
        //    int[] uczestnicyWycieczki = { 26, 34, 23, 54, 31 };

        //    for(int i = 0; i < 5; i++)
        //    {
        //        for (int j = 0; j < 4; j++)
        //        {
        //            if(uczestnicyWycieczki[j] > uczestnicyWycieczki[j + 1])
        //            {
        //                temp = uczestnicyWycieczki[j + 1];
        //                uczestnicyWycieczki[j + 1] = uczestnicyWycieczki[j];
        //                uczestnicyWycieczki[j] = temp;
        //            }
        //        }
        //    }

        //    for (int i = 0; i < 5; i++)
        //    {
        //        suma += uczestnicyWycieczki[i];
        //    }

        //    Console.WriteLine("Łączny wiek uczestników: " + suma);
        //    Console.WriteLine("Najstarszy uczestnik: " + uczestnicyWycieczki[4]);
        //    Console.WriteLine("Najmłodszy uczestnik: " + uczestnicyWycieczki[0]);
        //}


        //--------------------------
        //Zadanie 4
        //--------------------------
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Ile imoin chcesz wpisać?");
        //    int ile = Convert.ToInt32(Console.ReadLine());
        //    string[] imiona = new string[ile];

        //    for (int i = 0; i < ile; i++)
        //    {
        //        Console.WriteLine("Podaj imie " + (i + 1));
        //        imiona[i] = Console.ReadLine();
        //    }

        //    for (int i = 0; i < ile; i++)
        //    {
        //        Console.Write(imiona[i] + ", ");
        //    }
        //}


        //--------------------------
        //Zadanie 5
        //--------------------------
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Podaj ilość elementów tablicy.");
        //    int ile = Convert.ToInt32(Console.ReadLine());
        //    int[] liczby = new int[ile];
        //    int suma = 0;

        //    for (int i = 0; i < ile; i++)
        //    {
        //        Console.WriteLine("Podaj element [" + i + "] tablicy");
        //        liczby[i] = Convert.ToInt32(Console.ReadLine());
        //        suma += liczby[i];
        //    }
        //    Console.Write("Wybrane liczby to: ");
        //    for (int i = 0; i < ile; i++)
        //    {
        //        Console.Write(liczby[i] + ", ");
        //    }
        //    Console.Write("Suma elementów to: " + suma);
        //}


        //--------------------------
        //Zadanie 6
        //--------------------------
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Program wyświetla zawartość tablicy dwuwymiarowej 10x10.");
        //    int[,] liczby = new int[10,10];
        //    int suma = 0;

        //    for (int i = 0; i < 10; i++)
        //    {
        //        for (int j = 0; j < 10; j++)
        //        {
        //            if (i == j)
        //            {
        //                liczby[i, j] = 1;
        //                suma += liczby[i, j];
        //            }
        //            else liczby[i, j] = 0;
        //            Console.Write(liczby[i,j] + " ");
        //        }
        //        Console.Write("\n");
        //    }

        //    Console.Write("\n Suma wyróżnionych elementów to: " + suma);
        //}


        //--------------------------
        //Zadanie 7
        //--------------------------
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Program wyświetla zawartość tablicy dwuwymiarowej 10x10.\n");
        //    int[,] liczby = new int[10, 10];
        //    int suma = 0;

        //    for (int i = 0; i < 10; i++)
        //    {
        //        for (int j = 0; j < 10; j++)
        //        {
        //            if (j == 0)
        //            {
        //                liczby[i, j] = i;
        //                suma += liczby[i, j];
        //            }
        //            else if (j == 1)
        //            {
        //                liczby[i, j] = i * i;
        //                suma += liczby[i, j];
        //            }
        //            else liczby[i, j] = 0;
        //            Console.Write(liczby[i, j] + " ");
        //        }
        //        Console.Write("\n");
        //    }

        //    Console.Write("\n Suma wyróżnionych elementów to: " + suma);
        //}


        //--------------------------
        //Zadanie 8
        //--------------------------
        //static void Main(string[] args)
        //{
        //    int[] tab = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; 
        //    Array.Reverse(tab);

        //    Console.Write("Tablica po odwróceniu: ");
        //    for (int i = 0; i < 9; i++)
        //    {
        //        Console.Write(tab[i] + " ");
        //    }

        //}


        //--------------------------
        //Zadanie 9
        //--------------------------
        //static void Main(string[] args)
        //{
        //    int[] tab = { 4, 2, 6, 23, 1, 3, 7, 0 };
        //    Array.Sort(tab);

        //    Console.Write("Tablica po posortowaniu: ");
        //    for (int i = 0; i < tab.Length; i++)
        //    {
        //        Console.Write(tab[i] + " ");
        //    }
        //}


        //--------------------------
        //Zadanie 10
        //--------------------------
        //static void Main(string[] args)
        //{
        //    string[] imiona = { "Ala", "Agata", "Ela", "Gienia", "Ola", "Ela", "Tola", "Ela"};

        //    Console.WriteLine("Pierwsze wystąpieie imieia jest na indexie: " + Array.IndexOf(imiona, "Ala"));
        //    Console.WriteLine("Pierwsze wystąpieie imieia jest na indexie: " + Array.IndexOf(imiona, "Ela"));
        //    Console.WriteLine("Pierwsze wystąpieie imieia jest na indexie: " + Array.IndexOf(imiona, "Władysław"));
        //}


        //--------------------------
        //Zadanie 11 // nie wiem czy to jest to czego zadanie odemnie wymagało
        //--------------------------
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Podaj zakres minimalny dla tabliczki mnożenia");
        //    int min = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Podaj zakres maksymalny dla tabliczki mnożenia");
        //    int max = Convert.ToInt32(Console.ReadLine());

        //    int[,] wynik = new int[max, max];


        //    int x=0, y=0;
        //    for(int i = min; i <= max; i++)
        //    {
        //        for(int j = min; j <= max; j++)
        //        {
        //            wynik[x, y] = i*j;
        //            Console.Write(wynik[x, y] + " ");
        //            y++;
        //        }
        //        y = 0;
        //        x++;               
        //        Console.Write("\n");
        //    }
        //}


        //--------------------------
        //Zadanie 12 zapisane w tabeli poprawnie wyświetlenie jest problematyczne;
        //--------------------------
        //static void Main(string[] args)
        //{
        //    int[] losowe = new int[5];
        //    string[] liczby = new string[5];
        //    Array[] wynik = new Array[5];
        //    for(int i = 0; i < 5; i++)
        //    {
        //        Random r = new Random();
        //        int rInt = r.Next(0, 1000);
        //        losowe[i] = rInt;
        //        Console.WriteLine(losowe[i]);
        //    }
        //    string temp = "";

        //    for(int i = 0; i < 5; i++)
        //    {
        //        temp = losowe[i].ToString();
        //        liczby[i] = temp;
        //    }

        //    char[] wynik1 = liczby[0].ToCharArray();
        //    char[] wynik2 = liczby[1].ToCharArray();
        //    char[] wynik3 = liczby[2].ToCharArray();
        //    char[] wynik4 = liczby[3].ToCharArray();
        //    char[] wynik5 = liczby[4].ToCharArray();

        //    wynik[0] = wynik1;
        //    wynik[1] = wynik2;
        //    wynik[2] = wynik3;
        //    wynik[3] = wynik4;
        //    wynik[4] = wynik5;

        //    for (int i = 0; i < wynik1.Length; i++)
        //    {
        //        Console.Write(wynik1[i] + " ");
        //    }
        //    Console.Write("\n");
        //    for (int i = 0; i < wynik2.Length; i++)
        //    {
        //        Console.Write(wynik2[i] + " ");
        //    }
        //    Console.Write("\n");
        //    for (int i = 0; i < wynik3.Length; i++)
        //    {
        //        Console.Write(wynik3[i] + " ");
        //    }
        //    Console.Write("\n");
        //    for (int i = 0; i < wynik4.Length; i++)
        //    {
        //        Console.Write(wynik4[i] + " ");
        //    }
        //    Console.Write("\n");
        //    for (int i = 0; i < wynik5.Length; i++)
        //    {
        //        Console.Write(wynik5[i] + " ");
        //    }
        //}


        //--------------------------
        //Zadanie 13 // dwa rozwiązania 
        //--------------------------
        //static void Main(string[] args)
        //{
        //    string zdanie = "Dla podanego tekstu utwórz tablicę zawierającą słowa z tego tekstu.";
        //    string[] words = zdanie.Split(' ');

        //    for(int i = 0; i < words.Length; i++)
        //    {
        //        Console.WriteLine(words[i]);
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    //Dla podanego tekstu utwórz tablicę zawierającą słowa z tego tekstu
        //    string[] zdanie = new string[20];
        //    zdanie[0] = "Dla";
        //    zdanie[1] = " ";
        //    zdanie[2] = "podanego";
        //    zdanie[3] = " ";
        //    zdanie[4] = "tekstu";
        //    zdanie[5] = " ";
        //    zdanie[6] = "utwórz";//i tak dalej, chyba o czymś nie wiem albo zabieram się do tego źle.
        //}


        //--------------------------
        //Zadanie 1 // dodatkowe
        //--------------------------
        //static void Main(string[] args)
        //{
        //    int[] dane = new int[200];
        //    int suma = 0;

        //    for(int i = 0; i < 200; i++)
        //    {
        //        dane[i] = i+1;
        //    }

        //    foreach(int i in dane)
        //    {
        //        suma += i;
        //    }

        //    Console.WriteLine("Suma liczb od 1 do 200 wynosi: " + suma);
        //}

        //--------------------------
        //Zadanie 2 // dodatkowe
        //--------------------------
        static void Main(string[] args)
        {
            int[] dane = new int[200];
            int suma = 0;

            for (int i = 0; i < 200; i++)
            {
                dane[i] = i + 1;
            }

            foreach (int i in dane)
            {
                suma += i;
            }

            Console.WriteLine("Suma liczb od 1 do 200 wynosi: " + suma);
        }
    }
}
