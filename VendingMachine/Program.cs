using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            int coinValue = 0;
            int machineState = 0;
            int productNumber = 0;
            string readCoinType;
            string keyProducts="";
            string keyChange = "";
            bool ok = true;
            Stack<int> stack = new Stack<int>();
            while (true)
            {
                readCoinType = Console.ReadLine().ToUpper();
                if (readCoinType == "N")
                    coinValue = 5;
                else if (readCoinType == "D")
                    coinValue = 10;
                else if (readCoinType == "Q")
                    coinValue = 25;
                else
                    throw new Exception("The vending machine accepts only 5, 10 or 25 cents");
                machineState += coinValue;
                stack.Push(machineState);
               while(stack.Peek()>=20)
                {
                    if(machineState-20==20)   // 40-20 = 20 (ask client to choose change or one more product) hard coded method
                    {
                        machineState -= 20;
                        Console.WriteLine("Press x for another product c for change ");
                        string key = Console.ReadKey().Key.ToString();
                        if (key.ToUpper() == "X")
                        {
                            machineState -= 20;
                            stack.Push(machineState);
                            Console.WriteLine("\nPick up product");

                        }
                        else if(key.ToUpper() == "C")
                        {
                            machineState -= 20;
                            stack.Push(machineState);
                            Console.WriteLine("\nPick up change");
                        }
                    }
                    else
                    {
                        machineState -= 20;
                        if(machineState!=0)
                            Console.WriteLine($"\nPick up product and the change worth {machineState} cents");
                        else
                            Console.WriteLine($"\nPick up product");
                        machineState = 0;
                        stack.Push(0);
                    }
                }
            }
        }
    }
}
