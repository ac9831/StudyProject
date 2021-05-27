using System;

abstract class AAA{}
static class BBB{}

public class Point
{
    public int x;
    public int y;

    public Point(int x, int y)
    {
      
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point pt = new Point(1, 2);
        Console.WriteLine($"{pt.x}, {pt.y}");
    }
}