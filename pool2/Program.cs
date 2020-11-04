using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace pool2
{
    class Program
    {
        static void Main(string[] args)
        {
            problema1();
            problema2();
            problema3();
            problema4();
            problema5();
            problema6();
            problema7();
            problema8();
            problema9();
            problema10();
            problema11();
            problema12();
            problema13();
            problema14();
            problema15();
            problema16();
            problema17();
        }

        private static void problema17()
        {
            string sir = Console.ReadLine();
            int k = 0, ok = 1 ,nr=0,maxv=-1;
            foreach (char c in sir)
            {
                if (c == '0')
                    k++;
                else if (c == '1' && k > 0)
                    k--;
                else
                    ok = 0;
            }
            if(ok!=0 && k==0)
            {
                Console.WriteLine("Este corect parantezat");
                foreach(char c in sir)
                {
                    if (c == '0')
                        nr++;
                    else
                        nr--;
                    if (nr > maxv)
                        maxv = nr;
                }
                Console.WriteLine($"Incuibarea maxima este {maxv}");
            }
            else
                Console.WriteLine("nu este corect parantezat");
        }
        private static void problema16()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int ok = 1;
            int ok2 = 1;
            int ok1 = 0;
            int ok3 = 0;
            int count = n - 1;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int maxim = v[0], pozmax = 0; ;
            for (int i = 1; i < n; i++)
            {
                if (v[i] > maxim)
                {
                    maxim = v[i];
                    pozmax = i;
                }
            }
            for (int i = 1; i < pozmax; i++)
                if (v[i] >= v[i - 1])
                    ok++;
            if (ok != pozmax)
                Console.WriteLine("Nu este bitonica");
            else if (ok == pozmax)
            {
                for (int i = pozmax + 1; i < n - 1; i++)
                    if (v[i] < v[i + 1])
                        ok1++;
                if (ok1 == 0)
                    Console.WriteLine("Este bitonica");
                else
                {
                    for (int i = 0; i < n / 2; i++)
                    {
                        int aux = v[i];
                        v[i] = v[count];
                        v[count] = aux;
                        count--;
                    }
                    int maxim2 = v[0], pozmax2 = 0; ;
                    for (int i = 1; i < n; i++)
                    {
                        if (v[i] > maxim)
                        {
                            maxim2 = v[i];
                            pozmax2= i;
                        }
                    }
                    for (int i = 1; i < pozmax2; i++)
                        if (v[i] >= v[i - 1])
                            ok2++;
                    if (ok2 != pozmax2)
                        Console.WriteLine("Nu este bitonica rotita");
                    else if (ok2 == pozmax2)
                    {
                        for (int i = pozmax2 + 1; i < n - 1; i++)
                            if (v[i] < v[i + 1])
                                ok3++;
                    }
                    if (ok3 == 0)
                        Console.WriteLine("este bitonica rotita");
                    else
                        Console.WriteLine("nu este bitonica rotita");
                }
            }
        }

        private static void problema15()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int ok = 1;
            int ok1 = 0;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int maxim = v[0], pozmax = 0; ;
            for (int i = 1; i < n; i++)
            {
                if (v[i] > maxim)
                {
                    maxim = v[i];
                    pozmax = i;
                }
            }
            for (int i = 1; i < pozmax; i++)
                if (v[i] >= v[i - 1])
                    ok++;
            if(ok!=pozmax)
                Console.WriteLine("Nu este bitonica");
            else if(ok==pozmax)
            {
                for (int i = pozmax + 1; i < n - 1; i++)
                    if (v[i] < v[i + 1])
                        ok1++;
                if (ok1 == 0)
                    Console.WriteLine("Este bitonica");
                else
                    Console.WriteLine("Nu este bitonica");
            }
        }

        private static void problema14()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int count = n - 1;
            int ok = 0;
            int ok1 = 0;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (v[i] >= v[i + 1])
                    ok1++;
            }
            if (ok1 == 0)
                Console.WriteLine("este o secventa crescatoare");
            else if (ok1 == n - 1)
                Console.WriteLine("este o secventa descrescatoare");
            else
            {
                for (int i = 0; i < n / 2; i++)
                {
                    int aux = v[i];
                    v[i] = v[count];
                    v[count] = aux;
                    count--;
                }
                for (int i = 1; i < n - 1; i++)
                {
                    if (v[i] <= v[i + 1])
                        ok = 0;
                    else
                        ok++;
                }
                if (ok == 0)
                    Console.WriteLine("este o secventa crescatoare rotita.");
                else if (ok == n - 1)
                    Console.WriteLine("este o secventa descrescatoare rotita.");
                else
                    Console.WriteLine("nu este o secventa monotona rotita");
            }
            }

        private static void problema13()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int count = n-1;
            int ok = 0;
            int ok1 = 0;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n-1; i++)
            {
                if (v[i] >= v[i + 1])
                    ok1++;
            }
            if (ok1 == 0)
                Console.WriteLine("este o secventa crescatoare");
            else
            {
                for (int i = 0; i < n / 2; i++)
                {
                    int aux = v[i];
                    v[i] = v[count];
                    v[count] = aux;
                    count--;
                }
                for (int i = 1; i < n - 1; i++)
                {
                    if (v[i] <= v[i + 1])
                        ok = 0;
                    else
                        ok++;
                }
                if (ok == 0)
                    Console.WriteLine("este o secventa crescatoare rotita.");
                else
                    Console.WriteLine("nu este o secventa crescatoare rotita.");
            }
        }

        private static void problema12()
        {
            string sir = Console.ReadLine();
            string[] split = sir.Split('0');
            int i=0,ok=0,grup=0;

            for(i=0;i<split.Length;i++)
            {
                ok = 0;
                foreach(char c in split[i])
                {
                    if (Char.IsDigit(c))
                        ok++;
                }
                //Console.WriteLine("SPLIT I "+split[i]); verificare pasi
                //Console.WriteLine("OK "+ok);
                if (ok != 0)
                    grup++;
                //Console.WriteLine("GRUP "+grup);
            }
            Console.WriteLine(grup);
        }

        private static void problema11()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int s = 0;
            int invers;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                invers = 0;
                while(v[i]!=0)
                {
                    invers = invers*10 + v[i] % 10;
                    v[i] = v[i] / 10;
                }
                s+=invers;
            }
            Console.WriteLine(s);
        }

        private static void problema10()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int ok = 1, maxim = 0; ;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n-1; i++)
            {
                if (v[i] == v[i + 1])
                    ok++;
                else
                    ok = 1;
                if (ok >= maxim)
                    maxim = ok;
            }
            Console.WriteLine(maxim);
        }

        private static void problema9()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int okc = 0;
            for (int i = 0; i < n; i++)
            {
                v[i]= int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n-1; i++)
            {
                if (v[i] <= v[i + 1])
                    okc = 0;
                else
                    okc++;
            }
            if(okc==0)
                Console.WriteLine("Secventa monoton crescatoare");
            else if(okc== n-1)
                Console.WriteLine("Secventa monoton descrescatoare");
            else
                Console.WriteLine("Secventa nu este monotona");
        }

        private static void problema8()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            v[0] = 0;
            v[1] = 1;
            for (int i = 2; i < n; i++)
            {
                v[i] = v[i - 1] + v[i - 2];
            }
            Console.WriteLine($"al {n} lea nr este "+ v[n-1] );
        }

        private static void problema7()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int minim, maxim;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            minim = v[0];
            maxim = v[0];
            for (int i = 1; i < n; i++)
            {
                if (v[i] < minim)
                    minim = v[i];
                if (v[i] > maxim)
                    maxim = v[i];
            }
            Console.WriteLine("minim "+ minim);
            Console.WriteLine("maxim "+ maxim);
        }

        private static void problema6()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int nr = 0;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] >= v[i - 1])
                    nr = 0;
                else
                    nr++;
            }
            if(nr==0)
                Console.WriteLine("da");
            else
                Console.WriteLine("nu");
        }

        private static void problema5()
        {
            Console.WriteLine("n");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int nr = 0;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] == i)
                    nr++;
            }
            Console.WriteLine(nr);
        }

        private static void problema4()
        {
            Console.WriteLine("n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("a");
            int a = int.Parse(Console.ReadLine());
            int ok = 0,poz =0;
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if(v[i]==a)
                {
                    ok = 1;
                    poz = i;
                }
            }
            if(ok==1)
                Console.WriteLine($"poz {poz} ");
            else
                Console.WriteLine("-1");
        }

        private static void problema3()
        {
            int n= int.Parse(Console.ReadLine());
            int s = 0, p = 1;
            for (int i = 1; i <= n; i++)
            {
                s += i;
                p *= i;
            }
            Console.WriteLine($"suma {s} prod {p}");
        }

        private static void problema2()
        {
            int n = int.Parse(Console.ReadLine());
            int nrn = 0, nr0 = 0, nrp = 0; ;
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] < 0)
                    nrn++;
                else if (v[i] > 0)
                    nrp++;
                else if (v[i] == 0)
                    nr0++;
            }
            Console.WriteLine($"neg {nrn} poz {nrp} 0 {nr0}");
        }

        private static void problema1()
        {
            int n = int.Parse(Console.ReadLine());
            int nr = 0;
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] % 2 == 0)
                    nr++;
            }
            Console.WriteLine(nr);
        }
    }
}
