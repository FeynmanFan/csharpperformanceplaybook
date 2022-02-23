namespace CSharpPerformancePlaybook.Benchmarker
{
    public class PersonClass
    {
        public string Name { get; set; }

        public string name;
    }

    public struct PersonStruct
    {
        public string Name { get; set; }

        public string name;
    }

    public record PersonRecord(string Name);

    public record struct PersonStructRecord(string Name);
}
