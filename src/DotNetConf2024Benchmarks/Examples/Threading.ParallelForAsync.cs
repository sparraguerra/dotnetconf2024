//// dotnet run -c Release -f net8.0 --filter "*" --runtimes net8.0 net9.0

//using BenchmarkDotNet.Attributes;
//using BenchmarkDotNet.Running;

//BenchmarkSwitcher.FromAssembly(typeof(Tests).Assembly).Run(args);

//[HideColumns("Job", "Error", "StdDev", "Median", "RatioSD")]
//public class Tests
//{
//    [Benchmark]
//    public async Task ParallelForAsync()
//    {
//        await Parallel.ForAsync('\0', '\uFFFF', async (c, _) =>
//        {
//        });
//    }
//}