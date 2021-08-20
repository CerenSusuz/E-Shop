using System.Threading.Tasks;
using AutoMapper;
using EShop.Business.Abstract;
using EShop.Business.Models;
using EShop.Business.Repositories;
using EShop.Business.Validators;
using EShop.Core.Aspects.CacheAspect;
using EShop.Core.Aspects.Validation;
using EShop.Core.Extensions;
using EShop.Core.Models;
using EShop.DataAccess.Entities;
using EShop.DataAccess.Repositories;

namespace EShop.Business.Concrete
{
    [ValidationAspect(typeof(UserGroupValidator))]
    public class UserGroupService :ServiceRepository<UserGroup,UserGroupDto>,  IUserGroupService
    {
        private readonly IRepository<UserGroup> _repository;
        private readonly IMapper _mapper;

        public UserGroupService(IRepository<UserGroup> repository,IMapper mapper)  : base(repository,mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        [CacheAspect]
        public async Task<PagedList<UserGroupsDto>> GetAllAsync(Filter filter)
        {
            return await Task.Run(() => _repository.AsNoTracking.Filter(filter).ToPagedList<UserGroup, UserGroupsDto>(filter, _mapper));
        }
    }
}