﻿namespace Gifthub.Domain.Gifts;

public class Gift
{
    public Guid? ReservedBy { get; set; } = null;
    public Guid GiftListId { get; set; }
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
