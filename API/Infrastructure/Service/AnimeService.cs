using API.Infrastructure.Repository;
using AutoMapper;

namespace API.Infrastructure.Service;

public class AnimeService
{
    private readonly  AnimeRepository _animeRepository;

    public AnimeService(AnimeRepository animeRepository)
    {
        _animeRepository = animeRepository;
    }

    public void Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}