namespace CSharpPerformancePlaybook.Benchmarker
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Mathematics;
    using BenchmarkDotNet.Order;

    [ShortRunJob]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    public class Caching
    {
        [Benchmark]
        public string ChristmasEveDayofWeek()
        {
            var christmasEve = new DateTime(LongRunningOperation(), 12, 24);

            return christmasEve.DayOfWeek.ToString();
        }

        public int LongRunningOperation()
        {
            Thread.Sleep(1000);
            return DateTime.Today.Year;
        }
    }
}
