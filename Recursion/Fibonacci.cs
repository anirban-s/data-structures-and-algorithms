using System;

class Fibonacci
{
    //O(2^n)
    public static int fibonacciRecursively(int n)
    { 
        if (n < 2)
        {
            return n;
        }
        return fibonacciRecursively(n - 1) + fibonacciRecursively(n - 2);
    }

    //O(n)
    public static int fibonacciRecursivelyEfficient(int n, int val, int prev)
    {
        if (n == 0)
        {
            return prev;
        }
        if (n == 1)
        {
            return val;
        }
        return fibonacciRecursivelyEfficient(n - 1, val + prev, val);
    }

    //O(n)
    public static int fibonacciIteratively(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        int result = 1;
        int lastNumber = 0;
        int temp;
        for (int i = 1; i < n; i++)
        {
            temp = result;
            result += lastNumber;
            lastNumber = temp;
        }
        return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(fibonacciRecursively(10));
        Console.WriteLine(fibonacciRecursivelyEfficient(10, 1 , 0));
        Console.WriteLine(fibonacciIteratively(10));
    }
}