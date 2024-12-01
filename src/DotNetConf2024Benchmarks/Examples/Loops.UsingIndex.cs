//// dotnet run -c Release -f net8.0 --filter "*" --runtimes net8.0 net9.0

//using BenchmarkDotNet.Attributes;
//using BenchmarkDotNet.Running;

//BenchmarkSwitcher.FromAssembly(typeof(Tests).Assembly).Run(args);

//[DisassemblyDiagnoser]
//[HideColumns("Job", "Error", "StdDev", "Median", "RatioSD")]
//public class Tests
//{
//    private int[] _array = Enumerable.Range(0, 1000).ToArray();

//    [Benchmark]
//    public int Sum()
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