using API.Domain.Entity;
using API.Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;

namespace API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        // Endpoint para criar um usuário
        [HttpPost("create")]
        public IActionResult CreateUser([FromBody] User user)
        {
            try
            {
                if (!_userService.CreateUser(user))
                    return BadRequest("Não foi possível criar o usuário. Verifique os dados.");
                
                return Ok("Usuário criado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Endpoint para desativar um usuário
        [HttpPatch("deactivate/{userId}")]
        public IActionResult DeactivateUser(Guid userId)
        {
            try
            {
                var result = _userService.DeactivateUser(userId);
                if (!result)
                    return NotFound("Usuário não encontrado.");

                return Ok("Usuário desativado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}