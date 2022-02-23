namespace CSharpPerformancePlaybook.Benchmarker
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Mathematics;
    using BenchmarkDotNet.Order;

    [ShortRunJob]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    public class Assignment
    {
        [Benchmark]
        public void PropertyAssignment()
        {
            foreach (var name in new Loops().Names)
            {
                var person = new PersonStruct();

                person.Name = name;
            }
        }

        [Benchmark]
        public void DirectAssignment()
        {
            foreach (var name in new Loops().Names)
            {
                var person = new PersonStruct();

                person.name = name;
            }
        }
    }
}
