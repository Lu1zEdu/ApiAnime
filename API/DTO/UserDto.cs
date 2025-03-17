using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using API.Domain.Entity;
using API.Domain.Enum;

namespace API.Domain.DTO;

[Table("Users")]
public class UserDto 
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid IdUser { get; set; } //Identificador de usuário 
    
    [Required(ErrorMessage =  "O primeiro nome é obrigatória.")]
    [MaxLength(50)]
    public String FirstName { get; set; } //Primeiro nome
    
    [Required(ErrorMessage =  "O sobrenome é obrigatória.")]
    [MaxLength(100)]
    public String LastName { get; set; } //Sobrenome
    
    [Required(ErrorMessage =  "O username é obrigatória.")]
    [MaxLength(50)]
    [MinLength(3)]
    public String Username { get; set; } //UserName
    
    [Required(ErrorMessage =  "O email é obrigatória.")]
    [EmailAddress]
    public String Email { get; set; } //Email
    
    [Required(ErrorMessage = "A senha é obrigatória.")]
    [StringLength(30, MinimumLength = 7)]
    public String Password { get; set; } //Senha
    
    [Required]
    [DataType(DataType.Date)]
    public DateTime BirthDate { get; set; } //Data de nascimento
    
    [Required(ErrorMessage = "A estação do anime é obrigatória.")]
    [EnumDataType(typeof(Rating), ErrorMessage = "Valor inválido para a estação.")] 
    [JsonConverter(typeof(JsonStringEnumConverter))] // Serializa como string no JSON
    public Rating Rating { get; set; } //Classificação de idade
                                       
}