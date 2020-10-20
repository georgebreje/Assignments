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
            Console.Write("Convert from base ");
            int bazaInit = int.Parse(Console.ReadLine());
            Console.Write("to base ");
            int bazaTinta = int.Parse(Console.ReadLine());
            Console.Write("the number ");
            string numar = Console.ReadLine();
            string parteIntreaga;
            string parteFract;
            int nrCifreInt=0;
            int nrCifreFract=0;
            //splitting the number in fractional and integer
            string[] split = numar.Split('.');
            if (split.Length > 1)
            {
                parteIntreaga = split[0];
                parteFract = split[1];
                nrCifreInt = parteIntreaga.Length;
                nrCifreFract = parteFract.Length;
            }
            else //in case of a number without a fractional part
            {
                parteIntreaga = numar;
                nrCifreInt = parteIntreaga.Length;
                parteFract = null;
                nrCifreFract = 0;
            }
            double sumaInt = 0; // sumaInt is used to calculate the integer's part converted value
            // using ascii code for each character of the string the variable "sumaInt" 
            // is getting values with the help of the polynomial formula for "base x to base 10 conversion"
            foreach (char cifra in parteIntreaga)
            {
                if (Char.IsDigit(cifra) && nrCifreInt >= 0)
                {
                    --nrCifreInt;
                    sumaInt=sumaInt+ ((int)cifra - 48) * Math.Pow(bazaInit, nrCifreInt);
                }
                else
                {
                    --nrCifreInt;
                    sumaInt = sumaInt+ ((int)cifra - 55) * (int)Math.Pow(bazaInit, nrCifreInt);

                }
               // verificare sumaInt pt fiecare pas Console.WriteLine($"Suma pt pasul {nrCifreInt} este {sumaInt} ");
            }
        }
    }
}