using System.Collections.Generic;
using System.Threading.Tasks;
using EShop.Business.Models;
using EShop.DataAccess.Entities;

namespace EShop.Business.Abstract
{
    public interface IGenderService
    {
        Task<List<GendersDto>> GetAllAsync();
        Task<GenderDto> GetAsync();
        Task<int> InsertAsync(GenderDto dto);
        Task UpdateAsync(int id, GenderDto dto);
        Task DeleteAsync(GenderDto dto);
        Task DeleteRangeAsync(List<int> listOfId);
        Task RemoveCacheAsync();
    }
}