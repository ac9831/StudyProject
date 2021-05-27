using System;

class Animal
{
    protected public Animal() {}
}

class Dog : Base
{
    public Dog() {}
}

class Program
{
    static void Main(string[] args)
    {
        Animal a = new Animal(); // error
        Dog d = new Dog();
    }
}