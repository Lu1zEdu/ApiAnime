using API.Domain.Entity.Models;
using API.Domain.Entity.Models.Concluidos;
using API.Domain.Enum;

namespace API.Domain.Entity;
 /// <summary>
 /// 
 /// </summary>
public class Anime
{
    //Guid
    public Guid IdAnime { get; set; } //Anime
    
    
    //Strings
    public String NameJapanese { get; set; }// Nome em japones
    public String NameEnglish { get; set; }//Nome em ingles
    public String NamePortugues { get; set; } //
    public String Synopsis { get; set; } //
    public String Synonyms  { get; set; }//
    
    
    //Int
    public int Episodes { get; set; }//
    public int DurationEps  { get; set; } //duração do eps
    
    //DateTime
    public DateTime DateStar { get; set; } //Data de Inicio
    public DateTime DateEnd { get; set; } //Data de Final

    //Listas
    public List<Characters> Characters { get; set; } =  new List<Characters>(); //
    public List<GenreAnime> Genres { get; set; } =  new List<GenreAnime>();//
    public List<Producer> Producers { get; set; } =  new List<Producer>(); //
    
    //Classes
    
    public Adaptation Adaptation { get; set; }
    public Premiered Premiered { get; set; }
    public Aired Aired { get; set; }
    
    //Enum
    public Demographic Demographic{ get; set; }
    public Source source { get; set; }
    public Studios Studios  { get; set; }
    public Rating Rating { get; set; }
    public Licensors Licensors  { get; set; } // quem tem a licença
    public Status Status { get; set; }
    public Themes Theme { get; set; }
    public Season Season { get; set; }
    public TypeDisplay TypeDisplay { get; set; }

    //Metodos
    
}