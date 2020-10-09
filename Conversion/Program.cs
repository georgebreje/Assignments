using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int parteIntreaga = (int)n;
            double parteFractionara = n - (int)n;
            int rest;
            int numarBinar;
            int numarZecimale=0;
            Stack parteIntreagaBinar = new Stack(); // stiva pentru afisare in ordine a valorii binare
            while (parteIntreaga!=0)
            {
                rest = parteIntreaga - (2 * (int)(parteIntreaga / 2)); //pe baza faptului ca se imparte doar la 2 am gasist formula n-2*(n/2) = restul
                parteIntreagaBinar.Push(rest);
                parteIntreaga = (int)(parteIntreaga / 2);
            }
            while(parteIntreagaBinar.Count!=0)
            {
                Console.Write(parteIntreagaBinar.Peek());
                parteIntreagaBinar.Pop();
            }
            //Console.WriteLine($"{parteFractionara}");
            while(parteFractionara>0)
            {
                parteIntreaga = parteIntreaga * 10; // nu imi afiseaza nimic
                numarZecimale = numarZecimale + 1;
            }
            Console.WriteLine(numarZecimale);

            }
        }
    }
