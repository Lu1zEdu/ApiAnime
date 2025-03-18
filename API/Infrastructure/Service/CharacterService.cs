

using API.Domain.Entity;
using API.Infrastructure.Context;
using API.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

namespace API.Infrastructure.Service;

public class CharacterService
{
    private readonly CharactersContext _context;

    public CharacterService(CharactersContext context)
    {
        _context = context;
    }

    public List<Characters> GetAllCharacters()
    {
        return _context.Characters.ToList();
    }
}