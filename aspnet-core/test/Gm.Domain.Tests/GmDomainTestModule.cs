using Gm.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Gm;

[DependsOn(
    typeof(GmEntityFrameworkCoreTestModule)
    )]
public class GmDomainTestModule : AbpModule
{

}
