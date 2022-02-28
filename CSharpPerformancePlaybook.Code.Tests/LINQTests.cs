namespace CSharpPerformancePlaybook.Code.Tests
{
    using CSharpPerformancePlaybook.EFCore;
    using System;
    using System.Linq;
    using Xunit;

    public class LINQTests
    {
        [Fact]
        public void LoadBikeStoresLocalWhere()
        {
            var shops = new MyDbContext().Sales_Stores.ToList();

            var bikeShops = shops.Where(x => x.Name.Contains("bike"));

            Console.WriteLine(bikeShops.Count());
        }

        [Fact]
        public void LoadBikeStoresRemoteWhere()
        {
            var shops = new MyDbContext().Sales_Stores;

            var bikeShops = shops.Where(x => x.Name.Contains("bike"));

            Console.WriteLine(bikeShops.Count());
        }
    }
}