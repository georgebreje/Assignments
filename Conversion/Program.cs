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
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Conversion
{
    class Program
    {
        static void checkNumber(string number,int initBase)
        {
            foreach (char digit in number)
                if (Char.IsDigit(digit))
                { 
                    if ((int)digit - (int)'0' > initBase)
                        throw new Exception("Incorrect number");
                }
                else
                {
                    if ((int)digit - (int)'A'+10 > initBase)
                        throw new Exception("Incorrect number");
                }

        }
        static void Main(string[] args)
        {
            Console.Write("Convert the number ");
            string number = Console.ReadLine();
            Console.Write("from base ");
            int initBase = int.Parse(Console.ReadLine());
            Console.Write("to base ");
            int targetBase = int.Parse(Console.ReadLine());
            checkNumber(number, initBase);
            double suma = 0;
        }
    }
}
