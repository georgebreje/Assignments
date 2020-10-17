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
            int bazaInit = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti baza in care vreti sa convertiti");
            int bazaTinta = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul pe care vreti sa il convertiti");
            string numar = Console.ReadLine();
            //sfarsit introducere
            string parteIntreaga;
            string parteFract;
            int nrCifreInt=0;
            int nrCifreFract=0;
            string[] split = numar.Split('.');
            if (split.Length > 1)
            {
                parteIntreaga = split[0];
                parteFract = split[1];
                nrCifreInt = parteIntreaga.Length;
                nrCifreFract = parteFract.Length;
            }
            else
            {
                parteIntreaga = numar;
                parteFract = null;
                nrCifreFract = 0;
            }
            double suma = 0;
            foreach(char c in parteIntreaga)
            {
                if (Char.IsDigit(c)&&nrCifreInt>=0)
                {
                    suma = (int)c * Math.Pow(bazaInit, nrCifreInt - 1);
                    nrCifreInt--;
                }
            }
            Console.WriteLine(suma);
        }
    }
}