using System;
using System.Text;

class ReverseString
{
    public static String reverseStringRecursively(string str)
    {
        if (str.Length == 0)
        {
            return "";
        }
        return reverseStringRecursively(str.Substring(1)) + str[0];
    }

    public static String reverseStringIteratively(string str)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < str.Length; i++)
        {
            result.Append(str[str.Length - 1 - i]);
        }
        return result.ToString();
    }

    static void Main(string[] args)
    {
        Console.WriteLine(reverseStringRecursively("123456"));
        Console.WriteLine(reverseStringIteratively("123456"));
    }
}