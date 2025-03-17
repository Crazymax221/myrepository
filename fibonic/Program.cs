
using System;

static class FibonacciHelper
{
    public static int GetFibonacci(int n)
    {
        if (n < 0)
            throw new ArgumentException("The Fibonacci number must be non-negative..");

        if (n == 0) return 0;
        if (n == 1) return 1;

        return GetFibonacci(n - 1) + GetFibonacci(n - 2);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the Fibonacci number: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            try
            {
                int result = FibonacciHelper.GetFibonacci(n);
                Console.WriteLine($"Fibonacci number at number {n}: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: " + ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Invalid number entered!");
        }
    }
}

//:P