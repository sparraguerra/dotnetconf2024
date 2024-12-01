//// dotnet run -c Release -f net8.0 --filter "*" --runtimes net8.0 net9.0

//using BenchmarkDotNet.Attributes;
//using BenchmarkDotNet.Running;
//using System.Runtime.CompilerServices;

//BenchmarkSwitcher.FromAssembly(typeof(Tests).Assembly).Run(args);

//[DisassemblyDiagnoser]
//[MemoryDiagnoser(false)]
//[HideColumns("Job", "Error", "StdDev", "Median", "RatioSD")]
//public class Tests
//{
//    [Benchmark]
//    public void Test()
//    {
//        Dispose1<MyStruct>(default);
//        Dispose2<MyStruct>(default);
//    }

//    [MethodImpl(MethodImplOptions.NoInlining)]
//    private bool Dispose1<T>(T o)
//    {
//        bool disposed = false;
//        if (o is IDisposable disposable)
//        {
//            disposable.Dispose();
//            disposed = true;
//        }
//        return disposed;
//    }

//    [MethodImpl(MethodImplOptions.NoInlining)]
//    private bool Dispose2<T>(T o)
//    {
//        bool disposed = false;
//        if (o is IDisposable)
//        {
//            ((IDisposable)o).Dispose();
//            disposed = true;
//        }
//        return disposed;
//    }

//    private struct MyStruct : IDisposable
//    {
//        public void Dispose() { }
//    }
//}