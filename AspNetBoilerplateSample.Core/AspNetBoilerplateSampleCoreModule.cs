using System.Reflection;
using Abp.Modules;

namespace AspNetBoilerplateSample
{
    public class AspNetBoilerplateSampleCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
