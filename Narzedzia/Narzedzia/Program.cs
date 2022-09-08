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
                if (!rep)
                {
                    int pozycja = r.Next(arr.Length,1);
                    Console.WriteLine(arr[pozycja]);
                }
                else
                {
                    temp.Add(r.Next(arr.Length, 1));
                    for(int j = 0; j < temp.Count; j++)
                    {
                        for(int k = 0; k < temp.Count; k++)
                        {
                            if (temp[j] == temp[k])
                            {
                                powtorzenie = true;
                            }
                        }
                    }   
                    if(powtorzenie == false)
                    {
                        Console.WriteLine(temp[i]);
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
            Console.WriteLine(ru.RandomInt(1, 5));
            Console.WriteLine(ru.RandomDouble(1, 1));
            Console.WriteLine(ru.RandomDecimal(1));//nie wiem dokładnie jak to zrobić ponieważ liczby dziesiętne to int'y więc zrobiłem że znawsze jest mniejsze niż 0
            Console.WriteLine(ru.RandomString(10));
            int[] arr = { 1,2,3,4,5,6 };
            ru.RandomFromArray(5, arr, false);
            Console.ReadKey();
        }
    }
}
