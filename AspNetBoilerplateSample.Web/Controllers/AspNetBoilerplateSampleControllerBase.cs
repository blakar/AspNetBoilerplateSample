using Abp.Web.Mvc.Controllers;

namespace AspNetBoilerplateSample.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class AspNetBoilerplateSampleControllerBase : AbpController
    {
        protected AspNetBoilerplateSampleControllerBase()
        {
            LocalizationSourceName = AspNetBoilerplateSampleConsts.LocalizationSourceName;
        }
    }
}