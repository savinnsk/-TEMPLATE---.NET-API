using Domain.Entities;
using Infra.Repository;

namespace Services.Services;

public class UserService : BaseService<User>
{
    private readonly UserRepository _userRepository;

    public UserService(UserRepository repository)
        : base(repository)
    {
        _userRepository = repository;
    }

    
}