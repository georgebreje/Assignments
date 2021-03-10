using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema1
{
    class Program
    {
        static Random rnd = new Random();
        static int N, M;
        static void Main(string[] args)
        {
            int n = 5;
            N = n;
            int m = 5;
            M = m;
            int[,] a = new int[n, m];
            fillPrime(a);
        }
        static void fillPrime(int[,] a)
        {
            int i = 2;
            for(int j = 0; j < N; j++)
            {
                for (int k = 0; k < M; k++)
                {
                    while (!isPrime(i))
                    {
                        i++;
                    }
                    if (isPrime(i))
                    {
                        a[j, k] = i;
                        i++;
                    }
                }
            }
            displayMatrix(a);
        }
        static bool isPrime(int number)
        {
            if (number < 2)
                return false;
            if (number == 2)
                return true;
            for (int d = 2; d  <= number / 2; d++)
            {
                if (number % d == 0)
                    return false;
            }
            return true;
        }
        static void fillBorder(int[,] a)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (border(i, j) == true)
                        a[i, j] = i + j + 2;
                    else
                        a[i, j] = a[i - 1, j - 1] + a[i - 1, j] + a[i - 1, j + 1];
                }
            }
            displayMatrix(a);
        }
        private static bool border(int i, int j)
        {
            if (i == 0)
                return true;
            else if (j == N - 1)
                return true;
            else if (i == N - 1)
                return true;
            else if (j == 0)
                return true;
            return false;
        }
        static void diagonalFill(int[,] a)
        {
            for (int i = 0; i < N; i++)
            {
                a[i, N - i - 1] = N;
            }

            for (int i = 0; i < N - 1; i++)
            {
                for (int j = N - 2 - i; j >= 0; j--)
                {
                    a[i, j] = a[i, j + 1] - 1;
                }
            }
            for (int i = 1; i < N; i++)
            {
                for (int j = N - i; j < N; j++)
                {
                    a[i, j] = a[i, j - 1] + 1;
                }
            }
            displayMatrix(a);
        }
        static void fillMatrix(int[,] a)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    a[i, j] = rnd.Next(1, 10);
                }
            }
        }
        static void displayMatrix(int[,] a)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void spiralCross(int[,] a)
        {
            fillMatrix(a);
            displayMatrix(a);
            Console.WriteLine();
            int k = 0;
            for (k = 0; k < N / 2; k++)
            {
                //prima linie fara ultima coloana
                for (int i = 0 + k; i < M - 1 - k; i++)
                    Console.Write(a[0 + k, i] + " ");
                //ultima coloana fara ultima linie
                for (int i = 0 + k; i < N - 1 - k; i++)
                    Console.Write(a[i, M - 1 - k] + " ");
                //ultima linie fara prima coloana
                for (int i = M - 1 - k; i > 0 + k; i--)
                    Console.Write(a[N - 1 - k, i] + " ");
                //prima coloana fara prima linie
                for (int i = N - 1 - k; i > 0 + k; i--)
                    Console.Write(a[i, 0 + k] + " ");
            }
            if (N % 2 != 0)
            {
                Console.Write(a[N / 2, N / 2]);
            }
            Console.WriteLine();
        }
    }
}
