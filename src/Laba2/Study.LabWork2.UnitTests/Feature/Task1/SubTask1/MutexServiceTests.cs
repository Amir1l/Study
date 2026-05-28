using Study.LabWork2.Feature.Task1.SubTask1;

namespace Study.LabWork2.UnitTests.Feature.Task1.SubTask1;

[TestFixture]
public sealed class MutexServiceTests
{
    [Test]
    public void CountPrimes_From1To10000()
    {
        var service = new MutexService();
        var result = service.CountPrimes(1, 10000, 4);
        Assert.That(result.PrimeCount, Is.EqualTo(1229));
    }

    [Test]
    public void GetVersionName()
    {
        var service = new MutexService();
        Assert.That(service.GetVersionName(), Is.EqualTo("Mutex service"));
    }
}
