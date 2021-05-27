using System;
using System.Collections;

class NumCollections
{
    private int[] arr = new int[5] { 1,2,3,4,5 };

    public IEnumerable GetEnumerator()
    {
        Console.WriteLine("arr의 유효성");
        if ( arr == null ) throw new Exception("null");

        return implenetaion();
        
        // C#에 코루틴을 확인할 것
        IEnumerator implenetaion()
        {
            foreach( int n in arr )
            {
                yield return n;
            }
        }
    }
}

class Program
{
    public static void Main()
    {
        NumCollections nums = new NumCollections();
        IEnumerator it = nums.GetEnumerator();

        Console.WriteLine("After GetEnumerator");
        while( it.MoveNext() )
        {
            Console.WriteLine(it.Current);
        }
    }
}