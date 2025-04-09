namespace Gifthub.Domain.Gifts.Interfaces.Repositories;

public interface IGiftListsRepository
{
    Task<Guid> CreateAsync(GiftList giftList);
    Task UpdateAsync(Guid id, string newName, string newDescription);
    Task DeleteAsync(Guid id);
    Task<GiftList?> GetByIdAsync(Guid id);
    Task<ICollection<GiftList>> GetAllAsync();
}
