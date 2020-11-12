using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace pool3
{
    class Program
    {
        static void Main(string[] args)
        {
            //problema1();
            //problema2();
            //problema3();
            problema4();
        }

        private static void problema4()
        {

        }

        private static void problema3()
        {
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            int max;
            int min;
            int count = 0;
            for(int i=0;i<n;i++)
                A[i]= int.Parse(Console.ReadLine());
            min = max=A[0];
            for (int i = 1; i < n ; i++)
            {
                if (A[i] < min)
                    min = A[i];
                else if (A[i] > max)
                    max = A[i];
            }
            Console.WriteLine($"min {min} max {max}");
        }
        private static void problema2()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int k = int.Parse(Console.ReadLine());
            int ok = 0;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < n && ok == 0; i++)
            {
                if (v[i] == k)
                {
                    ok = 1;
                    Console.WriteLine(i);
                }
            }
            if (ok == 0)
                Console.WriteLine("-1");
        }

        private static void problema1()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                s += v[i];
            }
            Console.WriteLine(s);
        }
    }
}
