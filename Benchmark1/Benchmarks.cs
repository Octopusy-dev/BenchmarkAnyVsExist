using BenchmarkDotNet.Attributes;

using System.Collections.Generic;
using System.Linq;

namespace Benchmark1
{
    public class Benchmarks
    {
        [Benchmark(Baseline = true)]
        public void ScenarioAny()
        {
            // List 100 int
            List<int> list = GetListInts();

            list.Any(x => x > 50);
        }

        private List<int> GetListInts()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }

            return list;
        }

        [Benchmark]
        public void ScenarioExist()
        {
            List<int> list = GetListInts();
            list.Exists(x => x > 50);
        }
    }
}
