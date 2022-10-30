using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Gm;

[Dependency(ReplaceServices = true)]
public class GmBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Gm";
}
