using AbpFirstProject.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpFirstProject.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpFirstProjectController : AbpController
    {
        protected AbpFirstProjectController()
        {
            LocalizationResource = typeof(AbpFirstProjectResource);
        }
    }
}