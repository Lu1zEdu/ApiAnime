namespace API.Domain.Enum;

public enum Demographic
{
    Shounen,        // Voltado para o público jovem masculino (geralmente entre 12 e 18 anos)
    Shoujo,         // Voltado para o público jovem feminino (geralmente entre 12 e 18 anos)
    Seinen,         // Voltado para o público adulto masculino (geralmente acima de 18 anos)
    Josei,          // Voltado para o público adulto feminino (geralmente acima de 18 anos)
    Kodomomuke,     // Voltado para crianças (geralmente até 12 anos)
    Harem,          // Focado em um protagonista com múltiplos interesses românticos (normalmente voltado para o público masculino)
    ReverseHarem,   // Focado em uma protagonista com múltiplos interesses românticos (normalmente voltado para o público feminino)
    Yaoi,           // Focado em relacionamentos homossexuais masculinos (também conhecido como Boys' Love - BL)
    Yuri,           // Focado em relacionamentos homossexuais femininos (também conhecido como Girls' Love - GL)
    Adult,          // Conteúdo voltado para o público adulto, com temas mais pesados e explícitos
    Ecchi,          // Conteúdo sugestivo ou com cenas sexualmente insinuantes, mas sem ultrapassar limites explícitos
    AllAges         // Apropriado para todas as idades (ex: histórias infantis ou familiares)
}
