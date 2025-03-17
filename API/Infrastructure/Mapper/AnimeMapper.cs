using API.Domain.Entity;
using System.Linq;
using API.DTO;

namespace API.Infrastructure.Mapper;

public class AnimeMapper
{
    public static AnimeDto ToDTO(Anime anime)
    {
        return new AnimeDto
        {
            IdAnime = anime.IdAnime,
            NameJapanese = anime.NameJapanese,
            NameEnglish = anime.NameEnglish,
            NamePortugues = anime.NamePortugues,
            Synopsis = anime.Synopsis,
            Synonyms = anime.Synonyms,
            Episodes = anime.Episodes,
            DurationEps = anime.DurationEps,
            DateStar = anime.DateStar,
            DateEnd = anime.DateEnd,
            Genres = anime.Genres.Select(g => g.Genre).ToList(),
            Producers = anime.Producers.Select(p => p.Studios).ToList(),
            Studios = anime.Studios.Select(s => s.NameProducer).ToList(),
            Demographic = anime.Demographic,
            Source = anime.Source,
            Rating = anime.Rating,
            Status = anime.Status,
            Season = anime.Season,
            TypeDisplay = anime.TypeDisplay
        };
    }
}