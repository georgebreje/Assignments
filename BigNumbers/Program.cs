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
        public struct BigInteger : 

        static void ReadOperation()
        {
            ConsoleKeyInfo input = Console.ReadKey();
            switch (input.KeyChar)
            {
                case '1':
                    Addition();
                    break;
                case '2':
                    Substraction();
                    break;
                case '3':
                    Multiplication();
                    break;
                case '4':
                    Division();
                    break;
                case '5':
                    Exponentiation();
                    break;
                case '6':
                    SquareRoot();
                    break;
                default:
                    Console.WriteLine("Choose a number from 1 to 6");
                    break;


            }
        }

        private static void Addition()
        {
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Select operation by pressing its designated key");
            Console.WriteLine("1 -> addition");
            Console.WriteLine("2 -> substraction");
            Console.WriteLine("3 -> multiplication");
            Console.WriteLine("4 -> division");
            Console.WriteLine("5 -> exponentiation");
            Console.WriteLine("6 -> square root");
            ReadOperation();
            Console.WriteLine("Enter numbers on the same line with space separator");
            ReadNumbers();
        }

        private static void ReadNumbers()
        {
            BigInteger number = 
            string line = Console.ReadLine();
            string[] split = line.Split(' ');
            for(int i=0;i<split.Length;i++)
            {

            }
        }
    }
}
