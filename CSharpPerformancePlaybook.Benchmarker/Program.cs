﻿

using BenchmarkDotNet.Running;

var summary = BenchmarkRunner.Run(typeof(Program).Assembly);

Console.WriteLine("$$$$$$$$$$$$$$$$$$" + summary[0].TotalTime);