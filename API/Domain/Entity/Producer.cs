using API.Domain.Enum;

namespace API.Domain.Entity;

public class Producer
{
    //Identicador
    public Guid IdProducer { get; set; }
    
    //String
    public String NameProducer { get; set; }
    
    //int
    public int Year { get; set; }
    
    //Date
    public DateTime BirthDateProducer { get; set; }
    
    //Enum
    public Studios Studios { get; set; }

    //Constructor
    public Producer(Guid idProducer, string nameProducer, int year, DateTime birthDateProducer, Studios studios)
    {
        IdProducer = idProducer;
        NameProducer = nameProducer;
        Year = year;
        BirthDateProducer = birthDateProducer;
        Studios = studios;
    }
}