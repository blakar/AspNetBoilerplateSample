﻿using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace AspNetBoilerplateSample
{
    [DependsOn(typeof(AbpWebApiModule), typeof(AspNetBoilerplateSampleApplicationModule))]
    public class AspNetBoilerplateSampleWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(AspNetBoilerplateSampleApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
