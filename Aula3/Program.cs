// Fibonacci 

// 0 1 1 2 3 5 8 

// using System;

// public class Program
// {
//     public static void Main()
//     {
//         int n= 6
//         fibonacci(n);
//     }

//    static void fibonacci(int n){
//     int [] fib = new int[n];
//     fib[0] =0;
//     fib[1] =1;
//     for (int i = 2; i<n; i++){
//         fib[i] = fib[i-1] + fib[i-2]; } 

//    }
//    foreach (int num in fib)
//    {
//     System.Console.WriteLine(num);
//    }
// }}


using System;

public class Program
{
    public static void Main()
    {
        int n = 6;
        fibonacci(n);
    }

    static void fibonacci(int n)
    {
        int[] fib = new int[n];
        fib[0] = 0;
        fib[1] = 1;

        for (int i = 2; i < n; i++)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
        }

        foreach (int num in fib)
        {
            Console.WriteLine(num);
        }
    }
}
