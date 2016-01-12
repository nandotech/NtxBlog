using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace NtxBlog
{
    [DependsOn(typeof(NtxBlogCoreModule), typeof(AbpAutoMapperModule))]
    public class NtxBlogApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
