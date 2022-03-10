namespace CSharpPerformancePlaybook.Benchmarker
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Mathematics;
    using BenchmarkDotNet.Order;

    [ShortRunJob]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    public class Async
    {
        IEnumerable<int> numbers = Enumerable.Range(1, 1000);

        [Benchmark()]
        public int NotAsync()
        {
            int result = 0;

            foreach(var number in numbers)
            {
                result += number;
            }

            return result;
        }
    }
}
