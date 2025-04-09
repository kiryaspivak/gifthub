namespace Gifthub.Domain.Users.Interfaces.Services;

public interface IUsersService
{
    Task<User?> GetByIdAsync(Guid id);
    Task<User?> GetByNameAsync(string name);
    Task<User?> GetByEmailAsync(string email);
    Task<Guid> AddAsync(string name, string email, string password);
    Task<User?> UpdateAsync(User user, string newName);
    Task<IReadOnlyList<User>> GetAllUsersAsync();
} 
