using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices;
using System.IO; // pentru string
using System.Security;
using System.Reflection;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************************************************");
            Console.WriteLine("The program will convert your number from a base to another");
            Console.WriteLine("************************************************************");
            Console.Write("Convert the number ");
            string numar = Console.ReadLine();
            Console.Write("from base ");
            int bazaInit = int.Parse(Console.ReadLine());
            Console.Write("to base ");
            int bazaTinta = int.Parse(Console.ReadLine());
            double nrBaza10 = 0;
            int nrCifre=0;
            string[] split = numar.Split('.');
            if (split.Length > 1)
                nrCifre = numar.Length - 1;
            else
                if (split.Length <= 1)
                nrCifre = numar.Length;
            else
                if (split.Length > 2)
                    throw new Exception("Enter a number");
                foreach (char cifra in numar)    
                {                                
                    if (Char.IsDigit(cifra))         
                    {
                        --nrCifre;
                        nrBaza10 = nrBaza10 + ((int)cifra - (int)'0') * Math.Pow(bazaInit, nrCifre);
                    } 
                    else
                    {
                        --nrCifre;
                        nrBaza10 = nrBaza10 + ((int)cifra - (int)'A' + 10) * Math.Pow(bazaInit, nrCifre); 
                    }
                }
            //variable suma is the new number in base 10
            //if target base is different of base 10 suma will be separated in integer and fractional part
            //in the same case the algorithm "base 10 to target base" will be applied
            if(bazaTinta==10)
                Console.WriteLine("Result: " + nrBaza10);
            else
            {
                int parteIntS = (int)nrBaza10;
                double parteFrS = nrBaza10 - (int)nrBaza10;
                int rest;
                double produs=0;
                Stack<char> stInt = new Stack<char>();
                Queue<char> qFr = new Queue<char>();
                while(parteIntS!=0)
                {
                    rest = parteIntS % bazaTinta; // conversion realised by calculating the modulo 
                    if (rest >= 10)                         // of the integer part and target base
                        stInt.Push((char)(rest + (int)'A'));
                    else
                        stInt.Push((char)(rest+(int)'0'));
                    parteIntS = (int)(parteIntS / bazaTinta); //add values of the rest to the stack while integer part
                }                                                           //can be divided
                if (parteFrS != 0)          
                {
                    produs = parteFrS * bazaTinta;  // conversion realised by calculating the result of the
                    if (produs >= 10)               // multiplication of fractional part by target base
                        qFr.Enqueue((char)(produs + (int)'A'));
                    else
                        qFr.Enqueue((char)((int)produs+(int)'0'));
                    parteFrS = produs - (int)produs;  // using a queue because of the principle of the most significant bit
                }
                Console.WriteLine("Result:");
                while((produs-(int)produs)!=0)  // for the condition to exist, a first step had to be done
                {
                    produs = parteFrS * bazaTinta;      // the same formula is applied until the integer part of the result
                    qFr.Enqueue((char)((int)produs));                                   //is 0
                    parteFrS = produs - (int)produs;
                }
                while(stInt.Count!=0)   //displaying numbers from stack in order to form the integer part
                {
                    Console.Write(stInt.Peek());
                    stInt.Pop();
                }
                if (qFr.Count != 0)  //does not generate "." if there's no fractional part
                {
                    Console.Write("."); 
                    while (qFr.Count > 0)      //displaying values from queue to form the fractional part
                    {                                        
                        Console.Write(qFr.Peek());
                        qFr.Dequeue();
                    }
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
