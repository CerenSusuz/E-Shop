using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EShop.Business.Abstract;
using EShop.Business.Models;
using EShop.DataAccess.Entities;
using EShop.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EShop.Business.Concrete
{
    public class UserGroupService : IUserGroupService
    {
        private readonly IRepository<UserGroup> _repository;
        private readonly IMapper _mapper;

        public UserGroupService(IRepository<UserGroup> repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        public async Task<List<UserGroupsDto>> GetAllAsync()
        {
            var entities = await _repository.AsNoTracking.ToListAsync();
            return _mapper.Map<List<UserGroupsDto>>(entities);
        }

        public async Task<UserGroupDto> GetAsync(int id)
        {
            var entity = await _repository.GetAsync(id);
            return _mapper.Map<UserGroupDto>(entity);
        }

        public async Task<int> InsertAsync(UserGroupDto dto)
        {
            var entity = _mapper.Map<UserGroup>(dto);
            await _repository.InsertAsync(entity);
            return entity.Id;
        }

        public async Task UpdateAsync(int id, UserGroupDto dto)
        {
            var entity = _mapper.Map<UserGroup>(dto);
            entity.Id = id;
            await _repository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _repository.GetAsync(id);
            await _repository.DeleteAsync(entity);
        }

        public async Task DeleteRangeAsync(List<int> listOfId)
        {
            var entities = await _repository.AsNoTracking.Where(x => listOfId.Contains(x.Id)).ToListAsync();
            await _repository.DeleteRangeAsync(entities);
        }

        public async Task RemoveCacheAsync()
        {
            await Task.CompletedTask.ConfigureAwait(false);
        }
    }
}