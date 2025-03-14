namespace API.Domain.Enum;

public enum Rating
{
    G,             // Livre - Pode ser assistido por todas as idades
    PG,            // Livre para todas as idades, mas pode conter alguns temas leves
    PG13,          // Não recomendado para menores de 13 anos, pode conter violência moderada ou temas leves
    R,             // Recomendado para maiores de 17 anos, pode conter violência explícita, linguagem forte ou temas adultos
    R18,           // Restrito para maiores de 18 anos, com conteúdo explícito e adulto
    NC17,          // Não recomendado para menores de 17 anos, com conteúdo altamente explícito
    TVY,           // Apropriado para todas as idades, recomendado para crianças pequenas (Geração mais jovem)
    TVY7,          // Apto para crianças a partir de 7 anos, mas pode conter cenas ou temas mais complexos
    TVPG,          // Para público infantil, mas com cenas mais maduras, como linguagem ou violência leve
    TV14,          // Recomendado para maiores de 14 anos, pode ter temas de violência, drogas, ou outros conteúdos pesados
    TVMA           // Exclusivo para maiores de 17 anos, com conteúdo explícito (semelhante ao R)
}
