using System;

class Program
{
    static void Main()
    {
        Index i1 = new Index(3);
        Index i2 = new Index(3, fromEnd: true);

        Index i3 = Index.FromStart(3);
        Index i4 = Index.FromEnd(3);

        Index i5 = 3;
        Index i6 = ^3;

        string s = "ABCDEFGHI";
        char c1 = s[^3];
        char c2 = s[new Index(3, fromEnd: true)];
    }
}