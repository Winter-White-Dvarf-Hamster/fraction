using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Kaba
{
    internal class Fraction
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
            return new Fraction(this.numerator * f.denominator, denominator * f.numerator);
        }
        public Fraction Div(int val)
        {
            return new Fraction(this.numerator, denominator * val);
        }
        public Fraction Mult(Fraction f)
        {
            return new Fraction(this.numerator*f.numerator, denominator * f.denominator); 
        }
        public Fraction Mult(int val)
        {
            return new Fraction(this.numerator * val, denominator);
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }
        public double ToDouble()
        {
            return (double)numerator / denominator;
        }
    }
}
