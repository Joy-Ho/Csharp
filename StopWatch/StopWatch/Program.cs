using System.Diagnostics;

var stopwatch = Stopwatch.StartNew();

for(int i = 0; i < 1000; i++)
{
    Console.WriteLine($"Loop number {i}");
}

stopwatch.Stop();
Console.WriteLine("Time is ms: " + stopwatch.ElapsedMilliseconds);