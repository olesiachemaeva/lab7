using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Program
    {
        public struct Triangle
        {
            public double a, b, c;

        }
        static void Main(string[] args)
        {
            {
                int a1 = 6; int b1 = 6; int c1 = 7;
                int a2 = 6; int b2 = 14; int c2 = 15;
                Console.WriteLine("S1 = {0}, S2 = {1}", Geron(a1, b1, c1), Geron(a2, b2, c2));
                Console.Read();
            }
             double Geron(int a, int b, int c)
            {
                double p = (a + b + c) / 2;
                double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return S;
            }
            Console.ReadLine();
        }
        }
}
