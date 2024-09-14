using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.InProcess.Emit;
using BenchmarkDotNet.Toolchains.InProcess.NoEmit;
using System.Text;

namespace BlogPostTutorials.CodeBenchmarking.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = BenchmarkRunner.Run<BenchmarkDemo>();
        }
    }

    [SimpleJob(RuntimeMoniker.Net48, baseline: true)]
    [SimpleJob(RuntimeMoniker.Net80)]
    [MemoryDiagnoser]
    public class BenchmarkDemo
    {
        [Benchmark]
        public string ConcatenacionSimple()
        {
            string texto = "";
            for (int i = 0; i < 100; i++)
            {
                texto += i;
            }

            return texto;
        }

        [Benchmark]
        public string ConcatenacionConStringBuilder()
        {
            var builder = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                builder.Append(i);
            }

            return builder.ToString();

        }
    }
}