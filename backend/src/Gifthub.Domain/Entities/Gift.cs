namespace Gifthub.Domain.Entities
{
    public class Gift
    {
        public Guid GiftListId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
