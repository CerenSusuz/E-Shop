using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShop.Business.Abstract;
using EShop.Business.Models;
using EShop.DataAccess.Entities;
using EShop.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EShop.Business.Concrete
{
    public class GenderService : IGenderService
    {
        private readonly IRepository<Gender> _repository;

        public GenderService(IRepository<Gender> repository)
        {
            _repository = repository;
        }
        
        public async Task<List<GendersDto>> GetAllAsync()
        {
            var entities = await _repository.AsNoTracking.ToListAsync();
            entities.Select(x => new GendersDto()
            {
                Id = x.Id,
                Description = x.Description,
                IsBlocked = x.IsBlocked
            }).ToList();
            
            
        }

        public async Task<GenderDto> GetAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<int> InsertAsync(GenderDto dto)
        {
            throw new System.NotImplementedException();
        }

        public async Task UpdateAsync(int id, GenderDto dto)
        {
            throw new System.NotImplementedException();
        }

        public async Task DeleteAsync(GenderDto dto)
        {
            throw new System.NotImplementedException();
        }

        public async Task DeleteRangeAsync(List<int> listOfId)
        {
            throw new System.NotImplementedException();
        }

        public async Task RemoveCacheAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}