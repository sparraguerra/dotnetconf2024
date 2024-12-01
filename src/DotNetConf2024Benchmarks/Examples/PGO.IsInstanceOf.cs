//// dotnet run -c Release -f net8.0 --filter "*" --runtimes net8.0 net9.0

//using BenchmarkDotNet.Attributes;
//using BenchmarkDotNet.Running;

//BenchmarkSwitcher.FromAssembly(typeof(Tests).Assembly).Run(args);

//[DisassemblyDiagnoser(maxDepth: 0)]
//[HideColumns("Job", "Error", "StdDev", "Median", "RatioSD")]
//public class Tests
//{
//    private A _obj = new C();
//    private object _obj2 = "hello";

//    [Benchmark]
//    public bool IsInstanceOf() => _obj is B;

//    public class A { }
//    public class B : A { }
//    public class C : B { }

//    [Benchmark]
//    public bool IsInstanceOfTests() => _obj2 is Tests;
//}