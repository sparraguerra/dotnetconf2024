//// Add a <PackageReference Include="System.Numerics.Tensors" Version="9.0.0" /> to the csproj.
//// dotnet run -c Release -f net9.0 --filter "*"

//using BenchmarkDotNet.Attributes;
//using BenchmarkDotNet.Running;
//using System.Numerics.Tensors;

//BenchmarkSwitcher.FromAssembly(typeof(Tests).Assembly).Run(args);

//[HideColumns("Job", "Error", "StdDev", "Median", "RatioSD")]
//public class Tests
//{
//    private byte[] _x, _y;

//    [GlobalSetup]
//    public void Setup()
//    {
//        var r = new Random(42);
//        _x = Enumerable.Range(0, 1024).Select(_ => (byte)r.Next(0, 256)).ToArray();
//        _y = Enumerable.Range(0, 1024).Select(_ => (byte)r.Next(0, 256)).ToArray();
//    }

//    [Benchmark(Baseline = true)]
//    public int ManualLoop()
//    {
//        ReadOnlySpan<byte> source = _x;
//        Span<byte> destination = _y;
//        int count = 0;
//        for (int i = 0; i < source.Length; i++)
//        {
//            if (source[i] != destination[i])
//            {
//                count++;
//            }
//        }
//        return count;
//    }

//    [Benchmark]
//    public int BuiltIn() => TensorPrimitives.HammingDistance<byte>(_x, _y);
//}