// dotnet run -c Release -f net9.0 --filter "*"

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

BenchmarkSwitcher.FromAssembly(typeof(Tests).Assembly).Run(args);

[MemoryDiagnoser(false)]
[HideColumns("Job", "Error", "StdDev", "Median", "RatioSD")]
public partial class Tests
{
    // download War and Peace from Project Gutenberg
    private static readonly string s_input = new HttpClient().GetStringAsync("https://gutenberg.org/cache/epub/2600/pg2600.txt").Result;

    [GeneratedRegex(@"\b\w+\b")]
    private static partial Regex WordParser();

    [GeneratedRegex(@"\s+")]
    public static partial Regex Whitespace();

    [Benchmark(Baseline = true)]
    public Dictionary<string, int> CountWords()
    {
        string input = s_input;
        Dictionary<string, int> result = new(StringComparer.OrdinalIgnoreCase);

        foreach (Match match in WordParser().Matches(input))
        {
            string word = match.Value;
            result[word] = result.TryGetValue(word, out int count) ? count + 1 : 1;
        }

        return result;
    }

    [Benchmark]
    public Dictionary<string, int> CountWords1()
    {
        ReadOnlySpan<char> input = s_input;

        Dictionary<string, int> result = new(StringComparer.OrdinalIgnoreCase);

        foreach (ValueMatch match in WordParser().EnumerateMatches(input))
        {
            ReadOnlySpan<char> word = input.Slice(match.Index, match.Length);
            string key = word.ToString();
            result[key] = result.TryGetValue(key, out int count) ? count + 1 : 1;
        }

        return result;
    }

    [Benchmark]
    public Dictionary<string, int> CountWords2()
    {
        ReadOnlySpan<char> input = s_input;

        Dictionary<string, int> result = new(StringComparer.OrdinalIgnoreCase);
        Dictionary<string, int>.AlternateLookup<ReadOnlySpan<char>> alternate = result.GetAlternateLookup<ReadOnlySpan<char>>();

        foreach (ValueMatch match in WordParser().EnumerateMatches(input))
        {
            ReadOnlySpan<char> word = input.Slice(match.Index, match.Length);
            alternate[word] = alternate.TryGetValue(word, out int count) ? count + 1 : 1;
        }

        return result;
    }

    [Benchmark]
    public Dictionary<string, int> CountWords3()
    {
        ReadOnlySpan<char> input = s_input;

        Dictionary<string, int> result = new(StringComparer.OrdinalIgnoreCase);
        Dictionary<string, int>.AlternateLookup<ReadOnlySpan<char>> alternate = result.GetAlternateLookup<ReadOnlySpan<char>>();

        foreach (ValueMatch match in WordParser().EnumerateMatches(input))
        {
            ReadOnlySpan<char> word = input.Slice(match.Index, match.Length);
            CollectionsMarshal.GetValueRefOrAddDefault(alternate, word, out _)++;
        }

        return result;
    }

    [Benchmark]
    public Dictionary<string, int> CountWords4()
    {
        string input = s_input;

        Dictionary<string, int> result = new(StringComparer.OrdinalIgnoreCase);
        Dictionary<string, int>.AlternateLookup<ReadOnlySpan<char>> alternate = result.GetAlternateLookup<ReadOnlySpan<char>>();

        foreach (var match in Whitespace().Split(input))
        {
            var word = match;
            alternate[word] = alternate.TryGetValue(word, out int count) ? count + 1 : 1;
        }

        return result;
    }

    [Benchmark]
    public Dictionary<string, int> CountWords5()
    {
        string input = s_input;

        Dictionary<string, int> result = new(StringComparer.OrdinalIgnoreCase);
        Dictionary<string, int>.AlternateLookup<ReadOnlySpan<char>> alternate = result.GetAlternateLookup<ReadOnlySpan<char>>();

        foreach (var range in Whitespace().EnumerateSplits(input))
        {
            var word = input[range];
            alternate[word] = alternate.TryGetValue(word, out int count) ? count + 1 : 1;
        }

        return result;
    }
}