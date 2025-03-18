using API.Domain.Enum;

namespace API.Domain.Entity;

public class Premiered
{
    //DateTime
    public int Year { get; set; }
    
    //Enum
    public Season  Season { get; set; }

    //Constructor
    public Premiered(int year, Season season)
    {
        Year = year;
        Season = season;
    }
}