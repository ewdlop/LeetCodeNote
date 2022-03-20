// See https://aka.ms/new-console-template for more information


using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using LeetCodeNote;

var summary = BenchmarkRunner.Run<ISolution2>();

public class ISolution2
{
    private readonly int[] data = new[] { 1, 2, 3 };

    [Benchmark]
    public void Test() => ISolution.Permute(data);
    [Benchmark]
    public void Tes2t() => ISolution.Permute2(data);
}