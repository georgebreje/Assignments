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
            //problema15();
            //problema16();
            //problema17();
            //problema18();
            //problema19();
            //problema20();
            //problema21();
            problema22();
            //problema23();
            //problema24();
            //problema25();
        }

        private static void problema25()
        {
            Console.WriteLine("n,vector1");
            int n = int.Parse(Console.ReadLine());
            int[] v1 = new int[n];
            for (int i = 0; i < n; i++)
                v1[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("m,vector2");
            int m = int.Parse(Console.ReadLine());
            int[] v2 = new int[m];
            for (int i = 0; i < m; i++)
                v2[i] = int.Parse(Console.ReadLine());
            int[] v3 = new int[n + m];
            int l = 0, j = 0,k=0;
            while(l<n && j<m)
            {
                if(v1[l]<v2[j])
                {
                    v3[k] = v1[l];
                    k++;
                    l++;
                }
                else
                {
                    v3[k] = v2[j];
                    k++;
                    j++;
                }
            }
            if(l<n)
            {
                for(int p=l;p<n;p++)
                {
                    v3[k] = v1[p];
                    k++;
                }
            }
            if (j < m)
            {
                for (int p = j; p < m; p++)
                {
                    v3[k] = v2[p];
                    k++;
                }
            }
            Console.WriteLine(k);
            Afisare(v3, k);
        }

        private static void problema24()
        {
            
        }

        private static void problema23()
        {

        }

        private static void problema22()
        {
            int n = 10;
            int[] v1 = new int[] { 1, 2, 4, 5, 5, 3, 5, 6, 1,13,1 };
            int m = 10;
            int[] v2 = new int[] {8,5,1,8,9,10,11,13,7,10 };
            int[] v3 = new int[n + m];
            int k = 0;
            for(int i=0;i<n;i++)
            {
                bool gasit = false;
                int x = v1[i];
                for(int j=0;j<m;j++)
                {
                    if (x == v2[j])
                        gasit = true;
                }
                if(gasit==true)
                {
                    v3[k] = v1[i];
                    k++;
                }    
            }
            
                Afisare(v3, k);
            /*rezolvare cu frecvente
            int[] frecv = new int[100000];
            int[] frecv1 = new int[100000];
            int[] frecv2 = new int[100000];
            for (int i = 0; i < 100000; i++)
            {
                frecv[i] = 0;
                frecv1[i] = 0;
                frecv2[i] = 0;
            }
            Console.WriteLine("n,vector1");
            int n = int.Parse(Console.ReadLine());
            int[] v1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                v1[i] = int.Parse(Console.ReadLine());
                frecv[v1[i]]++;
                frecv1[v1[i]]++;
            }
            Console.WriteLine("m,vector2");
            int m = int.Parse(Console.ReadLine());
            int[] v2 = new int[m];
            for (int i = 0; i < m; i++)
            {
                v2[i] = int.Parse(Console.ReadLine());
                frecv[v2[i]]++;
                frecv2[v2[i]]++;
            }
            int p = n + m;
            int[] v3 = new int[p];
            int j = 0;
            //reuniune

            for (int i = 0; i < 100000; i++)
            {
                while (frecv[i] > 1)
                {
                    if (frecv[i] == 1)
                        p--;
                    else
                        p--;
                    frecv[i]--;

                }
                if (frecv[i] == 1 || frecv[i] == 1)
                {
                    v3[j] = i;
                    j++;
                }
            }
            Console.WriteLine($"p = {p}");
            Console.WriteLine("Reuniune:");
            Afisare(v3, p);
            //intersectie
            p = n + m;
            int j1 = 0, ps = 0;
            int[] v4 = new int[p];

            for (int i = 0; i < 100000; i++)
            {
                if (frecv1[i] != 0 && frecv2[i] != 0)
                {
                    v4[j1] = i;
                    j1++;
                    ps++;
                }
            }
            Console.WriteLine("\nIntersectia:");
            Afisare(v4, ps);
            //diferenta v1/v2
            int[] v5 = new int[p];
            int j2 = 0,ps1=0;
            for (int i = 0; i < 10000; i++)
            {
                if (frecv1[i] != 0 && frecv2[i] == 0)
                { 
                    v5[j2] = i;
                    j2++;
                    ps1++;
                }
            }
            Console.WriteLine("\nDiferenta v1-v2");
            Afisare(v5, ps1);
            int[] v6 = new int[p];
            int j3 = 0, ps2 = 0;
            for (int i = 0; i < 10000; i++)
            {
                if (frecv1[i] == 0 && frecv2[i] != 0)
                {
                    v6[j3] = i;
                    j3++;
                    ps2++;
                }
            }
            Console.WriteLine("\nDiferenta v2-v1");
            Afisare(v6, ps2);*/
        }


        private static void problema21()
        {
            Console.WriteLine("n,vector1");
            int n = int.Parse(Console.ReadLine());
            int[] v1 = new int[n];
            Citire(v1, n);
            Console.WriteLine("m,vector2");
            int m = int.Parse(Console.ReadLine());
            int[] v2 = new int[m];
            Citire(v2, m);
            int nr = 0;
            if (n > m)
            {
                for (int i = 0; i < m; i++)
                {
                    if (v1[i] > v2[i])
                    {
                        Console.WriteLine("V2 este primul");
                        break;
                    }
                    else if (v2[i] > v1[i])
                    {
                        Console.WriteLine("V1 este primul");
                        break;
                    }
                    else if (v1[i] == v2[i])
                    {
                        nr++;
                    }
                }
                if (nr == m)
                {
                    Console.WriteLine("V2 este primul");
                }
            }
            else
            {
                for (int i = 0; i < m; i++)
                {
                    if (v2[i] > v1[i])
                    {
                        Console.WriteLine("V1 este primul");
                        break;
                    }
                    else if (v1[i] > v2[i])
                    {
                        Console.WriteLine("V2 este primul");
                        break;
                    }
                    else if (v1[i] == v2[i])
                    {
                        nr++;
                    }
                }
                if (nr == n)
                {
                    if (n == m)
                        Console.WriteLine("sunt egale");
                    else
                        Console.WriteLine("V1 este primul");
                }
            }
        }
        public static void Rotire(int[] A, int n)
        {
            int aux;
            for (int i = 0; i < n - 1; i++)
            {
                aux = A[i];
                A[i] = A[i + 1];
                A[i + 1] = aux;
            }
        }
        public static void Citire(int[] A, int n)
        {

            for (int i = 0; i < n; i++)
                A[i] = int.Parse(Console.ReadLine());
        }
        public static void Afisare(int[] A, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write($"{A[i]} ");
        }
        private static int CautareVector(int[] A, int[] B, int max, int min)
        {
            int nr = 0;
            for (int i = 0; i < max - min + 1; i++)
            {
                int j;
                for (j = 0; j < min && A[j + i] == B[j]; j++) { }
                if (j == min)
                    nr++;
            }
            return nr;
        }
        private static void problema20()
        {
            Console.WriteLine("n,vector1");
            int n = int.Parse(Console.ReadLine());
            int[] v1 = new int[n];
            Citire(v1, n);
            Console.WriteLine("m,vector2");
            int m = int.Parse(Console.ReadLine());
            int[] v2 = new int[m];
            Citire(v2, m);
            int nr = 0;
            if (n > m)
            {
                for (int i1 = 0; i1 < n - 1; i1++)
                {
                    if (CautareVector(v1, v2, n, m) != 0)
                    {
                        nr++;
                    }

                    Rotire(v1, n);
                    Console.WriteLine();
                    Console.WriteLine($"Vectorul dupa rotirea numarul {i1} este");
                    Afisare(v1, n);
                }
            }
            else
            {
                for (int i2 = 0; i2 < m - 1; i2++)
                {
                    if (CautareVector(v2, v1, m, n) != 0)
                    {
                        nr++;
                    }

                    Rotire(v2, m);
                    Console.WriteLine();
                    Console.WriteLine($"Vectorul dupa rotirea numarul {i2} este");
                    Afisare(v2, m);
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Numarul de suprapuneri margea cu margea este {nr}");
        }

        private static void problema19()
        {
            Console.WriteLine("lungime vector in care se cauta");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            Console.WriteLine("vector in care se cauta");
            for (int i = 0; i < n; i++)
                A[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("lungime vector care se cauta");
            int m = int.Parse(Console.ReadLine());
            int[] B = new int[m];
            Console.WriteLine("vector care se cauta");
            for (int i = 0; i < m; i++)
                B[i] = int.Parse(Console.ReadLine());
            int nr = 0;
            for (int i = 0; i < n - m + 1; i++)
            {
                int j;
                for (j = 0; j < m && A[j + i] == B[j]; j++) { }
                if (j == m)
                    nr++;
            }
            Console.WriteLine(nr);
        }

        private static void problema18()
        {
            Console.WriteLine("Introduceti gradul polinomului");
            int n = int.Parse(Console.ReadLine());
            int nCopy = n;
            Console.WriteLine("Introduceti punctul x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Coeficientii (n+1 coeficienti)");
            int[] coef = new int[n + 1];
            int suma = 0;
            for (int i = 0; i < n + 1; i++)
                coef[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < n + 1; i++)
            {
                suma += coef[i] * (int)(Math.Pow(x, nCopy));
                if (i < n)
                {
                    Console.Write($"{coef[i]}*{x}^{nCopy} + ");
                }
                else
                {
                    Console.Write($"{coef[i]}*{x}^{nCopy} =");
                }
                nCopy--;
            }
            Console.Write(suma);
        }

        private static void problema17()
        {
            Console.WriteLine("Numarul in baza 10");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Baza");
            int b = int.Parse(Console.ReadLine());
            int rest;
            int[] v = new int[n];
            int i = 0;
            while (n != 0)
            {
                rest = n % b;
                n = n / b;
                v[i] = rest;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
            {
                if (v[j] < 10)
                    Console.Write(v[j]);
                else if (v[j] >= 10)
                    Console.Write((char)(v[j] + (int)'A' - 10));
            }
        }

        private static void problema16()
        {
            int n = int.Parse(Console.ReadLine());
            int cmmdc = 0;
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
                A[i] = int.Parse(Console.ReadLine());
            cmmdc = A[0];
            for (int i = 1; i < n; i++)
            {
                int copie = A[i];
                while (copie != cmmdc)
                {
                    if (copie > cmmdc)
                        copie -= cmmdc;
                    else if (copie < cmmdc)
                        cmmdc -= copie;
                }

            }
            Console.WriteLine(cmmdc);
        }

        private static void problema15()
        {
            //varianta 2
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
                A[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (A[i] == A[j])
                    {
                        for (int k = j; k < n - 1; k++)
                        {
                            A[k] = A[k + 1];
                        }
                        n--;
                        j--;
                    }
                }
            }
            for (int i = 0; i < n; i++)
                Console.Write($"{A[i]} ");
            /* varianta in care niciun element care se repeta nu mai apare
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            bool ok = true;
            int nCopy = n;
            int poz = 0;
            for (int i = 0; i < n; i++)
                A[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                ok = true;
                for (int j = i + 1; j < n; j++)
                {
                    if (A[i] == A[j])
                    {
                        A[j] = 0;
                        ok = false;
                    }
                }
                if (ok == false)
                    A[i] = 0;
            }
            //Console.WriteLine("Vectorul modificat cu 0 in loc de cifrele care se repeta");
            //for (int i = 0; i < n; i++)
            //    Console.Write($"{A[i]} ");
            //Console.WriteLine();
            for (int i = n - 1; i >= 0; i--)
            {
                if (A[i] == 0)
                {
                    for (int j = i; j < n - 1; j++)
                        A[j] = A[j + 1];
                    n--;
                }
            }
            Console.WriteLine("Noul vector");
            for (int i = 0; i < n; i++)
                Console.Write($"{A[i]} ");*/
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
