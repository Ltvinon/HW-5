using BenchmarkDotNet.Running;
using System.Text;
using System.Text.RegularExpressions;


class Program
{
    static void Main(string[] args)
    {
        string text = "Привіт привіт, це курс курс по дотнету дотнету.";

        string pattern = @"\b(\w+)\b\s+(\b\1\b)";

        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

        string result = regex.Replace(text, "$1");

        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine(result);

        //BenchmarkRunner.Run<Benchmarks>();
    }
}

