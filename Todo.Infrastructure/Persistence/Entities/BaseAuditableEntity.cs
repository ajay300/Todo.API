namespace Todo.Infrastructure.Persistence.Entities
{
    public abstract class BaseAuditableEntity : BaseEntity
    {
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        public DateTime CreatedBy { get; set; }

        public DateTime? UpdatedBy {  get; set; }
    }
}

