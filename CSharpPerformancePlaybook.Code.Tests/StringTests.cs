namespace CSharpPerformancePlaybook.Code.Tests
{
    using Xunit;

    public class StringTests
    {
        [Fact]
        public void BuildStringBadly()
        {
            var s = new StringWorker().BuildStringBadly("test");

            Assert.Equal("test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test", s);
        }

        [Fact]
        public void BuildStringBetter()
        {
            var s = new StringWorker().BuildStringBetter("test");

            Assert.Equal("test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test", s);
        }

        [Fact]
        public void FunctionsAreEquivalent()
        {
            var sw = new StringWorker();

            var sbad = sw.BuildStringBadly("test");
            var sbetter = sw.BuildStringBetter("test");

            Assert.Equal(sbad, sbetter);
        }
    }
}