using System.Threading.Tasks;
using Abp.Application.Services;
using NtxBlog.Roles.Dto;

namespace NtxBlog.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
