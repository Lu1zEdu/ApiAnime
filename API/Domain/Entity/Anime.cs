using API.Domain.Entity.Models;
using API.Domain.Entity.Models.Concluidos;
using API.Domain.Enum;

namespace API.Domain.Entity;
/// <summary>
/// Representa um Anime com informações detalhadas, incluindo nomes, sinopse, episódios, produtores, etc.
/// </summary>
public class Anime
{
    // GUID para identificar o Anime de forma única
    public Guid IdAnime { get; set; }

    // Strings para os nomes do Anime em japonês, inglês e português
    public string NameJapanese { get; set; }
    public string NameEnglish { get; set; }
    public string NamePortugues { get; set; }

    // Sinopse e sinônimos do Anime
    public string Synopsis { get; set; }
    public string Synonyms { get; set; }

    // Inteiros para o número de episódios e a duração dos episódios
    public int Episodes { get; set; }
    public int DurationEps { get; set; }
    public int Popularity { get; set; }

    // Data de início e fim do Anime
    public DateTime DateStar { get; set; }
    public DateTime DateEnd { get; set; }

    // Listas de personagens, gêneros, produtores e estúdios
    public List<Characters> Characters { get; set; } = new List<Characters>();
    public List<GenreAnime> Genres { get; set; } = new List<GenreAnime>();
    public List<Producer> Producers { get; set; } = new List<Producer>();
    public List<Producer> Studios { get; set; } = new List<Producer>();

    // Classes relacionadas ao Anime (Adaptação, Premiered, Aired)
    public Adaptation Adaptation { get; set; }
    public Premiered Premiered { get; set; }
    public Aired Aired { get; set; }

    // Enum para diversas classificações do Anime
    public Demographic Demographic { get; set; }
    public Source Source { get; set; }
    public Rating Rating { get; set; }
    public Licensors Licensors { get; set; }
    public Status Status { get; set; }
    public Themes Theme { get; set; }
    public Season Season { get; set; }
    public TypeDisplay TypeDisplay { get; set; }

    
    // Constructor
    public Anime(Guid idAnime, string nameJapanese, string nameEnglish, string namePortugues, string synopsis, string synonyms, int episodes, int durationEps, DateTime dateStar, DateTime dateEnd, Adaptation adaptation, Premiered premiered, Aired aired, Demographic demographic, Source source, Rating rating, Licensors licensors, Status status, Themes theme, Season season, TypeDisplay typeDisplay)
    {
        IdAnime = idAnime;
        NameJapanese = nameJapanese;
        NameEnglish = nameEnglish;
        NamePortugues = namePortugues;
        Synopsis = synopsis;
        Synonyms = synonyms;
        Episodes = episodes;
        DurationEps = durationEps;
        DateStar = dateStar;
        DateEnd = dateEnd;
        Adaptation = adaptation;
        Premiered = premiered;
        Aired = aired;
        Demographic = demographic;
        Source = source;
        Rating = rating;
        Licensors = licensors;
        Status = status;
        Theme = theme;
        Season = season;
        TypeDisplay = typeDisplay;
    }
}