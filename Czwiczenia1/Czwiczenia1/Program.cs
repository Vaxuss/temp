using System;

namespace Czwiczenia1
{
    class Program
    {
        // wszystkie zadania są zakomentowane oprócz ostatniego, by wszystko było w jednym pliku.

        //--------------------------------------
        //zadanie 1
        //--------------------------------------

        //static void Main(string[] args)
        //{
        //    string imie, nazwisko;
        //    Console.WriteLine("Podaj imie: ");
        //    imie = Console.ReadLine();
        //    Console.WriteLine("Podaj nazwisko: ");
        //    nazwisko = Console.ReadLine();

        //    Console.WriteLine("Twoje imie i nazwisko to: " + imie + " " + nazwisko);
        //}


        //--------------------------------------
        //zadanie 2
        //--------------------------------------

        //static void Main(string[] args)
        //{
        //    double a, b;
        //    Console.WriteLine("Podaj bok a: ");
        //    a = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Podaj bok b: ");
        //    b = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Pole prostokata wynosi: " + a*b);
        //}


        //--------------------------------------
        //zadanie 3
        //--------------------------------------

        //static void Main(string[] args)
        //{
        //    double kmh;
        //    Console.WriteLine("Program oblicza km/h na m/s: ");
        //    Console.WriteLine("Podaj prędkość w km/h: ");
        //    kmh = Convert.ToDouble(Console.ReadLine());
        //    kmh /= 3.6;
        //    Console.WriteLine("Przeliczona prędkość na m/s wynosi: " + System.Math.Round(kmh, 2));
        //}


        //--------------------------------------
        //zadanie 4
        //--------------------------------------

        //static void Main(string[] args)
        //{
        //    double r, pole, obwod;
        //    Console.WriteLine("Podaj promien r: ");
        //    r = Convert.ToDouble(Console.ReadLine());
        //    pole = Math.PI * r * r;
        //    obwod = 2 * Math.PI * r;
        //    Console.WriteLine("Pole kola o promieniu r = " + r + " wynosi: " + System.Math.Round(pole, 2));
        //    Console.WriteLine("Obwod kola o promieniu r = " + r + " wynosi: " + System.Math.Round(obwod, 2));
        //}


        //--------------------------------------
        //zadanie 5
        //--------------------------------------

        //static void Main(string[] args)
        //{
        //    double netto, brutto;
        //    Console.WriteLine("Podaj cene netto: ");
        //    netto = Convert.ToDouble(Console.ReadLine());
        //    brutto = netto * 1.22;
        //    Console.WriteLine("Cena brutto wynosi: " + System.Math.Round(brutto, 2));
        //    Console.WriteLine("Stawka vat wynosi: " + System.Math.Round(netto * 0.22, 2));
        //}


        //--------------------------------------
        //zadanie 6
        //--------------------------------------

        //static void Main(string[] args)
        //{
        //    int liczba;
        //    Console.WriteLine("Podaj swoją liczbe: ");
        //    liczba = Convert.ToInt32(Console.ReadLine());

        //    if (liczba % 2 == 0) Console.WriteLine("Liczba jest parzysta.");
        //    else Console.WriteLine("Liczba nie jest parzysta.");
        //}


        //--------------------------------------
        //zadanie 7 a) i b)
        //--------------------------------------

        //static void Main(string[] args)
        //{
        //    double waga, wzrost, bmi;
        //    Console.WriteLine("Podaj swoją wagę w kg: ");
        //    waga = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Podaj swoj wzrost w m: ");
        //    wzrost = Convert.ToDouble(Console.ReadLine());

        //    bmi = waga / (wzrost * wzrost);
        //    Console.WriteLine("Twoje BMI to: " + System.Math.Round(bmi, 2));

        //    //chciałem urzyć fajnie switcha ale mam za starą wersje c# na to i nie chce go aktualizować teraz :<;
        //    if(bmi < 16.0) Console.WriteLine("wygłodzenie");
        //    if (bmi < 17 && bmi >= 16.0) Console.WriteLine("wychudzenie");
        //    if (bmi < 18.5 && bmi >= 17.0) Console.WriteLine("niedowaga");
        //    if (bmi < 25 && bmi >= 18.5) Console.WriteLine("waga prawidłowa");
        //    if (bmi < 30 && bmi >= 25.0) Console.WriteLine("nadwaga");
        //    if (bmi < 35 && bmi >= 30) Console.WriteLine("otyłość I stopnia");
        //    if (bmi < 40 && bmi >= 35) Console.WriteLine("otyłość II stopnia");
        //    if (bmi >=40) Console.WriteLine("otyłość III stopnia");
        //}


