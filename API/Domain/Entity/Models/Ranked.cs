namespace API.Domain.Entity;

public class Ranked
{
    //Guid
    public Guid IdRanked { get; set; }
    
    // Anime <===> Guid
    public  Guid Id { get; set; }
    
    // Anime <===> String
    public String NameE { get; set; }
    public String NameJ { get; set; }
    public String NameP { get; set; }

    //Int
    public int NumberRanked { get; set; }

    //Constructor
    public Ranked(Guid idRanked, int numberRanked , Anime anime)
    {
        Id = anime.IdAnime;
        NameE = anime.NameEnglish;
        NameJ = anime.NameJapanese;
        NameP = anime.NamePortugues;
        IdRanked = idRanked;
        NumberRanked = numberRanked;
    }
}