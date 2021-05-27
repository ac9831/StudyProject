using System;

class Program
{
    static void Main()
    {
        int? n2 = null;

    
#nullable enable    // 참조 타입 변수를 null을 대입하면 경고..
        string s1 = null;
        string? s2 = null;
#nullable disable   

        int n = s1.Length;
    }
}