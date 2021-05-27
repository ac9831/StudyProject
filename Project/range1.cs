using System;

class Program
{
    static void Main()
    {
        string s1 = "ABCDEFGHIJ";

        char c = s1[2]; // C

        string s2 = s1[2..7];  // 7 포함 안됨
        string s3 = s1[2..^3];

        Console.WriteLine($"{c}, {s2}, {s3}");
    }
}