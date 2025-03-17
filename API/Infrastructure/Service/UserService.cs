using API.Domain.Entity;
using API.Infrastructure.Repository;

namespace API.Infrastructure.Service;

public class UserService
{
    private readonly UserRepository _userRepository;

    public UserService(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public bool CreateUser(User user)
    {
        if (user == null)
        {
            throw new ArgumentNullException(nameof(user), "User cannot be null.");
        }

        // Validação do IdUser (verifica se o Id não é vazio)
        if (user.IdUser == Guid.Empty)
        {
            user.IdUser = Guid.NewGuid(); // Se o Id não for fornecido, gera um novo
        }

        // Validação do e-mail (verifica se já existe um usuário com esse e-mail)
        var existingUser = _userRepository.GetUserByIdAsync(user.IdUser);
        if (existingUser != null)
        {
            throw new ArgumentException("A user with this email already exists.");
        }

        // Validação da senha (verifica se a senha tem pelo menos 6 caracteres)
        if (string.IsNullOrEmpty(user.Password))
        {
            throw new ArgumentException("Password is required.");
        }

        if (user.Password.Length < 6)
        {
            throw new ArgumentException("Password is too short, it must be at least 6 characters.");
        }

        // Validação da data de nascimento (não pode ser maior que a data atual)
        if (user.BirthDate >= DateTime.Now)
        {
            throw new ArgumentException("BirthDate must be in the past.");
        }

        // Validação do nome e sobrenome
        if (string.IsNullOrEmpty(user.FirstName) || string.IsNullOrEmpty(user.LastName))
        {
            throw new ArgumentException("First name and last name are required.");
        }

        // Se passou em todas as validações, cria o usuário no repositório
        _userRepository.CreateUserAsync(user);
        return true;
    }
    
    // Desativar usuário
    public bool DeactivateUser(Guid userId)
    {
        var user = _userRepository.GetUserByIdAsync(userId).Result;
        if (user == null)
            return false;

        return _userRepository.DeactivateUserAsync(userId).Result;
    }
}