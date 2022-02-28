

using BenchmarkDotNet.Running;

// var summary = BenchmarkRunner.Run(typeof(CSharpPerformancePlaybook.Benchmarker.Assignment));
// var summary = BenchmarkRunner.Run(typeof(CSharpPerformancePlaybook.Benchmarker.Perms));
// var summary = BenchmarkRunner.Run(typeof(CSharpPerformancePlaybook.Benchmarker.DateStuff));
// var summary = BenchmarkRunner.Run(typeof(CSharpPerformancePlaybook.Benchmarker.DBCalls));
var summary = BenchmarkRunner.Run(typeof(CSharpPerformancePlaybook.Benchmarker.LINQStuff));