namespace CSharpPerformancePlaybook.Code.Tests
{
    using System;
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
        public void NaiveSplitName()
        {
            var name = "Behrens, Chris";
            var worker = new StringWorker();

            var lastName = worker.NaiveSplitName(name).lastName;
            var firstName = worker.NaiveSplitName(name).firstName;

            Assert.Equal("Behrens", lastName);
            Assert.Equal("Chris", firstName);
        }

        [Fact]
        public void SplitSplitName()
        {
            var name = "Behrens, Chris";
            var worker = new StringWorker();

            var lastName = worker.SplitSplitName(name).lastName;
            var firstName = worker.SplitSplitName(name).firstName;

            Assert.Equal("Behrens", lastName);
            Assert.Equal("Chris", firstName);
        }

        [Fact]
        public void SpanSplitName()
        {
            var name = "Behrens, Chris";
            var worker = new StringWorker();

            var lastName = worker.SpanSplitName(name).lastName;
            var firstName = worker.SpanSplitName(name).firstName;

            Assert.Equal("Behrens", lastName);
            Assert.Equal("Chris", firstName);
        }

        [Fact]
        public void FunctionsAreEquivalent()
        {
            var sw = new StringWorker();

            var sbad = sw.BuildStringBadly("test");
            var sbetter = sw.BuildStringBetter("test");

            Assert.Equal(sbad, sbetter);
        }

        [Fact]
        public void DateStuff()
        {
            string dateString = "2022-02-22";

            ReadOnlySpan<char> dateSpan = dateString.AsSpan();

            var year = int.Parse(dateSpan.Slice(0, 4));
            var month = int.Parse(dateSpan.Slice(5, 2));
            var day = int.Parse(dateSpan.Slice(8, 2));

            Assert.Equal(2022, year);
            Assert.Equal(2, month);
            Assert.Equal(22, day);
        }
    }
}