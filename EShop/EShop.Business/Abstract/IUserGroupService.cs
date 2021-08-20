using System.Threading.Tasks;
using EShop.Business.Models;
using EShop.Business.Repositories;
using EShop.Core.Models;

namespace EShop.Business.Abstract
{
    public interface IUserGroupService : IServiceRepository<UserGroupDto>
    {
        Task<PagedList<UserGroupsDto>> GetAllAsync(Filter filter);

    }
}