namespace CSharpPerformancePlaybook.Benchmarker
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Mathematics;
    using BenchmarkDotNet.Order;
    using CSharpPerformancePlaybook.Code;

    [ShortRunJob]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    public class Perms
    {
        string permsFilePath = @"C:\code\cspp\permsfile.txt";

        [GlobalSetup]
        public void Setup()
        {
            FilePermissionsChecker.LoadACL();
        }

        [Benchmark]
        public void QuickAndDirty()
        {
            var x = FilePermissionsChecker.CheckPermissionQD(permsFilePath);
        }

        [Benchmark]
        public void ProperCheck()
        {
            var x = FilePermissionsChecker.CheckPermission(permsFilePath);
        }

        [Benchmark]
        public void FileACLCheck()
        {
            var x = FilePermissionsChecker.CheckPermissionFC(permsFilePath);
        }
    }
}
