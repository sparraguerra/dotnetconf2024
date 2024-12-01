//// dotnet run -c Release -f net8.0 --filter "*" --runtimes net8.0 net9.0

//using BenchmarkDotNet.Attributes;
//using BenchmarkDotNet.Running;

//BenchmarkSwitcher.FromAssembly(typeof(Tests).Assembly).Run(args);

//[MemoryDiagnoser(false)]
//[DisassemblyDiagnoser]
//[HideColumns("Job", "Error", "StdDev", "Median", "RatioSD")]
//public class Tests
//{
//    [Benchmark]
//    public int GetValue() => new MyObj(42).Value;

//    private class MyObj
//    {
//        public MyObj(int value) => Value = value;
//        public int Value { get; }
//    }
//}