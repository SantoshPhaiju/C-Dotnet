using System;

namespace OOP.Calculator;

public class MyCalculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Divide(int a, int b)
    {
        System.Console.WriteLine("Dividing " + a + " by " + b + " = " + ((double)a / b));
        return (double)a / b;
    }

    public int Mul(int a, int b)
    {
        return a * b;
    }

    public int Sub(int a, int b)
    {
        return a - b;
    }
}
