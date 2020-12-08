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
            Console.WriteLine("Insert numbers and operation (for sqrt use s character)");
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
                    Addition(number1Arr, number2Arr);
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
            int maxLength=0;
            if (a.Length > b.Length)
                maxLength = a.Length;
            else
                maxLength = b.Length;
            int n = maxLength + 1;
            int[] sum = new int[n];
            int j = b.Length - 1;
            int i = a.Length - 1;
            int k = a.Length;
            while (i >= 0 && j >= 0)
            {
                sum[k] += (a[i] + b[j]) % 10;
                if ((a[i] + b[j]) / 10 != 0)
                {
                    sum[k - 1]++;
                }
                else if ((a[i] + b[j]) / 10 != 0 && k == 1)
                {
                    n--;
                }

                i--;
                j--;
                k--;
            }
            if(i!=0)
            {
                while (i >= 0)
                {
                    sum[k] += a[i];
                    i--;
                    k--;
                }
            }
            if (j != 0)
            {
                while (j >= 0)
                {
                    sum[k] += b[j];
                    j--;
                    k--;
                }
            }
            for (int l = 1; l < n; l++)
                Console.Write(sum[l]);
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
