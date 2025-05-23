﻿namespace Gifthub.Domain.Gifts.Interfaces.Services;

public interface IGiftListsService
{
    Task<Guid> AddAsync(string name, string description);
    Task<Gift?> GetUserGiftListsAsync(Guid userId);
    Task<GiftList?> GetByIdAsync(Guid id);
    Task UpdateAsync(string newName, string newDescription);
    Task DeleteAsync(Guid id);
    Task<IReadOnlyList<Gift>> GetAllAsync();
}
