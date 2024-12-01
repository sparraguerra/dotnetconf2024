//// dotnet run -c Release -f net8.0 --filter "*"
//// dotnet run -c Release -f net9.0 --filter "*"

//using BenchmarkDotNet.Attributes;
//using BenchmarkDotNet.Running;

//BenchmarkSwitcher.FromAssembly(typeof(Tests).Assembly).Run(args);

//[DisassemblyDiagnoser(maxDepth: 0)]
//[HideColumns("Job", "Error", "StdDev", "Median", "RatioSD")]
//public class Tests
//{
//    private int[] _array = new int[1000];

//    [Benchmark]
//    public int Test()
//    {
//        int[] array = _array;

//        int sum = 0;
//        for (int i = 0; i < array.Length; i++)
//        {
//            sum += array[i];
//        }
//        return sum;
//    }
//}