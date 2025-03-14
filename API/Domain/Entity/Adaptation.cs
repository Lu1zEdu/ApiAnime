using API.Domain.Enum;

namespace API.Domain.Entity;

public class Adaptation
{
    public Guid IdAdaptation { get; set; }
    public string NameWork { get; set; }
    public TypeWork  TypeWork { get; set; }
    
}