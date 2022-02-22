namespace CSharpPerformancePlaybook.Benchmarker
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Mathematics;
    using BenchmarkDotNet.Order;

    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    public class StringComparison
    {
        string testString = "Whether tis nobler in the mind to Suffer the slings and arrows";

        [Benchmark()]
        public void EqualityComparison()
        {
            var compare = testString.ToUpper() == "Whether tis nobler in the mind to suffer the slings and arrows".ToUpper();
        }

        [Benchmark()]
        public void EqualsComparison()
        {
            var compare = testString.ToUpper().Equals("Whether tis nobler in the mind to suffer the slings and arrows".ToUpper());
        }

        [Benchmark]
        public void StringCompareComparison()
        {
            var compare = string.Compare(testString, "Whether tis nobler in the mind to suffer the slings and arrows", true);
        }
    }
}
