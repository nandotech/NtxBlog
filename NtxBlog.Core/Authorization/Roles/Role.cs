using Abp.Authorization.Roles;
using NtxBlog.MultiTenancy;
using NtxBlog.Users;

namespace NtxBlog.Authorization.Roles
{
    public class Role : AbpRole<Tenant, User>
    {

    }
}