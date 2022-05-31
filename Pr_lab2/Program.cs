using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Text.Json;


namespace Pr_lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, n;
            string json = "";
            Fraction c = new Fraction();
            c.numerator = int.Parse(Console.ReadLine());
            c.denominator = int.Parse(Console.ReadLine());
            c.GetInfo();
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c.Sum(a, b);
            c.GetInfo();
            n = double.Parse(Console.ReadLine());
            c.division(n);
            c.GetInfo();
            n = double.Parse(Console.ReadLine());
            c.multiplication(n);
            c.GetInfo();
            c.Save(c, json);
            c.Input(c, json);
            c.GetInfo();
        }
    }
}
