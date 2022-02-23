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

            for (var i = 0; i < classes.Count(); i++)
            {
                var x = classes.ElementAt(i).Name;
            }
        }

        [Benchmark]
        public void ThousandStructs()
        {
            var structs = Names.Select(x => new PersonStruct { Name = x });

            for (var i = 0; i < structs.Count(); i++)
            {
                var x = structs.ElementAt(i).Name;
            }
        }
        [Benchmark]
        public void ThousandRecordClasses()
        {
            var classes = Names.Select(x => new PersonRecord(x));

            for (var i = 0; i < classes.Count(); i++)
            {
                var x = classes.ElementAt(i).Name;
            }
        }

        [Benchmark]
        public void ThousandRecordStructs()
        {
            var structs = Names.Select(x => new PersonStructRecord (x));

            for (var i = 0; i < structs.Count(); i++)
            {
                var x = structs.ElementAt(i).Name;
            }
        }
    }
}
