using System;

class Sentense
{
    private string[] words = null;
    public Sentense(string s) { words = s.Split(); }

    public string this[int idx] { get {return words[idx]; } }
    public int Length { get { return words.Length; } }
    public int Count { get { return words.Length; } } 
}

class Program
{
    public static void Main()
    {
        Sentense sen = new Sentense("C# Program Study");

        string s1 = sen[1];
        string s2 = sen[^1]; // 1. this[Index] 검색
                            // 2. sen[ sen.Length - 1]
        Console.WriteLine($"{s1}, {s2}");               // 3. sen[ sen.Count - 1]

    }

}