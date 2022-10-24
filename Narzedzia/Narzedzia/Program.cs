using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narzedzia
{
    public class RandomUtility 
    { 
        public int RandomInt(int a, int b)
        {
            Random r = new Random();
            int wynik = r.Next(a,b);
            return wynik;
        }
        public double RandomDouble (int a, int b)
        {
            Random r = new Random();
            double wynik = (r.NextDouble() + a ) * b;
            return wynik;
        }
        public double RandomDecimal(int a)
        {
            Random r = new Random();
            double wynik = (r.NextDouble()) * a;
            return wynik;
        }
        public string RandomString (int n)
        {
            Random r = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            char[] stringChars = new char[n];
            string wynik = "";
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[r.Next(chars.Length)];
                wynik+=stringChars[i];
            }
            return wynik;
        }
        public void RandomFromArray(int n, int[] arr, bool rep)
        {
            List<int> temp = new List<int>();
            Random r = new Random();
            bool powtorzenie = false;
            for(int i = 0; i < n; i++)
            {
                if (rep == false)
                {
                    int pozycja = r.Next(0, arr.Length);
                    Console.WriteLine(arr[pozycja]);
                }
                else
                {
                    int pozycja = r.Next(0, arr.Length);
                    for(int j = 0; j < temp.Count; j++)
                    {
                        if (temp[j] == arr[pozycja])
                        {
                            powtorzenie = true;
                        }
                    }   
                    if(powtorzenie == false)
                    {
                        Console.WriteLine(arr[pozycja]);
                        temp.Add(arr[pozycja]);
                    }
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomUtility ru = new RandomUtility();
            Console.WriteLine(ru.RandomInt(1, 10));
            Console.WriteLine(ru.RandomDouble(1, 10));
            Console.WriteLine(ru.RandomDecimal(1));//nie wiem dokładnie jak to zrobić ponieważ liczby dziesiętne to int'y więc zrobiłem że znawsze jest mniejsze niż 0
            Console.WriteLine(ru.RandomString(10));
            int[] arr = { 1,2,3,4,5,6 };
            ru.RandomFromArray(5, arr, true);
            Console.ReadKey();
        }
    }
}
