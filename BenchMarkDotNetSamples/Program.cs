using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using BenchMarkDotNetSamples.tutorials.UseConfig.Benchmarks;
using BenchMarkDotNetSamples.Tutorials.UseConfig.Config;

namespace BenchMarkDotNetSamples.tutorials
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
             * Sample 3
             */

            //run several benchmarks with different configs and union results

            //var config20 = Config20.Create(DefaultConfig.Instance);
            //var config30 = Config30.Create(DefaultConfig.Instance);

            //BenchmarkRunner.Run(new[]{
            //     BenchmarkConverter.TypeToBenchmarks(typeof(ConfigedMd5VsSha256), config20),
            //     BenchmarkConverter.TypeToBenchmarks(typeof(Md5VsSha256), config30)
            // });

            /*
             * Sample 2
             */
            //run several benchmarks and union results

            //var config = Config20.Create(DefaultConfig.Instance);
            //BenchmarkRunner.Run(new[]{
            //     BenchmarkConverter.TypeToBenchmarks(typeof(ConfigedMd5VsSha256), config),
            //     BenchmarkConverter.TypeToBenchmarks(typeof(Md5VsSha256), config)
            // });

            /*
             * Sample 1
             */
            //run benchmark with config from atribute
            //BenchmarkRunner.Run<ConfigedMd5VsSha256>();

            /*
             * Sample 0
             */
            // Run single benchmark
            //var summary = BenchmarkRunner.Run<Md5VsSha256>();
        }
    }
}
