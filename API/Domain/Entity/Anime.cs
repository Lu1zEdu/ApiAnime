using API.Domain.Enum;

namespace API.Domain.Entity;

public class Anime
{
    public Guid IdAnime { get; set; } //Anime
    
    public String NameJapanese { get; set; }
    public String NameEnglish { get; set; }

    public String Synopsis { get; set; }
    public String Licensors  { get; set; } //quem tem a licença 

    public Adaptation Adaptation { get; set; } //Como foi adaptação
    
    public int DurationEps  { get; set; } //duração do eps
    public int Popularity  { get; set; }
    public int Members { get; set; }
    public int Favorites { get; set; }
    
    public Status Status { get; set; }
    public Producer Producer { get; set; }
    
    public Themes Theme { get; set; }
    public Genres Genres { get; set; }
    public Source Source { get; set; }
    public TypeAnime TypeAnime { get; set; }
}