﻿using BenchmarkDotNet.Attributes;

public class Benchmarks
{
    private string text = "Привіт привіт, це курс курс по дотнету дотнету.";
    [Benchmark]
    public void Compiled()
    {
        MyRegex.CompiledRegex(text);
    }
    [Benchmark]
    public void NotCompiled()
    {
        MyRegex.DefaultRegex(text);
    }
    [Benchmark]
    public void GenRegex()
    {

    }

}