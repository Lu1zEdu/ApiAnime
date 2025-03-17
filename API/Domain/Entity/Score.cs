namespace API.Domain.Entity;

public class Score
{
    public Guid IdScore { get; set; } // Identificador do Score
    
    public int ScoreAnime { get; set; } //Score do Anime
    
    public Guid IdUser { get; set; } // Identificador do usuario
    public int SumScore { get; set; } //Soma de score
    public int Popularity  { get; set; } //popularidade

    // Constructor
    public Score(Guid idScore, int scoreAnime, User user, int sumScore, int popularity)
    {
        IdScore = idScore;
        ScoreAnime = scoreAnime;
        IdUser = user.IdUser;
        SumScore = sumScore;
        Popularity = popularity;
    }
    
    // Método para atualizar a soma e calcular a popularidade
    public void UpdateScore(int newScore)
    {
        SumScore += newScore;
        // Atualiza a popularidade se a soma das notas alcançar 1000
        if (SumScore >= 1000)
        {
            Popularity = SumScore / 1000; // Calcula a média da popularidade
        }
    }
}