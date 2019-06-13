using App.Metrics;
using App.Metrics.Counter;

namespace SHD.DomainService.Common.Metrics
{
    public static class QuartzJobBaseMetricsRegistry
    {
        public static CounterOptions JobCounter => new CounterOptions
        {
            Name = "QuartzJob",
            MeasurementUnit = Unit.Calls
        };

        public static MetricTags GetTags(string name, string status)
        {
            return new MetricTags(new string[] { "name", "status" }, new string[] { name, status });
        }
    }
}
