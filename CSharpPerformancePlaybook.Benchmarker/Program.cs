

using BenchmarkDotNet.Running;

var summary = BenchmarkRunner.Run(typeof(CSharpPerformancePlaybook.Benchmarker.ClassvStruct));