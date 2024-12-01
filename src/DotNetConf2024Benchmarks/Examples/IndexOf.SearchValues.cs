//// dotnet run -c Release -f net9.0 --filter "*"

//using BenchmarkDotNet.Attributes;
//using BenchmarkDotNet.Running;
//using System.Buffers;

//BenchmarkSwitcher.FromAssembly(typeof(Tests).Assembly).Run(args);

//[HideColumns("Job", "Error", "StdDev", "Median", "RatioSD")]
//public class Tests
//{
//    private static readonly string s_input = new HttpClient().GetStringAsync("https://gutenberg.org/cache/epub/2600/pg2600.txt").Result;
//    private static readonly string[] s_daysOfWeek = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"];
//    private static readonly SearchValues<char> s_daysOfWeekSV = SearchValues.Create(['S', 's', 'M', 'm', 'T', 't', 'W', 'w', 'F', 'f']);

//    [Benchmark(Baseline = true)]
//    public bool ContainsFirstAprox()
//    {
//        string input = s_input;

//        for (int i = 0; i < input.Length; i++)
//        {
//            foreach (var dow in s_daysOfWeek)
//            {
//                if (input.StartsWith(dow))
//                {
//                    return true;
//                }
//            }
//        }

//        return false;
//    }

//    [Benchmark]
//    public bool ContainsIterate()
//    {
//        ReadOnlySpan<char> input = s_input;

//        for (int i = 0; i < input.Length; i++)
//        {
//            foreach (string dow in s_daysOfWeek)
//            {
//                if (input.Slice(i).StartsWith(dow, StringComparison.OrdinalIgnoreCase))
//                {
//                    return true;
//                }
//            }
//        }

//        return false;
//    }

//    [Benchmark]
//    public bool ContainsIterateSwitch()
//    {
//        ReadOnlySpan<char> input = s_input;

//        for (int i = 0; i < input.Length; i++)
//        {
//            ReadOnlySpan<char> slice = input.Slice(i);
//            switch ((char)(input[i] | 0x20))
//            {
//                case 's' when slice.StartsWith("Sunday", StringComparison.OrdinalIgnoreCase) ||
//                              slice.StartsWith("Saturday", StringComparison.OrdinalIgnoreCase):
//                case 'm' when slice.StartsWith("Monday", StringComparison.OrdinalIgnoreCase):
//                case 't' when slice.StartsWith("Tuesday", StringComparison.OrdinalIgnoreCase) ||
//                              slice.StartsWith("Thursday", StringComparison.OrdinalIgnoreCase):
//                case 'w' when slice.StartsWith("Wednesday", StringComparison.OrdinalIgnoreCase):
//                case 'f' when slice.StartsWith("Friday", StringComparison.OrdinalIgnoreCase):
//                    return true;
//            }
//        }

//        return false;
//    }

//    [Benchmark]
//    public bool ContainsIndexOfAnyFirstCharsSearchValues()
//    {
//        ReadOnlySpan<char> input = s_input;

//        int i;
//        while ((i = input.IndexOfAny(s_daysOfWeekSV)) >= 0)
//        {
//            ReadOnlySpan<char> slice = input.Slice(i);
//            switch ((char)(input[i] | 0x20))
//            {
//                case 's' when slice.StartsWith("Sunday", StringComparison.OrdinalIgnoreCase) ||
//                              slice.StartsWith("Saturday", StringComparison.OrdinalIgnoreCase):
//                case 'm' when slice.StartsWith("Monday", StringComparison.OrdinalIgnoreCase):
//                case 't' when slice.StartsWith("Tuesday", StringComparison.OrdinalIgnoreCase) ||
//                              slice.StartsWith("Thursday", StringComparison.OrdinalIgnoreCase):
//                case 'w' when slice.StartsWith("Wednesday", StringComparison.OrdinalIgnoreCase):
//                case 'f' when slice.StartsWith("Friday", StringComparison.OrdinalIgnoreCase):
//                    return true;
//            }

//            input = input.Slice(i + 1);
//        }

//        return false;
//    }

//    [Benchmark]
//    public bool ContainsStringSearchValues() => s_input.AsSpan().ContainsAny(s_daysOfWeekSV);
//}