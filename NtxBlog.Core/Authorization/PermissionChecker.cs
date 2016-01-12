using Abp.Authorization;
using NtxBlog.Authorization.Roles;
using NtxBlog.MultiTenancy;
using NtxBlog.Users;

namespace NtxBlog.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
