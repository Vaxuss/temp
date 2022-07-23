using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walec
{
    internal class Program
    {
        static int Main()
        {
            double pole, obj;
            Console.WriteLine("Podaj wysokość walca: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj promień podstawy walca: ");
            double r = Convert.ToDouble(Console.ReadLine());
            if(h < 0 || r < 0)
            {
                Console.WriteLine("Podano złe warości wciśnij enter by podać je ponownie");
                Console.ReadLine();
                return Main();
            }
            else
            {
                pole = (2 * Math.PI * r * r) + (2 * Math.PI * r * h);
                obj = Math.PI * Math.Pow(r, 2) * h;
            }
            Console.WriteLine("Pole: " + pole + " Objętość: " + obj);
            Console.ReadLine();
            return 0;
        }
    }
}
