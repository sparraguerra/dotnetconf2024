//// dotnet run -c Release -f net8.0 --filter "*"
//// dotnet run -c Release -f net9.0 --filter "*"

//using BenchmarkDotNet.Attributes;
//using BenchmarkDotNet.Running;

//BenchmarkSwitcher.FromAssembly(typeof(Tests).Assembly).Run(args);

//[DisassemblyDiagnoser]
//[HideColumns("Job", "Error", "StdDev", "Median", "RatioSD")]
//public class Tests
//{
//    [Benchmark]
//    public int UpwardCounting()
//    {
//        int count = 0;
//        for (int i = 0; i < 100; i++)
//        {
//            count++;
//        }
//        return count;
//    }
//}