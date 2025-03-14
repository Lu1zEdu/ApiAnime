namespace API.Domain.Enum;

public enum Source
{
    Manga,          // Baseado em manga (quadrinhos japoneses)
    LightNovel,     // Baseado em light novel (romances ilustrados)
    WebNovel,       // Baseado em web novel (romances publicados online)
    VisualNovel,    // Baseado em visual novel (jogos interativos com foco na narrativa)
    Original,       // Obra original, não adaptada de nada
    Game,           // Baseado em jogo (pode ser RPG, jogo de ação, etc.)
    Novel,          // Baseado em um romance tradicional (não necessariamente ilustrado)
    OVA,            // Baseado em OVA (Original Video Animation)
    Movie,          // Baseado em um filme
    Doujinshi,      // Baseado em doujinshi (obras criadas por fãs)
    MangaAdaptation, // Adaptado de um manga, mas com alterações significativas
    LightNovelAdaptation // Adaptado de uma light novel
}