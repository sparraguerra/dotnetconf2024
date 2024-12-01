//// Add a <PackageReference Include="Microsoft.Extensions.DependencyInjection" Version="8.0.0" /> to the csproj.
//// dotnet run -c Release -f net8.0 --filter "*"

//using BenchmarkDotNet.Attributes;
//using BenchmarkDotNet.Configs;
//using BenchmarkDotNet.Environments;
//using BenchmarkDotNet.Jobs;
//using BenchmarkDotNet.Running;
//using Microsoft.Extensions.DependencyInjection;

//var config = DefaultConfig.Instance
//    .AddJob(Job.Default.WithRuntime(CoreRuntime.Core80)
//        .WithNuGet("Microsoft.Extensions.DependencyInjection", "8.0.0")
//        .WithNuGet("Microsoft.Extensions.DependencyInjection.Abstractions", "8.0.1").AsBaseline())
//    .AddJob(Job.Default.WithRuntime(CoreRuntime.Core90)
//        .WithNuGet("Microsoft.Extensions.DependencyInjection", "9.0.0-rc.1.24431.7")
//        .WithNuGet("Microsoft.Extensions.DependencyInjection.Abstractions", "9.0.0-rc.1.24431.7"));
//BenchmarkSwitcher.FromAssembly(typeof(Tests).Assembly).Run(args, config);

//[MemoryDiagnoser(false)]
//[HideColumns("Job", "Error", "StdDev", "Median", "RatioSD", "NuGetReferences")]
//public class Tests
//{
//    private IServiceProvider _serviceProvider = new ServiceCollection().BuildServiceProvider();

//    [Benchmark]
//    public MyClass Create() => ActivatorUtilities.CreateInstance<MyClass>(_serviceProvider, 1, 2, 3);

//    public class MyClass
//    {
//        public MyClass() { }
//        public MyClass(int a) { }
//        public MyClass(int a, int b) { }
//        [ActivatorUtilitiesConstructor]
//        public MyClass(int a, int b, int c) { }
//    }
//}