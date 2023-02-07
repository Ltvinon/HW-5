using System.Text;
using System.Text.RegularExpressions;

public class MyRegex
{
     static public void DefaultRegex(string text)
    {
        string pattern = @"\b(\w+)\b\s+(\b\1\b)";

        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

        string result = regex.Replace(text, "$1");

        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine(result);

    }

   static  public void CompiledRegex(string text)
    {
        string pattern = @"\b(\w+)\b\s+(\b\1\b)";

        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);

        string result = regex.Replace(text, "$1");

        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine(result);

    }
    
    static public void GenRegex(string text)
    {
        string pattern = @"\b(\w+)\b\s+(\b\1\b)";

        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);

        string result = regex.Replace(text, "$1");

        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine(result);

    }
}

