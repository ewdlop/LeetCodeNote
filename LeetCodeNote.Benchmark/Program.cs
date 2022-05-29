// See https://aka.ms/new-console-template for more information


using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using LeetCodeNote;

var summary = BenchmarkRunner.Run<Test>();

public class ISolution2
{
    private readonly int[] data = new[] { 1, 2, 3 };

    [Benchmark]
    public void Test() => ISolution.Permute(data);
}

public class Test
{
    [Benchmark]
    public void Test1()
    {
        int y = 0;
        foreach(int i in Enumerable.Range(0,100000))
        {
            y++;
        }
        Console.WriteLine(y);
    }
    [Benchmark]
    public void Test2()
    {
        int y = 0;
        foreach (int i in Enumerable.Range(0, 100000).ToList())
        {
            y++;
        }
        Console.WriteLine(y);
    }
}