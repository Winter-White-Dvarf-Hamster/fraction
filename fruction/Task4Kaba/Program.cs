using System;

namespace Task4Kaba;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello, World!");
        Fraction c1 = new Fraction(1, 2);
        Fraction c2 = new Fraction(2, 3);
        Console.WriteLine(c1);
        Console.WriteLine(c2);
        Console.WriteLine(c1.Mult(c2));
        Console.WriteLine(c1.Mult(2));
        Console.WriteLine(c1.Div(c2));
        Console.WriteLine(c1.Div(2));
        Fraction cres = Fraction.Parse(Console.ReadLine());
        Console.WriteLine(cres);
    }
}  