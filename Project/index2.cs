using System;

class Program
{
    static void Main()
    {
        string s = "ABCDEFGHI";

        int idx1 = 2;
        Index idx2 = new Index(2); // 뒤에서 2번째
        Index idx3 = new Index(2, fromEnd: true); // 뒤에서 2번째

        char c1 = s[idx1]; // C
        char c2 = s[idx2]; // C
        char c3 = s[idx3]; // C

        Console.WriteLine($"{c1}, {c2}, {c3}");
    }
}