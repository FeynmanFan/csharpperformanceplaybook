namespace CSharpPerformancePlaybook.Benchmarker.Tests
{
    using BenchmarkDotNet.Configs;
    using BenchmarkDotNet.Mathematics;
    using BenchmarkDotNet.Reports;
    using BenchmarkDotNet.Running;
    using System.Linq;
    using Xunit;

    public class PermsBenchmarks
    {
        Summary summary;

        public PermsBenchmarks()
        {
            summary = BenchmarkRunner.Run(typeof(Perms), new DebugBuildConfig());
        }

        [Fact]
        public void FileACLWithinSpec()
        {
            var mean = GetReport(summary, "Perms.FileACLCheck").Mean;

            Assert.True(mean > 0 && mean < 500, "Mean was " + mean);
        }

        public static Statistics GetReport(Summary summary, string key)
        {
            return summary.Reports.FirstOrDefault(x => string.Compare(x.BenchmarkCase.Descriptor.DisplayInfo, key, true) == 0)?.ResultStatistics;
        }
    }
}