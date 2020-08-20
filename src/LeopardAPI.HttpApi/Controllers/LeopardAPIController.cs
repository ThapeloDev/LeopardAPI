using LeopardAPI.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace LeopardAPI.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class LeopardAPIController : AbpController
    {
        protected LeopardAPIController()
        {
            LocalizationResource = typeof(LeopardAPIResource);
        }
    }
}