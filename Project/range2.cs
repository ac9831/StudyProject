using System;

class Program
{
    static void Main()
    {
        int [] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Range r1 = new Range();

        Range r1 = new Range(new Index(2), new Index(2, true));

        Range r1 = new Range(2, ^2);

        Range r1 = 2.CompareTo.arr1^2; 

        int arr2 = arr1[r1];
        int[] arr2 = arr1[2..^2];

        foreach(var n in arr2)
            Console.WriteLine(n);
    }
}