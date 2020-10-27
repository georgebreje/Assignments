using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices;
using System.IO;
using System.Security;
using System.Reflection;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Runtime.CompilerServices;

namespace Conversion
{
    class Program
    {
        static void checkNumber(string number, int initBase)
        {
            bool flag;
            flag = true;
            foreach (char digit in number)
            {
                if (Char.IsDigit(digit))
                {
                    if ((int)digit - (int)'0' > initBase)
                    {
                        throw new Exception("Incorrect number");
                        return 1;
                    }
                }
                else
                {
                    if ((int)digit - (int)'A' + 10 > initBase)
                    {
                        throw new Exception("Incorrect number");
                        return 1;

                    }
                }
                if (!Char.IsDigit(digit) && digit != '.')
                {
                    throw new Exception("Incorrect input");
                    return 1;
                }
            }

            string[] split = number.Split('.');
            if (split.Length > 2)
            {
                throw new Exception("Incorrect number");
                return false;
            }
        }
        
    static void Main(string[] args)
    {
        Console.Write("Convert the number ");
            string number = checkNumber();
        Console.Write("from base ");
        int initBase = int.Parse(Console.ReadLine());
        Console.Write("to base ");
        int targetBase = int.Parse(Console.ReadLine());
        double suma = 0;
        string[] split = number.Split('.');
        Console.WriteLine(split[0]);
        int counter = split[0].Length - 1;
        foreach (char digit in number)
        {
            if (Char.IsDigit(digit) && digit != '.')
                suma = suma + ((int)digit - (int)'0') * Math.Pow(initBase, counter);
            else if (!Char.IsDigit(digit) && digit != '.')
                suma = suma + ((int)digit - (int)'A' + 10) * Math.Pow(initBase, counter);
            else if (digit == '.')
                counter = 0;
            counter--;
        }
    }
}
}
