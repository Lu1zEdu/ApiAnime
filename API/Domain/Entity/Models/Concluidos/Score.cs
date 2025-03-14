namespace API.Domain.Entity;

public class Score
{
    public Guid IdScore { get; set; } // Identificador do Score
    
    public int ScoreAnime { get; set; } //Score do Anime
    
    public Guid IdUser { get; set; } // Identificador do usuario
    public int SumScore { get; set; } //Soma de score
    public int Popularity  { get; set; } //popularidade

    public void SumUser(User user)
    {
        Console.Write($"O score {ScoreAnime} ");
    }

    public Score(Guid idScore, int scoreAnime, User user, int sumScore, int popularity)
    {
        IdScore = idScore;
        ScoreAnime = scoreAnime;
        IdUser = user.IdUser;
        SumScore = sumScore;
        Popularity = popularity;
    }
}