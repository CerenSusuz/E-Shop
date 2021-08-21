using System.Threading.Tasks;
using EShop.Business.Abstract;
using EShop.Core.Plugins.Authentication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        private IHttpContextAccessor _httpContextAccessor;

        public AuthenticationController(IAuthenticationService authenticationService, IHttpContextAccessor httpContextAccessor)
        {
            _authenticationService = authenticationService;
            _httpContextAccessor = httpContextAccessor;
        }

        private string IpAddress => _httpContextAccessor?.HttpContext?.Connection.RemoteIpAddress?.ToString() ?? "";

        [HttpPost("login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public virtual async Task<IActionResult> Login([FromBody] LoginRequestModel loginModel)
        {
            return Ok(await _authenticationService.LoginAsync(loginModel, IpAddress));
        }
    }
}