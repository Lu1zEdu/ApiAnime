namespace API.Domain.Entity.Models.Concluidos;

public class Aired
{
    //DateTime
    public DateTime DateStar { get; set; } //Data de Inicio
    public DateTime DateEnd { get; set; } //Data de Final

    //Constructor
    public Aired(DateTime dateStar, DateTime dateEnd)
    {
        DateStar = dateStar;
        DateEnd = dateEnd;
    }
}