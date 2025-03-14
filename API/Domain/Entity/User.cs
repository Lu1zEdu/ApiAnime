namespace API.Domain.Entity;

public class User
{
    public Guid IdUser { get; set; }
    
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public string Email { get; set; }
    public string Password { get; set; }

    public DateTime BirthDate { get; set; }

    
}