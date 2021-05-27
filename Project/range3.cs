using System;

class Program
{
    public static void Main() 
    {
        string s = "ABCDEFGHIJ";

        Range r1 = new Range();
        Range r2 = new Range(2, ^2);

        // 정적 메소드 사용
        Range r3 = Range.All;
        Range r4 = Range.StartAt(4);
        Range r6 = Range.EndAt(4);

        // 단축 표기법
        Range r6 = 2..7;
        Range r7 = 2..^2;
        Range r8 = ..4; // ABCD
        Range r9 = 4..; // EFGHIJ

        Console.WriteLine($"${s[r8]}, {s[r9]}");

    }
}