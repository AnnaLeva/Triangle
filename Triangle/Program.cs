using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            double S;
            TrP(a, b, c, out S);
            Console.WriteLine(S);
            Console.ReadKey();
        }
        static void TrP(int a, int b, int c, out double S)
        {
            double p = (a + b + c) / 2;
            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}

