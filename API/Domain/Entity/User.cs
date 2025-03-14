using API.Domain.Enum;

namespace API.Domain.Entity;

public class User
{
    //Guid
    public Guid IdUser { get; set; } // 
    
    //String
    public String FirstName { get; set; } //
    public String LastName { get; set; } //
    public String Username { get; set; } //
    public String Email { get; set; } //
    public String Password { get; set; } //

    //DateTime
    public DateTime BirthDate { get; set; } //

    //Listas
    public List<Anime> Favorites { get; set; } = new List<Anime>();
    
    //Enum
    public Rating Rating { get; set; }
    
    
}