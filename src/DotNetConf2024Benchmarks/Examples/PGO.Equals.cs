//// dotnet run -c Release -f net8.0 --filter "*"

//using BenchmarkDotNet.Attributes;
//using BenchmarkDotNet.Configs;
//using BenchmarkDotNet.Environments;
//using BenchmarkDotNet.Jobs;
//using BenchmarkDotNet.Running;

//var config = DefaultConfig.Instance
//    .AddJob(Job.Default.WithId(".NET 8").WithRuntime(CoreRuntime.Core80).WithEnvironmentVariable("DOTNET_ReadyToRun", "0"))
//    .AddJob(Job.Default.WithId(".NET 9").WithRuntime(CoreRuntime.Core90).WithEnvironmentVariable("DOTNET_ReadyToRun", "0"));
//BenchmarkSwitcher.FromAssembly(typeof(Tests).Assembly).Run(args, config);

//[DisassemblyDiagnoser(maxDepth: 0)]
//[HideColumns("Job", "Error", "StdDev", "Median", "RatioSD", "a", "b")]
//public class Tests
//{
//    [Benchmark]
//    [Arguments("abcd", "abcg")]
//    public bool Equals(string a, string b) => a == b;
//}