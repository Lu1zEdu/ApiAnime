namespace API.Domain.Entity;

public class Ranked
{
    public Guid IdRanked { get; set; }
    public  String Name { get; set; }
    public  Guid Id { get; set; }

    public Ranked(Guid idRanked,Anime anime)
    {
        IdRanked = idRanked;
        Name = anime.NameEnglish;
        Name = anime.NameJapanese;
        Id = anime.IdAnime;
    }
}