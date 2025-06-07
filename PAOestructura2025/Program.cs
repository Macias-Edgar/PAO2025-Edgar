using System;

class Program
{
    // Suma dos enteros
    static int Sumar(int a, int b) => a + b;

    // Resta dos decimales
    static double Restar(double a, double b) => a - b;

    static void Main()
    {
        Console.WriteLine("UNIVERSIDAD ESTATAL AMAZÓNICA\n");

        Console.WriteLine("Suma: " + Sumar(4, 6));
        Console.WriteLine("Resta: " + Restar(10.5, 3.2));
    }
}