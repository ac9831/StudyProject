using System;

class Base
{
    public Base() { WriteLine("Base()"); }
    public Base(int n) { WriteLine("Base(int)"); }
}

class Derived : Base
{
    public Derived() : base() { WriteLine("Derived()"); }
    public Derived(int n) : base(n) {WriteLine("Derived(int)"); }
}

class Program
{
    static void Main(string[] args)
    {
        Derived d = new Derived();
    }
}