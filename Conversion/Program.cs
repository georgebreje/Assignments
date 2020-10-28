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
using System.Dynamic;

namespace Conversion
{
    class Program
    {
        public static void CheckNumber(string number, int initBase)
        {
            foreach (char digit in number)
            {
                if (Char.IsDigit(digit))
                {
                    if ((int)digit - (int)'0' > initBase)
                    {
                        throw new Exception("Incorrect number");
                    }
                }
                else
                {
                    
                    if ( (int)Char.ToUpper(digit) - (int)'A' + 10 > initBase)
                    {
                        throw new Exception("Incorrect number");

                    }
                }
                if (digit != '.' && !Char.IsLetter(digit) && !Char.IsDigit(digit))
                {
                    throw new Exception("Incorrect input");
                }
            }
            string[] split = number.Split('.');
            if (split.Length > 2)
            {
                throw new Exception("Incorrect number");
            }
        }
        public static double ToBase10(string number,int initBase)
        {
            double suma = 0;
            string[] split = number.Split('.');
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
            return suma;
        }
        public static void TargetBase(double numberBase10,int targetBase)
        {
            double rest=0;
            double produs = numberBase10-(int)numberBase10;
            int numberBase10Int = (int)numberBase10;
            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();
            while(numberBase10Int!=0)
            {
                rest = numberBase10Int % targetBase;
                numberBase10Int = (int)(numberBase10Int / targetBase);
                if (rest >= 10)
                    stack.Push((char)(rest + (int)'A'));
                else
                    stack.Push((char)(rest + (int)'0'));
            }
            while (stack.Count > 0)
            {
               Console.Write(stack.Pop());
            }
            if (numberBase10 - (int)numberBase10 != 0)
                Console.Write('.');
            while(produs-(int)produs!=0)
            {
                produs = (produs - (int)produs) * targetBase;
                if ((int)produs >= 10)
                    queue.Enqueue((char)((int)produs + (int)'A'));
                else
                    queue.Enqueue((char)((int)produs + (int)'0'));
            }
            while(queue.Count>0)
            {
                Console.Write(queue.Peek());
                queue.Dequeue();
            }
        }
        public static void Main(string[] args)
        {
            Console.Write("Convert the number ");
            string number = Console.ReadLine();
            Console.Write("from base ");
            int initBase = int.Parse(Console.ReadLine());
            CheckNumber(number, initBase);
            Console.Write("to base ");
            int targetBase = int.Parse(Console.ReadLine());
            double numberBase10 = ToBase10(number, initBase);
            TargetBase(numberBase10,targetBase);
        }
    }
}
