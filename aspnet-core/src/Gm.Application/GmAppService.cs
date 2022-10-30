using System;
using System.Collections.Generic;
using System.Text;
using Gm.Localization;
using Volo.Abp.Application.Services;

namespace Gm;

/* Inherit your application services from this class.
 */
public abstract class GmAppService : ApplicationService
{
    protected GmAppService()
    {
        LocalizationResource = typeof(GmResource);
    }
}
