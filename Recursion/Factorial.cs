using System;

class Factorial
{
    public static long findFactorialRecursively(int number)
    { 
        if (number == 1)
        {
            return 1;
        }
        return number * findFactorialRecursively(number - 1);
    }

    public static long findFactorialIteratively(int number)
    { 
        long result = 1;
        for (int i = number; i > 0; i--)
        {
            result *= i;
        }
        return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(findFactorialRecursively(10));
        Console.WriteLine(findFactorialIteratively(10));
    }
}