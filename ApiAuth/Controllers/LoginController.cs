using ApiAuth.DTOs;
using ApiAuth.Repositories;
using ApiAuth.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiAuth.Controllers
{
    [ApiController]
    [Route("v1")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        public ActionResult<UserOutputDto> Authenticate([FromBody] UserInputDto input)
        {
            var user = UserRepository.Get(input.Username, input.Password);

            if (user == null)
            {
                return NotFound(new { message = "Usuário ou senha inválidos" });
            }

            var token = TokenService.GenerateToken(user);

            return Ok(new
            {
                user = UserOutputDto.FromUser(user),
                token
            });
        }
    }
}
