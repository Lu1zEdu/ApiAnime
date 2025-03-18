using API.Domain.Entity;
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

    public void Create(Anime anime)
    {
        // Validação do objeto Anime não ser nulo
        if (anime == null)
        {
            throw new ArgumentNullException(nameof(anime), "Anime cannot be null");
        }

        // Se o IdAnime estiver vazio, criamos um novo GUID
        if (anime.IdAnime == Guid.Empty)
        {
            anime.IdAnime = Guid.NewGuid();
        }

        // Verificando se os nomes do Anime não são nulos
        if (anime.NameJapanese == null || anime.NamePortugues == null || anime.NameEnglish == null)
        {
            throw new ArgumentException("Anime name cannot be null in any language (Japanese, Portuguese, English)");
        }

        // Verificando se os sinônimos do anime não são nulos
        if (anime.Synonyms == null)
        {
            throw new ArgumentException("Anime synonyms cannot be null");
        }

        // Verificando se o número de episódios e a duração dos episódios são válidos
        if (anime.Episodes <= 0 || anime.DurationEps <= 0)
        {
            throw new ArgumentException("Anime must have at least 1 episode and episode duration must be at least 1 minute");
        }

        // Validação de popularidade (caso não tenha, exibe que ainda não foi calculada)
        if (anime.Popularity == 0)
        {
            throw new ArgumentException("Anime does not have enough data to calculate popularity yet");
        }

        // Verificando a data de estreia, não pode ser uma data futura
        if (anime.DateStar > DateTime.Now)
        {
            throw new ArgumentException("Anime cannot have a start date in the future");
        }

        // Verificando se a data de fim é válida (não pode ser igual à data de início)
        if (anime.DateEnd == DateTime.Now || anime.DateStar > DateTime.Now)
        {
            throw new ArgumentException("Anime end date cannot be the same as the start date or in the future");
        }

        // Verificando se a data de início e fim são válidas (não podem ser iguais)
        if (anime.DateStar == anime.DateEnd)
        {
            throw new ArgumentException("Anime start and end dates cannot be the same");
        }

        // Validação dos personagens, cada um deve ter nome em inglês e japonês
        if (anime.Characters == null || anime.Characters.Any(c => string.IsNullOrEmpty(c.NameCharactersE) || string.IsNullOrEmpty(c.NameCharactersJ)))
        {
            throw new ArgumentException("Anime characters must have names in both English and Japanese");
        }

        // Verificando a quantidade de gêneros, não pode ser menor que 1 ou maior que 4
        if (anime.Genres == null || anime.Genres.Count == 0 || anime.Genres.Count > 4)
        {
            throw new ArgumentException("Anime must have at least 1 genre and no more than 4 genres");
        }

        // Verificando a quantidade de produtores (não pode ter menos de 1 ou mais de 1)
        if (anime.Producers == null || anime.Producers.Count != 1)
        {
            throw new ArgumentException("Anime must have exactly one producer");
        }

        // Verificando a quantidade de estúdios (não pode ter menos de 1 ou mais de 2)
        if (anime.Studios == null || anime.Studios.Count == 0 || anime.Studios.Count > 2)
        {
            throw new ArgumentException("Anime must have at least 1 studio and no more than 2 studios");
        }

        // Verificando se o anime tem licenciadora, não pode ser nulo
        if (anime.Licensors == null)
        {
            throw new ArgumentException("Anime must have at least one licensor");
        }

        // Verificando se a classificação (rating) não é nula
        if (anime.Rating == null)
        {
            throw new ArgumentException("Anime must have a rating, especially for more mature content");
        }

        // Verificando o status do anime, não pode ser nulo
        if (anime.Status == null)
        {
            throw new ArgumentException("Anime status cannot be null");
        }

        // Verificando a quantidade de temas, não pode ser menor que 1 ou maior que 4
        if (anime.Themes == null || anime.Themes.Count == 0 || anime.Themes.Count < 1 || anime.Themes.Count > 4)
        {
            throw new ArgumentException("Anime must have at least 1 theme and no more than 4 themes");
        }

        // Verificando se o tipo de display do anime é válido
        if (anime.TypeDisplay == null)
        {
            throw new ArgumentException("Anime type display cannot be null");
        }
        _animeRepository.AddAnime(anime);
    }

    // Método para obter todos os Animes
    public List<Anime> GetAllAnimes()
    {
        // Recupera todos os animes usando o repositório
        var animes = _animeRepository.GetAll();
        return animes;
    }

    // Método para obter todos os Producers
    public List<Producer> GetAllProducers()
    {
        // Recupera todos os produtores (supondo que você tenha um método GetAll no ProducerRepository)
        var producers = _animeRepository.GetAllProducers(); // Isso dependerá do seu repositório
        return producers;
    }
    
}