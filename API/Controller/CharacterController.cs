using API.Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;

namespace API.Controller;

[Route("api/[controller]")]
[ApiController]
public class CharacterController : ControllerBase
{
    private readonly AnimeService _animeService;

    public CharacterController(AnimeService animeService)
    {
        _animeService = animeService;
    }

    [HttpGet("search")]
    public IActionResult Search(
        [FromQuery] string name = null,
        [FromQuery] Guid? id = null,
        [FromQuery] string animeName = null)
    {
        try
        {
            var characters = _animeService.;  // Suponha que você tenha um método para pegar todos os personagens

            // Filtrando por nome
            if (!string.IsNullOrEmpty(name))
                characters = characters.Where(c => c.NameEnglish.Contains(name, StringComparison.OrdinalIgnoreCase) ||
                                                   c.NameJapanese.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();

            // Filtrando por ID
            if (id.HasValue)
                characters = characters.Where(c => c.Id == id.Value).ToList();

            // Filtrando por nome do anime
            if (!string.IsNullOrEmpty(animeName))
                characters = characters.Where(c => c.AnimeName.Contains(animeName, StringComparison.OrdinalIgnoreCase)).ToList();

            return Ok(characters);
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }
}