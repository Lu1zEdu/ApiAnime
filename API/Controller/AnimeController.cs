using API.Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;


namespace API.Controller;

[Route("api/[controller]")]
[ApiController]
public class AnimeController : ControllerBase
{
    private readonly AnimeService _animeService;

    public AnimeController(AnimeService animeService)
    {
        _animeService = animeService;
    }

    [HttpGet("search")]
    public IActionResult Search(
        [FromQuery] string name = null,
        [FromQuery] Guid? id = null,
        [FromQuery] string season = null,
        [FromQuery] List<string> genres = null,
        [FromQuery] string ranked = null,
        [FromQuery] int? score = null,
        [FromQuery] List<string> studios = null)
    {
        try
        {
            var animes = _animeService.GetAllAnimes();  // Suponha que você tenha um método para pegar todos os animes

            // Filtrando por nome
            if (!string.IsNullOrEmpty(name))
                animes = animes.Where(a => a.NameEnglish.Contains(name, StringComparison.OrdinalIgnoreCase) ||
                                           a.NameJapanese.Contains(name, StringComparison.OrdinalIgnoreCase) ||
                                           a.NamePortugues.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();

            // Filtrando por ID
            if (id.HasValue)
                animes = animes.Where(a => a.IdAnime == id.Value).ToList();

            // Filtrando por temporada
            if (!string.IsNullOrEmpty(season))
                animes = animes.Where(a => a.Season.Contains(season, StringComparison.OrdinalIgnoreCase)).ToList();

            // Filtrando por gênero
            if (genres != null && genres.Any())
                animes = animes.Where(a => a.Genres.Any(g => genres.Contains(g))).ToList();

            // Filtrando por ranked (popularidade ou status de classificação)
            if (!string.IsNullOrEmpty(ranked))
                animes = animes.Where(a => a.Ranked.Contains(ranked, StringComparison.OrdinalIgnoreCase)).ToList();

            // Filtrando por score
            if (score.HasValue)
                animes = animes.Where(a => a.Score >= score.Value).ToList();

            // Filtrando por estúdios
            if (studios != null && studios.Any())
                animes = animes.Where(a => a.Studios.Any(s => studios.Contains(s))).ToList();

            return Ok(animes);
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }
}

