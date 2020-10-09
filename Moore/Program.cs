using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Moore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti n:");
            int n = int.Parse(Console.ReadLine());
            int rezultatul = (int)(Math.Log(n,2)*18);
            int ani = rezultatul / 12;
            int luni = rezultatul % 12;
            Console.WriteLine($"Puterea va fi de {n} ori mai mare decat in prezent peste {ani} ani si {luni} luni");

        }
    }
}
