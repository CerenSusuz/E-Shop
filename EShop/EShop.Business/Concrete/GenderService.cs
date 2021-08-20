using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EShop.Business.Abstract;
using EShop.Business.Models;
using EShop.Business.Repositories;
using EShop.Core.Extensions;
using EShop.Core.Models;
using EShop.DataAccess.Entities;
using EShop.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EShop.Business.Concrete
{
    public class GenderService :ServiceRepository<Gender,GenderDto>, IGenderService
    {
        private readonly IRepository<Gender> _repository;
        private readonly IMapper _mapper;

        public GenderService(IRepository<Gender> repository,IMapper mapper) : base(repository,mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        public async Task<PagedList<GendersDto>> GetAllAsync(Filter filter)
        {
            return await Task.Run(() =>
                _repository.AsNoTracking.Filter(filter).ToPagedList<Gender, GendersDto>(filter, _mapper)
            );
           
        }
    }
}