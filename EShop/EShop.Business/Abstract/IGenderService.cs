﻿using System.Collections.Generic;
using System.Threading.Tasks;
using EShop.Business.Models;
using EShop.Business.Repositories;
using EShop.Core.Models;

namespace EShop.Business.Abstract
{
    public interface IGenderService : IServiceRepository<GenderDto>
    {
        Task<List<GendersDto>> GetAllAsync(Filter filter);

    }
}