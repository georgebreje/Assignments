using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices;
using System.IO; // pentru string
using System.Security;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //introducere
            Console.WriteLine("------------------------");
            Console.WriteLine("     Base converter");
            Console.WriteLine("------------------------");
            Console.WriteLine("Introduceti baza din care vreti sa convertiti");
            string bazaInit = Console.ReadLine();
            Console.WriteLine("Introduceti baza in care vreti sa convertiti");
            int bazaTinta = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul pe care vreti sa il convertiti");
            string numar = Console.ReadLine();
            //sfarsit introducere
            //trebuie sa aflam cate caractere sunt inainte si dupa punct
            string[] split = numar.Split('.');
            string parteIntreaga = split[0];
            string parteFract = split[1];

        }
    }
}