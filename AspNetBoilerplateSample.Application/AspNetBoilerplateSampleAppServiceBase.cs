using Abp.Application.Services;

namespace AspNetBoilerplateSample
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class AspNetBoilerplateSampleAppServiceBase : ApplicationService
    {
        protected AspNetBoilerplateSampleAppServiceBase()
        {
            LocalizationSourceName = AspNetBoilerplateSampleConsts.LocalizationSourceName;
        }
    }
}