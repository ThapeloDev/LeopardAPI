using Volo.Abp.Settings;

namespace LeopardAPI.Settings
{
    public class LeopardAPISettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(LeopardAPISettings.MySetting1));
        }
    }
}
