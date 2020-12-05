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
        private static void Addition()
        {
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter equation (use s character for square root)");
            ReadNumbers();
        }
        private static void ReadNumbers()
        {
            string line = Console.ReadLine();
            string[] split = line.Split('+', '-', '*', '/', '^', 's');
            string substituteSplit = "";
            int[] vector = new int[] { };
            for(int i=0;i<split.Length;i++)
            {
                substituteSplit = split[i];
                vector=SplittedTransform(substituteSplit);
                for (int j = 0; j < vector.Length; j++)
                {
                    Console.Write($"vector[{j}]= "+vector[j]+" ");
                }
            }
        }
        
        static int[] SplittedTransform(string stringArr)
        {
            int[] constant = new int[stringArr.Length];
            int i = 0;
            foreach(char digit in stringArr)
            {
                    constant[i] = (int)digit-(int)'0';
                    i++;
            }
            return constant;
        }
    }
}
