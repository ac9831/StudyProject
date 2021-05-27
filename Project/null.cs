using System;

class Program
{
    public static void Main()
    {
        string s1 = null;

        // C# 6.0
        string s2 = s1 ?? "hello";

        // C# 8.0
        s1 ??= "world";

        Console.WriteLine(s1);
    }
}