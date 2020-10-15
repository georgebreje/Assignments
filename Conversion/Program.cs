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
            Console.WriteLine("Introduceti baza din care vreti sa convertiti");
            int bazaInitiala = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti baza in care vreti sa convertiti");
            int bazaTinta = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul pe care vreti sa il convertiti");
            double n = double.Parse(Console.ReadLine());
            int parteIntreaga = (int)n;
            double parteFractionara = n - (int)n;
            int rest;
            double produs = 0;
            double parteFractionaraInitiala = n - (int)n;
            Stack parteIntreagaConv = new Stack(); // stiva pentru afisare in ordine a valorii binare
            Queue parteFractionaraConv = new Queue();
            if (bazaInitiala == 10) 
            {
                if (bazaTinta == 2)
                {
                    while (parteIntreaga != 0)
                    {
                        rest = (int)(parteIntreaga / 2); //pe baza faptului ca se imparte doar la 2 am gasist formula n-2*(n/2) = restul
                        parteIntreagaConv.Push(rest);
                        parteIntreaga = (int)(parteIntreaga / 2);
                    }
                    while (parteIntreagaConv.Count != 0)
                    {
                        Console.Write(parteIntreagaConv.Peek());
                        parteIntreagaConv.Pop();
                    }
                    Console.Write("."); // despartirea partii intregi de cea fractionara
                    bool ok = true;
                    while (produs != 1 && ok == true)
                    {
                        produs = parteFractionara * 2;
                        //Console.Write($"{(int)produs}"); // afisare 0 / 1
                        parteFractionaraConv.Enqueue((int)produs);
                        parteFractionara = produs - (int)produs;
                        if (parteFractionara - 0.0000000001 < parteFractionaraInitiala
                            && parteFractionara + 0.0000000001 > parteFractionaraInitiala)
                        {
                            ok = false;
                            break;
                        }
                    }
                    if (ok == false && parteFractionaraInitiala != 0)
                    {
                        Console.Write("(");
                        while (parteFractionaraConv.Count != 0)
                        {

                            Console.Write($"{parteFractionaraConv.Peek()}");
                            parteFractionaraConv.Dequeue();
                        }
                        Console.Write(")");
                    }
                    else
                    {
                        while (parteFractionaraConv.Count != 0 && parteFractionaraInitiala != 0)
                        {
                            Console.Write($"{parteFractionaraConv.Peek()}");
                            parteFractionaraConv.Dequeue();
                        }
                    }
                }
                else //baza tinta diferita de 2
                {
                    
                }
            }
        }
    }
}
    