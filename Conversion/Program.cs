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
            int nrCifreInt = 0;
            int nrCifreFract = 0;
            double sumaInt = 0;
            double suma = 0;
            //splitting the number in fractional and integer
            string[] split = numar.Split('.');
            if (split.Length > 1)
            {
                parteIntreaga = split[0];
                parteFract = split[1];
                nrCifreInt = parteIntreaga.Length;
                nrCifreFract = parteFract.Length;
                // sumaInt is used to calculate the integer's part converted value
                // using ascii code for each character of the string the variable "sumaInt" 
                // is getting values with the help of the polynomial formula for "base x to base 10 conversion"
                foreach (char cifra in parteIntreaga)
                {
                    if (Char.IsDigit(cifra) && nrCifreInt >= 0)
                    {
                        --nrCifreInt;
                        sumaInt = sumaInt + ((int)cifra - 48) * Math.Pow(bazaInit, nrCifreInt);
                    }
                    else
                    {
                        --nrCifreInt;
                        sumaInt = sumaInt + ((int)cifra - 55) * (int)Math.Pow(bazaInit, nrCifreInt);

                    }
                }
                double sumaFr = 0;
                nrCifreFract = nrCifreFract * -1;
                int counter = -1;
                foreach (char cifraFr in parteFract)
                {
                    if (Char.IsDigit(cifraFr))
                    {
                        sumaFr = sumaFr + ((int)cifraFr - 48) * (Math.Pow(bazaInit, counter));
                        counter--;

                    }
                    else
                    {
                        sumaFr = sumaFr + ((int)cifraFr - 55) * (Math.Pow(bazaInit, counter));
                        counter--;
                    }
                }
                suma = sumaInt + sumaFr;
            }
            else //in case of a number without a fractional part
            {
                parteIntreaga = numar;
                nrCifreInt = parteIntreaga.Length;
                parteFract = null;
                nrCifreFract = 0;
                foreach (char cifra in parteIntreaga)
                {
                    if (Char.IsDigit(cifra) && nrCifreInt >= 0)
                    {
                        --nrCifreInt;
                        sumaInt = sumaInt + ((int)cifra - 48) * Math.Pow(bazaInit, nrCifreInt);
                    }
                    else
                    {
                        --nrCifreInt;
                        sumaInt = sumaInt + ((int)cifra - 55) * (int)Math.Pow(bazaInit, nrCifreInt);
                    }
                }
                suma = sumaInt;
            }
            //variable suma is the new number in base 10
            //if target base is different of base 10 suma will be separated in integer and fractional part
            //in the same context the algorithm "base 10 to target base" will be applied
        }
    }
}