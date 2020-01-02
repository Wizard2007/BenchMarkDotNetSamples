using BenchmarkDotNet.Attributes;
using BenchMarkDotNetSamples.Tutorials.UseConfig.Config;

namespace BenchMarkDotNetSamples.Tutorials.UseConfig.Benchmarks
{
    [Config(typeof(ConfigIterationCount20))]
    public class ConfigedMd5VsSha256 : Md5VsSha256
    {
    }
}
