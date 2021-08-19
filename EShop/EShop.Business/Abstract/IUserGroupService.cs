using System.Collections.Generic;
using System.Threading.Tasks;
using EShop.Business.Models;

namespace EShop.Business.Abstract
{
    public interface IUserGroupService
    {
        Task<List<UserGroupsDto>> GetAllAsync();
        Task<UserGroupDto> GetAsync(int id);
        Task<int> InsertAsync(UserGroupDto dto);
        Task UpdateAsync(int id, UserGroupDto dto);
        Task DeleteAsync(int id);
        Task DeleteRangeAsync(List<int> listOfId);
        Task RemoveCacheAsync();
    }
}