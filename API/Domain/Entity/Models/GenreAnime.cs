using API.Domain.Enum;

namespace API.Domain.Entity.Models;

public class GenreAnime
{ 
    //Guid
    public Guid GenreAnimeId { get; set; }
    
    //int
    public int AnimesGenre { get; set; }

    //Enum
    public Genres  Genre { get; set; }
    
    //Constructor
    public GenreAnime(Guid genreAnimeId, int animesGenre, Genres genre)
    {
        GenreAnimeId = genreAnimeId;
        AnimesGenre = animesGenre;
        Genre = genre;
    }
}