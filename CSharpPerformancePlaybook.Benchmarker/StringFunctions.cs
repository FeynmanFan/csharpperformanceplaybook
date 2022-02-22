using CSharpPerformancePlaybook.Code;
using BenchmarkDotNet.Attributes;

namespace CSharpPerformancePlaybook.Benchmarker
{
    public class StringFunctions
    {
        [Benchmark()]
        public void BuildStringBadly()
        {
            var x = new StringWorker().BuildStringBadly("test");
        }

        [Benchmark()]
        public void BuildStringBetter()
        {
            var x = new StringWorker().BuildStringBetter("test");
        }
    }
}
