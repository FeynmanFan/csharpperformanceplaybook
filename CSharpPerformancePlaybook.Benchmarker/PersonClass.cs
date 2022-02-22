using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPerformancePlaybook.Benchmarker
{
    public class PersonClass
    {
        public string Name { get; set; }
    }

    public struct PersonStruct
    {
        public string Name { get; set; }
    }
}
