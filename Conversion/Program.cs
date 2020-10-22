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
                foreach (char cifra in parteIntreaga)       // the same algorithm is applied for sumaFr
                {                                           //if there is a fractional part of the number
                    if (Char.IsDigit(cifra) && nrCifreInt >= 0)         
                    {
                        --nrCifreInt;
                        //sumaInt = sumaInt + ((int)cifra - 48) * Math.Pow(bazaInit, nrCifreInt);
                        sumaInt = sumaInt * bazaInit + ((int)cifra - (int)'0');
                    } 
                    else
                    {
                        --nrCifreInt;
                        //sumaInt = sumaInt + ((int)cifra - 55) * (int)Math.Pow(bazaInit, nrCifreInt);
                        sumaInt = sumaInt * bazaInit + ((int)cifra - (int)'A'+10);
                    }
                }
                double sumaFr = 0;
                int counter = -1;
                foreach (char cifraFr in parteFract)
                {
                    if (Char.IsDigit(cifraFr))
                    {
                        sumaFr = sumaFr + ((int)cifraFr - (int)'0') * (Math.Pow(bazaInit, counter));
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
            else //in case of a number without a fractional part the program applies the same algorithm but
            {                                                           //only for the integer part
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
            //in the same case the algorithm "base 10 to target base" will be applied
            if(bazaTinta==10)
                Console.WriteLine("Result: " + suma);
            else
            {
                int parteIntS = (int)suma;
                double parteFrS = suma - (int)suma;
                int rest;
                double produs=0;
                Stack<char> stInt = new Stack<char>();
                Queue<char> qFr = new Queue<char>();
                while(parteIntS!=0)
                {
                    rest = parteIntS % bazaTinta; // conversion realised by calculating the modulo 
                    if (rest >= 10)                         // of the integer part and target base
                        stInt.Push((char)(rest + 55));
                    else
                        stInt.Push((char)(rest+(int)'0'));
                    parteIntS = (int)(parteIntS / bazaTinta); //add values of the rest to the stack while integer part
                }                                                           //can be divided
                if (parteFrS != 0)          
                {
                    produs = parteFrS * bazaTinta;  // conversion realised by calculating the result of the
                    if (produs >= 10)               // multiplication of fractional part by target base
                        qFr.Enqueue((char)(produs + 55));
                    else
                        qFr.Enqueue((int)produs);
                    parteFrS = produs - (int)produs;  // using a queue because of the principle of the most significant bit
                }
                Console.WriteLine("Result:");
                while((produs-(int)produs)!=0)  // for the condition to exist, a first step had to be done
                {
                    produs = parteFrS * bazaTinta;      // the same formula is applied until the integer part of the result
                    qFr.Enqueue((int)produs);                                   //is 0
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
                        qFr.Dequeue();0
                    }
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}