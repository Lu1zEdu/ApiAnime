using API.Domain.Enum;

namespace API.Domain.Entity;

public class Characters
{
    //Guid
    public Guid IdCharacters { get; set; }
    
    //String
    public String NameCharactersE { get; set; }
    public String NameCharactersJ { get; set; }

    public String UrlImage { get; set; }
    public String DescribeCharacters { get; set; }
    
    //DataTime
    public DateTime BirthdateCharacters { get; set; }
    
    //int
    public int Height  { get; set; }
    public int Weight { get; set; }
    
    //Enum
    public PositionCharacters  PositionCharacters { get; set; }
    
    //Constructor
    public Characters(Guid idCharacters, string nameCharactersE, string nameCharactersJ, string urlImage, string describeCharacters, DateTime birthdateCharacters, int height, int weight, PositionCharacters positionCharacters)
    {
        IdCharacters = idCharacters;
        NameCharactersE = nameCharactersE;
        NameCharactersJ = nameCharactersJ;
        UrlImage = urlImage;
        DescribeCharacters = describeCharacters;
        BirthdateCharacters = birthdateCharacters;
        Height = height;
        Weight = weight;
        PositionCharacters = positionCharacters;
    }
}