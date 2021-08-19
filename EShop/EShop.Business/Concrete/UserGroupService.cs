using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using EShop.Business.Abstract;
using EShop.Business.Models;
using EShop.Business.Repositories;
using EShop.DataAccess.Entities;
using EShop.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EShop.Business.Concrete
{
    public class UserGroupService :ServiceRepository<UserGroup,UserGroupDto>,  IUserGroupService
    {
        private readonly IRepository<UserGroup> _repository;
        private readonly IMapper _mapper;

        public UserGroupService(IRepository<UserGroup> repository,IMapper mapper)  : base(repository,mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        public async Task<List<UserGroupsDto>> GetAllAsync()
        {
            var entities = await _repository.AsNoTracking.ToListAsync();
            return _mapper.Map<List<UserGroupsDto>>(entities);
        }
    }
}