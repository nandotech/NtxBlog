using System.Threading.Tasks;
using Abp.Application.Services;
using NtxBlog.Users.Dto;

namespace NtxBlog.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task RemoveFromRole(long userId, string roleName);
    }
}