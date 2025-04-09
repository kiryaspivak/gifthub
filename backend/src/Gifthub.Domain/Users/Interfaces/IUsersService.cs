using Gifthub.Domain.Users.Entities;

namespace Gifthub.Domain.Users.Interfaces;

public interface IUsersService
{
    Task<User?> GetUsersAsync();
    Task<User?> GetUserByIdAsync(Guid id);
    Task<User?> GetUserByNameAsync(string name);
    Task<User?> GetUserByEmailAsync(string email);
    Task<Guid> AddNewUserAsync(string name, string email, string password);
    Task<User?> UpdateUserAsync(User user, string newName);
} 
