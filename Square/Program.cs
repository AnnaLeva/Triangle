using System;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            double S, V;
            Sq(a, out S, out V);
            Console.WriteLine(S);
            Console.WriteLine(V);
            Console.ReadKey();
        }
        static void Sq(int a, out double S, out double V)
        {
            S = 6*a*a;
            V = a*a*a; 
        }
    }
}
