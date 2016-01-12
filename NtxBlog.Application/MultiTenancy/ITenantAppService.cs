using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using NtxBlog.MultiTenancy.Dto;

namespace NtxBlog.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultOutput<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
