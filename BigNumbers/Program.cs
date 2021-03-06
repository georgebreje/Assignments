﻿using System;

namespace BigNumbers
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("The program calculates + - * / ^ sqrt of two natural numbers");
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
                case '-':
                    Substraction(number1Arr, number2Arr);
                    break;
                case '*':
                    if (IsBigger(number1Arr, number2Arr) == true) // este nevoie de numarul mai mic prestabilit
                    {                                             
                        Multiplication(number1Arr, number2Arr);
                    }
                    else
                    {
                        Multiplication(number2Arr, number1Arr);
                    }
                    break;
                case '/':
                    Division(number1Arr, number2Arr);
                    break;
                default:
                    break;
            }
        }

        private static void Division(int[] number1Arr, int[] number2Arr)
        {

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
        private static void Multiplication(int[] a, int[] b)
        {
            int zeroValuePositionCount = 0, multipliedArrLength = a.Length+1;
            int[] sumArr = new int[3*a.Length+1];
            Array.Reverse(a);
            Array.Reverse(b);
            for (int i = 0; i < b.Length; i++)
            {
                int[] multipliedArr = new int[multipliedArrLength];
                zeroValuePositionCount = multipliedArrLength - a.Length - 1;
                int k = zeroValuePositionCount;
                int zeroIndex = 0;
                while (zeroValuePositionCount > 0)
                {
                    multipliedArr[zeroIndex] = 0;
                    zeroValuePositionCount--;
                }

                for (int l = 0; l < a.Length; l++)
                {
                    if((multipliedArr[k] + a[l] * b[i]) >= 10)
                    {
                        multipliedArr[k + 1] = (multipliedArr[k] + a[l] * b[i]) / 10;
                        multipliedArr[k] = (multipliedArr[k] + a[l] * b[i]) % 10;
                        k++;
                    }
                    else
                    {
                        multipliedArr[k] = (multipliedArr[k] + a[l] * b[i]) % 10;
                        k++;
                    }
                }
                for(int idx=0;idx<multipliedArrLength;idx++)
                {
                    if((sumArr[idx]+multipliedArr[idx])>=10)
                    {
                        sumArr[idx] = (sumArr[idx] + multipliedArr[idx]) % 10;
                        sumArr[idx + 1]++;
                    }
                    else
                    {
                        sumArr[idx] = (sumArr[idx] + multipliedArr[idx]) % 10;
                    }
                }
                multipliedArrLength++;
            }
            Array.Reverse(sumArr);
            int i2 = 0;
            while (sumArr[i2] == 0)
            {
                i2++;
            }
            for (int i = i2; i < sumArr.Length; i++)
                Console.Write(sumArr[i]);
        }

        private static void Substraction(int[] a, int[] b)
        {
            int maxLength = 0;
            if (a.Length > b.Length)
            {
                maxLength = a.Length;
            }
            else
            {
                maxLength = b.Length;
            }
            int[] dif = new int[maxLength];
            bool bigger = true;
            if (IsBigger(a, b) == true)
            {
                bigger = true;
                Array.Reverse(a);
                Array.Reverse(b);
                for (int i = 0; i < b.Length; i++)
                {
                    if (a[i] >= b[i])
                    {
                        dif[i] = a[i] - b[i];
                    }
                    else
                    {
                        dif[i] = (a[i] + 10) - b[i];
                        a[i + 1]--;
                    }
                }
                for (int i = b.Length; i < a.Length; i++)
                {
                    dif[i] = a[i];
                }
            }
            else
            {
                bigger = false;
                Array.Reverse(a);
                Array.Reverse(b);
                for (int i = 0; i < a.Length; i++)
                {
                    if (b[i] >= a[i])
                    {
                        dif[i] = b[i] - a[i];
                    }
                    else
                    {
                        dif[i] = (b[i] + 10) - a[i];
                        b[i + 1]--;
                    }
                }
                for (int i = a.Length; i < b.Length; i++)
                {
                    dif[i] = b[i];
                }
            }
            Array.Reverse(dif);
            int j = 0;
            while (dif[j] == 0)
            {
                j++;
            }
            if (bigger == false)
            {
                Console.Write("-");
            }
            for (int k = j; k < maxLength; k++)
            {
                Console.Write(dif[k]);
            }
        }

        private static bool IsBigger(int[] a, int[] b)
        {
            int aInt = 0, bInt = 0;
            for (int i = 0; i < a.Length; i++)
            {
                aInt = aInt * 10 + a[i];
            }
            for (int i = 0; i < b.Length; i++)
            {
                bInt = bInt * 10 + b[i];
            }
            if (aInt >= bInt)
                return true;
            else
                return false;
        }

        private static void Addition(int[] a, int[] b)
        {
            int minLength, maxLength;
            if (a.Length > b.Length)
            {
                minLength = b.Length;
                maxLength = a.Length + 1;
            }
            else
            {
                minLength = a.Length;
                maxLength = b.Length + 1;
            }
            Array.Reverse(a);
            Array.Reverse(b);
            int[] sum = new int[maxLength];
            for (int i = 0; i < minLength; i++)
            {
                if (sum[i] + a[i] + b[i] >= 10)
                {
                    sum[i] = (sum[i] + a[i] + b[i]) % 10;
                    sum[i + 1]++;
                }
                else
                {
                    sum[i] = (sum[i] + a[i] + b[i]) % 10;
                }
            }
            if (a.Length != b.Length)
            {
                for (int i = minLength; i < maxLength - 1; i++)
                {
                    if (a.Length > b.Length)
                    {
                        if (sum[i] + a[i] >= 10)
                        {
                            sum[i] = (sum[i] + a[i]) % 10;
                            sum[i + 1]++;
                        }
                        else
                        {
                            sum[i] = (sum[i] + a[i]) % 10;
                        }
                    }
                    else
                    {
                        if (sum[i] + b[i] >= 10)
                        {
                            sum[i] = (sum[i] + b[i]) % 10;
                            sum[i + 1]++;
                        }
                        else
                        {
                            sum[i] = (sum[i] + b[i]) % 10;
                        }
                    }
                }
            }
            Array.Reverse(sum);
            if (sum[0] != 0)
            {
                for (int i = 0; i < sum.Length; i++)
                {
                    Console.Write($"{sum[i]}");
                }
            }
            else
            {
                for (int i = 1; i < sum.Length; i++)
                {
                    Console.Write($"{sum[i]}");
                }
            }
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
