using Study.LabWork2.Feature.Task1.SubTask1;

namespace Study.LabWork2;

public static class Program
{
    public static void Main()
    {
        var monitorService = new MonitorService();
        var monitorResult = monitorService.CountPrimes(1, 10000, 5);

        var mutexService = new MutexService();
        var mutexResult = mutexService.CountPrimes(1, 10000, 5);

        var semaphoreService = new SemaphoreService();
        var semaphoreResult = semaphoreService.CountPrimes(1, 10000, 5);


        Console.WriteLine(monitorResult.ToString() + "\n");
        Console.WriteLine(mutexResult.ToString() + "\n");
        Console.WriteLine(semaphoreResult.ToString() + "\n");

    }
}
