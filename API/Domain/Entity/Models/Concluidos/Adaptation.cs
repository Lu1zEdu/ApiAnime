using API.Domain.Enum;

namespace API.Domain.Entity.Models;

public class Adaptation
{
    public Guid IdAdaptation { get; set; }
    public string NameWork { get; set; }
    public TypeWork  TypeWork { get; set; }

    public Adaptation(Guid idAdaptation, string nameWork, TypeWork typeWork)
    {
        IdAdaptation = idAdaptation;
        NameWork = nameWork;
        TypeWork = typeWork;
    }
}