using System;
using System.Collections.Generic;
using System.Text;
using LeopardAPI.Localization;
using Volo.Abp.Application.Services;

namespace LeopardAPI
{
    /* Inherit your application services from this class.
     */
    public abstract class LeopardAPIAppService : ApplicationService
    {
        protected LeopardAPIAppService()
        {
            LocalizationResource = typeof(LeopardAPIResource);
        }
    }
}
