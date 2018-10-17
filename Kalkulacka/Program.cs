using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulacka
{
    class Program
    {
        static void Main(string[] args)
        {
            Kalkulacka kalkulacka = new Kalkulacka();
            Console.WriteLine("Zadej 1. číslo: ");
            kalkulacka.a= float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej 2. číslo: ");
            kalkulacka.b = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Sucet: {0}", kalkulacka.Sucet());
            Console.WriteLine("Rozdiel: {0}", kalkulacka.Rozdiel());
            Console.WriteLine("Sucin: {0}", kalkulacka.Nasobenie());
            Console.WriteLine("Delenie: {0}", kalkulacka.Delenie());
            Console.ReadKey();
        }
    }
}
