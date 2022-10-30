using Gm.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Gm.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(GmEntityFrameworkCoreModule),
    typeof(GmApplicationContractsModule)
    )]
public class GmDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
