using Abp.Application.Features;
using NtxBlog.Authorization.Roles;
using NtxBlog.MultiTenancy;
using NtxBlog.Users;

namespace NtxBlog.Features
{
    public class FeatureValueStore : AbpFeatureValueStore<Tenant, Role, User>
    {
        public FeatureValueStore(TenantManager tenantManager)
            : base(tenantManager)
        {
        }
    }
}