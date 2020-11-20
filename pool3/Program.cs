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
            //problema4();
            //problema5();
            //problema6();
            //problema7();
            //problema8();
            //problema9();
            //problema10();
            //problema11();
            //problema12();
            //problema13();
            //problema14();
            problema15();
        }

        private static void problema15()
        {
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            int nCopy = n;
            for (int i = 0; i < n; i++)
                A[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < n-2; i++)
            {
                for(int j=i+1;j<n-1;j++)
                {
                    while(A[i]==A[j])
                    {
                        A[i] = A[i + 1];
                        A[j] = A[j + 1];
                    }

                }
            }
                for (int i = 0; i < n; i++)
                Console.Write($"{A[i]} ");
        }

        private static void problema14()
        {
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
                A[i] = int.Parse(Console.ReadLine());
            int aux = 0;
            int j = n - 1;
            for (int i = 0; i <= j; i++)
            {
                if (A[i] == 0)
                {
                    while (A[j] == 0)
                    {
                        j--;
                    }
                    aux = A[i];
                    A[i] = A[j];
                    A[j] = aux;
                }
                j--;
            }
            for (int i = 0; i < n; i++)
                Console.Write($"{A[i]} ");
        }
        private static void problema13()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int copy = a[i];
                int j = i - 1;
                while (j >= 0 && a[j] > copy)
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = copy;
            }
            for (int i = 0; i < n; i++)
                Console.WriteLine($"{a[i]} ");
        }

        private static void problema12()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (a[j] < a[min_idx])
                        min_idx = j;
                int aux = a[min_idx];
                a[min_idx] = a[i];
                a[i] = aux;
            }
            for (int i = 0; i < n; i++)
                Console.WriteLine($"{a[i]} ");
        }

        private static void problema11()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = 0;
            a[0] = 1;
            a[1] = 1;
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (a[i] == 0)
                {
                    for (int j = 2; j < n / i; j++)
                        a[i * j] = 1;
                }
            }
            for (int i = 0; i < n; i++)
                if (a[i] == 0)
                    Console.WriteLine(i + " ");
        }

        public static object CautareBinara(int[] A, int k, int left, int right)
        {
            if (left > right)
                return -1;
            else
            {
                int mid = (left + right) / 2;
                if (k == A[mid])
                    return mid++;
                else
                {
                    if (A[mid] == k)
                        return mid;
                    if (k < A[mid])
                        return CautareBinara(A, k, left, mid - 1);
                    else
                        return CautareBinara(A, k, mid + 1, right);
                }
            }
        }
        public static void problema10()
        {
            Console.WriteLine("k,n,vector");
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
                A[i] = int.Parse(Console.ReadLine());
            Console.WriteLine(CautareBinara(A, k, 0, n - 1));
        }
        private static void problema9()
        {
            Console.WriteLine("k,n,vector");
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
                A[i] = int.Parse(Console.ReadLine());
            int j = 0;
            int aux;
            for (j = 0; j < k; j++)
                for (int i = 0; i < n - 1; i++)
                {
                    aux = A[i];
                    A[i] = A[i + 1];
                    A[i + 1] = aux;
                }

            for (int i = 0; i < n; i++)
                Console.Write($"{A[i]} ");
        }

        private static void problema8()
        {
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
                A[i] = int.Parse(Console.ReadLine());
            int aux;
            for (int i = 0; i < n - 1; i++)
            {
                aux = A[i];
                A[i] = A[i + 1];
                A[i + 1] = aux;
            }

            for (int i = 0; i < n; i++)
                Console.Write($"{A[i]} ");
        }

        private static void problema7()
        {
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
                A[i] = int.Parse(Console.ReadLine());
            int j = n - 1;
            int aux;
            for (int i = 0; i <= j; i++)
            {
                aux = A[i];
                A[i] = A[j];
                A[j] = aux;
                j--;
            }
            for (int i = 0; i < n; i++)
                Console.Write($"{A[i]} ");
        }

        private static void problema6()
        {
            Console.WriteLine("n,k,vector");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] A = new int[n + 1];
            for (int i = 0; i < n; i++)
                A[i] = int.Parse(Console.ReadLine());
            for (int i = k; i < n - 1; i++)
                A[i] = A[i + 1];
            n = n - 1;
            for (int i = 0; i < n; i++)
                Console.WriteLine($"{A[i] }");

        }

        private static void problema5()
        {
            Console.WriteLine("n,e,k,vector");
            int n = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] A = new int[n + 1];
            for (int i = 0; i < n; i++)
                A[i] = int.Parse(Console.ReadLine());
            for (int i = n - 1; i > k - 1; i--)
                A[i + 1] = A[i];
            n = n + 1;
            A[k] = e;
            for (int i = 0; i < n; i++)
                Console.WriteLine($"{A[i]} ");
        }

        private static void problema4()
        {
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            int[] F = new int[100000];
            for (int i = 0; i < F.Length; i++)
                F[i] = 1;
            int max;
            int min;
            for (int i = 0; i < n; i++)
                A[i] = int.Parse(Console.ReadLine());
            min = max = A[0];
            for (int i = 1; i < n; i++)
            {

                if (A[i] < min)
                {
                    min = A[i];
                }
                else if (A[i] == min)
                    F[min]++;
                else if (A[i] > max)
                {
                    max = A[i];
                }
                else if (A[i] == max)
                    F[max]++;


            }
            Console.WriteLine($"minim {min} apare de {F[min]} ori");
            Console.WriteLine($"max {max} apare de {F[max]} ori");
        }

        private static void problema3()
        {
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            int max;
            int min;
            int count = 0;
            for (int i = 0; i < n; i++)
                A[i] = int.Parse(Console.ReadLine());
            min = max = A[0];
            for (int i = 1; i < n; i++)
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
