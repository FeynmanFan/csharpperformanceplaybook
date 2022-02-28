namespace CSharpPerformancePlaybook.Benchmarker
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Mathematics;
    using BenchmarkDotNet.Order;
    using CSharpPerformancePlaybook.EFCore;

    [ShortRunJob]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    [MemoryDiagnoser]
    public class LINQStuff
    {
        [Benchmark]
        public void LoadBikeStoresLocalWhere()
        {
            var shops = new MyDbContext().Sales_Stores.ToList();

            var bikeShops = shops.Where(x => x.Name.Contains("bike"));

            Console.WriteLine(bikeShops.Count());
        }

        [Benchmark(Baseline =true)]
        public void LoadBikeStoresRemoteWhere()
        {
            var shops = new MyDbContext().Sales_Stores;

            var bikeShops = shops.Where(x => x.Name.Contains("bike"));

            Console.WriteLine(bikeShops.Count());
        }
    }
}
