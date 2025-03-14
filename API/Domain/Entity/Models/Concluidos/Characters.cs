using API.Domain.Enum;

namespace API.Domain.Entity;

public class Characters
{
    public Guid IdCharacters { get; set; }
    public string NameCharacters { get; set; }
    public PositionCharacters  PositionCharacters { get; set; }

    public Characters(Guid idCharacters, string nameCharacters, PositionCharacters positionCharacters)
    {
        IdCharacters = idCharacters;
        NameCharacters = nameCharacters;
        PositionCharacters = positionCharacters;
    }
}