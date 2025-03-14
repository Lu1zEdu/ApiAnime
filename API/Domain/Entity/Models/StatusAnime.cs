using API.Domain.Enum;

namespace API.Domain.Entity.Models;

public class StatusAnime
{
    public Guid IdStatusAnime { get; set; }
    public Status Status { get; set; }
    public Themes Theme { get; set; }
}