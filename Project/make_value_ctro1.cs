using System;

struct SPoint
{
    public int x;
    public int y;
    public int cnt;
    
    public SPoint(int a, int b)
    {
        x = a;
        y = b;
    }
}

class Program
{
    public static void Main()
    {
        SPoint pt = new SPoint(1, 2);
    }
}