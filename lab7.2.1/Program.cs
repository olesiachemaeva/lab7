﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну ребра куба:");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Обьем куба:" + Math.Pow(a, 3) + " куб.см");
            Console.WriteLine("Площадь поверхности:" + Math.Pow(a, 2) * 6 + " кв.см");//площать стороны * 6 сторон куба
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
