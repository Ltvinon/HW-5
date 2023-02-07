using System.Text;
using System.Text.RegularExpressions;

public partial class MyRegex
{
    const string Pattern = @"\b(\w+)\b\s+(\b\1\b)";

    [GeneratedRegex(@"\b(\w+)\b\s+(\b\1\b)", RegexOptions.IgnoreCase)]
    static private partial Regex GenRegex();

    static private  Regex DefRegex = new Regex(Pattern, RegexOptions.IgnoreCase);

    static private Regex ComRegex = new Regex(Pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

    static public void DefaultRegex(string text)
    {

        string result = DefRegex.Replace(text, "$1");

        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine(result);

    }

   static  public void CompiledRegex(string text)
    {

        string result = ComRegex.Replace(text, "$1");

        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine(result);

    }
    static public void GeneratedRegex(string text)
    {

        string result = GenRegex().Replace(text, "$1");

        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine(result);

    }

}


