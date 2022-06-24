// See https://aka.ms/new-console-template for more information


using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using LeetCodeNote;

var summary = BenchmarkRunner.Run<Test2>();

[MemoryDiagnoser]
public class Test2
{
    [Benchmark]
    public void Test()
    {
        var x = Solution.NumberToWords(23);
    }

    [Benchmark]
    public void Test3()
    {
        var x = Solution.LESS_THAN_20;
        var y = Solution.LESS_THAN_20;
    }
}

public class ISolution2
{
    private readonly int[] data = new[] { 1, 2, 3 };

    [Benchmark]
    public void Test() => Solution.Permute(data);
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