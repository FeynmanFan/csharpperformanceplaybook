namespace CSharpPerformancePlaybook.Benchmarker
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Mathematics;
    using BenchmarkDotNet.Order;

    [ShortRunJob]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    public class Loops
    {
        // string[] names = { "Chris", "Bob", "Mark", "Sam", "Cindy" };

        public List<string> Names
        {
            get 
            {
                return Resources.Resource1._1000firstnames.Split('\n').ToList();
            }
        }

        //[Benchmark]
        //public void ForLoop()
        //{
        //    var names = Names;

        //    var length = names.Count();

        //    for(var i = 0; i < length; i++)
        //    {
        //        var x= names[i];
        //    }
        //}

        //[Benchmark]
        //public void ForEachLoop()
        //{
        //    var names = Names;

        //    foreach (var name in names)
        //    {
        //        var x = name;
        //    }
        //}

        [Benchmark()]
        public void LoopThroughNames()
        {
            for(var i = 0; i < Names.Count; i++)
            {
                var x = Names[i];
            }
        }

        [Benchmark(Baseline = true)]
        public void CachedLoop()
        {
            var names = Names.ToList();

            foreach(var name in names)
            {
                var x = name;
            }
        }
    }
}
