using System.Collections.Generic;
using System.Threading.Tasks;
using EShop.Business.Models;
using EShop.Business.Repositories;

namespace EShop.Business.Abstract
{
    public interface IUserGroupService : IServiceRepository<UserGroupDto>
    {
        Task<List<UserGroupsDto>> GetAllAsync();

    }
}