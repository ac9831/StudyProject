using System;

class Program
{
    static void Main()
    {
        Index idx = ^3; // 값과 방향을 함께 저장

        int n = idx.Value;      // 3
        bool b = idx.IsFormEnd; // true

        Console.WriteLine($"{n}, {b}");
    }
}