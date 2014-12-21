using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using AspNetBoilerplateSample.EntityFramework;

namespace AspNetBoilerplateSample
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(AspNetBoilerplateSampleCoreModule))]
    public class AspNetBoilerplateSampleDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<AspNetBoilerplateSampleDbContext>(null);
        }
    }
}
