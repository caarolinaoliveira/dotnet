// See https://aka.ms/new-console-template for more information
// Fatorial 4 = 4 * 3 *2 *1

using System;

public class Program
{
    public static void Main()
    {
        fatorial(5);
    }

    static void fatorial(int n)
    {
        int fatorial = 1;
        for (int i = n; i > 0; i--)
        {
            fatorial *= i;
        }
        Console.WriteLine(fatorial);
    }
}