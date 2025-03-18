using API.Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;
using API.Domain.Enum;
using API.Domain.Entity;
using System.Collections.Generic;
using System.Linq;
using System;

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
            var animes = _animeService.GetAllAnimes();

            // Filtro por nome
            if (!string.IsNullOrEmpty(name))
            {
                animes = animes.Where(a =>
                    (a.NameEnglish?.Contains(name, StringComparison.OrdinalIgnoreCase) ?? false) ||
                    (a.NameJapanese?.Contains(name, StringComparison.OrdinalIgnoreCase) ?? false) ||
                    (a.NamePortugues?.Contains(name, StringComparison.OrdinalIgnoreCase) ?? false)
                ).ToList();
            }

            // Filtro por ID
            if (id.HasValue)
            {
                animes = animes.Where(a => a.IdAnime == id.Value).ToList();
            }

            // Filtro por temporada
            if (!string.IsNullOrEmpty(season) && Enum.TryParse<Season>(season, true, out var parsedSeason))
            {
                animes = animes.Where(a => a.Premiered?.Season == parsedSeason).ToList();
            }

            // Filtro por gênero
            if (genres != null && genres.Any())
            {
                animes = animes.Where(a =>
                    a.Genres.Any(g => genres.Contains(g.Genre.ToString()))
                ).ToList();
            }

            // Filtro por ranked
            if (!string.IsNullOrEmpty(ranked))
            {
                animes = animes.Where(a =>
                    (a.Ranked?.NameE?.Contains(ranked, StringComparison.OrdinalIgnoreCase) == true) ||
                    (a.Ranked?.NameJ?.Contains(ranked, StringComparison.OrdinalIgnoreCase) == true) ||
                    (a.Ranked?.NameP?.Contains(ranked, StringComparison.OrdinalIgnoreCase) == true)
                ).ToList();
            }

            // Filtro por score
            if (score.HasValue)
            {
                animes = animes.Where(a => a.Score?.ScoreAnime >= score.Value).ToList();
            }

            // Filtro por estúdios
            if (studios != null && studios.Any())
            {
                animes = animes.Where(a =>
                    a.Studios.Any(s => studios.Contains(s.NameProducer.ToString()))
                ).ToList();
            }

            return Ok(animes);
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }

    [HttpPost]
    public IActionResult Create([FromBody] Anime anime)
    {
        try
        {
            _animeService.Create(anime);
            return Ok("Anime criado com sucesso!");
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        try
        {
            _animeService.Delete(id);
            return Ok("Anime excluído com sucesso!");
        }
        catch (ArgumentException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}