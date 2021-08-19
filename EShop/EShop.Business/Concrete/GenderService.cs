﻿using System.Collections.Generic;
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
    public class GenderService : IGenderService
    {
        private readonly IRepository<Gender> _repository;
        private readonly IMapper _mapper;

        public GenderService(IRepository<Gender> repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        public async Task<List<GendersDto>> GetAllAsync()
        {
            var entities = await _repository.AsNoTracking.ToListAsync();
            // içindeki entities GendersDto tipinde çevir
            return _mapper.Map<List<GendersDto>>(entities);
        }

        public async Task<GenderDto> GetAsync(int id)
        {
            var entity = await _repository.GetAsync(id);
            return _mapper.Map<GenderDto>(entity);
        }

        public async Task<int> InsertAsync(GenderDto dto)
        {
            var entity = _mapper.Map<Gender>(dto);
            await _repository.InsertAsync(entity);
            return entity.Id;
        }

        public async Task UpdateAsync(int id, GenderDto dto)
        {
            var entity = _mapper.Map<Gender>(dto);
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