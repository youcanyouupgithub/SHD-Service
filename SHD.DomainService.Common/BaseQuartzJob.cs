using Abp.Dependency;
using Abp.Quartz;
using App.Metrics;
using SHD.DomainService.Common.Metrics;
using System;
using System.Collections.Generic;
using System.Text;

namespace SHD.DomainService.Common
{
    public abstract class BaseQuartzJob : JobBase, ITransientDependency
    {
        public LazyService ServiceProxy { get; set; }

        protected void Start()
        {
            ServiceProxy.GetService<IMetrics>().Measure.Counter.Increment(QuartzJobBaseMetricsRegistry.JobCounter, QuartzJobBaseMetricsRegistry.GetTags(this.GetType().Name, "start"));
        }

        protected void Stop()
        {
            ServiceProxy.GetService<IMetrics>().Measure.Counter.Increment(QuartzJobBaseMetricsRegistry.JobCounter, QuartzJobBaseMetricsRegistry.GetTags(this.GetType().Name, "stop"));
        }
    }
}
