namespace Gifthub.Domain.Users.Interfaces.Repositories
{
    public interface IUsersRepository
    {
        Task<Guid> CreateAsync(User user);
        Task UpdateAsync(Guid id, string newName);
        Task<User?> GetByIdAsync(Guid id);
        Task<User?> GetByNameAsync(string name);
        Task<ICollection<User>> GetAllAsync();
    }
}