        //--------------------------------------
        //zadanie 8
        //--------------------------------------

        //static void Main(string[] args)
        //{
        //    int day;
        //    Console.WriteLine("Wybierz liczbe od 1 do 7: ");
        //    day = Convert.ToInt32(Console.ReadLine());

        //    try
        //    {
        //        if (day < 1 || day > 7)
        //        {
        //            throw new IndexOutOfRangeException();
        //        }
        //    }
        //    catch(IndexOutOfRangeException)
        //    {
        //        Console.WriteLine("Wprowadź poprawną wartość następnym razem.");
        //    }

        //    switch (day)
        //    {
        //        case 1:
        //            Console.WriteLine("Wybrany dzień to: Poniedziałek");
        //            break;
        //        case 2:
        //            Console.WriteLine("Wybrany dzień to: Wtorek");
        //            break;
        //        case 3:
        //            Console.WriteLine("Wybrany dzień to: Środa");
        //            break;
        //        case 4:
        //            Console.WriteLine("Wybrany dzień to: Czwartek");
        //            break;
        //        case 5:
        //            Console.WriteLine("Wybrany dzień to: Piątek");
        //            break;
        //        case 6:
        //            Console.WriteLine("Wybrany dzień to: Sobota");
        //            break;
        //        case 7:
        //            Console.WriteLine("Wybrany dzień to: Niedziela");
        //            break;
        //    }
        //}


        //--------------------------------------
        //zadanie 9 wszystkie zadania z wykorzystaniem wszystkich pętli będą wyśiwietlać się po sobie by skrócić pracę;
        //--------------------------------------

        //static void Main(string[] args)
        //{
        //    int x = 0;
        //    Console.WriteLine("Pętla for: ");
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write(i + " ");       
        //    }

        //    Console.WriteLine("\nPętla while: ");
        //    while(x < 10)
        //    {
        //        Console.Write(x++ + " ");
        //    }
        //    x = 0;
        //    Console.WriteLine("\nPętla Do while: ");
        //    do
        //    {
        //        Console.Write(x++ + " ");
        //    }
        //    while (x < 10);
        //}

        //--------------------------------------
        //zadanie 10
        //--------------------------------------

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Program oblicza wartość funkci y = 3*x:");
        //    Console.WriteLine("dla x zmieniającego się od 0 do 10");
        //    int x = 0;
        //    Console.WriteLine("Pętla for: ");
        //    for (int i = 0; i < 11; i++)
        //    {
        //        Console.WriteLine("x = " + i + "  y = " + i*3);       
        //    }

        //    Console.WriteLine("\nPętla while: ");
        //    while(x < 11)
        //    {
        //        Console.WriteLine("x = " + x + "  y = " + x++ * 3);
        //    }
        //    x = 0;
        //    Console.WriteLine("\nPętla Do while: ");
        //    do
        //    {
        //        Console.WriteLine("x = " + x + "  y = " + x++ * 3);
        //    }
        //    while (x < 11);
        //}


        //--------------------------------------
        //zadanie 11
        //--------------------------------------

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Program sumuje liczby od 1 do 100");
        //    int x = 0, i = 1;

        //    Console.WriteLine("Pętla for: ");
        //    for (i = 1; i <= 100; i++)
        //    {
        //        x += i;      
        //    }
        //    Console.WriteLine("\nSuma liczb od 1 do 100 wynosi: " + x);

        //    Console.WriteLine("\nPętla while: ");
        //    x = 0;
        //    i = 1;
        //    while (i <= 100)
        //    {
        //        x += i++;
        //    }
        //    Console.WriteLine("\nSuma liczb od 1 do 100 wynosi: " + x);

        //    Console.WriteLine("\nPętla Do while: ");
        //    x = 0;
        //    i = 1;
        //    do
        //    {
        //        x += i++;
        //    }
        //    while (i <= 100);
        //    Console.WriteLine("\nSuma liczb od 1 do 100 wynosi: " + x);
        //}


        //--------------------------------------
        //zadanie 12
        //--------------------------------------

        //static void Main(string[] args)
        //{
        //     Console.WriteLine("Podaj swoją liczbe: ");
        //     int liczba = Convert.ToInt32(Console.ReadLine());
        //     int wynik = (liczba%2 == 0) ? 0 : 1;
        //     Console.WriteLine("Wynik: " + wynik);
        //}

        //--------------------------------------
        //zadanie 13
        //--------------------------------------

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbe: ");
            int liczba1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbe: ");
            int liczba2 = Convert.ToInt32(Console.ReadLine());
            int wynik = liczba1 > liczba2 ? liczba1 : liczba2;
            Console.WriteLine("Większa liczba to: " + wynik);
        }
    }
}
