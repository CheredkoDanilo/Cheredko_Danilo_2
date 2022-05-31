using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Text.Json;

namespace Pr_lab2
{
    class Fraction
    {
        public double numerator { get; set; }
        public double denominator { get; set; }

        public Fraction()
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public void GetInfo()
        {
            Console.WriteLine($"{numerator}/{denominator}");
        }

        public void Sum(double a, double b)
        {
            numerator = numerator * b + a * denominator;
            denominator = denominator * b;
            while ((denominator % numerator == 0) && (numerator != 1))
            {
                denominator = denominator / numerator;
                numerator = numerator / numerator;
            }
        }

        public double division(double n)
        {
            while (n % 1 != 0)
            {
                n = n * 10;
                numerator = numerator * 10;
            }
            denominator = denominator * n;
            while ((denominator % numerator == 0) && (numerator != 1))
            {
                denominator = denominator / numerator;
                numerator = numerator / numerator;
            }
            return denominator;
        }

        public double multiplication(double n)
        {
            while (n % 1 != 0)
            {
                n = n * 10;
                denominator = denominator * 10;
            }
            numerator = numerator * n;
            while ((denominator % numerator == 0) && (numerator != 1))
            {
                denominator = denominator / numerator;
                numerator = numerator / numerator;
            }
            return numerator;
        }

        public string Save(Fraction c, string json)
        {
            json = JsonConvert.SerializeObject(c);
            Console.WriteLine(json);
            return json;
        }

        public Fraction Input(Fraction c, string json)
        {
            c = JsonConvert.DeserializeObject<Fraction>(json);
            return c;
        }
    }
}
