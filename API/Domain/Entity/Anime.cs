using API.Domain.Entity.Models;
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
    public int Favorites { get; set; }//
    
    public StatusAnime StatusAnime { get; set; }
   
}