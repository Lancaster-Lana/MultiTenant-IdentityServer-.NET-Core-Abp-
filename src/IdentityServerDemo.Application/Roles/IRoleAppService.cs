using System.Threading.Tasks;
using Abp.Application.Services;
using IS.Roles.Dto;

namespace IS.Application.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
