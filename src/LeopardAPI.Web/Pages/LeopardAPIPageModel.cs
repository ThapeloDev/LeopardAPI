using LeopardAPI.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace LeopardAPI.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class LeopardAPIPageModel : AbpPageModel
    {
        protected LeopardAPIPageModel()
        {
            LocalizationResourceType = typeof(LeopardAPIResource);
        }
    }
}