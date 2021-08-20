﻿using System.Threading.Tasks;
using EShop.Api.Repository;
using EShop.Business.Abstract;
using EShop.Business.Models;
using EShop.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Api.Controllers
{
    public class AccountsController : ControllerRepository<IAccountService,AccountDto>
    {
        private readonly IAccountService _service;

        public AccountsController(IAccountService service):base(service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetAll([FromQuery]Filter filter)
        {
            var data =await _service.GetAllAsync(filter);
            
            return Ok(data);
        }
        
        
        
        
    }
}