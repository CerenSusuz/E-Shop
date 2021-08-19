using System.Threading.Tasks;
using EShop.Api.Repository;
using EShop.Business.Abstract;
using EShop.Business.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Api.Controllers
{
    public class UserGroupsController : ControllerRepository<IUserGroupService,UserGroupDto>
    {
        private readonly IUserGroupService _service;

        public UserGroupsController(IUserGroupService service):base(service)
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