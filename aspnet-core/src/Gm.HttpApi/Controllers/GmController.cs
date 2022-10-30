using Gm.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Gm.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class GmController : AbpControllerBase
{
    protected GmController()
    {
        LocalizationResource = typeof(GmResource);
    }
}
