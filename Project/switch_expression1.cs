using System;

class Program
{
    public int square(int n)
    {
        return n * n;
    }

    public int square2(int n) => n * n;

    public static void Main()
    {
        int n = 20;

        int s = n switch { 10 => 11, 20 => 22, 30 => 33, _ => 100 };

        Console.WriteLine(s);

        switch(n)
        {
            case 10: break;
            case 20: break;
            default: break;
        }
    }
}