using System;
using System.Collections.Generic;

class Shape{}
class Circle : Shape{}

class Rectangle : Shape
{
    public double width = 100;
    public double height = 100;
}

class Program
{
    public static List<Shape> group = new List<Shape>();
    
    public static void Draw(Shape s)
    {
        switch (s)
        {
            case var r when (group.Contains(r)) :
                break;

            case Rectangle r:
                break;

            default:
                break;
        }
    }

    public static void Main()
    {
        Draw(new Rectangle());

        int n = 1;
        switch (n)
        {
            // const pattern matching
            case null:
                break;

            // type pattern matching
            case Circle c:
                break;

            case Rectangle r when r.width == r.height:
                break;

            case Rectangle r:

            default:
                break;
        }
    }
}