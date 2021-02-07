using Microsoft.AspNetCore.Mvc;
using AuthorizationMicroService.Services;
using Microsoft.Extensions.Configuration;

namespace AuthorizationMicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IAuthenticateService _authenticateService;
        private readonly ITokenService _tokenService;
        public LoginController(IConfiguration config, IAuthenticateService authenticateService, ITokenService tokenService)
        {            
            _config = config;
            _tokenService = tokenService;
            _authenticateService = authenticateService;
        }

        [HttpGet]
        public IActionResult Login(string username, string pass)
        {
            if(_authenticateService.Verified(username,pass))               
                return Ok(_tokenService.GenerateJSONWebToken(username, _config));
            return Unauthorized();
        }

        [HttpGet("Run")]
        public ActionResult<string> Get()
        {
            return "The Authorization MicroService API is Running";
        }
    }
}
