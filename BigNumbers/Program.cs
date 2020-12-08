using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BigNumbers
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("The program calculates + - * / ^ sqrt of two numbers");
            Console.WriteLine("Insert numbers and operation");
            ReadNumbers();
        }

        private static void ReadNumbers()
        {
            string number1 = Console.ReadLine();
            CheckExceptionsNumber(number1);
            string number2 = Console.ReadLine();
            CheckExceptionsNumber(number2);
            char operation = char.Parse(Console.ReadLine());
            CheckExceptionsOperation(operation);
            int[] number1Arr = new int[] { };
            int[] number2Arr = new int[] { };
            number1Arr = StringTransformToInt(number1);
            number2Arr = StringTransformToInt(number2);
            switch (operation)
            {
                case '+':
                    Addition(number1Arr,number2Arr);
                    break;
                default:
                    break;

            }

        }
        static void CheckExceptionsOperation(char operation)
        {
            if (operation != '-' && operation != '+' && operation != '*' && operation != '/' && operation != 's')
                throw new Exception("Incorrect operation");
        }
        static void CheckExceptionsNumber(string number)
        {
            foreach (char c in number)
            {
                if (Char.IsDigit(c) == false)
                    throw new Exception("Incorrect input");
            }
        }
        private static void Addition(int[] a,int[] b)
        {
            Console.WriteLine("am ajuns la adunare");
        }

        //convert to int each digit
        static int[] StringTransformToInt(string stringArr)
        {
            int[] constant = new int[stringArr.Length];
            int i = 0;
            foreach (char digit in stringArr)
            {
                constant[i] = (int)digit - (int)'0';
                i++;
            }
            return constant;
        }
    }
}
