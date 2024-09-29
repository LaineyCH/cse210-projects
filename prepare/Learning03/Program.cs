using System;
using Learning03;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        string fractionString = fraction.GetFractionString();
        double fractionDecimal = fraction.GetDecimalValue();
        Console.WriteLine(fractionString);
        Console.WriteLine(fractionDecimal);
        
        Fraction fraction2 = new Fraction(5);
        string fraction2String = fraction2.GetFractionString();
        double fraction2Decimal = fraction2.GetDecimalValue();
        Console.WriteLine(fraction2String);
        Console.WriteLine(fraction2Decimal);
        
        Fraction fraction3 = new Fraction(3, 4);
        string fraction3String = fraction3.GetFractionString();
        double fraction3Decimal = fraction3.GetDecimalValue();
        Console.WriteLine(fraction3String);
        Console.WriteLine(fraction3Decimal);
        
        Fraction fraction4 = new Fraction(1, 3);
        string fraction4String = fraction4.GetFractionString();
        double fraction4Decimal = fraction4.GetDecimalValue();
        Console.WriteLine(fraction4String);
        Console.WriteLine(fraction4Decimal);


    }
}