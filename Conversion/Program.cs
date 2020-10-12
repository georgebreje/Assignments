using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices;

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
            double produs = 0;
            double parteFractionaraInitiala = n-(int)n;
            Stack parteIntreagaBinar = new Stack(); // stiva pentru afisare in ordine a valorii binare
            Queue parteFractionaraBinar = new Queue();
            while (parteIntreaga != 0)
            {
                rest = parteIntreaga - (2 * (int)(parteIntreaga / 2)); //pe baza faptului ca se imparte doar la 2 am gasist formula n-2*(n/2) = restul
                parteIntreagaBinar.Push(rest);
                parteIntreaga = (int)(parteIntreaga / 2);
            }
            while (parteIntreagaBinar.Count != 0)
            {
                Console.Write(parteIntreagaBinar.Peek());   
                parteIntreagaBinar.Pop();
            }
            Console.Write("."); // despartirea partii intregi de cea fractionara
            int i = 1;
            bool ok = true;


            while (produs != 1 && ok == true)
            {
                produs = parteFractionara * 2;
                //Console.Write($"{(int)produs}"); // afisare 0 / 1
                parteFractionaraBinar.Enqueue((int)produs);
                parteFractionara = produs - (int)produs;
                if (parteFractionara - 0.0000000001 < parteFractionaraInitiala
&& parteFractionara + 0.0000000001 > parteFractionaraInitiala)
                {
                    ok = false;
                    break;
                }
            }
            if(ok==false)
            {
                Console.Write("(");
                while(parteFractionaraBinar.Count!=0)
                {
                    
                    Console.Write( $"{parteFractionaraBinar.Peek()}");
                    parteFractionaraBinar.Dequeue();
                }
                Console.Write(")");
            }
            else
            {
                while (parteFractionaraBinar.Count != 0)
                {
                    Console.Write($"{parteFractionaraBinar.Peek()}");
                    parteFractionaraBinar.Dequeue();
                }
            }    

        }
    }
}
    