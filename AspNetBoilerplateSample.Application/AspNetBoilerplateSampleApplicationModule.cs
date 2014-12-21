using System.Reflection;
using Abp.Modules;

namespace AspNetBoilerplateSample
{
    [DependsOn(typeof(AspNetBoilerplateSampleCoreModule))]
    public class AspNetBoilerplateSampleApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
