//// dotnet run -c Release -f net8.0 --filter "*" --runtimes net8.0 net9.0

//using BenchmarkDotNet.Attributes;
//using BenchmarkDotNet.Running;
//using System.Runtime.CompilerServices;

//BenchmarkSwitcher.FromAssembly(typeof(Tests).Assembly).Run(args);

//[MemoryDiagnoser(false)]
//[HideColumns("Job", "Error", "StdDev", "Median", "RatioSD")]
//public class Tests
//{
//    [Benchmark]
//    public async Task WhenAll()
//    {
//        var atmb1 = new AsyncTaskMethodBuilder();
//        var atmb2 = new AsyncTaskMethodBuilder();
//        Task whenAll = Task.WhenAll([atmb1.Task, atmb2.Task]);
//        atmb1.SetResult();
//        atmb2.SetResult();
//        await whenAll;
//    }
//}