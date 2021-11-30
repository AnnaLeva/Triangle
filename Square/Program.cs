using System;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            double S, V;
            SqParam(a, out S, out V);
            Console.WriteLine(S);
            Console.WriteLine(V);
            Console.ReadKey();
        }
        static void SqParam(int a, out double S, out double V)
        {
            S = 6 * Math.Pow(a, 2);
            V = Math.Pow(a, 3);
        }
    }
}
