//// dotnet run -c Release -f net8.0 --filter "*" --runtimes net8.0 net9.0

//using BenchmarkDotNet.Attributes;
//using BenchmarkDotNet.Running;
//using System.Runtime.Intrinsics;

//BenchmarkSwitcher.FromAssembly(typeof(Tests).Assembly).Run(args);

//[HideColumns("Job", "Error", "StdDev", "Median", "RatioSD")]
//public class Tests
//{
//    private Vector128<byte> _v1 = Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

//    [Benchmark]
//    public Vector128<byte> Square() => _v1 * _v1;
//}