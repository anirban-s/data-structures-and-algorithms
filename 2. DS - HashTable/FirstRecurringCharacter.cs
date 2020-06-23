using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 5, 8, 5, 1, 8, 8, 7, 4, 4, 10 };
        Console.Write(FindFirstRecurringChar(arr));
    }

    static int FindFirstRecurringChar(int[] arr)
    {
        Hashtable h = new Hashtable();
        for (int i = 0; i < arr.Length; i++)
        {
            if(h.ContainsKey(arr[i]))
            {
                return arr[i];
            }
            h[arr[i]] = arr[i];
        }
        return 0;
    }
}