﻿using System.Collections.Generic;
using System.Threading.Tasks;
using EShop.Business.Models;

namespace EShop.Business.Abstract
{
    public interface IGenderService
    {
        Task<List<GendersDto>> GetAllAsync();
        Task<GenderDto> GetAsync(int id);
        Task<int> InsertAsync(GenderDto dto);
        Task UpdateAsync(int id, GenderDto dto);
        Task DeleteAsync(int id);
        Task DeleteRangeAsync(List<int> listOfId);
        Task RemoveCacheAsync();
    }
}