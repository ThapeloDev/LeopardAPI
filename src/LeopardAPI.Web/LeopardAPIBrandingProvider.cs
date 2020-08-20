using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace LeopardAPI.Web
{
    [Dependency(ReplaceServices = true)]
    public class LeopardAPIBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "LeopardAPI";
    }
}
