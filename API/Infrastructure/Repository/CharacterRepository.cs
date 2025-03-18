using API.Domain.Entity;
using API.Infrastructure.Context;

namespace API.Infrastructure.Repository;

public class CharacterRepository
{
    private readonly CharactersContext _context;

    public CharacterRepository(CharactersContext context)
    {
        _context = context;
    }

    // Método para obter todos os Characters
    public List<Characters> GetAll()
    {
        return _context.Characters.ToList(); // Obtém todos os personagens do banco de dados
    }
}