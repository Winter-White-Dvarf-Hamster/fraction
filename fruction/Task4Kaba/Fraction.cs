using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task4Kaba
{
    public class Fraction
    {
        private int numerator;
        private int denominator;
        public Fraction()
        {
            numerator = 0;
            denominator = 1;
        }
        public Fraction(int Numerator,int Denominator)
        {
            numerator = Numerator;
            denominator = Denominator;
        }
        public Fraction(string str)
        {
            numerator = 0;
            denominator = 0;
        }
        public static Fraction Parse(string str)
        {
            string[] tmp = str.Split('/');
            if (tmp.Length != 2)
                 throw new ArgumentException();
            return new Fraction(int.Parse(tmp[0]),int.Parse(tmp[1]));
        }
        
        public Fraction Add(Fraction f)
        {
            return new Fraction(this.numerator * f.denominator + f.numerator * denominator, denominator * f.denominator);
        }
        public Fraction Sub(Fraction f)
        {
            return new Fraction(this.numerator * f.denominator - f.numerator * denominator, denominator * f.denominator);
        }
        public Fraction Div(Fraction f)
        {
            int gcd = GCD(Math.Abs(this.numerator * f.denominator), Math.Abs(denominator * f.numerator));
            return new Fraction(this.numerator * f.denominator / gcd, denominator * f.numerator / gcd);
        }
        public Fraction Div(int val)
        {
            int gcd = GCD(Math.Abs(this.numerator), Math.Abs(denominator * val));
            return new Fraction(this.numerator / gcd, denominator * val / gcd);
        }
        public Fraction Mult(Fraction f)
        {
            int gcd = GCD(Math.Abs(this.numerator * f.numerator), Math.Abs(denominator * f.denominator));
            return new Fraction(this.numerator * f.numerator / gcd, denominator * f.denominator / gcd); 
        }
        public Fraction Mult(int val)
        {
            int gcd = GCD(Math.Abs(this.numerator * val), Math.Abs(denominator));
            return new Fraction(this.numerator * val / gcd, denominator / gcd);
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }
        public double ToDouble()
        {
            return (double)numerator / denominator;
        }
        public Fraction Reduce()
        {
            int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
            return new Fraction(numerator / gcd, denominator / gcd);
        }
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
        
            }
            return a;
        }
    }
}
