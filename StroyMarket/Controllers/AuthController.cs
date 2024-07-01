using Microsoft.AspNetCore.Mvc;
using StroyMarket.Dto;
using StroyMarket.Interfaces.Service;

namespace StroyMarket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
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

        [HttpGet("find")]
        public async Task<ActionResult<bool>> Find(string phone)
        {
            var response = this._authService.Find(phone);
            return Ok(response);
        }
    }
}
