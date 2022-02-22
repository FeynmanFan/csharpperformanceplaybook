namespace CSharpPerformancePlaybook.Benchmarker
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Mathematics;
    using BenchmarkDotNet.Order;

    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    public class ClassvStruct
    {
        public List<string> Names
        {
            get
            {
                return new Loops().Names;
            }
        }

        [Benchmark]
        public void ThousandClasses()
        {
            var classes = Names.Select(x => new PersonClass { Name = x });
        }

        [Benchmark]
        public void ThousandStructs()
        {
            var classes = Names.Select(x => new PersonStruct { Name = x });
        }
    }
}
