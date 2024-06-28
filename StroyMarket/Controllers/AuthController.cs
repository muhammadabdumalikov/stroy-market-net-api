using Microsoft.AspNetCore.Mvc;
using MohirdevNet.Dto;
using MohirdevNet.Interfaces.Service;

namespace MohirdevNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController: ControllerBase
    {
        private IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<ActionResult<bool>> Register(UserDto request)
        {
            return this._authService.Create(request);
        }

        [HttpPost("verify")]
        public async Task<ActionResult<bool>> Verify(string phone, int code)
        {
            var response = this._authService.Verify(phone, code);
            return Ok(response);    
        }
    }
}
