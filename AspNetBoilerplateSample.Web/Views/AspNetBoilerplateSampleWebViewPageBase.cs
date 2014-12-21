using Abp.Web.Mvc.Views;

namespace AspNetBoilerplateSample.Web.Views
{
    public abstract class AspNetBoilerplateSampleWebViewPageBase : AspNetBoilerplateSampleWebViewPageBase<dynamic>
    {

    }

    public abstract class AspNetBoilerplateSampleWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AspNetBoilerplateSampleWebViewPageBase()
        {
            LocalizationSourceName = AspNetBoilerplateSampleConsts.LocalizationSourceName;
        }
    }
}