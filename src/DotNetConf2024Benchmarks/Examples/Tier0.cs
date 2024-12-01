//// dotnet run -c Release -f net8.0 --filter "*"
//// dotnet run -c Release -f net9.0 --filter "*"

//using System.Runtime.CompilerServices;

//while (true)
//{
//	Test();
//}

//[MethodImpl(MethodImplOptions.NoInlining)]
//static void Test()
//{
//	long gc = GC.GetAllocatedBytesForCurrentThread();
//	for (int i = 0; i < 100; i++)
//	{
//		ThrowIfNull(i);
//	}
//	gc = GC.GetAllocatedBytesForCurrentThread() - gc;

//	Console.WriteLine(gc);
//	Thread.Sleep(1000);
//}

//static void ThrowIfNull<T>(T value) => ArgumentNullException.ThrowIfNull(value);