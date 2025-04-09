namespace Gifthub.Domain.Gifts.Interfaces.Repositories;

public interface IGiftsRepository
{
    Task<Guid> CreateAsync(Gift gift);
    Task UpdateAsync(Guid id, string newName, string newDescription);
    Task DeleteAsync(Gift gift);
    Task<Gift?> GetByIdAsync(Guid id);
    Task<ICollection<Gift>> GetAllAsync();
}
