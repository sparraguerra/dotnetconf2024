//// dotnet run -c Release -f net8.0 --filter "*"

//using BenchmarkDotNet.Attributes;
//using BenchmarkDotNet.Configs;
//using BenchmarkDotNet.Jobs;
//using BenchmarkDotNet.Environments;
//using BenchmarkDotNet.Running;
//using System.Runtime.Intrinsics;

//BenchmarkSwitcher.FromAssembly(typeof(Tests).Assembly).Run(args, DefaultConfig.Instance
//    .AddJob(Job.Default.WithId(".NET 8").WithRuntime(CoreRuntime.Core80).WithEnvironmentVariable("DOTNET_EnableAVX512F", "0").AsBaseline())
//    .AddJob(Job.Default.WithId(".NET 9").WithRuntime(CoreRuntime.Core90).WithEnvironmentVariable("DOTNET_EnableAVX512F", "0")));

//[HideColumns("Job", "Error", "StdDev", "Median", "RatioSD")]
//public class Tests
//{
//    private Vector256<long> _a = Vector256.Create(1, 2, 3, 4);
//    private Vector256<long> _b = Vector256.Create(5, 6, 7, 8);

//    [Benchmark]
//    public Vector256<long> Multiply() => Vector256.Multiply(_a, _b);
//}