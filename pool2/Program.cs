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
            problema16();
            //problema17();
        }

        private static void problema17()
        {
            string sir = Console.ReadLine();
            int k = 0, ok = 1, nr = 0, maxv = -1;
            foreach (char c in sir)
            {
                if (c == '0')
                    k++;
                else if (c == '1' && k > 0)
                    k--;
                else
                    ok = 0;
            }
            if (ok != 0 && k == 0)
            {
                Console.WriteLine("Este corect parantezat");
                foreach (char c in sir)
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
            int a = int.Parse(Console.ReadLine());
            int comparatorDesc = a;
            int comparatorCresc=a;
            bool crescatoare = false;
            bool descrescatoare = false,bitonica=false;
            int oktest = 0;
            for(int i=0;i<n-1;i++)
            {
                int b = int.Parse(Console.ReadLine());
                if (b <= a && crescatoare == false)
                {
                    descrescatoare = true;
                    oktest++;
                }
                else if(b>=comparatorCresc && crescatoare==false && descrescatoare==false)
                {
                    crescatoare = true;
                    descrescatoare = true;
                }
                else if (b >= a && crescatoare == false)
                {
                    crescatoare = true;
                    oktest++;
                }
                else if (b <= a && crescatoare == true)
                {
                    descrescatoare = true;
                    oktest++;
                }
                else if(b<=a && descrescatoare==true)
                {
                    crescatoare = true;
                    oktest++;
                }
                else if(b>=a && descrescatoare==true && crescatoare==true)
                {
                    if(b>=comparatorDesc || b>=comparatorCresc)
                    {
                        bitonica = true;
                    }
                    else
                    {
                        bitonica = false;
                    }
                }
                a = b;
            }
            if (bitonica == true)
                Console.WriteLine("Este bitonica rotita");
            else
                Console.WriteLine("Nu este bitonica rotita");
        }

        private static void problema15()
        {
            int n = int.Parse(Console.ReadLine());
            int ok = 0;
            int ok1 = 0;
            int oke = 0;
            bool crescatoare = false, descrescatoare = false;
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                int b = int.Parse(Console.ReadLine());
                if (b >= a && descrescatoare==false)
                {
                    crescatoare = true;
                    ok++;
                }
                else if (b <= a && crescatoare==true)
                {
                    descrescatoare = true;
                    ok1++;
                }
                a = b;
            }
            if(ok1+ok==n-1)
                Console.WriteLine("Bitonica");
            else
                Console.WriteLine("nu");
        }

    private static void problema14()
    {
        int n = int.Parse(Console.ReadLine());
        int a = int.Parse(Console.ReadLine());
        int minim, maxim;
        minim = maxim = a;
        bool crescatoare = true, descrescatoare = true;
        int cadereCresc = 0, cadereDescresc = 0, cadere = 0;
        for (int i = 0; i < n - 1; i++)
        {
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                crescatoare = false;
            }
            else if (a < b)
            {
                descrescatoare = false;
            }
            if (a > b && minim > b)
            {
                cadereCresc++;
            }
            if (a < b && maxim < b)
            {
                cadereDescresc++;
            }
            a = b;
        }
        if (crescatoare == true || cadereCresc == 1)
            Console.WriteLine("Monoton crescatoare rotita");
        else if (descrescatoare == true || cadereDescresc == 1)
            Console.WriteLine("Monoton descrescatoare rotita");
        else
            Console.WriteLine("Nu este monotona");
    }

    private static void problema13()
    {
        int n = int.Parse(Console.ReadLine());
        int a = int.Parse(Console.ReadLine());
        int minim = a;
        bool crescatoare = true;
        int cadere = 0;
        for (int i = 0; i < n - 1; i++)
        {
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                crescatoare = false;
            }
            if (a > b && minim > b)
            {
                cadere++;
            }
            a = b;
        }
        if (crescatoare == true || cadere == 1)
            Console.WriteLine("Este rotita crescatoare");
        else
            Console.WriteLine("Nu este rotita crescatoare");
    }

    private static void problema12()
    {
        string sir = Console.ReadLine();
        string[] split = sir.Split('0');
        int i = 0, grup = 0;
        int prev = 0, cresc = 0, nr = 0;
        for (i = 0; i < split.Length; i++)
        {
            cresc = 0;
            nr = 0;
            foreach (char c in split[i])
            {

                if (Char.IsDigit(c))
                {
                    if (c != '0')
                    {
                        if ((int)c > prev)
                        {
                            cresc++;
                        }
                        nr++;
                        prev = (int)c;
                    }
                }
            }
            if (cresc == nr && cresc != 0 && nr != 0)
                grup++;
        }
        Console.WriteLine($"Nr grupuri: {grup}");

    }

    private static void problema11()
    {
        Console.WriteLine("n");
        int n = int.Parse(Console.ReadLine());
        int s = 0;
        int invers;
        for (int i = 0; i < n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            invers = 0;
            while (a != 0)
            {
                invers = invers * 10 + a % 10;
                a = a / 10;
            }
            s += invers;
        }
        Console.WriteLine(s);
    }

    private static void problema10()
    {
        Console.WriteLine("n");
        int n = int.Parse(Console.ReadLine());
        int a = int.Parse(Console.ReadLine());
        int ok = 1, maxim = 0; ;
        for (int i = 1; i < n; i++)
        {
            int b = int.Parse(Console.ReadLine());
            if (a == b)
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
        int okc = 0;
        int okd = 0;
        int a = int.Parse(Console.ReadLine());
        for (int i = 1; i < n; i++)
        {
            int b = int.Parse(Console.ReadLine());
            if (a <= b)
                okc++;
            else
                okd++;
            b = a;
        }
        if (okd == 0)
            Console.WriteLine("Secventa monoton crescatoare");
        else if (okc == 0)
            Console.WriteLine("Secventa monoton descrescatoare");
        else
            Console.WriteLine("Secventa nu este monotona");
    }

    private static void problema8()
    {
        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        int c = 0;
        for (int i = 2; i < n; i++)
        {
            c = b + a;
            a = b;
            b = c;
        }
        Console.WriteLine($"al {n} lea nr este {c}");
    }

    private static void problema7()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];
        int b = int.Parse(Console.ReadLine());
        int minim, maxim;
        minim = maxim = b;
        for (int i = 1; i < n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            if (a < minim)
                minim = a;
            else if (a > maxim)
                maxim = a;
        }
        Console.WriteLine("minim " + minim);
        Console.WriteLine("maxim " + maxim);
    }

    private static void problema6()
    {
        Console.WriteLine("n");
        int n = int.Parse(Console.ReadLine());
        int a = int.Parse(Console.ReadLine());
        int nr = 0;
        for (int i = 1; i < n; i++)
        {
            int b = int.Parse(Console.ReadLine());
            if (b >= a)
                nr = 0;
            else
                nr++;
            a = b;
        }
        if (nr == 0)
            Console.WriteLine("da");
        else
            Console.WriteLine("nu");
    }

    private static void problema5()
    {
        Console.WriteLine("n");
        int n = int.Parse(Console.ReadLine());
        int nr = 0;
        for (int i = 0; i < n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            if (a == i)
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
        int ok = 0, poz = 0;
        for (int i = 0; i < n; i++)
        {
            int b = int.Parse(Console.ReadLine());
            if (b == a)
            {
                ok = 1;
                poz = i;
            }
        }
        if (ok == 1)
            Console.WriteLine($"poz {poz} ");
        else
            Console.WriteLine("-1");
    }

    private static void problema3()
    {
        int n = int.Parse(Console.ReadLine());
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
        for (int i = 0; i < n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            if (a < 0)
                nrn++;
            else if (a > 0)
                nrp++;
            else if (a == 0)
                nr0++;
        }
        Console.WriteLine($"neg {nrn} poz {nrp} 0 {nr0}");
    }

    private static void problema1()
    {
        int n = int.Parse(Console.ReadLine());
        int nr = 0;
        for (int i = 0; i < n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
                nr++;
        }
        Console.WriteLine(nr);
    }
}
}
