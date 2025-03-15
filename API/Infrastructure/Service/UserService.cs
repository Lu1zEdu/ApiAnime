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
        return true;
    }
}