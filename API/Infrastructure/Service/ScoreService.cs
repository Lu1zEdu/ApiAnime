using API.Domain.Entity;
using API.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace API.Infrastructure.Service;

public class ScoreService
{
    private readonly ScoreContext _context;

    public ScoreService(ScoreContext context)
    {
        _context = context;
    }

    // Método para adicionar ou atualizar a nota de um anime
    public async Task<bool> AddOrUpdateScore(Guid animeId, int score, User userId)
    {
        // Verifica se o anime existe
        var anime = await _context.Animes.FindAsync(animeId);
        if (anime == null)
        {
            return false; // Anime não encontrado
        }

        // Verifica se o usuário já deu uma nota para esse anime
        var existingScore = await _context.Scores
            .FirstOrDefaultAsync(s => s.IdAnime == animeId && s.IdUser.Equals(userId) );

        if (existingScore != null)
        {
            // Atualiza a nota existente
            existingScore.ScoreAnime = score;
        }
        else
        {
            // Adiciona uma nova nota
            var newScore = new Score(
                Guid.NewGuid(),
                score,
                userId,
                0, // Inicializa SumScore com 0
                0, // Inicializa Popularity com 0
                anime
            );

            _context.Scores.Add(newScore);
        }

        // Salva as mudanças no banco
        await _context.SaveChangesAsync();

        // Atualiza a popularidade do anime se tiver pelo menos 1000 notas
        anime.Popularity = await CalculatePopularity(animeId);
        _context.Animes.Update(anime);
        await _context.SaveChangesAsync();

        return true;
    }

    // Método para calcular a popularidade com base nas notas
    private async Task<int> CalculatePopularity(Guid animeId)
    {
        var scores = await _context.Scores
            .AsNoTracking()
            .Where(s => s.IdAnime == animeId)
            .ToListAsync();

        if (scores.Count >= 1000)
        {
            int totalScores = scores.Count;
            int sumScores = scores.Sum(s => s.ScoreAnime);
            return sumScores / totalScores; // Média das notas
        }

        return 0; // Popularidade só é calculada quando tiver pelo menos 1000 notas
    }
}
