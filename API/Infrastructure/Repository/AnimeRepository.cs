using API.Domain.Entity;
using API.Infrastructure.Context;

namespace API.Infrastructure.Repository;

public class AnimeRepository
{
    private readonly AnimeContext _context;

    public AnimeRepository(AnimeContext context)
    {
        _context = context;
    }

    public void AddAnime(Anime anime)
    {
        _context.Animes.Add(anime);
        _context.SaveChanges();
    }

    
    // Método para obter todos os Animes
    public List<Anime> GetAll()
    {
        return _context.Animes.ToList(); // Obtém todos os animes do banco de dados
    }

    // Método para obter todos os Producers
    public List<Producer> GetAllProducers()
    {
        return _context.Producers.ToList(); // Obtém todos os produtores do banco de dados
    }
}
