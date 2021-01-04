# BenchmarkPointerMath


``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18362.1016 (1903/May2019Update/19H1)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
  [Host]     : .NET Framework 4.8 (4.8.4200.0), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Framework 4.8 (4.8.4200.0), X64 RyuJIT


```
|             Method |     Mean |    Error |   StdDev |
|------------------- |---------:|---------:|---------:|
|     TestClassicFor | 51.70 μs | 0.657 μs | 0.583 μs |
| TestClassicForEach | 50.88 μs | 0.476 μs | 0.445 μs |
|    TestPointerMath | 25.15 μs | 0.059 μs | 0.055 μs |