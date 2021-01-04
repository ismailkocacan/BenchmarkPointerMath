using System;
using BenchmarkDotNet.Running;

unsafe class Program
{  
    static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<WhichFast>();
        Console.ReadLine();
    }
}