using System.Diagnostics;
using Study.LabWork2.Abstractions.Feature.Task1.SubTask1;
using Study.LabWork2.Abstractions.Feature.Task1.SubTask1.DtoModels;

namespace Study.LabWork2.Feature.Task1.SubTask1;

/// <summary>
/// Версия 2. Использует Mutex для синхронизации
/// </summary>
public sealed class MutexService : IPrimeCounter
{
    private readonly Mutex mutex = new Mutex();
    private int primeCount = 0;
    private List<int> foundPrimes;

    public PrimeCountResultDto CountPrimes(int start, int end, int threadCount)
    {
        primeCount = 0;
        foundPrimes = new List<int>();

        var stopWatch = Stopwatch.StartNew();

        var ranges = PrimeCounter.SplitRange(start, end, threadCount);
        var threads = new List<Thread>();

        for (int i = 0; i < threadCount; i++)
        {
            int threadNumber = i + 1;
            var range = ranges[i];
            var thread = new Thread(() => Work(threadNumber, range.start, range.end));
            thread.Start();
            threads.Add(thread);
        }

        foreach (var t in threads) t.Join();

        stopWatch.Stop();

        return new PrimeCountResultDto
        {
            PrimeCount = primeCount,
            ExecutionTime = stopWatch.Elapsed,
            ThreadCount = threadCount,
            SynchronizationType = GetVersionName(),
            FoundPrimes = foundPrimes,
        };
    }

    private void Work(int threadNumber, int start, int end)
    {
        for (int num = start; num <= end; num++)
        {
            Console.WriteLine($"Поток {threadNumber}: обрабатывает число {num}");

            if (PrimeCounter.IsPrime(num))
            {
                mutex.WaitOne();
                try
                {
                    primeCount++;
                    foundPrimes.Add(num);
                }
                finally
                {
                    mutex.ReleaseMutex();
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Поток {threadNumber}: Нашел простое число {num}");
                Console.ResetColor();
            }
        }
    }

    public string GetVersionName() => "Mutex service";
}
