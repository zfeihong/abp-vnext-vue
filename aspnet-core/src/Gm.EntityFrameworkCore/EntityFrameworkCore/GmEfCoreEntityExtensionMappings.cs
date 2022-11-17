using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging;
using Volo.Abp.Data;
using Volo.Abp.Identity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.PermissionManagement;
using Volo.Abp.Threading;

namespace Gm.EntityFrameworkCore;

public static class GmEfCoreEntityExtensionMappings
{
    private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

    public static void Configure()
    {
        GmGlobalFeatureConfigurator.Configure();
        GmModuleExtensionConfigurator.Configure();

        OneTimeRunner.Run(() =>
        {
            /* 配置实体扩展属性以及EF CORE相关映射
             *
             * 使用 GmModuleExtensionConfigurator 类 (在Domain.Shared项目中)
             * 定义实体的扩展属性
             *
             * Demo: 映射属性到表格字段:
                 ObjectExtensionManager.Instance
                     .MapEfCoreProperty<IdentityUser, string>(
                         "MyProperty",
                         (entityBuilder, propertyBuilder) =>
                         {
                             propertyBuilder.HasMaxLength(128);
                         }
                     );
             * 更多详情:
             * https://docs.abp.io/en/abp/latest/Customizing-Application-Modules-Extending-Entities
             */

            AbpCommonDbProperties.DbTablePrefix = "gm";
            AbpIdentityDbProperties.DbTablePrefix = "ids";
            AbpAuditLoggingDbProperties.DbTablePrefix = "log";
            AbpPermissionManagementDbProperties.DbTablePrefix = "auth";
        });
    }
}
