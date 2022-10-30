using Volo.Abp.Settings;

namespace Gm.Settings;

public class GmSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(GmSettings.MySetting1));
    }
}
