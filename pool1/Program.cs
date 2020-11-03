using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pool1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Problema1();
            Problema2();
            Problema3();
            Problema4();
            Problema5();
            Problema6();
            Problema7();
            Problema8();
            Problema9();
            Problema10();
            Problema11();
            Problema12();
            Problema13();
            Problema14();
            Problema15();
            Problema16();
            Problema17();
            Problema18();
            Problema19();*/
            Problema20();

        }

        private static string Problema20()
        {
            Console.WriteLine("Introduceti m n");
            int numr = int.Parse(Console.ReadLine());
            int denr = int.Parse(Console.ReadLine());
            string result="";
            Dictionary<int, int> mp = new Dictionary<int, int>();
            int rem=numr%denr;  
            while((rem!=0)&& !mp.ContainsValue(rem))
            {
                mp[rem] = result.Length;
                rem = rem * 10;
                int res_part = rem / denr;
                result += res_part.ToString();
                rem = rem % denr;   
            }
            if (rem == 0)
                return " ";
            else
    if (mp.ContainsKey(rem))
                return result.Substring(mp[rem]);
            return "";
        }

        private static void Problema19()
        {
            Console.WriteLine("Introduceti n");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[10];
            int nr = 0;
            for (int i = 0; i < 10; i++)
                v[i] = 0;
            while(n!=0)
            {
                v[n % 10]++;
                n /= 10;
            }
            for (int i = 0; i < 10; i++)
                if (v[i] != 0)
                    nr++;
            if(nr ==2)
                Console.WriteLine("Da");
            else
                Console.WriteLine("Nu");
        }

        private static void Problema18()
        {
            Console.WriteLine("Introduceti n");
            int n = int.Parse(Console.ReadLine());
            int d = 2;
            int p = 0;
            while(n>1)
            {
                p = 0;
                while(n%d==0)
                {
                    ++p;
                    n /= d;
                }
                if (p != 0)
                    Console.Write($" {d} ^ {p} + ");
                ++d;

                if (n > 1 && d * d > n)
                    d = n;
            }
            Console.Write('0');
        }

        private static void Problema17()
        {
            Console.WriteLine("Introduceti numerele");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int ac = a;
            int bc = b;
            int c, d;
            while(a!=b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            c = ac;
            d = bc;
            while(ac!=bc)
            {
                if (bc < ac)
                    bc += c;
                else
                    ac += d;
            }
            Console.WriteLine($"cmmdc: {a} cmmc: {bc}");
        }

        private static void Problema16()
        {
            Console.WriteLine("Introduceti numerele");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            if (a >= b && a >= c && a >= d && a >= e)
            {
                if (b >= c && b >= d && b >= e)
                {
                    if (c >= d && c >= e && d >= e)
                        Console.WriteLine($"{e} {d} {c} {b} {a}");
                    else if (c >= d && c >= e && e >= d)
                        Console.WriteLine($"{d} {e} {c} {b} {a}");
                    else if (d >= c && d >= e && c>=e)
                        Console.WriteLine($"{e} {c} {d} {b} {a}");
                    else if (d >= e && d >= c && e >= c)
                        Console.WriteLine($"{c} {e} {d} {b} {a}");
                    else if (e >= d && e >= c && d >= c)
                        Console.WriteLine($"{c} {d} {e} {b} {a}");
                    else if (e >= d && e >= c && c >= d)
                        Console.WriteLine($"{d} {c} {e} {b} {a}");
                }
                else if (c >= b && c >= d && c >= e)
                {
                    if (b >= d && b >= e && d >= e)
                        Console.WriteLine($"{e} {d} {b} {c} {a}");
                    else if (b >= d && b >= e && e >= d)
                        Console.WriteLine($"{d} {e} {b} {c} {a}");
                    else if (e >= d && e >= b && b >= d)
                        Console.WriteLine($"{d} {b} {e} {c} {a}");
                    else if (e >= d && e >= b && d >= b)
                        Console.WriteLine($"{b} {d} {e} {c} {a}");
                    else if(d>=b && d>=e && e>=b)
                        Console.WriteLine($"{b} {e} {d} {c} {a}");
                    else if (d >= b && d >= e && b>= e)
                        Console.WriteLine($"{e} {b} {d} {c} {a}");

                }
                else if (d >= b && d >= e && d >= c)
                {
                    if (c >= b && c >= e && b >= e)
                        Console.WriteLine($"{e} {b} {c} {d} {a}");
                    else if (c >= b && c >= e && e >= b)
                        Console.WriteLine($"{b} {e} {c} {d} {a}");
                    else if (b >= c && b >= e && e >= c)
                        Console.WriteLine($"{c} {e} {b} {d} {a}");
                    else if (b >= c && b >= e && c >= e)
                        Console.WriteLine($"{e} {c} {b} {d} {a}");
                    else if (e >= c && e >= b && b >= c)
                        Console.WriteLine($"{c} {b} {e} {d} {a}");
                    else if (e >= c && e >= b && c >= b)
                        Console.WriteLine($"{b} {c} {e} {d} {a}");
                }
                else if (e >= b && e >= d && e >= c)
                {
                    if (d >= c && d >= b && c >= b)
                        Console.WriteLine($"{b} {c} {d} {e} {a}");
                    else if (d >= c && d >= b && b >= c)
                        Console.WriteLine($"{c} {b} {d} {e} {a}");
                    else if (c >= d && c >= b && b >= d)
                        Console.WriteLine($"{d} {b} {c} {e} {a}");
                    else if (c >= d && c >= b && b >= d)
                        Console.WriteLine($"{d} {b} {c} {e} {a}");
                    else if (b >= d && b >= c && c >= d)
                        Console.WriteLine($"{d} {c} {b} {e} {a}");
                    else if (b >= d && b >= c && c >= d)
                        Console.WriteLine($"{d} {c} {b} {e} {a}");
                }
            }
            else if (b >= a && b >= c && b >= d && b >= e)
            {
                if (a >= c && a >= d && a >= e)
                {
                    if (c >= d && c >= e && d >= e)
                        Console.WriteLine($"{e} {d} {c} {a} {b}");
                    else if (c >= d && c >= e && e >= d)
                        Console.WriteLine($"{d} {e} {c} {a} {b}");
                    else if(d >= c && d >= e && c >= e)
                        Console.WriteLine($"{e} {c} {d} {a} {b}");
                    else if(d >= c && d >= e && e >= c)
                        Console.WriteLine($"{c} {e} {d} {a} {b}");
                    else if(e >= d && e >= c && d >= c)
                        Console.WriteLine($"{c} {d} {e} {a} {b}");
                    else if(e >= d && e >= c && c >= d)
                        Console.WriteLine($"{d} {c} {e} {a} {b}");
                }
                else if (c >= a && c >= d && c >= e)
                {
                    if (a >= d && a >= e && d >= e)
                        Console.WriteLine($"{e} {d} {a} {c} {b}");
                    else if (a >= d && a >= e && e >= d)
                        Console.WriteLine($"{d} {e} {a} {c} {b}");
                    else if (d >= a && d >= e && e >= a)
                        Console.WriteLine($"{a} {e} {d} {c} {b}");
                    else if (d >= a && d >= e && a >= e)
                        Console.WriteLine($"{e} {a} {d} {c} {b}");
                    else if (e >= d && e >= a && a >= d)
                        Console.WriteLine($"{d} {a} {e} {c} {b}");
                    else if (e >= d && e >= a && d >= a)
                        Console.WriteLine($"{a} {d} {e} {c} {b}");
                }
                else if (d >= a && d >= e && d >= c)
                {
                    if (c >= a && c >= e && a >= e)
                        Console.WriteLine($"{e} {a} {c} {d} {b}");
                    else if (c >= e && c >= a && e >= a)
                        Console.WriteLine($"{a} {e} {c} {d} {b}");
                    else if (a >= e && a >= c && c >= e)
                        Console.WriteLine($"{e} {c} {a} {d} {b}");
                    else if (a >= e && a >= c && e >= c)
                        Console.WriteLine($"{c} {e} {a} {d} {b}");
                    else if (e >= a && e >= c && c >= a)
                        Console.WriteLine($"{a} {c} {e} {d} {b}");
                    else if (e >= a && e >= c && a >= c)
                        Console.WriteLine($"{c} {a} {e} {d} {b}");
                }
                else if (e >= a && e >= d && e >= c)
                {
                    if(d>=a && d>=c && c>=a)
                        Console.WriteLine($"{a} {c} {d} {e} {b}");
                    else if(d >= a && d >= c && a >= c)
                        Console.WriteLine($"{c} {a} {d} {e} {b}");
                    else if (a >= d && a >= c && d>=c)
                        Console.WriteLine($"{c} {d} {a} {e} {b}");
                    else if (a >= d && d >= c && c >= d)
                        Console.WriteLine($"{d} {c} {a} {e} {b}");
                    else if (c >= d && c >= a && a >= d)
                        Console.WriteLine($"{d} {a} {c} {e} {b}");
                    else if (c >= d && c >= a && d >= a)
                        Console.WriteLine($"{a} {d} {c} {e} {b}");
                }
            }
            else if (c >= a && c >= b&& c >= d && c >= e)
            {
                if (a >= b && a >= d && a >= e)
                {
                    if (b >= d && b >= e && d >= e)
                        Console.WriteLine($"{e} {d} {b} {a} {c}");
                    else if (b >= d && b >= e && e >= d)
                        Console.WriteLine($"{d} {e} {b} {a} {c}");
                    else if (d >= b && d >= e && e >= b)
                        Console.WriteLine($"{b} {e} {d} {a} {c}");
                    else if (d >= e && d >= e && b >= e)
                        Console.WriteLine($"{e} {b} {d} {a} {c}");
                    else if (e >= b && e >= d && d >= b)
                        Console.WriteLine($"{b} {d} {e} {a} {c}");
                    else if (e >= b && e >= d && b >= d)
                        Console.WriteLine($"{d} {b} {e} {a} {c}");
                }
                else if (b >= a && b >= d && b >= e)
                {
                    if (a >= d && a >= e && d >= e)
                        Console.WriteLine($"{e} {d} {a} {b} {c}");
                    else if (a >= d && a >= e && e >= d)
                        Console.WriteLine($"{d} {e} {a} {b} {c}");
                    else if (d >= a && d >= e && e >= a)
                        Console.WriteLine($"{a} {e} {d} {b} {c}");
                    else if (d >= e && d >= e && a >= e)
                        Console.WriteLine($"{e} {a} {d} {b} {c}");
                    else if (e >= a && e >= d && d >= a)
                        Console.WriteLine($"{a} {d} {e} {b} {c}");
                    else if (e >= a && e >= a && a >= d)
                        Console.WriteLine($"{d} {a} {e} {b} {c}");
                }
                else if (d >= a && d >= e && d >= b)
                {
                    if (b >= a && b >= e && a >= e)
                        Console.WriteLine($"{e} {a} {b} {d} {c}");
                    else if (b >= a && b >= e && e >= a)
                        Console.WriteLine($"{a} {e} {b} {d} {c}");
                    else if (e >= a &&  e>= b &&  b >= a)
                        Console.WriteLine($"{a} {b} {e} {d} {c}");
                    else if (e >= b &&  e>= a && a >= b)
                        Console.WriteLine($"{b} {a} {e} {d} {c}");
                    else if (a >= b && a >= e && b >= e)
                        Console.WriteLine($"{e} {b} {a} {d} {c}");
                    else if (a >= b && a >= e && e >= b)
                        Console.WriteLine($"{b} {e} {a} {d} {c}");
                }
                else if (e >= a && e >= d && e >= b)
                {
                    if(d>=b && d>=a && b>=a)
                        Console.WriteLine($"{a} {b} {d} {e} {c}");
                    else if (d >= b && d >= a && a >= b)
                        Console.WriteLine($"{b} {a} {d} {e} {c}");
                    else if (a >= b && a >= d && b >= d)
                        Console.WriteLine($"{d} {b} {a} {e} {c}");
                    else if (a >= b && a >= d && d >= b)
                        Console.WriteLine($"{b} {d} {a} {e} {c}");
                    else if (b >= a && b >= d && a >= d)
                        Console.WriteLine($"{d} {a} {b} {e} {c}");
                    else if (b >= a && b >= d && d >= a)
                        Console.WriteLine($"{a} {d} {b} {e} {c}");

                }
            }
            else if (d >= a && d >= b && d >= c && d >= e)
            {
                if (a >= b && a >= d && a >= e)
                {
                    if (b >= c && b >= e && c >= e)
                        Console.WriteLine($"{e} {c} {b} {a} {d}");
                    else if (b >= c && b >= e && e >= c)
                        Console.WriteLine($"{c} {e} {b} {a} {d}");
                    else if (c >= b && c >= e && b >= e)
                        Console.WriteLine($"{e} {b} {c} {a} {d}");
                    else if (c >= b && c >= e && e >= b)
                        Console.WriteLine($"{b} {e} {c} {a} {d}");
                    else if (e >= b && e >= c && b >= c)
                        Console.WriteLine($"{c} {b} {e} {a} {d}");
                    else if (e >= b && e >= c && c >= b)
                        Console.WriteLine($"{b} {c} {e} {a} {d}");
                }
                else if (b >= a && b >= c && b >= e)
                {
                    if (a >= c && a >= e && c >= e)
                        Console.WriteLine($"{e} {c} {a} {b} {d}");
                    else if (a >= c && a >= e && e >= c)
                        Console.WriteLine($"{c} {e} {a} {b} {d}");
                    else if (c >= a && c >= e && e >= a)
                        Console.WriteLine($"{a} {e} {c} {b} {d}");
                    else if (c >= a && c >= e && a >= e)
                        Console.WriteLine($"{e} {a} {c} {b} {d}");
                    else if (e >= a && e >= c && c >= a)
                        Console.WriteLine($"{a} {c} {e} {b} {d}");
                    else if (e >= a && e >= c && a >= c)
                        Console.WriteLine($"{c} {a} {e} {b} {d}");
                }
                else if (c >= a && c >= e && c >= b)
                {
                    if (b >= e && b >= a && a >= e)
                        Console.WriteLine($"{e} {a} {b} {c} {d}");
                    else if (b >= e && b >= a && e >= a)
                        Console.WriteLine($"{a} {e} {b} {c} {d}");
                    else if (e >= a && e >= b && b >= a)
                        Console.WriteLine($"{a} {b} {e} {c} {d}");
                    else if (e >= a && e >= b && a >= b)
                        Console.WriteLine($"{b} {a} {e} {c} {d}");
                    else if (a >= e && a >= b && b >= e)
                        Console.WriteLine($"{e} {b} {a} {c} {d}");
                    else if (a >= e && e >= b && e >= b)
                        Console.WriteLine($"{b} {e} {a} {c} {d}");
                }

                else if (e >= a && e >= c && e >= b)
                {
                    if(c>=a && c>=b && b>=a)
                        Console.WriteLine($"{a} {b} {c} {e} {d}"); 
                    else if (c >= a && c >= b && a >= b)
                        Console.WriteLine($"{b} {a} {c} {e} {d}");
                    else if (b >= c && b >= a && a >= c)
                        Console.WriteLine($"{c} {a} {b} {e} {d}");
                    else if (b >= c && b >= a && c >= a)
                        Console.WriteLine($"{a} {c} {b} {e} {d}");
                    else if (a >= c && a >= b && b >= c)
                        Console.WriteLine($"{c} {b} {a} {e} {d}");
                    else if (a >= c && a >= b && c >= b)
                        Console.WriteLine($"{b} {c} {a} {e} {d}");
                }
            }
            else if (e >= a && e >= b && e >= c && e >= d)
            {
                if (a >= b && a >= d && a >= c)
                {
                    if (b >= d && b >= c && c >= d)
                        Console.WriteLine($"{d} {c} {b} {a} {e}");
                    else if (b >= d && b >= c && d >= c)
                        Console.WriteLine($"{c} {d} {b} {a} {e}");
                    else if (d >= b && d >= c && c >= b)
                        Console.WriteLine($"{b} {c} {d} {a} {e}");
                    else if (d >= c && d >= c && b >= c)
                        Console.WriteLine($"{c} {b} {d} {a} {e}");
                    else if (c >= b && c >= d && d >= b)
                        Console.WriteLine($"{b} {d} {c} {a} {e}");
                    else if (c >= b && c >= d && b >= d)
                        Console.WriteLine($"{d} {b} {c} {a} {e}");
                }
                else if (b >= a && b >= c && b >= d)
                {   
                    if(a>=c && a>=d && c>=d)
                        Console.WriteLine($"{d} {c} {a} {b} {e}");
                    else if (a >= c && a >= d && d >= c)
                        Console.WriteLine($"{c} {d} {a} {b} {e}");
                    else if (d >= a && d >= c && c >= a)
                        Console.WriteLine($"{a} {c} {d} {b} {e}");
                    else if (d >= c && d >= c && a >= c)
                        Console.WriteLine($"{c} {a} {d} {b} {e}");
                    else if (c >= a && c >= d && d >= a)
                        Console.WriteLine($"{a} {d} {c} {b} {e}");
                    else if (c >= a && c >= d && a >= d)
                        Console.WriteLine($"{d} {a} {c} {b} {e}");
                }
                else if (c >= a && c >= d && c >= b)
                {
                    if(b>=a && b>=d && a>=d)
                        Console.WriteLine($"{d} {a} {b} {c} {e}");
                    else if (b >= a && b >= d && d >= a)
                        Console.WriteLine($"{a} {d} {b} {c} {e}");
                    else if (d >= a && d >= b && b >= a)
                        Console.WriteLine($"{a} {b} {d} {c} {e}");
                    else if (d >= b && d >= b && a >= b)
                        Console.WriteLine($"{b} {a} {d} {c} {e}");
                    else if (b >= a && b >= d && d >= a)
                        Console.WriteLine($"{a} {d} {b} {c} {e}");
                    else if (b >= a && b >= d && a >= d)
                        Console.WriteLine($"{d} {a} {b} {c} {e}");
                }
                else if (d >= a && d >= c && d >= b)
                {
                    if(c>=b && c>=a && b>=a)
                      Console.WriteLine($"{a} {b} {c} {d} {e}");
                    else if (c >= b && c >= a && a >= b)
                        Console.WriteLine($"{b} {a} {c} {d} {e}");
                    else if (a >= b && a >= c && c >= b)
                        Console.WriteLine($"{b} {c} {a} {d} {e}");
                    else if (a >= b && a >= c && b >= c)
                        Console.WriteLine($"{c} {b} {a} {d} {e}");
                    else if (b >= a && b >= c && c >= a)
                        Console.WriteLine($"{a} {c} {b} {d} {e}");
                    else if (b >= a && b >= c && a >= c)
                        Console.WriteLine($"{c} {a} {b} {d} {e}");
                }
            }
        }

        private static void Problema15()
        {
            Console.WriteLine("Introduceti numerele");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a >= b && a>=c)
            {
                if (b >= c)
                    Console.WriteLine($"{c} {b} {a}");
                else
                    Console.WriteLine($"{b} {c} {a}");
            }
            else if (b >=a && b>=c )
            {
                if (a >= c)
                    Console.WriteLine($"{c} {a} {b}");
                else 
                    Console.WriteLine($"{a} {c} {b}");
            }
            else if(c>=a && c>=b)
            {
                if(a>=b)
                    Console.WriteLine($"{b} {a} {c}");
                else
                    Console.WriteLine($"{a} {b} {c}");
            }
        }

        private static void Problema14()
        {
            Console.WriteLine("Introduceti n");
            int n = int.Parse(Console.ReadLine());
            int og = 0;
            int c = n;
            while(c!=0)
            {
                og = og * 10 + c % 10;
                c /= 10;
            }
            if(og==n)
                Console.WriteLine("palindrom");
            else
                Console.WriteLine("nu este palindrom");
        }

        private static void Problema13()
        {
            Console.WriteLine("Introudceti anii y1, y2");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int counter = 0;
            int i = a + 1;
            while (i < b) 
            { 
                if (i % 4 == 0)
                {
                    counter++;
                    i = i + 4;
                }
                else
                    i++;
            }
            Console.WriteLine($"Sunt {counter} ani");
        }

        private static void Problema12()
        {
            Console.WriteLine("Introudceti intervalul [a, b]");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti n");
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = a; i <= b; i++)
                if (n % i == 0)
                    counter++;
            Console.WriteLine($"{counter} numere divizibile cu n");

        }

        private static void Problema11()
        {
            Console.WriteLine("Introduceti n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Cifrele in ordine inversa sunt: ");
            while(n!=0)
            {
                Console.Write(n % 10 + ',');
                n /= 10;
            }
        }

        private static void Problema10()
        {
            Console.WriteLine("Introduceti n");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
                Console.Write("Nu este prim");
            else if (n == 2)
            {
                Console.Write("Este prim");

            }
            else
            {
                for (int i = 3; i <= n; i++)
                    if (n % i == 0)
                    {
                        Console.Write("Nu este prim");
                        break;
                    }
            } 
        }

        private static void Problema9()
        {
            Console.WriteLine("Introduceti n");
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
                if(n%i==0)
                Console.Write($"{i},");
        }

        private static void Problema8()
        {
            Console.WriteLine("Introudceti a si b");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("a = a + b");
            Console.WriteLine("b = a - b");
            Console.WriteLine("a = a - b");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"{a} este a si {b} este b");
        }

        private static void Problema7()
        {
            Console.WriteLine("Introudceti a si b"); 
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int aux = 0;
            Console.WriteLine( $"Salvam in aux  care are valoarea {aux} numarul {a}");
            aux = a;
            Console.WriteLine($"In urma acestui pas aux are valoarea {aux}");
            a = b;
            Console.WriteLine($"Salvam in a valoarea lui b deci a are valoarea {a}");
            b = aux;
            Console.WriteLine($"Si b are valoarea lui aux adica {b}");
        }

        private static void Problema6()
        {
            Console.WriteLine("Introduceti lungimile laturilor triunghiului");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if(a+b<c)
                Console.WriteLine("Nu se poate forma triunghi");
            else if(a+c<b)
                Console.WriteLine("Nu se poate forma triunghi");
            else if (b + c < a)
                Console.WriteLine("Nu se poate forma triunghi");
            else
                Console.WriteLine("Se poate forma triunghi");
        }

        private static void Problema5()
        {
            Console.WriteLine("Introduceti numarul si a k a cifra dorita");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int nr = 0;
            while(n!=0)
            {
                nr++;
                n /= 10;
                if (nr == k)
                {
                    Console.WriteLine($"cifra este {n % 10}");
                    break;
                }
            }
        }

        private static void Problema4()
        {
            Console.WriteLine("Introduceti anul");
            int n = int.Parse(Console.ReadLine());
            if(n%4==0)
                Console.WriteLine("An bisect");
            else
                Console.WriteLine("Nu este an bisect");
        }

        private static void Problema3()
        {
            Console.WriteLine("Introduceti n si k");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            if (n % k == 0)
                Console.WriteLine("n se divide cu k");
            else
                Console.WriteLine("n nu se divide cu k");
        }

        private static void Problema2()
        {
            Console.WriteLine("Introduceti a, b si c din ecuatia ax^2+bx+c=0");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double x1,x2;
            double delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                x1 = (-b - Math.Sqrt(delta))/2*a;
                x2 = (-b + Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine($"x1 = {x1} si x2 = {x2}");
            }
            else if(delta==0)
            {
                x1 = (-b) / 2 * a;
                Console.WriteLine($"x1=x2={x1}");
            }
            else if(delta<0)
            {
                x1 = (-b - Math.Sqrt(-delta)) / 2 * a;
                x2 = (-b + Math.Sqrt(-delta)) / 2 * a;
                Console.WriteLine($"x1 = {x1}i si x2 = {x2}i unde i este numar complex");
            }
        }

        private static void Problema1()
        {
            Console.WriteLine("Introduceti a si b din ecuatia ax+b=0");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            float x;
            x = -b / a;
            Console.WriteLine($"x este {x}");
        }
    }
}
