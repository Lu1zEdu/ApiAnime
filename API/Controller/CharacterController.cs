using API.Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;

namespace API.Controller;

[Route("api/[controller]")]
[ApiController]
public class CharacterController : ControllerBase
{
    private readonly CharacterService _characterService; // Serviço correto

    // Injeção correta do CharacterService
    public CharacterController(CharacterService characterService)
    {
        _characterService = characterService;
    }

    [HttpGet("search")]
    public IActionResult Search(
        [FromQuery] string name = null,
        [FromQuery] Guid? id = null,
        [FromQuery] string animeName = null)
    {
        try
        {
            var characters = _characterService.GetAllCharacters(); // Método correto

            // Filtro por nome (propriedades corrigidas)
            if (!string.IsNullOrEmpty(name))
            {
                characters = characters.Where(c => 
                    c.NameCharactersE.Contains(name, StringComparison.OrdinalIgnoreCase) ||
                    c.NameCharactersJ.Contains(name, StringComparison.OrdinalIgnoreCase)
                ).ToList();
            }

            // Filtro por ID
            if (id.HasValue)
            {
                characters = characters.Where(c => c.IdCharacters == id.Value).ToList();
            }

            // Filtro por nome do anime (acesso via propriedade de navegação)
            if (!string.IsNullOrEmpty(animeName))
            {
                characters = characters.Where(c => 
                    c.Anime.NameEnglish.Contains(animeName, StringComparison.OrdinalIgnoreCase) ||
                    c.Anime.NameJapanese.Contains(animeName, StringComparison.OrdinalIgnoreCase)
                ).ToList();
            }

            return Ok(characters);
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }
}