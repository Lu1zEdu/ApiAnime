namespace API.Domain.Entity.Models;

public class Staff
{
    public Guid IdStaff { get; set; }
    
    //String
    public String NameE { get; set; }
    public String GivenNameJ { get; set; }
    public String FamilyNameJ { get; set; }
    public String AlternateNameJ { get; set; }
    public String Website { get; set; } //URL
    
    //DateTime
    public DateTime BirthdayStaff { get; set; }

    // Constructor
    public Staff(Guid idStaff, string nameE, string givenNameJ, string familyNameJ, string alternateNameJ, string website, DateTime birthdayStaff)
    {
        IdStaff = idStaff;
        NameE = nameE;
        GivenNameJ = givenNameJ;
        FamilyNameJ = familyNameJ;
        AlternateNameJ = alternateNameJ;
        Website = website;
        BirthdayStaff = birthdayStaff;

    }
}