using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Reports;

namespace BenchMarkDotNetSamples.Tutorials.UseConfig.Config
{
    public class ConfigIterationCount30 : ManualConfig
    {
        public ConfigIterationCount30()
        {
            UnionRule = ConfigUnionRule.Union;
            Options = this.Options | ConfigOptions.JoinSummary;
            SummaryStyle = SummaryStyle.Default.WithMaxParameterColumnWidth(50);

            Add(
                Job.Default
                    .With(RunStrategy.Monitoring)
                    .With(Jit.RyuJit)
                    .With(Platform.X64)
                    .With(ClrRuntime.Net461)
                    .WithIterationCount(30)
                    .WithLaunchCount(1)
                    .WithWarmupCount(1)
            );

            Add(StatisticColumn.Mean,
                StatisticColumn.Min,
                StatisticColumn.Max,
                StatisticColumn.Error,
                StatisticColumn.StdDev);

            Add(CsvExporter.Default);
            Add(CsvMeasurementsExporter.Default);
            Add(HtmlExporter.Default);
            Add(AsciiDocExporter.Default);
            Add(MarkdownExporter.Default);
            Add(RPlotExporter.Default);
        }
    }
}
