using System;
using System.Collections.Generic;
using System.Text;
using AbpFirstProject.Localization;
using Volo.Abp.Application.Services;

namespace AbpFirstProject
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpFirstProjectAppService : ApplicationService
    {
        protected AbpFirstProjectAppService()
        {
            LocalizationResource = typeof(AbpFirstProjectResource);
        }
    }
}
