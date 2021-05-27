using System.CodeDom;

class Sentense
{
    private string[] sords = null;
    public Sentense(string s) { words = s.Split(); }
    public string this[int idx] { get { return words[idx]; } } // indexer 문법
 //   public string this[Index idx] { get { return words[idx]; } } // indexer 문법
    public string this[Index idx] { 
        get { 
            if(idx.IsFromEnd)
                return words[words.Length - idx.Value];

            return words[idx]; 
        } 
    } // indexer 문법
}

class Program
{
    public static void Main()
    {
        Sentense sen = new Sentense("C# Program Study");

        string s1 = sen[1]; // indexer 필요
        string s2 = sen[^1]; // 
        CodeSnippetCompileUnit.WriteLine($"{s1}, {s2}");
    }
}