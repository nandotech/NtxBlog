using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using NtxBlog.EntityFramework;

namespace NtxBlog
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(NtxBlogCoreModule))]
    public class NtxBlogDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
