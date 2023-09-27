
using Epsa.Server.Authorization;
using Epsa.Server.Repository.User;
using Epsa.Shared.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Epsa.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpPost("authenticate")]
        public ActionResult Authenticate(AuthenticateRequest request)
        {            
            return Ok(_userRepository.Authenticate(request));

        }

        [HttpPost]
        public async Task<ActionResult> AddUser(SiUsuario siUsuario)
        {
            return Ok(await _userRepository.AddUser(siUsuario));
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _userRepository.GetUsers());
        }

    }
}
