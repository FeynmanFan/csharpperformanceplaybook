using BenchmarkDotNet.Attributes;

namespace CSharpPerformancePlaybook.Benchmarker
{
    public class StringFunctions
    {
        string[] words = { "This", "is", "a", "test" };

        [Benchmark()]
        public void PoorlyPerformingStringFunction()
        {
            string resultString = string.Empty;

            foreach(var word in words)
            {
                resultString += word + " ";
            }

            Console.WriteLine(resultString.Trim());
        }

        [Benchmark()]
        public void stringjoin()
        {
            Console.WriteLine(string.Join(' ', words));
        }

        [Benchmark()]
        public void SBJoin()
        {
            Console.WriteLine(new System.Text.StringBuilder().AppendJoin(' ', words));
        }
    }
}
