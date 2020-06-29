using Volo.Abp.Settings;

namespace AbpFirstProject.Settings
{
    public class AbpFirstProjectSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpFirstProjectSettings.MySetting1));
        }
    }
}
