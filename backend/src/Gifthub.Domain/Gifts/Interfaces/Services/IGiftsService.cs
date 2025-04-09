namespace Gifthub.Domain.Gifts.Interfaces.Services;

public interface IGiftsService
{
    Task<Gift?> GetByIdAsync(Guid id);
    Task<Guid> AddAsync(Guid giftListId, string name, string description);
    Task UpdateAsync(Guid id, string newName, string newDescription);
    Task DeleteAsync(Guid id);
    Task<IReadOnlyList<Gift>> GetAllAsync();
}
