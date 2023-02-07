# HW-5
# Benchmarks : 
BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19044.2486/21H2/November2021Update)
AMD Ryzen 5 3550H with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.102
  [Host]     : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2


```
|      Method |     Mean |   Error |  StdDev |
|------------ |---------:|--------:|--------:|
|    Compiled | 145.3 μs | 2.79 μs | 4.17 μs |
| NotCompiled | 158.7 μs | 3.16 μs | 8.81 μs |
|    GenRegex | 157.0 μs | 3.04 μs | 3.62 μs |