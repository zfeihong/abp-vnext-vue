using Volo.Abp.Modularity;

namespace Gm;

[DependsOn(
    typeof(GmApplicationModule),
    typeof(GmDomainTestModule)
    )]
public class GmApplicationTestModule : AbpModule
{

}
