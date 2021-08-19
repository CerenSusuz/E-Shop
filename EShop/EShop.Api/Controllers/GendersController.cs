using System.Threading.Tasks;
using EShop.Api.Repository;
using EShop.Business.Abstract;
using EShop.Business.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Api.Controllers
{
    public class GendersController : ControllerRepository<IGenderService,GenderDto>
    {
        private readonly IGenderService _service;

        public GendersController(IGenderService service):base(service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetAll()
        {
            var data =await _service.GetAllAsync();
            
            return Ok(data);
        }
        
        
        
        
    }
}