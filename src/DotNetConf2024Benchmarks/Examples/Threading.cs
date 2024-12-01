//// dotnet run -c Release -f net9.0 --filter "*"

//using BenchmarkDotNet.Attributes;
//using BenchmarkDotNet.Running;

//BenchmarkSwitcher.FromAssembly(typeof(Tests).Assembly).Run(args);

//[HideColumns("Job", "Error", "StdDev", "Median", "RatioSD")]
//public class Tests
//{
//    private readonly object _monitor = new();
//    private readonly Lock _lock = new();
//    private int _value;

//    [Benchmark]
//    public void WithMonitor()
//    {
//        lock (_monitor)
//        {
//            _value++;
//        }
//    }

//    [Benchmark]
//    public void WithLock()
//    {
//        lock (_lock)
//        {
//            _value++;
//        }
//    }
//}